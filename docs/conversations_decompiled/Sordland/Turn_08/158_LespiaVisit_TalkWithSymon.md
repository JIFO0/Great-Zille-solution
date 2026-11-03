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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[34]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] = true;`
- Węzeł `[64]` (Paskal Beniwoll): `PlaySoundEffect("ElectricTrainDeparting");`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `154` (*Sordland/Turn08/FPnT_LespiaVisit*), Węzeł `[11]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The Maroon Train slowly started to move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Among camera flashes and cheers, we departed from the Holsord central train station. Our destination was Perla, the capital of Lespia. The historic route we were using was also called The Southern Express."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Narrator**
> "This train had been in service for many years. It had nine locomotives with special quarters and an office. As the name implied, it was painted bright maroon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“Also, we need to be careful. I heard that he is a shrewd man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[60]`
  - -> `[38]`

### Węzeł `[7]`
Mówca: **Narrator**
> "We passed through the Lespian mountain range to the lowlands, with a short stop at the beautiful Sarea Nueva where Lespian security forces joined us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Looking outside the window, the difference in wealth between Valgen and Sarea Nueva was extraordinary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“This happened just yesterday. Apparently he was so drunk that he couldn't get off the plane on a diplomatic visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Is this something that could affect this trade deal?”"]** — Mówca: **Player**
> "“Is this something that could affect this trade deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“We are almost at Perla. I will return to my cabin now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "I heard a knock on the door to my office on the train and Symon entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I'll see you when we arrive.”"]** — Mówca: **Player**
> "“I'll see you when we arrive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Although I knew that he was one of the youngest state leaders in the world, I was still surprised by how boyish he looked. At his age, he was leading one of the strongest countries in Eastern Merkopa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Yes? What is it?”"]** — Mówca: **Player**
> "“Yes? What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Symon. Have a seat.”"]** — Mówca: **Player**
> "“Symon. Have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Leave the broken handle next to the teapot."]** — Mówca: **Player_Italic**
> "I left the broken handle next to the teapot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[19]`
Mówca: **Narrator**
> "He gestured towards the two couches and we sat down face-to-face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“I wanted to have a quick chat about Prime Minister Alvarez and give you a heads up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
Mówca: **Narrator**
> "He sat down on a chair in front of my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[22]`
Mówca: **Narrator**
> "He was holding his head like he had a headache and he was stumbling. Upon seeing me, he immediately composed himself. We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“I do. I am sure we will be fine, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“There have been some rumours about his...demeanour in public appearances.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[27]`
  - -> `[29]`

### Węzeł `[26]`
Mówca: **Narrator**
> "The door opened and Patricio Alvarez entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“What do you mean? What did he do?”"]** — Mówca: **Player**
> "“What do you mean? What did he do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I can handle him. Don't worry.”"]** — Mówca: **Player**
> "“I can handle him. Don't worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“I am sure we will be fine, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[31]`
Mówca: **Narrator**
> "The convoy came to a stop and I made my way to the entrance. The assistants directed me to a room to wait for Prime Minister Alvarez."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[32]`
Mówca: **Narrator**
> "A few minutes later, with a long whistle, our train came to a stop. I waved to the crowd from the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“He is known to have met with other state leaders while intoxicated on various occasions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_BrokenTeapot = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[35]`
Mówca: **Narrator**
> "The Yellow House was situated at the very centre of Perla in the middle of a circular park that was off limits to regular citizens. The park was full of roses on small patches."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "Hide it behind a nearby plant."]** — Mówca: **Player_Italic**
> "I hid the broken handle behind the plant next to the teapot cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Symon Holl**
> "“Some even call him an alcoholic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[39]`
  - -> `[43]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Now I am worried.”"]** — Mówca: **Player**
> "“Now I am worried.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“So the man can't handle his drink. Is that it?”"]** — Mówca: **Player**
> "“So the man can't handle his drink. Is that it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“Although his premiership is riddled with these kind of incidents, I also heard that he is a shrewd man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[60]`
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Symon Holl**
> "“Regardless, I don't think we should underestimate them. They hold substantial economic power, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Pocket the broken handle."]** — Mówca: **Player_Italic**
> "I put the broken handle in my pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It should be fine. I have dealt with worse than that before.”"]** — Mówca: **Player**
> "“It should be fine. I have dealt with worse than that before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Honestly, I don't know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Wait."]** — Mówca: **Player_Italic**
> "I sat in the exquisite room and looked up at the golden chandeliers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[46]`
Mówca: **Narrator**
> "The crowds of reporters that flocked over were pushed away by the Lespian security guards. We made our way to our cars and the convoy began its short trip to the Yellow House."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“That seems to be the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
Mówca: **Narrator**
> "I went back to my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“I don't think there will be any issues either. I just wanted to give you a heads up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Inspect the teapot."]** — Mówca: **Player_Italic**
> "I started inspecting the teapot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Thanks for giving me a heads up.”"]** — Mówca: **Player**
> "“Thanks for giving me a heads up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“After this incident, some say he is unfit to serve. But I don't believe that at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[61]`

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“I wouldn't bet on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“We need to be careful. I heard that he is a shrewd man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[60]`
  - -> `[38]`

### Węzeł `[55]`
Mówca: **Narrator**
> "He handed me a newspaper. The headline was 'Circling Over Staalport'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[56]`
Mówca: **Narrator**
> "After ten minutes. there was still no sign of Prime Minister Alvarez. It was almost time for our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
Mówca: **Narrator**
> "While I was touching it, the handle broke off. I looked around. Thankfully no one was in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[42]`
  - -> `[36]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“I hope he doesn't show up drunk to our meeting too.”"]** — Mówca: **Player**
> "“I hope he doesn't show up drunk to our meeting too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Why is that?”"]** — Mówca: **Player**
> "“Why is that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Trust me. I can handle him.”"]** — Mówca: **Player**
> "“Trust me. I can handle him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“These are the Lespians people fear? Ridiculous.”"]** — Mówca: **Player**
> "“These are the Lespians people fear? Ridiculous.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[62]`
Mówca: **Narrator**
> "My chair started to feel uncomfortable. I stood up and walked around to look at the various items in the room. A beautiful golden teapot piqued my interest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[63]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "Leave it alone."]** — Mówca: **Player_Italic**
> "I admired the teapot and left it alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("ElectricTrainDeparting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("ElectricTrainDeparting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
