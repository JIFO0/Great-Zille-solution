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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Good day to all of you, gentlemen.""** | `[5]` **Narrator**: "He introduced me to the players ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "A hush fell over the room as the..." |
| `[7]` | **""FC Anrica! Your president stands together with you today.""** | `[5]` **Narrator**: "He introduced me to the players ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "A hush fell over the room as the..." |
| `[8]` | **""Hello, everybody. I hope you are ready for the match of the decade!""** | `[5]` **Narrator**: "He introduced me to the players ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "A hush fell over the room as the..." |
| `[9]` | **""It's great to be here today among all of you.""** | `[5]` **Narrator**: "He introduced me to the players ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "A hush fell over the room as the..." |
| `[11]` | **""Today, we stand united on this hallowed ground, representing our nation, our flag..."** | `[10]` **Narrator**: "A hush fell over the room as the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Player**: ""Every pass, every tackle, every..."<br>`[16]` **Player**: ""This match is more than a game...."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **""Today, you have one purpose. You are here to win, to show the world the Sordish s..."** | `[10]` **Narrator**: "A hush fell over the room as the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[17]` **Player**: ""Every pass, every tackle, every..."<br>`[16]` **Player**: ""This match is more than a game...."<br>*(oraz 1 innych odgałęzień)* |
| `[13]` | **""I want you to know that millions are proud of you for reaching this stage in the ..."** | `[10]` **Narrator**: "A hush fell over the room as the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[17]` **Player**: ""Every pass, every tackle, every..."<br>`[16]` **Player**: ""This match is more than a game...."<br>*(oraz 1 innych odgałęzień)* |
| `[16]` | **""This match is more than a game. It's an opportunity to showcase the strength, res..."** | `[11]` **Player**: ""Today, we stand united on this ..."<br>`[12]` **Player**: ""Today, you have one purpose. Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[23]` **Player**: ""As you step onto that field, le..."<br>`[22]` **Player**: ""We must push ourselves beyond o..."<br>*(oraz 1 innych odgałęzień)* |
| `[17]` | **""Every pass, every tackle, every goal must be executed with the utmost precision, ..."** | `[11]` **Player**: ""Today, we stand united on this ..."<br>`[12]` **Player**: ""Today, you have one purpose. Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[23]` **Player**: ""As you step onto that field, le..."<br>`[22]` **Player**: ""We must push ourselves beyond o..."<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **""This match is a celebration, an opportunity to showcase the true essence of your ..."** | `[11]` **Player**: ""Today, we stand united on this ..."<br>`[12]` **Player**: ""Today, you have one purpose. Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: ""As you step onto that field, le..."<br>`[22]` **Player**: ""We must push ourselves beyond o..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **""You have inspired millions of Sordish men and women. Their hopes and dreams rest ..."** | `[18]` **Player**: ""This match is a celebration, an..."<br>`[17]` **Player**: ""Every pass, every tackle, every..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[27]` **Player**: ""I don't want to see any regrets..."<br>`[28]` **Player**: ""Failure is not an option, for i..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **""We must push ourselves beyond our limits, embracing discomfort and adversity as c..."** | `[18]` **Player**: ""This match is a celebration, an..."<br>`[17]` **Player**: ""Every pass, every tackle, every..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[27]` **Player**: ""I don't want to see any regrets..."<br>`[28]` **Player**: ""Failure is not an option, for i..."<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **""As you step onto that field, let go of any lingering doubts and embrace the sheer..."** | `[18]` **Player**: ""This match is a celebration, an..."<br>`[17]` **Player**: ""Every pass, every tackle, every..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[27]` **Player**: ""I don't want to see any regrets..."<br>`[28]` **Player**: ""Failure is not an option, for i..."<br>*(oraz 1 innych odgałęzień)* |
| `[27]` | **""I don't want to see any regrets after the match. You've got to leave everything o..."** | `[23]` **Player**: ""As you step onto that field, le..."<br>`[22]` **Player**: ""We must push ourselves beyond o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[33]` **Player**: ""You are an extraordinary team. ..."<br>`[34]` **Player**: ""The weight of this moment may f..."<br>*(oraz 1 innych odgałęzień)* |
| `[28]` | **""Failure is not an option, for it will reverberate through the annals of history. ..."** | `[23]` **Player**: ""As you step onto that field, le..."<br>`[22]` **Player**: ""We must push ourselves beyond o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[33]` **Player**: ""You are an extraordinary team. ..."<br>`[34]` **Player**: ""The weight of this moment may f..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **""Remember, it's not just about the outcome, but the memories we create and the smi..."** | `[23]` **Player**: ""As you step onto that field, le..."<br>`[22]` **Player**: ""We must push ourselves beyond o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[33]` **Player**: ""You are an extraordinary team. ..."<br>`[34]` **Player**: ""The weight of this moment may f..."<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **""You are an extraordinary team. The best in Sordland. Maybe even the best in Merko..."** | `[29]` **Player**: ""Remember, it's not just about t..."<br>`[28]` **Player**: ""Failure is not an option, for i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: ""The match today will not be eas..."<br>`[38]` **Player**: ""Now, go forth, my fellow Anrica..."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **""The weight of this moment may feel overwhelming, but it is in the crucible of pre..."** | `[29]` **Player**: ""Remember, it's not just about t..."<br>`[28]` **Player**: ""Failure is not an option, for i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[37]` **Player**: ""The match today will not be eas..."<br>`[38]` **Player**: ""Now, go forth, my fellow Anrica..."<br>*(oraz 1 innych odgałęzień)* |
| `[35]` | **""When the final whistle blows, we want to look back and know that we gave it our a..."** | `[29]` **Player**: ""Remember, it's not just about t..."<br>`[28]` **Player**: ""Failure is not an option, for i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: ""The match today will not be eas..."<br>`[38]` **Player**: ""Now, go forth, my fellow Anrica..."<br>*(oraz 1 innych odgałęzień)* |
| `[37]` | **""The match today will not be easy. But neither was the path that led to it. I am p..."** | `[33]` **Player**: ""You are an extraordinary team. ..."<br>`[35]` **Player**: ""When the final whistle blows, w..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: ""Long live the Republic and long..."<br>`[46]` **Player**: ""All together now. Eye to eye, t..."<br>*(oraz 2 innych odgałęzień)* |
| `[38]` | **""Now, go forth, my fellow Anrican warriors, and leave an indelible mark on this ga..."** | `[33]` **Player**: ""You are an extraordinary team. ..."<br>`[35]` **Player**: ""When the final whistle blows, w..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[42]` **Player**: ""Long live the Republic and long..."<br>`[46]` **Player**: ""All together now. Eye to eye, t..."<br>*(oraz 2 innych odgałęzień)* |
| `[39]` | **""Now take a moment to relax. And don't forget -- win or lose, Sordland is proud of..."** | `[33]` **Player**: ""You are an extraordinary team. ..."<br>`[35]` **Player**: ""When the final whistle blows, w..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[42]` **Player**: ""Long live the Republic and long..."<br>`[46]` **Player**: ""All together now. Eye to eye, t..."<br>*(oraz 2 innych odgałęzień)* |
| `[42]` | **""Long live the Republic and long live Sordland!""** | `[37]` **Player**: ""The match today will not be eas..."<br>`[39]` **Player**: ""Now take a moment to relax. And..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The players exchanged puzzled lo..." |
| `[46]` | **""All together now. Eye to eye, tooth to tooth! FC Anrica!""** | `[37]` **Player**: ""The match today will not be eas..."<br>`[39]` **Player**: ""Now take a moment to relax. And..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "All of them stood up and yelled ..." |
| `[47]` | **""Just know this... If you fail at this stage, you'll be proving me wrong. Nobody w..."** | `[37]` **Player**: ""The match today will not be eas..."<br>`[39]` **Player**: ""Now take a moment to relax. And..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = ...` | `[53]` **Narrator**: "The players exchanged nervous gl..." |
| `[48]` | **""A Morgna wes core!""** | `[37]` **Player**: ""The match today will not be eas..."<br>`[39]` **Player**: ""Now take a moment to relax. And..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[54]` **Narrator**: "Most of the team shouted back th..." |

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
  - -> `[3]` (*Narrator: "I pushed open the door and stepped into the bustling lock..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I pushed open the door and stepped into the bustling locker room. The players, clad in their FC Anrica jerseys, all stopped what they were doing and turned their heads to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The team's new manager, Iorgel Gloper, immediately came a..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The team's new manager, Iorgel Gloper, immediately came and shook my hand. He seemed to be under a large amount of stress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He introduced me to the players and invited me to give a ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He introduced me to the players and invited me to give a short motivational speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""Good day to all of you, gentlemen.""*)
  - -> `[7]` (*Player: ""FC Anrica! Your president stands together with you today.""*)
  - -> `[8]` (*Player: ""Hello, everybody. I hope you are ready for the match of ..."*)
  - -> `[9]` (*Player: ""It's great to be here today among all of you.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good day to all of you, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A hush fell over the room as the players leaned forward, ..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""FC Anrica! Your president stands together with you today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A hush fell over the room as the players leaned forward, ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hello, everybody. I hope you are ready for the match of the decade!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A hush fell over the room as the players leaned forward, ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's great to be here today among all of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A hush fell over the room as the players leaned forward, ..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "A hush fell over the room as the players leaned forward, eagerly awaiting my words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: ""Today, we stand united on this hallowed ground, represen..."*)
  - -> `[12]` (*Player: ""Today, you have one purpose. You are here to win, to sho..."*)
  - -> `[13]` (*Player: ""I want you to know that millions are proud of you for re..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Today, we stand united on this hallowed ground, representing our nation, our flag, and the hopes of millions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""Every pass, every tackle, every goal must be executed wi..."*)
  - -> `[16]` (*Player: ""This match is more than a game. It's an opportunity to s..."*)
  - -> `[18]` (*Player: ""This match is a celebration, an opportunity to showcase ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Today, you have one purpose. You are here to win, to show the world the Sordish spirit. And I know that you will succeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want you to know that millions are proud of you for reaching this stage in the Merkopan Cup. Regardless of the results, your achievements so far will not be forgotten.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""Every pass, every tackle, every goal must be executed wi..."*)
  - -> `[16]` (*Player: ""This match is more than a game. It's an opportunity to s..."*)
  - -> `[18]` (*Player: ""This match is a celebration, an opportunity to showcase ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""Every pass, every tackle, every goal must be executed wi..."*)
  - -> `[16]` (*Player: ""This match is more than a game. It's an opportunity to s..."*)
  - -> `[18]` (*Player: ""This match is a celebration, an opportunity to showcase ..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This match is more than a game. It's an opportunity to showcase the strength, resilience, and spirit of both FC Anrica and the country of Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Player), `[12]` (Player), `[13]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Every pass, every tackle, every goal must be executed with the utmost precision, for the eyes of the world and the Sordish people are upon us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Player), `[12]` (Player), `[13]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2"*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This match is a celebration, an opportunity to showcase the true essence of your craft. Let's take a moment to breathe in the electric atmosphere, to soak in the vibrant energy that surrounds you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Player), `[12]` (Player), `[13]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""As you step onto that field, let go of any lingering dou..."*)
  - -> `[22]` (*Player: ""We must push ourselves beyond our limits, embracing disc..."*)
  - -> `[21]` (*Player: ""You have inspired millions of Sordish men and women. The..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""As you step onto that field, let go of any lingering dou..."*)
  - -> `[22]` (*Player: ""We must push ourselves beyond our limits, embracing disc..."*)
  - -> `[21]` (*Player: ""You have inspired millions of Sordish men and women. The..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""As you step onto that field, let go of any lingering dou..."*)
  - -> `[22]` (*Player: ""We must push ourselves beyond our limits, embracing disc..."*)
  - -> `[21]` (*Player: ""You have inspired millions of Sordish men and women. The..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have inspired millions of Sordish men and women. Their hopes and dreams rest on what happens in the next 90 minutes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[17]` (Player), `[16]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must push ourselves beyond our limits, embracing discomfort and adversity as catalysts for our growth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[17]` (Player), `[16]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As you step onto that field, let go of any lingering doubts and embrace the sheer joy that comes with playing the game you love dearly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[17]` (Player), `[16]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""I don't want to see any regrets after the match. You've ..."*)
  - -> `[28]` (*Player: ""Failure is not an option, for it will reverberate throug..."*)
  - -> `[29]` (*Player: ""Remember, it's not just about the outcome, but the memor..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""I don't want to see any regrets after the match. You've ..."*)
  - -> `[28]` (*Player: ""Failure is not an option, for it will reverberate throug..."*)
  - -> `[29]` (*Player: ""Remember, it's not just about the outcome, but the memor..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""I don't want to see any regrets after the match. You've ..."*)
  - -> `[28]` (*Player: ""Failure is not an option, for it will reverberate throug..."*)
  - -> `[29]` (*Player: ""Remember, it's not just about the outcome, but the memor..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to see any regrets after the match. You've got to leave everything out there on the field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[22]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Failure is not an option, for it will reverberate through the annals of history. I implore you to dig deep within your souls, find that reservoir of untapped determination, and channel it into every fiber of your being.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[22]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2"*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Remember, it's not just about the outcome, but the memories we create and the smiles we bring to the faces of our fans.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[22]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""You are an extraordinary team. The best in Sordland. May..."*)
  - -> `[34]` (*Player: ""The weight of this moment may feel overwhelming, but it ..."*)
  - -> `[35]` (*Player: ""When the final whistle blows, we want to look back and k..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""You are an extraordinary team. The best in Sordland. May..."*)
  - -> `[34]` (*Player: ""The weight of this moment may feel overwhelming, but it ..."*)
  - -> `[35]` (*Player: ""When the final whistle blows, we want to look back and k..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""You are an extraordinary team. The best in Sordland. May..."*)
  - -> `[34]` (*Player: ""The weight of this moment may feel overwhelming, but it ..."*)
  - -> `[35]` (*Player: ""When the final whistle blows, we want to look back and k..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are an extraordinary team. The best in Sordland. Maybe even the best in Merkopa.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[28]` (Player), `[27]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""The match today will not be easy. But neither was the pa..."*)
  - -> `[38]` (*Player: ""Now, go forth, my fellow Anrican warriors, and leave an ..."*)
  - -> `[39]` (*Player: ""Now take a moment to relax. And don't forget -- win or l..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The weight of this moment may feel overwhelming, but it is in the crucible of pressure that true champions are forged.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[28]` (Player), `[27]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""When the final whistle blows, we want to look back and know that we gave it our all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[28]` (Player), `[27]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""The match today will not be easy. But neither was the pa..."*)
  - -> `[38]` (*Player: ""Now, go forth, my fellow Anrican warriors, and leave an ..."*)
  - -> `[39]` (*Player: ""Now take a moment to relax. And don't forget -- win or l..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""The match today will not be easy. But neither was the pa..."*)
  - -> `[38]` (*Player: ""Now, go forth, my fellow Anrican warriors, and leave an ..."*)
  - -> `[39]` (*Player: ""Now take a moment to relax. And don't forget -- win or l..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The match today will not be easy. But neither was the path that led to it. I am proud of each and every one of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player), `[35]` (Player), `[34]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Long live the Republic and long live Sordland!""*)
  - -> `[46]` (*Player: ""All together now. Eye to eye, tooth to tooth! FC Anrica!""*)
  - -> `[47]` (*Player: ""Just know this... If you fail at this stage, you'll be p..."*)
  - -> `[48]` (*Player: ""A Morgna wes core!""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now, go forth, my fellow Anrican warriors, and leave an indelible mark on this game! I have the utmost faith in your success!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player), `[35]` (Player), `[34]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now take a moment to relax. And don't forget -- win or lose, Sordland is proud of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player), `[35]` (Player), `[34]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 2"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Long live the Republic and long live Sordland!""*)
  - -> `[46]` (*Player: ""All together now. Eye to eye, tooth to tooth! FC Anrica!""*)
  - -> `[47]` (*Player: ""Just know this... If you fail at this stage, you'll be p..."*)
  - -> `[48]` (*Player: ""A Morgna wes core!""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Long live the Republic and long live Sordland!""*)
  - -> `[46]` (*Player: ""All together now. Eye to eye, tooth to tooth! FC Anrica!""*)
  - -> `[47]` (*Player: ""Just know this... If you fail at this stage, you'll be p..."*)
  - -> `[48]` (*Player: ""A Morgna wes core!""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Long live the Republic and long live Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[39]` (Player), `[38]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The players exchanged puzzled looks for a few seconds bef..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGameIsolated.FCAnricaTeamSpeech_Stress >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGa..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && Base..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGameIsolated.FCAnricaTeamSpeech_Stress >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] <= 5  and  Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnrica_Wins = true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGameIsolated.FCAnricaTeamSpeech_Stress >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] <= 5  and  Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Just then, the legendary Sordish defender, Captain Bruno ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All together now. Eye to eye, tooth to tooth! FC Anrica!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[39]` (Player), `[38]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "All of them stood up and yelled "Champion FC Anrica!""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just know this... If you fail at this stage, you'll be proving me wrong. Nobody wants that. Are we clear, gentlemen? Are you ready to win?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[39]` (Player), `[38]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[39]` (Player), `[38]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Most of the team shouted back the phrase: "Vectern sis da!""*)

### Węzeł `[50]`
Mówca: **Narrator**
> "The players exchanged puzzled looks for a few seconds before they broke into loud applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I cast my eyes over the team. The Sordish players were gr..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnricaTeamSpeech_Stress += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] = Variable["BaseGameIsolated.FCAnricaTeamSpeech_Stress"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The players exchanged nervous glances. Their captain gest..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "All of them stood up and yelled "Champion FC Anrica!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGa..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "The players exchanged nervous glances. Their captain gestured at them, and they burst into loud applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGa..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Most of the team shouted back the phrase: "Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I cast my eyes over the team. The Sordish players were gr..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "I cast my eyes over the team. The Sordish players were grinning, but others seemed unconvinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.FCAnricaTeamSpeech_Stress <= 5 && BaseGa..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.FCAnrica_Wins = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.FCAnrica_Wins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Just then, the legendary Sordish defender, Captain Bruno ..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Just then, the legendary Sordish defender, Captain Bruno Korkmer, came up to me and explained that he and his family had voted for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "He then introduced me to the two newest transfers to the ..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "He then introduced me to the two newest transfers to the team, already considered the star duo of FC Anrica -- the Neqisi midfielder Hsuen Xoqr and the Nibiyan striker Leon al-Ogwaldo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "They both shook my hand and greeted me in broken Sordish."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "They both shook my hand and greeted me in broken Sordish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Right after that, the manager signalled to the players th..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Right after that, the manager signalled to the players that the match was about to begin. The security staff ushered me back towards the lounge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
