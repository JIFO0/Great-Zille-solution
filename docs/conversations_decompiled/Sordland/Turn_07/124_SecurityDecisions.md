# Sordland/Turn07/SecurityDecisions

- **ID konwersacji:** `124`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/124_SecurityDecisions.md`
- **Liczba węzłów dialogowych:** 289
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Stopped_Investigations_NFP`
- `BaseGame.Turn05_SnO_Investigate_OldGuard`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn07_Investigate_Dropped`
- `BaseGame.Turn07_Investigate_OldGuard`
- `BaseGame.Turn07_Investigate_Oligarchs`
- `BaseGame.Turn07_Investigate_Opposition`
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGameSupport.Journal_Turn07_Results_DetainFrens`
- `BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP`
- `BaseGameSupport.Journal_Turn07_Results_DetainKesaro`
- `BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP`
- `BaseGameSupport.Journal_Turn07_Results_KillFrens`
- `BaseGameSupport.Journal_Turn07_Results_KillKesaro`
- `BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvestigateOldGuard`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[9]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 63

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[101]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- Węzeł `[114]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- Węzeł `[115]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- Węzeł `[116]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true; Variable["BaseGame.Turn07_Investi...`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- Węzeł `[118]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- Węzeł `[120]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- Węzeł `[128]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- *...oraz 55 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[9]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Karl Greiser was waiting for me by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Karl Greiser**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Karl Greiser**
> ""Can I have a moment of your time? I have something to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Of course. Let's go inside the office.""]** — Mówca: **Player**
> ""Of course. Let's go inside the office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""What is this about?""]** — Mówca: **Player**
> ""What is this about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Karl Greiser**
> ""It is classified information regarding our investigations, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Karl Greiser**
> ""It would be better if we talk inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Okay. Let's go inside the office.""]** — Mówca: **Player**
> ""Okay. Let's go inside the office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""Fine. But I don't have too much time to spare.""]** — Mówca: **Player**
> ""Fine. But I don't have too much time to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Karl Greiser**
> ""It will only take a moment, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "We entered my office. I sat behind my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[14]`
  - -> `[15]`
  - -> `[130]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""So... What is this about?""]** — Mówca: **Player**
> ""So... What is this about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I'm listening.""]** — Mówca: **Player**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Please have a seat, Karl.""]** — Mówca: **Player**
> ""Please have a seat, Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Karl Greiser**
> ""Thank you sir. But I'm fine. I will not take long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Karl Greiser**
> ""The Secret State Police has compiled a report regarding the active investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Karl Greiser**
> ""The Anti-Corruption Police has compiled a report regarding the active investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_OldGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_OldGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_OldGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_OldGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_OldGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_OldGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[36]`
Mówca: **Karl Greiser**
> ""We have been watching the Old Guard closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Old Guard seems to be involved in huge cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Karl Greiser**
> ""Most of the connections link to Chief Justice Hawker. Despite none of the members of assembly having direct ties with him, there seems to be a complex web of connections that is proving very difficult to track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there is an ongoing cooperation between the Young Sords organization and the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Karl Greiser**
> ""While this is huge, it is very difficult to create a solid case at the moment. And the Justices of the Court have immunity before the law. I don't see how we can take them down legally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
Mówca: **Karl Greiser**
> ""If we decide to make a case, we can arrest most of their connections in the Assembly. However, there is probably more to this than we had imagined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[85]`
  - -> `[86]`

### Węzeł `[45]`
Mówca: **Karl Greiser**
> ""While this is huge, it is very difficult to create a strong case at the moment. But the Justices of the Court no longer enjoys absolute immunity before the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Karl Greiser**
> ""If we decide to proceed, we can possibly take the Old Guard down in a legal way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Oligarchs seem to be involved in huge cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Karl Greiser**
> ""Even though so many links lead to Walter Tusk, we couldn't find a direct incriminating evidence yet. Currently, we're following a trail that leads to Estord, which will hopefully and finally get us Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connection between the increasing illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.Turn07_Detained_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.Turn07_Detained_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.Turn07_Detained_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[62]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but Marcel Koronti and Walter Tusk seems to have been involved in huge cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Karl Greiser**
> ""Currently, we're following a trail that leads to Estord, which might reveal some of their secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Oligarchs seem to be involved in huge cases of corruption and lobbying. And recently there was a major power shift to Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connection between the increasing illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
Mówca: **Karl Greiser**
> ""Even though so many links lead to Koronti, we couldn't find a direct incriminating evidence yet. Currently, we're following a trail that leads to Estord, which will hopefully and finally get us Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[69]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Oligarchs seem to be involved in huge cases of corruption and lobbying. And recently Tusk has increased his operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Karl Greiser**
> ""Even though so many links lead to Walter Tusk, we couldn't find a direct incriminating evidence yet. Currently, we're following a trail that leads to Estord, which will hopefully and finally get us Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connection between the increasing illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connections between the illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Karl Greiser**
> ""If we decide to proceed with our investigations, we can potentially undercover a lot more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[75]`
Mówca: **Karl Greiser**
> ""We have been watching the opposition closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Karl Greiser**
> ""We have been watching the opposition closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Karl Greiser**
> ""We have found suspicious irregularities and indirect connections to the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Karl Greiser**
> ""However, it is very difficult to make a legal argument against anything at this moment. Our investigation is still ongoing but the process is proving to very slow. Their tracks are very well covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[93]`
  - -> `[288]`
  - -> `[95]`

### Węzeł `[79]`
Mówca: **Karl Greiser**
> ""We have found suspicious irregularities and indirect connections to the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Karl Greiser**
> ""However, it is very difficult to make a legal argument against anything at this moment. Our investigation is still ongoing but the process is proving to very slow. Their tracks are very well covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[93]`
  - -> `[288]`
  - -> `[92]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[84]`
**[WYBÓR GRACZA: ""If the laws are not on our side, we'll find *another* way. That's why I have you.""]** — Mówca: **Player**
> ""If the laws are not on our side, we'll find *another* way. That's why I have you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""Proceed with the case. As long as we hurt them, the Court doesn't matter.""]** — Mówca: **Player**
> ""Proceed with the case. As long as we hurt them, the Court doesn't matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Let's drop the investigations for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigations for now. We don't need it anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""We don't need the *legal* way. I need Orso gone.""]** — Mówca: **Player**
> ""We don't need the *legal* way. I need Orso gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Proceed with a legal case. We can finally get them.""]** — Mówca: **Player**
> ""Proceed with a legal case. We can finally get them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Let's drop the investigations for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigations for now. We don't need it anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Continue your efforts and keep looking.""]** — Mówca: **Player**
> ""Continue your efforts and keep looking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Let's drop the investigation for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigation for now. We don't need it anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Let's drop the investigation for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigation for now. We don't need it anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""Continue your efforts and keep looking." [Investigate Opposition]"]** — Mówca: **Player**
> ""Continue your efforts and keep looking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""We don't need a *legal* case to end them, Karl. That's why I have you.""]** — Mówca: **Player**
> ""We don't need a *legal* case to end them, Karl. That's why I have you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Let's drop the investigation for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigation for now. We don't need it anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[96]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[105]`
  - -> `[104]`

### Węzeł `[97]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[98]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[108]`

### Węzeł `[99]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[100]`
Mówca: **Karl Greiser**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[102]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Keep your eyes open. I don't want your focus to be centered at one target.""]** — Mówca: **Player**
> ""Keep your eyes open. I don't want your focus to be centered at one target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""It's time we shift our focus on another faction.""]** — Mówca: **Player**
> ""It's time we shift our focus elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""]** — Mówca: **Player**
> ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""But for now, just proceed with the case, Karl. We don't want unnecessary attention.""]** — Mówca: **Player**
> ""But for now, just proceed with the case, Karl. We don't want unnecessary attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I want Orso gone. For good.""]** — Mówca: **Player**
> ""I want Orso gone. For good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I thought I was clear before. Why isn't Orso *gone*?""]** — Mówca: **Player**
> ""I thought I was clear before. Why isn't Orso *gone*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Karl Greiser**
> ""It will happen soon, sir. It was difficult to organize the force with the Old Guard having ears everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[113]`
Mówca: **Karl Greiser**
> ""I understand. I'll see to it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker = true;
BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true;
Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Dropped = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""]** — Mówca: **Player**
> ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Dropped = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[121]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[119]`
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Keep your eyes open. I don't want your focus to be centered at one target.""]** — Mówca: **Player**
> ""Keep your eyes open. I don't want your focus to be centered at one target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It's time we shift our focus to another faction.""]** — Mówca: **Player**
> ""It's time we shift our focus elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[140]`

### Węzeł `[124]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""It's time we shift our focus on another faction.""]** — Mówca: **Player**
> ""It's time we shift our focus elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[162]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""]** — Mówca: **Player**
> ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[126]`
  - -> `[125]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Dropped = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Keep your eyes open. I don't want your focus to be centered at one target.""]** — Mówca: **Player**
> ""Keep your eyes open. I don't want your focus to be centered at one target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Karl Greiser**
> ""Not yet sir, but soon. He will be gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""I hope there is an update about Orso, Karl.""]** — Mówca: **Player**
> ""I hope there is an update about Orso, Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[135]`
Mówca: **Karl Greiser**
> ""I wanted to tell you about something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Start investigating the Oligarchs.""]** — Mówca: **Player**
> ""Start investigating the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Start investigating the opposition.""]** — Mówca: **Player**
> ""Start investigating the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""Start investigating the opposition.""]** — Mówca: **Player**
> ""Start investigating the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Start investigating the Old Guard.""]** — Mówca: **Player**
> ""Start investigating the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[144]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[145]`
  - -> `[285]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""But for now, just continue your investigations, Karl. We don't want unnecessary attention.""]** — Mówca: **Player**
> ""But for now, just continue your investigations, Karl. We don't want unnecessary attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""I want Ricter gone. For good.""]** — Mówca: **Player**
> ""I want Ricter gone. For good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Karl Greiser**
> ""For good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[149]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I just want him detained and sent to Antel Rock.""]** — Mówca: **Player**
> ""I just want him detained and sent to Antel Rock.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[150]`
Mówca: **Karl Greiser**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Turn07_Emergency_Detained_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""We have already arrested Mr. Ricter. This should send a message to the others.""]** — Mówca: **Player**
> ""We have already arrested Mr. Ricter. This should send a message to the others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Karl Greiser**
> ""It already did, sir. But the opposition is furious about the decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
**[WYBÓR GRACZA: ""Keep watching them. Make sure nobody does something stupid.""]** — Mówca: **Player**
> ""Keep watching them. Make sure nobody does something stupid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""Arrest them if they create problems.""]** — Mówca: **Player**
> ""Arrest them if they create problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Karl Greiser**
> ""We'll do our best, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter = true;
BaseGame.Turn07_Investigate_Opposition = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Start investigating the Oligarchs.""]** — Mówca: **Player**
> ""Start investigating the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""Start investigating the Old Guard.""]** — Mówca: **Player**
> ""Start investigating the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[166]`
Mówca: **Karl Greiser**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter = true;
BaseGame.Turn07_Investigate_Opposition = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[168]`
Mówca: **Karl Greiser**
> ""I understand. I'll see to it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Karl Greiser**
> ""I'll give you an update soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[171]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[172]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[173]`
Mówca: **Karl Greiser**
> ""I will also send you the detailed report of our previous findings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Karl Greiser**
> ""Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[175]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I'll be waiting.""]** — Mówca: **Player**
> ""I'll be waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Thank you Karl.""]** — Mówca: **Player**
> ""Thank you Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Narrator**
> "He bowed his head and left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[178]`
**[WYBÓR GRACZA: ""I want Kibener gone. For good.""]** — Mówca: **Player**
> ""I want Kibener gone. For good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Karl Greiser**
> ""For good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[180]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""I just want him detained and sent to Antel Rock.""]** — Mówca: **Player**
> ""I just want him detained and sent to Antel Rock.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_KesaroKibener = true;
BaseGame.Turn07_Investigate_Opposition = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener = true;
BaseGame.Turn07_Investigate_Opposition = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_DetainKesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_KillKesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_KillKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_KillFrens = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_KillFrens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_DetainFrens = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainFrens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvestigateOldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker = true;
BaseGame.Turn07_Investigate_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] = true;
Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP  = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"]  = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Stopped_Investigations_NFP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
**[WYBÓR GRACZA: ""The oligarch connection sounds promising. Keep chasing that lead." [Investigate Oligarchs]"]** — Mówca: **Player**
> ""The oligarch connection sounds promising. Keep chasing that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
