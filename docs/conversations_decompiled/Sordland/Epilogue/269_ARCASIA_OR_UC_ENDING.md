# Sordland/ARCASIA OR UC ENDING

- **ID konwersacji:** `269`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ARCASIA OR UC ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/269_ARCASIA_OR_UC_ENDING.md`
- **Liczba węzłów dialogowych:** 139
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Investment_Arcasia_Successful`
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Retirement_Arcasia`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Retirement_UnitedContana`
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
| `[6]` | **"1960\|United Contana"** | `[125]` **Player**: "You sought him out on your first..."<br>`[126]` **Player**: "You waited for him to get in touch." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false` | *Brak zmian stanu* | `[35]` **Player**: "...became an adjunct professor o..."<br>`[41]` **Player**: "...started writing a memoir."<br>*(oraz 1 innych odgałęzień)* |
| `[11]` | **"1958\|Arcasia"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Player**: "...a city apartment."<br>`[113]` **Player**: "...a hillside mansion."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **"1958\|United Contana"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Player**: "...a country cottage."<br>`[123]` **Player**: "...an opulent hillside villa rec..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **"...joined the board of Armadine Industries and moved to Ventrie City, Arcasia."** | `[6]` **Narrator**: "At first, he would only speak wi..."<br>`[33]` **Narrator**: "When he heard you were in the co..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Investment_Arcasia_Successful"] == true` | `PrologueImage("pe_politicians");` | `[44]` **Narrator**: "Some time passed. A series of br..."<br>`[42]` **Narrator**: "Some time passed. A series of br..." |
| `[30]` | **"...started a charitable foundation to stop global hunger."** | `[42]` **Narrator**: "Some time passed. A series of br..."<br>`[44]` **Narrator**: "Some time passed. A series of br..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[92]` **Narrator**: "Political commentators liked to ..."<br>`[93]` **Narrator**: "Political commentators liked to ..." |
| `[32]` | **"...lived like royalty."** | `[42]` **Narrator**: "Some time passed. A series of br..."<br>`[44]` **Narrator**: "Some time passed. A series of br..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[10]` **Narrator**: "Your ostentatious lifestyle drew..."<br>`[86]` **Narrator**: "Franc, by now living on a farm w..." |
| `[33]` | **"1960\|United Contana"** | `[125]` **Player**: "You sought him out on your first..."<br>`[126]` **Player**: "You waited for him to get in touch." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false` | *Brak zmian stanu* | `[35]` **Player**: "...became an adjunct professor o..."<br>`[41]` **Player**: "...started writing a memoir."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **"1960\|United Contana"** | `[125]` **Player**: "You sought him out on your first..."<br>`[126]` **Player**: "You waited for him to get in touch." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`Variable["BaseGame.Relations_Franc_Opinion"] > 2` | *Brak zmian stanu* | `[35]` **Player**: "...became an adjunct professor o..."<br>`[41]` **Player**: "...started writing a memoir."<br>*(oraz 1 innych odgałęzień)* |
| `[35]` | **"...became an adjunct professor of politics at Franc's United People's University."** | `[6]` **Narrator**: "At first, he would only speak wi..."<br>`[33]` **Narrator**: "When he heard you were in the co..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_congress");` | `[79]` **Narrator**: "Your new job was unglamorous but..."<br>`[80]` **Narrator**: "Your new job was unglamorous but..."<br>*(oraz 2 innych odgałęzień)* |
| `[36]` | **"1960\|Arcasia"** | `[113]` **Player**: "...a hillside mansion."<br>`[117]` **Player**: "...a small cottage in the country."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`Variable["BaseGame.Archetype_CapitalistRayne"] == true` | *Brak zmian stanu* | `[56]` **Player**: "...did nothing."<br>`[57]` **Player**: "...had a bunker built, just in c..."<br>*(oraz 1 innych odgałęzień)* |
| `[37]` | **"1960\|Arcasia"** | `[113]` **Player**: "...a hillside mansion."<br>`[117]` **Player**: "...a small cottage in the country."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false` | *Brak zmian stanu* | `[56]` **Player**: "...did nothing."<br>`[57]` **Player**: "...had a bunker built, just in c..."<br>*(oraz 1 innych odgałęzień)* |
| `[41]` | **"...started writing a memoir."** | `[6]` **Narrator**: "At first, he would only speak wi..."<br>`[33]` **Narrator**: "When he heard you were in the co..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");`<br>`Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] =...` | `[61]` **Narrator**: "Your book titled "Rayne The Red;..."<br>`[62]` **Narrator**: "Your book titled "Rayne The Red;..."<br>*(oraz 2 innych odgałęzień)* |
| `[42]` | **"1965\|Arcasia"** | `[29]` **Player**: "...joined the board of Armadine ..."<br>`[56]` **Player**: "...did nothing."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` | *Brak zmian stanu* | `[32]` **Player**: "...lived like royalty."<br>`[30]` **Player**: "...started a charitable foundati..." |
| `[43]` | **"1960\|United Contana"** | `[125]` **Player**: "You sought him out on your first..."<br>`[126]` **Player**: "You waited for him to get in touch." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`Variable["BaseGame.Relations_Franc_Opinion"] > 2` | *Brak zmian stanu* | `[35]` **Player**: "...became an adjunct professor o..."<br>`[41]` **Player**: "...started writing a memoir."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **"1965\|Arcasia"** | `[29]` **Player**: "...joined the board of Armadine ..."<br>`[56]` **Player**: "...did nothing."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Retirement_FamilyWithYou"] == true` | *Brak zmian stanu* | `[32]` **Player**: "...lived like royalty."<br>`[30]` **Player**: "...started a charitable foundati..." |
| `[51]` | **"1960\|Arcasia"** | `[113]` **Player**: "...a hillside mansion."<br>`[117]` **Player**: "...a small cottage in the country."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false` | *Brak zmian stanu* | `[56]` **Player**: "...did nothing."<br>`[57]` **Player**: "...had a bunker built, just in c..."<br>*(oraz 1 innych odgałęzień)* |
| `[52]` | **"1960\|Arcasia"** | `[113]` **Player**: "...a hillside mansion."<br>`[117]` **Player**: "...a small cottage in the country."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`Variable["BaseGame.Archetype_CapitalistRayne"] == true` | *Brak zmian stanu* | `[56]` **Player**: "...did nothing."<br>`[57]` **Player**: "...had a bunker built, just in c..."<br>*(oraz 1 innych odgałęzień)* |
| `[56]` | **"...did nothing."** | `[36]` **Narrator**: "Your new role on the board of Ar..."<br>`[37]` **Narrator**: "Though at first uncomfortable wi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_politicians");` | `[44]` **Narrator**: "Some time passed. A series of br..."<br>`[42]` **Narrator**: "Some time passed. A series of br..." |
| `[57]` | **"...had a bunker built, just in case."** | `[36]` **Narrator**: "Your new role on the board of Ar..."<br>`[37]` **Narrator**: "Though at first uncomfortable wi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_politicians");` | `[44]` **Narrator**: "Some time passed. A series of br..."<br>`[42]` **Narrator**: "Some time passed. A series of br..." |
| `[61]` | **"1965\|United Contana"** | `[41]` **Player**: "...started writing a memoir." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`Variable["BaseGame.Retirement_UnitedContana"] == true` | *Brak zmian stanu* | `[101]` **Player**: "You became a doting grandfather." |
| `[62]` | **"1965\|United Contana"** | `[41]` **Player**: "...started writing a memoir." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`Variable["BaseGame.Retirement_UnitedContana"] == true` | *Brak zmian stanu* | `[74]` **Player**: "You ignored her."<br>`[75]` **Player**: "You asked her to get coffee with..." |
| `[69]` | **"1965\|Arcasia"** | `[41]` **Player**: "...started writing a memoir." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`(Variable["BaseGame.Retirement_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[101]` **Player**: "You became a doting grandfather." |
| `[73]` | **"1965\|Arcasia"** | `[41]` **Player**: "...started writing a memoir." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`(Variable["BaseGame.Retirement_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[74]` **Player**: "You ignored her."<br>`[75]` **Player**: "You asked her to get coffee with..." |
| `[74]` | **"You ignored her."** | `[62]` **Narrator**: "Your book titled "Rayne The Red;..."<br>`[73]` **Narrator**: "Your book, titled "Let Freedom R..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");`<br>`PrologueImage("");` | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." |
| `[75]` | **"You asked her to get coffee with you."** | `[62]` **Narrator**: "Your book titled "Rayne The Red;..."<br>`[73]` **Narrator**: "Your book, titled "Let Freedom R..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "The two of you met and had a lon..." |
| `[79]` | **"1965\|United Contana"** | `[35]` **Player**: "...became an adjunct professor o..." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`Variable["BaseGame.Retirement_UnitedContana"] == true` | *Brak zmian stanu* | `[102]` **Player**: "You became a doting grandfather." |
| `[80]` | **"1965\|United Contana"** | `[35]` **Player**: "...became an adjunct professor o..." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`Variable["BaseGame.Retirement_UnitedContana"] == true` | *Brak zmian stanu* | `[74]` **Player**: "You ignored her." |
| `[81]` | **"1965\|Arcasia"** | `[35]` **Player**: "...became an adjunct professor o..." | `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`<br>`(Variable["BaseGame.Retirement_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[74]` **Player**: "You ignored her."<br>`[75]` **Player**: "You asked her to get coffee with..." |
| `[85]` | **"1965\|Arcasia"** | `[35]` **Player**: "...became an adjunct professor o..." | `Variable["BaseGame.Retirement_FamilyWithYou"] == true`<br>`(Variable["BaseGame.Retirement_UnitedContana"] == true) == false` | *Brak zmian stanu* | `[102]` **Player**: "You became a doting grandfather." |
| `[87]` | **"You ignored him."** | `[10]` **Narrator**: "Your ostentatious lifestyle drew..."<br>`[86]` **Narrator**: "Franc, by now living on a farm w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[96]` **Narrator**: "You lived out the rest of your d..." |
| `[88]` | **"You helped him with whatever he needed."** | `[86]` **Narrator**: "Franc, by now living on a farm w..."<br>`[93]` **Narrator**: "Political commentators liked to ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[96]` **Narrator**: "You lived out the rest of your d..." |
| `[94]` | **"You did the same."** | `[10]` **Narrator**: "Your ostentatious lifestyle drew..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[96]` **Narrator**: "You lived out the rest of your d..." |
| `[95]` | **"You accepted."** | `[92]` **Narrator**: "Political commentators liked to ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[96]` **Narrator**: "You lived out the rest of your d..." |
| `[97]` | **"...never fully got back into politics."** | `[96]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[98]` | **"...never moved back to Sordland."** | `[96]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[99]` | **"...actually, you had no regrets."** | `[96]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[101]` | **"You became a doting grandfather."** | `[61]` **Narrator**: "Your book titled "Rayne The Red;..."<br>`[69]` **Narrator**: "Your book, titled "Let Freedom R..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");`<br>`PrologueImage("");` | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." |
| `[102]` | **"You became a doting grandfather."** | `[79]` **Narrator**: "Your new job was unglamorous but..."<br>`[85]` **Narrator**: "Your new job was unglamorous but..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");`<br>`PrologueImage("");` | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." |
| `[108]` | **"More time went by."** | `[100]` **Narrator**: "The two of you met and had a lon..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");`<br>`PrologueImage("");` | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." |
| `[110]` | **"...never moved back to Sordland."** | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[111]` | **"...never got back into politics."** | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[112]` | **"...actually, you had no regrets."** | `[104]` **Narrator**: "You lived out the rest of your d..."<br>`[109]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[113]` | **"...a hillside mansion."** | `[11]` **Narrator**: "With your presidency behind you,..." | `Variable["BaseGame.PersonalWealth"] > 2` | `PrologueImage("pe_city");` | `[36]` **Narrator**: "Your new role on the board of Ar..."<br>`[52]` **Narrator**: "Your new role on the board of Ar..."<br>*(oraz 2 innych odgałęzień)* |
| `[117]` | **"...a small cottage in the country."** | `[11]` **Narrator**: "With your presidency behind you,..." | `(Variable["BaseGame.PersonalWealth"] > 2) == false` | `PrologueImage("pe_city");` | `[36]` **Narrator**: "Your new role on the board of Ar..."<br>`[52]` **Narrator**: "Your new role on the board of Ar..."<br>*(oraz 2 innych odgałęzień)* |
| `[118]` | **"...a city apartment."** | `[11]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_city");` | `[36]` **Narrator**: "Your new role on the board of Ar..."<br>`[52]` **Narrator**: "Your new role on the board of Ar..."<br>*(oraz 2 innych odgałęzień)* |
| `[122]` | **"...a modest apartment in a prefab government housing bloc."** | `[12]` **Narrator**: "With your presidency behind you,..." | `(Variable["BaseGame.PersonalWealth"] > 2) == false` | `PrologueImage("pe_city");` | `[31]` **Narrator**: "You were happy not only to live ..."<br>`[16]` **Narrator**: "It was hard adjusting to the dif..." |
| `[123]` | **"...an opulent hillside villa recently vacated by a disgraced government official."** | `[12]` **Narrator**: "With your presidency behind you,..." | `Variable["BaseGame.PersonalWealth"] > 2` | `PrologueImage("pe_city");` | `[31]` **Narrator**: "You were happy not only to live ..."<br>`[16]` **Narrator**: "It was hard adjusting to the dif..." |
| `[124]` | **"...a country cottage."** | `[12]` **Narrator**: "With your presidency behind you,..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_city");` | `[31]` **Narrator**: "You were happy not only to live ..."<br>`[16]` **Narrator**: "It was hard adjusting to the dif..." |
| `[125]` | **"You sought him out on your first day there."** | `[16]` **Narrator**: "It was hard adjusting to the dif..."<br>`[31]` **Narrator**: "You were happy not only to live ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "You, him, Deana and Monica had f..."<br>`[34]` **Narrator**: "The two of you frequently got to..."<br>*(oraz 2 innych odgałęzień)* |
| `[126]` | **"You waited for him to get in touch."** | `[16]` **Narrator**: "It was hard adjusting to the dif..."<br>`[31]` **Narrator**: "You were happy not only to live ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "You, him, Deana and Monica had f..."<br>`[34]` **Narrator**: "The two of you frequently got to..."<br>*(oraz 2 innych odgałęzień)* |
| `[127]` | **"...funded President Walker's federalist New Democratic Concord party."** | `[36]` **Narrator**: "Your new role on the board of Ar..."<br>`[37]` **Narrator**: "Though at first uncomfortable wi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_politicians");` | `[44]` **Narrator**: "Some time passed. A series of br..."<br>`[42]` **Narrator**: "Some time passed. A series of br..." |

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
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_plane");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Arcasia == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_Arcasia == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "1958|Arcasia"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "1958|United Contana"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "At first, he would only speak with Deana and Monica. But gradually, the two of you began to reconcile.

Meanwhile, you yourself..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[125]` (Player), `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[35]` (*Player: "...became an adjunct professor of politics at Franc's Uni..."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "1960|United Contana"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "1960|United Contana"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Your ostentatious lifestyle drew international attention. Franc, by now living on a farming commune in United Contana, publicly disowned you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "You did the same."*)
  - -> `[87]` (*Player: "You ignored him."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "1958|Arcasia"]** — Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Arcasia. 

After transferring your money to the local currency, you could afford..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 2"*)
  - -> `[118]` (*Player: "...a city apartment."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "1958|United Contana"]** — Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in United Contana.

After transferring your money to the local currency, you could afford..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 2"*)
  - -> `[124]` (*Player: "...a country cottage."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Investment_Arcasia_Successful == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...joined the board of Armadine Industries and moved to V..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Investment_Arcasia_Successful == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Investment_Arcasia_Successful"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Narrator**
> "It was hard adjusting to the different culture and values, but you were happy to reconnect with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "You sought him out on your first day there."*)
  - -> `[126]` (*Player: "You waited for him to get in touch."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Your ostentatious lifestyle drew international attention...."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Franc, by now living on a farm with his wife and son, beg..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_CapitalistRayne == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "You were happy not only to live in a country that aligned..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "It was hard adjusting to the different culture and values..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 2"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion > 2)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the board of Armadine Industries and moved to Ventrie City, Arcasia."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started a charitable foundation to stop global hunger."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "You were happy not only to live in a country that aligned with your personal values, but to reconnect with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "You sought him out on your first day there."*)
  - -> `[126]` (*Player: "You waited for him to get in touch."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...lived like royalty."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed");"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "When he heard you were in the country, he refused to speak to you. But gradually, your relationship began to thaw.

Meanwhile, you yourself..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[125]` (Player), `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[35]` (*Player: "...became an adjunct professor of politics at Franc's Uni..."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "The two of you frequently got together for dinner and ideological discussions.

Meanwhile, you yourself..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `Variable["BaseGame.Relations_Franc_Opinion"] > 2`
- **Kontekst wejściowy (poprzednik):** `[125]` (Player), `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[35]` (*Player: "...became an adjunct professor of politics at Franc's Uni..."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Franc's United People's University."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Your new role on the board of Armadine Enterprises fit you like a glove.

Monica, meanwhile, was thrilled by the new possibilities and viewpoints the Arcasian women's movement had to offer.

In the face of escalating tensions with United Contana, you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Player), `[117]` (Player), `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...did nothing."*)
  - -> `[57]` (*Player: "...had a bunker built, just in case."*)
  - -> `[127]` (*Player: "...funded President Walker's federalist New Democratic Co..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Though at first uncomfortable with the country's rampant capitalism, you gradually settled into your new role on the board of Armadine Enterprises.

Monica, meanwhile, was thrilled by the new possibilities and viewpoints the Arcasian women's movement had to offer.

In the face of escalating tensions with United Contana, you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[113]` (Player), `[117]` (Player), `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...did nothing."*)
  - -> `[57]` (*Player: "...had a bunker built, just in case."*)
  - -> `[127]` (*Player: "...funded President Walker's federalist New Democratic Co..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "1960|United Contana"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "1960|United Contana"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[33]` (Narrator), `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Some time passed. A series of breakthrough inventions made Armadine one of the wealthiest corporations in Arcasia. 

You suddenly had more money than you'd ever been able to enjoy in Sordland. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "...lived like royalty."*)
  - -> `[30]` (*Player: "...started a charitable foundation to stop global hunger."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "You, him, Deana and Monica had frequent dinners together. It felt like old times.

Meanwhile, you yourself..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `Variable["BaseGame.Relations_Franc_Opinion"] > 2`
- **Kontekst wejściowy (poprzednik):** `[125]` (Player), `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[35]` (*Player: "...became an adjunct professor of politics at Franc's Uni..."*)
  - -> `[41]` (*Player: "...started writing a memoir."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Some time passed. A series of breakthrough inventions made Armadine one of the wealthiest corporations in Arcasia. 

You and your family suddenly had more money than you'd ever been able to enjoy in Sordland. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "...lived like royalty."*)
  - -> `[30]` (*Player: "...started a charitable foundation to stop global hunger."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "1965|Arcasia"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "1965|Arcasia"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "1960|Arcasia"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "1960|Arcasia"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Though at first uncomfortable with the country's rampant capitalism, you gradually settled into your new role on the board of Armadine Enterprises.

In the face of escalating tensions with United Contana, you..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[113]` (Player), `[117]` (Player), `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...did nothing."*)
  - -> `[57]` (*Player: "...had a bunker built, just in case."*)
  - -> `[127]` (*Player: "...funded President Walker's federalist New Democratic Co..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Your new role on the board of Armadine Enterprises fit you like a glove.

In the face of escalating tensions with United Contana, you...."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Player), `[117]` (Player), `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "...did nothing."*)
  - -> `[57]` (*Player: "...had a bunker built, just in case."*)
  - -> `[127]` (*Player: "...funded President Walker's federalist New Democratic Co..."*)

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
  - -> `[36]` (*Narrator: "1960|Arcasia"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "1960|Arcasia"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator), `[37]` (Narrator), `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...had a bunker built, just in case."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator), `[37]` (Narrator), `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "1965|United Contana"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "1965|United Contana"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your book titled "Rayne The Red; Why I Chose Communism Over The Sordish Presidency", was an instant best-seller. You and Monica toured it everywhere except Arcasia.

When you were at home, you frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "You became a doting grandfather."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your book titled "Rayne The Red; Why I Chose Communism Over The Sordish Presidency", was an instant best-seller. You toured it everywhere except Arcasia.

On your stop in Sordland, you noticed Monica in the audience."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "You ignored her."*)
  - -> `[75]` (*Player: "You asked her to get coffee with you."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_UnitedContana == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_UnitedContana == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_UnitedContana == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_UnitedContana == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your book, titled "Let Freedom Rayne: Why I Chose Arcasia Over The Sordish Presidency", was an instant best-seller. You and Monica toured it everywhere except United Contana.

When you were at home, you frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "You became a doting grandfather."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "1965|Arcasia"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "1965|Arcasia"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your book, titled "Let Freedom Rayne: Why I Chose Arcasia Over The Sordish Presidency", was an instant best-seller. You toured it everywhere except United Contana.

On your stop in Sordland, you noticed Monica in the audience."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[41]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "You ignored her."*)
  - -> `[75]` (*Player: "You asked her to get coffee with you."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ignored her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator), `[73]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You asked her to get coffee with you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator), `[73]` (Narrator), `[81]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The two of you met and had a long talk about everything t..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "1965|United Contana"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "1965|United Contana"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging. While you rose through the academic ranks, Monica became involved in the United Contana women's movement.

You frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You became a doting grandfather."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging.

Some years went by. One day, you noticed your ex-wife would be visiting campus to give a talk on Sordland's burgeoning women's movement."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "You ignored her."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging.

Some years went by. One day, you noticed your ex-wife would be visiting campus to give a talk on Sordland's burgeoning women's movement."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false` AND `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "You ignored her."*)
  - -> `[75]` (*Player: "You asked her to get coffee with you."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_FamilyWithYou == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "1965|Arcasia"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_FamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "1965|Arcasia"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging. While you rose through the academic ranks, Monica became involved in the Arcasian women's movement.

You frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true` AND `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "You became a doting grandfather."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Franc, by now living on a farm with his wife and son, began asking you for money."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "You ignored him."*)
  - -> `[88]` (*Player: "You helped him with whatever he needed."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ignored him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[86]` (Narrator), `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You helped him with whatever he needed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

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
  - -> `[92]` (*Narrator: "Political commentators liked to say that the Rayne Founda..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Political commentators liked to say that the Rayne Founda..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Political commentators liked to say that the Rayne Foundation helped more people than you ever had as president. 

On your visits back to Sordland, you were welcomed as a hero.

Franc, by now living on a farming commune in United Contana, reached out to reconcile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "You ignored him."*)
  - -> `[95]` (*Player: "You accepted."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Political commentators liked to say that the Rayne Foundation helped more people than you ever had as president. 

On your visits back to Sordland, you were welcomed as a hero.

Franc, by now living on a farm with his wife and son, began asking you for money."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "You ignored him."*)
  - -> `[88]` (*Player: "You helped him with whatever he needed."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did the same."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "You lived out the rest of your days in comfort, insulated from the global tensions around you. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: "...never fully got back into politics."*)
  - -> `[98]` (*Player: "...never moved back to Sordland."*)
  - -> `[99]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never fully got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never moved back to Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "The two of you met and had a long talk about everything that had happened during your presidency.

You left on slightly better terms, but you never got back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "More time went by."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You became a doting grandfather."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator), `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You became a doting grandfather."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator), `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_UnitedContana == true"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort, surrounded by admirers, family and a few close friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "...never moved back to Sordland."*)
  - -> `[111]` (*Player: "...never got back into politics."*)
  - -> `[112]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Retirement_Memoir == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Retirement_Memoir == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "More time went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir == true"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity as your presidency became a footnote in Sordish history.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "...never moved back to Sordland."*)
  - -> `[111]` (*Player: "...never got back into politics."*)
  - -> `[112]` (*Player: "...actually, you had no regrets."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never moved back to Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator), `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator), `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Narrator), `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hillside mansion."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 2"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 2)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "...a hillside mansion."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "...a small cottage in the country."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a small cottage in the country."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a city apartment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 2"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 2)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "...an opulent hillside villa recently vacated by a disgra..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "...a modest apartment in a prefab government housing bloc."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a modest apartment in a prefab government housing bloc."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...an opulent hillside villa recently vacated by a disgraced government official."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a country cottage."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_city");"*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You sought him out on your first day there."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 2"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You waited for him to get in touch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 2"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...funded President Walker's federalist New Democratic Concord party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator), `[37]` (Narrator), `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_plane");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Arcasia == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_city");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Retirement_Memoir = true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_UnitedContana == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_politicians");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_politicians");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou == true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "You lived out the rest of your days in comfort, insulated..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "You lived out the rest of your days in wealth and comfort..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "You lived out the rest of your days in relative anonymity..."*)
