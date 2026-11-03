# Rizia/Turn 8/A_SalInvestigationResults

- **ID konwersacji:** `406`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/406_A_SalInvestigationResults.md`
- **Liczba węzłów dialogowych:** 825
- **Liczba wyborów gracza:** 127

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLCIsolated.SalInvestigation_Alone`
- `RiziaDLCIsolated.SalInvestigation_Paper_1`
- `RiziaDLCIsolated.SalInvestigation_Paper_2`
- `RiziaDLCIsolated.SalInvestigation_Paper_3`
- `RiziaDLCIsolated.SalInvestigation_Paper_4`
- `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation`
- `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity`
- `RiziaDLCIsolated.SalInvestigation_Poison_BoyName`
- `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure`
- `RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork`
- `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne`
- `RiziaDLCIsolated.SalInvestigation_Sal_Sorry`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare`
- `RiziaDLCIsolated.Turn07_TitusChat_Derdia`
- `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PoisonInvestigation_Continues`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.SalExonerated`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Sal_MentionsProphecy`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLCIsolated.SalInvestigation_Alone`
- `RiziaDLCIsolated.SalInvestigation_Paper_1`
- `RiziaDLCIsolated.SalInvestigation_Paper_2`
- `RiziaDLCIsolated.SalInvestigation_Paper_3`
- `RiziaDLCIsolated.SalInvestigation_Paper_4`
- `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation`
- `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity`
- `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure`
- `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne`
- `RiziaDLCIsolated.SalInvestigation_Sal_Sorry`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare`
- `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus`
- `RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested`
- `RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo`
- `RiziaDLCSupport.News_Turn08_RH_SalArrested`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 21
- **Węzły modyfikujące stan gry:** 56

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[32]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] = true;`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] = true;`
- Węzeł `[42]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] = true;`
- Węzeł `[83]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] = true;`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] = true;`
- Węzeł `[93]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] = true;`
- Węzeł `[103]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] = true;`
- Węzeł `[146]` (Paskal Beniwoll): `End();`
- *...oraz 48 innych węzłów ze skryptami.*

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
  - -> `[824]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's so urgent that it keeps me from enjoying my lunch in peace and quiet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Letting out a sigh, I threw down my fork and speared the roast chicken with my knife before turning to find out what the hell she wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Lucita hurried into the room and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Titus hurried into the room and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""I'm sorry to disrupt you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[6]`
  - -> `[12]`
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Titus Gordion**
> ""I'm sorry to disrupt you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No worries at all. What can I do for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Lucita Azaro**
> ""Even the palace walls have ears, Your Majesty. If you wouldn't mind...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`
  - -> `[21]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[18]`
Mówca: **Titus Gordion**
> ""Even the palace walls have ears, sir. If you wouldn't mind...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""I've finished my investigation into Grand Wiseman Ignacius.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""It turns out your suspicions were correct. I now have solid evidence that he was involved in your late father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[298]`
  - -> `[299]`
  - -> `[392]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Out. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Titus Gordion**
> ""My investigation into the Grand Wiseman has concluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Titus Gordion**
> ""As it turns out, your suspicions about him were correct. I now have solid evidence that he was involved in your late father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[298]`
  - -> `[299]`
  - -> `[392]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Sal Investigation Results Questions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[34]`
  - -> `[39]`
  - -> `[65]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where was the bottle found?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mandragora. So Pabel was right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is the boy that told you about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not convinced. Is the bottle the only evidence you have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""The boy took us to a secret chamber within the capital's Archsanctuary which Sal apparently used as a study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[54]`
Mówca: **Titus Gordion**
> ""The boy took us to a secret chamber within the capital's Archsanctuary, which Sal seemingly utilized as a study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Investigation Results Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Your butler told you this? It's no wonder you're so fond of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Titus Gordion**
> ""Your butler told you about this substance? His insight should be rewarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Investigation Results Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Alfreth Tilda. An orphan taken in years ago. He was pursuing the path of a seminarian -- training to become a priest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Titus Gordion**
> "“Alfreth Tilda. An orphan who was taken in years ago. He was training to become a priest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> "“Initially hesitant to divulge what he knew, he eventually opened up when we stressed that we were investigating a potential homicide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""He knew nothing about this substance or how it was used.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[63]`
Mówca: **Titus Gordion**
> "“Initially hesitant to divulge what he knew, the kid eventually opened up when we stressed that we were investigating a potential homicide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Titus Gordion**
> ""He was unaware of what this substance was or how it was used.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == true || RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyName == true || RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == true || RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyName == true || RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`
  - -> `[547]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == true || RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyName == true || RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's quite the revelation. Please go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""That's not all. There is something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Titus Gordion**
> ""That's not all. There's something else you should see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Narrator**
> "She presented what appeared to be an old journal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Narrator**
> "He presented what appeared to be an old journal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "Take it and read it."]** — Mówca: **Player_Romus_Italic**
> "I took it and began reading its contents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "There were dates and short descriptions underneath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Sal Investigation Paper)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[85]`
  - -> `[90]`
  - -> `[104]`
  - -> `[112]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "Read the first entry."]** — Mówca: **Player_Romus_Italic**
> "I read the first entry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_1 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_1 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Paper_1 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_1 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "Read the second entry."]** — Mówca: **Player_Romus_Italic**
> "I read the second entry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_2 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_2 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Paper_2 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_2 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "Read the third entry."]** — Mówca: **Player_Romus_Italic**
> "Read the third entry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_3 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_3 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Paper_3 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_3 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Narrator**
> ""Valero agreed to go through the trials that I proposed. I fear what may come, yet I remain steadfast in the knowledge that the prophesied king will eventually return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Narrator**
> ""October 24th, sunset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Narrator**
> ""October 16th, late afternoon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Narrator**
> ""November 1st, close to midnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
Mówca: **Narrator**
> ""It's hard to believe the king has entrusted me with this sacred task. Sometimes I think that I take his faith in me for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> ""We will see if he is the one. I pray that it is true. I must up the dosage further. We are getting closer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[100]`
Mówca: **Narrator**
> ""While he exhibits signs of joy and laughter, it appears that the dosage is insufficient. I will augment it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[101]`
Mówca: **Narrator**
> ""The King is having convulsions. The dosage might be too high. But we are so close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "Read the fourth entry."]** — Mówca: **Player_Romus_Italic**
> "Read the fourth entry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_4 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_4 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_4 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Paper_4 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Narrator**
> ""November 18th, late evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Narrator**
> ""The king whispered my name before I left his chambers. It still echoes in my head. 'Sal, Sal... look after Romus.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Narrator**
> ""Not long after administering the final dose, I knew something was wrong -- a darkness began consuming him as if he had been cursed!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[110]`
Mówca: **Narrator**
> ""Everything depends on this now. I will administer the final dose on the 18th. Oh God, I pray to you for a successful outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[111]`
Mówca: **Narrator**
> ""Valero was not the chosen one. I have failed. Perhaps his son. Time will tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_1 == true && RiziaDLCIsolated.SalInvestigation_Paper_2 == true && RiziaDLCIsolated.SalInvestigation_Paper_3 == true && RiziaDLCIsolated.SalInvestigation_Paper_4 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Paper_1 == true && RiziaDLCIsolated.SalInvestigation_Paper_2 == true && RiziaDLCIsolated.SalInvestigation_Paper_3 == true && RiziaDLCIsolated.SalInvestigation_Paper_4 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Paper_1 == true && RiziaDLCIsolated.SalInvestigation_Paper_2 == true && RiziaDLCIsolated.SalInvestigation_Paper_3 == true && RiziaDLCIsolated.SalInvestigation_Paper_4 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Investigation Paper])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""Your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[124]`
  - -> `[123]`
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""Your orders, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[124]`
  - -> `[123]`
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think I should do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What he has or hasn't allegedly done is irrelevant. You're not to mention a word of this to anyone. Sal walks free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest the Grand Wiseman immediately and throw him in prison to rot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bring him to me. I will talk to him first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""If it were up to me, I'd say he should be arrested for treason against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[123]`
  - -> `[122]`

### Węzeł `[129]`
Mówca: **Titus Gordion**
> ""I find it hard to believe the Grand Wiseman could be guilty of such treason. But the evidence speaks for itself...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[123]`
  - -> `[122]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""This is... unexpected, but I shall abide by your command, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""This is... not the direction I'd expected you to take.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Lucita Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[139]`
Mówca: **Titus Gordion**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Sal Questioning)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[141]`
Mówca: **Narrator**
> "She bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[142]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Alone in the room where my father passed, I wondered if arresting Sal was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Did I act justly, or was I swayed by personal feelings?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[145]`
Mówca: **Narrator**
> "And if Sal didn't kill my father... who did?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Lucita Azaro**
> ""I'll fetch him at once, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[151]`
Mówca: **Titus Gordion**
> ""I'll bring him at once, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Questioning])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Several hours later, Lucita and a few guards arrived, as did my esteemed guest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[157]`
Mówca: **Narrator**
> "Several hours later, Titus and a few guards arrived, as did my esteemed guest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[158]`
Mówca: **Lucita Azaro**
> ""Here you are, Your Majesty. We brought him to you as ordered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""Here you are, Your Majesty, as instructed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[160]`
Mówca: **Narrator**
> "The guards held Sal firmly by both arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everyone except Sal. Out. I wish to speak to him in private.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep him close in case he tries anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Narrator**
> "It took a few tries to convince everyone to leave. Eventually, though, Sal and I were alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Narrator**
> "The guards held his arms tighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Sal Questions Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[174]`
  - -> `[553]`
  - -> `[178]`
  - -> `[183]`
  - -> `[198]`

### Węzeł `[166]`
Mówca: **Narrator**
> "On seeing the journal in my hands, Sal's eyes filled with fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[454]`
  - -> `[455]`
  - -> `[459]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you give my father that poison?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why should I spare you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me more about this prophecy you were trying to fulfill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhySpare = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Do you feel remorse for what you've done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_Sorry = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm finished with this interrogation. Everyone, please return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Alone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Alone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm finished with this interrogation. Here is my verdict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here is my verdict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Titus and his men came back into the room, eager to hear my verdict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[207]`
Mówca: **Sal Ignacius**
> ""It is not poison, Your Majesty. As you have already witnessed, it is a tool to prepare one's mind to receive the gift of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Sal Ignacius**
> ""When a Grand Wiseman such as myself partakes of it, such visions come in flashes, their meaning shrouded in mystery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[209]`
Mówca: **Sal Ignacius**
> ""Unfortunately, that did not transpire with His Majesty Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[582]`
  - -> `[584]`

### Węzeł `[210]`
Mówca: **Lucita Azaro**
> ""You are insane, Grand Wiseman. Pure and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""I cannot believe a psychoactive substance would play such a significant role in our religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Questions Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[213]`
Mówca: **Sal Ignacius**
> ""Because there is still hope, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Sal Ignacius**
> ""Your father may not have been the one, but as it is foretold, it may very well be you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Alone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Sal Ignacius**
> ""Do what you must, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""I am a humble servant of God and he alone knows my path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[223]`
Mówca: **Sal Ignacius**
> ""The prophecy is real. All the events are falling into place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""Did God tell you to murder the monarch of Rizia, kingslayer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Titus Gordion**
> ""What kind of God commands a man to slay his king?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Questions Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[227]`
Mówca: **Sal Ignacius**
> ""'Beneath the watchful gaze of the ancients, upon the hallowed altar, the king will partake of the sacred draught, its composition known only to the cloistered few.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Sal Ignacius**
> ""'As the elixir courses through his veins, the world around him shall dissolve.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Sal Ignacius**
> ""'In this expanse, the whispers of the ancients will foretell the trials and triumphs of his reign.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Sal Ignacius**
> ""'Amidst this ethereal void, a silhouette will emerge, a boy, born of his lineage, reaching for a crown that dances like a flame...'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[231]`
Mówca: **Sal Ignacius**
> ""This has been passed down for centuries, Your Majesty, and I shall recite it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Alone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Lucita Azaro**
> ""Such bullshit.... How dare you call yourself a priest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Titus Gordion**
> ""As a Wruhecist myself, this smells strongly to me of heresy. And you dare call yourself a priest...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Questions Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[241]`
Mówca: **Sal Ignacius**
> ""Valero was kind... and a friend, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Sal Ignacius**
> ""One of the few I could call upon. He entrusted his life to me, and I failed him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Alone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Lucita Azaro**
> ""Yes, you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Titus Gordion**
> ""God will never forgive you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Questions Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[252]`
Mówca: **Sal Ignacius**
> ""What happened with your father was a tragedy, but his death doesn't have to be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[253]`
Mówca: **Sal Ignacius**
> ""By keeping the faith, together we will unlock the secrets to Rizia’s glory and her salvation!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what he has or hasn't done. You're not to mention a word of this to anyone. Sal walks free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[255]`
Mówca: **Sal Ignacius**
> ""I do. Every day, I offer prayers to God for forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest Grand Wiseman Sal Ignacius immediately. Let him rot in prison for the rest of his wretched life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
Mówca: **Titus Gordion**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested = true;
RiziaDLCSupport.News_Turn08_RH_SalArrested = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
RiziaDLC.PoisonInvestigation_Continues = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Sal_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_SalArrested"] = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""It shall be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[264]`
Mówca: **Titus Gordion**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[265]`
Mówca: **Narrator**
> "The guards forcibly escorted Sal away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Lucita Azaro**
> ""I must admit, this is rather unexpected. Nevertheless, I will comply with your orders, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Titus Gordion**
> ""I must say, this is not the direction I'd expected you to take. But I understand wholeheartedly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""The Grand Wiseman shall be released.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[272]`
Mówca: **Titus Gordion**
> ""The Grand Wiseman shall be released.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[308]`
  - -> `[311]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Sal bowed and began to leave before turning back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_MentionsProphecy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Sal_MentionsProphecy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[289]`
Mówca: **Narrator**
> "As I dined in the palace's Hall of Nobility, adorned with paintings of Rizian royal figures, I was interrupted by Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[293]`
Mówca: **Narrator**
> "I dabbed my mouth and rose to welcome her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[294]`
Mówca: **Narrator**
> "She gestured at Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[295]`
Mówca: **Narrator**
> "He gestured at Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[296]`
Mówca: **Narrator**
> "Pabel bowed respectfully before exiting the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[297]`
Mówca: **Narrator**
> "He flashed me a look of gratitude before bowing respectfully and leaving the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal! I knew it was him!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a hard time believing that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Adria is a trusted confidante, not a wall. He will stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Pabel. You may leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[306]`
Mówca: **Sal Ignacius**
> ""Pass all the judgment you like, Romus the First, but you can't evade the judgment of God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[307]`
Mówca: **Sal Ignacius**
> ""Mark my words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not sparing you out of charity. You will help me when the time comes. Just as I helped you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go now and leave me be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Sal Ignacius**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
**[WYBÓR GRACZA: "Nod and gesture for him to leave."]** — Mówca: **Player_Romus_Italic**
> "I nodded and gestured for him to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Sal Ignacius**
> ""The path chosen for us will prevail, Your Majesty. We all have a purpose in this world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Sal Ignacius**
> ""Yours has yet to unfold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[314]`
Mówca: **Narrator**
> "Lucita gestured for Sal to leave. The wiscerer bowed low before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[315]`
Mówca: **Narrator**
> "Titus gestured for Sal to leave. The wiscerer bowed low before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `AddConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo = true;
RiziaDLC.SalExonerated = true;
RiziaDLC.PoisonInvestigation_Continues = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo"] = true;
Variable["RiziaDLC.SalExonerated"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo = true;
RiziaDLC.SalExonerated = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo"] = true;
Variable["RiziaDLC.SalExonerated"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can disrupt me any time, Lucita. Day or night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Lucita Azaro**
> ""Unfortunately, this disruption is a rather serious one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[327]`
Mówca: **Pabel Adria**
> ""Pardon the interruption, Your Majesty. But Duchess Azaro is here seeking your immediate attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Pabel Adria**
> ""Pardon the interruption, Your Majesty. But Captain Gordion is here seeking your immediate attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Pabel Adria**
> ""She insists it's a matter of great importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[355]`
  - -> `[356]`
  - -> `[357]`

### Węzeł `[333]`
Mówca: **Pabel Adria**
> ""He insists it's a matter of great importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[370]`
  - -> `[371]`
  - -> `[372]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[340]`
Mówca: **Narrator**
> "After a final sip of wine, I rose to welcome her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[341]`
Mówca: **Narrator**
> "I drained the last of my wine, then turned to find out what the hell she wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Narrator**
> "Letting out a sigh, I threw down my fork and speared the roast chicken with my knife before turning to find out what the hell he wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[349]`
Mówca: **Narrator**
> "I dabbed my mouth and rose to welcome him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[353]`
Mówca: **Narrator**
> "After a final sip of wine, I rose to welcome him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[354]`
Mówca: **Narrator**
> "I drained the last of my wine, then turned to find out what the hell he wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything's a matter of great importance with her. But very well. Send her in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Send her in right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell her I'm not here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Pabel Adria**
> ""I'm afraid she knows you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In that case, just send her in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Let's hear what she has to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Inform her regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[362]`
Mówca: **Narrator**
> "He promptly turned to open the door, bringing Lucita inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[363]`
Mówca: **Narrator**
> "He quickly turned to open the door and ushered Lucita inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[364]`
Mówca: **Narrator**
> "He swiftly pivoted to open the door and ushered Lucita inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still eating. Ask her to come back later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Lucita pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[367]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Lucita pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything's a matter of great importance with him. But very well. Send him in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Send him in right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell him I'm not here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Let's hear what he has to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[374]`
Mówca: **Narrator**
> "He promptly turned to open the door, bringing Titus inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[375]`
Mówca: **Narrator**
> "He quickly turned to open the door and ushered Titus inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[376]`
Mówca: **Narrator**
> "He swiftly pivoted to open the door and ushered Titus inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[377]`
Mówca: **Pabel Adria**
> ""I'm afraid he knows you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[373]`
  - -> `[379]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In that case, just send him in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Inform him regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still eating. Ask him to come back later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Titus pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[383]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Titus pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: LucitaEnter_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: TitusEnter_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [TitusEnter_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [TitusEnter_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [LucitaEnter_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [LucitaEnter_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess... in the billiard room... with the candlestick...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Lucita Azaro**
> ""I'm sorry, Your Majesty, but I don't have a clue what you're alluding to. Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[399]`
Mówca: **Titus Gordion**
> ""If only it were that easy... In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[400]`
Mówca: **Narrator**
> "She pulled out an evidence bag that contained a small brown bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[401]`
Mówca: **Narrator**
> "He pulled out an evidence bag that contained a small brown bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[402]`
Mówca: **Narrator**
> "Hallucinations... I wondered whether this was somehow related to the holy wine Sal drank at my consecration ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_MandragoraExtract");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_MandragoraExtract");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[404]`
Mówca: **Narrator**
> "She handed me the bag with the bottle. It still had a little bit of liquid left in it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Narrator**
> "He handed me bag with the bottle. It still had a little bit of liquid left in it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""I had many of his priests interrogated. Unfortunately, getting through to them proved impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""They remained tight-lipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[419]`
  - -> `[417]`
  - -> `[418]`

### Węzeł `[411]`
Mówca: **Lucita Azaro**
> "“Just when it seemed we’d exhausted all of our leads, a surprise witness who worked for the clergy came forward -- a boy, actually -- and gave us the break we desperately needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""He led us to this, Your Majesty. It belongs to the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[413]`
Mówca: **Titus Gordion**
> ""I subjected many of his priests to interrogation. Unfortunately, eliciting any useful information from them proved impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Titus Gordion**
> ""Every one of them remained tight-lipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[417]`
  - -> `[418]`

### Węzeł `[415]`
Mówca: **Titus Gordion**
> "“Just when it seemed we’d exhausted all of our leads, a surprise witness who worked for the clergy came forward -- a boy, actually -- and gave us the break we needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Titus Gordion**
> ""He led us to this, sir. It belongs to the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't say I'm surprised. Their loyalty is to their wiscerer, not their king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Interrogating priests? Are we staging a holy inquisition now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hah! Bring them to me. I'll handle them personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you no respect for the sanctity of Wruhecism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Lucita Azaro**
> ""I did what had to be done. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[425]`
Mówca: **Titus Gordion**
> ""Believe me, I took no pleasure in resorting to such measures. But it had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[429]`
Mówca: **Lucita Azaro**
> ""Fortunately, that won't be necessary. You see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[430]`
Mówca: **Titus Gordion**
> ""Thankfully, that won't be needed. You see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Lucita Azaro**
> ""They'd sooner lose a limb than betray the Grand Wiseman. Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[435]`
Mówca: **Titus Gordion**
> ""Yes, they'd sooner part with their limbs than betray the Grand Wiseman. Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Lucita Azaro**
> ""I wouldn't go that far... But I assure you., it was a measure taken out of necessity. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[440]`
Mówca: **Titus Gordion**
> ""I wouldn't go that far... But I assure you, it was out of necessity. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""Our toxicologists identified this as Mandragora. A deadly nightshade historically used to induce hallucinations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[442]`
Mówca: **Titus Gordion**
> ""Toxicologists identified this as Mandragora. It's a deadly nightshade historically used to induce hallucinations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[443]`
Mówca: **Sal Ignacius**
> ""By picking up where he left off, we not only honor his memory but open the door to succeeding where he failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[447]`
Mówca: **Sal Ignacius**
> ""You've had your doubts when it comes to matters of faith, so instead I ask you to put your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[448]`
Mówca: **Sal Ignacius**
> ""For He is the ultimate arbiter who punishes those who stray from the righteous path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[449]`
Mówca: **Sal Ignacius**
> ""'He stands as a king above all others -- the living embodiment of divine decree.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Council", "Position_GrandWiseman", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Council","Position_GrandWiseman","");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You’re unusually quiet. Something on your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You've been keeping secrets from me, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I assume you know why you’re here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Would you like to start or should I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I must say… I've come across some rather intriguing literature lately. Care to interpret it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[462]`
Mówca: **Narrator**
> "Sal remained silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`
  - -> `[465]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose the honor is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might want to say a silent prayer while you're at it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[466]`
Mówca: **Sal Ignacius**
> ""Wh... where did you get that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[467]`
  - -> `[469]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you do recognize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll ask the questions, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where you last left it. You've been careless. Sal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[470]`
Mówca: **Sal Ignacius**
> ""Your Majesty... I assure you I was loyal to your father until the very end. I never meant to harm him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. Groveling is beneath a man of your stature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Silence!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you *do* know why I summoned you here. Tell me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[474]`
Mówca: **Narrator**
> "He never looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[475]`
  - -> `[477]`

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, well... it appears you've been blessed with the gift of foresight after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a rhetorical question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at me when you address your king!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Sal Ignacius**
> ""Your Majesty... please. What happened to your father was a mistake, not murder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[479]`
Mówca: **Narrator**
> "His gaze slowly met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[480]`
Mówca: **Sal Ignacius**
> ""If I said I did not, would you believe me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From now on, I'll be the one asking the questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe the man I've come to know would do the righteous thing and confess to what he's done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not toy with me, Sal. Your insolence will not protect you from the consequences of your actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[484]`
Mówca: **Narrator**
> "His gaze met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[481]`
  - -> `[528]`

### Węzeł `[485]`
Mówca: **Narrator**
> "I had him brought to the King's quarters. The very place where my father took his last breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[486]`
Mówca: **Narrator**
> "I had him brought to the King's quarters. The very place where my father took his last breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[487]`
Mówca: **Sal Ignacius**
> ""'Its form blurring the lines between now and what is yet to come, a symbol of a legacy shrouded in the mists of destiny.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[488]`
Mówca: **Sal Ignacius**
> ""'Through him, Rizia shall achieve a greatness unparalleled in the annals of history -- the likes of which the world has never seen!'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[489]`
Mówca: **Titus Gordion**
> ""It was here where we found the bottle, tucked away in a drawer alongside some of the Grand Wiseman's other belongings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[490]`
Mówca: **Lucita Azaro**
> ""It was here where we discovered the bottle, tucked away in a drawer alongside some of Sal's other belongings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[491]`
Mówca: **Sal Ignacius**
> ""For what it's worth, I am deeply sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[492]`
  - -> `[500]`
  - -> `[495]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that with time I'll find the strength to forgive you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like God, I too am forgiving. Now go. Reclaim the righteous path so that you too may find forgiveness in His eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unlike your God, I'm not so easily forgiving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unlike God, I'm not so easily forgiving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like your God, I too am forgiving. Now go. Reclaim the righteous path so that you too may find forgiveness in His eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may have allowed you to walk free, but forgiveness is something I'll never grant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[504]`
Mówca: **Sal Ignacius**
> ""Well, I hope with time you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Sal Ignacius**
> ""I understand. But I hope that with time you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Narrator**
> "And with that, Sal departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[507]`
Mówca: **Sal Ignacius**
> ""As do I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[508]`
Mówca: **Sal Ignacius**
> ""I understand. However, I hope that with time, forgiveness may come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[509]`
Mówca: **Sal Ignacius**
> ""Thank you, Your Majesty. I will strive to make amends and walk the righteous path once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Narrator**
> "Alone in the room where my father passed, I wondered if letting Sal walk free was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`
  - -> `[520]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Narrator**
> "Alone, I wondered if arresting Sal was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[522]`
Mówca: **Narrator**
> "Alone, I wondered if letting Sal walk free was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[523]`
Mówca: **Narrator**
> "I looked around at my bed, chairs and wardrobe, trying to imagine the room as it was on the night Valero passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[524]`
Mówca: **Narrator**
> "I looked around at my bed, chairs and wardrobe, trying to imagine the room as it was on the night Valero passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[525]`
Mówca: **Sal Ignacius**
> ""Together we will unlock the secrets to Rizia’s glory and her salvation!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[526]`
Mówca: **Narrator**
> "Lucita bowed before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[527]`
Mówca: **Narrator**
> "Titus bowed before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[534]`
Mówca: **Lucita Azaro**
> ""The slightest overdose can result in death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[535]`
Mówca: **Titus Gordion**
> ""The slightest overdose can result in death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Lucita Azaro**
> ""Your butler told you this? You ought to reward him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[540]`
Mówca: **Lucita Azaro**
> "“Considering his age, he exhibited remarkable courage, despite possible repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Titus Gordion**
> "“Considering his age, he exhibited remarkable courage, despite possible consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Investigation Results Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So old Sal took a consciousness-expanding trip every now and again. Who doesn't? Is that all the evidence you've got?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fact that such a close advisor was hiding this substance is very worrying indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[548]`
Mówca: **Narrator**
> "The guards looked at me questioningly, awaiting my judgement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[549]`
Mówca: **Narrator**
> "He bowed his head, awaiting my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Alone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Alone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happened on the night of November 18, 1949? I want to know every detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[557]`
Mówca: **Narrator**
> "Sal trembled. His eyes darted to the journal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[558]`
Mówca: **Sal Ignacius**
> ""It is exactly as I wrote it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[559]`
Mówca: **Sal Ignacius**
> ""The King summoned me to his chambers for our final attempt at the sacred ritual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Sal Ignacius**
> ""As instructed by holy scripture, I prepared the tincture and administered it to His Majesty in a glass of wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Sal Ignacius**
> ""As soon as he consumed it, his eyes became wild with terror, as if witnessing something no man should ever see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[562]`
Mówca: **Sal Ignacius**
> ""He began slipping in and out of consciousness... when he spoke, it was unintelligible. 'Look after Romus' were the only words I could make out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`
  - -> `[565]`
  - -> `[594]`

### Węzeł `[563]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you just left him like that? You complete and utter coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you alert the guards?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He summoned you. He brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[566]`
Mówca: **Sal Ignacius**
> ""His Majesty had made me swear to keep the ritual a secret from everyone. And I was sure he would recover after a good night's sleep...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[567]`
Mówca: **Sal Ignacius**
> ""I know. I have rendered my garments so many times in repentance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[568]`
Mówca: **Sal Ignacius**
> ""I convinced him to do it. He was so desperate for answers, and I thought the prophecy would provide them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[569]`
Mówca: **Sal Ignacius**
> ""But I am afraid I underestimated how weak he was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sal Questions Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[574]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[575]`
Mówca: **Sal Ignacius**
> ""It is not poison, Your Majesty, but a tool to prepare one's mind to receive the gift of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[576]`
Mówca: **Sal Ignacius**
> ""Yet it is said that when the king who was prophesied drinks the holy elixir, the future shall be revealed to him as clearly as the past or present.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[577]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'visions' are nothing but hallucinations. They don't mean a damn thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[578]`
Mówca: **Sal Ignacius**
> ""Think of what I foretold at Plavo. Is it not coming true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`
  - -> `[581]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He always was anxious about the future. I can see why he wanted to take this risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like some real strong stuff. Mind if I have a swig?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Sal Ignacius**
> ""Your Majesty, performing this sacred ritual requires months of preparation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't mind receiving that gift myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`
  - -> `[591]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[592]`
Mówca: **Sal Ignacius**
> ""And a piety, that, I am sorry to say, you yourself lack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[593]`
Mówca: **Sal Ignacius**
> ""Spare my life. Then we can talk about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was still alive when you left. Someone else could have gotten to him afterward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[595]`
Mówca: **Sal Ignacius**
> ""I wish I could believe that, Your Majesty. I was so certain the dose I had given the King was non-lethal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true || RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true || RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true || RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true || RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true || RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true || RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[599]`
Mówca: **Narrator**
> "And what horrors did my father see before he drew his final breaths?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[603]`
Mówca: **Narrator**
> "Lucita and the other guards came back into the room, eager to hear my verdict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`
  - -> `[608]`

### Węzeł `[607]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Narrator**
> "Lucita watched him leave with an obvious look of dissatisfaction on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[610]`
Mówca: **Narrator**
> "Titus watched him leave with an obvious look of dissatisfaction on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[611]`
Mówca: **Lucita Azaro**
> ""This doesn't sit right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`
  - -> `[613]`
  - -> `[619]`
  - -> `[615]`

### Węzeł `[612]`
Mówca: **Titus Gordion**
> ""I trust your judgement, Your Majesty. But I feel uneasy letting that man walk free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`
  - -> `[619]`
  - -> `[615]`

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's indebted to me for sparing him. I can use that to my advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not convinced he's actually our culprit. We need to continue this investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[617]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe him. My father was not the king who was prophesied. Myself, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe that he killed my father by complete accident. And he seems remorseful for his actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[623]`
Mówca: **Lucita Azaro**
> ""Really? The case for the Grand Wiseman poisoning the King -- whether accidentally or on purpose -- seems very strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`
  - -> `[627]`
  - -> `[632]`

### Węzeł `[624]`
Mówca: **Titus Gordion**
> ""Are you certain? It seems like a clear-cut case to me, even if the Grand Wiseman acted unintentionally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`
  - -> `[625]`
  - -> `[632]`

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's still the mystery of why Duchess Azaro snuck into my father's room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo and my father were arguing that night. It can't be a coincidence that he died so soon afterward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_TitusChat_Derdia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_TitusChat_Derdia == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_TitusChat_Derdia == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's still the matter of Titus' unexplained absence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus explained why he had to leave his post, but I'm not sure I believe him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. It's too risky to continue investigating people in my inner circle anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[633]`
Mówca: **Lucita Azaro**
> ""Yes, I'm still wondering about that myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[634]`
Mówca: **Titus Gordion**
> ""I confess I've been wondering about that myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[638]`
Mówca: **Lucita Azaro**
> ""Perhaps not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[639]`
Mówca: **Titus Gordion**
> ""I would hate to think the Grand Vizier played a role. But you have a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[642]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`
  - -> `[645]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[646]`
Mówca: **Lucita Azaro**
> ""With that said, my team can't continue this investigation without further funding. And it appears the Crown is pinching pennies at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[647]`
Mówca: **Titus Gordion**
> ""However, the Golden Guard can't continue this investigation without further funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`
  - -> `[693]`
  - -> `[668]`

### Węzeł `[648]`
Mówca: **Titus Gordion**
> ""However, the Golden Guard can't continue our investigation without further funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[652]`
  - -> `[658]`
  - -> `[664]`

### Węzeł `[649]`
Mówca: **Lucita Azaro**
> ""With that said, my team can't continue our investigation without further funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`
  - -> `[658]`

### Węzeł `[650]`
**[WYBÓR GRACZA: ""Spare no expense. I want all your investigatory focus on the Grand Vizier." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Spare no expense. I want all your investigatory focus on the Grand Vizier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[651]`
**[WYBÓR GRACZA: ""So be it. You have my blessing and my funding to investigate Titus Gordion as the primary suspect." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""So be it. You have my blessing and my funding to investigate Titus Gordion as the primary suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[652]`
**[WYBÓR GRACZA: ""So be it. You have my blessing and my funding to investigate Lucita Azaro as the primary suspect." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""So be it. You have my blessing and my funding to investigate Lucita Azaro as the primary suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`
  - -> `[655]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[656]`
Mówca: **Lucita Azaro**
> ""Your wish is our command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[657]`
Mówca: **Titus Gordion**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[658]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind, then. I'm not going to throw any more money at this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[659]`
Mówca: **Lucita Azaro**
> ""We'll get on it straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[662]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[663]`
Mówca: **Titus Gordion**
> ""Duchess Azaro is already in prison, of course, but it may be useful to find more charges to bring against her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`
  - -> `[666]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[667]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why is it always about the money with you?! If anything, your people should be paying *me* for the pleasure of serving their monarch!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[668]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a pity. I was really hoping to get to the bottom of my father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`
  - -> `[671]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[672]`
Mówca: **Narrator**
> "Lucita backed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Narrator**
> "Titus backed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[674]`
Mówca: **Lucita Azaro**
> ""My apologies, Your Majesty. You've had quite the shock today. I'll give you some time to get over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[675]`
Mówca: **Titus Gordion**
> ""My apologies, Your Majesty. You've had quite the shock today. I'll give you some time to get over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[676]`
Mówca: **Narrator**
> "She and her guards bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[677]`
Mówca: **Narrator**
> "He and his guards bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo = true; RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus = true; RiziaDLC.Turn05_MurderInvest_InvestigateTitus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita = true; RiziaDLC.Turn05_MurderInvest_InvestigateLucita = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[681]`
Mówca: **Titus Gordion**
> ""With great pleasure, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo = true; RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Lucita Azaro**
> ""Understandable. I'm sorry we couldn't solve this case to your liking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[687]`
Mówca: **Titus Gordion**
> ""I understand. Please excuse our failure to tie up every loose end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[691]`
Mówca: **Lucita Azaro**
> ""If you ask me, we did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[692]`
Mówca: **Titus Gordion**
> ""I have the feeling we already did so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[693]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't throw any more money down this rabbit hole even if I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`
  - -> `[696]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[696]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[697]`
Mówca: **Narrator**
> "Lucita struggled to hold in her skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[698]`
Mówca: **Narrator**
> "Titus nodded seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[701]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[702]`
Mówca: **Lucita Azaro**
> ""We've got our hands full with threats from outside the palace. We can't let paranoia take over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`
  - -> `[705]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[706]`
Mówca: **Titus Gordion**
> ""He's an old man. He's suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[707]`
Mówca: **Lucita Azaro**
> ""I wouldn't be so sure. But he wouldn't dare to pull the same trick twice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[711]`
Mówca: **Lucita Azaro**
> ""Good thinking, Your Majesty. It wouldn't hurt to have the Sanctuary in your back pocket.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Titus Gordion**
> ""The Sanctuary's cooperation can indeed be a powerful tool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[713]`
Mówca: **Lucita Azaro**
> ""We'll leave it at that, then. I'll have my team destroy all records of this investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[714]`
Mówca: **Lucita Azaro**
> ""Nobody besides us and the Grand Wiseman will know ever happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[715]`
Mówca: **Titus Gordion**
> ""All right. With the King's blessing, the Grand Wiseman shall be cleared of all charges. It'll be as if this investigation never happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[716]`
Mówca: **Titus Gordion**
> ""Everyone has something to hide, Your Majesty. But it's not always worth finding out what that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[717]`
Mówca: **Narrator**
> "With a look of annoyance only I could detect, Pabel bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`
  - -> `[720]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[721]`
Mówca: **Pabel Adria**
> ""Right away, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[722]`
Mówca: **Pabel Adria**
> ""Thank you, Your Majesty, but it's quite all right. I'll see myself out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[726]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`
  - -> `[728]`

### Węzeł `[727]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[729]`
Mówca: **Lucita Azaro**
> ""Whether under the instructions of Sevrio Castellanus or those of the Grand Wiseman himself, they remained tight-lipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[419]`
  - -> `[417]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`
  - -> `[732]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[733]`
Mówca: **Titus Gordion**
> ""Via Sevrio Castellanus, I gained access to his network of priests. Unfortunately, eliciting any useful information from them proved impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[419]`
  - -> `[417]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[736]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[737]`
Mówca: **Titus Gordion**
> "“Alfreth Tilda. An orphan who was taken in years ago. He was training to become a member of Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`
  - -> `[740]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[741]`
Mówca: **Lucita Azaro**
> ""Alfreth Tilda. An orphan taken in years ago. He was training to become a member of Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`
  - -> `[744]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[745]`
Mówca: **Titus Gordion**
> ""But if Wruhec's Guardians is to continue, perhaps it's indeed best to overlook the Grand Wiseman's transgressions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[746]`
Mówca: **Titus Gordion**
> ""But I shall abide by your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`
  - -> `[749]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[750]`
Mówca: **Titus Gordion**
> ""I suppose this means the end of Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`
  - -> `[752]`
  - -> `[753]`

### Węzeł `[751]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Are you disappointed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[752]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal was manipulating me this entire time. Just as he manipulated my father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe I shouldn't be so hasty to disband my trusted holy army. Let's hear what the Grand Wiseman has to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
RiziaDLC.Sal_Arrested = true;
RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested = true;
RiziaDLC.PoisonInvestigation_Continues = false;)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
Variable["RiziaDLC.Sal_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[755]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[756]`
Mówca: **Titus Gordion**
> ""If the Grand Wiseman truly is a murderer, I was a fool to have followed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[757]`
Mówca: **Titus Gordion**
> ""And myself, Your Majesty. He deserves whatever hell awaits him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`
  - -> `[760]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[254]`

### Węzeł `[761]`
Mówca: **Narrator**
> "Suddenly, I heard a commotion outside the door. Sevrio Castellanus burst in and surveyed the scene in dismay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[762]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty... What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`
  - -> `[764]`
  - -> `[765]`
  - -> `[766]`

### Węzeł `[763]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman has been accused of murdering my father. King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't act like you don't know. You were in on this scheme the whole time, weren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[765]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing you need to be worried about, Sevrio. You may leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A mere misunderstanding. The Grand Wiseman has been accused of something he did not do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`
  - -> `[769]`

### Węzeł `[768]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[769]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[770]`
Mówca: **Lucita Azaro**
> ""What? We have concrete evidence of his guilt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[771]`
Mówca: **Titus Gordion**
> ""Your Majesty, Sevrio... I wish that were the case, but the evidence clearly points toward his guilt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[772]`
Mówca: **Sevrio Castellanus**
> ""Scheme? I still don't understand. Why have you detained the Grand Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[773]`
Mówca: **Sevrio Castellanus**
> ""What?! Surely there's been a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[774]`
Mówca: **Sevrio Castellanus**
> ""Please, Your Majesty. I swore to uphold religious order in Rizia. If something concerns the holiest figure in the kingdom, it concerns me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`
  - -> `[777]`

### Węzeł `[776]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[777]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[778]`
Mówca: **Lucita Azaro**
> ""He's right, Your Majesty. As the leader of Wruhec's Guardians, he deserves to know what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[779]`
Mówca: **Titus Gordion**
> ""Sevrio is right, Your Majesty. He deserves to know what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[780]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`
  - -> `[782]`

### Węzeł `[781]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[782]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[783]`
Mówca: **Narrator**
> "Lucita showed him the Grand Wiseman's journal and the bottle that had been found among his belongings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[784]`
Mówca: **Narrator**
> "Titus showed him the Grand Wiseman's journal and the bottle that had been found among his belongings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[785]`
Mówca: **Titus Gordion**
> ""I wish there had been a mistake, Captain Castellanus. But the evidence speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[786]`
Mówca: **Sevrio Castellanus**
> ""It can't be. The Grand Wiseman of the Wruhecist Sanctuary of Rizia would never do such a thing. Tell him, Grand Wiseman...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`

### Węzeł `[787]`
Mówca: **Narrator**
> "Sal quietly shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`
  - -> `[789]`
  - -> `[791]`

### Węzeł `[788]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman played us all for fools. He shall be placed under immediate arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[789]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Sal administered the drug that ended my father's life. But he did so out of love for God and for this country. He shall walk free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[790]`
Mówca: **Narrator**
> "The others gasped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[791]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was weak, Captain Castellanus. He had to die so that Rizia could be reborn. The Grand Wiseman's actions were entirely justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[792]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`
  - -> `[794]`

### Węzeł `[793]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[794]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[795]`
Mówca: **Sevrio Castellanus**
> ""This shall stay between us, Your Majesty. The other Wruhec's Guardians don't have to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[797]`
Mówca: **Narrator**
> "Sevrio bowed and followed Sal out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[798]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`
  - -> `[800]`

### Węzeł `[799]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[801]`
Mówca: **Narrator**
> "Sevrio turned to me, seemingly in a daze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[802]`
Mówca: **Sevrio Castellanus**
> ""He was my teacher. My mentor. And all this time, he was a fraud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[803]`
Mówca: **Narrator**
> "He violently tore off the gold chain that was hanging around his neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[804]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians were built on a foundation of lies. We must disband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[805]`
Mówca: **Sevrio Castellanus**
> ""It has been an honor serving you, Your Majesty. Despite everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`
  - -> `[808]`
  - -> `[809]`
  - -> `[810]`

### Węzeł `[806]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[807]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You still have the Wruhecist community's respect. I need you to make sure they weather this scandal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[808]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Sevrio. You're dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[809]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go with God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[810]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Sal gone, Rizia is in the market for a new Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[811]`
Mówca: **Sevrio Castellanus**
> ""I-- I could never. Not after this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[812]`
Mówca: **Sevrio Castellanus**
> ""Divus zaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[813]`
Mówca: **Sevrio Castellanus**
> ""I will talk to them. But I cannot promise they'll listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[814]`
Mówca: **Narrator**
> "He bowed his head and rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[815]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[816]`
Mówca: **Sevrio Castellanus**
> ""His guilt? What did he do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`
  - -> `[818]`
  - -> `[817]`

### Węzeł `[817]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing less than his duty. My father had to die so that Rizia could be reborn. The Grand Wiseman's actions were entirely justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[818]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As I said, this is all a misunderstanding. The Grand Wiseman is to be released immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[819]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father asked him to assist in the conduction of a sacred ritual. The fact that the ritual took his life is no fault of Sal's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[820]`
Mówca: **Narrator**
> "Sevrio's jaw dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigation_Continues = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigation_Continues = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[823]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested = true;
RiziaDLCSupport.News_Turn08_RH_SalArrested = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
RiziaDLC.PoisonInvestigation_Continues = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Sal_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_SalArrested"] = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[824]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Learning the truth behind their father’s death", "Dining Hall", "Palace Rezna");)*
- **Efekt (`userScript`):** `SetRichPresence("Learning the truth behind their father’s death","Dining Hall","Palace Rezna");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
