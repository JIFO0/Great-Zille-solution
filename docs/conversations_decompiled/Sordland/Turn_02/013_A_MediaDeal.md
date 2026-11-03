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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 10

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[102]` (Lucian Galade): `Variable["BaseGame.Media_SordlandToday_Bias"] = true; Variable["BaseGame.Situation_Law_MediaBias"...`
- Węzeł `[103]` (Lucian Galade): `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- Węzeł `[104]` (Lucian Galade): `Variable["GameCondition.Turn02_A_MediaDeal"] = true;`
- Węzeł `[167]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn02_StruckDealWithMarcel"] = true;`
- Węzeł `[168]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel"] = true;`
- Węzeł `[169]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmergency"] = true;`
- Węzeł `[170]` (Lucian Galade): `Variable["BaseGame.Accepted_MediaDeal"] = true;`
- Węzeł `[171]` (Lucian Galade): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2; Variable["BaseGame...`
- *...oraz 2 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Our motorcade headed to the meeting location set by Marcel Koronti. I had only my most confidential and trustworthy team members with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“I hope the journey was comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[133]`
  - -> `[13]`
  - -> `[161]`

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“He would have been very happy to hear this from you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Where are we, Serge?”"]** — Mówca: **Player**
> "“Where are we, Serge?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Look outside."]** — Mówca: **Player_Italic**
> "I looked outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Narrator**
> "After a few hours of driving along River Eskel, we took a turn before entering Conriat. The darkness started setting in as we drove up to a hill."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I could see giant stadium lights on the hilltop far away in the distance. It looked like a massive complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[10]`
Mówca: **Serge Wolkner**
> "“We are nearing the HOS Country Club, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Narrator**
> "We arrived and the big iron gates of the country club opened. It was huge and outright extravagant. The main building, inspired by Lespian architecture, was illuminated from all sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“The location is very remote indeed.”"]** — Mówca: **Player**
> "“The location is very remote indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“It wasn't bad. I am looking forward to this meeting.”"]** — Mówca: **Player**
> "“It wasn't bad. I am looking forward to this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Serge Wolkner**
> "“We'll be there shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
Mówca: **Serge Wolkner**
> "“We are nearing our destination.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Enter the building."]** — Mówca: **Player_Italic**
> "We entered the main building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[17]`
Mówca: **Petr Vectern**
> "“It's a very exclusive country club for people who value their privacy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“I am sure it will be worth our time. He is a Koronti after all. Let’s get personal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "It was rather chilly. I was approached by Petr Vectern and Lucian Galade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> "“Let's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[21]`
Mówca: **Narrator**
> "After opening the marble engraved wooden door, we were greeted by two tall women. The receptionists led us to the meeting room upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Marcel was standing by the window looking outside at the beautiful complex. He turned around to have a quick look at us both."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He was a strikingly handsome man with well-groomed hair. He walked towards me with his hand reached out for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "Reach out for a handshake."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> "“It is such a pleasure to meet you in person, Mr. Koronti. I appreciate your efforts to reach out and establish a mutually beneficial friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[27]`
Mówca: **Narrator**
> "He put his hand back in his pocket and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Narrator**
> "He had a firm grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Yes. There is much to discuss.”"]** — Mówca: **Player**
> "“Yes. There is much to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“I heard about your meteoric rise in HOS.”"]** — Mówca: **Player**
> "“I heard about your meteoric rise in HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Let’s have a seat.”"]** — Mówca: **Player**
> "“Let’s have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[32]`
Mówca: **Marcel Koronti**
> "“Believe it or not I have been a secret admirer of your political success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Marcel Koronti**
> "“I find your quick rise to power was shockingly well-executed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[44]`
  - -> `[45]`
  - -> `[110]`

### Węzeł `[34]`
Mówca: **Marcel Koronti**
> "“I'm flattered. You truly are going to be the best President this country has seen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“I say this because you have gone against the odds and survived. I respect that more than anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> "“Thanks for hosting us. I admired your father very much, may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“May he rest in peace. He was a true entrepreneur.”"]** — Mówca: **Player**
> "“May he rest in peace. He was a true entrepreneur.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Please accept our condolences. We are saddened.”"]** — Mówca: **Player**
> "“Please accept our condolences. We are saddened.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[39]`
Mówca: **Marcel Koronti**
> "“Welcome. Your kind words have touched me, Mr. Vice President. He was indeed a great man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[109]`

### Węzeł `[40]`
Mówca: **Marcel Koronti**
> "“It's time to look forward. Let's talk about our bright future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[31]`
  - -> `[30]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Marcel gently pointed at the seats. We sat down around a gigantic table. Before speaking he knocked on wood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“It seems we had similar experiences.”"]** — Mówca: **Player**
> "“It seems we had similar experiences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Politics is a ladder. The higher you climb the more chaos is around you.”"]** — Mówca: **Player**
> "“Politics is a ladder. The higher you climb the more chaos is around you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“I would not be standing here if I was bad at what I do.”"]** — Mówca: **Player**
> "“I would not be standing here if I was bad at what I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“The admiration goes both ways.”"]** — Mówca: **Player**
> "“The admiration goes both ways.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[46]`
Mówca: **Marcel Koronti**
> "“Well... I am known to be a straightforward person. So, let me get to the point without wasting your valuable time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Marcel Koronti**
> "“It was during the Alphonso campaign when I was struck by what you managed to do within the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Give Lucian a puzzled look."]** — Mówca: **Player_Italic**
> "I looked at Lucian Galade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Look at the painting."]** — Mówca: **Player_Italic**
> "I observed the painting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Look at Marcel."]** — Mówca: **Player_Italic**
> "I looked at Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Marcel's eyes traveled toward one of the paintings on his wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[48]`
  - -> `[50]`
  - -> `[164]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The famous piece depicted a giant, sleeping beneath a village. The trees, rivers and hills were all a part of the giant's body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Lucian looked back at me and shrugged. Then he raised his eyebrows, something which he usually did when curious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Its eyes were two caves looking up at the people. It showed daylight on the far left and night time on the far right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "The giant seemed to be watching the village. It was totally unbeknownst to the villagers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Marcel pointed his finger at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Marcel Koronti**
> "“You said we will transform this nation, Mr. Rayne. My conglomerate has a way of doing things and I don't want them to change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“So, I want to cooperate with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`
  - -> `[111]`
  - -> `[166]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Cooperate?”"]** — Mówca: **Player**
> "“Cooperate?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Please, explain further.”"]** — Mówca: **Player**
> "“Please, explain further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“You might have the people's support now, Mr. President. But what happens when you make mistakes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[62]`
Mówca: **Petr Vectern**
> "“What is that supposed to mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Let's hear his point, Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[64]`
Mówca: **Marcel Koronti**
> "“...If they were released.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[65]`
  - -> `[66]`
  - -> `[116]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Continue.”"]** — Mówca: **Player**
> "“Continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“You are playing a dangerous game.”"]** — Mówca: **Player**
> "“You are playing a dangerous game.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I see where you are getting at.”"]** — Mówca: **Player**
> "“I see where you are getting at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Now, assume that the press would actually protect your integrity no matter what. That the people I reach -- up to five million of them -- will not lose faith in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Marcel Koronti**
> "“You knew that a long time before you came here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“We are all dangerous men playing dangerous games.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What do you want in return?”"]** — Mówca: **Player**
> "“What do you want in return?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“You aren’t just being nice, are you?”"]** — Mówca: **Player**
> "“You aren’t just being nice, are you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“I want two things, Mr. President. Number one is a guarantee from you that the Rayne administration won't meddle in HOS affairs, no matter what happens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Number two is a simple gentleman's favor for the future. Let me prove my services to you first, and I'm sure you won't disapprove when the time comes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“This is far too risky for me.”"]** — Mówca: **Player**
> "“This is far too risky for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“It is an interesting proposal.”"]** — Mówca: **Player**
> "“It is an interesting proposal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“How do I know that I can trust you?”"]** — Mówca: **Player**
> "“How do I know that I can trust you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“I think it is a good deal. He is right, we will need the media support. With his newspapers and channels on our side we can dodge a lot of bullets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[79]`
Mówca: **Petr Vectern**
> "“I think he is getting more out of this than we are. He wouldn't be offering such a risky deal unless he wanted something big.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“Great risk means great reward. This mutually beneficial cooperation will help you greatly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“I can guarantee that you will see its benefits sooner than later. We can make history together, if we dare to challenge the odds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[86]`
  - -> `[87]`
  - -> `[92]`

### Węzeł `[82]`
Mówca: **Marcel Koronti**
> "“Not just interesting but necessary. You surely know that this is a win-win situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Marcel Koronti**
> "“The media will be on your side strengthening your position. It will also protect my business operations throughout the changes this country will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[86]`
  - -> `[87]`
  - -> `[92]`

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“My circle advised against this. They don't even know we are meeting. Mr. President, we're both putting ourselves at risk here, but I am willing to trust you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Marcel Koronti**
> "“The question is; are you willing to trust me and accept this offer?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[86]`
  - -> `[87]`
  - -> `[92]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“What do you think about this, Lucian?”"]** — Mówca: **Player**
> "“What do you think about this, Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“You have been awfully silent, Petr.”"]** — Mówca: **Player**
> "“You have been awfully silent, Petr.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“The one thing that bothers me though is his favor request. We do not know what he'll ask for, and it could be something that endangers our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[89]`
Mówca: **Petr Vectern**
> "“We need to be cautious. If we get caught or this gets out, I can't imagine the consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Petr leaned over to my ear and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Lucian leaned over to my ear and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Mr. Koronti, I have to reject.”"]** — Mówca: **Player**
> "“Mr. Koronti, I have to reject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“We have a deal.”"]** — Mówca: **Player**
> "“We have a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“Happy to hear that. You can contact me personally through this number.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[95]`
Mówca: **Marcel Koronti**
> "“I hope you will uphold your end of the bargain as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[105]`
  - -> `[106]`
  - -> `[132]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "Return to Holsord."]** — Mówca: **Player_Italic**
> "We returned to Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“Thank you for your time, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“Such a pity, Mr. President. And here I thought we were going to be good friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“It's a shame. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
> "“Let's leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“I was hoping that would end better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[127]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias = true;
BaseGame.Situation_Law_MediaBias = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = true;
Variable["BaseGame.Situation_Law_MediaBias"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_A_MediaDeal = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_A_MediaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“A deal is a deal.”"]** — Mówca: **Player**
> "“A deal is a deal. It will be upheld.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“You can bet on it.”"]** — Mówca: **Player**
> "“You can bet on it. I'm a man of my word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Remember who you are speaking to, Mr. Koronti.”"]** — Mówca: **Player**
> "“Remember who you are speaking to, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I regret coming here to see you.”"]** — Mówca: **Player**
> "“I regret coming here to see you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I remained silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“The intent is mutual.”"]** — Mówca: **Player**
> "“The intent is mutual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[112]`
Mówca: **Marcel Koronti**
> "“Everybody makes mistakes...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[113]`
Mówca: **Marcel Koronti**
> "“Being a president in this country means having many enemies. Enemies that would resort to anything to bring you down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Marcel Koronti**
> "“Let’s say these enemies caused a scandal or leaked sensitive information from the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Marcel Koronti**
> "“These would be destructive once they were released...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Are you threatening me?”"]** — Mówca: **Player**
> "“Are you threatening me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Let's hear your offer.”"]** — Mówca: **Player**
> "“Let's hear your offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[118]`
Mówca: **Marcel Koronti**
> "“Absolutely not. I'm merely offering a helping hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[71]`
  - -> `[119]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“It doesn't sound like help.”"]** — Mówca: **Player**
> "“It doesn't sound like help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Marcel Koronti**
> "“I harbor no ill will. It is up to you whether to accept my support or not. Let me at least explain further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[121]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“I have heard enough.”"]** — Mówca: **Player**
> "“I have heard enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Make your case.”"]** — Mówca: **Player**
> "“Make your case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[123]`
Mówca: **Marcel Koronti**
> "“So... do we have a deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[92]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Goodbye, Mr. Koronti.”"]** — Mówca: **Player**
> "“Goodbye, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Agreed.”"]** — Mówca: **Player**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“It was your idea.”"]** — Mówca: **Player**
> "“It was your idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“He pushed it too far.”"]** — Mówca: **Player**
> "“He pushed it too far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
> "“The threats were unacceptable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> "“I'm sorry. I should have seen it coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Lucian didn't comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[131]`
Mówca: **Marcel Koronti**
> "“As soon as you know that a story against you will break, please call me and it will be taken care of.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“As long as you do.”"]** — Mówca: **Player**
> "“As long as you do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Anything to keep me away from home.”"]** — Mówca: **Player**
> "“Anything to keep me away from home.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
> "“That bad, huh? Well this should prove distracting. Shall we then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[135]`
Mówca: **Marcel Koronti**
> "“The past months have been tumultuous to say the least, I am glad you and your family were unharmed at the shooting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“They were startled, but the important thing is they are safe and sound.”"]** — Mówca: **Player**
> "“They were startled, but the important thing is they are safe and sound.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“I will not allow this situation to continue.”"]** — Mówca: **Player**
> "“I will not allow this situation to continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“I stayed and served my country dutifully.”"]** — Mówca: **Player**
> "“I stayed and served my country dutifully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[139]`
Mówca: **Marcel Koronti**
> "“The whole incident must have been a shock for the kids. They aren't used to what we lived through back in the late '20s. I still remember when my father took us out of the country when it became too dangerous in Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[136]`
  - -> `[143]`
  - -> `[148]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
**[WYBÓR GRACZA: "“Spare me your life story, Mr. Koronti.”"]** — Mówca: **Player**
> "“Spare me your life story, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
Mówca: **Marcel Koronti**
> "“The restoration of order is important for business and the political atmosphere, but one must consider the measures and cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[145]`
Mówca: **Marcel Koronti**
> "“Of course that is all that matters. No family should suffer from tragedy ever again, we've had enough of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[146]`
Mówca: **Marcel Koronti**
> "“As you wish, but it's an amazing life story.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[147]`
Mówca: **Marcel Koronti**
> "“I am sure you did. My father also served this country and employed thousands in those times of crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Military_Order_Accomplished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
Mówca: **Narrator**
> "Marcel interrupted us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[152]`
Mówca: **Marcel Koronti**
> "“Oh, I know very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[153]`
Mówca: **Marcel Koronti**
> "“Hm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[154]`
Mówca: **Marcel Koronti**
> "“A man of his word, excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Marcel Koronti**
> "“I rarely bet, but when I do, all possibilities are accounted for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Marcel Koronti**
> "“You can count on me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Narrator**
> "We left the complex and entered the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Marcel put his second hand on mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[160]`
Mówca: **Marcel Koronti**
> "“We will meet again. Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“I can't think of comfort when our country is descending into chaos.”"]** — Mówca: **Player**
> "“I can't think of comfort when our country is descending into chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
> "“When you put it like that...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Let's just get to the point.”"]** — Mówca: **Player**
> "“Let's just get to the point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Let me be *straightforward*. Sit down and get to the damn point.”"]** — Mówca: **Player**
> "“Let me be *straightforward*. Sit down and get to the damn point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Marcel Koronti**
> "“Ah no need be rude, Mr. President. We are only here to conduct business, aren't we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "“Keep going.”"]** — Mówca: **Player**
> "“Keep going.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_StruckDealWithMarcel = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_StruckDealWithMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_RefusedDealWithMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_KesaroDemandsEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Accepted_MediaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 2; BaseGame.Democratic -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[172]`
Mówca: **Narrator**
> "He gave a cheeky smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2; BaseGame.Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
