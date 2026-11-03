# Rizia/Turn 4/A_HouseOfDelegates

- **ID konwersacji:** `312`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/312_A_HouseOfDelegates.md`
- **Liczba węzłów dialogowych:** 551
- **Liczba wyborów gracza:** 87

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[89]** Russello Montoro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Economy_PromiseNoMiningRegs`
- `RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject`
- `RiziaDLC.Focus_Economy_Diversification`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_WorkRegulationCost`
- `RiziaDLC.Country_ProductionCapacity`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Rusty_TookMedallion`
- `RiziaDLC.Turn04_EnableRRGStakeChange`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus`
- `RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty`
- `RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations`
- `RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_RegulationsMiningExemption`
- `RiziaDLCSupport.News_Turn04_RH_SafetyLaws`
- `RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed`
- `RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed`
- `RiziaDLCSupport.Reports_Turn04_Argno_MiningPause`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 26

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_WorkRegulationCost`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[159]` (Paskal Beniwoll): `EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustries"); Variable["RiziaDLC.Resources_Autho...`
- Węzeł `[160]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] = true; Variable["RiziaDLC.Re...`
- Węzeł `[226]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[322]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] = true;`
- Węzeł `[328]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] = true;`
- Węzeł `[333]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] = true;`
- Węzeł `[344]` (Paskal Beniwoll): `AddConversant("Daria de Rava");`
- Węzeł `[345]` (Paskal Beniwoll): `AddConversant("Manus Sazon");`
- *...oraz 18 innych węzłów ze skryptami.*

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
  - -> `[550]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I walked down the palm-tree-lined path that connected Palas Rezna to the nearby House of Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "In contrast to the ornate palace, the House was essentially a plain concrete box. Its stripped-down appearance reflected its hurried construction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The only adornment was a phrase chiseled above the entrance: "Ax Populat Rizati.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> ""To the Rizian People.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I made my way down the hall to the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Hugo rose to greet me as I entered the empty chamber. We took our seats atop the raised wooden platform in the center of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Directly below the platform were two podiums, one for each speaker. Wooden benches for the delegates were arranged in a circle around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""Welcome, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[164]`
  - -> `[11]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good morning, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[13]`
Mówca: **Narrator**
> "The clock struck ten and the delegates filed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Each wore a satin sash in the traditional color of his or her province: red for Rizia Imperii, blue for Valenqiris, yellow for Cardesse-Montaklar and green for Brenas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Next came the speakers. House Leader Daria de Rava walked out in a well-tailored crimson suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said she's a loyalist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which house does she belong to again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""Quite right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""The de Ravas aren't related to any of the royal houses. They were granted their nobility status through service to our family after the War of Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me, how did she land this job?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Technically, she's a Baroness. But she prefers the title of Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""She performed superbly as the head of the provincial council in Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I noted the approving tone in his voice as he spoke of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Next came Manus Sazon, clad in a black suit with a forest-green silk tie. He waved to his fellow delegates, then to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "Wave back to him."]** — Mówca: **Player_Romus_Italic**
> "I returned his wave. He smiled as he took his place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "Don't wave."]** — Mówca: **Player_Romus_Italic**
> "I didn't move as he took his place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Daria picked up a golden bell and rang it once."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Daria de Rava**
> ""Ladies and gentlemen, it is my privilege to call this meeting of the House of Delegates to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Daria de Rava**
> ""Today we are humbled by the presence of His Majesty King Romus, long may he reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "A few cries of "Long may he reign!" echoed among the delegates, particularly those in red and blue sashes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""The Rizian People's Party has prepared a proposal that Mr. Sazon will submit before the Delegates and His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[32]`
Mówca: **Daria de Rava**
> ""Mr. Sazon, would you like to explain more?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Manus Sazon**
> ""Gladly, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Manus Sazon**
> ""The past two decades have seen a marked increase in workplace accidents, particularly in the sectors of mining and manufacturing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[35]`
Mówca: **Manus Sazon**
> ""Now a cross-industry coalition of employees has bravely approached the Rizian People's Party with a list of requests to convey to our fellow delegates as well as His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""Among these are standardized workplace safety protocols, upgraded protective equipment, benefits for those injured on the job, and regular site inspections by state authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[37]`
Mówca: **Manus Sazon**
> ""Madam Speaker, Your Majesty, surely you agree on the urgency of this proposition. Rizia's great industries will not flourish as long as our workers are suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "I looked at Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is an honor to be here, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say that louder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am here to serve you, esteemed delegates. I look forward to your recommendations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I let her continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[43]`
Mówca: **Narrator**
> "The hall reverberated with full-throated cries of "LONG MAY HE REIGN!" Daria smiled and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[44]`
Mówca: **Narrator**
> "She smiled and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[45]`
Mówca: **Daria de Rava**
> ""The Delegates will vote on whether to accept or reject it, but this is a non-binding recommendation. The ultimate authority rests with the King and the Royal Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So Rusty was right. The RPP took up the workers' cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How does he expect us to pay for all this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's hard to believe we had none of these measures in place before now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""Mr. Montoro will be expecting you to make good on your assurance to him. But of course, you're under no obligation to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""This is why I never brought these meetings to your attention before. The proposals are impractical at best and ruinous at worst.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""And yet our industries flourished nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "I suddenly realized the hall had gone quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""Shall I continue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[74]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please go on. I didn't mean to interrupt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough from the RPP. I'd like to know what Ms. de Rava thinks about the Workers' Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[56]`
Mówca: **Daria de Rava**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Daria de Rava**
> ""Of course my party believes that worker safety is paramount. But the regulations that have been suggested today amount to overkill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[58]`
Mówca: **Daria de Rava**
> ""Furthermore, they already see employee safety as their responsibility. Shifting that responsibility to the government will do nothing to protect those at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Daria de Rava**
> ""It will, however, stifle our economic growth and decrease our viability in the global arena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[60]`
Mówca: **Daria de Rava**
> ""My point stands. With tensions rising in both our north and south, we simply cannot afford an extravagance of the type Mr. Sazon is proposing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[61]`
Mówca: **Narrator**
> "From near the front door came the sound of a single person applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[62]`
Mówca: **Daria de Rava**
> ""My point stands. Rizia's gold and gas income is far from guaranteed at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Busy as usual, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""The delegates will be on their best behavior with you here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[65]`
Mówca: **Narrator**
> "She had a brisk gait and impeccable posture. The other delegates practically held their breath as they waited for her to take her place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`
  - -> `[20]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""In all of the sessions I've attended, she has never made a decision that didn't align with the interests of the noble houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""It's now her third term as speaker. I do not believe she intends to vacate the position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[68]`
Mówca: **Narrator**
> "She flipped open a binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Daria de Rava**
> ""Today's session is regarding the Rizian Workers' Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""You're under no obligation to Mr. Montoro. But I would consider the costs of this proposal before saying yes to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, I would like to know how Rizia is to pay for these policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "He smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Manus Sazon**
> ""The Aureus gas field is expected to generate considerable revenue once Rizian drilling operations begin. I see no harm in running a slight deficit until then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
Mówca: **Manus Sazon**
> ""After all, in the end, this is a small price to pay for improving thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""Assuming the upcoming arbitrations go our way, the Aureus gas field is expected to generate considerable revenue for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""And in the end, this is a small price to pay for improving thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Manus cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""As a wise man once said, 'A society is only truly prosperous if every one of its members is able to share in its wealth.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Manus Sazon**
> ""As I was saying, my party and I believe that healthier workers will lead to a more prosperous society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""What we invest in these measures now will pay off tenfold in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[96]`
Mówca: **Manus Sazon**
> ""What we invest in these measures now will pay off tenfold in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Manus stepped back from his podium, trying to conceal his disappointment. Daria eagerly approached hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Daria de Rava**
> ""Our focus should be on achieving better diplomatic outcomes with our neighbors, not meddling in the affairs of our corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""Madam Speaker, you are on the board of a construction company yourself. Would you ever advise that it voluntarily undertake the measures we're describing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Daria brushed off the comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Cede == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Daria de Rava**
> ""Our focus should be on bolstering our businesses, not meddling in the affairs of our corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[108]`
Mówca: **Daria de Rava**
> ""My point stands. We should not be spending our wealth from the Aureus gas field acquisition before we have even earned it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Daria sharply knocked on her podium. All eyes turned to her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Daria de Rava**
> ""Forgive me, Your Majesty, but I cannot let my opponent continue with these lies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Manus reluctantly took a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[112]`
Mówca: **Manus Sazon**
> ""Our country still has a budget surplus, Your Majesty. One that will only increase once drilling on the Aureus gas field begins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Manus Sazon**
> ""Our country still has a budget surplus, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Manus Sazon**
> ""What is that wealth for, if not to improve the lives of our citizens?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Manus Sazon**
> ""Besides, a healthy worker is a productive worker. This small investment will pay off tenfold in the long term. For us and for our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[119]`
Mówca: **Narrator**
> "I looked towards the source. Rusty was standing in the back of the gallery, dressed in his usual plaid. He nodded at me as he kept clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[120]`
Mówca: **Narrator**
> "I turned towards Hugo again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[123]`
  - -> `[474]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want him out. Immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You didn't tell me that a special guest would be joining us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look, your favorite person's here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Hugo stared in Rusty's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Hugo stared in Rusty's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""I was not informed. In fact, I'm not certain how Mr. Montoro knew this discussion would be taking place today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Hugo stared in Rusty's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""Unfortunately, these sessions are open to the public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""We cannot ask him to leave without reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Hugo Toras**
> ""I should have known he'd make an appearance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""But I presume he is on the side of the RNC. The most he'll do is further expound on the impracticalities of Mr. Sazon's proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Rusty had stopped clapping now. He was scrutinizing me closely, a gleam in his eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Daria de Rava**
> ""How nice of you to join us, Mr. Montoro. Do you have any words on the topic at hand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Russello Montoro**
> ""Call me Rusty, Madam Speaker. And as a matter of fact, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Russello Montoro**
> ""Now, I won't take up too much of your time. The Baroness of Qaleo summed things up pretty well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Russello Montoro**
> ""But I wanted to offer my point of view as a humble business owner of common birth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Rusty ambled down the aisle of the chamber. He came to a stop between the two speaker podiums."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I side with the delegate majority. The workplace safety proposal from the Rizian People's Party shall not be undertaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I overrule the recommendation. The safety measures suggested by the RPP will be implemented in all industries with no exceptions." [-3 Budget, -3 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""I overrule the recommendation. The safety measures suggested by the RPP will be implemented in all industries with no exceptions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""After listening to compelling arguments from both Mr. Sazon and Mr. Montoro, I hereby order the implementation of the RPP's proposal, with the addendum that the mining industry will be exempt from the new regulations." [-2 Budget To Implement, -1 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""After listening to compelling arguments from both Mr. Sazon and Mr. Montoro, I hereby order the implementation of the RPP's proposal, with the addendum that the mining industry will be exempt from the new regulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[141]`
Mówca: **Russello Montoro**
> ""Damn straight, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""Silence, Mr. Montoro. Do not make His Majesty regret his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[143]`
Mówca: **Manus Sazon**
> ""The experts I've consulted with have pinpointed several factors responsible for the rise, chief among them a shortage of skilled labor and growing pressure from our trading partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Manus Sazon**
> ""Simply put, our corporations have been cutting corners, at the expense of human health and safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Manus Sazon**
> ""His Majesty's decree to grant full working permissions to guest workers has helped with the labor shortage, but these employees have been promoted in a rush, making conditions yet more hazardous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""And of course, financial penalties for corporations that fail to meet these requirements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[150]`
Mówca: **Daria de Rava**
> ""If our businesses are to remain competitive, it is wiser to incentivize good safety practices than to punish their absence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[151]`
Mówca: **Narrator**
> "My uncle gave Rusty a withering look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Russello Montoro**
> ""Son of a she-dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "My uncle gave Rusty a withering look. Manus stepped back from the podium, his expression hard to read."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Hugo Toras**
> ""His Majesty has made his decision. Do not question it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Rusty glared at me, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustries");
RiziaDLC.Resources_Authority += 2;
RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries = true;)*
- **Efekt (`userScript`):** `EnactDecree("Welfare_Citizenship_WorkersRightsAllIndustries");
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;
Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining = true;  
RiziaDLC.Resources_Budget -= 2;
RiziaDLC.Budget_Modifier_WorkRegulationCost = -1;
RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_RegulationsMiningExemption = true;
RiziaDLC.Country_ProductionCapacity -= 1;
RiziaDLC.LeaningValue_Democratic += 1;
RiziaDLC.LeaningValue_ProBusiness -= 1;
RiziaDLC.Country_PublicOpinion += 4;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLC.Budget_Modifier_WorkRegulationCost"] = -1;
Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_RegulationsMiningExemption"] = true;
Variable["RiziaDLC.Country_ProductionCapacity"] = Variable["RiziaDLC.Country_ProductionCapacity"] - 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] - 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 4;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Russello Montoro**
> ""All hail the king!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Hugo Toras**
> ""Silence, Mr. Montoro. Do not make His Majesty regret his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[163]`
Mówca: **Narrator**
> "My uncle gave Rusty a withering look. Manus stepped back from the podium, his face hard to read."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What can we expect today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Hugo Toras**
> ""The usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Hugo Toras**
> ""The Sazon boy will try to pass his latest impractical proposition, and the delegates will sensibly shoot it down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[176]`

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""The silence from Wehlen has me rather on edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[198]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[168]`
Mówca: **Hugo Toras**
> ""The Pales naval standoff has me rather on edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good that I'm here. It's about time someone listened to that kid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a waste of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""No. And you shouldn't be, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[175]`
Mówca: **Hugo Toras**
> ""There's a reason the King doesn't traditionally attend these sessions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impractical? I'll be the judge of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""I assure you that you'll agree with me once the arguments are presented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[178]`
Mówca: **Hugo Toras**
> ""The Sazon boy might even keep his speeches to under a half hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`
  - -> `[181]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Joke all you want, but it's about time someone listened to that kid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Based on what I saw in Sallabes, I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not jealous of the attention he gets, are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Someone besides your daughter, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""Ha. Far from it. Although I am worried about the attention he's been getting from one Vina Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[184]`
Mówca: **Hugo Toras**
> ""His speech there seemed to have done a number on your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a standoff. Just insurance in case things go south at the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, I'll be glad when it's over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. Lucita has everything under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""Duchess Azaro is 'Lucita' now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Hugo frowned pensively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[190]`
Mówca: **Hugo Toras**
> ""Will your war councilor, I wonder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""I trust Duchess Azaro is capable of de-escalation if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Me, too. I hope your son's gambit worked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Smolak will be at the next AN session. We can corner him there if we need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing we can do about it now. Let's focus on today's meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope the investigators haven't found anything damning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[199]`
Mówca: **Hugo Toras**
> ""Madam Speaker, let the record show that the King has aligned with the House majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Madam Speaker, let the record show that the King has overridden the House majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Daria de Rava**
> ""Noted, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Narrator**
> "Daria made a note in her binder, then looked up at Hugo and myself. If she was bothered by my decision, her face didn't show it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Daria de Rava**
> ""Once again, I thank His Majesty for blessing us with his presence today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Daria de Rava**
> ""And Grand Vizier Hugo Toras for presiding over the session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Daria de Rava**
> ""Noted, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Daria made a note in her binder, then looked up at me, slightly smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""An honor as usual, Madam Speaker. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Daria de Rava**
> ""My fellow delegates and esteemed guests, this meeting is now adjourned. Any follow-up questions will be addressed in future sittings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "She rang the bell again, and the room began to empty out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[210]`
Mówca: **Narrator**
> "As the guards escorted me and Hugo towards the exit, I noticed Rusty still standing in the hall with his arms folded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[388]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[445]`
  - -> `[383]`
  - -> `[384]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, Rusty. I couldn't make it look like I was playing favorites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No hard feelings?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? I'm a man of my word, aren't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me regret listening to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[218]`
Mówca: **Russello Montoro**
> ""And I'm a man of mine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You never seriously thought I was going to give in to you, did you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Russello Montoro**
> ""You're the king. It's your prerogative to change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[221]`
Mówca: **Russello Montoro**
> ""Sure, Your Majesty. I hear you loud and clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[222]`
Mówca: **Russello Montoro**
> ""None, Your Majesty. We're all just playing games here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to thank me. You and I wanted this equally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[224]`
Mówca: **Narrator**
> "He bowed to each of us in turn before hurrying back into the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[225]`
Mówca: **Russello Montoro**
> ""Never, Your Majesty. In fact...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Narrator**
> "He looked at me and winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Russello Montoro**
> ""Now. The Rizian Standard Dictionary defines 'gold' as a yellow precious metal, used in jewelry and to guarantee the value of currencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no bloviating in these chambers, *Rusty*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we are all familiar with the substance in question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "Let him talk."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent as he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Russello Montoro**
> ""But in Rizia, it's so much more. Commoners who've never even touched a ducat still feel proud to live 'on shores of gold', as we sing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Russello Montoro**
> ""Fair enough, Your Majesty. Mr. Sazon over there has done enough bloviating for all of us put together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[237]`
Mówca: **Russello Montoro**
> ""But our shores would never have been golden in the first place if our monarchs had listened to naysayers like Mr. Sazon here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Russello Montoro**
> ""Your Majesty, your predecessors knew that there can be no prosperity without hard work. Our grit and determination today fills the nation's coffers tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Russello Montoro**
> ""But where does that grit go when the government's got our hands tied? How can we function as a company when you folks don't trust us to take care of our own people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Manus Sazon**
> ""If I may ask, sir, how exactly would our proposal tie your hands? What is so difficult about regulating safety in gold mines?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Russello Montoro**
> ""Don't play dumb, kid. You know each mining site in Rizia is as unique as a birthmark on the Archpriest of Deyr's behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""They would be paid for in equal measure by the government and the corporations in question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[243]`
Mówca: **Daria de Rava**
> ""Mr. Montoro, I assume you are here as a representative of RRG as well as Rizia's business community as a whole. Is it safe to say your fellow executives share your opinion on the RPP's proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Narrator**
> "Rusty grinned toothily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Russello Montoro**
> ""Oh, it's very safe to say that. Although it does strike me that your opponent's proposal could be implemented in, say, the construction industry without too much difficulty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Daria's grip on her podium tightened. Rusty stroked his chin faux-thoughtfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Russello Montoro**
> ""Come to think of it, I won't presume to speak up for the people in Madam Speaker's high-and-mighty 'circles'. I'm the only one who cared enough to show up today, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Russello Montoro**
> ""So here's another thought. You regulate Rizian industry however you want. But maybe, just maybe, you think about making an exception for old Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[249]`
Mówca: **Narrator**
> "He winked at me again. Manus drew a hand across his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Manus Sazon**
> ""Our proposal as it stands does not allow for exceptions. The King may alter it as he sees fit, but the RPP refuses to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[257]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving *some* of the workers what they want might divide them enough to head off organized dissent, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Narrator**
> "Manus drew a hand across his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[256]`
Mówca: **Russello Montoro**
> ""But I'll just say this. There's no way we at RRG can keep filling your government's coffers if our hands are tied by unnecessary regulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your proposal was never going to be accepted in its entirety, Mr. Sazon. Compromise is part of the political process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've witnessed Mr. Montoro's cavalier attitude towards employee safety. If any company needs to be regulated, it's RRG.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't agree with Mr. Montoro's arguments one bit. It doesn't make sense to regulate some industries and not others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[260]`
Mówca: **Narrator**
> "Daria frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Daria de Rava**
> ""What it will do is hamper the majority of Rizian businesses while giving miners an unfair advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[262]`
Mówca: **Manus Sazon**
> ""My party will not compromise when human welfare is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[263]`
Mówca: **Narrator**
> "Daria nodded energetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Daria de Rava**
> ""No, it does not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[265]`
Mówca: **Russello Montoro**
> ""Cavalier? Heck, Your Majesty, you're the one who'd be putting men out of work with one decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Hugo calmly spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Hugo Toras**
> ""The time for a vote is drawing close. To be clear, Mr. Sazon, you do not wish to amend your proposal to take into account Mr. Montoro's comments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Daria de Rava**
> ""Please do not forget in whose presence you're speaking, Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[269]`
Mówca: **Manus Sazon**
> ""I do not, Your Grace. The King may choose to accept or ignore them at will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty, did you have any closing arguments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to confer with my Grand Vizier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Closing Arguments)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[358]`
  - -> `[361]`
  - -> `[325]`

### Węzeł `[273]`
Mówca: **Manus Sazon**
> ""I've stated my case, Your Majesty. But I will say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""This proposal would fail without you in this room. So I'd like to believe you've joined us for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_WorkWithRPP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_WorkWithRPP == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_WorkWithRPP == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Manus Sazon**
> ""I'm glad you joined us in this room today. Perhaps now you have a better sense of how His Majesty Valero's system was designed to function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""The majority of delegates in this room support noble interests. Not those of the subjects they claim to represent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Manus Sazon**
> ""As long as that is true, it is the King's responsibility to see past the lies and make the decision that best serves ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""Thank you for listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[282]`
Mówca: **Daria de Rava**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Narrator**
> "We turned away from the Delegates and spoke in low voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[289]`
  - -> `[301]`
  - -> `[302]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told Manus I wanted to work closer with him. Would I be throwing away that chance if I shot down his proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't ignore the potential benefits of cooperating with RRG. Can I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[292]`
Mówca: **Daria de Rava**
> ""All those in favor of the RPP's worker safety proposal, raise your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Narrator**
> "About a quarter of the delegates, mostly those with green sashes, put a hand in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Daria de Rava**
> ""Those in favor of encouraging Rizian businesses -- *all* businesses -- to develop and enforce their own safety protocols on a voluntary basis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Narrator**
> "The rest of the delegates -- an overwhelming majority -- raised their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Daria de Rava**
> ""The Delegates have an official recommendation. Rather than introduce sweeping and expensive labor reforms, Rizia should entrust the matter of safety to its business owners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Hugo nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Hugo Toras**
> ""Thank you, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Daria de Rava**
> ""The final decision is now in the hands of His Majesty King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Daria de Rava**
> ""Will you accept or overrule the Delegates' recommendation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would I lose face with the Delegates if I implemented a proposal they voted against?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think about Rusty's exception idea? Could I decide to exempt RRG from the new regulations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[303]`
Mówca: **Hugo Toras**
> ""Then you have the floor, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Daria de Rava**
> ""Thank you, Your Grace. As a reminder to you and His Majesty, this vote serves to demonstrate the opinion of the Rizian populace, and is a non-binding recommendation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[305]`
Mówca: **Hugo Toras**
> ""It would be highly unusual, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[306]`
Mówca: **Narrator**
> "Hugo coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Hugo Toras**
> ""Why would you-- Well. I'm sure you had a good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[308]`
Mówca: **Hugo Toras**
> ""Valero never rejected a recommendation in all his years as king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[309]`
Mówca: **Hugo Toras**
> ""You're the king. Of course you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[310]`
Mówca: **Hugo Toras**
> ""The young man does seem desperate to have you in his corner. I suspect the princess has something to do with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would I be making an enemy of Manus Sazon's party and his house if I shot down his proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Narrator**
> "Hugo coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""His party is the enemy already. Granting them your favor will strengthen their chances in the next election, and commensurately weaken the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""It would save the kingdom money, it would send Mr. Montoro over the moon and it would partly placate the complainers in the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Hugo Toras**
> ""However, it would have a significant effect on Rizia's other corporations, many of which are owned by nobles such as Baroness de Rava and her constituents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[319]`
Mówca: **Hugo Toras**
> ""In this case, accepting the RPP's proposal would be deleterious to the economies of the provinces the Delegates represent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[320]`
Mówca: **Hugo Toras**
> ""Mr. Montoro did imply that staying on good terms with his company would earn you the right to buy back the former royal stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""If we want to continue as a resource-based economy, owning more of RG would be advisable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Closing Arguments])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you said all that you wanted to say, Mr. Sazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here's what I have decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "Everyone in the room went silent as they awaited my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[413]`
  - -> `[416]`

### Węzeł `[327]`
Mówca: **Russello Montoro**
> ""I surely do not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Closing Arguments])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[330]`
Mówca: **Russello Montoro**
> ""It seems to me like the decision you have to make is no decision at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Russello Montoro**
> ""You could even walk out of this room right now and let your legislative system do the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Russello Montoro**
> ""But you're a man of action. I know you want the final say. So by all means, go on and say it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Closing Arguments])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[335]`
Mówca: **Narrator**
> "He reached out to shake my hand. I suddenly felt the cool of metal against my palm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[336]`
Mówca: **Russello Montoro**
> ""My guys dug this up in the MITZ a while back. Consider it a token of my appreciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[337]`
  - -> `[338]`
  - -> `[339]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Rusty. I'll treasure it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten what you wanted. No need for bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[340]`
Mówca: **Russello Montoro**
> ""Thought you'd like it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[341]`
Mówca: **Russello Montoro**
> ""Heck if I know. Looks pretty old, though, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[342]`
Mówca: **Russello Montoro**
> ""Who do you think I am? This is out of the goodness of my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[343]`
Mówca: **Russello Montoro**
> ""As for those revisions to the RRG shareholder contract... my lawyers will be in touch with the paperwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Daria de Rava");)*
- **Efekt (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Argno_MiningPause = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Argno_MiningPause"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_V_SafetyLawsHalfPassed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_V_SafetyLawsNotPassed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Rusty"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_Manus"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_HOD_Conclusion_ConsultWithHugo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[365]`
Mówca: **Manus Sazon**
> ""Now a cross-industry coalition of employees and guest workers has bravely approached the Rizian People's Party with a list of requests to convey to our fellow delegates as well as His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[366]`
Mówca: **Manus Sazon**
> ""Our industries' continued reliance on guest workers, who are paid and trained less than their native Rizian counterparts, is exacerbating the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_RH_SafetyLaws = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_SafetyLaws"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations = true;
RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights = true;
RiziaDLC.PersonalValue_Malenyevist -= 1;
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.LeaningValue_ProBusiness += 2;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights"] = true;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] + 2;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`
  - -> `[219]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something you'd like to say to me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[384]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I kept walking towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Russello Montoro**
> ""One moment of your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've been hoarding this? It belongs to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Russello Montoro**
> ""Finders keepers, I always thought. But hey, it's yours now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[388]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I ignored him and kept walking towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Narrator**
> "He eyed me coolly as Hugo and I passed him and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[390]`
Mówca: **Narrator**
> "He extended his hand for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "As I shook his hand, I suddenly felt the cool of metal against my palm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
**[WYBÓR GRACZA: "Leave without acknowledging him."]** — Mówca: **Player_Romus_Italic**
> "I motioned to Hugo, and we left without acknowledging him. I saw an amused look on his face as I walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[393]`
Mówca: **Narrator**
> "I withdrew my hand and took a closer look at the object he'd given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[394]`
Mówca: **Russello Montoro**
> ""Your act of benevolence will not be forgotten, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[395]`
Mówca: **Russello Montoro**
> ""I just wanted to express my gratitude, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Russello Montoro**
> ""See you real soon, Your Majesty. Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[400]`
Mówca: **Russello Montoro**
> ""If you'll recall, I also mentioned the possibility of revising the RRG shareholder contract. You interested?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`
  - -> `[403]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, but no. The Kingdom's share in RRG will stay the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps. I'd have to know more details first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've given some thought to it and, yes, I would like to alter Rizia's share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Russello Montoro**
> ""Your wish is my command. I'll have my lawyers get in touch with the paperwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[405]`
Mówca: **Russello Montoro**
> ""No problem. Just thought I'd ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_WruhecistMedallion");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_WruhecistMedallion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn04_EnableRRGStakeChange = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn04_EnableRRGStakeChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For what it's worth, you made a good case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[410]`
Mówca: **Russello Montoro**
> ""Nothing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Russello Montoro**
> ""We'll get to work on those regulations straight away. But I wasn't kidding about our gold output suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[412]`
Mówca: **Russello Montoro**
> ""Much obliged, Your Majesty. No hard feelings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While I sympathize with the RPP, our treasury is too strained for this proposal. It will not be implemented at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_TookMedallion = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rusty_TookMedallion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Hugo Toras**
> ""He seemed to have caught your attention in Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Hugo Toras**
> ""Rebuilding relations with House Sazon is a sound strategy. But we mustn't allow them to get too close to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[426]`
Mówca: **Hugo Toras**
> ""Rebuilding relations with House Sazon is a sound strategy. As long as you don't buy into their nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Hugo Toras**
> ""They're a fool for rhetoric over in Brenas. We mustn't allow ourselves to be so easily suckered in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[434]`
Mówca: **Hugo Toras**
> ""When you have enough power, attention is nothing but a hindrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[435]`
Mówca: **Russello Montoro**
> ""Raising the stake won't be free, naturally. But I'll give you a royal discount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[436]`
Mówca: **Daria de Rava**
> ""The RNC is not willing to compromise, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Diversification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Diversification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Diversification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Economy_Diversification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Diversification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[440]`
Mówca: **Hugo Toras**
> ""However, if the goal is to diversify our economy away from resources, that 15 percent barely matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[441]`
Mówca: **Daria de Rava**
> ""Rizia's other major corporations -- run by families with much longer and illustrious histories than that of Mr. Montoro here -- should not be punished simply because they do not happen to produce gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Narrator**
> "I heard whispers of agreement from several other RNC members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Manus Sazon**
> ""That you would refer to these perfectly reasonable suggestions as a 'punishment' is indicative of where your loyalties lie, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[444]`
Mówca: **Russello Montoro**
> ""I've got to head out and spread the bad news. See you real soon, Your Majesty. Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[448]`
Mówca: **Russello Montoro**
> ""It might be time to think about finding new gold sources. Just to keep us in the black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[452]`
Mówca: **Russello Montoro**
> ""At least the new mine in Qalus will keep us in the black. Just about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[453]`
Mówca: **Russello Montoro**
> ""You might want to think about digging under your relations' estates in Valenqiris after all. Just to keep us in the black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Enable_Policy_RD_Economy_QalusGoldMineProject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[457]`
Mówca: **Narrator**
> "He bowed to me, then jauntily straightened up and walked out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_WorkWithRPP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_WorkWithRPP == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_WorkWithRPP == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[461]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "I extended my hand. He hesitated for a moment, then shook it eagerly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Manus Sazon**
> ""Your Majesty. Thank you so much for attending today's session. And for implementing our proposal, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[517]`
  - -> `[519]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Manus Sazon**
> ""Your Majesty. Thank you so much for attending today's session. Implementing even part of our proposal was more than we could have hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[517]`
  - -> `[519]`
  - -> `[518]`

### Węzeł `[470]`
Mówca: **Manus Sazon**
> ""Your Majesty. I cannot thank you enough for attending today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[520]`
  - -> `[518]`

### Węzeł `[471]`
Mówca: **Narrator**
> "Manus' eyes traveled involuntarily to the street, where one of Rusty's guards was helping the gold magnate into a shiny black Kadilla."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Russello Montoro");)*
- **Efekt (`userScript`):** `AddConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Narrator**
> "Behind him, leaning against the wall, were two of the Arcasian guards I'd seen in Bronaz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is this going to be a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[476]`
Mówca: **Hugo Toras**
> ""I can't say I'm happy to see Mr. Montoro in these halls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[477]`
Mówca: **Narrator**
> "He gave Manus a brusque nod. The opposition speaker didn't acknowledge it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[478]`
Mówca: **Narrator**
> "Scandalized chatter broke out among the Delegates. Daria banged her gavel for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Russello Montoro**
> ""Point is, there's no one-size-fits-all protocol for regulating what we do. The environment, the ore density, the tech being used -- it all varies, even within parts of the same mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Russello Montoro**
> ""We're doing our best to keep our workers safe on the job. But we also want them to go home with healthy paychecks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're exaggerating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about the miners who have been speaking out? We cannot ignore their complaints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[483]`
Mówca: **Russello Montoro**
> ""Your Majesty, esteemed Delegates -- if we're forced to develop specialized protocols for every single nook and cranny of our business, we'll end up millions in the hole. Who even knows if anyone will be safer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[484]`
  - -> `[489]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You could easily afford such measures if you forewent a portion of your own salary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[485]`
Mówca: **Narrator**
> "Rusty chuckled to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[486]`
Mówca: **Russello Montoro**
> ""I beg your pardon, but half the people in this room are sitting on fortunes just because they happen to have the right last name. Asking a hard-working commoner to give up the money he spent his life scraping for -- it doesn't sit right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[487]`
Mówca: **Russello Montoro**
> ""RRG takes care of our own, Your Majesty. We'll solve this within our company, like we always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[488]`
Mówca: **Russello Montoro**
> ""Hey, if you want to test my theory, you're more than welcome to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That does seem much more complicated than Mr. Sazon made it out to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[490]`
Mówca: **Russello Montoro**
> ""Yes, well, he's a noble. Sooner or later, he's got to butt heads with the way the world really works.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[491]`
Mówca: **Narrator**
> "A quiet look of annoyance flashed across Daria's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[492]`
Mówca: **Narrator**
> "Daria cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[493]`
Mówca: **Daria de Rava**
> ""The subject of noble wealth is hardly germane to this discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[494]`
Mówca: **Hugo Toras**
> ""And if we are to increase our stake, it would behoove us not to damage RRG's profitability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[495]`
Mówca: **Hugo Toras**
> ""Passing a version that exempts RRG makes practical sense, but would surely anger the nobles whose investments are affected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[496]`
Mówca: **Hugo Toras**
> ""As for his family, I don't believe House Sazon had a hand in this proposal at all. They have as much to lose from it as the Azaros or Torases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[497]`
Mówca: **Hugo Toras**
> ""But I urge you to make the decision that benefits Rizia, not Mr. Sazon or his party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[498]`
Mówca: **Hugo Toras**
> ""The young man does seem desperate to have you in his corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations = true;
RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights = true;
RiziaDLC.LeaningValue_ProBusiness += 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_HouseOfDelegates_NoNewRegulations"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_WorkersRights"] = true;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[500]`
Mówca: **Russello Montoro**
> ""Good enough for me, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Russello Montoro");)*
- **Efekt (`userScript`):** `RemoveConversant("Russello Montoro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[458]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[545]`
  - -> `[546]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Daria de Rava");
RemoveConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `RemoveConversant("Daria de Rava");
RemoveConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[504]`
Mówca: **Narrator**
> "He bowed, then began whistling jauntily as he walked past me and out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[505]`
Mówca: **Narrator**
> "Hugo shook his head with disdain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Hugo Toras**
> ""You were right not to grant him an exception. That man's ego does not need any further inflation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[510]`
Mówca: **Hugo Toras**
> ""Exempting RRG from the new regulations was a logical compromise, but I do hope it won't inflate that man's ego any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Hugo Toras**
> ""You were right to side with the RNC. The more of Rizian Royal Gold we can snatch back from that man's hands, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[515]`
Mówca: **Hugo Toras**
> ""I'm still curious how he found out that today's session was taking place. It would be most unlike Speaker de Rava to inform him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Narrator**
> "As we stepped outside the House of Delegates, I saw Manus Sazon waiting to greet us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy to have gotten a look into the inner workings of the House of Delegates. It was very enlightening indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My foremost concern is for the Rizian economy. I hope you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're most welcome. We shall have to meet soon to discuss the next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you aren't too disappointed with the outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[521]`
Mówca: **Manus Sazon**
> ""I hope that means you'll continue to consider our proposals going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[522]`
Mówca: **Manus Sazon**
> ""You're welcome to attend as often as you'd like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[524]`
Mówca: **Manus Sazon**
> ""Not at all. I see the merit in my opponents' arguments, and I understand your decision completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Manus Sazon**
> ""I understand completely. I'll make sure our future proposals are more economically feasible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[526]`
Mówca: **Narrator**
> "Hugo gave him a thin-lipped smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[530]`
Mówca: **Hugo Toras**
> ""Congratulations, Mr. Sazon. I'm sure you and your party will be celebrating today's triumph.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""Indeed, Your Grace. His Majesty's ruling was... much more than I ever could have hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[535]`
Mówca: **Hugo Toras**
> ""Congratulations, Mr. Sazon. I hope your party isn't terribly disappointed about the exemption for Mr. Montoro's corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Narrator**
> "Manus' eyes traveled involuntarily to the street, where one of Rusty's guards was helping the gold magnate into a shiny black Kadilla."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Narrator**
> "A look seemed to pass between the two of them. What it meant, I wasn't certain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Manus Sazon**
> ""Of course many of my colleagues wanted more... But in my opinion, His Majesty's ruling is still cause for celebration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[539]`
Mówca: **Hugo Toras**
> ""You did well today, Mr. Sazon. I hope you and your party aren't too disappointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[540]`
Mówca: **Narrator**
> "Manus' eyes traveled involuntarily to the street, where one of Rusty's guards was helping the gold magnate into a shiny black Kadilla."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[541]`
Mówca: **Narrator**
> "A look seemed to pass between the two of them. What it meant, I wasn't certain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[542]`
Mówca: **Narrator**
> "A look seemed to pass between the two of them. What it meant, I wasn't certain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[543]`
Mówca: **Manus Sazon**
> ""A temporary setback, Your Grace. We'll continue to push for the well-being of all Rizians, to the extent that our limited forum allows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Manus Sazon**
> ""I won't trouble either of you any longer. Thanks once more and good afternoon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah. Just the man I wanted to see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[548]`
Mówca: **Daria de Rava**
> ""The business owners in my circles, most of whose companies span generations, cannot simply transform their practices at the whim of the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[549]`
Mówca: **Daria de Rava**
> ""The views of the nobility are hardly germane to this discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Listening to a proposal from the Rizian People’s Party", "House of Delegates", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Listening to a proposal from the Rizian People’s Party","House of Delegates","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
