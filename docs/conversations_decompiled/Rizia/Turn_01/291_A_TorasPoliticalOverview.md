# Rizia/Turn 1/A_TorasPoliticalOverview

- **ID konwersacji:** `291`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/291_A_TorasPoliticalOverview.md`
- **Liczba węzłów dialogowych:** 437
- **Liczba wyborów gracza:** 96

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.Prologue_Focus_SecurityCouncil`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration`
- `RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency`
- `RiziaDLC.Hugo_LargerYourQuarry`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Panel_RoyalDecrees`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn01_PromisedToSignTransition`
- `RiziaDLC.Turn01_WineWithHugo`
- `RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest`
- `RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs`
- `RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspected`
- `RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion`
- `RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid`

### Skoki między-konwersacyjne:
- Węzeł `[107]` -> **[292] Rizia/Turn 1/Houses Briefing Section** (../Turn_01/292_Houses_Briefing_Section.md), Węzeł `[1]`
- Węzeł `[123]` -> **[292] Rizia/Turn 1/Houses Briefing Section** (../Turn_01/292_Houses_Briefing_Section.md), Węzeł `[32]`
- Węzeł `[408]` -> **[293] Rizia/Turn 1/Intention Questions** (../Turn_01/293_Intention_Questions.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 30

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration`
- `RiziaDLC.Panel_RoyalDecrees`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[62]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[126]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- Węzeł `[127]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[128]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[167]` (Paskal Beniwoll): `Variable["RiziaDLC.Trait_SoberKing"] = true;`
- Węzeł `[171]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- Węzeł `[201]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- Węzeł `[223]` (Paskal Beniwoll): `Variable["RiziaDLC.Trait_SoberKing"] = true;`
- *...oraz 22 innych węzłów ze skryptami.*

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
  - -> `[436]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The stairway to the Royal Council chambers was longer than I remembered. I took a moment to catch my breath in front of the carved oak doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Vina Toras**
> ""Hurry up, Father! It's not very kingly of you to be late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`
  - -> `[355]`
  - -> `[29]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A true king is never late. It's the others who are early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better stop with that when we're inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just give me a second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "After collecting my thoughts, I pushed open the door and walked in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Everything was just as it had been in my youth. The high domed ceiling, with its skylight that shone into the center of the room. The oval mahogany table. The tall-backed red velvet chair where my father used to sit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I'd only been here once or twice. I gazed up at the high domed ceiling, with its skylight that shone down into the center of the room. Below it, a tall-backed red velvet chair towered over an oval mahogany table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[17]`
Mówca: **Narrator**
> "When Hugo saw me, he sprang to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""Romus, my boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[22]`
  - -> `[21]`
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to stand on ceremony with me, Hugo. Please sit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "Embrace him."]** — Mówca: **Player_Romus_Italic**
> "I embraced my uncle. He hugged me back warmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where is everyone else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good morning, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Hugo sat down with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""Although it seems it won't be as private as I was expecting. Are you staying, Princess Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Other kings don't have bullet wounds in their legs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How have you been?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is your son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is your wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""Rico is still raising hell. But governing Iza has instilled a real sense of responsibility in him. You'd be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Busy. Managing the royal transition is a full-time job in itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""Rico's still the hellraiser we both know and love. But governing Iza has instilled a real sense of responsibility in him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""Rita's as much of a thorn in my side as ever. She was begging me to retire after Valero's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[42]`
Mówca: **Narrator**
> "As I listened to him, my eyes drifted towards the back wall. It was covered in portraits of Rizia's previous kings, including a newly painted likeness of my father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""My dear brother. I do miss him, but I daresay it's time we had some fresh blood on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Welcome, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[22]`
  - -> `[21]`
  - -> `[20]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Hugo recognized the formality of my greeting and bowed slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""As Valero never got a chance to fill you in on his royal duties before he passed, I prepared an overview for you. Would you like to hear it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[58]`
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""As it's been quite some time since you last sat in these chambers, I've prepared an overview for you. Would you like to hear it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[58]`
  - -> `[54]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I already know everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""You always were a bright one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""As the king, you're both Rizia's head of state and commander of its armed forces, as well as the de jure governor of Rizia Imperii, Valenqiris, the Pales Administrative District and the island of Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm already up to speed. But I'm sure Vina would appreciate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""However, you should not neglect the House of Delegates, the legislative assembly my brother set up to appease the opposition after the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[64]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a cowardly move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. His theater of puppets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Hugo pursed his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""His Majesty Valero presided over the last elections in 1949. The Rizian National Coalition secured a House majority, as always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""I and the rest of the Royal Council will advise you to the best of our ability, and put forth decrees and state decisions for your approval. Ultimately, the King has the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaDLC.Coronation_Speech_Diplomacy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaDLC.Coronation_Speech_Diplomacy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true  or  Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_AntiMonarchy == true || RiziaDLC.Coronation_Speech_Diplomacy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true  or  Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""Thanks to that coronation speech you made, I'd say you're already off on the wrong foot with the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[86]`
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""Thankfully, your coronation speech got you off on the right foot with the RNC. Even if the speech itself was highly unconventional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[86]`
  - -> `[79]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_GaveSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""No good can come of ignoring the will of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[86]`
  - -> `[79]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if they disagree with me -- so what? I'll have them fired. Or better, beheaded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for letting me know. I'll be sure to listen to them going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""I'm here to serve, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""The opposition is small but worth keeping an eye on. Especially the new leader, Manus Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that was one of his better ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""I thought so as well. It gave Rizia the appearance of a constitutional democracy while keeping power firmly in the hands of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Shrewd, in fact. It gave Rizia the appearance of a constitutional democracy while keeping power firmly in the hands of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do the Delegates really represent the will of the people? Or just that of the nobility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Hugo made a tutting sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Hugo scanned my face closely as he spoke the name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[89]`
  - -> `[92]`
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The traitor's son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know all about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The opposition elected a Sazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have got to be joking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""I wish that I were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""Not just any Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[95]`
Mówca: **Hugo Toras**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""As you know, Duke Lucas Sazon was executed for his role in your kidnapping and the 1926 uprising, while his wife Angelica was sent into exile on Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""Upon finishing his studies in Kyrute, Manus returned to the mainland and proceeded to win the largest supporter base of any opposition leader we've seen thus far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[98]`
Mówca: **Hugo Toras**
> ""Then you know he could be a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Common man? He's descended from nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I'm not that concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to meet this fellow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right to be wary of him. We've got to keep him in our sights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""Yes, that's what makes him particularly dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""Neither was your father in the '20s, if you'll recall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""You'll get your chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""We will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Hugo closed the folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `292` (*Rizia/Turn 1/Houses Briefing Section*), Węzeł `[1]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Narrator**
> "He gestured towards my leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[112]`
Mówca: **Narrator**
> "He gestured towards my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Scar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Scar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Scar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Narrator**
> "He opened a folder and took out a picture of a clean-cut young man. Vina leaned forward to peer at it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[120]`
Mówca: **Narrator**
> "He opened a folder and took out a picture of a clean-cut young man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""As Grand Vizier, it's traditional for me to attend their sessions and pass any relevant information on to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[292]`
  - -> `[293]`
  - -> `[353]`

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Keep in mind that Rizia is also a player on the international stage, Your Majesty. We do not have to kowtow to dissenting opinions, but we must tolerate them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Houses Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `292` (*Rizia/Turn 1/Houses Briefing Section*), Węzeł `[32]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""His promises to give a voice to the common man seem to be resonating with the populace. Part of it, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`
  - -> `[102]`

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""Good thinking. This will apply to her too... One day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""While she remains under strict orders not to leave the island, no such restrictions were placed on the son she gave birth to shortly after her arrival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[130]`
Mówca: **Narrator**
> "To my slight surprise, the room was empty except for one man. My uncle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""I thought a private chat with your Grand Vizier would be in order before delving into council politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""You'll meet everyone else soon enough. But I thought a private chat with your Grand Vizier would be in order first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[133]`
Mówca: **Narrator**
> "His eyes traveled to the doorway, where Vina was still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[134]`
Mówca: **Vina Toras**
> ""Yes, Uncle Hugo. I'm sitting in on the King's council meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[138]`
  - -> `[142]`

### Węzeł `[135]`
Mówca: **Narrator**
> "My daughter gave a shy nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was against the idea, for the record. But she insisted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's going to learn by experience, just like I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's going to learn by experience. I wish I had done the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's unorthodox, I know. But future queens should have the same privileges as future kings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Hugo frowned as he processed this new information, then broke into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""By all means, then, Your Highness, have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "Vina walked over to the table as I made my way to the red velvet chair. Once we were all seated, I turned to my uncle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[146]`
Mówca: **Narrator**
> "He gestured to the red velvet chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""Sila Orica be damned, this is the real seat that matters. And it's been waiting for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "I made my way over to the chair. Once we were both seated, I turned to my uncle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""As though I'd trust anyone else to advise my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[150]`
Mówca: **Narrator**
> "He smiled fondly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""I hope you can make it out for a visit soon. Both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""You and the Princess ought to come out for a visit soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""Between that and visits to Rico in Iza, I haven't had a day off since the funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[157]`
Mówca: **Hugo Toras**
> ""They propose decrees and issue official approvals or disapprovals of the laws passed by you and the council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""It still works the way he intended. Rizia has the appearance of a constitutional democracy while power remains firmly in the hands of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Hugo raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[160]`
Mówca: **Hugo Toras**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Narrator**
> "Vina finished jotting down some notes as Hugo went searching for the wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[162]`
Mówca: **Hugo Toras**
> ""I think your father kept a store of vintage Cantuavo in one of these cabinets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Vina Toras**
> ""Thank you for the offer anyway, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[164]`
Mówca: **Vina Toras**
> ""Thank you for the invitation, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't drink, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gladly. We still have much to catch up on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Trait_SoberKing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another time, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm your superior now, Your Grace. It wouldn't be appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Narrator**
> "Hugo scowled briefly, then forced a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""Noon already. Shall we and the young heiress break for a glass of wine before the council convenes this afternoon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""I look forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""Is that so? Since when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[180]`
  - -> `[184]`
  - -> `[187]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I could never stand the taste of alcohol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since I found God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I overdid it as the Party Prince. I'm clean now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't remember. I just stopped at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""A respectable decision. But on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[189]`
Mówca: **Hugo Toras**
> ""A curious way of expressing your devotion. Alcohol consumption is expressly permitted in most Nurist denominations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Hugo Toras**
> ""I never knew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""You should remember that it's highly untraditional for a Rizian monarch to refuse his country's national beverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[192]`
Mówca: **Narrator**
> "Hugo raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[193]`
Mówca: **Hugo Toras**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[194]`
Mówca: **Narrator**
> "He stood up, then paused and turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[195]`
Mówca: **Hugo Toras**
> ""I think your father kept a store of vintage Cantuavo in one of these cabinets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't drink, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gladly. We still have much to catch up on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another time, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm your superior now, Your Grace. It wouldn't be appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Narrator**
> "Hugo scowled, then forced a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""Noon already. Shall we break for a glass of wine before the council convenes this afternoon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`
  - -> `[198]`
  - -> `[199]`

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""I look forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "He stood up, then paused and turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since I found God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I overdid it as the Party Prince. I'm clean now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't remember. I just stopped at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
Mówca: **Hugo Toras**
> ""A respectable decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[215]`
Mówca: **Hugo Toras**
> ""That's an extreme interpretation of Wruhecism. But I can respect it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[216]`
Mówca: **Hugo Toras**
> ""I never knew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[217]`
Mówca: **Hugo Toras**
> ""Is that so? Since when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[206]`
  - -> `[210]`
  - -> `[213]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I could never stand the taste of alcohol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[219]`
Mówca: **Hugo Toras**
> ""You should find a way to keep this a secret, though. No Rizian monarch can be seen refusing his country's national beverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. Well, in that case, my sober days are over. Pour me a glass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duly noted. I'll figure something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Narrator**
> "Hugo laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Trait_SoberKing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If tradition demands it, you might as well pour me a glass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duly noted, but this isn't a formal occasion. I respectfully decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Narrator**
> "Hugo laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[227]`
Mówca: **Vina Toras**
> ""Thank you for the offer anyway, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Hugo Toras**
> ""My pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Hugo Toras**
> ""I know how overwhelming the move to the capital can be, Your Highness. If you ever need someone to talk to, remember you can always come to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Narrator**
> "He turned to look Vina in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Vina smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Vina Toras**
> ""That's very kind of you, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`
  - -> `[240]`

### Węzeł `[233]`
Mówca: **Narrator**
> "He turned to look my daughter in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""What an intelligent and well-mannered young woman you've grown up to be, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Hugo Toras**
> ""I know how overwhelming the capital can seem compared to Monqiz. If you ever have questions, don't be afraid to come to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Narrator**
> "Vina smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Vina Toras**
> ""That's very kind of you, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`
  - -> `[253]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. *Too* kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to your uncle, Vina. He knows how everything works around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No offers of advice for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[241]`
Mówca: **Hugo Toras**
> ""Forgive my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[242]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[243]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
Mówca: **Hugo Toras**
> ""The larger your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Vina finished jotting down a few notes. The three of us packed up and left for the morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[249]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. *Too* kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to your uncle, Vina. He knows how everything works around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No offers of advice for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[254]`
Mówca: **Hugo Toras**
> ""Pardon my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[255]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[256]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[257]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[261]`
Mówca: **Hugo Toras**
> ""The more ferocious your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[262]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[263]`
Mówca: **Hugo Toras**
> ""I hope young Vina is adjusting to life in the capital? Please let her know that if she has questions, she shouldn't feel shy about coming to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`
  - -> `[267]`

### Węzeł `[264]`
Mówca: **Hugo Toras**
> ""I hope young Vina is adjusting to life in the capital? Please let her know that if she has questions, she shouldn't feel shy about coming to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`
  - -> `[280]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's kind of you. *Too* kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer. I'll let her know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No advice for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[268]`
Mówca: **Narrator**
> "He turned away and started searching for the wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[269]`
Mówca: **Hugo Toras**
> ""Forgive my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[270]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[271]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[276]`
Mówca: **Hugo Toras**
> ""The more ferocious your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's kind of you. *Too* kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer. I'll let her know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No advice for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[281]`
Mówca: **Narrator**
> "He turned away. The two of us packed up in silence and left for the morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[282]`
Mówca: **Hugo Toras**
> ""Forgive my forwardness. I'm simply excited to have the family together again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[283]`
Mówca: **Hugo Toras**
> ""What is my role as Grand Vizier, if not to advise the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[284]`
Mówca: **Hugo Toras**
> ""I said it all to you during our hunting days, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[285]`
Mówca: **Hugo Toras**
> ""I wouldn't presume to know better than you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[289]`
Mówca: **Hugo Toras**
> ""The larger your quarry, the more important it is not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[290]`
Mówca: **Hugo Toras**
> ""But of course you can always come to me with questions as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_WineWithHugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_WineWithHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why can't I attend? I want to be in touch with my populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think would be the consequences if I ignore them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Hugo Toras**
> ""Officially, there are none. Unofficially, I'd advise you to take their input into account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[295]`
Mówca: **Hugo Toras**
> ""The sessions can be quite long and tedious, Your Majesty. The King's time is better spent on other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Hugo Toras**
> ""With that said, I would advise you to take the Delegates' input into account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[297]`
Mówca: **Hugo Toras**
> ""Fortunately, the Delegates' speaker, Daria de Rava, is a Toras loyalist through and through. She should give you no trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_RustyAgainstRegs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need all this. I can fend for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So they're guarding Vina and Queen Mother Estela as well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Titus Gordion**
> ""Your limp says otherwise. There's no way that would have happened on our watch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[305]`
Mówca: **Titus Gordion**
> ""What about your young daughter? Your elderly mother? It may not always be you that your enemies target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[306]`
Mówca: **Titus Gordion**
> ""Yes, my men have eyes on both of them as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[307]`
Mówca: **Hugo Toras**
> ""One more thing. As you're aware, a few years before your father's death, he reinstated the Golden Guard...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[310]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. The royal family's personal security force. And where are they now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would he do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[311]`
Mówca: **Titus Gordion**
> ""Here, sir. Ready and able.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Narrator**
> "For the first time, I noticed the man standing in the corner of the room. He was wearing a tight-fitting gold blazer that barely concealed his muscular physique."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""Meet Titus Gordion, captain of the Golden Guard. He and his men have been keeping a close watch on you since the coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`
  - -> `[319]`

### Węzeł `[314]`
Mówca: **Titus Gordion**
> ""We hope to serve you well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""For his and your personal protection, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[316]`
Mówca: **Titus Gordion**
> ""A Golden Guard appears only if and when he is needed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Has he been in the room with us this whole time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm pleased to meet you, Captain Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Titus Gordion**
> ""Call me Titus, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""Titus and the members of his two-thousand strong brigade have been trained in the upper echelons of Rizia's military and police academies. Each has sworn an oath to protect the King and his family at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[336]`
  - -> `[299]`
  - -> `[300]`
  - -> `[358]`

### Węzeł `[322]`
Mówca: **Titus Gordion**
> ""My apologies, sir. I was waiting for an opportune time to introduce myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[326]`
Mówca: **Titus Gordion**
> ""Yes. My men have eyes on the Queen Mother as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Narrator**
> "He bowed to Vina. She looked a little flustered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Vina Toras**
> ""But didn't Queen Lyza discontinue the Golden Guard? Because she thought they made royals look elitist, and because...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Narrator**
> "She trailed off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Titus Gordion**
> ""Because she thought they were getting too powerful. It's why our current force is less than a fifth of the size it once was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's with the costumes? Wouldn't plainclothes bodyguards be more effective?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Titus Gordion**
> ""It sends the signal that you are well protected, sir. My predecessors wore solid gold breastplates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do we know they can be trusted? What if someone gets to them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Titus Gordion**
> ""I conduct regular screenings of each and every member of my brigade, Your Majesty. As for myself, I have no wife and child to threaten, and I receive a paycheck so large that bribery would be of no use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[338]`
Mówca: **Hugo Toras**
> ""Your father always had a fondness for Rizian tradition. So he spared no expense in bringing the Guard back, albeit in a reduced form.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`
  - -> `[342]`

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""My mother Lyza discontinued the Golden Guard. But King Valero always did have a fondness for Rizian tradition. He spared no expense in bringing it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`
  - -> `[342]`
  - -> `[343]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and your men had better stay in line, Captain Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It humbles me to be worthy of such an elite unit's protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was right to do so. The most important family in Rizia deserves the most important security force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards in gold... it still seems too flashy for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Titus Gordion**
> ""We'll be sure to stay out of your way, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[345]`
Mówca: **Titus Gordion**
> ""I won't let you down, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[346]`
Mówca: **Titus Gordion**
> ""The humility is all mine, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Titus Gordion**
> ""We answer to no one but you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Hugo Toras**
> ""Thank you, Titus. You may wait outside the chambers until the meeting's conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Narrator**
> "Titus nodded and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a waste of time. I'd rather just make all the decrees myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""I'd advise you to at least take the Delegates' input into account, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're wrong. It is very kingly of me to show up whenever I want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for that, Your Grace. I will be counting on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Hugo Toras**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. Looking forward to working with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Titus Gordion**
> ""It is an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[360]`
Mówca: **Hugo Toras**
> ""It was the only way for him to stay in power. Rizia could not survive past the 1920s without some semblance of democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "Hugo winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[363]`
Mówca: **Hugo Toras**
> ""Do not discount the importance of the nobility to this kingdom, my nephew. Keep them satisfied, and commoners' lives will be better for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Hugo Toras**
> ""But if you want a self-styled 'man of the people', look no further than the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Hugo Toras**
> ""More specifically, to their new leader Manus Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid = true;
RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Economy_AncientRezenidCityRestoration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Nelvisar_VergeOfDepletion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspected = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Havas_CoalDepositsSuspected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_RoyalDecrees = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[372]`
Mówca: **Hugo Toras**
> ""Like your father and grandmother before you, you alone have the power to shape this country by passing royal decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Hugo Toras**
> ""As is tradition over hundreds of years, each new ruler has passed the Sovereign Transition and Clemency Decree to start their reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""The kingdom will be expecting your decree very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[377]`
  - -> `[376]`
  - -> `[375]`
  - -> `[381]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never go against the traditions of Rizia. I will sign the decree as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The decrees will play a significant role in my reign. They won't be just symbolic gestures, but tools to shape the future of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your advice, uncle. It's comforting to have your wisdom and experience guiding me at the start of my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Hugo Toras**
> ""Your humility is appreciated. But remember, being King is about making hard decisions, not just following advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[379]`
Mówca: **Hugo Toras**
> ""Wield this power wisely, Romus. The decrees you issue should strengthen the fabric of our kingdom, not tear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[380]`
Mówca: **Hugo Toras**
> ""Very good. Upholding tradition is key to the stability of our monarchy and the continued loyalty of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been looking forward to this all my life. Finally, I have the power to make decisions completely unchallenged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_PromisedToSignTransition = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_PromisedToSignTransition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tradition is the enemy of progress. We should not be bound by the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Hugo Toras**
> ""Disregarding tradition is a perilous path, Romus. Our people cherish these customs. They are the bedrock of our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[388]`
Mówca: **Hugo Toras**
> ""I still urge caution. Nobody can stop you from passing decrees, but you have to be prepared for possible backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[389]`
Mówca: **Hugo Toras**
> ""Moving too swiftly away from them -- as you did during your coronation --might bring unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_GaveSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[393]`
Mówca: **Narrator**
> "Hugo reached for a neatly rolled parchment lying on the grand table. With deliberate movements, he unrolled it, revealing the prepared royal decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Narrator**
> "The intricate script and the seal of Rizia glinted under the chandelier's light."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_RoyalDecrees = true;
RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It troubles me that a single person can hold that much power. I am as fallible as anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Hugo Toras**
> ""That's what your advisors are for, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""I will, however, gently remind you that it is traditional for each new monarch of Rizia to pass the Sovereign Transition and Clemency Decree to start their reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[403]`
Mówca: **Hugo Toras**
> ""The kingdom will be expecting your signature soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[430]`
  - -> `[423]`
  - -> `[431]`
  - -> `[411]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_SecurityCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_SecurityCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_SecurityCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[407]`
Mówca: **Hugo Toras**
> ""You were assisting with royal decrees before your reign. Now, you're the one holding the seal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[408]`
Mówca: **Hugo Toras**
> ""I think we're almost done here. Unless there's anything else you'd like to bring up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `293` (*Rizia/Turn 1/Intention Questions*), Węzeł `[1]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_UnitedContanaICBMTest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_LargerYourQuarry = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_LargerYourQuarry"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It troubles me that a single person can hold that much power. I am as fallible as anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Hugo Toras**
> ""Moving too swiftly away from them -- as you did during your coronation --might bring unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[416]`
Mówca: **Hugo Toras**
> ""That's what your advisors are for, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_GaveSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_RoyalDecrees = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_SovereignTransitionandClemency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_PromisedToSignTransition = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_PromisedToSignTransition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never go against the traditions of Rizia. I will sign the decree as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Hugo Toras**
> ""I urge you to reconsider, Romus. No monarch wants to be remembered as a tyrant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[425]`
Mówca: **Hugo Toras**
> ""Very good. Upholding tradition is key to the stability of our monarchy and the continued loyalty of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been looking forward to this all my life. Finally, the power to make decisions completely unchallenged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tradition is the enemy of progress. We should not be bound by the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Hugo Toras**
> ""Disregarding tradition is a perilous path, Romus. Our people cherish these customs. They are the bedrock of our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[429]`
Mówca: **Hugo Toras**
> ""I still urge caution. Nobody can stop you from passing decrees, but you have to be prepared for possible backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Clemency? Ha! Under me, the people of Rizia will know no clemency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[435]`
Mówca: **Hugo Toras**
> ""At any rate, since you say you're caught up on the political situation, the rest of our meeting won't last long. But perhaps you'd appreciate an update on the noble houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Sizing up their kingdom’s intricate politics", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Sizing up their kingdom’s intricate politics","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
