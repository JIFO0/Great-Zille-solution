# Sordland/Turn10/AloneWithTarquinSoll

- **ID konwersacji:** `223`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/223_AloneWithTarquinSoll.md`
- **Liczba węzłów dialogowych:** 429
- **Liczba wyborów gracza:** 102

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[48]** Tarquin Soll

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.ChiefJustice_OrsoHawker`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.Enable_RumburgIncident`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Policy_Welfare_HealthPrivatization`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Veto_Loophole`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn07_PTV_SollConfrontation`
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_Action_Court_OldGuardReplaced`
- `BaseGame.Turn08_Action_Court_Shuffled`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn09_SollTrial_Acquitted`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGame.TarquinSoll_AidsWar`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[56]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 2

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.TarquinSoll_AidsWar`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[297]` (Paskal Beniwoll): `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- Węzeł `[369]` (Paskal Beniwoll): `Variable["BaseGame.TarquinSoll_AidsWar"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `222` (*Sordland/Turn10/Personal_FCAnricaDerby*), Węzeł `[56]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Tarquin Soll was already seated on the leather sofa, casting his hawk-like gaze out onto the field. He did not react when I entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To what do we owe this pleasure, Colonel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[5]`
Mówca: **Tarquin Soll**
> ""Mr. Rayne. I didn't hear you come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is good to see you here, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We seem to be crossing each other's paths on the oddest of occasions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you going to pretend I'm not here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_PTV_SollConfrontation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_PTV_SollConfrontation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_PTV_SollConfrontation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_PTV_SollConfrontation == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_PTV_SollConfrontation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Tarquin Soll leaned on his cane and turned his head to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He smiled at me and gestured at the vacant spot beside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Tarquin Soll**
> ""Please. Join me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Tarquin Soll leaned on his cane and turned his head to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[16]`
Mówca: **Tarquin Soll**
> ""Movies and football. Well, a pair of strivers like us have earned the right to a little leisure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Decision_TrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I approached the sofa and sat next to him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[21]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after that farce of a trial that you put me through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[22]`
Mówca: **Tarquin Soll**
> ""I suppose that demands some respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[35]`
  - -> `[26]`
  - -> `[47]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't need your respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You cannot escape justice forever, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Acquitted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Acquitted == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Acquitted == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That was in the past. I believe we can put it behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[32]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after the way our last meeting ended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[33]`
Mówca: **Tarquin Soll**
> ""You have my respect. Albeit begrudgingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[31]`
  - -> `[35]`
  - -> `[26]`
  - -> `[47]`

### Węzeł `[34]`
Mówca: **Tarquin Soll**
> ""Your support for FC Anrica and Sordish sports is heartening. Nothing brings the country together like watching their football team win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[75]`
  - -> `[74]`
  - -> `[96]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's very kind of you, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you. I know he had the utmost respect and admiration for you, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[37]`
Mówca: **Tarquin Soll**
> ""The Courts have already acquitted me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[38]`
Mówca: **Tarquin Soll**
> ""I thought you would have known by now how Sordish politics work on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[83]`
  - -> `[85]`

### Węzeł `[39]`
Mówca: **Tarquin Soll**
> ""Your resolve to punish me is pitiable, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn11_Election_AssassinationHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[43]`
Mówca: **Tarquin Soll**
> ""My condolences on the death of your driver. I heard he was a good one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[44]`
  - -> `[51]`
  - -> `[45]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""His name was Serge. And he wasn't just good; he was the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everyone involved in the attack will pay for what they've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Tarquin Soll**
> ""You talk of injustice only when the result doesn't suit your agenda. How righteous of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`
  - -> `[85]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't come here to face you, Mr. Soll. I came here for FC Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[52]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Tarquin Soll**
> ""I didn't have the opportunity to extend my support to you after that dastardly attack against Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[57]`
Mówca: **Tarquin Soll**
> ""You have my deepest sympathies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[45]`
  - -> `[58]`
  - -> `[139]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for your sympathy. It truly means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[59]`
Mówca: **Tarquin Soll**
> ""I must say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[60]`
Mówca: **Tarquin Soll**
> ""I didn't expect you to show up today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Tarquin Soll**
> ""I have already been acquitted in the eyes and hearts of the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[65]`
Mówca: **Tarquin Soll**
> ""It is heartening to see that you're a supporter of FC Anrica and Sordish sports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[69]`
  - -> `[72]`
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why? Did you think a few armed men would stop me from going out in public again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I could say the same for you, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't know you were a football fan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn11_Election_AssassinationHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought you returned to your island. What are you still doing around here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Especially when everyone's favorite former president is in the stands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't have taken you for a football fan, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""For a retired man, you certainly get around a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[76]`
Mówca: **Tarquin Soll**
> ""You knew I'd be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Narrator**
> "The corner of his mouth curled up mirthlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Tarquin Soll**
> ""Tell me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[79]`
Mówca: **Tarquin Soll**
> ""Can't an old man still travel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Tarquin Soll**
> ""You know I couldn't miss this historic moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[81]`
Mówca: **Tarquin Soll**
> ""I was referring to your *busy* schedule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[82]`
Mówca: **Narrator**
> "The corner of his mouth curled up mirthlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You can't suppress everything with military power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was naive enough to think justice could be served under the system you'd built. I won't make the same mistake again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You think you're above everything, don't you? Including the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't speak to me about the courts. We both know that you owe the result to your cronies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you really going to take me for a fool and tell me that the Court is just and lawful?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Tarquin Soll**
> ""It doesn't suit you to be so full of spite, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "The corner of his mouth curled up mirthlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[90]`
Mówca: **Tarquin Soll**
> ""My system is nothing but just. It keeps power-mad tyrants from throwing innocent old men in prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
Mówca: **Tarquin Soll**
> ""If that's what you think of them, why did you order a trial at all? Did you somehow believe your narrow view of 'justice' would prevail?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Tarquin Soll**
> ""I had such high hopes for you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[93]`
Mówca: **Narrator**
> "He heaved a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Narrator**
> "He had a barely visible smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[95]`
Mówca: **Tarquin Soll**
> ""I would never miss this historic occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's great to see you here, sir. Our conversation at the cinema in Erlory was far too brief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[100]`
Mówca: **Tarquin Soll**
> ""Is everything faring well with your new Constitution, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`
  - -> `[137]`
  - -> `[138]`

### Węzeł `[101]`
Mówca: **Narrator**
> "He gestured to the FC Anrica pin on his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[117]`
  - -> `[116]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[105]`
Mówca: **Tarquin Soll**
> ""Is everything faring well after the defeat of your reforms, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems that you and I are on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[126]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Be honest. Does it ever bother you that I'm one of the owners of FC Anrica?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Tarquin Soll**
> ""Hah!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Tarquin Soll**
> ""You must have been doing something right for our boys to progress this far. I wish I could say the same for your leadership of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure the team will give it their all, knowing that you and I are watching them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm happy to see you so excited, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[118]`
Mówca: **Narrator**
> "He gestured to the FC Anrica pin on his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[124]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems that once again, you and I are on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As a partner of the club, I must say I am humbled to see that pin on your jacket.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure the team will give it their all, knowing that you and I are watching.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm happy to see you so excited, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As a partner of the club, I must say I am humbled to see that pin on your jacket.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Tarquin Soll**
> ""Ah, yes. I always found it unbecoming for sitting presidents to engage in such schemes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[128]`
Mówca: **Tarquin Soll**
> ""We can find a more suitable occasion for a deeper conversation, if you so desire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Narrator**
> "He had a barely visible smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[130]`
Mówca: **Tarquin Soll**
> ""But today is for football, not politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, you won. No need to rub that in my face, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I may have not changed the constitution, but I've done my best to reform Sordland in my own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's nothing for you to worry about, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll admit. The term could have gone better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you still sore because you lost?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now that we've put the 1929 Constitution behind us, things are only going to get better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's nothing for you to worry about, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll admit. I'm starting to doubt the effectiveness of some of my reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me the truth, Colonel Soll. You knew about the attack, didn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you don't mind, Colonel, I'd prefer to watch the match in silence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough about me. Tell me more about how you and Lileas Graf conspired to throw Sordland into instability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[142]`
Mówca: **Tarquin Soll**
> ""Don't be a fool, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[143]`
Mówca: **Tarquin Soll**
> ""We cannot reverse time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[144]`
Mówca: **Tarquin Soll**
> ""You continued on the path that Ewald Alphonso started, obliterating our economy and throwing the nation into a quagmire of poverty and depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[145]`
Mówca: **Tarquin Soll**
> ""I will decide what I worry about, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[146]`
Mówca: **Tarquin Soll**
> ""So I have seen. But at what expense?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[150]`
Mówca: **Tarquin Soll**
> ""So I have seen. And the results have been impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Tarquin Soll**
> ""You assume too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[153]`
Mówca: **Tarquin Soll**
> ""Such childish games don't interest me. I am interested in results from this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[154]`
Mówca: **Tarquin Soll**
> ""But I can't help but feel troubled about the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Tarquin Soll**
> ""You couldn't stop Alphonso's mess, and you left the nation in a recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[156]`
Mówca: **Tarquin Soll**
> ""And you are turning Sordland into a puppet for superpowers to play with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[157]`
Mówca: **Tarquin Soll**
> ""I never would have thought I'd live to see Sordland invaded by imperialists. Especially at the invitation of a Sordish president...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Tarquin Soll**
> ""I never would have thought I'd live to see Sordland infected by Malenyevism. Especially at the invitation of a Sordish president...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[168]`
Mówca: **Tarquin Soll**
> ""Despite all my concerns, your achievements for this country have been commendable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[169]`
Mówca: **Tarquin Soll**
> ""Furthermore, you chose to defund our national defense in a time when Eastern Merkopa is waiting to explode in our faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[170]`
Mówca: **Tarquin Soll**
> ""I don't mean to overstep. But I can't sit still while your *reforms* are killing what's left of our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
Mówca: **Tarquin Soll**
> ""You are running the country as if it's a business -- destroying free Sordish welfare, and with it, the life of the average Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[175]`
Mówca: **Tarquin Soll**
> ""Furthermore, you sold the country and yourself to a few corrupt businessmen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Ally == true && BaseGame.EconomicDirection_Nationalization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Ally == true && BaseGame.EconomicDirection_Nationalization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Ally"] == true  and  Variable["BaseGame.EconomicDirection_Nationalization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Ally == true && BaseGame.EconomicDirection_Nationalization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Ally"] == true  and  Variable["BaseGame.EconomicDirection_Nationalization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[179]`
Mówca: **Tarquin Soll**
> ""You have strayed from the values of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[180]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about death and misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[237]`

### Węzeł `[181]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about disparity and exploitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[196]`

### Węzeł `[182]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about disparity and regression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[197]`

### Węzeł `[183]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. Don't you dare go too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[199]`

### Węzeł `[184]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about exploitation and abuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[194]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Faction_Oligarchs_Ally == true ||BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Faction_Oligarchs_Ally == true ||BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Faction_Oligarchs_Ally == true ||BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Tarquin Soll**
> ""Apart from your willingness to ignore the Sordish public's wishes, of course...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[189]`
Mówca: **Tarquin Soll**
> ""I hope your heart is in the right place, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[280]`
  - -> `[281]`
  - -> `[283]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My path is my own to tread. You have no influence over my presidency, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GenericOptions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[190]`
  - -> `[192]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your concerns, sir, but I beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't come here to listen to your criticism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No superpower can match the amount of abuse you've already inflicted on this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry but I'm done with the warmongering and paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're one to talk. I've been too busy fixing your messes to make the progress Sordland needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Regression? How many years did your reign set Sordland back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I seriously don't believe I have strayed from the USP's values. All I wanted to do was follow in your footsteps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't need to hear your threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame.Reform_Law_Veto_Loophole == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Policy_Order_SecretStatePolice == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame.Reform_Law_Veto_Loophole == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame.Reform_Law_Veto_Loophole == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Policy_Order_SecretStatePolice == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[209]`
Mówca: **Tarquin Soll**
> ""Be careful, Mr. Rayne. You are pulling all of Eastern Merkopa into a bloody conflict with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[210]`
Mówca: **Tarquin Soll**
> ""Don't get me wrong. I may have reacted the same way in your stead. But I would have made sure the Sordish military was well and ready for such a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[214]`
Mówca: **Tarquin Soll**
> ""To say nothing of the bloody conflict with Rumburg that you insist on pulling all of Eastern Merkopa into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[215]`
Mówca: **Tarquin Soll**
> ""Despite all the warning signs, you adamantly followed your own pigheaded vision for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[216]`
Mówca: **Tarquin Soll**
> ""Say what you will. Deep down inside, you know I'm right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[302]`
  - -> `[301]`
  - -> `[293]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[223]`
Mówca: **Tarquin Soll**
> ""I truly hope you are ready for what's coming. For all of our sakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[247]`

### Węzeł `[224]`
Mówca: **Tarquin Soll**
> ""It didn't even take four years for your mind to become poisoned with power fantasies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`
  - -> `[228]`
  - -> `[252]`

### Węzeł `[225]`
Mówca: **Tarquin Soll**
> ""You believe you are special, don't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's rich, coming from you of all people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am not you, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everything I did was for the development of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say, your lack of faith in Sordland is disturbing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[230]`
Mówca: **Narrator**
> "His brow furrowed as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Tarquin Soll**
> ""You cannot simply throw around such accusations, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am doing everything I can to prevent a conflict with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you so scared, Colonel? If the Rums come, we will show them hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's the path that Queen Beatrice chose, not me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are ready to crush Rumburg's armies once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't want it to come to this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I always thought you'd understand me. It's sad to see you be so combative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Tarquin Soll**
> ""Oh, but I understand you, Anton. That is precisely the reason for my stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[254]`
Mówca: **Tarquin Soll**
> ""You alone know what's best for Sordland, don't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[255]`
Mówca: **Tarquin Soll**
> ""I have nothing but faith in this country and its fine military. But both are nothing without a strong leader to guide them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Tarquin Soll**
> ""I rebuilt this Republic with my own sweat and blood. I will not see it collapse again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[356]`
  - -> `[355]`

### Węzeł `[257]`
Mówca: **Tarquin Soll**
> ""It's too late for regrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Tarquin Soll**
> ""The only future is victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[359]`
  - -> `[358]`

### Węzeł `[259]`
Mówca: **Tarquin Soll**
> ""You must try harder before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[260]`
Mówca: **Tarquin Soll**
> ""Is everything faring well after your emergency, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[286]`
  - -> `[263]`
  - -> `[261]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's nothing for you to worry about, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not everyone has been on board with it. But I'm still confident it's the right course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. I am starting to doubt that it was the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[267]`
Mówca: **Tarquin Soll**
> ""How is everything faring with your emergency, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[262]`
  - -> `[286]`
  - -> `[263]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[271]`
Mówca: **Tarquin Soll**
> ""Unless they crack under the pressure, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Tarquin Soll**
> ""The only correct side, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Tarquin Soll: ""Tell me...""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's not for you to question, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My heart belongs to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know it is, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope yours is as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[284]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[285]`
Mówca: **Tarquin Soll**
> ""The idea that I would wield such power from my little island -- let alone that I would use it to do harm to a sitting president -- is preposterous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everything's running as smoothly as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Tarquin Soll**
> ""That's very good to hear. I hope it stays that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My emergency? I thought it was *your* idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Tarquin Soll**
> ""Ha! Are you saying you're not responsible for declaring it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[291]`
Mówca: **Tarquin Soll**
> ""We must look to the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`
  - -> `[296]`
  - -> `[298]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: OptionsWSoll)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[61]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [OptionsWSoll])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The future is bright.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll drink to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your wisdom rings true as always, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[299]`
Mówca: **Tarquin Soll**
> ""Speaking of drinks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Tarquin Soll**
> ""I wonder if your predecessor got too inebriated to remember today's match. Where is he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? I think I need a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're talking past me, not to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Tarquin Soll**
> ""You don't know how to listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[376]`
  - -> `[373]`

### Węzeł `[305]`
Mówca: **Tarquin Soll**
> ""Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[312]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[313]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[320]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Tarquin Soll**
> ""All tyrants get what is coming to them in the end. You included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[292]`

### Węzeł `[322]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Tarquin Soll**
> ""The system I built still works. Sooner or later, you will face justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[292]`

### Węzeł `[324]`
Mówca: **Tarquin Soll**
> ""All incompetent leaders get what's coming to them in the end. Yourself included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[372]`
  - -> `[378]`

### Węzeł `[325]`
Mówca: **Tarquin Soll**
> ""You who claim to champion justice will soon get a taste of your own medicine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[372]`
  - -> `[378]`

### Węzeł `[326]`
Mówca: **Tarquin Soll**
> ""You still have a lot to learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[376]`
  - -> `[373]`
  - -> `[375]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_Shuffled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_Shuffled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_OldGuardReplaced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_OldGuardReplaced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OrsoHawker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OrsoHawker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OrsoHawker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[336]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after the stunt you pulled with the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Tarquin Soll**
> ""Putting good, experienced officials out of work, in the name of so-called justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Tarquin Soll**
> ""Still, you have my respect. Albeit begrudgingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[26]`
  - -> `[47]`
  - -> `[339]`
  - -> `[347]`
  - -> `[343]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Court now works the way it is supposed to. True justice will be served in Sordland for the first time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[340]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after the stunt you pulled with Chief Justice Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Tarquin Soll**
> ""Between you and me, I never actually liked the man. He reminded me of a dog, helpless without its master.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Tarquin Soll**
> ""I suppose you have my respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[26]`
  - -> `[47]`
  - -> `[339]`
  - -> `[347]`
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I had nothing to do with Hawker's removal. I only appointed a new justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true) && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true) && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true) && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Whether you respect it or not, you will be next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Narrator**
> "His hand curled into a fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Tarquin Soll**
> ""I wouldn't get my hopes up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[353]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Tarquin Soll**
> ""Yes. Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If something will collapse, it will be Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And I will never let that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And I will make sure that it is achieved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We will give them hell, Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Tarquin Soll**
> ""Good. At least you have the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[362]`
  - -> `[364]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [OptionsWSoll])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know we have had our differences, to say the least. But I cannot argue with your brilliance on the battlefield. Would you consider offering your military guidance as we enter this conflict?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know we have had our differences, to say the least. But I cannot argue with your brilliance on the battlefield. If we do go to war, would you consider offering your guidance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[368]`
Mówca: **Tarquin Soll**
> ""If and when that fateful day comes, I will not stand idly by and watch my country fall. I will tell you that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.TarquinSoll_AidsWar = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.TarquinSoll_AidsWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[370]`
Mówca: **Tarquin Soll**
> ""You could certainly use the help after your ill-advised purge of the general staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your threats mean nothing to me, Mr. Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will not give in to your threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [OptionsWSoll])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[374]`
Mówca: **Narrator**
> "A sudden burst of cheering from the stadium made both of us look out the window. The players had begun walking out onto the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps I do. But what makes you think you should be the one to teach me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I respect you, Colonel. I still wish the feeling was mutual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm willing to listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Whatever you say, I respect you Colonel. I wish we had some understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[379]`
Mówca: **Tarquin Soll**
> ""Look, Mr. Rayne. It's starting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Narrator**
> "He pointed directly at a group of FC Anrica fans who stood up holding colored boards, creating a massive illustration of Tarquin Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Narrator**
> "Under the portrait, the bottom row of boards slowly revealed the words: "Welcome Home Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[383]`
  - -> `[386]`

### Węzeł `[382]`
Mówca: **Tarquin Soll**
> ""You made the mistake of your career imprisoning her, Mr. Rayne. That woman is one of the truest Sordish patriots I have ever met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I forgot that you were from Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[384]`
**[WYBÓR GRACZA: "Keep watching."]** — Mówca: **Player_Italic**
> "I kept watching the stadium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you're wondering, I didn't organize that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Tarquin Soll**
> ""Of course. It wouldn't have been genuine otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[390]`
Mówca: **Tarquin Soll**
> ""If it weren't for my name plastered everywhere in this city, I might have forgotten myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[391]`
Mówca: **Tarquin Soll**
> ""It's been some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Tarquin Soll: ""Tell me...""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[393]`
Mówca: **Tarquin Soll**
> ""As if plastering my name everywhere in this city wasn't enough. I suppose I'm flattered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[394]`
Mówca: **Tarquin Soll**
> ""To be quite precise, it wasn't my idea. It was a rare show of initiative from Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Narrator**
> "His face turned serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[399]`
Mówca: **Tarquin Soll**
> ""You made a grave mistake by removing the national identity of this country from its constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Tarquin Soll**
> ""With one pen stroke, you destroyed a unified Sordish identity that took centuries to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Narrator**
> "He locked eyes with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[402]`
Mówca: **Tarquin Soll**
> ""And for what? To appease a minority that shows no respect or gratitude towards this great county of ours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Tarquin Soll**
> ""Movies and football. Well, a retired man like me has earned the right to a little leisure. You, though...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[407]`
Mówca: **Tarquin Soll**
> ""You must be referring to Alphonso. Sordland couldn't get enough of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Narrator**
> "He chuckled lightly at his joke, then gestured to the FC Anrica pin on his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[124]`

### Węzeł `[409]`
Mówca: **Tarquin Soll**
> ""Ah, yes. I always found it unbecoming for sitting presidents to engage in such schemes. But you must have been doing something right for our boys to progress this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[410]`
Mówca: **Tarquin Soll**
> ""I'll be even more excited if they win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[411]`
Mówca: **Tarquin Soll**
> ""I don't watch all the games. But I do have a soft spot for these hometown heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[412]`
Mówca: **Tarquin Soll**
> ""But you must have been doing something right for our boys to progress this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[413]`
Mówca: **Tarquin Soll**
> ""When it comes to football, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[414]`
Mówca: **Tarquin Soll**
> ""Unless they crack under pressure, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[415]`
Mówca: **Tarquin Soll**
> ""I'll be more excited when our boys win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[416]`
Mówca: **Tarquin Soll**
> ""Every decision you make will be faced with dissent. You must not let yourself succumb to doubt because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Tarquin Soll**
> ""You are taking a risk going over the head of General Kruger, son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Tarquin Soll**
> ""Despite the state of our economy and my concerns, your achievements for this country have still been commendable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[428]`
Mówca: **Tarquin Soll**
> ""But you should ask your new band of international allies instead. I'm sure they care just as much about Sordland's fate as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
