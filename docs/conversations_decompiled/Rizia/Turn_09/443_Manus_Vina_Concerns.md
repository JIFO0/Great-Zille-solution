# Rizia/Turn 9/Manus Vina Concerns

- **ID konwersacji:** `443`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/443_Manus_Vina_Concerns.md`
- **Liczba węzłów dialogowych:** 32
- **Liczba wyborów gracza:** 5

---

## 1. Uczestnicy Sceny

- **[75]** Manus Sazon
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[442] Rizia/Turn 9/TalkWithManus** (../Turn_09/442_TalkWithManus.md), Węzeł `[363]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **""She's got more of a spine than you do. She'll understand that this is necessary f..."** | `[7]` **Manus Sazon**: ""What will Her Highness say when..."<br>`[11]` **Manus Sazon**: ""We aren't close anymore, as you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Manus Sazon**: ""With all due respect, Your Maje..." |
| `[14]` | **""I'll make sure she's safely out of the way while all this is happening, if that's..."** | `[11]` **Manus Sazon**: ""We aren't close anymore, as you..."<br>`[12]` **Manus Sazon**: ""Both you and I know she'd never..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Manus Sazon**: ""That's the minimum I expect."" |
| `[18]` | **""We won't be able to get her out of Pales without resorting to violence. Sometimes..."** | `[7]` **Manus Sazon**: ""What will Her Highness say when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Manus Sazon**: ""That may be so in matters of wa..." |
| `[19]` | **""You're getting ahead of yourself. It will never come to violence.""** | `[7]` **Manus Sazon**: ""What will Her Highness say when..."<br>`[11]` **Manus Sazon**: ""We aren't close anymore, as you..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true` | *Brak zmian stanu* | `[23]` **Manus Sazon**: ""For all of our sakes, I hope not."" |
| `[24]` | **""Vina has nothing to do with this. It's none of your business what she'll think.""** | `[7]` **Manus Sazon**: ""What will Her Highness say when..."<br>`[11]` **Manus Sazon**: ""We aren't close anymore, as you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Manus Sazon**: ""None of my business? I'm her hu..."<br>`[28]` **Manus Sazon**: ""But..."" |

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
  - -> `[3]` (*Manus Sazon: ""Have you thought about how Vina will react?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""Have you thought about how Vina will react?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: ""What will Her Highness say when she comes back from Pale..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[7]`
Mówca: **Manus Sazon**
> ""What will Her Highness say when she comes back from Pales to a Rizia reformed by violent means?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""We won't be able to get her out of Pales without resorti..."*)
  - -> `[13]` (*Player_Romus: ""She's got more of a spine than you do. She'll understand..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[24]` (*Player_Romus: ""Vina has nothing to do with this. It's none of your busi..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Manus Sazon: ""Both you and I know she'd never want to see Rizia reform..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Manus Sazon: ""We aren't close anymore, as you know. But I don't believ..."*)

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""We aren't close anymore, as you know. But I don't believe she'd want to see Rizia reformed by violent means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""She's got more of a spine than you do. She'll understand..."*)
  - -> `[14]` (*Player_Romus: ""I'll make sure she's safely out of the way while all thi..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[24]` (*Player_Romus: ""Vina has nothing to do with this. It's none of your busi..."*)

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""Both you and I know she'd never want to see Rizia reformed by violent means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""She's got more of a spine than you do. She'll understand..."*)
  - -> `[14]` (*Player_Romus: ""I'll make sure she's safely out of the way while all thi..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[24]` (*Player_Romus: ""Vina has nothing to do with this. It's none of your busi..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's got more of a spine than you do. She'll understand that this is necessary for the greater good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[11]` (Manus Sazon), `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Manus Sazon: ""With all due respect, Your Majesty, it takes more of a s..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll make sure she's safely out of the way while all this is happening, if that's what you're worried about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon), `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""That's the minimum I expect.""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == ..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""You're getting ahead of yourself. It will never come to ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't be able to get her out of Pales without resorting to violence. Sometimes it's the only solution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Manus Sazon: ""That may be so in matters of war, but it's a dangerous l..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're getting ahead of yourself. It will never come to violence.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[11]` (Manus Sazon), `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Manus Sazon: ""For all of our sakes, I hope not.""*)

### Węzeł `[20]`
Mówca: **Manus Sazon**
> ""That's the minimum I expect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[21]`
Mówca: **Manus Sazon**
> ""With all due respect, Your Majesty, it takes more of a spine to resist violence than to give in to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Manus Sazon: ""But as I said, if this is really what you want, I won't ..."*)

### Węzeł `[22]`
Mówca: **Manus Sazon**
> ""That may be so in matters of war, but it's a dangerous line of thinking in internal politics...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Manus Sazon: ""But as I said, if this is really what you want, I won't ..."*)

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""For all of our sakes, I hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina has nothing to do with this. It's none of your business what she'll think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[11]` (Manus Sazon), `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Manus Sazon: ""None of my business? I'm her husband!""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Manus Sazon: ""But...""*)

### Węzeł `[28]`
Mówca: **Manus Sazon**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Manus Sazon: ""Fine. As I said, if this is truly what you want, I won't..."*)

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""None of my business? I'm her husband!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Manus Sazon: ""But as I said, if this is really what you want, I won't ..."*)

### Węzeł `[30]`
Mówca: **Manus Sazon**
> ""But as I said, if this is really what you want, I won't get in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[31]`
Mówca: **Manus Sazon**
> ""Fine. As I said, if this is truly what you want, I won't get in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
