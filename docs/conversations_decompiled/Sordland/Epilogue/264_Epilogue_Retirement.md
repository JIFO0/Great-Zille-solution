# Sordland/Epilogue_Retirement

- **ID konwersacji:** `264`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_Retirement)`
- **Lokalizacja pliku:** `Sordland/Epilogue/264_Epilogue_Retirement.md`
- **Liczba węzłów dialogowych:** 58
- **Liczba wyborów gracza:** 13

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Lileas`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Retirement_Anrica`
- `BaseGame.Retirement_Benfi`
- `BaseGame.Retirement_Erlory`
- `BaseGame.Retirement_Holsord`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGameIsolated.Turn07_AcceptedMarcelCar`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[45]` -> **[265] Sordland/HOLSORD ENDING** (../Epilogue/265_HOLSORD_ENDING.md), Węzeł `[1]`
- Węzeł `[48]` -> **[266] Sordland/ANRICA ENDING** (../Epilogue/266_ANRICA_ENDING.md), Węzeł `[1]`
- Węzeł `[51]` -> **[267] Sordland/BENFI ENDING** (../Epilogue/267_BENFI_ENDING.md), Węzeł `[1]`
- Węzeł `[54]` -> **[268] Sordland/ERLORY ENDING** (../Epilogue/268_ERLORY_ENDING.md), Węzeł `[1]`
- Węzeł `[55]` -> **[269] Sordland/ARCASIA OR UC ENDING** (../Epilogue/269_ARCASIA_OR_UC_ENDING.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Player**: "You felt sad."<br>`[57]` **Player**: "You felt relieved." |
| `[10]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Player**: "You felt sad."<br>`[57]` **Player**: "You felt relieved." |
| `[14]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Player**: "You felt sad."<br>`[57]` **Player**: "You felt relieved." |
| `[15]` | **"1958\|Holsord"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Player**: "You felt sad."<br>`[57]` **Player**: "You felt relieved." |
| `[37]` | **"...sincerely wished him luck."** | `[32]` **Narrator**: "The day after that, Frens Ricter..."<br>`[34]` **Narrator**: "The day after that, Kesaro Kiben..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[38]` | **"...told the press you hoped he would fail."** | `[32]` **Narrator**: "The day after that, Frens Ricter..."<br>`[34]` **Narrator**: "The day after that, Kesaro Kiben..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[39]` | **"...paid no attention."** | `[31]` **Narrator**: "The day after that, Lileas Graf ..."<br>`[32]` **Narrator**: "The day after that, Frens Ricter..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[40]` | **"...sincerely wished them luck."** | `[36]` **Narrator**: "The day after that, the new Peop..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[41]` | **"...told the press you hoped they would fail."** | `[36]` **Narrator**: "The day after that, the new Peop..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[42]` | **"...sincerely wished her luck."** | `[31]` **Narrator**: "The day after that, Lileas Graf ..."<br>`[33]` **Narrator**: "The day after that, Manoly Suhei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[43]` | **"...told the press you hoped she would fail."** | `[31]` **Narrator**: "The day after that, Lileas Graf ..."<br>`[33]` **Narrator**: "The day after that, Manoly Suhei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[56]` | **"You felt sad."** | `[9]` **Narrator**: "On your last day as President of..."<br>`[10]` **Narrator**: "On your last day as President of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "The day after that, Lileas Graf ..."<br>`[32]` **Narrator**: "The day after that, Frens Ricter..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"You felt relieved."** | `[9]` **Narrator**: "On your last day as President of..."<br>`[10]` **Narrator**: "On your last day as President of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "The day after that, Lileas Graf ..."<br>`[32]` **Narrator**: "The day after that, Frens Ricter..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "1958|Holsord"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "1958|Holsord"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

Serge gave you a ride home for the last time and promised he would stay in touch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "You felt sad."*)
  - -> `[57]` (*Player: "You felt relieved."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

Serge gave you a ride home for the last time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "You felt sad."*)
  - -> `[57]` (*Player: "You felt relieved."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "1958|Holsord"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "1958|Holsord"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

You drove away in the Randolfini sports car Marcel had given you, never to return."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "You felt sad."*)
  - -> `[57]` (*Player: "You felt relieved."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

You drove home yourself, never to return."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "You felt sad."*)
  - -> `[57]` (*Player: "You felt relieved."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Lileas == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Lileas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The day after that, Lileas Graf was inaugurated as the ne..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Lileas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Frens == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Frens == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The day after that, Frens Ricter was inaugurated as the n..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Manoly == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Manoly == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Manoly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "The day after that, Manoly Suheil of the PFJP was inaugur..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Manoly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Remus == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Remus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "The day after that, Remus Holstron of the NFP was inaugur..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Remus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The day after that, the new People's Front coalition took..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Kesaro == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_NewPresident_Kesaro == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_NewPresident_Kesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The day after that, Kesaro Kibener was inaugurated as the..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_NewPresident_Kesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Remus == true"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "The day after that, Lileas Graf was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "...sincerely wished her luck."*)
  - -> `[43]` (*Player: "...told the press you hoped she would fail."*)
  - -> `[39]` (*Player: "...paid no attention."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The day after that, Frens Ricter was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "...sincerely wished him luck."*)
  - -> `[38]` (*Player: "...told the press you hoped he would fail."*)
  - -> `[39]` (*Player: "...paid no attention."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "The day after that, Manoly Suheil of the PFJP was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "...sincerely wished her luck."*)
  - -> `[43]` (*Player: "...told the press you hoped she would fail."*)
  - -> `[39]` (*Player: "...paid no attention."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The day after that, Kesaro Kibener was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "...sincerely wished him luck."*)
  - -> `[38]` (*Player: "...told the press you hoped he would fail."*)
  - -> `[39]` (*Player: "...paid no attention."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "The day after that, Remus Holstron of the NFP was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "...sincerely wished him luck."*)
  - -> `[38]` (*Player: "...told the press you hoped he would fail."*)
  - -> `[39]` (*Player: "...paid no attention."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "The day after that, the new People's Front coalition took over as the governing party of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "...paid no attention."*)
  - -> `[40]` (*Player: "...sincerely wished them luck."*)
  - -> `[41]` (*Player: "...told the press you hoped they would fail."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sincerely wished him luck."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told the press you hoped he would fail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator), `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...paid no attention."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[32]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sincerely wished them luck."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told the press you hoped they would fail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sincerely wished her luck."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told the press you hoped she would fail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[33]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Holsord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Holsord == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_Holsord == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Holsord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_Holsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_Holsord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_Holsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Anrica == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Anrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Anrica == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_Anrica == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Anrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_Anrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_Anrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_Anrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Benfi == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Benfi == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_Benfi == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Erlory == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Erlory == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_Erlory == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Retirement_Erlory == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_Erlory == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Retirement_Erlory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Retirement_Erlory == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Retirement_Erlory"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt sad."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[10]` (Narrator), `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas == true"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt relieved."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[10]` (Narrator), `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_NewPresident_Lileas == true"*)
