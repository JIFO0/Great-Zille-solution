# Rizia/Turn 10/HOD Shutdown Notes/HOD Shutdown Notes Conversation

- **ID konwersacji:** `544`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/544_HOD_Shutdown_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 82
- **Liczba wyborów gracza:** 52

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_FunnyKing`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""No surprise that those claiming to serve the public ended up defying the Crown.""** | `[3]` **Narrator**: "I began to think aloud as I refl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Player_Romus**: ""They concealed their true loyal..."<br>`[7]` **Player_Romus**: ""I refused to let them steer thi..."<br>*(oraz 2 innych odgałęzień)* |
| `[5]` | **""All they did was twist our laws and traditions to suit their own purposes.""** | `[4]` **Player_Romus**: ""No surprise that those claiming..."<br>`[15]` **Player_Romus**: ""Once full of voices, this hall ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player_Romus**: ""You give them an inch of trust,..."<br>`[20]` **Player_Romus**: ""Justice demanded action, not co..."<br>*(oraz 2 innych odgałęzień)* |
| `[6]` | **""I never wanted it to come to this, but I did what needed to be done.""** | `[4]` **Player_Romus**: ""No surprise that those claiming..."<br>`[15]` **Player_Romus**: ""Once full of voices, this hall ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player_Romus**: ""You give them an inch of trust,..."<br>`[20]` **Player_Romus**: ""Justice demanded action, not co..."<br>*(oraz 2 innych odgałęzień)* |
| `[7]` | **""I refused to let them steer this kingdom off course.""** | `[4]` **Player_Romus**: ""No surprise that those claiming..."<br>`[15]` **Player_Romus**: ""Once full of voices, this hall ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player_Romus**: ""You give them an inch of trust,..."<br>`[20]` **Player_Romus**: ""Justice demanded action, not co..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""I always strived to protect and uphold the integrity of these lands.""** | `[5]` **Player_Romus**: ""All they did was twist our laws..."<br>`[6]` **Player_Romus**: ""I never wanted it to come to th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player_Romus**: ""It's why I was destined to beco..."<br>`[24]` **Player_Romus**: ""I had no choice but to cut them..."<br>*(oraz 1 innych odgałęzień)* |
| `[9]` | **""Even when others questioned me, I remained resolute.""** | `[5]` **Player_Romus**: ""All they did was twist our laws..."<br>`[6]` **Player_Romus**: ""I never wanted it to come to th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player_Romus**: ""It's why I was destined to beco..."<br>`[24]` **Player_Romus**: ""I had no choice but to cut them..."<br>*(oraz 1 innych odgałęzień)* |
| `[10]` | **"“Democracy... what a joke.”"** | `[27]` **Narrator**: "In it resided Rizia's constituti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Player_Romus**: ""Mob rule is more like it!""<br>`[13]` **Player_Romus**: ""Quixotic idealism fraught with ..."<br>*(oraz 2 innych odgałęzień)* |
| `[11]` | **""Mob rule is more like it!""** | `[10]` **Player_Romus**: "“Democracy... what a joke.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[12]` | **""Chaos-driven, pandering to the masses.""** | `[10]` **Player_Romus**: "“Democracy... what a joke.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[13]` | **""Quixotic idealism fraught with insurmountable problems.""** | `[10]` **Player_Romus**: "“Democracy... what a joke.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[14]` | **""Like giving a child a hammer -- everything’s a nail.""** | `[10]` **Player_Romus**: "“Democracy... what a joke.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[15]` | **""Once full of voices, this hall now reflects the Crown’s true strength.""** | `[3]` **Narrator**: "I began to think aloud as I refl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Player_Romus**: ""They concealed their true loyal..."<br>`[7]` **Player_Romus**: ""I refused to let them steer thi..."<br>*(oraz 2 innych odgałęzień)* |
| `[16]` | **""The old order thought they could cling to power, but now, it’s mine to reshape.""** | `[3]` **Narrator**: "I began to think aloud as I refl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Player_Romus**: ""They concealed their true loyal..."<br>`[7]` **Player_Romus**: ""I refused to let them steer thi..."<br>*(oraz 2 innych odgałęzień)* |
| `[17]` | **""These so-called delegates thought they held power but never grasped true leadersh..."** | `[3]` **Narrator**: "I began to think aloud as I refl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Player_Romus**: ""They concealed their true loyal..."<br>`[7]` **Player_Romus**: ""I refused to let them steer thi..."<br>*(oraz 2 innych odgałęzień)* |
| `[20]` | **""Justice demanded action, not complacency.""** | `[5]` **Player_Romus**: ""All they did was twist our laws..."<br>`[6]` **Player_Romus**: ""I never wanted it to come to th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player_Romus**: ""It's why I was destined to beco..."<br>`[24]` **Player_Romus**: ""I had no choice but to cut them..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **"Pick up banner."** | `[19]` **Narrator**: "My eyes fell on an old banner dr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "More like, "The Strength of the ..." |
| `[23]` | **"Ignore banner."** | `[19]` **Narrator**: "My eyes fell on an old banner dr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "And now..." |
| `[24]` | **""I had no choice but to cut them down before they could strike. Rizia's survival w..."** | `[8]` **Player_Romus**: ""I always strived to protect and..."<br>`[9]` **Player_Romus**: ""Even when others questioned me,..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "I reached the center of the cham..." |
| `[25]` | **""You give them an inch of trust, and they'll take a mile of betrayal.""** | `[5]` **Player_Romus**: ""All they did was twist our laws..."<br>`[6]` **Player_Romus**: ""I never wanted it to come to th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player_Romus**: ""It's why I was destined to beco..."<br>`[24]` **Player_Romus**: ""I had no choice but to cut them..."<br>*(oraz 1 innych odgałęzień)* |
| `[26]` | **""They concealed their true loyalty while sharpening their knives.""** | `[4]` **Player_Romus**: ""No surprise that those claiming..."<br>`[15]` **Player_Romus**: ""Once full of voices, this hall ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player_Romus**: ""You give them an inch of trust,..."<br>`[20]` **Player_Romus**: ""Justice demanded action, not co..."<br>*(oraz 2 innych odgałęzień)* |
| `[28]` | **""Still, I can't help but wonder if there could have been another way.""** | `[8]` **Player_Romus**: ""I always strived to protect and..."<br>`[9]` **Player_Romus**: ""Even when others questioned me,..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "I reached the center of the cham..." |
| `[29]` | **""It's why I was destined to become king. It was my duty, my purpose to bring these..."** | `[8]` **Player_Romus**: ""I always strived to protect and..."<br>`[9]` **Player_Romus**: ""Even when others questioned me,..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "I reached the center of the cham..." |
| `[31]` | **"“To think that this unassuming document could have incited such turmoil and challe..."** | `[27]` **Narrator**: "In it resided Rizia's constituti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[32]` | **""A good idea in theory but inevitably flawed.""** | `[27]` **Narrator**: "In it resided Rizia's constituti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[36]` | **""They certainly did love to hear themselves talk. Now, it’s blissfully quiet.""** | `[3]` **Narrator**: "I began to think aloud as I refl..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[26]` **Player_Romus**: ""They concealed their true loyal..."<br>`[7]` **Player_Romus**: ""I refused to let them steer thi..."<br>*(oraz 2 innych odgałęzień)* |
| `[40]` | **""They served the elites, not the common man.. The real revolution was doomed from ..."** | `[3]` **Narrator**: "I began to think aloud as I refl..." | `Variable["RiziaDLC.Trait_CommieKing"] == true` | *Brak zmian stanu* | `[26]` **Player_Romus**: ""They concealed their true loyal..."<br>`[7]` **Player_Romus**: ""I refused to let them steer thi..."<br>*(oraz 2 innych odgałęzień)* |
| `[43]` | **"It was no surprise that those claiming to serve the public would end up defying th..."** | `[42]` **Narrator**: "I began to reflect upon the even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Player_Romus_Italic**: "They concealed their true loyalt..."<br>`[46]` **Player_Romus_Italic**: "I refused to let them steer this..."<br>*(oraz 2 innych odgałęzień)* |
| `[44]` | **"They twisted our laws and traditions to suit their own purposes."** | `[43]` **Player_Romus_Italic**: "It was no surprise that those cl..."<br>`[54]` **Player_Romus_Italic**: "Once full of voices, this hall n..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player_Romus_Italic**: "I gave them an inch of trust, an..."<br>`[59]` **Player_Romus_Italic**: "Justice demanded action, not com..."<br>*(oraz 2 innych odgałęzień)* |
| `[45]` | **"I never wanted it to come to this, but it needed to be done."** | `[43]` **Player_Romus_Italic**: "It was no surprise that those cl..."<br>`[54]` **Player_Romus_Italic**: "Once full of voices, this hall n..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player_Romus_Italic**: "I gave them an inch of trust, an..."<br>`[59]` **Player_Romus_Italic**: "Justice demanded action, not com..."<br>*(oraz 2 innych odgałęzień)* |
| `[46]` | **"I refused to let them steer this kingdom off course."** | `[43]` **Player_Romus_Italic**: "It was no surprise that those cl..."<br>`[54]` **Player_Romus_Italic**: "Once full of voices, this hall n..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player_Romus_Italic**: "I gave them an inch of trust, an..."<br>`[59]` **Player_Romus_Italic**: "Justice demanded action, not com..."<br>*(oraz 2 innych odgałęzień)* |
| `[47]` | **"I always strove to protect and uphold the integrity of these lands."** | `[44]` **Player_Romus_Italic**: "They twisted our laws and tradit..."<br>`[45]` **Player_Romus_Italic**: "I never wanted it to come to thi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Player_Romus_Italic**: "It's why I was destined to becom..."<br>`[63]` **Player_Romus_Italic**: "I had no choice but to cut them ..."<br>*(oraz 1 innych odgałęzień)* |
| `[48]` | **"Even when others questioned me, I remained resolute."** | `[44]` **Player_Romus_Italic**: "They twisted our laws and tradit..."<br>`[45]` **Player_Romus_Italic**: "I never wanted it to come to thi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Player_Romus_Italic**: "It's why I was destined to becom..."<br>`[63]` **Player_Romus_Italic**: "I had no choice but to cut them ..."<br>*(oraz 1 innych odgałęzień)* |
| `[49]` | **"Democracy... what a joke."** | `[66]` **Narrator**: "In it resided Rizia's constituti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Player_Romus_Italic**: "Mob rule is more like it!"<br>`[52]` **Player_Romus_Italic**: "Quixotic idealism fraught with i..."<br>*(oraz 2 innych odgałęzień)* |
| `[50]` | **"Mob rule is more like it!"** | `[49]` **Player_Romus_Italic**: "Democracy... what a joke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[51]` | **"A system driven by chaos, catering to the fickle desires of the masses."** | `[49]` **Player_Romus_Italic**: "Democracy... what a joke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[52]` | **"Quixotic idealism fraught with insurmountable problems."** | `[49]` **Player_Romus_Italic**: "Democracy... what a joke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[53]` | **"Like giving a child a hammer -- everything’s a nail."** | `[49]` **Player_Romus_Italic**: "Democracy... what a joke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[54]` | **"Once full of voices, this hall now reflected the Crown’s true strength."** | `[42]` **Narrator**: "I began to reflect upon the even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Player_Romus_Italic**: "They concealed their true loyalt..."<br>`[46]` **Player_Romus_Italic**: "I refused to let them steer this..."<br>*(oraz 2 innych odgałęzień)* |
| `[55]` | **"The old order thought they could cling to power, but now, it was mine to reshape."** | `[42]` **Narrator**: "I began to reflect upon the even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Player_Romus_Italic**: "They concealed their true loyalt..."<br>`[46]` **Player_Romus_Italic**: "I refused to let them steer this..."<br>*(oraz 2 innych odgałęzień)* |
| `[56]` | **"These so-called delegates thought they held power but never grasped true leadership."** | `[42]` **Narrator**: "I began to reflect upon the even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Player_Romus_Italic**: "They concealed their true loyalt..."<br>`[46]` **Player_Romus_Italic**: "I refused to let them steer this..."<br>*(oraz 2 innych odgałęzień)* |
| `[59]` | **"Justice demanded action, not complacency."** | `[44]` **Player_Romus_Italic**: "They twisted our laws and tradit..."<br>`[45]` **Player_Romus_Italic**: "I never wanted it to come to thi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Player_Romus_Italic**: "It's why I was destined to becom..."<br>`[63]` **Player_Romus_Italic**: "I had no choice but to cut them ..."<br>*(oraz 1 innych odgałęzień)* |
| `[61]` | **"Pick up banner."** | `[58]` **Narrator**: "My eyes fell on an old banner dr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "More like, "The Strength of the ..." |
| `[62]` | **"Ignore banner."** | `[58]` **Narrator**: "My eyes fell on an old banner dr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "And now..." |
| `[63]` | **"I had no choice but to cut them down before they could strike. Rizia's survival wa..."** | `[47]` **Player_Romus_Italic**: "I always strove to protect and u..."<br>`[48]` **Player_Romus_Italic**: "Even when others questioned me, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "I reached the center of the cham..." |
| `[64]` | **"I gave them an inch of trust, and they took a mile of betrayal."** | `[44]` **Player_Romus_Italic**: "They twisted our laws and tradit..."<br>`[45]` **Player_Romus_Italic**: "I never wanted it to come to thi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Player_Romus_Italic**: "It's why I was destined to becom..."<br>`[63]` **Player_Romus_Italic**: "I had no choice but to cut them ..."<br>*(oraz 1 innych odgałęzień)* |
| `[65]` | **"They concealed their true loyalty while sharpening their knives."** | `[43]` **Player_Romus_Italic**: "It was no surprise that those cl..."<br>`[54]` **Player_Romus_Italic**: "Once full of voices, this hall n..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player_Romus_Italic**: "I gave them an inch of trust, an..."<br>`[59]` **Player_Romus_Italic**: "Justice demanded action, not com..."<br>*(oraz 2 innych odgałęzień)* |
| `[67]` | **"Still, I couldn't help but wonder if there could have been another way."** | `[47]` **Player_Romus_Italic**: "I always strove to protect and u..."<br>`[48]` **Player_Romus_Italic**: "Even when others questioned me, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "I reached the center of the cham..." |
| `[68]` | **"It's why I was destined to become king. It was my duty, my purpose to bring these ..."** | `[47]` **Player_Romus_Italic**: "I always strove to protect and u..."<br>`[48]` **Player_Romus_Italic**: "Even when others questioned me, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "I reached the center of the cham..." |
| `[70]` | **"To think that this unassuming document could have incited such turmoil and challen..."** | `[66]` **Narrator**: "In it resided Rizia's constituti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[71]` | **"A good idea in theory but inevitably flawed."** | `[66]` **Narrator**: "In it resided Rizia's constituti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "My eyes fell on an old banner dr..." |
| `[75]` | **"They certainly did love to hear themselves talk. Now, it’s blissfully quiet."** | `[42]` **Narrator**: "I began to reflect upon the even..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[65]` **Player_Romus_Italic**: "They concealed their true loyalt..."<br>`[46]` **Player_Romus_Italic**: "I refused to let them steer this..."<br>*(oraz 2 innych odgałęzień)* |
| `[79]` | **"The real revolution was doomed from the start in this place -- jackals who served ..."** | `[42]` **Narrator**: "I began to reflect upon the even..." | `Variable["RiziaDLC.Trait_CommieKing"] == true` | *Brak zmian stanu* | `[65]` **Player_Romus_Italic**: "They concealed their true loyalt..."<br>`[46]` **Player_Romus_Italic**: "I refused to let them steer this..."<br>*(oraz 2 innych odgałęzień)* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I began to think aloud as I reflected upon the circumstances surrounding the events that led me here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""Once full of voices, this hall now reflects the Crown’s ..."*)
  - -> `[17]` (*Player_Romus: ""These so-called delegates thought they held power but ne..."*)
  - -> `[4]` (*Player_Romus: ""No surprise that those claiming to serve the public ende..."*)
  - -> `[16]` (*Player_Romus: ""The old order thought they could cling to power, but now..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No surprise that those claiming to serve the public ended up defying the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""They concealed their true loyalty while sharpening their..."*)
  - -> `[7]` (*Player_Romus: ""I refused to let them steer this kingdom off course.""*)
  - -> `[5]` (*Player_Romus: ""All they did was twist our laws and traditions to suit t..."*)
  - -> `[6]` (*Player_Romus: ""I never wanted it to come to this, but I did what needed..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All they did was twist our laws and traditions to suit their own purposes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[15]` (Player_Romus), `[16]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""You give them an inch of trust, and they'll take a mile ..."*)
  - -> `[20]` (*Player_Romus: ""Justice demanded action, not complacency.""*)
  - -> `[9]` (*Player_Romus: ""Even when others questioned me, I remained resolute.""*)
  - -> `[8]` (*Player_Romus: ""I always strived to protect and uphold the integrity of ..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never wanted it to come to this, but I did what needed to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[15]` (Player_Romus), `[16]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""You give them an inch of trust, and they'll take a mile ..."*)
  - -> `[20]` (*Player_Romus: ""Justice demanded action, not complacency.""*)
  - -> `[9]` (*Player_Romus: ""Even when others questioned me, I remained resolute.""*)
  - -> `[8]` (*Player_Romus: ""I always strived to protect and uphold the integrity of ..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I refused to let them steer this kingdom off course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[15]` (Player_Romus), `[16]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""You give them an inch of trust, and they'll take a mile ..."*)
  - -> `[20]` (*Player_Romus: ""Justice demanded action, not complacency.""*)
  - -> `[9]` (*Player_Romus: ""Even when others questioned me, I remained resolute.""*)
  - -> `[8]` (*Player_Romus: ""I always strived to protect and uphold the integrity of ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I always strived to protect and uphold the integrity of these lands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Player_Romus), `[6]` (Player_Romus), `[7]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""It's why I was destined to become king. It was my duty, ..."*)
  - -> `[24]` (*Player_Romus: ""I had no choice but to cut them down before they could s..."*)
  - -> `[28]` (*Player_Romus: ""Still, I can't help but wonder if there could have been ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even when others questioned me, I remained resolute.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Player_Romus), `[6]` (Player_Romus), `[7]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""It's why I was destined to become king. It was my duty, ..."*)
  - -> `[24]` (*Player_Romus: ""I had no choice but to cut them down before they could s..."*)
  - -> `[28]` (*Player_Romus: ""Still, I can't help but wonder if there could have been ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Democracy... what a joke.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""Mob rule is more like it!""*)
  - -> `[13]` (*Player_Romus: ""Quixotic idealism fraught with insurmountable problems.""*)
  - -> `[14]` (*Player_Romus: ""Like giving a child a hammer -- everything’s a nail.""*)
  - -> `[12]` (*Player_Romus: ""Chaos-driven, pandering to the masses.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mob rule is more like it!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chaos-driven, pandering to the masses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quixotic idealism fraught with insurmountable problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like giving a child a hammer -- everything’s a nail.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once full of voices, this hall now reflects the Crown’s true strength.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""They concealed their true loyalty while sharpening their..."*)
  - -> `[7]` (*Player_Romus: ""I refused to let them steer this kingdom off course.""*)
  - -> `[5]` (*Player_Romus: ""All they did was twist our laws and traditions to suit t..."*)
  - -> `[6]` (*Player_Romus: ""I never wanted it to come to this, but I did what needed..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The old order thought they could cling to power, but now, it’s mine to reshape.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""They concealed their true loyalty while sharpening their..."*)
  - -> `[7]` (*Player_Romus: ""I refused to let them steer this kingdom off course.""*)
  - -> `[5]` (*Player_Romus: ""All they did was twist our laws and traditions to suit t..."*)
  - -> `[6]` (*Player_Romus: ""I never wanted it to come to this, but I did what needed..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These so-called delegates thought they held power but never grasped true leadership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""They concealed their true loyalty while sharpening their..."*)
  - -> `[7]` (*Player_Romus: ""I refused to let them steer this kingdom off course.""*)
  - -> `[5]` (*Player_Romus: ""All they did was twist our laws and traditions to suit t..."*)
  - -> `[6]` (*Player_Romus: ""I never wanted it to come to this, but I did what needed..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "A monarchy was the only way to ensure stability and order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "And now..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "My eyes fell on an old banner draped over a bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus_Italic: "Pick up banner."*)
  - -> `[23]` (*Player_Romus_Italic: "Ignore banner."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice demanded action, not complacency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Player_Romus), `[6]` (Player_Romus), `[7]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""It's why I was destined to become king. It was my duty, ..."*)
  - -> `[24]` (*Player_Romus: ""I had no choice but to cut them down before they could s..."*)
  - -> `[28]` (*Player_Romus: ""Still, I can't help but wonder if there could have been ..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "More like, "The Strength of the Crown," I thought to myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "A monarchy was the only way to ensure stability and order."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Pick up banner."]** — Mówca: **Player_Romus_Italic**
> "I picked up the banner and held it out. It read, "Voice of the People, Strength of the Nation!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "More like, "The Strength of the Crown," I thought to myself."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Ignore banner."]** — Mówca: **Player_Romus_Italic**
> "I ignored it as I continued walking toward the center of the room, relishing the moment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "And now..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no choice but to cut them down before they could strike. Rizia's survival was at stake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[9]` (Player_Romus), `[20]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "I reached the center of the chamber, I noticed the displa..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them an inch of trust, and they'll take a mile of betrayal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Player_Romus), `[6]` (Player_Romus), `[7]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""It's why I was destined to become king. It was my duty, ..."*)
  - -> `[24]` (*Player_Romus: ""I had no choice but to cut them down before they could s..."*)
  - -> `[28]` (*Player_Romus: ""Still, I can't help but wonder if there could have been ..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They concealed their true loyalty while sharpening their knives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[15]` (Player_Romus), `[16]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""You give them an inch of trust, and they'll take a mile ..."*)
  - -> `[20]` (*Player_Romus: ""Justice demanded action, not complacency.""*)
  - -> `[9]` (*Player_Romus: ""Even when others questioned me, I remained resolute.""*)
  - -> `[8]` (*Player_Romus: ""I always strived to protect and uphold the integrity of ..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "In it resided Rizia's constitution, a relic of this kingdom's brief experiment with democracy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""A good idea in theory but inevitably flawed.""*)
  - -> `[10]` (*Player_Romus: "“Democracy... what a joke.”"*)
  - -> `[31]` (*Player_Romus: "“To think that this unassuming document could have incite..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I can't help but wonder if there could have been another way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[9]` (Player_Romus), `[20]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "I reached the center of the chamber, I noticed the displa..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's why I was destined to become king. It was my duty, my purpose to bring these lands back under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[9]` (Player_Romus), `[20]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "I reached the center of the chamber, I noticed the displa..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "I reached the center of the chamber, I noticed the display case near the podiums."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "In it resided Rizia's constitution, a relic of this kingd..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“To think that this unassuming document could have incited such turmoil and challenge to my rule.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A good idea in theory but inevitably flawed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""They certainly did love to hear themselves talk. Now, it..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They certainly did love to hear themselves talk. Now, it’s blissfully quiet.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""They concealed their true loyalty while sharpening their..."*)
  - -> `[7]` (*Player_Romus: ""I refused to let them steer this kingdom off course.""*)
  - -> `[5]` (*Player_Romus: ""All they did was twist our laws and traditions to suit t..."*)
  - -> `[6]` (*Player_Romus: ""I never wanted it to come to this, but I did what needed..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_CommieKing == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""They served the elites, not the common man.. The real re..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_CommieKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They served the elites, not the common man.. The real revolution was doomed from the start in this place.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""They concealed their true loyalty while sharpening their..."*)
  - -> `[7]` (*Player_Romus: ""I refused to let them steer this kingdom off course.""*)
  - -> `[5]` (*Player_Romus: ""All they did was twist our laws and traditions to suit t..."*)
  - -> `[6]` (*Player_Romus: ""I never wanted it to come to this, but I did what needed..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "And now..."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Narrator**
> "I began to reflect upon the events that brought me here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus_Italic: "Once full of voices, this hall now reflected the Crown’s ..."*)
  - -> `[56]` (*Player_Romus_Italic: "These so-called delegates thought they held power but nev..."*)
  - -> `[43]` (*Player_Romus_Italic: "It was no surprise that those claiming to serve the publi..."*)
  - -> `[55]` (*Player_Romus_Italic: "The old order thought they could cling to power, but now,..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "It was no surprise that those claiming to serve the public would end up defying the Crown."]** — Mówca: **Player_Romus_Italic**
> "It was no surprise that those claiming to serve the public would end up defying the Crown."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus_Italic: "They concealed their true loyalty while sharpening their ..."*)
  - -> `[46]` (*Player_Romus_Italic: "I refused to let them steer this kingdom off course."*)
  - -> `[44]` (*Player_Romus_Italic: "They twisted our laws and traditions to suit their own pu..."*)
  - -> `[45]` (*Player_Romus_Italic: "I never wanted it to come to this, but it needed to be done."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "They twisted our laws and traditions to suit their own purposes."]** — Mówca: **Player_Romus_Italic**
> "They twisted our laws and traditions to suit their own purposes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[54]` (Player_Romus_Italic), `[55]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus_Italic: "I gave them an inch of trust, and they took a mile of bet..."*)
  - -> `[59]` (*Player_Romus_Italic: "Justice demanded action, not complacency."*)
  - -> `[48]` (*Player_Romus_Italic: "Even when others questioned me, I remained resolute."*)
  - -> `[47]` (*Player_Romus_Italic: "I always strove to protect and uphold the integrity of th..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "I never wanted it to come to this, but it needed to be done."]** — Mówca: **Player_Romus_Italic**
> "I never wanted it to come to this, but it needed to be done."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[54]` (Player_Romus_Italic), `[55]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus_Italic: "I gave them an inch of trust, and they took a mile of bet..."*)
  - -> `[59]` (*Player_Romus_Italic: "Justice demanded action, not complacency."*)
  - -> `[48]` (*Player_Romus_Italic: "Even when others questioned me, I remained resolute."*)
  - -> `[47]` (*Player_Romus_Italic: "I always strove to protect and uphold the integrity of th..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "I refused to let them steer this kingdom off course."]** — Mówca: **Player_Romus_Italic**
> "I refused to let them steer this kingdom off course."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[54]` (Player_Romus_Italic), `[55]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus_Italic: "I gave them an inch of trust, and they took a mile of bet..."*)
  - -> `[59]` (*Player_Romus_Italic: "Justice demanded action, not complacency."*)
  - -> `[48]` (*Player_Romus_Italic: "Even when others questioned me, I remained resolute."*)
  - -> `[47]` (*Player_Romus_Italic: "I always strove to protect and uphold the integrity of th..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "I always strove to protect and uphold the integrity of these lands."]** — Mówca: **Player_Romus_Italic**
> "I always strove to protect and uphold the integrity of these lands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Romus_Italic), `[45]` (Player_Romus_Italic), `[46]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus_Italic: "It's why I was destined to become king. It was my duty, m..."*)
  - -> `[63]` (*Player_Romus_Italic: "I had no choice but to cut them down before they could st..."*)
  - -> `[67]` (*Player_Romus_Italic: "Still, I couldn't help but wonder if there could have bee..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Even when others questioned me, I remained resolute."]** — Mówca: **Player_Romus_Italic**
> "Even when others questioned me, I remained resolute."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Romus_Italic), `[45]` (Player_Romus_Italic), `[46]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus_Italic: "It's why I was destined to become king. It was my duty, m..."*)
  - -> `[63]` (*Player_Romus_Italic: "I had no choice but to cut them down before they could st..."*)
  - -> `[67]` (*Player_Romus_Italic: "Still, I couldn't help but wonder if there could have bee..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Democracy... what a joke."]** — Mówca: **Player_Romus_Italic**
> "Democracy... what a joke."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus_Italic: "Mob rule is more like it!"*)
  - -> `[52]` (*Player_Romus_Italic: "Quixotic idealism fraught with insurmountable problems."*)
  - -> `[53]` (*Player_Romus_Italic: "Like giving a child a hammer -- everything’s a nail."*)
  - -> `[51]` (*Player_Romus_Italic: "A system driven by chaos, catering to the fickle desires ..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Mob rule is more like it!"]** — Mówca: **Player_Romus_Italic**
> "Mob rule is more like it!"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "A system driven by chaos, catering to the fickle desires of the masses."]** — Mówca: **Player_Romus_Italic**
> "A system driven by chaos, catering to the fickle desires of the masses."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Quixotic idealism fraught with insurmountable problems."]** — Mówca: **Player_Romus_Italic**
> "Quixotic idealism fraught with insurmountable problems."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "Like giving a child a hammer -- everything’s a nail."]** — Mówca: **Player_Romus_Italic**
> "Like giving a child a hammer -- everything’s a nail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Once full of voices, this hall now reflected the Crown’s true strength."]** — Mówca: **Player_Romus_Italic**
> "Once full of voices, this hall now reflected the Crown’s true strength."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus_Italic: "They concealed their true loyalty while sharpening their ..."*)
  - -> `[46]` (*Player_Romus_Italic: "I refused to let them steer this kingdom off course."*)
  - -> `[44]` (*Player_Romus_Italic: "They twisted our laws and traditions to suit their own pu..."*)
  - -> `[45]` (*Player_Romus_Italic: "I never wanted it to come to this, but it needed to be done."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "The old order thought they could cling to power, but now, it was mine to reshape."]** — Mówca: **Player_Romus_Italic**
> "The old order thought they could cling to power, but now, it was mine to reshape."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus_Italic: "They concealed their true loyalty while sharpening their ..."*)
  - -> `[46]` (*Player_Romus_Italic: "I refused to let them steer this kingdom off course."*)
  - -> `[44]` (*Player_Romus_Italic: "They twisted our laws and traditions to suit their own pu..."*)
  - -> `[45]` (*Player_Romus_Italic: "I never wanted it to come to this, but it needed to be done."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "These so-called delegates thought they held power but never grasped true leadership."]** — Mówca: **Player_Romus_Italic**
> "These so-called delegates thought they held power but never grasped true leadership."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus_Italic: "They concealed their true loyalty while sharpening their ..."*)
  - -> `[46]` (*Player_Romus_Italic: "I refused to let them steer this kingdom off course."*)
  - -> `[44]` (*Player_Romus_Italic: "They twisted our laws and traditions to suit their own pu..."*)
  - -> `[45]` (*Player_Romus_Italic: "I never wanted it to come to this, but it needed to be done."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "A monarchy was the only way to ensure stability and order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "And now..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "My eyes fell on an old banner draped over a bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus_Italic: "Pick up banner."*)
  - -> `[62]` (*Player_Romus_Italic: "Ignore banner."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "Justice demanded action, not complacency."]** — Mówca: **Player_Romus_Italic**
> "Justice demanded action, not complacency."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Romus_Italic), `[45]` (Player_Romus_Italic), `[46]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus_Italic: "It's why I was destined to become king. It was my duty, m..."*)
  - -> `[63]` (*Player_Romus_Italic: "I had no choice but to cut them down before they could st..."*)
  - -> `[67]` (*Player_Romus_Italic: "Still, I couldn't help but wonder if there could have bee..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "More like, "The Strength of the Crown," I thought to myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "A monarchy was the only way to ensure stability and order."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "Pick up banner."]** — Mówca: **Player_Romus_Italic**
> "I picked up the banner and held it out. It read, "Voice of the People, Strength of the Nation!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "More like, "The Strength of the Crown," I thought to myself."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "Ignore banner."]** — Mówca: **Player_Romus_Italic**
> "I ignored it as I continued walking toward the center of the room, relishing the moment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "And now..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "I had no choice but to cut them down before they could strike. Rizia's survival was at stake."]** — Mówca: **Player_Romus_Italic**
> "I had no choice but to cut them down before they could strike. Rizia's survival was at stake."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Romus_Italic), `[48]` (Player_Romus_Italic), `[59]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "I reached the center of the chamber, I noticed the displa..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "I gave them an inch of trust, and they took a mile of betrayal."]** — Mówca: **Player_Romus_Italic**
> "I gave them an inch of trust, and they took a mile of betrayal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Romus_Italic), `[45]` (Player_Romus_Italic), `[46]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus_Italic: "It's why I was destined to become king. It was my duty, m..."*)
  - -> `[63]` (*Player_Romus_Italic: "I had no choice but to cut them down before they could st..."*)
  - -> `[67]` (*Player_Romus_Italic: "Still, I couldn't help but wonder if there could have bee..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "They concealed their true loyalty while sharpening their knives."]** — Mówca: **Player_Romus_Italic**
> "They concealed their true loyalty while sharpening their knives."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[54]` (Player_Romus_Italic), `[55]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus_Italic: "I gave them an inch of trust, and they took a mile of bet..."*)
  - -> `[59]` (*Player_Romus_Italic: "Justice demanded action, not complacency."*)
  - -> `[48]` (*Player_Romus_Italic: "Even when others questioned me, I remained resolute."*)
  - -> `[47]` (*Player_Romus_Italic: "I always strove to protect and uphold the integrity of th..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "In it resided Rizia's constitution, a relic of this kingdom's brief experiment with democracy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus_Italic: "A good idea in theory but inevitably flawed."*)
  - -> `[49]` (*Player_Romus_Italic: "Democracy... what a joke."*)
  - -> `[70]` (*Player_Romus: "To think that this unassuming document could have incited..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "Still, I couldn't help but wonder if there could have been another way."]** — Mówca: **Player_Romus_Italic**
> "Still, I couldn't help but wonder if there could have been another way."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Romus_Italic), `[48]` (Player_Romus_Italic), `[59]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "I reached the center of the chamber, I noticed the displa..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "It's why I was destined to become king. It was my duty, my purpose to bring these lands back under control."]** — Mówca: **Player_Romus_Italic**
> "It's why I was destined to become king. It was my duty, my purpose to bring these lands back under control."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Romus_Italic), `[48]` (Player_Romus_Italic), `[59]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "I reached the center of the chamber, I noticed the displa..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "I reached the center of the chamber, I noticed the display case near the podiums."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "In it resided Rizia's constitution, a relic of this kingd..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "To think that this unassuming document could have incited such turmoil and challenge to my rule."]** — Mówca: **Player_Romus**
> "To think that this unassuming document could have incited such turmoil and challenge to my rule."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "A good idea in theory but inevitably flawed."]** — Mówca: **Player_Romus_Italic**
> "A good idea in theory but inevitably flawed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My eyes fell on an old banner draped over a bench."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus_Italic: "They certainly did love to hear themselves talk. Now, it’..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA: "They certainly did love to hear themselves talk. Now, it’s blissfully quiet."]** — Mówca: **Player_Romus_Italic**
> "They certainly did love to hear themselves talk. Now, it’s blissfully quiet."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus_Italic: "They concealed their true loyalty while sharpening their ..."*)
  - -> `[46]` (*Player_Romus_Italic: "I refused to let them steer this kingdom off course."*)
  - -> `[44]` (*Player_Romus_Italic: "They twisted our laws and traditions to suit their own pu..."*)
  - -> `[45]` (*Player_Romus_Italic: "I never wanted it to come to this, but it needed to be done."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_CommieKing == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "The real revolution was doomed from the start in this pla..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_CommieKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
**[WYBÓR GRACZA: "The real revolution was doomed from the start in this place -- jackals who served the elite, not the common man."]** — Mówca: **Player_Romus_Italic**
> "The real revolution was doomed from the start in this place -- jackals who served the elite, not the common man."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus_Italic: "They concealed their true loyalty while sharpening their ..."*)
  - -> `[46]` (*Player_Romus_Italic: "I refused to let them steer this kingdom off course."*)
  - -> `[44]` (*Player_Romus_Italic: "They twisted our laws and traditions to suit their own pu..."*)
  - -> `[45]` (*Player_Romus_Italic: "I never wanted it to come to this, but it needed to be done."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "And now..."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Narrator**
> "The House of Delegates was silent, a stark contrast to its former days of bustling activity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "As I walked through the grand chamber, my gaze over in th..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "As I walked through the grand chamber, my gaze over in the now-empty rows."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
