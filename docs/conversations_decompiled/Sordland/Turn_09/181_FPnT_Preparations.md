# Sordland/Turn09/FPnT_Preparations

- **ID konwersacji:** `181`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/181_FPnT_Preparations.md`
- **Liczba węzłów dialogowych:** 528
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Arcasia_AcceptedVisit`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn08_HarsherSecurity_Signed`
- `BaseGame.Bill_Turn08_TobaccoTax_Signed`
- `BaseGame.Bill_Turn09_AlcoholTax_Signed`
- `BaseGame.Bill_Turn09_LighterSecurity_Signed`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Economy`
- `BaseGame.Enable_RumburgIncident`
- `BaseGame.Hegel_PutInAGoodWordWithMalenyev`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_EducationUnification`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Law_MinorityRights`
- `BaseGame.Policy_Law_Prostitution_Illegal`
- `BaseGame.Policy_Law_ReligiousHarmony`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Policy_Law_WomenLiberation`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_FreedomAct`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecurityAct`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.UnitedContana_AcceptedVisit`
- `BaseGame.UnitedContana_MeetingOffer`
- `BaseGame.Valgsland_Alliance`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Arcasia_AcceptedVisit`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExpandedHumanRights`
- `BaseGame.Situation_Law_LimitedHumanRights`
- `BaseGame.Situation_Law_SomeHumanRights`
- `BaseGame.Situation_Order_CrimeWave`
- `BaseGame.Situation_Order_LittleSecurityPowers`
- `BaseGame.Situation_Order_OrganisedCrime`
- `BaseGame.Situation_Order_OrganisedCrimeContained`
- `BaseGame.Situation_Order_ReductionOfCrimeCommunities`
- `BaseGame.Situation_Order_SomeSecurityPowers`
- `BaseGame.Situation_Order_WideRangingSecurityPowers`
- `BaseGame.Situation_Welfare_IncreasedDepression`
- `BaseGame.SuperpowerVisit_ExtravagantWelcome`
- `BaseGame.SuperpowerVisit_MilitaryWelcome`
- `BaseGame.SuperpowerVisit_PlainWelcome`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.UnitedContana_AcceptedVisit`
- `BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft`
- `BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept`
- `BaseGameSupport.Journal_Turn09_Preparations_UCAccept`
- `BaseGameSupport.News_Turn09_HP_SordishPlaneShot`
- `BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDead`
- `BaseGameSupport.Report_Turn09_Valgen_SuicideRates`
- `GameCondition.Turn09_FPnT_Preparations`
- `GameCondition.Turn09_FPnT_SuperpowerVisit`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 43

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Iosef_Enemy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[185]` (Deivid Wisci): `Variable["BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft"] = true;`
- Węzeł `[191]` (Deivid Wisci): `Variable["BaseGame.UnitedContana_AcceptedVisit"] = true;`
- Węzeł `[198]` (Deivid Wisci): `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] = true;`
- Węzeł `[199]` (Deivid Wisci): `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;`
- Węzeł `[200]` (Deivid Wisci): `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;`
- Węzeł `[225]` (Deivid Wisci): `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- Węzeł `[378]` (Deivid Wisci): `Variable["BaseGame.Arcasia_AcceptedVisit"] = true;`
- Węzeł `[380]` (Deivid Wisci): `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] = true;`
- *...oraz 35 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Deivid Wisci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian entered the room with Iosef by his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Mr. President. Mr. Wisci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[6]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.UnitedContana_MeetingOffer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.UnitedContana_MeetingOffer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.UnitedContana_MeetingOffer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.UnitedContana_MeetingOffer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.UnitedContana_MeetingOffer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[9]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from the United Contana. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[12]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Deivid Wisci**
> "“To be precise, they *were* requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“That is until the United Contanan ambassador was assassinated in broad daylight in the capital half an hour ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[15]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from the United Contana. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from Arcasia. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[17]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Hegel_PutInAGoodWordWithMalenyev == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Hegel_PutInAGoodWordWithMalenyev == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[19]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Hegel_PutInAGoodWordWithMalenyev == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from the United Contana. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Deivid Wisci**
> "“Subsequently the United Contanan ambassador was shot in broad daylight in the capital half an hour ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“Someone is trying to sabotage this meet. Regardless, the request was not retracted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[27]`

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“In addition, as part of this state visit, Malenyev will, of course, meet with you in person, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[288]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“I want the perpetrator found and questioned. Immediately.”"]** — Mówca: **Player**
> "“I want the perpetrator found and questioned. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Getting closer with Valgsland is paying off.”"]** — Mówca: **Player**
> "“Getting closer with Valgsland is paying off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“I think so too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Looks like I am not the only one who is not keen on the idea.”"]** — Mówca: **Player**
> "“Looks like I am not the only one who is not keen on the idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Deivid Wisci**
> "“Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Deivid Wisci**
> "“This looks like it is much more than a simple disagreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Regardless, one thing is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Mr. President. We came as fast as we could.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[33]`
Mówca: **Narrator**
> "I was sitting right across from Deivid in the White Room after he scheduled an urgent meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He insisted on waiting for Iosef and Lucian so we did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[35]`
Mówca: **Narrator**
> "I knew that the matter must've been serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Deivid cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Deivid Wisci**
> "“Due to the potential ramifications, I wanted everyone to be present for this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[38]`
Mówca: **Deivid Wisci**
> "“Welcome, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[39]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[44]`

### Węzeł `[41]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[104]`

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It's about time. I wanted to meet with him as well.”"]** — Mówca: **Player**
> "“It's about time. I wanted to meet with him as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“It's about time. I wanted to meet with Comrade Malenyev as well.”"]** — Mówca: **Player**
> "“It's about time. I wanted to meet with Comrade Malenyev as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[45]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[47]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Iosef Lancea**
> "“With all due respect...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Iosef Lancea**
> "“Are you out of your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“This is madness. We can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[52]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[54]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[55]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“We don't need any outside *help*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[130]`
  - -> `[133]`

### Węzeł `[58]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[60]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[61]`
Mówca: **Iosef Lancea**
> "“*Comrade* Malenyev?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“Watch out, Mr. President. You have started to show your true colours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“But, I understand now. I see your intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“Let me say something then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Iosef Lancea**
> "“You and your plans with your *comrades* won't fly in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Iosef Lancea**
> "“I will personally make sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[69]`
  - -> `[75]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Are you threatening me?”"]** — Mówca: **Player**
> "“Are you threatening me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Your hands are tied. What power do you even have, Iosef?”"]** — Mówca: **Player**
> "“Your hands are tied. What power do you even have, Iosef?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“This is all a misunderstanding. Let's keep civil.”"]** — Mówca: **Player**
> "“This is all a misunderstanding. Let's keep civil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“In the name of the Sordish sovereignty, yes, I am, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“I swore an oath to protect Sordland and I will follow that oath until the end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“You will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[73]`
Mówca: **Iosef Lancea**
> "“No. There are no more misunderstandings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Iosef Lancea**
> "“I understand everything clearly. I see where you are directing this country towards.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[75]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Your hands are tied, Iosef. You won't find any allies in the General Staff.”"]** — Mówca: **Player**
> "“Your hands are tied, Iosef. You won't find any allies in the General Staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“You better remember yours as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Iosef got up and left the room. He banged the door so hard that I was sure anyone could hear it in the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Watch your tone, Iosef.”"]** — Mówca: **Player**
> "“Watch your tone, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I did not say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“I'm just saying that we can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[84]`
Mówca: **Iosef Lancea**
> "“Normally, I would be very much against the influence of any superpower, let alone United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“But as much as I hate to admit...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Iosef Lancea**
> "“We need help in our war against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[89]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Iosef Lancea**
> "“Especially since we don't have any allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[91]`
Mówca: **Iosef Lancea**
> "“We need allies to bolster our defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[92]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[96]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“If you are approaching this from the perspective of national defense then don't. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[123]`
  - -> `[127]`

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“That's why I am not against the idea of him coming here to extend his *helping hand*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“On one condition...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Iosef Lancea**
> "“Sordish military command must belong to Sordland at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[102]`
Mówca: **Deivid Wisci**
> "“Judging from the current climate, it is not hard to see what this is about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“CSP is always trying to expand its influence after all. They will most likely try to convince us to join.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I won't negotiate with communists.”"]** — Mówca: **Player**
> "“I won't negotiate with communists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“As much as I share their ideals, we need to be wary.”"]** — Mówca: **Player**
> "“As much as I share their ideals, we need to be wary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
Mówca: **Iosef Lancea**
> "“Otherwise our sovereignty will be in grave danger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[114]`
  - -> `[116]`
  - -> `[121]`

### Węzeł `[107]`
Mówca: **Iosef Lancea**
> "“But, *share* their ideals?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“Watch out, Mr. President. You have started to show your true colours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Iosef Lancea**
> "“But, I understand now. I see your intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Iosef Lancea**
> "“You are right about that. We need to be extremely cautious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
Mówca: **Iosef Lancea**
> "“You mean to bring a communist revolution to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“Let me say something then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Iosef Lancea**
> "“You and your plans won't fly in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Have no doubt, Iosef. I have sworn an oath to this country.”"]** — Mówca: **Player**
> "“Have no doubt, Iosef. I have sworn an oath to this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Everything is on the table if it ensures the well-being of Sordland.”"]** — Mówca: **Player**
> "“Everything is on the table if it ensures the well-being of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“I hope that will be enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "“Very well. I trust that you will be vigilant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“If we can't hold onto that much, all is already lost for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[120]`
Mówca: **Iosef Lancea**
> "“As for the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“We don't need any outside help.”"]** — Mówca: **Player**
> "“We don't need any outside help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Iosef Lancea**
> "“I'd like to agree but the situation is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[126]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> "“Sir? He has threatened you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[136]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Watch his every single move. I want to know if he is plotting something.”"]** — Mówca: **Player**
> "“Watch his every single move. I want to know if he is plotting something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“It was simply an unfortunate disagreement in opinion. Carry on.”"]** — Mówca: **Player**
> "“It was simply an unfortunate disagreement. Carry on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“Mr. Wisci. Please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Deivid Wisci**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[141]`
Mówca: **Deivid Wisci**
> "“It all boils down to your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[142]`
Mówca: **Deivid Wisci**
> "“World tension is increasing rapidly, Mr. President, and I am worried about the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Deivid Wisci**
> "“If we don't pick a side, we may end up right in the middle of a potential conflict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stay neutral in this case. Our geopolitical position is simply too important. Soon, we will have to take a side. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[145]`
Mówca: **Deivid Wisci**
> "“One misstep and the whole world might be engulfed in chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[146]`
Mówca: **Deivid Wisci**
> "“I am of the opinion that this is an opportunity that we can't miss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“Mr. Wisci. We rely a lot on you as you are an expert in your field with a proven track record.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[148]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[153]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Iosef Lancea**
> "“Well said, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[155]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[156]`
Mówca: **Iosef Lancea**
> "“Well said, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[157]`
Mówca: **Iosef Lancea**
> "“Well said, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[158]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[159]`
Mówca: **Iosef Lancea**
> "“We don't need any outside *help*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[166]`
  - -> `[168]`
  - -> `[171]`

### Węzeł `[160]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[163]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[164]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[165]`
Mówca: **Iosef Lancea**
> "“We stand ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "“Exactly. We have nothing to fear.”"]** — Mówca: **Player**
> "“Exactly. We have nothing to fear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Our allies will come in handy in our time of need.”"]** — Mówca: **Player**
> "“Our allies will come in handy in our time of need.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Iosef Lancea**
> "“Exactly. We don't need more allies in return for servitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“Although I said what I said before, it might still be good to hear what he will say.”"]** — Mówca: **Player**
> "“Although I said what I said before, it might still be good to hear what he will say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Iosef Lancea**
> "“I bet he will try to persuade you with his snake tongue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[173]`
Mówca: **Iosef Lancea**
> "“As for the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[176]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Malenyev.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[178]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[179]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[180]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[181]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[184]`
Mówca: **Deivid Wisci**
> "“But, I say we should at least listen to what Malenyev has to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[187]`
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> "“We heard our experts. You are the one who has to decide, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“Very well. Accept their offer.”"]** — Mówca: **Player**
> "“Very well. Accept their offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I don't want to involve ourselves with superpowers. Decline their offer.”"]** — Mówca: **Player**
> "“I don't want to involve ourselves with superpowers. Decline their offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Lucian. What do you think?”"]** — Mówca: **Player**
> "“Lucian. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[190]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.UnitedContana_AcceptedVisit = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.UnitedContana_AcceptedVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“Then there is a tiny detail we need to get over with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“How should we welcome their delegation, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "“Make it as extravagant as you can. We need to impress them.”"]** — Mówca: **Player**
> "“Make it as extravagant as you can. We need to impress them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“A military welcome is in order. They need to see our might.”"]** — Mówca: **Player**
> "“A military welcome is in order. They need to see our might.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“A plain welcome will suffice. They are the ones who are requesting this.”"]** — Mówca: **Player**
> "“A plain welcome will suffice. They are the ones who are requesting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[198]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerVisit_ExtravagantWelcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[199]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerVisit_MilitaryWelcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerVisit_PlainWelcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
> "“As you wish. I have taken a note.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[205]`
Mówca: **Deivid Wisci**
> "“There is another matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Deivid Wisci**
> "“We had discussions with Mr. Lancea on the declaration of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Deivid Wisci**
> "“To announce the declaration and the start of the operation, we are scheduling a televised speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`
  - -> `[211]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“Apart from that, my propaganda efforts are still underway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "“It will be glorious.”"]** — Mówca: **Player**
> "“It will be glorious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "“As long as it sways the public support, I am fine with it.”"]** — Mówca: **Player**
> "“As long as it sways the public support, I am fine with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“I was generally successful in increasing the public support for the war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[214]`
  - -> `[213]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "“We need to make sure we have the public support.”"]** — Mówca: **Player**
> "“We need to make sure we have the public support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Keep at it. We still have much to do.”"]** — Mówca: **Player**
> "“Keep at it. We still have much to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Good job. I am expecting good results.”"]** — Mówca: **Player**
> "“Good job. I am expecting good results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[216]`
Mówca: **Deivid Wisci**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Deivid Wisci**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Deivid Wisci**
> "“It will be a historic day for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“I'm on it, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Deivid Wisci**
> "“I think that is all for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Deivid Wisci**
> "“Thank you all for attending.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Narrator**
> "As we dispersed, the world map hanging on the wall in the room caught my attention. I walked over to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Narrator**
> "How often were the lines on the world map redrawn over the recent decades?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Narrator**
> "What about the future?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[225]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[226]`
Mówca: **Deivid Wisci**
> "“This looks like it is much more than a simple disagreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
**[WYBÓR GRACZA: "“Looks like I am not the only one who is not keen on the idea.”"]** — Mówca: **Player**
> "“Looks like I am not the only one who is not keen on the idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[228]`
**[WYBÓR GRACZA: "“I want the perpetrator found and questioned. Immediately.”"]** — Mówca: **Player**
> "“I want the perpetrator found and questioned. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Deivid Wisci**
> "“Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Iosef Lancea**
> "“Good riddance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
Mówca: **Iosef Lancea**
> "“This is a clear sabotage to our international status.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Iosef Lancea**
> "“We need to get to the bottom of this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Iosef Lancea**
> "“This way we won't need to deal with the snake-tongued Malenyev.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Lucian raised an eyebrow and stared at Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Iosef Lancea**
> "“Why are you looking at me like that, Mr. Galade?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Iosef Lancea**
> "“If you are trying to imply something you shouldn't then you shouldn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
> "“We will, I assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
> "“I haven't said anything, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
> "“Regardless, the situation we are in is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Deivid Wisci**
> "“Indeed. We have now lost the opportunity to side with a very strong ally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Deivid Wisci**
> "“That means we are all alone. We have no allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[246]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[249]`
Mówca: **Deivid Wisci**
> "“Thankfully we still have allies in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[253]`
Mówca: **Deivid Wisci**
> "“They will be helpful in the upcoming war with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[254]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[257]`
Mówca: **Deivid Wisci**
> "“As if that is not already bad news, there is also the fact that we are going to war with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[258]`
Mówca: **Iosef Lancea**
> "“Good. Because, we will need all the help we can get.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`

### Węzeł `[259]`
Mówca: **Iosef Lancea**
> "“With the current state our military is in, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`

### Węzeł `[260]`
Mówca: **Deivid Wisci**
> "“They will be helpful in acting as a deterrence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Iosef Lancea**
> "“We need everything we can get.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[272]`
  - -> `[271]`

### Węzeł `[262]`
Mówca: **Deivid Wisci**
> "“In the case of a war, we will not get any help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[263]`
Mówca: **Iosef Lancea**
> "“With the current state our military is in, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[272]`
  - -> `[271]`

### Węzeł `[264]`
**[WYBÓR GRACZA: "“God damn it! Can't you do anything right?”"]** — Mówca: **Player**
> "“God damn it! Can't you do anything right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
> "“We are very sorry, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[266]`
Mówca: **Narrator**
> "I slammed the table and the room fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
> "“But for now, the situation we are in is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "“You are making me nervous, Iosef.”"]** — Mówca: **Player**
> "“You are making me nervous, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[269]`
**[WYBÓR GRACZA: "“This is not the worst threat Sordland has ever faced. We will survive this too.”"]** — Mówca: **Player**
> "“This is not the worst threat Sordland has ever faced. We will survive this too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
**[WYBÓR GRACZA: "“Otherwise, we are doomed.”"]** — Mówca: **Player**
> "“Otherwise, we are doomed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[271]`
**[WYBÓR GRACZA: "“We don't need them. Why do we have the Sordish army for?”"]** — Mówca: **Player**
> "“We don't need them. Why do we have the Sordish army for?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "“That's right. Rumburg is still a very real threat.”"]** — Mówca: **Player**
> "“That's right. Rumburg is still a very real threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[273]`
**[WYBÓR GRACZA: "“You are making me nervous, Iosef.”"]** — Mówca: **Player**
> "“You are making me nervous, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“We will, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
> "“That doesn't exactly inspire confidence, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
> "“That doesn't exactly inspire confidence, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
> "“Exactly. As part of our enactments during our term, we worked on strengthening our military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
> "“We need to be careful. Too much is at stake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Deivid Wisci**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> "“We need to look at the future at this point and let bygones be bygones.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Lucian Galade**
> "“Agreed. Was that all for today, Mr. Wisci?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[282]`
Mówca: **Deivid Wisci**
> "“Judging from the current climate, it is not hard to see what this is about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Deivid Wisci**
> "“ATO is always trying to expand its influence after all. They will most likely try to convince us to join.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Deivid Wisci**
> "“In addition, as part of this state visit, Dwight Walker will, of course, meet with you in person, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[287]`
  - -> `[286]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "“It's about time. I wanted to meet with him as well.”"]** — Mówca: **Player**
> "“It's about time. I wanted to meet with him as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[286]`
**[WYBÓR GRACZA: "“As much as I share their ideals, we need to be wary.”"]** — Mówca: **Player**
> "“As much as I share their ideals, we need to be wary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[287]`
**[WYBÓR GRACZA: "“There is something we could gain from this state visit.”"]** — Mówca: **Player**
> "“There is something we could gain from this state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[288]`
**[WYBÓR GRACZA: "“There is something we could gain from this state visit.”"]** — Mówca: **Player**
> "“There is something we could gain from this state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[289]`
Mówca: **Iosef Lancea**
> "“You mean to bring a communist revolution to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[291]`
Mówca: **Iosef Lancea**
> "“Sordish military command must belong to Sordland at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Iosef Lancea**
> "“Otherwise our sovereignty will be in grave danger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[296]`
  - -> `[302]`
  - -> `[312]`

### Węzeł `[293]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[295]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[296]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[297]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[299]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[300]`
**[WYBÓR GRACZA: "“Have no doubt, Iosef. I have sworn an oath to this country.”"]** — Mówca: **Player**
> "“Have no doubt, Iosef. I have sworn an oath to this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[301]`
Mówca: **Iosef Lancea**
> "“We need allies to bolster our defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[302]`
**[WYBÓR GRACZA: "“Everything is on the table if it ensures the well-being of Sordland.”"]** — Mówca: **Player**
> "“Everything is on the table if it ensures the well-being of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[303]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[305]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Iosef Lancea**
> "“I hope that will be enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[307]`
Mówca: **Iosef Lancea**
> "“If you are approaching this from the perspective of national defense then don't. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[308]`
Mówca: **Iosef Lancea**
> "“Very well. I trust that you will be vigilant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[309]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I did not say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Iosef Lancea**
> "“If we can't hold onto that much, all is already lost for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[311]`
Mówca: **Iosef Lancea**
> "“This is madness. We can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[312]`
**[WYBÓR GRACZA: "“We don't need any outside help.”"]** — Mówca: **Player**
> "“We don't need any outside help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Iosef Lancea**
> "“With all due respect...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[314]`
Mówca: **Iosef Lancea**
> "“I'd like to agree but the situation is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[315]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[317]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[318]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[320]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[321]`
**[WYBÓR GRACZA: "“Watch your tone, Iosef.”"]** — Mówca: **Player**
> "“Watch your tone, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[322]`
Mówca: **Iosef Lancea**
> "“On one condition...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[323]`
Mówca: **Iosef Lancea**
> "“Are you out of your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[324]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Dwight Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[341]`
  - -> `[337]`

### Węzeł `[326]`
Mówca: **Iosef Lancea**
> "“Normally, I would be very much against the influence of any superpower.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[327]`
Mówca: **Iosef Lancea**
> "“I'm just saying that we can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
Mówca: **Iosef Lancea**
> "“We need help in our war against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Iosef Lancea**
> "“Especially since we don't have any allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[330]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Dwight Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[331]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[332]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[334]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[335]`
Mówca: **Iosef Lancea**
> "“As for the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[336]`
Mówca: **Iosef Lancea**
> "“That's why I am not against the idea of him coming here to extend his *helping hand*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[337]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[338]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[339]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[340]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[341]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[342]`
Mówca: **Iosef Lancea**
> "“But as much as I hate to admit...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[343]`
Mówca: **Lucian Galade**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[309]`

### Węzeł `[344]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[345]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[346]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[347]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[348]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[349]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[351]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[353]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Iosef Lancea**
> "“I agree. At first chance, they would pounce on the opportunity to enslave us to their will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[359]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Iosef Lancea**
> "“From the perspective of national defense; we are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Iosef Lancea**
> "“From the perspective of the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Dwight Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[363]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[364]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[365]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[366]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[367]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
> "“Mr. Walker never gives anything for free. There will be some concessions for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Lucian Galade**
> "“Mr. Wisci you are our most experienced foreign policy expert. What's your take on this? What do you think is the right action?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[371]`
Mówca: **Lucian Galade**
> "“What's your take on this? What do you think is the right action?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[372]`
Mówca: **Deivid Wisci**
> "“It all boils down to your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[373]`
Mówca: **Deivid Wisci**
> "“World tension is increasing rapidly, Mr. President, and I am worried about the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[374]`
Mówca: **Deivid Wisci**
> "“If we don't pick a side, we may end up right in the middle of a potential conflict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stay neutral in this case. Our geopolitical position is simply too important. Soon, we will have to take a side. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[376]`
Mówca: **Deivid Wisci**
> "“One misstep and the whole world might be engulfed in chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[377]`
Mówca: **Deivid Wisci**
> "“I am of the opinion that this is an opportunity that we can't miss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[378]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Arcasia_AcceptedVisit = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Arcasia_AcceptedVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[379]`
Mówca: **Lucian Galade**
> "“As you wish. I have taken a note.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[380]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerVisit_ExtravagantWelcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[381]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerVisit_MilitaryWelcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[382]`
Mówca: **Lucian Galade**
> "“How should we welcome their delegation, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[384]`
  - -> `[393]`

### Węzeł `[383]`
Mówca: **Deivid Wisci**
> "“But, I say we should at least listen to what Dwight Walker has to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[384]`
**[WYBÓR GRACZA: "“A military welcome is in order. They need to see our might.”"]** — Mówca: **Player**
> "“A military welcome is in order. They need to see our might.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[385]`
Mówca: **Lucian Galade**
> "“We heard our experts. You are the one who has to decide, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
**[WYBÓR GRACZA: "“Very well. Accept their offer.”"]** — Mówca: **Player**
> "“Very well. Accept their offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[387]`
**[WYBÓR GRACZA: "“I don't want to involve ourselves with superpowers. Decline their offer.”"]** — Mówca: **Player**
> "“I don't want to involve ourselves with superpowers. Decline their offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[388]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerVisit_PlainWelcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[389]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[390]`
**[WYBÓR GRACZA: "“Lucian. What do you think?”"]** — Mówca: **Player**
> "“Lucian. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[391]`
Mówca: **Lucian Galade**
> "“Then there is a tiny detail we need to get over with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[392]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[393]`
**[WYBÓR GRACZA: "“A plain welcome will suffice. They are the ones who are requesting this.”"]** — Mówca: **Player**
> "“A plain welcome will suffice. They are the ones who are requesting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[394]`
**[WYBÓR GRACZA: "“Make it as extravagant as you can. We need to impress them.”"]** — Mówca: **Player**
> "“Make it as extravagant as you can. We need to impress them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[395]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_FPnT_Preparations = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_FPnT_Preparations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.UnitedContana_AcceptedVisit == false && BaseGame.Arcasia_AcceptedVisit == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.UnitedContana_AcceptedVisit == false && BaseGame.Arcasia_AcceptedVisit == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.UnitedContana_AcceptedVisit"] == false  and  Variable["BaseGame.Arcasia_AcceptedVisit"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.UnitedContana_AcceptedVisit == false && BaseGame.Arcasia_AcceptedVisit == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.UnitedContana_AcceptedVisit"] == false  and  Variable["BaseGame.Arcasia_AcceptedVisit"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[399]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_FPnT_SuperpowerVisit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_FPnT_SuperpowerVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[400]`
Mówca: **Narrator**
> "I knew that the matter must've been serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[401]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[403]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[404]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Preparations_UCAccept = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Preparations_UCAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[405]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[406]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDead = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[407]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[409]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false))))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[410]`
Mówca: **Deivid Wisci**
> "“And I recently found out of a planned meeting between the Queen and President Walker of Arcasia. The CSP and Chairman Malenyev might be the necessary evil to stop worse things from happening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[411]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stand against Rumburg without strong allies. Soon, we will have to take a side in this global rivalry to avert a potential conflict with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[412]`
Mówca: **Deivid Wisci**
> "“Rumburg is bound to increase diplomatic pressure in the upcoming AN meeting. Backchannels are reporting rumours about Queen Beatrice Livingston meeting with military leaders in Thornbourg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[413]`
Mówca: **Deivid Wisci**
> "“I say we should consider this offer very seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[187]`
  - -> `[188]`

### Węzeł `[414]`
Mówca: **Deivid Wisci**
> "“I say we should consider this offer very seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[415]`
Mówca: **Deivid Wisci**
> "“And I recently found out of a planned meeting between the Queen and Chairman Malenyev of United Contana. The ATO and President Walker might be the necessary evil to stop worse things from happening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[416]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stand against Rumburg without strong allies. Soon, we will have to take a side in this global rivalry to avert a potential conflict with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[417]`
Mówca: **Deivid Wisci**
> "“Rumburg is bound to increase diplomatic pressure in the upcoming AN meeting. Backchannels are reporting rumours about Queen Beatrice Livingston meeting with military leaders in Thornbourg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[418]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[420]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false))))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[421]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Malenyev.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[422]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`
  - -> `[181]`

### Węzeł `[423]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[346]`
  - -> `[349]`

### Węzeł `[424]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[365]`
  - -> `[366]`

### Węzeł `[425]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[427]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Iosef Lancea**
> "“Even though our military situation has improved, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[272]`
  - -> `[271]`

### Węzeł `[429]`
Mówca: **Iosef Lancea**
> "“Even though our military situation has improved, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`

### Węzeł `[430]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[432]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[433]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[436]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately. Sordland stands alone in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[437]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately. Sordland stands alone in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[438]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[440]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[441]`
Mówca: **Deivid Wisci**
> "“We need to look at the future at this point even if we stand alone in it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[442]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[444]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[445]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[446]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[448]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[449]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[451]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[452]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_SomeHumanRights = true;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = true;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[453]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_RumburgKnows = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgIncident_RumburgKnows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[454]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Prostitution_Illegal == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true &&  BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Economy < 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Prostitution_Illegal == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true &&  BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Economy < 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Prostitution_Illegal"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true  and   Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Economy"] < 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[456]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Prostitution_Illegal == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true &&  BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Economy < 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Prostitution_Illegal"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true  and   Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Economy"] < 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[457]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[458]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaStays == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaStays == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[460]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaStays == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[461]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_MinorityRights == true
&&
(BaseGame.Policy_Law_ReligiousHarmony == false && BaseGame.Policy_Law_EducationUnification == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_MinorityRights == true
&&
(BaseGame.Policy_Law_ReligiousHarmony == false && BaseGame.Policy_Law_EducationUnification == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_MinorityRights"] == true
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and  Variable["BaseGame.Policy_Law_EducationUnification"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[463]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_MinorityRights == true
&&
(BaseGame.Policy_Law_ReligiousHarmony == false && BaseGame.Policy_Law_EducationUnification == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_MinorityRights"] == true
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and  Variable["BaseGame.Policy_Law_EducationUnification"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[464]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_SordishPlaneShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[465]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[466]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[467]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_IncreasedDepression = true;
BaseGameSupport.Report_Turn09_Valgen_SuicideRates = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_IncreasedDepression"] = true;
Variable["BaseGameSupport.Report_Turn09_Valgen_SuicideRates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[468]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[469]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation = true;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[470]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[472]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[473]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation = false;
BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[474]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[476]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_EmergencyDecree == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[477]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation = true;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[478]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[479]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime = true;
BaseGame.Situation_Order_ReductionOfCrimeCommunities = false;
BaseGame.Situation_Order_OrganisedCrimeContained = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true;
Variable["BaseGame.Situation_Order_ReductionOfCrimeCommunities"] = false;
Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[480]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[482]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[483]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[485]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[486]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[487]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[489]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_DecreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[490]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[492]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[493]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_SomeHumanRights = false;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[494]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_MinorityRights == false
&&
(BaseGame.Policy_Law_ReligiousHarmony == true && BaseGame.Policy_Law_EducationUnification == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_MinorityRights == false
&&
(BaseGame.Policy_Law_ReligiousHarmony == true && BaseGame.Policy_Law_EducationUnification == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_MinorityRights"] == false
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == true  and  Variable["BaseGame.Policy_Law_EducationUnification"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[496]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_MinorityRights == false
&&
(BaseGame.Policy_Law_ReligiousHarmony == true && BaseGame.Policy_Law_EducationUnification == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_MinorityRights"] == false
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == true  and  Variable["BaseGame.Policy_Law_EducationUnification"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[497]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[498]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[499]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_MinorityRights == true && BaseGame.Policy_Law_ReligiousHarmony == false &&
BaseGame.Policy_Law_EducationUnification == false && BaseGame.Policy_Diplomacy_RelaxedImmigration == true && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_MinorityRights == true && BaseGame.Policy_Law_ReligiousHarmony == false &&
BaseGame.Policy_Law_EducationUnification == false && BaseGame.Policy_Diplomacy_RelaxedImmigration == true && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_MinorityRights"] == true  and  Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and 
Variable["BaseGame.Policy_Law_EducationUnification"] == false  and  Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[501]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_MinorityRights == true && BaseGame.Policy_Law_ReligiousHarmony == false &&
BaseGame.Policy_Law_EducationUnification == false && BaseGame.Policy_Diplomacy_RelaxedImmigration == true && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_MinorityRights"] == true  and  Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and 
Variable["BaseGame.Policy_Law_EducationUnification"] == false  and  Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[502]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[503]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[504]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[506]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_IncreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[507]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[509]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[510]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[511]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = true;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[512]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[514]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[516]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation = false;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[517]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Rumburg", "Neutral");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[518]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[519]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[521]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[522]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[524]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishReconciliation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[525]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false && BaseGame.Enable_RumburgIncident == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[527]`

### Węzeł `[526]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false && BaseGame.Enable_RumburgIncident == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false  and  Variable["BaseGame.Enable_RumburgIncident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[527]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false && BaseGame.Enable_RumburgIncident == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false  and  Variable["BaseGame.Enable_RumburgIncident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
