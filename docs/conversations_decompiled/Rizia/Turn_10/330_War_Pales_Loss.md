# Rizia/Turn 10/War_Pales_Loss

- **ID konwersacji:** `330`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/330_War_Pales_Loss.md`
- **Liczba węzłów dialogowych:** 417
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_ParliamentProposesPeace`
- `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin`
- `RiziaDLCIsolated.Turn10_WarLoss_HowLong`
- `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon`
- `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Carlos_Deranked`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Faction_HouseAzaro_Carlos`
- `RiziaDLC.Faction_HouseAzaro_Lucita`
- `RiziaDLC.Faction_HouseAzaro_Taddeus`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Deranked`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.War_Pales_Loss_SueForPeace`
- `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin`
- `RiziaDLCIsolated.Turn10_WarLoss_HowLong`
- `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon`
- `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_KeepFighting`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace`
- `RiziaDLCSupport.News_Turn10_RH_LucitaTaddeusArrested`
- `RiziaDLCSupport.News_Turn10_RH_TaddeusArrested`
- `RiziaDLCText.LucitaTitle`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 27

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.War_Pales_Loss_SueForPeace`
- `RiziaDLCIsolated.Turn10_WarLoss_CanWeWin`
- `RiziaDLCIsolated.Turn10_WarLoss_HowLong`
- `RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon`
- `RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus`
- *...oraz 2 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[53]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] = true;`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] = true;`
- Węzeł `[55]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] = true;`
- Węzeł `[56]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] = true;`
- Węzeł `[78]` (Paskal Beniwoll): `Variable["RiziaDLC.War_Pales_Loss_SueForPeace"] = true; Variable["RiziaDLCSupport.Journal_Turn10_...`
- Węzeł `[79]` (Paskal Beniwoll): `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] = true; Variable["RiziaDLCSupport.Journal_T...`
- Węzeł `[98]` (Paskal Beniwoll): `Variable["RiziaDLC.Taddeus_Deranked"] = true; Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_...`
- Węzeł `[103]` (Paskal Beniwoll): `End();`
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
  - -> `[416]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "When I entered the War Room, General Taddeus Azaro was in his wheelchair next to the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[4]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[5]`
Mówca: **Taddeus Azaro**
> ""All my life, I was told I was meant for greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Taddeus Azaro**
> ""Once again, presenting the same news that I delivered to King Valero so many years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""My life has been nothing but a series of failures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[11]`
  - -> `[9]`
  - -> `[370]`

### Węzeł `[8]`
Mówca: **Taddeus Azaro**
> ""Yet here I am. Defeated, unworthy. I can't even stand on my own two feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spare me your antics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Clearly. Because you are weak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is always hope. No matter how dire the situation is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[13]`
Mówca: **Lucita Azaro**
> ""We have news from the frontline, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Lucita Azaro**
> ""Pales still stands despite our attacks on their heartland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""The Palesian army has pushed us back from the border into the Pales Administrative District.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""We've lost Terador and Fort Ales. The frontline is broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""Once we exhausted our troops, they managed to push us back, retaking Arces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""We are holding them at the frontline on an equal footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""They do not seem to be currently advancing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I have failed. This burden is mine to bear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""But our operation has failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Her words sank deep into my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[26]`
  - -> `[27]`
  - -> `[200]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no one to blame. We must look to the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where were you when we were losing this war, Duchess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[28]`
Mówca: **Taddeus Azaro**
> ""Please don't blame my daughter, Your Majesty. This is entirely on me, not her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[29]`
Mówca: **Taddeus Azaro**
> ""I know, Your Majesty. It is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[30]`
Mówca: **Taddeus Azaro**
> ""That's generous of you to say, Your Majesty. But we all know but we all know the failure is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[31]`
Mówca: **Taddeus Azaro**
> ""No, Your Majesty. It is all my fault. I'm the one whose to blame. Not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""Before we figure out who is to blame, I suggest we discuss what happens next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: War Loss Next Steps)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[41]`
  - -> `[44]`
  - -> `[47]`
  - -> `[50]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can we still win?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think we should sue for peace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long can we afford to keep the war going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would the Palesians be able to march on Porte Drazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_HowLong == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_HowLong == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_WarLoss_HowLong == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == true || RiziaDLCIsolated.Turn10_WarLoss_HowLong == true || RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == true || RiziaDLCIsolated.Turn10_WarLoss_HowLong == true || RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_WarLoss_CanWeWin == true || RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal == true || RiziaDLCIsolated.Turn10_WarLoss_HowLong == true || RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_CanWeWin = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_CanWeWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_PeaceDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_HowLong = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_HowLong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_WarLoss_MarchPorteDrazon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In light of this information, I know what needs to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to discuss anything. The path forward is clear. I know what needs to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""With the current state of the war, no. But, times change, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Lucita Azaro**
> ""If we keep the war going, we might eventually have an opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""If we sue for peace, we will lose face in the eyes of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Taddeus Azaro**
> ""Yes, however, our enemy might seize one for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Taddeus Azaro**
> ""It is a risk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""I think we should keep this going as far as we can. The international ramifications would render Rizia crippled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[65]`
Mówca: **Taddeus Azaro**
> ""I disagree. This war can bring down Rizia along with Pales. Not to mention the resources we have already spent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Taddeus Azaro**
> ""We should sue for peace and look forward as a country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""Unless the situation changes drastically... potentially years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""In the end, we have more resources than Pales. We would win the war of attrition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[69]`
Mówca: **Taddeus Azaro**
> ""We would, yes. But at what cost?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
Mówca: **Taddeus Azaro**
> ""Highly unlikely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""But not impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""If they keep pushing into Montaklar, they will gain a foothold in Rizia's heartland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""I knew you would, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""What is your decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [War Loss Next Steps])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will approach Pales to sue for peace. I do not wish any more blood to be spilled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will continue fighting until the last drop of blood. We have to keep pushing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Pales_Loss_SueForPeace"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Outcome_NoPeace_KeepFighting = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_KeepFighting = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_KeepFighting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""A sound decision, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Very well. Peace it is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "General Azaro looked outside the window again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[83]`
Mówca: **Taddeus Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Taddeus Azaro**
> ""I am sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Taddeus Azaro**
> ""I am sorry for failing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[86]`
Mówca: **Taddeus Azaro**
> ""And you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Narrator**
> "He turned to Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[88]`
Mówca: **Narrator**
> "He turned his wheelchair toward me. Lucita helped him out of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Taddeus Azaro**
> ""Command me. What are your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[312]`
  - -> `[97]`

### Węzeł `[90]`
Mówca: **Narrator**
> "He knelt on the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus Azaro. In light of your failures and incompetence, you are hereby incarcerated for a time of my choosing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Disgraced == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[95]`
Mówca: **Narrator**
> "I noticed the marks on his uniform where his medals used to be. I sat at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taddeus Azaro, you will leave your post immediately and relinquish all of your duties. I am de-ranking you to Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will continue to serve the Crown as you have before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Deranked = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Deranked"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedTaddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Taddeus Azaro**
> ""Yes, my King. I accept my change in rank.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[100]`
Mówca: **Narrator**
> "She helped him back into his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Taddeus Azaro**
> ""Thank you for your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[102]`
Mówca: **Narrator**
> "They bowed to me and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Taddeus Azaro**
> ""My Liege. My King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro"); RemoveConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");
RemoveConversant("Lucita Azaro");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""For your own good, Your Majesty... Romus. Listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""For your own good, Your Majesty, listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""You’re about to cross a line you can’t uncross.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I resend that order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Lucita Azaro**
> ""Please reconsider. For our sake. Yours, mine, and...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita Azaro. You will share your fathers' fate. I am sentencing you to prison for your transgressions and insults against the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""For your own good, please reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[113]`

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""Thank you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Lucita's eyes widened in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[126]`
Mówca: **Taddeus Azaro**
> ""Please, Your Majesty! Just take me! I am the one who is responsible, not Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""WHAT?! Are you out of your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RomanceHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""After everything we've been through together?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[132]`
Mówca: **Taddeus Azaro**
> ""I will gladly serve my sentence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Taddeus Azaro**
> ""But don't lock up my daughter as well. She shouldn't pay for my mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Narrator**
> "The old man's eyes were teary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""I beg you. I will do anything...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I will spare Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "Signal to the guards to take them both away."]** — Mówca: **Player_Romus_Italic**
> "I signaled to the guards to take them both away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[138]`
Mówca: **Taddeus Azaro**
> ""No. No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""How dare you touch me? Do you know who I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Narrator**
> "The guards took them away and closed the door after them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[142]`
Mówca: **Narrator**
> "I was left all alone in the War Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[143]`
Mówca: **Taddeus Azaro**
> ""Thank you. Thank you, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Guards put the old man back in his wheelchair and took him out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[145]`
Mówca: **Narrator**
> "Lucita stared at me in disbelief as she left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "The door closed with a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested = true;
RiziaDLC.Lucita_Arrested = true;
RiziaDLC.Council_Security_Lucita = false;
RiziaDLC.Council_Security_Taddeus = false;
RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus = true; RiziaDLC.Relations_Lucita_Together = false;
RiziaDLC.Lucita_Married = false;
RiziaDLC.PoisonInvestigator_Lucita = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested");
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
RiziaDLCSupport.News_Turn10_RH_LucitaTaddeusArrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLC.Council_Security_Lucita"] = false;
Variable["RiziaDLC.Council_Security_Taddeus"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestLucitaAndTaddeus"] = true;
Variable["RiziaDLC.Relations_Lucita_Together"] = false;
Variable["RiziaDLC.Lucita_Married"] = false;
Variable["RiziaDLC.PoisonInvestigator_Lucita"] = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested");
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
Variable["RiziaDLCSupport.News_Turn10_RH_LucitaTaddeusArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""Goodbye, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[152]`
Mówca: **Lucita Azaro**
> ""Goodbye, You Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested = true;
RiziaDLC.Lucita_Arrested = false;
RiziaDLC.Council_Security_Taddeus = false; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus = true;
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
RiziaDLCSupport.News_Turn10_RH_TaddeusArrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Lucita_Arrested"] = false;
Variable["RiziaDLC.Council_Security_Taddeus"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus"] = true;
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
Variable["RiziaDLCSupport.News_Turn10_RH_TaddeusArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[156]`
Mówca: **Taddeus Azaro**
> ""Yes, my King. I thank you profusely for your forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Rizia_Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Faction_HouseAzaro_Lucita = false;
RiziaDLC.Faction_HouseAzaro_Taddeus = false;
RiziaDLC.Faction_HouseAzaro_Carlos = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Lucita"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Council", "Position_WarInternalSecurity","");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Council","Position_WarInternalSecurity","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[163]`
Mówca: **Lucita Azaro**
> ""What about our unborn son, for God's sake?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[164]`
Mówca: **Narrator**
> "She gestured to her belly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LucitaTitle = "Queen Consort and War and Security Councilor";)*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LucitaTitle"] ="Queen Consort and War and Security Councilor";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Lucita was sitting at the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Narrator**
> "When I entered the War Room, General Carlos Azaro was standing next to the window looking out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[183]`
Mówca: **Narrator**
> "The hollow look on his face suggested he hadn't slept. His eyes stayed fixed on the world beyond the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Carlos Robles Azaro**
> ""There's news from the frontline, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Carlos Robles Azaro**
> ""Pales still stands despite our attacks on their heartland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Carlos Robles Azaro**
> ""The Palesian army has pushed us back from the border into the Pales Administrative District.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Carlos Robles Azaro**
> ""Once we exhausted our troops, they managed to push us back, retaking Arces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Carlos Robles Azaro**
> ""We've lost Terador and Fort Ales. The frontline is broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Carlos Robles Azaro**
> ""We are holding them at the frontline on an equal footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Carlos Robles Azaro**
> ""They do not seem to be currently advancing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Carlos Robles Azaro**
> ""But our operation... has failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Narrator**
> "His words sank deep into my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[26]`
  - -> `[200]`
  - -> `[199]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where were *you* when we were losing this war, General?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it weren't for the incompetency of the Azaro military command, we'd be celebrating our victory over Pales right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Carlos Robles Azaro**
> ""No, Your Majesty. It is all my fault. I will shoulder the blame, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[205]`
Mówca: **Carlos Robles Azaro**
> ""Regardless, if I may, I suggest we discuss next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Carlos Robles Azaro**
> ""That's generous of you to say, Your Majesty. But we all know this failure rests on my shoulders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Carlos Robles Azaro**
> ""Please don't blame Lucita, Your Majesty. This is entirely on me, not her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Carlos Robles Azaro**
> ""I know, Your Majesty. It is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[218]`
Mówca: **Carlos Robles Azaro**
> ""I know, Your Majesty. This is entirely my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[225]`
Mówca: **Carlos Robles Azaro**
> ""Given the current state of the war, no. That said, the tide of war can turn, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Carlos Robles Azaro**
> ""If we stay the course, an opportunity might present itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[227]`
Mówca: **Carlos Robles Azaro**
> ""However, our enemy might seize one for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Carlos Robles Azaro**
> ""Either way, it's a risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Carlos Robles Azaro**
> ""Hard to say. If we sue for peace, we stand to lose face in the eyes of the world, rendering us crippled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[233]`
Mówca: **Carlos Robles Azaro**
> ""Prolonging the conflict might delay that, but our resources are limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Carlos Robles Azaro**
> ""Maybe for the short term, but our resources are not infinite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[238]`
Mówca: **Carlos Robles Azaro**
> ""Yes, however, our enemy might seize one for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Carlos Robles Azaro**
> ""It is a risk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Carlos Robles Azaro**
> ""Unless the situation changes drastically... potentially years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Carlos Robles Azaro**
> ""At the end of the day, we have more resources than Pales and would win a war of attrition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[248]`
Mówca: **Carlos Robles Azaro**
> ""But it would come at a cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[258]`
Mówca: **Carlos Robles Azaro**
> ""Yes, but it would come at a cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Carlos Robles Azaro**
> ""Unlikely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Carlos Robles Azaro**
> ""But not impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Carlos Robles Azaro**
> ""If they keep pushing into Montaklar, they will gain a foothold in Rizia's interior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Carlos Robles Azaro**
> ""Very good, Your Majesty. I knew you would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Carlos Robles Azaro**
> ""What have you decided?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Carlos Robles Azaro**
> ""As you wish, Your Majesty. Peace it shall be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[280]`
Mówca: **Carlos Robles Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Carlos Robles Azaro**
> ""All my life, I believed I was destined to serve a higher purpose -- that I was meant for greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[285]`
Mówca: **Carlos Robles Azaro**
> ""Once again, presenting the same news that Taddeus Azaro delivered to your father so many years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Carlos Robles Azaro**
> ""I fear I will be remembered not for my achievements, but for my failures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[11]`
  - -> `[9]`
  - -> `[370]`

### Węzeł `[287]`
Mówca: **Carlos Robles Azaro**
> ""Yet here I am. Defeated in battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Carlos Robles Azaro**
> ""I'm sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[292]`
Mówca: **Narrator**
> "He cast his eyes down in shame."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Carlos Robles Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Narrator**
> "He sat straighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[298]`
Mówca: **Carlos Robles Azaro**
> ""I'm sorry for failing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[299]`
Mówca: **Narrator**
> "He turned to Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Carlos Robles Azaro**
> ""And you as well, my cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Narrator**
> "He faced me again and took a deep bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Carlos Robles Azaro**
> ""Command me. What are your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[97]`

### Węzeł `[303]`
Mówca: **Carlos Robles Azaro**
> ""My Liege. My King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Narrator**
> "He took a deep bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Carlos Robles Azaro, you will leave your post immediately and relinquish all of your duties. I am de-ranking you to Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Carlos_Deranked = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Carlos_Deranked"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_DerankedCarlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Carlos Robles Azaro**
> ""Yes, my King. I acknowledge my change in my rank.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Narrator**
> "He lowered himself back into his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Narrator**
> "He bowed once more before my guards came in and wheeled him out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Carlos Robles Azaro**
> ""Yes, my King. I can't thank you enough for your forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Carlos Robles Azaro**
> ""I am grateful for your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Narrator**
> "He stood to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[331]`
Mówca: **Narrator**
> "He bowed to me and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[332]`
Mówca: **Narrator**
> "He turned his wheelchair toward me, then, with visible effort, he struggled as he lifted himself out of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Final_Sentence_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[97]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Final_Sentence_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[338]`
Mówca: **Narrator**
> "My guards put the old man back in his wheelchair and took him out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Narrator**
> "The door closed behind them with a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[343]`
Mówca: **Carlos Robles Azaro**
> ""Which means Rizia would face the possibility of being dragged down along with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[344]`
Mówca: **Narrator**
> "Carlos saluted, his hand trembling slightly in my presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[345]`
Mówca: **Narrator**
> "I gestured for him to join me at the table, and he promptly did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[349]`
Mówca: **Narrator**
> "Lucita was sitting at the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[357]`
Mówca: **Taddeus Azaro**
> ""I know, Your Majesty. This is entirely my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested = true;
RiziaDLC.Council_Security_Taddeus = false;
RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus = true; 
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
RiziaDLCSupport.News_Turn10_RH_TaddeusArrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLC.Council_Security_Taddeus"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_ArrestTaddeus"] = true;
EnableCodexEntry("Characters_Council_TaddeusAzaro_Arrested");
Variable["RiziaDLCSupport.News_Turn10_RH_TaddeusArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Faction_HouseAzaro_Taddeus = false;
RiziaDLC.Faction_HouseAzaro_Carlos = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Arrested == false && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[369]`
Mówca: **Carlos Robles Azaro**
> ""Yet here I am. The shameful last scion of a disgraced noble house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you admit it. The vaunted House of Azaro is nothing but a bunch of weaklings who don't deserve the Crown's mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_ParliamentProposesPeace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_ParliamentProposesPeace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_ParliamentProposesPeace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_ParliamentProposesPeace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_ParliamentProposesPeace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Lucita Azaro**
> ""The Prime Minister was rather irate that you vetoed the parliament's ceasefire bill. The government's now insisting we sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[381]`
Mówca: **Lucita Azaro**
> ""The Prime Minister and our new parliament have already expressed their wish to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Lucita Azaro**
> ""But they didn't fight the war. We did. And you're the one with the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_ParliamentProposesPeace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_ParliamentProposesPeace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_ParliamentProposesPeace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_ParliamentProposesPeace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_ParliamentProposesPeace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Carlos Robles Azaro**
> ""The Prime Minister was rather irate that you vetoed the parliament's ceasefire bill. The government wants us to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[390]`
Mówca: **Carlos Robles Azaro**
> ""The Prime Minister and our new parliament are urging us to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Carlos Robles Azaro**
> ""But you're the one with the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[395]`
Mówca: **Lucita Azaro**
> ""Or, well... there's nothing to discuss, actually. The new government has already decided that we're suing for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Narrator**
> "She made a face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Loss_SueForPeace = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Pales_Loss_SueForPeace"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Failed_SueForPeace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`
  - -> `[404]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[401]`
Mówca: **Carlos Robles Azaro**
> ""Ahem. Actually, there's nothing to discuss. The Prime Minister has already decided to sue for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dammit! We could've turned this around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So why even bother meeting with me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reasonable decision. I have no qualms with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Lucita Azaro**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Carlos Robles Azaro**
> ""We should have done so already. *I* should have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Lucita Azaro**
> ""Our troops fought this war for you. You deserve to know how it ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[415]`
Mówca: **Carlos Robles Azaro**
> ""Our army fought this war for you. You deserve to know how it ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Losing the War against the Grand-Duchy of Pales", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Losing the War against the Grand-Duchy of Pales","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
