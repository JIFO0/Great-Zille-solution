# Rizia/Turn 8/NOTES_CONSTITION FINALIZED

- **ID konwersacji:** `408`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/408_NOTES_CONSTITION_FINALIZED.md`
- **Liczba węzłów dialogowych:** 78
- **Liczba wyborów gracza:** 22

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral`
- `RiziaDLCIsolated.Reform_Intention_Regions_Centralize`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Reform_Judiciary_Immunity`
- `RiziaDLC.Reform_Judiciary_JudicialReview`
- `RiziaDLC.Reform_Judiciary_LifeTenure`
- `RiziaDLC.Reform_Judiciary_NoConstitutionalCourt`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Legislative_RegionalSenate`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_UpperHouse_Advisory`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Situation_Order_AutonomousProvincialPolicing_None`
- `RiziaDLC.Situation_Order_AutonomousProvincialPolicing_Some`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_CentralizeRegions`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_HouseOfLords`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_JudicialReview`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_JudiciaryImmunity`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_LifeTenure`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_NoConstitutionalCourt`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseAdvisorary`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseEqual`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseLimited`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 12

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[10]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = true; Variable["RiziaDLCSupport.Journal_Tu...`
- Węzeł `[11]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true; Variable["RiziaDLCSupport.Journal_...`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true; Variable["RiziaDLCSupport.Journal_Turn08_...`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Judiciary_Immunity"] = true; Variable["RiziaDLCSupport.Journal_Turn08_R...`
- Węzeł `[41]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Regions_Centralized"] = true; Variable["RiziaDLCSupport.Journal_Turn08_...`
- Węzeł `[50]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Judiciary_NoConstitutionalCourt"] = true; Variable["RiziaDLCSupport.Jou...`
- Węzeł `[52]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true; Variable["RiziaDLCSupport.Journal_Turn08_R...`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true; Variable["RiziaDLCSupport.Journal_Turn08_Ref...`
- *...oraz 4 innych węzłów ze skryptami.*

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
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""How about the legislative? You mentioned establishing an upper house. How would that be structured?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[13]`
  - -> `[14]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind. We will establish a House of Lords comprised of the nobility as an upper house to get the nobility's backing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. House of Delegates will be the sole legislative body in the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""And how would the upper house be structured?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[17]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_HouseOfLords = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_HouseOfLords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_RegionalSenate = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind. We may need to establish an upper house that would provide checks and balances on the legislative branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will establish a House of Lords comprised of the nobility as an upper house to get the nobility's backing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will establish a Senate comprised of elected senators from each region as an upper house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's not the best idea. We will keep the House of Delegates as the sole legislative body.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "He kept taking notes as I spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[51]`

### Węzeł `[20]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They won't have the authority to initiate any legislation. They will only have limited legislative powers, such as voting on constitutional amendments and advising the lower house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both houses will vote on legislation and approval of both will be required for enacting new laws. We will exercise equal bicameralism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseAdvisorary = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseAdvisorary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""And the judiciary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[55]`
  - -> `[25]`
  - -> `[53]`
  - -> `[61]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will grant them life tenure, which would free them from the pressure of protecting powerful interests or deciding according to momentary populism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Judiciary_Immunity = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_JudiciaryImmunity = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_Immunity"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_JudiciaryImmunity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "He took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Manus Sazon**
> ""I'll get to work on the draft. Mr. Sotelato will take care of rallying the movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[32]`
Mówca: **Manus Sazon**
> ""We are going to work on centralizing the system and abolish the regional structure, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[62]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_Regions_Centralize"] ==  true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_Regions_Centralize"] ==  true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""We are going to keep the federal structure and respect the autonomy of the regions, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will centralize the system completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind after our discussion. Centralization will cost us much needed support. We'll respect the regions to get their vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will respect the current structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind after our discussion. Rizia is too small of a country to require a complicated regional system. I don't want to transition into a weak and inefficient democracy. We'll centralize the structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_CentralizeRegions = true;
RiziaDLC.Situation_Order_AutonomousProvincialPolicing_Some = false;
RiziaDLC.Situation_Order_AutonomousProvincialPolicing_None = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_CentralizeRegions"] = true;
Variable["RiziaDLC.Situation_Order_AutonomousProvincialPolicing_Some"] = false;
Variable["RiziaDLC.Situation_Order_AutonomousProvincialPolicing_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "He took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[43]`
Mówca: **Manus Sazon**
> ""How about the House of Delegates? Are we keeping the legislative unicameral as mentioned before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Judiciary_NoConstitutionalCourt = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_NoConstitutionalCourt = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_NoConstitutionalCourt"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_NoConstitutionalCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will have limited authority over legislation with the power to vote, and reject unconstitutional proposals and return them back to the lower house to be amended. However, the lower house should be able to bypass their veto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseLimited = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseLimited"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will grant them the power of judicial review and to declare laws unconstitutional, so that they can keep the legislative and the executive in check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseEqual = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseEqual"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will give the justices immunity so that they cannot be threatened by powerful interests or the acting executive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Judiciary_LifeTenure = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_LifeTenure = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_LifeTenure"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_LifeTenure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""Your Majesty. I think we've achieved a lot today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no constitutional court and the judiciary will not have any political powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Judiciary_JudicialReview = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_JudicialReview = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_JudicialReview"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_JudicialReview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[60]`
Mówca: **Manus Sazon**
> ""I'll get to work on the draft. And I'll begin rallying the movement as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want a strong judicial branch. We should retain some control over their composition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""How about the legislative? Are we seeking to establish an upper house as mentioned before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's not the best idea. We will keep the House of Delegates as the sole legislative body.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_RegionalSenate = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will establish a Senate comprised of elected senators from each region as an upper house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind. We will establish a Senate comprised of elected senators from each region as an upper house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind after our discussion. We'll respect our regional system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""How about the House of Delegates? Are we keeping the legislative unicameral as mentioned before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[8]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
