# Sordland/Turn10/DINNER ALONE

- **ID konwersacji:** `216`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/216_DINNER_ALONE.md`
- **Liczba węzłów dialogowych:** 109
- **Liczba wyborów gracza:** 15

---

## 1. Uczestnicy Sceny

- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Public_Opinion`
- `BaseGame.Rumburg_AttacksSordland`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Turn10_PartyCongress_Won`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[48]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"Give the guards a suspicious look."** | `[7]` **Narrator**: "The guards formed a cordon to le..."<br>`[15]` **Narrator**: "I didn't know if it was my imagi..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[14]` **Narrator**: "Once inside, I locked the front ..." |
| `[12]` | **"Don't look at them and go to your door."** | `[7]` **Narrator**: "The guards formed a cordon to le..."<br>`[15]` **Narrator**: "I didn't know if it was my imagi..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[14]` **Narrator**: "Once inside, I locked the front ..." |
| `[16]` | **"Get a beer from the fridge."** | `[13]` **Narrator**: "I hurried past them, went inside..."<br>`[14]` **Narrator**: "Once inside, I locked the front ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "I was right on time for the game..." |
| `[17]` | **"Go straight to the living room and turn on the TV."** | `[13]` **Narrator**: "I hurried past them, went inside..."<br>`[14]` **Narrator**: "Once inside, I locked the front ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "I was right on time for the game..." |
| `[35]` | **"Turn off the TV."** | `[34]` **Narrator**: "The captain stood up and explain..."<br>`[41]` **Narrator**: "Before kickoff, the team captain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Narrator**: "I couldn't even watch a football..." |
| `[36]` | **"Throw a heavy paperweight at the TV."** | `[34]` **Narrator**: "The captain stood up and explain..."<br>`[41]` **Narrator**: "Before kickoff, the team captain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Narrator**: "I couldn't even watch a football..." |
| `[82]` | **"Think about leaving the country."** | `[85]` **Player_Italic**: "No, it wasn't. Admitting that to..."<br>`[86]` **Narrator**: "The end of my term suddenly felt..." | `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)` | *Brak zmian stanu* | `[83]` **Narrator**: "I could go to Kyrute. It was the..." |
| `[84]` | **"Yes."** | `[77]` **Narrator**: "At least I was on track to win a..."<br>`[78]` **Narrator**: "My chances of re-election were s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "No matter what -- or who -- it w..." |
| `[85]` | **"No."** | `[77]` **Narrator**: "At least I was on track to win a..."<br>`[78]` **Narrator**: "My chances of re-election were s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Player_Italic**: "I went up to my office and began..."<br>`[89]` **Player_Italic**: "I gritted my teeth. I had come t..."<br>*(oraz 1 innych odgałęzień)* |
| `[88]` | **"Draft a speech announcing your retirement from politics."** | `[85]` **Player_Italic**: "No, it wasn't. Admitting that to..."<br>`[104]` **Narrator**: "The end of my term suddenly felt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "My entire life had built up to t..." |
| `[89]` | **"Decide to continue."** | `[85]` **Player_Italic**: "No, it wasn't. Admitting that to..."<br>`[104]` **Narrator**: "The end of my term suddenly felt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "No matter what -- or who -- it w..." |
| `[93]` | **"Leave now."** | `[83]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...`<br>`Variable["BaseGame.Exile_LeaveNow"] = true;` | `[96]` **Narrator**: "It was time for a fresh start." |
| `[94]` | **"Leave after covering up your tracks just in case."** | `[83]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[96]` **Narrator**: "It was time for a fresh start." |
| `[95]` | **"Stick with your plan to retire."** | `[86]` **Narrator**: "The end of my term suddenly felt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "My entire life had built up to t..." |
| `[105]` | **"Stop contemplating and go to bed."** | `[86]` **Narrator**: "The end of my term suddenly felt..."<br>`[104]` **Narrator**: "The end of my term suddenly felt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "My entire life had built up to t..." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The guards formed a cordon to let me through."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Italic: "Give the guards a suspicious look."*)
  - -> `[12]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Get a beer from the fridge."*)
  - -> `[17]` (*Player_Italic: "Go straight to the living room and turn on the TV."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Get a beer from the fridge."*)
  - -> `[17]` (*Player_Italic: "Go straight to the living room and turn on the TV."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Get a beer from the fridge."]** — Mówca: **Player_Italic**
> "I grabbed a beer from the fridge, went to the living room and turned on the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I was right on time for the game to start."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Go straight to the living room and turn on the TV."]** — Mówca: **Player_Italic**
> "I went to the living room and turned on the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I was right on time for the game to start."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I was right on time for the game to start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president. At least my own football team still liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As the game began, I found I couldn't even pay attention ..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Publi..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Right before kickoff, all of the members of FC Anrica sud..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Won == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true || (BaseGam..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true || (BaseGam..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true || (BaseG..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Before kickoff, the team captain gave a short speech than..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech thanking me for all I'd done during my term. At least my own football team still liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As the game began, I found I couldn't even pay attention ..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Right before kickoff, all of the members of FC Anrica suddenly lay down on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The captain stood up and explained that the President of ..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The captain stood up and explained that the President of Sordland had a substantial stake in the team. In protest of my despicable actions, he and his teammates would not be playing tonight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Italic: "Turn off the TV."*)
  - -> `[36]` (*Player_Italic: "Throw a heavy paperweight at the TV."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "Turn off the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "I couldn't even watch a football game without being remin..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "Throw a heavy paperweight at the TV."]** — Mówca: **Player_Italic**
> "I picked up the nearest paperweight and threw it at the screen. Broken glass flew everywhere."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "I couldn't even watch a football game without being remin..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president. At least Anrica still liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As the game began, I found I couldn't even pay attention ..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing Lileas Graf for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Italic: "Turn off the TV."*)
  - -> `[36]` (*Player_Italic: "Throw a heavy paperweight at the TV."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "I couldn't even watch a football game without being reminded of everything I'd done wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And everyone I'd lost."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "And everyone I'd lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Monica..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Monica..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Franc and Deana..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Franc and Deana..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Petr..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Petr..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Poor Serge..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Where would it end?"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Poor Serge..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Where would it end?"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Where would it end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "As the game began, I found I couldn't even pay attention to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I was too busy thinking about everything I had left to do."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "I was too busy thinking about everything I had left to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "And everyone I'd lost."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "My party had abandoned me."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "My party had abandoned me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "My military had turned against me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My military had turned against me."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "The Court wanted me removed from office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "And I'd signed part of my country over to Rumburg..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Pub..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "The Court wanted me removed from office."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "And I'd signed part of my country over to Rumburg..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AttacksSordland == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AttacksSordland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AttacksSordland == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_AttacksSordland == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AttacksSordland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_AttacksSordland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "And Rumburg was on our doorstep..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_AttacksSordland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_AttacksSordland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Pub..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "And Rumburg was on our doorstep..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Pub..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Public_Opinion > 1 || BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Pub..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Won == true || BaseGame.P..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Public_Opinion > 1 || BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Public_Opinion"] > 1  or  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "At least I was on track to win another term. But was that..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Public_Opinion > 1 || BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Public_Opinion"] > 1  or  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "At least I was on track to win another term. But was that what I even wanted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Italic: "Yes."*)
  - -> `[85]` (*Player_Italic: "No."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "My chances of re-election were slim, to say the least. And was that what I even wanted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Italic: "Yes."*)
  - -> `[85]` (*Player_Italic: "No."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "My chances of re-election were slim, to say the least. An..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Kontekst wejściowy (poprzednik):** `[85]` (Player_Italic), `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Italic: "Leave now."*)
  - -> `[94]` (*Player_Italic: "Leave after covering up your tracks just in case."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Yes."]** — Mówca: **Player_Italic**
> "I smiled to myself. My entire life had built up to this presidency. I had to keep going."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "No matter what -- or who -- it would cost me."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "No."]** — Mówca: **Player_Italic**
> "No, it wasn't. Admitting that to myself felt like a heavy weight being lifted off my shoulders."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Italic: "Draft a speech announcing your retirement from politics."*)
  - -> `[89]` (*Player_Italic: "Decide to continue."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "The end of my term suddenly felt years away. If I stayed in Sordland, would I even make it to retirement?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)
  - -> `[95]` (*Player_Italic: "Stick with your plan to retire."*)
  - -> `[105]` (*Player_Italic: "Stop contemplating and go to bed."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "No matter what -- or who -- it would cost me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Player_Italic), `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "My entire life had built up to this presidency. Now, I co..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "Decide to continue."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I had come this far. I would finish what I had started."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Player_Italic), `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "No matter what -- or who -- it would cost me."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeac..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Italic: "Think about leaving the country."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "Leave after covering up your tracks just in case."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks just in case. There were some documents that needed to be incinerated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "Stick with your plan to retire."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I would stick it out until the end of my term -- but no longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "My entire life had built up to this presidency. Now, I co..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "My entire life had built up to this presidency. Now, I couldn't wait for it to be over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The end of my term suddenly felt years away. If I stayed ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The end of my term suddenly felt ages away. And if I cont..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "The end of my term suddenly felt ages away. And if I continued in politics, the years after that would just be more of the same..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Italic: "Draft a speech announcing your retirement from politics."*)
  - -> `[89]` (*Player_Italic: "Decide to continue."*)
  - -> `[105]` (*Player_Italic: "Stop contemplating and go to bed."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "Stop contemplating and go to bed."]** — Mówca: **Player_Italic**
> "I willed myself to stop overthinking everything. I was tired."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator), `[104]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "My entire life had built up to this presidency. Now, I co..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
