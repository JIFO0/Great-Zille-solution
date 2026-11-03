# Rizia/Turn 11/Ending_Revolution

- **ID konwersacji:** `455`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Rizia/Turn_11/455_Ending_Revolution.md`
- **Liczba węzłów dialogowych:** 1287
- **Liczba wyborów gracza:** 178

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[90]** Bruno
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_InjuredInRevolution`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_FinalDecision_StayAndFight`
- `RiziaDLC.Pabel_InjuredInRevolution`
- `RiziaDLC.Policy_Order_GoldenGuard_Default`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn01_Religion_DivusZaitu`
- `RiziaDLCIsolated.Ending_Revolution_SevrioDead`
- `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno`
- `RiziaDLCIsolated.Revolution_EscapeCountdown`
- `RiziaDLCIsolated.Revolution_Guards_Count`
- `RiziaDLCIsolated.Revolution_Guards_Defend`
- `RiziaDLCIsolated.Revolution_Guards_Follow`
- `RiziaDLCIsolated.Revolution_Guards_Reinforcements`
- `RiziaDLCIsolated.Revolution_GunEmpty`
- `RiziaDLCIsolated.Revolution_HelicopterEnemyCount`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow`
- `RiziaDLCIsolated.Revolution_Titus_Reinforcements`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Epilogue_Death_Revolution_Speech`
- `RiziaDLC.Epilogue_Death_Revolution_Surrounded`
- `RiziaDLC.Epilogue_KingdomDissolves_Revolution`
- `RiziaDLC.Epilogue_Prison_Revolution_Surrounded`
- `RiziaDLC.Epilogue_Revolution_Survived_WithLucita`
- `RiziaDLC.Epilogue_Revolution_Survived_WithPabel`
- `RiziaDLC.Epilogue_Survived_Revolution`
- `RiziaDLC.Lucita_InjuredInRevolution`
- `RiziaDLC.Pabel_InjuredInRevolution`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLCIsolated.Ending_Revolution_SevrioDead`
- `RiziaDLCIsolated.Ending_Revolution_TitusDead`
- `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno`
- `RiziaDLCIsolated.Revolution_Barricade`
- `RiziaDLCIsolated.Revolution_Dialogue`
- `RiziaDLCIsolated.Revolution_EscapeCountdown`
- `RiziaDLCIsolated.Revolution_Guards_Count`
- `RiziaDLCIsolated.Revolution_Guards_Defend`
- `RiziaDLCIsolated.Revolution_Guards_Follow`
- `RiziaDLCIsolated.Revolution_Guards_Reinforcements`
- `RiziaDLCIsolated.Revolution_GunEmpty`
- `RiziaDLCIsolated.Revolution_Helicopter`
- `RiziaDLCIsolated.Revolution_HelicopterEnemyCount`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow`
- `RiziaDLCIsolated.Revolution_Titus_Reinforcements`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 107

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[64]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = 4;`
- Węzeł `[65]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Helicopter"] = true;`
- Węzeł `[66]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Dialogue"] = true;`
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Barricade"] = true;`
- Węzeł `[68]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] = true;`
- Węzeł `[69]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] = true;`
- Węzeł `[70]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- Węzeł `[71]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- *...oraz 99 innych węzłów ze skryptami.*

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
  - -> `[1286]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by Titus and Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Revolutionaries, armed to the teeth with a menacing array of weaponry, were pushing against the palace gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[5]`
Mówca: **Narrator**
> "While no shots had been fired, tension hung heavy in the air, as if the slightest spark would ignite the powder keg of unrest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's too many of them. We don't stand a chance. I'll address them from the palace balcony -- try to calm them down or at least buy us some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't rely on outside help. We have to get to the helipad on our own. It's risky, but it's our only means of escape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll barricade ourselves here and hold out until help arrives. We have no choice but to wait.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucita squeezed my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1123]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Pabel squeezed my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1135]`

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""I can't believe I'm saying this, but I'm scared. There are just too many of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[18]`
Mówca: **Pabel Adria**
> ""They've trampled straight through the hedge maze. That'll take weeks to replant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`
  - -> `[627]`
  - -> `[626]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do whatever it takes to protect you. Both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. Everything's going to be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Collective gasps and shouts of disbelief suddenly erupted from all around me. I turned back to the security monitor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[23]`
Mówca: **Lucita Azaro**
> ""If it weren't for {RiziaDLCText.KingsSon}, I'd insist we hold the capital at all costs. But Romus... I think this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He'd stayed by my side even as the revolutionaries closed in on Porte Drazon, drinking glass after glass of wine with me and listening to me reminisce about the days when kings still held power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""No, you can't! Are you insane? They'll arrest you -- or worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[912]`
  - -> `[74]`
  - -> `[75]`
  - -> `[77]`

### Węzeł `[32]`
Mówca: **Pabel Adria**
> ""That's insane! They'll arrest you -- or worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`
  - -> `[913]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[39]`
Mówca: **Lucita Azaro**
> ""I'll try my best to keep up. But don't slow down because of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[40]`
Mówca: **Pabel Adria**
> ""I'm with you, Rom. Always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[41]`
Mówca: **Narrator**
> "My guards awaited my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[94]`

### Węzeł `[42]`
Mówca: **Narrator**
> "I turned to see my guards, their expectant gazes awaiting my command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]`

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""They'd better arrive soon, or we're finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]`

### Węzeł `[50]`
Mówca: **Pabel Adria**
> ""Let's hope they arrive soon or we're done for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]`

### Węzeł `[51]`
Mówca: **Narrator**
> "My guards turned to me for instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay with us. Grab whatever you can and barricade the door.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[998]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need reinforcements. Go round up as many other guards as you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[994]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of you, come with me. We need every available hand to make it through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of you remain here in case there's any attempt to contact us over the radio.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come with me. I can't go out there without any guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and defend this room with your lives. Is that clear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Narrator**
> "With a salute, two of my guards rushed out of the room as quickly as they could. In the meantime, we needed to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[59]`
Mówca: **Narrator**
> "They saluted and fell in step behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[60]`
Mówca: **Narrator**
> "They gave a resounding "Yes, sir!" and saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[61]`
Mówca: **Narrator**
> "They saluted and fell into step behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[62]`
Mówca: **Narrator**
> "One of the guards saluted before attempting to tune into a radio channel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[63]`
Mówca: **Narrator**
> "They saluted me and scanned the room for anything they could use to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown = 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Helicopter = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Helicopter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Dialogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Dialogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Barricade = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Barricade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Follow = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Follow = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Reinforcements = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I don't make it back, know that I will always love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember me well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "Kiss him."]** — Mówca: **Player_Romus_Italic**
> "I kissed him. He had tears in his eyes as I pulled away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "Kiss her."]** — Mówca: **Player_Romus_Italic**
> "I kissed her. She had tears in her eyes as I pulled away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "I left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1148]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "We slipped out of the room as quietly as possible and ascended nearby stairs to the ground floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[80]`
Mówca: **Narrator**
> "And then we waited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "Barricade with a table."]** — Mówca: **Player_Romus_Italic**
> "I moved the table to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "Barricade with a bookshelf."]** — Mówca: **Player_Romus_Italic**
> "I moved the bookshelf to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[83]`
Mówca: **Narrator**
> "I heard the sound of footsteps approaching from the level above, gradually drawing closer and closer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Identify yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Before long, there was a knock on the door. I gripped my gun firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[87]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "Do not answer."]** — Mówca: **Player_Romus_Italic**
> "I did not answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Romus_Italic**
> "I opened the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "Do not open the door."]** — Mówca: **Player_Romus_Italic**
> "I did not open the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Narrator**
> "I heard the muffled voices of multiple people in the hallway. I couldn't make out who it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1097]`

### Węzeł `[91]`
Mówca: **Narrator**
> "After a short while, the people on the other side left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1024]`

### Węzeł `[92]`
Mówca: **Narrator**
> "It was the returning sentries bringing along four other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we proceed, we need additional reinforcements. Hurry and seek out more guards to aid in our defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "They saluted me and dashed out of the room as fast as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Reinforcements = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "We waited, anxious for the return of our reinforcements. Knowing that armed militants were rampaging through the palace made the minutes feel like hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1187]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Default == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Default == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Default == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Narrator**
> "It was the returning sentries bringing along two other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[110]`
Mówca: **Narrator**
> "It was Sevrio, bringing along seven other Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 7;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Narrator**
> "My guards returned. They couldn't find anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "They entered and informed us that the revolutionaries were closing in, urging us to prepare for the imminent threat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Reinforcements == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Reinforcements == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Reinforcements == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1004]`

### Węzeł `[117]`
Mówca: **Narrator**
> "It was one of the palace cleaners, trying to run away from the militants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "It was then I heard an increasing number of footsteps growing louder by the second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "They were rapidly approaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1077]`

### Węzeł `[120]`
Mówca: **Narrator**
> "We continued reinforcing the door. Before long, the footsteps stopped right outside our barricade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1062]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Listen closely."]** — Mówca: **Player_Romus_Italic**
> "I listened closely to understand what was going on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "Don't move."]** — Mówca: **Player_Romus_Italic**
> "I remained still, waiting to see what would happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[123]`
Mówca: **Narrator**
> "That's when I heard a loud piercing beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[124]`
  - -> `[126]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""GET DOWN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1067]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""IT'S THEM!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1067]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""RUN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1067]`

### Węzeł `[127]`
Mówca: **Narrator**
> "That's when I heard a loud beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1072]`

### Węzeł `[128]`
Mówca: **Narrator**
> "The door burst open with a deafening explosion, knocking me to the ground as an intense sound and flash overwhelmed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[130]`
Mówca: **Narrator**
> "With a deafening explosion, the door burst open, knocking me to the ground as an intense sound and flash overwhelmed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[132]`
Mówca: **Narrator**
> "A barrage of gunfire suddenly erupted from the hall -- the smoke from the explosion obscuring the gunmen -- and I took off running."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[134]`
  - -> `[137]`
  - -> `[133]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "Take cover."]** — Mówca: **Player_Romus_Italic**
> "I took cover behind the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
**[WYBÓR GRACZA: "Shield Pabel with your body."]** — Mówca: **Player_Romus_Italic**
> "I shielded Pabel with my body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "Shield Lucita with your body."]** — Mówca: **Player_Romus_Italic**
> "I shielded Lucita with my body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "Fire your gun blindly at the door."]** — Mówca: **Player_Romus_Italic**
> "Unable to see the assailants, I fired my gun blindly toward the direction of the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Narrator**
> "I cried out in agony as a sharp searing pain spread through my thigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1031]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Cries of pain told me I'd managed to land a hit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1030]`

### Węzeł `[145]`
Mówca: **Narrator**
> "As did Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
Mówca: **Narrator**
> "As did Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1032]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1032]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Narrator**
> "An eerie silence settled in, and a slow, creeping terror began to consume my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[157]`
Mówca: **Narrator**
> "I could feel the sharp glass and splinters piercing my skin as I crawled on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1025]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Before I knew it, a mob of masked militants wielding automatic rifles stormed the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1033]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[162]`
Mówca: **Narrator**
> "All of my guards were dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[163]`
Mówca: **Narrator**
> "They aimed their rifles in my direction the moment I was identified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Glancing over at Lucita, I was relieved to see her unharmed. At least for the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Glancing over at Pabel, I was relieved to see him unharmed. At least for the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[172]`
Mówca: **Narrator**
> "My remaining guards threw down their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[173]`
Mówca: **Narrator**
> "That's when I realized that I was the only one still holding a gun. The militants were yelling at me to lower it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "Drop your weapon."]** — Mówca: **Player_Romus_Italic**
> "I dropped my weapon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "Shoot them."]** — Mówca: **Player_Romus_Italic**
> "I raised the barrel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_GunEmpty = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_GunEmpty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_GunEmpty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_GunEmpty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_GunEmpty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_GunEmpty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_GunEmpty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[180]`
Mówca: **Narrator**
> "All I heard was a click. The magazine was empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[181]`
Mówca: **Narrator**
> "I targeted the man in the lead, shooting him in the head. In response, all rifles redirected their aim towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. I beg you. Don't hurt me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’ll give you anything you want. Name your price. Just let us go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "They closed in on me, delivering a blow to my gut before binding my wrists with handcuffs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[185]`
Mówca: **Narrator**
> "One of them stepped forward and kicked the gun away with his boot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`
  - -> `[609]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will pay for what you've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Prison_Revolution_Surrounded = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Prison_Revolution_Surrounded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Death_Revolution_Surrounded = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Death_Revolution_Surrounded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[190]`
**[WYBÓR GRACZA: "Load your gun."]** — Mówca: **Player_Romus_Italic**
> "I loaded a magazine into my gun and pulled back the slide, preparing for the worst."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Stress", "R_Stress_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[192]`
Mówca: **Narrator**
> "It was Sevrio, accompanied by six additional Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 6;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Sevrio Castellanus**
> ""They're closing in, Your Majesty. We've got to act fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1222]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[197]`
Mówca: **Narrator**
> "One of the guards carefully opened the door and peeked around the corner. Seeing the coast was clear, he motioned for us to follow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "Hurry to the garden exit."]** — Mówca: **Player_Romus_Italic**
> "We hurried toward the garden exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "Approach cautiously."]** — Mówca: **Player_Romus_Italic**
> "Instead of charging toward the exit at full speed, we took a cautious approach."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[200]`
Mówca: **Narrator**
> "Our small group advanced a few meters at a time, using columns and other obstructions as cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[201]`
Mówca: **Narrator**
> "I couldn't believe that I was fleeing my own palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[202]`
Mówca: **Narrator**
> "It was the most direct route but would leave us exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Narrator**
> "We attempted to cross swiftly, but Lucita couldn't keep up, so we slowed our pace to accommodate her despite her protestations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[208]`
Mówca: **Narrator**
> "I cursed under my breath upon seeing three armed men. Fortunately, their backs were turned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "Instruct your guards to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I instructed my guards to create a distraction so that we might increase the chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "Try to sneak by without being seen."]** — Mówca: **Player_Romus_Italic**
> "We tried to sneak by without being seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[215]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "Instruct your remaining guard to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I instructed my remaining guard to create a distraction so that we might increase the chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "Instruct one of your guards to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I instructed one of my guards to create a distraction so that we might increase the chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "Run by them as fast as you can."]** — Mówca: **Player_Romus_Italic**
> "We ran by them as fast as we could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count = 0; RiziaDLCIsolated.Ending_Revolution_TitusDead = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 0;
Variable["RiziaDLCIsolated.Ending_Revolution_TitusDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[220]`
Mówca: **Narrator**
> "As I thought, the guards' equipment made too much noise and we were immediately spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`
  - -> `[210]`
  - -> `[216]`

### Węzeł `[227]`
Mówca: **Narrator**
> "As luck would have it, we somehow passed without attracting their attention. Before long, we reached the doors leading to the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Narrator**
> "I did a quick headcount to see if we'd lost anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Narrator**
> "In a flash, gunfire erupted. The frenzy of the firefight granted us a chance to escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[237]`
Mówca: **Narrator**
> "Thankfully, Lucita was uninjured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Thankfully, Pabel was uninjured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[248]`
Mówca: **Narrator**
> "And the guards that were left were sufficient to get us the rest of the way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1206]`
  - -> `[254]`

### Węzeł `[249]`
Mówca: **Narrator**
> "However, only two guards remained, which wasn't very reassuring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1203]`
  - -> `[254]`

### Węzeł `[250]`
Mówca: **Narrator**
> "However, with only one guard remaining, our chances of success were greatly diminished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[251]`
Mówca: **Narrator**
> "However, there were no guards left. Our situation was bleak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Peeking through the cracked door, I could spot the helicopter from my vantage point. However, I also noticed three armed men kneeling beside it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[253]`
Mówca: **Narrator**
> "But before I could decipher what was going on, a deafening blast rang out. The helicopter blew up, along with our hopes of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_EscapeCountdown >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_EscapeCountdown >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Narrator**
> "I could see the helicopter from where I was,  but I also saw three armed men running towards it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[261]`
Mówca: **Narrator**
> "I could make out the helicopter from my vantage point, but I also spotted three armed men making their way toward it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[266]`
Mówca: **Narrator**
> "I squinted, struggling for a moment to discern their actions, and soon realized they appeared to be planting a bomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[267]`
Mówca: **Narrator**
> "We had time. We could make it if we were quick enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[271]`
Mówca: **Narrator**
> "It would be almost impossible to reach the vehicle before them, especially with Lucita in her current state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[272]`
Mówca: **Narrator**
> "I froze in place, and my vision started to blur."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Narrator**
> "I could barely make out the men rushing to surround us, their rifles aimed at our heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Narrator**
> "The harsh reality of my situation became painfully clear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""PRESS FORWARD! FIRE AT WILL!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "Aim and fire your weapon."]** — Mówca: **Player_Romus_Italic**
> "Without delay, I focused my aim and discharged my firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[280]`
Mówca: **Narrator**
> "The shot struck the man planting the bomb in the back of the head. He crumpled to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount = 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[292]`
Mówca: **Narrator**
> "I missed my shot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[301]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. All three militants were still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[302]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. All of the militants were dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[303]`
Mówca: **Narrator**
> "What followed was a blur in my memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[313]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. Two of the militants were still standing, and my gun's magazine was now empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[314]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. Only one of the militants was still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Narrator**
> "He immediately threw down his rifle and kneeled on the ground, begging for his life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[319]`
Mówca: **Narrator**
> "But then, much to my relief, I noticed one of my guards on the ground, playing dead. He gave me a slight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Narrator**
> "The moment the militants approached, he stood and opened fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Narrator**
> "By some miracle, he managed to kill both of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[325]`
Mówca: **Narrator**
> "He managed to kill one of them before a hail of machine gun bullets tore through his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "I never forgot his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[327]`
**[WYBÓR GRACZA: "Shoot him."]** — Mówca: **Player_Romus_Italic**
> "I took aim and shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[328]`
**[WYBÓR GRACZA: "Spare him."]** — Mówca: **Player_Romus_Italic**
> "After a moment's hesitation, I decided to leave him alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Surrounded Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Surrounded Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Surrounded Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Surrounded Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Surrounded Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Survived Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[335]`
Mówca: **Narrator**
> "We had won. There was nothing in between us and the helicopter. But at what cost?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1037]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Surrounded Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Narrator**
> "By some miracle, they managed to kill all three men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
Mówca: **Narrator**
> "I watched them die one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Surrounded Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[350]`
Mówca: **Narrator**
> "But as I diverted my attention, he lunged forward and tried to stab me with his knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[357]`
Mówca: **Narrator**
> "But just as I turned away from him, he lunged at Pabel with his knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[358]`
Mówca: **Narrator**
> "But just as I turned away from him, he lunged at Lucita with his knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[365]`
Mówca: **Narrator**
> "I tried to stop him, but it was too late. My wife screamed in agony as her attacker sunk his knife into her chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[366]`
Mówca: **Narrator**
> "Fortunately, Titus quickly recognized his intentions and promptly shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[367]`
Mówca: **Narrator**
> "Blinded by rage, I strangled the assailant until he died."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
Mówca: **Narrator**
> "Sevrio and I tried to stop him, but we were too late. My wife screamed in agony as the assailant sunk his knife into her chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[369]`
Mówca: **Narrator**
> "The guard immediately shot the attacker dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_InjuredInRevolution = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_InjuredInRevolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`

### Węzeł `[381]`
Mówca: **Narrator**
> "We had won. There was nothing between us and the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[382]`
Mówca: **Narrator**
> "I let out a huge sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[385]`
Mówca: **Narrator**
> "I tore off a piece of my shirt and wrapped it around Lucita's wound. She was bleeding profusely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1040]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1041]`

### Węzeł `[389]`
Mówca: **Narrator**
> "Fueled by adrenaline, I found the strength to carry my wife in my arms and hurried toward the chopper as quickly as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[390]`
Mówca: **Narrator**
> "I tore off a piece of my shirt and wrapped it around Pabel's wound. He was bleeding profusely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[391]`
Mówca: **Narrator**
> "Fueled by adrenaline, I found the strength to carry my lover in my arms and hurried toward the chopper as quickly as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[392]`
Mówca: **Narrator**
> "I grabbed Lucita by the waist to support her, and we hurried toward the chopper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Narrator**
> "I grabbed Pabel by the hand and we hurried toward the chopper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Narrator**
> "I started running toward the chopper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[401]`
**[WYBÓR GRACZA: "Board the helicopter."]** — Mówca: **Player_Romus_Italic**
> "We boarded the helicopter as the pilot started the engine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[402]`
Mówca: **Narrator**
> "With our avenues for retreat dwindling and imminent danger looming ever closer, our only hope lay in the helicopter in the palace gardens where a skilled pilot sat at the ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""R... Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`
  - -> `[416]`

### Węzeł `[410]`
Mówca: **Pabel Adria**
> ""R... Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`
  - -> `[416]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sshh. Don't waste your energy, my love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's okay. It's over now. We're going to be fine. Just hang on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are almost out of here. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[417]`
Mówca: **Lucita Azaro**
> ""Lis... Listen to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Lucita Azaro**
> ""If it comes down to choosing between me and our child... please, put his life first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Lucita Azaro**
> ""Please...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`
  - -> `[442]`

### Węzeł `[420]`
Mówca: **Pabel Adria**
> ""Listen... Listen to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Pabel Adria**
> ""I just wanted to say that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Pabel Adria**
> ""My heart has always belonged to you. I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`
  - -> `[442]`
  - -> `[1262]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[429]`
Mówca: **Lucita Azaro**
> ""I can't believe we made it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Pabel Adria**
> ""It's hard to believe that we made it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Lucita Azaro**
> ""That was magnificent, Romus. My heart's still pounding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Pabel Adria**
> ""I'm at a loss for words...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Lucita Azaro**
> ""Keep up that kind of bravery, and the capital is ours for the retaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Pabel Adria**
> ""You're more than a great king, Rom. You're a great man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""I love you. Now let's get the hell out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Pabel Adria**
> ""I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Narrator**
> "We kissed passionately as the helicopter blades whirred to life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[438]`
Mówca: **Narrator**
> "We began rising over the palace turrets. I took a look below me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[439]`
Mówca: **Narrator**
> "I ripped off another piece of my shirt to stop the bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't leave me. I need you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You’ll be fine. Just hold on a little longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[443]`
Mówca: **Narrator**
> "Palas Rezna, my home, was on fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Survived_Revolution = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Survived_Revolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[445]`
Mówca: **Narrator**
> "Ahead of me, a set of doors led to a long stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[446]`
Mówca: **Narrator**
> "Five flights later, I emerged into the upper-level corridor, still untouched by the armed assailants. The balcony was in the audience chamber at the far end of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[932]`

### Węzeł `[447]`
Mówca: **Narrator**
> "And that's when it hit me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[448]`
  - -> `[450]`
  - -> `[451]`

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand you now, Father. Perhaps I've grasped the depths of disgrace and shame a little too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]`

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like father like son... 'Frail.' Am I destined to bear the same name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should have never been the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should have never been the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[452]`
Mówca: **Narrator**
> "Unsurprisingly, his portrait didn't reply in return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Narrator**
> "The distant sounds of unrest from outside snapped me back to the present."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Narrator**
> "It wasn't long before I reached the doors to the audience chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[455]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[458]`
  - -> `[1167]`
  - -> `[1164]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I die, so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Romus. You can do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`

### Węzeł `[459]`
**[WYBÓR GRACZA: "Open the balcony doors."]** — Mówca: **Player_Romus_Italic**
> "I opened the balcony doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[955]`

### Węzeł `[460]`
Mówca: **Narrator**
> "I gazed out into the Palace grounds. Just like during my coronation, they were packed with huge crowds of people -- except now, instead of praising my name, they were calling for my downfall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[943]`

### Węzeł `[461]`
Mówca: **Narrator**
> "Yells and screams erupted from the crowd. I had certainly captured their attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[464]`
  - -> `[463]`
  - -> `[899]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Porte Drazon. Hear me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow Rizians!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My dearest subjects!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Narrator**
> "A few mocking laughs reached my ears. Despite this, I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[466]`
  - -> `[468]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your anger, but it's misplaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[469]`
  - -> `[480]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything I've done has been for the betterment of this nation! Nothing else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1168]`
  - -> `[470]`
  - -> `[472]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A king without his people is no king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[487]`
  - -> `[489]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The responsibility for the mess we find ourselves in rests with the other royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[483]`

### Węzeł `[470]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought I was right, but acknowledge that mistakes may have been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[473]`
  - -> `[475]`

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a shame that the Rizian people have suffered. But I am not to blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[473]`
  - -> `[475]`

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love my country more than anything! I know you do as well. That's why you are here!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[473]`
  - -> `[475]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I've made my fair share of poor decisions. However, let's not overlook the good ones as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[476]`
  - -> `[478]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every decision I've made has been with one goal in mind -- you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[476]`
  - -> `[478]`

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am but a fellow patriot much like yourselves!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[476]`
  - -> `[478]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I beg you. Make the right choice and release me. There's so much we can accomplish together, side by side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may wear the crown, but we share the same Rizian blood -- which means we are the same! I trust you to make the right call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Break this cycle of violence and let us usher in a new era of prosperity for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fault lies with the system that created this situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[483]`

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even the most well-intentioned individuals can end up in the most precarious situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[483]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevist conspirators have contrived this scenario to weaken us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`
  - -> `[486]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rot has taken place in our governmental institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`
  - -> `[486]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've done all I could to stop this from happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`
  - -> `[486]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your help to bring us to a better future. Together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nevertheless, as your rightful king, I promise that better days will come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The future of this country is in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This Kingdom owes everything to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`
  - -> `[492]`

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I recognize your resolve, and I commend it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`
  - -> `[492]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You, the people, have spoken. And I am listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`
  - -> `[492]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I live only to serve this nation and I will abide by the rules that make it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`
  - -> `[495]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet, violence can never be the answer to our issues. It will only increase our woes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`
  - -> `[495]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you wish to claim the palace, then come forth. It's yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`
  - -> `[495]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Through unity, we will demonstrate to the world that our resilience and strength will never be broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe in this nation and I believe in you to do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of a country we would be if we could not accept change?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[496]`
Mówca: **Narrator**
> "But the crowd wasn't listening. They simply chanted "Abdicate, Abdicate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I respect your wishes and hereby announce my abdication from the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite your calls, I refuse to abdicate. For I am the only one who truly grasps your needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[499]`
Mówca: **Narrator**
> "As I uttered my defiance, I watched as rifles trained on me from within the crowd. The air filled with the ominous chant of "Death to the King!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`
  - -> `[501]`
  - -> `[500]`

### Węzeł `[500]`
**[WYBÓR GRACZA: "Duck and take cover."]** — Mówca: **Player_Romus_Italic**
> "I ducked and took cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taking my life would mean losing the only king who's willing to listen and speak to the common man, despite his noble status.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[502]`
Mówca: **Narrator**
> "My words fell on deaf ears. I understood then and there what was about to happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`
  - -> `[505]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Defend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Defend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[980]`

### Węzeł `[506]`
Mówca: **Narrator**
> "At that moment, my guards ran out onto the balcony, attempting to rush me away, but they were too late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[507]`
Mówca: **Narrator**
> "Glancing down, I couldn't believe the sight of so much blood pooling beneath me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1046]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Death_Revolution_Speech = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Death_Revolution_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[509]`
Mówca: **Narrator**
> "The crowd fell silent. Each second felt heavier than the last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Narrator**
> "A single clap resonated through the silence,  igniting a chain reaction of applause throughout the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[516]`
  - -> `[518]`
  - -> `[827]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, heed my words... I will abdicate. All I ask is that you spare both me and my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it's riches you desire, they're yours for the taking -- all the gold you could ever want. But, please, spare the Royal Family from harm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[515]`
Mówca: **Narrator**
> "Gunshots rang out, and the next thing I knew, I was lying on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[984]`

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have emerged victorious. Now it is up to you to make sure it's not in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, let's stop this violence, and, together, bring peace to Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let it be known that I have done all I could for this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Narrator**
> "More cheers came from the crowd. They were chanting "Rizia! Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[947]`

### Węzeł `[520]`
Mówca: **Narrator**
> "And then they started fading away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[521]`
Mówca: **Narrator**
> "They had gotten what they came for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_KingdomDissolves_Revolution = true; RiziaDLC.SkipToEpilogue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_KingdomDissolves_Revolution"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Kingdom Dissolves Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Speech Death Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Kingdom Dissolves Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Speech Death Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `AddConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[537]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Speech Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Helicopter Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolution Barricade Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Speech Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Helicopter Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolution Barricade Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[550]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[551]`
Mówca: **Lucita Azaro**
> ""No! Romus! Don't do it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[552]`
Mówca: **Pabel Adria**
> ""Romus, wait! Don't!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[559]`
Mówca: **Lucita Azaro**
> ""No! Romus! Let him go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Pabel Adria**
> ""No! Romus! Let him go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Narrator**
> "My consciousness slowly faded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`
  - -> `[567]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithPabel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithLucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CoupGunshot");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CoupGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CoupGunshot");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CoupGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: StopMusic();)*
- **Efekt (`userScript`):** `StopMusic();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: StopMusic();)*
- **Efekt (`userScript`):** `StopMusic();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Explosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Explosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: StopMusic();)*
- **Efekt (`userScript`):** `StopMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: StopMusic();)*
- **Efekt (`userScript`):** `StopMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MultipleGunshots");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[580]`
Mówca: **Narrator**
> "Together with a handful of military personnel, we watched live images of the unfolding chaos on the security monitors before us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[581]`
Mówca: **Narrator**
> "Behind them surged a relentless tide of protestors. Some were calling out for justice; others were demanding my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[582]`
Mówca: **Narrator**
> "She put a protective hand over her belly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[583]`
Mówca: **Narrator**
> "There, in stark black and white, I witnessed the revolutionaries breach the palace gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Narrator**
> "They were inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[585]`
Mówca: **Narrator**
> "The moment I stepped out, the guards began barricading the room from the inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[586]`
Mówca: **Narrator**
> "Before I knew it, I found myself standing beneath the portrait of my father, Valero the Frail, as if drawn to him involuntarily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[587]`
Mówca: **Narrator**
> "I hurried to the nearest window and glanced outside. From there, I could see the crowd steadily expanding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[588]`
Mówca: **Narrator**
> "Before long, we heard the sound of approaching footsteps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[589]`
Mówca: **Narrator**
> "As we passed another hall, a large mob on the far end caught my eye. Their cries of alarm resonated through the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[590]`
Mówca: **Narrator**
> "Shots were fired. We had been seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`
  - -> `[216]`

### Węzeł `[591]`
Mówca: **Narrator**
> "At one point, a restless mob surged past from a hallway, but we remained motionless and evaded detection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[592]`
Mówca: **Narrator**
> "Once they'd moved on, we resumed our slow progress. However, the murmur of voices from around a nearby corner brought us to an abrupt halt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Narrator**
> "As I strained to identify the source of the sound, the polished surface of a nearby decorative vase caught my eye. Its gleaming reflection gave me the answer I was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[594]`
Mówca: **Narrator**
> "However, considering the number of guards with us, I knew it would be a challenge to sneak past them undetected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`
  - -> `[210]`
  - -> `[216]`

### Węzeł `[595]`
Mówca: **Narrator**
> "Before long, we reached the doors leading to the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[605]`
Mówca: **Narrator**
> "The guards that were left were more than enough to make it the rest of the way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[606]`
Mówca: **Narrator**
> "Only two guards remained, which wasn't very reassuring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[607]`
Mówca: **Narrator**
> "Only one guard remained, which greatly reduced our chances of success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[608]`
Mówca: **Narrator**
> "There were no guards left. The situation was bleak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`
  - -> `[611]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As God is my witness, you will pay for what you've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[613]`
Mówca: **Narrator**
> "We had to take action now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[614]`
Mówca: **Narrator**
> "I froze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[617]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[908]`

### Węzeł `[618]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by Sevrio Castellanus and his loyal second-in-command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[904]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray to God that all three of us will make it out of here alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll rebuild everything. Together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel. I promise I'll do whatever it takes to protect you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need for a stiff upper lip. I'm scared too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray to God that we'll make it out of here alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[633]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[636]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1133]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[637]`
Mówca: **Narrator**
> "Beside us, Bruno let out a nervous whimper. Pabel patted his head reassuringly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[638]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`
  - -> `[640]`

### Węzeł `[639]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1128]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[641]`
Mówca: **Narrator**
> "Beside us, Bruno let out a nervous whimper. Lucita patted his head reassuringly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`
  - -> `[644]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1134]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[645]`
Mówca: **Narrator**
> "Beside me, Bruno let out a nervous whimper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`
  - -> `[647]`
  - -> `[648]`

### Węzeł `[646]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, boy. I'll do whatever it takes to keep you safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll protect me, won't you, Bru?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[648]`
**[WYBÓR GRACZA: "Pat him on the head."]** — Mówca: **Player_Romus_Italic**
> "I patted his head reassuringly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1172]`

### Węzeł `[652]`
Mówca: **Narrator**
> "Titus gave a nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[653]`
Mówca: **Titus Gordion**
> ""Your instructions, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`
  - -> `[54]`
  - -> `[656]`

### Węzeł `[654]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need one of the guards to stay behind in case there's an attempt to contact us over the radio.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1183]`

### Węzeł `[655]`
Mówca: **Titus Gordion**
> ""Good thinking. I'll stick with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[656]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we proceed, we need additional reinforcements. Hurry and seek out more guards to assist in our defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1177]`

### Węzeł `[657]`
Mówca: **Titus Gordion**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[658]`
Mówca: **Narrator**
> "Titus saluted me and dashed out of the room as fast as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[660]`
Mówca: **Narrator**
> "Titus appeared in the doorway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`
  - -> `[664]`

### Węzeł `[663]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[665]`
Mówca: **Titus Gordion**
> ""I've brought four additional Golden Guardsmen. You should be well protected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[666]`
Mówca: **Titus Gordion**
> ""I've brought two additional Golden Guardsmen. We'll cover you as best we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[669]`
Mówca: **Titus Gordion**
> ""We have to move fast, though. The enemy is closing in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1222]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`
  - -> `[672]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, stay with me. Everyone else, go create a distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1191]`
  - -> `[673]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, can one of your guards create a distraction?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, I need you to create a distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[679]`
Mówca: **Titus Gordion**
> ""I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[680]`
Mówca: **Narrator**
> "My bodyguard swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[681]`
Mówca: **Titus Gordion**
> ""Your Majesty... In case I don't make it, it's been an honor serving you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`
  - -> `[683]`
  - -> `[685]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop talking nonsense! Of course, you'll make it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[683]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The honor has been all mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told you to create a distraction. What the hell are you waiting for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[688]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[690]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[691]`
Mówca: **Titus Gordion**
> ""You heard His Majesty. Move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count = 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[694]`
Mówca: **Narrator**
> "Titus motioned to his remaining guardsmen. They stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1198]`

### Węzeł `[695]`
Mówca: **Narrator**
> "Titus motioned to one of his guardsmen, who stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[696]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`
  - -> `[698]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[698]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[699]`
Mówca: **Narrator**
> "He turned to Lucita, but couldn't quite look her in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[700]`
Mówca: **Titus Gordion**
> ""Keep him safe, milady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[701]`
Mówca: **Lucita Azaro**
> ""I will, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[702]`
Mówca: **Narrator**
> "With a final salute, Titus stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`
  - -> `[705]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1199]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count = 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`
  - -> `[709]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[710]`
Mówca: **Narrator**
> "Bruno was still trotting along beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[717]`
Mówca: **Narrator**
> "However, Titus was the only one left to guard us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1203]`
  - -> `[254]`

### Węzeł `[718]`
Mówca: **Narrator**
> "But Titus -- poor Titus -- hadn't made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[726]`
Mówca: **Narrator**
> "Titus was the only one guarding me. I hoped he would be enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[727]`
Mówca: **Narrator**
> "It seemed like Titus hadn't made it. The situation was becoming increasingly bleak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[729]`
Mówca: **Narrator**
> "Titus handed me a gun. I stared at it, remembering how badly things had gone in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`
  - -> `[732]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1129]`

### Węzeł `[733]`
Mówca: **Narrator**
> "One of my guards thrust a gun into my hands. I stared at it, remembering how badly things had gone in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[736]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[737]`
Mówca: **Narrator**
> "From behind me, I heard Lucita fire her own weapon. The shot struck the man planting the bomb in the back of the head, and he collapsed to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`
  - -> `[740]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1225]`

### Węzeł `[741]`
Mówca: **Narrator**
> "I looked at the ground and saw Titus lying flat on his back, seemingly dead. One of his eyes quickly closed, then opened again -- a wink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`
  - -> `[744]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[745]`
Mówca: **Narrator**
> "I tried to stop him, but it was too late. Pabel screamed in agony as the attacker plunged the knife into his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`
  - -> `[748]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1233]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1229]`

### Węzeł `[749]`
Mówca: **Narrator**
> "A guard and I tried to stop him, but we were too late. Pabel screamed in agony as the assailant sunk his knife into his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`
  - -> `[752]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`
  - -> `[755]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[756]`
Mówca: **Narrator**
> "Bruno leaped at the assailant, snarling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[757]`
Mówca: **Narrator**
> "Blinded by rage, I immediately shot the assailant dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`
  - -> `[760]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`
  - -> `[763]`

### Węzeł `[762]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[763]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1238]`

### Węzeł `[764]`
Mówca: **Narrator**
> "He staggered backward, and without a moment's hesitation, Titus shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[765]`
Mówca: **Narrator**
> "He staggered backward, and without a moment's hesitation, Sevrio shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`
  - -> `[768]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[768]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1242]`

### Węzeł `[769]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`
  - -> `[771]`

### Węzeł `[770]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[772]`
Mówca: **Narrator**
> "Without a moment's hesitation, Titus shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[773]`
Mówca: **Narrator**
> "Without a moment's hesitation, my guard shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[774]`
Mówca: **Narrator**
> "With lightning speed, Lucita managed to draw her own knife from its holster and slit the assailant's throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true || RiziaDLCIsolated.Revolution_Guards_Count > 0 || RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`
  - -> `[777]`

### Węzeł `[776]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true || RiziaDLCIsolated.Revolution_Guards_Count > 0 || RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0  or  Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[777]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true || RiziaDLCIsolated.Revolution_Guards_Count > 0 || RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0  or  Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[778]`
Mówca: **Narrator**
> "I had won. There was nothing between me and the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[779]`
Mówca: **Narrator**
> "But the clamor of the revolutionary mob was growing louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[780]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`
  - -> `[782]`

### Węzeł `[781]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[782]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[783]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`
  - -> `[785]`

### Węzeł `[784]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[785]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1246]`

### Węzeł `[786]`
Mówca: **Narrator**
> "Titus looked at me with solemn eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`

### Węzeł `[787]`
Mówca: **Titus Gordion**
> ""You should make a run for it, Your Majesty. I'll make sure you're covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`
  - -> `[789]`
  - -> `[790]`

### Węzeł `[788]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for everything, Captain Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[789]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw that, Titus. You're coming, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[790]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`

### Węzeł `[791]`
Mówca: **Titus Gordion**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1084]`

### Węzeł `[792]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[793]`
Mówca: **Titus Gordion**
> ""Good luck out there, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1084]`

### Węzeł `[794]`
Mówca: **Titus Gordion**
> ""It's been an honor, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1084]`

### Węzeł `[795]`
**[WYBÓR GRACZA: "Board the helicopter."]** — Mówca: **Player_Romus_Italic**
> "I boarded the helicopter as the pilot started the engine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`
  - -> `[798]`

### Węzeł `[797]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[798]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[799]`
Mówca: **Narrator**
> "Just in time, Bruno hopped in and lay down at our feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`
  - -> `[802]`

### Węzeł `[801]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[802]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[803]`
Mówca: **Narrator**
> "Just in time, Bruno hopped in and lay down at my feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[804]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`
  - -> `[806]`

### Węzeł `[805]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[806]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Count > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`
  - -> `[809]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1246]`

### Węzeł `[810]`
Mówca: **Narrator**
> "Titus looked at me with solemn eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[811]`
Mówca: **Titus Gordion**
> ""You two should make a run for it, Your Majesty. I'll make sure you're covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`
  - -> `[813]`
  - -> `[814]`

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for everything, Captain Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[813]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw that, Titus. You're coming, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[814]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[815]`
Mówca: **Titus Gordion**
> ""Good luck out there, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1038]`

### Węzeł `[816]`
Mówca: **Titus Gordion**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1038]`

### Węzeł `[817]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[818]`
Mówca: **Titus Gordion**
> ""It's been an honor, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1038]`

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`
  - -> `[821]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1259]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`
  - -> `[824]`

### Węzeł `[823]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revolution_Guards_Count > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[824]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revolution_Guards_Count > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[825]`
Mówca: **Narrator**
> "The revolutionaries were streaming into the gardens as Titus shot at them again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[826]`
Mówca: **Narrator**
> "And Palas Rezna -- my home -- was on fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1060]`

### Węzeł `[827]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]`
  - -> `[829]`

### Węzeł `[828]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[829]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[830]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have fun running the country. I warn you, it's not as easy as it looks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[831]`
Mówca: **Narrator**
> "As I stepped out, a pair of ornate double doors at the far end of the hall caught my eye..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[832]`
Mówca: **Narrator**
> "The exit leading to the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[833]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`
  - -> `[835]`

### Węzeł `[834]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`

### Węzeł `[835]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1139]`

### Węzeł `[836]`
Mówca: **Narrator**
> "I turned to see Titus awaiting my command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[837]`
Mówca: **Titus Gordion**
> ""How can we support you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`
  - -> `[838]`

### Węzeł `[838]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come with me. I can't go out there without backup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`

### Węzeł `[839]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and defend this room with your lives. Is that clear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[840]`
Mówca: **Titus Gordion**
> ""As you command, Your Majesty. May God be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[841]`
Mówca: **Titus Gordion**
> ""We're with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]`

### Węzeł `[842]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Defend = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[844]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "My guards and I left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[845]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "We left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1150]`

### Węzeł `[846]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`
  - -> `[848]`

### Węzeł `[847]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]`

### Węzeł `[848]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[849]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`
  - -> `[851]`

### Węzeł `[850]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[851]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1153]`

### Węzeł `[852]`
Mówca: **Narrator**
> "Weapons drawn, my guards led the way, escorting me to a nearby stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[853]`
Mówca: **Narrator**
> "With his weapon drawn, Titus led the way, escorting me to a nearby stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[854]`
Mówca: **Narrator**
> "Five flights later, we emerged into the upper-level corridor, still untouched by the armed assailants. The balcony was in the audience chamber at the far end of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[937]`

### Węzeł `[855]`
Mówca: **Narrator**
> "Once my men confirmed the coast was clear, we hurried along. As we made our way down the hall, portraits of former rulers lining the walls caught my eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[856]`
Mówca: **Narrator**
> "My escort formed a protective circle around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[857]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`
  - -> `[859]`

### Węzeł `[858]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]`

### Węzeł `[859]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[860]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[861]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[862]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[863]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`
  - -> `[865]`

### Węzeł `[864]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[866]`
Mówca: **Titus Gordion**
> ""Your Majesty, your strength surpasses that of any title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]`

### Węzeł `[867]`
Mówca: **Titus Gordion**
> ""You possess the strength and wisdom to lead us forward with honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`
  - -> `[877]`
  - -> `[873]`

### Węzeł `[868]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`
  - -> `[870]`

### Węzeł `[869]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[870]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[871]`
Mówca: **Titus Gordion**
> ""Sire, your reign has been marked by resilience and courage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]`

### Węzeł `[872]`
Mówca: **Titus Gordion**
> ""'Frail' is but a word, not a reflection of your indomitable spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`
  - -> `[874]`
  - -> `[877]`
  - -> `[873]`

### Węzeł `[873]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please focus on the task at hand, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]`

### Węzeł `[874]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is neither the time nor the place for flattery!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]`

### Węzeł `[875]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for supporting your king in his darkest hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]`

### Węzeł `[876]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God grant me the strength to live up to your belief in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]`

### Węzeł `[877]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`
  - -> `[879]`

### Węzeł `[878]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[879]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[880]`
Mówca: **Narrator**
> "A loud commotion drew everyone's attention to the unrest outside the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[881]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`
  - -> `[883]`

### Węzeł `[882]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]`

### Węzeł `[883]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]`

### Węzeł `[884]`
Mówca: **Titus Gordion**
> ""We should get moving, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]`

### Węzeł `[885]`
Mówca: **Narrator**
> "I gave a curt nod, signaling Titus to proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]`

### Węzeł `[886]`
Mówca: **Narrator**
> "Not wanting to wait any longer, I signaled for my guards to keep moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]`

### Węzeł `[887]`
Mówca: **Narrator**
> "Titus ordered his men to take defensive positions in the hall while he and I entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[888]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]`
  - -> `[890]`

### Węzeł `[889]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]`

### Węzeł `[890]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1157]`

### Węzeł `[891]`
Mówca: **Narrator**
> "It wasn't long before we reached the doors to the audience chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]`

### Węzeł `[892]`
Mówca: **Narrator**
> "Sevrio instructed his guards to take up defensive positions in the hall while I went inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[893]`
Mówca: **Titus Gordion**
> ""Your Majesty, there's nothing to be ashamed of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]`

### Węzeł `[894]`
Mówca: **Titus Gordion**
> ""You are the rightful king, and we stand with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`
  - -> `[877]`
  - -> `[873]`

### Węzeł `[895]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[896]`
  - -> `[897]`

### Węzeł `[896]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]`

### Węzeł `[897]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1160]`

### Węzeł `[898]`
Mówca: **Titus Gordion**
> ""Divus zaitu!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1086]`

### Węzeł `[899]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shut up and listen to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[900]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`
  - -> `[902]`

### Węzeł `[901]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]`

### Węzeł `[902]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1139]`

### Węzeł `[903]`
Mówca: **Narrator**
> "Titus gave a nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[904]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`
  - -> `[906]`

### Węzeł `[905]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1121]`

### Węzeł `[906]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]`

### Węzeł `[907]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by Titus and his second-in-command in the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[908]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]`
  - -> `[910]`

### Węzeł `[909]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1122]`

### Węzeł `[910]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[911]`

### Węzeł `[911]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by the new captain of the Golden Guard and his loyal second-in-command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[912]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything happens, protect yourself and {RiziaDLCText.KingsSon}. Don't worry about me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[913]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry we didn't get more time together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[914]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]`
  - -> `[916]`

### Węzeł `[915]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1147]`

### Węzeł `[916]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[928]`

### Węzeł `[917]`
Mówca: **Narrator**
> "Bruno tilted his head and looked at me quizzically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[918]`
  - -> `[919]`
  - -> `[920]`

### Węzeł `[918]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come along, boy. The public will have more sympathy for a cute animal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[931]`

### Węzeł `[919]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too dangerous for you out there. Stay until I get back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1149]`

### Węzeł `[920]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[921]`
  - -> `[922]`

### Węzeł `[921]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[923]`

### Węzeł `[922]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[924]`

### Węzeł `[923]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and protect Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1149]`

### Węzeł `[924]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[925]`
  - -> `[926]`

### Węzeł `[925]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[927]`

### Węzeł `[926]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[927]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and protect Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1149]`

### Węzeł `[928]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[929]`
  - -> `[930]`

### Węzeł `[929]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`

### Węzeł `[930]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[931]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[932]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]`
  - -> `[934]`

### Węzeł `[933]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[935]`

### Węzeł `[934]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]`

### Węzeł `[935]`
Mówca: **Narrator**
> "Bruno, with his keen sense for danger, appeared relaxed as he sniffed a nearby statue -- his behavior reassuring me that we weren't under any immediate threat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]`

### Węzeł `[936]`
Mówca: **Narrator**
> "Confident the coast was clear, I hurried down the hall. As I did, I glanced at the portraits of former rulers lining the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[937]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[938]`
  - -> `[939]`

### Węzeł `[938]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[940]`

### Węzeł `[939]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`

### Węzeł `[940]`
Mówca: **Narrator**
> "Bruno, with his keen sense for danger, appeared relaxed as he sniffed a nearby statue -- his behavior reassuring us that we weren't under any immediate threat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[941]`

### Węzeł `[941]`
Mówca: **Narrator**
> "Once my men confirmed the coast was clear, we hurried along. As I did, I glanced at the portraits of former rulers lining the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[942]`
Mówca: **Narrator**
> "Bruno followed me out onto the balcony and remained by my side. His steadfast presence reassured me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[943]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[944]`
  - -> `[945]`

### Węzeł `[944]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[942]`

### Węzeł `[945]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[946]`
Mówca: **Narrator**
> "Bruno licked my hand, as if to comfort me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[951]`

### Węzeł `[947]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[948]`
  - -> `[949]`

### Węzeł `[948]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]`

### Węzeł `[949]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[951]`

### Węzeł `[950]`
Mówca: **Narrator**
> ""Divus zaitu" was a Wruhecist term meaning "May God be with you"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[951]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[952]`
  - -> `[953]`

### Węzeł `[952]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[956]`

### Węzeł `[953]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[954]`
Mówca: **Titus Gordion**
> ""Your Majesty, did I hear correctly? Are you truly abdicating the throne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[957]`

### Węzeł `[955]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[956]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]`

### Węzeł `[957]`
Mówca: **Narrator**
> "I turned to see Titus standing in the doorway, his eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[977]`
  - -> `[960]`
  - -> `[959]`
  - -> `[958]`

### Węzeł `[958]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Titus. I'm afraid I don't have any other option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[961]`

### Węzeł `[959]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, yes. For the first time in my life, I'm out of a job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[978]`

### Węzeł `[960]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your ears serve you well, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[979]`

### Węzeł `[961]`
Mówca: **Titus Gordion**
> ""But, sir, the kingdom needs your guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]`
  - -> `[963]`
  - -> `[962]`

### Węzeł `[962]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia will endure, Titus, with or without a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]`

### Węzeł `[963]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the best course for our people, as much as it pains me to admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]`

### Węzeł `[964]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The country will just have to go on without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]`

### Węzeł `[965]`
Mówca: **Titus Gordion**
> ""It goes without saying, Your Majesty, that serving you has been the greatest honor of my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[966]`

### Węzeł `[966]`
Mówca: **Titus Gordion**
> ""I only wish I could have done more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[969]`
  - -> `[970]`
  - -> `[968]`
  - -> `[967]`

### Węzeł `[967]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've done more than enough, Titus. Now, it's time for a new chapter, for both of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[975]`

### Węzeł `[968]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Farewell, my friend. May our paths cross again under better circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[973]`

### Węzeł `[969]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The failure is mine, not yours. Until we meet again, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[976]`

### Węzeł `[970]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`

### Węzeł `[971]`
Mówca: **Narrator**
> "Titus bowed respectfully and took his leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[972]`

### Węzeł `[972]`
Mówca: **Narrator**
> "I looked back to see the crowd, whose celebrations showed no signs of stopping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[973]`
Mówca: **Titus Gordion**
> ""May the future be kinder to us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]`

### Węzeł `[974]`
Mówca: **Narrator**
> "A flicker of disappointment briefly crossed Titus's face. However, he remained composed, bowing respectfully before taking his leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[972]`

### Węzeł `[975]`
Mówca: **Titus Gordion**
> ""I trust that the future holds brighter days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]`

### Węzeł `[976]`
Mówca: **Titus Gordion**
> ""Hopefully sooner than later. Farewell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]`

### Węzeł `[977]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spare me your pity and get out of my sight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]`

### Węzeł `[978]`
Mówca: **Titus Gordion**
> ""But, sir, our kingdom depends on your leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]`
  - -> `[963]`
  - -> `[962]`

### Węzeł `[979]`
Mówca: **Titus Gordion**
> ""But, sir, Rizia's future hinges on your guidance!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]`
  - -> `[963]`
  - -> `[962]`

### Węzeł `[980]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]`
  - -> `[982]`

### Węzeł `[981]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[988]`

### Węzeł `[982]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[983]`
Mówca: **Narrator**
> "At that moment, Titus ran out onto the balcony, attempting to rush me away, but he was too late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[984]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[985]`
  - -> `[986]`

### Węzeł `[985]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[987]`

### Węzeł `[986]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1090]`

### Węzeł `[987]`
Mówca: **Narrator**
> "Titus stood over me, his voice a distant murmur that I couldn't comprehend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1090]`

### Węzeł `[988]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[983]`

### Węzeł `[989]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[990]`
  - -> `[991]`

### Węzeł `[990]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[992]`

### Węzeł `[991]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1264]`

### Węzeł `[992]`
Mówca: **Narrator**
> "Titus nodded in confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[993]`

### Węzeł `[993]`
Mówca: **Titus Gordion**
> ""Your orders, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`

### Węzeł `[994]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[995]`
  - -> `[996]`

### Węzeł `[995]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[997]`

### Węzeł `[996]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1269]`

### Węzeł `[997]`
Mówca: **Narrator**
> "With a salute, Titus rushed out of the room. In the meantime, we needed to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1003]`

### Węzeł `[998]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]`
  - -> `[1000]`

### Węzeł `[999]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1001]`

### Węzeł `[1000]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1273]`

### Węzeł `[1001]`
Mówca: **Narrator**
> "Titus saluted, prompting the other guards to scan the room for anything they could use to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1002]`

### Węzeł `[1002]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Defend = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[1003]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Titus_Reinforcements = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[1004]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1005]`
  - -> `[1006]`

### Węzeł `[1005]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1009]`

### Węzeł `[1006]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Titus_Reinforcements == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[1007]`
Mówca: **Narrator**
> "It was Titus and his men bringing along four other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1008]`

### Węzeł `[1008]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]`

### Węzeł `[1009]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1010]`
  - -> `[1011]`

### Węzeł `[1010]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1007]`

### Węzeł `[1011]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1012]`

### Węzeł `[1012]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1013]`
  - -> `[1014]`

### Węzeł `[1013]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Default == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1019]`

### Węzeł `[1014]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1016]`

### Węzeł `[1015]`
Mówca: **Narrator**
> "Everyone came inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1066]`

### Węzeł `[1016]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1017]`
  - -> `[1018]`

### Węzeł `[1017]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1023]`

### Węzeł `[1018]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1022]`

### Węzeł `[1019]`
Mówca: **Narrator**
> "It was Titus and his men bringing along two other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1020]`

### Węzeł `[1020]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]`

### Węzeł `[1021]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 7;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]`

### Węzeł `[1022]`
Mówca: **Narrator**
> "Titus and his men had returned. They couldn't find anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]`

### Węzeł `[1023]`
Mówca: **Narrator**
> "It was Titus and Sevrio bringing along seven other Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1021]`

### Węzeł `[1024]`
Mówca: **Narrator**
> "However, it wasn't long before an influx of footsteps, more than before, could be heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1093]`

### Węzeł `[1025]`
Mówca: **Narrator**
> "As the smoke cleared, and my hearing slowly returned, I saw that two nearby guards lay dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1026]`

### Węzeł `[1026]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1027]`
  - -> `[1028]`

### Węzeł `[1027]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1029]`

### Węzeł `[1028]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1282]`

### Węzeł `[1029]`
Mówca: **Narrator**
> "Nearby, Titus was down, unconscious but still breathing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1042]`

### Węzeł `[1030]`
Mówca: **Narrator**
> "When the smoke cleared, I saw I had taken down two of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[1031]`
Mówca: **Narrator**
> "I'd been shot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[1032]`
Mówca: **Narrator**
> "Before I could react, a mob of masked militants wielding automatic rifles stormed the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[1033]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1034]`
  - -> `[1035]`

### Węzeł `[1034]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1036]`

### Węzeł `[1035]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[1036]`
Mówca: **Narrator**
> "But all of my guards were dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[1037]`
Mówca: **Narrator**
> "I shot at our assailants until I realized I wasn't firing at all. My magazine was empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1224]`

### Węzeł `[1038]`
Mówca: **Narrator**
> "Titus saluted, then readied his weapon and assumed a defensive stance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1039]`

### Węzeł `[1039]`
Mówca: **Narrator**
> "It hit me then that I had no idea when or if I'd ever see him again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1255]`

### Węzeł `[1040]`
Mówca: **Narrator**
> "I turned my gaze to Lucita and her injury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[1041]`
Mówca: **Narrator**
> "I turned my gaze to Pabel and his injury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[1042]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1043]`
  - -> `[1044]`

### Węzeł `[1043]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1045]`

### Węzeł `[1044]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[1045]`
Mówca: **Narrator**
> "Bruno was nowhere in sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[1046]`
Mówca: **Narrator**
> "Memories suddenly flooded my mind -- memories of Vina, my mother..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1047]`

### Węzeł `[1047]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1048]`
  - -> `[1049]`

### Węzeł `[1048]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1050]`

### Węzeł `[1049]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1051]`

### Węzeł `[1050]`
Mówca: **Narrator**
> "Lucita..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1051]`

### Węzeł `[1051]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1052]`
  - -> `[1053]`

### Węzeł `[1052]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1054]`

### Węzeł `[1053]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1055]`

### Węzeł `[1054]`
Mówca: **Narrator**
> "Pabel..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1055]`

### Węzeł `[1055]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1056]`
  - -> `[1057]`

### Węzeł `[1056]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1058]`

### Węzeł `[1057]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1061]`

### Węzeł `[1058]`
Mówca: **Narrator**
> "And Lena, my first love..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1061]`

### Węzeł `[1059]`
Mówca: **Narrator**
> "It was as if all the important moments of my life were captured in a single flash."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[1060]`
Mówca: **Narrator**
> "The life I once knew was gone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[1061]`
Mówca: **Narrator**
> "Not to mention all of my triumphs and failures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1059]`

### Węzeł `[1062]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1063]`
  - -> `[1064]`

### Węzeł `[1063]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1065]`

### Węzeł `[1064]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[1065]`
Mówca: **Narrator**
> "Bruno's ears flattened, and he started to growl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[1066]`
Mówca: **Titus Gordion**
> ""Sir, the militants are closing in. We have to get ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[1067]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1068]`
  - -> `[1069]`

### Węzeł `[1068]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1070]`

### Węzeł `[1069]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1277]`

### Węzeł `[1070]`
Mówca: **Titus Gordion**
> ""Your Majesty! Look out!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1071]`

### Węzeł `[1071]`
Mówca: **Narrator**
> "Titus propelled himself between me and the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[1072]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1073]`
  - -> `[1074]`

### Węzeł `[1073]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1075]`

### Węzeł `[1074]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1277]`

### Węzeł `[1075]`
Mówca: **Titus Gordion**
> ""Your Majesty! Get down!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1076]`

### Węzeł `[1076]`
Mówca: **Narrator**
> "Titus propelled himself between me and the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[1077]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1078]`
  - -> `[1079]`

### Węzeł `[1078]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1080]`

### Węzeł `[1079]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[1080]`
Mówca: **Titus Gordion**
> ""Whatever happens, Your Majesty, I just wanted you to know that it's been an honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1083]`
  - -> `[1082]`
  - -> `[1081]`

### Węzeł `[1081]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Much appreciated, but we haven't lost this fight yet!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[1082]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Save the sentiment, Titus. We're not dead yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[1083]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Titus, the honor is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[1084]`
Mówca: **Narrator**
> "Titus saluted then readied his weapon, assuming a defensive stance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1085]`

### Węzeł `[1085]`
Mówca: **Narrator**
> "It dawned on me that I had no idea when or if I'd ever see him again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[1086]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Religion_DivusZaitu == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1087]`
  - -> `[1088]`

### Węzeł `[1087]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Religion_DivusZaitu == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]`

### Węzeł `[1088]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Religion_DivusZaitu == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[1089]`
Mówca: **Narrator**
> "I felt a cold, wet nose against my cheek. Bruno was nudging me, trying to keep me awake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[1090]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1091]`
  - -> `[1092]`

### Węzeł `[1091]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1089]`

### Węzeł `[1092]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[1093]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Reinforcements == true || RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1094]`
  - -> `[1095]`

### Węzeł `[1094]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Reinforcements == true || RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true  or  Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1096]`

### Węzeł `[1095]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_Guards_Reinforcements == true || RiziaDLCIsolated.Revolution_Titus_Reinforcements == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true  or  Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[1096]`
Mówca: **Narrator**
> "They were rapidly approaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1101]`

### Węzeł `[1097]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1098]`
  - -> `[1099]`

### Węzeł `[1098]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1100]`

### Węzeł `[1099]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[1100]`
Mówca: **Narrator**
> "Bruno sniffed at the door and wagged his tail eagerly. Whoever it was, they weren't hostile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[1101]`
Mówca: **Narrator**
> "Before long, the footsteps stopped right outside the barricade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1102]`

### Węzeł `[1102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1103]`
  - -> `[1104]`

### Węzeł `[1103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1105]`

### Węzeł `[1104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1106]`
  - -> `[1107]`

### Węzeł `[1105]`
Mówca: **Narrator**
> "Bruno's ears flattened, and he started to growl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1106]`
  - -> `[1107]`

### Węzeł `[1106]`
**[WYBÓR GRACZA: "Listen closely."]** — Mówca: **Player_Romus_Italic**
> "I listened closely to understand what was going on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1108]`

### Węzeł `[1107]`
**[WYBÓR GRACZA: "Don't move."]** — Mówca: **Player_Romus_Italic**
> "I remained still, waiting to see what would happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1109]`

### Węzeł `[1108]`
Mówca: **Narrator**
> "That's when I heard a loud piercing beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1110]`

### Węzeł `[1109]`
Mówca: **Narrator**
> "That's when I heard a loud beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1110]`

### Węzeł `[1110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1111]`
  - -> `[1112]`

### Węzeł `[1111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1116]`

### Węzeł `[1112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1113]`

### Węzeł `[1113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1114]`
  - -> `[1115]`

### Węzeł `[1114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1117]`

### Węzeł `[1115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1119]`
  - -> `[1118]`
  - -> `[1120]`

### Węzeł `[1116]`
Mówca: **Lucita Azaro**
> ""An E4-X7 from DuMont Powder Company. I thought they stopped making those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1119]`
  - -> `[1118]`
  - -> `[1120]`

### Węzeł `[1117]`
Mówca: **Pabel Adria**
> ""That can't be good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1119]`
  - -> `[1118]`
  - -> `[1120]`

### Węzeł `[1118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""GET DOWN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[1119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""IT'S THEM!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[1120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""RUN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[1121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `AddConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[1122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `AddConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[1123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_FinalDecision_StayAndFight == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1124]`
  - -> `[1125]`

### Węzeł `[1124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_FinalDecision_StayAndFight == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1126]`

### Węzeł `[1125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_FinalDecision_StayAndFight == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1127]`

### Węzeł `[1126]`
Mówca: **Narrator**
> "She'd stayed by my side even as the revolutionaries closed in on Porte Drazon, helping me plan for the fight that still lay ahead of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[1127]`
Mówca: **Narrator**
> "She'd stayed by my side even as the revolutionaries closed in on Porte Drazon, watching me drink glass after glass of wine and reminisce about the days when kings still held power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[1128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[1129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1130]`
  - -> `[1131]`

### Węzeł `[1130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1132]`

### Węzeł `[1131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[1132]`
Mówca: **Narrator**
> "Sevrio handed me a gun. I stared at it, remembering how badly things had gone in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[1133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[1134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[1135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_FinalDecision_StayAndFight == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1136]`
  - -> `[1137]`

### Węzeł `[1136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_FinalDecision_StayAndFight == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1138]`

### Węzeł `[1137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_FinalDecision_StayAndFight == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[1138]`
Mówca: **Narrator**
> "He'd stayed by my side even as the revolutionaries closed in on Porte Drazon, helping me plan for the fight that still lay ahead of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[1139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1140]`
  - -> `[1141]`

### Węzeł `[1140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1142]`

### Węzeł `[1141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[1142]`
Mówca: **Narrator**
> "I turned to see Sevrio, his expectant gaze awaiting my command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1144]`
  - -> `[1143]`

### Węzeł `[1143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come with me. I can't go out there without backup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1146]`

### Węzeł `[1144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and the Guardians will stay here and defend this room with your lives. Is that clear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1145]`

### Węzeł `[1145]`
Mówca: **Sevrio Castellanus**
> ""As you command, sir. May God be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[1146]`
Mówca: **Sevrio Castellanus**
> ""We are with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[1147]`
Mówca: **Bruno**
> ""Hrr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]`

### Węzeł `[1148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[1149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Bruno");)*
- **Efekt (`userScript`):** `RemoveConversant("Bruno");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[928]`

### Węzeł `[1150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1151]`
  - -> `[1152]`

### Węzeł `[1151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[1152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1148]`

### Węzeł `[1153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1154]`
  - -> `[1155]`

### Węzeł `[1154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1156]`

### Węzeł `[1155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[1156]`
Mówca: **Narrator**
> "With his weapon drawn, Sevrio led the way, escorting me to a nearby stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[1157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1158]`
  - -> `[1159]`

### Węzeł `[1158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[892]`

### Węzeł `[1159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[1160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1161]`
  - -> `[1162]`

### Węzeł `[1161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Revolution_Guards_Follow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1163]`

### Węzeł `[1162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Revolution_Guards_Follow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[1163]`
Mówca: **Sevrio Castellanus**
> ""Divus zaitu, Your Majesty. May the Lord be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[1164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1165]`
  - -> `[1166]`

### Węzeł `[1165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[1166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[1167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here goes nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`

### Węzeł `[1168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1169]`
  - -> `[1170]`

### Węzeł `[1169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1171]`

### Węzeł `[1170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[1171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fought for the reforms you wanted. If there's anyone you should be angry at, it's the nobles who refused to let them pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[473]`
  - -> `[475]`

### Węzeł `[1172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1173]`
  - -> `[1174]`

### Węzeł `[1173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1175]`

### Węzeł `[1174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[1175]`
Mówca: **Narrator**
> "Sevrio gave a nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1176]`

### Węzeł `[1176]`
Mówca: **Sevrio Castellanus**
> ""Your instructions, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`
  - -> `[54]`
  - -> `[656]`

### Węzeł `[1177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1178]`
  - -> `[1179]`

### Węzeł `[1178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1180]`

### Węzeł `[1179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[1180]`
Mówca: **Sevrio Castellanus**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1181]`

### Węzeł `[1181]`
Mówca: **Narrator**
> "Sevrio saluted me and dashed out of the room as fast as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1182]`

### Węzeł `[1182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[1183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Titus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1184]`
  - -> `[1185]`

### Węzeł `[1184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Titus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1186]`

### Węzeł `[1185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Titus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[1186]`
Mówca: **Sevrio Castellanus**
> ""Good thinking. I'll stick with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[1187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1188]`
  - -> `[1189]`

### Węzeł `[1188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1190]`

### Węzeł `[1189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1211]`

### Węzeł `[1190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `AddConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[1191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1192]`
  - -> `[1193]`

### Węzeł `[1192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1194]`

### Węzeł `[1193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[1194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sevrio, can you create a distraction?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1195]`

### Węzeł `[1195]`
Mówca: **Sevrio Castellanus**
> ""It would be my honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1196]`

### Węzeł `[1196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1197]`

### Węzeł `[1197]`
Mówca: **Narrator**
> "With a deep breath, Sevrio stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1198]`

### Węzeł `[1198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sevrio Castellanus"); RiziaDLCIsolated.Ending_Revolution_SevrioDead = true;)*
- **Efekt (`userScript`):** `RemoveConversant("Sevrio Castellanus");
Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[1199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1200]`
  - -> `[1201]`

### Węzeł `[1200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1202]`

### Węzeł `[1201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[1202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_Revolution_SevrioDead = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[1203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1204]`
  - -> `[1205]`

### Węzeł `[1204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1210]`

### Węzeł `[1205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_Revolution_SevrioDead == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[1206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1207]`
  - -> `[1208]`

### Węzeł `[1207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1209]`

### Węzeł `[1208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_Revolution_SevrioDead == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[1209]`
Mówca: **Narrator**
> "But it seemed like poor Sevrio hadn't made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[1210]`
Mówca: **Narrator**
> "And it seemed like poor Sevrio hadn't made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[1211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1212]`
  - -> `[1213]`

### Węzeł `[1212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1214]`

### Węzeł `[1213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[1214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1215]`
  - -> `[1216]`

### Węzeł `[1215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1217]`

### Węzeł `[1216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1218]`

### Węzeł `[1217]`
Mówca: **Narrator**
> "It was the guard I'd sent out, accompanied by four additional Golden Guardsmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1219]`

### Węzeł `[1218]`
Mówca: **Narrator**
> "It was the guard I'd sent out, accompanied by two additional Golden Guardsmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1220]`

### Węzeł `[1219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1221]`

### Węzeł `[1220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Revolution_Guards_Count += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1221]`

### Węzeł `[1221]`
Mówca: **Narrator**
> "They informed me that the enemy was quickly closing in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1223]`

### Węzeł `[1222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`
  - -> `[54]`

### Węzeł `[1223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[1224]`
Mówca: **Narrator**
> "My guards remained under cover, attempting to return fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[1225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1226]`
  - -> `[1227]`

### Węzeł `[1226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1228]`

### Węzeł `[1227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[1228]`
Mówca: **Narrator**
> "But then, much to my relief, I noticed Sevrio on the ground, playing dead. He gave me a slight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[1229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1230]`
  - -> `[1231]`

### Węzeł `[1230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1232]`

### Węzeł `[1231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[1232]`
Mówca: **Narrator**
> "Sevrio and I tried to stop him, but we were too late. Pabel screamed in agony as the assailant sunk his knife into his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1237]`

### Węzeł `[1233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1234]`
  - -> `[1235]`

### Węzeł `[1234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[1235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1236]`

### Węzeł `[1236]`
Mówca: **Narrator**
> "Sevrio and I tried to stop him, but we were too late. My wife screamed in agony as the assailant sunk his knife into her chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[1237]`
Mówca: **Narrator**
> "Sevrio immediately shot the attacker dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[1238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1239]`
  - -> `[1240]`

### Węzeł `[1239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[1240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1241]`

### Węzeł `[1241]`
Mówca: **Narrator**
> "He staggered backward, and without a moment's hesitation, my guard shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[1242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1243]`
  - -> `[1244]`

### Węzeł `[1243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1245]`

### Węzeł `[1244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[1245]`
Mówca: **Narrator**
> "Without a moment's hesitation, Sevrio shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[1246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1247]`
  - -> `[1248]`

### Węzeł `[1247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1249]`

### Węzeł `[1248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[1249]`
Mówca: **Narrator**
> "Sevrio looked at me with solemn eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1250]`

### Węzeł `[1250]`
Mówca: **Sevrio Castellanus**
> ""The Lord put me on this planet for one reason, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1251]`

### Węzeł `[1251]`
Mówca: **Sevrio Castellanus**
> ""So that I could survive until today, until this very moment, to defend my King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1252]`
  - -> `[1256]`
  - -> `[1257]`

### Węzeł `[1252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1253]`

### Węzeł `[1253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1254]`

### Węzeł `[1254]`
Mówca: **Narrator**
> "Sevrio readied his weapon and assumed a defensive stance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1039]`

### Węzeł `[1255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[1256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The eternal bliss of Golconda will be your reward, my good soldier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1254]`

### Węzeł `[1257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. You're coming with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1258]`

### Węzeł `[1258]`
Mówca: **Sevrio Castellanus**
> ""Do not try to dissuade me from serving my highest purpose. Go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1254]`

### Węzeł `[1259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1260]`
  - -> `[1261]`

### Węzeł `[1260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[1261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[1262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1263]`

### Węzeł `[1263]`
Mówca: **Narrator**
> "He didn't have the strength to respond. I ripped off another piece of my shirt to stop the bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[1264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1265]`
  - -> `[1266]`

### Węzeł `[1265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1267]`

### Węzeł `[1266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[1267]`
Mówca: **Narrator**
> "Sevrio nodded in confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1268]`

### Węzeł `[1268]`
Mówca: **Sevrio Castellanus**
> ""Your orders, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`

### Węzeł `[1269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1270]`
  - -> `[1271]`

### Węzeł `[1270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1272]`

### Węzeł `[1271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[1272]`
Mówca: **Narrator**
> "With a salute, Sevrio rushed out of the room. In the meantime, we needed to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[1273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1274]`
  - -> `[1275]`

### Węzeł `[1274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1276]`

### Węzeł `[1275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[1276]`
Mówca: **Narrator**
> "Sevrio saluted me, prompting the others to scan the room for anything they could use to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[1277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1278]`
  - -> `[1279]`

### Węzeł `[1278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1280]`

### Węzeł `[1279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[1280]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty! Look out!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1281]`

### Węzeł `[1281]`
Mówca: **Narrator**
> "Sevrio propelled himself between me and the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[1282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1283]`
  - -> `[1284]`

### Węzeł `[1283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1285]`

### Węzeł `[1284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1042]`

### Węzeł `[1285]`
Mówca: **Narrator**
> "Nearby, Sevrio was down, unconscious but still breathing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1042]`

### Węzeł `[1286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Ending their reign with...", "Porte Drazon", "Kingdom of Rizia");)*
- **Efekt (`userScript`):** `SetRichPresence("Ending their reign with...","Porte Drazon","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
