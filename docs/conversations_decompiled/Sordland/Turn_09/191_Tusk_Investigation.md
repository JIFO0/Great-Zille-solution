# Sordland/Turn09/Tusk Investigation

- **ID konwersacji:** `191`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/191_Tusk_Investigation.md`
- **Liczba węzłów dialogowych:** 135
- **Liczba wyborów gracza:** 19

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Leader_Oligarchs_WalterTusk`
- `BaseGame.Oligarchs_Extradited`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_MikailAven`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn07_Fled_WalterTusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence`
- `BaseGame.Turn09_A_MarcelArrested`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_Oligarchs_KorontiLeader`
- `BaseGame.Leader_Oligarchs_WalterTusk`
- `BaseGame.SecretState_LucianKnowsSSPKills`
- `BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk`
- `BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed`
- `BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia`
- `BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence`
- `BaseGameSupport.Journal_Turn09_Investigations_KillTusk`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialTusk`
- `BaseGameSupport.Journal_Turn09_Investigations_TrialTuskInAbsentia`
- `BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[188] Sordland/Turn09/A_CampaignAndInvestigations** (../Turn_09/188_A_CampaignAndInvestigations.md), Węzeł `[68]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 17

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[22]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] = true; Variable["BaseGame.Secret...`
- Węzeł `[33]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed"] = true;`
- Węzeł `[34]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] = true;`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] = true;`
- Węzeł `[41]` (Paskal Beniwoll): `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence"] = true;`
- Węzeł `[106]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_KillTusk"] = true;`
- Węzeł `[107]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed"] = true;`
- Węzeł `[108]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence"] = true;`
- *...oraz 9 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `188` (*Sordland/Turn09/A_CampaignAndInvestigations*), Węzeł `[68]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""The Secret State Police have looked further into Walter Tusk's foreign ties, and found some very unsettling information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[20]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[21]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""One of his corporation's subsidiaries is directly involved in smuggling and selling Rumburgian KA-74s within Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""As you wish. Mr. Tusk shall remain a free man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""The Anti-Corruption Police have looked further into Walter Tusk's foreign ties, and found some very unsettling information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""As you wish. I'll inform the relevant authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Yes. I hope he hangs.""]** — Mówca: **Player**
> ""Yes. I hope he hangs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[27]`
  - -> `[30]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""I suppose it's my only choice.""]** — Mówca: **Player**
> ""I suppose it's my only choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""No. I can use that information as leverage to make him do what I want.""]** — Mówca: **Player**
> ""No. I can use that information as leverage to make him do what I want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Arrest? I want him killed!""]** — Mówca: **Player**
> ""Arrest? I want him killed!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = true; BaseGame.SecretState_LucianKnowsSSPKills = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] = true;
Variable["BaseGame.SecretState_LucianKnowsSSPKills"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian's eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""That traitor!""]** — Mówca: **Player**
> ""That traitor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Prison's too good for him.""]** — Mówca: **Player**
> ""Prison's too good for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""What can we do? He's already in jail.""]** — Mówca: **Player**
> ""What can we do? He's already in jail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""That's it? Everyone already knows he'd do anything for a ren.""]** — Mówca: **Player**
> ""That's it? Everyone already knows he'd do anything for a ren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""What can we do? He's still in Arcasia.""]** — Mówca: **Player**
> ""What can we do? He's still in Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Lucian's eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskBribeRevealed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""If you say so, sir. I'll give the orders to the new police chief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""If you say so, sir. I'll give the orders to Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_TuskTrialAbsentia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendTuskSentence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""No, it's a waste of time.""]** — Mówca: **Player**
> ""No, it's a waste of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""You didn't hear this from me, sir, but 'accidents' happen in prison all the time. Gang wars, cafeteria scuffles... you get the idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I suppose it's my only choice.""]** — Mówca: **Player**
> ""I suppose it's my only choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""No, it's a waste of time.""]** — Mówca: **Player**
> ""No, it's a waste of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""No, that'd attract too much suspicion. I'd rather just let him rot in there.""]** — Mówca: **Player**
> ""No, that'd attract too much suspicion. I'd rather just let him rot in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""It'd certainly be unfortunate if Tusk were to be the victim of such an accident. Unfortunate, yet unavoidable.""]** — Mówca: **Player**
> ""It'd certainly be unfortunate if Tusk were to be the victim of such an accident. Unfortunate, yet unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""It may be possible to trial him in absentia. Even if Arcasia didn't extradite him after that, it would set an example for other businessmen considering similar deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""This is treason on the highest level. There's no doubt Tusk must be punished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""I believe he called it a gesture of goodwill.""]** — Mówca: **Player**
> ""I believe he called it a gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""*If* you did such a thing, you should never have proceeded with this investigation. Once Mrs. Morgna hears about the bribe, she's never going to let it go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Sir, did you accept a bribe from Mr. Tusk at the beginning of your term?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[50]`
  - -> `[66]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""Yes, given the constraints of the Anti-Corruption Police, we could only succeed in extending his sentence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""I'll make some phone calls, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Lucian nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Lucian nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We may have... come to a place of mutual understanding.""]** — Mówca: **Player**
> ""We may have... come to a place of mutual understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""As you wish. Mr. Tusk's sentence will remain the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""You should've called this investigation off when you had the chance. Once Mrs. Morgna hears about the bribe, she's never going to let it go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""As you wish. I'll inform the relevant authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""As you wish. Mr. Tusk will remain in exile in Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""As you wish. I'll make the necessary calls immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""What? No.""]** — Mówca: **Player**
> ""What? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucian nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Lucian looked at me questioningly for a second, then nodded smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""However, Mrs. Morgna's force also found out something else...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Would you like to go forth with that, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[42]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""Shall we ask him? And order Tusk's arrest the minute he touches Sordish soil?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[122]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""Would you like to go forth with his arrest and trial, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Oligarchs_Extradited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Oligarchs_Extradited == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Oligarchs_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Oligarchs_Extradited == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Oligarchs_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""I'm sure President Walker would have no qualms about extraditing him. He offered such a proposal during his visit, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Good thing we had him extradited, then.""]** — Mówca: **Player**
> ""Good thing we had him extradited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Would you like to go forth with that, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[45]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_KillTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_KillTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TuskBribeRevealed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_ExtendTuskSentence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialTuskInAbsentia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialTuskInAbsentia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_TrialTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_TrialTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leader_Oligarchs_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leader_Oligarchs_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Leader_Oligarchs_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Leader_Oligarchs_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07_Fled_MarcelKoronti == false && BaseGame.Turn09_A_MarcelArrested == false && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.HeartOfSordland_Nationalization < 3 && BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07_Fled_MarcelKoronti == false && BaseGame.Turn09_A_MarcelArrested == false && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.HeartOfSordland_Nationalization < 3 && BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Killed_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false  and  Variable["BaseGame.Turn09_A_MarcelArrested"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.HeartOfSordland_Nationalization"] < 3  and  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Killed_MarcelKoronti == false && BaseGame.Turn07_Fled_MarcelKoronti == false && BaseGame.Turn09_A_MarcelArrested == false && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.HeartOfSordland_Nationalization < 3 && BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Killed_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false  and  Variable["BaseGame.Turn09_A_MarcelArrested"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.HeartOfSordland_Nationalization"] < 3  and  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_ExtendMarcelSentence"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MikailAven == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk = true; BaseGame.SecretState_LucianKnowsSSPKills = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] = true;
Variable["BaseGame.SecretState_LucianKnowsSSPKills"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Investigations_KillTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Investigations_KillTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Yes. I hope he suffers in jail.""]** — Mówca: **Player**
> ""Yes. I hope he suffers in jail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Fled_WalterTusk == true && BaseGame.Oligarchs_Extradited == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_WalterTusk"] == true  and  Variable["BaseGame.Oligarchs_Extradited"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""It may be possible to trial him in absentia. Even if Arcasia didn't extradite him after that, it would set an example for other businessmen considering similar deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_MarcelKoronti");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_MarcelKoronti");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_EdithAgnoc");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_EdithAgnoc");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Factions", "Position_Oligarch", "Faction_Oligarchs_MikailAven");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Factions","Position_Oligarch","Faction_Oligarchs_MikailAven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_KorontiLeader = true;
BaseGame.Leader_Oligarchs_WalterTusk = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_KorontiLeader"] = true;
Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Leader_Oligarchs_WalterTusk = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Leader_Oligarchs_WalterTusk"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
