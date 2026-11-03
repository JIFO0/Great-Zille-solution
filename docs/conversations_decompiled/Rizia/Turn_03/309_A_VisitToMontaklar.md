# Rizia/Turn 3/A_VisitToMontaklar

- **ID konwersacji:** `309`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/309_A_VisitToMontaklar.md`
- **Liczba węzłów dialogowych:** 683
- **Liczba wyborów gracza:** 173

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Pales_ProWar`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Turn02_Diplomacy_Intention_ATO`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage`
- `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Turn03_Montaklar_TookMap`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage`
- `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind`
- `RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps`
- `RiziaDLCSupport.News_Turn03_RH_Gossip_KingLucita`
- `RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplete`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 40

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[125]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- Węzeł `[126]` (Paskal Beniwoll): `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- Węzeł `[179]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] = true;`
- Węzeł `[180]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] = true;`
- Węzeł `[197]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] = true;`
- Węzeł `[264]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- Węzeł `[265]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- Węzeł `[289]` (Paskal Beniwoll): `Variable["RiziaDLC.Lucita_CompromisingPhoto"] = true; Variable["RiziaDLCSupport.News_Turn03_RH_Go...`
- *...oraz 32 innych węzłów ze skryptami.*

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
  - -> `[680]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "From anywhere in the city of Montaklar, you could look high into the hills and see the ruins of Fortress Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Lucita Azaro**
> ""How do you like the view, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Expanded and fortified over the centuries, it had served as a stronghold for the city's inhabitants from the early years of the Rezenid Empire until its destruction in the War of Rizian Succession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Today, the ruins served as a symbol of Montaklar's resilience - and that of its governing house. Perhaps that was why Lucita had invited me here for a tour and private talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "For safety's sake, a wooden walkway had been constructed over the crumbling remains of the parapets. Lucita and I walked along it until we came to the northwestern corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[8]`
Mówca: **Narrator**
> "From here, we could look down into the valley, where the provincial capital sprawled across the fast-flowing Alca river and up into the foothills of the mountains opposite us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[12]`
  - -> `[15]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's fine. I always preferred the ocean over mountains, myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spectacular. Why did you bring me here, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember it well from my military days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Imagine how this fortress must have looked a thousand years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""Incredible, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""I've come here as a child, as an army recruit and as a duchess. It's always different, and always the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "The fortress was closed off for our visit, but a crowd had gathered just outside its walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""My province has been cut off from the ocean since we lost Pales. We've learned to make do with what we have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""It took years for the Azaro and Toras families to repair their bond. I hope our houses will remain harmonious through your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[128]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that why you brought me here, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing means more to me than keeping the favor of House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Lucita Azaro**
> ""In part, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""I didn't agree with your decision to supercede my authority and transfer Central Police forces to the Duke of Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""It's great to hear you say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't understand. Iza is at a tipping point. The city's fate could determine that of the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras takes care of its own. If I do grant special favors to my cousin, that's none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family comes first, Duchess. You have to respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""Not even the Markians could destroy this place, you know. Only when Rizia's noble families turned against each other did it finally fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Lucita Azaro**
> ""For one, it's been too long since you visited this province. My constituents were starting to wonder if their king still cared about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""Speaking of provincial activities...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[32]`
Mówca: **Narrator**
> "She paused and turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[33]`
Mówca: **Narrator**
> "She gestured to the stone wall behind us. A metal ladder led to the top of a small watchtower, now the fortress' highest surviving structure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Lucita scaled it in a matter of seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "Follow her."]** — Mówca: **Player_Romus_Italic**
> "I followed her to the top of the tower."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll stay down here for now. What can you see?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""Don't you remember? Camp Domus is just downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""Camp Domus is just downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "From below, I heard the sound of a snare drum beating out a complex rhythm, followed by that of boots hitting the ground in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Narrator**
> "From what I knew was the main square, I heard the sound of a snare drum beating out a complex rhythm, followed by that of boots hitting the ground in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "The drumbeat dictated the platoon formation. It was a system from ancient days, modernized by Lucita's ancestor Domus Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[79]`
  - -> `[81]`
  - -> `[108]`

### Węzeł `[46]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[47]`
Mówca: **Lucita Azaro**
> ""These are new recruits. They'll learn fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[48]`
Mówca: **Narrator**
> "From this side, we could see Camp Domus, the country's largest military training facility. It stretched far into the distance, with hundreds of barracks clustered around grounds that simulated all types of terrain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "We looked down onto the main square. A platoon of some 50 soldiers -- mostly men, but a few women as well -- was preparing for an exercise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Lucita Azaro**
> ""Remember the code?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Lucita Azaro**
> ""Listen closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Narrator**
> "A drummer to the side of the square beat out a complex rhythm on a snare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Narrator**
> "A drummer to the side of the square beat out a complex rhythm on a snare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "The soldiers snapped into a V-shaped formation, narrow at the back and widening towards the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`
  - -> `[65]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe they're still using that system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Narrator**
> "The soldiers snapped into a V-shaped formation, narrow at the back and widening towards the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[64]`
  - -> `[63]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little archaic, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The woman on the right side was a little slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[66]`
Mówca: **Lucita Azaro**
> ""Comms can get jammed, orders misunderstood. But rhythm, you feel in your bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""Comms can get jammed, orders misunderstood. But rhythm, you feel in your bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How did you know that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Lucita Azaro**
> ""It's an ancient system from the province. My ancestor Domus Azaro turned it into a proper code.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe they're still using that system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many men are down there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like one of them is just a little bit out of step.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""Comms can get jammed, orders miscommunicated. But rhythm, you feel in your bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""At least 50. And five women, from the looks of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[75]`
Mówca: **Lucita Azaro**
> ""The best-trained soldiers in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Still the best-trained soldiers in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""These are new recruits. She'll learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[78]`
Mówca: **Narrator**
> "She brushed herself off. I saw steel in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`
  - -> `[602]`
  - -> `[603]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How did you know that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""It's an ancient system from the province. My ancestor Domus Azaro turned it into a proper code.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little archaic, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Another rhythm came from the drum: two rimshots followed by a rapid roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""Extended line spreading out into herringbone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Narrator**
> "Almost unconsciously, she started moving along with the soldiers. But as she put her left foot down, the section of wall beneath it suddenly gave way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "She began falling backwards towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "Catch her."]** — Mówca: **Player_Romus_Italic**
> "I ran to break her fall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "Don't catch her."]** — Mówca: **Player_Romus_Italic**
> "I watched her fall. She hit the ground with her knees bent, did a quick roll and stood back up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "She brushed herself off and turned to face me. I saw steel in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`
  - -> `[602]`
  - -> `[603]`

### Węzeł `[92]`
Mówca: **Narrator**
> "As she landed in my arms, my weak leg buckled underneath me. I hit the ground with her on top of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Narrator**
> "She landed in my arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "Get up."]** — Mówca: **Player_Romus_Italic**
> "I shoved her off of me and stood up with some difficulty. She took a second to compose herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "Don't get up."]** — Mówca: **Player_Romus_Italic**
> "We stayed in that position for a few long seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "Put her down."]** — Mówca: **Player_Romus_Italic**
> "I put her down. She took a second to compose herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "Don't put her down."]** — Mówca: **Player_Romus_Italic**
> "I held on to her for a few long seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""I'm fine. We're both fine. But who the hell let that happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. It seems old habits die hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""It's nearly four. Let me show you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would follow you, but my bum leg won't allow it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""I'm afraid I forgot about that, Your Majesty. You always seem so limber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Lucita Azaro**
> ""You're familiar with the sight, anyway. Camp Domus is just downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "She was right. I remembered exactly how the camp looked -- a vast training ground simulating all types of terrain, surrounded by hundreds of barracks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""The best-trained soldiers in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Lucita avoided my gaze as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Another rhythm came from the drum: two rimshots followed by a rapid roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""Extended line spreading out into herringbone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Almost unconsciously, she started moving along with the soldiers. But as she put her left foot down, the section of wall beneath it suddenly gave way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "She began falling backwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Grab her arm."]** — Mówca: **Player_Romus_Italic**
> "I grabbed her arm and pulled her towards me to safety."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Romus_Italic**
> "I watched her fall. With expert reflexes, she managed to grab the top rung of the ladder and pull herself back up to stand next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[117]`
Mówca: **Narrator**
> "She looked up at me in surprise, breathing heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "Let go of her."]** — Mówca: **Player_Romus_Italic**
> "I released my grip on her arm. She stepped back from me and brushed herself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "Don't let go of her."]** — Mówca: **Player_Romus_Italic**
> "I held on to her for a few long seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""It seems old habits die hard. Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Now, who the hell let that happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Lucita hurriedly stepped away from me, brushed herself off and turned to the guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
Mówca: **Narrator**
> "She swiftly turned her back on me and told the guards it was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[124]`
Mówca: **Narrator**
> "She swiftly climbed down and told the guards it was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[127]`
Mówca: **Narrator**
> "We waved down to them, then turned away, following the walkway towards the former armory. Our aides and guards stayed a respectable distance behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see why that wouldn't be the case. You and your relatives have sworn fealty to the crown, have they not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as you keep your family in line, they will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""Of course. But, well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""Your father and mine were close, Your Majesty. General Taddeus told me that he felt free to express his true opinions to the King, with no fear of repercussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""I'd like it if you and I had a similar relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`
  - -> `[136]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""You don't need to worry about my family's loyalty. I guess I'm referring specifically to the two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to have that relationship with all of my councilors, Duchess. Nobody should feel like they have to hold back their opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what makes you think you deserve that? You've barely been on the council for a year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can we when we barely even know each other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""A fair point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "She trained her eyes on a lizard that was crawling up the wall next to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""You have my permission, then. Ask me anything about myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... why aren't you married? As an Azaro, you should've been paired off the day you came of age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's drop the small talk. You brought me here today because you want something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's see. Do you have any hobbies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you follow in the Azaro family's footsteps? You could've chosen your own path in life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""My path was chosen for me after my uncle was killed in the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""Even as a young girl, I knew that marked a turning point. My noble blood didn't make me safe anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`
  - -> `[193]`
  - -> `[609]`

### Węzeł `[146]`
Mówca: **Narrator**
> "She grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Lucita Azaro**
> ""They had a match chosen for me, of course. But my father allowed me to break off the engagement when I joined the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""By the time I got out, I was considered too old to be of use in the marriage arena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who's going to carry on the Azaro legacy, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. A woman like you should be swarmed with suitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you've never known the touch of a man?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were what, 28? That's ancient for a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Narrator**
> "She raised an eyebrow, then laughed lightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""Unmarried doesn't mean chaste, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[155]`
Mówca: **Narrator**
> "She frowned and looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Narrator**
> "A wry smile formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""I'm not so pathetic as to base my self-worth on what men think of me. But thank you for the compliment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[158]`
Mówca: **Lucita Azaro**
> ""Call me foolish. I chose my country over my womanly reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Narrator**
> "She looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Lucita Azaro**
> ""My younger sister is poised to bring us an heir sooner or later. If not her, then surely one of our cousins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""Do you have any questions of a less... intimate nature?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""I've always enjoyed archery, when I've had the time for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Lucita Azaro**
> ""And my father and I used to play chess together. We still do, when he has a lucid moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`
  - -> `[167]`
  - -> `[168]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Lucita Personal Qs)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[185]`
  - -> `[182]`
  - -> `[176]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who wins?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe you and I can play someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No needlepoint? Calligraphy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chess is a silly game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Lucita Azaro**
> ""If you're prepared to lose, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[170]`
Mówca: **Narrator**
> "She gave me a taunting look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[171]`
Mówca: **Lucita Azaro**
> ""I do, mostly. I've let him win a few times since the stroke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[172]`
Mówca: **Lucita Azaro**
> ""I beg to differ. If you can win at chess, you can win at war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[173]`
Mówca: **Lucita Azaro**
> ""You *really* must not know me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Personal Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Personal Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I wanted to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those days are over. We don't have to live in fear of another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The real threat isn't from the commoners. It's from the foreign powers who want to destroy our way of life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your words ring true. I had the exact same thought after my kidnapping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""And you didn't feel the drive to do something about it? To armor yourself against such threats in the future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[195]`
Mówca: **Lucita Azaro**
> ""Whatever the source of the threat, it pays to be prepared for it. As a kingdom, and as an individual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Personal Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[198]`
Mówca: **Narrator**
> "She looked at me with flinty eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[199]`
Mówca: **Lucita Azaro**
> ""Perfect, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[200]`
Mówca: **Lucita Azaro**
> ""I know. It would be exceedingly gracious of you to extend that level of trust to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[249]`
  - -> `[267]`

### Węzeł `[201]`
Mówca: **Lucita Azaro**
> ""First of all, I must say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""My house and I had questions regarding your recent meeting in Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Lucita Azaro**
> ""Sources say you were quite deep in conversation with the House Sazon heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`
  - -> `[209]`
  - -> `[210]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all strategic. Without the Sazons on my side, I won't be able to prevent another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We were speaking of repairing the bond between our houses. As you yourself said, Rizia can only be strong if all of its royal families stand together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We were guests in his province. Refusing to converse would've been a terrible breach of etiquette.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Sazon_ManusTalkSoured == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did those sources fail to tell you I turned him away?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""That's what he led you to believe? His house would help you stop an uprising?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""You might as well use gasoline to put out a fire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Lucita Azaro**
> ""The Sazons were never a royal family. Just a group of merchants who fancied themselves higher than their true station.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""You know the entire house is still suspected to have ties to Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[222]`
  - -> `[221]`
  - -> `[301]`

### Węzeł `[218]`
Mówca: **Lucita Azaro**
> ""As terrible as what his family did to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""I had that impression. But I wanted to hear it from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to get closer to Arcasia. It's part of my diplomatic strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about Manus. He seems different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That isn't surprising. Arcasia has eyes and ears everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, better Arcasia than United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[243]`

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""Don't trust the man around your daughter, is all I'm saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[242]`
  - -> `[243]`

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""No matter what, Your Majesty, I wouldn't trust that man around your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[242]`
  - -> `[243]`

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""All the more reason not to trust that man around your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[242]`
  - -> `[243]`

### Węzeł `[230]`
Mówca: **Lucita Azaro**
> ""Oh, I'm not discounting the threat of United Contana. But they don't have tentacles in the Rizian nobility. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[231]`
Mówca: **Lucita Azaro**
> ""They and their allies have spent the better part of this century trying to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[243]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[243]`

### Węzeł `[238]`
Mówca: **Lucita Azaro**
> ""That's what he wants you to think. Keep in mind Arcasia and its allies have been endlessly inventive in their attempts to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[239]`
Mówca: **Lucita Azaro**
> ""I would ask you to reconsider that. Put your faith in the West and their allies, and they'll abuse it every time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your advice. Perhaps I'll require your assistance with this in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not a matter of national security. You needn't involve yourself in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter is allowed to consort with whomever she wants. Surely you understand that as a modern woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern. But I will deal with Mr. Sazon and his family on my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[244]`
Mówca: **Lucita Azaro**
> ""Isn't it, though? An agent of chaos attempting to get cozy with the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""As the woman in charge of this country's security, all I see is an agent of chaos attempting to get cozy with the royal family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""I'm just looking out for national security. As is my job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I am nothing if not gracious. Tell me what's on your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot trust you if I don't know you. Tell me more about yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[250]`
Mówca: **Lucita Azaro**
> ""I hope your curiosity has been satisfied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[251]`
Mówca: **Lucita Azaro**
> ""May I speak freely now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[266]`
  - -> `[682]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[253]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[254]`
Mówca: **Lucita Azaro**
> ""Well, let me know if you do require my assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[255]`
Mówca: **Lucita Azaro**
> ""I had one more thing I wanted to bring up while we were alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Lucita Azaro**
> ""Especially given the level of scrutiny he is currently under from Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""Especially while he's the subject of an investigation that, again, was commissioned without the involvement of my department.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[261]`
Mówca: **Lucita Azaro**
> ""All the more reason to keep the balance as it is, rather than put more power in your cousin's hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[262]`
Mówca: **Lucita Azaro**
> ""I beg your pardon, Your Majesty, but Rizia's internal security *is* my business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""I do. But putting more power in your cousin's hands sets a dangerous precedent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I'd still rather you didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will extend you my trust when you have earned it. That time has not yet come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[268]`
Mówca: **Narrator**
> "We had come to a small grassy patch in the shade of the fortress' southern wall. Lucita gestured for me to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[269]`
Mówca: **Narrator**
> "Suddenly, we heard the click of a camera shutter. A news photographer had managed to get a photo of us from the opposite parapet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[270]`
Mówca: **Narrator**
> "From below, a camera clicked. A news photographer had managed to reach the base of the fortress and capture a picture of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""You are to find this photographer and prevent the publication of this picture at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Her head disappeared back over the wall. Lucita hurriedly pushed away from me, brushed herself off and turned to the guards surrounding us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not berate our staff, Duchess Azaro. But yes, I don't want this photograph getting out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard her. I'm embarrassed at this obvious security lapse. You ought to be ashamed of yourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disregard that order, gentlemen. Let the papers do what they will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[276]`
Mówca: **Narrator**
> "The guards nodded. One of them sprinted off in the direction of the photographer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`
  - -> `[333]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Lucita spun around towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Lucita Azaro**
> ""Really? I thought you wouldn't want the public to think anything was happening between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[281]`
  - -> `[285]`
  - -> `[284]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why not? You yourself said our houses should be more harmonious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's beside the point. I'm not going to participate in censorship of the press.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Being seen with my arms around a gorgeous noblewoman will only benefit my reputation, wouldn't you agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what the public thinks. The King of Rizia is above such concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[286]`
Mówca: **Narrator**
> "She gave me a coy smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""If you say so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[288]`
Mówca: **Narrator**
> "The smile was still on her face as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto = true; RiziaDLCSupport.News_Turn03_RH_Gossip_KingLucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] = true;
Variable["RiziaDLCSupport.News_Turn03_RH_Gossip_KingLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[290]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""It's your decision, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Narrator**
> "She had a small smile on her face as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Lucita Azaro**
> ""We shouldn't fear an uprising, but we should be prepared for one regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arcasia's power is laughable compared to the combined might of the international workers' movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""I... don't know what to say to that. Except that they both pose a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Diplomacy_Intention_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""My department has the funding already. It wouldn't eat into our budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[567]`
  - -> `[569]`
  - -> `[571]`

### Węzeł `[308]`
Mówca: **Lucita Azaro**
> ""I wouldn't even need extra funding. Your expansion of the Golden Guard has created a few redundancies in our intelligence division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[567]`
  - -> `[569]`
  - -> `[571]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_GoldenGuard_InvestigateSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_GoldenGuard_InvestigateSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_GoldenGuard_InvestigateSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""It'd just take a small amount of funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[571]`
  - -> `[615]`
  - -> `[618]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Romance >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Narrator**
> "Her eyes softened as they met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Narrator**
> "She quickly pushed away from me and brushed herself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[318]`
Mówca: **Lucita Azaro**
> ""Nice catch, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Romance >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Narrator**
> "She hurriedly pushed me away and brushed herself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[323]`
Mówca: **Narrator**
> "Her eyes softened as they met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""Nice reflexes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[325]`
Mówca: **Lucita Azaro**
> ""That's true, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[326]`
Mówca: **Narrator**
> "She gave me a coy smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be continued, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was close. Wouldn't want anyone to think anything untoward was happening between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Lucita Azaro**
> ""Certainly not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[330]`
Mówca: **Narrator**
> "She gave me a coy smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Lucita Azaro**
> ""I hope so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly. What do we even pay the Golden Guard for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Lucita Azaro**
> ""You said it, Your Majesty. I didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "She had a small smile on her face as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Pales Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[337]`
Mówca: **Lucita Azaro**
> ""Is that so surprising? Everyone wants something from the King of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Lucita Azaro**
> ""All I am requesting is a chance to speak to you without the stultifying formality of the council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[339]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Consider that request refused, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's reasonable enough. Go ahead, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[343]`
Mówca: **Narrator**
> "Lucita bit her lip. She seemed uncharacteristically nervous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[344]`
Mówca: **Narrator**
> "She was smiling, but I registered slight disappointment in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`
  - -> `[348]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Were you hoping for special treatment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's precisely your willingness to speak your mind that makes you such a valuable asset on my council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
Mówca: **Lucita Azaro**
> ""No, no. That would be unfair to the others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to get to know you better. Tell me about yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[349]`
Mówca: **Lucita Azaro**
> ""I'm pleased to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Narrator**
> "She stared out at the surrounding mountains before turning back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Lucita Azaro**
> ""So. On the subject of speaking my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[352]`
Mówca: **Lucita Azaro**
> ""About myself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Narrator**
> "She seemed to be searching for words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Lucita Azaro**
> ""That depends, Your Majesty. What would you like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Personal Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[356]`
Mówca: **Lucita Azaro**
> ""My sincerest apologies, Your Majesty. I didn't mean to bother you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[357]`
Mówca: **Narrator**
> "Before she could stop herself, she let out an exasperated sigh. She tried to camouflage it as a cough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Lucita/Azaro grievances)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita/Azaro grievances])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[361]`
Mówca: **Lucita Azaro**
> ""No?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""I thought your granting extra funding to my department was an indication of your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`
  - -> `[404]`
  - -> `[413]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[562]`
  - -> `[372]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While we're at it, is there anything you want to know about me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It has. Now, what did you want to say to me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[374]`
Mówca: **Lucita Azaro**
> ""While we're here, though... there *is* something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[375]`
Mówca: **Lucita Azaro**
> ""Now that you mention it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Lucita Azaro**
> ""Turnabout is fair play, Your Majesty. Why aren't *you* married?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[385]`
  - -> `[384]`
  - -> `[383]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm terrified at the idea of loving someone that much again, only to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was already in one loveless marriage. I'm not about to enter another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is a highly inappropriate question. I refuse to answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Romance isn't easy as a royal. You can never tell who truly loves you and who's just grasping for wealth and power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still looking for a woman who can handle me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""I understand completely. That's why it's safest for us nobles to marry amongst each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[387]`
Mówca: **Lucita Azaro**
> ""What makes you think it would be loveless?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[548]`
  - -> `[549]`

### Węzeł `[388]`
Mówca: **Lucita Azaro**
> ""Falling in love is like heading into battle. You've got to know what you're up against, and protect yourself accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[536]`
  - -> `[537]`

### Węzeł `[389]`
Mówca: **Lucita Azaro**
> ""Ha. All men think they're hard to handle, until they turn into putty at the sight of a nice pair of--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[390]`
Mówca: **Narrator**
> "Lucita took a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Lucita Azaro**
> ""We're not equals after all, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Narrator**
> "She caught herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[394]`
Mówca: **Lucita Azaro**
> ""I may as well get to my point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita/Azaro grievances])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that now. Next time, I'll be better protected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[397]`
Mówca: **Lucita Azaro**
> ""Pardon my inappropriateness, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[534]`
  - -> `[557]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""...Royal orbs?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[399]`
Mówca: **Narrator**
> "She and I looked at each other for a long moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Lucita Pales Talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[401]`
Mówca: **Lucita Azaro**
> ""I suppose your turning down my request for funding should have been an indication that you didn't trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[412]`
  - -> `[417]`
  - -> `[413]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a gesture of good faith. I will trust you when you get results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust your capabilities. I'm still deciding whether I trust you, personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was only being pragmatic, Duchess. Zille was bombed. Of course we had to investigate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That had nothing to do with trust. I didn't want to provoke Wehlen so close to the handover deadline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[406]`
Mówca: **Lucita Azaro**
> ""Well... maybe this will help change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Narrator**
> "We had come to a small grassy patch in the shade of the fortress' southern wall. Lucita gestured for me to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Pales Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""You had other options, and you went with me. I'd like to think that means something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""We will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Lucita Azaro**
> ""In the meantime... there's something else I wanted to tell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, perhaps it should have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this, Duchess. You are on my council to provide guidance, not complaints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Lucita Azaro**
> ""That's fair, Your Majesty. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Lucita Azaro**
> ""On the subject of guidance... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[416]`
Mówca: **Lucita Azaro**
> ""Respectfully, Wehlen doesn't seem to have any intention of meeting that deadline. They could do with a little provocation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't take it personally. Titus made a better case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't take it personally. I thought both the proposed investigations were a waste of time and money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Lucita Azaro**
> ""May I remind you that the deadline for the Zille handover has almost passed? Perhaps at least one investigation could have sped up that process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[423]`
Mówca: **Lucita Azaro**
> ""Right. The man whose only qualification is his ability to take a punch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[424]`
Mówca: **Narrator**
> "She folded her arms and didn't speak for a while. We kept walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Lucita Azaro**
> ""While we are here... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[426]`
Mówca: **Lucita Azaro**
> ""Regardless, though... there's something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[427]`
Mówca: **Lucita Azaro**
> ""Wehlen aside... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""The Golden Guard aside... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[429]`
Mówca: **Lucita Azaro**
> ""But Zille aside... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[430]`
Mówca: **Lucita Azaro**
> ""When I took over my father's position on the Royal Council, he gave me a trove of his old files.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[431]`
Mówca: **Lucita Azaro**
> ""Wedged between standard purchase orders and internal security reports, I found this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Narrator**
> "She reached into her pocket and unfolded a thin square of paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Narrator**
> "On it was a map of Pales. Overlaying the outline of the Grand Duchy were arrows, diagrams of tanks and battalions, and hastily scribbled instructions. Some of them were in my father's handwriting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Lucita Azaro**
> ""Look at the date. 1949.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`
  - -> `[441]`
  - -> `[442]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So they were plotting another attempt on Pales. That's not surprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This would never have worked. Not with the military still weakened from the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is complete gibberish to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pathetic. The work of two sad, deluded old men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Intriguing. Why didn't my father tell me about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[443]`
Mówca: **Lucita Azaro**
> ""Had this been attempted, it would have been a complete rout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Lucita Azaro**
> ""All glory to King Valero, but perhaps it's fortunate that he died before this could be carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[455]`
  - -> `[459]`
  - -> `[461]`

### Węzeł `[445]`
Mówca: **Lucita Azaro**
> ""You're absolutely right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[446]`
Mówca: **Lucita Azaro**
> ""It's a plan to reconquer Pales. One that would have been futile, at least with the military of the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[447]`
Mówca: **Lucita Azaro**
> ""Some of these instructions are actually genius. But it would have been futile with the military of the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FriendlyToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""He thought you'd inform Duke Reinhart, I assume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Lucita Azaro**
> ""It was still a work in progress when he died, I assume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Lucita Azaro**
> ""This plan would have ended in a complete rout. At least with the military of the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare you even imply that my father's death was a fortunate occurrence? I should have you skinned alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it possible that whoever murdered him knew about this plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It pains me to say so, but yes. Better that he died rather than order more soldiers to their deaths.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe he didn't intend to carry it out. Maybe he wanted me to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Lucita Azaro**
> ""If he was murdered, that could have served as a motivation, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[474]`

### Węzeł `[463]`
Mówca: **Narrator**
> "She frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Or the plan was scrapped when they realized it would never work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[474]`

### Węzeł `[465]`
Mówca: **Lucita Azaro**
> ""If he was murdered as you suspect... that could be a motivation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[474]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[469]`
Mówca: **Lucita Azaro**
> ""Then again, it's possible they never intended to execute this plan. It could've just been idle daydreaming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[474]`

### Węzeł `[470]`
Mówca: **Lucita Azaro**
> ""I -- I'm so sorry. I never meant to imply that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
Mówca: **Lucita Azaro**
> ""Perhaps he never even intended to execute this, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[474]`

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His dying wish was for me to take back the lands that were lost. I can't fail him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand why this even exists, though. Why does Rizia need to reconquer Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Pales_ProWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Pales_ProWar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Pales_ProWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Pales_ProWar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Pales_ProWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[479]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The plan doesn't even make sense. I supported the Reclamation War, but... now? After all these years?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand why they drew this up, though. I too never gave up on reconquering Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The timing wasn't right to reconquer Pales in the '20s. But perhaps now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_TakeBackLand == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His dying wish was for me to take back the lands that were lost. But I'm no conqueror.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[484]`
Mówca: **Lucita Azaro**
> ""You, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[485]`
Mówca: **Narrator**
> "Lucita shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[486]`
Mówca: **Lucita Azaro**
> ""Of course, my family would disagree. My province never got over losing our access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[487]`
Mówca: **Lucita Azaro**
> ""You and most of my province. The Azaros never got over losing their access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[488]`
Mówca: **Lucita Azaro**
> ""It's an outdated concept. Invading territories based on centuries-old grudges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[489]`
Mówca: **Lucita Azaro**
> ""Yes, I heard your coronation speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[490]`
Mówca: **Lucita Azaro**
> ""But I don't see any merit in taking back Pales. At least, not for historic reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`
  - -> `[491]`
  - -> `[492]`
  - -> `[495]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying there are other reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust your guidance, Duchess. If there's a reason you think we should go to war with Pales again, I want to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[493]`
Mówca: **Lucita Azaro**
> ""My family is with you, of course. The Azaros never got over losing their access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""My family would be with you, of course. The Azaros never got over losing their access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lying. You're as thirsty for revenge as the rest of your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[496]`
Mówca: **Narrator**
> "She looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[497]`
Mówca: **Lucita Azaro**
> ""I don't want to sound paranoid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[498]`
Mówca: **Lucita Azaro**
> ""I'm a realist, Your Majesty. Revenge has no place in my worldview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[499]`
Mówca: **Lucita Azaro**
> ""Having said that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Lucita Azaro**
> ""But with Lespia in ATO, and Morella becoming closer to Valgsland and the CSP... I do wonder whether our neighbor will get swallowed up in the superpower conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`
  - -> `[504]`

### Węzeł `[501]`
Mówca: **Lucita Azaro**
> ""With Lespia in ATO, and Morella becoming closer to Valgsland and the CSP, I do wonder whether our neighbor will get swallowed up in the superpower conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`
  - -> `[504]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. It's an inconsequential little strip of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure what you're getting at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. That's a legitimate worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[505]`
Mówca: **Lucita Azaro**
> ""Look at what happened to Wehlen in the 1930s. Arcasia and United Contana nearly destroyed it by proxy in a rush to gain access to its oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""And now Pales may be sitting on an even more valuable resource...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`
  - -> `[508]`
  - -> `[518]`
  - -> `[520]`
  - -> `[509]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia's involvement with Pales is clear. But we haven't seen any signs that the CSP has designs on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[508]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you think we should conquer Pales for its own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're my security councilor, Duchess. I don't want you concerning yourself with geopolitics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad that you're the one who wound up on my council, not your hawk of a father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[511]`
Mówca: **Narrator**
> "She blanched slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
Mówca: **Lucita Azaro**
> ""My father belongs to a different generation. One that solves disputes with brute force, not subtlety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Lucita Azaro**
> ""I must admit that I harbor concerns about Pales as well, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[514]`
Mówca: **Lucita Azaro**
> ""'Conquer' is such an old-fashioned word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[515]`
Mówca: **Lucita Azaro**
> ""This is a security issue, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Lucita Azaro**
> ""Not yet. But with Morella edging closer to Valgsland, they might be emboldened to try for a reconquest of their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Lucita Azaro**
> ""Think of it as a chess game. Sometimes it's best to remove certain pieces from the board before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not Pales' resource. It's ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Lucita Azaro**
> ""At least part of it belongs to Pales. The researchers have determined that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So? How does that involve Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[521]`
Mówca: **Lucita Azaro**
> ""The Wehlen Civil War happened before the development of nuclear weapons, Your Majesty. Today's superpower conflicts have the potential for far more wide-ranging damage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[522]`
Mówca: **Lucita Azaro**
> ""That doesn't mean I think we should attack Pales again. Using diplomacy to get them on our side would be a more effective tactic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`
  - -> `[527]`
  - -> `[530]`

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that. I've been aiming for diplomacy this entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FriendlyToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war councilor is urging me to practice diplomacy. Now I've heard everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[528]`
Mówca: **Lucita Azaro**
> ""War should be a last resort, Your Majesty. Contrary to what your or my father would say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[529]`
Mówca: **Lucita Azaro**
> ""If we get into a dispute over the new gas field, it may be more difficult to stay the course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Diplomatic attempts will only get us so far. At some point, force may be needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Lucita Azaro**
> ""You may be right. But we should not be the first to initiate aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. You've just given me one more reason why retaking Pales is the best course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Lucita Azaro**
> ""I would not presume to contradict you, Your Majesty. But I urge caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, you're right. Beautiful women are a weakness of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1; RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;
Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not how it works. You can't fall in love if you're holding a part of yourself back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't much care for discussions about love. What are your feelings on the Galmish Manifesto?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[538]`
Mówca: **Narrator**
> "She laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[540]`
Mówca: **Lucita Azaro**
> ""Giving all of yourself to a lover allows them to have absolute power over you. I refuse to subjugate myself to anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[541]`
Mówca: **Lucita Azaro**
> ""Tell the Golden Guard to form a cordon around your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Narrator**
> "She laughed softly at her own joke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[543]`
Mówca: **Narrator**
> "The corner of her mouth twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Lucita Azaro**
> ""Except my king, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[545]`
Mówca: **Narrator**
> "She didn't blink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Lucita Azaro**
> ""It seeks to replace the sanctity of order and hierarchy with empty egalitarian illusions. Their leader Halvorsdatir won't hold out till the end of her term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Marriages between royals are political arrangements. Love seldom has anything to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've never loved a woman up till now. I just don't see it happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Lucita Azaro**
> ""It's never too late, though, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Lucita Azaro**
> ""You never know, Your Majesty. You might get lucky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Lucita Azaro**
> ""But we'd better move on to what I wanted to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[555]`
Mówca: **Lucita Azaro**
> ""I should move on to what I wanted to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I find intelligence far more attractive than physical attributes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[558]`
Mówca: **Narrator**
> "She smiled knowingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[559]`
Mówca: **Lucita Azaro**
> ""Then you'd better remarry quickly, before one takes advantage of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[560]`
Mówca: **Narrator**
> "She smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Lucita Azaro**
> ""I'm sure you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Far from it, Duchess. You still remain an inscrutable mystery to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[564]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Lucita Azaro**
> ""Fear not, Your Majesty. You'll have plenty of chances to learn more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[566]`
Mówca: **Lucita Azaro**
> ""If you wanted me to, I could send a task force to Pales to monitor the situation more closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the suggestion. But I'm afraid such an action will be misinterpreted as aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[568]`
**[WYBÓR GRACZA: ""That sounds wise. Do what you need to do." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""That sounds wise. Do what you need to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want all our intelligence capabilities concentrated on the Zille incident at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[570]`
Mówca: **Lucita Azaro**
> ""The idea would be to avoid aggression. But I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respectfully refuse. Our internal security is a lot more pressing right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[572]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[573]`
Mówca: **Lucita Azaro**
> ""I understand. We'll focus on that going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[574]`
**[WYBÓR GRACZA: ""That sounds wise. Do what you need to do.""]** — Mówca: **Player_Romus**
> ""That sounds wise. Do what you need to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[575]`
Mówca: **Lucita Azaro**
> ""I understand. We'll focus on that going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[576]`
Mówca: **Narrator**
> "She began standing up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`
  - -> `[588]`
  - -> `[589]`
  - -> `[580]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps = true; RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[579]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate you coming to me with all this. Please feel free to express your unfettered opinions to me in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May I keep that map of Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[581]`
Mówca: **Lucita Azaro**
> ""I don't see why not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[582]`
Mówca: **Narrator**
> "She handed me the piece of paper. I took a last look at it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`
  - -> `[591]`
  - -> `[592]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`
  - -> `[585]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for showing me this. But I must insist you bring up such issues at council meetings in the future. I don't want anyone getting the wrong idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Feel free to throw that map away. It's of no use to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do everything in my power to prevent conflict with Pales. But just in case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will finish what our fathers started. Even if it takes my entire reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[592]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will keep this as a reminder of Valero the Frail's folly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[593]`
Mówca: **Lucita Azaro**
> ""If it does come to that, you'll need a better strategy. Or a better army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[594]`
Mówca: **Lucita Azaro**
> ""If you insist on taking that path, you'll have my family's aid. As well as mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[595]`
Mówca: **Lucita Azaro**
> ""And General Taddeus Azaro's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[596]`
Mówca: **Lucita Azaro**
> ""But speaking of the military...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[597]`
Mówca: **Lucita Azaro**
> ""You can count on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[598]`
Mówca: **Lucita Azaro**
> ""Certainly, Your Majesty. I wouldn't presume to demand special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[599]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. It's a relic of a more reckless age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Montaklar_TookMap = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn03_Montaklar_TookMap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't the guards step in? I should have them disciplined at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me. I wasn't fast enough to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God you're unharmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Lucita Azaro**
> ""I wasn't expecting your assistance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[606]`
Mówca: **Lucita Azaro**
> ""God has nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[607]`
Mówca: **Lucita Azaro**
> ""There's only one person I rely on for protection. Me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[608]`
Mówca: **Lucita Azaro**
> ""I wasn't expecting their assistance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[609]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was the purpose of the uprising. To show us that our blood doesn't make us special.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[610]`
Mówca: **Lucita Azaro**
> ""I joined the military so I'd never get caught by surprise like that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[612]`
Mówca: **Lucita Azaro**
> ""All it showed me was that I had to be prepared to defend myself at a moment's notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplete = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplete"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[614]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[617]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`
  - -> `[620]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[621]`
**[WYBÓR GRACZA: ""I'll make sure you'll get what the help you need without the extra funds. Do what you need to do." [-2 Authority]"]** — Mówca: **Player_Romus**
> ""I'll make sure you'll get what the help you need without the extra funds. Do what you need to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[623]`
**[WYBÓR GRACZA: ""Sorry but we don't have extra funds to spare.""]** — Mówca: **Player_Romus**
> ""Sorry but we don't have extra funds to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Lucita Azaro**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[625]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CameraShutter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CameraShutter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CameraShutter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CameraShutter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[633]`
Mówca: **Lucita Azaro**
> ""And considering the provincial leaders no longer command their own police forces... it seems to me like you're granting Ricardus a special favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[26]`
  - -> `[636]`
  - -> `[640]`

### Węzeł `[634]`
Mówca: **Lucita Azaro**
> ""As long as the provincial police system exists, Iza should be receiving help from Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[638]`
  - -> `[640]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[636]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can send more police to Cardesse-Montaklar if you like. I won't stop you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[637]`
Mówca: **Lucita Azaro**
> ""That's not the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Brenas won't help him. House Sazon is practically laughing in his face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[639]`
Mówca: **Lucita Azaro**
> ""Then we ought to force them into line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just give Rico some time. If he can't get Iza under control with these extra reinforcements, I'll take them away again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[641]`
Mówca: **Narrator**
> "She nodded, not entirely convinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[642]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`
  - -> `[645]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[646]`
Mówca: **Lucita Azaro**
> ""I am curious why you decided to remove the provincial levy system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you'd be pleased with this decision. A completely centralized military means more troops under your direct command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[648]`
Mówca: **Lucita Azaro**
> ""Do you have reason to believe the royal houses should not be entrusted with their own armies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`
  - -> `[649]`
  - -> `[650]`
  - -> `[653]`

### Węzeł `[649]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe certain houses can be trusted and certain others can't. But it would have raised too much suspicion to remove the levies in only one province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but the provincial armies were a potential threat to my power as King. They had to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[651]`
Mówca: **Lucita Azaro**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.Relations_Lucita_Romance -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is strictly confidential. I'd rather not discuss it with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[654]`
Mówca: **Lucita Azaro**
> ""I'm sorry you felt that way. I know your father considered the Azaro special forces among his most valuable military assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[655]`
Mówca: **Narrator**
> "She half-smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[656]`
Mówca: **Lucita Azaro**
> ""As a councilor, I'm honored. As the Duchess of this province, I am skeptical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[658]`
Mówca: **Lucita Azaro**
> ""You'd rather not discuss significant security matters... with your security councilor. I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[659]`
Mówca: **Lucita Azaro**
> ""Well, perhaps you're willing to discuss this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[660]`
Mówca: **Lucita Azaro**
> ""I must tell you House Azaro wasn't happy with this directive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[661]`
Mówca: **Lucita Azaro**
> ""The Azaro army had a long, proud tradition of defending Rizia and its monarch. Their skill and dedication were unlike anything else in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`
  - -> `[663]`
  - -> `[664]`
  - -> `[671]`

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And they will be just as skillfull and dedicated serving directly under the Crown. Won't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. If such a formidable force ever were to turn against their King, the consequences would be catastrophic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the problem. Your house was making the rest of army look weak by comparison. Such greatness needs to be dispersed through the entire Armed Forces, not concentrated in one province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[665]`
Mówca: **Narrator**
> "She frowned reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[666]`
Mówca: **Lucita Azaro**
> ""Yes. I'll see to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[667]`
Mówca: **Lucita Azaro**
> ""I'm disappointed you think that would even be a possibility, Your Majesty. Your father considered the Azaro special forces among his most valuable military assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[669]`
Mówca: **Lucita Azaro**
> ""But you are not King Valero. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[670]`
Mówca: **Narrator**
> "She frowned in disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I am truly sad to see it go. But greater things are on the horizon for Rizia's armies. You'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[672]`
Mówca: **Narrator**
> "She gave a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[673]`
Mówca: **Lucita Azaro**
> ""That's very kind of you. I'll try to convey that reasoning to my relatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[674]`
Mówca: **Lucita Azaro**
> ""And I hope you believe me when I say the Azaros will never pose a threat to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[675]`
Mówca: **Lucita Azaro**
> ""On the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[676]`
Mówca: **Lucita Azaro**
> ""Whatever you have in store, I hope I'll be the first to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[677]`
Mówca: **Lucita Azaro**
> ""I will not question you any further about this. But there's something else that's been bothering me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Visiting Fortress Azaro with their Military Councillor", "Montaklar", "Province of Cardesse-Montaklar");)*
- **Efekt (`userScript`):** `SetRichPresence("Visiting Fortress Azaro with their Military Councillor","Montaklar","Province of Cardesse-Montaklar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. But while we're on the subject... isn't there anything you'd like to know about me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
