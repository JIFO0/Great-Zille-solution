# Sordland/Turn09/Old Guard Investivation

- **ID konwersacji:** `192`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/192_Old_Guard_Investivation.md`
- **Liczba węzłów dialogowych:** 112
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_OrsoHawker`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas`
- `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso`
- `BaseGameSupport.Codex_Characters_Cabinet_LileasGraf`
- `BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone`
- `BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators`
- `BaseGameSupport.Journal_Turn09_Investigations_FireLileas`
- `BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialLileas`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialOrso`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[65]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 27

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[54]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas"] = true;`
- Węzeł `[56]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_FireLileas"] = true;`
- Węzeł `[74]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- Węzeł `[75]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true; Variable["BaseGameS...`
- Węzeł `[76]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- Węzeł `[77]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true; Variable["BaseGameS...`
- Węzeł `[78]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- Węzeł `[79]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true; Variable["BaseGameS...`
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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `188` (*Sordland/Turn09/A_CampaignAndInvestigations*), Węzeł `[65]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""I want their heads, Lucian.""]** — Mówca: **Player**
> ""I want their heads, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna's task force suspected Old Guard members of multiple cases of corruption and lobbying. But when they looked deeper into it, they found something truly shocking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""The Old Guard led by Hawker and Graf -- with the suspected approval of Tarquin Soll -- organized the assassination of Bernard Circas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""The main co-conspirators were Orso Hawker and Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""You're joking.""]** — Mówca: **Player**
> ""You're joking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""What? But why?""]** — Mówca: **Player**
> ""What? But why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I always thought they were involved.""]** — Mówca: **Player**
> ""I always thought they were involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""Since you took office, their goal was to protect Soll and his constitution. They needed an event extreme enough to distract you from making reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""Of course, they didn't succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[97]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Who was involved in this?""]** — Mówca: **Player**
> ""Who was involved in this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""That may be complicated. Because we found out about another piece of information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""Of course, when that didn't work, they had other ways of impeding you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[97]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""And they succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[97]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""As you may recall, Karl Greiser hinted at a 'complex web of connections' surrounding the Old Guard as well as multiple cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""However, he kept stalling whenever I pressed him for details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""As did his successor after he was fired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Eventually, I received this bulletin from the desk of the Secret State Police. Supposedly a list of leads they'd uncovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "He handed me a sheet of paper. On it was a short list of names."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""Look at the first letter of each name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "I went down the list. It spelled "NICE TRY GALADE.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Cute.""]** — Mówca: **Player**
> ""Cute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""So they're playing with us?""]** — Mówca: **Player**
> ""So they're playing with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""What is the meaning of this?""]** — Mówca: **Player**
> ""What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""Lileas and the Old Guard undoubtedly have something to hide. But the Secret State Police is their instrument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Lucian smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""Frankly, sir, you asking them to investigate their own bosses was a waste of both your time and mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""I should have advised you not to pursue this. Sorry to have failed you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[45]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""It was my fault, not yours.""]** — Mówca: **Player**
> ""It was my fault, not yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""I realize that now. I'm sorry.""]** — Mówca: **Player**
> ""I realize that now. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Can't we still fire Lileas?""]** — Mówca: **Player**
> ""Can't we still fire Lileas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Apology accepted.""]** — Mówca: **Player**
> ""Apology accepted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""If you wish, you could still remove Lileas from her cabinet position for encouraging the police's insubordination. But it wouldn't make you very popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Ms. Graf has caused me nothing but grief. Let's get rid of her.""]** — Mówca: **Player**
> ""Ms. Graf has caused me nothing but grief. Let's get rid of her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""You're right. Can't be rocking the boat this close to the election.""]** — Mówca: **Player**
> ""You're right. Can't be rocking the boat this close to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Lucian swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""It may take some time to fire her without harming your election chances. But I'll get the process started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_AttemptToFireLileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""And then there are the dozens of Assembly members and thousands of government officials who may have been aware of the assassination plot and helped cover it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_FireLileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_FireLileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""The main conspirator was Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""And then there are the dozens of Assembly members and thousands of government officials who may have been aware of the assassination plot and helped cover it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[108]`
  - -> `[64]`
  - -> `[105]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We will get rid of every single one that was involved in this plot.""]** — Mówca: **Player**
> ""We will get rid of every single one that was involved in this plot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""It would cause ripples if we got rid of everyone at once. We will start with Orso and Lileas.""]** — Mówca: **Player**
> ""It would cause ripples if we got rid of everyone at once. We will start with Orso and Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""]** — Mówca: **Player**
> ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Orso Hawker should be our primary target. He is too dangerous keep around.""]** — Mówca: **Player**
> ""Orso Hawker should be our primary target. He is too dangerous keep around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We will get rid of every single one that was involved in this plot.""]** — Mówca: **Player**
> ""We will get rid of every single one that was involved in this plot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""]** — Mówca: **Player**
> ""Lileas Graf will be our primary target. It's time she left politics. Once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""That could end up being the largest government purge in Sordland's history. Are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Yes. The Old Guard has been a taint on my government for far too long.""]** — Mówca: **Player**
> ""Yes. The Old Guard has been a taint on my administration for far too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""I meant, let's get rid of all the main conspirators we can touch. No need to shake up the entire government so close to the election.""]** — Mówca: **Player**
> ""I meant, let's get rid of all the main conspirators we can touch. No need to shake up the entire government so close to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""That could end up being the largest government purge in Sordland's history. Are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Yes. The Old Guard has been a taint on my government for far too long.""]** — Mówca: **Player**
> ""Yes. The Old Guard has been a taint on my administration for far too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""I meant, let's get rid of the main conspirator we can touch. No need to shake up the entire government so close to the election.""]** — Mówca: **Player**
> ""I meant, let's get rid of the main conspirator we can touch. No need to shake up the entire government so close to the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialOrso = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialOrso = true;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialOrso"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeMainConspirators"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialOrso = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialLileas = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_LileasGraf = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialLileas"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_LileasGraf"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge = true;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge = true;
BaseGameSupport.Codex_Organisations_Governmental_ACP = false;
BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_ACP_InvestigatedOldGuard_PurgeEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_PurgeGovernmentOfficials"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""All right, sir. I'll get to work on it when we return to Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Further evidence suggests that they orchestrated the destruction of the Holsord State University archives. We found out their motive was to destroy the employee records and proof regarding all the informants they secretly employed at the university from 1930 until 1953.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""To imagine that this is the extent of our knowledge on their actions is deeply troubling. The chaos they created and the loss of life occurred because of them is treachery at the highest level and must not go unpunished in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[6]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Are there any other things they have done?""]** — Mówca: **Player**
> ""Are there any other things they have done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""Who is the main culprit?""]** — Mówca: **Player**
> ""Who is the main culprit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""We must act against this treachery.""]** — Mówca: **Player**
> ""We must act against this treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_InteriorMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_InteriorMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.YoungSords_Kill_OrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It would cause ripples if we got rid of everyone at once. We will start with Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
