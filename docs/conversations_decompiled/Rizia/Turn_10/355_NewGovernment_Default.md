# Rizia/Turn 10/NewGovernment_Default

- **ID konwersacji:** `355`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/355_NewGovernment_Default.md`
- **Liczba węzłów dialogowych:** 321
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Angelica`
- `RiziaDLC.Council_GrandVizier_Axel`
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_GrandVizier_Sal`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NewGov_PalesDebtPlan_DontPay`
- `RiziaDLC.Pales_Reconstruction_NoFunds`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.ReparationsAccepted_NoFunds`
- `RiziaDLCIsolated.NewGov_Butterfly_Chaos`
- `RiziaDLCIsolated.NewGov_Butterfly_Seasons`
- `RiziaDLCIsolated.NewGov_Butterfly_Taste`
- `RiziaDLCIsolated.NewGov_Butterfly_Traveled`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_Pales`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_Zille`
- `RiziaDLCIsolated.NewGov_ForeignAffairs`
- `RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.NewGov_Butterfly_Chaos`
- `RiziaDLCIsolated.NewGov_Butterfly_Seasons`
- `RiziaDLCIsolated.NewGov_Butterfly_Taste`
- `RiziaDLCIsolated.NewGov_Butterfly_Traveled`
- `RiziaDLCIsolated.NewGov_DomesticAffairs`
- `RiziaDLCIsolated.NewGov_ForeignAffairs`

### Skoki między-konwersacyjne:
- Węzeł `[73]` -> **[577] Rizia/Turn 10/Foreign_Affairs/Foreign_Affairs Conversation** (../Turn_10/577_Foreign_Affairs_Conversation.md), Węzeł `[1]`
- Węzeł `[74]` -> **[576] Rizia/Turn 10/Domestic Affairs/Domestic Affairs Conversation** (../Turn_10/576_Domestic_Affairs_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 25

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[14]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = true;`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = true;`
- Węzeł `[16]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;`
- Węzeł `[17]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;`
- Węzeł `[28]` (Paskal Beniwoll): `End(); ;`
- Węzeł `[29]` (Paskal Beniwoll): `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- Węzeł `[70]` (Paskal Beniwoll): `--;`
- Węzeł `[73]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`
- *...oraz 17 innych węzłów ze skryptami.*

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
  - -> `[29]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I stood on the palace balcony, watching as a flurry of monarch butterflies drifted through the air, their orange wings catching the late spring afternoon sunlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "They had come from as far as Rumburg, journeying thousands of miles to reach southern Xina, where they would winter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Rizia lay in the heart of their migration path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I had seen them before, but this time, something about their passage struck me differently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Perhaps it was the timing – this season of change, of endings and beginnings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't help but think that I, too, had traveled a great distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I was not the man I had been when I first took the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "A knock at the door drew me from my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I thought about how the flutter of a butterfly's wings could send ripples through the air, unseen but far-reaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't stop thinking about how when butterflies land on you, they’re tasting you with their feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
Mówca: **Narrator**
> "How even the smallest decisions in my reign -- those made in quiet moments -- could set off a chain of events far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Seasons = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Traveled = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Chaos = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Taste = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[18]`
Mówca: **Narrator**
> "As their footsteps faded down the corridor, I turned my gaze to the window overlooking the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The sun had begun to set, and the silhouettes of butterflies fluttered against the fading light."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[33]`
  - -> `[36]`
  - -> `[39]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I was once again reminded of the distance I had traveled to get here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[21]`
Mówca: **Narrator**
> "How my journey was far from over, and I would see it through to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Narrator**
> "I was once again reminded that, like the seasons, I too had changed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[23]`
Mówca: **Narrator**
> "And my transformation would carry me far into the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Narrator**
> "I was once again reminded of how the smallest of actions could result in consequences far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[25]`
Mówca: **Narrator**
> "I was once again reminded that they taste with their feet -- how life is fully of strange, unexpected oddities."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[26]`
Mówca: **Narrator**
> "And that as King of Rizia, it was my sole responsibility to deal with whatever came my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Narrator**
> "And no matter how strange the journey ahead might be, I would face the future head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Seasons == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Traveled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Chaos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Taste == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Taste == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Taste == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Narrator**
> "With no Grand Vizier to mediate between me and the matters of my kingdom, I alone was responsible for reviewing them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Narrator**
> "An attendant stepped forward, head bowed, holding a leather-bound folder thick with reports."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.Path_Stratocracy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.Path_Stratocracy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == false  or  Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.Path_Stratocracy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == false  or  Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
Mówca: **Narrator**
> "With one last glance at the butterflies, I stepped inside and made my way to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Setting the folder down, I took out the reports and spread them across my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Angelica stepped forward, head bowed. One of her aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Axel stepped forward, head bowed. One of his aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Sal stepped forward, head bowed. One of his aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Hugo stepped forward, head bowed. One of his aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[62]`
Mówca: **Angelica Sazon**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Hugo Toras**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, more paperwork. How delightful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guess I should get this over with...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. I will retire to my study and look this over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. You may go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[68]`
  - -> `[67]`
  - -> `[66]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "Foreign affairs."]** — Mówca: **Player_Romus_Italic**
> "I turned my attention to foreign affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "Domestic matters."]** — Mówca: **Player_Romus_Italic**
> "I opened the dossier on domestic matters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_ForeignAffairs = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `577` (*Rizia/Turn 10/Foreign_Affairs/Foreign_Affairs Conversation*), Węzeł `[1]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_DomesticAffairs = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_DomesticAffairs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `576` (*Rizia/Turn 10/Domestic Affairs/Domestic Affairs Conversation*), Węzeł `[1]`

### Węzeł `[75]`
Mówca: **Narrator**
> "I took the folder before they turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
Mówca: **Narrator**
> "I sat in my chair and took a moment to scan the contents, considering where to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[316]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ignacius"); RemoveConversant("Axel Reinhart"); RemoveConversant("Angelica Sazon"); 
RemoveConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Sal Ignacius");
RemoveConversant("Axel Reinhart");
RemoveConversant("Angelica Sazon");
RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Angelica Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NewGovEnding_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
Mówca: **Narrator**
> "It wasn't long before they entered my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[84]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone and summoned the attendant on the other end to summon my aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Council_GrandVizier_Sal == true || RiziaDLC.Council_GrandVizier_Axel == true || RiziaDLC.Council_GrandVizier_Angelica == true || RiziaDLC.Path_Stratocracy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Council_GrandVizier_Sal == true || RiziaDLC.Council_GrandVizier_Axel == true || RiziaDLC.Council_GrandVizier_Angelica == true || RiziaDLC.Path_Stratocracy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Sal"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Axel"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true  or  Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Council_GrandVizier_Sal == true || RiziaDLC.Council_GrandVizier_Axel == true || RiziaDLC.Council_GrandVizier_Angelica == true || RiziaDLC.Path_Stratocracy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Sal"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Axel"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true  or  Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Axel and his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Sal and his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Hugo and his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[91]`
Mówca: **Narrator**
> "It wasn't long before they entered my chambers, where I handed them what I had signed and sealed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon my wife and her aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Angelica and her aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[100]`
Mówca: **Angelica Sazon**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[104]`
Mówca: **Sal Ignacius**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[111]`
Mówca: **Axel Reinhart**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Angelica Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""As for funding the reparations for Pales, it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true 
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[133]`
Mówca: **Sal Ignacius**
> ""As for funding Pales' reconciliation... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[134]`
Mówca: **Narrator**
> "I handed them what I had signed and sealed, which they carefully looked over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NewGov_PalesDebtPlan_DontPay == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[138]`
Mówca: **Angelica Sazon**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[139]`
Mówca: **Angelica Sazon**
> ""As for funding Pales' reconciliation... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[155]`
Mówca: **Sal Ignacius**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[159]`
Mówca: **Hugo Toras**
> ""I take it that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[160]`
Mówca: **Sal Ignacius**
> ""I see that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[161]`
Mówca: **Sal Ignacius**
> ""I see that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Angelica Sazon**
> ""I see that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Angelica Sazon**
> ""I see that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Lucita Azaro**
> ""I see that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Lucita Azaro**
> ""I see that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`
  - -> `[173]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is resolved. I'm not paying for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“If they wish to rise from the rubble, they’ll find a way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I wish it were different. But the treasury is not endless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Then it is well-matched with the rest of the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""I take it that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""As for funding Pales' reconciliation... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""In any case, I'll see to it that your orders are carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Hugo bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[178]`
Mówca: **Sal Ignacius**
> ""Nevertheless, by His grace, your orders will be carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Sal bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[180]`
Mówca: **Angelica Sazon**
> ""Nevertheless, Your Majesty, I'll see to it that your orders are carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Angelica bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""Nevertheless, I'll see to it that your orders are carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Narrator**
> "Lucita bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[187]`
Mówca: **Narrator**
> "Lucita gave a slight nod before she turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ignacius"); RemoveConversant("Axel Reinhart"); RemoveConversant("Angelica Sazon"); 
RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Sal Ignacius");
RemoveConversant("Axel Reinhart");
RemoveConversant("Angelica Sazon");
RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“There is nothing more to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You assumed correctly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Hugo bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“The absence of change is the directive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Sal bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Angelica bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[216]`
Mówca: **Narrator**
> "Lucita bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Lucita gave a slight nod before she turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[213]`
  - -> `[210]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“If no order has been given, then you have your answer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[227]`
Mówca: **Hugo Toras**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[228]`
Mówca: **Sal Ignacius**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[232]`
Mówca: **Lucita Azaro**
> ""Forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[233]`
Mówca: **Angelica Sazon**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[234]`
Mówca: **Lucita Azaro**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[236]`
Mówca: **Lucita Azaro**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[240]`
Mówca: **Narrator**
> "They said they would "handle this at once," before departing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDLC.ReparationsAccepted_NoFunds == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDLC.ReparationsAccepted_NoFunds == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == false  and  Variable["RiziaDLC.ReparationsAccepted_NoFunds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDLC.ReparationsAccepted_NoFunds == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == false  and  Variable["RiziaDLC.ReparationsAccepted_NoFunds"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NewGov_PalesDebtPlan_DontPay == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[250]`
Mówca: **Narrator**
> "My advisor's attention was drawn to the report on Pales I had thrown across the room. An assistant retrieved it and smoothed it out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[251]`
Mówca: **Narrator**
> "The report on Pales was still sitting on my desk. My advisor eyed it cautiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[261]`
Mówca: **Narrator**
> "My advisor bowed once more before departing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[262]`
Mówca: **Narrator**
> "The report on Pales was still sitting on my desk. My advisor eyed it cautiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[266]`
Mówca: **Narrator**
> "My advisor's attention was drawn to the report on Pales I had thrown across the room. An assistant retrieved it and smoothed it out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[270]`
Mówca: **Narrator**
> "I handed the reports back to them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[274]`
Mówca: **Hugo Toras**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[275]`
Mówca: **Sal Ignacius**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[276]`
Mówca: **Angelica Sazon**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[277]`
Mówca: **Axel Reinhart**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_NoFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_NoFunds == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true 
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[284]`
Mówca: **Narrator**
> "I handed the reports back to them, saying nothing in them warranted decisive action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Narrator**
> "They acknowledged my remark, bowed and departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[290]`
Mówca: **Narrator**
> "And that just like the seasons, all things -- including my reign -- had to end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[294]`
Mówca: **Narrator**
> "And that my long journey was nearing its end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[298]`
Mówca: **Narrator**
> "And that one of those consequences was the imminent end of my reign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[302]`
Mówca: **Narrator**
> "I wondered what direction my own life would take once my reign came to an end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Path_Stratocracy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Path_Stratocracy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Path_Stratocracy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[306]`
Mówca: **Narrator**
> "Two columns of men in military garb walked in purposefully. They parted to reveal the Queen Consort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> "“Romus, Your Majesty. We've brought the latest reports from the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Empty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Empty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Narrator**
> "Two columns of men in military garb walked in purposefully. They parted to reveal my Grand Vizier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_ForeignAffairs == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_ForeignAffairs == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_ForeignAffairs == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_ForeignAffairs == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_ForeignAffairs == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_ForeignAffairs == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ForeignAffairs_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DomesticAffairs_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
