# Sordland/Turn07/PlansHub

- **ID konwersacji:** `121`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/121_PlansHub.md`
- **Liczba węzłów dialogowych:** 122
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_B`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_C`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_D`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_E`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso`
- `BaseGame.Turn07_Results_Decision_NewJusticesList`
- `BaseGame.Turn07_Results_Decision_RallyAgainstSC`
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn07_Results_Focus_Campaign`
- `BaseGame.Turn07_Results_Focus_Economy`
- `BaseGame.Turn07_Results_Focus_Party`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_B`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_C`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_D`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_E`
- `BaseGameSupport.Journal_Turn07_Results_CampaignFocus`
- `BaseGameSupport.Journal_Turn07_Results_EconomyFocus`
- `BaseGameSupport.Journal_Turn07_Results_NewJusticesList`
- `BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAgainstOrso`
- `BaseGameSupport.Journal_Turn07_Results_PartyFocus`
- `BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC`
- `BaseGameSupport.Journal_Turn07_Results_TrySoll`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[45]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 14

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn07_Results_Focus_Economy`
- `BaseGameSupport.Journal_Turn07_Results_EconomyFocus`
- `BaseGameSupport.Journal_Turn07_Results_TrySoll`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[18]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Focus_Party"] = true;`
- Węzeł `[19]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Focus_Campaign"] = true; Variable["BaseGame.Public_Opinion"] = ...`
- Węzeł `[20]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Focus_Economy"] = true;`
- Węzeł `[71]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Decision_RallyAgainstSC"] = true; Variable["BaseGameIsolated.Tu...`
- Węzeł `[72]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] = true; Variable["BaseGameIsolated.Turn07_Co...`
- Węzeł `[73]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso"] = true; Variable["BaseGameIsolat...`
- Węzeł `[74]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Results_Decision_NewJusticesList"] = true; Variable["BaseGameIsolated.T...`
- Węzeł `[114]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Results_CampaignFocus"] = true;`
- *...oraz 6 innych węzłów ze skryptami.*

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
  - -> `[14]`
  - -> `[4]`
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `117` (*Sordland/Turn07/PlayerHub*), Węzeł `[45]`

### Węzeł `[3]`
**[WYBÓR GRACZA: ""We must rally the people against the Supreme Court. That would put pressure on their investigation.""]** — Mówca: **Player**
> ""We must rally the people against the Supreme Court. That would put pressure on their investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < 10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < 10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""The public opinion is concerning. We must focus on campaigning for the next election already.""]** — Mówca: **Player**
> ""The public opinion is concerning. We must focus on campaigning for the next election already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""We must focus on raising our public opinion and start campaigning for the next election already.""]** — Mówca: **Player**
> ""We must focus on raising our public opinion and start campaigning for the next election already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy < 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy < 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""The state of our economy is very concerning. It must be our focus to achieve quick economic development.""]** — Mówca: **Player**
> ""The state of our economy is very concerning. It must be our focus to achieve quick economic development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Economy will be our number one priority until the end of our term. We will aim to boost it further.""]** — Mówca: **Player**
> ""Economy will be our number one priority until the end of our term. We will aim to boost it further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""It's time to focus on changing our party as a whole. I will add a new vision in our manifesto.""]** — Mówca: **Player**
> ""It's time to focus on changing our party as a whole. I will add a new vision in our manifesto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "The cabinet looked uneasy. Lileas spoke with a concerned look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Lucian nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Symon nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Party = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Focus_Party"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Campaign = true;
BaseGame.Public_Opinion += 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Focus_Campaign"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[34]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Focus_Economy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Focus_Economy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Lileas Graf**
> ""I'm sorry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[106]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Sordland needs to become an economic powerhouse.""]** — Mówca: **Player**
> ""Sordland needs to become an economic powerhouse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We can't get elected if we do not improve the economy.""]** — Mówca: **Player**
> ""We can't get elected if we do not improve the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""We should focus on eliminating poverty and homelessness.""]** — Mówca: **Player**
> ""We should focus on eliminating poverty and homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""We must convince the public that the emergency was useful.""]** — Mówca: **Player**
> ""We must convince the public that the emergency was useful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""We should put more focus on our constitutional victory.""]** — Mówca: **Player**
> ""We should put more focus on our constitutional victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""We should blame the opposition for the failure of the reforms.""]** — Mówca: **Player**
> ""We should blame the opposition for the failure of the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""We can't get elected if we do not convince the public in some way.""]** — Mówca: **Player**
> ""We can't get elected if we do not convince the public in some way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "There was a mixed response, but the majority seemed to be in agreement with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Almost everybody seemed to be in agreement with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""It's time USP shifts away from Sollism.""]** — Mówca: **Player**
> ""It's time USP shifts away from Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""As I said, I will reform our party platform.""]** — Mówca: **Player**
> ""As I said, I will reform our party platform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Lileas Graf**
> ""I see. And the party leadership will agree with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""You see, I am the current chairman Mrs. Graf...""]** — Mówca: **Player**
> ""You see, I am the current chairman Mrs. Graf...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Do you not agree with that, Mrs. Graf?""]** — Mówca: **Player**
> ""Do you not agree with that, Mrs. Graf?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I just wanted to announce this earlier, so you are aware. I won't change my mind.""]** — Mówca: **Player**
> ""I just wanted to announce this earlier, so you are aware. I won't change my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""If there are no comments, let's move on with the meeting.""]** — Mówca: **Player**
> ""If there are no comments, let's move on with the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SecondPlan)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[43]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Lileas Graf**
> ""You'll learn about my thoughts if you bring your suggestions to the leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> ""You are right about that. However, the party does not belong to you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[48]`
Mówca: **Lileas Graf**
> ""That was the extent of my comments. We can move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[49]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Thank you for your comments.""]** — Mówca: **Player**
> ""Thank you for your comments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Frankly, I don't care what you think. It has already been decided.""]** — Mówca: **Player**
> ""Frankly, I don't care what you think. It has already been decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""If there are no comments, I want to talk about another plan.""]** — Mówca: **Player**
> ""If there are no comments, I want to talk about another plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[61]`
  - -> `[69]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Now that we can, we will start an investigation on Tarquin Soll. It was long overdue.""]** — Mówca: **Player**
> ""Now that we can, we will start an investigation on Tarquin Soll. It was long overdue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""We can finally impeach Justices. Let's organize the Assembly against the Chief Justice.""]** — Mówca: **Player**
> ""We can finally impeach Justices. Let's organize the Assembly against the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
**[WYBÓR GRACZA: ""With the new laws, I can reshuffle the Supreme Court. I want a list of names.""]** — Mówca: **Player**
> ""With the new laws, I can reshuffle the Supreme Court. I want a list of names.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""On a second thought, let's just move on with the meeting before it gets too late.""]** — Mówca: **Player**
> ""On a second thought, let's just move on with the meeting before it gets too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""Yes, sir. I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_RallyAgainstSC = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_RallyAgainstSC"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_C = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_NewJusticesList = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_E = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_NewJusticesList"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Yes, sir. I'll start working on it immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Narrator**
> "Iosef narrowed his eyes and stared at me. I couldn't help but feel uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Lileas Graf**
> ""I have no words. And nobody else is going to react?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Lileas stood up and took a long look at the ministers around the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[92]`
Mówca: **Lileas Graf**
> ""I cannot believe this administration comes from the United Sordland Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""A lot of people suffered under Soll. Justice must be served.""]** — Mówca: **Player**
> ""A lot of people suffered under Soll. Justice must be served.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Thank you for your comments but I have already decided.""]** — Mówca: **Player**
> ""Thank you for your comments but I have already decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist >= 8)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Sollist"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Sollist >= 8))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Sollist"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Lileas Graf**
> ""I thought you respected Sollism. It seems I was completely wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""He will not sit idly against your attacks, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[100]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Let's just move on, Mrs. Graf.""]** — Mówca: **Player**
> ""Let's just move on, Mrs. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""He is an old man, Mrs. Graf. What is he going to do?""]** — Mówca: **Player**
> ""He is an old man, Mrs. Graf. What is he going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "She did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[121]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""I asked you something.""]** — Mówca: **Player**
> ""I asked you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lileas Graf**
> ""You are right, Mr. President. *As always*. Let's just move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""I'll start making the necessary arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You've heard me.""]** — Mówca: **Player**
> ""You've heard me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[107]`
Mówca: **Narrator**
> "I turned to the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucian put on his glasses to inspect the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[109]`
Mówca: **Narrator**
> "He wrote on the document and put down his pen after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[110]`
Mówca: **Narrator**
> "He wrote on the document and put down his pen after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Lucian put on his glasses to inspect the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[112]`
Mówca: **Narrator**
> "She sighed deeply. I looked at the cabinet to measure their reactions. No one said anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Then I looked at everyone else to measure their reactions. No one said anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_CampaignFocus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_CampaignFocus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_PartyFocus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_PartyFocus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_EconomyFocus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_EconomyFocus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAgainstOrso = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAgainstOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_NewJusticesList = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_NewJusticesList"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Results_TrySoll = true;
BaseGame.Public_Opinion -= 5;
BaseGame.Bludish_Opinion += 5;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_TrySoll"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I looked at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
