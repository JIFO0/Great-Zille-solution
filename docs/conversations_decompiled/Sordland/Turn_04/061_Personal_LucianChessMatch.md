# Sordland/Turn04/Personal_LucianChessMatch

- **ID konwersacji:** `61`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/061_Personal_LucianChessMatch.md`
- **Liczba węzłów dialogowych:** 339
- **Liczba wyborów gracza:** 125

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Lucian_GaladeDrawMatch`
- `BaseGame.Relations_Lucian_GaladeWonMatch`
- `BaseGameIsolated.Turn04_Personal_ChessPickBlack`
- `BaseGameIsolated.Turn04_Personal_ChessScore`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Lucian_GaladeDrawMatch`
- `BaseGame.Relations_Lucian_GaladeLostMatch`
- `BaseGame.Relations_Lucian_GaladeWonMatch`
- `BaseGameIsolated.Turn04_Personal_ChessPickBlack`
- `BaseGameIsolated.Turn04_Personal_ChessScore`
- `BaseGameSupport.Journal_Turn04_LucianChess_Draw`
- `BaseGameSupport.Journal_Turn04_LucianChess_Lose`
- `BaseGameSupport.Journal_Turn04_LucianChess_Won`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 18

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Lucian_GaladeDrawMatch`
- `BaseGame.Relations_Lucian_GaladeLostMatch`
- `BaseGame.Relations_Lucian_GaladeWonMatch`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Paskal Beniwoll): `AddConversant("Livia Suno");`
- Węzeł `[10]` (Paskal Beniwoll): `RemoveConversant("Lucian Galade");`
- Węzeł `[42]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] = true;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Perso...`
- Węzeł `[101]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Perso...`
- Węzeł `[112]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Perso...`
- Węzeł `[113]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Perso...`
- Węzeł `[210]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Perso...`
- *...oraz 10 innych węzłów ze skryptami.*

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
  - -> `[335]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Evening descended on the capital as Lucian and I found ourselves alone in my office. I followed my chief strategist's eyes to the chessboard on the coffee table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The sight of it reminded me of simpler times, of late-night strategy sessions turning into chess matches. We used to escape the political chaos into a world of rooks and bishops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Our battles were both tense and friendly, a reflection of our long history together. Lucian had always proved a challenging opponent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "His strategies, both on the chessboard and in politics, had the same unpredictable edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "A soft knock interrupted my reminiscing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Livia Suno**
> ""Long nights of strategy planning, and now a game of chess. You two never stop thinking, do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Livia Suno");)*
- **Efekt (`userScript`):** `AddConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucian Galade");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Livia came in with our usual coffee. She noticed the chessboard and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""I hope you remember that it's not always the king who holds the power. Sometimes, a well-placed pawn can change the game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Livia, always a pleasure. Even more so when you bring coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We might have to order dinner if this game takes as long as the ones we used to play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's your opinion on chess, Livia? Ever been tempted to learn?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Livia Suno**
> ""It's my job to keep the gears of this office turning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Livia Suno**
> ""I'll keep the Maroon Palace chef on speed dial then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Livia Suno**
> ""I prefer whist, Mr. President. I'll leave the complex plotting to the professionals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "She turned and left the room. Lucian acknowledged her exit with a slight nod, his eyes still fixed on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[20]`
Mówca: **Livia Suno**
> ""Have a good game, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't that the truth? I've used pawns for some of my best plays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Neither of them hold any real power, Lucian. It's the player who controls them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The power dynamics of a chess board can teach us a lot about politics, wouldn't you agree, Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""On the other hand, sir, even the most strategic pawn move won't help if you overlook the other pieces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""Of course, sir. But a wise player recognizes the value of every piece on the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""Absolutely. And playing chess with politicians will tell you more about their goals and plans than any speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Narrator**
> "His dexterous maneuvering reflected the unseen orchestration that helped Petr and me ascend through the ranks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Narrator**
> "As Lucian positioned the pieces on the chessboard, it stirred memories of our early days in the United Sordland Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[29]`
Mówca: **Narrator**
> "As the final piece was set into position, the board transformed into a silent battlefield."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Shall we get this game underway, Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough reminiscing. Let's start, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""Indeed, President Rayne. A game of chess is exactly what we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""Ah, the impatience of a president. Very well, let's begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""Which color do you prefer? Black as usual or white this time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Black for me. I like the advantage of reacting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Doesn't matter to me, Lucian. I can play either side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll take white. The honor of the first move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""A fine choice, befitting of your drive to lead. The first move is yours, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""A strategist's choice. I'm not surprised. The board is yours to react to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
> ""If it doesn't matter, allow me the honor of the first move. I'll take white.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[41]`
Mówca: **Narrator**
> "With the sides chosen, Lucian sat back, his fingers laced together in contemplation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessPickBlack = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[43]`
Mówca: **Narrator**
> "And thus the game began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessPickBlack == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessPickBlack == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_Personal_ChessPickBlack == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I always enjoy a good challenge, Lucian. The Xinan should keep us both on our toes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, Lucian, they do say the Xinan Defense is the best form of attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought I'd mix things up a bit, Lucian. Let's see how well you handle the Xinan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Reti? Let's throw in a bit of spice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's not always about the center, is it?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting start, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President. I look forward to seeing your next moves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""It's a dance of strategy, Mr. Rayne. Let's hope we both brought our dancing shoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""That they do, Mr. President. Let's see if it holds true for us today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[56]`
Mówca: **Narrator**
> "And thus the game began. The opening decision was mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Lucian moved his knight from g1 to f3. Aiming for a Reti Opening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Control the Center."]** — Mówca: **Player_Italic**
> "In response to Lucian's attempt at the Reti Opening, I advanced my pawn from d7 to d5, aiming to strengthen my grip on the center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "March of the Knight."]** — Mówca: **Player_Italic**
> "Countering Lucian's knight, I maneuvered my knight from g8 to f6, eyeing the center and setting up defenses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeWonMatch == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeWonMatch == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_GaladeWonMatch == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""Ah, symmetry. An art form in itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""A solid move, Mr. Rayne. Maintaining control of the center is often key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Lucian's next move was calculated and swift. The bishop glided from f1 to g2, preparing for a potential kingside castle and fortifying the pawn structure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[69]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Lucian's response came in the form of a g2 to g3 pawn move, hinting at the decision to fianchetto his bishop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[72]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's still early to hide behind defenses, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your bishop is on the move, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Opting for a solid defense, Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An unconventional approach. I'm curious to see where this leads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A fianchetto setup, interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're setting up your bishop, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Every castle needs its walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""One can never be too careful in the game of kings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Every piece has its role to play, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""One must develop their minor pieces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Life is full of surprises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""You know what they say about variety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "The Xinan Defense."]** — Mówca: **Player_Italic**
> "I started with e4, Lucian replied with c5. I was initiating the Xinan Defense, aiming for a dynamic and asymmetrical position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "The King's Gambit."]** — Mówca: **Player_Italic**
> "I moved my pawn to e4 and Lucian responded with e5. Then, I boldly advanced my f-pawn, signifying the King's Gambit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""Ah, the Xinan. A bold choice, Mr. Rayne. This should be an interesting match.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""The King's Gambit, Mr. Rayne? A daring opening. It promises an exciting game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Risk is part of the game, Lucian. Let's see if it pays off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The King's Gambit always guarantees an engaging game, Lucian. I'm looking forward to your response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A little daring keeps the game interesting, Lucian. Let's see how you manage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Agreed, Mr. President. I'm eager to navigate the labyrinth you're constructing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. Rayne. May the best player prevail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""So am I, Mr. President. Your move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[89]`
Mówca: **Narrator**
> "With this, the stage was set. The opening maneuvers had transformed into a mid-game battle of wits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Each pawn push, every subtle repositioning, had been showing to Lucian's strategic prowess and my resilience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "The next move would prove crucial. Lucian's queen cut a path through the heart of the board, menacing my vulnerable kingside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[92]`
Mówca: **Narrator**
> "As Lucian departed, I thought about what he'd told me. I'd learned a thing or two, but the man was more of a mystery than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "Unleash the Rook."]** — Mówca: **Player_Italic**
> "With a bold stride, I advanced my pawn, ripping open the f-file. The next move took a knight from Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""A sacrifice indeed, but one I'm willing to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That knight of yours... a daring sacrifice, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your knight is mine, Lucian. A worthy sacrifice on your part, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A bold decision, leaving your knight in such a precarious position, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[98]`
Mówca: **Narrator**
> "The stakes were sky-high. A bold pawn advance could release my rook's potential and threaten Lucian's knight. On the other hand, I could gamble with a Rummish Gambit, a risky play that could wrestle control of the center away from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[99]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "Attempt a Rummish Gambit."]** — Mówca: **Player_Italic**
> "I attempted a Rummish Gambit. I decided to risk a critical pawn, hoping to gain an advantage in the middle game."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[97]`
  - -> `[95]`
  - -> `[96]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""The high stakes and strategical intricacies of this game remind me of the trials I endured early in my career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""A daring maneuver under fiery pressure. You're an adept tactician but this is far from over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Lucian moved his rook from the corner, adding pressure on my exposed bishop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Ah, the Rummish Gambit. Pushing down the center. Bold, but risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[108]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Boldness can lead to victory, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes, one must gamble to win, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Risk often comes with rewards, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "He calmly slid his queen across the board, threatening my isolated pawn. His subtle smirk revealed he understood my gambit and was ready to counter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "Initiate Rizian Fork."]** — Mówca: **Player_Italic**
> "I maneuvered my knight expertly, landing it on a square that posed a double threat to Lucian's king and rook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "Fortify Bishop's Stand."]** — Mówca: **Player_Italic**
> "I shifted my rook, bringing it to stand beside the embattled bishop. The strong defensive formation would deter any of Lucian's advances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Only through fire do we learn the nature of the material.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't that what makes the game exciting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Lucian was in high spirits, his eyes gleaming with a rare look of contentment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[117]`
Mówca: **Narrator**
> "Lucian maintained a steady gaze, his face unreadable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""Your defenses are commendable. But you are giving me too much space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Lucian, undeterred by my fortress, slid his queen to a more advantageous square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[123]`
  - -> `[122]`
  - -> `[216]`

### Węzeł `[120]`
Mówca: **Narrator**
> "In response to my knight's threat, Lucian moved out the threat, creating a barrier between my knight and his king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[121]`
  - -> `[115]`
  - -> `[114]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fire is the test of gold, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Space is but a canvas, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes, we must give to take.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All the more room for your downfall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "Reinforce the King."]** — Mówca: **Player_Italic**
> "I decided to consolidate my defenses, bringing my rook in to guard my king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "Decoy the Queen."]** — Mówca: **Player_Italic**
> "I boldly moved my queen, placing it in a position that exposed Lucian's king to a potential checkmate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[127]`
Mówca: **Narrator**
> "The center was congested, a show of Lucian's unyielding style. His formation was formidable, his pieces interlocked in a matrix of support, each protecting the other while simultaneously projecting threats across the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "It was my move and the game had entered its final stages. Lucian's queen was uncomfortably close, radiating danger. I had only a few paths before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_Personal_ChessScore == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore == 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore == 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_Personal_ChessScore == 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "All or Nothing."]** — Mówca: **Player_Italic**
> "I decided to take a bold risk, hoping for a sudden twist in the game's conclusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "Offer Perpetual Check."]** — Mówca: **Player_Italic**
> "I positioned my queen to offer a perpetual check, potentially forcing a draw by repetition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "Defensive Shell."]** — Mówca: **Player_Italic**
> "I moved my pieces into a defensive formation, aiming to stave off Lucian's imminent attack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "Knight Sacrifice."]** — Mówca: **Player_Italic**
> "I decided to sacrifice my knight, hoping that the unexpected move would throw Lucian off balance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> ""A daring choice, President. It seems the end is near.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Lucian's king stood vulnerable, but a risky move could leave my own king exposed. However, seizing the opportunity seemed worth the risk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[125]`

### Węzeł `[141]`
Mówca: **Narrator**
> "The game was on a knife's edge, the outcome far from certain. The board offered a potential for a draw if I played conservatively or an opportunity for a hail mary win if I dared to go all in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[135]`

### Węzeł `[142]`
Mówca: **Narrator**
> "The game was slipping from my grasp. I had two options - a risky knight sacrifice that could lead to a swift end, or to hunker down and hope for a draw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[137]`

### Węzeł `[143]`
Mówca: **Narrator**
> "If Lucian overlooked the threat I posed, victory would be mine. If he identified the trap, the game could stretch on, but the advantage would be mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
> ""A cautious play, sir. You are forcing us into a drawn endgame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "If Lucian tried to attack aggressively now, the fortress I'd built around my king would be my saving grace, leading to a draw. If he chose to fortify his position as well, a drawn endgame would be inevitable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""A bold sacrifice. Let's see how this plays out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Narrator**
> "If Lucian fell into the trap, I might manage to draw. If he saw through it, my loss was imminent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
> ""You're on the defensive. The endgame is mine to command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Narrator**
> "If Lucian made a mistake now, I could potentially salvage a draw. However, if he played his cards right, defeat was the only outcome I could see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""Ah, looking for a draw, Mr. President? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "If Lucian fell into the repetition pattern, a draw would be secured. If he managed to evade and counter, the game could still be saved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Taking a gamble, are we, President Rayne? Let's see where this leads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Narrator**
> "If Lucian fell for my bold play, a miraculous victory might be snatched from the jaws of defeat. However, if he played cautiously, my loss would be inevitable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
> ""Well played. But it's not over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Despite Lucian's attempt to wriggle out, his king was trapped. My queen delivered the final blow, spelling a checkmate. The game was over, and I had won."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[173]`
  - -> `[172]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""Safety first. Your move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Narrator**
> "With both of us refusing to risk our positions, the game ended in a stalemate. Neither side had managed to achieve victory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[176]`
  - -> `[175]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Lucian, caught in my trap, tried to navigate his king out of the danger zone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Lucian, sensing my defensive play, bolstered his own defenses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""You're not the only one who can play this game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Narrator**
> "The checks continued, neither of us giving ground. With the position repeating three times, the game was declared a draw due to the threefold repetition rule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[185]`
  - -> `[184]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
> ""I see your gamble, and I raise you a castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
Mówca: **Narrator**
> "My daring gamble fell flat. Lucian's defense was unbreakable, and I had no more tricks up my sleeve. His queen swooped in for the final checkmate. The game was over, and Lucian had won."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[191]`
  - -> `[190]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Lucian tried to maneuver his king away from the repeated checks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Lucian chose not to take the bait, instead strengthening his defenses against my desperate gamble."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> ""A sacrifice in vain. I accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
Mówca: **Narrator**
> "My bold move backfired. Lucian's pieces closed in, trapping my king. It was checkmate. The game was over, and Lucian had won."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[197]`
  - -> `[196]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> ""It's time to break through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
Mówca: **Narrator**
> "His attack was ruthless. I couldn't withstand it. My king was cornered, and with a final, decisive move, Lucian declared checkmate. The game was over, and I had lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[203]`
  - -> `[202]`

### Węzeł `[170]`
Mówca: **Narrator**
> "Lucian seized the opportunity, capturing my sacrificed knight and strengthening his position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Lucian decided to press his advantage, launching an aggressive attack on my defensive shell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your king is trapped, Lucian. The game is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Checkmate, my friend. It was a well-fought battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems the king is cornered, Lucian. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've reached an impasse, Lucian. A draw it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A stalemate, then. Quite the battle, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It looks like neither of us could secure the victory, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. Rayne. You've played well. Congratulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""I see no way out. Well done, Mr. President. You've earned this victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""It's your win, President Rayne. You've played an impressive game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
> ""Yes, Mr. Rayne. It's a fitting end to a well-fought game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""A draw, indeed. Here is to our equally matched skills.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President. It's a stalemate. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're at a stalemate, Lucian. It's a draw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Neither victory nor defeat, Lucian. A draw it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A draw, then. You've managed to evade my checks, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""Yes, President Rayne. It was a challenging game, leading us to a draw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
> ""Neither of us could deliver the final blow. A draw it is, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
> ""It's a deadlock, Mr. President. A game well played.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My gamble didn't pay off, Lucian. You've won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've defended well, Lucian. It's your win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've seen through my gamble, Lucian. Well played.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
> ""Your bold move made for an interesting endgame, President Rayne. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
> ""Your gamble was a risky one, President Rayne. In this case, I prevailed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
> ""You played daringly, Mr. President. But this time, the game is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've trapped my king, Lucian. The game is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your strategy was superior, Lucian. I admit defeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've outmaneuvered me, Lucian. Well played.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Thank you, Mr. President. You've put up quite a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""You played well, Mr. President. Better luck next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
> ""The game was tough, Mr. President. Your defeat was not easily won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My king is cornered, Lucian. Well done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've broken through my defenses, Lucian. It's your win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your attack was relentless, Lucian. I concede.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Lucian Galade**
> ""Your defenses were tough to crack, President Rayne. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[206]`
Mówca: **Lucian Galade**
> ""Victory wasn't easy, Mr. President. You made me work for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
> ""Your game was strong, Mr. President. But in the end, I prevailed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[208]`
**[WYBÓR GRACZA: "Exploit the Back Rank."]** — Mówca: **Player_Italic**
> "I moved my rook to the last rank, threatening Lucian's king with a potential back rank checkmate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "Pioneer Pawn March."]** — Mówca: **Player_Italic**
> "I boldly advanced my central pawn, paving the way for my knights and bishops to assert their dominance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessScore -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
> ""Ah, a swift strike at the heart, Mr. President. The game grows more interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[213]`
Mówca: **Lucian Galade**
> ""Clever, President Rayne. But did you consider all the consequences?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Lucian had made a bold move, pushing his pawn forward and forcing my bishop into a vulnerable position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Narrator**
> "While the urge to secure my threatened bishop was strong, an enticing opportunity also lay before me: a potential double attack on Lucian's king and rook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[110]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[218]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> ""We learn more from our mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
> ""Maybe another match another time. If fate allows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[221]`
Mówca: **Lucian Galade**
> ""Time well spent. We learn less from victories though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[222]`
Mówca: **Narrator**
> "Lucian and I slowly began to dismantle the chessboard, each piece carefully placed back into its protective casing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Lucian responded to my King's Gambit with a cautious but smart move, advancing his knight to f6."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Narrator**
> "As a response to my Xinan Defense, Lucian surprised me by opting for the Open Xinan, advancing his pawn to d4."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[225]`
Mówca: **Narrator**
> "This was the Falkbeer Counter Gambit, directly attacking my e4 pawn while leaving my f4 pawn hanging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[228]`
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your move shows your experience, Lucian. This game is shaping up to be quite a match.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see you aren't one to back down from a challenge, Lucian. Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Falkbeer Counter Gambit, Lucian? You certainly know how to keep things interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
> ""One does try, Mr. Rayne. It's your move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
> ""I wouldn't expect anything less from you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
> ""It wouldn't be much of a game if I did, now would it, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
**[WYBÓR GRACZA: "Defend the Pawn."]** — Mówca: **Player_Italic**
> "I moved my knight to f3, defending my threatened e4 pawn while also preparing to castle on the next move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "Push the Pawn."]** — Mówca: **Player_Italic**
> "I pushed my e-pawn to e5, pressurizing Lucian's knight and attempting to gain control of the center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[235]`
Mówca: **Narrator**
> "He was pushing for control of the center early, looking to turn the game into a tactical melee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[238]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bold strategy, Lucian. It seems we're in for a battle of tactics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see you're trying to seize the center early, Lucian. That's an aggressive play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Open Xinan, Lucian? You're certainly not shy about your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[240]`
Mówca: **Lucian Galade**
> ""Why hide, Mr. Rayne? Chess is a game of strategy and confrontation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
> ""That's the essence of chess, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
> ""Aggression can be a key to victory, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "Exchange the Pawn."]** — Mówca: **Player_Italic**
> "I opted for an early exchange, capturing Lucian's pawn with my c5 pawn, aiming to equalize the position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[244]`
**[WYBÓR GRACZA: "Develop the Knight."]** — Mówca: **Player_Italic**
> "I developed my knight to f6, placing pressure on the advanced pawn and preparing for my own pawn advance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "Press the Center."]** — Mówca: **Player_Italic**
> "Seeing Lucian's strategy unfold, I decided to assert control over the center. Moving my pawn from e5 to e3, I prepared to challenge his dominance on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[246]`
**[WYBÓR GRACZA: "Castle Kingside."]** — Mówca: **Player_Italic**
> "I decided to mirror Lucian's strategy, moving my king to safety. I moved my king two squares towards the rook and switched the rook to the other side, completing a kingside castle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[247]`
**[WYBÓR GRACZA: "Bishop's Threat."]** — Mówca: **Player_Italic**
> "Responding to Lucian's decision to fianchetto, I moved my bishop from f8 to c5, threatening his pawn structure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[248]`
**[WYBÓR GRACZA: "Knight's Advance."]** — Mówca: **Player_Italic**
> "In response to Lucian's fianchetto, I advanced my knight from b8 to c6, aiming to control more of the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeLostMatch = true; BaseGameSupport.Journal_Turn04_LucianChess_Won = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_GaladeLostMatch"] = true;
Variable["BaseGameSupport.Journal_Turn04_LucianChess_Won"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeDrawMatch = true; BaseGameSupport.Journal_Turn04_LucianChess_Draw = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_GaladeDrawMatch"] = true;
Variable["BaseGameSupport.Journal_Turn04_LucianChess_Draw"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeWonMatch = true;
BaseGameSupport.Journal_Turn04_LucianChess_Lose = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] = true;
Variable["BaseGameSupport.Journal_Turn04_LucianChess_Lose"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[253]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeDrawMatch == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_GaladeDrawMatch == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_GaladeDrawMatch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_GaladeDrawMatch == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_GaladeDrawMatch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Lucian's eyes bore a far-off look. Perhaps he was replaying the match within his mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Narrator**
> "He picked up a knight and turned it over in his hand thoughtfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[259]`
Mówca: **Narrator**
> "The chess match seemed to have left him thoughtful, his mind perhaps mulling over the moves he could have made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Lucian Galade**
> ""This game always reminds me of the delicate balance we had to strike in the days of the old Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
Mówca: **Lucian Galade**
> ""A difficult game, chess. The constant threats and counter-threats take me back to some similarly challenging times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[267]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
> ""Although the situation there was rarely as black and white.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[265]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
> ""It was not always a simple task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[271]`
  - -> `[270]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You certainly know how to keep things interesting, Lucian. Your past seems to be a well-guarded secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Strategical intricacies, eh? Sounds like you've got some interesting stories about that career. Care to share one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me more. Did chess play a part in your youth?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Threats and counter-threats... your past seems a lot more interesting than mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Was there a particular challenge that still resonates?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sounds like you've had quite the complicated past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This balance you speak of, Lucian, it seems to hint at some intriguing aspects of your past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can't help but wonder what kind of situations you had to navigate, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Balance in the days of the old Kingdom? Lucian, have you been holding back some history from me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Lucian Galade**
> ""In a way, chess prepared me for some of the challenges I faced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
> ""I was involved in some complex situations, where every move could drastically alter the landscape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[279]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
> ""Some things from those days are better left unsaid. I will say there was a certain...duality to those times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
> ""Chess is not the only game where one has to maintain a balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[283]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
> ""We all have our pasts, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
> ""Mine happened to involve many moves and counter-moves, each with its own consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[281]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Every move altering the landscape? Your early career must have been quite eventful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Complex situations, you say? Sounds like you've dealt with a lot of tough decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Were these consequences a part of the old Kingdom's final years, Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Moves and counter-moves? So you've seen your share of conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Duality? Were you juggling multiple roles?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It sounds like you were in the thick of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President. My past isn't without its share of shadows. There was a time when I served in a capacity that wasn't so... straightforward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Lucian's gaze dropped to his empty glass as he fell into a moment of quiet introspection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[294]`
  - -> `[293]`

### Węzeł `[287]`
Mówca: **Lucian Galade**
> ""Mr. President, the old Kingdom was a cauldron of shifting alliances and loyalties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Lucian shut the chess box with a soft click. He seemed unwilling to say more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[299]`
  - -> `[301]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
> ""Yes, Mr. President, those were trying times for Sordland. And like many others, I was caught in the crossfire of those tumultuous years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Narrator**
> "A shadow seemed to pass over Lucian's eyes, a hint of the turmoil that still lingered in his memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[303]`
  - -> `[302]`

### Węzeł `[291]`
Mówca: **Lucian Galade**
> ""I can tell you that there were instances where I found myself in the midst of... let's call it, intelligence work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
> ""I danced on a knife-edge, every step carrying deep consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're beginning to intrigue me, Lucian. What are you not telling me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can you tell me more about this... different capacity you served in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I certainly don't wish to delve into matters that might unsettle you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
> ""I've reconciled with my past, sir. I don't shy away from sharing aspects of it with those I trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
> ""It was a complex dance, rife with deception and shadows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[309]`
  - -> `[308]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
> ""Let's just say I was one of many who had to navigate those treacherous waters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've known each other for years, and that's all I get?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Treacherous waters... were you a naval officer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I certainly don't wish to delve into matters that might unsettle you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What sort of conflicts are we talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Caught in the crossfire... were you in the military?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
> ""It is not my intent to withhold information from you. But I believe we should focus on the future of Sordland, and leave its history where it belongs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
> ""It's a discussion for another day, Mr. President. Suffice to say, it was a time when Sordland was a battleground of older ideals and ambitions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
> ""My role? Let's just say I was one of the pieces on the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[307]`
Mówca: **Lucian Galade**
> ""I've reconciled with my past and set it aside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you were a spy? Sounds fascinating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Cut the metaphors, Lucian. I want details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You were involved in intelligence work, Lucian? That's certainly an unexpected revelation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Lucian Galade**
> ""It's true, sir. During the late Kingdom era, I found myself part of King Egmund's intelligence service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
> ""In a manner many would find... objectionable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
> ""There's much I still cannot say. But I carried out some unconventional assignments for King Egmund.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Lucian Galade**
> ""I served in a capacity that often demanded... morally challenging choices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[315]`
Mówca: **Lucian Galade**
> ""'Spy' is a simplistic term, Mr. President. My past roles were, let's say, less than conventional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
> ""I served for the national interests of King Egmund.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
> ""Much as I'd love to elaborate, I must take my leave. Thank you for the delightful match.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[320]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Lucian Galade**
> ""On that note, it's time for me to depart. I thoroughly enjoyed our match tonight, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[323]`
  - -> `[322]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's always a pleasure to witness your strategic prowess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Delightful for you, maybe. I demand a rematch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Lucian. The match was indeed captivating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's very gracious of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As did I. The game was as enlightening as it was entertaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Indeed, the game was a great pleasure, Lucian. Safe travels home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
> ""I hope to play again soon. Though I cannot promise the outcome will be any different for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
> ""Win or lose, there's always something to be learned from a round of chess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[327]`
Mówca: **Narrator**
> "As Lucian exited the room, the memories of our game lingered, as did the enigmatic aura of the man himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucian Galade");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucian Galade");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[330]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
> ""Good night, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
> ""Good night, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Livia Suno");)*
- **Efekt (`userScript`):** `RemoveConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Playing a chess match with their top advisor", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Playing a chess match with their top advisor","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_Personal_ChessPickBlack = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[337]`
Mówca: **Narrator**
> "A few minutes passed and a few more actions were made on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[338]`
Mówca: **Narrator**
> "A few minutes passed and a few more actions were made on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
