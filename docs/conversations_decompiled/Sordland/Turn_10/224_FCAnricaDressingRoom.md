# Sordland/Turn10/FCAnricaDressingRoom

- **ID konwersacji:** `224`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/224_FCAnricaDressingRoom.md`
- **Liczba węzłów dialogowych:** 61
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGameIsolated.FCAnricaTeamSpeech_Stress`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGameIsolated.FCAnricaTeamSpeech_Stress`
- `BaseGameIsolated.FCAnrica_Wins`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[219]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 16

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[14]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[19]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[20]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[24]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[25]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- Węzeł `[30]` (Paskal Beniwoll): `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamS...`
- *...oraz 8 innych węzłów ze skryptami.*

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `222` (*Sordland/Turn10/Personal_FCAnricaDerby*), Węzeł `[219]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I pushed open the door and stepped into the bustling locker room. The players, clad in their FC Anrica jerseys, all stopped what they were doing and turned their heads to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The team's new manager, Iorgel Gloper, immediately came and shook my hand. He seemed to be under a large amount of stress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He introduced me to the players and invited me to give a short motivational speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good day to all of you, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""FC Anrica! Your president stands together with you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hello, everybody. I hope you are ready for the match of the decade!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's great to be here today among all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "A hush fell over the room as the players leaned forward, eagerly awaiting my words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`
  - -> `[13]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Today, we stand united on this hallowed ground, representing our nation, our flag, and the hopes of millions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[16]`
  - -> `[18]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Today, you have one purpose. You are here to win, to show the world the Sordish spirit. And I know that you will succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want you to know that millions are proud of you for reaching this stage in the Merkopan Cup. Regardless of the results, your achievements so far will not be forgotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[16]`
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[16]`
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This match is more than a game. It's an opportunity to showcase the strength, resilience, and spirit of both FC Anrica and the country of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Every pass, every tackle, every goal must be executed with the utmost precision, for the eyes of the world and the Sordish people are upon us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This match is a celebration, an opportunity to showcase the true essence of your craft. Let's take a moment to breathe in the electric atmosphere, to soak in the vibrant energy that surrounds you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`
  - -> `[21]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have inspired millions of Sordish men and women. Their hopes and dreams rest on what happens in the next 90 minutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must push ourselves beyond our limits, embracing discomfort and adversity as catalysts for our growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As you step onto that field, let go of any lingering doubts and embrace the sheer joy that comes with playing the game you love dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to see any regrets after the match. You've got to leave everything out there on the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Failure is not an option, for it will reverberate through the annals of history. I implore you to dig deep within your souls, find that reservoir of untapped determination, and channel it into every fiber of your being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Remember, it's not just about the outcome, but the memories we create and the smiles we bring to the faces of our fans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are an extraordinary team. The best in Sordland. Maybe even the best in Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The weight of this moment may feel overwhelming, but it is in the crucible of pressure that true champions are forged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""When the final whistle blows, we want to look back and know that we gave it our all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The match today will not be easy. But neither was the path that led to it. I am proud of each and every one of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now, go forth, my fellow Anrican warriors, and leave an indelible mark on this game! I have the utmost faith in your success!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now take a moment to relax. And don't forget -- win or lose, Sordland is proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Long live the Republic and long live Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGameIsolated.FCAnricaTeamSpeech_Stress >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGameIsolated.FCAnricaTeamSpeech_Stress >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] <= 5  and  Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGameIsolated.FCAnricaTeamSpeech_Stress >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] <= 5  and  Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All together now. Eye to eye, tooth to tooth! FC Anrica!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just know this... If you fail at this stage, you'll be proving me wrong. Nobody wants that. Are we clear, gentlemen? Are you ready to win?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Narrator**
> "The players exchanged puzzled looks for a few seconds before they broke into loud applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Narrator**
> "All of them stood up and yelled "Champion FC Anrica!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[53]`
Mówca: **Narrator**
> "The players exchanged nervous glances. Their captain gestured at them, and they burst into loud applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Most of the team shouted back the phrase: "Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "I cast my eyes over the team. The Sordish players were grinning, but others seemed unconvinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.FCAnrica_Wins = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.FCAnrica_Wins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Just then, the legendary Sordish defender, Captain Bruno Korkmer, came up to me and explained that he and his family had voted for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "He then introduced me to the two newest transfers to the team, already considered the star duo of FC Anrica -- the Neqisi midfielder Hsuen Xoqr and the Nibiyan striker Leon al-Ogwaldo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "They both shook my hand and greeted me in broken Sordish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Right after that, the manager signalled to the players that the match was about to begin. The security staff ushered me back towards the lounge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
