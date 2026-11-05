# Sordland/Turn11/SnO_CoupTrial

- **ID konwersacji:** `243`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/243_SnO_CoupTrial.md`
- **Liczba węzłów dialogowych:** 276
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[42]** Valken Kruger
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Economy`
- `BaseGame.Enable_SollTrial`
- `BaseGame.Policy_Law_Impeachment_Assembly`
- `BaseGame.Policy_Law_Impeachment_Default`
- `BaseGame.Policy_Law_Impeachment_Harder`
- `BaseGame.Policy_Law_Impeachment_Removed`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn09_EnT_IncreasedLivingStandards`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_BFF_Deal_Failed`
- `BaseGame.Unrest_BFF_Deal_Promised`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial`
- `GameCondition.Turn11_SnO_CoupTrial`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"“You are no judge. You are just a usurper.”"** | `[6]` **Iosef Lancea**: "“Normally, you are supposed to r..."<br>`[23]` **Valken Kruger**: "“Normally, you are supposed to r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Iosef Lancea**: "“Cranky, aren't we? I suppose th..."<br>`[28]` **Valken Kruger**: "“Cranky, aren't we? I suppose th..." |
| `[10]` | **"Take a seat."** | `[9]` **Narrator**: "Soldiers grabbed my arms and led..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "Looking around, I saw the flags ..." |
| `[18]` | **"Stand up."** | `[6]` **Iosef Lancea**: "“Normally, you are supposed to r..."<br>`[23]` **Valken Kruger**: "“Normally, you are supposed to r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Iosef Lancea**: "“Good.”"<br>`[33]` **Valken Kruger**: "“Good.”" |
| `[75]` | **"“You know what, screw you!”"** | `[197]` **Narrator**: "His mouth twitched upwards as a ..."<br>`[198]` **Narrator**: "His mouth twitched upwards as a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Iosef Lancea**: "“You dare say that to the head o..."<br>`[94]` **Valken Kruger**: "“You dare say that to the head o..." |
| `[76]` | **"“I will make it out of this and one day, you will be sorry for your life.”"** | `[197]` **Narrator**: "His mouth twitched upwards as a ..."<br>`[198]` **Narrator**: "His mouth twitched upwards as a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Iosef Lancea**: "“You dare threaten the head of y..."<br>`[89]` **Valken Kruger**: "“You dare threaten the head of y..." |
| `[77]` | **"“It doesn't matter what I say, does it?”"** | `[73]` **Iosef Lancea**: "“What do you have to say for you..."<br>`[74]` **Valken Kruger**: "“What do you have to say for you..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Iosef Lancea**: "“No, not really.”"<br>`[88]` **Valken Kruger**: "“No, not really.”" |
| `[78]` | **"“I see what this is. This is all a ploy to end Sordish democracy along with my pre..."** | `[197]` **Narrator**: "His mouth twitched upwards as a ..."<br>`[198]` **Narrator**: "His mouth twitched upwards as a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Iosef Lancea**: ""Your lies know no bound. Fortun..."<br>`[83]` **Valken Kruger**: ""Your lies know no bound. Fortun..." |
| `[99]` | **"“Just get on with it then. Finish it.”"** | `[82]` **Iosef Lancea**: ""Your lies know no bound. Fortun..."<br>`[83]` **Valken Kruger**: ""Your lies know no bound. Fortun..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Iosef Lancea**: "“Gladly.”"<br>`[107]` **Valken Kruger**: "“Gladly.”" |
| `[100]` | **"“At least let me see my family again. They are innocent.”"** | `[82]` **Iosef Lancea**: ""Your lies know no bound. Fortun..."<br>`[83]` **Valken Kruger**: ""Your lies know no bound. Fortun..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Iosef Lancea**: "“We do not negotiate with traito..."<br>`[112]` **Valken Kruger**: "“We do not negotiate with traito..." |
| `[101]` | **"“One day, the people of Sordland will look back and curse your name for what you h..."** | `[82]` **Iosef Lancea**: ""Your lies know no bound. Fortun..."<br>`[83]` **Valken Kruger**: ""Your lies know no bound. Fortun..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Iosef Lancea**: "“You are wrong, Mr. Rayne. They ..."<br>`[106]` **Valken Kruger**: "“You are wrong, Mr. Rayne. They ..." |
| `[124]` | **"“This is ridiculous! You have no proof!”"** | `[40]` **Iosef Lancea**: "“You are accused of high treason..."<br>`[41]` **Valken Kruger**: "“You are accused of high treason..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Iosef Lancea**: "“Shut your mouth. You will only ..."<br>`[131]` **Valken Kruger**: "“Shut your mouth. You will only ..." |
| `[125]` | **"“High treason? I would never betray my country. You know that more than anyone.”"** | `[40]` **Iosef Lancea**: "“You are accused of high treason..."<br>`[41]` **Valken Kruger**: "“You are accused of high treason..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Iosef Lancea**: "“Shut your mouth. You will only ..."<br>`[131]` **Valken Kruger**: "“Shut your mouth. You will only ..." |
| `[126]` | **"“If there is any betrayal here, it is yours against your democratically elected pr..."** | `[40]` **Iosef Lancea**: "“You are accused of high treason..."<br>`[41]` **Valken Kruger**: "“You are accused of high treason..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Iosef Lancea**: "“Shut your mouth. You will only ..."<br>`[131]` **Valken Kruger**: "“Shut your mouth. You will only ..." |
| `[160]` | **"“Yes, I do.”"** | `[158]` **Iosef Lancea**: "“Do you know why you are here?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Iosef Lancea**: "“We all know our sins.”" |
| `[161]` | **"“No, I don't.”"** | `[158]` **Iosef Lancea**: "“Do you know why you are here?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Iosef Lancea**: "“Hah. As expected. Acting innoce..." |
| `[162]` | **"“No, I don't.”"** | `[159]` **Valken Kruger**: "“Do you know why you are here?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Valken Kruger**: "“And we let this man be our Pres..." |
| `[163]` | **"“Yes, I do.”"** | `[159]` **Valken Kruger**: "“Do you know why you are here?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Valken Kruger**: "“At least he is aware.”" |
| `[182]` | **"“I've made Sordland a better place. Every Sord is living a pleasant life because o..."** | `[73]` **Iosef Lancea**: "“What do you have to say for you..."<br>`[74]` **Valken Kruger**: "“What do you have to say for you..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGame.Turn09_EnT_IncreasedLivingStandards"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] == false` | *Brak zmian stanu* | `[187]` **Iosef Lancea**: "“Mr. Rayne, you can't toss us a ..."<br>`[186]` **Valken Kruger**: "“Mr. Rayne, you can't toss us a ..." |
| `[188]` | **"“I dragged Sordland out of a recession and brought us to a golden age. Without me,..."** | `[73]` **Iosef Lancea**: "“What do you have to say for you..."<br>`[74]` **Valken Kruger**: "“What do you have to say for you..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] == false` | *Brak zmian stanu* | `[193]` **Iosef Lancea**: "“But the people have yet to know..."<br>`[189]` **Valken Kruger**: "“But the people have yet to know..." |
| `[221]` | **"“I gave you support so you can protect this country. Instead, you've chosen to dep..."** | `[73]` **Iosef Lancea**: "“What do you have to say for you..."<br>`[74]` **Valken Kruger**: "“What do you have to say for you..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] == false` | *Brak zmian stanu* | `[219]` **Iosef Lancea**: "“We are doing what we were assig..."<br>`[215]` **Valken Kruger**: "“We are doing what we were assig..." |
| `[222]` | **"“This is criminal. You have neither the right nor the authority to judge me.""** | `[73]` **Iosef Lancea**: "“What do you have to say for you..."<br>`[74]` **Valken Kruger**: "“What do you have to say for you..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] == false` | *Brak zmian stanu* | `[246]` **Player**: "“This is a power grab in the dis..."<br>`[242]` **Player**: "“Where are the justices!?""<br>*(oraz 3 innych odgałęzień)* |
| `[241]` | **"“Where are the members of the assembly and the justices!?""** | `[222]` **Player**: "“This is criminal. You have neit..." | `Variable["BaseGame.Policy_Law_Impeachment_Harder"] == true` | `-- continue;` | `[246]` **Player**: "“This is a power grab in the dis..." |
| `[242]` | **"“Where are the justices!?""** | `[222]` **Player**: "“This is criminal. You have neit..." | `Variable["BaseGame.Policy_Law_Impeachment_Default"] == true` | `-- continue;` | `[246]` **Player**: "“This is a power grab in the dis..." |
| `[243]` | **"“By the law, I cannot be judged!”"** | `[222]` **Player**: "“This is criminal. You have neit..." | `Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true` | *Brak zmian stanu* | `[247]` **Iosef Lancea**: ""The *law* that you wrote and pa..."<br>`[252]` **Valken Kruger**: ""The *law* that you wrote and pa..." |
| `[244]` | **"“Where are the members of the assembly!?""** | `[222]` **Player**: "“This is criminal. You have neit..." | `Variable["BaseGame.Policy_Law_Impeachment_Assembly"] == true` | `-- continue;` | `[246]` **Player**: "“This is a power grab in the dis..." |
| `[246]` | **"“This is a power grab in the disguise of protecting the republic, I demand a prope..."** | `[222]` **Player**: "“This is criminal. You have neit..."<br>`[241]` **Player**: "“Where are the members of the as..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Iosef Lancea**: ""You finished?""<br>`[227]` **Valken Kruger**: ""You finished?"" |
| `[262]` | **"Spit on his face."** | `[132]` **Valken Kruger**: "“Don't worry too much, Mr. Rayne..."<br>`[133]` **Iosef Lancea**: "“Don't worry too much, Mr. Rayne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Narrator**: "He swiped the saliva off his fac..." |
| `[263]` | **"Throw a punch at his jaw."** | `[132]` **Valken Kruger**: "“Don't worry too much, Mr. Rayne..."<br>`[133]` **Iosef Lancea**: "“Don't worry too much, Mr. Rayne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "Your punch connected but he bare..." |
| `[264]` | **"Stare a spiteful gaze into his eyes."** | `[132]` **Valken Kruger**: "“Don't worry too much, Mr. Rayne..."<br>`[133]` **Iosef Lancea**: "“Don't worry too much, Mr. Rayne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "He swiftly moved back and adjust..." |

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
  - -> `[3]` (*Narrator: "I was making my 14th scratch on the wall when the warden ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was making my 14th scratch on the wall when the warden opened the cell door. It was my first time seeing a person since the military detained me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He put handcuffs on my wrists and we started walking."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "“You are no judge. You are just a usurper.”"]** — Mówca: **Player**
> "“You are no judge. You are just a usurper.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Iosef Lancea), `[23]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He put handcuffs on my wrists and we started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I barely had enough energy to ask where we were going. I ..."*)

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“Normally, you are supposed to rise when a judge enters this room, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "“You are no judge. You are just a usurper.”"*)
  - -> `[18]` (*Player_Italic: "Stand up."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I barely had enough energy to ask where we were going. I just assumed the worst. He told me today was the day of my trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "While we were walking, I caught a glimpse of my reflectio..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "While we were walking, I caught a glimpse of my reflection in a metal door. My beard had grown and my cheeks were sunken. The conditions I was held in were showing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "I was the only one loaded into the prison truck. After a ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Soldiers grabbed my arms and led me inside. They gestured towards the table in the court room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Italic: "Take a seat."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Take a seat."]** — Mówca: **Player_Italic**
> "I took my place at the table."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Looking around, I saw the flags of the Sordish Armed Forc..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Looking around, I saw the flags of the Sordish Armed Forces hanging down from the walls, covering the crests of the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The room was completely empty except for me and the soldi..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The room was completely empty except for me and the soldiers on guard. I looked at the vacant seats on the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "The door opened and General Iosef Lancea entered alone."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "The door opened and General Valken Kruger entered alone."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "The door opened and General Iosef Lancea entered alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The soldiers saluted and he saluted back. I watched him t..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "The door opened and General Valken Kruger entered alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The soldiers saluted and he saluted back. I watched him t..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Stand up."]** — Mówca: **Player_Italic**
> "I stood up in my seat."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Iosef Lancea), `[23]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The soldiers saluted and he saluted back. I watched him take his seat comfortably."
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
  - -> `[6]` (*Iosef Lancea: "“Normally, you are supposed to rise when a judge enters t..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Valken Kruger: "“Normally, you are supposed to rise when a judge enters t..."*)

### Węzeł `[23]`
Mówca: **Valken Kruger**
> "“Normally, you are supposed to rise when a judge enters this room, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "“You are no judge. You are just a usurper.”"*)
  - -> `[18]` (*Player_Italic: "Stand up."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Iosef Lancea: "“Cranky, aren't we? I suppose that's what staying in a ce..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Valken Kruger: "“Cranky, aren't we? I suppose that's what staying in a ce..."*)

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“Cranky, aren't we? I suppose that's what staying in a cell for weeks does to people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[28]`
Mówca: **Valken Kruger**
> "“Cranky, aren't we? I suppose that's what staying in a cell for weeks does to people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Iosef Lancea: "“Good.”"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Valken Kruger: "“Good.”"*)

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[33]`
Mówca: **Valken Kruger**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Iosef Lancea: "“There is no time to waste. Let's begin.”"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Valken Kruger: "“There is no time to waste. Let's begin.”"*)

### Węzeł `[37]`
Mówca: **Iosef Lancea**
> "“There is no time to waste. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Iosef Lancea: "“This military court will now handle the case of Anton Ra..."*)

### Węzeł `[38]`
Mówca: **Valken Kruger**
> "“There is no time to waste. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Valken Kruger: "“This military court will now handle the case of Anton Ra..."*)

### Węzeł `[39]`
Mówca: **Iosef Lancea**
> "“This military court will now handle the case of Anton Rayne, the former President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Iosef Lancea: "“Do you know why you are here?”"*)

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“You are accused of high treason against Sordland, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“This is ridiculous! You have no proof!”"*)
  - -> `[125]` (*Player: "“High treason? I would never betray my country. You know ..."*)
  - -> `[126]` (*Player: "“If there is any betrayal here, it is yours against your ..."*)

### Węzeł `[41]`
Mówca: **Valken Kruger**
> "“You are accused of high treason against Sordland, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“This is ridiculous! You have no proof!”"*)
  - -> `[125]` (*Player: "“High treason? I would never betray my country. You know ..."*)
  - -> `[126]` (*Player: "“If there is any betrayal here, it is yours against your ..."*)

### Węzeł `[42]`
Mówca: **Valken Kruger**
> "“This military court will now handle the case of Anton Rayne, the former President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Valken Kruger: "“Do you know why you are here?”"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: "“You have allowed our military to degrade, causing direct..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“You have allowed our military to degrade, causing direct danger to the integrity of our country and our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Iosef Lancea: "“You have aligned our country with the evil ideology of M..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Iosef Lancea: "“You spat on the very foundations this country was built ..."*)

### Węzeł `[50]`
Mówca: **Iosef Lancea**
> "“You have aligned our country with the evil ideology of Malenyevism. Our fathers are now rolling in their graves because of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Iosef Lancea: "“You spat on the very foundations this country was built ..."*)

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“You spat on the very foundations this country was built upon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_SollTrial == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_SollTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_SollTrial == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Enable_SollTrial == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_SollTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Enable_SollTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Iosef Lancea: "“You even put Colonel Soll, the founder of our republic, ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Enable_SollTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Enable_SollTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“It is clear to me that you are actively trying to destro..."*)

### Węzeł `[55]`
Mówca: **Iosef Lancea**
> "“You even put Colonel Soll, the founder of our republic, on a trial!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“It is clear to me that you are actively trying to destroy our country from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Iosef Lancea: "“And any enemy of Sordland must pay the ultimate price.""*)

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“And any enemy of Sordland must pay the ultimate price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Iosef Lancea: "“What do you have to say for yourself, Mr. Rayne?”"*)

### Węzeł `[58]`
Mówca: **Valken Kruger**
> "“You have allowed our military to degrade, causing direct danger to the integrity of our country and our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[59]`
Mówca: **Valken Kruger**
> "“You spat on the very foundations this country was built upon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_SollTrial == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_SollTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_SollTrial == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Enable_SollTrial == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_SollTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Enable_SollTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Valken Kruger: "“You even put Colonel Soll, the founder of our republic, ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Enable_SollTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Enable_SollTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Valken Kruger: "“It is clear to me that you are actively trying to destro..."*)

### Węzeł `[63]`
Mówca: **Valken Kruger**
> "“You have aligned our country with the evil ideology of Malenyevism. Our fathers are now rolling in their graves because of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Valken Kruger: "“You spat on the very foundations this country was built ..."*)

### Węzeł `[64]`
Mówca: **Valken Kruger**
> "“And any enemy of Sordland must pay the ultimate price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Valken Kruger: "“What do you have to say for yourself, Mr. Rayne?”"*)

### Węzeł `[65]`
Mówca: **Valken Kruger**
> "“It is clear to me that you are actively trying to destroy our country from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Valken Kruger: "“And any enemy of Sordland must pay the ultimate price.""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Valken Kruger: "“You have allowed our military to degrade, causing direct..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Valken Kruger: "“You have aligned our country with the evil ideology of M..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Valken Kruger: "“You spat on the very foundations this country was built ..."*)

### Węzeł `[72]`
Mówca: **Valken Kruger**
> "“You even put Colonel Soll, the founder of our republic, on a trial!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[73]`
Mówca: **Iosef Lancea**
> "“What do you have to say for yourself, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Plead Unguilty Hub"*)

### Węzeł `[74]`
Mówca: **Valken Kruger**
> "“What do you have to say for yourself, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Plead Unguilty Hub"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“You know what, screw you!”"]** — Mówca: **Player**
> "“You know what, screw you!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I will make it out of this and one day, you will be sorry for your life.”"]** — Mówca: **Player**
> "“I will make it out of this and one day, you will be sorry for your life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“It doesn't matter what I say, does it?”"]** — Mówca: **Player**
> "“It doesn't matter what I say, does it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Iosef Lancea), `[74]` (Valken Kruger), `[186]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I see what this is. This is all a ploy to end Sordish democracy along with my presidency. I won't play along.""]** — Mówca: **Player**
> "“I see what this is. This is all a ploy to end Sordish democracy along with my presidency. I won't play along.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Narrator), `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Iosef Lancea: ""Your lies know no bound. Fortunately, we don't care if y..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Valken Kruger: ""Your lies know no bound. Fortunately, we don't care if y..."*)

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> ""Your lies know no bound. Fortunately, we don't care if you 'play along' or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“One day, the people of Sordland will look back and curse..."*)
  - -> `[99]` (*Player: "“Just get on with it then. Finish it.”"*)
  - -> `[100]` (*Player: "“At least let me see my family again. They are innocent.”"*)

### Węzeł `[83]`
Mówca: **Valken Kruger**
> ""Your lies know no bound. Fortunately, we don't care if you 'play along' or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“One day, the people of Sordland will look back and curse..."*)
  - -> `[99]` (*Player: "“Just get on with it then. Finish it.”"*)
  - -> `[100]` (*Player: "“At least let me see my family again. They are innocent.”"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Iosef Lancea: "“No, not really.”"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Valken Kruger: "“No, not really.”"*)

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“No, not really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "His mouth twitched upwards as a smirk started forming on ..."*)

### Węzeł `[88]`
Mówca: **Valken Kruger**
> "“No, not really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "His mouth twitched upwards as a smirk started forming on ..."*)

### Węzeł `[89]`
Mówca: **Valken Kruger**
> "“You dare threaten the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“One day, the people of Sordland will look back and curse..."*)
  - -> `[99]` (*Player: "“Just get on with it then. Finish it.”"*)
  - -> `[100]` (*Player: "“At least let me see my family again. They are innocent.”"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Iosef Lancea: "“You dare threaten the head of your own country's militar..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Valken Kruger: "“You dare threaten the head of your own country's militar..."*)

### Węzeł `[93]`
Mówca: **Iosef Lancea**
> "“You dare threaten the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“One day, the people of Sordland will look back and curse..."*)
  - -> `[99]` (*Player: "“Just get on with it then. Finish it.”"*)
  - -> `[100]` (*Player: "“At least let me see my family again. They are innocent.”"*)

### Węzeł `[94]`
Mówca: **Valken Kruger**
> "“You dare say that to the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“One day, the people of Sordland will look back and curse..."*)
  - -> `[99]` (*Player: "“Just get on with it then. Finish it.”"*)
  - -> `[100]` (*Player: "“At least let me see my family again. They are innocent.”"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“You dare say that to the head of your own country's mili..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Valken Kruger: "“You dare say that to the head of your own country's mili..."*)

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“You dare say that to the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“One day, the people of Sordland will look back and curse..."*)
  - -> `[99]` (*Player: "“Just get on with it then. Finish it.”"*)
  - -> `[100]` (*Player: "“At least let me see my family again. They are innocent.”"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Just get on with it then. Finish it.”"]** — Mówca: **Player**
> "“Just get on with it then. Finish it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Iosef Lancea), `[83]` (Valken Kruger), `[89]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“At least let me see my family again. They are innocent.”"]** — Mówca: **Player**
> "“At least let me see my family again. They are innocent.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Iosef Lancea), `[83]` (Valken Kruger), `[89]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“One day, the people of Sordland will look back and curse your name for what you have done.”"]** — Mówca: **Player**
> "“One day, the people of Sordland will look back and curse your name for what you have done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Iosef Lancea), `[83]` (Valken Kruger), `[89]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[102]`
Mówca: **Iosef Lancea**
> "“You are wrong, Mr. Rayne. They will thank me for getting rid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Iosef Lancea: "“You are wrong, Mr. Rayne. They will thank me for getting..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Valken Kruger: "“You are wrong, Mr. Rayne. They will thank me for getting..."*)

### Węzeł `[106]`
Mówca: **Valken Kruger**
> "“You are wrong, Mr. Rayne. They will thank me for getting rid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[107]`
Mówca: **Valken Kruger**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Iosef Lancea: "“Gladly.”"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Valken Kruger: "“Gladly.”"*)

### Węzeł `[112]`
Mówca: **Valken Kruger**
> "“We do not negotiate with traitors, Mr. Rayne. Permission denied.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Iosef Lancea: "“We do not negotiate with traitors, Mr. Rayne. Permission..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Valken Kruger: "“We do not negotiate with traitors, Mr. Rayne. Permission..."*)

### Węzeł `[116]`
Mówca: **Iosef Lancea**
> "“We do not negotiate with traitors, Mr. Rayne. Permission denied.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Iosef walked toward me and leaned in as he murmured faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Iosef Lancea: "“Don't worry too much, Mr. Rayne, we will make good use o..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Iosef walked toward me and leaned in as he murmured faintly."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Valken walked toward me and leaned in as he murmured fain..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "He swiftly moved back and adjusted his uniform before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "I was the only one loaded into the prison truck. After a couple of hours had passed, we finally came to a stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "After I exited the vehicle, I held my head up and saw the..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "After I exited the vehicle, I held my head up and saw the insignia of the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Soldiers grabbed my arms and led me inside. They gestured..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“This is ridiculous! You have no proof!”"]** — Mówca: **Player**
> "“This is ridiculous! You have no proof!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Iosef Lancea), `[41]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“High treason? I would never betray my country. You know that more than anyone.”"]** — Mówca: **Player**
> "“High treason? I would never betray my country. You know that more than anyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Iosef Lancea), `[41]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“If there is any betrayal here, it is yours against your democratically elected president and government.”"]** — Mówca: **Player**
> "“If there is any betrayal here, it is yours against your democratically elected president and government.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Iosef Lancea), `[41]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Iosef Lancea: "“Shut your mouth. You will only speak when you are spoken..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Valken Kruger: "“Shut your mouth. You will only speak when you are spoken..."*)

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“Shut your mouth. You will only speak when you are spoken to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[131]`
Mówca: **Valken Kruger**
> "“Shut your mouth. You will only speak when you are spoken to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[132]`
Mówca: **Valken Kruger**
> "“Don't worry too much, Mr. Rayne, we will make good use of the economy you left for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“Don't worry too much, Mr. Rayne, we will make good use of the economy you left for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Iosef Lancea: "“First and foremost, you have sold your own country, your..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unres..."*)

### Węzeł `[137]`
Mówca: **Iosef Lancea**
> "“First and foremost, you have sold your own country, your own people, to Rumburg. You have conceded Estord and Narbel to our sworn enemies. I have never seen such cowardice and betrayal. Even Alphonso didn't fall so low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unres..."*)

### Węzeł `[138]`
Mówca: **Valken Kruger**
> "“First and foremost, you have sold your own country, your own people, to Rumburg. You have conceded Estord and Narbel to our sworn enemies. I have never seen such cowardice and betrayal. Even Alphonso didn't fall so low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unres..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Valken Kruger: "“First and foremost, you have sold your own country, your..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unres..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unres..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unr..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Iosef Lancea: "“Instead of giving the order to destroy the BFF, you deci..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unres..."*)

### Węzeł `[145]`
Mówca: **Iosef Lancea**
> "“Instead of giving the order to destroy the BFF, you decided to side with known rebels that we have been fighting for years. You betrayed loyal Sords who sacrificed themselves for their country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unres..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unres..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unr..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Iosef Lancea: "“You have failed to govern your people and instead, as a ..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[149]`
Mówca: **Iosef Lancea**
> "“You have failed to govern your people and instead, as a result of your actions, they are revolting. If you can't put an end to this, then we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[150]`
Mówca: **Valken Kruger**
> "“Instead of giving the order to destroy the BFF, you decided to side with known rebels that we have been fighting for years. You betrayed loyal Sords who sacrificed themselves for their country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unres..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unres..."*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unr..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Valken Kruger: "“Instead of giving the order to destroy the BFF, you deci..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unres..."*)

### Węzeł `[154]`
Mówca: **Valken Kruger**
> "“You have failed to govern your people and instead, as a result of your actions, they are revolting. If you can't put an end to this, then we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unres..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unr..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Valken Kruger: "“You have failed to govern your people and instead, as a ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[158]`
Mówca: **Iosef Lancea**
> "“Do you know why you are here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: "“Yes, I do.”"*)
  - -> `[161]` (*Player: "“No, I don't.”"*)

### Węzeł `[159]`
Mówca: **Valken Kruger**
> "“Do you know why you are here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "“Yes, I do.”"*)
  - -> `[162]` (*Player: "“No, I don't.”"*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Iosef Lancea: "“We all know our sins.”"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“No, I don't.”"]** — Mówca: **Player**
> "“No, I don't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Iosef Lancea: "“Hah. As expected. Acting innocent until the end.”"*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“No, I don't.”"]** — Mówca: **Player**
> "“No, I don't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Valken Kruger: "“And we let this man be our President.”"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Valken Kruger: "“At least he is aware.”"*)

### Węzeł `[164]`
Mówca: **Iosef Lancea**
> "“Hah. As expected. Acting innocent until the end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Iosef Lancea: "“You are accused of high treason against Sordland, Mr. Ra..."*)

### Węzeł `[165]`
Mówca: **Valken Kruger**
> "“And we let this man be our President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Valken Kruger: "“You are accused of high treason against Sordland, Mr. Ra..."*)

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> "“We all know our sins.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Iosef Lancea: "“You are accused of high treason against Sordland, Mr. Ra..."*)

### Węzeł `[167]`
Mówca: **Valken Kruger**
> "“At least he is aware.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Valken Kruger: "“You are accused of high treason against Sordland, Mr. Ra..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Valken Kruger: "“And had him brutally executed!”"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Valken Kruger: "“It is clear to me that you are actively trying to destro..."*)

### Węzeł `[171]`
Mówca: **Valken Kruger**
> "“And had him brutally executed!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Valken Kruger: "“It is clear to me that you are actively trying to destro..."*)

### Węzeł `[172]`
Mówca: **Iosef Lancea**
> "“And had him brutally executed!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“It is clear to me that you are actively trying to destro..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Iosef Lancea: "“And had him brutally executed!”"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“It is clear to me that you are actively trying to destro..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_IncreasedLivingStandards == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_IncreasedLivingStandards == true && B..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_IncreasedLivingStandards == true &&..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_IncreasedLivingStandards == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_IncreasedLivingStandards"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: "“I've made Sordland a better place. Every Sord is living ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_IncreasedLivingStandards == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_IncreasedLivingStandards"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIs..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "“I dragged Sordland out of a recession and brought us to ..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
**[WYBÓR GRACZA: "“I've made Sordland a better place. Every Sord is living a pleasant life because of me.""]** — Mówca: **Player**
> "“I've made Sordland a better place. Every Sord is living a pleasant life because of me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_EnT_IncreasedLivingStandards"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Iosef Lancea), `[74]` (Valken Kruger), `[186]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Iosef Lancea: "“Mr. Rayne, you can't toss us a bone and expect us to liv..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Valken Kruger: "“Mr. Rayne, you can't toss us a bone and expect us to liv..."*)

### Węzeł `[186]`
Mówca: **Valken Kruger**
> "“Mr. Rayne, you can't toss us a bone and expect us to live in bliss ignorance of your crime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingSt..."*)

### Węzeł `[187]`
Mówca: **Iosef Lancea**
> "“Mr. Rayne, you can't toss us a bone and expect us to live in bliss ignorance of your crime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingSt..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I dragged Sordland out of a recession and brought us to a golden age. Without me, this republic would have crumbled. The people see me as a hero.""]** — Mówca: **Player**
> "“I dragged Sordland out of a recession and brought us to a golden age. Without me, this republic would have crumbled. The people see me as a hero.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Iosef Lancea), `[74]` (Valken Kruger), `[186]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[189]`
Mówca: **Valken Kruger**
> "“But the people have yet to know the cost it took, Mr. Rayne. When they know of your crimes, no one will still stand by you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishR..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Iosef Lancea: "“But the people have yet to know the cost it took, Mr. Ra..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Valken Kruger: "“But the people have yet to know the cost it took, Mr. Ra..."*)

### Węzeł `[193]`
Mówca: **Iosef Lancea**
> "“But the people have yet to know the cost it took, Mr. Rayne. When they know of your crimes, no one will still stand by you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishR..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Plead Unguilty Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_IncreasedLivingStandards == true && B..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true && B..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIs..."*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Unlawful..."*)
  - -> `[77]` (*Player: "“It doesn't matter what I say, does it?”"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Plead Unguilty Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Plead Unguilty Hub"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“I see what this is. This is all a ploy to end Sordish de..."*)
  - -> `[76]` (*Player: "“I will make it out of this and one day, you will be sorr..."*)
  - -> `[75]` (*Player: "“You know what, screw you!”"*)

### Węzeł `[197]`
Mówca: **Narrator**
> "His mouth twitched upwards as a smirk started forming on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[198]`
Mówca: **Narrator**
> "His mouth twitched upwards as a smirk started forming on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [Plead Unguilty Hub]"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [Plead Unguilty Hub]"*)

### Węzeł `[201]`
Mówca: **Iosef Lancea**
> "“No need to delay this further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Iosef Lancea: "“I will now announce the verdict on this case.”"*)

### Węzeł `[202]`
Mówca: **Valken Kruger**
> "“No need to delay this further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Valken Kruger: "“I will now announce the verdict on this case.”"*)

### Węzeł `[203]`
Mówca: **Valken Kruger**
> "“I will now announce the verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "I took a deep breath."*)

### Węzeł `[204]`
Mówca: **Iosef Lancea**
> "“I will now announce the verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "I took a deep breath."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_CoupTrial = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_CoupTrial = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn11_SnO_CoupTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[211]`
Mówca: **Narrator**
> "Valken walked toward me and leaned in as he murmured faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Valken Kruger: "“Don't worry too much, Mr. Rayne, we will make good use o..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true && B..."*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true &&..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“I gave you support so you can protect this country. Inst..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[215]`
Mówca: **Valken Kruger**
> "“We are doing what we were assigned to do. Protect this country. At this very moment, we are protecting it from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Increase..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Iosef Lancea: "“We are doing what we were assigned to do. Protect this c..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Valken Kruger: "“We are doing what we were assigned to do. Protect this c..."*)

### Węzeł `[219]`
Mówca: **Iosef Lancea**
> "“We are doing what we were assigned to do. Protect this country. At this very moment, we are protecting it from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Increase..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [Plead Unguilty Hub]"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“I gave you support so you can protect this country. Instead, you've chosen to depose your own president!?""]** — Mówca: **Player**
> "“I gave you support so you can protect this country. Instead, you've chosen to depose your own president!?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Iosef Lancea), `[74]` (Valken Kruger), `[186]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“This is criminal. You have neither the right nor the authority to judge me.""]** — Mówca: **Player**
> "“This is criminal. You have neither the right nor the authority to judge me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Iosef Lancea), `[74]` (Valken Kruger), `[186]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Default == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Assembly == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Harder == true"*)
  - -> `[246]` (*Player: "“This is a power grab in the disguise of protecting the r..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Removed == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Iosef Lancea: ""You finished?""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Valken Kruger: ""You finished?""*)

### Węzeł `[226]`
Mówca: **Iosef Lancea**
> ""You finished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Iosef Lancea: ""Shall we move on then?""*)

### Węzeł `[227]`
Mówca: **Valken Kruger**
> ""You finished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Valken Kruger: ""Shall we move on then?""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Unlawful..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Harder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Harder == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Impeachment_Harder == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Harder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Harder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "“Where are the members of the assembly and the justices!?""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Impeachment_Harder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Harder"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Default == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Impeachment_Default == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player: "“Where are the justices!?""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Removed == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Impeachment_Removed == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: "“By the law, I cannot be judged!”"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Impeachment_Assembly == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Impeachment_Assembly == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "“Where are the members of the assembly!?""*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[241]`
**[WYBÓR GRACZA: "“Where are the members of the assembly and the justices!?""]** — Mówca: **Player**
> "“Where are the members of the assembly and the justices!?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Impeachment_Harder"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Where are the justices!?""]** — Mówca: **Player**
> "“Where are the justices!?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Impeachment_Default"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "“By the law, I cannot be judged!”"]** — Mówca: **Player**
> "“By the law, I cannot be judged!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[244]`
**[WYBÓR GRACZA: "“Where are the members of the assembly!?""]** — Mówca: **Player**
> "“Where are the members of the assembly!?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Impeachment_Assembly"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: "“This is a power grab in the disguise of protecting the r..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: "“This is a power grab in the disguise of protecting the republic, I demand a proper trial.”"]** — Mówca: **Player**
> "“This is a power grab in the disguise of protecting the republic, I demand a proper trial.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Player), `[241]` (Player), `[242]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[247]`
Mówca: **Iosef Lancea**
> ""The *law* that you wrote and passed for yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Iosef Lancea: ""What a joke!""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Iosef Lancea: ""The *law* that you wrote and passed for yourself?""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Valken Kruger: ""The *law* that you wrote and passed for yourself?""*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Unlawful..."*)

### Węzeł `[252]`
Mówca: **Valken Kruger**
> ""The *law* that you wrote and passed for yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Valken Kruger: ""What a joke!""*)

### Węzeł `[253]`
Mówca: **Iosef Lancea**
> ""Shall we move on then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[254]`
Mówca: **Valken Kruger**
> ""Shall we move on then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[255]`
Mówca: **Iosef Lancea**
> ""What a joke!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[256]`
Mówca: **Valken Kruger**
> ""What a joke!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [Plead Unguilty Hub]"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Unlawful..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_Unlawf..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: "“This is criminal. You have neither the right nor the aut..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Italic: "Spit on his face."*)
  - -> `[263]` (*Player_Italic: "Throw a punch at his jaw."*)
  - -> `[264]` (*Player_Italic: "Stare a spiteful gaze into his eyes."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: "Spit on his face."]** — Mówca: **Player_Italic**
> "I spat on his face."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Valken Kruger), `[133]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "He swiped the saliva off his face and rubbed it on your s..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA: "Throw a punch at his jaw."]** — Mówca: **Player_Italic**
> "I punched his jaw."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Valken Kruger), `[133]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Your punch connected but he barely flinched."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "Stare a spiteful gaze into his eyes."]** — Mówca: **Player_Italic**
> "I stared into his eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Valken Kruger), `[133]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "He swiftly moved back and adjusted his uniform before con..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "He swiped the saliva off his face and rubbed it on your suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "He swiftly moved back and adjusted his uniform before con..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Your punch connected but he barely flinched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[267]`
Mówca: **Iosef Lancea**
> ""Weak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "He swiftly moved back and adjusted his uniform before con..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Iosef Lancea: ""Weak.""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Valken Kruger: ""Weak.""*)

### Węzeł `[271]`
Mówca: **Valken Kruger**
> ""Weak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "He swiftly moved back and adjusted his uniform before con..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Iosef Lancea: "“No need to delay this further.”"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Valken Kruger: "“No need to delay this further.”"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
