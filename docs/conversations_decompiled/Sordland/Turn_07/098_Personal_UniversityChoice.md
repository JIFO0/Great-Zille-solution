# Sordland/Turn07/Personal_UniversityChoice

- **ID konwersacji:** `98`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/098_Personal_UniversityChoice.md`
- **Liczba węzłów dialogowych:** 371
- **Liczba wyborów gracza:** 73

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Malenyevist`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Military_CompulsoryMilitaryService`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn06_PSnW_Education_ImproveRural`
- `BaseGame.Turn06_PSnW_Education_Salary`
- `BaseGame.Turn06_PSnW_Education_Schools`
- `BaseGame.Turn06_P_SupportedMonicaAtConfrontation`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedContana`
- `BaseGameIsolated.Turn07_P_Franc_Reconsidered`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedContana`
- `BaseGameIsolated.Turn07_P_Franc_Reconsidered`
- `BaseGameSupport.FactionReport_Turn07_ATO_CondemsDrugTraffic`
- `BaseGameSupport.Journal_Turn07_University_Arcasia`
- `BaseGameSupport.Journal_Turn07_University_Conscription`
- `BaseGameSupport.Journal_Turn07_University_HolsordState`
- `BaseGameSupport.Journal_Turn07_University_MilitarySchool`
- `BaseGameSupport.Journal_Turn07_University_UnitedContana`
- `BaseGameSupport.News_Turn07_HP_ErsenResult`
- `BaseGameSupport.News_Turn07_LT_AschrafUpcoming`
- `BaseGameSupport.News_Turn07_LT_BludishProtests`
- `BaseGameSupport.News_Turn07_R_EducationPrivatised`
- `BaseGameSupport.News_Turn07_R_ErsenResult`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillSigned`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillVetoed`
- `BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportEmergency`
- `BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt`
- `BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncreased`
- `BaseGameSupport.Report_Turn07_Vesord_EducationSalariesIncreased`
- `GameCondition.Turn07_Personal_FrancUniversityChoice`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 53

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[48]` (Monica): `Variable["GameCondition.Turn07_Personal_FrancUniversityChoice"] = true;`
- Węzeł `[63]` (Monica): `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] = true;`
- Węzeł `[167]` (Monica): `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = true;`
- Węzeł `[168]` (Monica): `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] = true;`
- Węzeł `[173]` (Monica): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1; ...`
- Węzeł `[189]` (Monica): `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] = true;`
- Węzeł `[190]` (Monica): `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = true;`
- Węzeł `[198]` (Monica): `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] = true;`
- *...oraz 45 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Monica)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I arrived home from work, hung my jacket up, and put my briefcase in the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Darling, what's wrong?""]** — Mówca: **Player**
> ""Darling, what's wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Who is it from?""]** — Mówca: **Player**
> ""Who is it from?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Sit down next to Monica."]** — Mówca: **Player_Italic**
> "I sat down on the couch next to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[7]`
Mówca: **Monica**
> ""It's from the Department of Education. Franc's university exam results are in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""How did he do?""]** — Mówca: **Player**
> ""How did he do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Why are you so worried, then?""]** — Mówca: **Player**
> ""Why are you so worried, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""He failed, didn't he?""]** — Mówca: **Player**
> ""He failed, didn't he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Monica**
> ""Just read the letter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "I looked at the page. Below Franc's name and address, his score was written: 435 points, out of a total of 1000."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "At the bottom of the letter, the word "Failed" was stamped in red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Monica**
> ""All those years of effort, all those private lessons... all down the drain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Maybe it'll be good for him to learn from his mistakes.""]** — Mówca: **Player**
> ""Maybe it'll be good for him to learn from his mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Does he know the results yet?""]** — Mówca: **Player**
> ""Does he know the results yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""He brought this upon himself.""]** — Mówca: **Player**
> ""He brought this upon himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Monica**
> ""This isn't just about Franc, you know. Him failing will reflect badly on you. On us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[19]`
Mówca: **Monica**
> ""No, but he should be back from school soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[20]`
Mówca: **Monica**
> ""I just don't understand. Franc's a smart boy -- why would he sabotage himself like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "I heard a key turning in the front door. Franc stomped in and was about to go straight upstairs when he noticed us both in the living room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Wait for Monica to start the conversation."]** — Mówca: **Player_Italic**
> "I waited for Monica to start the conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Have a seat, Franc.""]** — Mówca: **Player**
> ""Have a seat, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He took a seat across from us, and I handed him the letter. He started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Monica**
> ""Your exam results arrived today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Franc sat down, and Monica handed him the letter. He started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Franc**
> ""Oh, shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`
  - -> `[94]`
  - -> `[95]`

### Węzeł `[28]`
Mówca: **Franc**
> ""I... I need a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "He went to the kitchen sink and washed his face. A moment later, he came back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Franc**
> ""I never thought this would happen. I'm so sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""It's my fault. I should have been around to help you study.""]** — Mówca: **Player**
> ""It's my fault. I should have been around to help you study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How could you let us down like this?""]** — Mówca: **Player**
> ""How could you let us down like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""You made your mother cry with your actions.""]** — Mówca: **Player**
> ""You made your mother cry with your actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""It's not the end of the world.""]** — Mówca: **Player**
> ""It's not the end of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Franc**
> ""Pretty close, though, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[36]`
Mówca: **Franc**
> ""I know, I know, I can't do anything right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""So it seems.""]** — Mówca: **Player**
> ""So it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Not so fast. There might be something I can do.""]** — Mówca: **Player**
> ""Not so fast. There might be something I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[39]`
Mówca: **Monica**
> ""Anton. Isn't there *anything* you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Monica**
> ""If Alphonso could get his dimwit son into Kingshill University, I'm sure Holsord State would have room for a bright boy like Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[118]`
  - -> `[123]`

### Węzeł `[41]`
Mówca: **Monica**
> ""I'm going upstairs after him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[44]`
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Leave him be. He needs time.""]** — Mówca: **Player**
> ""Leave him be. He needs time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Suit yourself.""]** — Mówca: **Player**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Monica went upstairs after Franc and I started reading documents before dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Monica**
> ""I suppose I need some time as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Monica left the living room and I started reading newspapers before dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_Personal_FrancUniversityChoice = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_Personal_FrancUniversityChoice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Monica went upstairs after Franc and I started reading documents before dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[360]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""With enough money, I could get you into Harcard in Arcasia. It's one of the best universities in the world.""]** — Mówca: **Player**
> ""With enough money, I could get you into Harcard in Arcasia. It's one of the best universities in the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[54]`
Mówca: **Franc**
> ""That sounds... great, actually!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Monica**
> ""Anton! I want him to stay in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Franc**
> ""Mom. I've got to get out and experience the world sometime. And in Arcasia, people might see me as something more than just the president's son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Monica**
> ""I still don't like it, but I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""United People's University in United Contana is free. It also has an excellent medical program.""]** — Mówca: **Player**
> ""United People's University in United Contana is free. It also has an excellent medical program.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[59]`
Mówca: **Franc**
> ""Communism, I can dig that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Franc**
> ""Not exactly how I was expecting to spend my student years, but anything's better than the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Monica**
> ""This is the future of our boy, Anton. What should we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[303]`
  - -> `[207]`
  - -> `[210]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""It's been decided. You're going to United Contana, Franc.""]** — Mówca: **Player**
> ""It's been decided. You're going to United Contana, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""He must have made us proud.""]** — Mówca: **Player**
> ""He must have made us proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Monica**
> ""See for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[66]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Gone were the days when I could expect a warm welcome from my family. Franc was either at school, barricaded in his room or out with friends. Deana spent more and more time at her after-school art classes, and Monica... well, Monica avoided me at all costs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I awaited my usual welcome from Deana before realizing she was out at one of her art classes. Franc was still at school, and Monica... it had been a long time since she'd come to the door to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "I paused, awaiting my usual greeting from my wife and daughter. Deana was out at one of her after-school art classes, I remembered. But where was Monica?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "From the living room, I heard a muffled sob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Narrator**
> "I entered to find Monica sitting on the sofa, a letter in her hands and a look of despair on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[6]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Monica briefly rested her head on my shoulder, then handed me the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[78]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion > 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[80]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion > 2 ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Monica pointedly moved a few inches away from me, then handed me the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[82]`
Mówca: **Monica**
> ""You know what this means -- he's going to have to join the military. He could die, Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[83]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[86]`
Mówca: **Monica**
> ""He did this to get back at you, you know. Maybe if you had been there for him more often...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[87]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Franc**
> ""Hi, Mom. What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`

### Węzeł `[91]`
Mówca: **Franc**
> ""Mom? Dad? What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Franc! Language!""]** — Mówca: **Player**
> ""Franc! Language!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""That's all you have to say?""]** — Mówca: **Player**
> ""That's all you have to say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Son, we're not angry at you...""]** — Mówca: **Player**
> ""Son, we're not angry at you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""You're a disappointment to this family, Franc.""]** — Mówca: **Player**
> ""You're a disappointment to this family, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[96]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[99]`
Mówca: **Franc**
> ""Do you think I give a fuck?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Monica gasped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[101]`
Mówca: **Franc**
> ""Right, you should've taken a break from running the country to help your loser son!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Franc looked close to tears. Monica put her hand on his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[103]`
Mówca: **Franc**
> ""It's all about you, isn't it? You don't care that I bombed the test. You just care how it makes you look!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""How dare you speak to your parents that way!""]** — Mówca: **Player**
> ""How dare you speak to your parents that way!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""My image doesn't matter. This is your future we're talking about.""]** — Mówca: **Player**
> ""My image doesn't matter. This is your future we're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You're right. The President of Sordland cannot have a failure for a son!""]** — Mówca: **Player**
> ""You're right. The President of Sordland cannot have a failure for a son!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Monica put her hand on his shoulder. She glared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Monica put her hand on his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Monica**
> ""I know it's been a rough time. But you really should have studied harder, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Franc**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Franc's face crumpled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[112]`
Mówca: **Monica**
> ""It's going to be okay. But you really should have studied harder, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Monica**
> ""Yes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I'm not going to take life lessons from Ewald Alphonso.""]** — Mówca: **Player**
> ""I'm not going to take life lessons from Ewald Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[115]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[117]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[118]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I am a respected alumnus, it's true.""]** — Mówca: **Player**
> ""I am a respected alumnus, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I do have connections to the board.""]** — Mówca: **Player**
> ""I do have connections to the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It would be nice to have him closer to home.""]** — Mówca: **Player**
> ""It would be nice to have him closer to home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[124]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[126]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[127]`
Mówca: **Franc**
> ""I guess it's the army for me, then...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[37]`

### Węzeł `[128]`
Mówca: **Franc**
> ""So, what am I supposed to do now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Well, there's always military school. But you're the president's son. You still have options.""]** — Mówca: **Player**
> ""Well, there's always military school. But you're the president's son. You still have options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""You'll go to military school, of course. It's the only place that will have you.""]** — Mówca: **Player**
> ""You'll go to military school, of course. It's the only place that will have you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Monica surprised me with her enthusiasm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[132]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[134]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Franc**
> ""But I failed the exam. This sucks. Are you sure about all of this. Isn't it technically illegal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[319]`
  - -> `[320]`

### Węzeł `[136]`
Mówca: **Franc**
> ""If you're going to abuse your power to get me into a school, I want it to be as far away from this family as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`
  - -> `[341]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Wait. You could also study abroad...""]** — Mówca: **Player**
> ""Wait. You could also study abroad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""It's true, you could study abroad...""]** — Mówca: **Player**
> ""It's true, you could study abroad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""No. I won't influence your life. You've got to live with what you've done.""]** — Mówca: **Player**
> ""No. I won't influence your life. You've got to live with what you've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[140]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[143]`
Mówca: **Monica**
> ""Really? President Anton Rayne suddenly refuses to influence his family members' lives? After banning his wife from politics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[148]`
  - -> `[146]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""That's beside the point. You were the one who caused that whole deal in the first place.""]** — Mówca: **Player**
> ""That's beside the point. You were the one who caused that whole deal in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Monica**
> ""Come on, Anton. This is the least you can do after what you did to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""There was more at play there than just you or me or any of us. I have a duty to this nation.""]** — Mówca: **Player**
> ""There was more at play there than just you or me or any of us. I have a duty to this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Monica**
> ""I'm so sorry that duty required you to publicly ridicule me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Don't change the subject from Franc to you.""]** — Mówca: **Player**
> ""Don't change the subject from Franc to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[149]`
Mówca: **Franc**
> ""Mom! Dad! Stop fighting!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[152]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[153]`
Mówca: **Franc**
> ""I don't want to cause any more trouble than I already have. I'll go to military school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[154]`
Mówca: **Franc**
> ""I don't want to cause any more trouble than I already have. I'll join the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[155]`
Mówca: **Franc**
> ""I'm sick of this house and I'm sick of both of you. I'll go to military school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[156]`
Mówca: **Franc**
> ""I'm sick of this house and I'm sick of both of you. I'll join the goddamn army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[157]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[159]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[160]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[162]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[163]`
Mówca: **Monica**
> ""I understand principles are important. But, Anton, which is more important? Your principles or your son's future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Franc ran upstairs to his room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[165]`
**[WYBÓR GRACZA: ""Franc, wait--""]** — Mówca: **Player**
> ""Franc, wait--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""Good. It's time you learned some discipline.""]** — Mówca: **Player**
> ""Good. It's time you learned some discipline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[168]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancMilitarySchool = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""My principles, of course.""]** — Mówca: **Player**
> ""My principles, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""My son's future, of course.""]** — Mówca: **Player**
> ""My son's future, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[171]`
Mówca: **Monica**
> ""Then I believe you will make the right choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[184]`

### Węzeł `[172]`
Mówca: **Franc**
> ""I knew it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1;
BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[174]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Franc**
> ""If it's so important to you, I'll join the goddamn army. I won't be around to disgrace you any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[178]`
Mówca: **Franc**
> ""If it's so important to you, I'll go to goddamn military school. I won't be around to disgrace you any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[179]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[181]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""No, I've made my decision. You're going to military school.""]** — Mówca: **Player**
> ""No, I've made my decision. You're going to military school, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""No, I've made my decision. You're joining the army.""]** — Mówca: **Player**
> ""No, I've made my decision. You're joining the army, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[184]`
**[WYBÓR GRACZA: ""Fine. Let me think about this.""]** — Mówca: **Player**
> ""Fine. Let me think about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Monica**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[186]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[189]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancMilitarySchool = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[190]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[191]`
Mówca: **Franc**
> ""Great. See you when I come home in a body bag.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[192]`
Mówca: **Franc**
> ""All right, Dad. Serves me right for not studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""There's Holsord State, or you could study abroad...""]** — Mówca: **Player**
> ""There's Holsord State, or you could study abroad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[194]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Study Abroad)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[195]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[196]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[198]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_Reconsidered = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""You know how I feel about communists, but United People's University in Contana is free. It also has an excellent medical program.""]** — Mówca: **Player**
> ""You know how I feel about communists, but United People's University in Contana is free. It also has an excellent medical program.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[200]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[202]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[203]`
**[WYBÓR GRACZA: ""Holsord State University is the right decision after all. [Nepotism]""]** — Mówca: **Player**
> ""Holsord State University is the right decision after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""I won't influence your life, Franc. The military is the right choice.""]** — Mówca: **Player**
> ""I won't influence your life, Franc. The military is the right choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[205]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Military Convo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[206]`
Mówca: **Monica**
> ""What do you think, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[220]`
  - -> `[303]`
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_Reconsidered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_Reconsidered == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[209]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_P_Franc_Reconsidered == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[210]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[212]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA: ""There's also Harcard in Arcasia. It's one of the best universities in the world. With enough money, I could get you in.""]** — Mówca: **Player**
> ""There's also Harcard in Arcasia. It's one of the best universities in the world. With enough money, I could get you in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[214]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[215]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Military Convo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[216]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_DiscussedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[217]`
**[WYBÓR GRACZA: ""On second thought, I'd rather send Franc to Harcard in Arcasia." [-2 Personal Wealth]"]** — Mówca: **Player**
> ""On second thought, I'd rather send Franc to Harcard in Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""It's been decided. I'll pay for Franc to go to Harcard." [-2 Personal Wealth]"]** — Mówca: **Player**
> ""It's been decided. I'll pay for Franc to go to Harcard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""On the other hand, United People's University in United Contana is free and has an excellent medical program...""]** — Mówca: **Player**
> ""On the other hand, United People's University in United Contana is free and has an excellent medical program...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[220]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[222]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""On second thought, I'd rather send Franc to United Contana.""]** — Mówca: **Player**
> ""On second thought, I'd rather send Franc to United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[224]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[225]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Military Convo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[226]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[228]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[230]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[231]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Holsord State Decided)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Franc**
> ""The better to keep me under your thumb at all times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Franc**
> ""Thanks so much, Dad. I swear I won't let you down this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Franc**
> ""But fine, I accept. It's better than the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Monica let out a long exhale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Monica**
> ""What a day! Who's hungry for dinner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Monica disappeared to the kitchen; Franc to his room. I went to my office and began making some phone calls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[241]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Study Abroad Decided)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Franc**
> ""I don't care. Whichever gets me out of here the fastest!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[246]`
Mówca: **Franc**
> ""Thanks, Dad. Holsord State still would have been my first choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Monica**
> ""Not only yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Franc**
> ""But it's your call to make, after the way I messed up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[249]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[250]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[251]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[252]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Holsord State Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[253]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[254]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_UnitedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[255]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_HolsordState = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[256]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_Arcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_Arcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[258]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_UnitedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[259]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_MilitarySchool = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_MilitarySchool"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[260]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_Conscription = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[261]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[262]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[263]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 2;
BaseGame.Relations_Monica_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[264]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[265]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[266]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[267]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;
BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[268]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[269]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancMilitarySchool == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancMilitarySchool == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[271]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancMilitarySchool == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[272]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[274]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_ImproveRural == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[277]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_Salary == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[280]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_Schools == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[281]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[282]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Vesord_EducationSalariesIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Vesord_EducationSalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[283]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[284]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillSigned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[288]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillVetoed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillVetoed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[289]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[292]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[293]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_ErsenResult = true;
BaseGameSupport.News_Turn07_R_ErsenResult = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ErsenResult"] = true;
Variable["BaseGameSupport.News_Turn07_R_ErsenResult"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[294]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_LT_BludishProtests = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_BludishProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_LT_AschrafUpcoming = true; BaseGameSupport.FactionReport_Turn07_ATO_CondemsDrugTraffic = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_AschrafUpcoming"] = true;
Variable["BaseGameSupport.FactionReport_Turn07_ATO_CondemsDrugTraffic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[302]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_EducationPrivatised = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_EducationPrivatised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[303]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[305]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Holsord State University is the right decision after all. It will cost a little extra due to the privatization changes." [-1 Personal Wealth], [Nepotism]"]** — Mówca: **Player**
> ""Holsord State University is the right decision after all. It will cost a little extra due to the privatization changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[307]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[308]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_HolsordState = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[309]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[310]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[312]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[313]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[314]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[315]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[317]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[318]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Military Convo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[319]`
**[WYBÓR GRACZA: ""No. I won't influence your life. You've got to live with what you've done.""]** — Mówca: **Player**
> ""No. I won't influence your life. You've got to live with what you've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[320]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[323]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[325]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[326]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_HolsordState = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Terrific. Holsord State it is, then. [Nepotism]""]** — Mówca: **Player**
> ""Terrific. Holsord State it is, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Holsord State Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Terrific. Holsord State it is, then. Though, It is going to cost us a little bit extra due to the privatization changes. [-1 Personal Wealth], [Nepotism]""]** — Mówca: **Player**
> ""Terrific. Holsord State it is, then. Though, It going to cost us a little bit extra due to the privatization changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[332]`
**[WYBÓR GRACZA: ""Unfortunately, Holsord is a no go. We don't have the money, right now.""]** — Mówca: **Player**
> ""Unfortunately, Holsord is a no go. We don't have the money, right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Franc**
> ""All thanks to you and your privatization changes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
**[WYBÓR GRACZA: ""You could also study abroad...""]** — Mówca: **Player**
> ""You could also study abroad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
**[WYBÓR GRACZA: ""No. I won't influence your life. You've got to live with what you've done.""]** — Mówca: **Player**
> ""So, I guess, you've got to live with what you've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[336]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[337]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Military Convo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[338]`
**[WYBÓR GRACZA: ""No, I've made my decision. I'm sending you to Holsord State. [Nepotism]""]** — Mówca: **Player**
> ""No, I've made my decision. I'm sending you to Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_University_HolsordState = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[341]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[344]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[346]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[347]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Study Abroad])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[348]`
**[WYBÓR GRACZA: ""You could also study abroad...""]** — Mówca: **Player**
> ""You could also study abroad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[349]`
**[WYBÓR GRACZA: ""You're right. Besides, We don't have the money for Holsord, right now.""]** — Mówca: **Player**
> ""You're right. Besides, We don't have the money for Holsord, right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[350]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Holsord State Decided])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""No, I've made my decision. I'm sending you to Holsord State, even if it is going to cost us a little bit extra due to the privatization changes. [-1 Personal Wealth], [Nepotism]""]** — Mówca: **Player**
> ""No, I've made my decision. I'm sending you to Holsord State, even if it is going to cost us a little bit extra due to the privatization changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""So, I guess, you've got to live with what you've done.""]** — Mówca: **Player**
> ""So, I guess, you've got to live with what you've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[354]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Military Convo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[355]`
Mówca: **Franc**
> ""All thanks to you and your privatization changes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[353]`

### Węzeł `[356]`
Mówca: **Franc**
> ""Wow, you're the best dad, ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[357]`
Mówca: **Narrator**
> "Franc sneered at my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[358]`
Mówca: **Narrator**
> "Franc sneered at my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Franc**
> ""Wow, you're the best dad, ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Actually... never mind.""]** — Mówca: **Player**
> ""Actually... never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Monica**
> ""This is the future of our boy, Anton. What should we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[207]`

### Węzeł `[362]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[364]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[367]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[368]`
Mówca: **Franc**
> ""Holsord State would be amazing! A bunch of my friends are going there, I could still come home to do my laundry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[369]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[370]`
**[WYBÓR GRACZA: ""There's nothing for us to decide. Franc's going into the military.""]** — Mówca: **Player**
> ""There's nothing for us to decide. Franc's going into the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
