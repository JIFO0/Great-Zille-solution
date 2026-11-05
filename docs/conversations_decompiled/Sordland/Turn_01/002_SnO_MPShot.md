# Sordland/Turn01/SnO_MPShot

- **ID konwersacji:** `2`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/002_SnO_MPShot.md`
- **Liczba węzłów dialogowych:** 96
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[44]** Lileas Graf
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Reformist_Intention`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn01_LT_Murder`
- `GameCondition.Turn01_SnO_MPShot`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"“But why Bernard Circas?”"** | `[94]` **Lileas Graf**: ""The president and his family we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lileas Graf**: "“He has always been an infamous ..." |
| `[11]` | **"“What were the motivations of such a horrid act?”"** | `[94]` **Lileas Graf**: ""The president and his family we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lileas Graf**: "“Our investigators are suspectin..." |
| `[16]` | **"“An MP shot near the Palace. That is absolutely unacceptable.”"** | `[94]` **Lileas Graf**: ""The president and his family we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Lileas Graf**: "“I agree. We are re-evaluating o..." |
| `[20]` | **"“I fully agree. We should protect freedom of speech.”"** | `[8]` **Nia Morgna**: "“Freedom of expression is part o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Nia Morgna**: "“Our laws do, and for good reaso..." |
| `[21]` | **"“The Malenyevist ideology that the Red Youth promotes poses threats to our country..."** | `[8]` **Nia Morgna**: "“Freedom of expression is part o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lileas Graf**: "“Agreed. We are always watchful ..." |
| `[22]` | **"“The nationalist Young Sords have overstepped, and they must face consequences for..."** | `[8]` **Nia Morgna**: "“Freedom of expression is part o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Nia Morgna**: "“This is not a simple overstep b..." |
| `[31]` | **"“I agree. Internal stability must be maintained. Our security funding might need t..."** | `[7]` **Iosef Lancea**: "“Only if we stay vigilant as a c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lucian Galade**: "“I am sure the Minister of Inter..." |
| `[32]` | **"“We should not lose sight of our real political goals, like the constitutional ref..."** | `[7]` **Iosef Lancea**: "“Only if we stay vigilant as a c..." | `Variable["BaseGame.Reform_Reformist_Intention"] == true` | *Brak zmian stanu* | `[36]` **Lucian Galade**: "“Agreed, these matters shouldn't..." |
| `[33]` | **"“It is too soon to jump to conclusions. Reckless acts will have dire consequences.”"** | `[7]` **Iosef Lancea**: "“Only if we stay vigilant as a c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucian Galade**: "“Agreed. We need to be patient u..." |
| `[46]` | **"“Any threat to our power must be dealt with as soon as possible.”"** | `[7]` **Iosef Lancea**: "“Only if we stay vigilant as a c..." | `Variable["BaseGame.Reform_Dictator_Intention"] == true` | *Brak zmian stanu* | `[47]` **Lucian Galade**: "“Any direct attack against the g..." |
| `[56]` | **"“So I wasn't the target?”"** | `[94]` **Lileas Graf**: ""The president and his family we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lileas Graf**: "“Fortunately, no. You were simpl..." |
| `[62]` | **"“It is political, though, isn't it?”"** | `[12]` **Lucian Galade**: "“We should refrain from making t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucian Galade**: "“Yes, but we need to calm the co..." |
| `[63]` | **"“It's early, but will we attend the funeral?”"** | `[12]` **Lucian Galade**: "“We should refrain from making t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucian Galade**: "“In my opinion we should. The nu..." |
| `[70]` | **"“You are right. We need to defuse the situation.”"** | `[12]` **Lucian Galade**: "“We should refrain from making t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucian Galade**: "“Our government is capable to ma..." |
| `[76]` | **"“We can't fix the recession if there isn't stability.”"** | `[49]` **Nia Morgna**: "“It will be very difficult to pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Petr Vectern**: "“You are right. We need to trust..." |
| `[77]` | **"“We can't pass any constitutional reform in such an atmosphere.”"** | `[49]` **Nia Morgna**: "“It will be very difficult to pa..." | `Variable["BaseGame.Reform_Autocrat_Intention"] == false` | *Brak zmian stanu* | `[80]` **Petr Vectern**: "“No use worrying about it now. L..." |
| `[78]` | **"“We will make it through this and deliver our promises.”"** | `[49]` **Nia Morgna**: "“It will be very difficult to pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Petr Vectern**: "“Hell yes, President Rayne!”" |
| `[88]` | **"“Whoever is against the state is an enemy.”"** | `[49]` **Nia Morgna**: "“It will be very difficult to pa..." | `Variable["BaseGame.Reform_Autocrat_Intention"] == true` | *Brak zmian stanu* | `[89]` **Iosef Lancea**: "“We will prevail.”" |

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
  - -> `[3]` (*Narrator: "The mood in the situation room was gloomy."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The mood in the situation room was gloomy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "My cabinet members were gathered to discuss the shooting ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "My cabinet members were gathered to discuss the shooting outside the Palace. Lileas presented the initial report."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lileas Graf: "“Bernard Circas was shot dead at 9:03 pm in front of the ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_SnO_MPShot = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_SnO_MPShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[6]`
Mówca: **Lileas Graf**
> "“I agree. We are re-evaluating our security measures. However, the recession has affected my ministry negatively.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“This may well create a dangerous atmosphere where the le..."*)

### Węzeł `[7]`
Mówca: **Iosef Lancea**
> "“Only if we stay vigilant as a country... We must think about the upcoming budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“It is too soon to jump to conclusions. Reckless acts wil..."*)
  - -> `[31]` (*Player: "“I agree. Internal stability must be maintained. Our secu..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[8]`
Mówca: **Nia Morgna**
> "“Freedom of expression is part of our constitution. We can't have anyone, let alone an MP, shot for voicing different opinions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“I fully agree. We should protect freedom of speech.”"*)
  - -> `[21]` (*Player: "“The Malenyevist ideology that the Red Youth promotes pos..."*)
  - -> `[22]` (*Player: "“The nationalist Young Sords have overstepped, and they m..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“But why Bernard Circas?”"]** — Mówca: **Player**
> "“But why Bernard Circas?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lileas Graf: "“He has always been an infamous figure. His poems had a l..."*)

### Węzeł `[10]`
Mówca: **Lileas Graf**
> "“Bernard Circas was shot dead at 9:03 pm in front of the palace gates. He was an elected independent member of Assembly and as you know, a famous communist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "She spat the last word out with some distaste."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“What were the motivations of such a horrid act?”"]** — Mówca: **Player**
> "“What were the motivations behind such a horrid act?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lileas Graf: "“Our investigators are suspecting a political assassinati..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“We should refrain from making the issue a political one from the start. It will only add fuel to the fire.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“It is political, though, isn't it?”"*)
  - -> `[70]` (*Player: "“You are right. We need to defuse the situation.”"*)
  - -> `[63]` (*Player: "“It's early, but will we attend the funeral?”"*)

### Węzeł `[13]`
Mówca: **Lileas Graf**
> "“Regardless, a full investigation into all involved parties is under way. We will find the subversives and punish them soon enough, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Petr Vectern: "“I'll do my best to help coordinate the administrative ta..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The meeting concluded and the ministers left the room with concerned looks. It was hard to anticipate what would happen next."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_LT_Murder = true"*)

### Węzeł `[15]`
Mówca: **Lileas Graf**
> "“The guards at the scene were fifty meters away and immediately took action by responding and killing the assailant who was identified as a member of the nationalist organization, Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lileas Graf: ""The president and his family were unharmed, praise God.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“An MP shot near the Palace. That is absolutely unacceptable.”"]** — Mówca: **Player**
> "“An MP shot near the Palace. That is absolutely unacceptable.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lileas Graf: "“I agree. We are re-evaluating our security measures. How..."*)

### Węzeł `[17]`
Mówca: **Lileas Graf**
> "“Our investigators are suspecting a political assassination since the Young Sords have been threatening the communists for some time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“This may well create a dangerous atmosphere where the le..."*)

### Węzeł `[18]`
Mówca: **Lileas Graf**
> "“He has always been an infamous figure. His poems had a large impact in the spread of communist ideas in Sordland. Many considered him a threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lileas Graf: "“Our investigators are suspecting a political assassinati..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“This may well create a dangerous atmosphere where the left versus right political violence of the 1920s could spark once again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: "“A return to those days would be devastating. The coups a..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I fully agree. We should protect freedom of speech.”"]** — Mówca: **Player**
> "“I fully agree. We should protect freedom of speech.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Nia Morgna: "“Our laws do, and for good reason. Silencing voices only ..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“The Malenyevist ideology that the Red Youth promotes poses threats to our country too. We should be cautious.”"]** — Mówca: **Player**
> "“The Malenyevist ideology that the Red Youth promotes poses threats to our country too. We should be cautious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lileas Graf: "“Agreed. We are always watchful of internal threats, like..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“The nationalist Young Sords have overstepped, and they must face consequences for such an extreme action.”"]** — Mówca: **Player**
> "“The nationalist Young Sords have overstepped, and they must face consequences for such an extreme action.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: "“This is not a simple overstep but an attack on our count..."*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“A return to those days would be devastating. The coups are the reason why our country stagnated for a decade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Nia Morgna, the Minister of Justice, sighed."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Nia Morgna, the Minister of Justice, sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Nia Morgna: "“The Red Youth has condemned the killing but didn't stop ..."*)

### Węzeł `[25]`
Mówca: **Nia Morgna**
> "“Our laws do, and for good reason. Silencing voices only results in fear and stagnation inside society.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: "“We had that before and know very well how it was.”"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Several police cars rushed past the Maroon Palace and everyone went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lileas Graf: "“Regardless, a full investigation into all involved parti..."*)

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“All due respect, ma'am, but we shouldn't be quick to jump to conclusions before a full investigation has been conducted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: "“We should refrain from making the issue a political one ..."*)

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“Agreed. We are always watchful of internal threats, like the banned Communist Party members who support a similar agenda as the Red Youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Nia Morgna: "“These groups wouldn't resort to unconventional means if ..."*)

### Węzeł `[29]`
Mówca: **Iosef Lancea**
> "“Don't be stupid, woman. These organizations speak against the state. The Labor Union of Sordland is also in the same boat. I wouldn't be surprised if United Contana had a hand in supporting all of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: "“We should refrain from making the issue a political one ..."*)

### Węzeł `[30]`
Mówca: **Lileas Graf**
> "“I hear your concerns, our police do their best to uphold the rights of our citizens. We will prevent such an act from happening again by making sure our security measures are re-evaluated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Minister of Defense Iosef Lancea grunted in approval. He ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“I agree. Internal stability must be maintained. Our security funding might need to be increased.”"]** — Mówca: **Player**
> "“I agree. Internal stability must be maintained. Our security funding might need to be increased.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: "“I am sure the Minister of Interior has already taken the..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“We should not lose sight of our real political goals, like the constitutional reforms.”"]** — Mówca: **Player**
> "“We should not lose sight of our real political goals, like the constitutional reforms.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: "“Agreed, these matters shouldn't distract us from what th..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“It is too soon to jump to conclusions. Reckless acts will have dire consequences.”"]** — Mówca: **Player**
> "“It is too soon to jump to conclusions. Reckless acts will have dire consequences.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: "“Agreed. We need to be patient until we have the full pic..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“Agreed. We need to be patient until we have the full picture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Lucian took some notes after checking the latest newspape..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“I am sure the Minister of Interior has already taken the necessary precautions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“You can be assured that our police units and intelligenc..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Agreed, these matters shouldn't distract us from what the people want us to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Lucian took some notes after checking the latest newspape..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Intention == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“We should not lose sight of our real political goals, li..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Intention == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“Any threat to our power must be dealt with as soon as po..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“Any threat to our power must be dealt with as soon as po..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Any threat to our power must be dealt with as soon as possible.”"]** — Mówca: **Player**
> "“Any threat to our power must be dealt with as soon as possible.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“Any direct attack against the government and our people ..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“Any direct attack against the government and our people is a serious concern but we don't know enough to act on yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Lucian took some notes after checking the latest newspape..."*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> "“It seems that the tensions between the communists and nationalists will escalate further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: "“It will be very difficult to pass any meaningful change ..."*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> "“It will be very difficult to pass any meaningful change if there is chaos in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == false"*)
  - -> `[76]` (*Player: "“We can't fix the recession if there isn't stability.”"*)
  - -> `[78]` (*Player: "“We will make it through this and deliver our promises.”"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“You can be assured that our police units and intelligence units are on increased threat condition. Nobody should be able to move a finger against government officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Lucian took some notes after checking the latest newspape..."*)

### Węzeł `[51]`
Mówca: **Petr Vectern**
> "“This will be it for today then. We will convene again soon. Thank you all, and keep us updated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The meeting concluded and the ministers left the room wit..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Nia had always been one of the only members of the Justice Ministry truly deserving of the name. She had survived countless attacks on her character while fighting corruption within the ministry, and rising to power had only compounded her sense of moral duty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Nia Morgna: "“Freedom of expression is part of our constitution. We ca..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Minister of Defense Iosef Lancea grunted in disapproval. He towered over the rest of us in full military uniform, his many war medals conspicuously on display."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Iosef Lancea: "“All due respect, ma'am, but we shouldn't be quick to jum..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Minister of Defense Iosef Lancea grunted in disapproval. He towered over the rest of us in full military uniform, his many war medals conspicuously on display."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Iosef Lancea: "“Don't be stupid, woman. These organizations speak agains..."*)

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“Fortunately, no. You were simply in the wrong place at the wrong time. Our security forces have no reason to believe anybody has motivations to act against the President of Sordland for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lileas Graf: "“Our investigators are suspecting a political assassinati..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“So I wasn't the target?”"]** — Mówca: **Player**
> "“So I wasn't the target?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lileas Graf: "“Fortunately, no. You were simply in the wrong place at t..."*)

### Węzeł `[57]`
Mówca: **Nia Morgna**
> "“The Red Youth has condemned the killing but didn't stop there. They promised revenge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Nia Morgna: "“This will in turn spark further aggression from the Youn..."*)

### Węzeł `[58]`
Mówca: **Nia Morgna**
> "“This will in turn spark further aggression from the Young Sords. The whole cycle started because Bernard Circas expressed his views. We can't simply look away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Nia had always been one of the only members of the Justic..."*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> "“This is not a simple overstep but an attack on our country. Murder for political opinions is a thing of the past. Our administration is building something new.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: "“Agreed. We will reach out to the NFP and ask them to cal..."*)

### Węzeł `[60]`
Mówca: **Nia Morgna**
> "“These groups wouldn't resort to unconventional means if they were represented in our Assembly. The high electoral threshold and bans are making these factions extreme.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Minister of Defense Iosef Lancea grunted in disapproval. ..."*)

### Węzeł `[61]`
Mówca: **Nia Morgna**
> "“Justice will be served and the rule of law will return to this country stronger than ever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Iosef Lancea: "“Only if we stay vigilant as a country... We must think a..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“It is political, though, isn't it?”"]** — Mówca: **Player**
> "“It is political, though, isn't it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: "“Yes, but we need to calm the country. If we take sides w..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It's early, but will we attend the funeral?”"]** — Mówca: **Player**
> "“It's early, but will we attend the funeral?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: "“In my opinion we should. The nuance here is to detach th..."*)

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“How can that be achieved when it is Bernard Circas we are talking about? He is *the* communist of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“It is difficult, but an elected official has been shot. ..."*)

### Węzeł `[65]`
Mówca: **Iosef Lancea**
> "“There aren't many sides. The state versus its enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Several police cars rushed past the Maroon Palace and eve..."*)

### Węzeł `[66]`
Mówca: **Nia Morgna**
> "“We had that before and know very well how it was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lileas Graf: "“I hear your concerns, our police do their best to uphold..."*)

### Węzeł `[67]`
Mówca: **Iosef Lancea**
> "“Agreed, ma'am. Our Gendarmerie will also help boost security in the rural areas where possible. There might be more violence to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: "“We should refrain from making the issue a political one ..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Minister of Defense Iosef Lancea grunted in approval. He towered over the rest of us in full military uniform, his many war medals conspicuously on display."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Iosef Lancea: "“Agreed, ma'am. Our Gendarmerie will also help boost secu..."*)

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“Agreed. We will reach out to the NFP and ask them to calm the situation with the Young Sords. The two groups have ties and Mr. Kibener sees reason, after all, which can't be said about the Young Sords at times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Minister of Defense Iosef Lancea grunted in disapproval. ..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“You are right. We need to defuse the situation.”"]** — Mówca: **Player**
> "“You are right, we need to calm the situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: "“Our government is capable to maintain security. Our job ..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> "“Yes, but we need to calm the country. If we take sides we could escalate the situation further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Iosef Lancea: "“There aren't many sides. The state versus its enemies.”"*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> "“Our government is capable to maintain security. Our job will be to reduce tensions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Several police cars rushed past the Maroon Palace and eve..."*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> "“In my opinion we should. The nuance here is to detach the person from the violent act.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Iosef Lancea: "“How can that be achieved when it is Bernard Circas we ar..."*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“It is difficult, but an elected official has been shot. This is unacceptable for our new administration. We need to make sure we show our stance by condemning it at the funeral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Several police cars rushed past the Maroon Palace and eve..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Lucian took some notes after checking the latest newspapers and reports."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: "“It seems that the tensions between the communists and na..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“We can't fix the recession if there isn't stability.”"]** — Mówca: **Player**
> "“We can't fix the recession if there isn't stability.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: "“You are right. We need to trust our ministers to stabili..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“We can't pass any constitutional reform in such an atmosphere.”"]** — Mówca: **Player**
> "“We can't pass any constitutional reform in such an atmosphere.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Intention"] == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Petr Vectern: "“No use worrying about it now. Let's analyze the effects ..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“We will make it through this and deliver our promises.”"]** — Mówca: **Player**
> "“We will make it through this and deliver our promises.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: "“Hell yes, President Rayne!”"*)

### Węzeł `[79]`
Mówca: **Petr Vectern**
> "“You are right. We need to trust our ministers to stabilize the situation if it comes to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“This will be it for today then. We will convene again so..."*)

### Węzeł `[80]`
Mówca: **Petr Vectern**
> "“No use worrying about it now. Let's analyze the effects first. We will cross that bridge when we come to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“This will be it for today then. We will convene again so..."*)

### Węzeł `[81]`
Mówca: **Petr Vectern**
> "“Hell yes, President Rayne!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“This will be it for today then. We will convene again so..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == false"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == false)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“We can't pass any constitutional reform in such an atmos..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“Whoever is against the state is an enemy.”"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Whoever is against the state is an enemy.”"]** — Mówca: **Player**
> "“Whoever is against the state is an enemy.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Iosef Lancea: "“We will prevail.”"*)

### Węzeł `[89]`
Mówca: **Iosef Lancea**
> "“We will prevail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: "“We are here to stay.”"*)

### Węzeł `[90]`
Mówca: **Petr Vectern**
> "“We are here to stay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Petr Vectern: "“This will be it for today then. We will convene again so..."*)

### Węzeł `[91]`
Mówca: **Petr Vectern**
> "“I'll do my best to help coordinate the administrative tasks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Nia Morgna: "“Justice will be served and the rule of law will return t..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_LT_Murder = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_LT_Murder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_SnO_MPShot = true"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "She spat the last word out with some distaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lileas Graf: "“The guards at the scene were fifty meters away and immed..."*)

### Węzeł `[94]`
Mówca: **Lileas Graf**
> ""The president and his family were unharmed, praise God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“An MP shot near the Palace. That is absolutely unaccepta..."*)
  - -> `[11]` (*Player: "“What were the motivations of such a horrid act?”"*)
  - -> `[9]` (*Player: "“But why Bernard Circas?”"*)
  - -> `[56]` (*Player: "“So I wasn't the target?”"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
