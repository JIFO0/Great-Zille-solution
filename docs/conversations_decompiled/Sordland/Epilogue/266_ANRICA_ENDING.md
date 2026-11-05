# Sordland/ANRICA ENDING

- **ID konwersacji:** `266`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ANRICA ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/266_ANRICA_ENDING.md`
- **Liczba węzłów dialogowych:** 103
- **Liczba wyborów gracza:** 43

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
- `BaseGame.Resigned_GusManger`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Retirement_FamilyWithYou`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"...threw yourself into the role, studying football strategy and using all the tact..."** | `[3]` **Narrator**: "With your presidency behind you,..."<br>`[7]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_celebrity");` | `[11]` **Narrator**: "The team won more matches than i..."<br>`[24]` **Narrator**: "The team won more matches than i..."<br>*(oraz 2 innych odgałęzień)* |
| `[9]` | **"1970\|Anrica"** | `[32]` **Player**: "You never heard from either of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Player**: "...reconnected with Franc."<br>`[41]` **Player**: "...started writing a memoir." |
| `[10]` | **"...used it as an excuse to cut loose and schmooze with celebrities."** | `[3]` **Narrator**: "With your presidency behind you,..."<br>`[7]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] = false;` | `[44]` **Narrator**: "The team lost more matches in on..."<br>`[53]` **Narrator**: "The team lost more matches in on..."<br>*(oraz 2 innych odgałęzień)* |
| `[11]` | **"1960\|Anrica"** | `[8]` **Player**: "...threw yourself into the role,..." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[13]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **"...vocally supported her."** | `[11]` **Narrator**: "The team won more matches than i..."<br>`[24]` **Narrator**: "The team won more matches than i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[13]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[11]` **Narrator**: "The team won more matches than i..."<br>`[24]` **Narrator**: "The team won more matches than i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[14]` | **"...stayed silent, but used your influence with Anrica conservatives to lobby for h..."** | `[11]` **Narrator**: "The team won more matches than i..."<br>`[24]` **Narrator**: "The team won more matches than i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[24]` | **"1960\|Anrica"** | `[8]` **Player**: "...threw yourself into the role,..." | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[13]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[28]` | **"1960\|Anrica"** | `[8]` **Player**: "...threw yourself into the role,..." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[14]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **"1960\|Anrica"** | `[8]` **Player**: "...threw yourself into the role,..." | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[14]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[30]` | **"...found some racy photos of her you'd once taken, and leaked them to the press."** | `[28]` **Narrator**: "The team won more matches than i..."<br>`[29]` **Narrator**: "The team won more matches than i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "The ensuing scandal cost Monica ..." |
| `[32]` | **"You never heard from either of them ever again."** | `[31]` **Narrator**: "The ensuing scandal cost Monica ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "You spent the swinging '60s amon..." |
| `[38]` | **"1970\|Anrica"** | `[61]` **Player**: "Years went by." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Player**: "...reconnected with Franc."<br>`[41]` **Player**: "...started writing a memoir." |
| `[39]` | **"1970\|Anrica"** | `[62]` **Player**: "Years went by." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Player**: "...reconnected with Franc."<br>`[41]` **Player**: "...started writing a memoir." |
| `[40]` | **"...reconnected with Franc."** | `[9]` **Narrator**: "You spent the swinging '60s amon..."<br>`[38]` **Narrator**: "You spent the swinging '60s amon..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[82]` **Narrator**: "Franc, by now living on a commun..."<br>`[83]` **Narrator**: "Franc, by now living in the Arca..."<br>*(oraz 1 innych odgałęzień)* |
| `[41]` | **"...started writing a memoir."** | `[9]` **Narrator**: "You spent the swinging '60s amon..."<br>`[38]` **Narrator**: "You spent the swinging '60s amon..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[43]` **Narrator**: "Your book, titled 'One For The T..." |
| `[42]` | **"1975\|Bergia"** | `[40]` **Player**: "...reconnected with Franc." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[69]` **Player**: "...never got back into politics."<br>`[71]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **"1960\|Anrica"** | `[10]` **Player**: "...used it as an excuse to cut l..." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[55]` **Player**: "...vocally supported her."<br>`[56]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[48]` | **"1960\|Anrica"** | `[10]` **Player**: "...used it as an excuse to cut l..." | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[55]` **Player**: "...vocally supported her."<br>`[56]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[49]` | **"1960\|Anrica"** | `[10]` **Player**: "...used it as an excuse to cut l..." | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[55]` **Player**: "...vocally supported her."<br>`[56]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[53]` | **"1960\|Anrica"** | `[10]` **Player**: "...used it as an excuse to cut l..." | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[55]` **Player**: "...vocally supported her."<br>`[56]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **"...vocally supported her."** | `[44]` **Narrator**: "The team lost more matches in on..."<br>`[48]` **Narrator**: "The team lost more matches in on..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "You and Monica began speaking to..." |
| `[56]` | **"...stayed silent, but used your remaining political connections to lobby for her c..."** | `[44]` **Narrator**: "The team lost more matches in on..."<br>`[48]` **Narrator**: "The team lost more matches in on..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "You and Monica began speaking to..." |
| `[58]` | **"You never heard from either of them ever again."** | `[60]` **Narrator**: "The ensuing scandal cost Monica ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[64]` **Narrator**: "You spent the swinging '60s atte..." |
| `[59]` | **"...found some racy photos of her you'd once taken, and leaked them to the press."** | `[44]` **Narrator**: "The team lost more matches in on..."<br>`[48]` **Narrator**: "The team lost more matches in on..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "The ensuing scandal cost Monica ..." |
| `[61]` | **"Years went by."** | `[37]` **Narrator**: "You and Monica began speaking to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "You spent the swinging '60s amon..." |
| `[62]` | **"Years went by."** | `[36]` **Narrator**: "Your support buoyed Monica to ne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "You and Monica spent the swingin..." |
| `[63]` | **"Years went by."** | `[57]` **Narrator**: "You and Monica began speaking to..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[64]` **Narrator**: "You spent the swinging '60s atte..." |
| `[64]` | **"1970\|Anrica"** | `[58]` **Player**: "You never heard from either of t..."<br>`[63]` **Player**: "Years went by." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Player**: "...connect with Franc."<br>`[66]` **Player**: "...start writing a memoir." |
| `[66]` | **"...start writing a memoir."** | `[64]` **Narrator**: "You spent the swinging '60s atte..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[65]` **Narrator**: "Your book, titled 'One For The T..." |
| `[67]` | **"...connect with Franc."** | `[64]` **Narrator**: "You spent the swinging '60s atte..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[88]` **Narrator**: "Franc, by now living on a commun..."<br>`[87]` **Narrator**: "Franc, by now living in the Arca..."<br>*(oraz 1 innych odgałęzień)* |
| `[68]` | **"1975\|Bergia"** | `[67]` **Player**: "...connect with Franc." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[76]` **Player**: "...never repaired your marriage ..."<br>`[77]` **Player**: "...didn't take your football car..."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **"...never got back into politics."** | `[42]` **Narrator**: "Franc, by now living on a farm i..."<br>`[82]` **Narrator**: "Franc, by now living on a commun..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[70]` | **"...actually, you had no regrets."** | `[42]` **Narrator**: "Franc, by now living on a farm i..."<br>`[43]` **Narrator**: "Your book, titled 'One For The T..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[71]` | **"...never accomplished your presidential goals."** | `[42]` **Narrator**: "Franc, by now living on a farm i..."<br>`[43]` **Narrator**: "Your book, titled 'One For The T..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[75]` | **"...never reconciled with Franc."** | `[43]` **Narrator**: "Your book, titled 'One For The T..." | `Variable["BaseGame.Relations_Franc_Opinion"] < -2` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[76]` | **"...never repaired your marriage with Monica."** | `[65]` **Narrator**: "Your book, titled 'One For The T..."<br>`[68]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[77]` | **"...didn't take your football career seriously."** | `[65]` **Narrator**: "Your book, titled 'One For The T..."<br>`[68]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[78]` | **"...actually, you had no regrets."** | `[65]` **Narrator**: "Your book, titled 'One For The T..."<br>`[68]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[82]` | **"1975\|United Contana"** | `[40]` **Player**: "...reconnected with Franc." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` | *Brak zmian stanu* | `[69]` **Player**: "...never got back into politics."<br>`[71]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **"1975\|Arcasia"** | `[40]` **Player**: "...reconnected with Franc." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[69]` **Player**: "...never got back into politics."<br>`[71]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[87]` | **"1975\|Arcasia"** | `[67]` **Player**: "...connect with Franc." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[76]` **Player**: "...never repaired your marriage ..."<br>`[77]` **Player**: "...didn't take your football car..."<br>*(oraz 1 innych odgałęzień)* |
| `[88]` | **"1975\|United Contana"** | `[67]` **Player**: "...connect with Franc." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` | *Brak zmian stanu* | `[76]` **Player**: "...never repaired your marriage ..."<br>`[77]` **Player**: "...didn't take your football car..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Anrica.

You and Gus Manger had stayed friendly after his resignation, and he gladly helped install you as manager of the team you co-owned. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "...threw yourself into the role, studying football strate..."*)
  - -> `[10]` (*Player: "...used it as an excuse to cut loose and schmooze with ce..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "With your presidency behind you, you set out to begin you..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "With your presidency behind you, you set out to begin you..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Anrica.

You and Gus Manger had stayed friendly after your term ended, and he gladly helped install you as manager of the team you co-owned. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "...threw yourself into the role, studying football strate..."*)
  - -> `[10]` (*Player: "...used it as an excuse to cut loose and schmooze with ce..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...threw yourself into the role, studying football strategy and using all the tactics that helped you run Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_celebrity");"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s among Sordland's jet-setting elite while propelling FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "...reconnected with Franc."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...used it as an excuse to cut loose and schmooze with celebrities."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Thanks to your popularity, your wife was able to pick up her political career where she had left off.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[13]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[24]` (Narrator), `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your influence with Anrica conservatives to lobby for her cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[24]` (Narrator), `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou = false"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "1960|Anrica"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "1960|Anrica"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Thanks to your popularity, your wife was able to pick up her political career where she had left off.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[13]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "1960|Anrica"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "1960|Anrica"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)
  - -> `[30]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)
  - -> `[30]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator), `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The ensuing scandal cost Monica her political clout. She ..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "You never heard from either of them ever again."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "1970|Anrica"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "Years went by."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "Years went by."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s among Sordland's jet-setting elite while propelling FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "...reconnected with Franc."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples as you propelled FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "...reconnected with Franc."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...reconnected with Franc."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[38]` (Narrator), `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[38]` (Narrator), `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[40]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "...never got back into politics."*)
  - -> `[71]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[70]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How Failing As A President Helped Me Win As A Football Manager", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[70]` (*Player: "...actually, you had no regrets."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "...vocally supported her."*)
  - -> `[56]` (*Player: "...stayed silent, but used your remaining political conne..."*)
  - -> `[59]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "1960|Anrica"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "1960|Anrica"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Your unpopularity in Anrica trounced Monica's hopes of picking up her political advocacy where it had left off. Eventually, she filed for divorce and moved with Deana to Holsord.

Once in the capitol, Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "...vocally supported her."*)
  - -> `[56]` (*Player: "...stayed silent, but used your remaining political conne..."*)
  - -> `[59]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Your unpopularity in Anrica trounced Monica's hopes of picking up her political advocacy where it had left off. Eventually, she filed for divorce and moved with Deana to Holsord.

Once in the capitol, Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "...vocally supported her."*)
  - -> `[56]` (*Player: "...stayed silent, but used your remaining political conne..."*)
  - -> `[59]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "1960|Anrica"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "1960|Anrica"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "...vocally supported her."*)
  - -> `[56]` (*Player: "...stayed silent, but used your remaining political conne..."*)
  - -> `[59]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Retirement_FamilyWithYou"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[48]` (Narrator), `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your remaining political connections to lobby for her cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[48]` (Narrator), `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "Years went by."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[48]` (Narrator), `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The ensuing scandal cost Monica her political clout. She ..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "You never heard from either of them ever again."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "1970|Anrica"*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "1970|Anrica"*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s attempting to ingratiate yourself among Sordland's jet-setting elite as FC Anrica suffered one humiliating defeat after another.

Your money started running out, and Gus persuaded you to sell him your shares in the team. With your ownership stake gone, you were easily forced out as manager.

You used your new spare time to..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player), `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "...connect with Franc."*)
  - -> `[66]` (*Player: "...start writing a memoir."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How I Failed At Both The Presidency And Football", was an instant best-seller, lauded for its unflinching honesty. 

With your reputation saved and your presidency a mere footnote in Sordish history, you lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "...never repaired your marriage with Monica."*)
  - -> `[77]` (*Player: "...didn't take your football career seriously."*)
  - -> `[78]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...start writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...connect with Franc."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent between Anrica and Bergia. You weren't rich, but you were happy to have the love of your family."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "...never repaired your marriage with Monica."*)
  - -> `[77]` (*Player: "...didn't take your football career seriously."*)
  - -> `[78]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[82]` (Narrator), `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[43]` (Narrator), `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[43]` (Narrator), `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "...never reconciled with Franc."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never reconciled with Franc."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never repaired your marriage with Monica."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[68]` (Narrator), `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't take your football career seriously."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[68]` (Narrator), `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[68]` (Narrator), `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "1975|United Contana"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[40]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "...never got back into politics."*)
  - -> `[71]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[70]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[40]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "...never got back into politics."*)
  - -> `[71]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[70]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "1975|Arcasia"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "1975|Bergia"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "...never repaired your marriage with Monica."*)
  - -> `[77]` (*Player: "...didn't take your football career seriously."*)
  - -> `[78]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "...never repaired your marriage with Monica."*)
  - -> `[77]` (*Player: "...didn't take your football career seriously."*)
  - -> `[78]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "1975|United Contana"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

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
  - -> `[87]` (*Narrator: "1975|Arcasia"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "1975|Bergia"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_celebrity");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_celebrity");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "1970|Anrica"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Your book, titled 'One For The Team: How Failing As A Pre..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Your book, titled 'One For The Team: How I Failed At Both..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
