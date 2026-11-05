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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[112]` | **""Pure of blood? I wonder what that means...""** | `[49]` **Kesaro Kibener**: ""Together, we conquered the land..."<br>`[87]` **Remus Holstron**: ""Together, we conquered the land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Moderator**: ""That's all the time we have for..."<br>`[84]` **Lileas Graf**: ""Strategic alliances are all wel..."<br>*(oraz 2 innych odgałęzień)* |
| `[113]` | **"Say nothing."** | `[49]` **Kesaro Kibener**: ""Together, we conquered the land..."<br>`[87]` **Remus Holstron**: ""Together, we conquered the land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Moderator**: ""That's all the time we have for..."<br>`[84]` **Lileas Graf**: ""Strategic alliances are all wel..."<br>*(oraz 2 innych odgałęzień)* |
| `[114]` | **""That'll be enough of that, Kesaro.""** | `[49]` **Kesaro Kibener**: ""Together, we conquered the land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Moderator**: ""That's all the time we have for..."<br>`[84]` **Lileas Graf**: ""Strategic alliances are all wel..."<br>*(oraz 2 innych odgałęzień)* |
| `[115]` | **""A nice sentiment. A shame we can't ally with Valgsland and Agnolia at the same ti..."** | `[49]` **Kesaro Kibener**: ""Together, we conquered the land..."<br>`[87]` **Remus Holstron**: ""Together, we conquered the land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Moderator**: ""That's all the time we have for..."<br>`[84]` **Lileas Graf**: ""Strategic alliances are all wel..."<br>*(oraz 2 innych odgałęzień)* |
| `[118]` | **""How articulate of you, Remus. I'd say Kesaro wrote you some talking points, but I..."** | `[87]` **Remus Holstron**: ""Together, we conquered the land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Moderator**: ""That's all the time we have for..."<br>`[84]` **Lileas Graf**: ""Strategic alliances are all wel..."<br>*(oraz 2 innych odgałęzień)* |
| `[119]` | **""Yeah, shut up, Denis.""** | `[90]` **Moderator**: ""Let's move on to the next candi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Narrator**: "Denis sat back in his chair, fum..." |
| `[120]` | **"Say nothing."** | `[90]` **Moderator**: ""Let's move on to the next candi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Narrator**: "Denis sat back in his chair, fum..." |
| `[124]` | **""Let him speak.""** | `[90]` **Moderator**: ""Let's move on to the next candi..." | `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true) == false` | *Brak zmian stanu* | `[97]` **Denis Stahler**: ""I don't need charity from the m..."<br>`[28]` **Denis Stahler**: ""Thank you, Mr. President. I was..." |
| `[125]` | **""I lowered the election threshold to give Mr. Stahler and his party a voice. Let h..."** | `[90]` **Moderator**: ""Let's move on to the next candi..." | `Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true` | *Brak zmian stanu* | `[97]` **Denis Stahler**: ""I don't need charity from the m..."<br>`[28]` **Denis Stahler**: ""Thank you, Mr. President. I was..." |
| `[135]` | **""May I just add that my decision to join ATO likely saved us from having to go to ..."** | `[59]` **Moderator**: ""That's all the time we have for..." | `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`<br>`Variable["BaseGame.Joined_ATO"] == true` | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[142]` | **""May I just add that my decision to join CSP likely saved us from having to go to ..."** | `[59]` **Moderator**: ""That's all the time we have for..." | `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`<br>`Variable["BaseGame.Policy_Diplomacy_CSP"] == true`<br>`(Variable["BaseGame.Joined_ATO"] == true) == false` | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[146]` | **""May I just add that I managed to defuse a potential war with Rumburg without the ..."** | `[59]` **Moderator**: ""That's all the time we have for..." | `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`<br>`(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`<br>`(Variable["BaseGame.Joined_ATO"] == true) == false` | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[147]` | **""I just wanted to say that I avoided international alliances in order to put my fu..."** | `[59]` **Moderator**: ""That's all the time we have for..." | `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`<br>`(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`<br>`(Variable["BaseGame.Joined_ATO"] == true) == false` | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[157]` | **""May I just add that the international relationships I cultivated likely saved us ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[158]` | **""I just wanted to point out that no Sordish president has managed to garner the at..."** | `[59]` **Moderator**: ""That's all the time we have for..." | `Variable["BaseGame.Joined_ATO"] == true` | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[159]` | **""May I just point out that I have increased Sordland's international standing more..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |
| `[160]` | **"Don't say anything."** | `[59]` **Moderator**: ""That's all the time we have for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[189]` | **""Can I just add that my decision to send troops into Wehlen probably saved thousan..."** | `[59]` **Moderator**: ""That's all the time we have for..." | `Variable["BaseGame.Wehlen_JointOperation"] == true` | *Brak zmian stanu* | `[165]` **Moderator**: ""Of course. Thank you, Mr. Presi..."<br>`[161]` **Moderator**: ""As I said, we need to move on t..." |

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
  - -> `[6]` (*Moderator: ""My next question concerns Sordland's foreign relations.""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[6]`
Mówca: **Moderator**
> ""My next question concerns Sordland's foreign relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == false"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == false"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Neutrality == false)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Moderator: ""To the non-incumbent candidates, would you maintain the ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Neutrality == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Moderator: ""President Rayne, you haven't formed any strong internati..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Kesaro Kibener: ""If I may.""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[13]`
Mówca: **Moderator**
> ""To the non-incumbent candidates, would you maintain the international alliances President Rayne has formed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Manoly Suheil: ""Certainly not. Sordland only stands to benefit from form..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Denis Stahler: ""Absolutely not.""*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Poli..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_ATO == true"*)

### Węzeł `[20]`
Mówca: **Manoly Suheil**
> ""The members of ATO, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Denis Stahler: ""That's right, Suheil. Tow the party line.""*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Frens Ricter: ""I would do more than just maintain them. I would expand ..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Manoly Suheil: ""I would do more than just maintain them. I would expand ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[27]`
Mówca: **Manoly Suheil**
> ""Certainly not. Sordland only stands to benefit from forming more cordial relationships with its neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manoly Suheil: ""The members of ATO, for example.""*)

### Węzeł `[28]`
Mówca: **Denis Stahler**
> ""Thank you, Mr. President. I was going to stress that the superficial surface benefits of ATO are nothing compared to the deeper bonds cultivated by a membership in CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_ATO == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_ATO == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Remus Holstron: ""Is it my turn yet?""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Frens Ricter: ""Of course I would.""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Manoly Suheil: ""Of course I would.""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[41]`
Mówca: **Moderator**
> ""President Rayne, you haven't formed any strong international alliances during your term. I'd like to know if the other candidates would continue on the same track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Frens Ricter: ""Certainly not. Sordland can only move forward if we form..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Poli..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_CSP == false && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == false  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[48]`
Mówca: **Mansoun Leke**
> ""I would add that we have been unfairly ignoring the newly emancipated nations from Rika and Xina. Aiding these countries as they find their feet would strike a blow against the forces of colonialism, and could prove beneficial to us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[49]`
Mówca: **Kesaro Kibener**
> ""Together, we conquered the lands of Rum so many centuries ago. And together, we who are pure of blood will rise up and reclaim this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""Pure of blood? I wonder what that means...""*)
  - -> `[115]` (*Player: ""A nice sentiment. A shame we can't ally with Valgsland a..."*)
  - -> `[114]` (*Player: ""That'll be enough of that, Kesaro.""*)
  - -> `[113]` (*Player_Italic: "Say nothing."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[59]`
Mówca: **Moderator**
> ""That's all the time we have for that question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[160]` (*Player_Italic: "Don't say anything."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_ATO == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Moderator: ""That's all the time we have for that question.""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Mansoun Leke: ""I would add that we have been unfairly ignoring the newl..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[66]`
Mówca: **Frens Ricter**
> ""By joining ATO, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Denis Stahler: ""I can't believe we were ever in the same party.""*)

### Węzeł `[67]`
Mówca: **Frens Ricter**
> ""Certainly not. Sordland can only move forward if we form productive relationships with our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Frens Ricter: ""By joining ATO, for example.""*)

### Węzeł `[68]`
Mówca: **Frens Ricter**
> ""I would do more than just maintain them. I would expand upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Frens Ricter: ""Membership in ATO is the obvious next step forward for S..."*)

### Węzeł `[69]`
Mówca: **Lileas Graf**
> ""We must endeavor to stay in the good graces of both superpowers while asserting Sordland's strength and independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Moderator: ""That's all the time we have for that question.""*)

### Węzeł `[70]`
Mówca: **Manoly Suheil**
> ""I would do more than just maintain them. I would expand upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Manoly Suheil: ""Membership in ATO is the obvious next step forward for S..."*)

### Węzeł `[71]`
Mówca: **Lileas Graf**
> ""We must maintain the ties we've built while making a greater effort to assert Sordland's strength and independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Moderator: ""That's all the time we have for that question.""*)

### Węzeł `[72]`
Mówca: **Frens Ricter**
> ""Membership in ATO is the obvious next step forward for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Denis Stahler: ""I can't believe we were ever in the same party.""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_ATO == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_ATO == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lileas Graf: ""Strategic alliances are all well and good, but President..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == true"*)

### Węzeł `[76]`
Mówca: **Manoly Suheil**
> ""Membership in ATO is the obvious next step forward for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Denis Stahler: ""That's right, Suheil. Tow the party line.""*)

### Węzeł `[77]`
Mówca: **Kesaro Kibener**
> ""If I may.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Kesaro Kibener: ""All this talk of east and west, socialist and capitalist..."*)

### Węzeł `[78]`
Mówca: **Denis Stahler**
> ""That's right, Suheil. Tow the party line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[79]`
Mówca: **Remus Holstron**
> ""Is it my turn yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Remus Holstron: ""All this talk of east and west, socialist and capitalist..."*)

### Węzeł `[80]`
Mówca: **Denis Stahler**
> ""I can't believe we were ever in the same party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[81]`
Mówca: **Lileas Graf**
> ""Strategic alliances are all well and good, as long as our country receives its fair share of the benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: ""We must maintain the ties we've built while making a gre..."*)

### Węzeł `[82]`
Mówca: **Denis Stahler**
> ""We all know Lespia and Arcasia don't give a damn about us. We will only grow stronger by marching arm and arm with our socialist brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[83]`
Mówca: **Lileas Graf**
> ""Strategic alliances are all well and good, but President Rayne would practically give Leon Malenyev the shirt off his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: ""We must endeavor to stay in the good graces of both supe..."*)

### Węzeł `[84]`
Mówca: **Lileas Graf**
> ""Strategic alliances are all well and good, but President Rayne would practically give Dwight Walker the shirt off his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: ""We must maintain the ties we've built while making a gre..."*)

### Węzeł `[85]`
Mówca: **Frens Ricter**
> ""Of course I would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Frens Ricter: ""Membership in ATO was always the logical next step for S..."*)

### Węzeł `[86]`
Mówca: **Manoly Suheil**
> ""Of course I would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Manoly Suheil: ""Membership in ATO was always the logical next step for S..."*)

### Węzeł `[87]`
Mówca: **Remus Holstron**
> ""Together, we conquered the lands of Rum so many centuries ago. And together, we who are pure of blood will rise up and reclaim this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""Pure of blood? I wonder what that means...""*)
  - -> `[115]` (*Player: ""A nice sentiment. A shame we can't ally with Valgsland a..."*)
  - -> `[118]` (*Player: ""How articulate of you, Remus. I'd say Kesaro wrote you s..."*)
  - -> `[113]` (*Player_Italic: "Say nothing."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Denis sat back in his chair, fuming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[89]`
Mówca: **Frens Ricter**
> ""Membership in ATO was always the logical next step for Sordland. I'm looking forward to developing those relationships further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Denis Stahler: ""I can't believe we were ever in the same party.""*)

### Węzeł `[90]`
Mówca: **Moderator**
> ""Let's move on to the next candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Polic..."*)
  - -> `[119]` (*Player: ""Yeah, shut up, Denis.""*)
  - -> `[120]` (*Player_Italic: "Say nothing."*)

### Węzeł `[91]`
Mówca: **Manoly Suheil**
> ""Membership in ATO was always the logical next step for Sordland. I'm looking forward to developing those relationships further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Denis Stahler: ""That's right, Suheil. Tow the party line.""*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_CSP == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lileas Graf: ""Strategic alliances are all well and good, but President..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lileas Graf: ""Strategic alliances are all well and good, as long as ou..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Denis turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Denis Stahler: ""We all know Lespia and Arcasia don't give a damn about u..."*)

### Węzeł `[96]`
Mówca: **Remus Holstron**
> ""Of course I would advocate for staying on good terms with Arcasia, but Sordland's strongest ties must be to our tribal cousins in Valgsland and Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Remus Holstron: ""Together, we conquered the lands of Rum so many centurie..."*)

### Węzeł `[97]`
Mówca: **Denis Stahler**
> ""I don't need charity from the man who got me imprisoned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[98]`
Mówca: **Kesaro Kibener**
> ""Of course I would advocate for staying on good terms with Arcasia, but Sordland's strongest ties must be to our tribal cousins in Valgsland and Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Kesaro Kibener: ""Together, we conquered the lands of Rum so many centurie..."*)

### Węzeł `[99]`
Mówca: **Remus Holstron**
> ""All this talk of east and west, socialist and capitalist is missing the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Remus Holstron: ""Of course I would advocate for staying on good terms wit..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Polic..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Pol..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""I lowered the election threshold to give Mr. Stahler and..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Let him speak.""*)

### Węzeł `[103]`
Mówca: **Frens Ricter**
> ""However, with enough skilled diplomacy I can turn our standing around and regain Arcasia's trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Denis Stahler: ""I can't believe we were ever in the same party.""*)

### Węzeł `[104]`
Mówca: **Manoly Suheil**
> ""I still believe Sordland's future lies with ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Denis Stahler: ""That's right, Suheil. Tow the party line.""*)

### Węzeł `[105]`
Mówca: **Frens Ricter**
> ""But it's not impossible to cut ties and regain the trust of Arcasia and ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Denis Stahler: ""I can't believe we were ever in the same party.""*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Denis Stahler: ""I don't need charity from the man who got me imprisoned.""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Denis Stahler: ""Thank you, Mr. President. I was going to stress that the..."*)

### Węzeł `[109]`
Mówca: **Kesaro Kibener**
> ""All this talk of east and west, socialist and capitalist is missing the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Kesaro Kibener: ""Of course I would advocate for staying on good terms wit..."*)

### Węzeł `[110]`
Mówca: **Denis Stahler**
> ""I believe that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Moderator: ""Let's move on to the next candidate.""*)

### Węzeł `[111]`
Mówca: **Denis Stahler**
> ""Sure. The point is--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Moderator: ""Let's move on to the next candidate.""*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Pure of blood? I wonder what that means...""]** — Mówca: **Player**
> ""Pure of blood? I wonder what that means...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener), `[87]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I kept watching the debate unfold."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener), `[87]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""That'll be enough of that, Kesaro.""]** — Mówca: **Player**
> ""That'll be enough of that, Kesaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""A nice sentiment. A shame we can't ally with Valgsland and Agnolia at the same time.""]** — Mówca: **Player**
> ""A nice sentiment. A shame we can't ally with Valgsland and Agnolia at the same time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener), `[87]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Denis turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Denis Stahler: ""Rayne and I have had our disagreements, but not on this...."*)

### Węzeł `[117]`
Mówca: **Denis Stahler**
> ""Rayne and I have had our disagreements, but not on this. We must continue to march arm in arm with our socialist brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""How articulate of you, Remus. I'd say Kesaro wrote you some talking points, but I'm not convinced you can read.""]** — Mówca: **Player**
> ""How articulate of you, Remus. I'd say Kesaro wrote you some talking points, but I'm not convinced you can read.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Yeah, shut up, Denis.""]** — Mówca: **Player**
> ""Yeah, shut up, Denis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Denis sat back in his chair, fuming."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Denis sat back in his chair, fuming."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Mansoun Leke: ""Our socialist brothers *and sisters*.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Denis Stahler: ""I believe that--""*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Let him speak.""]** — Mówca: **Player**
> ""Let him speak.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I lowered the election threshold to give Mr. Stahler and his party a voice. Let him speak.""]** — Mówca: **Player**
> ""I lowered the election threshold to give Mr. Stahler and his party a voice. Let him speak.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[126]`
Mówca: **Mansoun Leke**
> ""Our socialist brothers *and sisters*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Denis Stahler: ""Sure. The point is--""*)

### Węzeł `[127]`
Mówca: **Denis Stahler**
> ""Absolutely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Denis Stahler: ""We must strengthen our ties with our socialist brothers,..."*)

### Węzeł `[128]`
Mówca: **Denis Stahler**
> ""We must strengthen our ties with our socialist brothers, so that we may inspire workers everywhere to rise up and be free of their shackles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[129]`
Mówca: **Denis Stahler**
> ""I can't believe we were ever in the same party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[130]`
Mówca: **Denis Stahler**
> ""That's right, Suheil. Tow the party line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[131]`
Mówca: **Denis Stahler**
> ""I can't believe we were ever in the same party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[132]`
Mówca: **Denis Stahler**
> ""That's right, Suheil. Tow the party line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "Denis turned to look at me."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "Denis turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Denis Stahler: ""An international movement is growing, and it's high time..."*)

### Węzeł `[134]`
Mówca: **Denis Stahler**
> ""An international movement is growing, and it's high time Sordland became a part of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Denis Stahler: ""We must strengthen our ties with our socialist brothers,..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""May I just add that my decision to join ATO likely saved us from having to go to war with Rumburg?""]** — Mówca: **Player**
> ""May I just add that my decision to join ATO likely saved us from having to go to war with Rumburg?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true` AND `Variable["BaseGame.Joined_ATO"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FPnT_RumburgIsolated == true"*)
  - -> `[158]` (*Player: ""I just wanted to point out that no Sordish president has..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_CSP == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_CSP == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: ""I just wanted to point out that no Sordish president has..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FPnT_RumburgIsolated == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == true"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""May I just add that my decision to join CSP likely saved us from having to go to war with Rumburg?""]** — Mówca: **Player**
> ""May I just add that my decision to join CSP likely saved us from having to go to war with Rumburg?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true` AND `Variable["BaseGame.Policy_Diplomacy_CSP"] == true` AND `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Neutrality == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""May I just add that I managed to defuse a potential war ..."*)
  - -> `[147]` (*Player: ""I just wanted to say that I avoided international allian..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Neutrality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FPnT_RumburgIsolated == true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""May I just add that I managed to defuse a potential war with Rumburg without the help of any international alliances?""]** — Mówca: **Player**
> ""May I just add that I managed to defuse a potential war with Rumburg without the help of any international alliances?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true` AND `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false` AND `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""I just wanted to say that I avoided international alliances in order to put my full focus on our domestic issues. I'm thinking globally for my next term.""]** — Mówca: **Player**
> ""I just wanted to say that I avoided international alliances in order to put my full focus on our domestic issues. I'm thinking globally for my next term.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true` AND `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false` AND `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FPnT_RumburgIsolated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FPnT_RumburgIsolated == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_FPnT_RumburgIsolated == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FPnT_RumburgIsolated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""May I just add that my decision to join ATO likely saved..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_FPnT_RumburgIsolated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FPnT_RumburgIsolated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FPnT_RumburgIsolated == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_FPnT_RumburgIsolated == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FPnT_RumburgIsolated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""May I just add that my decision to join CSP likely saved..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_FPnT_RumburgIsolated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FPnT_RumburgIsolated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FPnT_RumburgIsolated == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_FPnT_RumburgIsolated == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FPnT_RumburgIsolated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: ""May I just add that the international relationships I cu..."*)
  - -> `[159]` (*Player: ""May I just point out that I have increased Sordland's in..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_FPnT_RumburgIsolated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_FPnT_RumburgIsolated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA: ""May I just add that the international relationships I cultivated likely saved us from having to go to war with Rumburg?""]** — Mówca: **Player**
> ""May I just add that the international relationships I cultivated likely saved us from having to go to war with Rumburg?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""I just wanted to point out that no Sordish president has managed to garner the attention of a superpower before. Let alone ally with one.""]** — Mówca: **Player**
> ""I just wanted to point out that no Sordish president has managed to garner the attention of a superpower before. Let alone ally with one.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Joined_ATO"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""May I just point out that I have increased Sordland's international standing more than any other Sordish president?""]** — Mówca: **Player**
> ""May I just point out that I have increased Sordland's international standing more than any other Sordish president?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I waited for the next question."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[161]`
Mówca: **Moderator**
> ""As I said, we need to move on to the next topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Moderator: ""Of course. Thank you, Mr. President.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Moderator: ""As I said, we need to move on to the next topic.""*)

### Węzeł `[165]`
Mówca: **Moderator**
> ""Of course. Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Frens Ricter: ""Certainly not. The joint operation with Wehlen was a tra..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Frens Ricter: ""Certainly not. The alliance with Valgsland was a mistake.""*)

### Węzeł `[169]`
Mówca: **Frens Ricter**
> ""Certainly not. The joint operation with Wehlen was a travesty, and the alliance with Valgsland a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Frens Ricter: ""However, with enough skilled diplomacy I can turn our st..."*)

### Węzeł `[170]`
Mówca: **Frens Ricter**
> ""Certainly not. The alliance with Valgsland was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Frens Ricter: ""However, with enough skilled diplomacy I can turn our st..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Frens Ricter: ""Certainly not. The joint operation with Wehlen was a tra..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Frens Ricter: ""Certainly not. Joining CSP was one of President Rayne's ..."*)

### Węzeł `[174]`
Mówca: **Frens Ricter**
> ""Certainly not. The joint operation with Wehlen was a travesty, and CSP membership one of Rayne's biggest mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Frens Ricter: ""But it's not impossible to cut ties and regain the trust..."*)

### Węzeł `[175]`
Mówca: **Frens Ricter**
> ""Certainly not. Joining CSP was one of President Rayne's biggest mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Frens Ricter: ""But it's not impossible to cut ties and regain the trust..."*)

### Węzeł `[176]`
Mówca: **Manoly Suheil**
> ""Certainly not. The joint operation with Wehlen was a travesty, and the Valgsland alliance was ill-advised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Manoly Suheil: ""I still believe Sordland's future lies with ATO.""*)

### Węzeł `[177]`
Mówca: **Manoly Suheil**
> ""Certainly not. The Valgsland alliance was ill-advised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Manoly Suheil: ""I still believe Sordland's future lies with ATO.""*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Manoly Suheil: ""Certainly not. The joint operation with Wehlen was a tra..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Manoly Suheil: ""Certainly not. The Valgsland alliance was ill-advised.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Manoly Suheil: ""Certainly not. The joint operation with Wehlen was a tra..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Manoly Suheil: ""Certainly not. I have nothing but respect for the member..."*)

### Węzeł `[184]`
Mówca: **Manoly Suheil**
> ""Certainly not. The joint operation with Wehlen was a travesty. And I have nothing but respect for the member states of CSP, but I still believe Sordland's future lies with ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Denis Stahler: ""That's right, Suheil. Tow the party line.""*)

### Węzeł `[185]`
Mówca: **Manoly Suheil**
> ""Certainly not. I have nothing but respect for the member states of CSP, but I still believe Sordland's future lies with ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Denis Stahler: ""That's right, Suheil. Tow the party line.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""Can I just add that my decision to send troops into Wehl..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Can I just add that my decision to send troops into Wehlen probably saved thousands of Wehzek lives?""]** — Mówca: **Player**
> ""Can I just add that my decision to send troops into Wehlen probably saved thousands of Wehzek lives?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
