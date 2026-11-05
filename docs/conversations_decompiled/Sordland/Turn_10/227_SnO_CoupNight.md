# Sordland/Turn10/SnO_CoupNight

- **ID konwersacji:** `227`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/227_SnO_CoupNight.md`
- **Liczba węzłów dialogowych:** 212
- **Liczba wyborów gracza:** 30

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[42]** Valken Kruger
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Security_Unrest_Military`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGameSupport.Journal_Turn10_Coup_Iosef`
- `BaseGameSupport.Journal_Turn10_Coup_Valken`
- `GameCondition.Turn10_SnO_CoupNight`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“All right, all right. I'm coming.”"** | `[15]` **Narrator**: "I started walking downstairs. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Another knock. This time, even l..." |
| `[16]` | **"Keep walking towards the door."** | `[15]` **Narrator**: "I started walking downstairs. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Another knock. This time, even l..." |
| `[18]` | **"Open the door."** | `[6]` **Iosef Lancea**: "“We need to talk, Mr. President...."<br>`[17]` **Narrator**: "Another knock. This time, even l..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I was met with 20 to 30 men wait..." |
| `[19]` | **"Look through the peephole."** | `[17]` **Narrator**: "Another knock. This time, even l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "I could see Iosef standing outsi..."<br>`[24]` **Narrator**: "I could see General Valken Kruge..." |
| `[25]` | **"“What is going on? Why are you here at this hour? I won't open the door unless you..."** | `[23]` **Narrator**: "I could see Iosef standing outsi..."<br>`[24]` **Narrator**: "I could see General Valken Kruge..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Iosef Lancea**: "“We need to talk, Mr. President...."<br>`[26]` **Valken Kruger**: "“We need to talk, Mr. President...." |
| `[30]` | **"“Tell me what it's about first.”"** | `[6]` **Iosef Lancea**: "“We need to talk, Mr. President...."<br>`[26]` **Valken Kruger**: "“We need to talk, Mr. President...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Iosef Lancea**: "“Do it.”"<br>`[31]` **Valken Kruger**: "“Do it.”" |
| `[41]` | **"“Monica. Take Deana and hide somewhere.”"** | `[40]` **Monica**: "“Anton! What is going on?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "Another thud and the door was cr..." |
| `[42]` | **"“We have to run. Now.”"** | `[40]` **Monica**: "“Anton! What is going on?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "Another thud and the door was cr..." |
| `[43]` | **"“It's okay. I'll handle this.”"** | `[40]` **Monica**: "“Anton! What is going on?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "Another thud and the door was cr..." |
| `[47]` | **"“What the hell is the meaning of this?”"** | `[46]` **Narrator**: "As I opened the door wider, they..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "No one replied. Instead, the sol..."<br>`[53]` **Narrator**: "No one replied. Instead, the sol..." |
| `[48]` | **"“Explain yourselves! Immediately!”"** | `[46]` **Narrator**: "As I opened the door wider, they..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "No one replied. Instead, the sol..."<br>`[53]` **Narrator**: "No one replied. Instead, the sol..." |
| `[49]` | **"“You can't just barge into the house of the President! I will have you removed!”"** | `[46]` **Narrator**: "As I opened the door wider, they..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "No one replied. Instead, the sol..."<br>`[53]` **Narrator**: "No one replied. Instead, the sol..." |
| `[61]` | **"“You! How dare you?”"** | `[58]` **Narrator**: "Iosef walked in. Soldiers salute..."<br>`[59]` **Narrator**: "General Kruger walked in. Soldie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Iosef Lancea**: "“You have given us an order to p..."<br>`[68]` **Iosef Lancea**: "“I'm sorry, but your time is ove..."<br>*(oraz 2 innych odgałęzień)* |
| `[62]` | **"“You will explain to me what the hell is going on. Right now!”"** | `[58]` **Narrator**: "Iosef walked in. Soldiers salute..."<br>`[59]` **Narrator**: "General Kruger walked in. Soldie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Iosef Lancea**: "“You have given us an order to p..."<br>`[68]` **Iosef Lancea**: "“I'm sorry, but your time is ove..."<br>*(oraz 2 innych odgałęzień)* |
| `[63]` | **"“Do you think you can just get away with this?”"** | `[58]` **Narrator**: "Iosef walked in. Soldiers salute..."<br>`[59]` **Narrator**: "General Kruger walked in. Soldie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Iosef Lancea**: "“You have given us an order to p..."<br>`[68]` **Iosef Lancea**: "“I'm sorry, but your time is ove..."<br>*(oraz 2 innych odgałęzień)* |
| `[73]` | **"“You can take me, but please, don't hurt my family.”"** | `[70]` **Iosef Lancea**: "“Above all else, you have commit..."<br>`[71]` **Valken Kruger**: "“Above all else, you have commit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Iosef Lancea**: ""Your wife and daughter have bee..."<br>`[90]` **Iosef Lancea**: "“Rest assured. Your family will ..."<br>*(oraz 2 innych odgałęzień)* |
| `[74]` | **"“How long have you been planning this?”"** | `[70]` **Iosef Lancea**: "“Above all else, you have commit..."<br>`[71]` **Valken Kruger**: "“Above all else, you have commit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Iosef Lancea**: "“Since the day you betrayed your..."<br>`[76]` **Valken Kruger**: "“Since the day you betrayed your..." |
| `[75]` | **"“I have done nothing wrong. Please let me go at once!”"** | `[70]` **Iosef Lancea**: "“Above all else, you have commit..."<br>`[71]` **Valken Kruger**: "“Above all else, you have commit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Iosef Lancea**: "“I'm afraid that is impossible. ..."<br>`[81]` **Valken Kruger**: "“I'm afraid that is impossible. ..." |
| `[105]` | **"“No. You can't do this! I won't let you. I am the President of Sordland!”"** | `[102]` **Iosef Lancea**: "“That includes you, Mr. President.”"<br>`[103]` **Valken Kruger**: "“That includes you, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Iosef Lancea**: "“Not anymore.”"<br>`[108]` **Valken Kruger**: "“Not anymore.”" |
| `[106]` | **"“You are destroying our democracy!”"** | `[102]` **Iosef Lancea**: "“That includes you, Mr. President.”"<br>`[103]` **Valken Kruger**: "“That includes you, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Iosef Lancea**: "“No. We are protecting our count..."<br>`[113]` **Valken Kruger**: "“No. We are protecting our count..." |
| `[107]` | **"“You will pay one day for your heinous actions! I swear on my name!”"** | `[102]` **Iosef Lancea**: "“That includes you, Mr. President.”"<br>`[103]` **Valken Kruger**: "“That includes you, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Iosef Lancea**: "“The only heinous actions in que..."<br>`[118]` **Valken Kruger**: "“The only heinous actions in que..." |
| `[137]` | **"“Everything will be fine, Monica. Take care of Deana.”"** | `[136]` **Monica**: "“Anton.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Monica**: "“No! You can't take him away! Pl..." |
| `[138]` | **"“We will get through this. I promise.”"** | `[136]` **Monica**: "“Anton.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Monica**: "“No! You can't take him away! Pl..." |
| `[139]` | **"“I'm sorry for everything.”"** | `[136]` **Monica**: "“Anton.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Monica**: "“No! You can't take him away! Pl..." |
| `[142]` | **"Resist the arrest."** | `[140]` **Narrator**: "Another soldier pulled out handc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "The soldier angrily pulled out h..." |
| `[143]` | **"Let the soldier handcuff you."** | `[140]` **Narrator**: "Another soldier pulled out handc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "He escorted me to the truck. I r..." |
| `[149]` | **"“There is no need for handcuffs. I know when I have no way out.”"** | `[140]` **Narrator**: "Another soldier pulled out handc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "The soldier stopped in his track..."<br>`[154]` **Narrator**: "The soldier stopped in his track..." |
| `[192]` | **""It's okay, Monica. I'll be fine.""** | `[191]` **Monica**: ""Anton!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Monica**: ""I just wanted to say..."" |
| `[193]` | **""I'm sorry for everything, Monica.""** | `[191]` **Monica**: ""Anton!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Monica**: ""I just wanted to say..."" |
| `[194]` | **""I love you, Monica.""** | `[191]` **Monica**: ""Anton!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Monica**: ""I just wanted to say..."" |

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
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("LoudKnockDoor");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn10_SnO_CoupNight = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn10_SnO_CoupNight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I woke up to a loud knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I managed to open my eyes and looked at the clock. It was..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“All right, all right. I'm coming.”"]** — Mówca: **Player**
> "“All right, all right. I'm coming.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Another knock. This time, even louder."*)

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“We need to talk, Mr. President. This is urgent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Open the door."*)
  - -> `[30]` (*Player: "“Tell me what it's about first.”"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I managed to open my eyes and looked at the clock. It was 11:58 PM."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Who could it be at this hour?"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Who could it be at this hour?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Huffing and puffing, I put on my slippers."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Huffing and puffing, I put on my slippers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true )"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Out of habit, I looked towards the other side of the bed...."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Out of habit, I looked towards the other side of the bed. It was empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("LouderKnockDoor");"*)

### Węzeł `[14]`
Mówca: **Narrator**
> "I looked at the other side of the bed. Monica was sleeping soundly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("LouderKnockDoor");"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I started walking downstairs. I heard another knock on the door, louder this time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“All right, all right. I'm coming.”"*)
  - -> `[16]` (*Player_Italic: "Keep walking towards the door."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Keep walking towards the door."]** — Mówca: **Player_Italic**
> "I kept walking towards the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Another knock. This time, even louder."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Another knock. This time, even louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Open the door."*)
  - -> `[19]` (*Player_Italic: "Look through the peephole."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Italic**
> "I opened the door and looked outside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Iosef Lancea), `[17]` (Narrator), `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I was met with 20 to 30 men waiting near personnel trucks..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Look through the peephole."]** — Mówca: **Player_Italic**
> "I looked through the peephole."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I could see Iosef standing outside, accompanied by a few ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "I could see General Valken Kruger outside, accompanied by..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I could see Iosef standing outside, accompanied by a few soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Open the door."*)
  - -> `[25]` (*Player: "“What is going on? Why are you here at this hour? I won't..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "I could see General Valken Kruger outside, accompanied by a couple of soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Open the door."*)
  - -> `[25]` (*Player: "“What is going on? Why are you here at this hour? I won't..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“What is going on? Why are you here at this hour? I won't open the door unless you answer.”"]** — Mówca: **Player**
> "“What is going on? Why are you here at this hour? I won't open the door unless you answer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[26]`
Mówca: **Valken Kruger**
> "“We need to talk, Mr. President. This is urgent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Open the door."*)
  - -> `[30]` (*Player: "“Tell me what it's about first.”"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Iosef Lancea: "“We need to talk, Mr. President. This is urgent.”"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Valken Kruger: "“We need to talk, Mr. President. This is urgent.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Tell me what it's about first.”"]** — Mówca: **Player**
> "“Tell me what it's about first.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Iosef Lancea), `[26]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[31]`
Mówca: **Valken Kruger**
> "“Do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "With a scary thud, the door shook on its hinges."*)

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "With a scary thud, the door shook on its hinges."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Iosef Lancea: "“Do it.”"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Valken Kruger: "“Do it.”"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "With a scary thud, the door shook on its hinges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Another thud and the door was cracked open."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)

### Węzeł `[40]`
Mówca: **Monica**
> "“Anton! What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“It's okay. I'll handle this.”"*)
  - -> `[42]` (*Player: "“We have to run. Now.”"*)
  - -> `[41]` (*Player: "“Monica. Take Deana and hide somewhere.”"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Monica. Take Deana and hide somewhere.”"]** — Mówca: **Player**
> "“Monica. Take Deana and hide somewhere.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Another thud and the door was cracked open."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“We have to run. Now.”"]** — Mówca: **Player**
> "“We have to run. Now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Another thud and the door was cracked open."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It's okay. I'll handle this.”"]** — Mówca: **Player**
> "“It's okay. I'll handle this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Another thud and the door was cracked open."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Monica rushed down the stairs, still in her nightgown. Her voice was trembling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Monica: "“Anton! What is going on?”"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "I was met with 20 to 30 men waiting near personnel trucks, all in full combat gear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "As I opened the door wider, they started moving towards me."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "As I opened the door wider, they started moving towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "“Explain yourselves! Immediately!”"*)
  - -> `[47]` (*Player: "“What the hell is the meaning of this?”"*)
  - -> `[49]` (*Player: "“You can't just barge into the house of the President! I ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“What the hell is the meaning of this?”"]** — Mówca: **Player**
> "“What the hell is the meaning of this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Explain yourselves! Immediately!”"]** — Mówca: **Player**
> "“Explain yourselves! Immediately!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“You can't just barge into the house of the President! I will have you removed!”"]** — Mówca: **Player**
> "“You can't just barge into the house of the President! I will have you removed!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Another thud and the door was cracked open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Monica: "“Anton!”"*)

### Węzeł `[51]`
Mówca: **Monica**
> "“Anton!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Soldiers immediately stormed into my house."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Soldiers immediately stormed into my house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "They entered and went through every room, checking for th..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "No one replied. Instead, the soldiers stormed past me and into the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "They entered and went through every room, checking for th..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "They entered and went through every room, checking for threats. Once they were done, they stood ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Iosef walked in. Soldiers saluted him."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "General Kruger walked in. Soldiers saluted him."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Iosef walked in. Soldiers saluted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“You! How dare you?”"*)
  - -> `[62]` (*Player: "“You will explain to me what the hell is going on. Right ..."*)
  - -> `[63]` (*Player: "“Do you think you can just get away with this?”"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "General Kruger walked in. Soldiers saluted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“You! How dare you?”"*)
  - -> `[62]` (*Player: "“You will explain to me what the hell is going on. Right ..."*)
  - -> `[63]` (*Player: "“Do you think you can just get away with this?”"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Another thud and the door was cracked open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Soldiers immediately stormed into my house."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“You! How dare you?”"]** — Mówca: **Player**
> "“You! How dare you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“You will explain to me what the hell is going on. Right now!”"]** — Mówca: **Player**
> "“You will explain to me what the hell is going on. Right now!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Do you think you can just get away with this?”"]** — Mówca: **Player**
> "“Do you think you can just get away with this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[67]`
Mówca: **Valken Kruger**
> "“I'm sorry, but your time is over, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Valken Kruger: "“You are under arrest for your crimes against Sordland.”"*)

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“I'm sorry, but your time is over, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Iosef Lancea: "“You are under arrest for your crimes against Sordland.”"*)

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“You are under arrest for your crimes against Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Iosef Lancea: "“Above all else, you have committed high treason and cons..."*)

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“Above all else, you have committed high treason and conspired against the will of your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“How long have you been planning this?”"*)
  - -> `[75]` (*Player: "“I have done nothing wrong. Please let me go at once!”"*)
  - -> `[73]` (*Player: "“You can take me, but please, don't hurt my family.”"*)

### Węzeł `[71]`
Mówca: **Valken Kruger**
> "“Above all else, you have committed high treason and conspired against the will of your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“How long have you been planning this?”"*)
  - -> `[75]` (*Player: "“I have done nothing wrong. Please let me go at once!”"*)
  - -> `[73]` (*Player: "“You can take me, but please, don't hurt my family.”"*)

### Węzeł `[72]`
Mówca: **Valken Kruger**
> "“You are under arrest for your crimes against Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Valken Kruger: "“Above all else, you have committed high treason and cons..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“You can take me, but please, don't hurt my family.”"]** — Mówca: **Player**
> "“You can take me, but please, don't hurt my family.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“How long have you been planning this?”"]** — Mówca: **Player**
> "“How long have you been planning this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I have done nothing wrong. Please let me go at once!”"]** — Mówca: **Player**
> "“I have done nothing wrong. Please let me go at once!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Iosef Lancea), `[71]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[76]`
Mówca: **Valken Kruger**
> "“Since the day you betrayed your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Iosef Lancea: "“Since the day you betrayed your country.”"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Valken Kruger: "“Since the day you betrayed your country.”"*)

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“Since the day you betrayed your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[81]`
Mówca: **Valken Kruger**
> "“I'm afraid that is impossible. We do not negotiate with traitors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Iosef Lancea: "“I'm afraid that is impossible. We do not negotiate with ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Valken Kruger: "“I'm afraid that is impossible. We do not negotiate with ..."*)

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“I'm afraid that is impossible. We do not negotiate with traitors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[86]`
Mówca: **Valken Kruger**
> "“Rest assured. Your family will be under our watch and they will remain safe. That is, of course, if you cooperate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[90]`
Mówca: **Iosef Lancea**
> "“Rest assured. Your family will be under our watch and they will remain safe. That is, of course, if you cooperate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[91]`
Mówca: **Iosef Lancea**
> "“The military had no choice but to take over the government to ensure the well-being of Sordland and its people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Iosef Lancea: "“The Grand National Assembly is hereby abolished along wi..."*)

### Węzeł `[92]`
Mówca: **Valken Kruger**
> "“The military had no choice but to take over the government to ensure the well-being of Sordland and its people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Valken Kruger: "“The Grand National Assembly is hereby abolished along wi..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Iosef Lancea: "“The military had no choice but to take over the governme..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Valken Kruger: "“The military had no choice but to take over the governme..."*)

### Węzeł `[96]`
Mówca: **Iosef Lancea**
> "“The Grand National Assembly is hereby abolished along with the immunity of members of the parliament.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Iosef Lancea: "“In addition, a curfew is now in effect and all gathering..."*)

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“In addition, a curfew is now in effect and all gatherings are banned until further notice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“All government officials who are suspected of betraying ..."*)

### Węzeł `[98]`
Mówca: **Valken Kruger**
> "“The Grand National Assembly is hereby abolished along with the immunity of members of the parliament.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Valken Kruger: "“In addition, a curfew is now in effect and all gathering..."*)

### Węzeł `[99]`
Mówca: **Valken Kruger**
> "“In addition, a curfew is now in effect and all gatherings are banned until further notice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Valken Kruger: "“All government officials who are suspected of betraying ..."*)

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“All government officials who are suspected of betraying their country will be tried in military court and made to answer for their crimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Iosef Lancea: "“That includes you, Mr. President.”"*)

### Węzeł `[101]`
Mówca: **Valken Kruger**
> "“All government officials who are suspected of betraying their country will be tried in military court and made to answer for their crimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Valken Kruger: "“That includes you, Mr. President.”"*)

### Węzeł `[102]`
Mówca: **Iosef Lancea**
> "“That includes you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“No. You can't do this! I won't let you. I am the Preside..."*)
  - -> `[106]` (*Player: "“You are destroying our democracy!”"*)
  - -> `[107]` (*Player: "“You will pay one day for your heinous actions! I swear o..."*)

### Węzeł `[103]`
Mówca: **Valken Kruger**
> "“That includes you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“No. You can't do this! I won't let you. I am the Preside..."*)
  - -> `[106]` (*Player: "“You are destroying our democracy!”"*)
  - -> `[107]` (*Player: "“You will pay one day for your heinous actions! I swear o..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "A soldier started approaching me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“No. You can't do this! I won't let you. I am the President of Sordland!”"]** — Mówca: **Player**
> "“No. You can't do this! I won't let you. I am the President of Sordland!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Iosef Lancea), `[103]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“You are destroying our democracy!”"]** — Mówca: **Player**
> "“You are destroying our democracy!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Iosef Lancea), `[103]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“You will pay one day for your heinous actions! I swear on my name!”"]** — Mówca: **Player**
> "“You will pay one day for your heinous actions! I swear on my name!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Iosef Lancea), `[103]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[108]`
Mówca: **Valken Kruger**
> "“Not anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Valken Kruger: "“Take him away!”"*)

### Węzeł `[109]`
Mówca: **Iosef Lancea**
> "“Not anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Iosef Lancea: "“Take him away!”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Iosef Lancea: "“Not anymore.”"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Valken Kruger: "“Not anymore.”"*)

### Węzeł `[113]`
Mówca: **Valken Kruger**
> "“No. We are protecting our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Valken Kruger: "“Take him away!”"*)

### Węzeł `[114]`
Mówca: **Iosef Lancea**
> "“No. We are protecting our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Iosef Lancea: "“Take him away!”"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Iosef Lancea: "“No. We are protecting our country.”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Valken Kruger: "“No. We are protecting our country.”"*)

### Węzeł `[118]`
Mówca: **Valken Kruger**
> "“The only heinous actions in question are yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Valken Kruger: "“Take him away!”"*)

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“The only heinous actions in question are yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Iosef Lancea: "“Take him away!”"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“The only heinous actions in question are yours.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Valken Kruger: "“The only heinous actions in question are yours.""*)

### Węzeł `[123]`
Mówca: **Iosef Lancea**
> "“Take him away!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Iosef Lancea: "“I don't want to see his face.”"*)

### Węzeł `[124]`
Mówca: **Valken Kruger**
> "“Take him away!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Valken Kruger: "“I don't want to see his face.”"*)

### Węzeł `[125]`
Mówca: **Iosef Lancea**
> "“I don't want to see his face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Iosef Lancea: "“He will wait in a cell in Antel Rock Prison until his tr..."*)

### Węzeł `[126]`
Mówca: **Valken Kruger**
> "“I don't want to see his face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Valken Kruger: "“He will wait in a cell in Antel Rock Prison until his tr..."*)

### Węzeł `[127]`
Mówca: **Iosef Lancea**
> "“He will wait in a cell in Antel Rock Prison until his trial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Coup_Iosef = true"*)

### Węzeł `[128]`
Mówca: **Valken Kruger**
> "“He will wait in a cell in Antel Rock Prison until his trial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Coup_Valken = true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true )"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Another soldier pulled out handcuffs."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)

### Węzeł `[132]`
Mówca: **Monica**
> "“Anton! No! I won't let you take him!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "Deana appeared at the top of the stairs. She rubbed her e..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "Deana appeared at the top of the stairs. She rubbed her eyes in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Deana: "“Mama! Where are they taking him?”"*)

### Węzeł `[134]`
Mówca: **Deana**
> "“Mama! Where are they taking him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Monica pulled on my jacket. A soldier moved in and shoved..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Monica pulled on my jacket. A soldier moved in and shoved her away forcefully. Tears welled up in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Monica: "“Anton.”"*)

### Węzeł `[136]`
Mówca: **Monica**
> "“Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Everything will be fine, Monica. Take care of Deana.”"*)
  - -> `[138]` (*Player: "“We will get through this. I promise.”"*)
  - -> `[139]` (*Player: "“I'm sorry for everything.”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Everything will be fine, Monica. Take care of Deana.”"]** — Mówca: **Player**
> "“Everything will be fine, Monica. Take care of Deana.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Monica: "“No! You can't take him away! Please! This is unconstitut..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“We will get through this. I promise.”"]** — Mówca: **Player**
> "“We will get through this. I promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Monica: "“No! You can't take him away! Please! This is unconstitut..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I'm sorry for everything.”"]** — Mówca: **Player**
> "“I'm sorry for everything.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Monica: "“No! You can't take him away! Please! This is unconstitut..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Another soldier pulled out handcuffs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "“There is no need for handcuffs. I know when I have no wa..."*)
  - -> `[142]` (*Player_Italic: "Resist the arrest."*)
  - -> `[143]` (*Player_Italic: "Let the soldier handcuff you."*)

### Węzeł `[141]`
Mówca: **Monica**
> "“No! You can't take him away! Please! This is unconstitutional!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Another soldier pulled out handcuffs."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "Resist the arrest."]** — Mówca: **Player_Italic**
> "I pushed the soldier away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "The soldier angrily pulled out his rifle."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "Let the soldier handcuff you."]** — Mówca: **Player_Italic**
> "I let the soldier handcuff me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "He escorted me to the truck. I realized I still had my sl..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "The soldier angrily pulled out his rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "He hit me in the head with the gunstock."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "He hit me in the head with the gunstock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "My eyes closed."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "My eyes closed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "He escorted me to the truck. I realized I still had my slippers on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "They roughly shoved me into the back of the vehicle, as t..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "They roughly shoved me into the back of the vehicle, as they would a common criminal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“There is no need for handcuffs. I know when I have no way out.”"]** — Mówca: **Player**
> "“There is no need for handcuffs. I know when I have no way out.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "The soldier stopped in his tracks and looked at Iosef for confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He nodded."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "The soldier stopped in his tracks and looked at Iosef for..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "The soldier stopped in his tracks and looked at General K..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "The soldier stopped in his tracks and looked at General Kruger for confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He nodded."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "His men escorted me to the truck. I realized I still had ..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "His men escorted me to the truck. I realized I still had my slippers on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "They roughly shoved me into the back of the vehicle, as t..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "They roughly shoved me into the back of the vehicle, as they would a common criminal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Iosef Lancea: "“You have given us an order to protect this country from ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“I'm sorry, but your time is over, Mr. President.”"*)

### Węzeł `[161]`
Mówca: **Iosef Lancea**
> "“You have given us an order to protect this country from threats. We are doing exactly that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“I'm sorry, but your time is over, Mr. President.”"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Valken Kruger: "“You have given us an order to protect this country from ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Valken Kruger: "“I'm sorry, but your time is over, Mr. President.”"*)

### Węzeł `[165]`
Mówca: **Valken Kruger**
> "“You have given us an order to protect this country from threats. We are doing exactly that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Valken Kruger: "“I'm sorry, but your time is over, Mr. President.”"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "Out of habit, I looked towards the other side of the bed. It was empty. Monica and Deana were at the main house on the other side of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("LouderKnockDoor");"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true )"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Out of habit, I looked towards the other side of the bed...."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "I looked at the other side of the bed. Monica was sleepin..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true )"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Another thud, and the door was cracked open."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Monica rushed down the stairs, still in her nightgown. He..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Another thud, and the door was cracked open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Soldiers immediately stormed into the guesthouse."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Soldiers immediately stormed into the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "They entered and went through every room, checking for th..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "No one replied. Instead, the soldiers stormed past me and..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "No one replied. Instead, the soldiers stormed past me and..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "No one replied. Instead, the soldiers stormed past me and into the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "They entered and went through every room, checking for th..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Iosef Lancea: ""Your wife and daughter have been taken into military cus..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Iosef Lancea: "“Rest assured. Your family will be under our watch and th..."*)

### Węzeł `[182]`
Mówca: **Iosef Lancea**
> ""Your wife and daughter have been taken into military custody. Rest assured, they will remain safe as long as you cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Valken Kruger: ""Your wife and daughter have been taken into military cus..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Valken Kruger: "“Rest assured. Your family will be under our watch and th..."*)

### Węzeł `[186]`
Mówca: **Valken Kruger**
> ""Your wife and daughter have been taken into military custody. Rest assured, they will remain safe as long as you cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true )"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Suddenly, Monica came running across the courtyard, taile..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Monica: "“Anton! No! I won't let you take him!”"*)

### Węzeł `[190]`
Mówca: **Narrator**
> "Suddenly, Monica came running across the courtyard, tailed closely by two military men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Monica: ""Anton!""*)

### Węzeł `[191]`
Mówca: **Monica**
> ""Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: ""It's okay, Monica. I'll be fine.""*)
  - -> `[193]` (*Player: ""I'm sorry for everything, Monica.""*)
  - -> `[194]` (*Player: ""I love you, Monica.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""It's okay, Monica. I'll be fine.""]** — Mówca: **Player**
> ""It's okay, Monica. I'll be fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""I just wanted to say...""*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""I'm sorry for everything, Monica.""]** — Mówca: **Player**
> ""I'm sorry for everything, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""I just wanted to say...""*)

### Węzeł `[194]`
**[WYBÓR GRACZA: ""I love you, Monica.""]** — Mówca: **Player**
> ""I love you, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""I just wanted to say...""*)

### Węzeł `[195]`
Mówca: **Monica**
> ""I just wanted to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Monica: ""Do everything they tell you. Everything.""*)

### Węzeł `[196]`
Mówca: **Monica**
> ""Do everything they tell you. Everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Monica: ""If they so much as lay a finger on Deana... I'll kill yo..."*)

### Węzeł `[197]`
Mówca: **Monica**
> ""If they so much as lay a finger on Deana... I'll kill you myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Another soldier pulled out handcuffs."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "The engine rumbled to life and the truck started moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Iosef Lancea", "Defacto Head of Sta..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "The engine rumbled to life and the truck started moving."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The engine rumbled to life and the truck started moving."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "The engine rumbled to life and the truck started moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Valken Kruger", "Defacto Head of St..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Coup_Iosef = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Coup_Iosef"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "A soldier started approaching me."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Coup_Valken = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Coup_Valken"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "A soldier started approaching me."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 2; BaseGame.GovernmentBudget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_SnO_CoupNight = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Iosef Lancea", "Defacto Head of State");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Iosef Lancea","Defacto Head of State");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 2; BaseGame.GovernmentBudget -= 1;"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Valken Kruger", "Defacto Head of State");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Valken Kruger","Defacto Head of State");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 2; BaseGame.GovernmentBudget -= 1;"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("LoudKnockDoor");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("LoudKnockDoor");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I woke up to a loud knock on the door."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("LouderKnockDoor");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("LouderKnockDoor");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I started walking downstairs. I heard another knock on th..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
