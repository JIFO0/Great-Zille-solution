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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[174]` (Paskal Beniwoll): `PrologueImage("pe_seaside");`
- Węzeł `[175]` (Paskal Beniwoll): `PrologueImage("pe_coast");`
- Węzeł `[176]` (Paskal Beniwoll): `PrologueImage("pe_coast");`
- Węzeł `[177]` (Paskal Beniwoll): `PrologueImage("pe_red");`
- Węzeł `[178]` (Paskal Beniwoll): `PrologueImage("pe_loss");`
- Węzeł `[179]` (Paskal Beniwoll): `PrologueImage("pe_sordishgoat");`
- Węzeł `[180]` (Paskal Beniwoll): `PrologueImage("pe_blue");`
- Węzeł `[181]` (Paskal Beniwoll): `PrologueImage("");`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[174]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The boat journey to Kyrute took over a week. You spent most of it..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[6]`
  - -> `[9]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...alone in your cabin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...making plans with your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...playing cards with Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn10_MovePersonalWealth_Move == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You immediately accessed the savings you'd transferred to an overseas account. You had enough to afford..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[31]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You regretted that you hadn't transferred your savings to an overseas account.

Fortunately, Petr had brought enough cash for the two of you to get by. Together, you could afford..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You regretted that you hadn't transferred your savings to an overseas account.

You and Monica pooled together what little cash you'd brought. You had enough to afford..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[31]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "1958|Konstantium|Kyrute"]** — Mówca: **Narrator**
> "At long last, you reached the other side and disembarked in the city of Konstantium.

You regretted that you hadn't transferred your savings to an overseas account.

With the small amount of cash you'd brought, you had enough to afford..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a luxurious penthouse in the city center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a sprawling villa in the countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a cozy cabin in the mountains."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a simple house in the countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a modest apartment on the edge of the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Your ostentatious arrival attracted quite a bit of local attention. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept a low profile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...basked in the spotlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_CoupHappensAfterYouLeave == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_CoupHappensAfterYouLeave == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_CoupHappensAfterYouLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_CoupHappensAfterYouLeave == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_CoupHappensAfterYouLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[40]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Iosef and his troops realized you were gone, they released Monica and Deana from custody and staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Sordland was under military rule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[45]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Valken and his troops realized you were gone, they released Monica and Deana from custody and staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Lucian struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[165]`

### Węzeł `[59]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Albin struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[165]`

### Węzeł `[60]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Gloria struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[61]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Petr struggled to keep the country together in your absence.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[165]`

### Węzeł `[62]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

With both the vice president and the president gone, the country descended into chaos.

You felt..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[165]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Lileas == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Lileas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Narrator**
> "When it came time for the election, Lileas easily won on her promises to restore order.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Kesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Narrator**
> "When it came time for the election, Frens and the PFJP easily won on their promises to bring real change where you had failed.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[80]`
Mówca: **Narrator**
> "When it came time for the election, Manoly and the PFJP easily won on their promises to bring real change where you had failed.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[81]`
Mówca: **Narrator**
> "When it came time for the election, Kesaro and the NFP easily won on their promises to return Sordland to its roots.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[82]`
Mówca: **Narrator**
> "When it came time for the election, Remus and the NFP easily won on their promises to return Sordland to its roots.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
Mówca: **Narrator**
> "When it came time for the election, the new People's Front party easily won on their promises to return power to the masses.

Eventually, you lost interest in the travails of the new administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[84]`
Mówca: **Narrator**
> "With Iosef firmly in power, little news got out of the country that wasn't censored. 

Eventually, you stopped paying attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Narrator**
> "With Valken firmly in power, little news got out of the country that wasn't censored. 

Eventually, you stopped paying attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "1963|Kyrute"]** — Mówca: **Narrator**
> "Over time, you and Petr assimilated further into life in Kyrute. 

The two of you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[103]`
  - -> `[104]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "1963|Kyrute"]** — Mówca: **Narrator**
> "Over time, you assimilated further into life in Kyrute. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[103]`
  - -> `[104]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "1963|Kyrute"]** — Mówca: **Narrator**
> "Over time, you and your family assimilated further into life in Kyrute. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[103]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...took up vegetable farming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Exile_Country == true || BaseGameIsolated.Epilogue_Exile_Mountains == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Exile_Country == true || BaseGameIsolated.Epilogue_Exile_Mountains == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Exile_Country == true || BaseGameIsolated.Epilogue_Exile_Mountains == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Exile_Country"] == true  or  Variable["BaseGameIsolated.Epilogue_Exile_Mountains"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...embarked on a series of lucrative public speaking gigs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became notorious for your high-rolling ways."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the Konstantium city council."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Deana excelled at her new school and eventually landed a prestigious internship at the Alliance of Nations.

Franc, having returned to Holsord once it was safe to do so, married his university girlfriend. Before too long, you were a grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Deana excelled at her new school and eventually landed a prestigious internship at the Alliance of Nations.

One day, you received a postcard from Franc saying that you were now a grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Narrator**
> "You didn't hear much from Monica or the children. Deana called every so often -- it sounded like she was doing well in school.

One day, you received a postcard from Franc. You were now a grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "He named his son after you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from him again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "1973|Kyrute"]** — Mówca: **Narrator**
> "One day, you were shopping for groceries when you ran into Tuomas Sacker, the television host who had interviewed you.

While catching up over drinks, he proposed co-authoring a tell-all book about your presidency. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Exile_City == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Exile_City == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Exile_City"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Exile_City == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Exile_City"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "1973|Kyrute"]** — Mówca: **Narrator**
> "One day, on one of your rare trips into the city, you ran into Tuomas Sacker, the television host who had interviewed you.

While catching up over drinks, he proposed co-authoring a tell-all book about your presidency. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...agreed with gusto."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...turned him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Together, you and Tuomas captured every detail of your time in office -- the political manoeuvring, the corruption, the toll it took on your family life. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...spared no one, least of all yourself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...lied to make yourself look good."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You and Petr became persona non grata in Kyrute. Petr, despite having long since sworn off alcohol, developed a drug habit that quickly bankrupted you both.

You lived out the rest of your lives in destitution, alone except for each other, forgotten by everyone you ever knew."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You and your family became persona non grata in Kyrute. Deana blamed you for derailing her burgeoning political career.

Despite her misgivings, Monica stayed by your side.

Eventually, the people around you forgot who you were. You were able to live a normal, unexceptional life, taking what satisfaction you could wherever you could get it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You became persona non grata in Kyrute. With no friends or family around, you quickly drank through your book advance.

You lived out the rest of your life in destitution, alone, forgotten by everyone you ever knew."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', flopped miserably. You were ridiculed for attempting to rewrite history in your favor.

You and Petr became persona non grata in Kyrute. Petr began supplementing his alcoholism with a drug habit that quickly bankrupted you both.

You lived out the rest of your lives in destitution, alone except for each other, forgotten by everyone you ever knew."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never returned to Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "More time went by. The Anton Rayne presidency became little more than a historical footnote as you devoted yourself fully to life in exile.

While Deana became a rising star in Kyrute politics, you and Monica were content to live out the rest of your days in anonymity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "More time went by. The Anton Rayne presidency became little more than a historical footnote as you devoted yourself fully to life in exile.

While Petr continued to use his former vice presidential status to impress dates, you were content to live out the rest of your days in anonymity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "More time went by. The Anton Rayne presidency became little more than a historical footnote as you devoted yourself fully to life in exile.

While wars, scandals and countless crises broke out and ended in the countries around you, you were content to live out the rest of your days in anonymity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', was an instant best-seller. You were lauded for your unflinching honesty.

Your fame aided Deana immensely in her political career. The Raynes became one of Kyrute's most powerful families.

You lived out the rest of your life in luxury, surrounded by family and newfound friends."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', was an instant best-seller. You were lauded for your unflinching honesty.

You and Petr leveraged your newfound celebrity to become members of the Kyrute elite.

The two of you lived out the rest of your lives surrounded by riches and sycophantic admirers. But you couldn't forget about all the people and places you had lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "1975|Kyrute"]** — Mówca: **Narrator**
> "The book, titled 'Suzerain', was an instant best-seller. You were lauded for your unflinching honesty.

You leveraged your newfound celebrity to become one of Kyrute's most powerful men.

You lived out the rest of your life surrounded by riches and sycophantic admirers. But you couldn't forget about all the people and places you had lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried for him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried for her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...relieved it was no longer your responsibility."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[169]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Iosef and his troops realized you were gone, they staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true || BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true  or  Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[173]`
Mówca: **Narrator**
> "For the next few months, you followed the news from Sordland closely.

Once Valken and his troops realized you were gone, they staged a coup at the Maroon Palace, easily overpowering the security there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_seaside");)*
- **Efekt (`userScript`):** `PrologueImage("pe_seaside");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coast");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coast");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_red");)*
- **Efekt (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_loss");)*
- **Efekt (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
