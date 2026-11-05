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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **""Sounds like a disaster waiting to happen.""** | `[19]` **Manus Sazon**: ""It's creating serious challenge..."<br>`[182]` **Daria de Rava**: ""It's proving to be a major obst..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | *Koniec sceny / Terminal* |
| `[21]` | **""We’ll press on. There’s no other option.""** | `[19]` **Manus Sazon**: ""It's creating serious challenge..."<br>`[182]` **Daria de Rava**: ""It's proving to be a major obst..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | *Koniec sceny / Terminal* |
| `[22]` | **""So much for fair elections.""** | `[19]` **Manus Sazon**: ""It's creating serious challenge..."<br>`[182]` **Daria de Rava**: ""It's proving to be a major obst..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | *Koniec sceny / Terminal* |
| `[44]` | **""From what I can tell, they’re not making it easy for themselves.""** | `[19]` **Manus Sazon**: ""It's creating serious challenge..."<br>`[182]` **Daria de Rava**: ""It's proving to be a major obst..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | *Koniec sceny / Terminal* |
| `[60]` | **""Then we’ll control what we can. Those who want to disrupt this will find we’re no..."** | `[19]` **Manus Sazon**: ""It's creating serious challenge..."<br>`[182]` **Daria de Rava**: ""It's proving to be a major obst..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | *Koniec sceny / Terminal* |
| `[99]` | **""It seems we've underestimated the depth of their resentment. We'll have to push h..."** | `[75]` **Manus Sazon**: ""Despite full funding dedicated ..."<br>`[76]` **Manus Sazon**: ""With full funding dedicated to ..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Manus Sazon**: ""They’ll come around in time.""<br>`[116]` **Daria de Rava**: ""I'm sure they’ll come around in..."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **""Their bitterness is temporary. Rizia's faced worse and still emerged stronger.""** | `[75]` **Manus Sazon**: ""Despite full funding dedicated ..."<br>`[76]` **Manus Sazon**: ""With full funding dedicated to ..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Manus Sazon**: ""We always do.""<br>`[134]` **Daria de Rava**: ""Yes. We always do.""<br>*(oraz 1 innych odgałęzień)* |
| `[101]` | **""Time has a way of healing even the deepest wounds.""** | `[75]` **Manus Sazon**: ""Despite full funding dedicated ..."<br>`[76]` **Manus Sazon**: ""With full funding dedicated to ..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Manus Sazon**: ""We'll get there.""<br>`[125]` **Daria de Rava**: ""I believe that as well.""<br>*(oraz 1 innych odgałęzień)* |
| `[148]` | **""If it keeps us afloat, we have no choice.""** | `[145]` **Manus Sazon**: ""Fortunately, as a gesture of go..."<br>`[379]` **Manus Sazon**: ""Fortunately, Russello Montoro o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Manus Sazon**: ""It's not an ideal situation, bu..." |
| `[149]` | **""Trading one disaster for another... wonderful.""** | `[145]` **Manus Sazon**: ""Fortunately, as a gesture of go..."<br>`[379]` **Manus Sazon**: ""Fortunately, Russello Montoro o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Manus Sazon**: ""The alternative would be far wo..." |
| `[150]` | **""We’ll owe them for decades. But perhaps that’s the lesser evil.""** | `[145]` **Manus Sazon**: ""Fortunately, as a gesture of go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Manus Sazon**: ""It’s a heavy price, but it may ..." |
| `[151]` | **""Well done. Pales' swift reconstruction will be worth it.""** | `[146]` **Daria de Rava**: ""Fortunately, following a campai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Daria de Rava**: ""For the greater good, yes."" |
| `[152]` | **""I hope they'll be paid back in the end.""** | `[146]` **Daria de Rava**: ""Fortunately, following a campai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Daria de Rava**: ""I and my family keep our word."" |
| `[153]` | **""They’ll resist, but they can afford it.""** | `[147]` **Adarfo Sotelato**: ""Which is why, under my directio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Adarfo Sotelato**: ""In the end, they'll see it was ..." |
| `[154]` | **""If they’re true patriots, they’ll accept the burden.""** | `[147]` **Adarfo Sotelato**: ""Which is why, under my directio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Adarfo Sotelato**: ""Patriot or not, the choice is n..." |
| `[155]` | **""Which assets?""** | `[147]` **Adarfo Sotelato**: ""Which is why, under my directio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Adarfo Sotelato**: ""House Toras didn't really need ..." |
| `[156]` | **""Better to be in debt than in ruins.""** | `[145]` **Manus Sazon**: ""Fortunately, as a gesture of go..."<br>`[379]` **Manus Sazon**: ""Fortunately, Russello Montoro o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Manus Sazon**: ""Agreed. It's not an ideal situa..." |
| `[157]` | **""That sounds suspiciously like corruption.""** | `[146]` **Daria de Rava**: ""Fortunately, following a campai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Daria de Rava**: ""The job had to be done."" |
| `[158]` | **""Good. It’s about time they paid their share.""** | `[147]` **Adarfo Sotelato**: ""Which is why, under my directio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Adarfo Sotelato**: ""I couldn't agree more."" |
| `[380]` | **""Good call. I would have done the same.""** | `[379]` **Manus Sazon**: ""Fortunately, Russello Montoro o..." | `Variable["RiziaDLC.Rusty_Allied"] == true` | *Brak zmian stanu* | `[166]` **Manus Sazon**: ""It's not an ideal situation, bu..." |
| `[384]` | **""What? That man is not to be trusted.""** | `[379]` **Manus Sazon**: ""Fortunately, Russello Montoro o..." | `(Variable["RiziaDLC.Rusty_Allied"] == true) == false` | *Brak zmian stanu* | `[168]` **Manus Sazon**: ""The alternative would be far wo..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)
  - -> `[2]` (*System / OUTPUT: "input"*)
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)

### Węzeł `[2]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `input`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `input`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `output`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""Our military presence continues to provide security, allowing voting infrastructure to be established where conditions allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""In relatively stable areas, electoral operations are progressing accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Manus Sazon: ""However, the division of Pales has complicated the proce..."*)

### Węzeł `[7]`
Mówca: **Manus Sazon**
> ""Many voters remain displaced, and even where communities are intact, security concerns have discouraged participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)

### Węzeł `[8]`
Mówca: **Manus Sazon**
> ""On top of this, the violence of war and the forced unification have left deep scars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Manus Sazon: ""Many in Pales remain distrustful of Rizia’s motives.""*)

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""Many in Pales remain distrustful of Rizia’s motives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""For some, the election feels imposed -- a process they f..."*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""For some, the election feels imposed -- a process they fear could invite retaliation if they engage with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Manus Sazon: ""This distrust has already hindered voter registration, p..."*)

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""This distrust has already hindered voter registration, particularly in the less stable regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales_KingResponse_Hub]"*)

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""Despite being alien to many, the shift from a monarchy to a democratic system has been largely embraced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Manus Sazon: ""While some older citizens have shown resistance to chang..."*)

### Węzeł `[13]`
Mówca: **Manus Sazon**
> ""While some older citizens have shown resistance to change, the opportunity to vote has sparked a wave of enthusiasm, particularly among those who were previously sidelined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""However, challenges remain. The local governance structures in Pales continue to clash with the nationalized systems being implemented by Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""The military's presence in Rizian-held areas is helping restore order, allowing us to push forward with voting plans despite the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: ""In calmer regions, we've started early voting and absent..."*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""In calmer regions, we've started early voting and absentee ballots to boost participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""Still, the fighting has made it nearly impossible to hol..."*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""Still, the fighting has made it nearly impossible to hold a secure vote in many parts of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""Displacement, intimidation, and violence will likely red..."*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""Displacement, intimidation, and violence will likely reduce turnout and skew representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: ""It's creating serious challenges for our logistical plan..."*)

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""It's creating serious challenges for our logistical planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales_KingResponse_Hub"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a disaster waiting to happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Manus Sazon), `[182]` (Daria de Rava), `[187]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’ll press on. There’s no other option.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Manus Sazon), `[182]` (Daria de Rava), `[187]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So much for fair elections.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Manus Sazon), `[182]` (Daria de Rava), `[187]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == false)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: ""The military's presence in Rizian-held areas is helping ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Daria de Rava: ""The military's presence in Rizian-held areas is helping ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Adarfo Sotelato: ""The military's presence may be holding some ground, but ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Won == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Manus Sazon: ""However, extensive destruction from the war has left muc..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""While much of Pales is still recovering, the damage to i..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""In relatively stable areas, electoral operations are pro..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From what I can tell, they’re not making it easy for themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Manus Sazon), `[182]` (Daria de Rava), `[187]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PalesOwnership_Azaros == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Adarfo Sotelato: ""Unsurprisingly, tensions still linger between the Pales ..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Pales_KingResponse_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""From what I can tell, they’re not making it easy for the..."*)
  - -> `[20]` (*Player_Romus: ""Sounds like a disaster waiting to happen.""*)
  - -> `[22]` (*Player_Romus: ""So much for fair elections.""*)
  - -> `[21]` (*Player_Romus: ""We’ll press on. There’s no other option.""*)
  - -> `[60]` (*Player_Romus: ""Then we’ll control what we can. Those who want to disrup..."*)

### Węzeł `[52]`
Mówca: **Manus Sazon**
> ""However, extensive destruction from the war has left much of Pales in disarray, with vital infrastructure severely compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""While much of Pales is still recovering, the damage to infrastructure is moderate but significant enough to cause disruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Manus Sazon: ""Despite being alien to many, the shift from a monarchy t..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Daria de Rava: ""Though unfamiliar to many, the move from monarchy to dem..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Adarfo Sotelato: ""The move from monarchy to democracy has given power back..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we’ll control what we can. Those who want to disrupt this will find we’re not as unprepared as they think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Manus Sazon), `[182]` (Daria de Rava), `[187]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[61]`
Mówca: **Manus Sazon**
> ""Our military presence ensures security in the regions controlled by Rizia, facilitating the establishment of voting infrastructure where conditions permit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Manus Sazon: ""Our military presence ensures security in the regions co..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Manus Sazon: ""Our military presence continues to provide security, all..."*)

### Węzeł `[65]`
Mówca: **Manus Sazon**
> ""However, the division of Pales has complicated the process, especially in regions still recovering from conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""And families split between Rizia and Pales further complicate representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Manus Sazon: ""On top of this, the violence of war and the forced unifi..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Manus Sazon: ""And families split between Rizia and Pales further compl..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Manus Sazon: ""On top of this, the violence of war and the forced unifi..."*)

### Węzeł `[70]`
Mówca: **Manus Sazon**
> ""Tensions persist with Palesian local forces, but long-term integration is steadily underway, though it will likely take decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Manus Sazon: ""As for the upcoming election...""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Manus Sazon: ""The division of Pales is marked by conflict, though tens..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Manus Sazon: ""Tensions persist with Palesian local forces, but long-te..."*)

### Węzeł `[74]`
Mówca: **Manus Sazon**
> ""The division of Pales is marked by conflict, though tensions remain manageable, particularly along the new shared border, with full integration expected to take decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Manus Sazon: ""As for the upcoming election...""*)

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""Despite full funding dedicated to reparations, widespread bitterness and anger among Palesians makes reconciliation a prolonged and difficult process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[76]`
Mówca: **Manus Sazon**
> ""With full funding dedicated to reparations, tensions are slowly easing, however, a significant portion of the population still resents Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""With full funding dedicated to reparations, substantial progress has been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Manus Sazon: ""However, lingering distrust and resentment from certain ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Manus Sazon: ""Despite full funding dedicated to reparations, widesprea..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Manus Sazon: ""With full funding dedicated to reparations, tensions are..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Manus Sazon: ""With full funding dedicated to reparations, substantial ..."*)

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""Reparation efforts are ongoing, however, widespread bitterness and anger among many Palesians toward Rizia is making it a prolonged and difficult process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Manus Sazon: ""As agreed, installments are being made over time.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Manus Sazon: ""Reparation efforts are ongoing, however, widespread bitt..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Reparation efforts are ongoing, and while tensions are slowly easing, a significant portion of the population still resents Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Manus Sazon: ""As agreed, installments are being made over time.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Manus Sazon: ""Reparation efforts are ongoing, and while tensions are s..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Manus Sazon: ""Reparation efforts are ongoing.""*)

### Węzeł `[92]`
Mówca: **Manus Sazon**
> ""Reparation efforts are ongoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manus Sazon: ""While substantial progress has been made, lingering dist..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Immediate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Immediate == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ReparationsAccepted_Immediate == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Immediate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ReparationsAccepted_Immediate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Installments == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Installments == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Installments == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ReparationsAccepted_Installments == true )"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Installments == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ReparationsAccepted_Installments == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""But the lack of funding toward the agreed upon reparatio..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems we've underestimated the depth of their resentment. We'll have to push harder to smooth things over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Manus Sazon), `[76]` (Manus Sazon), `[106]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their bitterness is temporary. Rizia's faced worse and still emerged stronger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Manus Sazon), `[76]` (Manus Sazon), `[106]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time has a way of healing even the deepest wounds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Manus Sazon), `[76]` (Manus Sazon), `[106]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""But the lack of funding toward the agreed upon reparations cost has made any meaningful recovery impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Manus Sazon: ""As a result, infrastructure lies in ruin, and food is sc..."*)

### Węzeł `[103]`
Mówca: **Manus Sazon**
> ""As a result, infrastructure lies in ruin, and food is scarce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Manus Sazon: ""Lawlessness is at an all-time high, fueling widespread a..."*)

### Węzeł `[104]`
Mówca: **Manus Sazon**
> ""It became clear that if we failed to meet our obligation, it could reignite the war and provoke severe sanctions from the international community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested ==..."*)

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""While substantial progress has been made, lingering distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Manus Sazon: ""As agreed, installments are being made over time.""*)

### Węzeł `[106]`
Mówca: **Manus Sazon**
> ""As agreed, installments are being made over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[107]`
Mówca: **Manus Sazon**
> ""However, lingering distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[108]`
Mówca: **Manus Sazon**
> ""As for the upcoming election...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Immediate == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Immediate == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Immediate == true"*)

### Węzeł `[115]`
Mówca: **Manus Sazon**
> ""They’ll come around in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[116]`
Mówca: **Daria de Rava**
> ""I'm sure they’ll come around in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[117]`
Mówca: **Adarfo Sotelato**
> ""Some wounds aren't easily mended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Manus Sazon: ""They’ll come around in time.""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Daria de Rava: ""I'm sure they’ll come around in time.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Adarfo Sotelato: ""Some wounds aren't easily mended.""*)

### Węzeł `[124]`
Mówca: **Manus Sazon**
> ""We'll get there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[125]`
Mówca: **Daria de Rava**
> ""I believe that as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[126]`
Mówca: **Adarfo Sotelato**
> ""Provided we give them reason to heal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Manus Sazon: ""We'll get there.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Daria de Rava: ""I believe that as well.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Adarfo Sotelato: ""Provided we give them reason to heal.""*)

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""We always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""Yes. We always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""As long as they’re willing to see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Manus Sazon: ""We always do.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Daria de Rava: ""Yes. We always do.""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Adarfo Sotelato: ""As long as they’re willing to see reason.""*)

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""Lawlessness is at an all-time high, fueling widespread anger among Palesians toward Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Manus Sazon: ""It became clear that if we failed to meet our obligation..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reparations_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""It seems we've underestimated the depth of their resentm..."*)
  - -> `[101]` (*Player_Romus: ""Time has a way of healing even the deepest wounds.""*)
  - -> `[100]` (*Player_Romus: ""Their bitterness is temporary. Rizia's faced worse and s..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reparations_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "Reparations_Hub"*)

### Węzeł `[145]`
Mówca: **Manus Sazon**
> ""Fortunately, as a gesture of goodwill in Rizia's new leadership, the Republic of Lespia has offered us a generous loan to cover costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""If it keeps us afloat, we have no choice.""*)
  - -> `[156]` (*Player_Romus: ""Better to be in debt than in ruins.""*)
  - -> `[149]` (*Player_Romus: ""Trading one disaster for another... wonderful.""*)
  - -> `[150]` (*Player_Romus: ""We’ll owe them for decades. But perhaps that’s the lesse..."*)

### Węzeł `[146]`
Mówca: **Daria de Rava**
> ""Fortunately, following a campaign to sell bonds to the Rizian public, De Rava Construction is equipped to complete the repairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""That sounds suspiciously like corruption.""*)
  - -> `[151]` (*Player_Romus: ""Well done. Pales' swift reconstruction will be worth it.""*)
  - -> `[152]` (*Player_Romus: ""I hope they'll be paid back in the end.""*)

### Węzeł `[147]`
Mówca: **Adarfo Sotelato**
> ""Which is why, under my direction, the House of Delegates has approved the seizure of a few choice assets from noble families. Your own included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""Good. It’s about time they paid their share.""*)
  - -> `[153]` (*Player_Romus: ""They’ll resist, but they can afford it.""*)
  - -> `[154]` (*Player_Romus: ""If they’re true patriots, they’ll accept the burden.""*)
  - -> `[155]` (*Player_Romus: ""Which assets?""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it keeps us afloat, we have no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Manus Sazon), `[379]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Manus Sazon: ""It's not an ideal situation, but it's the path we must t..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trading one disaster for another... wonderful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Manus Sazon), `[379]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Manus Sazon: ""The alternative would be far worse.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’ll owe them for decades. But perhaps that’s the lesser evil.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Manus Sazon: ""It’s a heavy price, but it may be the only way forward.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well done. Pales' swift reconstruction will be worth it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Daria de Rava: ""For the greater good, yes.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope they'll be paid back in the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Daria de Rava: ""I and my family keep our word.""*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They’ll resist, but they can afford it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Adarfo Sotelato: ""In the end, they'll see it was worth it for the greater ..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they’re true patriots, they’ll accept the burden.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Adarfo Sotelato: ""Patriot or not, the choice is not up to them.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which assets?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Adarfo Sotelato: ""House Toras didn't really need its own zoo, did you?""*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Better to be in debt than in ruins.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Manus Sazon), `[379]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Manus Sazon: ""Agreed. It's not an ideal situation, but it's the path w..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds suspiciously like corruption.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Daria de Rava: ""The job had to be done.""*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. It’s about time they paid their share.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Adarfo Sotelato: ""I couldn't agree more.""*)

### Węzeł `[159]`
Mówca: **Adarfo Sotelato**
> ""Patriot or not, the choice is not up to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[160]`
Mówca: **Adarfo Sotelato**
> ""House Toras didn't really need its own zoo, did you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[161]`
Mówca: **Adarfo Sotelato**
> ""In the end, they'll see it was worth it for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[162]`
Mówca: **Adarfo Sotelato**
> ""I couldn't agree more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[163]`
Mówca: **Daria de Rava**
> ""For the greater good, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[164]`
Mówca: **Daria de Rava**
> ""The job had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[165]`
Mówca: **Daria de Rava**
> ""I and my family keep our word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""It's not an ideal situation, but it's the path we must take to maintain stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[167]`
Mówca: **Manus Sazon**
> ""Agreed. It's not an ideal situation, but it's the path we must take to maintain stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""The alternative would be far worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[169]`
Mówca: **Manus Sazon**
> ""It’s a heavy price, but it may be the only way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""But insufficient funding for the agreed reparations has rendered any substantial recovery unattainable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Daria de Rava: ""Consequently, infrastructure remains in disrepair, and f..."*)

### Węzeł `[171]`
Mówca: **Daria de Rava**
> ""Consequently, infrastructure remains in disrepair, and food is in short supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Daria de Rava: ""Lawlessness has reached unprecedented levels, sparking w..."*)

### Węzeł `[172]`
Mówca: **Daria de Rava**
> ""Lawlessness has reached unprecedented levels, sparking widespread resentment among Palesians toward Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Daria de Rava: ""It became apparent that failing to fulfill our duty coul..."*)

### Węzeł `[173]`
Mówca: **Daria de Rava**
> ""It became apparent that failing to fulfill our duty could reignite the war and invite harsh international sanctions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Daria de Rava: ""Fortunately, following a campaign to sell bonds to the R..."*)

### Węzeł `[174]`
Mówca: **Adarfo Sotelato**
> ""The lack of funding for the agreed reparations has made it impossible for the people to rebuild their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Adarfo Sotelato: ""As a result, communities remain shattered, and food is h..."*)

### Węzeł `[175]`
Mówca: **Adarfo Sotelato**
> ""As a result, communities remain shattered, and food is hard to come by.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Adarfo Sotelato: ""Lawlessness is rampant, and the suffering of the Palesia..."*)

### Węzeł `[176]`
Mówca: **Adarfo Sotelato**
> ""Lawlessness is rampant, and the suffering of the Palesians has only grown, fueling their anger toward Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Adarfo Sotelato: ""It became clear that if we failed to honor our commitmen..."*)

### Węzeł `[177]`
Mówca: **Adarfo Sotelato**
> ""It became clear that if we failed to honor our commitment, it would not only reignite the war but bring even greater hardship to the people, along with severe international repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Adarfo Sotelato: ""Which is why, under my direction, the House of Delegates..."*)

### Węzeł `[178]`
Mówca: **Daria de Rava**
> ""The military's presence in Rizian-held areas is helping maintain order, giving us room to move forward with voting plans despite the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Daria de Rava: ""In quieter regions, we've introduced early voting and ab..."*)

### Węzeł `[179]`
Mówca: **Daria de Rava**
> ""In quieter regions, we've introduced early voting and absentee ballots to encourage participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""Even so, the ongoing violence has made it nearly impossi..."*)

### Węzeł `[180]`
Mówca: **Daria de Rava**
> ""Even so, the ongoing violence has made it nearly impossible to hold a safe vote in much of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Daria de Rava: ""Displacement, threats, and violence are likely to suppre..."*)

### Węzeł `[181]`
Mówca: **Daria de Rava**
> ""Displacement, threats, and violence are likely to suppress turnout and distort representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Daria de Rava: ""It's proving to be a major obstacle in our logistical pl..."*)

### Węzeł `[182]`
Mówca: **Daria de Rava**
> ""It's proving to be a major obstacle in our logistical planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales_KingResponse_Hub"*)

### Węzeł `[183]`
Mówca: **Adarfo Sotelato**
> ""The military's presence may be holding some ground, but it's hardly enough to ensure a stable vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Adarfo Sotelato: ""Early voting and absentee ballots have been introduced i..."*)

### Węzeł `[184]`
Mówca: **Adarfo Sotelato**
> ""Early voting and absentee ballots have been introduced in calmer regions, but that's little comfort given the unrest elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Adarfo Sotelato: ""In truth, the fighting has made secure voting all but im..."*)

### Węzeł `[185]`
Mówca: **Adarfo Sotelato**
> ""In truth, the fighting has made secure voting all but impossible in many parts of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Adarfo Sotelato: ""With people displaced, threatened, or caught in the viol..."*)

### Węzeł `[186]`
Mówca: **Adarfo Sotelato**
> ""With people displaced, threatened, or caught in the violence, turnout will be dismal, and representation skewed beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Adarfo Sotelato: ""The war has turned what should have been a clear process..."*)

### Węzeł `[187]`
Mówca: **Adarfo Sotelato**
> ""The war has turned what should have been a clear process into a logistical nightmare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales_KingResponse_Hub"*)

### Węzeł `[188]`
Mówca: **Daria de Rava**
> ""Though unfamiliar to many, the move from monarchy to democracy has been widely welcomed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Daria de Rava: ""Some older citizens have resisted the change, but the ch..."*)

### Węzeł `[189]`
Mówca: **Daria de Rava**
> ""Some older citizens have resisted the change, but the chance to vote has energized those who once felt excluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[190]`
Mówca: **Daria de Rava**
> ""That said, challenges persist. Pales’ local governance still clashes with the national systems Rizia is trying to enforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[191]`
Mówca: **Adarfo Sotelato**
> ""The move from monarchy to democracy has given power back to the people -- a long-overdue step toward true equality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Adarfo Sotelato: ""While some of the older generation cling to the past, a ..."*)

### Węzeł `[192]`
Mówca: **Adarfo Sotelato**
> ""While some of the older generation cling to the past, a new wave of excitement is sweeping across the country, especially among those who once had no voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[193]`
Mówca: **Adarfo Sotelato**
> ""Of course, there are still hurdles. Pales’ long-standing leadership keeps resisting the national systems Rizia is putting in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[194]`
Mówca: **Daria de Rava**
> ""Our military continues to ensure security, allowing for the establishment of voting infrastructure where conditions allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[195]`
Mówca: **Daria de Rava**
> ""In relatively stable regions, electoral preparations are progressing as expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Daria de Rava: ""However, in areas still recovering from conflict, linger..."*)

### Węzeł `[196]`
Mówca: **Daria de Rava**
> ""However, in areas still recovering from conflict, lingering instability has made securing the election far more difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[197]`
Mówca: **Daria de Rava**
> ""Many voters remain displaced, and even in stable communities, security fears have kept some from participating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""On top of that, the war has left lasting wounds.""*)

### Węzeł `[198]`
Mówca: **Daria de Rava**
> ""On top of that, the war has left lasting wounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Daria de Rava: ""Many in Pales remain wary of Rizia’s intentions, especia..."*)

### Węzeł `[199]`
Mówca: **Daria de Rava**
> ""Many in Pales remain wary of Rizia’s intentions, especially when it comes to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Daria de Rava: ""For some, this whole thing feels like a trap -- like tak..."*)

### Węzeł `[200]`
Mówca: **Daria de Rava**
> ""For some, this whole thing feels like a trap -- like taking part could make them targets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Daria de Rava: ""That fear has already kept plenty of people from registe..."*)

### Węzeł `[201]`
Mówca: **Daria de Rava**
> ""That fear has already kept plenty of people from registering, especially in places where tensions are still high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales_KingResponse_Hub]"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Pales_KingResponse_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales_KingResponse_Hub"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Daria de Rava: ""While Pales is still recovering, infrastructure damage -..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Daria de Rava: ""In relatively stable regions, electoral preparations are..."*)

### Węzeł `[206]`
Mówca: **Daria de Rava**
> ""While Pales is still recovering, infrastructure damage -- though moderate -- has been significant enough to cause major disruptions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Daria de Rava: ""This, in turn, has created considerable obstacles for el..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Daria de Rava: ""However, extensive damage from the war has left much of ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[210]`
Mówca: **Daria de Rava**
> ""However, extensive damage from the war has left much of Pales in disarray, with critical infrastructure severely damaged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Daria de Rava: ""As you can imagine, this has made organizing the electio..."*)

### Węzeł `[211]`
Mówca: **Daria de Rava**
> ""As you can imagine, this has made organizing the election far more difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[212]`
Mówca: **Daria de Rava**
> ""This, in turn, has created considerable obstacles for election planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""As expected, tensions persist between the conquered Palesians and the local Azaro government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Daria de Rava: ""Full integration is expected to take decades, if not lon..."*)

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""As for the upcoming vote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Daria de Rava: ""Our military continues to ensure security, allowing for ..."*)

### Węzeł `[215]`
Mówca: **Adarfo Sotelato**
> ""The military's presence is keeping things from spiraling, which has allowed some groundwork for voting to begin -- but only where conditions allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[216]`
Mówca: **Adarfo Sotelato**
> ""In relatively stable areas, voting prep is moving along -- slowly, but it’s happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Adarfo Sotelato: ""But regions still trying to recover are facing instabili..."*)

### Węzeł `[217]`
Mówca: **Adarfo Sotelato**
> ""But regions still trying to recover are facing instability that’s making it even harder to secure the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[218]`
Mówca: **Adarfo Sotelato**
> ""Many voters remain displaced, and even where communities are intact, security concerns have discouraged participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Adarfo Sotelato: ""On top of this, the violence of war and the forced unifi..."*)

### Węzeł `[219]`
Mówca: **Adarfo Sotelato**
> ""On top of this, the violence of war and the forced unification have left deep scars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Adarfo Sotelato: ""We have tried to foster unity by emphasizing that Palesi..."*)

### Węzeł `[220]`
Mówca: **Adarfo Sotelato**
> ""But many in Pales still don’t trust Rizia's intentions, especially when it comes to anything related to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Adarfo Sotelato: ""This distrust has already hindered voter registration, p..."*)

### Węzeł `[221]`
Mówca: **Adarfo Sotelato**
> ""This distrust has already hindered voter registration, particularly in regions that remain unstable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales_KingResponse_Hub]"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Adarfo Sotelato: ""While some areas are steady enough to manage, plenty of ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Adarfo Sotelato: ""In relatively stable areas, voting prep is moving along ..."*)

### Węzeł `[225]`
Mówca: **Adarfo Sotelato**
> ""While some areas are steady enough to manage, plenty of places are still too battered for things to run smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Adarfo Sotelato: ""This, in turn, has created significant challenges for el..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Adarfo Sotelato: ""However, Pales is still reeling from the war -- roads, s..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[229]`
Mówca: **Adarfo Sotelato**
> ""However, Pales is still reeling from the war -- roads, services, and supply lines are barely functioning, making it far tougher to organize the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Adarfo Sotelato: ""This, in turn, has made electoral operations an uphill b..."*)

### Węzeł `[230]`
Mówca: **Adarfo Sotelato**
> ""This, in turn, has made electoral operations an uphill battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[231]`
Mówca: **Adarfo Sotelato**
> ""This, in turn, has created significant challenges for electoral operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)

### Węzeł `[232]`
Mówca: **Adarfo Sotelato**
> ""Unsurprisingly, tensions still linger between the Pales population and their Rizian stewards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Adarfo Sotelato: ""Full integration will take generations, if not longer.""*)

### Węzeł `[233]`
Mówca: **Adarfo Sotelato**
> ""Full integration will take generations, if not longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Adarfo Sotelato: ""The military's presence is keeping things from spiraling..."*)

### Węzeł `[234]`
Mówca: **Daria de Rava**
> ""Full integration is expected to take decades, if not longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Daria de Rava: ""As for the upcoming vote...""*)

### Węzeł `[235]`
Mówca: **Manus Sazon**
> ""More than anything, people are just relieved the war’s behind them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Manus Sazon: ""More than anything, people are just relieved the war’s b..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Daria de Rava: ""First and foremost, the end of the war has brought a sen..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Adarfo Sotelato: ""First and foremost, people are just relieved the war is ..."*)

### Węzeł `[242]`
Mówca: **Daria de Rava**
> ""First and foremost, the end of the war has brought a sense of relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[243]`
Mówca: **Adarfo Sotelato**
> ""First and foremost, people are just relieved the war is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[244]`
Mówca: **Daria de Rava**
> ""Even with full funding for reparations, bitterness and anger in Pales are still running high, making reconciliation slow and difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[245]`
Mówca: **Daria de Rava**
> ""Despite full funding for reparations, progress is slow, and resentment toward Rizia still lingers in much of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[246]`
Mówca: **Daria de Rava**
> ""With full funding toward reparations, substantial progress has been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Daria de Rava: ""However, lingering distrust and resentment from certain ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Daria de Rava: ""Even with full funding for reparations, bitterness and a..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Daria de Rava: ""Despite full funding for reparations, progress is slow, ..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Daria de Rava: ""With full funding toward reparations, substantial progre..."*)

### Węzeł `[253]`
Mówca: **Daria de Rava**
> ""Reparations are underway, but frustration and bitterness in Pales are dragging out the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Daria de Rava: ""As agreed, installments are being made over time.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Daria de Rava: ""Reparations are underway, but frustration and bitterness..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[257]`
Mówca: **Daria de Rava**
> ""Reparation efforts are ongoing, and while tensions are slowly easing, many Palesians still resent Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Daria de Rava: ""As agreed, installments are being made over time.""*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Daria de Rava: ""Reparation efforts are ongoing, and while tensions are s..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Daria de Rava: ""Reparation efforts are ongoing.""*)

### Węzeł `[261]`
Mówca: **Daria de Rava**
> ""Reparation efforts are ongoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Daria de Rava: ""While progress has been made, lingering distrust and res..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Immediate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Immediate == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ReparationsAccepted_Immediate == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Immediate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ReparationsAccepted_Immediate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Installments == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Installments == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Installments == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ReparationsAccepted_Installments == true )"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Installments == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ReparationsAccepted_Installments == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Daria de Rava: ""But insufficient funding for the agreed reparations has ..."*)

### Węzeł `[268]`
Mówca: **Daria de Rava**
> ""While progress has been made, lingering distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Daria de Rava: ""As agreed, installments are being made over time.""*)

### Węzeł `[269]`
Mówca: **Daria de Rava**
> ""As agreed, installments are being made over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[270]`
Mówca: **Daria de Rava**
> ""However, lingering distrust and resentment from certain Palesian groups still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reparations_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "Reparations_Hub"*)

### Węzeł `[272]`
Mówca: **Adarfo Sotelato**
> ""Despite full funding for reparations, progress is slow, and Palesian resentment continues to stand in the way of meaningful reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[273]`
Mówca: **Adarfo Sotelato**
> ""With full funding allocated to reparations, tensions are gradually easing, but deep-rooted resentment from many Palesians still complicates progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[274]`
Mówca: **Adarfo Sotelato**
> ""While reparations have seen substantial funding, but distrust and resentment from certain Palesian factions still hinder the complete healing of relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Adarfo Sotelato: ""Despite full funding for reparations, progress is slow, ..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Adarfo Sotelato: ""With full funding allocated to reparations, tensions are..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Adarfo Sotelato: ""While reparations have seen substantial funding, but dis..."*)

### Węzeł `[281]`
Mówca: **Adarfo Sotelato**
> ""Reparation efforts are underway, but widespread bitterness among Palesians toward Rizia is making the process longer and more difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Adarfo Sotelato: ""As agreed, installments are being made over time.""*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Adarfo Sotelato: ""Reparation efforts are underway, but widespread bitterne..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)

### Węzeł `[285]`
Mówca: **Adarfo Sotelato**
> ""Reparation efforts are ongoing, and while tensions are slowly easing, many Palesians still resent Rizia, complicating progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Adarfo Sotelato: ""As agreed, installments are being made over time.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Moderat..."*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moder..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Adarfo Sotelato: ""Reparation efforts are ongoing, and while tensions are s..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_War_Pales_Destruction_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Adarfo Sotelato: ""Reparation efforts continue, and though tensions are sta..."*)

### Węzeł `[289]`
Mówca: **Adarfo Sotelato**
> ""Reparation efforts continue, and though tensions are starting to ease, a significant portion of the population still resents Rizia, hindering progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Adarfo Sotelato: ""As agreed, installments are being made over time.""*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Immediate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Immediate == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ReparationsAccepted_Immediate == true)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Immediate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ReparationsAccepted_Immediate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Immediate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Installments == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Installments == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ReparationsAccepted_Installments == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ReparationsAccepted_Installments == true )"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ReparationsAccepted_Installments == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ReparationsAccepted_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_War_Pales_Destruction_Heavy =..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ReparationsAccepted_Installments == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ReparationsAccepted_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Adarfo Sotelato: ""The lack of funding for the agreed reparations has made ..."*)

### Węzeł `[296]`
Mówca: **Adarfo Sotelato**
> ""As agreed, installments are being made over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reparations_Hub]"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reparations_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "Reparations_Hub"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "output"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "output"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "output"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "output"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "output"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "output"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Manus Sazon: ""However, challenges remain. The local governance structu..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Manus Sazon: ""However, challenges remain. The local governance structu..."*)

### Węzeł `[307]`
Mówca: **Manus Sazon**
> ""However, challenges remain. The local governance structures in Pales continue to clash with the systems implemented in the other provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Daria de Rava: ""That said, challenges persist. Pales’ local governance s..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Daria de Rava: ""However, challenges remain. The local governance structu..."*)

### Węzeł `[311]`
Mówca: **Daria de Rava**
> ""However, challenges remain. The local governance structures in Pales continue to clash with the systems implemented in the other provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Adarfo Sotelato: ""Of course, there are still hurdles. Pales’ long-standing..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Adarfo Sotelato: ""Of course, there are still hurdles. Pales’ long-standing..."*)

### Węzeł `[315]`
Mówca: **Adarfo Sotelato**
> ""Of course, there are still hurdles. Pales’ long-standing leadership keeps resisting the systems Rizia's other provinces have put into place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[316]`
Mówca: **Manus Sazon**
> ""I thought Vina -- I mean, the Grand Duchess -- would be instrumental in getting out the vote. But she hasn't said a word one way or the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Manus Sazon: ""Which is perhaps just as well. Most Palesians are expect..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Manus Sazon: ""I thought Vina -- I mean, the Grand Duchess -- would be ..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Manus Sazon: ""Fortunately, the Grand Duchess has been instrumental in ..."*)

### Węzeł `[320]`
Mówca: **Manus Sazon**
> ""Fortunately, the Grand Duchess has been instrumental in energizing the populace. Her encouragement will drive Palesians to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "He frowned."*)

### Węzeł `[321]`
Mówca: **Daria de Rava**
> ""And neither your daughter nor Duke Reinhart have attempted to involve themselves in voter outreach efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Daria de Rava: ""I hope they come to their senses before the elections. O..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Daria de Rava: ""And neither your daughter nor Duke Reinhart have attempt..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Daria de Rava: ""Fortunately, your daughter and Duke Reinhart seem invest..."*)

### Węzeł `[325]`
Mówca: **Daria de Rava**
> ""Fortunately, your daughter and Duke Reinhart seem invested in making sure the process goes as smoothly as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Daria de Rava: ""Our new Palesian voter bloc will be key to clinching an ..."*)

### Węzeł `[326]`
Mówca: **Daria de Rava**
> ""Our new Palesian voter bloc will be key to clinching an RNC majority, I believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[327]`
Mówca: **Daria de Rava**
> ""I hope they come to their senses before the elections. Our new Palesian voter bloc will be key to clinching an RNC majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[328]`
Mówca: **Manus Sazon**
> ""Which is perhaps just as well. Most Palesians are expected to align with the RNC thanks to their many happy years under the Reinharts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[329]`
Mówca: **Manus Sazon**
> ""For better or worse. Most Palesians are expected to align with the RNC thanks to their many happy years under the Reinharts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Adarfo Sotelato: ""What's more, it seems the Princess of Rizia is not parti..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Adarfo Sotelato: ""Fortunately, the Princess of Rizia has very passionately..."*)

### Węzeł `[333]`
Mówca: **Adarfo Sotelato**
> ""What's more, it seems the Princess of Rizia is not particularly invested in voter outreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Adarfo Sotelato: ""And here I thought she was too intelligent to buy into t..."*)

### Węzeł `[334]`
Mówca: **Adarfo Sotelato**
> ""And here I thought she was too intelligent to buy into that succession nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Adarfo Sotelato: ""Just as well. I wouldn't be surprised if the Palesians w..."*)

### Węzeł `[335]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Princess of Rizia has very passionately involved herself in getting out the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Adarfo Sotelato: ""I always knew she was the real reformist in your family.""*)

### Węzeł `[336]`
Mówca: **Adarfo Sotelato**
> ""I always knew she was the real reformist in your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Adarfo Sotelato: ""Unfortunately, it looks like a majority of Palesians loo..."*)

### Węzeł `[337]`
Mówca: **Adarfo Sotelato**
> ""Just as well. I wouldn't be surprised if the Palesians went for the RNC. They're almost as conservative as your fellow Torases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[338]`
Mówca: **Adarfo Sotelato**
> ""Unfortunately, it looks like a majority of Palesians look set to vote for the RNC. They're almost as conservative as your fellow Torases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[339]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Manus Sazon: ""For better or worse. Most Palesians are expected to alig..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PalesOwnership_Azaros == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PalesOwnership_Azaros == true"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PalesOwnership_Azaros == true)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PalesOwnership_Azaros == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PalesOwnership_Azaros"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Daria de Rava: ""As expected, tensions persist between the conquered Pale..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PalesOwnership_Azaros == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PalesOwnership_Azaros"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Daria de Rava: ""As expected, tensions persist between the conquered Pale..."*)

### Węzeł `[343]`
Mówca: **Daria de Rava**
> ""As expected, tensions persist between the conquered Palesians and the local Crown-controlled government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Daria de Rava: ""Full integration is expected to take decades, if not lon..."*)

### Węzeł `[344]`
Mówca: **Adarfo Sotelato**
> ""We have tried to foster unity by emphasizing that Palesians and Rizians alike have been liberated from the yoke of the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Adarfo Sotelato: ""But many in Pales still don’t trust Rizia's intentions, ..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_EnoughFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_EnoughFunds == true)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_EnoughFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Manus Sazon: ""The costs of reconstruction have been fully paid off, bu..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_EnoughFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_Installments == true"*)

### Węzeł `[348]`
Mówca: **Manus Sazon**
> ""The costs of reconstruction have been fully paid off, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_Installments == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_Installments == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_Installments == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_Installments == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Manus Sazon: ""Reconstruction is assured as long as our treasury can co..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_Installments == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested =..."*)

### Węzeł `[352]`
Mówca: **Manus Sazon**
> ""Reconstruction is assured as long as our treasury can continue to cover the installments, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested =..."*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Manus Sazon: ""Reconstruction stalled out due to a lack of funds. It's ..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Manus Sazon: ""Reconstruction stalled out due to a lack of funds. It's ..."*)

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""Reconstruction stalled out due to a lack of funds. It's only now resumed thanks to a generous loan from Russello Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[357]`
Mówca: **Manus Sazon**
> ""Reconstruction stalled out due to a lack of funds. It's only now resumed thanks to a generous loan from some international benefactors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_EnoughFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_EnoughFunds == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_EnoughFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Daria de Rava: ""The costs of reconstruction have been fully paid off, bu..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_EnoughFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_Installments == true"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_Installments == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_Installments == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_Installments == true)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_Installments == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Daria de Rava: ""Reconstruction is assured as long as our treasury can co..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_Installments == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Daria de Rava: ""Reconstruction stalled out due to a lack of funds. It on..."*)

### Węzeł `[364]`
Mówca: **Daria de Rava**
> ""The costs of reconstruction have been fully paid off, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Daria de Rava: ""Many voters remain displaced, and even in stable communi..."*)

### Węzeł `[365]`
Mówca: **Daria de Rava**
> ""Reconstruction is assured as long as our treasury can continue to cover the installments, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Daria de Rava: ""Many voters remain displaced, and even in stable communi..."*)

### Węzeł `[366]`
Mówca: **Daria de Rava**
> ""Reconstruction stalled out due to a lack of funds. It only resumed after we ran a campaign for Rizians to buy bonds in my family's construction company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Daria de Rava: ""Many voters remain displaced, and even in stable communi..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_EnoughFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_EnoughFunds == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_EnoughFunds == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_EnoughFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Adarfo Sotelato: ""The costs of reconstruction have been fully paid off, bu..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_EnoughFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_EnoughFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_Installments == true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_Installments == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_Installments == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_Installments == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_Installments == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Adarfo Sotelato: ""Reconstruction is assured as long as our treasury can co..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_Installments == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_Installments"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Adarfo Sotelato: ""Reconstruction stalled out due to a lack of funds. It on..."*)

### Węzeł `[373]`
Mówca: **Adarfo Sotelato**
> ""The costs of reconstruction have been fully paid off, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Adarfo Sotelato: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[374]`
Mówca: **Adarfo Sotelato**
> ""Reconstruction is assured as long as our treasury can continue to cover the installments, but it is still expected to take some time before all of Pales is back to normal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Adarfo Sotelato: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[375]`
Mówca: **Adarfo Sotelato**
> ""Reconstruction stalled out due to a lack of funds. It only resumed after we sold off a few choice noble assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Adarfo Sotelato: ""Many voters remain displaced, and even where communities..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested ==..."*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested ..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Fled"] == true  or  Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Manus Sazon: ""Fortunately, Russello Montoro offered us a very generous..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Fled == true || RiziaDLC.Rusty_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Fled"] == true  or  Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manus Sazon: ""Fortunately, as a gesture of goodwill in Rizia's new lea..."*)

### Węzeł `[379]`
Mówca: **Manus Sazon**
> ""Fortunately, Russello Montoro offered us a very generous loan to cover costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[148]` (*Player_Romus: ""If it keeps us afloat, we have no choice.""*)
  - -> `[156]` (*Player_Romus: ""Better to be in debt than in ruins.""*)
  - -> `[149]` (*Player_Romus: ""Trading one disaster for another... wonderful.""*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good call. I would have done the same.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Kontekst wejściowy (poprzednik):** `[379]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Manus Sazon: ""It's not an ideal situation, but it's the path we must t..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player_Romus: ""Good call. I would have done the same.""*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Romus: ""What? That man is not to be trusted.""*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? That man is not to be trusted.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[379]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Manus Sazon: ""The alternative would be far worse.""*)
