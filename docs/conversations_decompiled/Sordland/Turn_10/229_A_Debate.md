# Sordland/Turn10/A_Debate

- **ID konwersacji:** `229`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/229_A_Debate.md`
- **Liczba węzłów dialogowych:** 144
- **Liczba wyborów gracza:** 9

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

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NFPLeader_Remus`
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus`
- `BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro`
- `BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed`
- `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGameIsolated.Debate_BasicIncomePromise`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Debate_NuclearPromise`
- `BaseGameIsolated.Debate_SpacePromise`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIPromised`
- `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Lileas`
- `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_NuclearPromised`
- `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_NuclearPromised`
- `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_SpacePromised`
- `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIPromised`
- `BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_Media`
- `BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_SpacePromised`
- `GameCondition.Turn10_A_Debate`

### Skoki między-konwersacyjne:
- Węzeł `[91]` -> **[230] Sordland/Turn10/New party convo** (../Turn_10/230_New_party_convo.md), Węzeł `[1]`
- Węzeł `[92]` -> **[231] Sordland/Turn10/Term plans** (../Turn_10/231_Term_plans.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 18

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[21]` (Mansoun Leke): `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] = true;`
- Węzeł `[22]` (Mansoun Leke): `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] = true;`
- Węzeł `[23]` (Mansoun Leke): `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] = true;`
- Węzeł `[24]` (Mansoun Leke): `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] = true;`
- Węzeł `[25]` (Mansoun Leke): `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = true;`
- Węzeł `[26]` (Mansoun Leke): `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] = true;`
- Węzeł `[105]` (Mansoun Leke): `Variable["BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIPromised"] = true; ;`
- Węzeł `[109]` (Mansoun Leke): `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIPromised"] = true;`
- *...oraz 10 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Mansoun Leke)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[6]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true   or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true   or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[12]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[14]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[15]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true  and  Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[17]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true  and  Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[18]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true  and  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true  and  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[22]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[23]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[24]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[25]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[26]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "The makeup girl dusted my cheeks with one last coat of powder as the lights in the Sordish Broadcasting Corporation studio flickered to life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Back during the '53 election, I had debated my political opponents on the radio. Now the debate was to be televised, like everything else these days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Check your reflection."]** — Mówca: **Player_Italic**
> "I pulled out a pocket mirror and looked at my face. I didn't remember all those wrinkles being there four years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "Have a seat."]** — Mówca: **Player_Italic**
> "I took my place in one of the uncomfortable wooden chairs next to the moderator's desk, beside the other presidential candidates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "Take a sip of something strong."]** — Mówca: **Player_Italic**
> "I pulled a flask from out of my coat pocket and took a quick nip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The moderator walked in and sat at her desk. I recognized her as a former SBC reporter I'd encountered on a number of occasions. She nodded to me and the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Moderator**
> ""We'll begin in just a few minutes. I'm looking forward to an evening of polite and civil discourse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Just don't forget who you work for.""]** — Mówca: **Player**
> ""Just don't forget who you work for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WYBÓR GRACZA: ""One can only hope.""]** — Mówca: **Player**
> ""One can only hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Ha. Where's the fun in that?""]** — Mówca: **Player**
> ""Ha. Where's the fun in that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "She forced a smile before turning back towards the cameras. After a quick countdown, we were live."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Narrator**
> "She smiled at me gratefully before turning back towards the cameras. After a quick countdown, we were live."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Moderator**
> ""Good evening, ladies and gentlemen. The Sordish Broadcasting Company is pleased to welcome all candidates in the 1957 Sordish presidential election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Moderator**
> ""To my left is Anton Rayne, the incumbent president of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Glad to be here.""]** — Mówca: **Player**
> ""Glad to be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""A Morgna wes core!""]** — Mówca: **Player**
> ""A Morgna wes core!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I kept my mouth shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Narrator**
> "He and Mansoun exchanged nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[48]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[50]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[51]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[53]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[54]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[56]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[57]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[60]`
Mówca: **Moderator**
> ""Kesaro Kibener, leader of the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[61]`
Mówca: **Denis Stahler**
> ""That's right. The President may have tried to silence me, but he couldn't silence our movement. The poor and downtrodden of Sordland *will* unite and rise up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[62]`
Mówca: **Moderator**
> ""To my right, Lileas Graf, former Interior Minister and leader of the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[63]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[65]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[66]`
Mówca: **Moderator**
> ""Our last candidate is Denis Stahler of the Communist Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[67]`
Mówca: **Moderator**
> ""Frens Ricter, leader of the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
Mówca: **Moderator**
> ""Mansoun Leke of the Bludish Workers' Party -- formerly an independent Assembly member.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[69]`
Mówca: **Moderator**
> ""Remus Holstron, new chairman of the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[70]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""A new era of freedom and justice is about to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[74]`
Mówca: **Moderator**
> ""Manoly Suheil, new leader of the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Manoly Suheil**
> ""It's an honor to be here. Despite the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[76]`
Mówca: **Kesaro Kibener**
> ""Greci Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Remus stiffly saluted. The "Iron Wall" had never been much for words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[78]`
Mówca: **Mansoun Leke**
> ""Indeed. The great Fetih Ejall and I once dreamed of a lasting peace for Bludia and Sordland. After his departure, I have recommitted to that dream and to my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[79]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true && (BaseGame.Policy_Law_Threshold_Default == true || (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true && (BaseGame.Policy_Law_Threshold_Default == true || (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  (Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true && (BaseGame.Policy_Law_Threshold_Default == true || (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  (Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Stahler looked at me, his eyes full of fury. A year in prison hadn't dulled his edge. Quite the opposite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
Mówca: **Denis Stahler**
> ""And of the People's Front coalition. Together, we will not be silenced. The poor and downtrodden of Sordland *will* unite and rise up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[84]`
Mówca: **Denis Stahler**
> ""That's right. We may have failed to meet the threshold last time, but the poor and downtrodden of Sordland *will* unite and rise up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Narrator**
> "I thought I saw Frens roll his eyes. He and Denis had been fierce rivals since the latter left the PFJP decades ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Moderator**
> ""Now that everyone's been introduced, let's proceed to the questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `230` (*Sordland/Turn10/New party convo*), Węzeł `[1]`

### Węzeł `[92]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `231` (*Sordland/Turn10/Term plans*), Węzeł `[1]`

### Węzeł `[93]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Lileas Graf**
> ""And protector of the legacy of Tarquin Soll, God rest his soul. I'm looking forward to your questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[97]`
Mówca: **Lileas Graf**
> ""And protector of the legacy of Tarquin Soll, lest we forget. I'm looking forward to your questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[98]`
Mówca: **Narrator**
> "She shot a pointed glance in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[99]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_BasicIncomePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_BasicIncomePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[101]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_BasicIncomePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_NuclearPromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_NuclearPromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[104]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_NuclearPromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_NuclearPromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[105]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIPromised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIPromised"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIPromised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[110]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_NuclearPromised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_NuclearPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_SordlandFirstDebate_NuclearPromised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_NuclearPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_SpacePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_SpacePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[118]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_SpacePromised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_SpacePromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_SordlandFirstDebate_SpacePromised = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_SpacePromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[120]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: GameCondition.Turn10_A_Debate = true;)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn10_A_Debate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[124]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Lileas = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[131]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_Media = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[132]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[133]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[135]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[136]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[138]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[139]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[140]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_USPBrooch"))*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_USPBrooch");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[141]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[143]`
Mówca: **Mansoun Leke**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
