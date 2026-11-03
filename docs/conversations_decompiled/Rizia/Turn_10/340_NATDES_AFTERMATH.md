# Rizia/Turn 10/NATDES AFTERMATH

- **ID konwersacji:** `340`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/340_NATDES_AFTERMATH.md`
- **Liczba węzłów dialogowych:** 337
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_Appease`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.NatDes_UniteHousesAgainst_Azaro`
- `RiziaDLC.NatDes_UniteHousesAgainst_Sazon`
- `RiziaDLC.NatDes_UniteHousesAgainst_Toras`
- `RiziaDLC.Pales_PromisedToHouseAzaro`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PipelineNatDes_DeploySO`
- `RiziaDLC.PipelineNatDes_DeployWG`
- `RiziaDLC.PipelineNatDes_PipelineDontRepair`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Diplomacy_Intermerkopum`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Revolutionary_Pipeline_Sabotage`
- `RiziaDLC.Rusty_LoanAmount`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Economy_NewBusiness_Collapse`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Turn10_CouncilGoodbyes_NoPromiseToAbdicate`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[120]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[8]` (Paskal Beniwoll): `AddConversant("Sal Ignacius");`
- Węzeł `[141]` (Paskal Beniwoll): `--;`
- Węzeł `[143]` (Paskal Beniwoll): `Variable["RiziaDLC.Adarfo_Arrested"] = true; EnableCodexEntry("Characters_PartyLeaders_AdarfoSote...`
- Węzeł `[298]` (Paskal Beniwoll): `--;`
- Węzeł `[325]` (Paskal Beniwoll): `Variable["RiziaDLC.PromiseToAbdicate"] = false; Variable["RiziaDLC.Turn10_CouncilGoodbyes_NoPromi...`

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `338` (*Rizia/Turn 10/CouncilMeeting*), Węzeł `[120]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I looked around at my advisors. Like me, they hadn't been getting much sleep lately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Sal Ignacius rushed into the room just as the clock struck four, bowing profusely in apology."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Vina followed him in and wordlessly took her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Lucita had a proud smile on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Taddeus wore a proud expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Titus wore a proud smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Lucita Azaro**
> ""I'm pleased to report that the unrest that has plagued our kingdom for so long is finally coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[24]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Taddeus Azaro**
> ""I'm pleased to report that the unrest that has plagued our kingdom for so long is finally coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[26]`
Mówca: **Titus Gordion**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Titus Gordion**
> ""I'm pleased to report that the unrest that has plagued our kingdom for so long is finally coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God be praised!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you quite sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want a full report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want, a medal? This is literally the least I expect from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing news, Councilor. The nightmare is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "My councilor nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Narrator**
> "My councilor handed me a copy of a dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Narrator**
> "My councilor frowned apologetically and handed me a copy of a dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[54]`
Mówca: **Lucita Azaro**
> ""With the cooperation of all three noble houses, we managed to hold back the tide of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""My cousin Carlos marshalled Azaro troops to drive the rioters out of Cardesse-Montaklar's cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Hubertus convinced the nobles of Valenqiris to lend their private armies to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""And I'd be remiss not to mention the bravery of my fellow noblewoman Angelica Sazon, who spurred her loyalists in Brenas into immediate action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[58]`
Mówca: **Taddeus Azaro**
> ""With the cooperation of all three noble houses, we managed to hold back the tide of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Taddeus Azaro**
> ""General Carlos marshalled Azaro troops to drive the rioters out of Cardesse-Montaklar's cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Taddeus Azaro**
> ""Hubertus convinced the nobles of Valenqiris to lend their private armies to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Taddeus Azaro**
> ""And I'd be remiss not to mention the bravery of Angelica Sazon, who spurred her loyalists in Brenas into immediate action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[62]`
Mówca: **Titus Gordion**
> ""With the cooperation of all three noble houses, we managed to hold back the tide of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Titus Gordion**
> ""General Carlos Azaro marshalled Azaro troops to drive the rioters out of Cardesse-Montaklar's cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Titus Gordion**
> ""Your cousin Hubertus convinced the nobles of Valenqiris to lend their private armies to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Titus Gordion**
> ""And I'd be remiss not to mention the bravery of Angelica Sazon, who spurred her loyalists in Brenas into immediate action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sacrifices were made. But it was all worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now we can focus our attention where it belongs. On defeating Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit, I didn't think House Sazon had it in them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in 1926, we must now turn our attention to restoring our citizens' trust in us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Yes, you'll receive an update on that front very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""Indeed it was, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[81]`
Mówca: **Elena Werner**
> ""Sacrifices indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Narrator**
> "I thought I saw disgust flash across my daughter's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[86]`
Mówca: **Laurento Esquibel**
> ""No. Nor did I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Elena Werner**
> ""We are already on our way to doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[91]`
Mówca: **Elena Werner**
> ""Yes, we can expect a rocky few months at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This must never be allowed to happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""As for Adarfo Sotelato, he has been apprehended and now sits in the Porte Drazon Citadel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[97]`
Mówca: **Taddeus Azaro**
> ""As for Adarfo Sotelato, he has been apprehended and now sits in the Porte Drazon Citadel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Titus Gordion**
> ""As for Adarfo Sotelato, he has been apprehended and now sits in the Porte Drazon citadel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[102]`
Mówca: **Lucita Azaro**
> ""Our crackdown on the protests was a total success. The movement is fractured, and has shown no sign of resurgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeploySO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeploySO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeploySO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Lucita Azaro**
> ""Su Omina was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""Wruhec's Guardians were especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeployWG == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""The Golden Guard was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Titus gave a salute from the doorway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Hugo smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[114]`
Mówca: **Taddeus Azaro**
> ""Our crackdown on the protests was a total success. The movement is fractured, and has shown no sign of resurgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeploySO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeploySO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeploySO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
Mówca: **Taddeus Azaro**
> ""Su Omina was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[119]`
Mówca: **Taddeus Azaro**
> ""The Golden Guard was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[120]`
Mówca: **Taddeus Azaro**
> ""Wruhec's Guardians were especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeployWG == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Titus gave a salute from the doorway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Hugo smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""I admit I was skeptical that the movement could be calmed without the need for harsh measures. But that seems to be exactly what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[127]`
Mówca: **Taddeus Azaro**
> ""I admit I was skeptical that the movement could be calmed without the need for harsh measures. But that seems to be exactly what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[128]`
Mówca: **Titus Gordion**
> ""Our crackdown on the protests was a total success. The movement is fractured, and has shown no sign of resurgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeploySO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeploySO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeploySO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Titus Gordion**
> ""Su Omina was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Titus Gordion**
> ""The Golden Guard was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""Wruhec's Guardians were especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeployWG == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[138]`
Mówca: **Narrator**
> "He smiled broadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Hugo smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[140]`
Mówca: **Titus Gordion**
> ""I admit I was skeptical that the movement could be calmed without the need for harsh measures. But that seems to be exactly what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[68]`
  - -> `[66]`
  - -> `[72]`
  - -> `[75]`

### Węzeł `[142]`
Mówca: **Elena Werner**
> ""Agreed. It was difficult enough for us to bounce back the first time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested = true;
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Arrested");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""We have rounded up as many of the movement ringleaders as we could and plan on making an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[145]`
Mówca: **Taddeus Azaro**
> ""We have rounded up as many of the movement ringleaders as we could and plan on making an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[146]`
Mówca: **Titus Gordion**
> ""We have rounded up as many of the ringleaders as we could and plan on making an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Elena Werner**
> ""The concessions we were forced to make to the protesters did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Appease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Appease == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Appease == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""Miraculously, the concessions we were forced to make to the protesters barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Elena Werner**
> ""The upheaval we experienced did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Elena Werner**
> ""Miraculously, the upheaval we experienced barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Revolutionary_Pipeline_Sabotage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Revolutionary_Pipeline_Sabotage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Revolutionary_Pipeline_Sabotage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[172]`
Mówca: **Elena Werner**
> ""Our energy reserves are still recovering from the sabotage incident. It may take some time before we're at our former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_PipelineDontRepair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_PipelineDontRepair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_PipelineDontRepair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Elena Werner**
> ""Thanks to your quick actions after the sabotage incident, our energy reserves are on track to reach their former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[180]`
Mówca: **Elena Werner**
> ""And we remain in debt to Rizian Royal Gold. I hope it isn't too late for that to be squared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[190]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanAmount > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[184]`
Mówca: **Elena Werner**
> ""Our robust energy reserves will undoubtedly help us weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Elena Werner**
> ""Thankfully, we have adequate energy reserves to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[189]`
Mówca: **Elena Werner**
> ""I am concerned that our energy reserves are insufficient to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Concerning news. But at least we're now in the position to begin working on our recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the anti-monarchists out of the way, our economy will soar even higher than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We handled the unrest. We can handle Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still much work to be done. We've got to address the root cause of the uprising, not just recover from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should take some time to rest on our laurels. We defeated a revolution, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Laurento Esquibel**
> ""Indeed. No easy feat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
Mówca: **Laurento Esquibel**
> ""Very prudent thinking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Laurento Esquibel**
> ""I have no doubt it will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[201]`
Mówca: **Laurento Esquibel**
> ""And work we will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Laurento Esquibel**
> ""I am sure we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Narrator**
> "He scribbled something on a notepad in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Laurento Esquibel**
> ""I will get word to our partners in GRACE that the threat of destabilization is over. I know they were beginning to worry about our trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Intermerkopum == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Laurento Esquibel**
> ""I will get word to our partners in Intermerkopum that the threat of destabilization is over. I know they were beginning to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Laurento Esquibel**
> ""I will get word to our trading partners that the threat of destabilization is over. I know they were beginning to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Laurento Esquibel**
> ""And I will speak with the Duke and Duchess of Pales about resuming our reunification efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[220]`
Mówca: **Sal Ignacius**
> ""Our nation remains greatly divided. Only the power of faith will heal it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[223]`
  - -> `[228]`
  - -> `[231]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice try, but no. Faith still divides Rizia more than it unifies us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wruhec's Guardians will be integral to our recovery efforts. I want them to focus on outreach to our disaffected citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The power of faith is second to the power of the Crown, Sal. Remember that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Narrator**
> "I looked at my daughter. She still hadn't said a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`
  - -> `[248]`
  - -> `[251]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`
  - -> `[244]`

### Węzeł `[239]`
Mówca: **Hugo Toras**
> ""Thank you all for joining us today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Hugo Toras**
> ""And for your loyalty and hard work during these recent trying times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Hugo Toras**
> ""Now. I will let our Councilor of War and Security share the good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shall we begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. What is this meeting about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you all for joining me here today. I hope you've brought good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina... I know mistakes were made. But I'll do better from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cat got your tongue, Your Highness?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does your husband have to say for himself? He's the reason all this happened, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If no one else has anything to say, we'll conclude the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Appease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Appease == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Appease == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[255]`
Mówca: **Vina Toras**
> ""I'm pleased that the Crown and the protesters could find a compromise, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Vina Toras**
> ""But if you'd only been willing to work with Manus, none of this would have happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[261]`
  - -> `[262]`
  - -> `[268]`

### Węzeł `[257]`
Mówca: **Vina Toras**
> ""So much senseless bloodshed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Vina Toras**
> ""If you'd only been willing to work with Manus, none of this would have happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[261]`
  - -> `[262]`
  - -> `[268]`

### Węzeł `[259]`
Mówca: **Narrator**
> "She sighed and shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[260]`
Mówca: **Vina Toras**
> ""What? Father, that's not true at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't know that. Who's to say the people would have accepted his watered-down reform attempts?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe. But we must look to the future now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that Adarfo's out of the picture, I can see myself collaborating with the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might still cooperate with the RPP in the future. Who knows?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your sweetheart's no saint. He was stirring up trouble from day one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Vina didn't respond. She gave a tight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[273]`
Mówca: **Narrator**
> "Vina didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[274]`
Mówca: **Vina Toras**
> ""But you never even tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[275]`
Mówca: **Vina Toras**
> ""Well... good. That's a start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
Mówca: **Elena Werner**
> ""I'm sure we're all eager to put this nightmare behind us and get back to our jobs. I suggest we adjourn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Hugo cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[278]`
Mówca: **Narrator**
> "Elena cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Elena nodded sagely.."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Elena Werner**
> ""Yes, I'm sure we're all eager to put this nightmare behind us and get back to our jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[284]`
Mówca: **Hugo Toras**
> ""We've all got work to do. I suggest we adjourn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Narrator**
> "Lucita came over to stand by my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Pales_PromisedToHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Pales_PromisedToHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true  or  Variable["RiziaDLC.Pales_PromisedToHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Pales_PromisedToHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true  or  Variable["RiziaDLC.Pales_PromisedToHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Her eyes were gleaming as she took my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[294]`
Mówca: **Narrator**
> "She took my hand and turned to face the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Long live the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[296]`
  - -> `[295]`
  - -> `[297]`
  - -> `[305]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God be with you all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Narrator**
> "One by one, my councilors bowed before me and departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too cocky. We've still got a war to win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  and  Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  and  Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[311]`
Mówca: **Narrator**
> "Only Hugo was left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Hugo Toras**
> ""I have not forgotten your promise, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""I trust it will not take too long to get your affairs in order. Six months, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[316]`
  - -> `[320]`
  - -> `[321]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have not forgotten, either. When the time comes, I will inform the nation that my reign is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must see the war to an end. After that, I will fulfill my promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Possibly even sooner. I don't have much to wrap up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you that hungry to take my place? Don't forget I have a daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My 'promise' counts for nothing. You should never have tried to demand my abdication in exchange for my own family's loyalty. I am going nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Shock and pain mixed in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Hugo Toras**
> ""Then good day to you, my nephew. And all the best to your... companion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate = false;
RiziaDLC.Turn10_CouncilGoodbyes_NoPromiseToAbdicate = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PromiseToAbdicate"] = false;
Variable["RiziaDLC.Turn10_CouncilGoodbyes_NoPromiseToAbdicate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "He turned and walked out without saying another word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[327]`
Mówca: **Hugo Toras**
> ""I did not mean to insinuate that your successor should be me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Hugo Toras**
> ""Though with Vina's whereabouts unknown... well. It is your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Hugo Toras**
> ""I wish you a good day, my nephew. And all the best to your... companion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[333]`
Mówca: **Hugo Toras**
> ""Even better, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[334]`
Mówca: **Hugo Toras**
> ""I understand. I would not ask you to abandon our chances at recapturing Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[335]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[336]`
Mówca: **Narrator**
> "He bowed respectfully and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
