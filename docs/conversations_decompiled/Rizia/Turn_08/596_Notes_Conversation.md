# Rizia/Turn 8/Notes/Notes Conversation

- **ID konwersacji:** `596`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/596_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 136
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[77]** Wiktor Smolak (R)
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF`
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan`
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2`
- `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2`
- `RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints`

### Skoki między-konwersacyjne:
- Węzeł `[25]` -> **[424] Rizia/Turn 8/FPnT_ZilleNegotiations** (../Turn_08/424_FPnT_ZilleNegotiations.md), Węzeł `[1173]`
- Węzeł `[26]` -> **[424] Rizia/Turn 8/FPnT_ZilleNegotiations** (../Turn_08/424_FPnT_ZilleNegotiations.md), Węzeł `[632]`
- Węzeł `[72]` -> **[424] Rizia/Turn 8/FPnT_ZilleNegotiations** (../Turn_08/424_FPnT_ZilleNegotiations.md), Węzeł `[484]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 26
- **Węzły modyfikujące stan gry:** 3

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2`
- `RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2"] = true;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2"] = true;`
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] = true; Variable["RiziaDLCIsolated....`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true && RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true && RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  and  Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true && RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  and  Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
Mówca: **Wiktor Smolak (R)**
> ""Can I count you to help Wehlen counter the Blushish threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[10]`
  - -> `[17]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. If it's gas imports you want, I'll make it happen. Even if it means taking a hit in the short term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but I cannot condone any form of oppression against the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought I made myself perfectly clear. I want nothing to do with your opression of the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, fine. If you're dead set on gas imports, I'll play along. But just know, we might end up taking a financial dip faster than a lead balloon -- or should I say lead *air ship*, given our present situation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Whatever it takes to get Zille back. What did you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[18]`
Mówca: **Wiktor Smolak (R)**
> ""Haha, well played, Your Majesty! It's good to see you haven't lost your sense of humor amidst all this serious talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[19]`
Mówca: **Wiktor Smolak (R)**
> ""Excellent! Your willingness to adapt to the situation is commendable, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
Mówca: **Wiktor Smolak (R)**
> ""That's unfortunate to hear. Well, if there's no changing your mind, then perhaps you'll agree to another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1 == true

))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Wiktor Smolak (R)**
> ""I'm quite disappointed by your unwillingness to compromise. In that case, I'm afraid that I have no choice but hold a referendum in Zille regarding the issue of reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Ref_Hub_2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `424` (*Rizia/Turn 8/FPnT_ZilleNegotiations*), Węzeł `[1173]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ZilleNeg_Hub_2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `424` (*Rizia/Turn 8/FPnT_ZilleNegotiations*), Węzeł `[632]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
Mówca: **Wiktor Smolak (R)**
> ""I'm glad you asked. Well for starters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
Mówca: **Wiktor Smolak (R)**
> ""Your decision not to ally with our anti-terrorist operations against the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[37]`
Mówca: **Wiktor Smolak (R)**
> ""And your decision to renig on your commitment to wiping out the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[41]`
Mówca: **Wiktor Smolak (R)**
> ""Agree to help us fight a common threat and you'll be one step closer to seeing Zille under the Rizian flag once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[42]`
Mówca: **Wiktor Smolak (R)**
> ""Assist in our efforts to combat the well-know terrorist group, the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Wiktor Smolak (R)**
> ""Ban Derdians from crossing into Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[44]`
Mówca: **Wiktor Smolak (R)**
> ""Agree to one or all of those proposals and you'll be one step closer to seeing Zille under the Rizian flag once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Wiktor Smolak (R)**
> ""Agree to one or all proposals, and I can assure that you'll be one step closer to seeing Zille under the Rizian flag once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Wiktor Smolak (R)**
> ""Well, seeing as how you never broke you promise to fight them because you never said you would in the first place, you could...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm willing to agree to only one of those proposals.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I can't do that. The issue is too sensitive. I'm not going to put myself in a politically dangerous position.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say no more. I agree to all of them, as long as you follow through as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Smolak's eyes went wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Wiktor Smolak (R)**
> ""This is excellent news! To be perfectly honestly, I wasn't sure I could convince you to agree to just one, let alone all three.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Wiktor Smolak (R)**
> ""Allowing Derdians free reign to cross into Rizia whenever they so choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[54]`
Mówca: **Wiktor Smolak (R)**
> ""There's the issue of Bludish migrants  still being allowed to cross your border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[61]`
Mówca: **Wiktor Smolak (R)**
> ""Stop Bludish migrants from crossing your borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == false && (RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == false && (RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == false  and  (Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == false && (RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == false  and  (Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you haven't given up on your crusades against the Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Wiktor Smolak (R)**
> ""That's like asking to give up our national security. The Bluds pose a constant threat, and we must remain vigilant in protecting our borders and our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 = true; RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] = true;
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints"] = Variable["RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[68]`
Mówca: **Wiktor Smolak (R)**
> ""As should you. They're just as much a threat to Rizia as they are to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[69]`
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, they are indeed a threat. But the political ramifications from the your conditions regarding this issue is too great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While Rizia has our own issues with the Bluds, their nothing compared to the yours, which is a result of your own making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""True. I can't argue with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ZilleNeg_Hub_1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `424` (*Rizia/Turn 8/FPnT_ZilleNegotiations*), Węzeł `[484]`

### Węzeł `[73]`
Mówca: **Narrator**
> "As the sun hung low in the sky, casting long shadows over the empty streets of Wraclawitz, our motorcade wound its way through the heart of Wehlen toward the presidential palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Historic buildings lined our path, their ornate facades a testament to the city's enduring legacy. Yet, despite their lavish appearance, it was clear that time had taken its toll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "At the behest of President Smolak, I had arrived here with the purpose of negotiating and sealing the agreement with him that would formally reunite Zille with Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Narrator**
> "However, Smolak was conspicuously absent. Upon my plane's landing, I was taken aback to find myself greeted not by President Smolak, but by an elaborate display of Wehlen soldiers standing in formation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Before long, the presidential palace came into view. But instead of turning towards the grand entrance, our convoy continued past it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[107]`
  - -> `[78]`
  - -> `[106]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Titus, what's the meaning of this? Why aren't we heading to the palace as planned?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Titus Gordion**
> "“I'll find out, Your Majesty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Titus reached for his handheld radio and contacted the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Titus Gordion**
> "“This is Titus. Why are we not heading to the palace?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "A crackling response from the captain of our Wehzek security escort came through the radio, but it was too inaudible for me to discern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Titus Gordion**
> "“I’m sorry, Your Majesty. There’s apparently been a change of plans. President Smolak isn't at the palace. We're to meet him elsewhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[103]`
  - -> `[84]`
  - -> `[102]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“’Elsewhere?’ Where?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "The convoy pulled up to an airfield on the outskirts of the palace grounds, and to my astonishment, a colossal airship awaited me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Its sleek form dominated the skyline, with President Smolak's giant image emblazoned on its side, accompanied by the flag of Wehlen along with a bold proclamations of Wehlen's ascent:"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Narrator**
> "“With Smolak at the Helm: Wehlen Rises, Soaring to New Heights!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[98]`
  - -> `[88]`
  - -> `[105]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Well, this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "If the red carpet stretching from my vehicle to the stairs leading to the airship’s gondola wasn’t a blatant indicator of where I could find Smolak, nothing was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Before long, I exited the vehicle and made my way down toward the airship, escorted by Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "It wasn’t until I neared the stairs that I noticed at least a dozen or more attractive young women in impeccably pressed uniforms flanked on either side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[100]`
  - -> `[92]`
  - -> `[97]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“It appears Smolak has a keen eye for... *talent*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Titus Gordion**
> "“If by ‘talent’ you mean pretty faces in crisp uniforms, then yes. A keen eye, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Stepping inside, the interior of the ship was adorned with lavish blue and white drapes cascading from floor-to-ceiling windows. Plush magenta seats line the cabin, each embellished with opulent tassels and cushions embroidered with the Wehlen crest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "And crystal chandeliers hung from the ceiling, casting a dazzling array of light across the space."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "The gondola cabin practically screamed excess, to the point of absurdity."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man's got his very own private blimp... why am I not surprised?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Looks like Smolak's crew selection process involves a very specific type.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
Mówca: **Narrator**
> "Smolak wiped his eyes, thought whether or not it was in jest was unclear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[112]`
  - -> `[110]`
  - -> `[114]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How fortuitous that today, of all days, you chose to watch that specific film.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Wiktor Smolak (R)**
> "“Oh, Your Majesty! Fancy seeing you here."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
Mówca: **Narrator**
> "One of the crew members led us to a room where Smolak was waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "I stepped into total blackness, with the only light coming from black and white images being projected onto a screen. Smolak apparently his own private movie theater onboard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "And there, sitting amongst the twenty or so seats, was the President of Wehlen. He was eating popcorn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[132]`
  - -> `[118]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "He turned to me and held a finger to his mouth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Wiktor Smolak (R)**
> "“Shhh! This is the best part!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I immediately recognize it as the Wehlen propaganda film, "From Here to Zille" a dramatized version of the 1926 Uprising."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Narrator**
> "In it, Wehlen soldiers are portrayed as valiant heroes, while the Rizian forces appear bumbling and ineffectual -- highly controversial, to say the least."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "In the scene I was currently watching, a frightened Rizian solider stood before a firing squad, his fate seemingly sealed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Wiktor Smolak (R)**
> "“Here it comes!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Narrator**
> "But just as the guns are about to fire, a machine gun erupts, mowing down the entire firing squad. The Rizian turns to see a Wehlen soldier standing over him, bathed in sunlight like a divine savior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Smolak began speaking along with the actors on the screen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Wiktor Smolak (R)**
> "“’Behold the might of Wehlen! Our noble soldiers, defenders of justice and champions of the weak! We come to the aid of our Rizian brethren, ensuring peace and prosperity for all under the glorious banner of Wehlen!’""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "The young solider thanked the Wehles soldier, exclaiming that he was forever in his debt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Soon after, the music swelled and the credits began to roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Wiktor Smolak (R)**
> "“Every time... gets me right in the feelings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Narrator**
> "The lights came up, and it was then that I noticed a baby, who couldn’t have been more than a year old, happily sitting next to Smolak."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is someone there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Smolak, is that you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[134]`
Mówca: **Wiktor Smolak (R)**
> "“But come, let us take our leave so we can talk somewhere more comfortably.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Smolak, still holding his bag of popcorn, picked up little Wiktor in his free hand and left the room. I followed after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "We reentered the observation deck, where I was, once again, greeted by extravagance."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
