# Rizia/Turn 3/A_VisitToIza

- **ID konwersacji:** `307`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/307_A_VisitToIza.md`
- **Liczba węzłów dialogowych:** 743
- **Liczba wyborów gracza:** 156

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[90]** Bruno
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_FamilyStatues_KingValero`
- `RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus`
- `RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Relations_Vina_TookBookAway`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn02_Hunting_KA74`
- `RiziaDLCIsolated.Turn02_Hunting_Rifle`
- `RiziaDLCIsolated.Turn02_Hunting_ShootToMiss`
- `RiziaDLCIsolated.Turn03_Iza_SawStatues`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.DeployedSO`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.FundedSO`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Rico_ShotDog`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn02_Hunting_KA74`
- `RiziaDLCIsolated.Turn02_Hunting_Rifle`
- `RiziaDLCIsolated.Turn02_Hunting_ShootToMiss`
- `RiziaDLCIsolated.Turn03_Iza_SawStatues`
- `RiziaDLCSupport.Journal_Turn03_Iza_AdoptBruno`
- `RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats`
- `RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO`
- `RiziaDLCSupport.News_RH_Turn03_Gossip_BrunoAdopted`
- `RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 27

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Rico_ShotDog`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats`
- `RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[148]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- Węzeł `[273]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] = true;`
- Węzeł `[283]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[287]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[295]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Rico_ShotDog"] = true;`
- Węzeł `[376]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true; Variable["RiziaDLC.Security_GoldenGuard_...`
- Węzeł `[387]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true; Variable["RiziaDLC.Security_GoldenGuard_...`
- Węzeł `[471]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] = true; Variable["RiziaDLCSupport.Jo...`
- *...oraz 19 innych węzłów ze skryptami.*

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
  - -> `[741]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After months of promises and schedule conflicts, Vina and I were finally on our way to visit my cousin Rico Toras at his palace in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I waved out the car window to the crowds of citizens lining the road. Up ahead, the domed library of the university brought back memories -- first of my happy student years there, then of the horrifying way they'd ended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I waved out the car window to the crowds of citizens lining the road. Up ahead loomed the domed library of the university."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The city's main road was straight and impossibly wide, a relic of Markian times when the city was a major trading center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Under Rico's stewardship, a formidable-looking iron gate had been constructed around the otherwise tranquil palace complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[11]`
Mówca: **Rico Toras**
> ""Welcome, my cousins! It has been far too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[24]`
  - -> `[28]`

### Węzeł `[12]`
Mówca: **Narrator**
> "We walked up to the doors. As soon as the guards opened them, a pair of long-nosed Rizian hunting dogs raced towards us, barking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go away! I hate dogs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Pet the dogs."]** — Mówca: **Player_Romus_Italic**
> "I reached out and carefully gave each dog a pat on the head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Easy there, puppies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay back, Vina. They might be dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Both dogs promptly sat at attention, still as statues."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I heard the sound of boots on tile as my cousin Rico approached. He was wearing an olive-green tweed jacket and a flat cap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Greetings, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So it has, Rico. You're looking sporty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Rico Toras**
> ""Did Father not tell you? We're going hunting!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Your first hunt as king. I wanted it to be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Hugo appeared from behind his son, a sheepish look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish we were seeing each other under more pleasant circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I enjoyed hunting with you as a child. But I prefer more intellectual pursuits now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A welcome surprise indeed. It's been ages since I shot something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know how much I love hunting. But I wanted to have a serious discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You could've warned us about the canine welcoming committee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Rico Toras**
> ""Bella and Bruno wouldn't hurt a fly. They're just overexcited about today's hunt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[30]`
Mówca: **Rico Toras**
> ""What do you mean? An afternoon in the woods killing boars sounds like the definition of pleasant to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[31]`
Mówca: **Rico Toras**
> ""I trust Father informed you of today's plans? We leave for the woods in an hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate it. But I was hoping the four of us could have a serious conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know me too well. Let's go shoot something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a barbaric sport. I prefer more intellectual pursuits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""We'll have plenty of chances for that. Nine-tenths of this sport is waiting, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Hunting requires a keen eye and a keener mind. Done properly, it's the most intellectual pursuit there is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Rico Toras**
> ""Not when you have this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Rico Toras**
> ""You'll be glad to know the technology has greatly improved since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "He turned around and showed us the KA-74 automatic rifle strapped to his back. Hugo turned up his nose disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Vina Toras**
> ""Isn't that cheating?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Rico Toras**
> ""Boars are speedy bastards. You'd be surprised, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "He smiled rakishly at my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Rico Toras**
> ""You're behind the times, Father. Who needs a keen mind when you have this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[44]`
Mówca: **Rico Toras**
> ""As His Majesty proclaims, so it shall be!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Rico Toras**
> ""I'm already equipped, myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""We have outfits prepared for the two of you. And your choice of weapons, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want a KA-74, same as Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll be a good old-fashioned rifle for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[49]`
Mówca: **Rico Toras**
> ""See, Father? We'll have bagged a dozen boars before you've even finished loading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""You see, boy, there are still real gentlemen in this world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Hugo smirked at his son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Inside, Vina and I quickly refreshed ourselves and changed into the hunting garb that had been laid out for us. We stepped out to find two waiting jeeps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`
  - -> `[305]`

### Węzeł `[53]`
Mówca: **Narrator**
> "I turned away from the window to see Rico looking at me intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[57]`
Mówca: **Rico Toras**
> ""You must already know what I'm about to say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[58]`
Mówca: **Rico Toras**
> ""I remember a time when you were chomping at the bit to speak in front of Su Omina. Now you regard us -- them -- as criminals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[64]`
  - -> `[66]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget to whom you are speaking, Duke Toras. Count yourself lucky I haven't ordered your arrest yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
Mówca: **Rico Toras**
> ""I knew you didn't approve of the company I keep here in Iza. But to accuse us -- them -- of terrorism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[64]`
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no other choice. I'm trying to avoid an international incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[65]`
Mówca: **Rico Toras**
> ""What I meant to say was... the Zille attack wasn't us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen has every reason to suspect Su Omina's involvement in what happened. As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Rico Toras**
> ""Of course, of course. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[68]`
Mówca: **Rico Toras**
> ""Trust me, nobody I know has a clue who was behind the Zille attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need names. The investigation will turn up the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A bold suggestion, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Rico Toras**
> ""Would you expect anything less of the Duke of Iza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[351]`
  - -> `[353]`
  - -> `[356]`

### Węzeł `[72]`
Mówca: **Rico Toras**
> ""The drugs, the violence, the open resistance against our government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`
  - -> `[394]`
  - -> `[395]`
  - -> `[396]`

### Węzeł `[73]`
Mówca: **Rico Toras**
> ""I wanted to thank you for your understanding, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[74]`
Mówca: **Narrator**
> "I turned away from the window to see my cousin smiling at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just between us... did Su Omina plan the attack?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Rico Toras**
> ""That's the funny thing. Nobody I've spoken to has a clue who did it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A false flag if I ever saw one. Wehlen obviously planned the bombing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to thank me. I was protecting myself as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What choice did I have? Members of our house must stand by each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[80]`
Mówca: **Rico Toras**
> ""Killing a few of their own means nothing to them. They're like ants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[81]`
  - -> `[83]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you no compassion, son? Those are human beings who died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your mouth. It's that kind of language that made Wehlen suspect Su Omina in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Rico Toras**
> ""Come now, I'll teach you. It'll be great fun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""I do wish I'd known about these plans. I've never so much as held a gun before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Why stop there? Why not hire an airplane and shoot them from the sky?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[90]`
Mówca: **Rico Toras**
> ""Nonetheless, I appreciate it. Especially since the organization is entirely innocent in this matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`
  - -> `[419]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Vina suddenly tapped me on the shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Vina Toras**
> ""Father? Look over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[93]`
Mówca: **Narrator**
> "His security let us through to the Duke's residence, a blindingly white building with the flags of Rizia and House Toras hanging from every window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""Hugo's meeting us here too, right? Why do you think they wanted us here so badly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[96]`
  - -> `[714]`
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect the Golden Guard investigation I ordered will be the main topic of discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my guesses. We'll see if they're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To see something like those statues, I wager. Give us an inkling of the pressure Rico is under.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The family hasn't been all together in ages. It's about time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The invitation coming so soon after the Zille incident is no coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""I can't even remember the last time Cousin Rico and I properly spoke. When we were children, maybe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "We rode on until we reached Palas Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[105]`
Mówca: **Rico Toras**
> ""Caught the scent already, my dears? Must be dozens of boars out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""But I've bored you enough, Your Highness. I believe Rico was going to show you the ropes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I was hoping *I* could escort my daughter on her first hunt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[108]`
Mówca: **Rico Toras**
> ""I would be delighted to. If the King permits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead, Vina. I hear Rico is an excellent shot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not my decision. Do you want to go with him, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_Hunting_KA74 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Hugo smoothly stepped between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[115]`
Mówca: **Narrator**
> "He extended his hand to my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[109]`
  - -> `[110]`

### Węzeł `[116]`
Mówca: **Narrator**
> "An assistant handed me my KA-74. It was slightly different than the one I'd handled in my army days, but felt reassuringly familiar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[117]`
Mówca: **Narrator**
> "An assistant handed me my rifle. It was a Rizian-made Dator 56, similar to the one I'd used during my summers hunting with Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Vina took Rico's hand. With a smile, he picked up their guns and walked her over to one of the blinds, dogs in tow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Narrator**
> "An assistant handed me my KA-74. It was much heavier than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Narrator**
> "An assistant handed me my rifle. It was a Rizian-made Dator 56. Clunkier than the one I'd used in the military, but usable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "An assistant handed me my rifle, a Rizian-made Dator 56. It was more awkward to hold than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""My son may aim for quantity. But men like us know quality is key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""You and my son may aim for quantity. But I know quality is key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "He locked and loaded his own Dator rifle. Its stock had a gold-embossed bull on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "We climbed up into the hunting blind opposite of Vina and Rico's position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""I may not like Rico's hunting methods, but his dogs are second to none. They'll drive the boars out in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[502]`
  - -> `[137]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why were you so keen that he and Vina go off together?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico's a shrewd kid. Takes after his father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Hugo Toras**
> ""You're too kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""If my son and your daughter are to be married, they ought to spend time together first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's up to Vina to choose her own husband. And I doubt her cousin ranks high on the list of candidates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He calmly adjusted his rifle's sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I have. But the two of them turned out as different as night and day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shockingly enough, the thought never crossed my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might have if your son were more of a gentleman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""Choose your words carefully, Your Majesty. You're referring to the last male scion of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""As you know, there are interests both inside and outside this country who seek to snatch Rizia away from House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Just then, we heard a rustling sound coming from the woods. Bella and Bruno had found their quarry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "A group of boars raced into the clearing, the dogs nipping at their heels. Working in tandem, they forced their prey into the lowest part of the glade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "Shoot a boar."]** — Mówca: **Player_Romus_Italic**
> "I took aim and pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
**[WYBÓR GRACZA: "Miss intentionally."]** — Mówca: **Player_Romus_Italic**
> "I aimed slightly to the right and pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_Hunting_KA74 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[158]`
Mówca: **Narrator**
> "As I gripped the KA-74, my military training took over. I fired a flurry of bullets into the group of boars. One after another fell to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Narrator**
> "The assault rifle was more unwieldy than the ones I was used to, but I managed to hit the largest boar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[166]`
Mówca: **Narrator**
> "I struggled to keep the gun steady as it unleashed a round of bullets. The boars scattered in all directions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[167]`
Mówca: **Narrator**
> "The largest boar fell to the ground. The others scattered in all directions, squealing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Narrator**
> "My first shot managed to hit the largest boar. I fired again and hit another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[175]`
Mówca: **Narrator**
> "I struggled to keep the gun steady as it fired. The shot went wide, and the boars scattered in all directions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[176]`
Mówca: **Rico Toras**
> ""Bruno!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Rico jumped down from his blind and raced into the clearing. The dog lay on his side, whimpering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[178]`
Mówca: **Narrator**
> "The others squealed as they scattered. A flurry of bullets came from Rico's blind, and one boar after another fell to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""Well done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[181]`
Mówca: **Narrator**
> "As I turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
Mówca: **Narrator**
> "By the end of the hunt, I'd racked up six kills. Hugo had four, and Rico had a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Narrator**
> "By the end of the hunt, Hugo had four kills and Rico and I had both racked up about a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "He and my daughter were deep in conversation as they climbed down from their blind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""Hmph. Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[186]`
Mówca: **Narrator**
> "By the end of the hunt, I had zero kills. Hugo had six, and Rico had racked up a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[187]`
Mówca: **Rico Toras**
> ""Lyza this, Lyza that. I'm telling you, if the Wehlen Civil War had happened while Grandmother was still in power, she wouldn't have set out the welcome mat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[188]`
Mówca: **Narrator**
> "My shot went just wide of where the boars were. They scattered in all directions, squealing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[192]`
Mówca: **Hugo Toras**
> ""Ha! Well done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Hugo Toras**
> ""Been too long, has it? Allow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[194]`
Mówca: **Narrator**
> "As I turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Narrator**
> "I got through the rest of the hunt without any additional kills. Hugo racked up four; Rico, a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[196]`
Mówca: **Hugo Toras**
> ""Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[197]`
Mówca: **Narrator**
> "In one swift motion, he aimed and fired his rifle. The largest of the boars fell to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Narrator**
> "As we turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[199]`
Mówca: **Narrator**
> "By the end of the hunt, I'd racked up four kills. Hugo had six, and Rico had a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[200]`
Mówca: **Narrator**
> "By the end of the hunt, I'd racked up six kills. Hugo had four, and Rico had a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[201]`
Mówca: **Hugo Toras**
> ""Well done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Narrator**
> "As I turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""Hmph. Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[204]`
Mówca: **Hugo Toras**
> ""Hmph. Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_Hunting_KA74 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "I heard a squeal, then a thud. To my surprise, I'd hit one of the boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[209]`
Mówca: **Narrator**
> "Hugo, Vina and I climbed down as Rico frantically ripped off a piece of his shirt and wrapped it tight around Bruno's bleeding leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[210]`
Mówca: **Rico Toras**
> ""What the hell, cousin? You shot my dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`
  - -> `[213]`
  - -> `[214]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refer to me as 'Your Majesty'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not my fault. I was aiming for the boar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a scratch. He'll be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my first time with a KA-74. I got flustered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Rico Toras**
> ""You don't fucking say!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Vina Toras**
> ""Why not? I've had enough father-daughter time lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[220]`
Mówca: **Vina Toras**
> ""Yes, I'd love to. We didn't even get a chance to speak at the coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[221]`
Mówca: **Rico Toras**
> ""Bella! Bruno! Sit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[222]`
Mówca: **Vina Toras**
> ""I'm telling you, if Wehzeks and Derdians were granted the same rights as native Rizians, none of this would be happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[226]`
Mówca: **Vina Toras**
> ""No! Lyza would have honored Rizia and Wehlen's long history of cooperation, and shown compassion for those who suffered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Rico Toras**
> ""You naive little girl. Everyone in Merkopa wants what we Rizians have. The Wehzeks saw a chance to get it, and they jumped on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Narrator**
> "He flung his gun on the ground in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Rico Toras**
> ""I'm afraid your daughter didn't shoot a damn thing on today's hunt, Your Majesty. She was too busy distracting me with her nonsense opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[244]`
  - -> `[245]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina is your intellectual superior in every way, you twit. You will apologize to her. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[231]`
Mówca: **Rico Toras**
> ""He can't hunt on three fucking legs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[232]`
Mówca: **Rico Toras**
> ""Excuse me. His Majesty King Romus Toras shot my fucking dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[233]`
Mówca: **Rico Toras**
> ""Next time, aim at your own fucking head!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[234]`
Mówca: **Vina Toras**
> ""Please, Rico. It was an accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Vina Toras**
> ""Honestly, Father! Why choose such a dangerous weapon if you don't know how to use it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Vina bent down and stroked Bruno's fur. The dog raised his head slightly and licked her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[240]`
Mówca: **Hugo Toras**
> ""Rico, Vina, why don't you two take Bruno back to the palace? His Majesty and I will wrap everything up here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[241]`
Mówca: **Narrator**
> "She put her hand on Rico's shoulder. He forced himself to take a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[242]`
Mówca: **Rico Toras**
> ""You're right. It'd be worse. Rizia would have collapsed under the strain of providing for its own as well as millions of foreign parasites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Vina Toras**
> ""Parasites? They mine our gold and farm our crops, you idiot. If anyone's a parasite, it's the nobles siphoning wealth from their labor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've done well enough for all four of us. Congratulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, we're guests here in Iza. Apologize to Rico now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[246]`
Mówca: **Narrator**
> "He seemed to collect himself for a moment, then smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[247]`
Mówca: **Rico Toras**
> ""Thank you. You didn't make out too poorly yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[248]`
Mówca: **Narrator**
> "My uncle gave me a meaningful glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you two go on. I'm truly sorry, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Hugo should go with you. I'll travel with the princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[251]`
Mówca: **Narrator**
> "Rico seemed to collect himself for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Rico Toras**
> ""I accept your apology. And this won't affect the agreement we made today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[256]`
Mówca: **Rico Toras**
> ""I accept your apology. I hope you'll give extra consideration to my police request, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Rico seemed like he was about to object, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Rico Toras**
> ""As you wish, Your Majesty. This won't affect the agreement we made today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[262]`
Mówca: **Rico Toras**
> ""Go on, then. I hope you'll give extra consideration to my police request, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[263]`
Mówca: **Narrator**
> "He seemed to collect himself for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Rico Toras**
> ""I'm sorry, Your Highness. I must have gotten carried away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Vina looked sullenly at the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Vina Toras**
> ""Sorry, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Rico Toras**
> ""Thank you. I wish I could say the same to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Narrator**
> "We posed for photographs next to the boars we'd killed. The assistants began packing everything away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Rico and Hugo posed for photographs next to the boars they'd killed. The assistants began packing everything away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_ShootToMiss = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""We'll eat well tonight. The chef at Palas Sazon does an excellent braised boar with wine sauce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Hugo Toras**
> ""Rico, Vina, why don't you two ride ahead and notify the kitchen staff? His Majesty and I will be right behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Narrator**
> "Vina gave me a pleading look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[280]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, go ahead. One last chance for you two to have a civil conversation before we leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you go with your son, Hugo? I'll accompany the princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Hugo raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Vina grimaced at me as Rico led her to one of the waiting jeeps. Hugo and I got into the second, and the four of us headed back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Narrator**
> "Dinner that night was indeed delicious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""As you wish. Come along, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Vina silently thanked me as Rico and Hugo departed. We climbed into the second jeep and headed back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[289]`
Mówca: **Narrator**
> "The assistants carefully placed Bruno on a blanket in the back of one of the jeeps. Hugo and Rico got in, and the car sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Narrator**
> "Vina and I got into the other jeep and followed them back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Narrator**
> "We left for Porte Drazon without staying for dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[292]`
Mówca: **Narrator**
> "The assistants carefully placed Bruno on a blanket in the back of one of the jeeps. Vina and Rico got in, and the car sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Narrator**
> "Hugo and I got into the other jeep and followed them back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[294]`
Mówca: **Narrator**
> "He calmly aimed his rifle towards the glade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Rico_ShotDog = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[296]`
Mówca: **Narrator**
> "I noticed most of the people who'd come out to see us were native Rizian -- even on the streets of the city's Wehzek quarter, Little Wraclawitz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[297]`
Mówca: **Narrator**
> "He gave me a quick bow of acknowledgement, then knelt and kissed Vina's hand. I was struck by his transformation from a gawky, insecure teen to a broad-shouldered, preternaturally confident young man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[298]`
Mówca: **Vina Toras**
> ""Wait. What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[25]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[32]`
  - -> `[34]`

### Węzeł `[302]`
Mówca: **Rico Toras**
> ""What a splendid idea. Remind me to plan that for next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll ride with Duke Rico. I have much to discuss with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, care to share a car with your old man?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, shall we ride together and let the children catch up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Narrator**
> "Rico swiftly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Narrator**
> "Rico nodded. An aide held the door open, and we hopped into the first car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[308]`
Mówca: **Rico Toras**
> ""If you don't mind, Your Majesty, I've had this car prepared for the two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Narrator**
> "He gestured to his aide, who held the door of the first jeep open. The two of us stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[310]`
Mówca: **Narrator**
> "East of the palace, the landscape quickly turned hilly and green. We were entering the Brenas Forest Estate, a private hunting ground reserved for nobility only."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[311]`
Mówca: **Rico Toras**
> ""Well, I humbly request that you try harder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Rico Toras**
> ""Whatever you may think of us, Su Omina didn't plan the Zille attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[313]`
Mówca: **Rico Toras**
> ""Though I can't say I wasn't happy to see those Wehzeks get what was coming to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`
  - -> `[316]`
  - -> `[318]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For heaven's sake, son, have some respect for the dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll get what's coming to you if you carry on with that kind of talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
Mówca: **Narrator**
> "A light smirk formed on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you want me to believe your organization is completely innocent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Rico Toras**
> ""In Wehlen? Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
Mówca: **Rico Toras**
> ""Excuse me. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[321]`
Mówca: **Rico Toras**
> ""We were all thinking it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[322]`
Mówca: **Rico Toras**
> ""The point is that your investigation into us will turn up nothing. About Wehlen, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
Mówca: **Rico Toras**
> ""Your investigation into us will turn up nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Rico Toras**
> ""But if you want this mess cleared up in time for Zille to be returned, I think I can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`
  - -> `[335]`

### Węzeł `[331]`
Mówca: **Rico Toras**
> ""The point is that President Smolak's accusations are based on nothing. Just his own vendetta against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[332]`
Mówca: **Rico Toras**
> ""Smolak's accusations are based on nothing. Just his own vendetta against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't believe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In exchange for what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[336]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Rico Toras**
> ""The people in my organization are loyal to me, Your Majesty. Very loyal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
Mówca: **Rico Toras**
> ""Aside from getting your Golden Guard off Su Omina's tail? Nothing. I wouldn't dare to bargain with my cousin and my King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[339]`
Mówca: **Rico Toras**
> ""Regardless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[340]`
Mówca: **Rico Toras**
> ""If one or two of them were to confess to the attack, as a splinter cell acting independently of both Su Omina and the crown, it'd solve both of our problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[70]`
  - -> `[345]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're offering to commit a crime on my behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen's investigators aren't stupid. They'd uncover the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Rico Toras**
> ""Not if the truth is that Wehlen itself was behind the attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Rico Toras**
> ""My hunch is, they're counting on Rizia to deny the crime so they can postpone the Zille handover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Rico Toras**
> ""By handing over my men, we'd be calling their bluff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[351]`
  - -> `[353]`
  - -> `[356]`

### Węzeł `[349]`
Mówca: **Rico Toras**
> ""In time to get Zille back by the end of the year? I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[357]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Rico Toras**
> ""I'm not offering anything. Just pointing out how convenient it would be should such a confession occur.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[351]`
  - -> `[353]`
  - -> `[356]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just how loyal are these scapegoats you're proposing? Would they crack under interrogation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the fact that this would put a premature end to my investigation into Su Omina? A nice little bonus for you, I presume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the gesture. But I can't condone this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care how long it takes. I won't stoop to the kind of tactics you're suggesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It *would* be convenient to put this incident behind us as fast as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[359]`
Mówca: **Rico Toras**
> ""Trust me, cousin. If it came down to that, I have the resources to make sure their loved ones are well cared for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[382]`
  - -> `[370]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Rico Toras**
> ""And you as well. Don't forget your own history with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[382]`
  - -> `[370]`

### Węzeł `[364]`
Mówca: **Rico Toras**
> ""And you as well. Don't forget that we're related.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[382]`
  - -> `[370]`

### Węzeł `[365]`
Mówca: **Rico Toras**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Narrator**
> "He winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[369]`

### Węzeł `[367]`
Mówca: **Rico Toras**
> ""I-- Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[368]`
Mówca: **Rico Toras**
> ""Just say the word, cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[382]`
  - -> `[370]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not code, Rico. Come forth with false suspects, and I'll have your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* it were to emerge that said suspects were lying, the order for them to come forward would never be traceable back to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Rico Toras**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[372]`
Mówca: **Rico Toras**
> ""Oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Rico Toras**
> ""Never mind, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Narrator**
> "Rico looked away for a moment. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[375]`
Mówca: **Narrator**
> "Rico nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats = true; RiziaDLC.Security_GoldenGuard_InvestigateSO = false; RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 2;
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true;
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] = false;
Variable["RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 2;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we have an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, no. I won't go along with this plan. Your organization must be held accountable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Rico Toras**
> ""Carry on with your investigation and forget I mentioned anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[380]`
Mówca: **Rico Toras**
> ""I-- well within your right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[381]`
Mówca: **Rico Toras**
> ""Carry on with your investigation and forget I said anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. Let's try this your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe I'm even entertaining this thought. The answer is no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[384]`
Mówca: **Rico Toras**
> ""I-- thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Rico Toras**
> ""I'll make the arrangements as soon as we get back into the city. And thank you in advance for ending that useless investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Rico Toras**
> ""I'll make the arrangements as soon as we get back into the city. And thank you in advance for ending that useless investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats = true; RiziaDLC.Security_GoldenGuard_InvestigateSO = false; RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 2;
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true;
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] = false;
Variable["RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 2;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Narrator**
> "We drove on. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If there's anything else you'd like to bring up with your king, now is the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you faring as Duke of Iza, my cousin? Be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Narrator**
> "Rico eagerly turned back toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Rico Toras**
> ""I'm sure you've been kept abreast of the situation here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The headless statues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not a child, Rico. Pull yourself together and become the leader this city needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't seem that bad to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's concerning indeed. What can I do to help?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[397]`
Mówca: **Rico Toras**
> ""You weren't supposed to see those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[398]`
Mówca: **Rico Toras**
> ""I'm trying. But I can't do it without reinforcements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[399]`
Mówca: **Rico Toras**
> ""Sooner or later, it will add up to something greater than its parts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Rico Toras**
> ""I'm glad you asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Rico Toras**
> ""I've heard that in times of emergency, police from the Rizian central forces can be placed under individual leaders' direct command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Rico Toras**
> ""I've petitioned your War and Security Councilor for just such a transfer, but she refused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`
  - -> `[405]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rightly so. You should be cooperating with the greater province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're using your family connections to go over her head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She made a mistake. The Brenas police cannot be counted on to help you keep the peace here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[406]`
Mówca: **Rico Toras**
> ""You mean with the Sazons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Rico Toras**
> ""Well... yes. I don't see another alternative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[408]`
Mówca: **Rico Toras**
> ""If anything, they are actively working against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[409]`
Mówca: **Narrator**
> "He snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Rico Toras**
> ""They can't be counted on to cooperate. If anything, they're actively plotting against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Rico Toras**
> ""You understand that this city is a bellwether for our house. If we lose it, we lose Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Rico Toras**
> ""I'll send you the petition when we are both back home. I trust you to do what's best for our city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[413]`
Mówca: **Rico Toras**
> ""I know the Wehzeks were pressuring you to denounce Su Omina. You very wisely saw their witch hunt for what it was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[77]`
  - -> `[84]`
  - -> `[706]`

### Węzeł `[414]`
Mówca: **Rico Toras**
> ""Although we weren't sorry to hear those Wehzeks got what was coming to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[81]`

### Węzeł `[415]`
Mówca: **Narrator**
> "Rico smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Rico Toras**
> ""I will let you in on a secret, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure I believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's clearly a ruse planned by the Wehzeks themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They're upstanding citizens. I can't imagine they would stoop to violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Rico Toras**
> ""No, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[421]`
Mówca: **Rico Toras**
> ""You don't have to. But I'm telling you the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[422]`
Mówca: **Narrator**
> "Rico contorted his mouth into an approximation of a frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Rico Toras**
> ""Of course. It was a terrible tragedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[424]`
Mówca: **Rico Toras**
> ""It's just us here in this car, isn't it? We can tell it like it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Rico Toras**
> ""Speaking of which... I'll let you in on a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Rico Toras**
> ""Just prior to the incident, we were about to activate a branch of Su Omina in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[431]`
  - -> `[430]`
  - -> `[429]`

### Węzeł `[427]`
Mówca: **Rico Toras**
> ""They'll be exposed soon enough. They aren't intelligent enough to cover their own tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[428]`
Mówca: **Narrator**
> "He glanced at me conspiratorially."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're not still planning on going through with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean, 'activate?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would have been an idiotic thing to do without the King's permission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To what end, precisely?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[433]`
Mówca: **Rico Toras**
> ""Why shouldn't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Rico Toras**
> ""Smolak was never going to hand Zille over on a silver platter. We'll only get back what's ours if we put the screws to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[435]`
Mówca: **Rico Toras**
> ""The region is teeming with Rizian loyalists anyway. All they need is a spark.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't condone this, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Define 'mess with.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[438]`
Mówca: **Rico Toras**
> ""Of course anyone we sent up there would have to operate in total secrecy. But wouldn't it be fun to mess with the Wehzeks?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`
  - -> `[443]`
  - -> `[446]`

### Węzeł `[439]`
Mówca: **Rico Toras**
> ""No, Your Majesty. Of course you can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[440]`
Mówca: **Narrator**
> "He winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[450]`
  - -> `[451]`

### Węzeł `[441]`
Mówca: **Rico Toras**
> ""Nothing as extreme as the bombing, mind you. We'd just spread the word about the benevolence of King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already have one pro-Rizian organization active in Zille. I don't need two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It wouldn't hurt to have more of an upper hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[447]`
Mówca: **Rico Toras**
> ""With or without some light coercion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`
  - -> `[457]`

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Were your group's activities in Zille to be revealed, I would proclaim complete ignorance of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Rico Toras**
> ""Quite right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not code. If I hear about any Su Omina activity north of the Wehlen border, I'll have your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seriously, I appreciate the offer, but I don't want to put your organization at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[452]`
Mówca: **Rico Toras**
> ""We wouldn't interfere with whatever you have in motion. We'd simply spread the word about the benevolence of King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[453]`
Mówca: **Rico Toras**
> ""I-- understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Rico Toras**
> ""I was only trying to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A tempting proposition, but I wouldn't want to put you or your organization at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More people should be aware of my benevolence, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not like you. I don't need brute force to accomplish my goals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[458]`
Mówca: **Rico Toras**
> ""That should be the least of your worries. We know how to protect ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[459]`
Mówca: **Rico Toras**
> ""Consider us your flag bearers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[460]`
Mówca: **Rico Toras**
> ""You might not *need* it. But it makes for a fine insurance policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[461]`
Mówca: **Rico Toras**
> ""So... we have an understanding, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`
  - -> `[465]`

### Węzeł `[462]`
Mówca: **Narrator**
> "Rico looked away for a moment. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[463]`
**[WYBÓR GRACZA: ""Yes. We are in agreement." [-2 Budget, -250 Military Equipment]"]** — Mówca: **Player_Romus**
> ""Yes. We are in agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[464]`
**[WYBÓR GRACZA: "Nod. [-2 Budget, -250 Military Equipment]"]** — Mówca: **Player_Romus_Italic**
> "I nodded wordlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually... no. You are to limit Su Omina's activity to within Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[466]`
Mówca: **Rico Toras**
> ""You don't have to get your hands dirty, cousin. Just say the word if you want our assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`
  - -> `[465]`
  - -> `[467]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know how much clearer I can make this. My answer is no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[468]`
Mówca: **Narrator**
> "Rico grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[469]`
Mówca: **Rico Toras**
> ""The Crown has much to gain from this arrangement, Your Majesty. And not only in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Narrator**
> "We kept driving. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive = true;
RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO = true;
RiziaDLC.Resources_Military_Equipment -= 250;
RiziaDLC.Resources_Budget -= 2;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2;
RiziaDLC.Zille_ViolentResistancePower += 1;
RiziaDLC.LeaningValue_Democratic -= 2;
RiziaDLC.FundedSO += 1;
RiziaDLC.DeployedSO += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO"] = true;
Variable["RiziaDLC.Resources_Military_Equipment"] = Variable["RiziaDLC.Resources_Military_Equipment"] - 250;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 2;
Variable["RiziaDLC.FundedSO"] = Variable["RiziaDLC.FundedSO"] + 1;
Variable["RiziaDLC.DeployedSO"] = Variable["RiziaDLC.DeployedSO"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[472]`
Mówca: **Narrator**
> "We pulled off the road and continued some distance on a dirt path that wound through the pines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Narrator**
> "We came to a halt at the mouth of a grassy clearing with gently sloping sides. Hunting blinds lined its perimeter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Narrator**
> "In my youth, Hugo and I had nicknamed it the 'Soup Tureen'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Narrator**
> "It vaguely resembled a gigantic serving vessel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Rico Toras**
> ""At last! Enough politics talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Narrator**
> "We disembarked and Rico eagerly unlatched the back of our jeep. Bella and Bruno hopped out and started sniffing the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[481]`
Mówca: **Narrator**
> "The other car pulled up next to us. Hugo and Vina got out, still in conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[482]`
Mówca: **Hugo Toras**
> ""...so you see, Your Highness, knowing how to aim and fire a gun correctly is as useful a royal skill as knowing how to hold a salad fork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`
  - -> `[485]`
  - -> `[486]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep at it, Hugo. You'll make a huntress out of my daughter yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the essential difference that lettuce doesn't bleed when you pierce it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you two enjoyed the car ride?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't listen to Hugo, Vina. Your uncle's a notoriously terrible shot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Narrator**
> "Hugo scowled at me briefly. He waved his son over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[488]`
Mówca: **Hugo Toras**
> ""It's always a pleasure to get to know the princess better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Narrator**
> "He waved his son over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[490]`
Mówca: **Hugo Toras**
> ""I've bored you enough, Your Highness. I believe Rico was going to show you the ropes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[491]`
Mówca: **Narrator**
> "Hugo chuckled politely. He waved his son over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[492]`
Mówca: **Hugo Toras**
> ""With her instincts, she'll be the finest shot this kingdom ever saw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[493]`
Mówca: **Hugo Toras**
> ""Why not let the youngsters have their fun? Old men like us would slow them down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Rico Toras**
> ""You're damned right about that, Father. Shall we, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Narrator**
> "He beckoned to Vina again. She hesitantly followed him over to the nearest hunting blind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[496]`
Mówca: **Narrator**
> "Hugo shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[497]`
Mówca: **Hugo Toras**
> ""The two of us it is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_KA74 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Hunting_Rifle = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[500]`
Mówca: **Hugo Toras**
> ""And now we play the waiting game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[501]`
Mówca: **Narrator**
> "There was a long stretch of silence, punctuated only by the chirping of birds and the occasional bark of Bella and Bruno in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't help but think you and he had an ulterior motive for inviting us here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[503]`
Mówca: **Hugo Toras**
> ""And yet night and day are inseparable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[504]`
Mówca: **Hugo Toras**
> ""Her cousin once removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[505]`
Mówca: **Hugo Toras**
> ""Consanguinity wouldn't be my first choice, either. But it's the only way to keep our family in power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[518]`
  - -> `[519]`
  - -> `[522]`

### Węzeł `[506]`
Mówca: **Hugo Toras**
> ""That is indeed shocking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[507]`
Mówca: **Hugo Toras**
> ""What are Her Highness' other options? A rival house? A foreign prince? Anyone other than Rico would dilute our family's blood and loosen our grip on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[518]`
  - -> `[519]`
  - -> `[522]`

### Węzeł `[508]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? No! They're cousins!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Hugo Toras**
> ""Once removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[510]`
Mówca: **Hugo Toras**
> ""But more pressingly, if my son and your daughter are to be married, they ought to spend time together first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[511]`
Mówca: **Narrator**
> "He calmly adjusted his rifle's sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
Mówca: **Hugo Toras**
> ""Of course there's the nastiness with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[513]`
Mówca: **Hugo Toras**
> ""So you'll consider him as a marriage prospect for your daughter, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[508]`
  - -> `[514]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never said that. Vina deserves to marry a gentleman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[515]`
Mówca: **Hugo Toras**
> ""Or have you seriously never considered the possibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[146]`
  - -> `[147]`
  - -> `[508]`

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point, but it's still Vina's decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Hugo Toras**
> ""Letting youngsters 'follow their hearts' is a recipe for disaster. My brother was the ultimate example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's see how they get along today before we start making wedding arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our family has been in power long enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Hugo Toras**
> ""Not as long as God has preordained.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[521]`
Mówca: **Hugo Toras**
> ""Fair enough. Rico can be quite the charmer when he sets his mind to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The right alliances can make us more powerful than blood alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Hugo Toras**
> ""And the wrong ones will doom us to history's dustbin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[524]`
Mówca: **Hugo Toras**
> ""As your uncle and your advisor, this is my advice. You may follow or disregard it as you choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[525]`
Mówca: **Narrator**
> "Looking through my gun sight, I fixed my crosshairs on the group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[526]`
Mówca: **Narrator**
> "My uncle gave me a look of disapproval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[527]`
Mówca: **Narrator**
> "He looked up at me with almost feral eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[528]`
Mówca: **Hugo Toras**
> ""For God's sake, Rico, shut your mouth!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[529]`
Mówca: **Hugo Toras**
> ""My deepest apologies, Your Majesty. My son's not in his right mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[530]`
Mówca: **Rico Toras**
> ""Please excuse my outburst, Your Majesty. I understand you weren't aiming for Bruno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Rico Toras**
> ""But what good is a hunting dog who can't hunt?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[540]`
  - -> `[536]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still holding a gun. Put him out of his misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Vina Toras**
> ""What? Father! No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[534]`
Mówca: **Narrator**
> "Rico looked at me, appalled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Rico Toras**
> ""How big of an asshole do you think I am, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[556]`
  - -> `[557]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Put him out to stud. I bet he's got good blood, doesn't he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Narrator**
> "Rico half-smirked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Rico Toras**
> ""A purebred through and through, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Rico Toras**
> ""All right. I'll keep the poor fellow around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll take him, then. I wouldn't mind having a dog around the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[541]`
Mówca: **Narrator**
> "Vina's eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Vina Toras**
> ""Really, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`
  - -> `[544]`
  - -> `[543]`

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I shot the poor fellow. He's my responsibility now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who knows what your brute of a cousin will do to him if I don't take him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A three-legged royal dog? The public will love it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Narrator**
> "Rico looked down at his dog."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Rico Toras**
> ""Well, Bruno? You want to go live in Porte Drazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[548]`
Mówca: **Narrator**
> "Rico looked at me and shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Rico Toras**
> ""Very well, Your Majesty. He eats only raw meat. Venison, if you have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Rico Toras**
> ""Take good care of him. And this won't affect the agreement we made today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[554]`
Mówca: **Rico Toras**
> ""Take good care of him. And I hope you'll give extra consideration to my police request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't care about dead Wehzeks, but you care about an injured dog?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. That was a joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said it yourself. He's useless on three legs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[558]`
Mówca: **Rico Toras**
> ""No, no. I'll find something to do with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[559]`
Mówca: **Vina Toras**
> ""It wasn't funny, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[560]`
Mówca: **Rico Toras**
> ""Wehzeks are expendable. Bruno is a royal pedigree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Rico Toras**
> ""Actually... if he can't hunt, I can still put him out to stud. Wouldn't want to let a good bloodline go to waste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[562]`
Mówca: **Narrator**
> "He half-smirked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[563]`
Mówca: **Rico Toras**
> ""Let's take him home. I'll figure out what to do with him there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted = true; RiziaDLC.Relations_Vina += 1; RiziaDLCSupport.Journal_Turn03_Iza_AdoptBruno = true;
RiziaDLCSupport.News_RH_Turn03_Gossip_BrunoAdopted = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BrunoDog_Adopted"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;
Variable["RiziaDLCSupport.Journal_Turn03_Iza_AdoptBruno"] = true;
Variable["RiziaDLCSupport.News_RH_Turn03_Gossip_BrunoAdopted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[568]`
Mówca: **Narrator**
> "He got to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[569]`
Mówca: **Hugo Toras**
> ""Rico, Vina, why don't you two take Bruno back to the palace? His Majesty and I will wrap everything up here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[570]`
Mówca: **Narrator**
> "My uncle gave me a meaningful glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you two go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'd prefer to travel with the princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[573]`
Mówca: **Narrator**
> "Vina nodded solemnly and turned to Rico."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[574]`
Mówca: **Vina Toras**
> ""You can tell me more about Bruno on the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[578]`
Mówca: **Vina Toras**
> ""Let's go, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[579]`
Mówca: **Narrator**
> "The assistants carefully placed Bruno on a blanket in the back of one of the jeeps. Hugo and Rico got in, and the car sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[580]`
Mówca: **Narrator**
> "My daughter and I got in the other car and followed them back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[581]`
Mówca: **Narrator**
> "Vina looked at me coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[582]`
Mówca: **Vina Toras**
> ""If it's quite all right, I'll go with Rico. He can tell me more about Bruno on the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[583]`
Mówca: **Narrator**
> "In front of the university library, a construction crew was hastily pulling a sheet over a large object."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[584]`

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop the car at once. I want to see what's under that sheet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have time to stop. Let's just get to Rico's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[586]`
Mówca: **Narrator**
> "We came to a halt. My guards exited the car and ordered the workers to remove the sheet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[590]`
Mówca: **Narrator**
> "Beneath it was one of the statues I'd commissioned of my father, King Valero."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[591]`
Mówca: **Narrator**
> "His head had been chopped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`
  - -> `[601]`
  - -> `[599]`
  - -> `[600]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`
  - -> `[594]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[595]`
Mówca: **Narrator**
> "Beneath it was one of the statues I'd commissioned earlier in my reign, depicting myself standing beside my father King Valero."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[596]`
Mówca: **Narrator**
> "Both of our heads had been chopped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[601]`
  - -> `[599]`
  - -> `[600]`

### Węzeł `[597]`
Mówca: **Narrator**
> "Beneath it was one of the statues I'd commissioned earlier in my reign, depicting the Toras lineage: my father, myself, and Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[598]`
Mówca: **Narrator**
> "All of our heads had been chopped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[601]`
  - -> `[599]`
  - -> `[600]`

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is an outrage. The guilty party must be found and punished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could Rico have allowed this to happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks like the good people of Iza are exercising their freedom of expression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Vina. It's only my father they're mad at, not you or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Vina. I'm sure it's just teenage vandals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[607]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[608]`
Mówca: **Vina Toras**
> ""I'm not worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[609]`
Mówca: **Narrator**
> "Her face looked noticeably paler. She unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[610]`
Mówca: **Narrator**
> "She wore a bemused expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[613]`

### Węzeł `[612]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[614]`
Mówca: **Vina Toras**
> ""You're not worried, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[615]`
Mówca: **Vina Toras**
> ""Today it's statues they're beheading, tomorrow...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[616]`
Mówca: **Narrator**
> "Vina laughed grimly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[617]`
Mówca: **Vina Toras**
> ""Do you think Rico wanted us to see this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[618]`
Mówca: **Vina Toras**
> ""He's trying to crack down on crime here, isn't he? What better excuse than sedition against the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`
  - -> `[639]`
  - -> `[640]`
  - -> `[641]`

### Węzeł `[619]`
Mówca: **Vina Toras**
> ""It's certainly not a warm welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a good theory, Vina. You're as perceptive as your mother was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[621]`
Mówca: **Vina Toras**
> ""I wonder if Rico wanted us to see this. He's trying to crack down on crime here, isn't he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[622]`
Mówca: **Vina Toras**
> ""What better excuse than sedition against the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`
  - -> `[626]`
  - -> `[627]`
  - -> `[624]`

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he can't keep a few troublemakers from defacing statues, he's not fit to be in charge here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a good theory, Vina. You're as perceptive as your mother was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[625]`
Mówca: **Narrator**
> "Vina unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Sedition' is a strong word. This is just some light hooliganism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[627]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's his strategy, it's not a very smart one. He's allowing the authority of House Toras to be undermined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Narrator**
> "Her face looked noticeably paler. She unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[632]`
Mówca: **Vina Toras**
> ""It's certainly not a warm welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[633]`
Mówca: **Narrator**
> "Vina laughed bleakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[636]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[637]`
Mówca: **Vina Toras**
> ""Like Duchess Azaro said, he's in over his head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[638]`
Mówca: **Narrator**
> "She unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he can't keep vandals from defacing royal statues before the King's visit, he doesn't deserve my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Either way, this is a disgrace. Order must be brought to Iza one way or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is bigger than just Iza. The anti-monarchist foreign powers are out to get us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[642]`
Mówca: **Vina Toras**
> ""If there's a revolution coming, it doesn't need House Toras' permission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[643]`
Mówca: **Narrator**
> "Vina laughed bleakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Talk to me, Vina. What's going on with you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the attitude. You're the Princess of Rizia and I want you on your best behavior for this visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[649]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I didn't comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[650]`
Mówca: **Narrator**
> "She sighed audibly and slouched against the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`
  - -> `[648]`
  - -> `[649]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`
  - -> `[653]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[654]`
Mówca: **Vina Toras**
> ""Yes, let's get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[655]`
Mówca: **Vina Toras**
> ""Thank you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[656]`
Mówca: **Vina Toras**
> ""Now can we please get this over with?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[657]`
Mówca: **Vina Toras**
> ""I don't know, Father. Beheading royals is a strong statement, even if they're only made of marble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[658]`
Mówca: **Vina Toras**
> ""Beheading royals strikes me as more than mere 'troublemaking', Father. Even if they're only made of marble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[659]`
Mówca: **Vina Toras**
> ""Then it's good that the King of Rizia is on his way to restore that authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[660]`
Mówca: **Vina Toras**
> ""I suppose you'll have to hear him out first. Find out what he actually wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[661]`
Mówca: **Vina Toras**
> ""Good thing the King of Rizia is on his way to restore it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[662]`
Mówca: **Vina Toras**
> ""If that were true, it wouldn't just be statues losing their heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[663]`
Mówca: **Narrator**
> "She straightened up a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[664]`
Mówca: **Vina Toras**
> ""I understand, Father. I won't make a scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[665]`
Mówca: **Vina Toras**
> ""Nothing. Remind me again why I have to be here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`
  - -> `[668]`
  - -> `[667]`
  - -> `[666]`

### Węzeł `[666]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because your king commands it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[667]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because your family has requested your presence, and family is the most important thing in this world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
  - -> `[670]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_TookBookAway == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because if I leave you alone, you'll start reading that propaganda again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want your opinion on the Rico situation. It's valuable to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[673]`
Mówca: **Vina Toras**
> ""Whatever you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[674]`
Mówca: **Narrator**
> "She smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[675]`
Mówca: **Vina Toras**
> ""And wake up to the truth about how the world works? Yes, heaven forbid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[676]`
Mówca: **Vina Toras**
> ""And your own daughter's wishes? Those are of no importance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[680]`
Mówca: **Vina Toras**
> ""If you wanted my opinion, you should've let me on your council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[681]`
Mówca: **Vina Toras**
> ""All right. I'll try to gather all the insight I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[682]`
Mówca: **Narrator**
> "She straightened up a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[683]`
Mówca: **Narrator**
> "We rode on in silence until we reached Palas Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[685]`
Mówca: **Narrator**
> "She sighed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[686]`
Mówca: **Vina Toras**
> ""Sorry, Your Majesty. I'll be on my best behavior with Cousin Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Iza_SawStatues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Iza_SawStatues == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Iza_SawStatues == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Iza_SawStatues == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`
  - -> `[694]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[696]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true || RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true || RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`
  - -> `[698]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true || RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true || RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[698]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true || RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true || RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[699]`
Mówca: **Narrator**
> "We passed a street cleaner who was rapidly trying to scrub graffiti off of the side of a building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[700]`
Mówca: **Narrator**
> "I could just make out the remnants. They read "House Toras Will Fall"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[701]`
Mówca: **Narrator**
> "Vina didn't seem to notice. She sighed audibly as she slouched against the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`
  - -> `[648]`
  - -> `[649]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[705]`
Mówca: **Narrator**
> "Vina didn't seem to notice. She looked lost in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't mean I approve of the group or its activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[710]`
Mówca: **Rico Toras**
> ""Of course, of course. You're entitled to your own opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[711]`
Mówca: **Narrator**
> "He reached into his vest pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[712]`
Mówca: **Rico Toras**
> ""Here's his favorite toy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_DogToy");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_DogToy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Iza_SawStatues == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_Iza_SawStatues == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_Iza_SawStatues == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[720]`
Mówca: **Rico Toras**
> ""You refused to denounce Su Omina in the face of pressure from Wehlen. For that, we -- they -- are grateful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[721]`
Mówca: **Rico Toras**
> ""But then I got wind of your investigation. Tell me, cousin, do you really think I keep company with terrorists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[64]`
  - -> `[722]`
  - -> `[723]`

### Węzeł `[722]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I don't. Assuming you are innocent, the investigation will clear your name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[723]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You tell me, Ricardus. Do you have something to hide?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[724]`
Mówca: **Rico Toras**
> ""With regards to Zille? Nothing at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Bruno");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[726]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[727]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");
RemoveConversant("Rico Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Vina Toras");
AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Vina Toras");
AddConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[730]`
Mówca: **Bruno**
> ""YELP!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[731]`
Mówca: **Bruno**
> ""Aroo...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Military_Equipment >= 250)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`
  - -> `[734]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Military_Equipment >= 250)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Military_Equipment >= 250))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[735]`
Mówca: **Rico Toras**
> ""The only thing we would need to seal this deal is some additional treasury support and some weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't afford to do this right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[737]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_GoldenGuard_InvestigateSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`
  - -> `[739]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_GoldenGuard_InvestigateSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_GoldenGuard_InvestigateSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[740]`
Mówca: **Rico Toras**
> ""Do you really think I'd dare to bargain with the King of Rizia? Consider it a family favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Discussing security while hunting with the Duke of Iza", "Iza Forest", "Province of Brenas");)*
- **Efekt (`userScript`):** `SetRichPresence("Discussing security while hunting with the Duke of Iza","Iza Forest","Province of Brenas");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Hunting boars with machine guns", "Iza Forest", "Province of Brenas");)*
- **Efekt (`userScript`):** `SetRichPresence("Hunting boars with machine guns","Iza Forest","Province of Brenas");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
