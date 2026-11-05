# Sordland/ERLORY ENDING

- **ID konwersacji:** `268`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ERLORY ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/268_ERLORY_ENDING.md`
- **Liczba węzłów dialogowych:** 104
- **Liczba wyborów gracza:** 37

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
- `BaseGame.Petr_Dead`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Party`
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Party`
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"1960\|Erlory"** | `[10]` **Player**: "...resumed wine production." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Player**: "You happily sampled your own goods."<br>`[55]` **Player**: "You stayed sober." |
| `[7]` | **"1960\|Erlory"** | `[14]` **Player**: "...used the space to host fabulo..." | `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false` | *Brak zmian stanu* | `[57]` **Player**: "You stayed clean and networked."<br>`[56]` **Player**: "You indulged in the party lifest..." |
| `[8]` | **"1960\|Erlory"** | `[14]` **Player**: "...used the space to host fabulo..." | `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false) == false` | *Brak zmian stanu* | `[57]` **Player**: "You stayed clean and networked."<br>`[56]` **Player**: "You indulged in the party lifest..." |
| `[10]` | **"...resumed wine production."** | `[9]` **Narrator**: "With your presidency behind you,..."<br>`[73]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Win...`<br>`PrologueImage("pe_relaxed");` | `[3]` **Narrator**: "You didn't know much about winem..." |
| `[14]` | **"...used the space to host fabulous parties."** | `[9]` **Narrator**: "With your presidency behind you,..."<br>`[73]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_party");` | `[7]` **Narrator**: "Between your villa and Petr's ac..."<br>`[8]` **Narrator**: "Your villa became a gathering po..." |
| `[25]` | **"...stayed silent, but used your remaining political influence to lobby for her cause."** | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[18]` **Narrator**: "You and Monica began speaking to..." |
| `[26]` | **"Years went by."** | `[18]` **Narrator**: "You and Monica began speaking to..."<br>`[34]` **Narrator**: "Your support buoyed Monica to ne..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_city");`<br>`PrologueImage("pe_drinking");`<br>*(+1 skryptów)* | `[40]` **Narrator**: "You and Monica spent the swingin..."<br>`[68]` **Narrator**: "You and Monica spent the swingin..."<br>*(oraz 2 innych odgałęzień)* |
| `[27]` | **"You never heard from either of them ever again."** | `[39]` **Narrator**: "The ensuing scandal cost Monica ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_drinking");`<br>`PrologueImage("pe_loss");` | `[47]` **Narrator**: "Years of heavy partying took the..."<br>`[64]` **Narrator**: "Though you hadn't meant to get c..." |
| `[28]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[18]` **Narrator**: "You and Monica began speaking to..." |
| `[29]` | **"...vocally supported her."** | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[18]` **Narrator**: "You and Monica began speaking to..." |
| `[30]` | **"1962\|Erlory"** | `[55]` **Player**: "You stayed sober."<br>`[57]` **Player**: "You stayed clean and networked."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[29]` **Player**: "...vocally supported her."<br>`[28]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[31]` | **"1962\|Erlory"** | `[55]` **Player**: "You stayed sober."<br>`[57]` **Player**: "You stayed clean and networked."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[29]` **Player**: "...vocally supported her."<br>`[28]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[32]` | **"1962\|Erlory"** | `[55]` **Player**: "You stayed sober."<br>`[57]` **Player**: "You stayed clean and networked."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[29]` **Player**: "...vocally supported her."<br>`[25]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **"1962\|Erlory"** | `[55]` **Player**: "You stayed sober."<br>`[57]` **Player**: "You stayed clean and networked."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[29]` **Player**: "...vocally supported her."<br>`[25]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[35]` | **"...found some racy photos of her you'd once taken, and leaked them to the press."** | `[32]` **Narrator**: "At one of your gatherings, you h..."<br>`[33]` **Narrator**: "At one of your gatherings, you h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "The ensuing scandal cost Monica ..." |
| `[40]` | **"1970\|Erlory"** | `[26]` **Player**: "Years went by." | `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[42]` **Player**: "...reconnected with Franc."<br>`[43]` **Player**: "...started writing a memoir." |
| `[42]` | **"...reconnected with Franc."** | `[40]` **Narrator**: "You and Monica spent the swingin..."<br>`[68]` **Narrator**: "You and Monica spent the swingin..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[90]` **Narrator**: "Franc, by now living on a commun..."<br>`[91]` **Narrator**: "Franc, by now living in the Arca..."<br>*(oraz 1 innych odgałęzień)* |
| `[43]` | **"...started writing a memoir."** | `[40]` **Narrator**: "You and Monica spent the swingin..."<br>`[68]` **Narrator**: "You and Monica spent the swingin..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[41]` **Narrator**: "Your book, titled 'Purple Rayne:..."<br>`[72]` **Narrator**: "Your book, titled 'Suzerain: The..." |
| `[47]` | **"1970\|Erlory"** | `[27]` **Player**: "You never heard from either of t..."<br>`[26]` **Player**: "Years went by." | `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[48]` **Player**: "...asked your son if you could m..."<br>`[49]` **Player**: "...checked yourself into rehab a..." |
| `[48]` | **"...asked your son if you could move in with him."** | `[47]` **Narrator**: "Years of heavy partying took the..."<br>`[64]` **Narrator**: "Though you hadn't meant to get c..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[82]` **Narrator**: "Franc, by now living on a commun..."<br>`[81]` **Narrator**: "Franc, by now living in the Arca..."<br>*(oraz 1 innych odgałęzień)* |
| `[49]` | **"...checked yourself into rehab and began working on your memoir."** | `[47]` **Narrator**: "Years of heavy partying took the..."<br>`[64]` **Narrator**: "Though you hadn't meant to get c..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[50]` **Narrator**: "Your book, titled "Marooned: How..." |
| `[50]` | **"1975\|Benfi"** | `[49]` **Player**: "...checked yourself into rehab a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |
| `[51]` | **"...never got back into politics."** | `[41]` **Narrator**: "Your book, titled 'Purple Rayne:..."<br>`[50]` **Narrator**: "Your book, titled "Marooned: How..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[52]` | **"...never accomplished your presidential goals."** | `[41]` **Narrator**: "Your book, titled 'Purple Rayne:..."<br>`[50]` **Narrator**: "Your book, titled "Marooned: How..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[53]` | **"...actually, you had no regrets."** | `[41]` **Narrator**: "Your book, titled 'Purple Rayne:..."<br>`[50]` **Narrator**: "Your book, titled "Marooned: How..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[54]` | **"You happily sampled your own goods."** | `[3]` **Narrator**: "You didn't know much about winem..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Par...`<br>`PrologueImage("pe_monicaspeech");`<br>*(+1 skryptów)* | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..."<br>*(oraz 2 innych odgałęzień)* |
| `[55]` | **"You stayed sober."** | `[3]` **Narrator**: "You didn't know much about winem..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");`<br>`PrologueImage("pe_monicaspeech");` | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..."<br>*(oraz 2 innych odgałęzień)* |
| `[56]` | **"You indulged in the party lifestyle."** | `[7]` **Narrator**: "Between your villa and Petr's ac..."<br>`[8]` **Narrator**: "Your villa became a gathering po..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Par...`<br>`PrologueImage("pe_monicaspeech");`<br>*(+1 skryptów)* | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..."<br>*(oraz 2 innych odgałęzień)* |
| `[57]` | **"You stayed clean and networked."** | `[7]` **Narrator**: "Between your villa and Petr's ac..."<br>`[8]` **Narrator**: "Your villa became a gathering po..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");`<br>`PrologueImage("pe_monicaspeech");` | `[30]` **Narrator**: "Your wife, sensing an opportunit..."<br>`[31]` **Narrator**: "Your wife, sensing an opportunit..."<br>*(oraz 2 innych odgałęzień)* |
| `[64]` | **"1970\|Erlory"** | `[27]` **Player**: "You never heard from either of t..."<br>`[26]` **Player**: "Years went by." | `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true) == false`<br>`(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[48]` **Player**: "...asked your son if you could m..."<br>`[49]` **Player**: "...checked yourself into rehab a..." |
| `[68]` | **"1970\|Erlory"** | `[26]` **Player**: "Years went by." | `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[42]` **Player**: "...reconnected with Franc."<br>`[43]` **Player**: "...started writing a memoir." |
| `[80]` | **"1975\|Bergia"** | `[48]` **Player**: "...asked your son if you could m..." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |
| `[81]` | **"1975\|Arcasia"** | `[48]` **Player**: "...asked your son if you could m..." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **"1975\|United Contana"** | `[48]` **Player**: "...asked your son if you could m..." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |
| `[86]` | **"1975\|Bergia"** | `[42]` **Player**: "...reconnected with Franc." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |
| `[90]` | **"1975\|United Contana"** | `[42]` **Player**: "...reconnected with Franc." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |
| `[91]` | **"1975\|Arcasia"** | `[42]` **Player**: "...reconnected with Franc." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[52]` **Player**: "...never accomplished your presi..."<br>`[51]` **Player**: "...never got back into politics."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "1960|Erlory"]** — Mówca: **Narrator**
> "You didn't know much about winemaking, but the vineyard's staff did. Rayne Wines gained a reputation as some of Sordland's finest.

As you opened the villa up for tastings, Erlory became a gathering point for the Sordland elite."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "You happily sampled your own goods."*)
  - -> `[55]` (*Player: "You stayed sober."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything == true || BaseGame.Turn08_SecondScandal_ShareBlame == true || BaseGame.Turn08_SecondScandal_LiviaInvestigated == false && BaseGame.Petr_Dead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true || B..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_DenyEverything == true ||..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything == true || BaseGame.Turn08_SecondScandal_ShareBlame == true || BaseGame.Turn08_SecondScandal_LiviaInvestigated == false && BaseGame.Petr_Dead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "1960|Erlory"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_DenyEverything == true || BaseGame.Turn08_SecondScandal_ShareBlame == true || BaseGame.Turn08_SecondScandal_LiviaInvestigated == false && BaseGame.Petr_Dead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "1960|Erlory"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "1960|Erlory"]** — Mówca: **Narrator**
> "Between your villa and Petr's across town, Erlory became a gathering point for the Sordland elite."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "You stayed clean and networked."*)
  - -> `[56]` (*Player: "You indulged in the party lifestyle."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "1960|Erlory"]** — Mówca: **Narrator**
> "Your villa became a gathering point for the Sordland elite."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "You stayed clean and networked."*)
  - -> `[56]` (*Player: "You indulged in the party lifestyle."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Erlory.

Your villa in Erlory wasn't quite as grand as Petr's, but it was spacious and calm, the perfect refuge after the chaos of Holsord.

You and your family..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "...resumed wine production."*)
  - -> `[14]` (*Player: "...used the space to host fabulous parties."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...resumed wine production."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Wine = true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "With your presidency behind you, you set out to begin you..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "With your presidency behind you, you set out to begin you..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...used the space to host fabulous parties."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_party");"*)

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
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "Years went by."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGam..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "1962|Erlory"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "1962|Erlory"*)

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
  - -> `[32]` (*Narrator: "1962|Erlory"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "1962|Erlory"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your remaining political influence to lobby for her cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator), `[31]` (Narrator), `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator), `[31]` (Narrator), `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "Your wife, sensing an opportunity, parlayed these new connections into a second attempt at a political career. 

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[57]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...vocally supported her."*)
  - -> `[28]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[25]` (*Player: "...stayed silent, but used your remaining political influ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "Your wife, sensing an opportunity, parlayed these new connections into a second attempt at a political career. 

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[57]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...vocally supported her."*)
  - -> `[28]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[25]` (*Player: "...stayed silent, but used your remaining political influ..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "At one of your gatherings, you heard a rumor that your ex-wife was getting back into politics. It turned out to be true.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[57]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...vocally supported her."*)
  - -> `[25]` (*Player: "...stayed silent, but used your remaining political influ..."*)
  - -> `[35]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "At one of your gatherings, you heard a rumor that your ex-wife was getting back into politics. It turned out to be true.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[57]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...vocally supported her."*)
  - -> `[25]` (*Player: "...stayed silent, but used your remaining political influ..."*)
  - -> `[35]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "Years went by."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The ensuing scandal cost Monica her political clout. She ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Your support buoyed Monica to new heights. People began r..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "You and Monica began speaking to each other again, althou..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "You never heard from either of them ever again."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with celebrities as you promoted your wines and her causes.

Eventually, you decided to settle down. You handed over control of the wine business and..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "...reconnected with Franc."*)
  - -> `[43]` (*Player: "...started writing a memoir."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Your book, titled 'Purple Rayne: How I Failed The Presidency But Won At Wine", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...reconnected with Franc."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "Years of heavy partying took their toll on you.

By the end of the swinging '60s, you were strung out and losing money fast. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Player), `[26]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...asked your son if you could move in with him."*)
  - -> `[49]` (*Player: "...checked yourself into rehab and began working on your ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...asked your son if you could move in with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...checked yourself into rehab and began working on your memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Marooned: How I Quit Both The Presidency And Booze", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days at your leafy villa, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[50]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[50]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[50]` (Narrator), `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You happily sampled your own goods."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Party = true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You stayed sober."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You indulged in the party lifestyle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Party = true"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You stayed clean and networked."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed");"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Party = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Party = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_drinking");"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "Though you hadn't meant to get caught up in the party lifestyle, the swinging '60s took their toll on you.

By the end of the decade, you were strung out and losing money fast. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true) == false` AND `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Player), `[26]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "...asked your son if you could move in with him."*)
  - -> `[49]` (*Player: "...checked yourself into rehab and began working on your ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "1970|Erlory"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "1970|Erlory"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with celebrities as you promoted her causes.

Eventually, you decided to settle down. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true) == false` AND `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "...reconnected with Franc."*)
  - -> `[43]` (*Player: "...started writing a memoir."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Your book, titled 'Purple Rayne: How I Failed The Preside..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Your book, titled 'Suzerain: The Real Story Of The Anton ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Your book, titled 'Suzerain: The Real Story Of The Anton Rayne Presidency", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Erlory.

Your villa in Erlory wasn't quite as grand as Petr's, but it was spacious and calm, the perfect refuge after the chaos of Holsord.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "...resumed wine production."*)
  - -> `[14]` (*Player: "...used the space to host fabulous parties."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "1975|United Contana"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "1975|Arcasia"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "1975|Bergia"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent in Bergia. You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "1975|United Contana"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent in Bergia. You weren't rich, but you were happy to have the love of your family."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "1975|Arcasia"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "1975|Bergia"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[51]` (*Player: "...never got back into politics."*)
  - -> `[53]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "1960|Erlory"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_party");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_party");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true || B..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_drinking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_drinking");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "1970|Erlory"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "1970|Erlory"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "1975|Benfi"*)
