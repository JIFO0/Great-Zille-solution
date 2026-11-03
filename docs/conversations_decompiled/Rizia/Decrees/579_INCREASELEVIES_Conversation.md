# Rizia/INCREASELEVIES/INCREASELEVIES Conversation

- **ID konwersacji:** `579`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (INCREASELEVIES)`
- **Lokalizacja pliku:** `Rizia/Decrees/579_INCREASELEVIES_Conversation.md`
- **Liczba węzłów dialogowych:** 139
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Said_Halaita`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[52]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[49]` (Paskal Beniwoll): `--;`
- Węzeł `[93]` (Paskal Beniwoll): `EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLevies");`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- Węzeł `[120]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- Węzeł `[135]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- Węzeł `[138]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `356` (*Rizia/CouncilRoyalDecrees*), Węzeł `[52]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""I've heard that you're calling for an increase in the levy obligations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[8]`
  - -> `[9]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not just an increase. A doubling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. It's time the provinces contribute their fair share of soldiers and resources for the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[6]`
Mówca: **Hugo Toras**
> ""That may be the intent, but you're also giving the noble houses more leverage than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""There's no denying that a stronger army is an asset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know it is risky to give the Houses more power, but it's a necessary compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo. You heard it right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[10]`
Mówca: **Narrator**
> "He leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Especially given our current circumstances as the weakest military power in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Especially given that all our neighbors possess stronger militaries than ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""But I hope you considered in detail what this will mean for the royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[35]`
  - -> `[33]`
  - -> `[39]`
  - -> `[89]`
  - -> `[36]`
  - -> `[131]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The houses have always provided troops. If anything, more soldiers will ensure that every region is prepared should the kingdom face a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""And I understand this could also be helpful against the unrest we're facing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""There's no denying we need a stronger force to end the Pales invasion quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""If you're certain these forces would make a difference in the ground operations, this would be the right call. We need numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I'm just going with my gut here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""Then take the time to consider it, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to *consider* what's already obvious. The houses will grumble, they always do. But they will comply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""Doubling their forces will double their influence as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More soldiers mean stronger houses, but it also means they are more dependent on the Crown. If they want to keep their new forces, they'll need to stay in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will make them more loyal in the long run. This is both their burden and their reward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Hugo narrowed his eyes, seemingly unimpressed by my sarcasm. A forceful smile appeared on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""Ah, of course! Who needs a Grand Vizier when one has intestines?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[51]`
  - -> `[50]`
  - -> `[52]`
  - -> `[90]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""There's a fine line between grumbling and resisting, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""Will they, now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Handing each of these houses twice the number of soldiers under their personal command only empowers them to do the opposite of 'falling in line.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""Handing each of these houses twice the number of soldiers under their personal command is the very thing that could make 'grumbling' turn into something far worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do you propose, Uncle? That we keep our forces weak? That the House armies stay tiny and underequipped while threats gather on our borders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You believe this decree could weaken the monarchy in the long run?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might be right. If they try to use their troops as their personal armies rather than the kingdom's forces, then we'll have a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[47]`
  - -> `[46]`
  - -> `[112]`
  - -> `[122]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Naturally. Strategic foresight is overrated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do pride myself on efficiency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I assume you came here for something other than dramatic irony, Uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""I'm not here to question your authority. But I must remind you that this decree doesn't only increase our forces. It shifts power in ways we can't control once the ink is dry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""I'm only here to challenge you before your enemies do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""That depends on the Azaros and the Sazons. And on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Then the decree is completely justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Hugo blinked once, then exhaled slowly, pressing his lips together as if physically holding back a response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""You're the king, Romus. No one is saying you haven’t thought this through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""I will speak of this no more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""Say what you will. But the absence of fear has toppled more kings than I can count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I'm here to challenge you before your enemies do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""That is precisely why I am here. So you do not ignore the potential fallout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""Because once you give a man an army, the only thing stopping him from using it is whether he fears you enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[67]`
  - -> `[68]`
  - -> `[122]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I'll make sure they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I remove them before they get that chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the words, but fear won't hold a nation together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's too dramatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""No, but the absence of fear has toppled more kings than I can count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""You lose nothing by thinking twice, but you risk everything by acting too soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""The trouble with preemptive strikes, Romus, is that they teach others to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
Mówca: **Narrator**
> "I grabbed the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[106]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "Hugo's eyes were fixed on my hands as I placed my signature on the paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""I surely hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""But I understand the situation we're in. This decree will indeed be helpful with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""But I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[87]`
Mówca: **Narrator**
> "I grabbed the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""Look...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With all due respect, Hugo, I've already thought about this in detail and I'm aware of the potential consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your concerns, Hugo, but I am certain these forces would make a difference in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales won't be conquered easily with what we have now. The royal houses have the manpower. We should use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLevies");)*
- **Efekt (`userScript`):** `EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLevies");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""I'll let the others know about the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Hugo Toras**
> ""Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""I understand. Take your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you at dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Now I need a moment, if you'll excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""But I hope you considered in detail what this will mean for the royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[35]`
  - -> `[33]`
  - -> `[89]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""And I understand this could also be helpful against the unrest we're facing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""No. I propose you stop assuming their compliance is guaranteed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""Just be sure that when we win, these forces answer to you, not the Houses who command them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[110]`
  - -> `[125]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""Then by all means, sign the decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. Thank you for the advice, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No offense, Hugo, but I tire of your assumption that I haven't thought this through. Do you believe I draft decrees in a drunken stupor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to worry. I have no intention of letting the Houses walk over me. They may grumble, but they will comply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's think about that after I sign this decree and win the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand where you're coming from, but I am certain these forces are desperately needed for the war effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might be right. I've been focused on the war effort, but I haven't considered what happens after the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the provinces want to keep their new forces, they'll need to stay in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""I wouldn't have expected that after our discussion where you were considering abolishing the levies altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[130]`
Mówca: **Hugo Toras**
> ""I'm a little surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.CurrentTurn < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.CurrentTurn < 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.CurrentTurn < 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I have not. I am a mere instrument of God's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "Hugo narrowed his eyes, as if trying to determine whether I was serious. A forceful smile appeared on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Hugo Toras**
> ""Ah, of course! The pure, God-given instincts of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[51]`
  - -> `[50]`
  - -> `[90]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
