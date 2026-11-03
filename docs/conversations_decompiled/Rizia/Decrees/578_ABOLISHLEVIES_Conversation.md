# Rizia/ABOLISHLEVIES/ABOLISHLEVIES Conversation

- **ID konwersacji:** `578`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (ABOLISHLEVIES)`
- **Lokalizacja pliku:** `Rizia/Decrees/578_ABOLISHLEVIES_Conversation.md`
- **Liczba węzłów dialogowych:** 157
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Dead`
- `RiziaDLC.Army_Unit_Sazon_Dead`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_DeclareIntention_WeakStatement`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.War_Objective_Captured_Pales`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`
- `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports`
- `RiziaDLCSetup.CurrentStep`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`
- `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[51]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 3

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[116]` (Paskal Beniwoll): `EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevies");`
- Węzeł `[152]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- Węzeł `[153]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] = true;`

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
  - -> `[147]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `356` (*Rizia/CouncilRoyalDecrees*), Węzeł `[51]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""The provincial levies have existed for centuries, tied to the authority of the royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""To dismantle them is to upend the internal balance of our kingdom itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The levies are relics of feudalism. How can we claim to be united under one crown when the provinces hold the means to defy us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am aware of what this decree entails, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly what I'm aiming to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, Hugo. Tell me what's on your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""I understand the logic, Romus. Centralizing the military under the crown would give you unmatched control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""I understand the logic, Romus. Centralizing the military under the crown would standardize our forces and stop the Houses from using their levies to threaten the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""But if House Toras stands firm and the others remain manageable, then perhaps this is the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[64]`
  - -> `[65]`
  - -> `[91]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""But you must consider the ripples this will send through the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""But to push this now, when we’re so fragile... It is madness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""The kingdom is already teetering. Unrest brews in the cities, and the whispers of revolution are growing louder than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""We need the Houses' full cooperation to get this dissent under control, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[106]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""This decree risks tearing the kingdom apart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[72]`
  - -> `[92]`
  - -> `[78]`
  - -> `[74]`
  - -> `[106]`

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""The provincial levies are the backbone of our manpower. To dissolve them now would cripple our forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""But to push this now, while we're at war with Pales... It makes no sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""The kingdom is already teetering. Unrest is brewing in the cities, and we're already fighting a war with the very levies you're trying to abolish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "I'm aware, Hugo. I expect resistance already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't about weakening them. It's about strengthening the kingdom as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do you suggest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They can try to resist all they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.CurrentTurn < 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.CurrentTurn < 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.CurrentTurn"] < 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.CurrentTurn < 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.CurrentTurn"] < 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentStep <= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentStep <= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.CurrentTurn"] <= 9  and  Variable["RiziaDLCSetup.CurrentStep"] <= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentStep <= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.CurrentTurn"] <= 9  and  Variable["RiziaDLCSetup.CurrentStep"] <= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""This is a dangerous gamble so early in your reign, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""The unity you seek will mean nothing if our army is crushed by Pales again. Wait until the war is won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""This could be a dangerous gamble before overseeing the return of Zille, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""This is a dangerous gamble while our military is already in a weak shape, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""This could be a dangerous gamble, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Especially considering the already weakened state of our military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""The unity you seek will mean nothing if our kingdom falls. Wait until our immediate threats are dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. But what would you have me do? Allow this fractured system to continue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""You underestimate the danger. The houses may seem loyal now, but ordering the removal of their units will feel like a betrayal to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""I must counsel against this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[106]`
  - -> `[105]`

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""You underestimate the risk. This could unite the Houses against your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""And it could very well unite the Houses against your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, does House Toras stand firm, Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe this is the right time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""The royal houses have grown accustomed to their autonomy. Their levies are not just military forces; they're symbols of their power and the means to maintain their control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""To take them away will be seen as an attempt by the Crown to render them powerless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""And they will resist that perception fiercely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[39]`
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The levies are what's tearing the kingdom apart. The sooner I get rid of them, the faster unity will be restored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This will not weaken our forces, it will strengthen the central administration's ability to handle the situation more swiftly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're worrying too much. We will win this war in no time. We don't need the levies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo, but I have already decided to sign this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[84]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Terador == true || RiziaDLC.War_Objective_Captured_Pales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Terador == true || RiziaDLC.War_Objective_Captured_Pales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Terador == true || RiziaDLC.War_Objective_Captured_Pales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_Sazon_Dead > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_Sazon_Dead > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0  and  Variable["RiziaDLC.Army_Unit_Sazon_Dead"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_Sazon_Dead > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0  and  Variable["RiziaDLC.Army_Unit_Sazon_Dead"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Azaro and Sazon's elite divisions have already been mostly destroyed. This is the perfect time to sign this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about the war. I'll make sure this decree won't cripple our forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Then let's get to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More importantly, do I have your support?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. But what would you have me do? Allow this fractured system to continue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""Of course. As always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""I just want you to be careful, Romus. Keep the other Houses close to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Hugo Toras**
> ""I will do my best to support you in keeping them in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[67]`
  - -> `[89]`
  - -> `[90]`

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""If you sign that decree, I will do my best to support you in keeping the Houses in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[123]`
  - -> `[126]`
  - -> `[132]`

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""I just want you to be careful, Romus. Try to use persuasion, not force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[98]`
Mówca: **Narrator**
> "There was a brief silence. His eyes locked onto mine, calculating. Then, slowly, his gaze drifted downward, settling on the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""But if you are sure about passing it, I will not stand in your way. I'll trust your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[115]`
  - -> `[120]`
  - -> `[106]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""For now, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""We need the Houses' full cooperation to win this war, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[74]`
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're telling me to let this go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. I'll listen to your counsel, Hugo. I won't sign this decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[108]`
Mówca: **Narrator**
> "There was a brief silence. His eyes locked onto mine. Then, slowly, his gaze drifted downward, settling on the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""I'll let the others know about the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""You have all the time in your hands, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""Wait for a better time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[106]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm ready to take that gamble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[114]`
Mówca: **Hugo Toras**
> ""This could be a dangerous gamble, Your Majesty. I must still counsel against this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have no choice but to respect my decision, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevies");)*
- **Efekt (`userScript`):** `EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevies");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[117]`
Mówca: **Narrator**
> "I grabbed the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "Hugo's eyes were fixed on my hands as I placed my signature on the paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo, but I have already decided to sign this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""I understand, Your Majesty. Thank you for listening to my counsel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[129]`
  - -> `[128]`

### Węzeł `[122]`
Mówca: **Narrator**
> "His expression loosened slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sure, Hugo. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Then let's get to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I'm not making a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will see. That depends on their reaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will see. That depends on their reaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[136]`
Mówca: **Hugo Toras**
> ""You've already abolished the local police forces. Now you would deny the provinces their armies when they need them the most?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""But now that you've also removed their local police forces... If House Toras stands firm and the others remain manageable, perhaps this is the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[64]`
  - -> `[65]`
  - -> `[91]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Again with the Royal Houses, Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""I have to bring it up again since you're still trying to damage them openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""I don't know what you're thinking, Romus, but to dismantle this system is to upend the internal balance of our kingdom itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""I'm surprised you are now considering abolishing our provincial levies after our conversation about increasing them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_CounselIgnored += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
