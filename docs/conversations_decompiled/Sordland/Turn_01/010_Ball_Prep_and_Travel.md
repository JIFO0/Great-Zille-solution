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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“I won't let your family down, Serge.”"** | `[4]` **Serge Wolkner**: "“You know... my entire family vo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Serge Wolkner**: "“I don't doubt that, sir. You ar..." |
| `[6]` | **"“I'm nervous myself, Franc. But I'd feel a lot more confident with my son by my si..."** | `[97]` **Franc**: "“Dad, do I really have to go? Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "Franc smiled reluctantly." |
| `[7]` | **"“Thank you and your family. I am here with all of your support.”"** | `[4]` **Serge Wolkner**: "“You know... my entire family vo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Serge Wolkner**: "“No reason to thank me, sir. You..." |
| `[15]` | **"“Good to know, Serge.""** | `[4]` **Serge Wolkner**: "“You know... my entire family vo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Serge opened the door for me. Th..." |
| `[19]` | **"“I did, Serge. Thank you.”"** | `[30]` **Serge Wolkner**: "“We are here, sir. Hope you enjo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Serge Wolkner**: "“Always a pleasure to hear that.”" |
| `[20]` | **"“Much appreciated. How are you today?”"** | `[30]` **Serge Wolkner**: "“We are here, sir. Hope you enjo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Serge Wolkner**: "“I am just as good as I can be. ..." |
| `[26]` | **"Nod."** | `[30]` **Serge Wolkner**: "“We are here, sir. Hope you enjo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Serge opened the door for me. Th..." |
| `[29]` | **"“These people are our friends, Deana.”"** | `[79]` **Narrator**: "She pointed at the Presidential ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Monica**: "“It's all right, baby. They're h..." |
| `[34]` | **"Stroke her hair."** | `[14]` **Deana**: "“Papa! Mama told me it’s time to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: ""Someday I'll have to pry the bo..."<br>`[103]` **Player**: ""You could be president yourself..." |
| `[35]` | **"“Tell your mother I will be ready very soon.”"** | `[14]` **Deana**: "“Papa! Mama told me it’s time to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Deana**: "“Okay, Papa. I can't wait to see..." |
| `[36]` | **"“Hello, darling, I am ready. Where is your brother?”"** | `[14]` **Deana**: "“Papa! Mama told me it’s time to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Deana**: "“I think Franc is still upstairs.”" |
| `[39]` | **"“Let's just enjoy the night.”"** | `[47]` **Monica**: ""I know you will, honey.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "After what seemed like just a fe..." |
| `[40]` | **"“Monica, Franc, enough fussing around! Let's get a move on!”"** | `[54]` **Narrator**: "It was almost time to leave. The..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[73]` **Narrator**: "Monica came down the stairs." |
| `[41]` | **"“This means a great deal to me.”"** | `[47]` **Monica**: ""I know you will, honey.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "After what seemed like just a fe..." |
| `[43]` | **"Stay silent."** | `[47]` **Monica**: ""I know you will, honey.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "After what seemed like just a fe..." |
| `[44]` | **"“Darling! Franc! It’s time.”"** | `[54]` **Narrator**: "It was almost time to leave. The..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Narrator**: "Monica came down the stairs." |
| `[45]` | **"“We'll see, darling.”"** | `[47]` **Monica**: ""I know you will, honey.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "After what seemed like just a fe..." |
| `[48]` | **"“Now, where's my First Lady?”"** | `[54]` **Narrator**: "It was almost time to leave. The..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[73]` **Narrator**: "Monica came down the stairs." |
| `[50]` | **"“Good. Let's go.”"** | `[22]` **Franc**: "“I'm here now, aren't I?”"<br>`[3]` **Narrator**: "Serge opened the door for me. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Deana**: "“Papa, are these people going to..." |
| `[53]` | **"“I'm not joking, son.”"** | `[22]` **Franc**: "“I'm here now, aren't I?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "Franc looked at the floor sullenly." |
| `[60]` | **""With all that's been happening, I'm wondering if I made the right choice.""** | `[66]` **Monica**: "“Anton, what are you thinking ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Monica**: "“I know you have a lot on your m..." |
| `[61]` | **"“I was thinking that we've come a long way together, haven't we?”"** | `[66]` **Monica**: "“Anton, what are you thinking ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Monica**: "“Yes, we have. And there's still..." |
| `[62]` | **"“Nothing. Nice car, isn't it?”"** | `[66]` **Monica**: "“Anton, what are you thinking ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Monica**: "“I know you have a lot on your m..." |
| `[63]` | **"“Are you good to go, Franc?”"** | `[42]` **Narrator**: "Franc tugged at the collar of hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Franc**: "“Yes. The sooner we go, the soon..." |
| `[68]` | **"“I'm glad to have you with us for this big night.”"** | `[42]` **Narrator**: "Franc tugged at the collar of hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Franc**: "“Sure, Dad. I'm just dying to go.”" |
| `[69]` | **"“Monica, my love, you look as gorgeous as the day we married.”"** | `[99]` **Player_Italic**: "She extended a gloved hand, and ..."<br>`[100]` **Player_Italic**: "I pulled her into a deep embrace."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Monica**: "“Now, there's that charm that go..." |
| `[74]` | **"“How do I look?”"** | `[99]` **Player_Italic**: "She extended a gloved hand, and ..."<br>`[100]` **Player_Italic**: "I pulled her into a deep embrace."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Monica**: ""Like the 4th President of Sordl..." |
| `[75]` | **"“Unfortunately, yes. They can't leave our side until my term ends. You'll get used..."** | `[79]` **Narrator**: "She pointed at the Presidential ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Monica**: "“It's all right, baby. They're h..." |
| `[77]` | **"“Yes. Sordland's most important family needs extra protection!”"** | `[79]` **Narrator**: "She pointed at the Presidential ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Monica**: "“It's all right, baby. They're h..." |
| `[82]` | **"“Don't make me wait again.”"** | `[42]` **Narrator**: "Franc tugged at the collar of hi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[22]` **Franc**: "“I'm here now, aren't I?”" |
| `[83]` | **"“You'll love it, son. I'm sure there'll be plenty of pretty girls to dance with...”"** | `[97]` **Franc**: "“Dad, do I really have to go? Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Franc**: "“If there's even time in between..." |
| `[89]` | **"“Don't make me angry, Franc.""** | `[97]` **Franc**: "“Dad, do I really have to go? Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Franc fell silent for a short wh..." |
| `[96]` | **"“Now where the hell is Franc? FRANC!""** | `[99]` **Player_Italic**: "She extended a gloved hand, and ..."<br>`[100]` **Player_Italic**: "I pulled her into a deep embrace."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "Franc rushed down the stairs." |
| `[98]` | **"“It's a party thrown for me! Don't you want to support your father?”"** | `[97]` **Franc**: "“Dad, do I really have to go? Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Franc**: "“A party for squares. Who will I..." |
| `[99]` | **"Kiss her hand."** | `[78]` **Monica**: "“How do you do, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Player**: "“Now where the hell is Franc? FR..."<br>`[69]` **Player**: "“Monica, my love, you look as go..."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **"Embrace her."** | `[78]` **Monica**: "“How do you do, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Player**: "“Now where the hell is Franc? FR..."<br>`[69]` **Player**: "“Monica, my love, you look as go..."<br>*(oraz 1 innych odgałęzień)* |
| `[101]` | **"Just stand there and look at her."** | `[78]` **Monica**: "“How do you do, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Player**: "“Now where the hell is Franc? FR..."<br>`[69]` **Player**: "“Monica, my love, you look as go..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **""Someday I'll have to pry the boys away from you.""** | `[34]` **Player_Italic**: "I stroked her hair." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Deana**: "“Papa, don't be gross!"" |
| `[103]` | **""You could be president yourself someday, you know that?""** | `[34]` **Player_Italic**: "I stroked her hair." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Deana**: "“Only when I'm old like you!"" |

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
  - -> `[12]` (*Narrator: "Suddenly Deana hugged me from behind, startling me a litt..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“Good. Let's go.”"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Serge opened the door for me. The normally imposing palace was festooned with garish banners that nearly made it look cheerful. A line of shiny luxury sedans stretched around it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
Mówca: **Serge Wolkner**
> "“You know... my entire family voted for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“Good to know, Serge.""*)
  - -> `[7]` (*Player: "“Thank you and your family. I am here with all of your su..."*)
  - -> `[5]` (*Player: "“I won't let your family down, Serge.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“I won't let your family down, Serge.”"]** — Mówca: **Player**
> "“I won't let your family down, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Serge Wolkner: "“I don't doubt that, sir. You are the one who sparked a g..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“I'm nervous myself, Franc. But I'd feel a lot more confident with my son by my side.“"]** — Mówca: **Player**
> "“I'm nervous myself, Franc. But I'd feel a lot more confident with my son by my side.“"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Franc smiled reluctantly."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Thank you and your family. I am here with all of your support.”"]** — Mówca: **Player**
> "“Thank you and your family. I am here with all of your support.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Serge Wolkner: "“No reason to thank me, sir. You are the one who sparked ..."*)

### Węzeł `[8]`
Mówca: **Monica**
> "“It's all right, baby. They're here to make sure nothing bad happens to your papa -- or his family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Monica held Deana's hand. Together, flanked by the guards..."*)

### Węzeł `[9]`
Mówca: **Serge Wolkner**
> "“No reason to thank me, sir. You are the one who sparked a glimmer of hope in us all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Serge opened the door for me. The normally imposing palac..."*)

### Węzeł `[10]`
Mówca: **Serge Wolkner**
> "“I don't doubt that, sir. You are the one who sparked a glimmer of hope in us all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Serge opened the door for me. The normally imposing palac..."*)

### Węzeł `[11]`
Mówca: **Monica**
> "“Got that over with, Franc? Let's go. The car is waiting for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The Presidential Guard showed us the way as red and blue ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Suddenly Deana hugged me from behind, startling me a little. Monica had fixed her hair into an elaborate braid, woven through with ribbons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deana: "“Papa! Mama told me it’s time to go!”"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "All those years, she had stayed by my side. Now, we were about to begin the most challenging chapter in our lives yet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: "“How do you do, Mr. President.”"*)

### Węzeł `[14]`
Mówca: **Deana**
> "“Papa! Mama told me it’s time to go!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“Hello, darling, I am ready. Where is your brother?”"*)
  - -> `[35]` (*Player: "“Tell your mother I will be ready very soon.”"*)
  - -> `[34]` (*Player_Italic: "Stroke her hair."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Good to know, Serge.""]** — Mówca: **Player**
> "“Good to know, Serge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Serge opened the door for me. The normally imposing palac..."*)

### Węzeł `[16]`
Mówca: **Franc**
> "“Sure, Dad. I'm just dying to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[17]`
Mówca: **Franc**
> "“If there's even time in between all the boring speeches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Franc: "“But I guess I have no choice.""*)

### Węzeł `[18]`
Mówca: **Narrator**
> "She shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "It was almost time to leave. The big ball was starting in..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“I did, Serge. Thank you.”"]** — Mówca: **Player**
> "“I did, Serge. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Serge Wolkner: "“Always a pleasure to hear that.”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Much appreciated. How are you today?”"]** — Mówca: **Player**
> "“Much appreciated. How are you today, Serge?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Serge Wolkner: "“I am just as good as I can be. But today is your day, si..."*)

### Węzeł `[21]`
Mówca: **Serge Wolkner**
> "“Always a pleasure to hear that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Serge opened the door for me. The normally imposing palac..."*)

### Węzeł `[22]`
Mówca: **Franc**
> "“I'm here now, aren't I?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“Good. Let's go.”"*)
  - -> `[53]` (*Player: "“I'm not joking, son.”"*)

### Węzeł `[23]`
Mówca: **Serge Wolkner**
> "“I am just as good as I can be. But today is your day, sir. I'm glad you are in charge now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Serge Wolkner: "“You know... my entire family voted for you.”"*)

### Węzeł `[24]`
Mówca: **Franc**
> "“Yes. The sooner we go, the sooner it'll be over, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deana: "“Papa, are these people going to be around us from now on?”"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deana: "“Papa, are these people going to be around us from now on?”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Serge opened the door for me. The normally imposing palac..."*)

### Węzeł `[27]`
Mówca: **Deana**
> "“Papa, don't be gross!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "She giggled."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Franc trudged down the stairs."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“These people are our friends, Deana.”"]** — Mówca: **Player**
> "“These people are our friends, Deana.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Monica: "“It's all right, baby. They're here to make sure nothing ..."*)

### Węzeł `[30]`
Mówca: **Serge Wolkner**
> "“We are here, sir. Hope you enjoyed the drive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“I did, Serge. Thank you.”"*)
  - -> `[20]` (*Player: "“Much appreciated. How are you today?”"*)
  - -> `[26]` (*Player_Italic: "Nod."*)

### Węzeł `[31]`
Mówca: **Deana**
> "“I think Franc is still upstairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "She shrugged."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Serge rolled down the limousine's soundproof partition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Serge Wolkner: "“We are here, sir. Hope you enjoyed the drive.”"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "After what seemed like just a few minutes, the convoy slowed to a halt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Serge rolled down the limousine's soundproof partition."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "Stroke her hair."]** — Mówca: **Player_Italic**
> "I stroked her hair."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""Someday I'll have to pry the boys away from you.""*)
  - -> `[103]` (*Player: ""You could be president yourself someday, you know that?""*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Tell your mother I will be ready very soon.”"]** — Mówca: **Player**
> "“Tell your mother I will be ready very soon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deana: "“Okay, Papa. I can't wait to see the Palace!""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Hello, darling, I am ready. Where is your brother?”"]** — Mówca: **Player**
> "“Hello, darling, I am ready. Where is your brother?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deana: "“I think Franc is still upstairs.”"*)

### Węzeł `[37]`
Mówca: **Franc**
> "“This thing itches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Franc tugged at the collar of his new tuxedo. He seemed i..."*)

### Węzeł `[38]`
Mówca: **Deana**
> "“Papa, are these people going to be around us from now on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "She pointed at the Presidential Guards at the door of the..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Let's just enjoy the night.”"]** — Mówca: **Player**
> "“Let's just enjoy the night.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After what seemed like just a few minutes, the convoy slo..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Monica, Franc, enough fussing around! Let's get a move on!”"]** — Mówca: **Player**
> "“Monica, Franc, enough fussing around! Let's get a move on!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1; BaseGame.Relation..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“This means a great deal to me.”"]** — Mówca: **Player**
> "“This means a great deal to me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After what seemed like just a few minutes, the convoy slo..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Franc tugged at the collar of his new tuxedo. He seemed ill at ease."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“Are you good to go, Franc?”"*)
  - -> `[68]` (*Player: "“I'm glad to have you with us for this big night.”"*)
  - -> `[82]` (*Player: "“Don't make me wait again.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "You stayed silent and kept looking out of the window."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After what seemed like just a few minutes, the convoy slo..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Darling! Franc! It’s time.”"]** — Mówca: **Player**
> "“Darling! Franc! It’s time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Monica came down the stairs."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We'll see, darling.”"]** — Mówca: **Player**
> "“We'll see, darling.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After what seemed like just a few minutes, the convoy slo..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Franc looked at the floor sullenly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[47]`
Mówca: **Monica**
> ""I know you will, honey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“We'll see, darling.”"*)
  - -> `[41]` (*Player: "“This means a great deal to me.”"*)
  - -> `[39]` (*Player: "“Let's just enjoy the night.”"*)
  - -> `[43]` (*Player_Italic: "Stay silent."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Now, where's my First Lady?”"]** — Mówca: **Player**
> "“Now, where's my First Lady?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Franc rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Monica: ""I know you will, honey.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Good. Let's go.”"]** — Mówca: **Player**
> "“Good. Let's go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Franc), `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deana: "“Papa, are these people going to be around us from now on?”"*)

### Węzeł `[51]`
Mówca: **Deana**
> "“I'm going to help Papa fix everything!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Franc rolled his eyes."*)

### Węzeł `[52]`
Mówca: **Monica**
> ""Just remember, no matter what happens, the children and I will always be here for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Deana: "“I'm going to help Papa fix everything!”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I'm not joking, son.”"]** — Mówca: **Player**
> "“I'm not joking, son.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Franc looked at the floor sullenly."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "It was almost time to leave. The big ball was starting in less than an hour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "“Now, where's my First Lady?”"*)
  - -> `[44]` (*Player: "“Darling! Franc! It’s time.”"*)
  - -> `[40]` (*Player: "“Monica, Franc, enough fussing around! Let's get a move on!”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Monica: ""Just remember, no matter what happens, the children and ..."*)

### Węzeł `[56]`
Mówca: **Deana**
> "“Okay, Papa. I can't wait to see the Palace!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "It was almost time to leave. The big ball was starting in..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "She giggled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "It was almost time to leave. The big ball was starting in..."*)

### Węzeł `[58]`
Mówca: **Monica**
> "“I know you have a lot on your mind. But you deserve to relax tonight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Monica: ""Just remember, no matter what happens, the children and ..."*)

### Węzeł `[59]`
Mówca: **Monica**
> "“Yes, we have. And there's still so much that we'll accomplish, side by side.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""With all that's been happening, I'm wondering if I made the right choice.""]** — Mówca: **Player**
> ""With all that's been happening, I'm wondering if I made the right choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Monica: "“I know you have a lot on your mind. But you deserve to r..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“I was thinking that we've come a long way together, haven't we?”"]** — Mówca: **Player**
> "“I was thinking that we've come a long way together, haven't we?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Monica: "“Yes, we have. And there's still so much that we'll accom..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Nothing. Nice car, isn't it?”"]** — Mówca: **Player**
> "“Nothing. Nice car, isn't it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Monica: "“I know you have a lot on your mind. But you deserve to r..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Are you good to go, Franc?”"]** — Mówca: **Player**
> "“Are you good to go, Franc?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Franc: "“Yes. The sooner we go, the sooner it'll be over, right?”"*)

### Węzeł `[64]`
Mówca: **Franc**
> "“I'm here! I'm here!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Franc tugged at the collar of his new tuxedo. He seemed i..."*)

### Węzeł `[65]`
Mówca: **Franc**
> "“A party for squares. Who will I even talk to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Monica: "“Come on, Franc, we've been through this.""*)

### Węzeł `[66]`
Mówca: **Monica**
> "“Anton, what are you thinking about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Nothing. Nice car, isn't it?”"*)
  - -> `[60]` (*Player: ""With all that's been happening, I'm wondering if I made ..."*)
  - -> `[61]` (*Player: "“I was thinking that we've come a long way together, have..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Halfway to the car, Franc stopped abruptly and turned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Franc: "“Dad, do I really have to go? Couldn't I stay home instead?""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I'm glad to have you with us for this big night.”"]** — Mówca: **Player**
> "“I'm glad to have you with us for this big night.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Franc: "“Sure, Dad. I'm just dying to go.”"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Monica, my love, you look as gorgeous as the day we married.”"]** — Mówca: **Player**
> "“Monica, my love, you look as gorgeous as the day we married.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Player_Italic), `[100]` (Player_Italic), `[101]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Monica: "“Now, there's that charm that got you elected.”"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "The motorcade started moving towards the palace. I gazed out the window, deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Monica: "“Anton, what are you thinking about?”"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "She was wearing a simple yet elegant beige sheath dress and short heels. Her hair had been neatly pinned into a chignon, showing off the pearl earrings I had given her for our 15th anniversary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "All those years, she had stayed by my side. Now, we were ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The Presidential Guard showed us the way as red and blue lights flashed around us. Serge, my driver, ushered us into our armored limousine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The motorcade started moving towards the palace. I gazed ..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Monica came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "She was wearing a simple yet elegant beige sheath dress a..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“How do I look?”"]** — Mówca: **Player**
> "“How do I look?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Player_Italic), `[100]` (Player_Italic), `[101]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: ""Like the 4th President of Sordland.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Unfortunately, yes. They can't leave our side until my term ends. You'll get used to it.”"]** — Mówca: **Player**
> "“Unfortunately, yes. They can't leave our side until my term ends. You'll get used to it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Monica: "“It's all right, baby. They're here to make sure nothing ..."*)

### Węzeł `[76]`
Mówca: **Monica**
> "“Now, there's that charm that got you elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 2"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Yes. Sordland's most important family needs extra protection!”"]** — Mówca: **Player**
> "“Yes. Sordland's most important family needs extra protection!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Monica: "“It's all right, baby. They're here to make sure nothing ..."*)

### Węzeł `[78]`
Mówca: **Monica**
> "“How do you do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Italic: "Kiss her hand."*)
  - -> `[100]` (*Player_Italic: "Embrace her."*)
  - -> `[101]` (*Player_Italic: "Just stand there and look at her."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "She pointed at the Presidential Guards at the door of the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“Yes. Sordland's most important family needs extra protec..."*)
  - -> `[75]` (*Player: "“Unfortunately, yes. They can't leave our side until my t..."*)
  - -> `[29]` (*Player: "“These people are our friends, Deana.”"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Franc fell silent for a short while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Franc: "“Fine. I'm sorry...""*)

### Węzeł `[81]`
Mówca: **Franc**
> "“Fine. I'm sorry...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 2"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Don't make me wait again.”"]** — Mówca: **Player**
> "“Don't make me wait again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“You'll love it, son. I'm sure there'll be plenty of pretty girls to dance with...”"]** — Mówca: **Player**
> "“You'll love it, son. I'm sure there'll be plenty of pretty girls to dance with...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Franc: "“If there's even time in between all the boring speeches.""*)

### Węzeł `[84]`
Mówca: **Monica**
> "“Come on, Franc, we've been through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Franc: "“Yeah, I know. I'm sorry. Just wanted to try my luck.""*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Franc trudged down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Franc: "“This thing itches.""*)

### Węzeł `[86]`
Mówca: **Franc**
> "“Yeah, I know. I'm sorry. Just wanted to try my luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Monica: "“Got that over with, Franc? Let's go. The car is waiting ..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Monica held Deana's hand. Together, flanked by the guards, we walked out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Halfway to the car, Franc stopped abruptly and turned tow..."*)

### Węzeł `[88]`
Mówca: **Franc**
> "“But I guess I have no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Monica: "“Got that over with, Franc? Let's go. The car is waiting ..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Don't make me angry, Franc.""]** — Mówca: **Player**
> "“Don't make me angry, Franc.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Franc fell silent for a short while."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Monica: "“Got that over with, Franc? Let's go. The car is waiting ..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The Presidential Guard showed us the way as red and blue ..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Franc smiled reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Franc: "“Well when you put it like that...sure. Let's go.""*)

### Węzeł `[93]`
Mówca: **Franc**
> "“Well when you put it like that...sure. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Franc rushed down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1; BaseGame.Relation..."*)

### Węzeł `[95]`
Mówca: **Monica**
> ""Like the 4th President of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Franc trudged down the stairs."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Now where the hell is Franc? FRANC!""]** — Mówca: **Player**
> "“Now where the hell is Franc? FRANC!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Player_Italic), `[100]` (Player_Italic), `[101]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Franc rushed down the stairs."*)

### Węzeł `[97]`
Mówca: **Franc**
> "“Dad, do I really have to go? Couldn't I stay home instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“I'm nervous myself, Franc. But I'd feel a lot more confi..."*)
  - -> `[98]` (*Player: "“It's a party thrown for me! Don't you want to support yo..."*)
  - -> `[83]` (*Player: "“You'll love it, son. I'm sure there'll be plenty of pret..."*)
  - -> `[89]` (*Player: "“Don't make me angry, Franc.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“It's a party thrown for me! Don't you want to support your father?”"]** — Mówca: **Player**
> "“It's a party thrown for me! Don't you want to support your father?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Franc: "“A party for squares. Who will I even talk to?""*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "Kiss her hand."]** — Mówca: **Player_Italic**
> "She extended a gloved hand, and I raised it to my lips."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“Now where the hell is Franc? FRANC!""*)
  - -> `[69]` (*Player: "“Monica, my love, you look as gorgeous as the day we marr..."*)
  - -> `[74]` (*Player: "“How do I look?”"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "Embrace her."]** — Mówca: **Player_Italic**
> "I pulled her into a deep embrace."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“Now where the hell is Franc? FRANC!""*)
  - -> `[69]` (*Player: "“Monica, my love, you look as gorgeous as the day we marr..."*)
  - -> `[74]` (*Player: "“How do I look?”"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "Just stand there and look at her."]** — Mówca: **Player_Italic**
> "I stood there and looked my wife up and down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“Now where the hell is Franc? FRANC!""*)
  - -> `[69]` (*Player: "“Monica, my love, you look as gorgeous as the day we marr..."*)
  - -> `[74]` (*Player: "“How do I look?”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Someday I'll have to pry the boys away from you.""]** — Mówca: **Player**
> ""Someday I'll have to pry the boys away from you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Deana: "“Papa, don't be gross!""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""You could be president yourself someday, you know that?""]** — Mówca: **Player**
> ""You could be president yourself someday, you know that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Deana: "“Only when I'm old like you!""*)

### Węzeł `[104]`
Mówca: **Deana**
> "“Only when I'm old like you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "She giggled."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Franc: "“I'm here now, aren't I?”"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deana: "“Papa, are these people going to be around us from now on?”"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1;
BaseGame.Relations_Franc_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;
Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Monica came down the stairs."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Monica came down the stairs."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1;
BaseGame.Relations_Franc_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;
Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Franc: "“I'm here! I'm here!""*)
