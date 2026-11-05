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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[23]` | **""No. Next question.""** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[25]` | **""I would have achieved unprecedented rights for Sordland's women had certain indiv..."** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[29]` | **""This term was just the beginning. In the next four years, I will achieve full equ..."** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[30]` | **""Sordland will not give in to the demands of a few radicals. We must hold firm to ..."** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[34]` | **""Over the next four years, my amazing Women's Rights Commission will finish the wo..."** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | `Variable["BaseGame.WomensRightCommission"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[45]` | **""Sordland's women have all the rights they need thanks to me. It's time to focus o..."** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[81]` | **""That makes a lot of sense. Remind me to consult with you on this during my next t..."** | `[95]` **Denis Stahler**: ""We will only truly be free as a..."<br>`[109]` **Mansoun Leke**: ""As your president, I would crea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Mansoun Leke**: ""*If* you win a second term, I w..."<br>`[88]` **Denis Stahler**: ""I'll remind you to go to hell.""<br>*(oraz 1 innych odgałęzień)* |
| `[112]` | **""Sordish women are doing just fine! I don't know what you all are on about.""** | `[95]` **Denis Stahler**: ""We will only truly be free as a..."<br>`[109]` **Mansoun Leke**: ""As your president, I would crea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Moderator**: ""Anything to add, Mr. President?"" |
| `[120]` | **"Say nothing."** | `[95]` **Denis Stahler**: ""We will only truly be free as a..."<br>`[109]` **Mansoun Leke**: ""As your president, I would crea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Moderator**: ""Anything to add, Mr. President?"" |
| `[124]` | **""Shh. The grown-ups are talking.""** | `[95]` **Denis Stahler**: ""We will only truly be free as a..."<br>`[109]` **Mansoun Leke**: ""As your president, I would crea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Moderator**: ""Anything to add, Mr. President?"" |
| `[142]` | **""Only that I have already given Sordland its first female vice president. That sho..."** | `[16]` **Moderator**: ""Anything to add, Mr. President?"" | `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |

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
  - -> `[4]` (*Moderator: ""This next topic is of personal interest to many people w..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Frens Ricter**
> ""Until women have the same rights as men, peace is not an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[4]`
Mówca: **Moderator**
> ""This next topic is of personal interest to many people watching at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Moderator: ""In the wake of the President's recent legislation, do yo..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Moderator: ""Women across Sordland have been marching for equal right..."*)

### Węzeł `[8]`
Mówca: **Mansoun Leke**
> ""More women in the workforce sounds nice on paper. But it's unfortunately not as simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Mansoun Leke: ""Look at countries like Arcasia. The women in high-paying..."*)

### Węzeł `[9]`
Mówca: **Moderator**
> ""In the wake of the President's recent legislation, do you plan to act further to increase women's rights?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[10]`
Mówca: **Moderator**
> ""Women across Sordland have been marching for equal rights throughout the Rayne presidency -- do you plan on addressing their demands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lileas Graf: ""I'll stop you right there.""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[14]`
Mówca: **Remus Holstron**
> ""Thanks to Anton Rayne's laws, entire generations of young Sords will grow up motherless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[15]`
Mówca: **Lileas Graf**
> ""I'll stop you right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[16]`
Mówca: **Moderator**
> ""Anything to add, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.WomensRightCommission == true"*)
  - -> `[23]` (*Player: ""No. Next question.""*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[17]`
Mówca: **Lileas Graf**
> ""You can't expect a man -- and a divorced man at that -- to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[18]`
Mówca: **Manoly Suheil**
> ""Says the woman running for President! Do you not see a contradiction here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Manoly Suheil: ""As Sordland's first female President, would achieve what..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lileas Graf: ""You can't expect a man -- and a divorced man at that -- ..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lileas Graf: ""You can't expect a man to know what's best for Sordish w..."*)

### Węzeł `[22]`
Mówca: **Moderator**
> ""But what about the argument that more women in the workforce leads to greater productivity as a nation--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""No. Next question.""]** — Mówca: **Player**
> ""No. Next question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[24]`
Mówca: **Lileas Graf**
> ""You can't expect a man to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I would have achieved unprecedented rights for Sordland's women had certain individuals not blocked me.""]** — Mówca: **Player**
> ""I would have achieved unprecedented rights for Sordland's women had certain individuals not blocked me.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lileas Graf: ""The laws passed under his administration will cause more..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lileas Graf: ""These radical demonstrators hardly represent a majority...."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""This term was just the beginning. In the next four years, I will achieve full equality for all women.""]** — Mówca: **Player**
> ""This term was just the beginning. In the next four years, I will achieve full equality for all women.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Sordland will not give in to the demands of a few radicals. We must hold firm to tradition.""]** — Mówca: **Player**
> ""Sordland will not give in to the demands of a few radicals. We must hold firm to tradition.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[31]`
Mówca: **Lileas Graf**
> ""These radical demonstrators hardly represent a majority. The only thing ladies truly want is a peaceful home life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[32]`
Mówca: **Mansoun Leke**
> ""*If* you win a second term, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Moderator: ""Anything to add, Mr. President?""*)

### Węzeł `[33]`
Mówca: **Lileas Graf**
> ""The laws passed under his administration will cause more harm than good as generations of young Sords grow up motherless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Over the next four years, my amazing Women's Rights Commission will finish the work they started.""]** — Mówca: **Player**
> ""Over the next four years, my amazing Women's Rights Commission will finish the work they started.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.WomensRightCommission"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[35]`
Mówca: **Kesaro Kibener**
> ""I'll stop you right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Kesaro Kibener: ""You can't expect a divorced man to know what's best for ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[39]`
Mówca: **Kesaro Kibener**
> ""Thanks to Anton Rayne's laws, entire generations of young Sords will grow up motherless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[40]`
Mówca: **Kesaro Kibener**
> ""You can't expect a divorced man to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[41]`
Mówca: **Kesaro Kibener**
> ""These radical demonstrators hardly represent a majority. The only thing ladies truly want is a peaceful home life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Kesaro Kibener: ""Thanks to Anton Rayne's laws, entire generations of youn..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Kesaro Kibener: ""These radical demonstrators hardly represent a majority...."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Sordland's women have all the rights they need thanks to me. It's time to focus on other, more pressing issues.""]** — Mówca: **Player**
> ""Sordland's women have all the rights they need thanks to me. It's time to focus on other, more pressing issues.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""More women in the workforce sounds nice on paper. But it..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Denis Stahler: ""The workforce. Of course 'productivity' is your main con..."*)

### Węzeł `[49]`
Mówca: **Denis Stahler**
> ""The workforce. Of course 'productivity' is your main concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Denis Stahler: ""We will only truly be free as a society when childrearin..."*)

### Węzeł `[50]`
Mówca: **Frens Ricter**
> ""I have consulted intensively with my deputy Manoly Suheil on this. With the PFJP in power, we would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[51]`
Mówca: **Frens Ricter**
> ""Says the woman running for President! Do you not see a contradiction here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.WomensRightCommission == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.WomensRightCommission == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.WomensRightCommission == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.WomensRightCommission == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.WomensRightCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Over the next four years, my amazing Women's Rights Comm..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.WomensRightCommission == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.WomensRightCommission"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""Sordland's women have all the rights they need thanks to..."*)
  - -> `[29]` (*Player: ""This term was just the beginning. In the next four years..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""I would have achieved unprecedented rights for Sordland'..."*)
  - -> `[30]` (*Player: ""Sordland will not give in to the demands of a few radica..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Kesaro Kibener: ""I'll stop you right there.""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[61]`
Mówca: **Manoly Suheil**
> ""As Sordland's first female President, I would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Remus Holstron: ""Stop right there.""*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Frens Ricter: ""Says the woman running for President! Do you not see a c..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Moderator: ""But what about the argument that more women in the workf..."*)

### Węzeł `[68]`
Mówca: **Remus Holstron**
> ""Stop right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[69]`
Mówca: **Remus Holstron**
> ""These radical demonstrators hardly represent a majority. The only thing ladies truly want is a peaceful home life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Remus Holstron: ""You can't expect a divorced man to know what's best for ..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[73]`
Mówca: **Remus Holstron**
> ""You can't expect a divorced man to know what's best for Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Remus Holstron: ""Thanks to Anton Rayne's laws, entire generations of youn..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Remus Holstron: ""These radical demonstrators hardly represent a majority...."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manoly Suheil: ""Says the woman running for President! Do you not see a c..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[80]`
Mówca: **Manoly Suheil**
> ""As Sordland's first female President, would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""That makes a lot of sense. Remind me to consult with you on this during my next term.""]** — Mówca: **Player**
> ""That makes a lot of sense. Remind me to consult with you on this during my next term.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Denis Stahler), `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manoly Suheil: ""As Sordland's first female president, I would expand on ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Manoly Suheil: ""As Sordland's first female President, I would achieve wh..."*)

### Węzeł `[85]`
Mówca: **Frens Ricter**
> ""I have consulted intensively with my deputy Manoly Suheil on this. With the PFJP in power, we would achieve what Rayne failed to and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[86]`
Mówca: **Frens Ricter**
> ""Are you serious? Women can have careers and families at the same time. Perhaps we men can even assume some of the childcare duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[87]`
Mówca: **Denis Stahler**
> ""Getting a little ahead of yourself, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Moderator: ""Anything to add, Mr. President?""*)

### Węzeł `[88]`
Mówca: **Denis Stahler**
> ""I'll remind you to go to hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Moderator: ""Anything to add, Mr. President?""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manoly Suheil: ""Until women have the same rights as men, peace is not an..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[92]`
Mówca: **Manoly Suheil**
> ""Are you serious? Women can have careers and families at the same time. Perhaps men can even assume some of the childcare duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manoly Suheil: ""As Sordland's first female president, I would expand on ..."*)

### Węzeł `[93]`
Mówca: **Frens Ricter**
> ""I have consulted intensively with my deputy Manoly Suheil on this. With the PFJP in power, we would expand on Rayne's laws and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[94]`
Mówca: **Mansoun Leke**
> ""Look at countries like Arcasia. The women in high-paying jobs are those privileged enough to hand off their domestic duties to household staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Mansoun Leke: ""As your president, I would create policies specifically ..."*)

### Węzeł `[95]`
Mówca: **Denis Stahler**
> ""We will only truly be free as a society when childrearing, cleaning and other so-called 'women's work' is considered just as productive as the work done by President Rayne here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""That makes a lot of sense. Remind me to consult with you..."*)
  - -> `[112]` (*Player: ""Sordish women are doing just fine! I don't know what you..."*)
  - -> `[120]` (*Player_Italic: "Say nothing."*)
  - -> `[124]` (*Player: ""Shh. The grown-ups are talking.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Denis Stahler: ""I'll remind you to go to hell.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Denis Stahler: ""Getting a little ahead of yourself, aren't you?""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[102]`
Mówca: **Manoly Suheil**
> ""As Sordland's first female president, I would expand on Rayne's laws and help unprecedented numbers of women enter the Sordish workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Frens Ricter: ""Until women have the same rights as men, peace is not an..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Moderator: ""But what about the argument that more women in the workf..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Mansoun Leke: ""*If* you win a second term, I will.""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[109]`
Mówca: **Mansoun Leke**
> ""As your president, I would create policies specifically aimed at women from disadvantaged communities, so that no female Sord is lifted up at the expense of another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""That makes a lot of sense. Remind me to consult with you..."*)
  - -> `[112]` (*Player: ""Sordish women are doing just fine! I don't know what you..."*)
  - -> `[120]` (*Player_Italic: "Say nothing."*)
  - -> `[124]` (*Player: ""Shh. The grown-ups are talking.""*)

### Węzeł `[110]`
Mówca: **Frens Ricter**
> ""Because husbands aren't allowed to beat their wives anymore? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[111]`
Mówca: **Manoly Suheil**
> ""Until women have the same rights as men, peace is not an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Manoly Suheil: ""As Sordland's first female President, I would achieve wh..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Sordish women are doing just fine! I don't know what you all are on about.""]** — Mówca: **Player**
> ""Sordish women are doing just fine! I don't know what you all are on about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Denis Stahler), `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Moderator: ""Anything to add, Mr. President?""*)

### Węzeł `[113]`
Mówca: **Manoly Suheil**
> ""Because husbands aren't allowed to beat their wives anymore? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manoly Suheil: ""As Sordland's first female president, I would expand on ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Moderator: ""But what about the argument that more women in the workf..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Denis Stahler), `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Moderator: ""Anything to add, Mr. President?""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Manoly Suheil: ""Because husbands aren't allowed to beat their wives anym..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_GenderEqualityInEducation == t..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Shh. The grown-ups are talking.""]** — Mówca: **Player**
> ""Shh. The grown-ups are talking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Denis Stahler), `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Moderator: ""Anything to add, Mr. President?""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_GenderEqualityInEducation == t..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_GenderEqualityInEducation ==..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Manoly Suheil: ""Because girls are allowed to study trigonometry? A littl..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Manoly Suheil: ""Are you serious? Women can have careers and families at ..."*)

### Węzeł `[128]`
Mówca: **Manoly Suheil**
> ""Because girls are allowed to study trigonometry? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manoly Suheil: ""As Sordland's first female president, I would expand on ..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Frens Ricter: ""Because husbands aren't allowed to beat their wives anym..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_GenderEqualityInEducation == t..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_GenderEqualityInEducation == t..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_GenderEqualityInEducation ==..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Frens Ricter: ""Because girls may now learn trigonometry? A little hyper..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_GenderEqualityInEducation == true && BaseGame.Situation_Law_ExcellentWomenRights == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true  and  Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Frens Ricter: ""Are you serious? Women can have careers and families at ..."*)

### Węzeł `[135]`
Mówca: **Frens Ricter**
> ""Because girls may now learn trigonometry? A little hyperbolic, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_Turn08_Decree_WomensRights == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Frens Ricter: ""I have consulted intensively with my deputy Manoly Suhei..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""Only that I have already given Sordland its first female..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Only that I have already given Sordland its first female vice president. That should show how committed I am to advancing the status of women in this country.""]** — Mówca: **Player**
> ""Only that I have already given Sordland its first female vice president. That should show how committed I am to advancing the status of women in this country.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true ||..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
