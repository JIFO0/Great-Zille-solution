# Sordland/Epilogue_ImpeachmentTrial

- **ID konwersacji:** `262`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ImpeachmentTrial)`
- **Lokalizacja pliku:** `Sordland/Epilogue/262_Epilogue_ImpeachmentTrial.md`
- **Liczba węzłów dialogowych:** 120
- **Liczba wyborów gracza:** 59

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Franc_Died`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"1958\|Supreme Court of Sordland"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Player**: "...blamed only yourself."<br>`[8]` **Player**: "...were angry at everyone who sp..."<br>*(oraz 1 innych odgałęzień)* |
| `[4]` | **"...did your best for Sordland. No matter what."** | `[3]` **Narrator**: "The gavel was tapped two times a..."<br>`[33]` **Narrator**: "The gavel was tapped two times a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "The next words you heard were "I..." |
| `[6]` | **"...worried about the future of your family."** | `[11]` **Narrator**: "But the judge wasn't done speaki..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[45]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[13]` **Narrator**: "Your cell was cold and lonely. T..." |
| `[7]` | **"...declared that you would take revenge."** | `[11]` **Narrator**: "But the judge wasn't done speaki..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[45]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[13]` **Narrator**: "Your cell was cold and lonely. T..." |
| `[8]` | **"...were angry at everyone who spoke against you."** | `[3]` **Narrator**: "The gavel was tapped two times a..."<br>`[33]` **Narrator**: "The gavel was tapped two times a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "The next words you heard were "I..." |
| `[9]` | **"...blamed only yourself."** | `[3]` **Narrator**: "The gavel was tapped two times a..."<br>`[33]` **Narrator**: "The gavel was tapped two times a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "The next words you heard were "I..." |
| `[10]` | **"...the first impeached President of Sordland."** | `[5]` **Narrator**: "The next words you heard were "I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "But the judge wasn't finished sp..."<br>`[11]` **Narrator**: "But the judge wasn't done speaki..." |
| `[12]` | **"...accepted your fate."** | `[11]` **Narrator**: "But the judge wasn't done speaki..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[45]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[13]` **Narrator**: "Your cell was cold and lonely. T..." |
| `[13]` | **"1959\|Antel Rock Prison"** | `[6]` **Player**: "...worried about the future of y..."<br>`[7]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | *Brak zmian stanu* | `[46]` **Player**: "Time flies in jail." |
| `[14]` | **"1968\|Antel Rock Prison"** | `[60]` **Player**: "Your whole world fell apart."<br>`[61]` **Player**: "...congratulated him."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | *Brak zmian stanu* | `[77]` **Player**: "Something was wrong." |
| `[15]` | **"Something was wrong."** | `[67]` **Narrator**: "In the middle of the night, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "Seeing you, Deana quickly turned..." |
| `[17]` | **"You were overcome with grief."** | `[16]` **Narrator**: "Seeing you, Deana quickly turned..."<br>`[79]` **Narrator**: "Deana couldn't hold her tears an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "You returned to your cell, numb ..." |
| `[19]` | **"End it all."** | `[18]` **Narrator**: "You returned to your cell, numb ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Before you could kick your chair..." |
| `[20]` | **"Don't do it."** | `[18]` **Narrator**: "You returned to your cell, numb ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "You spent the rest of your life ..."<br>`[83]` **Narrator**: "You spent the rest of your life ..." |
| `[21]` | **"1976"** | `[20]` **Player**: "Don't do it."<br>`[112]` **Player**: "A failure to the end." | `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true` | *Brak zmian stanu* | `[23]` **Player**: ""I am sorry.""<br>`[24]` **Player**: ""I regret nothing."" |
| `[22]` | **"And so Anton Rayne was no more."** | `[25]` **Narrator**: "Deana started crying and hugged ..."<br>`[87]` **Narrator**: "Franc and Deana started crying a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[23]` | **""I am sorry.""** | `[21]` **Narrator**: "You spent the rest of your life ..."<br>`[83]` **Narrator**: "You spent the rest of your life ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Deana started crying and hugged ..."<br>`[87]` **Narrator**: "Franc and Deana started crying a..." |
| `[24]` | **""I regret nothing.""** | `[21]` **Narrator**: "You spent the rest of your life ..."<br>`[83]` **Narrator**: "You spent the rest of your life ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Deana started crying and hugged ..."<br>`[87]` **Narrator**: "Franc and Deana started crying a..." |
| `[25]` | **"1976"** | `[23]` **Player**: ""I am sorry.""<br>`[24]` **Player**: ""I regret nothing."" | `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true` | *Brak zmian stanu* | `[22]` **Player**: "And so Anton Rayne was no more." |
| `[33]` | **"1958\|Supreme Court of Sordland"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Player**: "...blamed only yourself."<br>`[8]` **Player**: "...were angry at everyone who sp..."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **"1958\|Supreme Court of Sordland"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Player**: "...blamed only yourself."<br>`[8]` **Player**: "...were angry at everyone who sp..."<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **"...worried about the future of your family."** | `[38]` **Narrator**: "But the judge wasn't finished sp..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[92]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[91]` **Narrator**: "Your cell was cold and lonely. Y..." |
| `[40]` | **"...declared that you would take revenge."** | `[38]` **Narrator**: "But the judge wasn't finished sp..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[92]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[91]` **Narrator**: "Your cell was cold and lonely. Y..." |
| `[41]` | **"...accepted your fate."** | `[38]` **Narrator**: "But the judge wasn't finished sp..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_jail");` | `[92]` **Narrator**: "Your cell was cold and lonely. A..."<br>`[91]` **Narrator**: "Your cell was cold and lonely. Y..." |
| `[45]` | **"1959\|Antel Rock Prison"** | `[6]` **Player**: "...worried about the future of y..."<br>`[7]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[46]` **Player**: "Time flies in jail." |
| `[46]` | **"Time flies in jail."** | `[13]` **Narrator**: "Your cell was cold and lonely. T..."<br>`[45]` **Narrator**: "Your cell was cold and lonely. T..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[56]` **Narrator**: "Franc visited you for the first ..."<br>`[57]` **Narrator**: "Franc visited you for the first ..." |
| `[56]` | **"1964\|Antel Rock Prison"** | `[46]` **Player**: "Time flies in jail." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true` | *Brak zmian stanu* | `[63]` **Player**: "...said you were worried for his..."<br>`[62]` **Player**: "...told him not to get too deep ..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"1964\|Antel Rock Prison"** | `[46]` **Player**: "Time flies in jail." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false` | *Brak zmian stanu* | `[63]` **Player**: "...said you were worried for his..."<br>`[62]` **Player**: "...told him not to get too deep ..."<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **"1964\|Antel Rock Prison"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Player**: "...said you were worried for his..."<br>`[62]` **Player**: "...told him not to get too deep ..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"1964\|Antel Rock Prison"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "Your whole world fell apart." |
| `[60]` | **"Your whole world fell apart."** | `[59]` **Narrator**: "The warden paid you a visit to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "In the middle of the night, the ..."<br>`[67]` **Narrator**: "In the middle of the night, the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[61]` | **"...congratulated him."** | `[56]` **Narrator**: "Franc visited you for the first ..."<br>`[57]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "In the middle of the night, the ..."<br>`[67]` **Narrator**: "In the middle of the night, the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[62]` | **"...told him not to get too deep into politics."** | `[56]` **Narrator**: "Franc visited you for the first ..."<br>`[57]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "In the middle of the night, the ..."<br>`[67]` **Narrator**: "In the middle of the night, the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[63]` | **"...said you were worried for his future."** | `[56]` **Narrator**: "Franc visited you for the first ..."<br>`[57]` **Narrator**: "Franc visited you for the first ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "In the middle of the night, the ..."<br>`[67]` **Narrator**: "In the middle of the night, the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[67]` | **"1968\|Antel Rock Prison"** | `[60]` **Player**: "Your whole world fell apart."<br>`[61]` **Player**: "...congratulated him."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[15]` **Player**: "Something was wrong." |
| `[71]` | **"1968\|Antel Rock Prison"** | `[60]` **Player**: "Your whole world fell apart."<br>`[61]` **Player**: "...congratulated him."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`<br>`Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[76]` **Player**: "Something was wrong." |
| `[75]` | **"1968\|Antel Rock Prison"** | `[60]` **Player**: "Your whole world fell apart."<br>`[61]` **Player**: "...congratulated him."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`<br>`(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | *Brak zmian stanu* | `[78]` **Player**: "Something was wrong." |
| `[76]` | **"Something was wrong."** | `[71]` **Narrator**: "In the middle of the night, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "Deana couldn't hold her tears an..." |
| `[77]` | **"Something was wrong."** | `[14]` **Narrator**: "It had been months since Monica'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "Deana couldn't hold her tears an..." |
| `[78]` | **"Something was wrong."** | `[75]` **Narrator**: "It had been months since Monica'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "Seeing you, Deana quickly turned..." |
| `[83]` | **"1976"** | `[20]` **Player**: "Don't do it."<br>`[112]` **Player**: "A failure to the end." | `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false` | *Brak zmian stanu* | `[23]` **Player**: ""I am sorry.""<br>`[24]` **Player**: ""I regret nothing."" |
| `[87]` | **"1976"** | `[23]` **Player**: ""I am sorry.""<br>`[24]` **Player**: ""I regret nothing."" | `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false` | *Brak zmian stanu* | `[22]` **Player**: "And so Anton Rayne was no more." |
| `[91]` | **"1958\|Antel Rock Prison"** | `[39]` **Player**: "...worried about the future of y..."<br>`[40]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false` | *Brak zmian stanu* | `[93]` **Player**: "The week was over." |
| `[92]` | **"1958\|Antel Rock Prison"** | `[39]` **Player**: "...worried about the future of y..."<br>`[40]` **Player**: "...declared that you would take ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[93]` **Player**: "The week was over." |
| `[93]` | **"The week was over."** | `[91]` **Narrator**: "Your cell was cold and lonely. Y..."<br>`[92]` **Narrator**: "Your cell was cold and lonely. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "The day of your execution had ar..." |
| `[94]` | **"1958\|Day of the Execution\|Antel Rock Prison"** | `[93]` **Player**: "The week was over." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "...the largest, bloodiest steak ..."<br>`[96]` **Player**: "...a hearty and healthy breakfast."<br>*(oraz 1 innych odgałęzień)* |
| `[95]` | **"...the largest, bloodiest steak he could find."** | `[94]` **Narrator**: "The day of your execution had ar..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[98]` **Narrator**: "You were dragged outside after y..." |
| `[96]` | **"...a hearty and healthy breakfast."** | `[94]` **Narrator**: "The day of your execution had ar..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[98]` **Narrator**: "You were dragged outside after y..." |
| `[97]` | **"...a bottle of whiskey."** | `[94]` **Narrator**: "The day of your execution had ar..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[98]` **Narrator**: "You were dragged outside after y..." |
| `[99]` | **"You heard the footsteps of soldiers approaching."** | `[98]` **Narrator**: "You were dragged outside after y..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_execution");` | `[100]` **Narrator**: "The squad of soldiers turned the..." |
| `[101]` | **"Beg Iosef to free you."** | `[100]` **Narrator**: "The squad of soldiers turned the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Narrator**: "He asked you if you had any last..." |
| `[102]` | **"Accept your death."** | `[100]` **Narrator**: "The squad of soldiers turned the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Narrator**: "He asked you if you had any last..." |
| `[104]` | **""I regret nothing.""** | `[103]` **Narrator**: "He asked you if you had any last..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[107]` **Narrator**: "He covered your eyes and stepped..." |
| `[105]` | **""A Morgna wes core! Vectern sis da!""** | `[103]` **Narrator**: "He asked you if you had any last..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[107]` **Narrator**: "He covered your eyes and stepped..." |
| `[106]` | **""I am sorry.""** | `[103]` **Narrator**: "He asked you if you had any last..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[107]` **Narrator**: "He covered your eyes and stepped..." |
| `[108]` | **"...felt relaxed. It was finally over."** | `[107]` **Narrator**: "He covered your eyes and stepped..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The gunshots were the last thing..." |
| `[109]` | **"...defiantly stood proud and strong."** | `[107]` **Narrator**: "He covered your eyes and stepped..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The gunshots were the last thing..." |
| `[110]` | **"...cried like a child."** | `[107]` **Narrator**: "He covered your eyes and stepped..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The gunshots were the last thing..." |
| `[112]` | **"A failure to the end."** | `[26]` **Narrator**: "Before you could kick your chair..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "You spent the rest of your life ..."<br>`[83]` **Narrator**: "You spent the rest of your life ..." |

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
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_gavel");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "The gavel was tapped two times and Orso Hawker demanded silence in the loud room. After a long pause, he ordered everyone to rise.

One of his retainers handed him the letter with the verdict. Orso opened it with a barely suppressed smile. 

Knowing what was coming next, you felt that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "...blamed only yourself."*)
  - -> `[8]` (*Player: "...were angry at everyone who spoke against you."*)
  - -> `[4]` (*Player: "...did your best for Sordland. No matter what."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best for Sordland. No matter what."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The next words you heard were "It is hereby decided that ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The next words you heard were "It is hereby decided that Anton Rayne is impeached from office."

The crowd in the courtroom -- the very same people who celebrated your inauguration -- erupted in loud cheers.

You thought about how you would go down in history as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "...the first impeached President of Sordland."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were angry at everyone who spoke against you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The next words you heard were "It is hereby decided that ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...blamed only yourself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The next words you heard were "It is hereby decided that ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the first impeached President of Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "But the judge wasn't done speaking.

"For the magnitude of his crimes against Sordland, Anton Rayne is sentenced to life in prison."

The crowd cheered even louder this time. Security officers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "...worried about the future of your family."*)
  - -> `[7]` (*Player: "...declared that you would take revenge."*)
  - -> `[12]` (*Player: "...accepted your fate."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading was the only thing you could do. After finishing the precious books sent by Monica, you kept yourself busy by writing your own memoir.

Meanwhile, your family visited you at least once a month."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[6]` (Player), `[7]` (Player), `[12]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "Time flies in jail."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "It had been months since Monica's last visit. In the middle of the night, the warden knocked roughly on your door and told you you had a visitor.

Deana was waiting for you with teary eyes."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[60]` (Player), `[61]` (Player), `[62]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "Something was wrong."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Seeing you, Deana quickly turned around, hiding her face...."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Seeing you, Deana quickly turned around, hiding her face. Franc couldn't hold his tears anymore and told you that his mother passed away. 

His mother, your wife, Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "You were overcome with grief."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were overcome with grief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "You returned to your cell, numb and exhausted.  Every pas..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "You returned to your cell, numb and exhausted.

Every passing second was torture as you rotted away in this dark, isolated hellhole.

Lying down on your bed, you looked at your belt and the metal pipe in the ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "End it all."*)
  - -> `[20]` (*Player: "Don't do it."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "End it all."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Before you could kick your chair away, the warden rushed ..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Don't do it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "You spent the rest of your life between four walls.

Eventually, old age caught up with you. You were discharged from prison to the hospital to spend your last moments with your family.

As you took your last breath, you grabbed Deana. You pulled her close and said..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[112]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""I am sorry.""*)
  - -> `[24]` (*Player: ""I regret nothing.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "And so Anton Rayne was no more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[87]` (Narrator), `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator), `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I regret nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator), `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "Deana started crying and hugged you.

You could feel you were slipping away.

Your eyes filled with tears and started to close, never to be opened again."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Before you could kick your chair away, the warden rushed in and pulled you down. You were stripped of any potentially dangerous belongings and placed under constant surveillance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "A failure to the end."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "1958|Supreme Court of Sordland"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "1958|Supreme Court of Sordland"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "1958|Supreme Court of Sordland"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "The gavel was tapped two times and Ovid Grecer demanded silence in the loud room. After a long pause, he ordered everyone to rise.

One of his retainers handed him the letter with the verdict. Ovid opened it with a stern face. 

Knowing what was coming next, you felt that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "...blamed only yourself."*)
  - -> `[8]` (*Player: "...were angry at everyone who spoke against you."*)
  - -> `[4]` (*Player: "...did your best for Sordland. No matter what."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "The gavel was tapped two times and Heron Garaci demanded silence in the loud room. After a long pause, he ordered everyone to rise.

One of his retainers handed him the letter with the verdict. Heron opened it with a barely suppressed smile. 

Knowing what was coming next, you felt that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "...blamed only yourself."*)
  - -> `[8]` (*Player: "...were angry at everyone who spoke against you."*)
  - -> `[4]` (*Player: "...did your best for Sordland. No matter what."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "But the judge wasn't finished speaking.  "For the magnitu..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "But the judge wasn't done speaking.  "For the magnitude o..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "But the judge wasn't finished speaking.

"For the magnitude of the crimes he has committed against Sordland, Anton Rayne is sentenced to execution by firing squad."

The crowd cheered even louder this time. Security officers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "...worried about the future of your family."*)
  - -> `[40]` (*Player: "...declared that you would take revenge."*)
  - -> `[41]` (*Player: "...accepted your fate."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail");"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "1959|Antel Rock Prison"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "1959|Antel Rock Prison"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading books was the only thing you could do. Eventually, you started scribbling notes about your life that you hoped you could turn into a memoir.

Monica and the children visited only once, to have you sign the divorce papers."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Player), `[7]` (Player), `[12]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "Time flies in jail."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time flies in jail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "1964|Antel Rock Prison"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he joined the ranks of the People's Freedom and Justice Party. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "...said you were worried for his future."*)
  - -> `[62]` (*Player: "...told him not to get too deep into politics."*)
  - -> `[61]` (*Player: "...congratulated him."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he joined the ranks of the Communist Party of Sordland. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "...said you were worried for his future."*)
  - -> `[62]` (*Player: "...told him not to get too deep into politics."*)
  - -> `[61]` (*Player: "...congratulated him."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he was now a senior army official on a track to the higher ranks. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "...said you were worried for his future."*)
  - -> `[62]` (*Player: "...told him not to get too deep into politics."*)
  - -> `[61]` (*Player: "...congratulated him."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "The warden paid you a visit to deliver a letter from the Sordish Armed Forces. You opened the envelope.

Franc Rayne was killed in action in a battle against the BFF near Erzaren."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "Your whole world fell apart."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your whole world fell apart."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...congratulated him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[57]` (Narrator), `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told him not to get too deep into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[57]` (Narrator), `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were worried for his future."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[57]` (Narrator), `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "In the middle of the night, the warden knocked roughly on your door and told you you had visitors.

Franc, his wife and Deana were waiting for you with teary eyes."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false` AND `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[60]` (Player), `[61]` (Player), `[62]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "Something was wrong."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "1968|Antel Rock Prison"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "1968|Antel Rock Prison"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "In the middle of the night, the warden knocked roughly on your door and told you you had a visitor.

Deana was waiting for you with teary eyes."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true` AND `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[60]` (Player), `[61]` (Player), `[62]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "Something was wrong."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "1968|Antel Rock Prison"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "1968|Antel Rock Prison"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "It had been months since Monica's last visit. In the middle of the night, the warden knocked roughly on your door and told you you had visitors.

Franc, his wife and Deana were waiting for you with teary eyes."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false` AND `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[60]` (Player), `[61]` (Player), `[62]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "Something was wrong."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Deana couldn't hold her tears anymore and told you that h..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Deana couldn't hold her tears anymore and told you that h..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Seeing you, Deana quickly turned around, hiding her face...."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Deana couldn't hold her tears anymore and told you that her mother passed away. 

Her mother, your wife, Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "You were overcome with grief."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1976"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "1976"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "You spent the rest of your life between four walls.

Eventually, old age caught up with you. You were discharged from prison to the hospital to spend your last moments with your family.

As you took your last breath, you grabbed Franc and Deana. You pulled them close and said..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[112]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""I am sorry.""*)
  - -> `[24]` (*Player: ""I regret nothing.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "1976"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "1976"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "Franc and Deana started crying and hugged you.

You could feel you were slipping away.

Your eyes filled with tears and started to close, never to be opened again."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "And so Anton Rayne was no more."*)

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
  - -> `[92]` (*Narrator: "1958|Antel Rock Prison"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "1958|Antel Rock Prison"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. You had a week until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

You were happy that at least your family visited you every day."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Player), `[40]` (Player), `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "The week was over."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. A week remained until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

Monica visited you only once, along with the kids."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[39]` (Player), `[40]` (Player), `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "The week was over."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The week was over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator), `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "1958|Day of the Execution|Antel Rock Prison"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "1958|Day of the Execution|Antel Rock Prison"]** — Mówca: **Narrator**
> "The day of your execution had arrived.

The cell door opened and the warden entered. He asked you what would be your final meal.

You asked him for..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "...the largest, bloodiest steak he could find."*)
  - -> `[96]` (*Player: "...a hearty and healthy breakfast."*)
  - -> `[97]` (*Player: "...a bottle of whiskey."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the largest, bloodiest steak he could find."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hearty and healthy breakfast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a bottle of whiskey."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "You were dragged outside after you finished your final meal. The guards brought you to a corner just outside the prison block and tied your hands behind your back.

You took a look at the wall behind you. It was covered in dried blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: "You heard the footsteps of soldiers approaching."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You heard the footsteps of soldiers approaching."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_execution");"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "The squad of soldiers turned the corner and lined up across from you. At the head of the line was their commander, Iosef.

He checked his watch and declared that the time had come. 

He pulled out a cloth to cover your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "Accept your death."*)
  - -> `[101]` (*Player: "Beg Iosef to free you."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Beg Iosef to free you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "He asked you if you had any last words."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Accept your death."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "He asked you if you had any last words."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "He asked you if you had any last words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""A Morgna wes core! Vectern sis da!""*)
  - -> `[104]` (*Player: ""I regret nothing.""*)
  - -> `[106]` (*Player: ""I am sorry.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I regret nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core! Vectern sis da!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "He covered your eyes and stepped back. 

After a moment, you heard the sounds of the guns being cocked.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "...defiantly stood proud and strong."*)
  - -> `[110]` (*Player: "...cried like a child."*)
  - -> `[108]` (*Player: "...felt relaxed. It was finally over."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...felt relaxed. It was finally over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The gunshots were the last thing you ever heard."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...defiantly stood proud and strong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The gunshots were the last thing you ever heard."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cried like a child."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The gunshots were the last thing you ever heard."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "The gunshots were the last thing you ever heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "And so Anton Rayne was no more."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "A failure to the end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_gavel");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_gavel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_jail");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_jail");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_red");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "You were dragged outside after you finished your final me..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_execution");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_execution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The squad of soldiers turned the corner and lined up acro..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "He covered your eyes and stepped back.   After a moment, ..."*)
