# Sordland/Turn07/A_ConvinceIsabel

- **ID konwersacji:** `107`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/107_A_ConvinceIsabel.md`
- **Liczba węzłów dialogowych:** 419
- **Liczba wyborów gracza:** 81

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[39]** Waiter
- **[50]** Kesaro Kibener
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reform_Heron_SentKesaro`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Turn05_SnO_Investigate_OldGuard`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad`
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`
- `BaseGameIsolated.Turn07_A_Ordered_Early`
- `BaseGameIsolated.Turn07_A_Ordered_LespianZabla`
- `BaseGameIsolated.Turn07_A_Ordered_Liver`
- `BaseGameIsolated.Turn07_A_Ordered_Salad`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_HeronDecision`
- `BaseGame.Enable_HeronMeeting`
- `BaseGame.Enable_OfferBribeToHeron`
- `BaseGame.Lucian_FailsHeron`
- `BaseGame.Lucian_PersuadesHeron`
- `BaseGame.Reform_Reform_Heron_SentKesaro`
- `BaseGame.Reform_Reform_Isabel_Convinced`
- `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad`
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`
- `BaseGameIsolated.Turn07_A_Ordered_Early`
- `BaseGameIsolated.Turn07_A_Ordered_LespianZabla`
- `BaseGameIsolated.Turn07_A_Ordered_Liver`
- `BaseGameIsolated.Turn07_A_Ordered_Salad`
- `BaseGameSupport.Journal_Turn07_Isabel_Convinced`
- `BaseGameSupport.Journal_Turn07_Isabel_Failed`
- `GameCondition.Turn07_A_ConvinceHeron`
- `GameCondition.Turn07_A_ConvinceIsabel`
- `GameCondition.Turn07_Decision_HeronMeeting`

### Skoki między-konwersacyjne:
- Węzeł `[8]` -> **[114] Sordland/Turn07/NiaDialogue01_Opposition** (../Turn_07/114_NiaDialogue01_Opposition.md), Węzeł `[1]`
- Węzeł `[9]` -> **[108] Sordland/Turn07/NiaDialogue01_Ally** (../Turn_07/108_NiaDialogue01_Ally.md), Węzeł `[1]`
- Węzeł `[148]` -> **[113] Sordland/Turn07/IsabelIntro** (../Turn_07/113_IsabelIntro.md), Węzeł `[1]`
- Węzeł `[188]` -> **[110] Sordland/Turn07/WhatAreYourIntentions** (../Turn_07/110_WhatAreYourIntentions.md), Węzeł `[1]`
- Węzeł `[275]` -> **[109] Sordland/Turn07/NiaDialogue02_Personal** (../Turn_07/109_NiaDialogue02_Personal.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 34

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[53]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[57]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- Węzeł `[58]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;`
- Węzeł `[59]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- Węzeł `[83]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[84]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[126]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- Węzeł `[127]` (Nia Morgna): `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- *...oraz 26 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Nia Morgna)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We settled on a table on the second floor of Le Papillion, a world class Lespian restaurant in downtown Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The whole floor was reserved for us, and the music coming from downstairs was enough to guard our voices from potential eavesdroppers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Nia Morgna had arranged a dinner meeting with Justice Isabel Edmonds. Ahead of the dinner, Nia and I met to have a talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Nia Morgna**
> ""...I still can't believe Soll came to the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `114` (*Sordland/Turn07/NiaDialogue01_Opposition*), Węzeł `[1]`

### Węzeł `[9]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `108` (*Sordland/Turn07/NiaDialogue01_Ally*), Węzeł `[1]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The waiter approached us and bowed in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Waiter**
> ""Did you decide on the entrée, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""We have a guest coming. We'll wait for her to order.""]** — Mówca: **Player**
> ""We have a guest coming. We'll wait for her to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Not yet.""]** — Mówca: **Player**
> ""Not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""What's on today's menu?""]** — Mówca: **Player**
> ""What's on today's menu?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""We are in a meeting here. Can you leave us alone?""]** — Mówca: **Player**
> ""We are in a meeting here. Can you leave us alone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Waiter**
> ""Of course, sir. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[17]`
Mówca: **Waiter**
> ""And madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""We'll order later, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[19]`
Mówca: **Waiter**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[20]`
Mówca: **Waiter**
> ""For the entrée, we have the options of sauté-Perlase with Lespian-style Zabla, Falenco-style liver fricassée, or Salade Luco made with fresh vegetables and herbs from southern Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I'll have sauté-Perlase with Lespian Zabla.""]** — Mówca: **Player**
> ""I'll have sauté-Perlase with Lespian Zabla.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I'll have the liver fricassée.""]** — Mówca: **Player**
> ""I'll have the liver fricassée.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""I'll have Salade Luco.""]** — Mówca: **Player**
> ""I'll have Salade Luco.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I won't order now.""]** — Mówca: **Player**
> ""I won't order now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Waiter**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Waiter**
> ""Perfect. And you, madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[27]`
Mówca: **Nia Morgna**
> ""No thank you. I'd rather wait for our guest to arrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Waiter**
> ""I'll be around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Waiter**
> ""Of course, madame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Waiter**
> ""I'll leave you to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "He went downstairs again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[32]`
Mówca: **Waiter**
> ""Of course. I'll be around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[33]`
Mówca: **Nia Morgna**
> ""Let's try not to agitate her when she comes. We won the vote, so she already has pressure on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Not to mention the pressure from the anti-corruption police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Nia Morgna**
> ""But if she feels cornered, we might lose her. So it's important not to put too much pressure on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Agreed. We shouldn't scare her off.""]** — Mówca: **Player**
> ""Agreed. We shouldn't scare her off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I disagree. We must keep up the pressure.""]** — Mówca: **Player**
> ""I disagree. We must keep up the pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Let's not overthink this.""]** — Mówca: **Player**
> ""Let's not overthink this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Nia Morgna**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[43]`
Mówca: **Nia Morgna**
> ""I am not sure about that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""Just please don't forget that we cannot succeed without her help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[45]`
Mówca: **Nia Morgna**
> ""That's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[46]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: NiaHubEnd)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[47]`
Mówca: **Narrator**
> "At that moment, the waiter came back with my order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[48]`
Mówca: **Nia Morgna**
> ""Oh, Good to see you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Suddenly, I noticed Justice Isabel Edmonds coming upstairs. She was wearing a plain dark gray dress that hid most of her features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Nia got up from her chair to shake Isabel's hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "Stand up for a handshake."]** — Mówca: **Player_Italic**
> "I stood up and shook her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "Welcome her from your seat."]** — Mówca: **Player_Italic**
> "I welcomed her without standing up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[53]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[54]`
Mówca: **Isabel Edmonds**
> ""Mr. President. Good to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[107]`

### Węzeł `[55]`
Mówca: **Narrator**
> "She bowed her head slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Isabel Edmonds**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[107]`

### Węzeł `[57]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[58]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Liver = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[60]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGameIsolated.Turn07_A_Ordered_Liver == true || BaseGameIsolated.Turn07_A_Ordered_LespianZabla == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGameIsolated.Turn07_A_Ordered_Liver == true || BaseGameIsolated.Turn07_A_Ordered_LespianZabla == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[62]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGameIsolated.Turn07_A_Ordered_Liver == true || BaseGameIsolated.Turn07_A_Ordered_LespianZabla == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[63]`
Mówca: **Waiter**
> ""May I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Narrator**
> "He placed the plate of Salade Luco on the table. It looked very fresh and smelled of olive oil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[67]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Ordered_Salad == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Liver == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Liver == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Ordered_Liver == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Narrator**
> "He placed the plate of Falenco style liver fricassée on the table. It looked and smelled like heaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Narrator**
> "He placed the plate of sauté-Perlase and next to it, the Lespian style Zabla, which was served in a small clay bowl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He went ahead and refilled our glasses with water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "Welcome her from your seat."]** — Mówca: **Player_Italic**
> "I welcomed her without standing up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[76]`
Mówca: **Nia Morgna**
> ""Oh, Good to see you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Suddenly, I noticed Justice Isabel Edmonds coming upstairs. She was wearing a plain dark gray dress that hid most of her features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Nia got up from her chair to shake Isabel's hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[75]`

### Węzeł `[79]`
Mówca: **Narrator**
> "She bowed her head slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "Stand up for a handshake."]** — Mówca: **Player_Italic**
> "I stood up and shook her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Isabel Edmonds**
> ""Mr. President. Good to see you. I hope you're enjoying your meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[90]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[82]`
Mówca: **Isabel Edmonds**
> ""Mr. President. I hope you're enjoying your meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[90]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[83]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[84]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[85]`
Mówca: **Waiter**
> ""Would you like to order Madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Narrator**
> "The waiter held a chair for Isabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[87]`
Mówca: **Nia Morgna**
> ""Is there something wrong, Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[88]`
Mówca: **Isabel Edmonds**
> ""No, thank you. I won't be here long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Narrator**
> "She took a long look at the table and my plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Good to see you, Justice Edmonds.""]** — Mówca: **Player**
> ""Good to see you, Justice Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Please, join me.""]** — Mówca: **Player**
> ""Please, join me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Please, take a seat.""]** — Mówca: **Player**
> ""Please, take a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[93]`
Mówca: **Isabel Edmonds**
> ""Oh no, there's nothing wrong. I just don't want to eat up too much of your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Isabel Edmonds**
> ""I also didn't want to intrude your meal, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`
  - -> `[95]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Wouldn't you want to join me?""]** — Mówca: **Player**
> ""Wouldn't you want to join me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""It's okay, Mrs. Edmonds. I thought we were here to meet over a meal.""]** — Mówca: **Player**
> ""It's okay, Mrs. Edmonds. I thought we were here to meet over a meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Please, don't worry about it.""]** — Mówca: **Player**
> ""Please, don't worry about it. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Isabel Edmonds**
> ""Yes...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Narrator**
> "She stared at me for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Isabel Edmonds**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Isabel Edmonds**
> ""Thanks for the offer. I'm good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""What was on the menu?""]** — Mówca: **Player**
> ""What was on the menu?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[103]`
Mówca: **Nia Morgna**
> ""Come on, Mrs. Edmonds. Let's order something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Narrator**
> "The waiter looked uncomfortable while waiting for the orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[105]`
Mówca: **Nia Morgna**
> ""I'll have the sauté-Perlase, please. And for Mrs. Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Isabel Edmonds**
> ""...I'll have the salad, then. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Please, take a seat.""]** — Mówca: **Player**
> ""Please, take a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Good to see you, Justice Edmonds.""]** — Mówca: **Player**
> ""Good to see you, Justice Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Welcome, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Welcome, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "She took a seat across the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Isabel Edmonds**
> ""I would normally say good, but this time I will take the liberty to say that it was insanely exhausting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""How was your day, Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Isabel Edmonds**
> ""Heavy court matters again... Not that I'm complaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Suddenly, the waiter approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Waiter**
> ""Are you ready to give the orders, sir? Madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[116]`
Mówca: **Nia Morgna**
> ""I'll have the sauté-Perlase, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I'll have the same.""]** — Mówca: **Player**
> ""I'll have the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Mrs. Edmonds?""]** — Mówca: **Player**
> ""Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Isabel Edmonds**
> ""I'll have the salad. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[120]`
Mówca: **Waiter**
> ""Perfect, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[121]`
Mówca: **Waiter**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[122]`
Mówca: **Waiter**
> ""Of course. And you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`
  - -> `[123]`
  - -> `[291]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I'll have the salad too.""]** — Mówca: **Player**
> ""I'll have the salad too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""I'll get the same as Mrs. Morgna.""]** — Mówca: **Player**
> ""I'll get the same as Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Waiter**
> ""Perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[126]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[127]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[128]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Waiter**
> ""I'll be back shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[130]`
Mówca: **Waiter**
> ""For the entrée, we have the options of sauté-Perlase with Lespian-style Zabla, Falenco-style liver fricassée, or Salade Luco made with fresh vegetables and herbs from southern Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[131]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Liver = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I'll have sauté-Perlase with Lespian Zabla.""]** — Mówca: **Player**
> ""I'll have sauté-Perlase with Lespian Zabla.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""I'll have the liver fricassée.""]** — Mówca: **Player**
> ""I'll have the liver fricassée.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""I'll have Salade Luco.""]** — Mówca: **Player**
> ""I'll have Salade Luco.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[136]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[137]`
Mówca: **Waiter**
> ""Perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "He quickly took a couple of notes in his tiny notebook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[139]`
Mówca: **Narrator**
> "He went back downstairs, leaving us alone on the upper floor again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`
  - -> `[142]`
  - -> `[143]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""Mrs. Edmonds. You know why we're here.""]** — Mówca: **Player**
> ""Mrs. Edmonds. You know why we're here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""How is the situation in the Supreme Court?""]** — Mówca: **Player**
> ""How is the situation in the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""We want to cooperate with you, Mrs. Edmonds.""]** — Mówca: **Player**
> ""We want to cooperate with you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Let's get to the point, shall we?""]** — Mówca: **Player**
> ""Let's get to the point, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Isabel Edmonds**
> ""As you wish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Isabel Edmonds**
> ""Yes, Mr. President. I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Isabel Edmonds**
> ""That's very welcome, Mr. President. I want the same thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Isabel Edmonds**
> ""Let's just say... busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "She moved herself on the chair to be more comfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `113` (*Sordland/Turn07/IsabelIntro*), Węzeł `[1]`

### Węzeł `[149]`
Mówca: **Narrator**
> "At that moment, the waiter came back from downstairs, carrying plates of food. After seeing that we were in the midst of a discussion, he averted his eyes as he approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Early = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Early"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[151]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Early == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Early == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Early"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[153]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Ordered_Early == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Early"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Narrator**
> "He quickly served Nia and Isabel's food and refilled all of our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Isabel Edmonds**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[156]`
Mówca: **Narrator**
> "He quickly started serving the food and refilled our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Liver == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Liver == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Ordered_Liver == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[160]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Ordered_Salad == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Ordered_Salad == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
Mówca: **Narrator**
> "He placed the plate of Falenco-style liver fricassée in front of me. It looked and smelled like heaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Narrator**
> "He placed the plate of Salade Luco in front of me. It looked very fresh and smelled of olive oil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Narrator**
> "He placed the plate of sauté-Perlase and next to it, the Lespian style Zabla, which was served in a small clay bowl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Narrator**
> "I was very hungry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[168]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[169]`
Mówca: **Nia Morgna**
> ""Thank you. It looks delicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
Mówca: **Isabel Edmonds**
> ""I'll have the salad. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[171]`
Mówca: **Isabel Edmonds**
> ""I'll have the same. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""I am, thank you.""]** — Mówca: **Player**
> ""I am, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[173]`
Mówca: **Narrator**
> "The waiter bowed to us and quickly went downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[174]`
Mówca: **Narrator**
> "We wished each other a good meal as Isabel and Nia slowly started to eat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Nia Morgna**
> ""So, Mrs. Edmonds... Are you still thinking the same about the Old Guard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Isabel Edmonds**
> ""Of course. Nothing has changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Nia Morgna**
> ""That's good. We still have that in common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Isabel Edmonds**
> ""That doesn't mean I will accept any proposal the Old Guards oppose...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Isabel Edmonds**
> ""...nor it means I will put the whole Court under the bus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[180]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[182]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Isabel Edmonds**
> ""The impeachment clause about the Justices affects all of us, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Nia Morgna**
> ""Yet we must do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Nia Morgna**
> ""You also know that we need this change in our institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
Mówca: **Nia Morgna**
> ""I understand your concerns. I also do not agree with that clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Nia Morgna**
> ""But we must start somewhere. I am supporting the President because he made this proposal with good intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Isabel took a sip from her water and turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `110` (*Sordland/Turn07/WhatAreYourIntentions*), Węzeł `[1]`

### Węzeł `[189]`
Mówca: **Nia Morgna**
> ""You have decided then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Isabel Edmonds**
> ""Let's see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[192]`
  - -> `[191]`

### Węzeł `[191]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I waited for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Please, Isabel. This vote means a lot to us.""]** — Mówca: **Player**
> ""Please, Isabel. This vote means a lot to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Mrs. Edmonds, I really hope you vote for the proposal.""]** — Mówca: **Player**
> ""Mrs. Edmonds, I really hope you vote for the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Isabel Edmonds**
> ""Okay. Let me finish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[197]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[198]`
Mówca: **Isabel Edmonds**
> ""I think I can get behind this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[206]`
  - -> `[205]`

### Węzeł `[199]`
Mówca: **Isabel Edmonds**
> ""I regret to say I do not see eye to eye with you, Mr. President. I don't think I can support this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[201]`
  - -> `[200]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""Please reconsider, Mrs. Edmonds. This proposal is very important.""]** — Mówca: **Player**
> ""Please reconsider, Mrs. Edmonds. This proposal is very important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[201]`
**[WYBÓR GRACZA: ""That's very sad to hear. Is there no way to change your mind?""]** — Mówca: **Player**
> ""That's very sad to hear. Is there no way to change your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Look, I will be clear. Whatever you think about it, you will vote yes!""]** — Mówca: **Player**
> ""Look, I will be clear. Whatever you think about it, you will vote yes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Isabel Edmonds**
> ""Mr. President... Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""That's great to hear.""]** — Mówca: **Player**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""You think?""]** — Mówca: **Player**
> ""You think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Thank you, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Thank you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[207]`
Mówca: **Isabel Edmonds**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[208]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Isabel Edmonds**
> ""I can get you the three votes you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[212]`
Mówca: **Isabel Edmonds**
> ""I think I can get you the votes you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[213]`
Mówca: **Isabel Edmonds**
> ""I don't think so, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[214]`
Mówca: **Isabel Edmonds**
> ""I don't think my conclusion will differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[215]`
Mówca: **Nia Morgna**
> ""Justice Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Isabel Edmonds**
> ""In fact, I think it's time that I leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Isabel Edmonds**
> ""I see that we're all finished with our meals too. I think it's time to conclude this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Isabel Edmonds**
> ""Thank you for inviting me here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[234]`

### Węzeł `[219]`
Mówca: **Isabel Edmonds**
> ""I'll do my best to convince my group. But I can only speak for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`
  - -> `[225]`

### Węzeł `[220]`
Mówca: **Isabel Edmonds**
> ""We were already somewhat inclined to vote for the proposal. I will talk with my group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[223]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Are you sure that you can bring three votes?""]** — Mówca: **Player**
> ""Are you sure that you can bring three votes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Good.""]** — Mówca: **Player**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[224]`
Mówca: **Isabel Edmonds**
> ""Yes. We always act together. They will listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[225]`
**[WYBÓR GRACZA: ""That's not good enough.""]** — Mówca: **Player**
> ""That's not good enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""So you are not sure if you can bring three votes?""]** — Mówca: **Player**
> ""So you are not sure if you can bring three votes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Isabel Edmonds**
> ""I told you that I will speak with them. What else would you want me to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[229]`
Mówca: **Narrator**
> "Isabel took her coat and walked downstairs. Nia and I looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[230]`
Mówca: **Nia Morgna**
> ""Nothing but your support, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Isabel_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[232]`
Mówca: **Nia Morgna**
> ""That's great to hear that you will support us. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[233]`
Mówca: **Isabel Edmonds**
> ""And that I will give.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[234]`
**[WYBÓR GRACZA: ""Don't disrespect me like this, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Don't disrespect me like this, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
**[WYBÓR GRACZA: ""You can't leave before we agree on this.""]** — Mówca: **Player**
> ""You can't leave before we agree on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Narrator**
> "She stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Narrator**
> "She stood up and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[239]`
Mówca: **Isabel Edmonds**
> ""I don't know what you mean. I have already told you my position. And I have another place to be, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Isabel Edmonds**
> ""If you'll excuse me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[241]`
Mówca: **Nia Morgna**
> ""Thank you for the meeting, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Isabel Edmonds**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[243]`
Mówca: **Isabel Edmonds**
> ""I see that we're all finished with our meals too. I think it's time to conclude this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Isabel Edmonds**
> ""Thank you for inviting me here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Let's change the Constitution, Mrs. Edmonds!""]** — Mówca: **Player**
> ""Let's change the Constitution, Mrs. Edmonds!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""I'll be expecting your vote in the upcoming session.""]** — Mówca: **Player**
> ""I'll be expecting your vote in the upcoming session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Narrator**
> "She stood up and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[249]`
Mówca: **Nia Morgna**
> ""Thank you for the meeting, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Isabel Edmonds**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[251]`
Mówca: **Nia Morgna**
> ""That's not good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[252]`

### Węzeł `[252]`
**[WYBÓR GRACZA: ""What do we do now?""]** — Mówca: **Player**
> ""What do we do now?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[253]`
**[WYBÓR GRACZA: ""It's not...""]** — Mówca: **Player**
> ""It's not...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
**[WYBÓR GRACZA: ""Oh really? Tell me about it!""]** — Mówca: **Player**
> ""Oh really? Tell me about it!"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Nia Morgna**
> ""You should maybe talk to Lucian about other options. We may need to reach out to Heron, but I don't think he'll be of any help without Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Narrator**
> "She did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Narrator**
> "After a few minutes of thoughtful silence, we also got up from our seats and left the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[258]`
Mówca: **Narrator**
> "Isabel took her coat and walked downstairs. Nia and I looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Nia Morgna**
> ""That's good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[262]`
  - -> `[261]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Yes. I hope we can trust her.""]** — Mówca: **Player**
> ""Yes. I hope we can trust her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""We still need to reach out to more people. She won't be enough.""]** — Mówca: **Player**
> ""We still need to reach out to more people. She won't be enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""That's great news!""]** — Mówca: **Player**
> ""That's great news!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Nia Morgna**
> ""You should maybe talk to Lucian about other options. We may try reaching out to Heron if you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Narrator**
> "After a few minutes of thoughtful silence, we also got up from our seats and left the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[265]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[268]`
Mówca: **Nia Morgna**
> ""No, thank you. I'll be leaving soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[269]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[272]`
Mówca: **Nia Morgna**
> ""No thank you. I'll be leaving soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[273]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `109` (*Sordland/Turn07/NiaDialogue02_Personal*), Węzeł `[1]`

### Węzeł `[276]`
Mówca: **Nia Morgna**
> ""Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Nia Morgna**
> ""I know it's too late, but you are making a mistake. You've sent our opportunity to change the constitution for the better right into the trash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Nia Morgna**
> ""And I can't believe that you also...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[279]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[118]`

### Węzeł `[281]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[282]`
Mówca: **Nia Morgna**
> ""Oh I know that feeling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[283]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[285]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[286]`
Mówca: **Narrator**
> "She shook our hands and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[287]`
Mówca: **Nia Morgna**
> ""Have a nice evening, Mr. President. Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[288]`
Mówca: **Narrator**
> "She shook our hands and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[289]`
Mówca: **Nia Morgna**
> ""Have a nice evening, Mr. President. Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[290]`
Mówca: **Nia Morgna**
> ""I won't be ordering. I was just leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[291]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[293]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[294]`
Mówca: **Isabel Edmonds**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[295]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[297]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[298]`
Mówca: **Nia Morgna**
> ""But now that you are here, I will take my leave. I have business to take care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[299]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[302]`
Mówca: **Narrator**
> "He quickly served Isabel's food and refilled our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Isabel Edmonds**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[305]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[308]`
Mówca: **Narrator**
> "We wished each other a good meal as Isabel started to eat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Narrator**
> "The food here was insanely delicious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[310]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[192]`
  - -> `[191]`

### Węzeł `[312]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[313]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[315]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[316]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[318]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[319]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Isabel took her coat and walked downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[323]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[325]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[326]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[328]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[329]`
Mówca: **Narrator**
> "It was not a good start. It looked like I had no choice but to work with the Old Guards if I wanted to pass this Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[330]`
Mówca: **Narrator**
> "It was a good start. But I was still uncertain if Isabel would be enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Narrator**
> "It was time to think about the other options if I wanted to pass this Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_ConvinceIsabel = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceIsabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[333]`
Mówca: **Narrator**
> "I got in the presidential Kadilla and Serge started driving me home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[334]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[336]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[337]`
Mówca: **Narrator**
> "On the way, I received a call on the brand new radio phone that was mounted in our vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[338]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentKesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentKesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[340]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_SentKesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[341]`
Mówca: **Narrator**
> "On the way, I received a call from on the brand new radio phone that was mounted in our vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Narrator**
> "It was Kesaro Kibener. His voice was very difficult to understand through the static."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Narrator**
> "It was Lucian. His voice was very difficult to understand through the static."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Kesaro Kibener**
> ""Mr. President. I hope your meeting went well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
> ""Mr. President. I hope your meeting went well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[346]`
Mówca: **Kesaro Kibener**
> ""I have some good news for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Kesaro Kibener**
> ""Mr. Garaci had agreed to meet with you. As long as the meeting is not documented and kept hidden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Kesaro Kibener**
> ""I will try to arrange something. Would you be able to meet with him outside of the capital? He said it would be safer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`
  - -> `[365]`

### Węzeł `[349]`
Mówca: **Lucian Galade**
> ""I have urgent news to share. Heron has agreed to meet before the Court Vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Lucian Galade**
> ""He wants to arrange a meeting outside of the capital. Somewhere more hidden and out of the public eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`
  - -> `[353]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""Arrange a meeting with him immediately.""]** — Mówca: **Player**
> ""Arrange a meeting with him immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[352]`
**[WYBÓR GRACZA: ""That's good news. I'll leave the arrangement up to you.""]** — Mówca: **Player**
> ""That's good news. I'll leave the arrangement up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""That I cannot do, Lucian.""]** — Mówca: **Player**
> ""That I cannot do, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Lucian Galade**
> ""Sir, are you sure? He'd be very helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[357]`
  - -> `[360]`

### Węzeł `[355]`
Mówca: **Lucian Galade**
> ""Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[356]`
Mówca: **Lucian Galade**
> ""Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""Okay, I'll leave it to your judgement.""]** — Mówca: **Player**
> ""Okay, I'll leave it to your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Yes. I'm sure.""]** — Mówca: **Player**
> ""Yes. I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[359]`
Mówca: **Lucian Galade**
> ""Understood, sir. Then I'll try to arrange a meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Don't make me repeat myself, Lucian.""]** — Mówca: **Player**
> ""Don't make me repeat myself, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[361]`
Mówca: **Lucian Galade**
> ""Good evening. Leaving the call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[363]`
**[WYBÓR GRACZA: ""Arrange a meeting with him immediately.""]** — Mówca: **Player**
> ""Arrange a meeting with him immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[364]`
**[WYBÓR GRACZA: ""That's good news. I'll leave the arrangement up to you.""]** — Mówca: **Player**
> ""That's good news. I'll leave the arrangement up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
**[WYBÓR GRACZA: ""That I cannot do, Kesaro.""]** — Mówca: **Player**
> ""That I cannot do, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Kesaro Kibener**
> ""What do you mean? I thought you wanted me to convince him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[369]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Kesaro Kibener**
> ""Understood. Leave that up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[368]`
**[WYBÓR GRACZA: ""You're right. Okay, I'll leave the arrangement to your judgement, Kesaro.""]** — Mówca: **Player**
> ""You're right. Okay, I'll leave the arrangement to your judgement, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[369]`
**[WYBÓR GRACZA: ""Yes, I did. But the meeting has to be on my terms. Is he not willing to meet in Holsord?""]** — Mówca: **Player**
> ""Yes, I did. But the meeting has to be on my terms. Is he not willing to meet in Holsord?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
**[WYBÓR GRACZA: ""He's either going to come to my office or we won't have a meeting.""]** — Mówca: **Player**
> ""He's either going to come to my office or we won't have a meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Kesaro Kibener**
> ""I'm afraid that won't do for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
**[WYBÓR GRACZA: ""Fine. We'll have it his way.""]** — Mówca: **Player**
> ""Fine. We'll have it his way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[373]`
**[WYBÓR GRACZA: ""Then force him. I thought you were supposed to convince him.""]** — Mówca: **Player**
> ""Then force him. I thought you were supposed to convince him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[374]`
Mówca: **Kesaro Kibener**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[375]`
Mówca: **Kesaro Kibener**
> ""I'll let you return to your duties now. Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[376]`
Mówca: **Kesaro Kibener**
> ""Okay. I'll arrange it soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[377]`
Mówca: **Kesaro Kibener**
> ""I already did. You are asking for too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[378]`
Mówca: **Kesaro Kibener**
> ""Anyway, I'll leave you to your duties. Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[379]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_Investigate_OldGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_Investigate_OldGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_Investigate_OldGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Lucian_PersuadesHeron = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lucian_PersuadesHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Lucian_FailsHeron = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Lucian_FailsHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[387]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Enable_OfferBribeToHeron = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_OfferBribeToHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[388]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_Decision_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_ConvinceHeron = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[390]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_Decision_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_ConvinceHeron = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[392]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentKesaro = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[393]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_Decision_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[394]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Isabel_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Isabel_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[395]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Isabel_Failed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Isabel_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[396]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_IsabelOrdered_Salad = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_IsabelOrdered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[397]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_IsabelOrdered_Salad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[399]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_IsabelOrdered_Salad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[400]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_Decision_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[401]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_Decision_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[402]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Enable_HeronDecision = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_HeronDecision"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[403]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Enable_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[404]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Enable_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[405]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Enable_HeronMeeting = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[406]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[408]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[409]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[412]`
Mówca: **Isabel Edmonds**
> ""I'll do my best to get the three votes but I can only speak for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Isabel Edmonds**
> ""Your changes to Article 6 and 7 will make it really difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`
  - -> `[414]`

### Węzeł `[414]`
**[WYBÓR GRACZA: ""That's not good enough.""]** — Mówca: **Player**
> ""That's not good enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[415]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[416]`
**[WYBÓR GRACZA: ""So you are not sure if you can bring three votes?""]** — Mówca: **Player**
> ""So you are not sure if you can bring three votes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Isabel Edmonds**
> ""Maybe you should have thought about this before you altered your proposal at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[418]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
