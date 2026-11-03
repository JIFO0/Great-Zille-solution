# Rizia/Turn 2/P_VinaAtMonqiz

- **ID konwersacji:** `300`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/300_P_VinaAtMonqiz.md`
- **Liczba węzłów dialogowych:** 568
- **Liczba wyborów gracza:** 155

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.Hugo_KnowsIntention`
- `RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative`
- `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_InBoatAccident`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_TookBookAway`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Security_ValeroPoisoningTalk_Happened`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Turn02_Intention_NoMonarchy`
- `RiziaDLC.Vina_PromisedQueen`
- `RiziaDLC.Vina_WarnedPossibleDisinheritance`
- `RiziaDLCSupport.Journal_Turn02_Pabel_Listened`
- `RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist`
- `RiziaDLCSupport.News_Turn02_G_SaveTheRiver`
- `RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis`
- `RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep`

### Skoki między-konwersacyjne:
- Węzeł `[179]` -> **[301] Rizia/Turn 2/Pabel Valero Poisoning Talk** (../Turn_02/301_Pabel_Valero_Poisoning_Talk.md), Węzeł `[1]`
- Węzeł `[349]` -> **[301] Rizia/Turn 2/Pabel Valero Poisoning Talk** (../Turn_02/301_Pabel_Valero_Poisoning_Talk.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 26

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Vina_WarnedPossibleDisinheritance`
- `RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[23]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[44]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1; Variable["RiziaDLC...`
- Węzeł `[46]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1; Variable["RiziaDLC...`
- Węzeł `[109]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[138]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[182]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- Węzeł `[192]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] = true;`
- *...oraz 18 innych węzłów ze skryptami.*

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
  - -> `[521]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was low tide. The waves of the Antacean Sea lapped at the sands below the cliffs of Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "A trail was carved into the cliffside, just wide enough for a single horse. Vina picked up speed as she guided her mare, Lizzie, around a sharp curve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`
  - -> `[12]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina! Slow down!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Go faster yourself."]** — Mówca: **Player_Romus_Italic**
> "I urged my own horse on. She balked at the steep drop, slowing us down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Narrator**
> "She glanced back at me for just long enough to roll her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Vina Toras**
> ""Meet you at the beach!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Vina glanced back at me with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I watched her fly down the trail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[11]`
Mówca: **Narrator**
> "At the bottom of the trail was a sheltered cove where Pabel had laid out a picnic lunch. I dismounted and sat down next to Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Faster! Remember what I taught you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "She glanced back at me with a grin and gave the horse a swift kick in the side with her spurred boot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[14]`
Mówca: **Vina Toras**
> ""You really didn't have to come back to Monqiz with me, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[16]`
  - -> `[49]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to. It's been ages since we had time together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm grateful for the break. It's too hectic in Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[17]`
Mówca: **Vina Toras**
> ""We could be spending time at Palas Rezna. If you'd let me on the council, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[205]`
  - -> `[207]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to. Council meetings don't exactly count as quality time together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Vina Toras**
> ""Deciding the fate of the country together? That screams quality time to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Vina Toras**
> ""I like the place. But I can't let Lizzie think I've forgotten about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Vina Toras**
> ""A Sordish resort in Monqiz! I can't believe you agreed to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`
  - -> `[215]`
  - -> `[218]`

### Węzeł `[29]`
Mówca: **Vina Toras**
> ""Ah. I knew there was another reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[30]`
Mówca: **Narrator**
> "She picked up a lobster salad sandwich from the picnic basket and nibbled at it. A solemn silence descended as we stared out at the waves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Vina Toras**
> ""Eight years since she died. When I'm here, it might as well have been yesterday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[435]`
  - -> `[437]`
  - -> `[439]`

### Węzeł `[32]`
Mówca: **Vina Toras**
> ""I can't even dip my toe in the water, or it'll all come rushing back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd still declare you next in line. Rizia needs a queen like you, and the rules were meant to be broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He'd become my successor, of course. Those are the rules. But you'll still be a duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what'll help blot out those memories? A big Sordish resort, right on this spot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll get easier over time. It did for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grief isn't a straight line, my daughter. It ebbs and flows like the tide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Vina Toras**
> ""It's always high tide for me. And I'm not sure I even want to come up for air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[42]`
Mówca: **Vina Toras**
> ""But you must be feeling the same way about Mother. Otherwise, you would've remarried by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think our family will still hold power by the time I die?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1; RiziaDLC.Vina_PromisedQueen = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;
Variable["RiziaDLC.Vina_PromisedQueen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Vina Toras**
> ""But you're a man. As long as your wife's young enough, you could have another child at any age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1;
RiziaDLC.Vina_WarnedPossibleDisinheritance = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;
Variable["RiziaDLC.Vina_WarnedPossibleDisinheritance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "She folded her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[48]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've got to do some glad-handing here anyway, before the Sordish invasion begins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just wanted to relish the sight of this beautiful, Sord-free beach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Vina Toras**
> ""A Sordish resort in Monqiz! I can't believe they thought you'd go for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[224]`
  - -> `[226]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Vina Toras**
> ""Don't you think that's a little elitist? Beaches should belong to everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[202]`
  - -> `[204]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have anything to worry about. My childbearing days are over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[63]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Vina Toras**
> ""Never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Vina Toras**
> ""Like Queen Lyza said. The eldest sibling should inherit the throne, no matter their sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The tide was beginning to lap at the edge of our blanket. We stood up and pulled it away from the water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Vina Toras**
> ""But... Queen Lyza always said the eldest child should inherit the throne. No matter their sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Vina Toras**
> ""Then let's see how many rules I can break once I'm queen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[72]`
Mówca: **Vina Toras**
> ""The rules are the rules, I get it. No use being queen if the people don't want me, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[73]`
Mówca: **Vina Toras**
> ""Never mind. Who knows if it will even happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[74]`
Mówca: **Vina Toras**
> ""Father? One more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[75]`
  - -> `[305]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not hungry right now. I'll eat my sandwich when we get back to the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Narrator**
> "She hopped astride Lizzie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[78]`
Mówca: **Vina Toras**
> ""It's just...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Vina Toras**
> ""No, not that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""Grandmother is always on about how I need to find the right husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Vina Toras**
> ""How important is it to you, really? Whom I marry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[86]`
  - -> `[85]`
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Do you have any candidates in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't listen to that hypocrite. Grandma followed her heart, and so should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[84]`
Mówca: **Vina Toras**
> ""No, but do *you*? Are you going to marry me off, like your father did to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care whom you marry. As long as he's of noble birth, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a princess, Vina. Your marriage status matters not only to me, but to the whole country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Vina Toras**
> ""Does that mean you're planning to marry me off? Like your father did to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[98]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""So you're not planning to marry me off. Like your father did to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[111]`
  - -> `[97]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still considering all the options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My arranged marriage was the best thing that ever happened to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. Arranged marriage is a barbaric tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Vina Toras**
> ""I wasn't blind and deaf growing up. I don't want to end up like you and Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[105]`
  - -> `[107]`
  - -> `[106]`

### Węzeł `[96]`
Mówca: **Vina Toras**
> ""You and Mother were lucky to fall in love. Most such marriages are miserable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[105]`
  - -> `[107]`
  - -> `[106]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might suggest a potential husband or two. But I'll never drag you to the altar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Vina Toras**
> ""You and Mother were living proof of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[132]`
  - -> `[133]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""It worked out for you and Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[135]`
  - -> `[136]`

### Węzeł `[104]`
Mówca: **Narrator**
> "She fixed me with a stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want to be queen? This is part of it. A single wedding can accomplish more than a hundred political conferences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I might suggest a potential husband or two, but I'll never drag you to the altar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether or not I loved her, I did what I was ordered to do. As you will when the day comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[108]`
Mówca: **Vina Toras**
> ""So you won't try to marry me off. Like your father did to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[111]`
  - -> `[97]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think of it as yet another one of your royal obligations. You can always take a lover on the side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you to make the right decision. For yourself, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HadAffairs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Narrator**
> "She regarded me coolly for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[116]`
Mówca: **Narrator**
> "She mulled over my words for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[118]`
Mówca: **Narrator**
> "She looked relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Vina Toras**
> ""I'm interested in hearing these suggestions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[120]`
Mówca: **Vina Toras**
> ""That's the least I could ask of you. But good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We were an exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[125]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Her expression was hard to read."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[130]`
Mówca: **Vina Toras**
> ""Let's hope that my heart and Rizia's needs align.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""I appreciate your honesty. I do know we royals must make compromises in our personal lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We both loved you. And we both swore you'd never go through the same hell we did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All because I didn't have the courage to speak to my father as an equal. You're braver than I was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We made the best of the situation we'd been forced into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still wish I'd had a choice. The least I can do is grant you one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[139]`
Mówca: **Vina Toras**
> ""That means a lot, Father. And it's a decision I won't take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[140]`
Mówca: **Narrator**
> "She regarded me coolly for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Vina Toras**
> ""I wasn't deaf or blind as a child, you know. I'm happy I won't have to subject my own to the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""I hope someday I can have what you two had. Arranged or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[143]`
Mówca: **Narrator**
> "I staggered through the doorway of Palas Monqiz, exhausted. Pabel swiftly took my coat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Pabel Adria**
> ""Welcome back, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's too fast for her old man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's visiting with a friend, but she wanted to thank you for lunch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In another castle. I let her go out, against my better judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Pabel Adria**
> ""I remember a certain Romus Toras being quite the rider himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[152]`
Mówca: **Pabel Adria**
> ""I heard you used to be quite the rider yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[153]`
Mówca: **Pabel Adria**
> ""Monqiz lobster. It's never so sweet as when it's fresh out of the water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Pabel Adria**
> ""She's more than old enough to go out alone. You can't protect her from everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[158]`
Mówca: **Pabel Adria**
> ""Any daughter of King Romus is bound to have a strong will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You read my mind, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sore at all. But a bath sounds good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if it's got bubbles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
Mówca: **Pabel Adria**
> ""All part of the job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
Mówca: **Pabel Adria**
> ""Let me know if you need anything else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Pabel Adria**
> ""Is there any other kind of bath?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I made my way to Palas Monqiz's master bathroom, where an enormous clawfoot tub was filled to the brim with soapy, eucalyptus-scented water. I undressed and got in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "Scrub your right arm."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my right arm. The temperature was perfect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "Scrub your left arm."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my left arm. The temperature was perfect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "Scrub your right leg."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my right leg. The temperature was perfect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "Scrub your left leg."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my left leg. The temperature was perfect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Narrator**
> "A tap came at the door, so soft I thought I was imagining it at first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Pabel Adria**
> ""Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not now. Go away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[178]`
Mówca: **Pabel Adria**
> ""I'll just be a second. I forgot to leave you a towel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[179]`
  - -> `[346]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `301` (*Rizia/Turn 2/Pabel Valero Poisoning Talk*), Węzeł `[1]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you have anything better to do? Stop bothering me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Pabel Adria**
> ""Very well. Have a nice bath, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Pabel Adria**
> ""Very well. Have a nice bath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Narrator**
> "After a thorough soak, I dressed and headed to my study. I still had some work to go over before the trip back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[188]`
Mówca: **Narrator**
> "I heard his footsteps receding in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[189]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[190]`
Mówca: **Narrator**
> "She seemed to shrink a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Vina Toras**
> ""Whatever you say, Father. I should be going now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[193]`
Mówca: **Narrator**
> "She'd thrown herself into horseback riding after Lena died. We kept a few horses in Porte Drazon as well, but Lizzie was her favorite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Narrator**
> "I followed her at a leisurely pace, taking time to gaze back up the hill at Palas Monqiz. With Hubertus Toras governing the province from his own estate, I was free to visit my old home and its private beach anytime I liked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We already discussed this. What have you been doing instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know how much we're deciding. Sometimes I feel like it's out of any of our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother was right about a few things. It's not healthy to spend too long in those chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep up that enthusiasm. It will serve you well when you're older.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[199]`
Mówca: **Vina Toras**
> ""The usual. Ballgoing. Public appearances. Grandmother enrolled me in an advanced etiquette class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not our beach, though, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Vina Toras**
> ""Why should we be an exception?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Marcel Koronti resort on these shores would attract the worst kind of elitist. Trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Vina Toras**
> ""You're probably right. I've read about him and his horrible father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`
  - -> `[451]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everyone in *Rizia*. The Sords have their own beaches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, it's nowhere near as exciting as you imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Vina Toras**
> ""I'm sure it's more exciting than the etiquette class Grandmother made me start taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of your backtalk. Let's just treasure what time we have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[208]`
Mówca: **Vina Toras**
> ""Hectic for you, maybe. I'm bored to tears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[413]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[212]`
Mówca: **Vina Toras**
> ""By the way, did you know it's considered polite to intentionally lose a Derdian Duel of Generosity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`
  - -> `[443]`
  - -> `[30]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would you have done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They made me drink whiskey. It went to my head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you questioning my decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[216]`
Mówca: **Narrator**
> "She considered it seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Vina Toras**
> ""Honestly... I probably would have let them have it. Lyza knew how valuable it was to be close to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was the right diplomatic move. I'm sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what would you have done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[220]`
Mówca: **Narrator**
> "My daughter fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[221]`
Mówca: **Vina Toras**
> ""Not at all, Father. I'm sure you had your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[222]`
Mówca: **Vina Toras**
> ""No need to make excuses, Father. A King stands by his decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[223]`
Mówca: **Vina Toras**
> ""I'll miss the unobstructed views, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may have made the wrong diplomatic move, but it felt right in my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Vina Toras**
> ""No need to make excuses, Father. A King stands by his decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They thought they could buy me with their greasy Sordish ren. I showed them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Vina Toras**
> ""I'm sure you did, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[228]`
Mówca: **Narrator**
> "I looked out at the sea again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[233]`

### Węzeł `[229]`
Mówca: **Narrator**
> "But they were too strong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true  and  Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true  and  Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[233]`
**[WYBÓR GRACZA: "Let yourself remember."]** — Mówca: **Player_Romus_Italic**
> "The memories rushed over me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "Try not to think about it."]** — Mówca: **Player_Romus_Italic**
> "I consciously tried to repress my memories."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[235]`
Mówca: **Narrator**
> "The sickening sound the boat had made as its girders splintered. Calling out for my wife, over and over, until my voice finally gave out. The beep of the hospital machines as I told Vina to say goodbye to her mother one last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_InBoatAccident == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Tears formed at the corners of my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[240]`
  - -> `[257]`

### Węzeł `[240]`
**[WYBÓR GRACZA: "Don't resist."]** — Mówca: **Player_Romus_Italic**
> "I started sobbing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[241]`
Mówca: **Narrator**
> "The sickening sound the boat had made as its girders splintered. Vina calling out for her mother, over and over, until her voice finally gave out. My daughter's eyes as I told her she would never see Lena again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[242]`
Mówca: **Narrator**
> "It was just an ocean. A big, impartial ocean."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[39]`
  - -> `[40]`
  - -> `[267]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[246]`
Mówca: **Narrator**
> "The break in the coast guard's voice as he told me the news. The hospital staff muttering meaningless reassurances. The beep of the ventilator as my wife slipped in and out of consciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[247]`
**[WYBÓR GRACZA: "Don't cry."]** — Mówca: **Player_Romus_Italic**
> "I took a second to regain my composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Was there anything I could have done to save her? In another timeline, were there three of us sitting on this beach instead of two?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[252]`
Mówca: **Narrator**
> "The break in the coast guard's voice as he told me the news. The hospital staff muttering meaningless reassurances. My daughter's eyes as I told her she would never see her mother again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Narrator**
> "If I had been on that boat, would things have gone differently? In another timeline, were there three of us sitting on this beach instead of two?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Worst of all: the secret relief I felt when the hospital ventilator beeped for the last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`
  - -> `[257]`

### Węzeł `[255]`
**[WYBÓR GRACZA: "Cry."]** — Mówca: **Player_Romus_Italic**
> "A man in my position would be crying. I forced out a few tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[256]`
**[WYBÓR GRACZA: "Keep your cool."]** — Mówca: **Player_Romus_Italic**
> "I kept staring out at the water, my eyes dry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[260]`
**[WYBÓR GRACZA: "Pray."]** — Mówca: **Player_Romus_Italic**
> "I muttered a prayer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[261]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Vina Toras**
> ""Did it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Narrator**
> "She let out a sound that was half-laugh, half-sniffle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Vina Toras**
> ""Then why haven't you remarried? You must know it's unusual for a king to stay a widower for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[265]`
Mówca: **Vina Toras**
> ""If you're so keen to forget her, why haven't you remarried?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[266]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to move forward. Lena wouldn't have wanted us to stay in mourning for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[268]`
Mówca: **Vina Toras**
> ""Are you... are you thinking of moving forward, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Vina Toras**
> ""Eight years and not so much as a date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[272]`
  - -> `[273]`
  - -> `[271]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be naive. I've had dates. Just nobody worth telling you about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's with the sudden interest in my love life?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It feels useless to try. I'll never love anyone else as much as I loved your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looking after you has been my number-one priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Vina looked unconvinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Narrator**
> "Vina gave me a small smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[279]`
Mówca: **Vina Toras**
> ""Oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Her face went through a few different expressions as she quietly processed this information."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[281]`
Mówca: **Vina Toras**
> ""You can't use that as an excuse for much longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[282]`
Mówca: **Vina Toras**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Narrator**
> "She nervously picked up a handful of sand and let it run through her fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Vina appeared at a loss for words. She tentatively put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Vina Toras**
> ""I'm sorry, Father. I didn't realize it was still so fresh for you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[40]`
  - -> `[267]`
  - -> `[289]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's in a better place now, Vina. As you and I will be one day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[288]`
Mówca: **Narrator**
> "My daughter didn't join me, but maintained a respectful silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[267]`
  - -> `[287]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I miss her so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Vina Toras**
> ""Me too. But it's got to get easier sometime, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Vina Toras**
> ""Maybe not. But I can't help it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[294]`
Mówca: **Vina Toras**
> ""And you can't stay a widower forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[295]`
Mówca: **Vina Toras**
> ""But what happens until then? We're just supposed to keep going like nothing happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Vina Toras**
> ""I mean, look at you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[298]`
Mówca: **Vina Toras**
> ""But then... if you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Vina Toras**
> ""But... if you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[300]`
Mówca: **Vina Toras**
> ""Say you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[301]`
Mówca: **Narrator**
> "She nervously picked up a handful of sand and let it run through her fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Vina Toras**
> ""So... if you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Vina Toras**
> ""What if you had a son? Who would be your successor when you died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[537]`

### Węzeł `[304]`
Mówca: **Vina Toras**
> ""Thank you, Father. It means a lot to know all my preparation won't be for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, you can bring Lizzie back to Porte Drazon. But you'll have to get rid of one of your other horses to make room in the stables.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Vina Toras**
> ""Oh, that'd be grand! But I wanted to ask something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[307]`
Mówca: **Vina Toras**
> ""Sorry to run, but one of the countesses from my school days has invited me for tea. She's just a few estates down the beach from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[318]`
  - -> `[310]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I thought we'd be spending the whole visit together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have fun. I'm glad we were able to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! Send one of your men to keep an eye on her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Narrator**
> "My guard appeared from behind a rock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Titus Gordion**
> ""Sure thing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Vina Toras**
> ""I've spent enough time with you, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[317]`
Mówca: **Vina Toras**
> ""Don't worry. I'll be back before supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Try and gauge her reaction to the Sordish resort idea, will you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[322]`
Mówca: **Narrator**
> "She rode away before I could think of a comeback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[323]`
Mówca: **Narrator**
> "She rode away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Vina Toras**
> ""So am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[328]`
Mówca: **Vina Toras**
> ""Yes, it was *very* enlightening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[329]`
Mówca: **Vina Toras**
> ""I won't get into trouble. But I understand the need for protocol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[330]`
Mówca: **Vina Toras**
> ""No need. I already know her family hates it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Vina Toras**
> ""I already know her family hates it. But I'll try to sway them for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[335]`
Mówca: **Narrator**
> "The trip back up to the palace felt a lot longer than the way down. It was dusk by the time I'd returned my horse to the stables."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");
RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Pabel Adria**
> ""Back so soon? I hope I packed enough food for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Pabel Adria**
> ""Where is the princess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[150]`

### Węzeł `[344]`
Mówca: **Pabel Adria**
> ""There's a warm bath waiting for you upstairs, in case you're sore from the ride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`
  - -> `[161]`

### Węzeł `[345]`
Mówca: **Pabel Adria**
> ""May I come in? I forgot to leave you a towel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[179]`
  - -> `[346]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not important. I'll dry off without one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[348]`
Mówca: **Pabel Adria**
> ""It's... a very special towel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[349]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Fine, bring it in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `301` (*Rizia/Turn 2/Pabel Valero Poisoning Talk*), Węzeł `[1]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told you not to come in, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[351]`
Mówca: **Narrator**
> "Vina's eyes grew wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Vina Toras**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`
  - -> `[536]`
  - -> `[355]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's time for the people of Rizia to hold the real power, Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The monarchy must die if Rizia is to enter the modern era. At least in its current form.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We stopped one uprising. I fear the next won't be so easy to suppress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[356]`
Mówca: **Vina Toras**
> ""But... what would become of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would stay on, but only in a symbolic role. The human embodiment of Rizian grace and dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We could do anything we wanted! All the riches, none of the responsibility. Isn't that the dream?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'd live as normal citizens. We don't deserve to be treated as superior simply by virtue of our birth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Vina Toras**
> ""You really think that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would still perform some important duties. But a democratically elected leader should do the real work of governing the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Vina Toras**
> ""I understand. I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[363]`
Mówca: **Vina Toras**
> ""I understand. But I always thought I'd be more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[364]`
Mówca: **Vina Toras**
> ""Maybe for you. I always thought my life would be more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Vina Toras**
> ""You know, Queen Lyza likened the monarchy to a steady ship on a stormy ocean. We provide stability and comfort, even during the most unpredictable of times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[386]`
  - -> `[395]`
  - -> `[396]`

### Węzeł `[369]`
Mówca: **Vina Toras**
> ""You know, this book I'm reading likened monarchy to a leaky old galleon -- weighed down by the anchor of tradition, steered only by inertia and the whims of a privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[376]`
  - -> `[377]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Chavatangakwunua, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_TookBookAway == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you still reading that? I took it away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still reading that? Even after I banned Malenyevist propaganda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's cruel to those of us who are only trying to keep our country afloat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's time to sink that ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[378]`
Mówca: **Vina Toras**
> ""Maybe it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[379]`
Mówca: **Vina Toras**
> ""Maybe we're dead weight. We have to sink so the rest of the country can swim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[380]`
Mówca: **Vina Toras**
> ""Well... um, yes. He makes a lot of good points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`
  - -> `[391]`

### Węzeł `[381]`
Mówca: **Narrator**
> "Vina folded her arms defiantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[385]`
Mówca: **Vina Toras**
> ""You can't stop me from informing myself, Father. And he makes a lot of good points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[484]`
  - -> `[486]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She was right. We're not ready to sink to the bottom of the ocean just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words. But the Rizian people should steer their own ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am warning you, Vina. Stop filling your head with this nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know, His concept of vanguardism doesn't sound too far off from monarchy to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep on reading. Sounds like there's a lot of useful information in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like his analogy. I'm less convinced about his preferred system of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Vina Toras**
> ""Yes, I've also started to read about Valgslandian Socialism. It makes even more sense to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[393]`
Mówca: **Vina Toras**
> ""That's why Hegel branched off with Valgslandian Socialism. I've been reading about that as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[394]`
Mówca: **Vina Toras**
> ""To be honest, a lot of it is outdated. I've also been reading some newer texts about Valgslandian Socialism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be a steady ship, but it sails on the currents of privilege and tradition, not the winds of change and progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We do not need a steady ship. We need to recognize the changing seas and adapt to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[397]`
Mówca: **Vina Toras**
> ""I hope not. Our people still need us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[398]`
Mówca: **Vina Toras**
> ""How can they, without a noble hand to guide them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[399]`
Mówca: **Vina Toras**
> ""That doesn't need to be the case. Monarchs have embraced change and progress in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[400]`
Mówca: **Vina Toras**
> ""Change can be threatening to many people. Our presence on the throne is a symbol of continuity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[401]`
Mówca: **Vina Toras**
> ""The next? That's pessimistic, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[402]`
Mówca: **Vina Toras**
> ""They don't belong to everyone in Rizia, though, do they? So much of this coast is private property...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`
  - -> `[451]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What have you been doing these days, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Vina Toras**
> ""The usual. Ballgoing. Public appearances. Grandmother enrolled me in an advanced etiquette class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[405]`
Mówca: **Narrator**
> "She reached up and gave her horse a pat on the nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Vina Toras**
> ""It's beautiful here, isn't it? I can see why the Sords had their eye on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think it was the right decision to let them build their resort?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They did indeed. But I showed them who's in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think I should have given it to them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's your own fault. Why don't you find something to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Vina Toras**
> ""You mean between the ballgoing, the public appearances and the advanced etiquette classes Grandmother's making me go to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[415]`
Mówca: **Vina Toras**
> ""You just accepted that Sordish resort deal, didn't you? That was entirely your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[454]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Vina Toras**
> ""You just turned down the Sords' offer to build a resort here, didn't you? That was entirely your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's so beautiful it deserves to be shared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[421]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""Sure. I mean, Queen Lyza recognized the importance of being connected with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Vina Toras**
> ""Mother would be rolling in her grave at the news, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[431]`
  - -> `[432]`

### Węzeł `[424]`
Mówca: **Vina Toras**
> ""It's what Queen Lyza would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[425]`
Mówca: **Vina Toras**
> ""A Sordish resort on our shores! Imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[426]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Vina Toras**
> ""Maybe. If only to honor the history of trade between our countries under Queen Lyza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[431]`
  - -> `[432]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't even get me started on what your Aunt Bea calls them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[430]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yeah. That was a cheap shot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She had an ear for a good pun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since who died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Vina Toras**
> ""Mother, obviously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I honestly don't think about it that often.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Vina Toras**
> ""Lucky you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You almost died too that day, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[438]`
Mówca: **Vina Toras**
> ""Sometimes I wish I had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about it. It hurts every time we come back here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[440]`
Mówca: **Vina Toras**
> ""But we keep doing it anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? I'll remember that the next time I'm in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's a Duel of Generosity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? Those classes aren't entirely useless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[444]`
Mówca: **Vina Toras**
> ""Some sort of welcome ceremony. But Rizia hasn't had a diplomatic visit to Derdia in decades, so the exact procedure is unknown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[445]`
Mówca: **Vina Toras**
> ""Remember to tell them to treat women like people, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[446]`
Mówca: **Vina Toras**
> ""They are. Have you heard about how abysmal women's rights are in Derdia? I'm never setting foot there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Vina Toras**
> ""Sure, Father. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you up to nowadays, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was only following your late mother's wishes. Remember how she used to call them 'Sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For now, let's just enjoy having this time and this beach to ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[452]`
Mówca: **Vina Toras**
> ""Sure, Father. I don't mean to complain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[453]`
Mówca: **Vina Toras**
> ""It's true. She would have been rolling in her grave if you'd said yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you agree with it? Should I have turned them down instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. I showed them who's in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think I should have let them build it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I'm proud of it. A beach as beautiful as this deserves to be shared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[458]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Vina Toras**
> ""I don't think so. I mean, Queen Lyza recognized the importance of being connected with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[460]`
Mówca: **Vina Toras**
> ""Mother would be rolling in her grave at the news, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`
  - -> `[468]`
  - -> `[469]`

### Węzeł `[461]`
Mówca: **Vina Toras**
> ""It's what Queen Lyza would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[462]`
Mówca: **Vina Toras**
> ""A Sordish resort on our shores! Imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[463]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Vina Toras**
> ""Maybe. If only to honor the history of trade between our countries under Queen Lyza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`
  - -> `[468]`
  - -> `[469]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't even get me started on what your Aunt Bea calls them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[467]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`
  - -> `[468]`
  - -> `[469]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yeah. That was a cheap shot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She had an ear for a good pun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "She picked up a lobster salad sandw..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "She picked up a lobster salad sandw..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "She picked up a lobster salad sandw..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Vina Toras**
> ""But I agree that if the people of this country want revolution, we will not be able to stop them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`
  - -> `[494]`

### Węzeł `[477]`
Mówca: **Vina Toras**
> ""But in my opinion, if the people want revolution, we should be the ones who bring it to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`
  - -> `[491]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it really revolution if we're still on the throne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We Torases are not revolutionaries. We are keepers of tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true; RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_NoMonarchy = true; RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_NoMonarchy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Keep reading it if that's what you really want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 1; RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm concerned for your safety. If you're going to harbor these sentiments, then by God be quiet about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Vina Toras**
> ""I will. You're the one who brought up the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[488]`
Mówca: **Vina Toras**
> ""But... you're the one talking about getting rid of the monarchy. Would you turn us into Lespia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Vina Toras**
> ""It is. And I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[490]`
Mówca: **Vina Toras**
> ""Never mind. You know best, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people who want revolution also want to see me dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. But we can die trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that is truly what they want, I will not get in their way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't tell me you're still reading Comrade Chavatangakwunua.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_TookBookAway == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[501]`
Mówca: **Vina Toras**
> ""No thanks to you. I'm a grown woman and I will read what I like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`
  - -> `[505]`
  - -> `[506]`

### Węzeł `[502]`
Mówca: **Vina Toras**
> ""Would you have me executed if I said yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`
  - -> `[505]`
  - -> `[506]`

### Węzeł `[503]`
Mówca: **Vina Toras**
> ""Well... um, yes. He makes a lot of good points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`
  - -> `[507]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am warning you, Vina. Stop filling your head with this nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to get defensive. Keep reading it if that's what you really want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm concerned for your safety. If you're going to harbor these sentiments, then by God be quiet about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give me a summary when you have the chance. I'm dying of curiosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[508]`
Mówca: **Vina Toras**
> ""That doesn't sound very appealing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Vina Toras**
> ""Neither will I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Vina Toras**
> ""I don't know what it was like in the '20s. But it does feel like some sort of change is brewing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[511]`
Mówca: **Vina Toras**
> ""Why not? A good monarch adapts to the times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[512]`
Mówca: **Vina Toras**
> ""Why can't we be both?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[513]`
Mówca: **Vina Toras**
> ""Not if you're willing to change with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[514]`
Mówca: **Vina Toras**
> ""I will, I will. You're the one who brought up the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[515]`
Mówca: **Vina Toras**
> ""It is, and I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 1; RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Vina Toras**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[518]`
Mówca: **Vina Toras**
> ""Never mind. You know best, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Vina Toras**
> ""Sure thing, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_G_SaveTheRiver = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_SaveTheRiver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_Happened = true;
RiziaDLCSupport.Journal_Turn02_Pabel_Listened = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Pabel_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == false  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == false  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter. You heard what I said to Hugo. It's time for House Toras to step aside and let the people rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Vina Toras**
> ""So you really mean it. You want to reform the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The future is unpredictable. Any one of the other royal houses could seize power at any moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Vina Succession Answers)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[551]`
  - -> `[59]`

### Węzeł `[538]`
Mówca: **Vina Toras**
> ""Not if you neutralize the threat. Like you were talking about with Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[542]`
Mówca: **Vina Toras**
> ""That's what you're worried about? Not the people of Rizia seizing power themselves?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[493]`
  - -> `[494]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just what are you implying, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Vina Toras**
> ""Nothing, Father. Can we go back to my original question? What would happen if you had a son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Vina Succession Answers])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[549]`
Mówca: **Vina Toras**
> ""It can't be that hard to keep the provinces happy. Can it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Vina Toras**
> ""You didn't answer my question. What would happen if you had a son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know, Vina. If the situation ever arises, it will be a hard decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
Mówca: **Narrator**
> "She folded her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Vina Toras**
> ""Thanks. It's lovely to know all my preparations may or may not be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Narrator**
> "She uncrossed her arms again with a look of contrition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[556]`
Mówca: **Vina Toras**
> ""Sorry, Father. I do understand the importance of royal tradition. But it's frustrating not to have any power over my lot in life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`
  - -> `[563]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want agency, you can always take yourself out of the line of succession. If I don't have a son, the crown will go to Hugo when I die. Or more likely, your cousin Ricardus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all completely hypothetical. Just assume that you're my successor and prepare yourself accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[559]`
Mówca: **Narrator**
> "She made a face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Vina Toras**
> ""I'm not ready to give up all hope of becoming queen, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[561]`
Mówca: **Vina Toras**
> ""Yes. That's what I've been doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a future Duchess and a member of the Royal Council. That's already more power than most Rizians will ever have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[566]`
Mówca: **Vina Toras**
> ""You're right, of course. But you knew you'd be king ever since you were a child. It's different for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a future Duchess and a member of House Toras. That's already more power than most Rizians will ever have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`
