# Sordland/Turn01/Personal_Ball

- **ID konwersacji:** `9`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/009_Personal_Ball.md`
- **Liczba węzłów dialogowych:** 241
- **Liczba wyborów gracza:** 78

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
- **[46]** Bernard Circas
- **[54]** Serge Wolkner
- **[57]** Reporter
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Prologue_Speech_Democracy_Conservative`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_Immigration_Tighten`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportIntentionAtBall`
- `BaseGameSupport.Codex_Characters_Assembly_BernardCircas`
- `BaseGameSupport.Codex_Characters_Assembly_BernardCircas_Dead`
- `BaseGameSupport.News_Turn01_ST_Interview_CallOthers`
- `BaseGameSupport.News_Turn01_ST_Interview_DifferingValues`
- `BaseGameSupport.News_Turn01_ST_Interview_Negative`
- `BaseGameSupport.News_Turn01_ST_Interview_NoComment`
- `BaseGameSupport.News_Turn01_ST_Interview_NoExpect`
- `BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble`
- `BaseGameSupport.News_Turn01_ST_Interview_Regardless`
- `BaseGameSupport.News_Turn01_ST_Interview_USPPower`
- `BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt`
- `BaseGameSupport.News_Turn01_ST_MPShot`
- `BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased`
- `GameCondition.Turn01_Personal_Ball`

### Skoki między-konwersacyjne:
- Węzeł `[89]` -> **[10] Sordland/Turn01/Ball Prep and Travel** (../Turn_01/010_Ball_Prep_and_Travel.md), Węzeł `[1]`
- Węzeł `[92]` -> **[11] Sordland/Turn01/Shooting** (../Turn_01/011_Shooting.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 22

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportIntentionAtBall`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[94]` (Monica): `Variable["GameCondition.Turn01_Personal_Ball"] = true;`
- Węzeł `[103]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt"] = true; ;`
- Węzeł `[104]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_CallOthers"] = true;`
- Węzeł `[105]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoExpect"] = true;`
- Węzeł `[106]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoComment"] = true;`
- Węzeł `[107]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_Regardless"] = true;`
- Węzeł `[108]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_DifferingValues"] = true;`
- Węzeł `[109]` (Monica): `Variable["BaseGameSupport.News_Turn01_ST_Interview_Negative"] = true;`
- *...oraz 14 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Monica)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had just finished buttoning up my suit jacket when the doorbell rang. The Presidential Guard had arrived to pick us up for the inaugural ball."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The ball was a three-decade-old tradition, breathlessly anticipated by politicians, bureaucrats and the press. All eyes were about to be on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[5]`
Mówca: **Narrator**
> "My guards fended most of them off, but one woman managed to dodge them and corner me. I recognized the Sordish Broadcasting Company logo on her press lanyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“If the opposition is willing to support us.”"]** — Mówca: **Player**
> "“If the opposition is willing to support us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“My administration will bring real change.”"]** — Mówca: **Player**
> "“My administration will bring real change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“This night is for celebration. I’m not going to talk about my policies now.”"]** — Mówca: **Player**
> "“This night is for celebration. I’m not going to talk about my policies now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“We are going to work with everybody.”"]** — Mówca: **Player**
> "“We are going to work with everybody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[10]`
Mówca: **Reporter**
> "“Do you plan on working together with the opposition parties on the expected constitutional reforms?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[6]`
  - -> `[9]`

### Węzeł `[11]`
Mówca: **Reporter**
> "“Does that mean you don’t plan on working together? Do you think you share no common ground with the other parties?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[12]`
Mówca: **Reporter**
> "“Mr. Ricter clarified that as long as you hold your promises of democratization, they will support you on these issues to the end. What do you think about this statement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I did not say that.”"]** — Mówca: **Player**
> "“I did not say that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“We will do our job, no matter what.”"]** — Mówca: **Player**
> "“We will do our job, no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I don’t think the opposition shares our values, no.”"]** — Mówca: **Player**
> "“I don’t think the opposition shares our values, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""No comment, sorry.""]** — Mówca: **Player**
> "“No comment, sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I welcome it. This is a challenge for us all.”"]** — Mówca: **Player**
> "“I welcome it. This is a challenge for us all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“We want the other parties to join him in this endeavor.”"]** — Mówca: **Player**
> "“We want the other parties to join him in this endeavor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Honestly, I don’t expect much from him.”"]** — Mówca: **Player**
> "“Honestly, I don’t expect much from him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I can’t comment since I haven’t seen his statement yet.”"]** — Mówca: **Player**
> "“I can’t comment since I haven’t seen his statement yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[21]`
Mówca: **Reporter**
> ""One more question. One of your first acts as president was to sign a campaign finance law allocating public election funds by seats in the Assembly as opposed to number of votes. Is this a deliberate attempt to defund the Communist Party and the Bludia Workers' Party, neither of which have reached the election threshold?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`
  - -> `[122]`
  - -> `[133]`

### Węzeł `[22]`
Mówca: **Narrator**
> "“That’s enough, ma'am,” said one of my guards while nudging the reporter away from me. A path through the crowd was now open, and we quickly made our way to the entrance of the palace. At the same time, a dozen fireworks went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "The entrance was decorated with beautiful ribbons in Sordland’s colors of white, yellow and maroon. A lush maroon carpet had been rolled down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "We entered the lobby and joined the throngs of people making their way towards the ballroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[25]`
Mówca: **Deana**
> "“Uncle Petr!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Franc**
> "“Hi, Uncle Petr. It's great to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> "“There they are, the most beautiful family in Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[28]`
Mówca: **Evelyn Vectern**
> "“Congratulations, Anton. I have to say, the results were clear to me from the beginning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[36]`
  - -> `[37]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> "“You two are growing faster than I am getting wiser!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Are you sure you've gotten any wiser, Petr?”"]** — Mówca: **Player**
> "“Are you sure you've gotten any wiser, Petr?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“You're a sight for sore eyes, Petr.”"]** — Mówca: **Player**
> "“You're a sight for sore eyes, Petr.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Mr. Vice President.”"]** — Mówca: **Player**
> "“Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Inside, we were yet again surrounded by a noisy crowd – but this time, it was the politicians who sought to appease the new authority in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Petr's wife Evelyn approached us and shook our hands with a firmness that belied her delicate features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Appreciated, Evelyn. It means a lot.”"]** — Mówca: **Player**
> "“Appreciated, Evelyn. It means a lot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I wish I was as sure as you.”"]** — Mówca: **Player**
> "“I wish I was as sure as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“There's a woman behind every successful man.”"]** — Mówca: **Player**
> "“There's a woman behind every successful man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Thank you. We both worked hard to make it happen.”"]** — Mówca: **Player**
> "“Thank you. We both worked hard to make it happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[39]`
Mówca: **Evelyn Vectern**
> "“Monica, how are you? You've barely said a word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""And tonight, we reap the rewards!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[71]`
  - -> `[66]`
  - -> `[67]`

### Węzeł `[41]`
Mówca: **Evelyn Vectern**
> "“What a gentleman.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[42]`
Mówca: **Evelyn Vectern**
> "“The pleasure is mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[43]`
Mówca: **Deana**
> "“Papa, can we go? I want to see the ballroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Yes, it's time. Let's go.”"]** — Mówca: **Player**
> "“Yes, it's time. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Of course, darling.”"]** — Mówca: **Player**
> "“Of course, my darling. Let's not delay any longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Move to the ball room."]** — Mówca: **Player_Italic**
> "We left the lobby and made our way towards the ballroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“I'll see you on the trip home.”"]** — Mówca: **Player**
> "“I'll see you on the trip home.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "I stepped out and immediately found myself surrounded by loud voices and camera flashes. Hordes of eager journalists thrust their portable microphones my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Politicians, bureaucrats and celebrities -- the creme de la creme of the Sordland elite -- streamed inside the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Serge Wolkner**
> "“Good luck out there, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> "“Maybe not. After all, I'm still sticking with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
Mówca: **Petr Vectern**
> "“Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Monica**
> "“Happy to see a familiar face, Petr. Evelyn!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[56]`
Mówca: **Reporter**
> "“Mr. President! Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We are having a conversation here, Deana.”"]** — Mówca: **Player**
> "“We are having a conversation here, Deana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "She turned away in disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Monica**
> "“That's all right, we need to go anyway. It's already time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""Come now, you became the president. You held fast against the party leadership and managed to win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Evelyn Vectern**
> "“We know you did. You deserve the position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> "“I think it's time to celebrate this victory!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[71]`
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Thank you, Petr.”"]** — Mówca: **Player**
> "“Thank you, Petr.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I couldn't have done it without you.”"]** — Mówca: **Player**
> "“I couldn't have done it without you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“We could start by getting some drinks.”"]** — Mówca: **Player**
> "“We could start by getting some drinks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Yes, I definitely need a celebration after all that.”"]** — Mówca: **Player**
> "“Yes, I definitely need a celebration after all that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> "“I know you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[69]`
Mówca: **Petr Vectern**
> "“You read my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Petr grinned and beckoned a roving waiter. The four of us each took a glass of champagne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Exactly, that's why we are here.”"]** — Mówca: **Player**
> "“Exactly, that's why we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“I hope you will show the same enthusiasm on the job.”"]** — Mówca: **Player**
> "“I hope you will show the same enthusiasm on the job.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He gave a short smile that looked halfway genuine. He seemed uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“Of course I will! You know me -- I work as hard as I play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Somebody had to do it.”"]** — Mówca: **Player**
> "“Somebody had to do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Petr Vectern**
> ""You're right. I'm glad it was you is all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[77]`
Mówca: **Petr Vectern**
> "“We could start by getting some drinks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Monica smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[79]`
Mówca: **Petr Vectern**
> ""I only did my part, Anton. But, thanks, that means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[80]`
Mówca: **Narrator**
> "We finally settled down at our dinner table with the Vecterns as the band started playing some slow jazz tunes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""Oof. That was tiring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[84]`
  - -> `[87]`
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“We have to get used to it.""]** — Mówca: **Player**
> "“We have to get used to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“If I have to shake another hand again...""]** — Mówca: **Player**
> "“If I have to shake another hand again...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“What, you're already tired?""]** — Mówca: **Player**
> "“What, you're already tired?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Petr Vectern**
> ""Well-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Suddenly, a loud banging noise echoed from outside the ballroom. Then another one. And another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“Another drink?""]** — Mówca: **Player**
> ""Another drink?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
Mówca: **Monica**
> ""I'm more than relieved to have this roller-coaster ride over with. But of course, now the real work begins...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[89]`
Mówca: **Narrator**
> "I called on Monica to get the children ready. Looking in the mirror, I straightened my tie and took a deep breath. After tonight, there would be no turning back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `10` (*Sordland/Turn01/Ball Prep and Travel*), Węzeł `[1]`

### Węzeł `[90]`
Mówca: **Narrator**
> "I spent the next few hours shaking hands, joining various conversations -- some serious, some superficial -- and making speeches."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[91]`
Mówca: **Narrator**
> "The musicians stopped playing. Everyone in the room was looking around in confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""Fireworks!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `11` (*Sordland/Turn01/Shooting*), Węzeł `[1]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Petr and I turned towards each other, realization dawning on both of our faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn01_Personal_Ball = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn01_Personal_Ball"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[95]`
Mówca: **Narrator**
> "At all costs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[96]`
Mówca: **Narrator**
> "I crushed the cigarette on the ashtray."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[97]`
Mówca: **Evelyn Vectern**
> ""Ah, yes. Managing the help, planning parties, daily trips to the salon to look your best for foreign dignitaries --""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Monica**
> "“Don't be so old-fashioned, Evelyn! I plan to use my power as First Lady to advance the position of women throughout Sordland. Equal rights for our sex are long overdue, wouldn't you say, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`
  - -> `[125]`
  - -> `[126]`

### Węzeł `[99]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Conservative == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Conservative == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Speech_Democracy_Conservative == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[102]`
Mówca: **Reporter**
> "“Mr. Ricter clarified that as long as you support their demands of democratization, they will work with you on all issues with a cooperative spirit. What do you think about this statement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[103]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[104]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_CallOthers = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_CallOthers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[105]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_NoExpect = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoExpect"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[106]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_NoComment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoComment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_Regardless = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_Regardless"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_DifferingValues = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_DifferingValues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[109]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_Negative = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_Negative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[110]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_MPShot = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_MPShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[111]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased = true;
BaseGameSupport.Codex_Characters_Assembly_BernardCircas = false; BaseGameSupport.Codex_Characters_Assembly_BernardCircas_Dead = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased"] = true;
Variable["BaseGameSupport.Codex_Characters_Assembly_BernardCircas"] = false;
Variable["BaseGameSupport.Codex_Characters_Assembly_BernardCircas_Dead"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[112]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[113]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[115]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Reporter**
> ""One more question. One of your first acts as president was to veto a campaign finance law that would have deprived small parties of public funds while increasing those channeled to your own. Are we seeing the beginning of a more egalitarian administration?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[142]`
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I've had it with your questions!""]** — Mówca: **Player**
> ""I've had it with your questions!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""It was agreed on by the majority of the GNA. I couldn't use my veto on the first day.""]** — Mówca: **Player**
> ""It was agreed on by the majority of the GNA. I couldn't use my veto on the first day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I've had it with your questions!""]** — Mówca: **Player**
> ""I've had it with your questions!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Yes. No political party deserves to be silenced.""]** — Mówca: **Player**
> ""Yes. No political party deserves to be silenced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I just didn't want to cause too much of a stir on my first day.""]** — Mówca: **Player**
> ""I just didn't want to cause too much of a stir on my first day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Perhaps it was. If left unchecked, those two parties will only make trouble for me.""]** — Mówca: **Player**
> ""Perhaps it was. If left unchecked, those two parties will only make trouble for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""As long as you don't burn the roast. Am I right, Petr?""]** — Mówca: **Player**
> ""As long as you don't burn the roast. Am I right, Petr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Up to a point, yes. They mustn't neglect their responsibilities to their husbands and families.""]** — Mówca: **Player**
> ""Up to a point, yes. They mustn't neglect their responsibilities to their husbands and families.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Absolutely. And we'll work together to achieve that.""]** — Mówca: **Player**
> ""Absolutely. And we'll work together to achieve that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""That's my wife -- never content to be just a pretty face!""]** — Mówca: **Player**
> ""That's my wife -- never content to be just a pretty face!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Petr laughed loudly. Monica and Evelyn both glared at us. An awkward silence descended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Monica opened her mouth, then closed it again. An awkward silence descended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Monica flashed me a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;
BaseGame.Relations_Monica_SupportIntentionAtBall = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;
Variable["BaseGame.Relations_Monica_SupportIntentionAtBall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[131]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Deana suddenly jumped in between us and tugged on my sleeve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""It's to ensure the USP has the funds we need to stay in power long enough to truly bring democracy to this country.""]** — Mówca: **Player**
> ""No, it's to ensure the USP has the funds we need to stay in power long enough to truly bring democracy to this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_USPPower = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_USPPower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[135]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[136]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[137]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[139]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Narrator**
> "I had just finished buttoning up my suit jacket when the doorbell rang. The Presidential Guard had arrived to pick us up for the inaugural ball."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[141]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: PlaySoundEffect("BallGunshot");)*
- **Efekt (`userScript`):** `PlaySoundEffect("BallGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Absolutely. Whether the bill is proposed by my own party or not, I would use my veto on it if it goes against the interest of our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[143]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[144]`
Mówca: **Bernard Circas**
> ""Congratulations, President Rayne. A remarkable achievement, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[149]`
  - -> `[150]`
  - -> `[165]`

### Węzeł `[145]`
Mówca: **Bernard Circas**
> ""Political differences shouldn't keep us from acknowledging achievements. But I still hold out hope that joining the Red Youth wasn't just a phase for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Behind me, I heard a familiar voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[147]`
Mówca: **Bernard Circas**
> "“Perhaps now is the time that our long-nurtured dream of revolution will finally become a reality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[178]`
  - -> `[176]`
  - -> `[177]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Circas. Your congratulations are well received, despite our political differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A remarkable achievement, yes. But the true test begins now, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your congratulations. But from one former Red Youth member to another, we both know our work has just begun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[151]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[153]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[156]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[157]`
Mówca: **Remus Holstron**
> ""President Rayne. You have no idea how happy it makes me to see a fellow Young Sord in the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`
  - -> `[197]`
  - -> `[194]`

### Węzeł `[158]`
Mówca: **Remus Holstron**
> ""We sure have. But I still remember them like they were yesterday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[159]`
Mówca: **Remus Holstron**
> ""Once a Young Sord, always a Young Sord. That's what I believe, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Holstron. Our shared past binds us in this journey for a stronger Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've come a long way from our Young Sords days, haven't we, Mr. Holstron?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Almost as happy as it makes me to see a fellow Young Sord at this ball.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Navigating the sea of guests, I found myself face-to-face with a towering figure. Remus Holstron, the 'Iron Wall', former Young Sord, and a stalwart of the National Front Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[164]`
Mówca: **Narrator**
> "As I navigated through the crowd, a familiar figure stepped into my path. It was Bernard Circas -- the acclaimed poet and now MP. His face bore a look of subtle defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Circas. We've both come a long way from our Red Youth days, haven't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Bernard Circas**
> ""Correct, Mr. President. The real work begins now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[167]`
Mówca: **Bernard Circas**
> ""That's right, President Rayne. Once a Red Youth, always a Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[168]`
Mówca: **Bernard Circas**
> ""Yes, we have. But some things never change, do they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[169]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: RemoveConversant("Bernard Circas");)*
- **Efekt (`userScript`):** `RemoveConversant("Bernard Circas");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[170]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: RemoveConversant("Remus Holstron");)*
- **Efekt (`userScript`):** `RemoveConversant("Remus Holstron");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[171]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Conservative == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Conservative == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[173]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Speech_Democracy_Conservative == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[174]`
Mówca: **Bernard Circas**
> "“I can't help but wonder how the winds of change will blow in our Sordland now that you've taken the helm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Revolution, Mr. Circas? Let's hope it's a peaceful one, for the sake of both Sordland and its new president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be onto something, Bernard. But tonight, let's put politics aside and enjoy the evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Revolution or not, Mr. Circas. It's a night of unity for Sordland. Let's celebrate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sordland needs progress, not revolution. Any upheaval will endanger our chance for improvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
Mówca: **Bernard Circas**
> ""You mustn't forget. To ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[180]`
Mówca: **Bernard Circas**
> ""You're right. Tonight should be a celebration. But remember, to ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
Mówca: **Bernard Circas**
> ""Unity is a rare beast, President Rayne. Remember, to ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
Mówca: **Bernard Circas**
> ""Remember, to ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[183]`
Mówca: **Bernard Circas**
> ""That is the weight of your new role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[184]`
Mówca: **Bernard Circas**
> ""Let's hope for the same for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[185]`
Mówca: **Bernard Circas**
> ""We will share this journey together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Bernard Circas**
> ""Danger and progress... they might be more intertwined than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Bernard Circas**
> ""I've taken up enough of your time, President Rayne. This is your night, after all. Your family, friends, and country await.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[190]`
  - -> `[189]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks for sharing your wisdom, Mr. Circas. Enjoy your evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well said, Bernard. I'll see you inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You certainly have a way with words, Mr. Circas. I see why they gave you the Vulpitzer Award.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
Mówca: **Narrator**
> "Were they mere poetic expressions? Or a reflection of the real socialist sentiments stirring within the country?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[192]`
Mówca: **Narrator**
> "As I watched Bernard Circas blend back into the crowd, his words echoed in my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[193]`
Mówca: **Bernard Circas**
> ""Until we meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your sentiments, Mr. Holstron. This triumph belongs to every Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Remus Holstron**
> ""I know every maroon-blooded Sord is rejoicing at your victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[196]`
Mówca: **Remus Holstron**
> ""From street brawls in Jen to handshakes at the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[197]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[199]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Speech_Democracy_Liberal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[200]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Tighten == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Tighten == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Tighten"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[202]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Immigration_Tighten == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Tighten"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[203]`
Mówca: **Remus Holstron**
> ""My time in the Young Sords taught me a lot about the true spirit of this nation. You too, I bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Remus Holstron**
> ""Think of Sordland like a piece of iron forged in fire. Strengthened by the flame of dedication and the hammer of order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[208]`
  - -> `[206]`
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Nicely put, Mr. Holstron. Our shared past and values will help in forging a strong Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't forget the importance of embracing new ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your emphasis on order and strength concerns me. We must not forget that democracy is the core of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your perspective, but I believe we need to balance strength with compassion to truly honor the spirit of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Remus Holstron**
> ""Compassion won't help when the country descends into chaos. Only a firm hand with an unyielding grip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[210]`
Mówca: **Remus Holstron**
> ""I hope so. That weakling Alphonso knew nothing about the true nature of leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[211]`
Mówca: **Remus Holstron**
> ""I beg to differ. Democracy isn't the core of our nation, Mr. President. It's something we copied from our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Remus Holstron**
> ""I'm all for new ideals, as long as we don't stray too far from the principles that have defined us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[213]`
Mówca: **Remus Holstron**
> ""Either way, it looks like both of us have a busy term ahead of us. I've got a series of bills I'm working on to address the friction in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[214]`
Mówca: **Remus Holstron**
> ""Whether in 1866 or 1928, one thing rings true. Without order, there is chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[215]`
Mówca: **Remus Holstron**
> ""I heard about your promise to tighten Sordland's immigration laws, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[216]`
Mówca: **Remus Holstron**
> ""We can't let our culture and identity become diluted. Sordland for Sords, as they say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[222]`
  - -> `[221]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your support. Together, we will ensure the preservation of our Sordish identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The tightening of laws should be aimed at preserving our nation's harmony, not fostering division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, our immigration is sorely in need of regulation. But we must remember our values of unity and compassion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I disagree. Diversity fosters richness in culture and ideas. Immigration will only strengthen Sordish identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Holstron, our nation has always thrived by accepting others. We can't shy away from that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I did not want to change too much too quickly. But I do agree with you. I'm looking to tighten those laws in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[223]`
Mówca: **Remus Holstron**
> ""Speaking of which, I heard you're sticking with Alphonso's lax immigration laws? Surely that's not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[224]`
Mówca: **Remus Holstron**
> ""I'm glad you're as concerned about preserving our nation's identity as I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[219]`
  - -> `[218]`

### Węzeł `[225]`
Mówca: **Remus Holstron**
> ""But tonight's a celebration, right? Time to show all the establishment politicians in the Palace how a real patriot lets loose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, let's put aside politics for tonight. Enjoy the evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I fully intend to do so. Thanks for the kind words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have a lot of work to do, Mr. Holstron. I look forward to seeing your proposals. Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
Mówca: **Narrator**
> "A mirror to the nationalism still stirring within Sordland, he offered a potent reminder of the complexities and divisions that we would need to navigate in the days to come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[230]`
Mówca: **Narrator**
> "As Remus Holstron disappeared back into the crowd, his parting words resonated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[231]`
Mówca: **Remus Holstron**
> ""We'll speak soon. And remember, never lose sight of the iron cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[232]`
Mówca: **Remus Holstron**
> ""Looking forward to it, Mr. President. Remember: One Sordland, One Nation, One Future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[233]`
Mówca: **Remus Holstron**
> ""Remember, Mr. President: One Sordland, One Nation, One Future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[234]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_4", "Legislative_MansounLeke");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_4","Legislative_MansounLeke");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My days in the Young Sords are long behind me now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Remus Holstron**
> ""Once a Young Sord, always a Young Sord. That's how I feel, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's been a long time, Comrade Circas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Bernard Circas**
> ""It has, President Rayne. But once a Red Youth, always a Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[239]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[240]`
Mówca: **Narrator**
> "He leveled a steel gaze at me, then broke into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
