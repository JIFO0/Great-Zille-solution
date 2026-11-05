# Sordland/HOLSORD ENDING

- **ID konwersacji:** `265`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (HOLSORD ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/265_HOLSORD_ENDING.md`
- **Liczba węzłów dialogowych:** 125
- **Liczba wyborów gracza:** 48

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"...joined the board of Underhall Construction."** | `[10]` **Narrator**: "With your presidency behind you,..." | `Variable["BaseGame.Turn05_P_Underhall"] == true` | `PrologueImage("pe_monicaspeech");` | `[6]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[5]` **Narrator**: "Meanwhile, your wife became ever..."<br>*(oraz 2 innych odgałęzień)* |
| `[6]` | **"1960\|Holsord"** | `[3]` **Player**: "...joined the board of Underhall..."<br>`[23]` **Player**: "...became an adjunct professor o..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[27]` **Player**: "...vocally supported her."<br>`[30]` **Player**: "...stayed silent, but agreed to ..." |
| `[7]` | **"1965\|Holsord"** | `[29]` **Player**: "You never saw either of them eve..."<br>`[41]` **Player**: "Years went by." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`Variable["BaseGame.Turn05_P_Underhall"] == true` | *Brak zmian stanu* | `[60]` **Player**: "You didn't care."<br>`[61]` **Player**: "You lost sleep over it." |
| `[8]` | **"1960\|Holsord"** | `[3]` **Player**: "...joined the board of Underhall..."<br>`[23]` **Player**: "...became an adjunct professor o..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[27]` **Player**: "...vocally supported her."<br>`[31]` **Player**: "...found some racy photos you'd ..." |
| `[9]` | **"...began writing a memoir."** | `[10]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] =...`<br>`PrologueImage("pe_monicaspeech");` | `[6]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[5]` **Narrator**: "Meanwhile, your wife became ever..."<br>*(oraz 2 innych odgałęzień)* |
| `[11]` | **"1960\|Holsord"** | `[3]` **Player**: "...joined the board of Underhall..."<br>`[23]` **Player**: "...became an adjunct professor o..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[27]` **Player**: "...vocally supported her."<br>`[31]` **Player**: "...found some racy photos you'd ..." |
| `[22]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "You were happy to reconnect with..."<br>`[58]` **Player**: "You didn't respond." |
| `[23]` | **"...became an adjunct professor of politics at Holsord State University."** | `[10]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[6]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[5]` **Narrator**: "Meanwhile, your wife became ever..."<br>*(oraz 2 innych odgałęzień)* |
| `[27]` | **"...vocally supported her."** | `[5]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[6]` **Narrator**: "Meanwhile, your wife became ever..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[4]` **Narrator**: "You and Monica began speaking to..." |
| `[29]` | **"You never saw either of them ever again."** | `[18]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[7]` **Narrator**: "As you used your remaining polit..." |
| `[30]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[5]` **Narrator**: "Meanwhile, your wife became ever..."<br>`[6]` **Narrator**: "Meanwhile, your wife became ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[4]` **Narrator**: "You and Monica began speaking to..." |
| `[31]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[8]` **Narrator**: "Meanwhile, you couldn't help but..."<br>`[11]` **Narrator**: "Meanwhile, you couldn't help but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "The ensuing scandal erased most ..." |
| `[41]` | **"Years went by."** | `[4]` **Narrator**: "You and Monica began speaking to..."<br>`[28]` **Narrator**: "Your support buoyed Monica to ne..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[7]` **Narrator**: "As you used your remaining polit..." |
| `[42]` | **"...helped him with whatever he needed."** | `[48]` **Narrator**: "As you used your remaining polit..."<br>`[95]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[43]` | **"...refused to give him anything."** | `[48]` **Narrator**: "As you used your remaining polit..."<br>`[95]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[44]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "Life went on." |
| `[48]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: "...helped him with whatever he n..."<br>`[43]` **Player**: "...refused to give him anything." |
| `[52]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Player**: "Author Rayne." |
| `[56]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "Life went on." |
| `[57]` | **"You were happy to reconnect with him."** | `[22]` **Narrator**: "After years of hard work, your m..."<br>`[96]` **Narrator**: "After years of hard work, your m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[58]` | **"You didn't respond."** | `[22]` **Narrator**: "After years of hard work, your m..."<br>`[96]` **Narrator**: "After years of hard work, your m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[59]` | **"1975\|Holsord"** | `[42]` **Player**: "...helped him with whatever he n..."<br>`[43]` **Player**: "...refused to give him anything."<br>*(oraz 5 innych węzłów)* | `Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[65]` **Player**: "...never got back into politics."<br>`[66]` **Player**: "...didn't fulfill the goals you'..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **"You didn't care."** | `[7]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[61]` | **"You lost sleep over it."** | `[7]` **Narrator**: "As you used your remaining polit..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[65]` | **"...never got back into politics."** | `[59]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[66]` | **"...didn't fulfill the goals you'd set out as President."** | `[59]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[67]` | **"...actually, you had no regrets."** | `[59]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[68]` | **"1975\|Holsord"** | `[42]` **Player**: "...helped him with whatever he n..."<br>`[43]` **Player**: "...refused to give him anything."<br>*(oraz 5 innych węzłów)* | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[69]` **Player**: "...never got back into politics."<br>`[70]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **"...never got back into politics."** | `[68]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[70]` | **"...actually, you had no regrets."** | `[68]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[71]` | **"...were never able to mend your marriage with Monica."** | `[68]` **Narrator**: "You lived out the rest of your d..." | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[72]` | **"1975\|Holsord"** | `[85]` **Player**: "Life went on." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[76]` **Player**: "...never got back into politics."<br>`[77]` **Player**: "...didn't fulfill the goals you'..."<br>*(oraz 1 innych odgałęzień)* |
| `[73]` | **"...actually, you had no regrets."** | `[72]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[74]` | **"1975\|Holsord"** | `[85]` **Player**: "Life went on." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[79]` **Player**: "...never got back into politics."<br>`[75]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[75]` | **"...actually, you had no regrets."** | `[74]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[76]` | **"...never got back into politics."** | `[72]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[77]` | **"...didn't fulfill the goals you'd set out as President."** | `[72]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[78]` | **"...were never able to mend your marriage with Monica."** | `[74]` **Narrator**: "You lived out the rest of your d..." | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[79]` | **"...never got back into politics."** | `[74]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[84]` | **"Author Rayne."** | `[52]` **Narrator**: "After years of hard work, your m..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");`<br>`PrologueImage("pe_relaxed");` | `[59]` **Narrator**: "You lived out the rest of your d..."<br>`[68]` **Narrator**: "You lived out the rest of your d..." |
| `[85]` | **"Life went on."** | `[44]` **Narrator**: "You threw yourself into your tea..."<br>`[56]` **Narrator**: "You threw yourself into your tea..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "You lived out the rest of your d..."<br>`[74]` **Narrator**: "You lived out the rest of your d..." |
| `[95]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: "...helped him with whatever he n..."<br>`[43]` **Player**: "...refused to give him anything." |
| `[96]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "You were happy to reconnect with..."<br>`[58]` **Player**: "You didn't respond." |
| `[97]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "You were happy to reconnect with..."<br>`[58]` **Player**: "You didn't respond." |
| `[104]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "Life went on." |
| `[105]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "Life went on." |
| `[112]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "Life went on." |
| `[113]` | **"1965\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "Life went on." |

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
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the board of Underhall Construction."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Years went by."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "...vocally supported her."*)
  - -> `[30]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player), `[23]` (Player), `[9]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "...vocally supported her."*)
  - -> `[30]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living with his wife and son on a farming commune in United Contana, publicly distanced himself from you."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "You didn't care."*)
  - -> `[61]` (*Player: "You lost sleep over it."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player), `[23]` (Player), `[9]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "...vocally supported her."*)
  - -> `[31]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...began writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir = true"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "With your presidency behind you, you began your new life in Holsord. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[23]` (*Player: "...became an adjunct professor of politics at Holsord Sta..."*)
  - -> `[9]` (*Player: "...began writing a memoir."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player), `[23]` (Player), `[9]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "...vocally supported her."*)
  - -> `[31]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "You were happy to reconnect with him."*)
  - -> `[58]` (*Player: "You didn't respond."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Holsord State University."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "...joined the board of Underhall Construction."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[6]` (Narrator), `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Years went by."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in the Maroon Palace."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator), `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "1960|Holsord"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Meanwhile, your wife became ever more entrenched in her s..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "1960|Holsord"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "1960|Holsord"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator), `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...helped him with whatever he needed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...refused to give him anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a farm somewhere in Bergia."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "Life went on."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "1965|Holsord"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living on a small farm in Bergia with his wife and son, frequently asked you for money. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "...helped him with whatever he needed."*)
  - -> `[43]` (*Player: "...refused to give him anything."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "1965|Holsord"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "Author Rayne."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in Bergia, came to visit from time to time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "Life went on."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[96]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[96]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Player), `[43]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "...never got back into politics."*)
  - -> `[66]` (*Player: "...didn't fulfill the goals you'd set out as President."*)
  - -> `[67]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't care."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You lost sleep over it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed");"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed");"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, surrounded by sycophants and just a few true friends.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Player), `[43]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "...never got back into politics."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true ||BaseGame.Rela..."*)
  - -> `[70]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "...never got back into politics."*)
  - -> `[77]` (*Player: "...didn't fulfill the goals you'd set out as President."*)
  - -> `[73]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, alone except for a few close friends.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "...never got back into politics."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true ||BaseGame.Rela..."*)
  - -> `[75]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "1975|Holsord"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "1975|Holsord"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Author Rayne."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Life went on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[56]` (Narrator), `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "1965|Holsord"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "1965|Holsord"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "1965|Holsord"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "1965|Holsord"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "1965|Holsord"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living in the Arcasian suburbs with his wife and son, frequently asked you for money. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "...helped him with whatever he needed."*)
  - -> `[43]` (*Player: "...refused to give him anything."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "You were happy to reconnect with him."*)
  - -> `[58]` (*Player: "You didn't respond."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "You were happy to reconnect with him."*)
  - -> `[58]` (*Player: "You didn't respond."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "1965|Holsord"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "1965|Holsord"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "1965|Holsord"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son somewhere in the Arcasian suburbs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "Life went on."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a commune somewhere in United Contana."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "Life went on."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "1965|Holsord"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "1965|Holsord"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "1965|Holsord"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in the Arcasian suburbs, came to visit from time to time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "Life went on."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son on a commune in United Contana, came to visit from time to time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "Life went on."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "With your presidency behind you, you began your new life ..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "1975|Holsord"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "1975|Holsord"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true ||BaseGame.Rela..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true ||BaseGame.Re..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "...were never able to mend your marriage with Monica."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true ||BaseGame.Rela..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true ||BaseGame.Re..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "...were never able to mend your marriage with Monica."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
