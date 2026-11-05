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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **""Livia, always a pleasure. Even more so when you bring coffee.""** | `[8]` **Livia Suno**: ""Long nights of strategy plannin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Livia Suno**: ""It's my job to keep the gears o..." |
| `[14]` | **""We might have to order dinner if this game takes as long as the ones we used to p..."** | `[8]` **Livia Suno**: ""Long nights of strategy plannin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Livia Suno**: ""I'll keep the Maroon Palace che..." |
| `[15]` | **""What's your opinion on chess, Livia? Ever been tempted to learn?""** | `[8]` **Livia Suno**: ""Long nights of strategy plannin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Livia Suno**: ""I prefer whist, Mr. President. ..." |
| `[21]` | **""Isn't that the truth? I've used pawns for some of my best plays.""** | `[12]` **Lucian Galade**: ""I hope you remember that it's n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucian Galade**: ""On the other hand, sir, even th..." |
| `[22]` | **""Neither of them hold any real power, Lucian. It's the player who controls them.""** | `[12]` **Lucian Galade**: ""I hope you remember that it's n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucian Galade**: ""Of course, sir. But a wise play..." |
| `[23]` | **""The power dynamics of a chess board can teach us a lot about politics, wouldn't y..."** | `[12]` **Lucian Galade**: ""I hope you remember that it's n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucian Galade**: ""Absolutely. And playing chess w..." |
| `[30]` | **""Shall we get this game underway, Lucian?""** | `[29]` **Narrator**: "As the final piece was set into ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Lucian Galade**: ""Indeed, President Rayne. A game..." |
| `[31]` | **""Enough reminiscing. Let's start, Lucian.""** | `[29]` **Narrator**: "As the final piece was set into ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: ""Ah, the impatience of a preside..." |
| `[35]` | **""Black for me. I like the advantage of reacting.""** | `[34]` **Lucian Galade**: ""Which color do you prefer? Blac..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack...` | `[39]` **Lucian Galade**: ""A strategist's choice. I'm not ..." |
| `[36]` | **""Doesn't matter to me, Lucian. I can play either side.""** | `[34]` **Lucian Galade**: ""Which color do you prefer? Blac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Lucian Galade**: ""If it doesn't matter, allow me ..." |
| `[37]` | **""I'll take white. The honor of the first move.""** | `[34]` **Lucian Galade**: ""Which color do you prefer? Blac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Lucian Galade**: ""A fine choice, befitting of you..." |
| `[47]` | **""I always enjoy a good challenge, Lucian. The Xinan should keep us both on our toes.""** | `[81]` **Lucian Galade**: ""Ah, the Xinan. A bold choice, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Lucian Galade**: ""It's a dance of strategy, Mr. R..." |
| `[48]` | **""Well, Lucian, they do say the Xinan Defense is the best form of attack.""** | `[81]` **Lucian Galade**: ""Ah, the Xinan. A bold choice, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucian Galade**: ""That they do, Mr. President. Le..." |
| `[49]` | **""I thought I'd mix things up a bit, Lucian. Let's see how well you handle the Xinan.""** | `[81]` **Lucian Galade**: ""Ah, the Xinan. A bold choice, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Lucian Galade**: ""Indeed, Mr. President. I look f..." |
| `[50]` | **""Reti? Let's throw in a bit of spice.""** | `[57]` **Narrator**: "Lucian moved his knight from g1 ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Italic**: "In response to Lucian's attempt ..."<br>`[59]` **Player_Italic**: "Countering Lucian's knight, I ma..." |
| `[51]` | **""It's not always about the center, is it?"** | `[57]` **Narrator**: "Lucian moved his knight from g1 ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Italic**: "In response to Lucian's attempt ..."<br>`[59]` **Player_Italic**: "Countering Lucian's knight, I ma..." |
| `[52]` | **""Interesting start, Lucian.""** | `[57]` **Narrator**: "Lucian moved his knight from g1 ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Italic**: "In response to Lucian's attempt ..."<br>`[59]` **Player_Italic**: "Countering Lucian's knight, I ma..." |
| `[58]` | **"Control the Center."** | `[50]` **Player**: ""Reti? Let's throw in a bit of s..."<br>`[51]` **Player**: ""It's not always about the cente..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Lucian Galade**: ""A solid move, Mr. Rayne. Mainta..." |
| `[59]` | **"March of the Knight."** | `[50]` **Player**: ""Reti? Let's throw in a bit of s..."<br>`[51]` **Player**: ""It's not always about the cente..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: ""Ah, symmetry. An art form in it..." |
| `[67]` | **""It's still early to hide behind defenses, isn't it?""** | `[65]` **Narrator**: "Lucian's next move was calculate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucian Galade**: ""One can never be too careful in..." |
| `[68]` | **""Your bishop is on the move, I see.""** | `[65]` **Narrator**: "Lucian's next move was calculate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lucian Galade**: ""Every piece has its role to pla..." |
| `[69]` | **""Opting for a solid defense, Lucian?""** | `[65]` **Narrator**: "Lucian's next move was calculate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucian Galade**: ""Every castle needs its walls."" |
| `[70]` | **""An unconventional approach. I'm curious to see where this leads.""** | `[66]` **Narrator**: "Lucian's response came in the fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: ""Life is full of surprises."" |
| `[71]` | **""A fianchetto setup, interesting.""** | `[66]` **Narrator**: "Lucian's response came in the fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lucian Galade**: ""You know what they say about va..." |
| `[72]` | **""You're setting up your bishop, I see.""** | `[66]` **Narrator**: "Lucian's response came in the fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: ""One must develop their minor pi..." |
| `[79]` | **"The Xinan Defense."** | `[56]` **Narrator**: "And thus the game began. The ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Lucian Galade**: ""Ah, the Xinan. A bold choice, M..." |
| `[80]` | **"The King's Gambit."** | `[56]` **Narrator**: "And thus the game began. The ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lucian Galade**: ""The King's Gambit, Mr. Rayne? A..." |
| `[83]` | **""Risk is part of the game, Lucian. Let's see if it pays off.""** | `[82]` **Lucian Galade**: ""The King's Gambit, Mr. Rayne? A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lucian Galade**: ""Indeed, Mr. Rayne. May the best..." |
| `[84]` | **""The King's Gambit always guarantees an engaging game, Lucian. I'm looking forward..."** | `[82]` **Lucian Galade**: ""The King's Gambit, Mr. Rayne? A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lucian Galade**: ""So am I, Mr. President. Your mo..." |
| `[85]` | **""A little daring keeps the game interesting, Lucian. Let's see how you manage.""** | `[82]` **Lucian Galade**: ""The King's Gambit, Mr. Rayne? A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Lucian Galade**: ""Agreed, Mr. President. I'm eage..." |
| `[93]` | **"Unleash the Rook."** | `[98]` **Narrator**: "The stakes were sky-high. A bold..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] =...` | `[218]` **Player_Italic**: "I kept playing without commenting."<br>`[97]` **Player**: ""A bold decision, leaving your k..."<br>*(oraz 2 innych odgałęzień)* |
| `[95]` | **""That knight of yours... a daring sacrifice, Lucian.""** | `[93]` **Player_Italic**: "With a bold stride, I advanced m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Lucian Galade**: ""A sacrifice indeed, but one I'm..." |
| `[96]` | **""Your knight is mine, Lucian. A worthy sacrifice on your part, it seems.""** | `[93]` **Player_Italic**: "With a bold stride, I advanced m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Lucian Galade**: ""A sacrifice indeed, but one I'm..." |
| `[97]` | **""A bold decision, leaving your knight in such a precarious position, Lucian.""** | `[93]` **Player_Italic**: "With a bold stride, I advanced m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Lucian Galade**: ""A sacrifice indeed, but one I'm..." |
| `[99]` | **"Attempt a Rummish Gambit."** | `[98]` **Narrator**: "The stakes were sky-high. A bold..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] =...` | `[105]` **Lucian Galade**: ""Ah, the Rummish Gambit. Pushing..." |
| `[106]` | **""Boldness can lead to victory, Lucian.""** | `[105]` **Lucian Galade**: ""Ah, the Rummish Gambit. Pushing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "He calmly slid his queen across ..." |
| `[107]` | **""Sometimes, one must gamble to win, Lucian.""** | `[105]` **Lucian Galade**: ""Ah, the Rummish Gambit. Pushing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "He calmly slid his queen across ..." |
| `[108]` | **""Risk often comes with rewards, Lucian.""** | `[105]` **Lucian Galade**: ""Ah, the Rummish Gambit. Pushing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "He calmly slid his queen across ..." |
| `[110]` | **"Initiate Rizian Fork."** | `[215]` **Narrator**: "While the urge to secure my thre..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] =...` | `[103]` **Lucian Galade**: ""A daring maneuver under fiery p..." |
| `[111]` | **"Fortify Bishop's Stand."** | `[215]` **Narrator**: "While the urge to secure my thre..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] =...` | `[118]` **Lucian Galade**: ""Your defenses are commendable. ..." |
| `[114]` | **""Only through fire do we learn the nature of the material.""** | `[120]` **Narrator**: "In response to my knight's threa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[115]` | **""Isn't that what makes the game exciting?""** | `[120]` **Narrator**: "In response to my knight's threa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[121]` | **""Fire is the test of gold, Lucian.""** | `[120]` **Narrator**: "In response to my knight's threa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[122]` | **""Space is but a canvas, Lucian.""** | `[119]` **Narrator**: "Lucian, undeterred by my fortres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[123]` | **""Sometimes, we must give to take.""** | `[119]` **Narrator**: "Lucian, undeterred by my fortres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[124]` | **""All the more room for your downfall.""** | `[119]` **Narrator**: "Lucian, undeterred by my fortres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[125]` | **"Reinforce the King."** | `[140]` **Narrator**: "Lucian's king stood vulnerable, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Lucian Galade**: ""A cautious play, sir. You are f..." |
| `[126]` | **"Decoy the Queen."** | `[140]` **Narrator**: "Lucian's king stood vulnerable, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Lucian Galade**: ""A daring choice, President. It ..." |
| `[135]` | **"All or Nothing."** | `[141]` **Narrator**: "The game was on a knife's edge, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Lucian Galade**: ""Taking a gamble, are we, Presid..." |
| `[136]` | **"Offer Perpetual Check."** | `[141]` **Narrator**: "The game was on a knife's edge, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucian Galade**: ""Ah, looking for a draw, Mr. Pre..." |
| `[137]` | **"Defensive Shell."** | `[142]` **Narrator**: "The game was slipping from my gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Lucian Galade**: ""You're on the defensive. The en..." |
| `[138]` | **"Knight Sacrifice."** | `[142]` **Narrator**: "The game was slipping from my gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Lucian Galade**: ""A bold sacrifice. Let's see how..." |
| `[172]` | **""Your king is trapped, Lucian. The game is mine.""** | `[155]` **Narrator**: "Despite Lucian's attempt to wrig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Lucian Galade**: ""It's your win, President Rayne...." |
| `[173]` | **""Checkmate, my friend. It was a well-fought battle.""** | `[155]` **Narrator**: "Despite Lucian's attempt to wrig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Lucian Galade**: ""I see no way out. Well done, Mr..." |
| `[174]` | **""It seems the king is cornered, Lucian. Good game.""** | `[155]` **Narrator**: "Despite Lucian's attempt to wrig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Lucian Galade**: ""Indeed, Mr. Rayne. You've playe..." |
| `[175]` | **""We've reached an impasse, Lucian. A draw it is.""** | `[157]` **Narrator**: "With both of us refusing to risk..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Lucian Galade**: ""Indeed, Mr. President. It's a s..." |
| `[176]` | **""A stalemate, then. Quite the battle, Lucian.""** | `[157]` **Narrator**: "With both of us refusing to risk..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Lucian Galade**: ""A draw, indeed. Here is to our ..." |
| `[177]` | **""It looks like neither of us could secure the victory, Lucian.""** | `[157]` **Narrator**: "With both of us refusing to risk..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Lucian Galade**: ""Yes, Mr. Rayne. It's a fitting ..." |
| `[184]` | **""We're at a stalemate, Lucian. It's a draw.""** | `[161]` **Narrator**: "The checks continued, neither of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Lucian Galade**: ""It's a deadlock, Mr. President...." |
| `[185]` | **""Neither victory nor defeat, Lucian. A draw it is.""** | `[161]` **Narrator**: "The checks continued, neither of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Lucian Galade**: ""Neither of us could deliver the..." |
| `[186]` | **""A draw, then. You've managed to evade my checks, Lucian.""** | `[161]` **Narrator**: "The checks continued, neither of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Lucian Galade**: ""Yes, President Rayne. It was a ..." |
| `[190]` | **""My gamble didn't pay off, Lucian. You've won.""** | `[163]` **Narrator**: "My daring gamble fell flat. Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Lucian Galade**: ""You played daringly, Mr. Presid..." |
| `[191]` | **""You've defended well, Lucian. It's your win.""** | `[163]` **Narrator**: "My daring gamble fell flat. Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Lucian Galade**: ""Your gamble was a risky one, Pr..." |
| `[192]` | **""You've seen through my gamble, Lucian. Well played.""** | `[163]` **Narrator**: "My daring gamble fell flat. Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Lucian Galade**: ""Your bold move made for an inte..." |
| `[196]` | **""You've trapped my king, Lucian. The game is yours.""** | `[167]` **Narrator**: "My bold move backfired. Lucian's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Lucian Galade**: ""The game was tough, Mr. Preside..." |
| `[197]` | **""Your strategy was superior, Lucian. I admit defeat.""** | `[167]` **Narrator**: "My bold move backfired. Lucian's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Lucian Galade**: ""You played well, Mr. President...." |
| `[198]` | **""You've outmaneuvered me, Lucian. Well played.""** | `[167]` **Narrator**: "My bold move backfired. Lucian's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Lucian Galade**: ""Thank you, Mr. President. You'v..." |
| `[202]` | **""My king is cornered, Lucian. Well done.""** | `[169]` **Narrator**: "His attack was ruthless. I could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Lucian Galade**: ""Your game was strong, Mr. Presi..." |
| `[203]` | **""You've broken through my defenses, Lucian. It's your win.""** | `[169]` **Narrator**: "His attack was ruthless. I could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Lucian Galade**: ""Victory wasn't easy, Mr. Presid..." |
| `[204]` | **""Your attack was relentless, Lucian. I concede.""** | `[169]` **Narrator**: "His attack was ruthless. I could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Lucian Galade**: ""Your defenses were tough to cra..." |
| `[208]` | **"Exploit the Back Rank."** | `[114]` **Player**: ""Only through fire do we learn t..."<br>`[115]` **Player**: ""Isn't that what makes the game ..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] =...` | `[213]` **Lucian Galade**: ""Clever, President Rayne. But di..." |
| `[209]` | **"Pioneer Pawn March."** | `[114]` **Player**: ""Only through fire do we learn t..."<br>`[115]` **Player**: ""Isn't that what makes the game ..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] =...` | `[212]` **Lucian Galade**: ""Ah, a swift strike at the heart..." |
| `[216]` | **"Keep playing and don't comment."** | `[119]` **Narrator**: "Lucian, undeterred by my fortres..."<br>`[120]` **Narrator**: "In response to my knight's threa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Player_Italic**: "I moved my rook to the last rank..."<br>`[209]` **Player_Italic**: "I boldly advanced my central paw..." |
| `[217]` | **"Keep playing and don't comment."** | `[105]` **Lucian Galade**: ""Ah, the Rummish Gambit. Pushing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "He calmly slid his queen across ..." |
| `[218]` | **"Keep playing and don't comment."** | `[93]` **Player_Italic**: "With a bold stride, I advanced m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "Lucian moved his rook from the c..." |
| `[226]` | **""Your move shows your experience, Lucian. This game is shaping up to be quite a ma..."** | `[225]` **Narrator**: "This was the Falkbeer Counter Ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Lucian Galade**: ""I wouldn't expect anything less..." |
| `[227]` | **""I see you aren't one to back down from a challenge, Lucian. Very well.""** | `[225]` **Narrator**: "This was the Falkbeer Counter Ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Lucian Galade**: ""It wouldn't be much of a game i..." |
| `[228]` | **""A Falkbeer Counter Gambit, Lucian? You certainly know how to keep things interest..."** | `[225]` **Narrator**: "This was the Falkbeer Counter Ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Lucian Galade**: ""One does try, Mr. Rayne. It's y..." |
| `[229]` | **"Keep playing and don't comment."** | `[225]` **Narrator**: "This was the Falkbeer Counter Ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Player_Italic**: "I moved my knight to f3, defendi..."<br>`[234]` **Player_Italic**: "I pushed my e-pawn to e5, pressu..." |
| `[233]` | **"Defend the Pawn."** | `[229]` **Player_Italic**: "I kept playing without commenting."<br>`[230]` **Lucian Galade**: ""One does try, Mr. Rayne. It's y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[234]` | **"Push the Pawn."** | `[229]` **Player_Italic**: "I kept playing without commenting."<br>`[230]` **Lucian Galade**: ""One does try, Mr. Rayne. It's y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[236]` | **""Bold strategy, Lucian. It seems we're in for a battle of tactics.""** | `[235]` **Narrator**: "He was pushing for control of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Lucian Galade**: ""That's the essence of chess, Mr..." |
| `[237]` | **""I see you're trying to seize the center early, Lucian. That's an aggressive play.""** | `[235]` **Narrator**: "He was pushing for control of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucian Galade**: ""Aggression can be a key to vict..." |
| `[238]` | **""The Open Xinan, Lucian? You're certainly not shy about your intentions.""** | `[235]` **Narrator**: "He was pushing for control of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Lucian Galade**: ""Why hide, Mr. Rayne? Chess is a..." |
| `[239]` | **"Keep playing and don't comment."** | `[235]` **Narrator**: "He was pushing for control of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Player_Italic**: "I opted for an early exchange, c..."<br>`[244]` **Player_Italic**: "I developed my knight to f6, pla..." |
| `[243]` | **"Exchange the Pawn."** | `[239]` **Player_Italic**: "I kept playing without commenting."<br>`[240]` **Lucian Galade**: ""Why hide, Mr. Rayne? Chess is a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[244]` | **"Develop the Knight."** | `[239]` **Player_Italic**: "I kept playing without commenting."<br>`[240]` **Lucian Galade**: ""Why hide, Mr. Rayne? Chess is a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[245]` | **"Press the Center."** | `[73]` **Lucian Galade**: ""Every castle needs its walls.""<br>`[74]` **Lucian Galade**: ""One can never be too careful in..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[246]` | **"Castle Kingside."** | `[73]` **Lucian Galade**: ""Every castle needs its walls.""<br>`[74]` **Lucian Galade**: ""One can never be too careful in..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[247]` | **"Bishop's Threat."** | `[76]` **Lucian Galade**: ""One must develop their minor pi..."<br>`[77]` **Lucian Galade**: ""Life is full of surprises.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[248]` | **"Knight's Advance."** | `[76]` **Lucian Galade**: ""One must develop their minor pi..."<br>`[77]` **Lucian Galade**: ""Life is full of surprises.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "With this, the stage was set. Th..." |
| `[252]` | **"Keep playing and don't comment."** | `[66]` **Narrator**: "Lucian's response came in the fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Player_Italic**: "Responding to Lucian's decision ..."<br>`[248]` **Player_Italic**: "In response to Lucian's fianchet..." |
| `[253]` | **"Keep playing and don't comment."** | `[65]` **Narrator**: "Lucian's next move was calculate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Player_Italic**: "Seeing Lucian's strategy unfold,..."<br>`[246]` **Player_Italic**: "I decided to mirror Lucian's str..." |
| `[264]` | **""You certainly know how to keep things interesting, Lucian. Your past seems to be ..."** | `[262]` **Lucian Galade**: ""Although the situation there wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Lucian Galade**: ""In a way, chess prepared me for..." |
| `[265]` | **""Strategical intricacies, eh? Sounds like you've got some interesting stories abou..."** | `[262]` **Lucian Galade**: ""Although the situation there wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Lucian Galade**: ""In a way, chess prepared me for..." |
| `[266]` | **""Tell me more. Did chess play a part in your youth?""** | `[262]` **Lucian Galade**: ""Although the situation there wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Lucian Galade**: ""In a way, chess prepared me for..." |
| `[267]` | **""Threats and counter-threats... your past seems a lot more interesting than mine.""** | `[261]` **Lucian Galade**: ""A difficult game, chess. The co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Lucian Galade**: ""We all have our pasts, Mr. Pres..." |
| `[268]` | **""Was there a particular challenge that still resonates?""** | `[261]` **Lucian Galade**: ""A difficult game, chess. The co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Lucian Galade**: ""We all have our pasts, Mr. Pres..." |
| `[269]` | **""Sounds like you've had quite the complicated past.""** | `[261]` **Lucian Galade**: ""A difficult game, chess. The co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Lucian Galade**: ""We all have our pasts, Mr. Pres..." |
| `[270]` | **""This balance you speak of, Lucian, it seems to hint at some intriguing aspects of..."** | `[263]` **Lucian Galade**: ""It was not always a simple task."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Lucian Galade**: ""Some things from those days are..." |
| `[271]` | **""I can't help but wonder what kind of situations you had to navigate, Lucian.""** | `[263]` **Lucian Galade**: ""It was not always a simple task."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Lucian Galade**: ""Some things from those days are..." |
| `[272]` | **""Balance in the days of the old Kingdom? Lucian, have you been holding back some h..."** | `[263]` **Lucian Galade**: ""It was not always a simple task."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Lucian Galade**: ""Some things from those days are..." |
| `[279]` | **""Every move altering the landscape? Your early career must have been quite eventful.""** | `[274]` **Lucian Galade**: ""I was involved in some complex ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Lucian Galade**: ""Indeed, Mr. President. My past ..." |
| `[280]` | **""Complex situations, you say? Sounds like you've dealt with a lot of tough decisio..."** | `[274]` **Lucian Galade**: ""I was involved in some complex ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Lucian Galade**: ""Indeed, Mr. President. My past ..." |
| `[281]` | **""Were these consequences a part of the old Kingdom's final years, Lucian?""** | `[278]` **Lucian Galade**: ""Mine happened to involve many m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lucian Galade**: ""Yes, Mr. President, those were ..." |
| `[282]` | **""Moves and counter-moves? So you've seen your share of conflict.""** | `[278]` **Lucian Galade**: ""Mine happened to involve many m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lucian Galade**: ""Yes, Mr. President, those were ..." |
| `[283]` | **""Duality? Were you juggling multiple roles?""** | `[276]` **Lucian Galade**: ""Chess is not the only game wher..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Lucian Galade**: ""Mr. President, the old Kingdom ..." |
| `[284]` | **""It sounds like you were in the thick of it.""** | `[276]` **Lucian Galade**: ""Chess is not the only game wher..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Lucian Galade**: ""Mr. President, the old Kingdom ..." |
| `[293]` | **""You're beginning to intrigue me, Lucian. What are you not telling me?""** | `[286]` **Narrator**: "Lucian's gaze dropped to his emp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lucian Galade**: ""I can tell you that there were ..." |
| `[294]` | **""Can you tell me more about this... different capacity you served in?""** | `[286]` **Narrator**: "Lucian's gaze dropped to his emp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lucian Galade**: ""I can tell you that there were ..." |
| `[295]` | **""I certainly don't wish to delve into matters that might unsettle you.""** | `[286]` **Narrator**: "Lucian's gaze dropped to his emp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Lucian Galade**: ""I've reconciled with my past, s..." |
| `[299]` | **""We've known each other for years, and that's all I get?""** | `[288]` **Narrator**: "Lucian shut the chess box with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Lucian Galade**: ""It's a discussion for another d..." |
| `[300]` | **""Treacherous waters... were you a naval officer?""** | `[288]` **Narrator**: "Lucian shut the chess box with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Lucian Galade**: ""It's a discussion for another d..." |
| `[301]` | **""I certainly don't wish to delve into matters that might unsettle you.""** | `[288]` **Narrator**: "Lucian shut the chess box with a..."<br>`[290]` **Narrator**: "A shadow seemed to pass over Luc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Lucian Galade**: ""I've reconciled with my past an..." |
| `[302]` | **""What sort of conflicts are we talking about?""** | `[290]` **Narrator**: "A shadow seemed to pass over Luc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Lucian Galade**: ""It is not my intent to withhold..." |
| `[303]` | **""Caught in the crossfire... were you in the military?""** | `[290]` **Narrator**: "A shadow seemed to pass over Luc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Lucian Galade**: ""It is not my intent to withhold..." |
| `[308]` | **""So you were a spy? Sounds fascinating.""** | `[297]` **Lucian Galade**: ""It was a complex dance, rife wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Lucian Galade**: ""'Spy' is a simplistic term, Mr...." |
| `[309]` | **""Cut the metaphors, Lucian. I want details.""** | `[297]` **Lucian Galade**: ""It was a complex dance, rife wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Lucian Galade**: ""There's much I still cannot say..." |
| `[310]` | **""You were involved in intelligence work, Lucian? That's certainly an unexpected re..."** | `[297]` **Lucian Galade**: ""It was a complex dance, rife wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Lucian Galade**: ""It's true, sir. During the late..." |
| `[319]` | **""It's always a pleasure to witness your strategic prowess.""** | `[317]` **Lucian Galade**: ""Much as I'd love to elaborate, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Lucian Galade**: ""I hope to play again soon. Thou..." |
| `[320]` | **""Delightful for you, maybe. I demand a rematch.""** | `[317]` **Lucian Galade**: ""Much as I'd love to elaborate, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Lucian Galade**: ""I hope to play again soon. Thou..." |
| `[321]` | **""Thank you, Lucian. The match was indeed captivating.""** | `[317]` **Lucian Galade**: ""Much as I'd love to elaborate, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Lucian Galade**: ""I hope to play again soon. Thou..." |
| `[322]` | **""That's very gracious of you.""** | `[318]` **Lucian Galade**: ""On that note, it's time for me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Lucian Galade**: ""Win or lose, there's always som..." |
| `[323]` | **""As did I. The game was as enlightening as it was entertaining.""** | `[318]` **Lucian Galade**: ""On that note, it's time for me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Lucian Galade**: ""Win or lose, there's always som..." |
| `[324]` | **""Indeed, the game was a great pleasure, Lucian. Safe travels home.""** | `[318]` **Lucian Galade**: ""On that note, it's time for me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Lucian Galade**: ""Win or lose, there's always som..." |

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
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Playing a chess match with their top adv..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Evening descended on the capital as Lucian and I found ourselves alone in my office. I followed my chief strategist's eyes to the chessboard on the coffee table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The sight of it reminded me of simpler times, of late-nig..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The sight of it reminded me of simpler times, of late-night strategy sessions turning into chess matches. We used to escape the political chaos into a world of rooks and bishops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Our battles were both tense and friendly, a reflection of..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Our battles were both tense and friendly, a reflection of our long history together. Lucian had always proved a challenging opponent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "His strategies, both on the chessboard and in politics, h..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "His strategies, both on the chessboard and in politics, had the same unpredictable edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "A soft knock interrupted my reminiscing."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "A soft knock interrupted my reminiscing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "AddConversant("Livia Suno");"*)

### Węzeł `[8]`
Mówca: **Livia Suno**
> ""Long nights of strategy planning, and now a game of chess. You two never stop thinking, do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""Livia, always a pleasure. Even more so when you bring co..."*)
  - -> `[14]` (*Player: ""We might have to order dinner if this game takes as long..."*)
  - -> `[15]` (*Player: ""What's your opinion on chess, Livia? Ever been tempted t..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Livia Suno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Livia came in with our usual coffee. She noticed the ches..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucian Galade");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Evening descended on the capital as Lucian and I found ou..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Livia came in with our usual coffee. She noticed the chessboard and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Livia Suno: ""Long nights of strategy planning, and now a game of ches..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""I hope you remember that it's not always the king who holds the power. Sometimes, a well-placed pawn can change the game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Isn't that the truth? I've used pawns for some of my bes..."*)
  - -> `[22]` (*Player: ""Neither of them hold any real power, Lucian. It's the pl..."*)
  - -> `[23]` (*Player: ""The power dynamics of a chess board can teach us a lot a..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Livia, always a pleasure. Even more so when you bring coffee.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Livia Suno: ""It's my job to keep the gears of this office turning, Mr..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We might have to order dinner if this game takes as long as the ones we used to play.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Livia Suno: ""I'll keep the Maroon Palace chef on speed dial then.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's your opinion on chess, Livia? Ever been tempted to learn?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Livia Suno: ""I prefer whist, Mr. President. I'll leave the complex pl..."*)

### Węzeł `[16]`
Mówca: **Livia Suno**
> ""It's my job to keep the gears of this office turning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Livia Suno: ""Have a good game, gentlemen.""*)

### Węzeł `[17]`
Mówca: **Livia Suno**
> ""I'll keep the Maroon Palace chef on speed dial then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Livia Suno: ""Have a good game, gentlemen.""*)

### Węzeł `[18]`
Mówca: **Livia Suno**
> ""I prefer whist, Mr. President. I'll leave the complex plotting to the professionals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Livia Suno: ""Have a good game, gentlemen.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "She turned and left the room. Lucian acknowledged her exit with a slight nod, his eyes still fixed on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Livia Suno");"*)

### Węzeł `[20]`
Mówca: **Livia Suno**
> ""Have a good game, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "She turned and left the room. Lucian acknowledged her exi..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't that the truth? I've used pawns for some of my best plays.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""On the other hand, sir, even the most strategic pawn mov..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Neither of them hold any real power, Lucian. It's the player who controls them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""Of course, sir. But a wise player recognizes the value o..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The power dynamics of a chess board can teach us a lot about politics, wouldn't you agree, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""Absolutely. And playing chess with politicians will tell..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""On the other hand, sir, even the most strategic pawn move won't help if you overlook the other pieces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "As Lucian positioned the pieces on the chessboard, it sti..."*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""Of course, sir. But a wise player recognizes the value of every piece on the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "As Lucian positioned the pieces on the chessboard, it sti..."*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""Absolutely. And playing chess with politicians will tell you more about their goals and plans than any speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "As Lucian positioned the pieces on the chessboard, it sti..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "His dexterous maneuvering reflected the unseen orchestration that helped Petr and me ascend through the ranks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "As the final piece was set into position, the board trans..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "As Lucian positioned the pieces on the chessboard, it stirred memories of our early days in the United Sordland Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "His dexterous maneuvering reflected the unseen orchestrat..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "As the final piece was set into position, the board transformed into a silent battlefield."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Shall we get this game underway, Lucian?""*)
  - -> `[31]` (*Player: ""Enough reminiscing. Let's start, Lucian.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Shall we get this game underway, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""Indeed, President Rayne. A game of chess is exactly what..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough reminiscing. Let's start, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""Ah, the impatience of a president. Very well, let's begin.""*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""Indeed, President Rayne. A game of chess is exactly what we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""Which color do you prefer? Black as usual or white this ..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""Ah, the impatience of a president. Very well, let's begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""Which color do you prefer? Black as usual or white this ..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""Which color do you prefer? Black as usual or white this time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""I'll take white. The honor of the first move.""*)
  - -> `[35]` (*Player: ""Black for me. I like the advantage of reacting.""*)
  - -> `[36]` (*Player: ""Doesn't matter to me, Lucian. I can play either side.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Black for me. I like the advantage of reacting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessPickBlack = true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Doesn't matter to me, Lucian. I can play either side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucian Galade: ""If it doesn't matter, allow me the honor of the first mo..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll take white. The honor of the first move.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""A fine choice, befitting of your drive to lead. The firs..."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""A fine choice, befitting of your drive to lead. The first move is yours, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "With the sides chosen, Lucian sat back, his fingers laced..."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""A strategist's choice. I'm not surprised. The board is yours to react to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "With the sides chosen, Lucian sat back, his fingers laced..."*)

### Węzeł `[40]`
Mówca: **Lucian Galade**
> ""If it doesn't matter, allow me the honor of the first move. I'll take white.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessPickBlack = true"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "With the sides chosen, Lucian sat back, his fingers laced together in contemplation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessPickBlack == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessPickBlack = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""A strategist's choice. I'm not surprised. The board is y..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "And thus the game began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Lucian moved his knight from g1 to f3. Aiming for a Reti ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessPickBlack == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessPickBlack == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_Personal_ChessPickBlack == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessPickBlack == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And thus the game began."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_Personal_ChessPickBlack == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "And thus the game began. The opening decision was mine."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I always enjoy a good challenge, Lucian. The Xinan should keep us both on our toes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""It's a dance of strategy, Mr. Rayne. Let's hope we both ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, Lucian, they do say the Xinan Defense is the best form of attack.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""That they do, Mr. President. Let's see if it holds true ..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought I'd mix things up a bit, Lucian. Let's see how well you handle the Xinan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""Indeed, Mr. President. I look forward to seeing your nex..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Reti? Let's throw in a bit of spice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Control the Center."*)
  - -> `[59]` (*Player_Italic: "March of the Knight."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's not always about the center, is it?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Control the Center."*)
  - -> `[59]` (*Player_Italic: "March of the Knight."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting start, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Control the Center."*)
  - -> `[59]` (*Player_Italic: "March of the Knight."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President. I look forward to seeing your next moves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "As a response to my Xinan Defense, Lucian surprised me by..."*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""It's a dance of strategy, Mr. Rayne. Let's hope we both brought our dancing shoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "As a response to my Xinan Defense, Lucian surprised me by..."*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""That they do, Mr. President. Let's see if it holds true for us today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "As a response to my Xinan Defense, Lucian surprised me by..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "And thus the game began. The opening decision was mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Italic: "The Xinan Defense."*)
  - -> `[80]` (*Player_Italic: "The King's Gambit."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Lucian moved his knight from g1 to f3. Aiming for a Reti Opening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: ""Interesting start, Lucian.""*)
  - -> `[50]` (*Player: ""Reti? Let's throw in a bit of spice.""*)
  - -> `[51]` (*Player: ""It's not always about the center, is it?"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Control the Center."]** — Mówca: **Player_Italic**
> "In response to Lucian's attempt at the Reti Opening, I advanced my pawn from d7 to d5, aiming to strengthen my grip on the center."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[51]` (Player), `[52]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""A solid move, Mr. Rayne. Maintaining control of the cent..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "March of the Knight."]** — Mówca: **Player_Italic**
> "Countering Lucian's knight, I maneuvered my knight from g8 to f6, eyeing the center and setting up defenses."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[51]` (Player), `[52]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: ""Ah, symmetry. An art form in itself.""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeWonMatch == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeWonMatch == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_GaladeWonMatch == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeWonMatch == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Lucian was in high spirits, his eyes gleaming with a rare..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_GaladeWonMatch == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeDrawMatch == true"*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""Ah, symmetry. An art form in itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "A few minutes passed and a few more actions were made on ..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""A solid move, Mr. Rayne. Maintaining control of the center is often key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "A few minutes passed and a few more actions were made on ..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Lucian's next move was calculated and swift. The bishop glided from f1 to g2, preparing for a potential kingside castle and fortifying the pawn structure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[69]` (*Player: ""Opting for a solid defense, Lucian?""*)
  - -> `[67]` (*Player: ""It's still early to hide behind defenses, isn't it?""*)
  - -> `[68]` (*Player: ""Your bishop is on the move, I see.""*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Lucian's response came in the form of a g2 to g3 pawn move, hinting at the decision to fianchetto his bishop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[72]` (*Player: ""You're setting up your bishop, I see.""*)
  - -> `[70]` (*Player: ""An unconventional approach. I'm curious to see where thi..."*)
  - -> `[71]` (*Player: ""A fianchetto setup, interesting.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's still early to hide behind defenses, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""One can never be too careful in the game of kings.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your bishop is on the move, I see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""Every piece has its role to play, Mr. President.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Opting for a solid defense, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: ""Every castle needs its walls.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An unconventional approach. I'm curious to see where this leads.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Life is full of surprises.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A fianchetto setup, interesting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""You know what they say about variety.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're setting up your bishop, I see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""One must develop their minor pieces.""*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Every castle needs its walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Italic: "Press the Center."*)
  - -> `[246]` (*Player_Italic: "Castle Kingside."*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""One can never be too careful in the game of kings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Italic: "Press the Center."*)
  - -> `[246]` (*Player_Italic: "Castle Kingside."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Every piece has its role to play, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Italic: "Press the Center."*)
  - -> `[246]` (*Player_Italic: "Castle Kingside."*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""One must develop their minor pieces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Italic: "Bishop's Threat."*)
  - -> `[248]` (*Player_Italic: "Knight's Advance."*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Life is full of surprises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Italic: "Bishop's Threat."*)
  - -> `[248]` (*Player_Italic: "Knight's Advance."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""You know what they say about variety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Italic: "Bishop's Threat."*)
  - -> `[248]` (*Player_Italic: "Knight's Advance."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "The Xinan Defense."]** — Mówca: **Player_Italic**
> "I started with e4, Lucian replied with c5. I was initiating the Xinan Defense, aiming for a dynamic and asymmetrical position."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: ""Ah, the Xinan. A bold choice, Mr. Rayne. This should be ..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "The King's Gambit."]** — Mówca: **Player_Italic**
> "I moved my pawn to e4 and Lucian responded with e5. Then, I boldly advanced my f-pawn, signifying the King's Gambit."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""The King's Gambit, Mr. Rayne? A daring opening. It promi..."*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""Ah, the Xinan. A bold choice, Mr. Rayne. This should be an interesting match.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: ""I thought I'd mix things up a bit, Lucian. Let's see how..."*)
  - -> `[47]` (*Player: ""I always enjoy a good challenge, Lucian. The Xinan shoul..."*)
  - -> `[48]` (*Player: ""Well, Lucian, they do say the Xinan Defense is the best ..."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""The King's Gambit, Mr. Rayne? A daring opening. It promises an exciting game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""A little daring keeps the game interesting, Lucian. Let'..."*)
  - -> `[83]` (*Player: ""Risk is part of the game, Lucian. Let's see if it pays o..."*)
  - -> `[84]` (*Player: ""The King's Gambit always guarantees an engaging game, Lu..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Risk is part of the game, Lucian. Let's see if it pays off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""Indeed, Mr. Rayne. May the best player prevail.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The King's Gambit always guarantees an engaging game, Lucian. I'm looking forward to your response.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""So am I, Mr. President. Your move.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A little daring keeps the game interesting, Lucian. Let's see how you manage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""Agreed, Mr. President. I'm eager to navigate the labyrin..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Agreed, Mr. President. I'm eager to navigate the labyrinth you're constructing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Lucian responded to my King's Gambit with a cautious but ..."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. Rayne. May the best player prevail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Lucian responded to my King's Gambit with a cautious but ..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""So am I, Mr. President. Your move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Lucian responded to my King's Gambit with a cautious but ..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "With this, the stage was set. The opening maneuvers had transformed into a mid-game battle of wits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Each pawn push, every subtle repositioning, had been show..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Each pawn push, every subtle repositioning, had been showing to Lucian's strategic prowess and my resilience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "The next move would prove crucial. Lucian's queen cut a p..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "The next move would prove crucial. Lucian's queen cut a path through the heart of the board, menacing my vulnerable kingside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "The stakes were sky-high. A bold pawn advance could relea..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "As Lucian departed, I thought about what he'd told me. I'd learned a thing or two, but the man was more of a mystery than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "Unleash the Rook."]** — Mówca: **Player_Italic**
> "With a bold stride, I advanced my pawn, ripping open the f-file. The next move took a knight from Lucian."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore += 1"*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""A sacrifice indeed, but one I'm willing to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Lucian moved his rook from the corner, adding pressure on..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That knight of yours... a daring sacrifice, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""A sacrifice indeed, but one I'm willing to make.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your knight is mine, Lucian. A worthy sacrifice on your part, it seems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""A sacrifice indeed, but one I'm willing to make.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A bold decision, leaving your knight in such a precarious position, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""A sacrifice indeed, but one I'm willing to make.""*)

### Węzeł `[98]`
Mówca: **Narrator**
> "The stakes were sky-high. A bold pawn advance could release my rook's potential and threaten Lucian's knight. On the other hand, I could gamble with a Rummish Gambit, a risky play that could wrestle control of the center away from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Italic: "Unleash the Rook."*)
  - -> `[99]` (*Player_Italic: "Attempt a Rummish Gambit."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "Attempt a Rummish Gambit."]** — Mówca: **Player_Italic**
> "I attempted a Rummish Gambit. I decided to risk a critical pawn, hoping to gain an advantage in the middle game."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore -= 1"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[97]` (*Player: ""A bold decision, leaving your knight in such a precariou..."*)
  - -> `[95]` (*Player: ""That knight of yours... a daring sacrifice, Lucian.""*)
  - -> `[96]` (*Player: ""Your knight is mine, Lucian. A worthy sacrifice on your ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Ah, the Rummish Gambit. Pushing down the center. Bold, b..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""The high stakes and strategical intricacies of this game remind me of the trials I endured early in my career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lucian Galade: ""Although the situation there was rarely as black and whi..."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""A daring maneuver under fiery pressure. You're an adept tactician but this is far from over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "In response to my knight's threat, Lucian moved out the t..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Lucian moved his rook from the corner, adding pressure on my exposed bishop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Lucian had made a bold move, pushing his pawn forward and..."*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Ah, the Rummish Gambit. Pushing down the center. Bold, but risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[108]` (*Player: ""Risk often comes with rewards, Lucian.""*)
  - -> `[106]` (*Player: ""Boldness can lead to victory, Lucian.""*)
  - -> `[107]` (*Player: ""Sometimes, one must gamble to win, Lucian.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Boldness can lead to victory, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He calmly slid his queen across the board, threatening my..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes, one must gamble to win, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He calmly slid his queen across the board, threatening my..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Risk often comes with rewards, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He calmly slid his queen across the board, threatening my..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "He calmly slid his queen across the board, threatening my isolated pawn. His subtle smirk revealed he understood my gambit and was ready to counter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Lucian had made a bold move, pushing his pawn forward and..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "Initiate Rizian Fork."]** — Mówca: **Player_Italic**
> "I maneuvered my knight expertly, landing it on a square that posed a double threat to Lucian's king and rook."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore += 1"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "Fortify Bishop's Stand."]** — Mówca: **Player_Italic**
> "I shifted my rook, bringing it to stand beside the embattled bishop. The strong defensive formation would deter any of Lucian's advances."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore -= 1"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""A daring maneuver under fiery pressure. You're an adept ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""Your defenses are commendable. But you are giving me too..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Only through fire do we learn the nature of the material.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't that what makes the game exciting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Lucian was in high spirits, his eyes gleaming with a rare look of contentment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""The high stakes and strategical intricacies of this game..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Lucian maintained a steady gaze, his face unreadable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "The chess match seemed to have left him thoughtful, his m..."*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""Your defenses are commendable. But you are giving me too much space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Lucian, undeterred by my fortress, slid his queen to a mo..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Lucian, undeterred by my fortress, slid his queen to a more advantageous square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""All the more room for your downfall.""*)
  - -> `[123]` (*Player: ""Sometimes, we must give to take.""*)
  - -> `[122]` (*Player: ""Space is but a canvas, Lucian.""*)
  - -> `[216]` (*Player_Italic: "Keep playing and don't comment."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "In response to my knight's threat, Lucian moved out the threat, creating a barrier between my knight and his king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[121]` (*Player: ""Fire is the test of gold, Lucian.""*)
  - -> `[115]` (*Player: ""Isn't that what makes the game exciting?""*)
  - -> `[114]` (*Player: ""Only through fire do we learn the nature of the material.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fire is the test of gold, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Space is but a canvas, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes, we must give to take.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All the more room for your downfall.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "Reinforce the King."]** — Mówca: **Player_Italic**
> "I decided to consolidate my defenses, bringing my rook in to guard my king."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucian Galade: ""A cautious play, sir. You are forcing us into a drawn en..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "Decoy the Queen."]** — Mówca: **Player_Italic**
> "I boldly moved my queen, placing it in a position that exposed Lucian's king to a potential checkmate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: ""A daring choice, President. It seems the end is near.""*)

### Węzeł `[127]`
Mówca: **Narrator**
> "The center was congested, a show of Lucian's unyielding style. His formation was formidable, his pieces interlocked in a matrix of support, each protecting the other while simultaneously projecting threats across the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "It was my move and the game had entered its final stages...."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "It was my move and the game had entered its final stages. Lucian's queen was uncomfortably close, radiating danger. I had only a few paths before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore == 3"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore == 3"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_Personal_ChessScore == 3)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Lucian's king stood vulnerable, but a risky move could le..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_Personal_ChessScore == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore == 2"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore == 2"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_Personal_ChessScore == 2)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore == 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "The game was on a knife's edge, the outcome far from cert..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_Personal_ChessScore == 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The game was slipping from my grasp. I had two options - ..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "All or Nothing."]** — Mówca: **Player_Italic**
> "I decided to take a bold risk, hoping for a sudden twist in the game's conclusion."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""Taking a gamble, are we, President Rayne? Let's see wher..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "Offer Perpetual Check."]** — Mówca: **Player_Italic**
> "I positioned my queen to offer a perpetual check, potentially forcing a draw by repetition."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: ""Ah, looking for a draw, Mr. President? Interesting.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "Defensive Shell."]** — Mówca: **Player_Italic**
> "I moved my pieces into a defensive formation, aiming to stave off Lucian's imminent attack."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucian Galade: ""You're on the defensive. The endgame is mine to command.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "Knight Sacrifice."]** — Mówca: **Player_Italic**
> "I decided to sacrifice my knight, hoping that the unexpected move would throw Lucian off balance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: ""A bold sacrifice. Let's see how this plays out.""*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> ""A daring choice, President. It seems the end is near.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "If Lucian overlooked the threat I posed, victory would be..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Lucian's king stood vulnerable, but a risky move could leave my own king exposed. However, seizing the opportunity seemed worth the risk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Italic: "Decoy the Queen."*)
  - -> `[125]` (*Player_Italic: "Reinforce the King."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "The game was on a knife's edge, the outcome far from certain. The board offered a potential for a draw if I played conservatively or an opportunity for a hail mary win if I dared to go all in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Italic: "Offer Perpetual Check."*)
  - -> `[135]` (*Player_Italic: "All or Nothing."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "The game was slipping from my grasp. I had two options - a risky knight sacrifice that could lead to a swift end, or to hunker down and hope for a draw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Italic: "Knight Sacrifice."*)
  - -> `[137]` (*Player_Italic: "Defensive Shell."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "If Lucian overlooked the threat I posed, victory would be mine. If he identified the trap, the game could stretch on, but the advantage would be mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: ""Well played. But it's not over yet.""*)

### Węzeł `[144]`
Mówca: **Lucian Galade**
> ""A cautious play, sir. You are forcing us into a drawn endgame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "If Lucian tried to attack aggressively now, the fortress ..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "If Lucian tried to attack aggressively now, the fortress I'd built around my king would be my saving grace, leading to a draw. If he chose to fortify his position as well, a drawn endgame would be inevitable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: ""Safety first. Your move.""*)

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""A bold sacrifice. Let's see how this plays out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "If Lucian fell into the trap, I might manage to draw. If ..."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "If Lucian fell into the trap, I might manage to draw. If he saw through it, my loss was imminent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: ""A sacrifice in vain. I accept.""*)

### Węzeł `[148]`
Mówca: **Lucian Galade**
> ""You're on the defensive. The endgame is mine to command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "If Lucian made a mistake now, I could potentially salvage..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "If Lucian made a mistake now, I could potentially salvage a draw. However, if he played his cards right, defeat was the only outcome I could see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: ""It's time to break through.""*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""Ah, looking for a draw, Mr. President? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "If Lucian fell into the repetition pattern, a draw would ..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "If Lucian fell into the repetition pattern, a draw would be secured. If he managed to evade and counter, the game could still be saved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: ""You're not the only one who can play this game.""*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Taking a gamble, are we, President Rayne? Let's see where this leads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "If Lucian fell for my bold play, a miraculous victory mig..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "If Lucian fell for my bold play, a miraculous victory might be snatched from the jaws of defeat. However, if he played cautiously, my loss would be inevitable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucian Galade: ""I see your gamble, and I raise you a castle.""*)

### Węzeł `[154]`
Mówca: **Lucian Galade**
> ""Well played. But it's not over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Lucian, caught in my trap, tried to navigate his king out..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Despite Lucian's attempt to wriggle out, his king was trapped. My queen delivered the final blow, spelling a checkmate. The game was over, and I had won."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: ""It seems the king is cornered, Lucian. Good game.""*)
  - -> `[173]` (*Player: ""Checkmate, my friend. It was a well-fought battle.""*)
  - -> `[172]` (*Player: ""Your king is trapped, Lucian. The game is mine.""*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""Safety first. Your move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Lucian, sensing my defensive play, bolstered his own defe..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "With both of us refusing to risk our positions, the game ended in a stalemate. Neither side had managed to achieve victory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""It looks like neither of us could secure the victory, Lu..."*)
  - -> `[176]` (*Player: ""A stalemate, then. Quite the battle, Lucian.""*)
  - -> `[175]` (*Player: ""We've reached an impasse, Lucian. A draw it is.""*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Lucian, caught in my trap, tried to navigate his king out of the danger zone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Despite Lucian's attempt to wriggle out, his king was tra..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Lucian, sensing my defensive play, bolstered his own defenses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "With both of us refusing to risk our positions, the game ..."*)

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""You're not the only one who can play this game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Lucian tried to maneuver his king away from the repeated ..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "The checks continued, neither of us giving ground. With the position repeating three times, the game was declared a draw due to the threefold repetition rule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: ""A draw, then. You've managed to evade my checks, Lucian.""*)
  - -> `[185]` (*Player: ""Neither victory nor defeat, Lucian. A draw it is.""*)
  - -> `[184]` (*Player: ""We're at a stalemate, Lucian. It's a draw.""*)

### Węzeł `[162]`
Mówca: **Lucian Galade**
> ""I see your gamble, and I raise you a castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Lucian chose not to take the bait, instead strengthening ..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "My daring gamble fell flat. Lucian's defense was unbreakable, and I had no more tricks up my sleeve. His queen swooped in for the final checkmate. The game was over, and Lucian had won."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: ""You've seen through my gamble, Lucian. Well played.""*)
  - -> `[191]` (*Player: ""You've defended well, Lucian. It's your win.""*)
  - -> `[190]` (*Player: ""My gamble didn't pay off, Lucian. You've won.""*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Lucian tried to maneuver his king away from the repeated checks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The checks continued, neither of us giving ground. With t..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Lucian chose not to take the bait, instead strengthening his defenses against my desperate gamble."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "My daring gamble fell flat. Lucian's defense was unbreaka..."*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> ""A sacrifice in vain. I accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Lucian seized the opportunity, capturing my sacrificed kn..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "My bold move backfired. Lucian's pieces closed in, trapping my king. It was checkmate. The game was over, and Lucian had won."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: ""You've outmaneuvered me, Lucian. Well played.""*)
  - -> `[197]` (*Player: ""Your strategy was superior, Lucian. I admit defeat.""*)
  - -> `[196]` (*Player: ""You've trapped my king, Lucian. The game is yours.""*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> ""It's time to break through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Lucian decided to press his advantage, launching an aggre..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "His attack was ruthless. I couldn't withstand it. My king was cornered, and with a final, decisive move, Lucian declared checkmate. The game was over, and I had lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player: ""Your attack was relentless, Lucian. I concede.""*)
  - -> `[203]` (*Player: ""You've broken through my defenses, Lucian. It's your win.""*)
  - -> `[202]` (*Player: ""My king is cornered, Lucian. Well done.""*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Lucian seized the opportunity, capturing my sacrificed knight and strengthening his position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "My bold move backfired. Lucian's pieces closed in, trappi..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Lucian decided to press his advantage, launching an aggressive attack on my defensive shell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "His attack was ruthless. I couldn't withstand it. My king..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your king is trapped, Lucian. The game is mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""It's your win, President Rayne. You've played an impress..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Checkmate, my friend. It was a well-fought battle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: ""I see no way out. Well done, Mr. President. You've earne..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems the king is cornered, Lucian. Good game.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: ""Indeed, Mr. Rayne. You've played well. Congratulations.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've reached an impasse, Lucian. A draw it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: ""Indeed, Mr. President. It's a stalemate. Good game.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A stalemate, then. Quite the battle, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""A draw, indeed. Here is to our equally matched skills.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It looks like neither of us could secure the victory, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucian Galade: ""Yes, Mr. Rayne. It's a fitting end to a well-fought game.""*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. Rayne. You've played well. Congratulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: ""We learn more from our mistakes.""*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""I see no way out. Well done, Mr. President. You've earned this victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: ""We learn more from our mistakes.""*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""It's your win, President Rayne. You've played an impressive game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: ""We learn more from our mistakes.""*)

### Węzeł `[181]`
Mówca: **Lucian Galade**
> ""Yes, Mr. Rayne. It's a fitting end to a well-fought game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Maybe another match another time. If fate allows.""*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""A draw, indeed. Here is to our equally matched skills.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Maybe another match another time. If fate allows.""*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President. It's a stalemate. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Maybe another match another time. If fate allows.""*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're at a stalemate, Lucian. It's a draw.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucian Galade: ""It's a deadlock, Mr. President. A game well played.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Neither victory nor defeat, Lucian. A draw it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: ""Neither of us could deliver the final blow. A draw it is..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A draw, then. You've managed to evade my checks, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: ""Yes, President Rayne. It was a challenging game, leading..."*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""Yes, President Rayne. It was a challenging game, leading us to a draw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Maybe another match another time. If fate allows.""*)

### Węzeł `[188]`
Mówca: **Lucian Galade**
> ""Neither of us could deliver the final blow. A draw it is, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Maybe another match another time. If fate allows.""*)

### Węzeł `[189]`
Mówca: **Lucian Galade**
> ""It's a deadlock, Mr. President. A game well played.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Maybe another match another time. If fate allows.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My gamble didn't pay off, Lucian. You've won.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucian Galade: ""You played daringly, Mr. President. But this time, the g..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've defended well, Lucian. It's your win.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: ""Your gamble was a risky one, President Rayne. In this ca..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've seen through my gamble, Lucian. Well played.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: ""Your bold move made for an interesting endgame, Presiden..."*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> ""Your bold move made for an interesting endgame, President Rayne. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> ""Your gamble was a risky one, President Rayne. In this case, I prevailed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[195]`
Mówca: **Lucian Galade**
> ""You played daringly, Mr. President. But this time, the game is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've trapped my king, Lucian. The game is yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: ""The game was tough, Mr. President. Your defeat was not e..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your strategy was superior, Lucian. I admit defeat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: ""You played well, Mr. President. Better luck next time.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've outmaneuvered me, Lucian. Well played.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: ""Thank you, Mr. President. You've put up quite a fight.""*)

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Thank you, Mr. President. You've put up quite a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""You played well, Mr. President. Better luck next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[201]`
Mówca: **Lucian Galade**
> ""The game was tough, Mr. President. Your defeat was not easily won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My king is cornered, Lucian. Well done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: ""Your game was strong, Mr. President. But in the end, I p..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've broken through my defenses, Lucian. It's your win.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucian Galade: ""Victory wasn't easy, Mr. President. You made me work for..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your attack was relentless, Lucian. I concede.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucian Galade: ""Your defenses were tough to crack, President Rayne. Good..."*)

### Węzeł `[205]`
Mówca: **Lucian Galade**
> ""Your defenses were tough to crack, President Rayne. Good game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[206]`
Mówca: **Lucian Galade**
> ""Victory wasn't easy, Mr. President. You made me work for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[207]`
Mówca: **Lucian Galade**
> ""Your game was strong, Mr. President. But in the end, I prevailed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: ""Time well spent. We learn less from victories though.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA: "Exploit the Back Rank."]** — Mówca: **Player_Italic**
> "I moved my rook to the last rank, threatening Lucian's king with a potential back rank checkmate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Player), `[115]` (Player), `[121]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore += 1"*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "Pioneer Pawn March."]** — Mówca: **Player_Italic**
> "I boldly advanced my central pawn, paving the way for my knights and bishops to assert their dominance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Player), `[115]` (Player), `[121]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_Personal_ChessScore -= 1"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lucian Galade: ""Clever, President Rayne. But did you consider all the co..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessScore -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] = Variable["BaseGameIsolated.Turn04_Personal_ChessScore"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: ""Ah, a swift strike at the heart, Mr. President. The game..."*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> ""Ah, a swift strike at the heart, Mr. President. The game grows more interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "The center was congested, a show of Lucian's unyielding s..."*)

### Węzeł `[213]`
Mówca: **Lucian Galade**
> ""Clever, President Rayne. But did you consider all the consequences?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "The center was congested, a show of Lucian's unyielding s..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Lucian had made a bold move, pushing his pawn forward and forcing my bishop into a vulnerable position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "While the urge to secure my threatened bishop was strong,..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "While the urge to secure my threatened bishop was strong, an enticing opportunity also lay before me: a potential double attack on Lucian's king and rook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Italic: "Fortify Bishop's Stand."*)
  - -> `[110]` (*Player_Italic: "Initiate Rizian Fork."*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator), `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Italic: "Exploit the Back Rank."*)
  - -> `[209]` (*Player_Italic: "Pioneer Pawn March."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He calmly slid his queen across the board, threatening my..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Lucian moved his rook from the corner, adding pressure on..."*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> ""We learn more from our mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeLostMatch = true; BaseGam..."*)

### Węzeł `[220]`
Mówca: **Lucian Galade**
> ""Maybe another match another time. If fate allows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeDrawMatch = true; BaseGam..."*)

### Węzeł `[221]`
Mówca: **Lucian Galade**
> ""Time well spent. We learn less from victories though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeWonMatch = true; BaseGame..."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "Lucian and I slowly began to dismantle the chessboard, each piece carefully placed back into its protective casing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeWonMatch == true"*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Lucian responded to my King's Gambit with a cautious but smart move, advancing his knight to f6."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "This was the Falkbeer Counter Gambit, directly attacking ..."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "As a response to my Xinan Defense, Lucian surprised me by opting for the Open Xinan, advancing his pawn to d4."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "He was pushing for control of the center early, looking t..."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "This was the Falkbeer Counter Gambit, directly attacking my e4 pawn while leaving my f4 pawn hanging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[228]` (*Player: ""A Falkbeer Counter Gambit, Lucian? You certainly know ho..."*)
  - -> `[226]` (*Player: ""Your move shows your experience, Lucian. This game is sh..."*)
  - -> `[227]` (*Player: ""I see you aren't one to back down from a challenge, Luci..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your move shows your experience, Lucian. This game is shaping up to be quite a match.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Lucian Galade: ""I wouldn't expect anything less from you, Mr. President.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see you aren't one to back down from a challenge, Lucian. Very well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucian Galade: ""It wouldn't be much of a game if I did, now would it, Mr..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Falkbeer Counter Gambit, Lucian? You certainly know how to keep things interesting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Lucian Galade: ""One does try, Mr. Rayne. It's your move.""*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Italic: "Defend the Pawn."*)
  - -> `[234]` (*Player_Italic: "Push the Pawn."*)

### Węzeł `[230]`
Mówca: **Lucian Galade**
> ""One does try, Mr. Rayne. It's your move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Italic: "Defend the Pawn."*)
  - -> `[234]` (*Player_Italic: "Push the Pawn."*)

### Węzeł `[231]`
Mówca: **Lucian Galade**
> ""I wouldn't expect anything less from you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Italic: "Defend the Pawn."*)
  - -> `[234]` (*Player_Italic: "Push the Pawn."*)

### Węzeł `[232]`
Mówca: **Lucian Galade**
> ""It wouldn't be much of a game if I did, now would it, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Italic: "Defend the Pawn."*)
  - -> `[234]` (*Player_Italic: "Push the Pawn."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: "Defend the Pawn."]** — Mówca: **Player_Italic**
> "I moved my knight to f3, defending my threatened e4 pawn while also preparing to castle on the next move."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Italic), `[230]` (Lucian Galade), `[231]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "Push the Pawn."]** — Mówca: **Player_Italic**
> "I pushed my e-pawn to e5, pressurizing Lucian's knight and attempting to gain control of the center."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Italic), `[230]` (Lucian Galade), `[231]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "He was pushing for control of the center early, looking to turn the game into a tactical melee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Italic: "Keep playing and don't comment."*)
  - -> `[238]` (*Player: ""The Open Xinan, Lucian? You're certainly not shy about y..."*)
  - -> `[236]` (*Player: ""Bold strategy, Lucian. It seems we're in for a battle of..."*)
  - -> `[237]` (*Player: ""I see you're trying to seize the center early, Lucian. T..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bold strategy, Lucian. It seems we're in for a battle of tactics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucian Galade: ""That's the essence of chess, Mr. President.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see you're trying to seize the center early, Lucian. That's an aggressive play.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: ""Aggression can be a key to victory, Mr. Rayne.""*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Open Xinan, Lucian? You're certainly not shy about your intentions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lucian Galade: ""Why hide, Mr. Rayne? Chess is a game of strategy and con..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Italic: "Exchange the Pawn."*)
  - -> `[244]` (*Player_Italic: "Develop the Knight."*)

### Węzeł `[240]`
Mówca: **Lucian Galade**
> ""Why hide, Mr. Rayne? Chess is a game of strategy and confrontation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Italic: "Exchange the Pawn."*)
  - -> `[244]` (*Player_Italic: "Develop the Knight."*)

### Węzeł `[241]`
Mówca: **Lucian Galade**
> ""That's the essence of chess, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Italic: "Exchange the Pawn."*)
  - -> `[244]` (*Player_Italic: "Develop the Knight."*)

### Węzeł `[242]`
Mówca: **Lucian Galade**
> ""Aggression can be a key to victory, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Italic: "Exchange the Pawn."*)
  - -> `[244]` (*Player_Italic: "Develop the Knight."*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "Exchange the Pawn."]** — Mówca: **Player_Italic**
> "I opted for an early exchange, capturing Lucian's pawn with my c5 pawn, aiming to equalize the position."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Player_Italic), `[240]` (Lucian Galade), `[241]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: "Develop the Knight."]** — Mówca: **Player_Italic**
> "I developed my knight to f6, placing pressure on the advanced pawn and preparing for my own pawn advance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Player_Italic), `[240]` (Lucian Galade), `[241]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "Press the Center."]** — Mówca: **Player_Italic**
> "Seeing Lucian's strategy unfold, I decided to assert control over the center. Moving my pawn from e5 to e3, I prepared to challenge his dominance on the board."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lucian Galade), `[74]` (Lucian Galade), `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: "Castle Kingside."]** — Mówca: **Player_Italic**
> "I decided to mirror Lucian's strategy, moving my king to safety. I moved my king two squares towards the rook and switched the rook to the other side, completing a kingside castle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lucian Galade), `[74]` (Lucian Galade), `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA: "Bishop's Threat."]** — Mówca: **Player_Italic**
> "Responding to Lucian's decision to fianchetto, I moved my bishop from f8 to c5, threatening his pawn structure."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade), `[77]` (Lucian Galade), `[78]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA: "Knight's Advance."]** — Mówca: **Player_Italic**
> "In response to Lucian's fianchetto, I advanced my knight from b8 to c6, aiming to control more of the board."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade), `[77]` (Lucian Galade), `[78]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "With this, the stage was set. The opening maneuvers had t..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeLostMatch = true; BaseGameSupport.Journal_Turn04_LucianChess_Won = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_GaladeLostMatch"] = true;
Variable["BaseGameSupport.Journal_Turn04_LucianChess_Won"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Lucian and I slowly began to dismantle the chessboard, ea..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeDrawMatch = true; BaseGameSupport.Journal_Turn04_LucianChess_Draw = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_GaladeDrawMatch"] = true;
Variable["BaseGameSupport.Journal_Turn04_LucianChess_Draw"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Lucian and I slowly began to dismantle the chessboard, ea..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeWonMatch = true;
BaseGameSupport.Journal_Turn04_LucianChess_Lose = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_GaladeWonMatch"] = true;
Variable["BaseGameSupport.Journal_Turn04_LucianChess_Lose"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Lucian and I slowly began to dismantle the chessboard, ea..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Italic: "Bishop's Threat."*)
  - -> `[248]` (*Player_Italic: "Knight's Advance."*)

### Węzeł `[253]`
**[WYBÓR GRACZA: "Keep playing and don't comment."]** — Mówca: **Player_Italic**
> "I kept playing without commenting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Italic: "Press the Center."*)
  - -> `[246]` (*Player_Italic: "Castle Kingside."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeDrawMatch == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_GaladeDrawMatch == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_GaladeDrawMatch == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_GaladeDrawMatch == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_GaladeDrawMatch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Lucian maintained a steady gaze, his face unreadable."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_GaladeDrawMatch == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_GaladeDrawMatch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Lucian's eyes bore a far-off look. Perhaps he was replayi..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Lucian's eyes bore a far-off look. Perhaps he was replaying the match within his mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "He picked up a knight and turned it over in his hand thou..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "He picked up a knight and turned it over in his hand thoughtfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: ""A difficult game, chess. The constant threats and counte..."*)

### Węzeł `[259]`
Mówca: **Narrator**
> "The chess match seemed to have left him thoughtful, his mind perhaps mulling over the moves he could have made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lucian Galade: ""This game always reminds me of the delicate balance we h..."*)

### Węzeł `[260]`
Mówca: **Lucian Galade**
> ""This game always reminds me of the delicate balance we had to strike in the days of the old Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucian Galade: ""It was not always a simple task.""*)

### Węzeł `[261]`
Mówca: **Lucian Galade**
> ""A difficult game, chess. The constant threats and counter-threats take me back to some similarly challenging times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: ""Sounds like you've had quite the complicated past.""*)
  - -> `[268]` (*Player: ""Was there a particular challenge that still resonates?""*)
  - -> `[267]` (*Player: ""Threats and counter-threats... your past seems a lot mor..."*)

### Węzeł `[262]`
Mówca: **Lucian Galade**
> ""Although the situation there was rarely as black and white.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: ""Tell me more. Did chess play a part in your youth?""*)
  - -> `[265]` (*Player: ""Strategical intricacies, eh? Sounds like you've got some..."*)
  - -> `[264]` (*Player: ""You certainly know how to keep things interesting, Lucia..."*)

### Węzeł `[263]`
Mówca: **Lucian Galade**
> ""It was not always a simple task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player: ""Balance in the days of the old Kingdom? Lucian, have you..."*)
  - -> `[271]` (*Player: ""I can't help but wonder what kind of situations you had ..."*)
  - -> `[270]` (*Player: ""This balance you speak of, Lucian, it seems to hint at s..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You certainly know how to keep things interesting, Lucian. Your past seems to be a well-guarded secret.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: ""In a way, chess prepared me for some of the challenges I..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Strategical intricacies, eh? Sounds like you've got some interesting stories about that career. Care to share one?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: ""In a way, chess prepared me for some of the challenges I..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me more. Did chess play a part in your youth?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: ""In a way, chess prepared me for some of the challenges I..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Threats and counter-threats... your past seems a lot more interesting than mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lucian Galade: ""We all have our pasts, Mr. President.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Was there a particular challenge that still resonates?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lucian Galade: ""We all have our pasts, Mr. President.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sounds like you've had quite the complicated past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lucian Galade: ""We all have our pasts, Mr. President.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This balance you speak of, Lucian, it seems to hint at some intriguing aspects of your past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: ""Some things from those days are better left unsaid. I wi..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can't help but wonder what kind of situations you had to navigate, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: ""Some things from those days are better left unsaid. I wi..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Balance in the days of the old Kingdom? Lucian, have you been holding back some history from me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: ""Some things from those days are better left unsaid. I wi..."*)

### Węzeł `[273]`
Mówca: **Lucian Galade**
> ""In a way, chess prepared me for some of the challenges I faced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Lucian Galade: ""I was involved in some complex situations, where every m..."*)

### Węzeł `[274]`
Mówca: **Lucian Galade**
> ""I was involved in some complex situations, where every move could drastically alter the landscape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: ""Complex situations, you say? Sounds like you've dealt wi..."*)
  - -> `[279]` (*Player: ""Every move altering the landscape? Your early career mus..."*)

### Węzeł `[275]`
Mówca: **Lucian Galade**
> ""Some things from those days are better left unsaid. I will say there was a certain...duality to those times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lucian Galade: ""Chess is not the only game where one has to maintain a b..."*)

### Węzeł `[276]`
Mówca: **Lucian Galade**
> ""Chess is not the only game where one has to maintain a balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player: ""It sounds like you were in the thick of it.""*)
  - -> `[283]` (*Player: ""Duality? Were you juggling multiple roles?""*)

### Węzeł `[277]`
Mówca: **Lucian Galade**
> ""We all have our pasts, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucian Galade: ""Mine happened to involve many moves and counter-moves, e..."*)

### Węzeł `[278]`
Mówca: **Lucian Galade**
> ""Mine happened to involve many moves and counter-moves, each with its own consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""Moves and counter-moves? So you've seen your share of co..."*)
  - -> `[281]` (*Player: ""Were these consequences a part of the old Kingdom's fina..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Every move altering the landscape? Your early career must have been quite eventful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucian Galade: ""Indeed, Mr. President. My past isn't without its share o..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Complex situations, you say? Sounds like you've dealt with a lot of tough decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucian Galade: ""Indeed, Mr. President. My past isn't without its share o..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Were these consequences a part of the old Kingdom's final years, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucian Galade: ""Yes, Mr. President, those were trying times for Sordland..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Moves and counter-moves? So you've seen your share of conflict.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucian Galade: ""Yes, Mr. President, those were trying times for Sordland..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Duality? Were you juggling multiple roles?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucian Galade: ""Mr. President, the old Kingdom was a cauldron of shiftin..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It sounds like you were in the thick of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucian Galade: ""Mr. President, the old Kingdom was a cauldron of shiftin..."*)

### Węzeł `[285]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President. My past isn't without its share of shadows. There was a time when I served in a capacity that wasn't so... straightforward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucian Galade: ""I danced on a knife-edge, every step carrying deep conse..."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Lucian's gaze dropped to his empty glass as he fell into a moment of quiet introspection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player: ""I certainly don't wish to delve into matters that might ..."*)
  - -> `[294]` (*Player: ""Can you tell me more about this... different capacity yo..."*)
  - -> `[293]` (*Player: ""You're beginning to intrigue me, Lucian. What are you no..."*)

### Węzeł `[287]`
Mówca: **Lucian Galade**
> ""Mr. President, the old Kingdom was a cauldron of shifting alliances and loyalties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lucian Galade: ""Let's just say I was one of many who had to navigate tho..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Lucian shut the chess box with a soft click. He seemed unwilling to say more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player: ""Treacherous waters... were you a naval officer?""*)
  - -> `[299]` (*Player: ""We've known each other for years, and that's all I get?""*)
  - -> `[301]` (*Player: ""I certainly don't wish to delve into matters that might ..."*)

### Węzeł `[289]`
Mówca: **Lucian Galade**
> ""Yes, Mr. President, those were trying times for Sordland. And like many others, I was caught in the crossfire of those tumultuous years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "A shadow seemed to pass over Lucian's eyes, a hint of the..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "A shadow seemed to pass over Lucian's eyes, a hint of the turmoil that still lingered in his memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player: ""I certainly don't wish to delve into matters that might ..."*)
  - -> `[303]` (*Player: ""Caught in the crossfire... were you in the military?""*)
  - -> `[302]` (*Player: ""What sort of conflicts are we talking about?""*)

### Węzeł `[291]`
Mówca: **Lucian Galade**
> ""I can tell you that there were instances where I found myself in the midst of... let's call it, intelligence work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucian Galade: ""It was a complex dance, rife with deception and shadows.""*)

### Węzeł `[292]`
Mówca: **Lucian Galade**
> ""I danced on a knife-edge, every step carrying deep consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Lucian's gaze dropped to his empty glass as he fell into ..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're beginning to intrigue me, Lucian. What are you not telling me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucian Galade: ""I can tell you that there were instances where I found m..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can you tell me more about this... different capacity you served in?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucian Galade: ""I can tell you that there were instances where I found m..."*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I certainly don't wish to delve into matters that might unsettle you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lucian Galade: ""I've reconciled with my past, sir. I don't shy away from..."*)

### Węzeł `[296]`
Mówca: **Lucian Galade**
> ""I've reconciled with my past, sir. I don't shy away from sharing aspects of it with those I trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucian Galade: ""I can tell you that there were instances where I found m..."*)

### Węzeł `[297]`
Mówca: **Lucian Galade**
> ""It was a complex dance, rife with deception and shadows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: ""You were involved in intelligence work, Lucian? That's c..."*)
  - -> `[309]` (*Player: ""Cut the metaphors, Lucian. I want details.""*)
  - -> `[308]` (*Player: ""So you were a spy? Sounds fascinating.""*)

### Węzeł `[298]`
Mówca: **Lucian Galade**
> ""Let's just say I was one of many who had to navigate those treacherous waters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Lucian shut the chess box with a soft click. He seemed un..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've known each other for years, and that's all I get?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Lucian Galade: ""It's a discussion for another day, Mr. President. Suffic..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Treacherous waters... were you a naval officer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Lucian Galade: ""It's a discussion for another day, Mr. President. Suffic..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I certainly don't wish to delve into matters that might unsettle you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator), `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucian Galade: ""I've reconciled with my past and set it aside.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What sort of conflicts are we talking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucian Galade: ""It is not my intent to withhold information from you. Bu..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Caught in the crossfire... were you in the military?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucian Galade: ""It is not my intent to withhold information from you. Bu..."*)

### Węzeł `[304]`
Mówca: **Lucian Galade**
> ""It is not my intent to withhold information from you. But I believe we should focus on the future of Sordland, and leave its history where it belongs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Lucian Galade: ""On that note, it's time for me to depart. I thoroughly e..."*)

### Węzeł `[305]`
Mówca: **Lucian Galade**
> ""It's a discussion for another day, Mr. President. Suffice to say, it was a time when Sordland was a battleground of older ideals and ambitions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lucian Galade: ""My role? Let's just say I was one of the pieces on the b..."*)

### Węzeł `[306]`
Mówca: **Lucian Galade**
> ""My role? Let's just say I was one of the pieces on the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucian Galade: ""It is not my intent to withhold information from you. Bu..."*)

### Węzeł `[307]`
Mówca: **Lucian Galade**
> ""I've reconciled with my past and set it aside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucian Galade: ""It is not my intent to withhold information from you. Bu..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you were a spy? Sounds fascinating.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Lucian Galade: ""'Spy' is a simplistic term, Mr. President. My past roles..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Cut the metaphors, Lucian. I want details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Lucian Galade: ""There's much I still cannot say. But I carried out some ..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You were involved in intelligence work, Lucian? That's certainly an unexpected revelation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Lucian Galade: ""It's true, sir. During the late Kingdom era, I found mys..."*)

### Węzeł `[311]`
Mówca: **Lucian Galade**
> ""It's true, sir. During the late Kingdom era, I found myself part of King Egmund's intelligence service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucian Galade: ""In a manner many would find... objectionable.""*)

### Węzeł `[312]`
Mówca: **Lucian Galade**
> ""In a manner many would find... objectionable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Lucian Galade: ""Much as I'd love to elaborate, I must take my leave. Tha..."*)

### Węzeł `[313]`
Mówca: **Lucian Galade**
> ""There's much I still cannot say. But I carried out some unconventional assignments for King Egmund.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Lucian Galade: ""I served in a capacity that often demanded... morally ch..."*)

### Węzeł `[314]`
Mówca: **Lucian Galade**
> ""I served in a capacity that often demanded... morally challenging choices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Lucian Galade: ""Much as I'd love to elaborate, I must take my leave. Tha..."*)

### Węzeł `[315]`
Mówca: **Lucian Galade**
> ""'Spy' is a simplistic term, Mr. President. My past roles were, let's say, less than conventional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Lucian Galade: ""I served for the national interests of King Egmund.""*)

### Węzeł `[316]`
Mówca: **Lucian Galade**
> ""I served for the national interests of King Egmund.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Lucian Galade: ""Much as I'd love to elaborate, I must take my leave. Tha..."*)

### Węzeł `[317]`
Mówca: **Lucian Galade**
> ""Much as I'd love to elaborate, I must take my leave. Thank you for the delightful match.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player: ""Thank you, Lucian. The match was indeed captivating.""*)
  - -> `[320]` (*Player: ""Delightful for you, maybe. I demand a rematch.""*)
  - -> `[319]` (*Player: ""It's always a pleasure to witness your strategic prowess.""*)

### Węzeł `[318]`
Mówca: **Lucian Galade**
> ""On that note, it's time for me to depart. I thoroughly enjoyed our match tonight, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: ""Indeed, the game was a great pleasure, Lucian. Safe trav..."*)
  - -> `[323]` (*Player: ""As did I. The game was as enlightening as it was enterta..."*)
  - -> `[322]` (*Player: ""That's very gracious of you.""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's always a pleasure to witness your strategic prowess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucian Galade: ""I hope to play again soon. Though I cannot promise the o..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Delightful for you, maybe. I demand a rematch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucian Galade: ""I hope to play again soon. Though I cannot promise the o..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Lucian. The match was indeed captivating.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucian Galade: ""I hope to play again soon. Though I cannot promise the o..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's very gracious of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucian Galade: ""Win or lose, there's always something to be learned from..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As did I. The game was as enlightening as it was entertaining.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucian Galade: ""Win or lose, there's always something to be learned from..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Indeed, the game was a great pleasure, Lucian. Safe travels home.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucian Galade: ""Win or lose, there's always something to be learned from..."*)

### Węzeł `[325]`
Mówca: **Lucian Galade**
> ""I hope to play again soon. Though I cannot promise the outcome will be any different for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "He smiled."*)

### Węzeł `[326]`
Mówca: **Lucian Galade**
> ""Win or lose, there's always something to be learned from a round of chess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Lucian Galade: ""Good night, Mr. President.""*)

### Węzeł `[327]`
Mówca: **Narrator**
> "As Lucian exited the room, the memories of our game lingered, as did the enigmatic aura of the man himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucian Galade");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "As Lucian exited the room, the memories of our game linge..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucian Galade");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucian Galade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "As Lucian departed, I thought about what he'd told me. I'..."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Lucian Galade: ""Good night, Mr. President.""*)

### Węzeł `[331]`
Mówca: **Lucian Galade**
> ""Good night, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucian Galade");"*)

### Węzeł `[332]`
Mówca: **Lucian Galade**
> ""Good night, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucian Galade");"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Livia Suno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""I hope you remember that it's not always the king who ho..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Playing a chess match with their top advisor", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Playing a chess match with their top advisor","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucian Galade");"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_Personal_ChessPickBlack = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_Personal_ChessPickBlack"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "With the sides chosen, Lucian sat back, his fingers laced..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "A few minutes passed and a few more actions were made on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Lucian's response came in the form of a g2 to g3 pawn mov..."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "A few minutes passed and a few more actions were made on the board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Lucian's next move was calculated and swift. The bishop g..."*)
