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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[29]` | **"Check your reflection."** | `[28]` **Narrator**: "Back during the '53 election, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Player_Italic**: "I took my place in one of the un..." |
| `[30]` | **"Have a seat."** | `[29]` **Player_Italic**: "I pulled out a pocket mirror and..."<br>`[31]` **Player_Italic**: "I pulled a flask from out of my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "The moderator walked in and sat ..." |
| `[31]` | **"Take a sip of something strong."** | `[28]` **Narrator**: "Back during the '53 election, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Player_Italic**: "I took my place in one of the un..." |
| `[34]` | **""Just don't forget who you work for.""** | `[33]` **Moderator**: ""We'll begin in just a few minut..." | `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[40]` **Narrator**: "She forced a smile before turnin..." |
| `[38]` | **""One can only hope.""** | `[33]` **Moderator**: ""We'll begin in just a few minut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "She smiled at me gratefully befo..." |
| `[39]` | **""Ha. Where's the fun in that?""** | `[33]` **Moderator**: ""We'll begin in just a few minut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She forced a smile before turnin..." |
| `[44]` | **""Glad to be here.""** | `[43]` **Moderator**: ""To my left is Anton Rayne, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Moderator**: ""To my right, Lileas Graf, forme..."<br>`[67]` **Moderator**: ""Frens Ricter, leader of the PFJP.""<br>*(oraz 1 innych odgałęzień)* |
| `[45]` | **""A Morgna wes core!""** | `[43]` **Moderator**: ""To my left is Anton Rayne, the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[62]` **Moderator**: ""To my right, Lileas Graf, forme..."<br>`[67]` **Moderator**: ""Frens Ricter, leader of the PFJP."" |
| `[46]` | **"Say nothing."** | `[43]` **Moderator**: ""To my left is Anton Rayne, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Moderator**: ""To my right, Lileas Graf, forme..."<br>`[67]` **Moderator**: ""Frens Ricter, leader of the PFJP.""<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true )"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn0..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_I..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn0..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Tur..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true   or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true   or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Inv..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke = true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == false)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "The makeup girl dusted my cheeks with one last coat of po..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf = true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_I..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true  and  Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil = true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PFJPLeader_Manoly == true && BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true  and  Variable["BaseGame.Turn09_A_Investigation_PFJP_ManolyFramed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Inv..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_I..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true  and  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron = true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NFPLeader_Remus == true && BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true  and  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_Remus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener = true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn0..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn0..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "The makeup girl dusted my cheeks with one last coat of po..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "The makeup girl dusted my cheeks with one last coat of powder as the lights in the Sordish Broadcasting Corporation studio flickered to life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Back during the '53 election, I had debated my political opponents on the radio. Now the debate was to be televised, like everything else these days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Italic: "Check your reflection."*)
  - -> `[31]` (*Player_Italic: "Take a sip of something strong."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Check your reflection."]** — Mówca: **Player_Italic**
> "I pulled out a pocket mirror and looked at my face. I didn't remember all those wrinkles being there four years ago."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Italic: "Have a seat."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "Have a seat."]** — Mówca: **Player_Italic**
> "I took my place in one of the uncomfortable wooden chairs next to the moderator's desk, beside the other presidential candidates."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Italic), `[31]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The moderator walked in and sat at her desk. I recognized..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "Take a sip of something strong."]** — Mówca: **Player_Italic**
> "I pulled a flask from out of my coat pocket and took a quick nip."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Italic: "Have a seat."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The moderator walked in and sat at her desk. I recognized her as a former SBC reporter I'd encountered on a number of occasions. She nodded to me and the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Moderator: ""We'll begin in just a few minutes. I'm looking forward t..."*)

### Węzeł `[33]`
Mówca: **Moderator**
> ""We'll begin in just a few minutes. I'm looking forward to an evening of polite and civil discourse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""One can only hope.""*)
  - -> `[39]` (*Player: ""Ha. Where's the fun in that?""*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Just don't forget who you work for.""]** — Mówca: **Player**
> ""Just don't forget who you work for.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She forced a smile before turning back towards the camera..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Just don't forget who you work for.""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WYBÓR GRACZA: ""One can only hope.""]** — Mówca: **Player**
> ""One can only hope.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "She smiled at me gratefully before turning back towards t..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Ha. Where's the fun in that?""]** — Mówca: **Player**
> ""Ha. Where's the fun in that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She forced a smile before turning back towards the camera..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She forced a smile before turning back towards the cameras. After a quick countdown, we were live."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Moderator: ""Good evening, ladies and gentlemen. The Sordish Broadcas..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "She smiled at me gratefully before turning back towards the cameras. After a quick countdown, we were live."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Moderator: ""Good evening, ladies and gentlemen. The Sordish Broadcas..."*)

### Węzeł `[42]`
Mówca: **Moderator**
> ""Good evening, ladies and gentlemen. The Sordish Broadcasting Company is pleased to welcome all candidates in the 1957 Sordish presidential election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Moderator: ""To my left is Anton Rayne, the incumbent president of So..."*)

### Węzeł `[43]`
Mówca: **Moderator**
> ""To my left is Anton Rayne, the incumbent president of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""Glad to be here.""*)
  - -> `[45]` (*Player: ""A Morgna wes core!""*)
  - -> `[46]` (*Player_Italic: "Say nothing."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Glad to be here.""]** — Mówca: **Player**
> ""Glad to be here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""A Morgna wes core!""]** — Mówca: **Player**
> ""A Morgna wes core!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I kept my mouth shut."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "He and Mansoun exchanged nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Moderator: ""Now that everyone's been introduced, let's proceed to th..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Moderator: ""To my right, Lileas Graf, former Interior Minister and l..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Moderator: ""Mansoun Leke of the Bludish Workers' Party -- formerly a..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Moderator: ""Our last candidate is Denis Stahler of the Communist Par..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Moderator: ""Frens Ricter, leader of the PFJP.""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Moderator: ""Kesaro Kibener, leader of the NFP.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[60]`
Mówca: **Moderator**
> ""Kesaro Kibener, leader of the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Kesaro Kibener: ""Greci Sordland.""*)

### Węzeł `[61]`
Mówca: **Denis Stahler**
> ""That's right. The President may have tried to silence me, but he couldn't silence our movement. The poor and downtrodden of Sordland *will* unite and rise up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Stahler looked at me, his eyes full of fury. A year in pr..."*)

### Węzeł `[62]`
Mówca: **Moderator**
> ""To my right, Lileas Graf, former Interior Minister and leader of the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_RedYouth == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Denis Stahler: ""That's right. The President may have tried to silence me..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true && (Ba..."*)

### Węzeł `[66]`
Mówca: **Moderator**
> ""Our last candidate is Denis Stahler of the Communist Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth == true"*)

### Węzeł `[67]`
Mówca: **Moderator**
> ""Frens Ricter, leader of the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Frens Ricter: ""A new era of freedom and justice is about to begin.""*)

### Węzeł `[68]`
Mówca: **Moderator**
> ""Mansoun Leke of the Bludish Workers' Party -- formerly an independent Assembly member.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Mansoun Leke: ""Indeed. The great Fetih Ejall and I once dreamed of a la..."*)

### Węzeł `[69]`
Mówca: **Moderator**
> ""Remus Holstron, new chairman of the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Remus stiffly saluted. The "Iron Wall" had never been muc..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Moderator: ""Remus Holstron, new chairman of the NFP.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""A new era of freedom and justice is about to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[74]`
Mówca: **Moderator**
> ""Manoly Suheil, new leader of the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Manoly Suheil: ""It's an honor to be here. Despite the circumstances.""*)

### Węzeł `[75]`
Mówca: **Manoly Suheil**
> ""It's an honor to be here. Despite the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "She shot a pointed glance in my direction."*)

### Węzeł `[76]`
Mówca: **Kesaro Kibener**
> ""Greci Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Remus stiffly saluted. The "Iron Wall" had never been much for words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[78]`
Mówca: **Mansoun Leke**
> ""Indeed. The great Fetih Ejall and I once dreamed of a lasting peace for Bludia and Sordland. After his departure, I have recommitted to that dream and to my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Moderator: ""Our last candidate is Denis Stahler of the Communist Par..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true && (BaseGame.Policy_Law_Threshold_Default == true || (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true && (Ba..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true && (..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true && (BaseGame.Policy_Law_Threshold_Default == true || (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  (Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Denis Stahler: ""And of the People's Front coalition. Together, we will n..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true && (BaseGame.Policy_Law_Threshold_Default == true || (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  (Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Denis Stahler: ""That's right. We may have failed to meet the threshold l..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Stahler looked at me, his eyes full of fury. A year in prison hadn't dulled his edge. Quite the opposite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Moderator: ""Now that everyone's been introduced, let's proceed to th..."*)

### Węzeł `[83]`
Mówca: **Denis Stahler**
> ""And of the People's Front coalition. Together, we will not be silenced. The poor and downtrodden of Sordland *will* unite and rise up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He and Mansoun exchanged nods."*)

### Węzeł `[84]`
Mówca: **Denis Stahler**
> ""That's right. We may have failed to meet the threshold last time, but the poor and downtrodden of Sordland *will* unite and rise up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I thought I saw Frens roll his eyes. He and Denis had bee..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Moderator: ""Now that everyone's been introduced, let's proceed to th..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "I thought I saw Frens roll his eyes. He and Denis had been fierce rivals since the latter left the PFJP decades ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Moderator: ""Now that everyone's been introduced, let's proceed to th..."*)

### Węzeł `[89]`
Mówca: **Moderator**
> ""Now that everyone's been introduced, let's proceed to the questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lileas Graf: ""And protector of the legacy of Tarquin Soll, God rest hi..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lileas Graf: ""And protector of the legacy of Tarquin Soll, lest we for..."*)

### Węzeł `[96]`
Mówca: **Lileas Graf**
> ""And protector of the legacy of Tarquin Soll, God rest his soul. I'm looking forward to your questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[97]`
Mówca: **Lileas Graf**
> ""And protector of the legacy of Tarquin Soll, lest we forget. I'm looking forward to your questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "She shot a pointed glance in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_BasicIncomePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_BasicIncomePromise == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_BasicIncomePromise == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_BasicIncomePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_BasicIncomePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_BasicIncomePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_NuclearPromise == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_NuclearPromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_NuclearPromise == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_NuclearPromise == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_NuclearPromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Nuclea..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_NuclearPromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_NuclearPromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIPromised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIPromised"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIProm..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_E_SordlandFirstDebate_UBIProm..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIProm..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIPromised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_UBIPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_NuclearPromise == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_NuclearPromised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_NuclearPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_SordlandFirstDebate_Nuclear..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_NuclearPromised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_NuclearPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_SpacePromise == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_SpaceP..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_SpacePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_SpacePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_SpacePromised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_SpacePromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_SpacePromised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_SpacePromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_SordlandFirstDebate_SpacePr..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn10_A_Debate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn10_A_Debate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Lileas..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Lileas = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_Media ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Debate = true;"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_Media = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_ST_SordlandFirstDebate_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Debate = true;"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == fa..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter = true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_NFP_Destroyed == true  || BaseGame.Turn0..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true )"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Moderator: ""Manoly Suheil, new leader of the PFJP.""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_USPBrooch")`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_USPBrooch");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Back during the '53 election, I had debated my political ..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Back during the '53 election, I had debated my political ..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_USPBrooch")"*)
