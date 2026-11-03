# Rizia/Turn 10/Notes/Notes Conversation

- **ID konwersacji:** `575`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/575_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 328
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Angelica`
- `RiziaDLC.Council_GrandVizier_Axel`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_GrandVizier_Sal`
- `RiziaDLC.Council_Treasury_Daria`
- `RiziaDLC.Council_Treasury_Rusty`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Policy_Diplomacy_ANMember`
- `RiziaDLC.Policy_Economy_ResourceBased`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Situation_Economy_Diversified`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Economy_Mixed`
- `RiziaDLC.Situation_Economy_NewBusiness_Collapse`
- `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth`
- `RiziaDLC.Situation_Welfare_LivingStandards_Acceptable`
- `RiziaDLC.Situation_Welfare_LivingStandards_Average`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.NewGov_Geopolitics`
- `RiziaDLCIsolated.NewGov_Goverment`
- `RiziaDLCIsolated.NewGov_Pales`
- `RiziaDLCIsolated.NewGov_Zille`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.NewGov_ForeignAffairs`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 39
- **Węzły modyfikujące stan gry:** 4

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[7]` (Paskal Beniwoll): `--;`
- Węzeł `[41]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`
- Węzeł `[81]` (Paskal Beniwoll): `--;`
- Węzeł `[257]` (Paskal Beniwoll): `--;`

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
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, more paperwork. How delightful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. We shall retire to my study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. Let’s go through them together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[5]`
  - -> `[4]`
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Angelica opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[9]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Lucita followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[10]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Angelica followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[11]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Sal followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[12]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Hugo followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[13]`
Mówca: **Narrator**
> ""With one last glance at the butterflies, I stepped inside. Axel followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I took a moment to scan the contents, considering where to begin."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""So where would you like to begin today? Affairs abroad or governance at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[28]`
Mówca: **Sal Ignacius**
> ""Where would you like to begin today, Your Majesty? Foreign affairs or domestic matters?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[29]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Lucita opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
Mówca: **Axel Reinhart**
> ""Where would you like to begin today, Your Majesty? Affairs abroad or matters at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[31]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Axel opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[32]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Sal opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[33]`
Mówca: **Narrator**
> "When we reached the study, we sat down, and Hugo opened the folder, laying the reports out on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""Where would you like to begin today, Your Majesty? Affairs abroad or matters at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[35]`
Mówca: **Angelica Sazon**
> ""Shall we begin with matters beyond our borders or those within them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[36]`
Mówca: **Lucita Azaro**
> ""Where would you like to begin today, Romus? Affairs abroad or matters at home?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's begin with foreign affairs.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_ForeignAffairs = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[54]`
Mówca: **Axel Reinhart**
> ""Yes, of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[55]`
Mówca: **Angelica Sazon**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[57]`
Mówca: **Sal Ignacius**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""Most certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Very well, Your Majesty""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_ANMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We stand alone now. I only hope we stand strong enough.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a tragedy -- to rule ourselves without permission.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God’s will is not debated in foreign halls.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia bows to no one. This was the only path forward.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh no, the AN misses us? They should've thought of that before trying to leash us."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have shut the door behind us. I only hope we haven't locked ourselves inside.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[69]`
  - -> `[70]`
  - -> `[77]`
  - -> `[80]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_ANMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Axel Reinhart**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Axel Reinhart**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Axel Reinhart**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[88]`
Mówca: **Sal Ignacius**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_ANMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_ANMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
Mówca: **Angelica Sazon**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Sal Ignacius**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[97]`
Mówca: **Angelica Sazon**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[98]`
Mówca: **Angelica Sazon**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[99]`
Mówca: **Sal Ignacius**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_ANMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_ANMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_ANMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""I’d like to begin by addressing our decision to leave the AN. It goes without saying that our absence has been clearly noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""As expected, leaving has isolated us on the world stage and weakened our ability to influence global decisions on security and trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""However, it has reduced the risk of foreign influence and strengthened our diplomatic flexibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[106]`
Mówca: **Ovid Grecer**
> ""With Zille's vast reserves of gold and oil now under Rizia’s control, I hereby declare the region a development project to harness its resources, transforming it into a hub of industry.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In celebration of Zille's return, I hereby declare that the Gulf of Moridia shall henceforth be known as the Gulf of Rizia.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To honor this occasion, I hereby order the removal of Smolak’s statues, which shall be unceremoniously cast into the Gulf of Rizia to form artificial reefs, fostering new life beneath the waves.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As part of 'The Great Resettlement,' I hereby offer thousands of loyal Rizian families generous incentives to relocate to Zille and help build our future.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIsolated.NewGov_Intermerkopum == true || RiziaDLCIsolated.NewGov_GRACE == true || RiziaDLCIsolated.NewGov_Goverment == true || RiziaDLCIsolated.NewGov_Zille == true || RiziaDLCIsolated.NewGov_Pales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIsolated.NewGov_Intermerkopum == true || RiziaDLCIsolated.NewGov_GRACE == true || RiziaDLCIsolated.NewGov_Goverment == true || RiziaDLCIsolated.NewGov_Zille == true || RiziaDLCIsolated.NewGov_Pales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Geopolitics"] == true  or  RiziaDLCIsolated.NewGov_Intermerkopum == true  or  RiziaDLCIsolated.NewGov_GRACE == true  or  Variable["RiziaDLCIsolated.NewGov_Goverment"] == true  or  Variable["RiziaDLCIsolated.NewGov_Zille"] == true  or  Variable["RiziaDLCIsolated.NewGov_Pales"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Geopolitics == true || RiziaDLCIsolated.NewGov_Intermerkopum == true || RiziaDLCIsolated.NewGov_GRACE == true || RiziaDLCIsolated.NewGov_Goverment == true || RiziaDLCIsolated.NewGov_Zille == true || RiziaDLCIsolated.NewGov_Pales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Geopolitics"] == true  or  RiziaDLCIsolated.NewGov_Intermerkopum == true  or  RiziaDLCIsolated.NewGov_GRACE == true  or  Variable["RiziaDLCIsolated.NewGov_Goverment"] == true  or  Variable["RiziaDLCIsolated.NewGov_Zille"] == true  or  Variable["RiziaDLCIsolated.NewGov_Pales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
Mówca: **Narrator**
> ""Living standards remain excellent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[114]`
Mówca: **Narrator**
> ""Living standards are good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[115]`
Mówca: **Narrator**
> ""The latest report on living conditions indicates stability across the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[116]`
Mówca: **Narrator**
> ""The latest report on living conditions indicates stability across the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[117]`
Mówca: **Narrator**
> ""Living standards have worsened significantly, with families crammed into dilapidated homes or forced into homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[118]`
Mówca: **Narrator**
> ""Living standards have deteriorated severely, with families crammed into crumbling homes or simply becoming homeless altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[119]`
Mówca: **Narrator**
> ""As for new businesses, they are flourishing, with a surge of small retail shops, diners, local factories, and service providers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[120]`
Mówca: **Narrator**
> ""As for new businesses, they are growing steadily, from neighborhood stores to family-run restaurants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[121]`
Mówca: **Narrator**
> ""As for new businesses, their numbers are dwindling due to rising costs and limited access to credit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[122]`
Mówca: **Narrator**
> ""As for new businesses, their numbers have plummeted, with most startups closing due to unaffordable rents, lack of capital, and stiff competition from established firms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[123]`
Mówca: **Narrator**
> ""Rizia's economy is robust and diverse, combining energy production with growing sectors like manufacturing, services, and technology, providing a solid foundation for future growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[124]`
Mówca: **Narrator**
> ""Rizia's economy is a balanced mix of energy resources, manufacturing, and agricultural sectors, providing steady growth, diversified income streams, and a strong foundation for future development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[125]`
Mówca: **Narrator**
> ""The economy is heavily dependent on energy resources, which dominate the market, providing substantial revenue and infrastructure development, though it leaves the kingdom vulnerable to global energy price fluctuations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[126]`
Mówca: **Narrator**
> ""The Crown's overwhelmingly pro-business stance has fueled rapid economic growth and industry expansion, though critics argue it has concentrated wealth and influence into the hands of a powerful few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[127]`
Mówca: **Narrator**
> ""Overall, the energy crisis persists unabated, crippling industrial operational potential and stalling economic growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[128]`
Mówca: **Narrator**
> ""In terms of budget, the government's substantial reserves and investment capacity ensure financial stability and room for growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[129]`
Mówca: **Narrator**
> ""In terms of budget, the government's reserves remain balanced with moderate growth, allowing for some investments while maintaining fiscal responsibility, though there's little room for excess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[130]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing constraints, with limited resources and a focus on necessary expenses, making it difficult to fund larger projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[131]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing a deficit, requiring significant borrowing to cover essential costs and raising concerns about long-term financial stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[132]`
Mówca: **Narrator**
> ""Lastly, our energy revenue is booming, providing a robust financial foundation for the nation, fueling large-scale development and global influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[133]`
Mówca: **Narrator**
> ""Lastly, our energy income remains steady, supporting essential programs and investments, though it doesn't provide the extra cushion for expansive ventures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[134]`
Mówca: **Narrator**
> ""Lastly, our country's energy sector is underperforming, resulting in a tight budget with limited capacity for reinvestment or innovation in the sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[135]`
Mówca: **Narrator**
> ""Lastly, our energy resources are failing to generate meaningful revenue, leaving the government in a precarious financial position with increasing reliance on external sources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Diversified == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Diversified == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Diversified"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Diversified == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Diversified"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Mixed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Mixed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Mixed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_ResourceBased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_ResourceBased == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_ResourceBased == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 8)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_ProBusiness < 8))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "Economy and Energy."]** — Mówca: **Player_Romus_Italic**
> "I picked up the report related to the economy and energy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Goverment == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Goverment == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Goverment"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Goverment == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Goverment"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
Mówca: **Narrator**
> ""Over 70% of Rizians own televisions, approximately half of all homes have air conditioning, and personal cars are so common that weekend getaways and dining out have become routine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[210]`
Mówca: **Narrator**
> ""Over 50% of Rizians own televisions, many households have air conditioning, and personal cars are becoming more common, making weekend trips and dining out a regular luxury for many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[211]`
Mówca: **Narrator**
> ""Standards remain largely unchanged from when you first ascended the throne -- neither great strides nor sharp declines, but a steady course nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[212]`
Mówca: **Narrator**
> ""Standards remain largely unchanged from when you first ascended the throne -- neither great strides nor sharp declines, but a steady course nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[213]`
Mówca: **Narrator**
> ""Water shortages are now commonplace, food prices have risen to unaffordable levels for many, and struggling clinics along with dwindling classrooms offer little hope for improvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[214]`
Mówca: **Narrator**
> ""Increased demand and accessible loans have fueled this growth, creating thousands of new jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[215]`
Mówca: **Narrator**
> ""However, many struggle to expand, facing competition from established chains and high operating costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[216]`
Mówca: **Narrator**
> ""Because of this, many entrepreneurs are forced to close their doors, with only a few surviving in niche markets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[217]`
Mówca: **Narrator**
> ""This has led to numerous empty storefronts across the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[218]`
Mówca: **Narrator**
> ""Water shortages have become routine, food prices have soared beyond reach for many, and failing clinics and emptying classrooms leave little hope for relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Goverment == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Goverment == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Goverment"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Goverment == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Goverment"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
**[WYBÓR GRACZA: "Living Standards and New Business."]** — Mówca: **Player_Romus_Italic**
> "I picked up the report related to living standards and new business."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_EnergyModifiersTotal <= 1) || (RiziaDLC.Resources_Energy >= 4 && RiziaDLC.Resources_Energy <= 5 && RiziaDLC.Resources_EnergyModifiersTotal <= -4))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_EnergyModifiersTotal <= 1) || (RiziaDLC.Resources_Energy >= 4 && RiziaDLC.Resources_Energy <= 5 && RiziaDLC.Resources_EnergyModifiersTotal <= -4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] <= 2  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1)  or  (Variable["RiziaDLC.Resources_Energy"] >= 4  and  Variable["RiziaDLC.Resources_Energy"] <= 5  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= -4)`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Resources_Energy <= 2 && RiziaDLC.Resources_EnergyModifiersTotal <= 1) || (RiziaDLC.Resources_Energy >= 4 && RiziaDLC.Resources_Energy <= 5 && RiziaDLC.Resources_EnergyModifiersTotal <= -4)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Resources_Energy"] <= 2  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1)  or  (Variable["RiziaDLC.Resources_Energy"] >= 4  and  Variable["RiziaDLC.Resources_Energy"] <= 5  and  Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= -4)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Daria de Rava, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Treasury_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[230]`
Mówca: **Narrator**
> ""That wraps up the report. Signed, Russello Montoro, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[231]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Elena Werner, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Daria de Rava, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Treasury_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Treasury_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Treasury_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Treasury_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Treasury_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Treasury_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[242]`
Mówca: **Narrator**
> ""That wraps up the report. Signed, Russello Montoro, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[243]`
Mówca: **Narrator**
> ""This concludes the report. Signed, Elena Werner, Councilor of the Treasury and Economics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[244]`
Mówca: **Narrator**
> ""In terms of budget, the government's substantial reserves and investment capacity ensure financial stability and room for growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
Mówca: **Narrator**
> ""In terms of budget, the government's reserves remain balanced with moderate growth, allowing for some investments while maintaining fiscal responsibility, though there's little room for excess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[246]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing constraints, with limited resources and a focus on necessary expenses, making it difficult to fund larger projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[247]`
Mówca: **Narrator**
> ""In terms of the budget, the government is facing a deficit, requiring significant borrowing to cover essential costs and raising concerns about long-term financial stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModifiersTotal >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModifiersTotal >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] + Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget + RiziaDLC.Resources_BudgetModifiersTotal >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] + Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[261]`
Mówca: **Adarfo Sotelato**
> ""The House of Lords will begin its duties after the elections, though I doubt it will be anything but a drawn-out affair as they settle into their self-important roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Adarfo Sotelato**
> ""The political appointments are nearing completion, with noble families, scholars, and former statesmen -- all the usual suspects -- being selected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[263]`
Mówca: **Adarfo Sotelato**
> ""Given that they’ll hold equal power over laws, we can expect delays and complications as these 'blue bloods' bicker over every little detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is constructed, they’ll gather in the Grand Assembly Hall.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Adarfo Sotelato**
> ""With their limited power, we shouldn't face much resistance in passing legislation, though they'll still likely try to meddle for the sake of appearances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[272]`
Mówca: **Adarfo Sotelato**
> ""Given their minimal influence on policy, we don’t expect much interference; their role will be little more than ceremonial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Adarfo Sotelato**
> ""Which, if you ask me, is still far more than they deserve. Nevertheless""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""The formation of the Regional Senate is well underway, with candidates actively preparing for the upcoming elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Manus Sazon**
*(Węzeł logiki narracyjnej: Manus Sazon: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[276]`
Mówca: **Manus Sazon**
> ""Given the Senate's equal authority to the lower chamber, we should expect longer debates and potential gridlock once established, as regional interests clash with national priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""Nevertheless, until the new legislative building is finished, they’ll convene in the Grand Assembly Hall.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Manus Sazon**
> ""With their limited power, we shouldn't expect too many hurdles when passing new legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""However, given their limited power in shaping policy, we don’t expect much interference; their role will be more symbolic than impactful, as you well know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[292]`
Mówca: **Daria de Rava**
> ""Your Majesty, the House of Lords will commence its duties after the elections, ensuring a seamless transition as they assume their responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Daria de Rava**
> ""The political appointments are nearly finalized, with selections from noble families, scholars, and former statesmen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[294]`
Mówca: **Daria de Rava**
> ""Given their equal power in shaping laws, we are prepared for potential delays and complications from a lengthy negotiation process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Daria de Rava**
> ""Until the new legislative building is complete, they’ll convene in the Grand Assembly Hall.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Daria de Rava**
> ""With their limited power, we shouldn't face many obstacles when passing new legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[303]`
Mówca: **Daria de Rava**
> ""However, given their limited influence on policy, we don’t expect much interference; their role will remain largely symbolic, as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[304]`
Mówca: **Adarfo Sotelato**
> ""The political appointments are nearing completion, with noble families, scholars, and former statesmen -- all the usual suspects -- being selected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[308]`
Mówca: **Adarfo Sotelato**
> ""With their limited power, we shouldn't face much resistance in passing legislation, though they'll still likely try to meddle for the sake of appearances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is constructed, they’ll gather in the Grand Assembly Hall.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Adarfo Sotelato**
> ""However, given their minimal influence on policy, we don’t expect much interference; their role will be little more than ceremonial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[314]`
Mówca: **Adarfo Sotelato**
> ""Given that they’ll hold equal power over laws, we can expect delays and complications as these 'blue bloods' bicker over every little detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[315]`
Mówca: **Adarfo Sotelato**
> ""Your Majesty, the House of Lords will begin its duties after the elections, though I doubt it will be anything but a drawn-out affair as they settle into their self-important roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[316]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly what they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[317]`
Mówca: **Manus Sazon**
> "“Voter registration is progressing well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Manus Sazon**
> ""Participation is high in the cities, though some of the more remote regions have been slower to respond.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[325]`
Mówca: **Daria de Rava**
> "“Voter registration is moving forward, Your Majesty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Daria de Rava**
> "“Cities are seeing strong participation, though some of the more remote areas are slower to respond.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[327]`
Mówca: **Adarfo Sotelato**
> ""Voter registration is proceeding well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Adarfo Sotelato**
> ""Cities are seeing strong participation, however, the more remote areas have been slower to respond.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
