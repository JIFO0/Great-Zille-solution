# Rizia/Turn 10/BDAY FALLOUT

- **ID konwersacji:** `343`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/343_BDAY_FALLOUT.md`
- **Liczba węzłów dialogowych:** 230
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[80]** Elena Werner
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.CountryRelation_Morella_Allied`
- `RiziaDLC.CountryRelation_Wehlen_Allied`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_Appease`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.Pales_Rizia_PreparationsUnification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PipelineNatDes_PipelineDontRepair`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Revolutionary_Pipeline_Sabotage`
- `RiziaDLC.Rusty_LoanAmount`
- `RiziaDLC.Situation_Economy_NewBusiness_Collapse`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Welfare_State_Strong`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Unrest_NatDes_Happened`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Resources_Budget`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[524]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 4

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[216]` (Paskal Beniwoll): `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- Węzeł `[226]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 5;`
- Węzeł `[227]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 3;`
- Węzeł `[228]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `338` (*Rizia/Turn 10/CouncilMeeting*), Węzeł `[524]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I sat at the long table in my council chambers, facing Elena and Laurento."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""I hope you are well today, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Laurento Esquibel**
> ""Indeed... We seem to be having a cold spell of late. But I am certain spring is just around the corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "They both spoke in somewhat unnatural tones. I saw flashes of fear in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, you two... it's just me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the events of my mother's birthday seemed rather extreme. But trust me, it had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is something wrong, councilors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Correct, Mr. Esquibel. The daffodils in the Palace gardens have already begun to bloom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
Mówca: **Elena Werner**
> ""N-no, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Laurento Esquibel**
> ""Not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Laurento Esquibel**
> ""I do not doubt it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[14]`
Mówca: **Laurento Esquibel**
> ""Oh, I wasn't aware I was acting out of the ordinary. Please accept my apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""How lovely...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone == true || RiziaDLC.Council_GrandVizier_Empty == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone == true || RiziaDLC.Council_GrandVizier_Empty == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Empty"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone == true || RiziaDLC.Council_GrandVizier_Empty == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Empty"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[19]`
Mówca: **Narrator**
> "They glanced at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[20]`
Mówca: **Elena Werner**
> ""Such actions are sometimes necessary for the health of the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[21]`
Mówca: **Elena Werner**
> ""And mine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[22]`
Mówca: **Laurento Esquibel**
> ""With the... departure of our Grand Vizier and Duchess Azaro, there are now two spots on the council that need filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""With the... departure of our Grand Vizier and General Azaro, there are now two spots on the council that need filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Elena Werner**
> ""Fortunately, we're quite close to the Hearing of Petitions. I'm sure you'll be able to find suitable candidates to fill both seats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember that your own seat on this council is by no means guaranteed. Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite their treachery, they were competent advisors. They leave big shoes to fill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It makes no difference in the end. *I* am the one making the decisions. You people are nothing but leeches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are still a few months to go. I trust you to help me run the country in the meantime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Elena Werner**
> ""We'll do our best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""Yes, we're... aware of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[34]`
Mówca: **Elena Werner**
> ""Yes, I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[35]`
Mówca: **Elena Werner**
> ""I have never once taken it for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[36]`
Mówca: **Laurento Esquibel**
> ""Both Azaro generals are committed to seeing it through, despite the fate of their House and Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Laurento checked his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of all three provinces to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of Valenqiris and Cardesse-Montaklar to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of Cardesse-Montaklar to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[53]`
Mówca: **Laurento Esquibel**
> ""The Crown Princess continues to reside in Palas Toras in Monqiz. All other members of the noble houses in question have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[60]`
Mówca: **Laurento Esquibel**
> ""It appears the transfer of Cardesse-Montaklar and Brenas to Crown control is well underway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""All members of the noble houses in question have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""All Azaros have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Laurento Esquibel**
> ""All members of the noble houses in question, including your cousin Hubertus, have been vacated from their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Elena Werner**
> ""They shall live as commoners, with no special privileges or entitlements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "She allowed herself a small, grim smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Elena Werner**
> ""Naturally, the seizure of their estates will bring a substantial boost to our treasury. Some of their assets, however, were held offshore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[80]`
  - -> `[81]`
  - -> `[83]`
  - -> `[86]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Laurento Esquibel**
> ""With the... departure of your uncle from the council, the Grand Vizier seat will need filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Elena Werner**
> ""Fortunately, we're quite close to the Hearing of Petitions. I'm sure you'll be able to find a suitable candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[30]`
  - -> `[31]`
  - -> `[72]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My uncle was a competent advisor. He leaves big shoes to fill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[73]`
Mówca: **Laurento Esquibel**
> ""With the... departure of our security councilor, there is a seat at this table that needs filling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Elena Werner**
> ""Fortunately, we're quite close to the Hearing of Petitions. I'm sure you'll be able to find a suitable candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[30]`
  - -> `[31]`
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita was a competent advisor. She leaves big shoes to fill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus was a competent advisor. He leaves big shoes to fill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was not the reason behind my actions. But I admit it's a nice bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. I have big plans for that funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That money should go straight into the hands of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_State_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_State_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_State_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_State_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_State_Strong"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that so? I should have done this a long time ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""With regards to the ongoing war in Pales...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[88]`
Mówca: **Laurento Esquibel**
> ""General Carlos Robles Azaro is committed to seeing it through, despite the fate of his relatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[92]`
Mówca: **Laurento Esquibel**
> ""With luck, they should finally be able to bring the Princess home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[93]`
Mówca: **Laurento Esquibel**
> ""With regard to the ongoing Pales reunification talks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_PreparationsUnification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_PreparationsUnification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_PreparationsUnification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_PreparationsUnification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_PreparationsUnification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[97]`
Mówca: **Laurento Esquibel**
> ""Duke Reinhart has shown a willingness to continue the process. But he does warn that your 'lack of respect for Rizia's provincial autonomy' has given him pause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Laurento Esquibel**
> ""His words, not mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Laurento Esquibel**
> ""Her Excellency Queen Beatrice, meanwhile, has sent us a telegram praising your show of dominance over Rizia's wayward nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[113]`
  - -> `[114]`
  - -> `[116]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Laurento Esquibel**
> ""President Wiktor Smolak, meanwhile, has sent us a telegram praising your show of dominance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[113]`
  - -> `[114]`
  - -> `[116]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Wehlen_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Wehlen_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Wehlen_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Wehlen_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Morella_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Morella_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Morella_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Laurento Esquibel**
> ""Prime Minister Saltana of Morella has notified us that while she is not against the expropriation of noble estates in principle, she does question the method by which we have done so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[113]`
  - -> `[116]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Splendid. Anything else I should know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[112]`
Mówca: **Laurento Esquibel**
> ""Fortunately, international blowback over the... incident... has been minimal. Especially since few specifics have been leaked to the world at large.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[113]`
  - -> `[114]`
  - -> `[116]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be in charge of a nation sometimes requires one to make bold decisions. Our trade partners know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world must know that the King of Rizia is not to be messed with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Elena Werner**
> ""One other thing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want anyone to get the wrong idea. This was a defensive measure, not some sort of power grab.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Laurento Esquibel**
> ""I will try to communicate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""Most certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Unrest_NatDes_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Elena Werner**
> ""This doesn't fall under either of our purview, but with the security councilor indisposed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Elena Werner**
> ""It's our proud duty to tell you that the unrest that has plagued Rizia for so long has come to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[181]`
  - -> `[179]`
  - -> `[177]`

### Węzeł `[127]`
Mówca: **Elena Werner**
> ""You'll hear more about this from your security councilor, but for now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[128]`
Mówca: **Elena Werner**
> ""That will be it for now. I'm sure you have a lot of work to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[132]`
Mówca: **Elena Werner**
> ""The concessions we were forced to make to the protesters did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Appease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Appease == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Appease == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Elena Werner**
> ""Miraculously, the concessions we were forced to make to the protesters barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Elena Werner**
> ""The upheaval we experienced did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Elena Werner**
> ""Miraculously, the upheaval we experienced barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Revolutionary_Pipeline_Sabotage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Revolutionary_Pipeline_Sabotage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Revolutionary_Pipeline_Sabotage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[142]`
Mówca: **Elena Werner**
> ""Our energy reserves are still recovering from the sabotage incident. It may take some time before we're at our former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_PipelineDontRepair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_PipelineDontRepair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_PipelineDontRepair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Elena Werner**
> ""Thanks to your quick actions after the sabotage incident, our energy reserves are on track to reach their former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[150]`
Mówca: **Elena Werner**
> ""And we remain in debt to Rizian Royal Gold. I hope it isn't too late for that to be squared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[160]`
  - -> `[166]`
  - -> `[167]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanAmount > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[166]`
  - -> `[167]`

### Węzeł `[154]`
Mówca: **Elena Werner**
> ""Our robust energy reserves will undoubtedly help us weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Elena Werner**
> ""Thankfully, we have adequate energy reserves to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[159]`
Mówca: **Elena Werner**
> ""I am concerned that our energy reserves are insufficient to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Concerning news. But at least we're now in the position to begin working on our recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the anti-monarchists out of the way, our economy will soar even higher than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We handled the unrest. We can handle Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still much work to be done. We've got to address the root cause of the uprising, not just recover from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should take some time to rest on our laurels. We defeated a revolution, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Laurento Esquibel**
> ""Indeed. No easy feat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[169]`
Mówca: **Laurento Esquibel**
> ""I have no doubt it will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[170]`
Mówca: **Laurento Esquibel**
> ""Very prudent thinking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[171]`
Mówca: **Laurento Esquibel**
> ""And work we will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[172]`
Mówca: **Laurento Esquibel**
> ""I am sure we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God be praised!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want, a medal? That's literally the least that I expect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Elena Werner**
> ""No medal necessary. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you quite sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One less thing to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[185]`
Mówca: **Elena Werner**
> ""The ringleader -- Adarfo, was it? -- now sits in the Porte Drazon Citadel, awaiting your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Adarfo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Adarfo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false  and  Variable["RiziaDLC.Adarfo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Adarfo_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false  and  Variable["RiziaDLC.Adarfo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Elena Werner**
> ""The ringleaders have all been arrested, and the movement has scattered to the winds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[190]`
Mówca: **Elena Werner**
> ""Your decision not to resort to harsh measures has apparently paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Ms. Werner. And I'm sorry again about all the recent unpleasantness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, lots of work to be done. No thanks to my shrunken council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[194]`
Mówca: **Narrator**
> "They both paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[199]`
  - -> `[198]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Narrator**
> "She and Laurento stood up and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[197]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let recent events be a lesson to you. Nobody goes against Romus Toras and lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good day to you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You both served my father for years. Would he have been proud of what I did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I lost my wife. My heir. I have no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I lost my uncle. My closest advisor. I have no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing. You're both dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[208]`
Mówca: **Narrator**
> "They both looked uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Laurento Esquibel**
> ""I am sorry, Your Majesty. This cannot be easy for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[210]`
Mówca: **Narrator**
> "They both looked uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Laurento Esquibel**
> ""He would have understood, Your Majesty. Reigning is not easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Their faces both paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Laurento Esquibel**
> ""Understood, Your Majesty. We would never dream of doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Elena Werner**
> ""It was for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Narrator**
> "I kept my eyes on my oldest and most loyal councilors as they departed my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget += 5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget += 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget += 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, something is better than nothing. We’ll take what we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
