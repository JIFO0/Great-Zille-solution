# Sordland/Turn02/A_MediaDeal

- **ID konwersacji:** `13`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/013_A_MediaDeal.md`
- **Liczba węzłów dialogowych:** 175
- **Liczba wyborów gracza:** 61

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[38]** Lucian Galade
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Reform_Autocrat_Intention`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Democratic`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel`
- `BaseGameSupport.Journal_Turn02_StruckDealWithMarcel`
- `BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmergency`
- `GameCondition.Turn02_A_MediaDeal`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“Where are we, Serge?”"** | `[8]` **Narrator**: "After a few hours of driving alo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Serge Wolkner**: "“We are nearing the HOS Country ..." |
| `[7]` | **"Look outside."** | `[8]` **Narrator**: "After a few hours of driving alo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "I could see giant stadium lights..." |
| `[12]` | **"“The location is very remote indeed.”"** | `[4]` **Petr Vectern**: "“I hope the journey was comforta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Petr Vectern**: "“It's a very exclusive country c..." |
| `[13]` | **"“It wasn't bad. I am looking forward to this meeting.”"** | `[4]` **Petr Vectern**: "“I hope the journey was comforta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucian Galade**: "“I am sure it will be worth our ..." |
| `[16]` | **"Enter the building."** | `[17]` **Petr Vectern**: "“It's a very exclusive country c..."<br>`[20]` **Petr Vectern**: "“Let's.”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "After opening the marble engrave..." |
| `[24]` | **"Reach out for a handshake."** | `[23]` **Narrator**: "He was a strikingly handsome man..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He had a firm grip." |
| `[25]` | **"Do nothing."** | `[23]` **Narrator**: "He was a strikingly handsome man..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "He put his hand back in his pock..." |
| `[29]` | **"“Yes. There is much to discuss.”"** | `[40]` **Marcel Koronti**: "“It's time to look forward. Let'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Marcel Koronti**: "“Believe it or not I have been a..." |
| `[30]` | **"“I heard about your meteoric rise in HOS.”"** | `[40]` **Marcel Koronti**: "“It's time to look forward. Let'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Marcel Koronti**: "“I'm flattered. You truly are go..." |
| `[31]` | **"“Let’s have a seat.”"** | `[40]` **Marcel Koronti**: "“It's time to look forward. Let'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[37]` | **"“May he rest in peace. He was a true entrepreneur.”"** | `[39]` **Marcel Koronti**: "“Welcome. Your kind words have t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Marcel Koronti**: "“He would have been very happy t..." |
| `[38]` | **"“Please accept our condolences. We are saddened.”"** | `[39]` **Marcel Koronti**: "“Welcome. Your kind words have t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Marcel Koronti**: "“He would have been very happy t..." |
| `[42]` | **"“It seems we had similar experiences.”"** | `[35]` **Marcel Koronti**: "“I say this because you have gon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[43]` | **"“Politics is a ladder. The higher you climb the more chaos is around you.”"** | `[35]` **Marcel Koronti**: "“I say this because you have gon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[44]` | **"“I would not be standing here if I was bad at what I do.”"** | `[33]` **Marcel Koronti**: "“I find your quick rise to power..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[45]` | **"“The admiration goes both ways.”"** | `[33]` **Marcel Koronti**: "“I find your quick rise to power..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[48]` | **"Give Lucian a puzzled look."** | `[51]` **Narrator**: "Marcel's eyes traveled toward on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Lucian looked back at me and shr..." |
| `[49]` | **"Look at the painting."** | `[51]` **Narrator**: "Marcel's eyes traveled toward on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The famous piece depicted a gian..." |
| `[50]` | **"Look at Marcel."** | `[51]` **Narrator**: "Marcel's eyes traveled toward on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "Marcel pointed his finger at me." |
| `[59]` | **"“Cooperate?”"** | `[58]` **Marcel Koronti**: "“So, I want to cooperate with you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Marcel Koronti**: "“You might have the people's sup..." |
| `[60]` | **"“Please, explain further.”"** | `[58]` **Marcel Koronti**: "“So, I want to cooperate with you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Marcel Koronti**: "“You might have the people's sup..." |
| `[65]` | **"“Continue.”"** | `[64]` **Marcel Koronti**: "“...If they were released.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Marcel Koronti**: "“Now, assume that the press woul..." |
| `[66]` | **"“You are playing a dangerous game.”"** | `[64]` **Marcel Koronti**: "“...If they were released.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Marcel Koronti**: "“We are all dangerous men playin..." |
| `[67]` | **"“I see where you are getting at.”"** | `[64]` **Marcel Koronti**: "“...If they were released.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Marcel Koronti**: "“You knew that a long time befor..." |
| `[71]` | **"“What do you want in return?”"** | `[68]` **Marcel Koronti**: "“Now, assume that the press woul..."<br>`[69]` **Marcel Koronti**: "“You knew that a long time befor..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“I want two things, Mr. Presiden..." |
| `[72]` | **"“You aren’t just being nice, are you?”"** | `[68]` **Marcel Koronti**: "“Now, assume that the press woul..."<br>`[69]` **Marcel Koronti**: "“You knew that a long time befor..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“I want two things, Mr. Presiden..." |
| `[75]` | **"“This is far too risky for me.”"** | `[74]` **Marcel Koronti**: "“Number two is a simple gentlema..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Marcel Koronti**: "“Great risk means great reward. ..." |
| `[76]` | **"“It is an interesting proposal.”"** | `[74]` **Marcel Koronti**: "“Number two is a simple gentlema..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Marcel Koronti**: "“Not just interesting but necess..." |
| `[77]` | **"“How do I know that I can trust you?”"** | `[74]` **Marcel Koronti**: "“Number two is a simple gentlema..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Marcel Koronti**: "“My circle advised against this...." |
| `[86]` | **"“What do you think about this, Lucian?”"** | `[81]` **Marcel Koronti**: "“I can guarantee that you will s..."<br>`[83]` **Marcel Koronti**: "“The media will be on your side ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "Lucian leaned over to my ear and..." |
| `[87]` | **"“You have been awfully silent, Petr.”"** | `[81]` **Marcel Koronti**: "“I can guarantee that you will s..."<br>`[83]` **Marcel Koronti**: "“The media will be on your side ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "Petr leaned over to my ear and w..." |
| `[92]` | **"“Mr. Koronti, I have to reject.”"** | `[81]` **Marcel Koronti**: "“I can guarantee that you will s..."<br>`[83]` **Marcel Koronti**: "“The media will be on your side ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`<br>`Variable["BaseGameSupport.Journal_Turn02_RefusedDealWithM...`<br>*(+1 skryptów)* | `[98]` **Marcel Koronti**: "“Such a pity, Mr. President. And..." |
| `[93]` | **"“We have a deal.”"** | `[81]` **Marcel Koronti**: "“I can guarantee that you will s..."<br>`[83]` **Marcel Koronti**: "“The media will be on your side ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Media_SordlandToday_Bias"] = true; Var...`<br>`Variable["BaseGame.Accepted_MediaDeal"] = true;`<br>*(+2 skryptów)* | `[94]` **Marcel Koronti**: "“Happy to hear that. You can con..." |
| `[96]` | **"Return to Holsord."** | `[97]` **Lucian Galade**: "“Thank you for your time, Mr. Ko..."<br>`[128]` **Lucian Galade**: "“The threats were unacceptable.”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn02_A_MediaDeal"] = true;`<br>`Variable["BaseGameSupport.Report_Turn02_Holsord_KesaroDem...`<br>*(+1 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[105]` | **"“A deal is a deal.”"** | `[95]` **Marcel Koronti**: "“I hope you will uphold your end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Marcel Koronti**: "“A man of his word, excellent.”" |
| `[106]` | **"“You can bet on it.”"** | `[95]` **Marcel Koronti**: "“I hope you will uphold your end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Marcel Koronti**: "“I rarely bet, but when I do, al..." |
| `[107]` | **"“Remember who you are speaking to, Mr. Koronti.”"** | `[99]` **Marcel Koronti**: "“It's a shame. Really.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Marcel Koronti**: "“Oh, I know very well.”" |
| `[108]` | **"“I regret coming here to see you.”"** | `[99]` **Marcel Koronti**: "“It's a shame. Really.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Marcel Koronti**: "“Hm.”" |
| `[109]` | **"Stay silent."** | `[39]` **Marcel Koronti**: "“Welcome. Your kind words have t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Marcel Koronti**: "“It's time to look forward. Let'..." |
| `[110]` | **"“Thank you.”"** | `[33]` **Marcel Koronti**: "“I find your quick rise to power..."<br>`[35]` **Marcel Koronti**: "“I say this because you have gon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[111]` | **"“The intent is mutual.”"** | `[58]` **Marcel Koronti**: "“So, I want to cooperate with you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Marcel Koronti**: "“You might have the people's sup..." |
| `[116]` | **"“Are you threatening me?”"** | `[64]` **Marcel Koronti**: "“...If they were released.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Marcel Koronti**: "“Absolutely not. I'm merely offe..." |
| `[117]` | **"“Let's hear your offer.”"** | `[68]` **Marcel Koronti**: "“Now, assume that the press woul..."<br>`[69]` **Marcel Koronti**: "“You knew that a long time befor..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“I want two things, Mr. Presiden..." |
| `[119]` | **"“It doesn't sound like help.”"** | `[118]` **Marcel Koronti**: "“Absolutely not. I'm merely offe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Marcel Koronti**: "“I harbor no ill will. It is up ..." |
| `[121]` | **"“I have heard enough.”"** | `[120]` **Marcel Koronti**: "“I harbor no ill will. It is up ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`<br>`Variable["BaseGameSupport.Journal_Turn02_RefusedDealWithM...`<br>*(+1 skryptów)* | `[98]` **Marcel Koronti**: "“Such a pity, Mr. President. And..." |
| `[122]` | **"“Make your case.”"** | `[120]` **Marcel Koronti**: "“I harbor no ill will. It is up ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“I want two things, Mr. Presiden..." |
| `[124]` | **"“Goodbye, Mr. Koronti.”"** | `[99]` **Marcel Koronti**: "“It's a shame. Really.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Petr Vectern**: "“Let's leave.”" |
| `[125]` | **"“Agreed.”"** | `[101]` **Lucian Galade**: "“I was hoping that would end bet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Lucian Galade**: "“I'm sorry. I should have seen i..." |
| `[126]` | **"“It was your idea.”"** | `[101]` **Lucian Galade**: "“I was hoping that would end bet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "Lucian didn't comment." |
| `[127]` | **"“He pushed it too far.”"** | `[101]` **Lucian Galade**: "“I was hoping that would end bet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Lucian Galade**: "“The threats were unacceptable.”" |
| `[132]` | **"“As long as you do.”"** | `[95]` **Marcel Koronti**: "“I hope you will uphold your end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Marcel Koronti**: "“You can count on me.”" |
| `[133]` | **"“Anything to keep me away from home.”"** | `[4]` **Petr Vectern**: "“I hope the journey was comforta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Petr Vectern**: "“That bad, huh? Well this should..." |
| `[136]` | **"“They were startled, but the important thing is they are safe and sound.”"** | `[139]` **Marcel Koronti**: "“The whole incident must have be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Marcel Koronti**: "“Of course that is all that matt..." |
| `[137]` | **"“I will not allow this situation to continue.”"** | `[139]` **Marcel Koronti**: "“The whole incident must have be..." | `Variable["BaseGame.Reform_Autocrat_Intention"] == true` | *Brak zmian stanu* | `[144]` **Marcel Koronti**: "“The restoration of order is imp..." |
| `[138]` | **"“I stayed and served my country dutifully.”"** | `[139]` **Marcel Koronti**: "“The whole incident must have be..." | `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true` | *Brak zmian stanu* | `[147]` **Marcel Koronti**: "“I am sure you did. My father al..." |
| `[143]` | **"“Spare me your life story, Mr. Koronti.”"** | `[139]` **Marcel Koronti**: "“The whole incident must have be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Marcel Koronti**: "“As you wish, but it's an amazin..." |
| `[159]` | **"Shake his hand."** | `[95]` **Marcel Koronti**: "“I hope you will uphold your end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "Marcel put his second hand on mine." |
| `[161]` | **"“I can't think of comfort when our country is descending into chaos.”"** | `[4]` **Petr Vectern**: "“I hope the journey was comforta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Petr Vectern**: "“When you put it like that...”" |
| `[163]` | **"“Let's just get to the point.”"** | `[33]` **Marcel Koronti**: "“I find your quick rise to power..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Marcel gently pointed at the sea..." |
| `[164]` | **"“Let me be *straightforward*. Sit down and get to the damn point.”"** | `[51]` **Narrator**: "Marcel's eyes traveled toward on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Marcel Koronti**: "“Ah no need be rude, Mr. Preside..." |
| `[166]` | **"“Keep going.”"** | `[58]` **Marcel Koronti**: "“So, I want to cooperate with you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Marcel Koronti**: "“You might have the people's sup..." |

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
  - -> `[3]` (*Narrator: "Our motorcade headed to the meeting location set by Marce..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Our motorcade headed to the meeting location set by Marcel Koronti. I had only my most confidential and trustworthy team members with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "After a few hours of driving along River Eskel, we took a..."*)

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“I hope the journey was comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“The location is very remote indeed.”"*)
  - -> `[133]` (*Player: "“Anything to keep me away from home.”"*)
  - -> `[13]` (*Player: "“It wasn't bad. I am looking forward to this meeting.”"*)
  - -> `[161]` (*Player: "“I can't think of comfort when our country is descending ..."*)

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“He would have been very happy to hear this from you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Marcel Koronti: "“It's time to look forward. Let's talk about our bright f..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Where are we, Serge?”"]** — Mówca: **Player**
> "“Where are we, Serge?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Serge Wolkner: "“We are nearing the HOS Country Club, Mr. President.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Look outside."]** — Mówca: **Player_Italic**
> "I looked outside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I could see giant stadium lights on the hilltop far away ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "After a few hours of driving along River Eskel, we took a turn before entering Conriat. The darkness started setting in as we drove up to a hill."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“Where are we, Serge?”"*)
  - -> `[7]` (*Player_Italic: "Look outside."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I could see giant stadium lights on the hilltop far away in the distance. It looked like a massive complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Serge Wolkner: "“We are nearing our destination.”"*)

### Węzeł `[10]`
Mówca: **Serge Wolkner**
> "“We are nearing the HOS Country Club, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Serge Wolkner: "“We'll be there shortly.”"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "We arrived and the big iron gates of the country club opened. It was huge and outright extravagant. The main building, inspired by Lespian architecture, was illuminated from all sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "It was rather chilly. I was approached by Petr Vectern an..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“The location is very remote indeed.”"]** — Mówca: **Player**
> "“The location is very remote indeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Petr Vectern: "“It's a very exclusive country club for people who value ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“It wasn't bad. I am looking forward to this meeting.”"]** — Mówca: **Player**
> "“It wasn't bad. I am looking forward to this meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“I am sure it will be worth our time. He is a Koronti aft..."*)

### Węzeł `[14]`
Mówca: **Serge Wolkner**
> "“We'll be there shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We arrived and the big iron gates of the country club ope..."*)

### Węzeł `[15]`
Mówca: **Serge Wolkner**
> "“We are nearing our destination.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We arrived and the big iron gates of the country club ope..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Enter the building."]** — Mówca: **Player_Italic**
> "We entered the main building."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Petr Vectern), `[20]` (Petr Vectern), `[134]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "After opening the marble engraved wooden door, we were gr..."*)

### Węzeł `[17]`
Mówca: **Petr Vectern**
> "“It's a very exclusive country club for people who value their privacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Enter the building."*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“I am sure it will be worth our time. He is a Koronti after all. Let’s get personal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: "“Let's.”"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "It was rather chilly. I was approached by Petr Vectern and Lucian Galade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: "“I hope the journey was comfortable.”"*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> "“Let's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Enter the building."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "After opening the marble engraved wooden door, we were greeted by two tall women. The receptionists led us to the meeting room upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Marcel was standing by the window looking outside at the ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Marcel was standing by the window looking outside at the beautiful complex. He turned around to have a quick look at us both."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He was a strikingly handsome man with well-groomed hair. ..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He was a strikingly handsome man with well-groomed hair. He walked towards me with his hand reached out for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Italic: "Reach out for a handshake."*)
  - -> `[25]` (*Player_Italic: "Do nothing."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "Reach out for a handshake."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He had a firm grip."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He put his hand back in his pocket and smiled."*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> "“It is such a pleasure to meet you in person, Mr. Koronti. I appreciate your efforts to reach out and establish a mutually beneficial friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: "“Thanks for hosting us. I admired your father very much, ..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "He put his hand back in his pocket and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: "“It is such a pleasure to meet you in person, Mr. Koronti..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He had a firm grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: "“It is such a pleasure to meet you in person, Mr. Koronti..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Yes. There is much to discuss.”"]** — Mówca: **Player**
> "“Yes. There is much to discuss.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Marcel Koronti: "“Believe it or not I have been a secret admirer of your p..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“I heard about your meteoric rise in HOS.”"]** — Mówca: **Player**
> "“I heard about your meteoric rise in HOS.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Marcel Koronti: "“I'm flattered. You truly are going to be the best Presid..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Let’s have a seat.”"]** — Mówca: **Player**
> "“Let’s have a seat.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[32]`
Mówca: **Marcel Koronti**
> "“Believe it or not I have been a secret admirer of your political success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Marcel Koronti: "“I find your quick rise to power was shockingly well-exec..."*)

### Węzeł `[33]`
Mówca: **Marcel Koronti**
> "“I find your quick rise to power was shockingly well-executed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "“Let's just get to the point.”"*)
  - -> `[44]` (*Player: "“I would not be standing here if I was bad at what I do.”"*)
  - -> `[45]` (*Player: "“The admiration goes both ways.”"*)
  - -> `[110]` (*Player: "“Thank you.”"*)

### Węzeł `[34]`
Mówca: **Marcel Koronti**
> "“I'm flattered. You truly are going to be the best President this country has seen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Marcel Koronti: "“I say this because you have gone against the odds and su..."*)

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“I say this because you have gone against the odds and survived. I respect that more than anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Thank you.”"*)
  - -> `[42]` (*Player: "“It seems we had similar experiences.”"*)
  - -> `[43]` (*Player: "“Politics is a ladder. The higher you climb the more chao..."*)

### Węzeł `[36]`
Mówca: **Petr Vectern**
> "“Thanks for hosting us. I admired your father very much, may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Marcel Koronti: "“Welcome. Your kind words have touched me, Mr. Vice Presi..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“May he rest in peace. He was a true entrepreneur.”"]** — Mówca: **Player**
> "“May he rest in peace. He was a true entrepreneur.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“He would have been very happy to hear this from you, Mr...."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Please accept our condolences. We are saddened.”"]** — Mówca: **Player**
> "“Please accept our condolences. We are saddened.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“He would have been very happy to hear this from you, Mr...."*)

### Węzeł `[39]`
Mówca: **Marcel Koronti**
> "“Welcome. Your kind words have touched me, Mr. Vice President. He was indeed a great man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“May he rest in peace. He was a true entrepreneur.”"*)
  - -> `[38]` (*Player: "“Please accept our condolences. We are saddened.”"*)
  - -> `[109]` (*Player_Italic: "Stay silent."*)

### Węzeł `[40]`
Mówca: **Marcel Koronti**
> "“It's time to look forward. Let's talk about our bright future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“Yes. There is much to discuss.”"*)
  - -> `[31]` (*Player: "“Let’s have a seat.”"*)
  - -> `[30]` (*Player: "“I heard about your meteoric rise in HOS.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Marcel gently pointed at the seats. We sat down around a gigantic table. Before speaking he knocked on wood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Marcel Koronti: "“The past months have been tumultuous to say the least, I..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“It seems we had similar experiences.”"]** — Mówca: **Player**
> "“It seems we had similar experiences.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Politics is a ladder. The higher you climb the more chaos is around you.”"]** — Mówca: **Player**
> "“Politics is a ladder. The higher you climb the more chaos is around you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“I would not be standing here if I was bad at what I do.”"]** — Mówca: **Player**
> "“I would not be standing here if I was bad at what I do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“The admiration goes both ways.”"]** — Mówca: **Player**
> "“The admiration goes both ways.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[46]`
Mówca: **Marcel Koronti**
> "“Well... I am known to be a straightforward person. So, let me get to the point without wasting your valuable time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Marcel Koronti: "“It was during the Alphonso campaign when I was struck by..."*)

### Węzeł `[47]`
Mówca: **Marcel Koronti**
> "“It was during the Alphonso campaign when I was struck by what you managed to do within the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Marcel's eyes traveled toward one of the paintings on his..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Give Lucian a puzzled look."]** — Mówca: **Player_Italic**
> "I looked at Lucian Galade."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Lucian looked back at me and shrugged. Then he raised his..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Look at the painting."]** — Mówca: **Player_Italic**
> "I observed the painting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The famous piece depicted a giant, sleeping beneath a vil..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Look at Marcel."]** — Mówca: **Player_Italic**
> "I looked at Marcel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Marcel pointed his finger at me."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Marcel's eyes traveled toward one of the paintings on his wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Italic: "Look at the painting."*)
  - -> `[48]` (*Player_Italic: "Give Lucian a puzzled look."*)
  - -> `[50]` (*Player_Italic: "Look at Marcel."*)
  - -> `[164]` (*Player: "“Let me be *straightforward*. Sit down and get to the dam..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The famous piece depicted a giant, sleeping beneath a village. The trees, rivers and hills were all a part of the giant's body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Its eyes were two caves looking up at the people. It show..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Lucian looked back at me and shrugged. Then he raised his eyebrows, something which he usually did when curious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Marcel pointed his finger at me."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Its eyes were two caves looking up at the people. It showed daylight on the far left and night time on the far right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "The giant seemed to be watching the village. It was total..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "The giant seemed to be watching the village. It was totally unbeknownst to the villagers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Marcel pointed his finger at me."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Marcel pointed his finger at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Marcel Koronti: "“You said we will transform this nation, Mr. Rayne. My co..."*)

### Węzeł `[57]`
Mówca: **Marcel Koronti**
> "“You said we will transform this nation, Mr. Rayne. My conglomerate has a way of doing things and I don't want them to change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“So, I want to cooperate with you.”"*)

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“So, I want to cooperate with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Cooperate?”"*)
  - -> `[60]` (*Player: "“Please, explain further.”"*)
  - -> `[111]` (*Player: "“The intent is mutual.”"*)
  - -> `[166]` (*Player: "“Keep going.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Cooperate?”"]** — Mówca: **Player**
> "“Cooperate?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“You might have the people's support now, Mr. President. ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Please, explain further.”"]** — Mówca: **Player**
> "“Please, explain further.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“You might have the people's support now, Mr. President. ..."*)

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“You might have the people's support now, Mr. President. But what happens when you make mistakes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Marcel Koronti: "“Everybody makes mistakes...”"*)

### Węzeł `[62]`
Mówca: **Petr Vectern**
> "“What is that supposed to mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“Let's hear his point, Vice President.”"*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Let's hear his point, Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Marcel Koronti: "“Being a president in this country means having many enem..."*)

### Węzeł `[64]`
Mówca: **Marcel Koronti**
> "“...If they were released.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“I see where you are getting at.”"*)
  - -> `[65]` (*Player: "“Continue.”"*)
  - -> `[66]` (*Player: "“You are playing a dangerous game.”"*)
  - -> `[116]` (*Player: "“Are you threatening me?”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Continue.”"]** — Mówca: **Player**
> "“Continue.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Marcel Koronti: "“Now, assume that the press would actually protect your i..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“You are playing a dangerous game.”"]** — Mówca: **Player**
> "“You are playing a dangerous game.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Marcel Koronti: "“We are all dangerous men playing dangerous games.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I see where you are getting at.”"]** — Mówca: **Player**
> "“I see where you are getting at.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Marcel Koronti: "“You knew that a long time before you came here.”"*)

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Now, assume that the press would actually protect your integrity no matter what. That the people I reach -- up to five million of them -- will not lose faith in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Let's hear your offer.”"*)
  - -> `[71]` (*Player: "“What do you want in return?”"*)
  - -> `[72]` (*Player: "“You aren’t just being nice, are you?”"*)

### Węzeł `[69]`
Mówca: **Marcel Koronti**
> "“You knew that a long time before you came here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Let's hear your offer.”"*)
  - -> `[71]` (*Player: "“What do you want in return?”"*)
  - -> `[72]` (*Player: "“You aren’t just being nice, are you?”"*)

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“We are all dangerous men playing dangerous games.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Let's hear your offer.”"*)
  - -> `[71]` (*Player: "“What do you want in return?”"*)
  - -> `[72]` (*Player: "“You aren’t just being nice, are you?”"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What do you want in return?”"]** — Mówca: **Player**
> "“What do you want in return?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Marcel Koronti), `[69]` (Marcel Koronti), `[70]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“I want two things, Mr. President. Number one is a guaran..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“You aren’t just being nice, are you?”"]** — Mówca: **Player**
> "“You aren’t just being nice, are you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Marcel Koronti), `[69]` (Marcel Koronti), `[70]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“I want two things, Mr. President. Number one is a guaran..."*)

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“I want two things, Mr. President. Number one is a guarantee from you that the Rayne administration won't meddle in HOS affairs, no matter what happens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Number two is a simple gentleman's favor for the future...."*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Number two is a simple gentleman's favor for the future. Let me prove my services to you first, and I'm sure you won't disapprove when the time comes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“This is far too risky for me.”"*)
  - -> `[76]` (*Player: "“It is an interesting proposal.”"*)
  - -> `[77]` (*Player: "“How do I know that I can trust you?”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“This is far too risky for me.”"]** — Mówca: **Player**
> "“This is far too risky for me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Marcel Koronti: "“Great risk means great reward. This mutually beneficial ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“It is an interesting proposal.”"]** — Mówca: **Player**
> "“It is an interesting proposal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Marcel Koronti: "“Not just interesting but necessary. You surely know that..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“How do I know that I can trust you?”"]** — Mówca: **Player**
> "“How do I know that I can trust you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Marcel Koronti: "“My circle advised against this. They don't even know we ..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“I think it is a good deal. He is right, we will need the media support. With his newspapers and channels on our side we can dodge a lot of bullets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“The one thing that bothers me though is his favor reques..."*)

### Węzeł `[79]`
Mówca: **Petr Vectern**
> "“I think he is getting more out of this than we are. He wouldn't be offering such a risky deal unless he wanted something big.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Petr Vectern: "“We need to be cautious. If we get caught or this gets ou..."*)

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“Great risk means great reward. This mutually beneficial cooperation will help you greatly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Marcel Koronti: "“I can guarantee that you will see its benefits sooner th..."*)

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“I can guarantee that you will see its benefits sooner than later. We can make history together, if we dare to challenge the odds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“We have a deal.”"*)
  - -> `[86]` (*Player: "“What do you think about this, Lucian?”"*)
  - -> `[87]` (*Player: "“You have been awfully silent, Petr.”"*)
  - -> `[92]` (*Player: "“Mr. Koronti, I have to reject.”"*)

### Węzeł `[82]`
Mówca: **Marcel Koronti**
> "“Not just interesting but necessary. You surely know that this is a win-win situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Marcel Koronti: "“The media will be on your side strengthening your positi..."*)

### Węzeł `[83]`
Mówca: **Marcel Koronti**
> "“The media will be on your side strengthening your position. It will also protect my business operations throughout the changes this country will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“We have a deal.”"*)
  - -> `[86]` (*Player: "“What do you think about this, Lucian?”"*)
  - -> `[87]` (*Player: "“You have been awfully silent, Petr.”"*)
  - -> `[92]` (*Player: "“Mr. Koronti, I have to reject.”"*)

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“My circle advised against this. They don't even know we are meeting. Mr. President, we're both putting ourselves at risk here, but I am willing to trust you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Marcel Koronti: "“The question is; are you willing to trust me and accept ..."*)

### Węzeł `[85]`
Mówca: **Marcel Koronti**
> "“The question is; are you willing to trust me and accept this offer?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“We have a deal.”"*)
  - -> `[86]` (*Player: "“What do you think about this, Lucian?”"*)
  - -> `[87]` (*Player: "“You have been awfully silent, Petr.”"*)
  - -> `[92]` (*Player: "“Mr. Koronti, I have to reject.”"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“What do you think about this, Lucian?”"]** — Mówca: **Player**
> "“What do you think about this, Lucian?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Marcel Koronti), `[83]` (Marcel Koronti), `[85]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Lucian leaned over to my ear and whispered."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“You have been awfully silent, Petr.”"]** — Mówca: **Player**
> "“You have been awfully silent, Petr.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Marcel Koronti), `[83]` (Marcel Koronti), `[85]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Petr leaned over to my ear and whispered."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“The one thing that bothers me though is his favor request. We do not know what he'll ask for, and it could be something that endangers our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Marcel interrupted us."*)

### Węzeł `[89]`
Mówca: **Petr Vectern**
> "“We need to be cautious. If we get caught or this gets out, I can't imagine the consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Marcel interrupted us."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Petr leaned over to my ear and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: "“I think he is getting more out of this than we are. He w..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Lucian leaned over to my ear and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: "“I think it is a good deal. He is right, we will need the..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Mr. Koronti, I have to reject.”"]** — Mówca: **Player**
> "“Mr. Koronti, I have to reject.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Marcel Koronti), `[83]` (Marcel Koronti), `[85]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias = false"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“We have a deal.”"]** — Mówca: **Player**
> "“We have a deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Marcel Koronti), `[83]` (Marcel Koronti), `[85]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias = true; BaseGame.Situat..."*)

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“Happy to hear that. You can contact me personally through this number.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Marcel Koronti: "“As soon as you know that a story against you will break,..."*)

### Węzeł `[95]`
Mówca: **Marcel Koronti**
> "“I hope you will uphold your end of the bargain as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Italic: "Shake his hand."*)
  - -> `[105]` (*Player: "“A deal is a deal.”"*)
  - -> `[106]` (*Player: "“You can bet on it.”"*)
  - -> `[132]` (*Player: "“As long as you do.”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "Return to Holsord."]** — Mówca: **Player_Italic**
> "We returned to Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Lucian Galade), `[128]` (Lucian Galade), `[129]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_MediaDeal = true"*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“Thank you for your time, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Italic: "Return to Holsord."*)

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“Such a pity, Mr. President. And here I thought we were going to be good friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: "“It's a shame. Really.”"*)

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“It's a shame. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“Goodbye, Mr. Koronti.”"*)
  - -> `[107]` (*Player: "“Remember who you are speaking to, Mr. Koronti.”"*)
  - -> `[108]` (*Player: "“I regret coming here to see you.”"*)

### Węzeł `[100]`
Mówca: **Petr Vectern**
> "“Let's leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "We left the complex and entered the car."*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“I was hoping that would end better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Agreed.”"*)
  - -> `[126]` (*Player: "“It was your idea.”"*)
  - -> `[127]` (*Player: "“He pushed it too far.”"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias = true;
BaseGame.Situation_Law_MediaBias = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = true;
Variable["BaseGame.Situation_Law_MediaBias"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal = true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel = true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_A_MediaDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_A_MediaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmerge..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“A deal is a deal.”"]** — Mówca: **Player**
> "“A deal is a deal. It will be upheld.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Marcel Koronti: "“A man of his word, excellent.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“You can bet on it.”"]** — Mówca: **Player**
> "“You can bet on it. I'm a man of my word.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Marcel Koronti: "“I rarely bet, but when I do, all possibilities are accou..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Remember who you are speaking to, Mr. Koronti.”"]** — Mówca: **Player**
> "“Remember who you are speaking to, Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Marcel Koronti: "“Oh, I know very well.”"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I regret coming here to see you.”"]** — Mówca: **Player**
> "“I regret coming here to see you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Marcel Koronti: "“Hm.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I remained silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Marcel Koronti: "“It's time to look forward. Let's talk about our bright f..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Marcel Koronti), `[35]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“The intent is mutual.”"]** — Mówca: **Player**
> "“The intent is mutual.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“You might have the people's support now, Mr. President. ..."*)

### Węzeł `[112]`
Mówca: **Marcel Koronti**
> "“Everybody makes mistakes...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Petr Vectern: "“What is that supposed to mean?”"*)

### Węzeł `[113]`
Mówca: **Marcel Koronti**
> "“Being a president in this country means having many enemies. Enemies that would resort to anything to bring you down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Marcel Koronti: "“Let’s say these enemies caused a scandal or leaked sensi..."*)

### Węzeł `[114]`
Mówca: **Marcel Koronti**
> "“Let’s say these enemies caused a scandal or leaked sensitive information from the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Marcel Koronti: "“These would be destructive once they were released...”"*)

### Węzeł `[115]`
Mówca: **Marcel Koronti**
> "“These would be destructive once they were released...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Marcel Koronti: "“...If they were released.”"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Are you threatening me?”"]** — Mówca: **Player**
> "“Are you threatening me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Marcel Koronti: "“Absolutely not. I'm merely offering a helping hand.”"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Let's hear your offer.”"]** — Mówca: **Player**
> "“Let's hear your offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Marcel Koronti), `[69]` (Marcel Koronti), `[70]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“I want two things, Mr. President. Number one is a guaran..."*)

### Węzeł `[118]`
Mówca: **Marcel Koronti**
> "“Absolutely not. I'm merely offering a helping hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Let's hear your offer.”"*)
  - -> `[71]` (*Player: "“What do you want in return?”"*)
  - -> `[119]` (*Player: "“It doesn't sound like help.”"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“It doesn't sound like help.”"]** — Mówca: **Player**
> "“It doesn't sound like help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Marcel Koronti: "“I harbor no ill will. It is up to you whether to accept ..."*)

### Węzeł `[120]`
Mówca: **Marcel Koronti**
> "“I harbor no ill will. It is up to you whether to accept my support or not. Let me at least explain further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "“Make your case.”"*)
  - -> `[121]` (*Player: "“I have heard enough.”"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“I have heard enough.”"]** — Mówca: **Player**
> "“I have heard enough.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias = false"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Make your case.”"]** — Mówca: **Player**
> "“Make your case.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“I want two things, Mr. President. Number one is a guaran..."*)

### Węzeł `[123]`
Mówca: **Marcel Koronti**
> "“So... do we have a deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“We have a deal.”"*)
  - -> `[92]` (*Player: "“Mr. Koronti, I have to reject.”"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Goodbye, Mr. Koronti.”"]** — Mówca: **Player**
> "“Goodbye, Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: "“Let's leave.”"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Agreed.”"]** — Mówca: **Player**
> "“Agreed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: "“I'm sorry. I should have seen it coming.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“It was your idea.”"]** — Mówca: **Player**
> "“It was your idea.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Lucian didn't comment."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“He pushed it too far.”"]** — Mówca: **Player**
> "“He pushed it too far.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucian Galade: "“The threats were unacceptable.”"*)

### Węzeł `[128]`
Mówca: **Lucian Galade**
> "“The threats were unacceptable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Italic: "Return to Holsord."*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> "“I'm sorry. I should have seen it coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Italic: "Return to Holsord."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Lucian didn't comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Italic: "Return to Holsord."*)

### Węzeł `[131]`
Mówca: **Marcel Koronti**
> "“As soon as you know that a story against you will break, please call me and it will be taken care of.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Marcel Koronti: "“I hope you will uphold your end of the bargain as well.”"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“As long as you do.”"]** — Mówca: **Player**
> "“As long as you do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Marcel Koronti: "“You can count on me.”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Anything to keep me away from home.”"]** — Mówca: **Player**
> "“Anything to keep me away from home.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: "“That bad, huh? Well this should prove distracting. Shall..."*)

### Węzeł `[134]`
Mówca: **Petr Vectern**
> "“That bad, huh? Well this should prove distracting. Shall we then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Enter the building."*)

### Węzeł `[135]`
Mówca: **Marcel Koronti**
> "“The past months have been tumultuous to say the least, I am glad you and your family were unharmed at the shooting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Marcel Koronti: "“The whole incident must have been a shock for the kids. ..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“They were startled, but the important thing is they are safe and sound.”"]** — Mówca: **Player**
> "“They were startled, but the important thing is they are safe and sound.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Marcel Koronti: "“Of course that is all that matters. No family should suf..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“I will not allow this situation to continue.”"]** — Mówca: **Player**
> "“I will not allow this situation to continue.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Marcel Koronti: "“The restoration of order is important for business and t..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“I stayed and served my country dutifully.”"]** — Mówca: **Player**
> "“I stayed and served my country dutifully.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Marcel Koronti: "“I am sure you did. My father also served this country an..."*)

### Węzeł `[139]`
Mówca: **Marcel Koronti**
> "“The whole incident must have been a shock for the kids. They aren't used to what we lived through back in the late '20s. I still remember when my father took us out of the country when it became too dangerous in Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[136]` (*Player: "“They were startled, but the important thing is they are ..."*)
  - -> `[143]` (*Player: "“Spare me your life story, Mr. Koronti.”"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“I will not allow this situation to continue.”"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
**[WYBÓR GRACZA: "“Spare me your life story, Mr. Koronti.”"]** — Mówca: **Player**
> "“Spare me your life story, Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Marcel Koronti: "“As you wish, but it's an amazing life story.”"*)

### Węzeł `[144]`
Mówca: **Marcel Koronti**
> "“The restoration of order is important for business and the political atmosphere, but one must consider the measures and cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Marcel Koronti: "“Well... I am known to be a straightforward person. So, l..."*)

### Węzeł `[145]`
Mówca: **Marcel Koronti**
> "“Of course that is all that matters. No family should suffer from tragedy ever again, we've had enough of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Marcel Koronti: "“Well... I am known to be a straightforward person. So, l..."*)

### Węzeł `[146]`
Mówca: **Marcel Koronti**
> "“As you wish, but it's an amazing life story.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "He gave a cheeky smile."*)

### Węzeł `[147]`
Mówca: **Marcel Koronti**
> "“I am sure you did. My father also served this country and employed thousands in those times of crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Marcel Koronti: "“Well... I am known to be a straightforward person. So, l..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Military_Order_Accomplished == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: "“I stayed and served my country dutifully.”"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Military_Order_Accomplished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
Mówca: **Narrator**
> "Marcel interrupted us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Marcel Koronti: "“So... do we have a deal?”"*)

### Węzeł `[152]`
Mówca: **Marcel Koronti**
> "“Oh, I know very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: "“Let's leave.”"*)

### Węzeł `[153]`
Mówca: **Marcel Koronti**
> "“Hm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: "“Let's leave.”"*)

### Węzeł `[154]`
Mówca: **Marcel Koronti**
> "“A man of his word, excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Marcel Koronti: "“We will meet again. Goodbye.”"*)

### Węzeł `[155]`
Mówca: **Marcel Koronti**
> "“I rarely bet, but when I do, all possibilities are accounted for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Marcel Koronti: "“We will meet again. Goodbye.”"*)

### Węzeł `[156]`
Mówca: **Marcel Koronti**
> "“You can count on me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Marcel Koronti: "“We will meet again. Goodbye.”"*)

### Węzeł `[157]`
Mówca: **Narrator**
> "We left the complex and entered the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: "“I was hoping that would end better.”"*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Marcel put his second hand on mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Marcel Koronti: "“We will meet again. Goodbye.”"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Marcel put his second hand on mine."*)

### Węzeł `[160]`
Mówca: **Marcel Koronti**
> "“We will meet again. Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: "“Thank you for your time, Mr. Koronti.”"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“I can't think of comfort when our country is descending into chaos.”"]** — Mówca: **Player**
> "“I can't think of comfort when our country is descending into chaos.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Petr Vectern: "“When you put it like that...”"*)

### Węzeł `[162]`
Mówca: **Petr Vectern**
> "“When you put it like that...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Enter the building."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Let's just get to the point.”"]** — Mówca: **Player**
> "“Let's just get to the point.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Marcel gently pointed at the seats. We sat down around a ..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Let me be *straightforward*. Sit down and get to the damn point.”"]** — Mówca: **Player**
> "“Let me be *straightforward*. Sit down and get to the damn point.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Marcel Koronti: "“Ah no need be rude, Mr. President. We are only here to c..."*)

### Węzeł `[165]`
Mówca: **Marcel Koronti**
> "“Ah no need be rude, Mr. President. We are only here to conduct business, aren't we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Marcel pointed his finger at me."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "“Keep going.”"]** — Mówca: **Player**
> "“Keep going.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“You might have the people's support now, Mr. President. ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_StruckDealWithMarcel = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_StruckDealWithMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Marcel Koronti: "“Happy to hear that. You can contact me personally throug..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2; BaseGame.Democratic += 1;"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Accepted_MediaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 2; BaseGame.Democratic -= 2;"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 2; BaseGame.Democratic -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_StruckDealWithMarcel = true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "He gave a cheeky smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Marcel Koronti: "“Well... I am known to be a straightforward person. So, l..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2; BaseGame.Democratic += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Marcel Koronti: "“Such a pity, Mr. President. And here I thought we were g..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
