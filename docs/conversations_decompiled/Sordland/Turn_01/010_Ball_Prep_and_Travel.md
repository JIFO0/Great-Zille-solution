# Sordland/Turn01/Ball Prep and Travel

- **ID konwersacji:** `10`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/010_Ball_Prep_and_Travel.md`
- **Liczba węzłów dialogowych:** 110
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[9] Sordland/Turn01/Personal_Ball** (../Turn_01/009_Personal_Ball.md), Węzeł `[50]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 10

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[25]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- Węzeł `[55]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- Węzeł `[90]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- Węzeł `[91]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- Węzeł `[105]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- Węzeł `[106]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- Węzeł `[107]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1...`
- *...oraz 2 innych węzłów ze skryptami.*

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
  - -> `[12]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `9` (*Sordland/Turn01/Personal_Ball*), Węzeł `[50]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Serge opened the door for me. The normally imposing palace was festooned with garish banners that nearly made it look cheerful. A line of shiny luxury sedans stretched around it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
Mówca: **Serge Wolkner**
> "“You know... my entire family voted for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[7]`
  - -> `[5]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“I won't let your family down, Serge.”"]** — Mówca: **Player**
> "“I won't let your family down, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“I'm nervous myself, Franc. But I'd feel a lot more confident with my son by my side.“"]** — Mówca: **Player**
> "“I'm nervous myself, Franc. But I'd feel a lot more confident with my son by my side.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Thank you and your family. I am here with all of your support.”"]** — Mówca: **Player**
> "“Thank you and your family. I am here with all of your support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Monica**
> "“It's all right, baby. They're here to make sure nothing bad happens to your papa -- or his family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[9]`
Mówca: **Serge Wolkner**
> "“No reason to thank me, sir. You are the one who sparked a glimmer of hope in us all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[10]`
Mówca: **Serge Wolkner**
> "“I don't doubt that, sir. You are the one who sparked a glimmer of hope in us all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[11]`
Mówca: **Monica**
> "“Got that over with, Franc? Let's go. The car is waiting for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Suddenly Deana hugged me from behind, startling me a little. Monica had fixed her hair into an elaborate braid, woven through with ribbons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Narrator**
> "All those years, she had stayed by my side. Now, we were about to begin the most challenging chapter in our lives yet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[14]`
Mówca: **Deana**
> "“Papa! Mama told me it’s time to go!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[35]`
  - -> `[34]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Good to know, Serge.""]** — Mówca: **Player**
> "“Good to know, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[16]`
Mówca: **Franc**
> "“Sure, Dad. I'm just dying to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[17]`
Mówca: **Franc**
> "“If there's even time in between all the boring speeches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[18]`
Mówca: **Narrator**
> "She shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“I did, Serge. Thank you.”"]** — Mówca: **Player**
> "“I did, Serge. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Much appreciated. How are you today?”"]** — Mówca: **Player**
> "“Much appreciated. How are you today, Serge?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Serge Wolkner**
> "“Always a pleasure to hear that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[22]`
Mówca: **Franc**
> "“I'm here now, aren't I?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[53]`

### Węzeł `[23]`
Mówca: **Serge Wolkner**
> "“I am just as good as I can be. But today is your day, sir. I'm glad you are in charge now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[24]`
Mówca: **Franc**
> "“Yes. The sooner we go, the sooner it'll be over, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[27]`
Mówca: **Deana**
> "“Papa, don't be gross!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“These people are our friends, Deana.”"]** — Mówca: **Player**
> "“These people are our friends, Deana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[30]`
Mówca: **Serge Wolkner**
> "“We are here, sir. Hope you enjoyed the drive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[26]`

### Węzeł `[31]`
Mówca: **Deana**
> "“I think Franc is still upstairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Serge rolled down the limousine's soundproof partition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[33]`
Mówca: **Narrator**
> "After what seemed like just a few minutes, the convoy slowed to a halt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "Stroke her hair."]** — Mówca: **Player_Italic**
> "I stroked her hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Tell your mother I will be ready very soon.”"]** — Mówca: **Player**
> "“Tell your mother I will be ready very soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Hello, darling, I am ready. Where is your brother?”"]** — Mówca: **Player**
> "“Hello, darling, I am ready. Where is your brother?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[37]`
Mówca: **Franc**
> "“This thing itches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
Mówca: **Deana**
> "“Papa, are these people going to be around us from now on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Let's just enjoy the night.”"]** — Mówca: **Player**
> "“Let's just enjoy the night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Monica, Franc, enough fussing around! Let's get a move on!”"]** — Mówca: **Player**
> "“Monica, Franc, enough fussing around! Let's get a move on!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“This means a great deal to me.”"]** — Mówca: **Player**
> "“This means a great deal to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[42]`
Mówca: **Narrator**
> "Franc tugged at the collar of his new tuxedo. He seemed ill at ease."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[68]`
  - -> `[82]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "You stayed silent and kept looking out of the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Darling! Franc! It’s time.”"]** — Mówca: **Player**
> "“Darling! Franc! It’s time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We'll see, darling.”"]** — Mówca: **Player**
> "“We'll see, darling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Franc looked at the floor sullenly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[47]`
Mówca: **Monica**
> ""I know you will, honey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[41]`
  - -> `[39]`
  - -> `[43]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Now, where's my First Lady?”"]** — Mówca: **Player**
> "“Now, where's my First Lady?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Franc rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Good. Let's go.”"]** — Mówca: **Player**
> "“Good. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[51]`
Mówca: **Deana**
> "“I'm going to help Papa fix everything!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Monica**
> ""Just remember, no matter what happens, the children and I will always be here for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I'm not joking, son.”"]** — Mówca: **Player**
> "“I'm not joking, son.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[54]`
Mówca: **Narrator**
> "It was almost time to leave. The big ball was starting in less than an hour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[44]`
  - -> `[40]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[56]`
Mówca: **Deana**
> "“Okay, Papa. I can't wait to see the Palace!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
Mówca: **Narrator**
> "She giggled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[58]`
Mówca: **Monica**
> "“I know you have a lot on your mind. But you deserve to relax tonight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[59]`
Mówca: **Monica**
> "“Yes, we have. And there's still so much that we'll accomplish, side by side.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""With all that's been happening, I'm wondering if I made the right choice.""]** — Mówca: **Player**
> ""With all that's been happening, I'm wondering if I made the right choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“I was thinking that we've come a long way together, haven't we?”"]** — Mówca: **Player**
> "“I was thinking that we've come a long way together, haven't we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Nothing. Nice car, isn't it?”"]** — Mówca: **Player**
> "“Nothing. Nice car, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Are you good to go, Franc?”"]** — Mówca: **Player**
> "“Are you good to go, Franc?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[64]`
Mówca: **Franc**
> "“I'm here! I'm here!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[65]`
Mówca: **Franc**
> "“A party for squares. Who will I even talk to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[66]`
Mówca: **Monica**
> "“Anton, what are you thinking about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Halfway to the car, Franc stopped abruptly and turned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I'm glad to have you with us for this big night.”"]** — Mówca: **Player**
> "“I'm glad to have you with us for this big night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Monica, my love, you look as gorgeous as the day we married.”"]** — Mówca: **Player**
> "“Monica, my love, you look as gorgeous as the day we married.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[70]`
Mówca: **Narrator**
> "The motorcade started moving towards the palace. I gazed out the window, deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[71]`
Mówca: **Narrator**
> "She was wearing a simple yet elegant beige sheath dress and short heels. Her hair had been neatly pinned into a chignon, showing off the pearl earrings I had given her for our 15th anniversary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[72]`
Mówca: **Narrator**
> "The Presidential Guard showed us the way as red and blue lights flashed around us. Serge, my driver, ushered us into our armored limousine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Monica came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“How do I look?”"]** — Mówca: **Player**
> "“How do I look?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Unfortunately, yes. They can't leave our side until my term ends. You'll get used to it.”"]** — Mówca: **Player**
> "“Unfortunately, yes. They can't leave our side until my term ends. You'll get used to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[76]`
Mówca: **Monica**
> "“Now, there's that charm that got you elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Yes. Sordland's most important family needs extra protection!”"]** — Mówca: **Player**
> "“Yes. Sordland's most important family needs extra protection!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[78]`
Mówca: **Monica**
> "“How do you do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[79]`
Mówca: **Narrator**
> "She pointed at the Presidential Guards at the door of the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[75]`
  - -> `[29]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Franc fell silent for a short while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Franc**
> "“Fine. I'm sorry...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Don't make me wait again.”"]** — Mówca: **Player**
> "“Don't make me wait again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“You'll love it, son. I'm sure there'll be plenty of pretty girls to dance with...”"]** — Mówca: **Player**
> "“You'll love it, son. I'm sure there'll be plenty of pretty girls to dance with...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[84]`
Mówca: **Monica**
> "“Come on, Franc, we've been through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Franc trudged down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[86]`
Mówca: **Franc**
> "“Yeah, I know. I'm sorry. Just wanted to try my luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Monica held Deana's hand. Together, flanked by the guards, we walked out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[88]`
Mówca: **Franc**
> "“But I guess I have no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Don't make me angry, Franc.""]** — Mówca: **Player**
> "“Don't make me angry, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Franc smiled reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Franc**
> "“Well when you put it like that...sure. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Franc rushed down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[95]`
Mówca: **Monica**
> ""Like the 4th President of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Now where the hell is Franc? FRANC!""]** — Mówca: **Player**
> "“Now where the hell is Franc? FRANC!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Franc**
> "“Dad, do I really have to go? Couldn't I stay home instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[98]`
  - -> `[83]`
  - -> `[89]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“It's a party thrown for me! Don't you want to support your father?”"]** — Mówca: **Player**
> "“It's a party thrown for me! Don't you want to support your father?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "Kiss her hand."]** — Mówca: **Player_Italic**
> "She extended a gloved hand, and I raised it to my lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[69]`
  - -> `[74]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "Embrace her."]** — Mówca: **Player_Italic**
> "I pulled her into a deep embrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[69]`
  - -> `[74]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "Just stand there and look at her."]** — Mówca: **Player_Italic**
> "I stood there and looked my wife up and down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[69]`
  - -> `[74]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Someday I'll have to pry the boys away from you.""]** — Mówca: **Player**
> ""Someday I'll have to pry the boys away from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""You could be president yourself someday, you know that?""]** — Mówca: **Player**
> ""You could be president yourself someday, you know that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Deana**
> "“Only when I'm old like you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1;
BaseGame.Relations_Franc_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;
Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1;
BaseGame.Relations_Franc_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;
Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
