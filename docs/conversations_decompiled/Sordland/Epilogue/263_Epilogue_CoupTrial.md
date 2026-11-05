# Sordland/Epilogue_CoupTrial

- **ID konwersacji:** `263`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_CoupTrial)`
- **Lokalizacja pliku:** `Sordland/Epilogue/263_Epilogue_CoupTrial.md`
- **Liczba węzłów dialogowych:** 135
- **Liczba wyborów gracza:** 66

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Franc_Died`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_BFF_Deal_Signed`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"1958\|Supreme Court of Sordland"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Player**: "...blamed only yourself."<br>`[9]` **Player**: "...were angry at everyone who be..."<br>*(oraz 1 innych odgałęzień)* |
| `[4]` | **"...did your best for Sordland. No matter what."** | `[3]` **Narrator**: "Valken Kruger tapped the gavel. ..."<br>`[5]` **Narrator**: "Iosef Lancea tapped the gavel. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "The next words you heard were "I..." |
| `[5]` | **"1958\|Supreme Court of Sordland"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Player**: "...blamed only yourself."<br>`[9]` **Player**: "...were angry at everyone who be..."<br>*(oraz 1 innych odgałęzień)* |
| `[7]` | **"...worried about the future of your family."** | `[13]` **Narrator**: "But he wasn't done speaking.  "F..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[55]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[17]` **Narrator**: "Your cell was cold and lonely. T..." |
| `[8]` | **"...declared that you would take revenge."** | `[13]` **Narrator**: "But he wasn't done speaking.  "F..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[55]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[17]` **Narrator**: "Your cell was cold and lonely. T..." |
| `[9]` | **"...were angry at everyone who betrayed you."** | `[3]` **Narrator**: "Valken Kruger tapped the gavel. ..."<br>`[5]` **Narrator**: "Iosef Lancea tapped the gavel. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "The next words you heard were "I..." |
| `[10]` | **"...blamed only yourself."** | `[3]` **Narrator**: "Valken Kruger tapped the gavel. ..."<br>`[5]` **Narrator**: "Iosef Lancea tapped the gavel. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "The next words you heard were "I..." |
| `[11]` | **"...the victim of yet another one of Sordland's coups."** | `[6]` **Narrator**: "The next words you heard were "I..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_gavel");` | `[39]` **Narrator**: "But he wasn't finished speaking...."<br>`[13]` **Narrator**: "But he wasn't done speaking.  "F..." |
| `[14]` | **"Your whole world fell apart."** | `[120]` **Narrator**: "The warden paid you a visit to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "After 7 years in jail, Sordland'..." |
| `[15]` | **"...accepted your fate."** | `[13]` **Narrator**: "But he wasn't done speaking.  "F..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[55]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[17]` **Narrator**: "Your cell was cold and lonely. T..." |
| `[16]` | **"...congratulated him."** | `[28]` **Narrator**: "Franc visited you for the first ..."<br>`[33]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "After 7 years in jail, Sordland'..." |
| `[17]` | **"1959\|Antel Rock Prison"** | `[7]` **Player**: "...worried about the future of y..."<br>`[8]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | *Brak zmian stanu* | `[57]` **Player**: "Time flies in jail." |
| `[18]` | **"...cried like a child."** | `[23]` **Narrator**: "He covered your eyes and stepped..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The gunshots were the last thing..." |
| `[19]` | **"...defiantly stood proud and strong."** | `[23]` **Narrator**: "He covered your eyes and stepped..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The gunshots were the last thing..." |
| `[20]` | **"...felt relaxed. It was finally over."** | `[23]` **Narrator**: "He covered your eyes and stepped..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The gunshots were the last thing..." |
| `[21]` | **"1958\|Antel Rock Prison"** | `[41]` **Player**: "...worried about the future of y..."<br>`[42]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[63]` **Player**: "The week was over." |
| `[22]` | **"And so Anton Rayne was no more."** | `[12]` **Narrator**: "The gunshots were the last thing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[24]` | **""Go to hell.""** | `[29]` **Narrator**: "He asked you if you had any last..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "He covered your eyes and stepped..." |
| `[25]` | **""A Morgna wes core! Vectern sis da!""** | `[29]` **Narrator**: "He asked you if you had any last..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "He covered your eyes and stepped..." |
| `[26]` | **""I regret nothing.""** | `[29]` **Narrator**: "He asked you if you had any last..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "He covered your eyes and stepped..." |
| `[27]` | **"1958\|Antel Rock Prison"** | `[41]` **Player**: "...worried about the future of y..."<br>`[42]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | *Brak zmian stanu* | `[63]` **Player**: "The week was over." |
| `[28]` | **"1964\|Antel Rock Prison"** | `[79]` **Player**: "...hoped that someone would hang..."<br>`[83]` **Player**: "...hoped that someone would hang..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false` | *Brak zmian stanu* | `[38]` **Player**: "...said you were worried for his..."<br>`[30]` **Player**: "...told him not to get too deep ..."<br>*(oraz 1 innych odgałęzień)* |
| `[30]` | **"...told him not to get too deep into politics."** | `[28]` **Narrator**: "Franc visited you for the first ..."<br>`[33]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "After 7 years in jail, Sordland'..." |
| `[31]` | **"Accept your death."** | `[37]` **Narrator**: "The squad of soldiers turned the..."<br>`[74]` **Narrator**: "The squad of soldiers turned the..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[29]` **Narrator**: "He asked you if you had any last..." |
| `[32]` | **"Beg Iosef to free you."** | `[37]` **Narrator**: "The squad of soldiers turned the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "He asked you if you had any last..." |
| `[33]` | **"1964\|Antel Rock Prison"** | `[79]` **Player**: "...hoped that someone would hang..."<br>`[83]` **Player**: "...hoped that someone would hang..." | `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false` | *Brak zmian stanu* | `[38]` **Player**: "...said you were worried for his..."<br>`[30]` **Player**: "...told him not to get too deep ..."<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **"...said you were worried for his future."** | `[28]` **Narrator**: "Franc visited you for the first ..."<br>`[33]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "After 7 years in jail, Sordland'..." |
| `[40]` | **"You heard the footsteps of soldiers approaching."** | `[50]` **Narrator**: "You were dragged outside after y..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_execution");` | `[37]` **Narrator**: "The squad of soldiers turned the..."<br>`[74]` **Narrator**: "The squad of soldiers turned the..." |
| `[41]` | **"...worried about the future of your family."** | `[39]` **Narrator**: "But he wasn't finished speaking...." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[21]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[27]` **Narrator**: "Your cell was cold and lonely. Y..." |
| `[42]` | **"...declared that you would take revenge."** | `[39]` **Narrator**: "But he wasn't finished speaking...." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[21]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[27]` **Narrator**: "Your cell was cold and lonely. Y..." |
| `[43]` | **"...accepted your fate."** | `[39]` **Narrator**: "But he wasn't finished speaking...." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[21]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[27]` **Narrator**: "Your cell was cold and lonely. Y..." |
| `[54]` | **"1964\|Antel Rock Prison"** | `[79]` **Player**: "...hoped that someone would hang..."<br>`[83]` **Player**: "...hoped that someone would hang..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true` | *Brak zmian stanu* | `[38]` **Player**: "...said you were worried for his..."<br>`[30]` **Player**: "...told him not to get too deep ..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **"1959\|Antel Rock Prison"** | `[7]` **Player**: "...worried about the future of y..."<br>`[8]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[57]` **Player**: "Time flies in jail." |
| `[56]` | **"...a bottle of whiskey."** | `[67]` **Narrator**: "The day of your execution had ar..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[50]` **Narrator**: "You were dragged outside after y..." |
| `[57]` | **"Time flies in jail."** | `[17]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[55]` **Narrator**: "Your cell was cold and lonely. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "You learned in prison that after..." |
| `[58]` | **"...a hearty and healthy breakfast."** | `[67]` **Narrator**: "The day of your execution had ar..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[50]` **Narrator**: "You were dragged outside after y..." |
| `[59]` | **"...the largest, bloodiest steak he could find."** | `[67]` **Narrator**: "The day of your execution had ar..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[50]` **Narrator**: "You were dragged outside after y..." |
| `[63]` | **"The week was over."** | `[21]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[27]` **Narrator**: "Your cell was cold and lonely. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "The day of your execution had ar..." |
| `[67]` | **"1958\|Day of the Execution\|Antel Rock Prison"** | `[63]` **Player**: "The week was over." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Player**: "...the largest, bloodiest steak ..."<br>`[58]` **Player**: "...a hearty and healthy breakfast."<br>*(oraz 1 innych odgałęzień)* |
| `[75]` | **"Beg Valken to free you."** | `[74]` **Narrator**: "The squad of soldiers turned the..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[29]` **Narrator**: "He asked you if you had any last..." |
| `[76]` | **"1960"** | `[57]` **Player**: "Time flies in jail." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: "...did not care much."<br>`[78]` **Player**: "...thought that this could be yo..."<br>*(oraz 2 innych odgałęzień)* |
| `[77]` | **"...did not care much."** | `[76]` **Narrator**: "You learned in prison that after..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[54]` **Narrator**: "Franc visited you for the first ..."<br>`[28]` **Narrator**: "Franc visited you for the first ..." |
| `[78]` | **"...thought that this could be your way out."** | `[76]` **Narrator**: "You learned in prison that after..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[54]` **Narrator**: "Franc visited you for the first ..."<br>`[28]` **Narrator**: "Franc visited you for the first ..." |
| `[79]` | **"...hoped that someone would hang Iosef for his crimes."** | `[76]` **Narrator**: "You learned in prison that after..." | `Variable["BaseGame.Relations_Iosef_Enemy"] == true` | *Brak zmian stanu* | `[54]` **Narrator**: "Franc visited you for the first ..."<br>`[28]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **"...hoped that someone would hang Valken for his crimes."** | `[76]` **Narrator**: "You learned in prison that after..." | `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false` | *Brak zmian stanu* | `[54]` **Narrator**: "Franc visited you for the first ..."<br>`[28]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych odgałęzień)* |
| `[84]` | **"1965"** | `[14]` **Player**: "Your whole world fell apart."<br>`[16]` **Player**: "...congratulated him."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had grown old." |
| `[85]` | **"You had grown old."** | `[84]` **Narrator**: "After 7 years in jail, Sordland'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "You took your first step outside..."<br>`[94]` **Narrator**: "You took your first step outside..."<br>*(oraz 2 innych odgałęzień)* |
| `[86]` | **"1967"** | `[100]` **Player**: "The years haven't been kind to you."<br>`[101]` **Player**: "But they hadn't been kind to you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "...have another shot at politics."<br>`[103]` **Player**: "...retire to the countryside."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **"The years haven't been kind to you."** | `[87]` **Narrator**: "You took your first step outside..."<br>`[94]` **Narrator**: "You took your first step outside..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[86]` **Narrator**: "Getting used to being a free man..." |
| `[101]` | **"But they hadn't been kind to you either."** | `[95]` **Narrator**: "You took your first step outside..."<br>`[96]` **Narrator**: "You took your first step outside..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[86]` **Narrator**: "Getting used to being a free man..." |
| `[102]` | **"...have another shot at politics."** | `[86]` **Narrator**: "Getting used to being a free man..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "You tried to get back into polit..." |
| `[103]` | **"...retire to the countryside."** | `[86]` **Narrator**: "Getting used to being a free man..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "Life was good.  You took up vari..." |
| `[104]` | **"...find an earnest job."** | `[86]` **Narrator**: "Getting used to being a free man..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Life was good.  You took up wood..." |
| `[105]` | **"1973"** | `[102]` **Player**: "...have another shot at politics." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Player**: "At least you were free." |
| `[106]` | **"1973"** | `[103]` **Player**: "...retire to the countryside." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Player**: "You had all the time in the world." |
| `[107]` | **"At least you were free."** | `[105]` **Narrator**: "You tried to get back into polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[111]` **Narrator**: "A week after your 66th birthday,..." |
| `[108]` | **"1973"** | `[104]` **Player**: "...find an earnest job." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Player**: "You had to get by somehow." |
| `[109]` | **"You had all the time in the world."** | `[106]` **Narrator**: "Life was good.  You took up vari..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[111]` **Narrator**: "A week after your 66th birthday,..." |
| `[110]` | **"You had to get by somehow."** | `[108]` **Narrator**: "Life was good.  You took up wood..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[111]` **Narrator**: "A week after your 66th birthday,..." |
| `[111]` | **"1974"** | `[107]` **Player**: "At least you were free."<br>`[109]` **Player**: "You had all the time in the world."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Player**: "...just wanted to finally have p..."<br>`[113]` **Player**: "...helped her as best as you could." |
| `[112]` | **"...just wanted to finally have peace of mind."** | `[111]` **Narrator**: "A week after your 66th birthday,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "After many hours of interviews, ..." |
| `[113]` | **"...helped her as best as you could."** | `[111]` **Narrator**: "A week after your 66th birthday,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "After many hours of interviews, ..." |
| `[115]` | **"You wondered why."** | `[114]` **Narrator**: "After many hours of interviews, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "You heard a knock on your door. ..." |
| `[117]` | **"You picked up the book."** | `[116]` **Narrator**: "You heard a knock on your door. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "It was titled Suzerain: The Stor..." |
| `[119]` | **"You faintly smiled."** | `[118]` **Narrator**: "It was titled Suzerain: The Stor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[120]` | **"1964\|Antel Rock Prison"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Player**: "Your whole world fell apart." |

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
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "Valken Kruger tapped the gavel. The sound echoed in the empty courtroom.

He rose from his seat.

Knowing what was coming next, you felt that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "...blamed only yourself."*)
  - -> `[9]` (*Player: "...were angry at everyone who betrayed you."*)
  - -> `[4]` (*Player: "...did your best for Sordland. No matter what."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best for Sordland. No matter what."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The next words you heard were "I hereby decide that you a..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "Iosef Lancea tapped the gavel. The sound echoed in the empty courtroom.

He rose from his seat.

Knowing what was coming next, you felt that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "...blamed only yourself."*)
  - -> `[9]` (*Player: "...were angry at everyone who betrayed you."*)
  - -> `[4]` (*Player: "...did your best for Sordland. No matter what."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The next words you heard were "I hereby decide that you are guilty."

You thought about how you would go down in history as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "...the victim of yet another one of Sordland's coups."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were angry at everyone who betrayed you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The next words you heard were "I hereby decide that you a..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...blamed only yourself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The next words you heard were "I hereby decide that you a..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the victim of yet another one of Sordland's coups."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_gavel");"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The gunshots were the last thing you ever heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "But he wasn't done speaking.

"For the magnitude of the crimes you have committed against Sordland, I am sentencing you to life in prison."

Soldiers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "...worried about the future of your family."*)
  - -> `[8]` (*Player: "...declared that you would take revenge."*)
  - -> `[15]` (*Player: "...accepted your fate."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your whole world fell apart."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "1965"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...congratulated him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator), `[33]` (Narrator), `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "1965"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading was the only thing you could do. After finishing the precious books sent by Monica, you kept yourself busy by writing your own memoir.

You were happy that at least your family was allowed to visit once a month."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Player), `[8]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "Time flies in jail."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cried like a child."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The gunshots were the last thing you ever heard."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...defiantly stood proud and strong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The gunshots were the last thing you ever heard."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...felt relaxed. It was finally over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The gunshots were the last thing you ever heard."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. A week remained until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

Monica visited you only once, along with the kids."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Player), `[42]` (Player), `[43]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "The week was over."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "And so Anton Rayne was no more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He covered your eyes and stepped back. 

After a moment, you heard the sounds of the guns being cocked.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "...defiantly stood proud and strong."*)
  - -> `[18]` (*Player: "...cried like a child."*)
  - -> `[20]` (*Player: "...felt relaxed. It was finally over."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Go to hell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He covered your eyes and stepped back.   After a moment, ..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core! Vectern sis da!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He covered your eyes and stepped back.   After a moment, ..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I regret nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He covered your eyes and stepped back.   After a moment, ..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. You had a week until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

You were happy that at least your family was allowed to visit you every day."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[41]` (Player), `[42]` (Player), `[43]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "The week was over."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he had joined the ranks of the Communist Party of Sordland. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Player), `[83]` (Player), `[77]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...said you were worried for his future."*)
  - -> `[30]` (*Player: "...told him not to get too deep into politics."*)
  - -> `[16]` (*Player: "...congratulated him."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "He asked you if you had any last words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""A Morgna wes core! Vectern sis da!""*)
  - -> `[26]` (*Player: ""I regret nothing.""*)
  - -> `[24]` (*Player: ""Go to hell.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told him not to get too deep into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator), `[33]` (Narrator), `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "1965"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Accept your death."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator), `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Beg Iosef to free you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He asked you if you had any last words."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he was now a senior army official on a track to the higher ranks. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Player), `[83]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...said you were worried for his future."*)
  - -> `[30]` (*Player: "...told him not to get too deep into politics."*)
  - -> `[16]` (*Player: "...congratulated him."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "But he wasn't finished speaking.  "For the magnitude of t..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "But he wasn't done speaking.  "For the magnitude of the c..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The squad of soldiers turned the corner and lined up across from you. At the head of the line was their commander, Iosef.

He checked his watch and declared that the time had come. 

He pulled out a cloth to cover your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "Beg Iosef to free you."*)
  - -> `[31]` (*Player: "Accept your death."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were worried for his future."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator), `[33]` (Narrator), `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "1965"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "But he wasn't finished speaking.

"For the magnitude of the crimes you have committed against Sordland, I am sentencing you to execution by firing squad."

Soldiers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "...worried about the future of your family."*)
  - -> `[42]` (*Player: "...declared that you would take revenge."*)
  - -> `[43]` (*Player: "...accepted your fate."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You heard the footsteps of soldiers approaching."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_execution");"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "1959|Antel Rock Prison"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "1959|Antel Rock Prison"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "You were dragged outside after you finished your final meal. Soldiers brought you to a corner just outside the prison block and tied your hands behind your back.

You took a look at the wall behind you. It was covered in dried blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "You heard the footsteps of soldiers approaching."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1958|Antel Rock Prison"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "1958|Antel Rock Prison"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he had joined the ranks of the People's Freedom and Justice Party. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Kontekst wejściowy (poprzednik):** `[79]` (Player), `[83]` (Player), `[77]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...said you were worried for his future."*)
  - -> `[30]` (*Player: "...told him not to get too deep into politics."*)
  - -> `[16]` (*Player: "...congratulated him."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading books was the only thing you could do. Eventually, you started scribbling notes about your life that you hoped you could turn into a memoir.

Monica and the children visited only once, to have you sign the divorce papers."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Player), `[8]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "Time flies in jail."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a bottle of whiskey."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time flies in jail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "1960"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hearty and healthy breakfast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the largest, bloodiest steak he could find."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The week was over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator), `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "1958|Day of the Execution|Antel Rock Prison"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "1958|Day of the Execution|Antel Rock Prison"]** — Mówca: **Narrator**
> "The day of your execution had arrived.

The cell door opened and the warden entered. He asked you what would be your final meal.

You asked him for..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "...the largest, bloodiest steak he could find."*)
  - -> `[58]` (*Player: "...a hearty and healthy breakfast."*)
  - -> `[56]` (*Player: "...a bottle of whiskey."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coup_iosef");"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coup_valken");"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The squad of soldiers turned the corner and lined up acro..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The squad of soldiers turned the corner and lined up acro..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "The squad of soldiers turned the corner and lined up across from you. At the head of the line was their commander, Valken.

He checked his watch and declared that the time had come. 

He pulled out a cloth to cover your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "Accept your death."*)
  - -> `[75]` (*Player: "Beg Valken to free you."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Beg Valken to free you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "You learned in prison that after 2 years, the military junta finally gave the power back to people.

The political parties and the Grand National Assembly were re-established.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "...did not care much."*)
  - -> `[78]` (*Player: "...thought that this could be your way out."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did not care much."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...thought that this could be your way out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...hoped that someone would hang Iosef for his crimes."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "...hoped that someone would hang Iosef for his crimes."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "...hoped that someone would hang Valken for his crimes."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...hoped that someone would hang Valken for his crimes."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "1965"]** — Mówca: **Narrator**
> "After 7 years in jail, Sordland's new president finally granted amnesty to political prisoners from the military rule days.

You looked at yourself in the mirror as you were packing up your belongings to leave."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[16]` (Player), `[30]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had grown old."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had grown old."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "1967"]** — Mówca: **Narrator**
> "Getting used to being a free man took years.

You finally felt confident enough to plan out what to do with the rest of your life.

You chose to..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player), `[101]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "...have another shot at politics."*)
  - -> `[103]` (*Player: "...retire to the countryside."*)
  - -> `[104]` (*Player: "...find an earnest job."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

No one was waiting for you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "The years haven't been kind to you."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "You took your first step outside. Freedom felt good.  No ..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "You took your first step outside. Freedom felt good.  Fra..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

Franc and his family were waiting for you. 

Everything had changed so much that you felt out of place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "The years haven't been kind to you."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

Monica, Deana and Franc were waiting for you.

Unfortunately, the years hadn't been kind to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "But they hadn't been kind to you either."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

Monica and Deana were waiting for you.

Unfortunately, the years hadn't been kind to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "But they hadn't been kind to you either."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "You took your first step outside. Freedom felt good.  Mon..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "You took your first step outside. Freedom felt good.  Mon..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The years haven't been kind to you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "But they hadn't been kind to you either."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator), `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...have another shot at politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "1973"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...retire to the countryside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "1973"*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...find an earnest job."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "1973"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "1973"]** — Mówca: **Narrator**
> "You tried to get back into politics, but Sordland had changed too much.

The political spheres formed after the coup did not accept you.

You had to work menial, though at least honest, jobs to get by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "At least you were free."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "1973"]** — Mówca: **Narrator**
> "Life was good.

You took up various hobbies like gardening and woodworking. Out of boredom, you became a carpenter.

Your new past times earned you just enough money to get by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "You had all the time in the world."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "At least you were free."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "1973"]** — Mówca: **Narrator**
> "Life was good.

You took up woodworking and became a carpenter.

It was a menial job, but at least it was honest."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "You had to get by somehow."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had all the time in the world."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had to get by somehow."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "1974"]** — Mówca: **Narrator**
> "A week after your 66th birthday, a woman knocked on your door.

She was a young upstart journalist fascinated by your life story. No matter what you did, she kept coming back. Finally, you gave in. She said she was working on a book about you. 

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Player), `[109]` (Player), `[110]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "...just wanted to finally have peace of mind."*)
  - -> `[113]` (*Player: "...helped her as best as you could."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...just wanted to finally have peace of mind."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "After many hours of interviews, she said that she had eno..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...helped her as best as you could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "After many hours of interviews, she said that she had eno..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "After many hours of interviews, she said that she had enough information and disappeared from your life.

You looked up the name she had given you, but you couldn't find it anywhere. You suspected she'd used an alias."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "You wondered why."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You wondered why."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "You heard a knock on your door. It was the delivery man w..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "You heard a knock on your door. It was the delivery man with a large, heavy package.

The package was filled with copies of books. There was a small note on top of it.

"Thank you. --Carol Circas""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "You picked up the book."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You picked up the book."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "It was titled Suzerain: The Story of Anton Rayne."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "It was titled Suzerain: The Story of Anton Rayne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "You faintly smiled."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You faintly smiled."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "The warden paid you a visit to deliver a letter from the Sordish Armed Forces. You opened the envelope.

Franc Rayne was killed in action in a battle against the BFF near Erzaren."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "Your whole world fell apart."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest_BFF_Deal_Signed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_UnrestStopped == false || BaseGame.Unre..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest_BFF_Deal_Signed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coup_iosef");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coup_iosef");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "1958|Supreme Court of Sordland"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coup_valken");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coup_valken");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "1958|Supreme Court of Sordland"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_gavel");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_gavel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_jail");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_jail");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_red");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "You were dragged outside after you finished your final me..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_execution");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_execution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He asked you if you had any last words."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "1967"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "1974"*)
