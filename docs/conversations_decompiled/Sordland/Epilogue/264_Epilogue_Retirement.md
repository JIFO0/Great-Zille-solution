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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 0
- **Węzły modyfikujące stan gry:** 0

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

Serge gave you a ride home for the last time and promised he would stay in touch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

Serge gave you a ride home for the last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_AcceptedMarcelCar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

You drove away in the Randolfini sports car Marcel had given you, never to return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "1958|Holsord"]** — Mówca: **Narrator**
> "On your last day as President of Sordland, you cleaned out all your personal belongings from your office at the Maroon Palace.

You drove home yourself, never to return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Lileas == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Kesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[31]`
Mówca: **Narrator**
> "The day after that, Lileas Graf was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`
  - -> `[39]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The day after that, Frens Ricter was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Narrator**
> "The day after that, Manoly Suheil of the PFJP was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`
  - -> `[39]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The day after that, Kesaro Kibener was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Narrator**
> "The day after that, Remus Holstron of the NFP was inaugurated as the new President of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Narrator**
> "The day after that, the new People's Front coalition took over as the governing party of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sincerely wished him luck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told the press you hoped he would fail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...paid no attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sincerely wished them luck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told the press you hoped they would fail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sincerely wished her luck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told the press you hoped she would fail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Holsord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Holsord == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_Holsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `265` (*Sordland/HOLSORD ENDING*), Węzeł `[1]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_Holsord == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_Holsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Anrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Anrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_Anrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `266` (*Sordland/ANRICA ENDING*), Węzeł `[1]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_Anrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_Anrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `267` (*Sordland/BENFI ENDING*), Węzeł `[1]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Erlory == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Erlory == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_Erlory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `268` (*Sordland/ERLORY ENDING*), Węzeł `[1]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_Erlory == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_Erlory"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `269` (*Sordland/ARCASIA OR UC ENDING*), Węzeł `[1]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt sad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
