# Sordland/Turn10/Foreign Policy

- **ID konwersacji:** `234`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/234_Foreign_Policy.md`
- **Liczba węzłów dialogowych:** 190
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
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
- `BaseGame.Joined_ATO`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_ATO`
- `BaseGame.Policy_Diplomacy_CSP`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_8`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Turn10_FPnT_RumburgIsolated`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[235] Sordland/Turn10/Women's Rights** (../Turn_10/235_Women's_Rights.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
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
  - -> `[6]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `235` (*Sordland/Turn10/Women's Rights*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[6]`
Mówca: **Moderator**
> ""My next question concerns Sordland's foreign relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Neutrality == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[13]`
Mówca: **Moderator**
> ""To the non-incumbent candidates, would you maintain the international alliances President Rayne has formed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[20]`
Mówca: **Manoly Suheil**
> ""The members of ATO, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[27]`
Mówca: **Manoly Suheil**
> ""Certainly not. Sordland only stands to benefit from forming more cordial relationships with its neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[28]`
Mówca: **Denis Stahler**
> ""Thank you, Mr. President. I was going to stress that the superficial surface benefits of ATO are nothing compared to the deeper bonds cultivated by a membership in CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[41]`
Mówca: **Moderator**
> ""President Rayne, you haven't formed any strong international alliances during your term. I'd like to know if the other candidates would continue on the same track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[48]`
Mówca: **Mansoun Leke**
> ""I would add that we have been unfairly ignoring the newly emancipated nations from Rika and Xina. Aiding these countries as they find their feet would strike a blow against the forces of colonialism, and could prove beneficial to us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[49]`
Mówca: **Kesaro Kibener**
> ""Together, we conquered the lands of Rum so many centuries ago. And together, we who are pure of blood will rise up and reclaim this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[115]`
  - -> `[114]`
  - -> `[113]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[59]`
Mówca: **Moderator**
> ""That's all the time we have for that question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[136]`
  - -> `[160]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[66]`
Mówca: **Frens Ricter**
> ""By joining ATO, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[67]`
Mówca: **Frens Ricter**
> ""Certainly not. Sordland can only move forward if we form productive relationships with our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[68]`
Mówca: **Frens Ricter**
> ""I would do more than just maintain them. I would expand upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Lileas Graf**
> ""We must endeavor to stay in the good graces of both superpowers while asserting Sordland's strength and independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[70]`
Mówca: **Manoly Suheil**
> ""I would do more than just maintain them. I would expand upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[71]`
Mówca: **Lileas Graf**
> ""We must maintain the ties we've built while making a greater effort to assert Sordland's strength and independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[72]`
Mówca: **Frens Ricter**
> ""Membership in ATO is the obvious next step forward for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[76]`
Mówca: **Manoly Suheil**
> ""Membership in ATO is the obvious next step forward for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Kesaro Kibener**
> ""If I may.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[78]`
Mówca: **Denis Stahler**
> ""That's right, Suheil. Tow the party line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[79]`
Mówca: **Remus Holstron**
> ""Is it my turn yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[80]`
Mówca: **Denis Stahler**
> ""I can't believe we were ever in the same party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[81]`
Mówca: **Lileas Graf**
> ""Strategic alliances are all well and good, as long as our country receives its fair share of the benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[82]`
Mówca: **Denis Stahler**
> ""We all know Lespia and Arcasia don't give a damn about us. We will only grow stronger by marching arm and arm with our socialist brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[83]`
Mówca: **Lileas Graf**
> ""Strategic alliances are all well and good, but President Rayne would practically give Leon Malenyev the shirt off his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
> ""Strategic alliances are all well and good, but President Rayne would practically give Dwight Walker the shirt off his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[85]`
Mówca: **Frens Ricter**
> ""Of course I would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Manoly Suheil**
> ""Of course I would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
Mówca: **Remus Holstron**
> ""Together, we conquered the lands of Rum so many centuries ago. And together, we who are pure of blood will rise up and reclaim this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[115]`
  - -> `[118]`
  - -> `[113]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Denis sat back in his chair, fuming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[89]`
Mówca: **Frens Ricter**
> ""Membership in ATO was always the logical next step for Sordland. I'm looking forward to developing those relationships further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[90]`
Mówca: **Moderator**
> ""Let's move on to the next candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[119]`
  - -> `[120]`

### Węzeł `[91]`
Mówca: **Manoly Suheil**
> ""Membership in ATO was always the logical next step for Sordland. I'm looking forward to developing those relationships further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Denis turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[96]`
Mówca: **Remus Holstron**
> ""Of course I would advocate for staying on good terms with Arcasia, but Sordland's strongest ties must be to our tribal cousins in Valgsland and Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[97]`
Mówca: **Denis Stahler**
> ""I don't need charity from the man who got me imprisoned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[98]`
Mówca: **Kesaro Kibener**
> ""Of course I would advocate for staying on good terms with Arcasia, but Sordland's strongest ties must be to our tribal cousins in Valgsland and Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[99]`
Mówca: **Remus Holstron**
> ""All this talk of east and west, socialist and capitalist is missing the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[103]`
Mówca: **Frens Ricter**
> ""However, with enough skilled diplomacy I can turn our standing around and regain Arcasia's trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[104]`
Mówca: **Manoly Suheil**
> ""I still believe Sordland's future lies with ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[105]`
Mówca: **Frens Ricter**
> ""But it's not impossible to cut ties and regain the trust of Arcasia and ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[109]`
Mówca: **Kesaro Kibener**
> ""All this talk of east and west, socialist and capitalist is missing the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[110]`
Mówca: **Denis Stahler**
> ""I believe that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[111]`
Mówca: **Denis Stahler**
> ""Sure. The point is--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Pure of blood? I wonder what that means...""]** — Mówca: **Player**
> ""Pure of blood? I wonder what that means...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I kept watching the debate unfold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""That'll be enough of that, Kesaro.""]** — Mówca: **Player**
> ""That'll be enough of that, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""A nice sentiment. A shame we can't ally with Valgsland and Agnolia at the same time.""]** — Mówca: **Player**
> ""A nice sentiment. A shame we can't ally with Valgsland and Agnolia at the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Denis turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Denis Stahler**
> ""Rayne and I have had our disagreements, but not on this. We must continue to march arm in arm with our socialist brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""How articulate of you, Remus. I'd say Kesaro wrote you some talking points, but I'm not convinced you can read.""]** — Mówca: **Player**
> ""How articulate of you, Remus. I'd say Kesaro wrote you some talking points, but I'm not convinced you can read.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Yeah, shut up, Denis.""]** — Mówca: **Player**
> ""Yeah, shut up, Denis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Let him speak.""]** — Mówca: **Player**
> ""Let him speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I lowered the election threshold to give Mr. Stahler and his party a voice. Let him speak.""]** — Mówca: **Player**
> ""I lowered the election threshold to give Mr. Stahler and his party a voice. Let him speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[126]`
Mówca: **Mansoun Leke**
> ""Our socialist brothers *and sisters*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[127]`
Mówca: **Denis Stahler**
> ""Absolutely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Denis Stahler**
> ""We must strengthen our ties with our socialist brothers, so that we may inspire workers everywhere to rise up and be free of their shackles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[129]`
Mówca: **Denis Stahler**
> ""I can't believe we were ever in the same party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[130]`
Mówca: **Denis Stahler**
> ""That's right, Suheil. Tow the party line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[131]`
Mówca: **Denis Stahler**
> ""I can't believe we were ever in the same party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Denis Stahler**
> ""That's right, Suheil. Tow the party line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "Denis turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Denis Stahler**
> ""An international movement is growing, and it's high time Sordland became a part of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""May I just add that my decision to join ATO likely saved us from having to go to war with Rumburg?""]** — Mówca: **Player**
> ""May I just add that my decision to join ATO likely saved us from having to go to war with Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[158]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[151]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""May I just add that my decision to join CSP likely saved us from having to go to war with Rumburg?""]** — Mówca: **Player**
> ""May I just add that my decision to join CSP likely saved us from having to go to war with Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Neutrality == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""May I just add that I managed to defuse a potential war with Rumburg without the help of any international alliances?""]** — Mówca: **Player**
> ""May I just add that I managed to defuse a potential war with Rumburg without the help of any international alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""I just wanted to say that I avoided international alliances in order to put my full focus on our domestic issues. I'm thinking globally for my next term.""]** — Mówca: **Player**
> ""I just wanted to say that I avoided international alliances in order to put my full focus on our domestic issues. I'm thinking globally for my next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FPnT_RumburgIsolated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FPnT_RumburgIsolated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_FPnT_RumburgIsolated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FPnT_RumburgIsolated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FPnT_RumburgIsolated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_FPnT_RumburgIsolated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FPnT_RumburgIsolated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FPnT_RumburgIsolated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_FPnT_RumburgIsolated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA: ""May I just add that the international relationships I cultivated likely saved us from having to go to war with Rumburg?""]** — Mówca: **Player**
> ""May I just add that the international relationships I cultivated likely saved us from having to go to war with Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[158]`
**[WYBÓR GRACZA: ""I just wanted to point out that no Sordish president has managed to garner the attention of a superpower before. Let alone ally with one.""]** — Mówca: **Player**
> ""I just wanted to point out that no Sordish president has managed to garner the attention of a superpower before. Let alone ally with one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""May I just point out that I have increased Sordland's international standing more than any other Sordish president?""]** — Mówca: **Player**
> ""May I just point out that I have increased Sordland's international standing more than any other Sordish president?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I waited for the next question."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[161]`
Mówca: **Moderator**
> ""As I said, we need to move on to the next topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[165]`
Mówca: **Moderator**
> ""Of course. Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Frens Ricter**
> ""Certainly not. The joint operation with Wehlen was a travesty, and the alliance with Valgsland a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[170]`
Mówca: **Frens Ricter**
> ""Certainly not. The alliance with Valgsland was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Frens Ricter**
> ""Certainly not. The joint operation with Wehlen was a travesty, and CSP membership one of Rayne's biggest mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[175]`
Mówca: **Frens Ricter**
> ""Certainly not. Joining CSP was one of President Rayne's biggest mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[176]`
Mówca: **Manoly Suheil**
> ""Certainly not. The joint operation with Wehlen was a travesty, and the Valgsland alliance was ill-advised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[177]`
Mówca: **Manoly Suheil**
> ""Certainly not. The Valgsland alliance was ill-advised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Manoly Suheil**
> ""Certainly not. The joint operation with Wehlen was a travesty. And I have nothing but respect for the member states of CSP, but I still believe Sordland's future lies with ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[185]`
Mówca: **Manoly Suheil**
> ""Certainly not. I have nothing but respect for the member states of CSP, but I still believe Sordland's future lies with ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Can I just add that my decision to send troops into Wehlen probably saved thousands of Wehzek lives?""]** — Mówca: **Player**
> ""Can I just add that my decision to send troops into Wehlen probably saved thousands of Wehzek lives?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
