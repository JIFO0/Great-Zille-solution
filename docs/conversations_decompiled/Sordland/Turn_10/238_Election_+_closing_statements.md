# Sordland/Turn10/Election + closing statements

- **ID konwersacji:** `238`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/238_Election_+_closing_statements.md`
- **Liczba węzłów dialogowych:** 245
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
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
- `BaseGame.Decision_Turn03_Extraction_AddressProtestors`
- `BaseGame.Democratic`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Malenyevist`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_8`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Debate_SpacePromise`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_MansounLeke`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[229] Sordland/Turn10/A_Debate** (../Turn_10/229_A_Debate.md), Węzeł `[99]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""What kind of a question is that? Of course I'll accept the results.""** | `[5]` **Moderator**: ""Will you accept the results of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Denis Stahler**: ""Ha! Listen to this man.""<br>`[46]` **Frens Ricter**: ""The mere fact that you have to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[7]` | **""I will respect what the people of Sordland decide.""** | `[5]` **Moderator**: ""Will you accept the results of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Denis Stahler**: ""Ha! Listen to this man.""<br>`[46]` **Frens Ricter**: ""The mere fact that you have to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""I accepted the results when the USP voted me out, didn't I?""** | `[5]` **Moderator**: ""Will you accept the results of ..." | `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true` | *Brak zmian stanu* | `[13]` **Denis Stahler**: ""Ha! Listen to this man.""<br>`[46]` **Frens Ricter**: ""The mere fact that you have to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[12]` | **""Yes. But I pledge I will never stop fighting for my beliefs.""** | `[5]` **Moderator**: ""Will you accept the results of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Denis Stahler**: ""Ha! Listen to this man.""<br>`[46]` **Frens Ricter**: ""The mere fact that you have to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[63]` | **""I couldn't have said that better myself.""** | `[59]` **Lileas Graf**: ""This is such a disrespectful qu..."<br>`[65]` **Kesaro Kibener**: ""Surely this is a disrespectful ..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false` | *Brak zmian stanu* | `[54]` **Moderator**: ""Right. I'd like to end the even..." |
| `[64]` | **""And that's the reason I left the USP.""** | `[59]` **Lileas Graf**: ""This is such a disrespectful qu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Moderator**: ""Right. I'd like to end the even..." |
| `[67]` | **""If there is a God, you will never become president.""** | `[59]` **Lileas Graf**: ""This is such a disrespectful qu..."<br>`[65]` **Kesaro Kibener**: ""Surely this is a disrespectful ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Moderator**: ""Right. I'd like to end the even..." |
| `[68]` | **""She was well within her right to ask that. The president must never be elevated a..."** | `[59]` **Lileas Graf**: ""This is such a disrespectful qu..."<br>`[65]` **Kesaro Kibener**: ""Surely this is a disrespectful ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Moderator**: ""Right. I'd like to end the even..." |
| `[135]` | **""I've already said everything I need to say. Thank you for a pleasant evening.""** | `[113]` **Moderator**: ""President Rayne?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Moderator**: ""Very well. Thanks to all the ca..." |
| `[136]` | **""Why accept my opponents' mediocre promises when you could have... the moon?""** | `[113]` **Moderator**: ""President Rayne?"" | `Variable["BaseGameIsolated.Debate_SpacePromise"] == true` | *Brak zmian stanu* | `[139]` **Moderator**: ""Very well. Thanks to all the ca..." |
| `[137]` | **""People of Sordland... we have only just begun.""** | `[113]` **Moderator**: ""President Rayne?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Moderator**: ""Very well. Thanks to all the ca..." |
| `[138]` | **""A new day began to dawn. We must not abandon what we started.""** | `[113]` **Moderator**: ""President Rayne?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Moderator**: ""Very well. Thanks to all the ca..." |
| `[151]` | **""I understand your concerns given my predecessors' attempts to cling to power. But..."** | `[46]` **Frens Ricter**: ""The mere fact that you have to ..."<br>`[53]` **Manoly Suheil**: ""The mere fact that you have to ..." | `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false` | *Brak zmian stanu* | `[54]` **Moderator**: ""Right. I'd like to end the even..." |
| `[152]` | **""Of course, there's always the possibility of election fraud, in which case I will..."** | `[46]` **Frens Ricter**: ""The mere fact that you have to ..."<br>`[53]` **Manoly Suheil**: ""The mere fact that you have to ..." | `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`<br>`(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false` | *Brak zmian stanu* | `[54]` **Moderator**: ""Right. I'd like to end the even..." |
| `[172]` | **""Denis, I have nothing but admiration for you and your ideology. Please do not tes..."** | `[191]` **Narrator**: "The studio went deathly silent." | `Variable["BaseGame.Malenyevist"] > 15` | *Brak zmian stanu* | `[168]` **Denis Stahler**: ""Admiration? You had me thrown i..."<br>`[205]` **Narrator**: "Denis gaped at me indignantly, t..." |
| `[181]` | **""Don't make me do it again.""** | `[168]` **Denis Stahler**: ""Admiration? You had me thrown i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Denis sat, his face red. None of..." |
| `[182]` | **""I didn't give that order.""** | `[168]` **Denis Stahler**: ""Admiration? You had me thrown i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Denis Stahler**: ""Abdicating responsibility. A go..." |
| `[190]` | **""Leave this building. Now.""** | `[201]` **Denis Stahler**: ""I--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Denis Stahler**: ""Gladly."" |
| `[192]` | **""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely fo..."** | `[191]` **Narrator**: "The studio went deathly silent." | `Variable["BaseGame.Democratic"] < -10` | *Brak zmian stanu* | `[211]` **Narrator**: "Denis paled slightly." |
| `[193]` | **""Sit back down. Now.""** | `[201]` **Denis Stahler**: ""I--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Denis sat, his face red. None of..." |
| `[194]` | **""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""** | `[191]` **Narrator**: "The studio went deathly silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Denis Stahler**: ""Gladly."" |
| `[200]` | **""I have no idea what you're talking about.""** | `[191]` **Narrator**: "The studio went deathly silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Denis Stahler**: ""The hell you do."" |
| `[203]` | **""If I was censoring the media, would I permit you to make this kind of scene?""** | `[199]` **Denis Stahler**: ""The hell you do."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Narrator**: "Denis gaped at me indignantly, t..." |
| `[204]` | **""Whatever you think you know about me, it's a lie.""** | `[199]` **Denis Stahler**: ""The hell you do."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Denis Stahler**: ""I won't play this game a second..." |
| `[206]` | **""Guards, this man is a danger to me. Please escort him out of the building at once.""** | `[199]` **Denis Stahler**: ""The hell you do."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Denis Stahler**: ""I'll find my own way out."" |
| `[226]` | **""The Red Youth were out of control. You should have done something.""** | `[168]` **Denis Stahler**: ""Admiration? You had me thrown i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Denis Stahler**: ""They're more violent than they ..." |

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
  - -> `[3]` (*Moderator: ""Uh, it appears we have time for one last question.""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""People of Sordland, I have watched this man lead our gre..."*)

### Węzeł `[3]`
Mówca: **Moderator**
> ""Uh, it appears we have time for one last question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Moderator: ""President Rayne, given this country's rather turbulent p..."*)

### Węzeł `[4]`
Mówca: **Moderator**
> ""President Rayne, given this country's rather turbulent political history...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Moderator: ""Will you accept the results of the election, whatever th..."*)

### Węzeł `[5]`
Mówca: **Moderator**
> ""Will you accept the results of the election, whatever they are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""What kind of a question is that? Of course I'll accept t..."*)
  - -> `[7]` (*Player: ""I will respect what the people of Sordland decide.""*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[12]` (*Player: ""Yes. But I pledge I will never stop fighting for my beli..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""What kind of a question is that? Of course I'll accept the results.""]** — Mówca: **Player**
> ""What kind of a question is that? Of course I'll accept the results.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I will respect what the people of Sordland decide.""]** — Mówca: **Player**
> ""I will respect what the people of Sordland decide.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""I accepted the results when the USP voted me out, didn't I?""]** — Mówca: **Player**
> ""I accepted the results when the USP voted me out, didn't I?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: ""I accepted the results when the USP voted me out, didn't..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Yes. But I pledge I will never stop fighting for my beliefs.""]** — Mówca: **Player**
> ""Yes. But I pledge I will never stop fighting for my beliefs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_..."*)

### Węzeł `[13]`
Mówca: **Denis Stahler**
> ""Ha! Listen to this man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true || BaseGame.Refor..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge == false"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[17]`
Mówca: **Denis Stahler**
> ""You're going to trust someone who promised change, only to warp the constitution to suit his own desires?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Denis Stahler: ""You're going to trust someone who promised change, only ..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Denis Stahler: ""You're going to trust someone who promised change, only ..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Denis Stahler: ""You're going to trust someone who fabricated an emergenc..."*)

### Węzeł `[24]`
Mówca: **Denis Stahler**
> ""You're going to trust someone who promised change, only to attempt to warp the constitution to suit his own desires?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[25]`
Mówca: **Denis Stahler**
> ""You're going to trust someone who fabricated an emergency as an excuse to seize power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[26]`
Mówca: **Moderator**
> ""Mr. Stahler, my question was for the President alone. Please don't interrupt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Denis Stahler: ""I cannot fucking believe this!""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Moderator: ""Mr. Stahler, my question was for the President alone. Pl..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_DenisChallenge == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge == false"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_DenisChallenge == false)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_DenisChallenge == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Denis Stahler: ""Ha! Listen to this man.""*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_DenisChallenge == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_DenisChallenge"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_DenisStahler == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Denis looked like he wanted to say something, but thought..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_DenisStahler == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Denis looked like he wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Mansoun looked like he wanted to say something, but thoug..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Mansoun looked like he wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Frens looked like he wanted to say something, but thought..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Manoly looked like she wanted to say something, but thoug..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Manoly looked like she wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Frens looked like he wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[46]`
Mówca: **Frens Ricter**
> ""The mere fact that you have to ask that question is proof that Sordland is far from the democracy it must become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Frens Ricter: ""The mere fact that you have to ask that question is proo..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manoly Suheil: ""The mere fact that you have to ask that question is proo..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf"*)

### Węzeł `[53]`
Mówca: **Manoly Suheil**
> ""The mere fact that you have to ask that question is proof that Sordland is far from the democracy it must become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf"*)

### Węzeł `[54]`
Mówca: **Moderator**
> ""Right. I'd like to end the evening by allowing each candidate to make a short closing statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler == false"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Denis looked at the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Denis Stahler: ""No further comment. The events of this evening speak for..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: ""This is such a disrespectful question to ask a sitting p..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""This is such a disrespectful question to ask a sitting president. The leader of Sordland shall stay in power for however long its people and God will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""I couldn't have said that better myself.""*)
  - -> `[64]` (*Player: ""And that's the reason I left the USP.""*)
  - -> `[67]` (*Player: ""If there is a God, you will never become president.""*)
  - -> `[68]` (*Player: ""She was well within her right to ask that. The president..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Kesaro Kibener: ""Surely this is a disrespectful question to ask a sitting..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I couldn't have said that better myself.""]** — Mówca: **Player**
> ""I couldn't have said that better myself.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Lileas Graf), `[65]` (Kesaro Kibener), `[66]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""And that's the reason I left the USP.""]** — Mówca: **Player**
> ""And that's the reason I left the USP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""Surely this is a disrespectful question to ask a sitting president. The leader of Sordland shall stay in power for however long its people and God will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""I couldn't have said that better myself.""*)
  - -> `[67]` (*Player: ""If there is a God, you will never become president.""*)
  - -> `[68]` (*Player: ""She was well within her right to ask that. The president..."*)

### Węzeł `[66]`
Mówca: **Remus Holstron**
> ""How dare you ask that of a sitting president? The leader of Sordland shall stay in power for however long is the Sords and God wills it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""I couldn't have said that better myself.""*)
  - -> `[67]` (*Player: ""If there is a God, you will never become president.""*)
  - -> `[68]` (*Player: ""She was well within her right to ask that. The president..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""If there is a God, you will never become president.""]** — Mówca: **Player**
> ""If there is a God, you will never become president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lileas Graf), `[65]` (Kesaro Kibener), `[66]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""She was well within her right to ask that. The president must never be elevated above anyone else.""]** — Mówca: **Player**
> ""She was well within her right to ask that. The president must never be elevated above anyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lileas Graf), `[65]` (Kesaro Kibener), `[66]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_DenisChallenge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_DenisChallenge == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_DenisChallenge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler == true"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_DenisChallenge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_DenisChallenge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Polic..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_DenisStahler == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Denis looked at the floor."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_DenisStahler == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Mansoun Leke: ""I agree. No further comment.""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[78]`
Mówca: **Denis Stahler**
> ""No further comment. The events of this evening speak for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke"*)

### Węzeł `[79]`
Mówca: **Mansoun Leke**
> ""I agree. No further comment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[80]`
Mówca: **Frens Ricter**
> ""I have nothing to add. I trust the Sordish people will make the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Frens Ricter: ""I have nothing to add. I trust the Sordish people will m..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[84]`
Mówca: **Manoly Suheil**
> ""I have nothing to add. I trust the Sordish people will make the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Mansoun Leke: "Mansoun looked at Denis' empty chair."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[88]`
Mówca: **Mansoun Leke**
> "Mansoun looked at Denis' empty chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Mansoun Leke: ""I won't comment further. The events of this evening spea..."*)

### Węzeł `[89]`
Mówca: **Mansoun Leke**
> ""I won't comment further. The events of this evening speak for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Frens looked at Denis and Mansoun's empty chairs."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Frens looked at Denis and Mansoun's empty chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Frens Ricter: ""I have nothing to add. I trust the Sordish people will m..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Manoly looked at Denis and Mansoun's empty chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Manoly Suheil: ""I have nothing to add. I trust the Sordish people will m..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lileas Graf: ""Well, I will say something.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[98]`
Mówca: **Lileas Graf**
> ""Well, I will say something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""People of Sordland, I have watched this man lead our gre..."*)

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""People of Sordland, I have watched this man lead our great country astray. Place your trust in me, and I will put us back on the path that the Lord chose for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Remus Holstron: ""I am a man of action, not of words.""*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Moderator: ""President Rayne?""*)

### Węzeł `[106]`
Mówca: **Kesaro Kibener**
> ""Whatever differences of opinion President Rayne and I expressed during this debate, the NFP is prepared to stand with him and his party. For a Sordland that truly belongs to the Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Moderator: ""President Rayne?""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Kesaro Kibener: ""Whatever differences of opinion President Rayne and I ex..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Kesaro Kibener: ""For a Sordland that truly belongs to its own people, the..."*)

### Węzeł `[110]`
Mówca: **Kesaro Kibener**
> ""For a Sordland that truly belongs to its own people, there is only one way to vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Moderator: ""President Rayne?""*)

### Węzeł `[111]`
Mówca: **Remus Holstron**
> ""I am a man of action, not of words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Remus Holstron: ""Vote NFP. For a Sordland that truly belongs to the Sords..."*)

### Węzeł `[112]`
Mówca: **Remus Holstron**
> ""Vote NFP. For a Sordland that truly belongs to the Sords. We shall realise our destiny as a great people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Moderator: ""President Rayne?""*)

### Węzeł `[113]`
Mówca: **Moderator**
> ""President Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""I've already said everything I need to say. Thank you fo..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)
  - -> `[137]` (*Player: ""People of Sordland... we have only just begun.""*)
  - -> `[138]` (*Player: ""A new day began to dawn. We must not abandon what we sta..."*)

### Węzeł `[114]`
Mówca: **Denis Stahler**
> ""I am grateful to the President for finally paving the way for my party into Assembly. But I ask you: Why stop there? Sordish Socialism is upon our doorstep. All that is left to do is embrace it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Polic..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Pol..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Denis Stahler: ""I am grateful to the President for finally paving the wa..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Denis Stahler: ""My party spent years shut out of assembly while the voic..."*)

### Węzeł `[118]`
Mówca: **Denis Stahler**
> ""My party spent years shut out of assembly while the voices of thousands of Sords were denied. It is time for a new way forward. The People's Front is the future Sordland deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Denis Stahler: ""Join our coalition and we promise equality for every man..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[122]`
Mówca: **Denis Stahler**
> ""Join our coalition and we promise equality for every man and woman, every Blud and Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[123]`
Mówca: **Mansoun Leke**
> ""Now that smaller parties have been given a voice, it is time to rise up and make your own heard. Man or woman, Blud or Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Mansoun Leke: ""Now that smaller parties have been given a voice, it is ..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[127]`
Mówca: **Frens Ricter**
> ""I know Sordland is ready for democracy. Under the PFJP, you will enjoy a freedom you have never known before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[131]`
Mówca: **Manoly Suheil**
> ""My predecessor Frens Ricter believed that Sordland was finally ready for democracy. It's time for the people to prove him right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""People of Sordland, I have watched this man lead our gre..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I've already said everything I need to say. Thank you for a pleasant evening.""]** — Mówca: **Player**
> ""I've already said everything I need to say. Thank you for a pleasant evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Moderator: ""Very well. Thanks to all the candidates for your time to..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Why accept my opponents' mediocre promises when you could have... the moon?""]** — Mówca: **Player**
> ""Why accept my opponents' mediocre promises when you could have... the moon?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Moderator: ""Very well. Thanks to all the candidates for your time to..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""People of Sordland... we have only just begun.""]** — Mówca: **Player**
> ""People of Sordland... we have only just begun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Moderator: ""Very well. Thanks to all the candidates for your time to..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""A new day began to dawn. We must not abandon what we started.""]** — Mówca: **Player**
> ""A new day began to dawn. We must not abandon what we started.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Moderator: ""Very well. Thanks to all the candidates for your time to..."*)

### Węzeł `[139]`
Mówca: **Moderator**
> ""Very well. Thanks to all the candidates for your time tonight. The Sordish Broadcasting Corporation wishes all our viewers a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "She motioned to the crew, and the cameras stopped rolling."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "She motioned to the crew, and the cameras stopped rolling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Frens Ricter: ""Whatever differences President Rayne and I expressed dur..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Frens Ricter: ""I know Sordland is ready for democracy. Under the PFJP, ..."*)

### Węzeł `[144]`
Mówca: **Frens Ricter**
> ""Whatever differences President Rayne and I expressed during this debate, our alliance still stands. No matter who wins, we will govern together to bring Sordland a freedom it has never known before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_SpacePromise == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""Why accept my opponents' mediocre promises when you coul..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_SpacePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_SpacePromise"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Remus Holstron: ""How dare you ask that of a sitting president? The leader..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""I couldn't have said that better myself.""*)
  - -> `[151]` (*Player: ""I understand your concerns given my predecessors' attemp..."*)
  - -> `[152]` (*Player: ""Of course, there's always the possibility of election fr..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I understand your concerns given my predecessors' attempts to cling to power. But I swear I will serve only as long as the people want me.""]** — Mówca: **Player**
> ""I understand your concerns given my predecessors' attempts to cling to power. But I swear I will serve only as long as the people want me.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Frens Ricter), `[53]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Of course, there's always the possibility of election fraud, in which case I will fight to make sure the will of the people is respected.""]** — Mówca: **Player**
> ""Of course, there's always the possibility of election fraud, in which case I will fight to make sure the will of the people is respected.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false` AND `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Frens Ricter), `[53]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Manoly looked at Denis and Mansoun's empty chairs."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Manoly Suheil: ""My predecessor Frens Ricter believed that Sordland was f..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler == false"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_DenisStahler == false)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Moderator: ""Um...with those who remain at least.""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_DenisStahler == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge == true"*)

### Węzeł `[162]`
Mówca: **Moderator**
> ""Um...with those who remain at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge == true"*)

### Węzeł `[163]`
Mówca: **Mansoun Leke**
> ""Denis, calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Denis Stahler: ""No. The charade has gone on long enough. How can the bla..."*)

### Węzeł `[164]`
Mówca: **Denis Stahler**
> ""No. The charade has gone on long enough. How can the blatant censorship of the media go unremarked upon on this stage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Facti..."*)

### Węzeł `[165]`
Mówca: **Denis Stahler**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "The moderator took a minute to regain her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Moderator: ""Right. I'd like to end the evening by allowing each cand..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Denis rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_Extraction_AddressProtestors == ..."*)

### Węzeł `[168]`
Mówca: **Denis Stahler**
> ""Admiration? You had me thrown in prison!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""I didn't give that order.""*)
  - -> `[181]` (*Player: ""Don't make me do it again.""*)
  - -> `[226]` (*Player: ""The Red Youth were out of control. You should have done ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Mansoun Leke: ""Denis, calm down.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Denis Stahler: ""This charade has gone on long enough. Can't you others s..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""]** — Mówca: **Player**
> ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] > 15`
- **Kontekst wejściowy (poprzednik):** `[191]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[173]`
Mówca: **Denis Stahler**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[174]`
Mówca: **Denis Stahler**
> ""This charade has gone on long enough. Can't you others see he has the media rigged against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Facti..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Facti..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Fac..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true || Ba..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true || Ba..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true || ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Denis Stahler: ""Not to mention the disappearance of one of the most prom..."*)
  - -> `[183]` (*Denis Stahler: ""Not to mention the disappearance of one of the most prom..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Don't make me do it again.""]** — Mówca: **Player**
> ""Don't make me do it again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Denis sat, his face red. None of the other candidates spoke."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I didn't give that order.""]** — Mówca: **Player**
> ""I didn't give that order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Denis Stahler: ""Abdicating responsibility. A good look for a President.""*)

### Węzeł `[183]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[184]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[185]`
Mówca: **Denis Stahler**
> ""Let's go, Mansoun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_Default == true || BaseGame..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Denis Stahler: ""To say nothing of the mysterious deaths of certain indiv..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "The studio went deathly silent."*)

### Węzeł `[189]`
Mówca: **Denis Stahler**
> ""To say nothing of the mysterious deaths of certain individuals in the President's orbit...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "The studio went deathly silent."*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Leave this building. Now.""]** — Mówca: **Player**
> ""Leave this building. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Denis Stahler: ""Gladly.""*)

### Węzeł `[191]`
Mówca: **Narrator**
> "The studio went deathly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic < -10"*)
  - -> `[194]` (*Player: ""Mr. Stahler. Leave this stage and do not ever show your ..."*)
  - -> `[200]` (*Player: ""I have no idea what you're talking about.""*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""]** — Mówca: **Player**
> ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Democratic"] < -10`
- **Kontekst wejściowy (poprzednik):** `[191]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Denis paled slightly."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Sit back down. Now.""]** — Mówca: **Player**
> ""Sit back down. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Denis sat, his face red. None of the other candidates spoke."*)

### Węzeł `[194]`
**[WYBÓR GRACZA: ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""]** — Mówca: **Player**
> ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Denis Stahler: ""Gladly.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 15)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""Denis, I have nothing but admiration for you and your id..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
Mówca: **Denis Stahler**
> ""I'll find my own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[199]`
Mówca: **Denis Stahler**
> ""The hell you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""Guards, this man is a danger to me. Please escort him ou..."*)
  - -> `[204]` (*Player: ""Whatever you think you know about me, it's a lie.""*)
  - -> `[203]` (*Player: ""If I was censoring the media, would I permit you to make..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I have no idea what you're talking about.""]** — Mówca: **Player**
> ""I have no idea what you're talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Denis Stahler: ""The hell you do.""*)

### Węzeł `[201]`
Mówca: **Denis Stahler**
> ""I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""Sit back down. Now.""*)
  - -> `[190]` (*Player: ""Leave this building. Now.""*)

### Węzeł `[202]`
Mówca: **Denis Stahler**
> ""Abdicating responsibility. A good look for a President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""If I was censoring the media, would I permit you to make this kind of scene?""]** — Mówca: **Player**
> ""If I was censoring the media, would I permit you to make this kind of scene?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Denis gaped at me indignantly, then sat, his face red."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Whatever you think you know about me, it's a lie.""]** — Mówca: **Player**
> ""Whatever you think you know about me, it's a lie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Denis Stahler: ""I won't play this game a second longer.""*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Denis gaped at me indignantly, then sat, his face red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Denis Stahler: ""Unbelievable.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Guards, this man is a danger to me. Please escort him out of the building at once.""]** — Mówca: **Player**
> ""Guards, this man is a danger to me. Please escort him out of the building at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Denis Stahler: ""I'll find my own way out.""*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Denis Stahler: ""Admiration? You had me thrown in prison!""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Denis gaped at me indignantly, then sat, his face red."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Denis sat, his face red. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[211]`
Mówca: **Narrator**
> "Denis paled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Denis Stahler: ""I--""*)

### Węzeł `[212]`
Mówca: **Denis Stahler**
> ""I won't play this game a second longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Denis Stahler: ""Let's go, Mansoun.""*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Denis loudly pushed his chair back and stormed out of the..."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "He and Denis walked out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseG..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic < -10"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic < -10)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic < -10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: ""Mr. Stahler. If I really am as powerful as you claim, wo..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic < -10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_DenisChallenge = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "The moderator took a minute to regain her composure."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_Default == true || BaseGame..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_Default == true || BaseGa..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "Mansoun got up and looked into the camera."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Mansoun Leke: ""Sorry, Denis, I can't risk it. You're on your own.""*)

### Węzeł `[224]`
Mówca: **Denis Stahler**
> ""They're more violent than they used to be, I'll agree with you there. But your reaction crossed a line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Denis Stahler: ""Let's just get this dog and pony show over with.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""The Red Youth were out of control. You should have done something.""]** — Mówca: **Player**
> ""The Red Youth were out of control. You should have done something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Denis Stahler: ""They're more violent than they used to be, I'll agree wi..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseGameIsolated.Debate_Enable_DenisStahler = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false;
Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[228]`
Mówca: **Mansoun Leke**
> ""It doesn't have to be this way. Vote People's Front for real change in '57.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "He and Denis walked out of the studio. None of the other ..."*)

### Węzeł `[229]`
Mówca: **Denis Stahler**
> ""I cannot fucking believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Denis rose from his seat."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Denis loudly pushed his chair back and stormed out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler = false"*)

### Węzeł `[231]`
Mówca: **Denis Stahler**
> ""Let's just get this dog and pony show over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Denis sat, his face red. None of the other candidates spoke."*)

### Węzeł `[232]`
Mówca: **Mansoun Leke**
> ""Sorry, Denis, I can't risk it. You're on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Denis loudly pushed his chair back and stormed out of the..."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "Mansoun got up and looked into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Mansoun Leke: ""It doesn't have to be this way. Vote People's Front for ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_Extraction_AddressProtestors == ..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_Extraction_AddressProtestors =..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Denis Stahler: ""This charade has gone on long enough. Can't you others s..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_A_Protestors_Calm == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Denis Stahler: ""You claimed to understand the plight of the common man b..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_A_Protestors_Calm == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Calm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Denis Stahler: ""Ever since our confrontation in Narbel I've known exactl..."*)

### Węzeł `[240]`
Mówca: **Denis Stahler**
> ""You claimed to understand the plight of the common man back in Narbel. But it was all an act, wasn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[241]`
Mówca: **Denis Stahler**
> ""Ever since our confrontation in Narbel I've known exactly what kind of man you were, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Manoly Suheil: ""I have nothing to add. I trust the Sordish people will m..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
