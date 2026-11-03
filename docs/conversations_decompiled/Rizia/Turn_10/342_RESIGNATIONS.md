# Rizia/Turn 10/RESIGNATIONS

- **ID konwersacji:** `342`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/342_RESIGNATIONS.md`
- **Liczba węzłów dialogowych:** 310
- **Liczba wyborów gracza:** 22

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Unrest_NatDes_Happened`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Arrested`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[524]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[38]` (Paskal Beniwoll): `--;`
- Węzeł `[140]` (Paskal Beniwoll): `--;`
- Węzeł `[252]` (Paskal Beniwoll): `--;`
- Węzeł `[307]` (Paskal Beniwoll): `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- Węzeł `[308]` (Paskal Beniwoll): `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- Węzeł `[309]` (Paskal Beniwoll): `Variable["RiziaDLC.Adarfo_Arrested"] = true;`

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
> "I sat at the head of the long table in my council chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Hugo and my security councilor sat across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[11]`
Mówca: **Narrator**
> "My security councilor sat across from me, looking despondent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Hugo sat across from me, a hollow look in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Your Majesty... it is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""All members of House Toras have relinquished their titles and estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""With the exception of the Crown Princess, who shall remain in Monqiz but will no longer reign over the province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Valenqiris is entirely yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this has taught you all a valuable lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Lucita nodded despondently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Taddeus nodded despondently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""The same goes for my home province, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""As is my home province, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""The Azaros have ceded control of Cardesse-Montaklar. Our lands are officially the property of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[32]`
Mówca: **Taddeus Azaro**
> ""The Azaros have ceded control of Cardesse-Montaklar. Our lands are officially the property of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Lucita Azaro**
> ""It is done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[37]`
Mówca: **Taddeus Azaro**
> ""It is done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[40]`
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your province's armed forces answer directly to me now as well. Don't forget that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry. I truly didn't mean for all this to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Power corrupts. You will thank me for this in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So what are you still doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""I have come to hand in my official resignation. I can no longer serve as your Grand Vizier after my family's disgrace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""Our cousin Hubertus no longer reigns over the province. He's scraped together what funds he can and intends to continue his world travels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[51]`
Mówca: **Narrator**
> "My uncle had a hollow look in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[52]`
Mówca: **Lucita Azaro**
> ""From this point on, we will live as commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[53]`
Mówca: **Taddeus Azaro**
> ""We are to live as commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[60]`
Mówca: **Lucita Azaro**
> ""I hate to entrust anyone else with our kingdom's national security. But you'll understand why I cannot remain on the Royal Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""And every moment I spend in Porte Drazon is a crushing reminder of my son's fate...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""And every moment I spend in Porte Drazon is a crushing reminder of the shame I endured...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""Without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Lucita Azaro**
> ""Yes. It has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[74]`
Mówca: **Taddeus Azaro**
> ""Indeed. Neither I nor any other Azaro will ever challenge your power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""They are yours to command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Lucita Azaro**
> ""Their allegiance is strictly to the Crown now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[86]`
Mówca: **Taddeus Azaro**
> ""Their allegiance is to the Crown, as it always was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""I am not complaining, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Lucita Azaro**
> ""You expect me to *thank* you?! I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[98]`
Mówca: **Taddeus Azaro**
> ""Yours is the judgement around which this kingdom revolves. I will not question it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. Perhaps I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[100]`
Mówca: **Narrator**
> "She caught herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""I should have done more to secure the rest of House Toras' allegiance. The fault is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""What happened at the birthday gathering felt quite deliberate to me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""My daughter started all this when she betrayed our kingdom. We deserve our punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Hugo placed both of his hands on the table, palms up in a sign of supplication."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Lucita's face filled with resolve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Regret was etched into Taddeus' features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""Carlos, my father and I will continue to see the Pales war through. But my service to the Kingdom will end there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[142]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""Carlos and I will continue to see the Pales war through. But my service to the Kingdom will end there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[142]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""My father may not have many years left in him. I'll return to Cardesse-Montaklar and to my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""I know I risk receiving the same fate as my father. But I hope you will let me go in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""All my life, I believed I was destined for greatness. But here I am, Your Majesty. A broken man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Taddeus Azaro**
> ""I deserve neither my noble title, my rank nor my position on this council. I am nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[143]`
  - -> `[145]`
  - -> `[151]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go, then. But I will never forget your act of cowardice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less than a complete and total victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have failed me as you have failed Rizia. Your name shall be written out of the history books.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the circumstances, I thank you both for your years of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the circumstances, I thank you for your years of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Narrator**
> "My security councilor numbly handed me a large folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't quit. Because you're fired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Hugo numbly handed me a large folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""This should be all the information my replacement needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Including an update on the recent unrest. As you can see, the protests have died down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Unrest_NatDes_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[166]`
Mówca: **Taddeus Azaro**
> ""This should be all the information my replacement needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Taddeus Azaro**
> ""Including an update on the recent unrest. As you can see, the protests have died down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Unrest_NatDes_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
Mówca: **Lucita Azaro**
> ""The ringleader, Adarfo Sotelato, has been arrested. I hope you make an example out of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Lucita Azaro**
> ""The ringleaders have all been arrested. I trust they'll receive the Sotelato treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[179]`
Mówca: **Lucita Azaro**
> ""I admit I didn't think we'd be able to subdue the movement without resorting to harsh measures. But it seems the revolutionaries won't trouble us any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Taddeus Azaro**
> ""The ringleader, Adarfo Sotelato, has been arrested. I hope you make an example out of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[184]`
Mówca: **Taddeus Azaro**
> ""The ringleaders have all been arrested. I trust you'll make an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[185]`
Mówca: **Taddeus Azaro**
> ""I admit I didn't think we'd be able to subdue the movement without resorting to harsh measures. But it seems the revolutionaries won't trouble us any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[189]`
Mówca: **Hugo Toras**
> ""This should be all the information my replacement needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
Mówca: **Hugo Toras**
> ""As well as a dossier I've compiled for your new security councilor, whoever they may be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Hugo Toras**
> ""It includes an update on the recent unrest. As you can see, the protests have died down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_NatDes_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Unrest_NatDes_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_AssassinationOrdered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Hugo Toras**
> ""The ringleader, Adarfo Sotelato, has been arrested. I'd advise you to make an example out of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""The ringleaders have all been arrested. I advise you to make an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""I admit I didn't think we'd be able to subdue the movement without resorting to harsh measures. But it seems the revolutionaries won't trouble us any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NatDes_Oppress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.NatDes_Oppress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring all three provinces to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

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
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[220]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring both Valenqiris and Cardesse-Montaklar to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[221]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring both Valenqiris and Brenas to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Taddeus Azaro**
> ""Overseeing the transfer of all three provinces to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[229]`
Mówca: **Taddeus Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Valenqiris to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[230]`
Mówca: **Taddeus Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Brenas to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseSazon_Conquered == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""The bureaucratic fallout from transferring Valenqiris to Crown control will be a hefty task, but I'm sure you'll be able to manage without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Taddeus Azaro**
> ""Overseeing the complete transfer of Cardesse-Montaklar to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true && RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""Overseeing the transfer of all three provinces to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Valenqiris to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""Overseeing the transfer of both Cardesse-Montaklar and Brenas to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[248]`
Mówca: **Lucita Azaro**
> ""Overseeing the complete transfer of Cardesse-Montaklar to Crown control will be a delicate security matter. But I'm sure you can handle it without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing work. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Now please get out of my sights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true && (RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true || RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true  and  (Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true  or  Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Narrator**
> "My advisors hurriedly stood, bowed and backed towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[272]`
  - -> `[280]`

### Węzeł `[262]`
Mówca: **Narrator**
> "My advisor stood, bowed and backed towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[280]`
  - -> `[279]`

### Węzeł `[263]`
Mówca: **Narrator**
> "My advisors stood and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[272]`

### Węzeł `[264]`
Mówca: **Narrator**
> "My advisor stood and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[280]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Toras and Mr. Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[282]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[282]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[276]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Toras and Ms. Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Ms. Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meeting adjourned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until we meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still my uncle, Hugo. I love and respect you greatly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pox on your entire family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[283]`
Mówca: **Narrator**
> "Titus opened the door and ushered Hugo and Lucita out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Hugo didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[285]`
Mówca: **Narrator**
> "Hugo didn't react. I saw venom in Lucita's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Hugo didn't react. Taddeus merely cast his eyes downward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Narrator**
> "I saw venom in Lucita's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Taddeus cast his eyes downward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[289]`
Mówca: **Hugo Toras**
> ""Goodbye, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Narrator**
> "I saw venom in my ex-councilor's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Narrator**
> "Titus opened the door and ushered Hugo and Taddeus out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[301]`
Mówca: **Narrator**
> "Titus opened the door and ushered Hugo out, a frown of regret on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Narrator**
> "Titus opened the door and ushered Lucita out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[306]`
Mówca: **Narrator**
> "Titus opened the door and ushered Taddeus out, a small smile of triumph on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
