# Sordland/BENFI ENDING

- **ID konwersacji:** `267`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (BENFI ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/267_BENFI_ENDING.md`
- **Liczba węzłów dialogowych:** 132
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
- `BaseGame.PersonalWealth`
- `BaseGame.Petr_Dead`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`
- `BaseGameIsolated.Epilogue_Retirement_Partying`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Memoir`
- `BaseGameIsolated.Epilogue_Retirement_Partying`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"...a luxurious beach house."** | `[9]` **Narrator**: "With your presidency behind you,..." | `Variable["BaseGame.PersonalWealth"] > 2` | *Brak zmian stanu* | `[10]` **Narrator**: "Your new home had everything you..." |
| `[7]` | **"...a modest condominium."** | `[9]` **Narrator**: "With your presidency behind you,..." | `(Variable["BaseGame.PersonalWealth"] > 2) == false` | *Brak zmian stanu* | `[11]` **Narrator**: "It was a far cry from the luxury..." |
| `[8]` | **"...a cozy cottage."** | `[9]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "It was a far cry from the luxury..." |
| `[12]` | **"...became an adjunct professor of politics at Benfi University."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");` | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych odgałęzień)* |
| `[13]` | **"...started writing a memoir."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] =...`<br>`PrologueImage("pe_monicaspeech");` | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych odgałęzień)* |
| `[17]` | **"...started hosting fabulous gatherings."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false` | `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"]...`<br>`PrologueImage("pe_monicaspeech");` | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych odgałęzień)* |
| `[21]` | **"...hit the clubs."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | `(Variable["BaseGame.Petr_Dead"] == false) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == false` | `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"]...`<br>`PrologueImage("pe_monicaspeech");` | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych odgałęzień)* |
| `[22]` | **"...called up Petr and hit the clubs."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | `Variable["BaseGame.Petr_Dead"] == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == false` | `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"]...`<br>`PrologueImage("pe_monicaspeech");` | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych odgałęzień)* |
| `[23]` | **"You never heard from either of them ever again."** | `[36]` **Narrator**: "The ensuing scandal cost Monica ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_coast");` | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." |
| `[30]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[32]` | **"1960\|Benfi"** | `[12]` **Player**: "...became an adjunct professor o..."<br>`[17]` **Player**: "...started hosting fabulous gath..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[30]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **"1960\|Benfi"** | `[12]` **Player**: "...became an adjunct professor o..."<br>`[17]` **Player**: "...started hosting fabulous gath..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[30]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **"1960\|Benfi"** | `[12]` **Player**: "...became an adjunct professor o..."<br>`[17]` **Player**: "...started hosting fabulous gath..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[39]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[35]` | **"1960\|Benfi"** | `[12]` **Player**: "...became an adjunct professor o..."<br>`[17]` **Player**: "...started hosting fabulous gath..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[39]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **"...vocally supported her."** | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[39]` | **"...stayed silent, but used your remaining political influence to lobby for her cause."** | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[46]` | **"...found some racy photos of her you'd once taken, and leaked them to the press."** | `[34]` **Narrator**: "As your star faded, your ex-wife..."<br>`[35]` **Narrator**: "As your star faded, your ex-wife..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "The ensuing scandal cost Monica ..." |
| `[47]` | **"Years went by."** | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_coast");` | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." |
| `[48]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Player**: "You had never felt so close to y..." |
| `[56]` | **"1970\|Benfi"** | `[23]` **Player**: "You never heard from either of t..."<br>`[47]` **Player**: "Years went by." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true` | *Brak zmian stanu* | `[58]` **Player**: "...asked your son if you could m..."<br>`[59]` **Player**: "...checked yourself into rehab a..." |
| `[58]` | **"...asked your son if you could move in with him."** | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "Franc, by now living on a commun..."<br>`[97]` **Narrator**: "Franc, by now living in the Arca..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"...checked yourself into rehab and began working on your memoir."** | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "Your book, titled "Raynespotting..." |
| `[63]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: "You were happy to reconnect with..."<br>`[78]` **Player**: "You didn't respond." |
| `[64]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: "...never got back into politics."<br>`[81]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[68]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: "...never got back into politics."<br>`[81]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[72]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Player**: "Anton Rayne was famous once more." |
| `[76]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Player**: "You had never felt so close to y..." |
| `[77]` | **"You were happy to reconnect with him."** | `[63]` **Narrator**: "After years of publication delay..."<br>`[108]` **Narrator**: "After years of publication delay..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "You lived out the rest of your d..." |
| `[78]` | **"You didn't respond."** | `[63]` **Narrator**: "After years of publication delay..."<br>`[108]` **Narrator**: "After years of publication delay..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "You lived out the rest of your d..." |
| `[79]` | **"Anton Rayne was famous once more."** | `[72]` **Narrator**: "After years of publication delay..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "You lived out the rest of your d..." |
| `[80]` | **"...never got back into politics."** | `[64]` **Narrator**: "Your teaching career, though ung..."<br>`[68]` **Narrator**: "Your teaching career, though ung..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[81]` | **"...never accomplished your presidential goals."** | `[64]` **Narrator**: "Your teaching career, though ung..."<br>`[68]` **Narrator**: "Your teaching career, though ung..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[82]` | **"...actually, you had no regrets."** | `[64]` **Narrator**: "Your teaching career, though ung..."<br>`[68]` **Narrator**: "Your teaching career, though ung..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[84]` | **"You had never felt so close to your family."** | `[48]` **Narrator**: "You and Monica spent the swingin..."<br>`[76]` **Narrator**: "You and Monica spent the swingin..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "After receiving multiple lifetim..." |
| `[85]` | **"1980\|Benfi"** | `[84]` **Player**: "You had never felt so close to y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Player**: "...never got back into politics."<br>`[87]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[86]` | **"...never got back into politics."** | `[85]` **Narrator**: "After receiving multiple lifetim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[87]` | **"...never accomplished your presidential goals."** | `[85]` **Narrator**: "After receiving multiple lifetim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[88]` | **"...actually, you had no regrets."** | `[85]` **Narrator**: "After receiving multiple lifetim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[89]` | **"1975\|Benfi"** | `[59]` **Player**: "...checked yourself into rehab a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player**: "...never accomplished your presi..."<br>`[92]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[90]` | **"...never mended your marriage with Monica."** | `[89]` **Narrator**: "Your book, titled "Raynespotting..."<br>`[96]` **Narrator**: "Franc, by now living on a commun..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Retirement_FamilyWithYou"] == false` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[91]` | **"...never accomplished your presidential goals."** | `[89]` **Narrator**: "Your book, titled "Raynespotting..."<br>`[96]` **Narrator**: "Franc, by now living on a commun..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[92]` | **"...actually, you had no regrets."** | `[89]` **Narrator**: "Your book, titled "Raynespotting..."<br>`[96]` **Narrator**: "Franc, by now living on a commun..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[108]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: "You were happy to reconnect with..."<br>`[78]` **Player**: "You didn't respond." |
| `[109]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: "You were happy to reconnect with..."<br>`[78]` **Player**: "You didn't respond." |
| `[119]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: "...never got back into politics."<br>`[81]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[120]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: "...never got back into politics."<br>`[81]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[127]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Player**: "You had never felt so close to y..." |
| `[128]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Player**: "You had never felt so close to y..." |

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
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coast");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 2"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 2)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "...a luxurious beach house."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "...a modest condominium."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a luxurious beach house."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Your new home had everything your heart desired. You love..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a modest condominium."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "It was a far cry from the luxury you'd enjoyed in Holsord..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a cozy cottage."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "It was a far cry from the luxury you'd enjoyed in Holsord..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Benfi. You moved into..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 2"*)
  - -> `[8]` (*Player: "...a cozy cottage."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Your new home had everything your heart desired. You loved waking up and falling asleep to the sound of the waves.

You couldn't stay idle for long, though. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...became an adjunct professor of politics at Benfi Unive..."*)
  - -> `[13]` (*Player: "...started writing a memoir."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "It was a far cry from the luxury you'd enjoyed in Holsord, but you loved waking up to the sound of the waves.

You couldn't stay idle for long, though. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...became an adjunct professor of politics at Benfi Unive..."*)
  - -> `[13]` (*Player: "...started writing a memoir."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Benfi University."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir = true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == false)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == false"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "...started hosting fabulous gatherings."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started hosting fabulous gatherings."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying = true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == false"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Petr_Dead == false)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Petr_Dead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "...called up Petr and hit the clubs."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Petr_Dead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Petr_Dead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "...hit the clubs."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...hit the clubs."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Petr_Dead"] == false) == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying = true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...called up Petr and hit the clubs."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Petr_Dead"] == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coast");"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "1960|Benfi"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "1960|Benfi"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "Years went by."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your wife's rose.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[12]` (Player), `[17]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[30]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your wife's rose.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[12]` (Player), `[17]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[30]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your ex-wife's rose.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[12]` (Player), `[17]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)
  - -> `[46]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your ex-wife's rose.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[12]` (Player), `[17]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)
  - -> `[46]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage in the Erlory countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "You never heard from either of them ever again."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "Years went by."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your remaining political influence to lobby for her cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "1960|Benfi"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "1960|Benfi"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The ensuing scandal cost Monica her political clout. She ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coast");"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Eventually you managed to reconcile with Franc."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Partying = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Partying == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Partying == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Partying == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Partying == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_P..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "1970|Benfi"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your hard-partying lifestyle began to take its toll. Strung out and losing money fast, you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[47]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "...asked your son if you could move in with him."*)
  - -> `[59]` (*Player: "...checked yourself into rehab and began working on your ..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...asked your son if you could move in with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...checked yourself into rehab and began working on your memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "1975|Benfi"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 2"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "You were happy to reconnect with him."*)
  - -> `[78]` (*Player: "You didn't respond."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a farm in Bergia with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "...never got back into politics."*)
  - -> `[81]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[82]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 2"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion > 2)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "1970|Benfi"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

You even managed to reconcile with Franc.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "...never got back into politics."*)
  - -> `[81]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[82]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "1970|Benfi"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "Anton Rayne was famous once more."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_P..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2  or Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "1970|Benfi"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2  or Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living on a farm in Bergia with his wife and son, occasionally came for visits."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator), `[108]` (Narrator), `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "You lived out the rest of your days in wealth and comfort..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator), `[108]` (Narrator), `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "You lived out the rest of your days in wealth and comfort..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Anton Rayne was famous once more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "You lived out the rest of your days in wealth and comfort..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[68]` (Narrator), `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[68]` (Narrator), `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[68]` (Narrator), `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort by the seaside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "...never got back into politics."*)
  - -> `[81]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[82]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had never felt so close to your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[76]` (Narrator), `[127]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "1980|Benfi"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "1980|Benfi"]** — Mówca: **Narrator**
> "After receiving multiple lifetime achievement awards for her women's rights work, Monica decided to finally take a break. The two of you spent the rest of your days in leisure by the seaside.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "...never got back into politics."*)
  - -> `[87]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[88]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Raynespotting: How I Quit Both The Presidency And Drugs", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days by the seaside, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)
  - -> `[91]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[92]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never mended your marriage with Monica."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator), `[96]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator), `[96]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator), `[96]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == false)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "...never mended your marriage with Monica."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)
  - -> `[91]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[92]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)
  - -> `[91]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[92]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent between in Bergia. You weren't rich, but you were happy to have the love of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == false"*)
  - -> `[91]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[92]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Franc, by now living on a commune in United Contana with ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Franc, by now living in the Arcasian suburbs with his wif..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Franc, by now living on a farm in Bergia with his wife an..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "1970|Benfi"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "You were happy to reconnect with him."*)
  - -> `[78]` (*Player: "You didn't respond."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "You were happy to reconnect with him."*)
  - -> `[78]` (*Player: "You didn't respond."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "1970|Benfi"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "1970|Benfi"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "1970|Benfi"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "1970|Benfi"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "1970|Benfi"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living in the Arcasian suburbs with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "...never got back into politics."*)
  - -> `[81]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[82]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a commune in United Contana with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "...never got back into politics."*)
  - -> `[81]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[82]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "1970|Benfi"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "1970|Benfi"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "1970|Benfi"*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living in the Arcasian suburbs with his wife and son, occasionally came for visits."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living in a commune in United Contana with his wife and son, occasionally came for visits."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coast");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "With your presidency behind you, you set out to begin you..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coast");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying == true"*)
