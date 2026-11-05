# Sordland/ANRICA ELECTION ENDING

- **ID konwersacji:** `272`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ANRICA ELECTION ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/272_ANRICA_ELECTION_ENDING.md`
- **Liczba węzłów dialogowych:** 145
- **Liczba wyborów gracza:** 44

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
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Monica_Divorce`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[271] Sordland/Epilogue_ElectionLose** (../Epilogue/271_Epilogue_ElectionLose.md), Węzeł `[2]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"...threw yourself into the role, studying football strategy and using all the tact..."** | `[3]` **Narrator**: "With politics behind you, you se..."<br>`[7]` **Narrator**: "With politics behind you, you se..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_celebrity");`<br>`PrologueImage("pe_monicaspeech");` | `[67]` **Narrator**: "The team won more matches than i..." |
| `[9]` | **"1970\|Anrica"** | `[29]` **Player**: "You never heard from either of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: "...reconnected with Franc."<br>`[38]` **Player**: "...started writing a memoir." |
| `[10]` | **"...used it as an excuse to cut loose and schmooze with celebrities."** | `[3]` **Narrator**: "With politics behind you, you se..."<br>`[7]` **Narrator**: "With politics behind you, you se..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[62]` **Narrator**: "The team lost more matches in on..." |
| `[11]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[13]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **"...vocally supported her."** | `[11]` **Narrator**: "The team won more matches than i..."<br>`[21]` **Narrator**: "The team won more matches than i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[34]` **Narrator**: "You and Monica began speaking to..." |
| `[13]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[11]` **Narrator**: "The team won more matches than i..."<br>`[21]` **Narrator**: "The team won more matches than i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[34]` **Narrator**: "You and Monica began speaking to..." |
| `[14]` | **"...stayed silent, but used your influence with Anrica conservatives to lobby for h..."** | `[11]` **Narrator**: "The team won more matches than i..."<br>`[21]` **Narrator**: "The team won more matches than i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[34]` **Narrator**: "You and Monica began speaking to..." |
| `[21]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[13]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[14]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[26]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Player**: "...vocally supported her."<br>`[14]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[27]` | **"...found some racy photos of her you'd once taken, and leaked them to the press."** | `[25]` **Narrator**: "The team won more matches than i..."<br>`[26]` **Narrator**: "The team won more matches than i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "The ensuing scandal cost Monica ..." |
| `[29]` | **"You never heard from either of them ever again."** | `[28]` **Narrator**: "The ensuing scandal cost Monica ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_celebrity");` | `[9]` **Narrator**: "You spent the swinging '60s amon..." |
| `[35]` | **"1970\|Anrica"** | `[68]` **Player**: "Years went by."<br>`[41]` **Player**: "Years went by." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: "...reconnected with Franc."<br>`[38]` **Player**: "...started writing a memoir." |
| `[36]` | **"1970\|Anrica"** | `[42]` **Player**: "Years went by." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: "...reconnected with Franc."<br>`[38]` **Player**: "...started writing a memoir." |
| `[37]` | **"...reconnected with Franc."** | `[9]` **Narrator**: "You spent the swinging '60s amon..."<br>`[35]` **Narrator**: "You spent the swinging '60s amon..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[98]` **Narrator**: "Franc, by now living on a commun..."<br>`[100]` **Narrator**: "Franc, by now living on a commun..." |
| `[38]` | **"...started writing a memoir."** | `[9]` **Narrator**: "You spent the swinging '60s amon..."<br>`[35]` **Narrator**: "You spent the swinging '60s amon..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[80]` **Narrator**: "Your book, titled 'One For The T..."<br>`[40]` **Narrator**: "Your book, titled 'One For The T..." |
| `[41]` | **"Years went by."** | `[34]` **Narrator**: "You and Monica began speaking to..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_celebrity");` | `[35]` **Narrator**: "You spent the swinging '60s amon..." |
| `[42]` | **"Years went by."** | `[33]` **Narrator**: "Your support buoyed Monica to ne..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_celebrity");` | `[36]` **Narrator**: "You and Monica spent the swingin..." |
| `[43]` | **"1970\|Anrica"** | `[63]` **Player**: "Years went by."<br>`[101]` **Player**: "You never saw either of them eve..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player**: "...connect with Franc."<br>`[45]` **Player**: "...start writing a memoir." |
| `[45]` | **"...start writing a memoir."** | `[43]` **Narrator**: "You spent the swinging '60s atte..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[72]` **Narrator**: "Your book, titled 'One For The T..."<br>`[44]` **Narrator**: "Your book, titled 'One For The T..." |
| `[46]` | **"...connect with Franc."** | `[43]` **Narrator**: "You spent the swinging '60s atte..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[47]` **Narrator**: "Franc, by now living on a farm i..."<br>`[76]` **Narrator**: "Franc, by now living on a farm i..." |
| `[48]` | **"...never got back into politics."** | `[39]` **Narrator**: "Franc, by now living on a farm i..."<br>`[84]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[49]` | **"...actually, you had no regrets."** | `[39]` **Narrator**: "Franc, by now living on a farm i..."<br>`[84]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[50]` | **"...never got back into politics."** | `[40]` **Narrator**: "Your book, titled 'One For The T..."<br>`[80]` **Narrator**: "Your book, titled 'One For The T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[51]` | **"...actually, you had no regrets."** | `[40]` **Narrator**: "Your book, titled 'One For The T..."<br>`[80]` **Narrator**: "Your book, titled 'One For The T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[55]` | **"...never reconciled with Franc."** | `[40]` **Narrator**: "Your book, titled 'One For The T..."<br>`[80]` **Narrator**: "Your book, titled 'One For The T..." | `Variable["BaseGame.Relations_Franc_Opinion"] < -2` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[56]` | **"...never got back into politics."** | `[44]` **Narrator**: "Your book, titled 'One For The T..."<br>`[47]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[57]` | **"...didn't take your football career seriously."** | `[44]` **Narrator**: "Your book, titled 'One For The T..."<br>`[47]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[58]` | **"...actually, you had no regrets."** | `[44]` **Narrator**: "Your book, titled 'One For The T..."<br>`[47]` **Narrator**: "Franc, by now living on a farm i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[62]` | **"1965\|Anrica"** | `[10]` **Player**: "...used it as an excuse to cut l..." | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true` | *Brak zmian stanu* | `[63]` **Player**: "Years went by." |
| `[63]` | **"Years went by."** | `[62]` **Narrator**: "The team lost more matches in on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "You spent the swinging '60s atte..." |
| `[67]` | **"1965\|Anrica"** | `[8]` **Player**: "...threw yourself into the role,..." | `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true` | *Brak zmian stanu* | `[68]` **Player**: "Years went by." |
| `[68]` | **"Years went by."** | `[67]` **Narrator**: "The team won more matches than i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "You spent the swinging '60s amon..." |
| `[101]` | **"You never saw either of them ever again."** | `[119]` **Narrator**: "The ensuing scandal erased most ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[43]` **Narrator**: "You spent the swinging '60s atte..." |
| `[105]` | **"You never talked to Monica again."** | `[115]` **Narrator**: "Your attitude created tensions b..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[43]` **Narrator**: "You spent the swinging '60s atte..." |
| `[114]` | **"...found some racy photos you'd once taken of her, and leaked them to the press."** | `[129]` **Narrator**: "The team lost more matches in on..."<br>`[130]` **Narrator**: "The team lost more matches in on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "The ensuing scandal erased most ..." |
| `[118]` | **"Years went by."** | `[113]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[116]` **Narrator**: "Monica raised herself to new hei..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_loss");` | `[43]` **Narrator**: "You spent the swinging '60s atte..." |
| `[121]` | **"...stayed silent."** | `[124]` **Narrator**: "The team lost more matches in on..."<br>`[128]` **Narrator**: "The team lost more matches in on..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "Monica raised herself to new hei..." |
| `[122]` | **"...advised her to stop."** | `[124]` **Narrator**: "The team lost more matches in on..."<br>`[128]` **Narrator**: "The team lost more matches in on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "Monica ignored you and in time, ..."<br>`[115]` **Narrator**: "Your attitude created tensions b..." |
| `[123]` | **"...vocally supported her."** | `[124]` **Narrator**: "The team lost more matches in on..."<br>`[128]` **Narrator**: "The team lost more matches in on..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[120]` **Narrator**: "You and Monica began speaking to..." |
| `[124]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: "...vocally supported her."<br>`[121]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[128]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: "...vocally supported her."<br>`[121]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[129]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: "...vocally supported her."<br>`[121]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |
| `[130]` | **"1960\|Anrica"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: "...vocally supported her."<br>`[121]` **Player**: "...stayed silent."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "With politics behind you, you set out to begin your new life in Anrica.

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
  - -> `[3]` (*Narrator: "With politics behind you, you set out to begin your new l..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "With politics behind you, you set out to begin your new l..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "With politics behind you, you set out to begin your new life in Anrica.

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
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s among Sordland's jet-setting elite while propelling FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "...reconnected with Franc."*)
  - -> `[38]` (*Player: "...started writing a memoir."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...used it as an excuse to cut loose and schmooze with celebrities."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Thanks to your popularity, your wife was able to pick up her political career where she had left off.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[13]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[21]` (Narrator), `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your influence with Anrica conservatives to lobby for her cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[21]` (Narrator), `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "1960|Anrica"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1960|Anrica"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Thanks to your popularity, your wife was able to pick up her political career where she had left off.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[13]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "1960|Anrica"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "1960|Anrica"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)
  - -> `[27]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...vocally supported her."*)
  - -> `[14]` (*Player: "...stayed silent, but used your influence with Anrica con..."*)
  - -> `[27]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "The ensuing scandal cost Monica her political clout. She ..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "You never heard from either of them ever again."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_celebrity");"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "Years went by."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Years went by."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s among Sordland's jet-setting elite while propelling FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Player), `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "...reconnected with Franc."*)
  - -> `[38]` (*Player: "...started writing a memoir."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples as you propelled FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "...reconnected with Franc."*)
  - -> `[38]` (*Player: "...started writing a memoir."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...reconnected with Franc."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...never got back into politics."*)
  - -> `[49]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How Failing As A President Helped Me Win As A Football Manager", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "...never got back into politics."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[51]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_celebrity");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_celebrity");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s attempting to ingratiate yourself among Sordland's jet-setting elite as FC Anrica suffered one humiliating defeat after another.

Your money started running out, and Gus persuaded you to sell him your shares in the team. With your ownership stake gone, you were easily forced out as manager.

You used your new spare time to..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Player), `[101]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "...connect with Franc."*)
  - -> `[45]` (*Player: "...start writing a memoir."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How I Failed At Both The Presidency And Football", was an instant best-seller, lauded for its unflinching honesty. 

With your reputation saved and your presidency a mere footnote in Sordish history, you lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...never got back into politics."*)
  - -> `[57]` (*Player: "...didn't take your football career seriously."*)
  - -> `[58]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...start writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...connect with Franc."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent between Anrica and Bergia. You weren't rich, but you were happy to have the love of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...never got back into politics."*)
  - -> `[57]` (*Player: "...didn't take your football career seriously."*)
  - -> `[58]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator), `[84]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator), `[84]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "...never reconciled with Franc."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never reconciled with Franc."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[47]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't take your football career seriously."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[47]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[47]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_LateRetire == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "1965|Anrica"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_LateRetire == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "1965|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "Years went by."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "1970|Anrica"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_LateRetire == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_celebrity");"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_LateRetire == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "1965|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "Years went by."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "1970|Anrica"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Your book, titled 'One For The Team: How I Failed At Both..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Your book, titled 'One For The Team: How I Failed At Both..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How I Failed At Both The Presidency And Football", was an instant best-seller, lauded for its unflinching honesty. 

With your reputation saved and your presidency a mere footnote in Sordish history, you lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...never got back into politics."*)
  - -> `[57]` (*Player: "...didn't take your football career seriously."*)
  - -> `[58]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Franc, by now living on a farm in Bergia with his wife an..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Franc, by now living on a farm in Bergia with his wife an..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent between Anrica and Bergia. You weren't rich, but you were happy to have the love of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...never got back into politics."*)
  - -> `[57]` (*Player: "...didn't take your football career seriously."*)
  - -> `[58]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Your book, titled 'One For The Team: How Failing As A Pre..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Your book, titled 'One For The Team: How Failing As A Pre..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How Failing As A President Helped Me Win As A Football Manager", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "...never got back into politics."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[51]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...never got back into politics."*)
  - -> `[49]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Franc, by now living on a commune in United Contana with ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Franc, by now living in the Arcasian suburbs with his wif..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Franc, by now living on a farm in Bergia with his wife an..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Franc, by now living on a commune in United Contana with ..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Franc, by now living in the Arcasian suburbs with his wif..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Franc, by now living on a farm in Bergia with his wife an..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...never got back into politics."*)
  - -> `[49]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...never got back into politics."*)
  - -> `[49]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...never got back into politics."*)
  - -> `[49]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...never got back into politics."*)
  - -> `[49]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Monica ignored you and in time, raised herself to new hei..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Your attitude created tensions between you and Monica. Te..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "You never talked to Monica again."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "Years went by."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Narrator), `[130]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "The ensuing scandal erased most of Monica's political clo..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce = true"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "Years went by."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Monica ignored you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "Years went by."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator), `[116]` (Narrator), `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "You never saw either of them ever again."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "Years went by."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator), `[128]` (Narrator), `[129]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Monica raised herself to new heights. She was becoming th..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator), `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator), `[128]` (Narrator), `[129]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Your unpopularity in Anrica trounced Monica's hopes of picking up her political advocacy where it had left off.

Once in the capitol, Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "...vocally supported her."*)
  - -> `[121]` (*Player: "...stayed silent."*)
  - -> `[122]` (*Player: "...advised her to stop."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "1960|Anrica"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "1960|Anrica"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Your unpopularity in Anrica trounced Monica's hopes of picking up her political advocacy where it had left off.

Once in the capitol, Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "...vocally supported her."*)
  - -> `[121]` (*Player: "...stayed silent."*)
  - -> `[122]` (*Player: "...advised her to stop."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "...vocally supported her."*)
  - -> `[121]` (*Player: "...stayed silent."*)
  - -> `[114]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "...vocally supported her."*)
  - -> `[121]` (*Player: "...stayed silent."*)
  - -> `[114]` (*Player: "...found some racy photos you'd once taken of her, and le..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "1960|Anrica"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "1960|Anrica"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_celebrity");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_celebrity");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "1965|Anrica"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_celebrity");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_celebrity");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "1970|Anrica"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_celebrity");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_celebrity");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "1970|Anrica"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_celebrity");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_celebrity");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "1970|Anrica"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "1970|Anrica"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
