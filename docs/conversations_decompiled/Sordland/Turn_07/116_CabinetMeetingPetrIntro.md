# Sordland/Turn07/CabinetMeetingPetrIntro

- **ID konwersacji:** `116`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/116_CabinetMeetingPetrIntro.md`
- **Liczba węzłów dialogowych:** 291
- **Liczba wyborów gracza:** 19

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Faction_Oligarchs_Destroyed`
- `BaseGame.Faction_Oligarchs_Enemy`
- `BaseGame.Faction_USP_AgainstProposal`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_Default`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_AssemblyVote_LostBy1`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reform_Heron_Convinced`
- `BaseGame.Reform_Reform_Isabel_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Reform_VoteCount_NFP`
- `BaseGame.Reform_VoteCount_PFJP_RictersWing`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn04_PSnW_Education_Progressive`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 0

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `117` (*Sordland/Turn07/PlayerHub*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Narrator**
> "When we entered the room, Petr was speaking to the cabinet members who were already seated around the table. As soon as they noticed me, they all stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "Gesture at their seats."]** — Mówca: **Player_Italic**
> "I gestured at their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Petr Vectern**
> ""...And here's our president!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Petr turned towards me. Everybody except him took their seats. He stood right next to my chair in the middle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Good day everybody. Please have a seat.""]** — Mówca: **Player**
> ""Good day everybody. Please have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Ladies and gentlemen.""]** — Mówca: **Player**
> ""Ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "Say nothing and watch the room."]** — Mówca: **Player_Italic**
> "I looked around at my cabinet members. They were staring at me and waiting for me to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Petr stood right next to my seat in the middle. He turned to me and gave a wave of his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""...And here's our president!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
Mówca: **Narrator**
> "He held out my chair for me to sit down and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Narrator**
> "He held out my chair for me to sit down and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "When I sat down, everybody immediately took their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""Ladies and gentlemen, we are here to discuss our current status and plan the remaining of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""I know that some of you have had your concerns about our style of governance so far. There will be a time to speak up about these in the meeting today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""But I must also thank you all for your hard work so far. We are very lucky to have a team like this. All of you have been invaluable to this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""We have worked long and hard but we couldn't reform the Sordish Constitution...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == false || BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == false || BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  or  Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == false || BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  or  Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malenyevist >= 6 || BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malenyevist >= 6 || BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Malenyevist"] >= 6  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malenyevist >= 6 || BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Malenyevist"] >= 6  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Faction_Oligarchs_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Faction_Oligarchs_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] == true  or  Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Faction_Oligarchs_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Enemy"] == true  or  Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Nia and Ciara grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Lileas grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Ciara grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Gus grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""Having said that... Now we have reached a critical point of our term. We are nearing the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""We have successfully made changes to the Sordish Constitution. This is a historic accomplishment. Without this team, it couldn't have been possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""Sadly and for reasons outside of our control, Sordland plunged into violent terror at the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""Today, the state of emergency still continues. Despite making some of our jobs harder, it has also helped stabilize our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Let Petr talk."]** — Mówca: **Player_Italic**
> "Petr walked to his seat and spoke, still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""What's on our agenda?""]** — Mówca: **Player**
> ""What's on our agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""We'll be discussing our current status and planning the remainder of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Petr walked to his seat but didn't sit down. He took a look at the ministers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""Now that Mr. President is here, we can begin the meeting. I know that some of you have had your concerns about our style of governance so far. There will be a time to speak up about these in the meeting today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""Sadly and for reasons outside of our control, Sordland had plunged into violent terror in the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""As we all know, the state of emergency is no longer in place. In a plot against President Rayne, it was revoked prematurely by the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""Do not make a mistake. This plot affects all of us. An attack against President Rayne is an attack against our whole administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""It is against the United Sordland Party. And ultimately, against the people of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""As we all know, the beginning of our term saw an extraordinary period of violence that led us to a state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Petr Vectern**
> ""Mr. President was brave enough to act swiftly, and thus we have successfully restored stability in a time of uncertainty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""As we all know, the state of emergency that was declared against the chaos in the beginning of our term, is no longer in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Petr Vectern**
> ""Mr. President was brave enough to act swiftly and revoked his decree when the situation was stabilized. However, the same Justices who agreed to the decree are now trying to use it against him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""Do not make a mistake. This is a clear plot that affects all of us. An attack against President Rayne is an attack against our whole administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[74]`
Mówca: **Narrator**
> "The cabinet members started looking around the room. Petr glanced at Nia and Ciara, who were sitting next to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[89]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Even though some people, even within our own administration, had hoped to see us fail in the Court... We did succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "Look at Nia."]** — Mówca: **Player_Italic**
> "Nia squinted at Petr and frowned. She then noticed me and immediately averted her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "Look at Petr."]** — Mówca: **Player_Italic**
> "Petr held his eyes on the two women, an enigmatic smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "Watch the room."]** — Mówca: **Player_Italic**
> "The ministers looked concerned and kept watching Petr speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[82]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Unfortunately, some people within our team also worked towards this goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "The cabinet members started looking at each other and eventually set their eyes on Nia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[81]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "Look at Nia."]** — Mówca: **Player_Italic**
> "Nia squinted at Petr and frowned. She then noticed me and immediately averted her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "Look at Petr."]** — Mówca: **Player_Italic**
> "Petr stared at Nia and narrowed his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "Look at Ciara."]** — Mówca: **Player_Italic**
> "Ciara glanced sideways at Petr and me, avoiding eye contact."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""The new Constitution has brought us one step closer to the Sordish dream. We should be proud for having strengthened our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Threshold_Default == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Nia raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Nia Morgna**
> ""Mr. Vice President. I wouldn't go as far to claim that we have *strengthened our democracy*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Nia raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""Mr. Vice President. With all due respect, I wouldn't go as far to claim that we have *strengthened* anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "The room fell silent for a few seconds. Petr broke the silence with a cough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Petr Vectern**
> ""You do not need to feel proud, Mrs. Morgna. Please let me finish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[127]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""We know where the real power is gathered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Everyone in the room turned to look at Nia. Ciara put her hand on Nia's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[114]`
Mówca: **Petr Vectern**
> ""But the past is past. We must now look towards our future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Another stain on our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""The deep state has acted once more. Our proposal had gathered 166 votes, but was unlawfully rejected. The very parliament we control has stabbed us in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Petr Vectern**
> ""We have reasons to believe that this was an organized effort which Mr. Soll himself was implicated in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""Our organization was flawed. Our party was not united. The very parliament we control has denied us the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[122]`
Mówca: **Narrator**
> "The cabinet members started looking at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[123]`
Mówca: **Narrator**
> "He paused and looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[124]`
Mówca: **Petr Vectern**
> ""We are investigating and analyzing our faults. We will be taking measures accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Narrator**
> "He glanced at both Lucian and me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""Our success with these changes has brought with it great support. Our party --which was divided at the beginning of our term-- is finally coming together once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Italic**
> "Nia did not respond. I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""]** — Mówca: **Player**
> ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Nia Morgna**
> ""I'm sorry, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Petr Vectern**
> ""So... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Petr Vectern**
> ""Ah yes. Our success...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[132]`
Mówca: **Petr Vectern**
> ""Our party still remains divided. In order to look at the future, we may need to make some changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Petr Vectern**
> ""On the other hand, the opposition is exploiting our failure to reform. The latest polls show a steep increase in the opposition's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""I must thank Mr. President for being brave enough to act so swiftly. And thank you all for your understanding our predicament at this difficult time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Iosef was nodding in agreement while Nia and Ciara whispered to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Narrator**
> "Nia raised an eyebrow and stared at Petr mockingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[137]`
Mówca: **Narrator**
> "He paused and looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[138]`
Mówca: **Narrator**
> "He paused and looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""The emergency decree also gives the president the power to enact laws that are otherwise not possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Petr Vectern**
> ""This will open the way for our long-awaited reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He glanced at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "Nod in agreement."]** — Mówca: **Player_Italic**
> "I nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "Shake your head in disagreement."]** — Mówca: **Player_Italic**
> "I shook my head in disagreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""We are all responsible for the actions of this administration. Today, we need to be united more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 20)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 20)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion >= 20))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""So... Let's start the meeting with a brief look at some reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Narrator**
> "He fumbled with the stack of papers in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[150]`
Mówca: **Petr Vectern**
> ""We will do whatever it takes to come out of this stronger and serve our country better. If need be, we'll make major changes in our party structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Lileas raised an eyebrow and stared at Petr with crossed arms. Nia raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Italic**
> "Nia did not respond. I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[153]`
Mówca: **Nia Morgna**
> ""Mr. Vice President. I warned you about the path you took, but you did not listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[154]`
Mówca: **Narrator**
> "The room fell silent for a few seconds. Petr broke the silence with a cough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Petr Vectern**
> ""So... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[156]`
Mówca: **Petr Vectern**
> ""And how did you help us inside the Court, Mrs. Morgna? Please let me finish before we start arguing about the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`
  - -> `[152]`

### Węzeł `[157]`
Mówca: **Nia Morgna**
> ""Mr. Hawker is very adamant about the impeachment, and Mr. President has given him a good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Everyone in the room was looking at Nia. Ciara, who sat next to her, put her hand on Nia's shoulder and slightly pulled her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Mrs. Morgna. As a member of the Supreme Court yourself, you are supposed to have this case dismissed.""]** — Mówca: **Player**
> ""Mrs. Morgna. As a member of the Supreme Court yourself, you are supposed to have this case dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""]** — Mówca: **Player**
> ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Nia Morgna**
> ""Understood, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[162]`
Mówca: **Nia Morgna**
> ""I ca- Yes. I am doing my best, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Petr Vectern**
> ""You have our complete trust, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Petr smiled at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[165]`
Mówca: **Petr Vectern**
> ""Maybe we should take a look at our current situation first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[166]`
Mówca: **Petr Vectern**
> ""According to the latest polls, we have seen an increase in our popularity. The public opinion is most positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[182]`
Mówca: **Petr Vectern**
> ""According to the latest polls, people seem to be content about our administration. The public opinion has not changed much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[192]`
Mówca: **Petr Vectern**
> ""According to the latest polls, we have seen a decrease in our popularity. The public opinion has shrunk since we took office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion >= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[199]`
Mówca: **Petr Vectern**
> ""Despite the recent troubles, we have seen an increase in our popularity in general. The public opinion is most positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[200]`
Mówca: **Petr Vectern**
> ""Despite the recent troubles, people seem to be content about our administration. The public opinion has not changed much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[201]`
Mówca: **Petr Vectern**
> ""With the latest developments, we have seen a decrease in our popularity. The public opinion has shrunk since we took office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[202]`
Mówca: **Petr Vectern**
> ""According to the latest polls, we have seen an enormous decrease in our popularity. The public opinion about our party is at an all-time low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Petr Vectern**
> ""With the latest developments, we have seen an enormous decrease in our popularity. The public opinion about our party is at an all-time low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[204]`
Mówca: **Petr Vectern**
> ""Citizens are most concerned about the state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

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
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Petr Vectern**
> ""Our historic constitutional changes did not reflect well on our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[218]`
Mówca: **Narrator**
> "He took out a piece of paper from the stack and inspected it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[219]`
Mówca: **Petr Vectern**
> ""The biggest factor for the people's contentment is the state of our economy. We have stopped the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[229]`
Mówca: **Narrator**
> "He took out a piece of paper from the stack and inspected it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[230]`
Mówca: **Petr Vectern**
> ""One of the most important factors for the people's contentment is the state of our economy. We have greatly slowed down the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[231]`
Mówca: **Petr Vectern**
> ""The biggest concern of the people is the state of our economy. We are still plagued by the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Petr Vectern**
> ""The biggest concern of the people is the state of our economy. We are slowly slipping into a depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Petr Vectern**
> ""It is only a matter of time until the people will be hit further. This will have dire consequences for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[234]`
Mówca: **Petr Vectern**
> ""Despite everything, the state of our economy is in very good shape. We have stopped the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[235]`
Mówca: **Petr Vectern**
> ""Despite everything, we have managed to greatly slow down the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
Mówca: **Petr Vectern**
> ""A major concern of the people is the state of our economy. We are still plagued by the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Petr Vectern**
> ""This will have dire consequences for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[238]`
Mówca: **Petr Vectern**
> ""A major concern of the people is the state of our economy. We are slowly slipping into a depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""If everything goes well, it is a matter of time that people will feel its results. Our economy is not looking too bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Petr Vectern**
> ""I must thank Mr. Holl for his great work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Petr Vectern**
> ""This is the time to give the best we can. For this administration and for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Symon nodded with a dimpled smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Petr Vectern**
> ""We mustn't lose hope and give it our best. Sordland needs us more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Narrator**
> "Petr turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Petr Vectern**
> ""I'll give the word to the President now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[246]`
Mówca: **Petr Vectern**
> ""If everything goes well, it is a matter of time that people will feel its results. Our economy is looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""Our success with these changes has brought with it great support. Our party --which was divided at the beginning of our term-- is finally coming together once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_VoteCount_NFP <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_VoteCount_NFP <= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_VoteCount_NFP"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_VoteCount_NFP <= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_VoteCount_NFP"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_VoteCount_PFJP_RictersWing"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_VoteCount_PFJP_RictersWing"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important == true && BaseGame.Bill_Turn01_CampaignFinance_Signed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important == true && BaseGame.Bill_Turn01_CampaignFinance_Signed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Family_Important"] == true  and  Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Family_Important == true && BaseGame.Bill_Turn01_CampaignFinance_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Family_Important"] == true  and  Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[266]`
Mówca: **Petr Vectern**
> ""Gloria and the conservative wing of the party didn't back us up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[267]`
Mówca: **Petr Vectern**
> ""Some party centrists have opposed us due to our decision to veto the campaign finance bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[268]`
Mówca: **Petr Vectern**
> ""Albin and the reformist wing didn't vote for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[269]`
Mówca: **Petr Vectern**
> ""Frens Ricter and the PFJP left us hanging on the assembly floor. They voted nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""Kesaro Kibener and the National Front MP's didn't like the proposal and voted against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[271]`
Mówca: **Petr Vectern**
> ""The Lotherberg group led a massive lobbying effort against us in the Assembly which caused us to lose many votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[272]`
Mówca: **Petr Vectern**
> ""Lucian and I have begun investigating who let us down at the vote when we needed them the most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Isabel_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Isabel_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Isabel_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Isabel_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[279]`
Mówca: **Petr Vectern**
> ""Me and Lucian know the culprits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[280]`
Mówca: **Petr Vectern**
> ""Isabel and the other justices lenient to her legal opinion did not support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[281]`
Mówca: **Petr Vectern**
> ""Heron and the other centrists voted against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[285]`
Mówca: **Petr Vectern**
> ""We lost most of our support after editing the proposal to include changes to Articles 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_AgainstProposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_AgainstProposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_AgainstProposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_AgainstProposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_AgainstProposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Petr Vectern**
> ""Despite doing our best, we didn't get enough support from the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[290]`
Mówca: **Petr Vectern**
> ""The higher-ups of the USP has abandoned their support for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
