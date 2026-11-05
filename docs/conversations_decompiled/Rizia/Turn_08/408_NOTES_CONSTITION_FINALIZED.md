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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""I've changed my mind. We will establish a House of Lords comprised of the nobilit..."** | `[43]` **Manus Sazon**: ""How about the House of Delegate..." | `Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true` | `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = tr...` | `[19]` **Narrator**: "He kept taking notes as I spoke." |
| `[8]` | **""Yes. House of Delegates will be the sole legislative body in the country.""** | `[43]` **Manus Sazon**: ""How about the House of Delegate..."<br>`[77]` **Manus Sazon**: ""How about the House of Delegate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Manus Sazon**: ""I understand."" |
| `[12]` | **""I've changed my mind. We may need to establish an upper house that would provide ..."** | `[43]` **Manus Sazon**: ""How about the House of Delegate..." | `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true) == false` | *Brak zmian stanu* | `[9]` **Manus Sazon**: ""And how would the upper house b..." |
| `[13]` | **""We will establish a House of Lords comprised of the nobility as an upper house to..."** | `[6]` **Manus Sazon**: ""How about the legislative? You ..."<br>`[9]` **Manus Sazon**: ""And how would the upper house b..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = tr...` | `[19]` **Narrator**: "He kept taking notes as I spoke." |
| `[17]` | **""We will establish a Senate comprised of elected senators from each region as an u..."** | `[9]` **Manus Sazon**: ""And how would the upper house b..."<br>`[6]` **Manus Sazon**: ""How about the legislative? You ..." | `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false` | `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = ...` | `[19]` **Narrator**: "He kept taking notes as I spoke." |
| `[18]` | **""Maybe it's not the best idea. We will keep the House of Delegates as the sole leg..."** | `[6]` **Manus Sazon**: ""How about the legislative? You ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Manus Sazon**: ""I understand."" |
| `[21]` | **""They won't have the authority to initiate any legislation. They will only have li..."** | `[19]` **Narrator**: "He kept taking notes as I spoke." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true; V...` | `[20]` **Manus Sazon**: ""I understand."" |
| `[22]` | **""Both houses will vote on legislation and approval of both will be required for en..."** | `[19]` **Narrator**: "He kept taking notes as I spoke." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true; Vari...` | `[20]` **Manus Sazon**: ""I understand."" |
| `[25]` | **""We will grant them life tenure, which would free them from the pressure of protec..."** | `[24]` **Manus Sazon**: ""And the judiciary?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Judiciary_LifeTenure"] = true; ...` | `[27]` **Narrator**: "He took notes." |
| `[37]` | **""Yes. We will centralize the system completely.""** | `[32]` **Manus Sazon**: ""We are going to work on central..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Regions_Centralized"] = true; V...` | `[42]` **Narrator**: "He took notes." |
| `[38]` | **""I've changed my mind after our discussion. Centralization will cost us much neede..."** | `[32]` **Manus Sazon**: ""We are going to work on central..." | `Variable["RiziaDLC.Reform_Diplomatic"] == true` | *Brak zmian stanu* | `[42]` **Narrator**: "He took notes." |
| `[39]` | **""Yes. We will respect the current structure.""** | `[36]` **Manus Sazon**: ""We are going to keep the federa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Narrator**: "He took notes." |
| `[40]` | **""I've changed my mind after our discussion. Rizia is too small of a country to req..."** | `[36]` **Manus Sazon**: ""We are going to keep the federa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Regions_Centralized"] = true; V...` | `[42]` **Narrator**: "He took notes." |
| `[51]` | **""They will have limited authority over legislation with the power to vote, and rej..."** | `[19]` **Narrator**: "He kept taking notes as I spoke." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true; Va...` | `[20]` **Manus Sazon**: ""I understand."" |
| `[53]` | **""We will grant them the power of judicial review and to declare laws unconstitutio..."** | `[24]` **Manus Sazon**: ""And the judiciary?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Judiciary_JudicialReview"] = tr...` | `[27]` **Narrator**: "He took notes." |
| `[55]` | **""We will give the justices immunity so that they cannot be threatened by powerful ..."** | `[24]` **Manus Sazon**: ""And the judiciary?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Judiciary_Immunity"] = true; Va...` | `[27]` **Narrator**: "He took notes." |
| `[58]` | **""There will be no constitutional court and the judiciary will not have any politic..."** | `[24]` **Manus Sazon**: ""And the judiciary?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Judiciary_NoConstitutionalCourt...` | `[27]` **Narrator**: "He took notes." |
| `[61]` | **""I don't want a strong judicial branch. We should retain some control over their c..."** | `[24]` **Manus Sazon**: ""And the judiciary?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "He took notes." |
| `[69]` | **""Maybe it's not the best idea. We will keep the House of Delegates as the sole leg..."** | `[68]` **Manus Sazon**: ""How about the legislative? Are ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[20]` **Manus Sazon**: ""I understand."" |
| `[71]` | **""Yes. We will establish a Senate comprised of elected senators from each region as..."** | `[68]` **Manus Sazon**: ""How about the legislative? Are ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = ...` | `[19]` **Narrator**: "He kept taking notes as I spoke." |
| `[72]` | **""I've changed my mind. We will establish a Senate comprised of elected senators fr..."** | `[77]` **Manus Sazon**: ""How about the House of Delegate..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = ...` | `[19]` **Narrator**: "He kept taking notes as I spoke." |
| `[73]` | **""I've changed my mind after our discussion. We'll respect our regional system.""** | `[32]` **Manus Sazon**: ""We are going to work on central..." | `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false` | *Brak zmian stanu* | `[42]` **Narrator**: "He took notes." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Manus Sazon: ""I'll get to work on the draft. Mr. Sotelato will take ca..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Manus Sazon: ""I'll get to work on the draft. And I'll begin rallying t..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""How about the legislative? You mentioned establishing an upper house. How would that be structured?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""Maybe it's not the best idea. We will keep the House of ..."*)
  - -> `[13]` (*Player_Romus: ""We will establish a House of Lords comprised of the nobi..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind. We will establish a House of Lords comprised of the nobility as an upper house to get the nobility's backing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Kontekst wejściowy (poprzednik):** `[43]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords = true; RiziaDLC..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. House of Delegates will be the sole legislative body in the country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Manus Sazon), `[77]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""And how would the upper house be structured?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""We will establish a House of Lords comprised of the nobi..."*)
  - -> `[17]` (*Player_Romus: ""We will establish a Senate comprised of elected senators..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_HouseOfLords = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_HouseOfLords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He kept taking notes as I spoke."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_RegionalSenate = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He kept taking notes as I spoke."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind. We may need to establish an upper house that would provide checks and balances on the legislative branch.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[43]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Manus Sazon: ""And how would the upper house be structured?""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will establish a House of Lords comprised of the nobility as an upper house to get the nobility's backing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Manus Sazon), `[9]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords = true; RiziaDLC..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""We will establish a Senate comprised of elected senators..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will establish a Senate comprised of elected senators from each region as an upper house.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Manus Sazon), `[6]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_RegionalSenate = true; RiziaD..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's not the best idea. We will keep the House of Delegates as the sole legislative body.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "He kept taking notes as I spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""They won't have the authority to initiate any legislatio..."*)
  - -> `[22]` (*Player_Romus: ""Both houses will vote on legislation and approval of bot..."*)
  - -> `[51]` (*Player_Romus: ""They will have limited authority over legislation with t..."*)

### Węzeł `[20]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Manus Sazon: ""And the judiciary?""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They won't have the authority to initiate any legislation. They will only have limited legislative powers, such as voting on constitutional amendments and advising the lower house.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory = true; RiziaDLCSuppo..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both houses will vote on legislation and approval of both will be required for enacting new laws. We will exercise equal bicameralism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal = true; RiziaDLCSupport...."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseAdvisorary = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseAdvisorary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""And the judiciary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""There will be no constitutional court and the judiciary ..."*)
  - -> `[55]` (*Player_Romus: ""We will give the justices immunity so that they cannot b..."*)
  - -> `[25]` (*Player_Romus: ""We will grant them life tenure, which would free them fr..."*)
  - -> `[53]` (*Player_Romus: ""We will grant them the power of judicial review and to d..."*)
  - -> `[61]` (*Player_Romus: ""I don't want a strong judicial branch. We should retain ..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will grant them life tenure, which would free them from the pressure of protecting powerful interests or deciding according to momentary populism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Judiciary_LifeTenure = true; RiziaDLCSupp..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Judiciary_Immunity = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_JudiciaryImmunity = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_Immunity"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_JudiciaryImmunity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He took notes."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "He took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Manus Sazon: ""Your Majesty. I think we've achieved a lot today.""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Manus Sazon**
> ""I'll get to work on the draft. Mr. Sotelato will take care of rallying the movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[32]`
Mówca: **Manus Sazon**
> ""We are going to work on centralizing the system and abolish the regional structure, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""Yes. We will centralize the system completely.""*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  ..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_Regions_Centralize"] ==  true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Manus Sazon: ""We are going to work on centralizing the system and abol..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Intention_Regions_Centralize ==  true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_Regions_Centralize"] ==  true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Manus Sazon: ""We are going to keep the federal structure and respect t..."*)

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""We are going to keep the federal structure and respect the autonomy of the regions, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Yes. We will respect the current structure.""*)
  - -> `[40]` (*Player_Romus: ""I've changed my mind after our discussion. Rizia is too ..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will centralize the system completely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized = true; RiziaDLCSuppo..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind after our discussion. Centralization will cost us much needed support. We'll respect the regions to get their vote.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He took notes."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will respect the current structure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He took notes."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind after our discussion. Rizia is too small of a country to require a complicated regional system. I don't want to transition into a weak and inefficient democracy. We'll centralize the structure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized = true; RiziaDLCSuppo..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_CentralizeRegions = true;
RiziaDLC.Situation_Order_AutonomousProvincialPolicing_Some = false;
RiziaDLC.Situation_Order_AutonomousProvincialPolicing_None = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_CentralizeRegions"] = true;
Variable["RiziaDLC.Situation_Order_AutonomousProvincialPolicing_Some"] = false;
Variable["RiziaDLC.Situation_Order_AutonomousProvincialPolicing_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He took notes."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "He took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[43]`
Mówca: **Manus Sazon**
> ""How about the House of Delegates? Are we keeping the legislative unicameral as mentioned before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Yes. House of Delegates will be the sole legislative bod..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.R..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Intention_Legislative_Unicamera..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Manus Sazon: ""How about the House of Delegates? Are we keeping the leg..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""How about the legislative? You mentioned establishing an..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.R..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""I've changed my mind. We will establish a House of Lords..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true && RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""I've changed my mind. We may need to establish an upper ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Judiciary_NoConstitutionalCourt = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_NoConstitutionalCourt = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_NoConstitutionalCourt"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_NoConstitutionalCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He took notes."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will have limited authority over legislation with the power to vote, and reject unconstitutional proposals and return them back to the lower house to be amended. However, the lower house should be able to bypass their veto.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited = true; RiziaDLCSuppor..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseLimited = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseLimited"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will grant them the power of judicial review and to declare laws unconstitutional, so that they can keep the legislative and the executive in check.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Judiciary_JudicialReview = true; RiziaDLC..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseEqual = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_UpperHouseEqual"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will give the justices immunity so that they cannot be threatened by powerful interests or the acting executive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Judiciary_Immunity = true; RiziaDLCSuppor..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Judiciary_LifeTenure = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_LifeTenure = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_LifeTenure"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_LifeTenure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He took notes."*)

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""Your Majesty. I think we've achieved a lot today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no constitutional court and the judiciary will not have any political powers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Judiciary_NoConstitutionalCourt = true; R..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Judiciary_JudicialReview = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_JudicialReview = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Judiciary_JudicialReview"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_JudicialReview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He took notes."*)

### Węzeł `[60]`
Mówca: **Manus Sazon**
> ""I'll get to work on the draft. And I'll begin rallying the movement as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want a strong judicial branch. We should retain some control over their composition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He took notes."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""I've changed my mind after our discussion. Centralizatio..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""I've changed my mind after our discussion. We'll respect..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Intention_Legislative_Unicamera..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Manus Sazon: ""How about the House of Delegates? Are we keeping the leg..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Manus Sazon: ""How about the legislative? Are we seeking to establish a..."*)

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""How about the legislative? Are we seeking to establish an upper house as mentioned before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""Maybe it's not the best idea. We will keep the House of ..."*)
  - -> `[71]` (*Player_Romus: ""Yes. We will establish a Senate comprised of elected sen..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's not the best idea. We will keep the House of Delegates as the sole legislative body.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_RegionalSenate = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_RegionSenate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He kept taking notes as I spoke."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will establish a Senate comprised of elected senators from each region as an upper house.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_RegionalSenate = true; RiziaD..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind. We will establish a Senate comprised of elected senators from each region as an upper house.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_RegionalSenate = true; RiziaD..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've changed my mind after our discussion. We'll respect our regional system.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[32]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He took notes."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""How about the House of Delegates? Are we keeping the legislative unicameral as mentioned before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""I've changed my mind. We will establish a Senate compris..."*)
  - -> `[8]` (*Player_Romus: ""Yes. House of Delegates will be the sole legislative bod..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""I understand.""*)
