# Sordland/Turn01/Shooting

- **ID konwersacji:** `11`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/011_Shooting.md`
- **Liczba węzłów dialogowych:** 87
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[28]** Evelyn Vectern
- **[31]** Franc
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[9] Sordland/Turn01/Personal_Ball** (../Turn_01/009_Personal_Ball.md), Węzeł `[95]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 4

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[83]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1; ...`
- Węzeł `[84]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1; ...`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1; ...`
- Węzeł `[86]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1; ...`

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `9` (*Sordland/Turn01/Personal_Ball*), Węzeł `[95]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Karl Greiser, head of the Sordish Police Force, was running towards us with three more police officers in decorated uniforms. They all had their guns drawn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "<shout>"NO! GUNSHOTS!!!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Narrator**
> "As soon as he made it to us and saw that we were unharmed, he let out a big sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Monica was still trying to tend to Deana as Franc paced the room, mumbling that he should have stayed home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[74]`
  - -> `[73]`

### Węzeł `[7]`
Mówca: **Narrator**
> "As soon as Monica heard the word, she lunged from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[16]`

### Węzeł `[8]`
Mówca: **Karl Greiser**
> "“I am sorry, sir. I will personally conduct the investigation into our palace security force once we figure out what is going on. I can assure you I will be relentless in dealing with incompetence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[9]`
Mówca: **Karl Greiser**
> "“He fired three shots at an MP -- one to the head, two to the body -- instantly killing him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""What a fucking night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[49]`
  - -> `[43]`

### Węzeł `[11]`
Mówca: **Karl Greiser**
> "“Presidential guards at the palace immediately shot and killed the attacker. He has not been identified yet and will require an investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“GET DOWN!""]** — Mówca: **Player**
> "<shout>“GET DOWN!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[13]`
Mówca: **Karl Greiser**
> "“The MP that was killed was identified as Bernard Circas.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The room went quiet. Petr seemed like he was about to say something, but with one look from me, he stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""This is huge, Anton. This will cause a lot of problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Shield Monica and kids."]** — Mówca: **Player_Italic**
> "I threw myself on Monica, Deana and Franc to shield them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[17]`
Mówca: **Petr Vectern**
> ""A lot of problems...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Monica**
> "<shout>“ANTON, THE KIDS!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Petr pulled out two cigarettes and handed me one. He then turned to Evelyn. I could hear him trying to reassure her that everything was going to be all right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[20]`
Mówca: **Narrator**
> "We promptly followed Karl through the winding halls and corridors of the palace. His men still had their guns drawn, which did nothing to ease the tension. On the way, Petr made an attempt to break the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“This is what we know so far. We have confirmed that two people were gunned down in front of the palace. The attacker is one of them and we have reasons to believe he was working alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Monica, Deana and Franc all looked at me beseechingly. I rushed to shield them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Karl Greiser**
> "“As you command, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He gestured towards a more private corner of the room and starting speaking more quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[25]`
Mówca: **Karl Greiser**
> "“Do not worry. The situation is now under control. Please follow me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Deana started crying again because of my yelling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Karl flipped a switch on the wall and a panel opened, revealing a hidden staircase leading to a large reinforced door. Inside, a set of emergency lights flickered on. The safe room was comfortable and spacious, with expensive-looking leather sofas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[28]`
Mówca: **Karl Greiser**
> "“If I may, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[29]`
Mówca: **Deana**
> "“Papa! What's happening!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Karl Greiser**
> "“Paul, Jansen, follow my lead. We will bring them to the safe room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Franc**
> ""I knew it! We never should've come!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“YOU BETTER FOR YOUR SAKE. STATUS UPDATE!""]** — Mówca: **Player**
> "<shout>“YOU'D BETTER FOR YOUR SAKE. STATUS UPDATE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Good. So what is going on?""]** — Mówca: **Player**
> "“Good. So what is going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He glanced towards Monica, Evelyn and the kids."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He now turned to Monica, Evelyn and the children and spoke in a softer voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Chaos broke out as some guests flung themselves under their tables and others ran towards the doors, screaming. Deana burst into tears while Franc tried to comfort her, hiding the fear in his own eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Karl Greiser**
> "“No, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[44]`
  - -> `[46]`

### Węzeł `[38]`
Mówca: **Karl Greiser**
> "“Good news. We are not in any danger at the moment. The situation has been dealt with and the perimeter has been secured by the guards and the police.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Three more gunshots rang out loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Karl Greiser**
> "“Certainly not, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Karl turned to us with a serious face as we were about to round a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[42]`
Mówca: **Karl Greiser**
> "“Mr. President! Are you all right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“You can say that again.""]** — Mówca: **Player**
> "“You can say that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“THEN TELL ME HOW THIS CIRCUS SHOW HAPPENED IN MY BALL.""]** — Mówca: **Player**
> "<shout>“THEN TELL ME HOW THIS CIRCUS SHOW HAPPENED AT MY BALL."</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[45]`
Mówca: **Karl Greiser**
> "“One second, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Sorry for yelling, Karl. I'm just a bit nervous right now.""]** — Mówca: **Player**
> "“Sorry for yelling, Karl. I'm just a bit nervous right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Karl Greiser**
> "I completely understand, sir. I will personally conduct the investigation into our palace security force and I can assure you I will be relentless in dealing with incompetence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Karl's radio suddenly crackled to life. Every second felt like an eternity as he pressed his ear to the receiver. When it fell silent, he turned to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Can't you shut your mouth for a bit?""]** — Mówca: **Player**
> "“Can't you shut your mouth for a bit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[50]`
Mówca: **Karl Greiser**
> "“I should receive confirmation soon, Mr. President. Everything is under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Sssshh. Not now Petr.""]** — Mówca: **Player**
> "“Sssshh. Not now, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's not over yet.""]** — Mówca: **Player**
> "“It's not over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Petr let out a nervous laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“So, what's the status?""]** — Mówca: **Player**
> "“So, what's the status?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Small security monitors on the wall displayed grainy footage of each room in the palace. There was a boardroom and a pantry containing enough provisions to last us months. Monica and Evelyn sat the children down and started wiping their tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[56]`
Mówca: **Karl Greiser**
> "“I should receive confirmation soon, Mr. President. Everything is under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Check the perimeter.""]** — Mówca: **Player**
> "“Check the perimeter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Karl Greiser**
> "“Thank God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[64]`
  - -> `[57]`

### Węzeł `[59]`
Mówca: **Narrator**
> "He turned around quickly to his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Karl Greiser**
> "“Quiet, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Are we under attack? Who is attacking us? What is going on?!""]** — Mówca: **Player**
> "“Are we under attack? Who is attacking us? What is going on?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[62]`
Mówca: **Karl Greiser**
> "“CHECK THE PERIMETER! NOW!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Karl stepped away from us and made a few radio calls. When he was done, he returned to me and Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[65]`
  - -> `[67]`
  - -> `[69]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“STATUS REPORT!""]** — Mówca: **Player**
> "“STATUS REPORT!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Not the best inauguration ball I've been to.""]** — Mówca: **Player**
> "“Not the best inauguration ball I've been to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“What the hell is going on?!""]** — Mówca: **Player**
> "“What the hell is going on?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Are we under attack? Who is attacking us? What is going on?!""]** — Mówca: **Player**
> "“Are we under attack? Who is attacking us? What is going on?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[68]`
Mówca: **Evelyn Vectern**
> "“Petr, shut up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“So tell me Karl. DO I HAVE CLOWNS FOR A SECURITY FORCE?""]** — Mówca: **Player**
> "<shout>“So tell me Karl. DO I HAVE CLOWNS FOR A SECURITY FORCE?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "As I raised my voice, he lowered his head in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""Sorry, I talk when I get nervous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "Comfort Monica and the kids."]** — Mówca: **Player_Italic**
> "I sat down beside my wife and children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[82]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "Smoke alone."]** — Mówca: **Player_Italic**
> "I lit the cigarette and took a deep drag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Petr, old friend, what the hell have we gotten ourselves into?""]** — Mówca: **Player**
> ""Petr, old friend, what the hell have we gotten ourselves into?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Nothing like this will ever happen again. I'll make sure of it.""]** — Mówca: **Player**
> ""Nothing like this will ever happen again. I'll make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Narrator**
> "As I continued smoking, a peculiar calm washed over me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We can't be sure of anything anymore, Anton.""]** — Mówca: **Monica**
> ""We can't be sure of anything anymore, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[78]`
Mówca: **Narrator**
> "I lit my cigarette and took a deep drag. I was going to see this through and keep my family safe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[79]`
Mówca: **Narrator**
> "I was going to see this through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[80]`
Mówca: **Petr Vectern**
> ""Nothing you and I can't handle, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "I lit my cigarette and took a deep drag. We were going to see this through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We are safe. I'll make sure everything's going to be fine.""]** — Mówca: **Player**
> ""We are safe. I'll make sure everything's going to be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;
BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1;
BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;
BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1;
BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
