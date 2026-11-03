# Rizia/Turn 7/BFF Convo (Friendly)

- **ID konwersacji:** `390`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/390_BFF_Convo_(Friendly).md`
- **Liczba węzłów dialogowych:** 106
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[92]** Beatrice Livingston (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Rumburg_Hostile`
- `RiziaDLC.CountryRelation_Rumburg_Unfriendly`
- `RiziaDLC.Diplomacy_Wehlen_AgreementRefused`
- `RiziaDLC.Policy_Law_GolcondistBlasphemy`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Wehlen_FundBFF`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Zille_ViolentResistancePower`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[389] Rizia/Turn 7/FPnT_RumburgMeeting** (../Turn_07/389_FPnT_RumburgMeeting.md), Węzeł `[1370]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 2

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Zille_ViolentResistancePower`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[97]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePow...`

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
  - -> `[76]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `389` (*Rizia/Turn 7/FPnT_RumburgMeeting*), Węzeł `[1370]`

### Węzeł `[3]`
Mówca: **Beatrice Livingston (R)**
> ""I suggest that you take advantage of Rumburg's contacts within the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[10]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Bluds? But they're terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those Golcondists? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? Of course I welcome the opportunity to assist devout Wruhecists in need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't see how that will help us in any way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Beatrice Livingston (R)**
> ""It's simple, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""As loathe as I am to suggest violence as a solution to the Zille conundrum...  an internal resistance effort from the BFF could work in perfect concert with the Derdian mercenaries already present in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[33]`
  - -> `[91]`

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""I am still loathe to suggest violence as a solution to the Zille conundrum. But in the absence of an agreement with President Smolak, an internal resistance might be our last hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[27]`
  - -> `[33]`
  - -> `[91]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Laurento Esquibel**
> ""I am loathe to suggest violence as a solution to the Zille conundrum. Especially since Wehlen may yet return the region through diplomatic means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[33]`
  - -> `[91]`

### Węzeł `[21]`
Mówca: **Beatrice Livingston (R)**
> ""They are a persecuted minority fighting an oppressive government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Beatrice Livingston (R)**
> ""And they, in turn, can assist you in the reclamation of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[23]`
Mówca: **Beatrice Livingston (R)**
> ""And their struggle can, conveniently, be channeled towards Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[24]`
Mówca: **Beatrice Livingston (R)**
> ""Try to see past their religion and empathize with their struggle against the Wehzek government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Beatrice Livingston (R)**
> ""A struggle that can, conveniently, be channeled towards Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want the BFF getting in the way of our existing resistance plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The BFF would be active in Zille sooner or later, anyway. We'd just be giving them a nudge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The BFF have their own fight going on. I don't want to interfere with it one way or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we funded the BFF and Smolak found out about it, he'd have an excuse to hold on to Zille forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do I get the feeling you're trying to use both Rizia and the BFF toward your own ends, Your Excellency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Beatrice Livingston (R)**
> ""Don't be so cynical. I see an opportunity for our interests to align. That's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[43]`

### Węzeł `[35]`
Mówca: **Beatrice Livingston (R)**
> ""And who would tell him? Do you run that leaky of a ship, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[43]`

### Węzeł `[36]`
Mówca: **Beatrice Livingston (R)**
> ""Suit yourself, Your Majesty. It was just a suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[37]`
Mówca: **Beatrice Livingston (R)**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[43]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No... I don't like this. We'll figure out another way to retake Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Beatrice Livingston (R)**
> ""Ah, well. I don't know what else is happening in Zille. I merely saw an opportunity for our interests to align.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[43]`

### Węzeł `[40]`
Mówca: **Beatrice Livingston (R)**
> ""The BFF only exists due to foreign powers interfering in Bludia. It's only right that we help them tip the scales in the other direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""You don't have to twist my arm, Your Excellency. I'll fund the Bludish Freedom Front, if you can promise me they'll help us 'liberate' Zille." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""You don't have to twist my arm, Your Excellency. I'll fund the Bludish Freedom Front, if you can promise me they'll help us 'liberate' Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot agree to this plan in good conscience. I'll be damned to hell before I help Golcondist sinners spread their twisted gospel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd love to agree to this. But I don't have the budget for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[47]`
Mówca: **Beatrice Livingston (R)**
> ""Oh, my.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Beatrice Livingston (R)**
> ""I knew you were taking Rizia in a more religious direction, but to hear such zealotry with my own ears...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[54]`
  - -> `[56]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zealotry? I am telling the objective truth. If you could only look beyond the narrow worldview of St. Dast, you would agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[50]`
Mówca: **Beatrice Livingston (R)**
> ""Up to this point, we have been aiding the Bluds' liberation efforts in the north of Wehlen. But I see no reason why their struggle can't be directed southward as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_GolcondistBlasphemy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should consider the same, Your Excellency. Your secularization reforms will lead Rumburg to ruin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[55]`
Mówca: **Laurento Esquibel**
> ""If I may, Your Excellency... Zille has nothing to do with the former Greater Bludia region. Why would the BFF get involved there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not too late for you to embrace Wruhecism either, Beatrice. Your sister was so happy after she saw the light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Beatrice Livingston (R)**
> ""My sister despised your silly religion almost as much as she despised you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Beatrice Livingston (R)**
> ""My sister was happy with you. Wruhecism had nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Beatrice Livingston (R)**
> ""I... I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[63]`
Mówca: **Beatrice Livingston (R)**
> ""As valuable as religion is to me personally, it must be separated from the state if my nation is to be taken seriously. I'm surprised Mr. Esquibel hasn't told you the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Laurento Esquibel**
> ""Rizia's religious governance is between the King and our Grand Wiseman. I wouldn't presume to have a say in such matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Laurento's face flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Laurento Esquibel**
> ""The King has turned down your offer, Your Excellency. No need to bring up personal matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Laurento grew indignant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[68]`
Mówca: **Beatrice Livingston (R)**
> ""You have established Rizia as a safe haven for their so-called religion. Besides which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Beatrice Livingston (R)**
> ""You have shown yourself to be no great friend to Wiktor Smolak. Besides which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Beatrice Livingston (R)**
> ""Any action that destabilizes the Smolak regime will help the Bludish cause, no matter where it is carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Laurento pondered over this for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[75]`
Mówca: **Laurento Esquibel**
> ""His Majesty has turned down your offer. Let's leave it at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[76]`
Mówca: **Narrator**
> "She leaned forward and spoke confidentially."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Beatrice Livingston (R)**
> ""I suggest that you assist Rumburg in funding the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[10]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have a chance to get Zille back fair and square. If that fails, you might hear from me again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Beatrice Livingston (R)**
> ""Then we'll have to leave it be. Rizia must ante up to have a stake in this game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[89]`
Mówca: **Beatrice Livingston (R)**
> ""I cannot control their actions completely, of course. But as I said, I will do my very best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[90]`
Mówca: **Beatrice Livingston (R)**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false && RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false && RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false && RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Her face contorted into a snarl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Laurento hurriedly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Laurento Esquibel**
> ""Your Excellency, the King has turned down your offer. Perhaps it's best to leave it at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to twist my arm, Your Excellency. I want the BFF's help in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Beatrice Livingston (R)**
> ""Then you shall have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Diplomacy_Wehlen_FundBFF = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Laurento coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[102]`
Mówca: **Laurento Esquibel**
> ""At any rate, Your Excellency, thank you for this offer. And for entrusting us with such sensitive information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Beatrice Livingston (R)**
> ""Why, certainly. What are allies for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Beatrice still looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Beatrice Livingston (R)**
> ""It is a dangerous road you are traveling, Romus. I do not know how much further Rumburg can accompany you down it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
