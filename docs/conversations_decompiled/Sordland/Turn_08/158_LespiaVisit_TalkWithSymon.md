# Sordland/Turn08/LespiaVisit_TalkWithSymon

- **ID konwersacji:** `158`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/158_LespiaVisit_TalkWithSymon.md`
- **Liczba węzłów dialogowych:** 65
- **Liczba wyborów gracza:** 22

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn08_FPnT_BrokenTeapot`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[154] Sordland/Turn08/FPnT_LespiaVisit** (../Turn_08/154_FPnT_LespiaVisit.md), Węzeł `[11]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“Is this something that could affect this trade deal?”"** | `[37]` **Symon Holl**: "“Some even call him an alcoholic.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Symon Holl**: "“Honestly, I don't know.”" |
| `[13]` | **"“I'll see you when we arrive.”"** | `[11]` **Symon Holl**: "“We are almost at Perla. I will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "A few minutes later, with a long..." |
| `[16]` | **"“Yes? What is it?”"** | `[14]` **Symon Holl**: "“Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Symon Holl**: "“I wanted to have a quick chat a..." |
| `[17]` | **"“Symon. Have a seat.”"** | `[14]` **Symon Holl**: "“Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "He sat down on a chair in front ..." |
| `[18]` | **"Leave the broken handle next to the teapot."** | `[57]` **Narrator**: "While I was touching it, the han..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] = t...` | `[26]` **Narrator**: "The door opened and Patricio Alv..." |
| `[24]` | **"“Very well.”"** | `[11]` **Symon Holl**: "“We are almost at Perla. I will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "A few minutes later, with a long..." |
| `[27]` | **"“What do you mean? What did he do?”"** | `[25]` **Symon Holl**: "“There have been some rumours ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Symon Holl**: "“He is known to have met with ot..." |
| `[28]` | **"“Go on.”"** | `[25]` **Symon Holl**: "“There have been some rumours ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Symon Holl**: "“He is known to have met with ot..." |
| `[29]` | **"“I can handle him. Don't worry.”"** | `[25]` **Symon Holl**: "“There have been some rumours ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Symon Holl**: "“He is known to have met with ot..." |
| `[36]` | **"Hide it behind a nearby plant."** | `[57]` **Narrator**: "While I was touching it, the han..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] = t...` | `[26]` **Narrator**: "The door opened and Patricio Alv..." |
| `[38]` | **"“Now I am worried.”"** | `[6]` **Symon Holl**: "“Also, we need to be careful. I ..."<br>`[40]` **Symon Holl**: "“Although his premiership is rid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Symon Holl**: "“I am sure we will be fine, Mr. ..." |
| `[39]` | **"“So the man can't handle his drink. Is that it?”"** | `[37]` **Symon Holl**: "“Some even call him an alcoholic.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Symon Holl**: "“That seems to be the case.”" |
| `[42]` | **"Pocket the broken handle."** | `[57]` **Narrator**: "While I was touching it, the han..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] = t...` | `[26]` **Narrator**: "The door opened and Patricio Alv..." |
| `[43]` | **"“It should be fine. I have dealt with worse than that before.”"** | `[37]` **Symon Holl**: "“Some even call him an alcoholic.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Symon Holl**: "“I don't think there will be any..." |
| `[45]` | **"Wait."** | `[31]` **Narrator**: "The convoy came to a stop and I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "After ten minutes. there was sti..." |
| `[50]` | **"Inspect the teapot."** | `[62]` **Narrator**: "My chair started to feel uncomfo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "While I was touching it, the han..." |
| `[51]` | **"“Thanks for giving me a heads up.”"** | `[6]` **Symon Holl**: "“Also, we need to be careful. I ..."<br>`[40]` **Symon Holl**: "“Although his premiership is rid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Symon Holl**: "“I am sure we will be fine, Mr. ..." |
| `[58]` | **"“I hope he doesn't show up drunk to our meeting too.”"** | `[52]` **Symon Holl**: "“After this incident, some say h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Symon Holl**: "“I wouldn't bet on it.”" |
| `[59]` | **"“Why is that?”"** | `[52]` **Symon Holl**: "“After this incident, some say h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Symon Holl**: "“Although his premiership is rid..." |
| `[60]` | **"“Trust me. I can handle him.”"** | `[6]` **Symon Holl**: "“Also, we need to be careful. I ..."<br>`[40]` **Symon Holl**: "“Although his premiership is rid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Symon Holl**: "“I do. I am sure we will be fine..." |
| `[61]` | **"“These are the Lespians people fear? Ridiculous.”"** | `[52]` **Symon Holl**: "“After this incident, some say h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Symon Holl**: "“Regardless, I don't think we sh..." |
| `[63]` | **"Leave it alone."** | `[62]` **Narrator**: "My chair started to feel uncomfo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "I went back to my chair." |

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
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ElectricTrainDeparting");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“We are almost at Perla. I will return to my cabin now.”"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The Maroon Train slowly started to move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "This train had been in service for many years. It had nin..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Among camera flashes and cheers, we departed from the Holsord central train station. Our destination was Perla, the capital of Lespia. The historic route we were using was also called The Southern Express."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "We passed through the Lespian mountain range to the lowla..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "This train had been in service for many years. It had nine locomotives with special quarters and an office. As the name implied, it was painted bright maroon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Among camera flashes and cheers, we departed from the Hol..."*)

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“Also, we need to be careful. I heard that he is a shrewd man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Thanks for giving me a heads up.”"*)
  - -> `[60]` (*Player: "“Trust me. I can handle him.”"*)
  - -> `[38]` (*Player: "“Now I am worried.”"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "We passed through the Lespian mountain range to the lowlands, with a short stop at the beautiful Sarea Nueva where Lespian security forces joined us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Looking outside the window, the difference in wealth betw..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Looking outside the window, the difference in wealth between Valgen and Sarea Nueva was extraordinary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I heard a knock on the door to my office on the train and..."*)

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“This happened just yesterday. Apparently he was so drunk that he couldn't get off the plane on a diplomatic visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“After this incident, some say he is unfit to serve. But ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Is this something that could affect this trade deal?”"]** — Mówca: **Player**
> "“Is this something that could affect this trade deal?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Symon Holl: "“Honestly, I don't know.”"*)

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“We are almost at Perla. I will return to my cabin now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“Very well.”"*)
  - -> `[13]` (*Player: "“I'll see you when we arrive.”"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "I heard a knock on the door to my office on the train and Symon entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Symon Holl: "“Mr. President.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I'll see you when we arrive.”"]** — Mówca: **Player**
> "“I'll see you when we arrive.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "A few minutes later, with a long whistle, our train came ..."*)

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“Symon. Have a seat.”"*)
  - -> `[16]` (*Player: "“Yes? What is it?”"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Although I knew that he was one of the youngest state leaders in the world, I was still surprised by how boyish he looked. At his age, he was leading one of the strongest countries in Eastern Merkopa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He was holding his head like he had a headache and he was..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Yes? What is it?”"]** — Mówca: **Player**
> "“Yes? What is it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“I wanted to have a quick chat about Prime Minister Alvar..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Symon. Have a seat.”"]** — Mówca: **Player**
> "“Symon. Have a seat.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "He sat down on a chair in front of my desk."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Leave the broken handle next to the teapot."]** — Mówca: **Player_Italic**
> "I left the broken handle next to the teapot."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot = true"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "He gestured towards the two couches and we sat down face-to-face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“I wanted to have a quick chat about Prime Minister Alvarez and give you a heads up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: "“There have been some rumours about his...demeanour in pu..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "He sat down on a chair in front of my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“I wanted to have a quick chat about Prime Minister Alvar..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "He was holding his head like he had a headache and he was stumbling. Upon seeing me, he immediately composed himself. We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He gestured towards the two couches and we sat down face-..."*)

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“I do. I am sure we will be fine, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“We are almost at Perla. I will return to my cabin now.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "A few minutes later, with a long whistle, our train came ..."*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“There have been some rumours about his...demeanour in public appearances.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“Go on.”"*)
  - -> `[27]` (*Player: "“What do you mean? What did he do?”"*)
  - -> `[29]` (*Player: "“I can handle him. Don't worry.”"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "The door opened and Patricio Alvarez entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Although I knew that he was one of the youngest state lea..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“What do you mean? What did he do?”"]** — Mówca: **Player**
> "“What do you mean? What did he do?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“He is known to have met with other state leaders while i..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“He is known to have met with other state leaders while i..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I can handle him. Don't worry.”"]** — Mówca: **Player**
> "“I can handle him. Don't worry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“He is known to have met with other state leaders while i..."*)

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“I am sure we will be fine, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“We are almost at Perla. I will return to my cabin now.”"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "The convoy came to a stop and I made my way to the entrance. The assistants directed me to a room to wait for Prime Minister Alvarez."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Italic: "Wait."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "A few minutes later, with a long whistle, our train came to a stop. I waved to the crowd from the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The crowds of reporters that flocked over were pushed awa..."*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“He is known to have met with other state leaders while intoxicated on various occasions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Symon Holl: "“Some even call him an alcoholic.”"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "The door opened and Patricio Alvarez entered."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "The Yellow House was situated at the very centre of Perla in the middle of a circular park that was off limits to regular citizens. The park was full of roses on small patches."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The convoy came to a stop and I made my way to the entran..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "Hide it behind a nearby plant."]** — Mówca: **Player_Italic**
> "I hid the broken handle behind the plant next to the teapot cabinet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot = true"*)

### Węzeł `[37]`
Mówca: **Symon Holl**
> "“Some even call him an alcoholic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Is this something that could affect this trade deal?”"*)
  - -> `[39]` (*Player: "“So the man can't handle his drink. Is that it?”"*)
  - -> `[43]` (*Player: "“It should be fine. I have dealt with worse than that bef..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Now I am worried.”"]** — Mówca: **Player**
> "“Now I am worried.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Symon Holl), `[40]` (Symon Holl), `[54]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: "“I am sure we will be fine, Mr. President.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“So the man can't handle his drink. Is that it?”"]** — Mówca: **Player**
> "“So the man can't handle his drink. Is that it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Symon Holl: "“That seems to be the case.”"*)

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“Although his premiership is riddled with these kind of incidents, I also heard that he is a shrewd man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Thanks for giving me a heads up.”"*)
  - -> `[60]` (*Player: "“Trust me. I can handle him.”"*)
  - -> `[38]` (*Player: "“Now I am worried.”"*)

### Węzeł `[41]`
Mówca: **Symon Holl**
> "“Regardless, I don't think we should underestimate them. They hold substantial economic power, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Symon Holl: "“Also, we need to be careful. I heard that he is a shrewd..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Pocket the broken handle."]** — Mówca: **Player_Italic**
> "I put the broken handle in my pocket."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot = true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It should be fine. I have dealt with worse than that before.”"]** — Mówca: **Player**
> "“It should be fine. I have dealt with worse than that before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“I don't think there will be any issues either. I just wa..."*)

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Honestly, I don't know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He handed me a newspaper. The headline was 'Circling Over..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Wait."]** — Mówca: **Player_Italic**
> "I sat in the exquisite room and looked up at the golden chandeliers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "After ten minutes. there was still no sign of Prime Minis..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The crowds of reporters that flocked over were pushed away by the Lespian security guards. We made our way to our cars and the convoy began its short trip to the Yellow House."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "The Yellow House was situated at the very centre of Perla..."*)

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“That seems to be the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He handed me a newspaper. The headline was 'Circling Over..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "I went back to my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "The door opened and Patricio Alvarez entered."*)

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“I don't think there will be any issues either. I just wanted to give you a heads up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He handed me a newspaper. The headline was 'Circling Over..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Inspect the teapot."]** — Mówca: **Player_Italic**
> "I started inspecting the teapot."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "While I was touching it, the handle broke off. I looked a..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Thanks for giving me a heads up.”"]** — Mówca: **Player**
> "“Thanks for giving me a heads up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Symon Holl), `[40]` (Symon Holl), `[54]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: "“I am sure we will be fine, Mr. President.”"*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“After this incident, some say he is unfit to serve. But I don't believe that at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Why is that?”"*)
  - -> `[58]` (*Player: "“I hope he doesn't show up drunk to our meeting too.”"*)
  - -> `[61]` (*Player: "“These are the Lespians people fear? Ridiculous.”"*)

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“I wouldn't bet on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Symon Holl: "“We need to be careful. I heard that he is a shrewd man.”"*)

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“We need to be careful. I heard that he is a shrewd man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Thanks for giving me a heads up.”"*)
  - -> `[60]` (*Player: "“Trust me. I can handle him.”"*)
  - -> `[38]` (*Player: "“Now I am worried.”"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "He handed me a newspaper. The headline was 'Circling Over Staalport'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: "“This happened just yesterday. Apparently he was so drunk..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "After ten minutes. there was still no sign of Prime Minister Alvarez. It was almost time for our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "My chair started to feel uncomfortable. I stood up and wa..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "While I was touching it, the handle broke off. I looked around. Thankfully no one was in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Leave the broken handle next to the teapot."*)
  - -> `[42]` (*Player_Italic: "Pocket the broken handle."*)
  - -> `[36]` (*Player_Italic: "Hide it behind a nearby plant."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“I hope he doesn't show up drunk to our meeting too.”"]** — Mówca: **Player**
> "“I hope he doesn't show up drunk to our meeting too.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Symon Holl: "“I wouldn't bet on it.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Why is that?”"]** — Mówca: **Player**
> "“Why is that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Symon Holl: "“Although his premiership is riddled with these kind of i..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Trust me. I can handle him.”"]** — Mówca: **Player**
> "“Trust me. I can handle him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Symon Holl), `[40]` (Symon Holl), `[54]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Symon Holl: "“I do. I am sure we will be fine, Mr. President.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“These are the Lespians people fear? Ridiculous.”"]** — Mówca: **Player**
> "“These are the Lespians people fear? Ridiculous.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Symon Holl: "“Regardless, I don't think we should underestimate them. ..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "My chair started to feel uncomfortable. I stood up and walked around to look at the various items in the room. A beautiful golden teapot piqued my interest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Italic: "Inspect the teapot."*)
  - -> `[63]` (*Player_Italic: "Leave it alone."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Leave it alone."]** — Mówca: **Player_Italic**
> "I admired the teapot and left it alone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "I went back to my chair."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("ElectricTrainDeparting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("ElectricTrainDeparting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The Maroon Train slowly started to move."*)
