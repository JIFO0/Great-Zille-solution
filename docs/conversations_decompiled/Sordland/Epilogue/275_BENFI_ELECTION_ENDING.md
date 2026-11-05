# Sordland/BENFI ELECTION ENDING

- **ID konwersacji:** `275`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (BENFI ELECTION ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/275_BENFI_ELECTION_ENDING.md`
- **Liczba węzłów dialogowych:** 186
- **Liczba wyborów gracza:** 62

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
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`
- `BaseGameIsolated.Epilogue_Retirement_Partying`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Memoir`
- `BaseGameIsolated.Epilogue_Retirement_Partying`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[271] Sordland/Epilogue_ElectionLose** (../Epilogue/271_Epilogue_ElectionLose.md), Węzeł `[2]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"...a luxurious beach house."** | `[9]` **Narrator**: "With your presidency behind you,..." | `Variable["BaseGame.PersonalWealth"] > 2` | *Brak zmian stanu* | `[10]` **Narrator**: "Your new home had everything you..." |
| `[7]` | **"...a modest condominium."** | `[9]` **Narrator**: "With your presidency behind you,..." | `(Variable["BaseGame.PersonalWealth"] > 2) == false` | *Brak zmian stanu* | `[11]` **Narrator**: "It was a far cry from the luxury..." |
| `[8]` | **"...a cozy cottage."** | `[9]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "It was a far cry from the luxury..." |
| `[12]` | **"...became an adjunct professor of politics at Benfi University."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_monicaspeech");`<br>`PrologueImage("pe_blue");`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[13]` | **"...started writing a memoir."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] =...`<br>`PrologueImage("pe_monicaspeech");` | *Koniec sceny / Terminal* |
| `[17]` | **"...started hosting fabulous gatherings."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false` | `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"]...`<br>`PrologueImage("pe_monicaspeech");` | *Koniec sceny / Terminal* |
| `[21]` | **"...hit the clubs."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | `(Variable["BaseGame.Petr_Dead"] == false) == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == false` | `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"]...`<br>`PrologueImage("pe_monicaspeech");` | *Koniec sceny / Terminal* |
| `[22]` | **"...called up Petr and hit the clubs."** | `[10]` **Narrator**: "Your new home had everything you..."<br>`[11]` **Narrator**: "It was a far cry from the luxury..." | `Variable["BaseGame.Petr_Dead"] == false`<br>`Variable["BaseGame.Retirement_FamilyWithYou"] == false` | `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"]...`<br>`PrologueImage("pe_monicaspeech");` | *Koniec sceny / Terminal* |
| `[23]` | **"You never heard from either of them ever again."** | `[36]` **Narrator**: "The ensuing scandal cost Monica ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("");`<br>*(+2 skryptów)* | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." |
| `[30]` | **"...stayed silent, but agreed to look after Deana as Monica spent more and more tim..."** | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[32]` | **"1960\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[30]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **"1960\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[30]` **Player**: "...stayed silent, but agreed to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **"1960\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[39]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[35]` | **"1960\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "...vocally supported her."<br>`[39]` **Player**: "...stayed silent, but used your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **"...vocally supported her."** | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[39]` | **"...stayed silent, but used your remaining political influence to lobby for her cause."** | `[32]` **Narrator**: "As your star faded, your wife's ..."<br>`[33]` **Narrator**: "As your star faded, your wife's ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." |
| `[46]` | **"...found some racy photos of her you'd once taken, and leaked them to the press."** | `[34]` **Narrator**: "As your star faded, your ex-wife..."<br>`[35]` **Narrator**: "As your star faded, your ex-wife..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "The ensuing scandal cost Monica ..." |
| `[47]` | **"Years went by."** | `[31]` **Narrator**: "Your support buoyed Monica to ne..."<br>`[37]` **Narrator**: "You and Monica began speaking to..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");`<br>`PrologueImage("");`<br>*(+2 skryptów)* | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." |
| `[48]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had never felt so close to y..." |
| `[56]` | **"1970\|Benfi"** | `[23]` **Player**: "You never heard from either of t..."<br>`[47]` **Player**: "Years went by." | `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`<br>`Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true` | *Brak zmian stanu* | `[58]` **Player**: "...asked your son if you could m..."<br>`[59]` **Player**: "...checked yourself into rehab a..." |
| `[58]` | **"...asked your son if you could move in with him."** | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "Franc, now living on a commune i..."<br>`[179]` **Narrator**: "Franc, now living on commune in ..."<br>*(oraz 4 innych odgałęzień)* |
| `[59]` | **"...checked yourself into rehab and began working on your memoir."** | `[56]` **Narrator**: "Your hard-partying lifestyle beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "Your book, titled "Raynespotting..."<br>`[107]` **Narrator**: "Your book, titled "Raynespotting..." |
| `[63]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player**: "You were happy to reconnect with..."<br>`[79]` **Player**: "You didn't respond." |
| `[64]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[68]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[72]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: "Anton Rayne was famous once more." |
| `[73]` | **"1975\|Bergia"** | `[58]` **Player**: "...asked your son if you could m..." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[77]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had never felt so close to y..." |
| `[78]` | **"You were happy to reconnect with him."** | `[63]` **Narrator**: "After years of publication delay..."<br>`[146]` **Narrator**: "After years of publication delay..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "You lived out the rest of your d..."<br>`[115]` **Narrator**: "You lived out the rest of your d..." |
| `[79]` | **"You didn't respond."** | `[63]` **Narrator**: "After years of publication delay..."<br>`[146]` **Narrator**: "After years of publication delay..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "You lived out the rest of your d..."<br>`[115]` **Narrator**: "You lived out the rest of your d..." |
| `[80]` | **"Anton Rayne was famous once more."** | `[72]` **Narrator**: "After years of publication delay..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "You lived out the rest of your d..."<br>`[115]` **Narrator**: "You lived out the rest of your d..." |
| `[81]` | **"...never got back into politics."** | `[64]` **Narrator**: "Your teaching career, though ung..."<br>`[68]` **Narrator**: "Your teaching career, though ung..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[82]` | **"...never accomplished your presidential goals."** | `[64]` **Narrator**: "Your teaching career, though ung..."<br>`[68]` **Narrator**: "Your teaching career, though ung..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[83]` | **"...actually, you had no regrets."** | `[64]` **Narrator**: "Your teaching career, though ung..."<br>`[68]` **Narrator**: "Your teaching career, though ung..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[85]` | **"You had never felt so close to your family."** | `[48]` **Narrator**: "You and Monica spent the swingin..."<br>`[77]` **Narrator**: "You and Monica spent the swingin..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "After receiving multiple lifetim..."<br>`[86]` **Narrator**: "After receiving multiple lifetim..." |
| `[86]` | **"1980\|Benfi"** | `[85]` **Player**: "You had never felt so close to y..." | `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` | *Brak zmian stanu* | `[87]` **Player**: "...never got back into politics."<br>`[88]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[87]` | **"...never got back into politics."** | `[86]` **Narrator**: "After receiving multiple lifetim..."<br>`[111]` **Narrator**: "After receiving multiple lifetim..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[88]` | **"...never accomplished your presidential goals."** | `[86]` **Narrator**: "After receiving multiple lifetim..."<br>`[111]` **Narrator**: "After receiving multiple lifetim..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[89]` | **"...actually, you had no regrets."** | `[86]` **Narrator**: "After receiving multiple lifetim..."<br>`[111]` **Narrator**: "After receiving multiple lifetim..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[90]` | **"1975\|Benfi"** | `[59]` **Player**: "...checked yourself into rehab a..." | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[91]` | **"...never mended your marriage with Monica."** | `[73]` **Narrator**: "Franc, now living on a farm in B..."<br>`[90]` **Narrator**: "Your book, titled "Raynespotting..."<br>*(oraz 6 innych węzłów)* | `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true` | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[92]` | **"...never got back into politics."** | `[73]` **Narrator**: "Franc, now living on a farm in B..."<br>`[90]` **Narrator**: "Your book, titled "Raynespotting..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[93]` | **"...actually, you had no regrets."** | `[73]` **Narrator**: "Franc, now living on a farm in B..."<br>`[90]` **Narrator**: "Your book, titled "Raynespotting..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[103]` | **"1975\|Bergia"** | `[58]` **Player**: "...asked your son if you could m..." | `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[107]` | **"1975\|Benfi"** | `[59]` **Player**: "...checked yourself into rehab a..." | `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[111]` | **"1980\|Benfi"** | `[85]` **Player**: "You had never felt so close to y..." | `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` | *Brak zmian stanu* | `[87]` **Player**: "...never got back into politics."<br>`[88]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[122]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[123]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[130]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had never felt so close to y..." |
| `[131]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had never felt so close to y..." |
| `[138]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had never felt so close to y..." |
| `[139]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Player**: "You had never felt so close to y..." |
| `[146]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player**: "You were happy to reconnect with..."<br>`[79]` **Player**: "You didn't respond." |
| `[147]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player**: "You were happy to reconnect with..."<br>`[79]` **Player**: "You didn't respond." |
| `[154]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[155]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[162]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[163]` | **"1970\|Benfi"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Player**: "...never got back into politics."<br>`[82]` **Player**: "...never accomplished your presi..."<br>*(oraz 1 innych odgałęzień)* |
| `[170]` | **"1975\|Arcasia"** | `[58]` **Player**: "...asked your son if you could m..." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[171]` | **"1975\|United Contana"** | `[58]` **Player**: "...asked your son if you could m..." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[178]` | **"1975\|Arcasia"** | `[58]` **Player**: "...asked your son if you could m..." | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`<br>`(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`<br>`(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |
| `[179]` | **"1975\|United Contana"** | `[58]` **Player**: "...asked your son if you could m..." | `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`<br>`(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false` | *Brak zmian stanu* | `[92]` **Player**: "...never got back into politics."<br>`[93]` **Player**: "...actually, you had no regrets."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[9]` (*Narrator: "With your presidency behind you, you set out to begin you..."*)

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
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

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
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true || BaseGame...."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
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
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[30]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your wife's rose.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[30]` (*Player: "...stayed silent, but agreed to look after Deana as Monic..."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your ex-wife's rose.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "...vocally supported her."*)
  - -> `[39]` (*Player: "...stayed silent, but used your remaining political influ..."*)
  - -> `[46]` (*Player: "...found some racy photos of her you'd once taken, and le..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your ex-wife's rose.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
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
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Eventually you managed to reconcile with Franc, by now living on a farm in Bergia with his wife and son."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Partying = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

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
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Partying == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == false && BaseGame...."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your hard-partying lifestyle began to take its toll. Strung out and losing money fast, you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false` AND `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[47]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "...asked your son if you could move in with him."*)
  - -> `[59]` (*Player: "...checked yourself into rehab and began working on your ..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...asked your son if you could move in with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...checked yourself into rehab and began working on your memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

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
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "You were happy to reconnect with him."*)
  - -> `[79]` (*Player: "You didn't respond."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a farm in Bergia with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

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
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

You even managed to reconcile with Franc.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

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
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

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
  - -> `[80]` (*Player: "Anton Rayne was famous once more."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, now living on a farm in Bergia with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Kontekst wejściowy (poprzednik):** `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living on a farm in Bergia with his wife and son, occasionally came for visits."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator), `[146]` (Narrator), `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator), `[146]` (Narrator), `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Anton Rayne was famous once more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[68]` (Narrator), `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[68]` (Narrator), `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[68]` (Narrator), `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[84]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort by the seaside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had never felt so close to your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[77]` (Narrator), `[130]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "1980|Benfi"]** — Mówca: **Narrator**
> "After receiving multiple lifetime achievement awards for her women's rights work, Monica decided to finally take a break. The two of you spent the rest of your days in leisure by the seaside.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "...never got back into politics."*)
  - -> `[88]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[89]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Raynespotting: How I Quit Both The Presidency And Drugs", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days by the seaside, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never mended your marriage with Monica."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[90]` (Narrator), `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[90]` (Narrator), `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[90]` (Narrator), `[103]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "...never mended your marriage with Monica."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_LateRetire == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_LateRetire == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_LateRetire == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Partying == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_LateRetire == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monicaspeech");"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, now living on a farm in Bergia with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "1975|Benfi"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "1975|Benfi"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Raynespotting: How I Quit Both The Presidency And Drugs", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days by the seaside, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "1980|Benfi"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "1980|Benfi"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "1980|Benfi"]** — Mówca: **Narrator**
> "After receiving multiple lifetime achievement awards for her women's rights work, Monica decided to finally take a break. The two of you spent the rest of your days in leisure by the seaside.

Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Kontekst wejściowy (poprzednik):** `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "...never got back into politics."*)
  - -> `[88]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[89]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "You lived out the rest of your days in wealth and comfort..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "You lived out the rest of your days in wealth and comfort..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort by the seaside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Election_Forcedout == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Election_Forcedout == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Election_Forcedout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "1970|Benfi"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Election_Forcedout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "1970|Benfi"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

You even managed to reconcile with Franc.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a farm in Bergia with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

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
  - -> `[131]` (*Narrator: "1970|Benfi"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "1970|Benfi"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "1970|Benfi"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Eventually you managed to reconcile with Franc, by now living in the Arcasian suburbs with his wife and son."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Eventually you managed to reconcile with Franc, by now living on a commune in United Contana with his wife and son."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "1970|Benfi"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "1970|Benfi"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "1970|Benfi"*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living in the Arcasian suburbs with his wife and son, occasionally came for visits."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living on a commune in United Contana with his wife and son, occasionally came for visits."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "You had never felt so close to your family."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "1970|Benfi"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "1970|Benfi"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "1970|Benfi"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "You were happy to reconnect with him."*)
  - -> `[79]` (*Player: "You didn't respond."*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "You were happy to reconnect with him."*)
  - -> `[79]` (*Player: "You didn't respond."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "1970|Benfi"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "1970|Benfi"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "1970|Benfi"*)

### Węzeł `[154]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living in the Arcasian suburbs with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a commune in United Contana with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "1970|Benfi"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "1970|Benfi"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "1970|Benfi"*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living in the Arcasian suburbs with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a commune in United Contana with his wife and son.

Your only regret was that you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "...never got back into politics."*)
  - -> `[82]` (*Player: "...never accomplished your presidential goals."*)
  - -> `[83]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "1975|United Contana"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "1975|Arcasia"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "1975|Bergia"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, now living in the Arcasian suburbs with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Kontekst wejściowy (poprzednik):** `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, now living on a commune in United Contana with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Kontekst wejściowy (poprzednik):** `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "1975|United Contana"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "1975|Arcasia"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "1975|Bergia"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, now living in the Arcasian suburbs with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true` AND `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false` AND `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, now living on commune in United Contana with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true` AND `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "...never got back into politics."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[93]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monicaspeech");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == false && BaseGame.Re..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 2"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "1970|Benfi"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
