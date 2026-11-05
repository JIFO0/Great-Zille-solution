# Sordland/Turn09/SnO_MilitaryParade

- **ID konwersacji:** `207`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/207_SnO_MilitaryParade.md`
- **Liczba węzłów dialogowych:** 306
- **Liczba wyborów gracza:** 59

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[54]** Serge Wolkner
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_Coup`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Situation_Military_ExperiencedGenerals`
- `BaseGame.Situation_Military_GreenGenerals`
- `BaseGame.Situation_Military_ModernisedAirForce`
- `BaseGame.Situation_Military_ModernisedArmy`
- `BaseGame.Situation_Military_OutdatedMilitaryEquipment`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGameIsolated.Turn09_A_Parade_IosefWithYou`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_SergeFuneral`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGameIsolated.Turn09_A_Parade_IosefWithYou`
- `BaseGameSupport.CountryReport_Turn10_Agnolia_CondolencesAssasination`
- `BaseGameSupport.Journal_Turn09_MilitaryParade_Survived`
- `BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead`
- `BaseGameSupport.News_Turn09_HP_MilitaryParade_Assassination`
- `BaseGameSupport.News_Turn09_LT_MilitaryParade_Assassination`
- `BaseGameSupport.News_Turn09_R_MilitaryParade_Assassination`
- `BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination`
- `BaseGameSupport.Report_Turn09_Holsord_Assassination`
- `BaseGameSupport.Report_Turn09_Holsord_Parade`
- `GameCondition.Turn09_SnO_MilitaryParade`
- `GameCondition.Turn10_Personal_SergeFuneral`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“Let's get this over with.”"** | `[12]` **Iosef Lancea**: "“We will depart right after the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Iosef nodded." |
| `[7]` | **"Nod."** | `[56]` **Iosef Lancea**: "“Do you remember those days?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Serge Wolkner**: "“We are here, sir.”"<br>`[57]` **Iosef Lancea**: "“I also remember, Mr. President ..." |
| `[13]` | **"“Good.”"** | `[12]` **Iosef Lancea**: "“We will depart right after the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Iosef nodded." |
| `[15]` | **"“Rumburg will think twice after today.”"** | `[12]` **Iosef Lancea**: "“We will depart right after the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Iosef Lancea**: "“They will tremble before the So..." |
| `[23]` | **"“Strict as ever.”"** | `[21]` **Narrator**: "He performed an excellent salute..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Iosef Lancea**: "“Old habits die hard.”" |
| `[24]` | **"“Doesn't give me much confidence that our soldiers do not even know how to properl..."** | `[21]` **Narrator**: "He performed an excellent salute..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Iosef Lancea**: "“I will have him educated.”" |
| `[25]` | **"“Is it time yet?”"** | `[21]` **Narrator**: "He performed an excellent salute..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Iosef Lancea**: "“Very soon.”" |
| `[36]` | **"“Yes, Serge. I have seen it.”"** | `[35]` **Serge Wolkner**: "“Rumburg will be so scared when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Serge Wolkner**: "“My kids were very excited to wa..." |
| `[37]` | **"“That is the plan.”"** | `[35]` **Serge Wolkner**: "“Rumburg will be so scared when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Serge Wolkner**: "“A great one, I'd say.”" |
| `[38]` | **"“I sure hope so.”"** | `[35]` **Serge Wolkner**: "“Rumburg will be so scared when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Serge Wolkner**: "“I am sure, Mr. President.”" |
| `[50]` | **"“Unfortunately, I do. Rough times.”"** | `[56]` **Iosef Lancea**: "“Do you remember those days?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Iosef Lancea**: "“Indeed. Those were rough times.”" |
| `[51]` | **"“Who can forget about Major Lancea? We called him 'The Relentless'.”"** | `[56]` **Iosef Lancea**: "“Do you remember those days?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Narrator**: "Iosef let out a long laugh." |
| `[58]` | **"“I did what needed to be done.”"** | `[57]` **Iosef Lancea**: "“I also remember, Mr. President ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Iosef Lancea**: "“Which was disobeying orders. Bu..." |
| `[59]` | **"“It's in the past now.”"** | `[57]` **Iosef Lancea**: "“I also remember, Mr. President ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Iosef Lancea**: "“True.”" |
| `[60]` | **"“Let's cut the chit chat and do what we are here to do.”"** | `[57]` **Iosef Lancea**: "“I also remember, Mr. President ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Iosef Lancea**: "“Very well.”" |
| `[69]` | **"Wave."** | `[68]` **Narrator**: "We waited for a few minutes for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "We kept our slow and steady pace..."<br>`[258]` **Narrator**: "Looking at the benches where the..."<br>*(oraz 1 innych odgałęzień)* |
| `[70]` | **"Salute."** | `[68]` **Narrator**: "We waited for a few minutes for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "We kept our slow and steady pace..."<br>`[258]` **Narrator**: "Looking at the benches where the..."<br>*(oraz 1 innych odgałęzień)* |
| `[71]` | **"Raise your fist."** | `[68]` **Narrator**: "We waited for a few minutes for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "We kept our slow and steady pace..."<br>`[258]` **Narrator**: "Looking at the benches where the..."<br>*(oraz 1 innych odgałęzień)* |
| `[74]` | **"“Hey Iosef, is that truck part of the parade?”"** | `[73]` **Narrator**: "The convoy continued. As I looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Iosef Lancea**: "“Yes it is, sir. Although I am n..." |
| `[75]` | **"Shrug it off."** | `[73]` **Narrator**: "The convoy continued. As I looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "We continued and neared the statue." |
| `[81]` | **"“Was this scheduled?”"** | `[79]` **Narrator**: "The truck was standing in the mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Iosef Lancea**: "“No.”" |
| `[82]` | **"“What is going on? Do you see the truck?”"** | `[79]` **Narrator**: "The truck was standing in the mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Iosef Lancea**: "“Something is not right.”" |
| `[90]` | **"“SERGE! FLOOR IT! NOW!”"** | `[89]` **Narrator**: "In a split second Iosef pulled h..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[92]` **Narrator**: "Serge quickly accelerated the ca..." |
| `[91]` | **"“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"** | `[89]` **Narrator**: "In a split second Iosef pulled h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Serge reversed the car at full s..." |
| `[96]` | **"“I'm okay.”"** | `[95]` **Iosef Lancea**: "<shout>“ANSWER ME.”</shout>" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Iosef Lancea**: "“Thank God! He is alive!”" |
| `[97]` | **"“What just happened!?”"** | `[95]` **Iosef Lancea**: "<shout>“ANSWER ME.”</shout>" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Iosef Lancea**: "“Thank God! He is alive!”" |
| `[102]` | **"“Nevermind me. Are you alright?”"** | `[101]` **Narrator**: "He was bleeding." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Iosef Lancea**: "“It's just a bullet in the shoul..." |
| `[103]` | **"“Are we safe?”"** | `[101]` **Narrator**: "He was bleeding." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Iosef Lancea**: "“We are for now.”" |
| `[110]` | **"“What happened to the attackers?”"** | `[101]` **Narrator**: "He was bleeding." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Iosef Lancea**: "“They are dead. I got one of the..." |
| `[112]` | **"“THEY WILL PAY FOR THIS.”"** | `[109]` **Narrator**: "I froze." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Iosef Lancea**: "“They will, sir.”" |
| `[113]` | **"“No. This can't be true.”"** | `[109]` **Narrator**: "I froze." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Iosef Lancea**: "“I'm afraid it is.”" |
| `[129]` | **"“I SAID GET DOWN!”"** | `[128]` **Narrator**: "I saw the wound on Iosef's right..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "As he stumbled, he pointed his p..." |
| `[130]` | **"Pull him back to the cover."** | `[128]` **Narrator**: "I saw the wound on Iosef's right..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "As he stumbled, he pointed his p..." |
| `[133]` | **"“Are they dead? Is it over?”"** | `[132]` **Narrator**: "A brief gunfight ensued outside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "Iosef turned to me after grunting." |
| `[134]` | **"“Iosef, are you okay?”"** | `[132]` **Narrator**: "A brief gunfight ensued outside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "Iosef turned to me after grunting." |
| `[136]` | **"“Is everyone alright!?”"** | `[95]` **Iosef Lancea**: "<shout>“ANSWER ME.”</shout>" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Iosef Lancea**: "“Thank God! He is alive!”" |
| `[143]` | **"“I'm fine. Are you injured?”"** | `[142]` **Serge Wolkner**: "<shout>“SIR! ARE YOU ALRIGHT?”</..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "He patted himself down." |
| `[144]` | **"“No, Serge. I won't be fine until they pay for what they have done.”"** | `[142]` **Serge Wolkner**: "<shout>“SIR! ARE YOU ALRIGHT?”</..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Serge Wolkner**: "“They will pay, sir.”" |
| `[211]` | **"“Hey Serge, is that truck part of the parade?”"** | `[209]` **Narrator**: "The convoy continued. As I looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Serge Wolkner**: "“I think so, Mr. President. Alth..." |
| `[212]` | **"Shrug it off."** | `[209]` **Narrator**: "The convoy continued. As I looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "We continued and neared the statue." |
| `[215]` | **"“Was this scheduled?”"** | `[214]` **Narrator**: "The truck was standing in the mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Serge Wolkner**: "“I- I don't think so, sir.”" |
| `[217]` | **"“What is going on? Do you see the truck?”"** | `[214]` **Narrator**: "The truck was standing in the mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Serge Wolkner**: "“I- I don't know, sir.”" |
| `[224]` | **"“SERGE! FLOOR IT! NOW!”"** | `[223]` **Narrator**: "Three men who jumped out of the ..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[225]` **Narrator**: "Serge quickly accelerated the car." |
| `[229]` | **"“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"** | `[223]` **Narrator**: "Three men who jumped out of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "Serge reversed the car at full s..." |
| `[231]` | **"Start praying."** | `[228]` **Narrator**: "The car hit one of the soldiers...." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushEnd");` | `[230]` **Narrator**: "I regained consciousness after t..." |
| `[235]` | **"“I'm fine. Are you injured?”"** | `[239]` **Serge Wolkner**: "<shout>“SIR! ARE YOU ALRIGHT?”</..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Narrator**: "He pat himself down." |
| `[240]` | **"“No, Serge. I won't be fine until they pay for what they have done.”"** | `[239]` **Serge Wolkner**: "<shout>“SIR! ARE YOU ALRIGHT?”</..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Serge Wolkner**: "“They will pay, sir.”" |
| `[250]` | **"Hold on as tightly as you can."** | `[228]` **Narrator**: "The car hit one of the soldiers...." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushEnd");` | `[230]` **Narrator**: "I regained consciousness after t..." |
| `[251]` | **"Close your eyes."** | `[228]` **Narrator**: "The car hit one of the soldiers...." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushEnd");` | `[230]` **Narrator**: "I regained consciousness after t..." |
| `[252]` | **"Close your eyes."** | `[232]` **Narrator**: "Serge reversed the car at full s..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[233]` **Narrator**: "They started firing and my ears ..." |
| `[253]` | **"Start praying."** | `[232]` **Narrator**: "Serge reversed the car at full s..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[233]` **Narrator**: "They started firing and my ears ..." |
| `[254]` | **"Duck down."** | `[232]` **Narrator**: "Serge reversed the car at full s..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[233]` **Narrator**: "They started firing and my ears ..." |
| `[255]` | **"Duck down."** | `[93]` **Narrator**: "Serge reversed the car at full s..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[126]` **Narrator**: "They started firing and my ears ..." |
| `[256]` | **"Close your eyes."** | `[93]` **Narrator**: "Serge reversed the car at full s..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[126]` **Narrator**: "They started firing and my ears ..." |
| `[257]` | **"Start praying."** | `[93]` **Narrator**: "Serge reversed the car at full s..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushStart");` | `[126]` **Narrator**: "They started firing and my ears ..." |
| `[280]` | **"Start praying."** | `[279]` **Narrator**: "The car hit one of the soldiers...." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushEnd");` | `[284]` **Narrator**: "I regained consciousness after t..." |
| `[281]` | **"Close your eyes."** | `[279]` **Narrator**: "The car hit one of the soldiers...." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushEnd");` | `[284]` **Narrator**: "I regained consciousness after t..." |
| `[283]` | **"Hold on as tightly as you can."** | `[279]` **Narrator**: "The car hit one of the soldiers...." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AmbushEnd");` | `[284]` **Narrator**: "I regained consciousness after t..." |
| `[285]` | **"“He did nothing wrong.”"** | `[109]` **Narrator**: "I froze." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Iosef Lancea**: "“He served his country until the..." |

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
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was an unusual day for the residents of Holsord. Regularly used streets and avenues were blocked off by the military personnel. Many shops and cafes were closed and once crowded stores were now empty. Instead, thousands of residents in Holsord were concentrated in one street, Victory Avenue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Stretching out through the heart of Holsord, people on bo..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Stretching out through the heart of Holsord, people on both sides of the road were waving their Sordish flags proudly for the military parade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I was getting prepared to embark on my trip. It was going..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I was getting prepared to embark on my trip. It was going to be a short drive down the Victory Avenue until we reached Maroon Palace. My company for this trip was Iosef with Serge, as usual, driving the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Iosef approached me. He was wearing his decorated ceremon..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Let's get this over with.”"]** — Mówca: **Player**
> "“Let's get this over with.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Iosef nodded."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)

### Węzeł `[8]`
Mówca: **Iosef Lancea**
> "“Mr. President. We are almost ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Iosef Lancea: "“We will depart right after the tank column.”"*)

### Węzeł `[9]`
Mówca: **Serge Wolkner**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Serge Wolkner: "“Mr. Lancea.”"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Iosef approached me. He was wearing his decorated ceremony outfit. He carried a sword with a goat head at the handle and his pistol by his hip. He put on his cap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Iosef Lancea: "“Mr. President. We are almost ready.”"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Serge appeared from the entrance and joined us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Serge Wolkner: "“Mr. President.”"*)

### Węzeł `[12]`
Mówca: **Iosef Lancea**
> "“We will depart right after the tank column.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“Good.”"*)
  - -> `[6]` (*Player: "“Let's get this over with.”"*)
  - -> `[15]` (*Player: "“Rumburg will think twice after today.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good.”"]** — Mówca: **Player**
> "“Good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Iosef nodded."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "After hearing the loud thump of a book falling down to the floor, he turned to a couple of privates that were doing the preparations on the schedule and started walking in their direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Iosef Lancea: "“Private! Can't you do your job properly?”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Rumburg will think twice after today.”"]** — Mówca: **Player**
> "“Rumburg will think twice after today.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Iosef Lancea: "“They will tremble before the Sordish military might.”"*)

### Węzeł `[16]`
Mówca: **Iosef Lancea**
> "“They will tremble before the Sordish military might.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "After hearing the loud thump of a book falling down to th..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Iosef nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "After hearing the loud thump of a book falling down to th..."*)

### Węzeł `[18]`
Mówca: **Iosef Lancea**
> "“Private! Can't you do your job properly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I watched the young soldiers perform a lousy salute to Io..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I watched the young soldiers perform a lousy salute to Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Iosef Lancea: "“WHAT IS THAT SALUTE SOLDIER? WATCH! THIS IS A REAL SALUTE!”"*)

### Węzeł `[20]`
Mówca: **Iosef Lancea**
> "“WHAT IS THAT SALUTE SOLDIER? WATCH! THIS IS A REAL SALUTE!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "He performed an excellent salute and after scolding the p..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "He performed an excellent salute and after scolding the privates he walked back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Strict as ever.”"*)
  - -> `[24]` (*Player: "“Doesn't give me much confidence that our soldiers do not..."*)
  - -> `[25]` (*Player: "“Is it time yet?”"*)

### Węzeł `[22]`
Mówca: **Iosef Lancea**
> "“Old habits die hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Serge appeared from the entrance and joined us."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Strict as ever.”"]** — Mówca: **Player**
> "“Strict as ever.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Iosef Lancea: "“Old habits die hard.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Doesn't give me much confidence that our soldiers do not even know how to properly salute.”"]** — Mówca: **Player**
> "“Doesn't give me much confidence that our soldiers do not even know how to properly salute.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Iosef Lancea: "“I will have him educated.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Is it time yet?”"]** — Mówca: **Player**
> "“Is it time yet?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Iosef Lancea: "“Very soon.”"*)

### Węzeł `[26]`
Mówca: **Iosef Lancea**
> "“I will have him educated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Serge appeared from the entrance and joined us."*)

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“Very soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Serge appeared from the entrance and joined us."*)

### Węzeł `[28]`
Mówca: **Serge Wolkner**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Serge performed a salute to Iosef which made Iosef smile ..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Serge performed a salute to Iosef which made Iosef smile under his moustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Iosef Lancea: "“At ease, Mr. Wolkner.”"*)

### Węzeł `[30]`
Mówca: **Iosef Lancea**
> "“At ease, Mr. Wolkner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Iosef Lancea: "“Are we ready to depart yet?”"*)

### Węzeł `[31]`
Mówca: **Iosef Lancea**
> "“Are we ready to depart yet?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Serge Wolkner: "“Yes, sir. Follow me please.”"*)

### Węzeł `[32]`
Mówca: **Serge Wolkner**
> "“Yes, sir. Follow me please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "We started following Serge through the corridors."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "We started following Serge through the corridors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Serge Wolkner: "“Mr. President. Have you seen the tanks? Our planes too?”"*)

### Węzeł `[34]`
Mówca: **Serge Wolkner**
> "“Mr. President. Have you seen the tanks? Our planes too?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Serge Wolkner: "“Rumburg will be so scared when they see this.”"*)

### Węzeł `[35]`
Mówca: **Serge Wolkner**
> "“Rumburg will be so scared when they see this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“Yes, Serge. I have seen it.”"*)
  - -> `[37]` (*Player: "“That is the plan.”"*)
  - -> `[38]` (*Player: "“I sure hope so.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Yes, Serge. I have seen it.”"]** — Mówca: **Player**
> "“Yes, Serge. I have seen it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Serge Wolkner: "“My kids were very excited to wake up today. You know. To..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“That is the plan.”"]** — Mówca: **Player**
> "“That is the plan.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Serge Wolkner: "“A great one, I'd say.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“I sure hope so.”"]** — Mówca: **Player**
> "“I sure hope so.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Serge Wolkner: "“I am sure, Mr. President.”"*)

### Węzeł `[39]`
Mówca: **Serge Wolkner**
> "“A great one, I'd say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Serge Wolkner: "“My kids were very excited to wake up today. You know. To..."*)

### Węzeł `[40]`
Mówca: **Serge Wolkner**
> "“My kids were very excited to wake up today. You know. To see the planes fly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Iosef Lancea: "“Serge, where did you do your military service?”"*)

### Węzeł `[41]`
Mówca: **Serge Wolkner**
> "“I am sure, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Serge Wolkner: "“My kids were very excited to wake up today. You know. To..."*)

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“Serge, where did you do your military service?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Serge Wolkner: "“Morna. 7th Artillery Squadron. I still talk with many of..."*)

### Węzeł `[43]`
Mówca: **Serge Wolkner**
> "“Morna. 7th Artillery Squadron. I still talk with many of my friends from those days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Iosef Lancea: "“The camaraderie of military is never forgotten. I'm stil..."*)

### Węzeł `[44]`
Mówca: **Iosef Lancea**
> "“The camaraderie of military is never forgotten. I'm still in touch with my friends from basic training as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Serge Wolkner: "“What about you, sir? Where did you serve?”"*)

### Węzeł `[45]`
Mówca: **Serge Wolkner**
> "“What about you, sir? Where did you serve?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: "“All over Sordland. You know, Mr. President was under my ..."*)

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“All over Sordland. You know, Mr. President was under my command once. Gumren Outpost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He turned to me."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Military_Order_Accomplished == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Serge Wolkner: "“We are here, sir.”"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Military_Order_Accomplished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Iosef Lancea: "“I also remember, Mr. President did not like to execute d..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Unfortunately, I do. Rough times.”"]** — Mówca: **Player**
> "“I do. Rough times.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Iosef Lancea: "“Indeed. Those were rough times.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Who can forget about Major Lancea? We called him 'The Relentless'.”"]** — Mówca: **Player**
> "“Who can forget about Major Lancea? We called him 'The Relentless'.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Iosef let out a long laugh."*)

### Węzeł `[52]`
Mówca: **Iosef Lancea**
> "“Indeed. Those were rough times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)

### Węzeł `[53]`
Mówca: **Iosef Lancea**
> "“Good old days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Iosef let out a long laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Iosef Lancea: "“Good old days.”"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“Do you remember those days?”"*)

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“Do you remember those days?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Italic: "Nod."*)
  - -> `[50]` (*Player: "“Unfortunately, I do. Rough times.”"*)
  - -> `[51]` (*Player: "“Who can forget about Major Lancea? We called him 'The Re..."*)

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“I also remember, Mr. President did not like to execute direct orders from his superiors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“It's in the past now.”"*)
  - -> `[58]` (*Player: "“I did what needed to be done.”"*)
  - -> `[60]` (*Player: "“Let's cut the chit chat and do what we are here to do.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“I did what needed to be done.”"]** — Mówca: **Player**
> "“I did what needed to be done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Iosef Lancea: "“Which was disobeying orders. But I won't delve into the ..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“It's in the past now.”"]** — Mówca: **Player**
> "“It's in the past now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Iosef Lancea: "“True.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Let's cut the chit chat and do what we are here to do.”"]** — Mówca: **Player**
> "“Let's cut the chit chat and do what we are here to do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Iosef Lancea: "“Very well.”"*)

### Węzeł `[61]`
Mówca: **Iosef Lancea**
> "“Which was disobeying orders. But I won't delve into the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Serge Wolkner: "“We are here, sir.”"*)

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“True.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Serge Wolkner: "“We are here, sir.”"*)

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Serge Wolkner: "“We are here, sir.”"*)

### Węzeł `[64]`
Mówca: **Serge Wolkner**
> "“We are here, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "We exited the building and walked over to the clearance where the black Kadila, the presidential car, was waiting. It was decorated properly for the event and the top canopy had been removed so that we could stand and wave to people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ExperiencedGenerals == true"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "We entered the car and Serge started the engine. Iosef was standing right next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "The car started rolling."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "A group of ten, maybe twelve latest technology S-16 fighter jets flew above our heads and I thought that the engine sounds was going to leave me deaf. Loud footsteps of the marching soldiers were followed by loud noises coming from tank engines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ModernisedArmy == true"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "We waited for a few minutes for the announcement. Finally, it was our turn. On both sides of the Victory Avenue there were numerous citizens cheering my name, waving their Sordish flags."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Italic: "Salute."*)
  - -> `[69]` (*Player_Italic: "Wave."*)
  - -> `[71]` (*Player_Italic: "Raise your fist."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "Wave."]** — Mówca: **Player_Italic**
> "I waved to the people."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false &..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "Salute."]** — Mówca: **Player_Italic**
> "I saluted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false &..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "Raise your fist."]** — Mówca: **Player_Italic**
> "I raised my fist."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false &..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "We kept our slow and steady pace. We were almost at the Artor S. Wisci statue several hundred meters away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_OutdatedMilitaryEquipment == ..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The convoy continued. As I looked around and saw that there was a military truck parked next to the statue in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“Hey Iosef, is that truck part of the parade?”"*)
  - -> `[75]` (*Player_Italic: "Shrug it off."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Hey Iosef, is that truck part of the parade?”"]** — Mówca: **Player**
> "“Hey Iosef, is that truck part of the parade?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Iosef Lancea: "“Yes it is, sir. Although I am not sure why it is not fol..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "Shrug it off."]** — Mówca: **Player_Italic**
> "I shrugged it off. It was probably nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "We continued and neared the statue."*)

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“Yes it is, sir. Although I am not sure why it is not following the motorcade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Iosef Lancea: "“I will make sure they are punished.”"*)

### Węzeł `[77]`
Mówca: **Iosef Lancea**
> "“I will make sure they are punished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "We continued and neared the statue."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "We continued and neared the statue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "The truck was standing in the middle of the road blocking..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "The truck was standing in the middle of the road blocking the parade a few dozen meters in-front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "“Was this scheduled?”"*)
  - -> `[82]` (*Player: "“What is going on? Do you see the truck?”"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "His jaw was clenched and his hand was slowly making its way to the gun on his hip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "His other hand went to his radio."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Was this scheduled?”"]** — Mówca: **Player**
> "“Was this scheduled?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“No.”"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“What is going on? Do you see the truck?”"]** — Mówca: **Player**
> "“What is going on? Do you see the truck?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Iosef Lancea: "“Something is not right.”"*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "His jaw was clenched and his hand was slowly making its w..."*)

### Węzeł `[84]`
Mówca: **Iosef Lancea**
> "“Something is not right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "His jaw was clenched and his hand was slowly making its w..."*)

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“What on earth is going on with that truck? Bring the guards at once. Do you copy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Iosef Lancea: "“I radioed the instru-”"*)

### Węzeł `[86]`
Mówca: **Narrator**
> "His other hand went to his radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Iosef Lancea: "“What on earth is going on with that truck? Bring the gua..."*)

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“I radioed the instru-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Three men who jumped out of the truck started running tow..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Three men who jumped out of the truck started running towards our car. They were holding KA-74's pointed right at us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "In a split second Iosef pulled his pistol and shot at the..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "In a split second Iosef pulled his pistol and shot at the gunmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“SERGE! FLOOR IT! NOW!”"*)
  - -> `[91]` (*Player: "“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“SERGE! FLOOR IT! NOW!”"]** — Mówca: **Player**
> "<shout>“SERGE! FLOOR IT! NOW!”</shout>"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"]** — Mówca: **Player**
> "<shout>“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”</shout>"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Serge reversed the car at full speed and ducked."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Serge quickly accelerated the car. The gunmen started firing and my ears started ringing. The sounds of the bullet impacts were horrifying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "The car hit one of the soldiers. We were about to crash i..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Serge reversed the car at full speed and ducked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Italic: "Duck down."*)
  - -> `[257]` (*Player_Italic: "Start praying."*)
  - -> `[256]` (*Player_Italic: "Close your eyes."*)

### Węzeł `[94]`
Mówca: **Iosef Lancea**
> "<shout>“MR. PRESIDENT. ARE YOU OKAY?”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Iosef Lancea: "<shout>“ANSWER ME.”</shout>"*)

### Węzeł `[95]`
Mówca: **Iosef Lancea**
> "<shout>“ANSWER ME.”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“I'm okay.”"*)
  - -> `[97]` (*Player: "“What just happened!?”"*)
  - -> `[136]` (*Player: "“Is everyone alright!?”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“I'm okay.”"]** — Mówca: **Player**
> "“I'm okay.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“Thank God! He is alive!”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“What just happened!?”"]** — Mówca: **Player**
> "“What just happened!?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“Thank God! He is alive!”"*)

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“Thank God! He is alive!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Iosef Lancea: "“Are you injured? Do you feel any pain?”"*)

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“Are you injured? Do you feel any pain?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I checked my body and didn't feel any injuries. I shook m..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I checked my body and didn't feel any injuries. I shook my head. I saw the wound on Iosef's right shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "He was bleeding."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "He was bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Nevermind me. Are you alright?”"*)
  - -> `[103]` (*Player: "“Are we safe?”"*)
  - -> `[110]` (*Player: "“What happened to the attackers?”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Nevermind me. Are you alright?”"]** — Mówca: **Player**
> "“Nevermind me. Are you alright?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Iosef Lancea: "“It's just a bullet in the shoulder, sir. Nothing critical.”"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Are we safe?”"]** — Mówca: **Player**
> "“Are we safe?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“We are for now.”"*)

### Węzeł `[104]`
Mówca: **Iosef Lancea**
> "“It's just a bullet in the shoulder, sir. Nothing critical.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "The car horn wouldn't stop blaring. I looked over to the ..."*)

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“We are for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "The car horn wouldn't stop blaring. I looked over to the ..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "The car horn wouldn't stop blaring. I looked over to the driver's seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Iosef Lancea: "“Mr. President. I'm sorr-”"*)

### Węzeł `[107]`
Mówca: **Iosef Lancea**
> "“Mr. President. I'm sorr-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Serge's head was leaning against the wheel, completely mo..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Serge's head was leaning against the wheel, completely motionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "I froze."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "I froze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player: "“He did nothing wrong.”"*)
  - -> `[113]` (*Player: "“No. This can't be true.”"*)
  - -> `[112]` (*Player: "“THEY WILL PAY FOR THIS.”"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“What happened to the attackers?”"]** — Mówca: **Player**
> "“What happened to the attackers?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Iosef Lancea: "“They are dead. I got one of them the guards handled the ..."*)

### Węzeł `[111]`
Mówca: **Iosef Lancea**
> "“They are dead. I got one of them the guards handled the other two.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "The car horn wouldn't stop blaring. I looked over to the ..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“THEY WILL PAY FOR THIS.”"]** — Mówca: **Player**
> "“THEY WILL PAY FOR THIS.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Iosef Lancea: "“They will, sir.”"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“No. This can't be true.”"]** — Mówca: **Player**
> "“No. This can't be true.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Iosef Lancea: "“I'm afraid it is.”"*)

### Węzeł `[114]`
Mówca: **Iosef Lancea**
> "“They will, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Emergency medical teams arrived and started examining me...."*)

### Węzeł `[115]`
Mówca: **Iosef Lancea**
> "“I'm afraid it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Emergency medical teams arrived and started examining me...."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "They started taking care of Iosef and put him on a stretc..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "They started taking care of Iosef and put him on a stretcher. He was yelling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Iosef Lancea: "<shout>“HOW CAN YOU LET THIS HAPPEN? IDIOTS, ALL OF YOU!”..."*)

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "<shout>“HOW CAN YOU LET THIS HAPPEN? IDIOTS, ALL OF YOU!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“YOU CAN'T EVEN PROTECT YOUR OWN PRESIDENT! WHY WAS I THE..."*)

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“YOU CAN'T EVEN PROTECT YOUR OWN PRESIDENT! WHY WAS I THE FIRST ONE TO RESPOND?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Iosef was put in an ambulance and taken away."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Iosef was put in an ambulance and taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Trails of blood were leading to the dead gunmen behind th..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I watched the medics pull out Serge's lifeless body from the car and place it into a black body bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead = true"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Trails of blood were leading to the dead gunmen behind the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I watched the medics pull out Serge's lifeless body from ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassinati..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "We continued on as per the schedule and finally arrived a..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "They started firing and my ears started ringing. I could hear the bullets impacting the car as we reversed and hit a roadblock behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "I dared to look up for a second and saw that Iosef had hi..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "I dared to look up for a second and saw that Iosef had his pistol drawn, shooting back at the attackers. I checked my body and didn't feel any injuries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "I saw the wound on Iosef's right shoulder. He was shot."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "I saw the wound on Iosef's right shoulder. He was shot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "“I SAID GET DOWN!”"*)
  - -> `[130]` (*Player_Italic: "Pull him back to the cover."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“I SAID GET DOWN!”"]** — Mówca: **Player**
> "<shout>“I SAID GET DOWN!”</shout>"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "As he stumbled, he pointed his pistol, aimed and then fir..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "Pull him back to the cover."]** — Mówca: **Player_Italic**
> "I tried to pull him back to the cover but he didn't flinch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "As he stumbled, he pointed his pistol, aimed and then fir..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "As he stumbled, he pointed his pistol, aimed and then fired at the gunmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "A brief gunfight ensued outside as the police and soldier..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle. There was a complete silence and the screams from of the crowd subdued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“Are they dead? Is it over?”"*)
  - -> `[134]` (*Player: "“Iosef, are you okay?”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Are they dead? Is it over?”"]** — Mówca: **Player**
> "“Are they dead? Is it over?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Iosef turned to me after grunting."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Iosef, are you okay?”"]** — Mówca: **Player**
> "“Iosef, are you okay?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Iosef turned to me after grunting."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "There was a muffled sound from the front seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Serge Wolkner: "“What just happene-”"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Is everyone alright!?”"]** — Mówca: **Player**
> "“Is everyone alright!?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“Thank God! He is alive!”"*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Iosef turned to me after grunting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Iosef Lancea: "“I've been better, sir. Got two of them.”"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Iosef turned to me after grunting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Iosef Lancea: "“I got two of them.”"*)

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“I've been better, sir. Got two of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "There was a muffled sound from the front seat."*)

### Węzeł `[140]`
Mówca: **Iosef Lancea**
> "“I got two of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "There was a muffled sound from the front seat."*)

### Węzeł `[141]`
Mówca: **Serge Wolkner**
> "“What just happene-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Serge Wolkner: "<shout>“SIR! ARE YOU ALRIGHT?”</shout>"*)

### Węzeł `[142]`
Mówca: **Serge Wolkner**
> "<shout>“SIR! ARE YOU ALRIGHT?”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: "“No, Serge. I won't be fine until they pay for what they ..."*)
  - -> `[143]` (*Player: "“I'm fine. Are you injured?”"*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“I'm fine. Are you injured?”"]** — Mówca: **Player**
> "“I'm fine. Are you injured?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He patted himself down."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "“No, Serge. I won't be fine until they pay for what they have done.”"]** — Mówca: **Player**
> "“No, Serge. I won't be fine until they pay for what they have done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Serge Wolkner: "“They will pay, sir.”"*)

### Węzeł `[145]`
Mówca: **Serge Wolkner**
> "“No injuries, sir. Thank God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Serge Wolkner: "“Mr. Lancea is a tough cookie to crack.”"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "He patted himself down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: "“No injuries, sir. Thank God.”"*)

### Węzeł `[147]`
Mówca: **Serge Wolkner**
> "“They will pay, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Serge Wolkner: "“Mr. Lancea is a tough cookie to crack.”"*)

### Węzeł `[148]`
Mówca: **Serge Wolkner**
> "“Mr. Lancea is a tough cookie to crack.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Iosef Lancea: "“I'm not dead yet.”"*)

### Węzeł `[149]`
Mówca: **Iosef Lancea**
> "“I'm not dead yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He grunted in pain again."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "He grunted in pain again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Emergency medical teams arrived and started examining me...."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "They started taking care of Iosef and put him on a stretc..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "They started taking care of Iosef and put him on a stretcher. He was yelling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Iosef Lancea: "<shout>“HOW CAN YOU LET THIS HAPPEN? IDIOTS, ALL OF YOU!”..."*)

### Węzeł `[153]`
Mówca: **Iosef Lancea**
> "<shout>“HOW CAN YOU LET THIS HAPPEN? IDIOTS, ALL OF YOU!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Iosef Lancea: "“YOU CAN'T EVEN PROTECT YOUR OWN PRESIDENT! WHY WAS I THE..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Iosef was put in an ambulance and taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Trails of blood were leading to the dead gunmen behind th..."*)

### Węzeł `[155]`
Mówca: **Iosef Lancea**
> "“YOU CAN'T EVEN PROTECT YOUR OWN PRESIDENT! WHY WAS I THE FIRST ONE TO RESPOND?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Iosef was put in an ambulance and taken away."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Trails of blood were leading to the dead gunmen behind the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "I was finally placed in an ambulance as well and was rush..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "I was finally placed in an ambulance as well and was rushed to the hospital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_MilitaryParade_Survived = ..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_OutdatedMilitaryEquipment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_OutdatedMilitaryEquipment == ..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_OutdatedMilitaryEquipment =..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_OutdatedMilitaryEquipment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_OutdatedMilitaryEquipment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "A group of soldiers saluted me as we passed by. They look..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ModernisedAirForce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ModernisedAirForce == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_ModernisedAirForce == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ModernisedAirForce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_ModernisedAirForce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "A group of ten, maybe twelve latest technology S-16 fight..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_ModernisedAirForce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_ModernisedAirForce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "A couple of old propeller planes flew above our heads and..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ModernisedArmy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ModernisedArmy == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_ModernisedArmy == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ModernisedArmy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_ModernisedArmy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "The tanks came into my view. They were top of the line mo..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_ModernisedArmy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_ModernisedArmy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "The tanks came into my view. They were not the most moder..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "A couple of old propeller planes flew above our heads and I thought whether the planes were older than me. Loud footsteps of the marching soldiers were followed by loud noises coming from tank engines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ModernisedArmy == true"*)

### Węzeł `[168]`
Mówca: **Narrator**
> "The tanks came into my view. They were top of the line modern battle tanks. Their shining armour under the sun invigorated national pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "We waited for a few minutes for the announcement. Finally..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "The tanks came into my view. They were not the most modern models however they displayed our military might. I couldn't even finish my thought and one of the tanks broke down and had to be towed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "We waited for a few minutes for the announcement. Finally..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ExperiencedGenerals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ExperiencedGenerals == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_ExperiencedGenerals == true)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ExperiencedGenerals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_ExperiencedGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "On the way to the car, generals and admirals were lined u..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_ExperiencedGenerals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_ExperiencedGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_GreenGenerals == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_GreenGenerals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_GreenGenerals == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_GreenGenerals == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_GreenGenerals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_GreenGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "On the way to the car, generals and admirals were lined u..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_GreenGenerals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_GreenGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "On the way to the car, generals and admirals were lined up on both sides of the carpet. The atmosphere immediately changed when these experienced men who fought many times for their country saluted me. I saluted back with respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[177]`
Mówca: **Narrator**
> "On the way to the car, generals and admirals were lined up on both sides of the carpet. I was surprised by the young age of some generals. I wondered whether they have even seen any action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "A group of soldiers saluted me as we passed by. They did not even have matching guns. Iosef turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Iosef Lancea: "“This is all result of the cuts, Mr. President.”"*)

### Węzeł `[179]`
Mówca: **Iosef Lancea**
> "“This is all result of the cuts, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "A group of soldiers saluted me as we passed by. They looked proud and stout in the new infantry uniforms and with brand-new rifles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[181]`
Mówca: **Narrator**
> "We continued on as per the schedule and finally arrived at the Maroon Palace which marked the end of the parade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "People of Holsord dispersed to their homes."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "People of Holsord dispersed to their homes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "A clear message was sent to Rumburg by the display of our..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "A clear message was sent to Rumburg by the display of our military might."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "We were about to see whether it would be enough or not."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "We were about to see whether it would be enough or not."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_SnO_MilitaryParade = true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_SnO_MilitaryParade = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_SnO_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == false"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == false)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou = true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was an unusual day for the residents of Holsord. Regul..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was an unusual day for the residents of Holsord. Regul..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We exited the building and walked over to the clearance w..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "We exited the building and walked over to the clearance w..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "We exited the building and walked over to the clearance where the black Kadila, the presidential car, was waiting. It was decorated properly for the event and the top canopy had been removed so that I could stand and wave to people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ExperiencedGenerals == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "We entered the car and Serge started the engine. Iosef wa..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "I entered the car and Serge started the engine. Iosef sal..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "I entered the car and Serge started the engine. Iosef saluted me. We were on our way shortly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Iosef Lancea: "“Good luck, Mr. President.”"*)

### Węzeł `[198]`
Mówca: **Iosef Lancea**
> "“Good luck, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "The car started rolling."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "The car started rolling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Even though there were many walls and trees in between th..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "The car started rolling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Even though there were many walls and trees in between th..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Even though there were many walls and trees in between the car and the crowd, I was able to hear the deafening sounds of cheering Sordish citizens. Gradually we made our way to the starting point."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ModernisedAirForce == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "A group of soldiers saluted me as we passed by. They did ..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "A group of soldiers saluted me as we passed by. They did ..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "A group of soldiers saluted me as we passed by. They did not even have matching guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The convoy continued. As I looked around and saw that the..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The convoy continued. As I looked around and saw that the..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "The convoy continued. As I looked around and saw that there was a military truck parked next to the statue in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: "“Hey Serge, is that truck part of the parade?”"*)
  - -> `[212]` (*Player_Italic: "Shrug it off."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "We continued and neared the statue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "The truck was standing in the middle of the road blocking..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "“Hey Serge, is that truck part of the parade?”"]** — Mówca: **Player**
> "“Hey Serge, is that truck part of the parade?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Serge Wolkner: "“I think so, Mr. President. Although I am not sure why it..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA: "Shrug it off."]** — Mówca: **Player_Italic**
> "I shrugged it off. It was probably nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "We continued and neared the statue."*)

### Węzeł `[213]`
Mówca: **Serge Wolkner**
> "“I think so, Mr. President. Although I am not sure why it's parked.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "We continued and neared the statue."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "The truck was standing in the middle of the road blocking the parade a few dozen meters in-front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: "“Was this scheduled?”"*)
  - -> `[217]` (*Player: "“What is going on? Do you see the truck?”"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Was this scheduled?”"]** — Mówca: **Player**
> "“Was this scheduled?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Serge Wolkner: "“I- I don't think so, sir.”"*)

### Węzeł `[216]`
Mówca: **Serge Wolkner**
> "“I- I don't think so, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Serge Wolkner: "“Something's wrong.”"*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "“What is going on? Do you see the truck?”"]** — Mówca: **Player**
> "“What is going on? Do you see the truck?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Serge Wolkner: "“I- I don't know, sir.”"*)

### Węzeł `[218]`
Mówca: **Serge Wolkner**
> "“I- I don't know, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Serge Wolkner: "“Something's wrong.”"*)

### Węzeł `[219]`
Mówca: **Narrator**
> "His jaw was clenched and he was intently watching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "Serge then picked up the radio."*)

### Węzeł `[220]`
Mówca: **Serge Wolkner**
> "“Something's wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "His jaw was clenched and he was intently watching."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "Serge then picked up the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Serge Wolkner: "“There seems to be a truck on the way. Is this part of th..."*)

### Węzeł `[222]`
Mówca: **Serge Wolkner**
> "“There seems to be a truck on the way. Is this part of the schedu-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Three men who jumped out of the truck started running tow..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Three men who jumped out of the truck started running towards our car. They were holding KA-74's pointed right at us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player: "“SERGE! FLOOR IT! NOW!”"*)
  - -> `[229]` (*Player: "“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“SERGE! FLOOR IT! NOW!”"]** — Mówca: **Player**
> "<shout>“SERGE! FLOOR IT! NOW!”</shout>"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[225]`
Mówca: **Narrator**
> "Serge quickly accelerated the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "Gunmen started firing and my ears started ringing. The so..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "Gunmen started firing and my ears started ringing. The sounds of the bullet impacts were horrifying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "The car hit one of the soldiers. We were about to crash i..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "There was a complete silence followed by screams from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "There was a muffled sound from the front seat."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "The car hit one of the soldiers. We were about to crash into the truck in-front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Italic: "Hold on as tightly as you can."*)
  - -> `[231]` (*Player_Italic: "Start praying."*)
  - -> `[251]` (*Player_Italic: "Close your eyes."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"]** — Mówca: **Player**
> "<shout>“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”</shout>"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Serge reversed the car at full speed and ducked."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "I regained consciousness after the crash. The muffled screams from the crowd combined with the car horn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "A brief gunfight ensued outside as the police and soldier..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to the God."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushEnd");"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Serge reversed the car at full speed and ducked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Italic: "Duck down."*)
  - -> `[253]` (*Player_Italic: "Start praying."*)
  - -> `[252]` (*Player_Italic: "Close your eyes."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "They started firing and my ears started ringing. I could hear the bullets impacting the car as we reversed and hit a roadblock behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "There was a complete silence followed by screams from the..."*)

### Węzeł `[234]`
Mówca: **Serge Wolkner**
> "“They will pay, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Emergency medical teams arrived and started examining me ..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "“I'm fine. Are you injured?”"]** — Mówca: **Player**
> "“I'm fine. Are you injured?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "He pat himself down."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "There was a muffled sound from the front seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Serge Wolkner: "“What just happene-”"*)

### Węzeł `[237]`
Mówca: **Serge Wolkner**
> "“What just happene-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "A brief gunfight ensued outside as the police and soldier..."*)

### Węzeł `[238]`
Mówca: **Serge Wolkner**
> "“No injuries, sir. Thank God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Emergency medical teams arrived and started examining me ..."*)

### Węzeł `[239]`
Mówca: **Serge Wolkner**
> "<shout>“SIR! ARE YOU ALRIGHT?”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: "“No, Serge. I won't be fine until they pay for what they ..."*)
  - -> `[235]` (*Player: "“I'm fine. Are you injured?”"*)

### Węzeł `[240]`
**[WYBÓR GRACZA: "“No, Serge. I won't be fine until they pay for what they have done.”"]** — Mówca: **Player**
> "“No, Serge. I won't be fine until they pay for what they have done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Serge Wolkner: "“They will pay, sir.”"*)

### Węzeł `[241]`
Mówca: **Narrator**
> "He pat himself down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Serge Wolkner: "“No injuries, sir. Thank God.”"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me and Serge. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "The car was dotted with bullet holes. The bodies of dead ..."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "The car was dotted with bullet holes. The bodies of dead gunmen were in-front of it. It was a miracle that no one died."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_MilitaryParade_Survived = ..."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "The car horn just wouldn't stop. I looked over to the driver seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Serge's head was leaning against the wheel, completely mo..."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "Serge's head was leaning against the wheel, completely motionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "I froze."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "I froze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Emergency medical teams arrived and started examining me...."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "Trails of blood were leading to the dead gunmen behind the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "I watched the medics pull out Serge's lifeless body from ..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Trails of blood were leading to the dead gunmen behind th..."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "I watched the medics pull out Serge's lifeless body from the car and into a black body bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead = true"*)

### Węzeł `[250]`
**[WYBÓR GRACZA: "Hold on as tightly as you can."]** — Mówca: **Player_Italic**
> "I held on as tight as I could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushEnd");"*)

### Węzeł `[251]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushEnd");"*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[253]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to the God."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[254]`
**[WYBÓR GRACZA: "Duck down."]** — Mówca: **Player_Italic**
> "I ducked down as fast as I could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[255]`
**[WYBÓR GRACZA: "Duck down."]** — Mówca: **Player_Italic**
> "I ducked down as fast as I could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[256]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to God."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushStart");"*)

### Węzeł `[258]`
Mówca: **Narrator**
> "Looking at the benches where the new officers of the General Staff was sitting at, I saw Tarquin Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false && BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false &..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false && BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == false  and  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false && BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == false  and  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We kept our slow and steady pace. We were almost at the A..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "From this distance it was hard to tell, but he tipped his hat off to me and I could swear that he was smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We kept our slow and steady pace. We were almost at the A..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "Looking at the benches where the new officers of the Gene..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Looking at the benches where the General Staff was sittin..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Looking at the benches where the General Staff was sitting at, I saw Tarquin Soll sitting next to General Valken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSer..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "I saluted the high ranking military staff and attaches fr..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[272]`
Mówca: **Narrator**
> "I saluted the high ranking military staff and attaches from CSP. We shook hands before proceeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "I saluted the high ranking military staff and attaches fr..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)

### Węzeł `[276]`
Mówca: **Narrator**
> "I saluted the high ranking military staff and attaches from ATO. We shook hands before proceeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Serge Wolkner: "<shout>“SIR! ARE YOU ALRIGHT?”</shout>"*)

### Węzeł `[278]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle. My head was spinning and my ears were still ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "The car horn just wouldn't stop. I looked over to the dri..."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "The car hit one of the soldiers. We were about to crash into the truck in front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Italic: "Hold on as tightly as you can."*)
  - -> `[280]` (*Player_Italic: "Start praying."*)
  - -> `[281]` (*Player_Italic: "Close your eyes."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to God."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushEnd");"*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushEnd");"*)

### Węzeł `[282]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle. Iosef fired several more times towards the gunmen. My head was spinning and my ears were still ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Iosef Lancea: "<shout>“MR. PRESIDENT. ARE YOU OKAY?”</shout>"*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "Hold on as tightly as you can."]** — Mówca: **Player_Italic**
> "I held on as tight as I could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AmbushEnd");"*)

### Węzeł `[284]`
Mówca: **Narrator**
> "I regained consciousness after the crash. The muffled screams from the crowd combined with the car horn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "A brief gunfight ensued outside as the police and soldier..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "“He did nothing wrong.”"]** — Mówca: **Player**
> "“He did nothing wrong.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Iosef Lancea: "“He served his country until the very end.”"*)

### Węzeł `[286]`
Mówca: **Iosef Lancea**
> "“He served his country until the very end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Emergency medical teams arrived and started examining me...."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_SergeFuneral = true; GameCondition.Turn10..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_SergeFuneral = true; GameCondition.Turn10_Personal_SergeFuneral = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_SergeFuneral"] = true;
Variable["GameCondition.Turn10_Personal_SergeFuneral"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Holsord_Assassination = tru..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_MilitaryParade_Survived = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_MilitaryParade_Survived"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Holsord_Assassination = tru..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination = true;
BaseGameSupport.News_Turn09_R_MilitaryParade_Assassination = true;
BaseGameSupport.News_Turn09_LT_MilitaryParade_Assassination = true;
BaseGameSupport.News_Turn09_HP_MilitaryParade_Assassination = true;
BaseGameSupport.CountryReport_Turn10_Agnolia_CondolencesAssasination = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.News_Turn09_R_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.News_Turn09_LT_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.News_Turn09_HP_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.CountryReport_Turn10_Agnolia_CondolencesAssasination"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt = true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Holsord_Assassination = true; BaseGameSupport.Report_Turn09_Holsord_Parade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_Assassination"] = true;
Variable["BaseGameSupport.Report_Turn09_Holsord_Parade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "From this distance it was hard to tell, but he tipped his..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We kept our slow and steady pace. We were almost at the A..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AmbushStart");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Serge quickly accelerated the car. The gunmen started fir..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AmbushEnd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AmbushEnd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "I regained consciousness after the crash. The muffled scr..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_SnO_MilitaryParade = true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AmbushStart");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "Serge quickly accelerated the car."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AmbushEnd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AmbushEnd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "I regained consciousness after the crash. The muffled scr..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AmbushStart");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "They started firing and my ears started ringing. I could ..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AmbushStart");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "They started firing and my ears started ringing. I could ..."*)
