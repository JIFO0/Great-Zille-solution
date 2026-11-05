# Sordland/Turn11/SnO_WorldWar

- **ID konwersacji:** `256`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/256_SnO_WorldWar.md`
- **Liczba węzłów dialogowych:** 174
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[24]** Dwight Walker
- **[47]** Leon Malenyev
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn10_SnO_FrancPulledToHolsord`
- `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh`
- `BaseGame.Turn10_SnO_Phase1_Pincer`
- `BaseGame.Turn10_SnO_Phase2_TakeDome`
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`
- `GameCondition.Turn11_SnO_WorldWar`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"“Surely that should be no threat to our victory, right?”"** | `[70]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..."<br>`[71]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Iosef Lancea**: "“Have faith in the Sordish Armed..." |
| `[13]` | **"Read the newspaper."** | `[9]` **Narrator**: "The daily stack of newspapers wa..."<br>`[24]` **Narrator**: "'P.S.: Mom is fine and Deana mig..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false` | *Brak zmian stanu* | `[10]` **Narrator**: "The first thing I saw was the he..." |
| `[14]` | **"Open the letter."** | `[9]` **Narrator**: "The daily stack of newspapers wa..."<br>`[24]` **Narrator**: "'P.S.: Mom is fine and Deana mig..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false` | *Brak zmian stanu* | `[25]` **Narrator**: "I recognized Franc's handwriting..." |
| `[72]` | **"“We have come this far. We will not fall back now.”"** | `[70]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..."<br>`[71]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Iosef Lancea**: "“I agree. We need Rumburg to cap..." |
| `[73]` | **"“Keep on pressing. I don't care who we are fighting against. Rumburg is finished.”"** | `[70]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..."<br>`[71]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Iosef Lancea**: "“As you command.”" |
| `[77]` | **"“Maybe we should end this war before things escalate.”"** | `[70]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..."<br>`[71]` **Iosef Lancea**: "“We may be at the Thornbourgh's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Iosef Lancea**: "“I think we are in far too deep ..." |
| `[88]` | **"“Sordland will end all wars when we win this one.”"** | `[87]` **Iosef Lancea**: "“A 'world war', one might call i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Iosef Lancea**: "“Say what you will, sir... this ..." |
| `[89]` | **"“I don't even want to entertain the idea. I hope it does not come to that.”"** | `[87]` **Iosef Lancea**: "“A 'world war', one might call i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Iosef Lancea**: "“Say what you will, sir... this ..." |
| `[90]` | **"“You might be right. If the ATO and CSP go up against each other, they won't stop ..."** | `[87]` **Iosef Lancea**: "“A 'world war', one might call i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Iosef Lancea**: "“Say what you will, sir... this ..." |
| `[93]` | **"“I am not worried. We are winning. Let's be a bit more cheerful.”"** | `[92]` **Iosef Lancea**: "“My colleagues here agree that t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Iosef Lancea**: "“Sir. Never before have such lar..." |
| `[94]` | **"“If what you said happens, do we have what it takes to come out in the winning side?”"** | `[92]` **Iosef Lancea**: "“My colleagues here agree that t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Iosef Lancea**: "“Sir. Never before have such lar..." |
| `[97]` | **"“You are making me anxious, Iosef.”"** | `[92]` **Iosef Lancea**: "“My colleagues here agree that t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Iosef Lancea**: "“Sir. Never before have such lar..." |
| `[107]` | **"Pick up the phone."** | `[106]` **Narrator**: "They left the room." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "I heard Dwight Walker's voice fr..."<br>`[112]` **Narrator**: "I heard Leon Malenyev's voice fr..." |
| `[118]` | **"“Hello?”"** | `[117]` **Dwight Walker**: "“...can't...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Dwight Walker**: "“...don't... coming...”" |
| `[120]` | **"“Hello. Can you hear me?”"** | `[119]` **Dwight Walker**: "“...don't... coming...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Dwight Walker**: "“...I-”" |
| `[130]` | **"“Hello?”"** | `[129]` **Leon Malenyev**: "“...can't...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Leon Malenyev**: "“...don't... coming...”" |
| `[134]` | **"“Hello. Can you hear me?”"** | `[133]` **Leon Malenyev**: "“...don't... coming...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Leon Malenyev**: "“...I-”" |
| `[161]` | **"“Is everything all right?”"** | `[117]` **Dwight Walker**: "“...can't...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Dwight Walker**: "“...don't... coming...”" |
| `[162]` | **""Mr. Walker! What's going on?""** | `[119]` **Dwight Walker**: "“...don't... coming...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Dwight Walker**: "“...I-”" |
| `[163]` | **"“Comrade Malenyev! Is everything all right?""** | `[133]` **Leon Malenyev**: "“...don't... coming...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Leon Malenyev**: "“...I-”" |
| `[164]` | **"“I didn't quite catch that.""** | `[129]` **Leon Malenyev**: "“...can't...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Leon Malenyev**: "“...don't... coming...”" |

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
  - -> `[3]` (*Narrator: "The mood was merry in the Maroon Palace."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The mood was merry in the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Since the beginning of the war, we had received nothing b..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Surely that should be no threat to our victory, right?”"]** — Mówca: **Player**
> "“Surely that should be no threat to our victory, right?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Iosef Lancea: "“Have faith in the Sordish Armed Forces and our allies, M..."*)

### Węzeł `[5]`
Mówca: **Iosef Lancea**
> "“Good morning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“We have a couple of guests here today.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Since the beginning of the war, we had received nothing but good news. Our army's initial successes were followed by further battlefield victories deeper in Rumburg territory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I strolled casually into my office and closed the door."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I strolled casually into my office and closed the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The daily stack of newspapers was on my desk along with a..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Iosef entered my office for our daily war briefing. He had an unusually serious look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Iosef Lancea: "“Good morning, Mr. President.”"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The daily stack of newspapers was on my desk along with a letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Information Hub"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The first thing I saw was the headline: "Conqueror Rayne", written in giant letters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I continued reading."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Information Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Newspaper == false"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == false"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIso..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his radical plan, in his own words, 'Maradunen Schlium', caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Thornbourgh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: ""Experts anticipate that the siege of Thornbourgh will be..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Read the newspaper."]** — Mówca: **Player_Italic**
> "I picked up the newspaper on top of the stack."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[24]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The first thing I saw was the headline: "Conqueror Rayne"..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Open the letter."]** — Mówca: **Player_Italic**
> "I opened the letter."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[24]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "I recognized Franc's handwriting immediately."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Newspaper == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Newspaper == false"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Newspaper == false)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Newspaper == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Italic: "Read the newspaper."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Newspaper == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == false"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Letter == false)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Italic: "Open the letter."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Letter == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Information Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Information Hub"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Jump to: [Information Hub]"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I continued reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: ""...After a string of triumphant victories, Rumburg's def..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "'P.S.: Mom is fine and Deana might have a boyfriend.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter = true"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "I recognized Franc's handwriting immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: ""Dear Father. I hope this letter finds you well.""*)

### Węzeł `[26]`
Mówca: **Narrator**
> ""Dear Father. I hope this letter finds you well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: ""Is that how you old folks do it? I know I could've just ..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> ""I just have one request: When Rumburg surrenders and you meet Queen Beatrice, give her a big fat middle finger from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "'Best Regards, Franc Rayne.'"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Home_Public == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: ""Everyone's talking about the war here at school. I know ..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Newspaper = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Jump to: [Information Hub]"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Smiling, I shoved the papers to the side of my desk. I heard a knock on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Iosef entered my office for our daily war briefing. He ha..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> ""...After a string of triumphant victories, Rumburg's defeat seems to be imminent. We eagerly await the day when we can welcome our soldiers back home. Celebrations of Rumburg's defeat have already begun...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Pincer == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIso..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameI..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Smiling, I shoved the papers to the side of my desk. I he..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Pincer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Pincer == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_Pincer == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Pincer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_Pincer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his radical pincer attack plan caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Thornbourgh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: ""Experts anticipate that the siege of Thornbourgh will be..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "'Best Regards, Franc Rayne.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "I put down the paper to take a sip from my coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Newspaper = true"*)

### Węzeł `[49]`
Mówca: **Narrator**
> ""Experts anticipate that the siege of Thornbourgh will be the last push that will drive Rumburg into a full and unconditional surrender...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "I put down the paper to take a sip from my coffee."*)

### Węzeł `[50]`
Mówca: **Narrator**
> ""Is that how you old folks do it? I know I could've just called, but writing feels more appropriate for the occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "'I wanted to congratulate you on our approaching victory ..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "'I wanted to congratulate you on our approaching victory over Rumburg. We showed them who they were messing with.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "He gestured towards two generals from ATO. Our alliance had been critical to our successes in the field. We saluted each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Iosef Lancea: "“As you know, we are nearing a total victory.”"*)

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“We have a couple of guests here today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He gestured towards two generals from ATO. Our alliance h..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He gestured towards two generals from CSP. Our alliance h..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He gestured towards two generals from CSP. Our alliance had been critical to our successes in the field. We saluted each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Iosef Lancea: "“As you know, we are nearing a total victory.”"*)

### Węzeł `[61]`
Mówca: **Iosef Lancea**
> "“As you know, we are nearing a total victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Iosef Lancea: "“But, there is a problem. A large one.”"*)

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“But, there is a problem. A large one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Iosef Lancea: "“We received reports yesterday that CSP ramped up their s..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Iosef Lancea: "“We received reports yesterday that ATO ramped up their s..."*)

### Węzeł `[66]`
Mówca: **Iosef Lancea**
> "“We received reports yesterday that CSP ramped up their support of Rumburg by delivering a thousand tonnes of military equipment to their northern port.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“They have officially declared that they will be joining ..."*)

### Węzeł `[67]`
Mówca: **Iosef Lancea**
> "“We received reports yesterday that ATO ramped up their support of Rumburg by delivering a thousand tonnes of military equipment by cargo plane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Iosef Lancea: "“They have officially declared that they will be joining ..."*)

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“They have officially declared that they will be joining the war. It is possible that Sordland will be open to an attack from the sea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Iosef Lancea: "“We may be at the Thornbourgh's doorstep, but the CSP's i..."*)

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“They have officially declared that they will be joining the war. It is possible that Sordland will be open to an attack from the south and west.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Iosef Lancea: "“We may be at the Thornbourgh's doorstep, but the ATO's i..."*)

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“We may be at the Thornbourgh's doorstep, but the CSP's involvement could lose us this war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“Maybe we should end this war before things escalate.”"*)
  - -> `[72]` (*Player: "“We have come this far. We will not fall back now.”"*)
  - -> `[4]` (*Player: "“Surely that should be no threat to our victory, right?”"*)
  - -> `[73]` (*Player: "“Keep on pressing. I don't care who we are fighting again..."*)

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“We may be at the Thornbourgh's doorstep, but the ATO's involvement could lose us this war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“Maybe we should end this war before things escalate.”"*)
  - -> `[72]` (*Player: "“We have come this far. We will not fall back now.”"*)
  - -> `[4]` (*Player: "“Surely that should be no threat to our victory, right?”"*)
  - -> `[73]` (*Player: "“Keep on pressing. I don't care who we are fighting again..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“We have come this far. We will not fall back now.”"]** — Mówca: **Player**
> "“We have come this far. We will not fall back now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Iosef Lancea: "“I agree. We need Rumburg to capitulate as quickly as pos..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Keep on pressing. I don't care who we are fighting against. Rumburg is finished.”"]** — Mówca: **Player**
> "“Keep on pressing. I don't care who we are fighting against. Rumburg is finished.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Iosef Lancea: "“As you command.”"*)

### Węzeł `[74]`
Mówca: **Iosef Lancea**
> "“I agree. We need Rumburg to capitulate as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Iosef Lancea: "“But I'm afraid that we may be past the point where we ca..."*)

### Węzeł `[75]`
Mówca: **Iosef Lancea**
> "“Have faith in the Sordish Armed Forces and our allies, Mr. President. We will bring you victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Iosef Lancea: "“But I'm afraid that we may be past the point where we ca..."*)

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Iosef Lancea: "“But I'm afraid that we may be past the point where we ca..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Maybe we should end this war before things escalate.”"]** — Mówca: **Player**
> "“Maybe we should end this war before things escalate.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Iosef Lancea: "“I think we are in far too deep for that, Mr. President.”"*)

### Węzeł `[78]`
Mówca: **Iosef Lancea**
> "“I think we are in far too deep for that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Iosef Lancea: "“And I'm afraid that we may be past the point where we ca..."*)

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“But I'm afraid that we may be past the point where we can finish the war quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“The CSP's involvement is not a good sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Iosef Lancea: "“If this escalates further and the clashes between the tw..."*)

### Węzeł `[81]`
Mówca: **Iosef Lancea**
> "“If this escalates further and the clashes between the two factions continue, we may end up in a war the likes of which this world has never seen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Iosef Lancea: "“A 'world war', one might call it. The war to end all wars.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Iosef Lancea: "“The CSP's involvement is not a good sign.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Iosef Lancea: "“The ATO's involvement is not a good sign.""*)

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“If this escalates further and the clashes between the two factions continue, we may end up in a war the likes of which this world has never seen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Iosef Lancea: "“A 'world war', one might call it. The war to end all wars.""*)

### Węzeł `[86]`
Mówca: **Iosef Lancea**
> "“The ATO's involvement is not a good sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Iosef Lancea: "“If this escalates further and the clashes between the tw..."*)

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“A 'world war', one might call it. The war to end all wars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“I don't even want to entertain the idea. I hope it does ..."*)
  - -> `[88]` (*Player: "“Sordland will end all wars when we win this one.”"*)
  - -> `[90]` (*Player: "“You might be right. If the ATO and CSP go up against eac..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Sordland will end all wars when we win this one.”"]** — Mówca: **Player**
> "“Sordland will end all wars when we win this one.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Iosef Lancea: "“Say what you will, sir... this is an increasing possibil..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“I don't even want to entertain the idea. I hope it does not come to that.”"]** — Mówca: **Player**
> "“I don't even want to entertain the idea. I hope it does not come to that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Iosef Lancea: "“Say what you will, sir... this is an increasing possibil..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“You might be right. If the ATO and CSP go up against each other, they won't stop until one side wins.""]** — Mówca: **Player**
> "“You might be right. If the ATO and CSP go up against each other, they won't stop until one side wins.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Iosef Lancea: "“Say what you will, sir... this is an increasing possibil..."*)

### Węzeł `[91]`
Mówca: **Iosef Lancea**
> "“Say what you will, sir... this is an increasing possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Iosef Lancea: "“My colleagues here agree that this conflict has the pote..."*)

### Węzeł `[92]`
Mówca: **Iosef Lancea**
> "“My colleagues here agree that this conflict has the potential to reach far beyond Sordland and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "“If what you said happens, do we have what it takes to co..."*)
  - -> `[93]` (*Player: "“I am not worried. We are winning. Let's be a bit more ch..."*)
  - -> `[97]` (*Player: "“You are making me anxious, Iosef.”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I am not worried. We are winning. Let's be a bit more cheerful.”"]** — Mówca: **Player**
> "“I am not worried. We are winning a war. Let's be a bit more cheerful.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Iosef Lancea: "“Sir. Never before have such large armies clashed against..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“If what you said happens, do we have what it takes to come out in the winning side?”"]** — Mówca: **Player**
> "“If what you said happens, do we have what it takes to come out in the winning side?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Iosef Lancea: "“Sir. Never before have such large armies clashed against..."*)

### Węzeł `[95]`
Mówca: **Iosef Lancea**
> "“Sir. Never before have such large armies clashed against each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Iosef Lancea: "“Frankly, I don't know what would be the outcome. This is..."*)

### Węzeł `[96]`
Mówca: **Iosef Lancea**
> "“Frankly, I don't know what would be the outcome. This is unknown territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "The phone started ringing."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“You are making me anxious, Iosef.”"]** — Mówca: **Player**
> "“You are making me anxious, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Iosef Lancea: "“Sir. Never before have such large armies clashed against..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "The phone started ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "It was the blue phone, a direct connection to Dwight Walker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "This line was used only for extremely urgent calls and em..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "It was the blue phone, a direct connection to Dwight Walker."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "It was the red phone, a a direct connection to Leon Malen..."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "It was the red phone, a a direct connection to Leon Malenyev."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "This line was used only for extremely urgent calls and em..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "This line was used only for extremely urgent calls and emergencies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“Please excuse us, Mr. President. We will continue this s..."*)

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“Please excuse us, Mr. President. We will continue this soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "They left the room."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Italic: "Pick up the phone."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Italic**
> "I picked up the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I heard Dwight Walker's voice from the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Dwight Walker: "“Mr. President. Listen to me. There is no time to waste.”"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I heard Dwight Walker's voice from the other end."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "I heard Leon Malenyev's voice from the other end."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "I heard Leon Malenyev's voice from the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Leon Malenyev: "“Mr. President. Listen to me. There is no time to waste.”"*)

### Węzeł `[113]`
Mówca: **Dwight Walker**
> "“Mr. President. Listen to me. There is no time to waste.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Dwight Walker: "“Five minutes ago, our radar detected a missile launch to..."*)

### Węzeł `[114]`
Mówca: **Dwight Walker**
> "“Five minutes ago, our radar detected a missile launch towards Holsord from the unoccupied territories near Thornbourgh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Dwight Walker: "“Please get... to... safety immediately.”"*)

### Węzeł `[115]`
Mówca: **Dwight Walker**
> "“Please get... to... safety immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I heard the crackling of static. President Walker's words..."*)

### Węzeł `[116]`
Mówca: **Dwight Walker**
> "“The... intel... confirmed....”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Dwight Walker: "“...can't...”"*)

### Węzeł `[117]`
Mówca: **Dwight Walker**
> "“...can't...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player: "“Is everything all right?”"*)
  - -> `[118]` (*Player: "“Hello?”"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Hello?”"]** — Mówca: **Player**
> "“Hello?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Dwight Walker: "“...don't... coming...”"*)

### Węzeł `[119]`
Mówca: **Dwight Walker**
> "“...don't... coming...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: ""Mr. Walker! What's going on?""*)
  - -> `[120]` (*Player: "“Hello. Can you hear me?”"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Hello. Can you hear me?”"]** — Mówca: **Player**
> "“Hello. Can you hear me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Dwight Walker: "“...I-”"*)

### Węzeł `[121]`
Mówca: **Dwight Walker**
> "“...I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("LineDropDead");"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Then the sirens began."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "Then the sirens began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_WorldWar = true"*)

### Węzeł `[124]`
Mówca: **Leon Malenyev**
> "“Mr. President. Listen to me. There is no time to waste.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Leon Malenyev: "“Five minutes ago, our radar detected a missile launch to..."*)

### Węzeł `[125]`
Mówca: **Leon Malenyev**
> "“Five minutes ago, our radar detected a missile launch towards Holsord from the unoccupied territories near Thornbourgh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Leon Malenyev: "“Please get... to... safety immediately.”"*)

### Węzeł `[126]`
Mówca: **Leon Malenyev**
> "“Please get... to... safety immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I heard the crackling of static. Malenyev's words were be..."*)

### Węzeł `[127]`
Mówca: **Leon Malenyev**
> "“The... intel... confirmed....”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Leon Malenyev: "“...can't...”"*)

### Węzeł `[128]`
Mówca: **Leon Malenyev**
> "“...I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("LineDropDead");"*)

### Węzeł `[129]`
Mówca: **Leon Malenyev**
> "“...can't...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: "“I didn't quite catch that.""*)
  - -> `[130]` (*Player: "“Hello?”"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Hello?”"]** — Mówca: **Player**
> "“Hello?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Leon Malenyev: "“...don't... coming...”"*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Then the sirens began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_WorldWar = true"*)

### Węzeł `[132]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Then the sirens began."*)

### Węzeł `[133]`
Mówca: **Leon Malenyev**
> "“...don't... coming...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "“Hello. Can you hear me?”"*)
  - -> `[163]` (*Player: "“Comrade Malenyev! Is everything all right?""*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Hello. Can you hear me?”"]** — Mówca: **Player**
> "“Hello. Can you hear me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Leon Malenyev: "“...I-”"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_WorldWar = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn11_SnO_WorldWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: ""Everyone at Camp Strongarm is talking about the war, obv..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: ""Still... I wonder if you and the other bigwigs back in H..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> ""Everyone at Camp Strongarm is talking about the war, obviously. And they're talking about me. Not in a good way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: ""I can't help but think about all my friends and squadmat..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> ""But there's nothing I can do to change any of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: ""I just have one request: When Rumburg surrenders and you..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: ""Everyone's talking about the war here in Arcasia. I have..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: ""Everyone's talking about the war here in Arcasia. I have..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> ""I can't help but think about all my friends and squadmates on the front lines. I know I'm lucky to be deployed here in Holsord, but part of me wishes I could be there fighting with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: ""But there's nothing I can do to change any of that now.""*)

### Węzeł `[145]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[147]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> ""Everyone's talking about the war here at school. I know I complain about how hard it is being your son sometimes, but I have to say it feels pretty nice right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: ""Everyone's talking about the war here in United Contana...."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: ""Everyone's talking about the war here in United Contana...."*)

### Węzeł `[153]`
Mówca: **Narrator**
> ""That said... I can't help but think about all the guys who're still dying over there. That could be me. Considering how badly I flunked my exams, it probably should be me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: ""But there's nothing I can do to change any of that now.""*)

### Węzeł `[154]`
Mówca: **Narrator**
> ""Still... I wonder if you and the other bigwigs back in Holsord know the real cost of this war. It's not just that I could've died. It's that some of the things I've done make me wish I had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: ""It's hard for me and the other guys to sleep at night. I..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> ""It's hard for me and the other guys to sleep at night. I can only hope the memories will go away with time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: ""But there's nothing I can do to change any of that now.""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "'P.S.: Mom is fine and Deana might have a boyfriend.'"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter = true"*)

### Węzeł `[159]`
Mówca: **Iosef Lancea**
> "“And I'm afraid that we may be past the point where we can finish the war quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[160]`
Mówca: **Narrator**
> "I heard the crackling of static. President Walker's words were becoming harder to distinguish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Dwight Walker: "“The... intel... confirmed....”"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Is everything all right?”"]** — Mówca: **Player**
> "“I didn't quite catch that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Dwight Walker: "“...don't... coming...”"*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Mr. Walker! What's going on?""]** — Mówca: **Player**
> ""Mr. Walker! What's going on?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Dwight Walker: "“...I-”"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Comrade Malenyev! Is everything all right?""]** — Mówca: **Player**
> "“Comrade Malenyev! Is everything all right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Leon Malenyev: "“...I-”"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“I didn't quite catch that.""]** — Mówca: **Player**
> "“I didn't quite catch that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Leon Malenyev: "“...don't... coming...”"*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I heard the crackling of static. Malenyev's words were becoming harder to distinguish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Leon Malenyev: "“The... intel... confirmed....”"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("LineDropDead");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("LineDropDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "The line dropped dead."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("LineDropDead");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("LineDropDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "The line dropped dead."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[169]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy. Our troops were victorious in their assault and tipped the scales in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: ""Experts anticipate that the siege of Thornbourgh will be..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy at Dome. Following that operation, our troops were victorious in their assaults towards their capital and tipped the scales in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: ""Experts anticipate that the siege of Thornbourgh will be..."*)
