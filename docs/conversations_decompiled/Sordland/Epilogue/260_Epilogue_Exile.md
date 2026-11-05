# Sordland/Epilogue_Exile

- **ID konwersacji:** `260`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_Exile)`
- **Lokalizacja pliku:** `Sordland/Epilogue/260_Epilogue_Exile.md`
- **Liczba węzłów dialogowych:** 183
- **Liczba wyborów gracza:** 46

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Decision_Turn08_VPSelection_Lucian`
- `BaseGame.Decision_Turn10_MovePersonalWealth_Move`
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Lileas`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Exile_CoupHappensAfterYouLeave`
- `BaseGame.Exile_MonicaDeanaWithYou`
- `BaseGame.Exile_PetrWithYou`
- `BaseGame.Exile_WholeFamilyWithYou`
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGameIsolated.Epilogue_Exile_City`
- `BaseGameIsolated.Epilogue_Exile_Country`
- `BaseGameIsolated.Epilogue_Exile_Mountains`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"...alone in your cabin."** | `[3]` **Narrator**: "The boat journey to Kyrute took ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_coast");`<br>`PrologueImage("pe_coast");` | `[16]` **Narrator**: "At long last, you reached the ot..."<br>`[17]` **Narrator**: "At long last, you reached the ot..." |
| `[5]` | **"...making plans with your family."** | `[3]` **Narrator**: "The boat journey to Kyrute took ..." | `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true` | `PrologueImage("pe_coast");`<br>`PrologueImage("pe_coast");` | `[16]` **Narrator**: "At long last, you reached the ot..."<br>`[17]` **Narrator**: "At long last, you reached the ot..." |
| `[12]` | **"...playing cards with Petr."** | `[3]` **Narrator**: "The boat journey to Kyrute took ..." | `Variable["BaseGame.Exile_PetrWithYou"] == true` | `PrologueImage("pe_coast");`<br>`PrologueImage("pe_coast");` | `[16]` **Narrator**: "At long last, you reached the ot..."<br>`[17]` **Narrator**: "At long last, you reached the ot..." |
| `[16]` | **"1958\|Konstantium\|Kyrute"** | `[4]` **Player**: "...alone in your cabin."<br>`[5]` **Player**: "...making plans with your family."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true` | *Brak zmian stanu* | `[31]` **Player**: "...a cozy cabin in the mountains."<br>`[29]` **Player**: "...a luxurious penthouse in the ..."<br>*(oraz 3 innych odgałęzień)* |
| `[17]` | **"1958\|Konstantium\|Kyrute"** | `[4]` **Player**: "...alone in your cabin."<br>`[5]` **Player**: "...making plans with your family."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Exile_PetrWithYou"] == true`<br>`(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false` | *Brak zmian stanu* | `[29]` **Player**: "...a luxurious penthouse in the ..."<br>`[30]` **Player**: "...a sprawling villa in the coun..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **"1958\|Konstantium\|Kyrute"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Player**: "...a simple house in the country..."<br>`[33]` **Player**: "...a modest apartment on the edg..."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **"1958\|Konstantium\|Kyrute"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Player**: "...a simple house in the country..."<br>`[33]` **Player**: "...a modest apartment on the edg..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **"...a luxurious penthouse in the city center."** | `[17]` **Narrator**: "At long last, you reached the ot..."<br>`[16]` **Narrator**: "At long last, you reached the ot..." | `Variable["BaseGame.PersonalWealth"] > 1` | *Brak zmian stanu* | `[34]` **Narrator**: "Your ostentatious arrival attrac..." |
| `[30]` | **"...a sprawling villa in the countryside."** | `[17]` **Narrator**: "At long last, you reached the ot..."<br>`[16]` **Narrator**: "At long last, you reached the ot..." | `Variable["BaseGame.PersonalWealth"] > 1` | *Brak zmian stanu* | `[34]` **Narrator**: "Your ostentatious arrival attrac..." |
| `[31]` | **"...a cozy cabin in the mountains."** | `[16]` **Narrator**: "At long last, you reached the ot..."<br>`[17]` **Narrator**: "At long last, you reached the ot..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");`<br>`PrologueImage("pe_loss");` | `[58]` **Narrator**: "For the next few months, you fol..." |
| `[32]` | **"...a simple house in the countryside."** | `[21]` **Narrator**: "At long last, you reached the ot..."<br>`[25]` **Narrator**: "At long last, you reached the ot..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.PersonalWealth"] > 1) == false` | `PrologueImage("pe_red");`<br>`PrologueImage("pe_loss");` | `[58]` **Narrator**: "For the next few months, you fol..." |
| `[33]` | **"...a modest apartment on the edge of the city."** | `[21]` **Narrator**: "At long last, you reached the ot..."<br>`[25]` **Narrator**: "At long last, you reached the ot..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.PersonalWealth"] > 1) == false` | `PrologueImage("pe_red");`<br>`PrologueImage("pe_loss");` | `[58]` **Narrator**: "For the next few months, you fol..." |
| `[35]` | **"...kept a low profile."** | `[34]` **Narrator**: "Your ostentatious arrival attrac..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");`<br>`PrologueImage("pe_loss");` | `[58]` **Narrator**: "For the next few months, you fol..." |
| `[36]` | **"...basked in the spotlight."** | `[34]` **Narrator**: "Your ostentatious arrival attrac..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");`<br>`PrologueImage("pe_loss");` | `[58]` **Narrator**: "For the next few months, you fol..." |
| `[41]` | **"Sordland was under military rule."** | `[40]` **Narrator**: "For the next few months, you fol..."<br>`[45]` **Narrator**: "For the next few months, you fol..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "With Iosef firmly in power, litt..."<br>`[88]` **Narrator**: "With Valken firmly in power, lit..." |
| `[89]` | **"Years went by."** | `[66]` **Narrator**: "When it came time for the electi..."<br>`[79]` **Narrator**: "When it came time for the electi..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_blue");` | `[98]` **Narrator**: "Over time, you and your family a..."<br>`[90]` **Narrator**: "Over time, you and Petr assimila..."<br>*(oraz 1 innych odgałęzień)* |
| `[90]` | **"1963\|Kyrute"** | `[89]` **Player**: "Years went by." | `Variable["BaseGame.Exile_PetrWithYou"] == true`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[103]` **Player**: "...embarked on a series of lucra..."<br>`[104]` **Player**: "...became notorious for your hig..."<br>*(oraz 2 innych odgałęzień)* |
| `[97]` | **"1963\|Kyrute"** | `[89]` **Player**: "Years went by." | `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[103]` **Player**: "...embarked on a series of lucra..."<br>`[104]` **Player**: "...became notorious for your hig..."<br>*(oraz 2 innych odgałęzień)* |
| `[98]` | **"1963\|Kyrute"** | `[89]` **Player**: "Years went by." | `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true` | *Brak zmian stanu* | `[103]` **Player**: "...embarked on a series of lucra..."<br>`[99]` **Player**: "...took up vegetable farming."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **"...took up vegetable farming."** | `[90]` **Narrator**: "Over time, you and Petr assimila..."<br>`[97]` **Narrator**: "Over time, you assimilated furth..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true` | *Brak zmian stanu* | `[112]` **Narrator**: "Deana excelled at her new school..."<br>`[113]` **Narrator**: "Deana excelled at her new school..."<br>*(oraz 1 innych odgałęzień)* |
| `[103]` | **"...embarked on a series of lucrative public speaking gigs."** | `[90]` **Narrator**: "Over time, you and Petr assimila..."<br>`[97]` **Narrator**: "Over time, you assimilated furth..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "Deana excelled at her new school..."<br>`[113]` **Narrator**: "Deana excelled at her new school..."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **"...became notorious for your high-rolling ways."** | `[90]` **Narrator**: "Over time, you and Petr assimila..."<br>`[97]` **Narrator**: "Over time, you assimilated furth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "Deana excelled at her new school..."<br>`[113]` **Narrator**: "Deana excelled at her new school..."<br>*(oraz 1 innych odgałęzień)* |
| `[105]` | **"...joined the Konstantium city council."** | `[90]` **Narrator**: "Over time, you and Petr assimila..."<br>`[97]` **Narrator**: "Over time, you assimilated furth..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true) == false` | *Brak zmian stanu* | `[112]` **Narrator**: "Deana excelled at her new school..."<br>`[113]` **Narrator**: "Deana excelled at her new school..."<br>*(oraz 1 innych odgałęzień)* |
| `[115]` | **"He named his son after you."** | `[112]` **Narrator**: "Deana excelled at her new school..."<br>`[113]` **Narrator**: "Deana excelled at her new school..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false` | *Brak zmian stanu* | `[120]` **Narrator**: "One day, you were shopping for g..."<br>`[124]` **Narrator**: "One day, on one of your rare tri..." |
| `[119]` | **"You never heard from him again."** | `[112]` **Narrator**: "Deana excelled at her new school..."<br>`[113]` **Narrator**: "Deana excelled at her new school..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Relations_Franc_Opinion"] < -2` | *Brak zmian stanu* | `[120]` **Narrator**: "One day, you were shopping for g..."<br>`[124]` **Narrator**: "One day, on one of your rare tri..." |
| `[120]` | **"1973\|Kyrute"** | `[115]` **Player**: "He named his son after you."<br>`[119]` **Player**: "You never heard from him again." | `Variable["BaseGameIsolated.Epilogue_Exile_City"] == true` | *Brak zmian stanu* | `[125]` **Player**: "...agreed with gusto."<br>`[126]` **Player**: "...turned him down." |
| `[124]` | **"1973\|Kyrute"** | `[115]` **Player**: "He named his son after you."<br>`[119]` **Player**: "You never heard from him again." | `(Variable["BaseGameIsolated.Epilogue_Exile_City"] == true) == false` | *Brak zmian stanu* | `[125]` **Player**: "...agreed with gusto."<br>`[126]` **Player**: "...turned him down." |
| `[125]` | **"...agreed with gusto."** | `[120]` **Narrator**: "One day, you were shopping for g..."<br>`[124]` **Narrator**: "One day, on one of your rare tri..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[127]` **Narrator**: "Together, you and Tuomas capture..." |
| `[126]` | **"...turned him down."** | `[120]` **Narrator**: "One day, you were shopping for g..."<br>`[124]` **Narrator**: "One day, on one of your rare tri..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("");` | `[150]` **Narrator**: "More time went by. The Anton Ray..."<br>`[151]` **Narrator**: "More time went by. The Anton Ray..."<br>*(oraz 1 innych odgałęzień)* |
| `[128]` | **"...spared no one, least of all yourself."** | `[127]` **Narrator**: "Together, you and Tuomas capture..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Narrator**: "The book, titled 'Suzerain', was..."<br>`[160]` **Narrator**: "The book, titled 'Suzerain', was..."<br>*(oraz 1 innych odgałęzień)* |
| `[129]` | **"...lied to make yourself look good."** | `[127]` **Narrator**: "Together, you and Tuomas capture..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "The book, titled 'Suzerain', flo..."<br>`[141]` **Narrator**: "The book, titled 'Suzerain', flo..."<br>*(oraz 2 innych odgałęzień)* |
| `[136]` | **"1975\|Kyrute"** | `[129]` **Player**: "...lied to make yourself look good." | `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`<br>`Variable["BaseGame.Exile_PetrWithYou"] == true`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[137]` | **"1975\|Kyrute"** | `[129]` **Player**: "...lied to make yourself look good." | `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[141]` | **"1975\|Kyrute"** | `[129]` **Player**: "...lied to make yourself look good." | `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[142]` | **"1975\|Kyrute"** | `[129]` **Player**: "...lied to make yourself look good." | `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`<br>`Variable["BaseGame.Exile_PetrWithYou"] == true`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[143]` | **"You never returned to Sordland."** | `[136]` **Narrator**: "The book, titled 'Suzerain', flo..."<br>`[137]` **Narrator**: "The book, titled 'Suzerain', flo..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[150]` | **"1975\|Kyrute"** | `[126]` **Player**: "...turned him down." | `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[151]` | **"1975\|Kyrute"** | `[126]` **Player**: "...turned him down." | `Variable["BaseGame.Exile_PetrWithYou"] == true`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[152]` | **"1975\|Kyrute"** | `[126]` **Player**: "...turned him down." | `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[159]` | **"1975\|Kyrute"** | `[128]` **Player**: "...spared no one, least of all y..." | `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[160]` | **"1975\|Kyrute"** | `[128]` **Player**: "...spared no one, least of all y..." | `Variable["BaseGame.Exile_PetrWithYou"] == true`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[161]` | **"1975\|Kyrute"** | `[128]` **Player**: "...spared no one, least of all y..." | `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`<br>`(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false` | *Brak zmian stanu* | `[143]` **Player**: "You never returned to Sordland." |
| `[162]` | **"...worried for him."** | `[58]` **Narrator**: "For the next few months, you fol..."<br>`[59]` **Narrator**: "For the next few months, you fol..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[66]` **Narrator**: "When it came time for the electi..."<br>`[79]` **Narrator**: "When it came time for the electi..." |
| `[163]` | **"...worried."** | `[62]` **Narrator**: "For the next few months, you fol..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[66]` **Narrator**: "When it came time for the electi..."<br>`[79]` **Narrator**: "When it came time for the electi..." |
| `[164]` | **"...worried for her."** | `[60]` **Narrator**: "For the next few months, you fol..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[66]` **Narrator**: "When it came time for the electi..."<br>`[79]` **Narrator**: "When it came time for the electi..." |
| `[165]` | **"...relieved it was no longer your responsibility."** | `[58]` **Narrator**: "For the next few months, you fol..."<br>`[59]` **Narrator**: "For the next few months, you fol..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_sordishgoat");` | `[66]` **Narrator**: "When it came time for the electi..."<br>`[79]` **Narrator**: "When it came time for the electi..." |

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
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_seaside");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The boat journey to Kyrute took over a week. You spent most of it..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "...alone in your cabin."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...alone in your cabin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_MovePersonalWealth_Move == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...making plans with your family."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_MovePersonalWealth_Move == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "...making plans with your family."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "...playing cards with Petr."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...playing cards with Petr."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_MovePersonalWealth_Move == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_MovePersonalWealth_Move == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_MovePersonalWealth_Move == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_MovePersonalWealth_Move == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coast");"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coast");"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You immediately accessed the savings you'd transferred to an overseas account. You had enough to afford..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Player), `[5]` (Player), `[12]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[31]` (*Player: "...a cozy cabin in the mountains."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You regretted that you hadn't transferred your savings to an overseas account.

Fortunately, Petr had brought enough cash for the two of you to get by. Together, you could afford..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_PetrWithYou"] == true` AND `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Player), `[5]` (Player), `[12]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...a luxurious penthouse in the city center."*)
  - -> `[30]` (*Player: "...a sprawling villa in the countryside."*)
  - -> `[31]` (*Player: "...a cozy cabin in the mountains."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "1958|Konstantium|Kyrute"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You regretted that you hadn't transferred your savings to an overseas account.

You and Monica pooled together what little cash you'd brought. You had enough to afford..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "...a simple house in the countryside."*)
  - -> `[33]` (*Player: "...a modest apartment on the edge of the city."*)
  - -> `[31]` (*Player: "...a cozy cabin in the mountains."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1958|Konstantium|Kyrute"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "1958|Konstantium|Kyrute"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You regretted that you hadn't transferred your savings to an overseas account.

With the small amount of cash you'd brought, you had enough to afford..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "...a simple house in the countryside."*)
  - -> `[33]` (*Player: "...a modest apartment on the edge of the city."*)
  - -> `[31]` (*Player: "...a cozy cabin in the mountains."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "...a luxurious penthouse in the city center."*)
  - -> `[30]` (*Player: "...a sprawling villa in the countryside."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "...a simple house in the countryside."*)
  - -> `[33]` (*Player: "...a modest apartment on the edge of the city."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a luxurious penthouse in the city center."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Your ostentatious arrival attracted quite a bit of local ..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a sprawling villa in the countryside."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Your ostentatious arrival attracted quite a bit of local ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a cozy cabin in the mountains."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[17]` (Narrator), `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_CoupHappensAfterYouLeave == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a simple house in the countryside."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator), `[25]` (Narrator), `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_CoupHappensAfterYouLeave == true"*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a modest apartment on the edge of the city."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator), `[25]` (Narrator), `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_CoupHappensAfterYouLeave == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Your ostentatious arrival attracted quite a bit of local attention. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "...kept a low profile."*)
  - -> `[36]` (*Player: "...basked in the spotlight."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept a low profile."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_CoupHappensAfterYouLeave == true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...basked in the spotlight."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_CoupHappensAfterYouLeave == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_CoupHappensAfterYouLeave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_CoupHappensAfterYouLeave == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_CoupHappensAfterYouLeave == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_CoupHappensAfterYouLeave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_CoupHappensAfterYouLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_CoupHappensAfterYouLeave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_CoupHappensAfterYouLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_loss");"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Iosef and his troops realized you were gone, they released Monica and Deana from custody and staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Sordland was under military rule."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Sordland was under military rule."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator), `[45]` (Narrator), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Valken and his troops realized you were gone, they released Monica and Deana from custody and staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Sordland was under military rule."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Lucian struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "...worried for him."*)
  - -> `[165]` (*Player: "...relieved it was no longer your responsibility."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Albin struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "...worried for him."*)
  - -> `[165]` (*Player: "...relieved it was no longer your responsibility."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Gloria struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: "...worried for her."*)
  - -> `[165]` (*Player: "...relieved it was no longer your responsibility."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Petr struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "...worried for him."*)
  - -> `[165]` (*Player: "...relieved it was no longer your responsibility."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

With both the vice president and the president gone, the country descended into chaos.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "...worried."*)
  - -> `[165]` (*Player: "...relieved it was no longer your responsibility."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Lileas == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "When it came time for the election, Lileas easily won on ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Lileas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "When it came time for the election, Lileas easily won on her promises to restore order.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "When it came time for the election, Frens and the PFJP ea..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Manoly == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "When it came time for the election, Manoly and the PFJP e..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Kesaro == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "When it came time for the election, Kesaro and the NFP ea..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Kesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Remus == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "When it came time for the election, Remus and the NFP eas..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "When it came time for the election, the new People's Fron..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "When it came time for the election, Frens and the PFJP easily won on their promises to bring real change where you had failed.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "When it came time for the election, Manoly and the PFJP easily won on their promises to bring real change where you had failed.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "When it came time for the election, Kesaro and the NFP easily won on their promises to return Sordland to its roots.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "When it came time for the election, Remus and the NFP easily won on their promises to return Sordland to its roots.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "When it came time for the election, the new People's Front party easily won on their promises to return power to the masses.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "With Iosef firmly in power, little news got out of the country that wasn't censored. 

Eventually, you stopped paying attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Iosef_Enemy == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "With Iosef firmly in power, little news got out of the co..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Iosef_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "With Valken firmly in power, little news got out of the c..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "With Valken firmly in power, little news got out of the country that wasn't censored. 

Eventually, you stopped paying attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "Years went by."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[79]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_blue");"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "1963|Kyrute"]** — Mówca: **Narrator**
> "Over time, you and Petr assimilated further into life in Kyrute. 

The two of you..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_PetrWithYou"] == true` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_Country == true || BaseGa..."*)
  - -> `[103]` (*Player: "...embarked on a series of lucrative public speaking gigs."*)
  - -> `[104]` (*Player: "...became notorious for your high-rolling ways."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "1963|Kyrute"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "1963|Kyrute"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "1963|Kyrute"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "1963|Kyrute"]** — Mówca: **Narrator**
> "Over time, you assimilated further into life in Kyrute. 

You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_Country == true || BaseGa..."*)
  - -> `[103]` (*Player: "...embarked on a series of lucrative public speaking gigs."*)
  - -> `[104]` (*Player: "...became notorious for your high-rolling ways."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "1963|Kyrute"]** — Mówca: **Narrator**
> "Over time, you and your family assimilated further into life in Kyrute. 

You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_Country == true || BaseGa..."*)
  - -> `[103]` (*Player: "...embarked on a series of lucrative public speaking gigs."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...took up vegetable farming."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator), `[97]` (Narrator), `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Exile_Country == true || BaseGameIsolated.Epilogue_Exile_Mountains == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_Country == true || BaseGa..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Exile_Country == true || Base..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Exile_Country == true || BaseGameIsolated.Epilogue_Exile_Mountains == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: "...took up vegetable farming."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Exile_Country == true || BaseGameIsolated.Epilogue_Exile_Mountains == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "...joined the Konstantium city council."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...embarked on a series of lucrative public speaking gigs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator), `[97]` (Narrator), `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became notorious for your high-rolling ways."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the Konstantium city council."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator), `[97]` (Narrator), `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Deana excelled at her new school and eventually landed a ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Deana excelled at her new school and eventually landed a ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "You didn't hear much from Monica or the children. Deana c..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Deana excelled at her new school and eventually landed a prestigious internship at the Alliance of Nations.

Franc, having returned to Holsord once it was safe to do so, married his university girlfriend. Before too long, you were a grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Deana excelled at her new school and eventually landed a prestigious internship at the Alliance of Nations.

One day, you received a postcard from Franc saying that you were now a grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "You didn't hear much from Monica or the children. Deana called every so often -- it sounded like she was doing well in school.

One day, you received a postcard from Franc. You were now a grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "He named his son after you."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Kontekst wejściowy (poprzednik):** `[112]` (Narrator), `[113]` (Narrator), `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_City == true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < -2"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < -2)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "You never heard from him again."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "He named his son after you."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from him again."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Kontekst wejściowy (poprzednik):** `[112]` (Narrator), `[113]` (Narrator), `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_City == true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "1973|Kyrute"]** — Mówca: **Narrator**
> "One day, you were shopping for groceries when you ran into Tuomas Sacker, the television host who had interviewed you.

While catching up over drinks, he proposed co-authoring a tell-all book about your presidency. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Epilogue_Exile_City"] == true`
- **Kontekst wejściowy (poprzednik):** `[115]` (Player), `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "...agreed with gusto."*)
  - -> `[126]` (*Player: "...turned him down."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Exile_City == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Epilogue_Exile_City == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Epilogue_Exile_City == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Epilogue_Exile_City == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Exile_City"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "1973|Kyrute"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Epilogue_Exile_City == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Exile_City"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "1973|Kyrute"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "1973|Kyrute"]** — Mówca: **Narrator**
> "One day, on one of your rare trips into the city, you ran into Tuomas Sacker, the television host who had interviewed you.

While catching up over drinks, he proposed co-authoring a tell-all book about your presidency. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Epilogue_Exile_City"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Player), `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "...agreed with gusto."*)
  - -> `[126]` (*Player: "...turned him down."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...agreed with gusto."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator), `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...turned him down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator), `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "PrologueImage("");"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Together, you and Tuomas captured every detail of your time in office -- the political manoeuvring, the corruption, the toll it took on your family life. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: "...spared no one, least of all yourself."*)
  - -> `[129]` (*Player: "...lied to make yourself look good."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...spared no one, least of all yourself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...lied to make yourself look good."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You and Petr became persona non grata in Kyrute. Petr, despite having long since sworn off alcohol, developed a drug habit that quickly bankrupted you both.

You lived out the rest of your lives in destitution, alone except for each other, forgotten by everyone you ever knew."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true` AND `Variable["BaseGame.Exile_PetrWithYou"] == true` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You and your family became persona non grata in Kyrute. Deana blamed you for derailing her burgeoning political career.

Despite her misgivings, Monica stayed by your side.

Eventually, the people around you forgot who you were. You were able to live a normal, unexceptional life, taking what satisfaction you could wherever you could get it."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You became persona non grata in Kyrute. With no friends or family around, you quickly drank through your book advance.

You lived out the rest of your life in destitution, alone, forgotten by everyone you ever knew."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You and Petr became persona non grata in Kyrute. Petr began supplementing his alcoholism with a drug habit that quickly bankrupted you both.

You lived out the rest of your lives in destitution, alone except for each other, forgotten by everyone you ever knew."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false` AND `Variable["BaseGame.Exile_PetrWithYou"] == true` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never returned to Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Narrator), `[137]` (Narrator), `[141]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "More time went by. The Anton Rayne presidency became little more than a historical footnote as you devoted yourself fully to life in exile.

While Deana became a rising star in Kyrute politics, you and Monica were content to live out the rest of your days in anonymity."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "More time went by. The Anton Rayne presidency became little more than a historical footnote as you devoted yourself fully to life in exile.

While Petr continued to use his former vice presidential status to impress dates, you were content to live out the rest of your days in anonymity."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_PetrWithYou"] == true` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "More time went by. The Anton Rayne presidency became little more than a historical footnote as you devoted yourself fully to life in exile.

While wars, scandals and countless crises broke out and ended in the countries around you, you were content to live out the rest of your days in anonymity."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "1975|Kyrute"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', was an instant best-seller. You were lauded for your unflinching honesty.

Your fame aided Deana immensely in her political career. The Raynes became one of Kyrute's most powerful families.

You lived out the rest of your life in luxury, surrounded by family and newfound friends."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[128]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', was an instant best-seller. You were lauded for your unflinching honesty.

You and Petr leveraged your newfound celebrity to become members of the Kyrute elite.

The two of you lived out the rest of your lives surrounded by riches and sycophantic admirers. But you couldn't forget about all the people and places you had lost."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_PetrWithYou"] == true` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', was an instant best-seller. You were lauded for your unflinching honesty.

You leveraged your newfound celebrity to become one of Kyrute's most powerful men.

You lived out the rest of your life surrounded by riches and sycophantic admirers. But you couldn't forget about all the people and places you had lost."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false` AND `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "You never returned to Sordland."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried for him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[59]` (Narrator), `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried for her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...relieved it was no longer your responsibility."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[59]` (Narrator), `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sordishgoat");"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Iosef and his troops realized you were gone, they staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Sordland was under military rule."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.E..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "For the next few months, you followed the news from Sordl..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Valken and his troops realized you were gone, they staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "Sordland was under military rule."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_seaside");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_seaside");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The boat journey to Kyrute took over a week. You spent mo..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coast");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "1958|Konstantium|Kyrute"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coast");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_red");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_loss");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sordishgoat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_blue");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Together, you and Tuomas captured every detail of your ti..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exi..."*)
