# Sordland/Turn04/PSnW_EducationReform

- **ID konwersacji:** `57`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/057_PSnW_EducationReform.md`
- **Liczba węzłów dialogowych:** 289
- **Liczba wyborów gracza:** 20

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Economy`
- `BaseGame.Gasom_Bankrupt`
- `BaseGame.Gasom_Default`
- `BaseGame.Gasom_Downsized`
- `BaseGame.GovernmentBudget`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_None`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Education_Budget_Maintain`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BlackTuesdayHappened`
- `BaseGame.Capitalist`
- `BaseGame.Education`
- `BaseGame.FinancialAid_Arcasia`
- `BaseGame.FinancialAid_Both`
- `BaseGame.FinancialAid_UC`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Policy_Welfare_TraditionalEducation`
- `BaseGame.Situation_Economy_Tourism_Average`
- `BaseGame.Situation_Economy_Tourism_Booming`
- `BaseGame.Situation_Economy_Tourism_Declining`
- `BaseGame.Situation_Welfare_EducationGap`
- `BaseGame.Situation_Welfare_ModernEducationTechniques`
- `BaseGame.Situation_Welfare_SollistTeachings`
- `BaseGame.Sollist`
- `BaseGame.SuperpowerTradeWarHappened`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite`
- `BaseGameSupport.Journal_Turn04_EducationReform_Maintain`
- `BaseGameSupport.Journal_Turn04_EducationReform_PrivatisedEducation`
- `BaseGameSupport.Journal_Turn04_EducationReform_Reform`
- `BaseGameSupport.Journal_Turn04_EducationReform_StateEducation`
- `BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms`
- `BaseGameSupport.News_Turn04_E_Gasom_Downsizes`
- `BaseGameSupport.News_Turn04_E_Gasom_Stagnates`
- `BaseGameSupport.News_Turn04_HP_FreeOfProtests`
- `BaseGameSupport.News_Turn04_LT_EducationPrivatization_KeptPromise`
- `BaseGameSupport.News_Turn04_LT_Kibener_R`
- `BaseGameSupport.News_Turn04_LT_Ricter_D`
- `BaseGameSupport.News_Turn04_R_EducationPrivatization_BrokenPromise`
- `BaseGameSupport.News_Turn04_R_ProtestersArrested`
- `BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal`
- `BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal`
- `BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike`
- `BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks`
- `BaseGameSupport.Report_Turn04_Holsord_EducationReformStart`
- `BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersStrike`
- `BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurfew`
- `BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike`
- `GameCondition.Turn04_PSnW_EducationReform`
- `GameCondition.Turn05_Decision_FinancialAid`
- `GameCondition.Turn05_Decision_Penalty`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“I agree. An educational reform is necessary.”"** | `[7]` **Narrator**: "Lucian took off his reading glas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Ciara Walda**: "“Exactly.”" |
| `[9]` | **"“I don't see what's wrong with our education system.”"** | `[7]` **Narrator**: "Lucian took off his reading glas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Ciara Walda**: "“You don't?”" |
| `[20]` | **"“Very well. What do we need to do for an education reform?”"** | `[19]` **Ciara Walda**: "“Mr. President. We need to bring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Ciara Walda**: "“We need to keep politics out of..." |
| `[21]` | **"“Everything is fine as it is. Why change it?”"** | `[19]` **Ciara Walda**: "“Mr. President. We need to bring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Ciara Walda**: "“I don't think my words are gett..." |
| `[27]` | **"“We have more important matters to think about than education for a bunch of kids.”"** | `[26]` **Ciara Walda**: "“We need to reform our education..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Ciara Walda**: "“I can't believe it. This will b..." |
| `[28]` | **"“We will not stray away from Soll's path.”"** | `[26]` **Ciara Walda**: "“We need to reform our education..." | `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true) == false` | *Brak zmian stanu* | `[32]` **Ciara Walda**: "“I can't believe it. This will b..." |
| `[33]` | **"“You have a point. Alright. So what's your plan?”"** | `[26]` **Ciara Walda**: "“We need to reform our education..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Ciara Walda**: "“I'm glad you have seen reason.”" |
| `[42]` | **"“Lucian, what do you think?”"** | `[40]` **Ciara Walda**: "“Either we raise a generation re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Lucian Galade**: "“As much as I respect Colonel So..." |
| `[43]` | **"“Maintain the traditional education system.”"** | `[40]` **Ciara Walda**: "“Either we raise a generation re..."<br>`[41]` **Lucian Galade**: "“As much as I respect Colonel So..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn04_EducationReform_...`<br>`Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = ...`<br>*(+1 skryptów)* | `[208]` **Narrator**: "Ciara looked furious. She shook ..." |
| `[44]` | **"“Reform the education system.”"** | `[40]` **Ciara Walda**: "“Either we raise a generation re..."<br>`[41]` **Lucian Galade**: "“As much as I respect Colonel So..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn04_EducationReform_...`<br>`Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = ...`<br>*(+1 skryptów)* | `[45]` **Ciara Walda**: "“You will not regret it. I will ..." |
| `[69]` | **"“Education should remain as a state service only. Certainly this is the most ideal..."** | `[68]` **Ciara Walda**: "“But before moving forward, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Ciara Walda**: "“I agree. The government should ..." |
| `[70]` | **"“There is a possibility of privatization having negative side effects.”"** | `[77]` **Ciara Walda**: "“This has led us to think about ..."<br>`[78]` **Ciara Walda**: "“Therefore we are investigating ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Ciara Walda**: "“Trust me, I know that. It could..." |
| `[75]` | **"“Tell us about the benefits of allowing private schools.”"** | `[68]` **Ciara Walda**: "“But before moving forward, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Ciara Walda**: "“I've made my opinion clear: I'm..." |
| `[93]` | **"“What are the advantages of privatization?""** | `[77]` **Ciara Walda**: "“This has led us to think about ..."<br>`[78]` **Ciara Walda**: "“Therefore we are investigating ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Ciara Walda**: "“There aren't many. But it would..." |
| `[100]` | **"“Initiate privatization to draw more funds. This should allow for more competition..."** | `[64]` **Ciara Walda**: "“So, what is your decision?”" | `Variable["BaseGame.Economy"] >= 4` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Policy_Welfare_EducationPrivatization"...`<br>*(+4 skryptów)* | `[108]` **Ciara Walda**: "“Will do. That should be it for ..." |
| `[107]` | **"“Thank you for your time.”"** | `[103]` **Lucian Galade**: "“This has been a very productive..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "We dispersed after spending near..." |
| `[113]` | **"“Keep education solely a matter of the state. We need to prevent interference from..."** | `[64]` **Ciara Walda**: "“So, what is your decision?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...`<br>`Variable["BaseGameSupport.Journal_Turn04_EducationReform_...` | `[117]` **Ciara Walda**: "“Great. That should be it for no..."<br>`[108]` **Ciara Walda**: "“Will do. That should be it for ..." |
| `[115]` | **"“Have a good day.”"** | `[103]` **Lucian Galade**: "“This has been a very productive..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "We dispersed after spending near..." |
| `[116]` | **"“See you later.”"** | `[103]` **Lucian Galade**: "“This has been a very productive..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "We dispersed after spending near..." |
| `[271]` | **"“Initiate privatization to draw more funds. This should allow for more competition..."** | `[64]` **Ciara Walda**: "“So, what is your decision?”" | `(Variable["BaseGame.Economy"] >= 4) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Policy_Welfare_EducationPrivatization"...`<br>*(+4 skryptów)* | `[108]` **Ciara Walda**: "“Will do. That should be it for ..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "We were still in Leiren, staying at a modest guesthouse f..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian was seated across from me at the table, going through documents. Ciara entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Ciara Walda: "“After the visit yesterday, I couldn't even sleep thinkin..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "We were still in Leiren, staying at a modest guesthouse for state employees. Ciara set up a meeting with me and Lucian to go over her plans for education reform after our school visit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian was seated across from me at the table, going thro..."*)

### Węzeł `[5]`
Mówca: **Ciara Walda**
> "“After the visit yesterday, I couldn't even sleep thinking about that little boy and girl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Ciara Walda: "“I have never been more sure of my intentions to reform o..."*)

### Węzeł `[6]`
Mówca: **Ciara Walda**
> "“I have never been more sure of my intentions to reform our education system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Lucian took off his reading glasses and put it on the table."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucian took off his reading glasses and put it on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“I agree. An educational reform is necessary.”"*)
  - -> `[9]` (*Player: "“I don't see what's wrong with our education system.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“I agree. An educational reform is necessary.”"]** — Mówca: **Player**
> "“I agree. An educational reform is necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Ciara Walda: "“Exactly.”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I don't see what's wrong with our education system.”"]** — Mówca: **Player**
> "“I don't see what's wrong with our education system.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Ciara Walda: "“You don't?”"*)

### Węzeł `[10]`
Mówca: **Ciara Walda**
> "“You don't?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Ciara Walda: "“Can't you look at it objectively and see what's wrong wi..."*)

### Węzeł `[11]`
Mówca: **Ciara Walda**
> "“Can't you look at it objectively and see what's wrong with it? You can't be serious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: "“Ciara. Check your tone.”"*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“Ciara. Check your tone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Ciara Walda: ""Would you say that to a man, Lucian?”"*)

### Węzeł `[13]`
Mówca: **Ciara Walda**
> ""Would you say that to a man, Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ciara Walda: "“Those students have to repeat that same Sollist propagan..."*)

### Węzeł `[14]`
Mówca: **Ciara Walda**
> "“Those students have to repeat that same Sollist propaganda every single day. They are being brainwashed at an age when their minds need to be free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ciara Walda: "“On top of that, young girls are denied the same opportun..."*)

### Węzeł `[15]`
Mówca: **Ciara Walda**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Ciara Walda: "“Those students have to repeat that same Sollist propagan..."*)

### Węzeł `[16]`
Mówca: **Ciara Walda**
> "“Those students have to repeat that same Sollist propaganda every single day. They are being brainwashed at an age when their minds need to be free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ciara Walda: "“On top of that, young girls are denied the same opportun..."*)

### Węzeł `[17]`
Mówca: **Ciara Walda**
> "“On top of that, young girls are denied the same opportunity as boys. They're forced into the role of housewife before they even reach puberty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Ciara Walda: "“The only way people like me, Nia, Lileas, Gloria, even y..."*)

### Węzeł `[18]`
Mówca: **Ciara Walda**
> "“On top of that, young girls are denied the same opportunity as boys. They're forced into the role of housewife before they even reach puberty! Nothing's changed since I went to school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Ciara Walda: "“Women like me, Lileas, Nia, even your wife -- we had to ..."*)

### Węzeł `[19]`
Mówca: **Ciara Walda**
> "“Mr. President. We need to bring change. We need to free the minds of these young people. They are our future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“Very well. What do we need to do for an education reform?”"*)
  - -> `[21]` (*Player: "“Everything is fine as it is. Why change it?”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Very well. What do we need to do for an education reform?”"]** — Mówca: **Player**
> "“Very well. What do we need to do for an education reform?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Ciara Walda: "“We need to keep politics out of the curriculum. Soll sho..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Everything is fine as it is. Why change it?”"]** — Mówca: **Player**
> "“Everything is fine as it is. Why change it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Ciara Walda: "“I don't think my words are getting through to you.”"*)

### Węzeł `[22]`
Mówca: **Ciara Walda**
> "“I don't think my words are getting through to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Ciara Walda: "“Are you really fine with filling the heads of our childr..."*)

### Węzeł `[23]`
Mówca: **Ciara Walda**
> "“Are you really fine with filling the heads of our children with Sollist propaganda? With teaching girls like Deana that their only value to this country is as vessels for childbearing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Ciara Walda: "“You know the words of Artor S. Wisci. You know them bett..."*)

### Węzeł `[24]`
Mówca: **Ciara Walda**
> "“You know the words of Artor S. Wisci. You know them better than I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Ciara Walda: "“Education is the premise of progress, in all societies, ..."*)

### Węzeł `[25]`
Mówca: **Ciara Walda**
> "“Education is the premise of progress, in all societies, in all families.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: "“We need to reform our education system. Otherwise, Sordl..."*)

### Węzeł `[26]`
Mówca: **Ciara Walda**
> "“We need to reform our education system. Otherwise, Sordland's future is bleak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“You have a point. Alright. So what's your plan?”"*)
  - -> `[27]` (*Player: "“We have more important matters to think about than educa..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == ..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“We have more important matters to think about than education for a bunch of kids.”"]** — Mówca: **Player**
> "“We have more important matters to think about than education for a bunch of kids.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ciara Walda: "“I can't believe it. This will be seen as a huge mistake ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“We will not stray away from Soll's path.”"]** — Mówca: **Player**
> "“We will not stray away from Soll's path.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ciara Walda: "“I can't believe it. This will be seen as a huge mistake ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == ..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait =..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“We will not stray away from Soll's path.”"*)

### Węzeł `[32]`
Mówca: **Ciara Walda**
> "“I can't believe it. This will be seen as a huge mistake when people look back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Ciara slumped in defeat."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“You have a point. Alright. So what's your plan?”"]** — Mówca: **Player**
> "“You have a point. Alright. So what's your plan?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Ciara Walda: "“I'm glad you have seen reason.”"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Ciara slumped in defeat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_EducationReform_Maintain =..."*)

### Węzeł `[35]`
Mówca: **Ciara Walda**
> "“I'm glad you have seen reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Ciara Walda: "“We need to keep politics out of the curriculum. Soll sho..."*)

### Węzeł `[36]`
Mówca: **Ciara Walda**
> "“This is actively poisoning young bright minds. Instead of thinking for themselves, they're learning to take things at face value.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Ciara Walda: "“We also need to ensure boys and girls receive the same i..."*)

### Węzeł `[37]`
Mówca: **Ciara Walda**
> "“We also need to ensure boys and girls receive the same instruction. Handcrafts like knitting and sewing should be taught to both sexes, or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Ciara Walda: "“Sordland's youth must be technically skilled and capable..."*)

### Węzeł `[38]`
Mówca: **Ciara Walda**
> "“We need to keep politics out of the curriculum. Soll should only be viewed as a historical figure. Children shouldn't have to repeat his name everyday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Ciara Walda: "“This is actively poisoning young bright minds. Instead o..."*)

### Węzeł `[39]`
Mówca: **Ciara Walda**
> "“Sordland's youth must be technically skilled and capable for the next decade. That won't be possible with the amount of nationalistic indoctrination and narrow-minded thinking found in schools today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ciara Walda: "“Either we raise a generation ready for the challenges of..."*)

### Węzeł `[40]`
Mówca: **Ciara Walda**
> "“Either we raise a generation ready for the challenges of the future or not. What will it be, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“Lucian, what do you think?”"*)
  - -> `[44]` (*Player: "“Reform the education system.”"*)
  - -> `[43]` (*Player: "“Maintain the traditional education system.”"*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“As much as I respect Colonel Soll, his time has passed. Now is our time. I do think this might be the first step of a larger plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Reform the education system.”"*)
  - -> `[43]` (*Player: "“Maintain the traditional education system.”"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Lucian, what do you think?”"]** — Mówca: **Player**
> "“Lucian, what do you think?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“As much as I respect Colonel Soll, his time has passed. ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Maintain the traditional education system.”"]** — Mówca: **Player**
> "“Maintain the traditional education system.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ciara Walda), `[41]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_EducationReform_Maintain =..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Reform the education system.”"]** — Mówca: **Player**
> "“Reform the education system.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ciara Walda), `[41]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_EducationReform_Reform = t..."*)

### Węzeł `[45]`
Mówca: **Ciara Walda**
> "“You will not regret it. I will get to work immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[46]`
Mówca: **Ciara Walda**
> "“I am utterly disappointed. Especially after yesterday's school visit. I thought it would awaken something in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "She let out a deep sigh."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Ciara Walda: "“It will be an uphill battle, considering that the educat..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: "“Now that the decision was made, let's move on.”"*)

### Węzeł `[50]`
Mówca: **Ciara Walda**
> "“It will be an uphill battle, considering that the education budget was lowered against my recommendations. But I will give it my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: "“Now that the decision was made, let's move on.”"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_TraditionalEducation = true; Base..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationReform = true; BaseGame...."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationReform = true;
BaseGame.Situation_Welfare_ModernEducationTechniques = true;
BaseGame.Policy_Welfare_TraditionalEducation = false;
BaseGame.Situation_Welfare_SollistTeachings = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationReform"] = true;
Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] = true;
Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = false;
Variable["BaseGame.Situation_Welfare_SollistTeachings"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Ciara Walda: "“You will not regret it. I will get to work immediately.”"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_TraditionalEducation = true;
BaseGame.Situation_Welfare_SollistTeachings = true;
BaseGame.Policy_Welfare_EducationReform = false;
BaseGame.Situation_Welfare_ModernEducationTechniques = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true;
Variable["BaseGame.Situation_Welfare_SollistTeachings"] = true;
Variable["BaseGame.Policy_Welfare_EducationReform"] = false;
Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Ciara looked furious. She shook her head slowly."*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> "“Now that the decision was made, let's move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Ciara Walda: "“Very well.”"*)

### Węzeł `[56]`
Mówca: **Ciara Walda**
> "“After the budget increase, the ministry quickly began formulating plans on how to effectively use the money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ciara Walda: "“But before moving forward, the question of keeping educa..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Ciara Walda: "“After the budget increase, the ministry quickly began fo..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Ciara Walda: "“With no change in budget, the ministry was left to its o..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Ciara Walda: "“The reduction of the education budget left our hands com..."*)

### Węzeł `[63]`
Mówca: **Ciara Walda**
> "“With no change in budget, the ministry was left to its own devices. We made some tough choices but still lack additional funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ciara Walda: "“Therefore we are investigating if privatizing education ..."*)

### Węzeł `[64]`
Mówca: **Ciara Walda**
> "“So, what is your decision?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 4"*)
  - -> `[113]` (*Player: "“Keep education solely a matter of the state. We need to ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: "“It would go against our overall economic strategy of a p..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: "“It would support our overall economic strategy of promot..."*)

### Węzeł `[68]`
Mówca: **Ciara Walda**
> "“But before moving forward, the question of keeping education fully state-funded or allowing for new private schools remains open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“Tell us about the benefits of allowing private schools.”"*)
  - -> `[69]` (*Player: "“Education should remain as a state service only. Certain..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Education should remain as a state service only. Certainly this is the most ideal situation.”"]** — Mówca: **Player**
> "“Education should remain as a state service only. Certainly this is the most ideal situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Ciara Walda: "“I agree. The government should be responsible of managin..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“There is a possibility of privatization having negative side effects.”"]** — Mówca: **Player**
> "“There is a possibility of privatization having negative side effects.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Ciara Walda), `[78]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Ciara Walda: "“Trust me, I know that. It could increase the cost of a q..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Ciara Walda: "“We can manage without additional funds. The only reason ..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Ciara Walda: "“It would be a lie to say that a decrease in the budget d..."*)

### Węzeł `[74]`
Mówca: **Ciara Walda**
> "“Trust me, I know that. It could increase the cost of a quality education, but that is hardly avoidable now anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Tell us about the benefits of allowing private schools.”"]** — Mówca: **Player**
> "“Tell us about the benefits of allowing private schools.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Ciara Walda: "“I've made my opinion clear: I'm against it. But it would..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Ciara skimmed over her documents before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[77]`
Mówca: **Ciara Walda**
> "“This has led us to think about allowing privatization to at least keep vital education services unaffected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“What are the advantages of privatization?""*)
  - -> `[70]` (*Player: "“There is a possibility of privatization having negative ..."*)

### Węzeł `[78]`
Mówca: **Ciara Walda**
> "“Therefore we are investigating if privatizing education would draw enough funds to conduct investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“What are the advantages of privatization?""*)
  - -> `[70]` (*Player: "“There is a possibility of privatization having negative ..."*)

### Węzeł `[79]`
Mówca: **Ciara Walda**
> "“It would be a lie to say that a decrease in the budget didn't force us to consider this. We just need the funds even though we don't like privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ciara Walda: "“So, what is your decision?”"*)

### Węzeł `[80]`
Mówca: **Ciara Walda**
> "“We can manage without additional funds. The only reason I wanted to consider it is to have more money to improve education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ciara Walda: "“So, what is your decision?”"*)

### Węzeł `[81]`
Mówca: **Ciara Walda**
> "“We have enough money to improve education in Sordland. We do not need to complicate things further with a privatization incentive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ciara Walda: "“So, what is your decision?”"*)

### Węzeł `[82]`
Mówca: **Ciara Walda**
> "“I've made my opinion clear: I'm against it. But it would give us additional funds for education while increasing competition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[83]`
Mówca: **Ciara Walda**
> "“I agree. The government should be responsible of managing education completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“State education is contrary to our overall economic strategy of promoting a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "A few minutes of deliberation passed."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: "“Private education is inconsistent with our overall econo..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: "“State education is contrary to our overall economic stra..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "A few minutes of deliberation passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Ciara Walda: "“We have enough money to improve education in Sordland. W..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true"*)

### Węzeł `[92]`
Mówca: **Ciara Walda**
> "“There aren't many. But it would give us sorely needed funds and increase competition among schools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“What are the advantages of privatization?""]** — Mówca: **Player**
> "“What are the advantages of privatization?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Ciara Walda), `[78]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Ciara Walda: "“There aren't many. But it would give us sorely needed fu..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> "“Private education is inconsistent with our overall economic strategy of a planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "A few minutes of deliberation passed."*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> "“It would go against our overall economic strategy of a planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "A few minutes of deliberation passed."*)

### Węzeł `[96]`
Mówca: **Ciara Walda**
> "“The reduction of the education budget left our hands completely tied. We are in a budget crisis management situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Ciara Walda: "“This has led us to think about allowing privatization to..."*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“It would support our overall economic strategy of promoting a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "A few minutes of deliberation passed."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "She let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: "“Now that the decision was made, let's move on.”"*)

### Węzeł `[99]`
Mówca: **Ciara Walda**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Ciara skimmed over her documents before continuing."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Initiate privatization to draw more funds. This should allow for more competition and quality.” [+2 Government Budget]"]** — Mówca: **Player**
> "“Initiate privatization to draw more funds. This should allow for more competition and quality.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[64]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 2;"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization = true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“This has been a very productive day. I will be returning to Holsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“Thank you for your time.”"*)
  - -> `[116]` (*Player: "“See you later.”"*)
  - -> `[115]` (*Player: "“Have a good day.”"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist -= 2;
BaseGame.Malenyevist += 2;
BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_EducationReform_StateEduca..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EducationGap = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_EducationGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Education += 1"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationPrivatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EducationGap = true"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Thank you for your time.”"]** — Mówca: **Player**
> "“Thank you for your time everybody.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "We dispersed after spending nearly the entire day togethe..."*)

### Węzeł `[108]`
Mówca: **Ciara Walda**
> "“Will do. That should be it for now. I will get to work and report back later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“This has been a very productive day. I will be returning..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Education += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Education"] = Variable["BaseGame.Education"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_EducationReform_Privatised..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true &..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Ciara Walda: "“Great. That should be it for now. I will get to work and..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ciara Walda: "“Will do. That should be it for now. I will get to work a..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Keep education solely a matter of the state. We need to prevent interference from private interests.""]** — Mówca: **Player**
> "“Keep education solely a matter of the state. We need to prevent interference from private interests.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist -= 2; BaseGame.Malenyevist += 2; Base..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "We dispersed after spending nearly the entire day together. I took a moment simply to breathe the fresh evening air of Leiren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "I felt calmer here, somehow. But I would have to return t..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Have a good day.”"]** — Mówca: **Player**
> "“Have a good day and safe travels.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "We dispersed after spending nearly the entire day togethe..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“See you later.”"]** — Mówca: **Player**
> "“See you both later.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "We dispersed after spending nearly the entire day togethe..."*)

### Węzeł `[117]`
Mówca: **Ciara Walda**
> "“Great. That should be it for now. I will get to work and report back later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“This has been a very productive day. I will be returning..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "I felt calmer here, somehow. But I would have to return to the chaos of Holsord soon enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest <= 0"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_EducationReform_Maintain = true;
BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_Maintain"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive = false"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_EducationReform_Reform = true;
BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_Reform"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_EducationReform_PrivatisedEducation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_PrivatisedEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization = true; Base..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_EducationReform_StateEducation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_StateEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_Ricter_D = true"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_Kibener_R = true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_Kibener_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_Kibener_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_Ricter_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_Ricter_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal =..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest <= 0"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest <= 0)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_FreeOfProtests = true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == false"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_FreeOfProtests = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_FreeOfProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lachaven", "City_Widespr..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == false"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_DecreasedInteriorFunding == false)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_FreeOfProtests = true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_DecreasedInteriorFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_ProtestersArrested = true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == false"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_ProtestersArrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_ProtestersArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Tu..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true && BaseGame...."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_EducationPrivatization_Kep..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellit..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Tu..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.T..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_EducationPrivatization_BrokenPromise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_EducationPrivatization_BrokenPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellit..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_EducationPrivatization_KeptPromise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_EducationPrivatization_KeptPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellit..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_PSnW_EducationReform = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_PSnW_EducationReform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && Ba..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurf..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurfew = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurfew"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_EducationReformStar..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_EducationReformStart = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_EducationReformStart"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks =..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike = true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true &..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersS..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_PSnW_EducationReform = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersStrike = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_PSnW_EducationReform = true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -8"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -8)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened = true;"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 6"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 6)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened = true;"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Decision_Penalty = true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Decision_Penalty = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Decision_Penalty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true && BaseGame.Refor..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true && BaseGame.Refor..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BlackTuesdayHappened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true && BaseGame.Refor..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true && BaseGame.Refor..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true && BaseGame.Ref..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.FinancialAid_UC = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true && BaseGame.Refor..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false &&
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true && BaseGame.Refor..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_None == true && BaseGame.Ref..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false &&
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and 
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.FinancialAid_UC = true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false &&
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and 
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true && BaseGame.Refor..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.FinancialAid_UC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.FinancialAid_UC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_Emerg..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true && BaseGame.Refor..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true && BaseGame.Ref..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.FinancialAid_Arcasia = true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true && BaseGame.Refor..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.FinancialAid_Arcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.FinancialAid_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_Emerg..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true && 
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true && BaseGame.Refor..."*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_None == true && BaseGame.Ref..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true && 
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.FinancialAid_Arcasia = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true && 
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Refo..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Refo..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Re..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true  and   Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.FinancialAid_Both = true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true  and   Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Decision_FinancialAid = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.FinancialAid_Both = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.FinancialAid_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_Emerg..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Decision_FinancialAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Decision_FinancialAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_Emerg..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Ciara looked furious. She shook her head slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Ciara Walda: "“I am utterly disappointed. Especially after yesterday's ..."*)

### Węzeł `[209]`
Mówca: **Ciara Walda**
> "“The only way people like me, Nia, Lileas, Gloria, even your wife were able to escape that is because our families were fortunate and well-connected enough to be able to educate us outside of the public school system. Is that the kind of country you want your daughter to grow up in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Ciara Walda: "“Mr. President. We need to bring change. We need to free ..."*)

### Węzeł `[210]`
Mówca: **Ciara Walda**
> "“Women like me, Lileas, Nia, even your wife -- we had to study twice as hard to receive the same university education that you and Lucian took for granted. Is that the kind of country you want your daughter to grow up in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Ciara Walda: "“Mr. President. We need to bring change. We need to free ..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.T..."*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_EducationPrivatization_Brok..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellit..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Promise_Economy_Planned == true && BaseGame.P..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Promise_Economy_Planned == true && BaseGame.P..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 6"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 5"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -7"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -7)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened = true;"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 5"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 5)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened = true;"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Decision_Penalty = true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == false"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_DecreasedInteriorFunding == false)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_ProtestersArrested = true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_DecreasedInteriorFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lachaven", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erlory", "City_Widesprea..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erlory", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erlory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_Widespread..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_RedYouth == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Benfi", "City_Widespread..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Widesprea..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Anrica", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Arvory", "City_Widesprea..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Arvory", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Morna", "City_Widespread..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_Widespre..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Benfi", "City_Widespread..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "City_Widespre..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Valgen", "City_Widesprea..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Valgen", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Valgen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_EmergencyDecree == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_Emerg..."*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_Eme..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_EmergencyDecree == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] >= 4  or  Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming = false; BaseG..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_EmergencyDecree == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] >= 4  or  Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed =..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming = false;
BaseGame.Situation_Economy_Tourism_Average = false;
BaseGame.Situation_Economy_Tourism_Declining = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Average"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Declining"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Default == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed =..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming = true; BaseGa..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming = false; BaseG..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming = true;
BaseGame.Situation_Economy_Tourism_Average = false;
BaseGame.Situation_Economy_Tourism_Declining = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] = true;
Variable["BaseGame.Situation_Economy_Tourism_Average"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Declining"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Default == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming = false;
BaseGame.Situation_Economy_Tourism_Average = true;
BaseGame.Situation_Economy_Tourism_Declining = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Average"] = true;
Variable["BaseGame.Situation_Economy_Tourism_Declining"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Default == true"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Default == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Default == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_Gasom_Stagnates = true;"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_Gasom_Stagnates = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Gasom_Stagnates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms = true;"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Downsized == true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Downsized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Downsized == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Downsized == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Downsized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Downsized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_Gasom_Downsizes = true;"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Downsized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Downsized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_Gasom_Downsizes = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Gasom_Downsizes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 4"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 4)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“Initiate privatization to draw more funds. This should a..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: "“Initiate privatization to draw more funds. This should a..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA: "“Initiate privatization to draw more funds. This should allow for more competition and quality.” [+1 Government Budget]"]** — Mówca: **Player**
> "“Initiate privatization to draw more funds. This should allow for more competition and quality.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] >= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[64]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 1;"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization = true;
BaseGame.Capitalist += 5;
BaseGame.Malenyevist -= 4;
BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 4;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ciara Walda: "“Will do. That should be it for now. I will get to work a..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization = true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -9"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -8"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -9`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -9"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -9)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -9`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -9`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened = true;"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -9)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -9) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -7"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -6"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -6"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -6)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened = true;"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && Ba..."*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && ..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Decision_Penalty = true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Promise_Economy_Planned == true && BaseGame.Pol..."*)
