# Rizia/Turn 6/Intro Section

- **ID konwersacji:** `373`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/373_Intro_Section.md`
- **Liczba węzłów dialogowych:** 197
- **Liczba wyborów gracza:** 48

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Turn06_WarSpeech_EntireFamily`
- `RiziaDLC.Turn06_WarSpeech_Estela`
- `RiziaDLC.Turn06_WarSpeech_EstelaHugo`
- `RiziaDLC.Turn06_WarSpeech_Hugo`
- `RiziaDLC.Turn06_WarSpeech_RomusAlone`
- `RiziaDLC.Turn06_WarSpeech_Vina`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[372] Rizia/Turn 6/A_PalaceBalconySpeech** (../Turn_06/372_A_PalaceBalconySpeech.md), Węzeł `[458]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Turn06_WarSpeech_EntireFamily`
- `RiziaDLC.Turn06_WarSpeech_Estela`
- `RiziaDLC.Turn06_WarSpeech_EstelaHugo`
- `RiziaDLC.Turn06_WarSpeech_Hugo`
- `RiziaDLC.Turn06_WarSpeech_RomusAlone`
- `RiziaDLC.Turn06_WarSpeech_Vina`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[164]` (Paskal Beniwoll): `RemoveConversant("Estela Toras"); RemoveConversant("Vina Toras");`
- Węzeł `[167]` (Paskal Beniwoll): `RemoveConversant("Vina Toras");`
- Węzeł `[171]` (Paskal Beniwoll): `RemoveConversant("Hugo Toras"); RemoveConversant("Estela Toras"); RemoveConversant("Vina Toras");`
- Węzeł `[172]` (Paskal Beniwoll): `RemoveConversant("Hugo Toras"); RemoveConversant("Vina Toras"); ;`
- Węzeł `[178]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn06_WarSpeech_EstelaHugo"] = true;`
- Węzeł `[179]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] = true;`
- Węzeł `[180]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] = true;`
- Węzeł `[181]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] = true;`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `372` (*Rizia/Turn 6/A_PalaceBalconySpeech*), Węzeł `[458]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The moment was punctuated by the arrival of a member of the Golden Guard. He was wearing a ceremonial breastplate that gleamed under the room's warm lights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""War is a crucible. If you can face it head-on and survive, you will be unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`
  - -> `[31]`
  - -> `[42]`
  - -> `[9]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must also remember the toll conflict takes on our people. History should recall the hearts and spirits of those brave commoners sent to fight for their kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But what if it's all too much? What if I fail?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Lord is on our side. Our victory will not only be a testament to our strength but also to our faith and righteousness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Crucible' is a fitting word for it. I will lead our kingdom to battle with an iron fist. All will know Rizia's might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hoped it would never come to this. But if we must weather the storm of war, I shall do my best to steer Rizia through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[13]`
Mówca: **Vina Toras**
> ""Still, the people need compassion now more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[14]`
Mówca: **Estela Toras**
> ""If only historians shared your compassion, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[15]`
Mówca: **Estela Toras**
> ""You won't, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Estela Toras**
> ""Because you've learned from your predecessors' mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[20]`
Mówca: **Vina Toras**
> ""It's a heavy burden, but one that we'll share as a family. And as a nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[21]`
Mówca: **Vina Toras**
> ""It was your choice to go to war, Father. You've got to bear the burden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[25]`
Mówca: **Estela Toras**
> ""But it's the kings they pay attention to. Their triumphs -- and their failures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[29]`
Mówca: **Vina Toras**
> ""I wish I could've done more to prevent this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Next to him, my mother nodded silently. She looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[40]`
Mówca: **Vina Toras**
> ""Faith can sometimes misguide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[41]`
Mówca: **Vina Toras**
> ""Prayer won't help the death we're about to unleash, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
Mówca: **Estela Toras**
> ""Such ferocity, son. Save some for the populace out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[52]`
Mówca: **Vina Toras**
> ""We shouldn't charge headlong into battle. No one will be safe from the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[53]`
Mówca: **Vina Toras**
> ""The iron fist has never brought good things for our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[54]`
Mówca: **Estela Toras**
> ""Just be careful not to lose your own footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
Mówca: **Vina Toras**
> ""Calm and thoughtful leadership is what Rizia needs right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[62]`
Mówca: **Vina Toras**
> ""All these metaphors are making me seasick. I just hope history doesn't repeat itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Compassion is noble, but it must not overshadow the need for decisive action in times of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. If we lose our moral compass, then we lose everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Decisiveness is key. But I won't let it harden our kingdom's heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. It's up to me to make the tough but necessary decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Two and a half million people have gathered outside. Our entire police force is deployed for their safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""The Golden Guard will ensure the palace and its surroundings remain secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""I suspect it was always going to come to this, Your Highness. You shouldn't blame yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. You were lucky to get out of there alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything, it was my actions that led us to this point. But now that we've set ourselves on this path, we can't turn back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no use lamenting what could have been. We've got to concentrate on what comes next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""Your solidarity is admirable, Your Highness, but there are some decisions your father will have to make on his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[192]`
  - -> `[83]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""The mantle of leadership is a solitary one. But the choices you make will affect every living soul in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""We will not win this war without faith, Your Highness. But it must be combined with clear-headed strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""For as long as I live, our family will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""Strength is a tool, Your Highness. One that can be valuable if used judiciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[90]`
  - -> `[95]`

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""Precisely, Your Highness. We don't want our kingdom to be perceived as the aggressor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`
  - -> `[99]`

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""Facing Pales is our chance to correct past mistakes, not repeat them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`
  - -> `[96]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you nonetheless, Vina. I'll never turn away from the wisdom of my family and council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all part and parcel of being king. I was born to rule alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only I can protect our nation in these trying times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The weight of this war rests solely on me, a responsibility I must accept for Rizia's safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to defend our kingdom's sovereignty and future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our faith will bolster us, but our strategy against Pales will be pragmatic and calculated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is Rizia's destiny to reunite with Pales. If we pray enough, we will manifest our victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My head is clearer than it's ever been. I know God will show us the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We seek comfort in prayer, but our decisive actions will be what protects Rizia from the Palesian menace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Palesians brought this on themselves. They deserve all the destruction we can rain down on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Palesians have given us no choice, Vina. It's now or never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I swear on my own life that no harm shall befall the Toras family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We aren't bound by our past as we confront Pales. We will forge a new path for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our strength will be a shield, not a weapon of oppression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do what I must to protect our people. No matter how painful the decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our history with Pales is a guide. We'll use it to avoid repeating old errors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In war, we shall remain calm, our actions swift and decisive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But we don't want to be seen as weaklings, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Controlled strength. That's what I'm aiming for in this speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know exactly what my father did wrong. I'll never fall into the same traps he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't repeat history, we'll rewrite it. Starting today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""I have been outside. The atmosphere is tense, yet there's an undeniable sense of solidarity among our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""Look at how prepared we are, Madam Queen Mother. Our armies will not falter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[104]`
Mówca: **Estela Toras**
> ""I remember this feeling from all the way back in 1923. And I remember what happened next...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Estela Toras**
> ""Listen to me, Romus. We can't lose to Pales again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""We will learn and adapt from what happened back then. Our will shall guide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[116]`
Mówca: **Vina Toras**
> ""I just hope that less blood will be spilled than during the Reclamation War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""I just hope that we can find a peaceful resolution to this. Sooner rather than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
Mówca: **Narrator**
> "The rhythmic cadence of countless voices echoed outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""Pacifying the Palesian populace will lead to the least harm. That is our goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`
  - -> `[125]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""The Palesians don't want peace, Your Highness. Furthering the cycle of violence allows them to garner more support from their Lespian backers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`
  - -> `[128]`

### Węzeł `[121]`
Mówca: **Narrator**
> "He relayed to Hugo that all was prepared. The time had come to address the Kingdom, to define the future of Rizia at war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll aim to pacify Pales, but not at the expense of our humanity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pacification should not mean oppression. We'll ensure fairness in our approach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[124]`
Mówca: **Estela Toras**
> ""Choose your words carefully, son. This speech isn't just about the war; it's about rallying the Rizian people in the face of adversity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our goal is peace, but we must be ready for resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am confident that Duke Reinhart wants a swift end to the war, just as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are not going to fall into that trap. We'll choose the path of peace at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're facing a harsh reality. We must be ready for whatever violence comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[129]`
Mówca: **Estela Toras**
> ""Just don't forget that less-than-decisive action on our part risks drawing out the conflict further and losing more lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Mother. This speech is a call to unity, a reminder that we are stronger together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a chance to remind them what they'll be fighting for. What they'll be dying for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll use this speech to lift our people's spirits. Rizia will only win this war if they believe we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[133]`
Mówca: **Estela Toras**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""Everything has been prepared for you. Would you like any of us to be by your side on the balcony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[142]`
  - -> `[139]`
  - -> `[137]`
  - -> `[138]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are all family. I want you by my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Princess Vina represents the future. She should be with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our Queen Mother should be next to me to show that we survived the past tribulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should be with me, Hugo. As my uncle and my trusted second-in-command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[145]`
Mówca: **Hugo Toras**
> ""We stand with you, Romus. United, as a family should be in such times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[146]`
Mówca: **Estela Toras**
> ""*Completely* united. Right, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""Then together, the Royal Family shall present a united front to the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[148]`
Mówca: **Vina Toras**
> ""Father... I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""The entire division of the Golden Guard has been deployed, ensuring the city center is a safe zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother, Uncle, I want you both with me during this pivotal moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""Your father would be proud. We'll face this together, as we always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""It would be an honor to stand beside you, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[156]`
Mówca: **Estela Toras**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[157]`
Mówca: **Estela Toras**
> ""That's true. The lower the morale, the higher the casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[158]`
Mówca: **Estela Toras**
> ""As long as we don't get lost in the same darkness that Valero did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[159]`
Mówca: **Estela Toras**
> ""A swift end is great, as long as you're on the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This burden is mine to bear. I will make the speech alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Hugo Toras**
> ""We'll be with you in spirit, every step of the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[162]`
Mówca: **Estela Toras**
> ""Good luck out there. Don't forget to enunciate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[163]`
Mówca: **Vina Toras**
> ""Yes, Father. Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[165]`
Mówca: **Hugo Toras**
> ""Indeed. Queen Mother Estela shall remind the public of the history we have weathered together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[166]`
Mówca: **Estela Toras**
> ""If only Valero could be here to see the two of you together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[176]`
Mówca: **Vina Toras**
> ""Yes, good luck, Father. We'll be here if you need us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[177]`
Mówca: **Vina Toras**
> ""Yes, of course. It's my duty and my privilege to stand with the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_EstelaHugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_EstelaHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_RomusAlone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Estela = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_Hugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_WarSpeech_EntireFamily = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[185]`
Mówca: **Vina Toras**
> ""If that's what you want, so be it. I will stand with you, for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[189]`
Mówca: **Vina Toras**
> ""I'll stand with you. The people need to know their princess is with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[190]`
Mówca: **Narrator**
> "My mother put a firm hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[195]`
Mówca: **Narrator**
> "My mother kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[196]`
Mówca: **Estela Toras**
> ""In other words, I'm old. No need to sugar-coat it, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
