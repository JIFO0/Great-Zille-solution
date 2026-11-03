# Rizia/Turn 10/Pales_Reform_Branch/Pales_Reform_Branch Conversation

- **ID konwersacji:** `546`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/546_Pales_Reform_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 385
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.PalesOwnership_Azaros`
- `RiziaDLC.Pales_Reconstruction_EnoughFunds`
- `RiziaDLC.Pales_Reconstruction_Installments`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.ReparationsAccepted_Immediate`
- `RiziaDLC.ReparationsAccepted_Installments`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_Fled`
- `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy`
- `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate`
- `RiziaDLC.War_BorderOutcome_Peace_PalesDivided`
- `RiziaDLC.War_Pales_Won`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[4]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[298]` (Paskal Beniwoll): `--;`
- Węzeł `[299]` (Paskal Beniwoll): `--;`
- Węzeł `[300]` (Paskal Beniwoll): `--;`
- Węzeł `[301]` (Paskal Beniwoll): `--;`
- Węzeł `[302]` (Paskal Beniwoll): `--;`
- Węzeł `[303]` (Paskal Beniwoll): `--;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`
  - -> `[2]`
  - -> `[3]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[2]`
Mówca: **Paskal Beniwoll**
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: input)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: output)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `348` (*Rizia/Turn 10/TalkWithPrimeMinister*), Węzeł `[679]`

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""Our military presence continues to provide security, allowing voting infrastructure to be established where conditions allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""In relatively stable areas, electoral operations are progressing accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[7]`
Mówca: **Manus Sazon**
> ""Many voters remain displaced, and even where communities are intact, security concerns have discouraged participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[8]`
Mówca: **Manus Sazon**
> ""On top of this, the violence of war and the forced unification have left deep scars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""Many in Pales remain distrustful of Rizia’s motives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""For some, the election feels imposed -- a process they fear could invite retaliation if they engage with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""This distrust has already hindered voter registration, particularly in the less stable regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""Despite being alien to many, the shift from a monarchy to a democratic system has been largely embraced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Manus Sazon**
> ""While some older citizens have shown resistance to change, the opportunity to vote has sparked a wave of enthusiasm, particularly among those who were previously sidelined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""However, challenges remain. The local governance structures in Pales continue to clash with the nationalized systems being implemented by Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""The military's presence in Rizian-held areas is helping restore order, allowing us to push forward with voting plans despite the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""In calmer regions, we've started early voting and absentee ballots to boost participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""Still, the fighting has made it nearly impossible to hold a secure vote in many parts of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""Displacement, intimidation, and violence will likely reduce turnout and skew representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""It's creating serious challenges for our logistical planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a disaster waiting to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’ll press on. There’s no other option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So much for fair elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From what I can tell, they’re not making it easy for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Pales_KingResponse_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[20]`
  - -> `[22]`
  - -> `[21]`
  - -> `[60]`

### Węzeł `[52]`
Mówca: **Manus Sazon**
> ""However, extensive destruction from the war has left much of Pales in disarray, with vital infrastructure severely compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""While much of Pales is still recovering, the damage to infrastructure is moderate but significant enough to cause disruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we’ll control what we can. Those who want to disrupt this will find we’re not as unprepared as they think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[61]`
Mówca: **Manus Sazon**
> ""Our military presence ensures security in the regions controlled by Rizia, facilitating the establishment of voting infrastructure where conditions permit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[65]`
Mówca: **Manus Sazon**
> ""However, the division of Pales has complicated the process, especially in regions still recovering from conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""And families split between Rizia and Pales further complicate representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[70]`
Mówca: **Manus Sazon**
> ""Tensions persist with Palesian local forces, but long-term integration is steadily underway, though it will likely take decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[74]`
Mówca: **Manus Sazon**
> ""The division of Pales is marked by conflict, though tensions remain manageable, particularly along the new shared border, with full integration expected to take decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""Despite full funding dedicated to reparations, widespread bitterness and anger among Palesians makes reconciliation a prolonged and difficult process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[76]`
Mówca: **Manus Sazon**
> ""With full funding dedicated to reparations, tensions are slowly easing, however, a significant portion of the population still resents Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""With full funding dedicated to reparations, substantial progress has been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""Reparation efforts are ongoing, however, widespread bitterness and anger among many Palesians toward Rizia is making it a prolonged and difficult process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Reparation efforts are ongoing, and while tensions are slowly easing, a significant portion of the population still resents Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Manus Sazon**
> ""Reparation efforts are ongoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Immediate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Immediate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ReparationsAccepted_Immediate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Installments == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Installments == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ReparationsAccepted_Installments == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems we've underestimated the depth of their resentment. We'll have to push harder to smooth things over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their bitterness is temporary. Rizia's faced worse and still emerged stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time has a way of healing even the deepest wounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""But the lack of funding toward the agreed upon reparations cost has made any meaningful recovery impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Manus Sazon**
> ""As a result, infrastructure lies in ruin, and food is scarce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[104]`
Mówca: **Manus Sazon**
> ""It became clear that if we failed to meet our obligation, it could reignite the war and provoke severe sanctions from the international community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""While substantial progress has been made, lingering distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Manus Sazon**
> ""As agreed, installments are being made over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[107]`
Mówca: **Manus Sazon**
> ""However, lingering distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[108]`
Mówca: **Manus Sazon**
> ""As for the upcoming election...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[115]`
Mówca: **Manus Sazon**
> ""They’ll come around in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[116]`
Mówca: **Daria de Rava**
> ""I'm sure they’ll come around in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[117]`
Mówca: **Adarfo Sotelato**
> ""Some wounds aren't easily mended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[124]`
Mówca: **Manus Sazon**
> ""We'll get there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[125]`
Mówca: **Daria de Rava**
> ""I believe that as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[126]`
Mówca: **Adarfo Sotelato**
> ""Provided we give them reason to heal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""We always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""Yes. We always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""As long as they’re willing to see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""Lawlessness is at an all-time high, fueling widespread anger among Palesians toward Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Reparations_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[101]`
  - -> `[100]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Reparations_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[145]`
Mówca: **Manus Sazon**
> ""Fortunately, as a gesture of goodwill in Rizia's new leadership, the Republic of Lespia has offered us a generous loan to cover costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[156]`
  - -> `[149]`
  - -> `[150]`

### Węzeł `[146]`
Mówca: **Daria de Rava**
> ""Fortunately, following a campaign to sell bonds to the Rizian public, De Rava Construction is equipped to complete the repairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Adarfo Sotelato**
> ""Which is why, under my direction, the House of Delegates has approved the seizure of a few choice assets from noble families. Your own included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[153]`
  - -> `[154]`
  - -> `[155]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it keeps us afloat, we have no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trading one disaster for another... wonderful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’ll owe them for decades. But perhaps that’s the lesser evil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well done. Pales' swift reconstruction will be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope they'll be paid back in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They’ll resist, but they can afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they’re true patriots, they’ll accept the burden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which assets?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Better to be in debt than in ruins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds suspiciously like corruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. It’s about time they paid their share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Adarfo Sotelato**
> ""Patriot or not, the choice is not up to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[160]`
Mówca: **Adarfo Sotelato**
> ""House Toras didn't really need its own zoo, did you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[161]`
Mówca: **Adarfo Sotelato**
> ""In the end, they'll see it was worth it for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[162]`
Mówca: **Adarfo Sotelato**
> ""I couldn't agree more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[163]`
Mówca: **Daria de Rava**
> ""For the greater good, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[164]`
Mówca: **Daria de Rava**
> ""The job had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[165]`
Mówca: **Daria de Rava**
> ""I and my family keep our word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""It's not an ideal situation, but it's the path we must take to maintain stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[167]`
Mówca: **Manus Sazon**
> ""Agreed. It's not an ideal situation, but it's the path we must take to maintain stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""The alternative would be far worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[169]`
Mówca: **Manus Sazon**
> ""It’s a heavy price, but it may be the only way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""But insufficient funding for the agreed reparations has rendered any substantial recovery unattainable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Daria de Rava**
> ""Consequently, infrastructure remains in disrepair, and food is in short supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Daria de Rava**
> ""Lawlessness has reached unprecedented levels, sparking widespread resentment among Palesians toward Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Daria de Rava**
> ""It became apparent that failing to fulfill our duty could reignite the war and invite harsh international sanctions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[174]`
Mówca: **Adarfo Sotelato**
> ""The lack of funding for the agreed reparations has made it impossible for the people to rebuild their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Adarfo Sotelato**
> ""As a result, communities remain shattered, and food is hard to come by.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Adarfo Sotelato**
> ""Lawlessness is rampant, and the suffering of the Palesians has only grown, fueling their anger toward Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Adarfo Sotelato**
> ""It became clear that if we failed to honor our commitment, it would not only reignite the war but bring even greater hardship to the people, along with severe international repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[178]`
Mówca: **Daria de Rava**
> ""The military's presence in Rizian-held areas is helping maintain order, giving us room to move forward with voting plans despite the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Daria de Rava**
> ""In quieter regions, we've introduced early voting and absentee ballots to encourage participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Daria de Rava**
> ""Even so, the ongoing violence has made it nearly impossible to hold a safe vote in much of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Daria de Rava**
> ""Displacement, threats, and violence are likely to suppress turnout and distort representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Daria de Rava**
> ""It's proving to be a major obstacle in our logistical planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[183]`
Mówca: **Adarfo Sotelato**
> ""The military's presence may be holding some ground, but it's hardly enough to ensure a stable vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Adarfo Sotelato**
> ""Early voting and absentee ballots have been introduced in calmer regions, but that's little comfort given the unrest elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Adarfo Sotelato**
> ""In truth, the fighting has made secure voting all but impossible in many parts of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Adarfo Sotelato**
> ""With people displaced, threatened, or caught in the violence, turnout will be dismal, and representation skewed beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Adarfo Sotelato**
> ""The war has turned what should have been a clear process into a logistical nightmare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[188]`
Mówca: **Daria de Rava**
> ""Though unfamiliar to many, the move from monarchy to democracy has been widely welcomed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Daria de Rava**
> ""Some older citizens have resisted the change, but the chance to vote has energized those who once felt excluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[190]`
Mówca: **Daria de Rava**
> ""That said, challenges persist. Pales’ local governance still clashes with the national systems Rizia is trying to enforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[191]`
Mówca: **Adarfo Sotelato**
> ""The move from monarchy to democracy has given power back to the people -- a long-overdue step toward true equality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Adarfo Sotelato**
> ""While some of the older generation cling to the past, a new wave of excitement is sweeping across the country, especially among those who once had no voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[193]`
Mówca: **Adarfo Sotelato**
> ""Of course, there are still hurdles. Pales’ long-standing leadership keeps resisting the national systems Rizia is putting in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[194]`
Mówca: **Daria de Rava**
> ""Our military continues to ensure security, allowing for the establishment of voting infrastructure where conditions allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[195]`
Mówca: **Daria de Rava**
> ""In relatively stable regions, electoral preparations are progressing as expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Daria de Rava**
> ""However, in areas still recovering from conflict, lingering instability has made securing the election far more difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[197]`
Mówca: **Daria de Rava**
> ""Many voters remain displaced, and even in stable communities, security fears have kept some from participating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Daria de Rava**
> ""On top of that, the war has left lasting wounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Daria de Rava**
> ""Many in Pales remain wary of Rizia’s intentions, especially when it comes to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Daria de Rava**
> ""For some, this whole thing feels like a trap -- like taking part could make them targets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Daria de Rava**
> ""That fear has already kept plenty of people from registering, especially in places where tensions are still high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Pales_KingResponse_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[206]`
Mówca: **Daria de Rava**
> ""While Pales is still recovering, infrastructure damage -- though moderate -- has been significant enough to cause major disruptions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[210]`
Mówca: **Daria de Rava**
> ""However, extensive damage from the war has left much of Pales in disarray, with critical infrastructure severely damaged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Daria de Rava**
> ""As you can imagine, this has made organizing the election far more difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[212]`
Mówca: **Daria de Rava**
> ""This, in turn, has created considerable obstacles for election planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""As expected, tensions persist between the conquered Palesians and the local Azaro government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""As for the upcoming vote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[215]`
Mówca: **Adarfo Sotelato**
> ""The military's presence is keeping things from spiraling, which has allowed some groundwork for voting to begin -- but only where conditions allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[216]`
Mówca: **Adarfo Sotelato**
> ""In relatively stable areas, voting prep is moving along -- slowly, but it’s happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Adarfo Sotelato**
> ""But regions still trying to recover are facing instability that’s making it even harder to secure the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[218]`
Mówca: **Adarfo Sotelato**
> ""Many voters remain displaced, and even where communities are intact, security concerns have discouraged participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Adarfo Sotelato**
> ""On top of this, the violence of war and the forced unification have left deep scars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[220]`
Mówca: **Adarfo Sotelato**
> ""But many in Pales still don’t trust Rizia's intentions, especially when it comes to anything related to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Adarfo Sotelato**
> ""This distrust has already hindered voter registration, particularly in regions that remain unstable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[225]`
Mówca: **Adarfo Sotelato**
> ""While some areas are steady enough to manage, plenty of places are still too battered for things to run smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[229]`
Mówca: **Adarfo Sotelato**
> ""However, Pales is still reeling from the war -- roads, services, and supply lines are barely functioning, making it far tougher to organize the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Adarfo Sotelato**
> ""This, in turn, has made electoral operations an uphill battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[231]`
Mówca: **Adarfo Sotelato**
> ""This, in turn, has created significant challenges for electoral operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[232]`
Mówca: **Adarfo Sotelato**
> ""Unsurprisingly, tensions still linger between the Pales population and their Rizian stewards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Adarfo Sotelato**
> ""Full integration will take generations, if not longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[234]`
Mówca: **Daria de Rava**
> ""Full integration is expected to take decades, if not longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[235]`
Mówca: **Manus Sazon**
> ""More than anything, people are just relieved the war’s behind them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Daria de Rava**
> ""First and foremost, the end of the war has brought a sense of relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[243]`
Mówca: **Adarfo Sotelato**
> ""First and foremost, people are just relieved the war is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[244]`
Mówca: **Daria de Rava**
> ""Even with full funding for reparations, bitterness and anger in Pales are still running high, making reconciliation slow and difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[245]`
Mówca: **Daria de Rava**
> ""Despite full funding for reparations, progress is slow, and resentment toward Rizia still lingers in much of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[246]`
Mówca: **Daria de Rava**
> ""With full funding toward reparations, substantial progress has been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[253]`
Mówca: **Daria de Rava**
> ""Reparations are underway, but frustration and bitterness in Pales are dragging out the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Daria de Rava**
> ""Reparation efforts are ongoing, and while tensions are slowly easing, many Palesians still resent Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Daria de Rava**
> ""Reparation efforts are ongoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Immediate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Immediate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ReparationsAccepted_Immediate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Installments == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Installments == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ReparationsAccepted_Installments == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[268]`
Mówca: **Daria de Rava**
> ""While progress has been made, lingering distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Daria de Rava**
> ""As agreed, installments are being made over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Daria de Rava**
> ""However, lingering distrust and resentment from certain Palesian groups still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Reparations_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[272]`
Mówca: **Adarfo Sotelato**
> ""Despite full funding for reparations, progress is slow, and Palesian resentment continues to stand in the way of meaningful reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[273]`
Mówca: **Adarfo Sotelato**
> ""With full funding allocated to reparations, tensions are gradually easing, but deep-rooted resentment from many Palesians still complicates progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[274]`
Mówca: **Adarfo Sotelato**
> ""While reparations have seen substantial funding, but distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[281]`
Mówca: **Adarfo Sotelato**
> ""Reparation efforts are underway, but widespread bitterness among Palesians toward Rizia is making the process longer and more difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Adarfo Sotelato**
> ""Reparation efforts are ongoing, and while tensions are slowly easing, many Palesians still resent Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Adarfo Sotelato**
> ""Reparation efforts continue, and though tensions are starting to ease, a significant portion of the population still resents Rizia, hindering progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Immediate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Immediate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ReparationsAccepted_Immediate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Installments == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ReparationsAccepted_Installments == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ReparationsAccepted_Installments == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[296]`
Mówca: **Adarfo Sotelato**
> ""As agreed, installments are being made over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Reparations_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Manus Sazon**
> ""However, challenges remain. The local governance structures in Pales continue to clash with the systems implemented in the other provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Daria de Rava**
> ""However, challenges remain. The local governance structures in Pales continue to clash with the systems implemented in the other provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Adarfo Sotelato**
> ""Of course, there are still hurdles. Pales’ long-standing leadership keeps resisting the systems Rizia's other provinces have put into place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[316]`
Mówca: **Manus Sazon**
> ""I thought Vina -- I mean, the Grand Duchess -- would be instrumental in getting out the vote. But she hasn't said a word one way or the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Manus Sazon**
> ""Fortunately, the Grand Duchess has been instrumental in energizing the populace. Her encouragement will drive Palesians to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[321]`
Mówca: **Daria de Rava**
> ""And neither your daughter nor Duke Reinhart have attempted to involve themselves in voter outreach efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Daria de Rava**
> ""Fortunately, your daughter and Duke Reinhart seem invested in making sure the process goes as smoothly as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Daria de Rava**
> ""Our new Palesian voter bloc will be key to clinching an RNC majority, I believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[327]`
Mówca: **Daria de Rava**
> ""I hope they come to their senses before the elections. Our new Palesian voter bloc will be key to clinching an RNC majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[328]`
Mówca: **Manus Sazon**
> ""Which is perhaps just as well. Most Palesians are expected to align with the RNC thanks to their many happy years under the Reinharts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[329]`
Mówca: **Manus Sazon**
> ""For better or worse. Most Palesians are expected to align with the RNC thanks to their many happy years under the Reinharts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Adarfo Sotelato**
> ""What's more, it seems the Princess of Rizia is not particularly invested in voter outreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Adarfo Sotelato**
> ""And here I thought she was too intelligent to buy into that succession nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[335]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Princess of Rizia has very passionately involved herself in getting out the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Adarfo Sotelato**
> ""I always knew she was the real reformist in your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Adarfo Sotelato**
> ""Just as well. I wouldn't be surprised if the Palesians went for the RNC. They're almost as conservative as your fellow Torases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[338]`
Mówca: **Adarfo Sotelato**
> ""Unfortunately, it looks like a majority of Palesians look set to vote for the RNC. They're almost as conservative as your fellow Torases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[339]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PalesOwnership_Azaros == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PalesOwnership_Azaros == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PalesOwnership_Azaros"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PalesOwnership_Azaros == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PalesOwnership_Azaros"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Daria de Rava**
> ""As expected, tensions persist between the conquered Palesians and the local Crown-controlled government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[344]`
Mówca: **Adarfo Sotelato**
> ""We have tried to foster unity by emphasizing that Palesians and Rizians alike have been liberated from the yoke of the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_EnoughFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_EnoughFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_EnoughFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Manus Sazon**
> ""The costs of reconstruction have been fully paid off, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_Installments == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_Installments == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_Installments == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Manus Sazon**
> ""Reconstruction is assured as long as our treasury can continue to cover the installments, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""Reconstruction stalled out due to a lack of funds. It's only now resumed thanks to a generous loan from Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[357]`
Mówca: **Manus Sazon**
> ""Reconstruction stalled out due to a lack of funds. It's only now resumed thanks to a generous loan from some international benefactors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_EnoughFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_EnoughFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_EnoughFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_Installments == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_Installments == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_Installments == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[364]`
Mówca: **Daria de Rava**
> ""The costs of reconstruction have been fully paid off, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[365]`
Mówca: **Daria de Rava**
> ""Reconstruction is assured as long as our treasury can continue to cover the installments, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[366]`
Mówca: **Daria de Rava**
> ""Reconstruction stalled out due to a lack of funds. It only resumed after we ran a campaign for Rizians to buy bonds in my family's construction company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_EnoughFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_EnoughFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_EnoughFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_Installments == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Reconstruction_Installments == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Reconstruction_Installments == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[373]`
Mówca: **Adarfo Sotelato**
> ""The costs of reconstruction have been fully paid off, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[374]`
Mówca: **Adarfo Sotelato**
> ""Reconstruction is assured as long as our treasury can continue to cover the installments, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[375]`
Mówca: **Adarfo Sotelato**
> ""Reconstruction stalled out due to a lack of funds. It only resumed after we sold off a few choice noble assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Fled"] == true  or  Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Fled"] == true  or  Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[379]`
Mówca: **Manus Sazon**
> ""Fortunately, Russello Montoro offered us a very generous loan to cover costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[148]`
  - -> `[156]`
  - -> `[149]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good call. I would have done the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? That man is not to be trusted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
