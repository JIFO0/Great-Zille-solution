# Rizia/Turn 1/Economy and Treasury Section

- **ID konwersacji:** `290`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/290_Economy_and_Treasury_Section.md`
- **Liczba węzłów dialogowych:** 438
- **Liczba wyborów gracza:** 102

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_Focus_EnergyIndustry`
- `RiziaDLC.Prologue_Focus_TreasuryFinances`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes`
- `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gas`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes`
- `RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[289] Rizia/Turn 1/EnT_CouncilBriefing** (../Turn_01/289_EnT_CouncilBriefing.md), Węzeł `[262]`
- Węzeł `[428]` -> **[289] Rizia/Turn 1/EnT_CouncilBriefing** (../Turn_01/289_EnT_CouncilBriefing.md), Węzeł `[284]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 23

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Budget`
- `RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[22]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] = true;`
- Węzeł `[44]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[65]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- Węzeł `[102]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- Węzeł `[125]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[128]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[153]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] = true;`
- *...oraz 15 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `289` (*Rizia/Turn 1/EnT_CouncilBriefing*), Węzeł `[262]`

### Węzeł `[3]`
Mówca: **Elena Werner**
> ""Surely His Majesty already has some awareness regarding the state of Rizia's economy and resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`
  - -> `[408]`

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""It's healthy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He had the right idea. If Rumburg and the other countries in GRACE stop importing from us, that surplus could disappear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Elena Werner**
> ""Thanks to your own wise financial decisions over the past few years, that surplus is fairly high. But of course, there's always room for improvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[7]`
Mówca: **Laurento Esquibel**
> ""Why would Rumburg suddenly put an end to decades of peaceful trade?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[8]`
Mówca: **Laurento Esquibel**
> ""A shortage of *Rizian* workers, Elena. Those vacancies could easily be filled with migrants from Wehlen and Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much of our revenue comes from taxes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't know how much of Queen Beatrice's goodwill was due to my ties with her sister. With Lena gone, we can't take Rumburg's loyalty for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just speaking in hypotheticals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust Rumburg, but it's never wise for a country to rely too much on one trading partner. We need to diversify.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""Very astute, Your Majesty. I did have a number of alternative candidates in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[17]`
Mówca: **Elena Werner**
> ""For now, are there any other questions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == true || RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == true || RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes == true ||RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == true || RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all the information I need for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gas = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Elena Werner**
> ""Historically, our resource-based economy has allowed us to have some of the lowest tax rates on the continent. It's been a real boon for businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your words, Ms. Werner. The nobility may not have an income, but we are the foundation upon which Rizian society is built.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't seem fair. Low-earning workers pay taxes while nobles don't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. Without my family's manufacturing industry investments, for example, half of Cardesse-Montaklar would be out of a job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""A ten percent tax is a low price for commoners to pay for the privilege of living and working in the best country in Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could we generate extra revenue by introducing estate or inheritance taxes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Economy/Treasury Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[30]`
Mówca: **Elena Werner**
> ""As a fellow monarchy and a member of the Guild of Royal Allies for Commercial Exchange, Rumburg has more than a familial interest in our partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[31]`
Mówca: **Elena Werner**
> ""Your House's province, Valenqiris, leads the realm in GDP... driven by its wine, gas, and tourism sectors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[32]`
Mówca: **Elena Werner**
> ""The manufacturing concerns in Cardesse-Montaklar are doing very well, to the point that business councils are complaining about an imminent shortage of skilled workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""Since we began trading with Rumburg, we've been running a surplus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not particularly. I'm the Party Prince, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got gold, we've got energy. What else do I need to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the broad strokes. But I'm happy to get caught up on the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but I'm sure my daughter would appreciate a refresher course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Elena smiled at Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Elena Werner**
> ""Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Elena Werner**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
Mówca: **Elena Werner**
> ""It's slightly more complicated than that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""I doubt anyone here has forgotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "She smoothly adjusted her reading glasses before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Elena Werner**
> ""Until the 1940s, Rizia was historically one of the wealthiest countries in South Merkopa. But His Majesty the late King Valero bequeathed us a number of challenges in that department.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[52]`
Mówca: **Elena Werner**
> ""Or we can spend our budget elsewhere as we wait for access to the new field south of Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Laurento Esquibel**
> ""Careful, Ms. Werner. One shouldn't count one's pheasants before they've been bagged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excuse me? What field would that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The south of Caleqabiz... wouldn't that put the field close to Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will quit squabbling and tell me about this new field at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Elena looked at Laurento, then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Elena Werner**
> ""Well... we're still in the extremely early stages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are we waiting for? Let's get to drilling!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should proceed very carefully with this. We don't want a gas dispute on our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps we should let it go, in the interest of keeping the peace with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""Wise words, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Vina. Duchess Azaro, save the military talk for your own briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't interrupt my councilors, Vina. You will speak only when spoken to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[66]`
Mówca: **Elena Werner**
> ""We should save this discussion for if and when we know more about the gas field in question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time to grow up, my dear daughter. In real life, there's always a winner and a loser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[68]`
Mówca: **Elena Werner**
> ""But we may have at least part of a claim to a substantial reserve of natural gas between the port of Pales and the Rizian island of Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`
  - -> `[304]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Elena suppressed a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[70]`
Mówca: **Elena Werner**
> ""Our researchers have been investigating the field's size and borders. Once those are known, it will be easy to determine ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Laurento gave me a significant look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Laurento Esquibel**
> ""Exactly, Your Majesty. Ms. Werner, tell him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[73]`
Mówca: **Vina Toras**
> ""I don't know why we're even discussing a military response. We'll surely be able to reach a compromise using proper diplomacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`
  - -> `[67]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Vina tentatively raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""Where should I start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Budget == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about our government budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[83]`
Mówca: **Elena Werner**
> ""It's always a good idea to envision all possible scenarios. But as a fellow monarchy and member of the Guild of Royal Allies for Commercial Exchange, it's against Rumburg's interests to disrupt our partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Laurento Esquibel**
> ""With that said, your father was conservative when it came to our international trade. I have a number of alternative partners in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[85]`
Mówca: **Elena Werner**
> ""Now, new gold mines are scarce, our richest sources nearly depleted, and the Kingdom’s burdens have grown over the past decade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[90]`
  - -> `[89]`
  - -> `[5]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not slander the late King of Rizia. I'm sure my father had his reasons for such frugality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""Elena meant no offense, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Elena Werner**
> ""Indeed not. I'm just pointing out that the money is there, should you choose to spend it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonetheless, it's great to know that we're not going broke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to sugarcoat it. He was a miser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's been going on with our gold industry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""With that said, our budget will need more padding if we want to complete the slate of military modernization measures I have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Elena pursed her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[97]`
Mówca: **Elena Werner**
> ""With all due respect, Duchess Azaro, I'm not sure the military is the King's number one focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[100]`
  - -> `[101]`
  - -> `[104]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why wouldn't it be, Ms. Werner? Rizia continues to have many enemies, both foreign and internal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It most certainly is not. That money should be spent on the Rizian people, not weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The last time Rizia had a strong military, its members mutinied against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""Very well said, Your Majesty. We cannot rely on the likes of Wehlen or Rumburg to protect us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, it isn't. If we invest our surplus in Rizian industries, we'll get back what we spent triplefold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Elena Werner**
> ""Very good thinking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[106]`
Mówca: **Laurento Esquibel**
> ""I agree, Your Majesty. Think of the advances we were able to make during the Lyza era due to the Queen's investments in citizen welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""That was many years ago, Your Majesty. And the responsible parties have all been punished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""Great news, Ms. Werner. I already have a full slate of military modernization measures I was hoping to propose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[109]`
Mówca: **Elena Werner**
> ""He had his reasons, I'm sure. But he did miss a number of potentially lucrative investment opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""Including, of course, the opportunity to completely modernize the Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[111]`
Mówca: **Elena Werner**
> ""Thank you, Mr. Esquibel. You'll get your chance to present those later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Elena Werner**
> ""For now, I will point out that holding on to that surplus has not done Rizia any favors. We have missed a number of potentially lucrative investment opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Laurento Esquibel**
> ""Ultimately, shouldn't that money be spent on the Rizian people? Think of the advances we were able to make during the Lyza era due to the Queen's investments in citizen welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""'True prosperity is not defined by the amount of gold in our coffers, but by the health and happiness of each soul within our borders.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[121]`
  - -> `[123]`

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""I do agree there are better uses for those funds. Think of the advances we were able to make during the Lyza era due to the Queen's investments in citizen welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shh. You're supposed to be a silent observer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Truer words have never been spoken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More pragmatically, a happy and well-fed populace is one that does not rise up against its leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true that a happy and well-fed populace is one that does not rise up against its leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand, there can be no welfare without security. What good is health or happiness if we're unable to defend ourselves?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Mr. Esquibel. If we focus on citizen welfare, we can set the standard not only for Merkopa, but for the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""If I may, the Princess has a point. Rizia's wealth, and my mother's judicious handling of it, was one of the factors that allowed us to survive the Century of Revolutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Vina blushed and lowered her eyes. Hugo put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Vina beamed. Hugo nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Hugo nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""I will point out that Rizia's wealth, and my mother's judicious handling of it, was one of the factors that allowed us to survive the Century of Revolutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Hugo put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""However, those were different times. As a modern nation in an era of increasing superpower influence, we are expected to have a certain standard of military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`

### Węzeł `[134]`
Mówca: **Elena Werner**
> ""Well, Your Majesty, gold is still the backbone of the Rizian economy. Though production has declined as our reserves begin to exhaust themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Elena Werner**
> ""We can try. There are a number of promising sites that have yet to be explored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we increase our mining efforts within Rizia to make up for the loss?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[137]`
Mówca: **Elena Werner**
> ""We have a number of active mines within the country, operated by the Rizian Royal Gold corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[138]`
Mówca: **Narrator**
> "She unrolled a map on the table and pointed to a region in the east of Morella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[139]`
Mówca: **Elena Werner**
> ""The double blow of losing our mines in Zille and 15 percent of our RRG stake has made us quite reliant on the gold from the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much say does the government have over operations in the MITZ?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Elena Werner**
> ""A fair amount. Any changes to regulations or profit shares have to be agreed on by all four nations involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When we get Zille back, will we get its gold back as well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Elena Werner**
> ""I certainly hope so. Wehlen has been mining extensively in the region since taking over in 1927.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille == true && RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Regs"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold_Rizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[147]`
  - -> `[150]`
  - -> `[370]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Gold Qs)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Gold Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Econ_Gas == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gas"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's talk about our energy holdings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Elena rubbed her hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""Very gladly, Your Majesty. This is a new area for us compared to gold, but the financial possibilities are intriguing indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[170]`
Mówca: **Narrator**
> "She pointed again at the map on the table, this time directing our attention to the east of Morella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Econ_ElenaShowedMap"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Narrator**
> "She pointed at the map in front of her, this time directing our attention to the southern coast of Valenqiris."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Narrator**
> "She unrolled a map on the table and pointed to the southern coast of Valenqiris."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[178]`
Mówca: **Elena Werner**
> ""Though our state energy company is called Rizian Oil and Gas, production of the former has slowed over the years, and is threatening to come to a complete halt. The latter, however, shows immense potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Elena Werner**
> ""Our most productive gas field is Esqiris, off the coast of Topes. Assuming enough money is invested into its expansion, we can expect it to fuel our kingdom for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Vina Toras**
> ""Sorry, Father. I got overexcited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""Forgive me, Your Majesty. I thought you were asking for my input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Vina Toras**
> ""Oh, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Elena gently cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[185]`
Mówca: **Elena Werner**
> ""That's it for our discussion on gold. Shall we move on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Economy/Treasury Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[91]`
  - -> `[161]`
  - -> `[10]`
  - -> `[18]`

### Węzeł `[187]`
Mówca: **Elena Werner**
> ""The central government does collect a flat income tax of ten percent. This is mostly paid by workers, since nobles have no income to speak of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[192]`
  - -> `[25]`
  - -> `[28]`

### Węzeł `[188]`
Mówca: **Elena Werner**
> ""I didn't make the rules, Your Majesty. They were proposed by the House of Delegates and agreed on by your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[189]`
Mówca: **Elena Werner**
> ""We definitely could, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Elena Werner**
> ""I do happen to think that taxing wealthy nobles makes more sense than taxing the workers who generate said wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Elena Werner**
> ""On the other hand, the current tax code was proposed by the House of Delegates and agreed on by your father. It might not be easy to change it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ten percent... that's low, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Elena Werner**
> ""Compared to most of our neighbors, yes. We do provide a high standard of social services to our people, but it's mostly financed with trade income.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Hugo Toras**
> ""This is by the House of Delegates' design, Your Majesty. Lowering the tax burden on citizens leads to higher satisfaction with the government and less likelihood of rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[203]`
  - -> `[202]`
  - -> `[209]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, could we raise that rate?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[196]`
Mówca: **Hugo Toras**
> ""The commoners should consider themselves lucky. Ten percent is far lower than elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[207]`
  - -> `[211]`

### Węzeł `[197]`
Mówca: **Hugo Toras**
> ""Nor should we. Taxing nobles would be an attack on the very backbone of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Lucita Azaro**
> ""Yes, our families' investments power half the businesses in this country. Why should we be forced to pay double?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But nobles only got the money for those investments by siphoning it from hard-working commoners. Isn't it our responsibility to break the cycle somehow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have a point. We shouldn't disincentivize families like yours from supporting Rizia's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not convinced. But I'll drop the subject for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still think that rate could be higher. Imagine what we could do with the funding!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise idea. But it leaves us at the mercy of our resources and trade partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. We certainly don't want another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""And our family's investments power half of Rizia's businesses anyway. Why ask us to pay double?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[206]`
Mówca: **Hugo Toras**
> ""I don't think it would be wise. The House of Delegates determined that lowering the tax burden on citizens leads to higher satisfaction with the government and less likelihood of rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's no wonder there hasn't been another uprising when they're paying that little.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not get rid of income tax altogether, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[210]`
Mówca: **Hugo Toras**
> ""Yes, this was the House of Delegates' intention. Lowering the tax burden on citizens leads to higher satisfaction with the government and less likelihood of rebellion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do wonder if the nobility should contribute more. We can certainly afford to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""If you'd like to retain the loyalty of the House of Delegates, I would suggest keeping our tax laws the way they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[213]`
Mówca: **Elena Werner**
> ""That would be a risk, Your Majesty. Without any other revenue-generating measure to replace that tax, it would leave us completely reliant on our natural resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[214]`
Mówca: **Elena Werner**
> ""We already have a budget surplus, Your Majesty. I see no need to raise taxes unless it's absolutely necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[215]`
Mówca: **Elena Werner**
> ""Not completely. But yes, if our international trade were to be disrupted, we would have to abandon this system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[216]`
Mówca: **Elena Werner**
> ""At the moment, we have little risk of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Hugo looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Hugo Toras**
> ""It is our responsibility to make wise choices with the money we have. Dwelling on how we came to have it accomplishes nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[219]`
Mówca: **Hugo Toras**
> ""Think of your own house, Your Majesty. Would the Rizian wine industry be where it is without our backing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Elena Werner**
> ""Very well, Your Majesty. For the record, I'm not convinced either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Elena Werner**
> ""In terms of our provinces' individual contributions... they pay less than three percent directly to the Crown, which mostly goes towards administrative costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[222]`
Mówca: **Elena Werner**
> ""Brenas is still suffering the effects of the loss of Iza and Zille. However, it's made advances in shipping and agriculture, alongside its gold mines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[223]`
Mówca: **Hugo Toras**
> ""That is a slippery slope, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Laurento Esquibel**
> ""After the Wehlen Civil War, we began granting 'labor hand' visas to Wehzek migrants and a smaller number of Derdians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
Mówca: **Laurento Esquibel**
> ""Are you familiar with Rizia's two-tier employment system, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please explain it to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I believe I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[228]`
Mówca: **Elena Werner**
> ""Labor hands may accept employment by Rizian industries, but they don't have the right to social security or other benefits. And there is a cap on how much they are allowed to earn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Elena Werner**
> ""They now make up most of our blue-collar workforce, with higher-paid jobs held by native Rizians as well as smaller numbers of Lespians, Valgslandians and Rumburgians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Laurento Esquibel**
> ""The program did wonders for the economy when King Valero initiated it. But as a result, we now have millions of workers in this country who are being treated like second-class citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[231]`
Mówca: **Laurento Esquibel**
> ""Granting 'labor hand' visas to Wehzeks and Derdians did wonders for our economy in the 1930s and 40s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Laurento Esquibel**
> ""But as a result, Rizia now has a millions-strong workforce that is essentially treated like second-class citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They should have the same working rights as their Rizian counterparts. Especially if they're paying taxes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the system functions, I see no need to change it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those visas were granted to temporary residents. They were supposed to go home at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see where you're going with this, but granting them full employment rights would lead to a flood of uncontrolled migration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Hugo Toras**
> ""Rizia offered Wehzeks asylum where other countries did not. There must be some limit to our generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[238]`
Mówca: **Laurento Esquibel**
> ""I wouldn't say it functions. Barring these people from upward mobility will have consequences in the long term. The worker shortage Elena mentioned is just one of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[239]`
Mówca: **Elena Werner**
> ""That was the initial aim. But Rizia's current-day economy now relies on these workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Laurento Esquibel**
> ""All the more reason why they deserve an upgrade in status.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[241]`
Mówca: **Laurento Esquibel**
> ""I'm not sure about that. The situation in Wehlen has stabilized since the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[254]`
  - -> `[256]`

### Węzeł `[245]`
Mówca: **Hugo Toras**
> ""There was a time when you supported that stance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[254]`
  - -> `[256]`
  - -> `[252]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just being pragmatic. Expanding foreign workers' rights does seem like a convenient solution to the shortage Elena mentioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[247]`
Mówca: **Hugo Toras**
> ""Rizia offered Wehzeks asylum where other countries did not. There must be some limit to our generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[255]`
  - -> `[257]`

### Węzeł `[251]`
Mówca: **Hugo Toras**
> ""I recall you once supported that stance as well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`
  - -> `[255]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was a different person back in those days. I no longer support Su Omina or the values it stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did and I still do. I'm all for diversity, but we Rizians cannot allow ourselves to become outnumbered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taking advantage of migrants' dire financial situation by forcing them to work for low wages is hardly 'generosity.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From a purely pragmatic point of view, expanding foreign workers' rights does seem like a convenient solution to the shortage Elena mentioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps. But I do worry that having a growing army of disenfranchised laborers will lead to unrest down the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. I'm all for diversity, but we Rizians cannot allow ourselves to become outnumbered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[258]`
Mówca: **Lucita Azaro**
> ""From a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[259]`
Mówca: **Lucita Azaro**
> ""Very possible, Your Majesty. And allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""And from a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Hugo Toras**
> ""Do you not fear the dilution of Rizian culture and values, Duchess Azaro? Or the infiltration of Dastnurists and Golcondists into our Wruhecist society?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Narrator**
> "She shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""Societies change, Your Grace. And I don't recall these concerns being raised about the Rumburgians who moved here after our alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`
  - -> `[268]`
  - -> `[269]`

### Węzeł `[264]`
Mówca: **Lucita Azaro**
> ""I will add that from a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[265]`
Mówca: **Lucita Azaro**
> ""I will point out that from a security standpoint, allowing migrants to earn more money would curb the kind of black-market activities that have been taking place in cities like Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well put, Duchess. I can already tell you're going to be a brilliant addition to this council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's completely different. The Rumburgians are our blood relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To tell the truth, I'm not thrilled about any of those groups.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is a multicultural nation now, Hugo. Whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Narrator**
> "I saw a smile play across her lips. Hugo stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[272]`
Mówca: **Hugo Toras**
> ""There are also far fewer of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[273]`
Mówca: **Hugo Toras**
> ""Nor am I. But the Rumburgians are a small minority compared to the Wehzeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[274]`
Mówca: **Hugo Toras**
> ""We cannot let the events of the last two decades destroy what it has taken over a thousand years to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[275]`
Mówca: **Narrator**
> "Hugo fixed Lucita with a defiant stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Elena Werner**
> ""We seem to have veered off track. Can we get back to your questions about the economy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Elena looked uneasily at the three of us. She tapped a pencil on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Taxes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Hugo. I'll take Duchess Azaro's suggestion seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Other countries might compete to have the biggest guns. Not Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And there's the fact that we're sandwiched between the highly contentious regions of Zille and Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we cultivate our alliances well, we won't need that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""I'm honored, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[284]`
Mówca: **Lucita Azaro**
> ""It's not about big guns, Your Majesty. It's about being prepared for any eventuality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[285]`
Mówca: **Lucita Azaro**
> ""Precisely, Your Majesty. We've got to be prepared for the worst-case scenario, even if it doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""Allies can turn on us, Your Majesty. A loyal, well-funded military is worth its weight in gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Elena Werner**
> ""Your enthusiasm is heartening, Duchess Azaro. I'm sure you'll have much more advice to share during your own briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Elena Werner**
> ""Any further questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Gold = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Gold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Econ_Budget = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Econ_Budget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[293]`
Mówca: **Elena Werner**
> ""Perfect, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Laurento stroked his mustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Laurento Esquibel**
> ""It was established shortly before you joined the Royal Council, was it not, Elena? I heard the negotiations between Rizia, Valgsland, Lespia and Morella took over a year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[296]`
Mówca: **Elena Werner**
> ""We would just need to commission a survey to find them. Keeping in mind that any mining site near noble-owned estates might lead to a devaluation of those properties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[297]`
Mówca: **Elena Werner**
> ""But as per the terms of our agreement, Zille and all of the resources therein will return to Rizian ownership in 1952.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Narrator**
> "Laurento looked down at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Laurento Esquibel**
> ""Forgive me, Your Majesty. I will let the treasurer speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[301]`
Mówca: **Elena Werner**
> ""I'd like nothing more, Your Majesty. But protocol must be followed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[302]`
Mówca: **Laurento Esquibel**
> ""Of course, we are liaising extremely closely with Pales to avoid misunderstandings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[303]`
Mówca: **Laurento Esquibel**
> ""I agree that maintaining or even improving our relations with Pales should be our number-one goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales barely counts as a country. Of course we have a claim to the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Narrator**
> "Laurento looked uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Laurento Esquibel**
> ""Whatever our feelings about Palesian sovereignty, we are bound to respect protocol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Elena Werner**
> ""We have teamed up with Palesian researchers to investigate the field's size and borders. Once those are known, it will be easier to determine ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[311]`
Mówca: **Elena Werner**
> ""With that said, if there's even a chance we have a claim to that gas, we really ought to take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""As we should. Nobody wants a repeat of the last conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[316]`
  - -> `[319]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really, Duchess Azaro? Your family isn't itching for a rematch?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it *does* come down to that -- God forbid -- Rizia will win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed not. I will not practice the same mindless militarism as my father and Taddeus Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the Grand Duchy does not provoke us, we will not provoke them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[320]`
Mówca: **Narrator**
> "Lucita laughed uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""Just because the Azaros are demanding the reclamation of Pales doesn't mean it's a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""Of course, if Pales shows hostility towards us, we will react in kind. But Rizia should not be the first to resort to aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[323]`
Mówca: **Narrator**
> "Lucita winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""Not with our military in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Lucita Azaro**
> ""As much as my family is clamoring for a repeat of the Pales campaign, I think it's best to ignore them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[326]`
Mówca: **Narrator**
> "Lucita's eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Lucita Azaro**
> ""The attack on Pales in the '20s was not 'mindless', Your Majesty. It was driven by demand from the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Lucita Azaro**
> ""But some people don't know what's best for them. Especially my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[329]`
Mówca: **Narrator**
> "Lucita nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""As much as my family is clamoring for a repeat of the Pales campaign, I think it's best to ignore them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[331]`
Mówca: **Laurento Esquibel**
> ""You'll recall her famous quote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[332]`
Mówca: **Laurento Esquibel**
> ""'True prosperity is not defined by the amount of gold in our coffers, but by the health and happiness of each soul within our borders.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[334]`
Mówca: **Hugo Toras**
> ""The people of this country will accept diversity up to a certain point, Your Majesty. But if they begin to feel their national identity is under threat, there will be consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[335]`
Mówca: **Narrator**
> "She and Hugo exchanged glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Hugo Toras**
> ""And unfortunately, we cannot talk about Rizian Royal Gold without talking about its CEO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`
  - -> `[339]`
  - -> `[340]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do we have to talk about him? It's Rizian *Royal* Gold, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why 'unfortunately', Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had better get that discussion over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not speak ill of our country's most vaunted businessman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""My apologies, Your Majesty. Of course I do not mean to call Russello Montoro's acumen into question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[342]`
Mówca: **Elena Werner**
> ""That's the problem. It isn't ours. Since 1935, it's been under the control of Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[343]`
Mówca: **Elena Werner**
> ""Your uncle never could countenance the presence of Russello Montoro. But we can't mine gold in this country without him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[344]`
Mówca: **Elena Werner**
> ""For better or worse, our country's gold stores rely on Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still cannot believe he was allowed to gain such a large majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[346]`
Mówca: **Elena Werner**
> ""After a *very* lengthy back-and-forth, it was agreed that the Kingdom's share in RRG be decreased from 45 to 30 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`
  - -> `[357]`

### Węzeł `[347]`
Mówca: **Elena Werner**
> ""Mr. Montoro -- excuse me, Rusty -- currently owns 70 percent of Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fine by me. We all know that private enterprise can achieve what the government cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As much as I respect Rusty, I believe we royals should be in charge of our own gold mines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
Mówca: **Hugo Toras**
> ""Nor can I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Narrator**
> "He looked at Elena."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Elena Werner**
> ""Rusty's first move after taking over the company was to sue your father's government for loss of revenue connected to the Zille handover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[353]`
Mówca: **Hugo Toras**
> ""In some cases, perhaps. But after what this man did...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""That will be difficult, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not tolerate this. I want Rizia's original stake back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia should not own 30 percent of RRG, or even 45 percent. The entire company should be nationalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see any problem with that. We shouldn't have so much of our money tied up in an outdated resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Laurento Esquibel**
> ""I beg your pardon, Your Majesty, but healthy gold stocks are crucial to Rizia's reputation on the international stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Elena Werner**
> ""Rumburg is buying our gold for technological uses. And some of our neighbors have shown interest in using it to shore up their unstable currencies, as we did here after the '26 uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[360]`
Mówca: **Elena Werner**
> ""It's not that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Elena Werner**
> ""Curry enough favor with Rusty, and it should be possible. But any more than 45 percent will be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Laurento Esquibel**
> ""The patent for RRG's proprietary mining technology was filed in Ventrie City, Arcasia. And most of its financial assets are kept in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Elena Werner**
> ""In other words, attempting to nationalize the company without Mr. Montoro's express approval would strip it of its value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Narrator**
> "She adjusted her glasses before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Elena Werner**
> ""While RRG controls mining within Rizia, the royal government is a direct stakeholder in the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[366]`
Mówca: **Elena Werner**
> ""And at the time of our last survey, there was much more than 30 years' worth of gold in the ground there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[367]`
Mówca: **Narrator**
> "I saw Hugo wince at that remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[368]`
Mówca: **Elena Werner**
> ""RRG gets a percentage of the MITZ profits for the use of its technology, but we can make decisions without Mr. Montoro's input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[369]`
Mówca: **Elena Werner**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get the picture. Let's move on to other topics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""Which, by the way, is why I wholeheartedly support your decision to impose a tax on non-Wruhecists so early into your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[375]`
Mówca: **Hugo Toras**
> ""Which, by the way, is why I wholeheartedly support the Rizian National Coalition's suggestion to impose a tax on non-Wruhecists. Filling our coffers and rewarding the native Rizian faithful in one go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_TreasuryFinances == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_TreasuryFinances == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_TreasuryFinances == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Elena Werner**
> ""It's not as high as it used to be. But I think we should put it to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_ArmedForces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[383]`
Mówca: **Lucita Azaro**
> ""I'm sure His Majesty will agree with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[387]`
  - -> `[390]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I share your goals, Duchess. By the end of my reign, the Rizian Armed Forces shall be known and feared throughout the continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Narrator**
> "Lucita smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""I've planned a separate meeting to discuss national security. We'll go over it all then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enhancing our army stockpiles will be good for Rizia's finances, Ms. Werner. If there's one thing there's always a market for, it's weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Elena Werner**
> ""Hmm. You do have a point there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Lucita Azaro**
> ""As long as we've got enough left over to fight with if need be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I chose to gave our military a much-needed upgrade before my coronation, yes. That doesn't mean it will be a major focus during my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Lucita Azaro**
> ""Ah. Forgive me if I misunderstood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Laurento Esquibel**
> ""Not that I disagree with King Romus, but I personally believe that more financial attention should be paid to our citizens' welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Laurento Esquibel**
> ""Doing so would vastly improve our global image. You'll remember Queen Lyza's famous quote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_TreasuryFinances == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_TreasuryFinances == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_TreasuryFinances == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[397]`
Mówca: **Narrator**
> "She smiled fondly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Elena Werner**
> ""I believe you know the answer, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_EnergyIndustry == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_EnergyIndustry == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_EnergyIndustry == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[402]`
Mówca: **Elena Werner**
> ""Your past efforts have certainly helped bolster our reserves. However, the amount of gold in the ground is finite, and extraction has plateaued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[403]`
Mówca: **Elena Werner**
> ""Very gladly, Your Majesty. I know this is your area of expertise, but there have been a few new developments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 18)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 18)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 18`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 18))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 18) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[407]`
Mówca: **Elena Werner**
> ""Said surplus is... unusually large, compared to your father's regime. It's almost as if you've been able to conjure up money out of nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do, Ms. Werner. As a matter of fact, there's no need for today's briefing. Why don't you all take the rest of the day off?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Narrator**
> "My councilors glanced at each other in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Elena Werner**
> ""Are you sure, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find I think best when I'm alone. Get me in my study with a fountain pen and a stack of decrees, and I'll handle the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[417]`
  - -> `[419]`
  - -> `[424]`

### Węzeł `[415]`
Mówca: **Elena Werner**
> ""Perhaps you're all caught up on our economic situation, but Her Highness still has much to learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[416]`
  - -> `[417]`
  - -> `[418]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. For Vina's sake, please proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Lord will guide me to make the right decisions, Elena. Your counsel is not necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And learn she will. Vina, this is how a real king cuts through the blather and gets down to business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You clearly worked hard to put today's briefing together. So please proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Narrator**
> "Elena frowned, clearly hurt, before straightening up and snapping her ledger shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[422]`
Mówca: **Narrator**
> "Vina stared at me in confusion. A faint smile of amusement played on Lucita's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get some fresh air. Cut loose a little. It's not like you're getting any younger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Narrator**
> "A faint smile of amusement played on Lucita's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[426]`
Mówca: **Narrator**
> "She nodded slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Elena Werner**
> ""I understand. I won't get in your way, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Briefing Skipped])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `289` (*Rizia/Turn 1/EnT_CouncilBriefing*), Węzeł `[284]`

### Węzeł `[429]`
Mówca: **Elena Werner**
> ""The arrangement dates back to agreements made after the War of Rizian Succession. After four years of civil war, the Crown granted broad fiscal autonomy to the provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Hugo Toras**
> ""It is the very structure of the realm, our code of agreements, one that has endured for centuries. The provinces remain the backbone of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[432]`
  - -> `[431]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to know what returns we’re getting through growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then let’s go over what each province contributes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are the provinces performing economically?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Elena Werner**
> ""There are key differences worth your attention. Let me walk you through them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[435]`
Mówca: **Elena Werner**
> ""Of course. Their profiles vary, but each plays a big role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[436]`
Mówca: **Elena Werner**
> ""Growth, trade, and indirect levies offer us some leverage. Let me break it down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[437]`
Mówca: **Elena Werner**
> ""All glory to the late Valero, but he had a certain prudence about spending government funds, even when it might have made Rizia richer today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
