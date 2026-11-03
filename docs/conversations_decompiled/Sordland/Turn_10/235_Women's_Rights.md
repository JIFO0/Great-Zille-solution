# Sordland/Turn10/Women's Rights

- **ID konwersacji:** `235`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/235_Women's_Rights.md`
- **Liczba węzłów dialogowych:** 146
- **Liczba wyborów gracza:** 11

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn09_StrongWomensRights_Signed`
- `BaseGame.Bill_Turn09_WeakWomensRights_Signed`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Situation_Welfare_GenderEqualityInEducation`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[236] Sordland/Turn10/Bludish Issues + Scandals** (../Turn_10/236_Bludish_Issues_+_Scandals.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `236` (*Sordland/Turn10/Bludish Issues + Scandals*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Frens Ricter**
> ""Until women have the same rights as men, peace is not an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[4]`
Mówca: **Moderator**
> ""This next topic is of personal interest to many people watching at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Mansoun Leke**
> ""More women in the workforce sounds nice on paper. But it's unfortunately not as simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[9]`
Mówca: **Moderator**
> ""In the wake of the President's recent legislation, do you plan to act further to increase women's rights?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Moderator**
> ""Women across Sordland have been marching for equal rights throughout the Rayne presidency -- do you plan on addressing their demands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[14]`
Mówca: **Remus Holstron**
> ""Thanks to Anton Rayne's laws, entire generations of young Sords will grow up motherless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[15]`
Mówca: **Lileas Graf**
> ""I'll stop you right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Moderator**
> ""Anything to add, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[52]`
  - -> `[23]`
  - -> `[139]`

### Węzeł `[17]`
Mówca: **Lileas Graf**
> ""You can't expect a man -- and a divorced man at that -- to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[18]`
Mówca: **Manoly Suheil**
> ""Says the woman running for President! Do you not see a contradiction here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Moderator**
> ""But what about the argument that more women in the workforce leads to greater productivity as a nation--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""No. Next question.""]** — Mówca: **Player**
> ""No. Next question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[24]`
Mówca: **Lileas Graf**
> ""You can't expect a man to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I would have achieved unprecedented rights for Sordland's women had certain individuals not blocked me.""]** — Mówca: **Player**
> ""I would have achieved unprecedented rights for Sordland's women had certain individuals not blocked me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""This term was just the beginning. In the next four years, I will achieve full equality for all women.""]** — Mówca: **Player**
> ""This term was just the beginning. In the next four years, I will achieve full equality for all women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Sordland will not give in to the demands of a few radicals. We must hold firm to tradition.""]** — Mówca: **Player**
> ""Sordland will not give in to the demands of a few radicals. We must hold firm to tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[31]`
Mówca: **Lileas Graf**
> ""These radical demonstrators hardly represent a majority. The only thing ladies truly want is a peaceful home life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[32]`
Mówca: **Mansoun Leke**
> ""*If* you win a second term, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[33]`
Mówca: **Lileas Graf**
> ""The laws passed under his administration will cause more harm than good as generations of young Sords grow up motherless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Over the next four years, my amazing Women's Rights Commission will finish the work they started.""]** — Mówca: **Player**
> ""Over the next four years, my amazing Women's Rights Commission will finish the work they started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[35]`
Mówca: **Kesaro Kibener**
> ""I'll stop you right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Kesaro Kibener**
> ""Thanks to Anton Rayne's laws, entire generations of young Sords will grow up motherless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[40]`
Mówca: **Kesaro Kibener**
> ""You can't expect a divorced man to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Kesaro Kibener**
> ""These radical demonstrators hardly represent a majority. The only thing ladies truly want is a peaceful home life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Sordland's women have all the rights they need thanks to me. It's time to focus on other, more pressing issues.""]** — Mówca: **Player**
> ""Sordland's women have all the rights they need thanks to me. It's time to focus on other, more pressing issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Denis Stahler**
> ""The workforce. Of course 'productivity' is your main concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[50]`
Mówca: **Frens Ricter**
> ""I have consulted intensively with my deputy Manoly Suheil on this. With the PFJP in power, we would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[51]`
Mówca: **Frens Ricter**
> ""Says the woman running for President! Do you not see a contradiction here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.WomensRightCommission == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.WomensRightCommission == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.WomensRightCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.WomensRightCommission == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.WomensRightCommission"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[29]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_ExcellentWomenRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[30]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Manoly Suheil**
> ""As Sordland's first female President, I would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[68]`
Mówca: **Remus Holstron**
> ""Stop right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Remus Holstron**
> ""These radical demonstrators hardly represent a majority. The only thing ladies truly want is a peaceful home life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Remus Holstron**
> ""You can't expect a divorced man to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[80]`
Mówca: **Manoly Suheil**
> ""As Sordland's first female President, would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""That makes a lot of sense. Remind me to consult with you on this during my next term.""]** — Mówca: **Player**
> ""That makes a lot of sense. Remind me to consult with you on this during my next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[85]`
Mówca: **Frens Ricter**
> ""I have consulted intensively with my deputy Manoly Suheil on this. With the PFJP in power, we would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[86]`
Mówca: **Frens Ricter**
> ""Are you serious? Women can have careers and families at the same time. Perhaps we men can even assume some of the childcare duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
Mówca: **Denis Stahler**
> ""Getting a little ahead of yourself, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[88]`
Mówca: **Denis Stahler**
> ""I'll remind you to go to hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[92]`
Mówca: **Manoly Suheil**
> ""Are you serious? Women can have careers and families at the same time. Perhaps men can even assume some of the childcare duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[93]`
Mówca: **Frens Ricter**
> ""I have consulted intensively with my deputy Manoly Suheil on this. With the PFJP in power, we would expand on Rayne's laws and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[94]`
Mówca: **Mansoun Leke**
> ""Look at countries like Arcasia. The women in high-paying jobs are those privileged enough to hand off their domestic duties to household staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[95]`
Mówca: **Denis Stahler**
> ""We will only truly be free as a society when childrearing, cleaning and other so-called 'women's work' is considered just as productive as the work done by President Rayne here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[112]`
  - -> `[120]`
  - -> `[124]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[102]`
Mówca: **Manoly Suheil**
> ""As Sordland's first female president, I would expand on Rayne's laws and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[109]`
Mówca: **Mansoun Leke**
> ""As your president, I would create policies specifically aimed at women from disadvantaged communities, so that no female Sord is lifted up at the expense of another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[112]`
  - -> `[120]`
  - -> `[124]`

### Węzeł `[110]`
Mówca: **Frens Ricter**
> ""Because husbands aren't allowed to beat their wives anymore? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[111]`
Mówca: **Manoly Suheil**
> ""Until women have the same rights as men, peace is not an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Sordish women are doing just fine! I don't know what you all are on about.""]** — Mówca: **Player**
> ""Sordish women are doing just fine! I don't know what you all are on about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[113]`
Mówca: **Manoly Suheil**
> ""Because husbands aren't allowed to beat their wives anymore? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Shh. The grown-ups are talking.""]** — Mówca: **Player**
> ""Shh. The grown-ups are talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[128]`
Mówca: **Manoly Suheil**
> ""Because girls are allowed to study trigonometry? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[135]`
Mówca: **Frens Ricter**
> ""Because girls may now learn trigonometry? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Only that I have already given Sordland its first female vice president. That should show how committed I am to advancing the status of women in this country.""]** — Mówca: **Player**
> ""Only that I have already given Sordland its first female vice president. That should show how committed I am to advancing the status of women in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
