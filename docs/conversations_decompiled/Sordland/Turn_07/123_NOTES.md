# Sordland/Turn07/NOTES

- **ID konwersacji:** `123`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/123_NOTES.md`
- **Liczba węzłów dialogowych:** 50
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reform_AssemblyVote_LostBy1`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub`
- `BaseGameIsolated.Turn07_CourtResults_ReportsHub`
- `BaseGameIsolated.Turn07_CourtResults_SpeechHub`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_CourtResults_SpeechHub`

### Skoki między-konwersacyjne:
- Węzeł `[5]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[30]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""I'll also start with a short speech.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: ""We have successfully made chang..."<br>`[17]` **Player**: ""We have worked long and hard bu..."<br>*(oraz 4 innych odgałęzień)* |
| `[4]` | **""I'd like to finish the meeting with a speech.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[17]` | **""We have worked long and hard but we couldn't reform the Sordish Constitution...""** | `[3]` **Player**: ""I'll also start with a short sp..." | `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`<br>`Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[38]` **Petr Vectern**: ""The Supreme Court blocked us on..."<br>`[46]` **Petr Vectern**: ""The Supreme Court blocked us on..."<br>*(oraz 2 innych odgałęzień)* |
| `[42]` | **""We have successfully made changes to the Sordish Constitution. This is a historic..."** | `[3]` **Player**: ""I'll also start with a short sp..." | `Variable["BaseGame.Reform_Reform_Court_Success"] == true`<br>`Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[35]` **Petr Vectern**: ""Even though some people inside ..." |
| `[43]` | **""Sadly and for reasons outside of our control, Sordland had plunged into violent t..."** | `[3]` **Player**: ""I'll also start with a short sp..." | `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`<br>`Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[44]` | **""As we all know, the state of emergency that was declared against the chaos in the..."** | `[3]` **Player**: ""I'll also start with a short sp..." | `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[45]` | **""Sadly and for reasons outside of our control, Sordland had plunged into violent t..."** | `[3]` **Player**: ""I'll also start with a short sp..." | `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`<br>`Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[47]` | **""As we all know, the beginning of our term saw an extraordinary period of violence..."** | `[3]` **Player**: ""I'll also start with a short sp..." | `Variable["BaseGame.Faction_OldGuard_Content"] == true`<br>`(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | *Koniec sceny / Terminal* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: ""I'll also start with a short speech.""]** — Mówca: **Player**
> ""I'll also start with a short speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""I'd like to finish the meeting with a speech.""]** — Mówca: **Player**
> ""I'd like to finish the meeting with a speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PlayerAnnounceHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_SpeechHub = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "Jump to: [PlayerAnnounceHub]"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true && BaseGameIsolated.Turn07_CourtResults_SpeechHub == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_ReportsHub == true &..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true && BaseGameIsolated.Turn07_CourtResults_SpeechHub == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""I'd like to finish the meeting with a speech.""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true && BaseGameIsolated.Turn07_CourtResults_SpeechHub == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""We have reasons to believe that this was an organized effort which Mr. Soll himself was implicated in.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have worked long and hard but we couldn't reform the Sordish Constitution...""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` AND `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: ""The deep state has acted once more. Our proposal had gat..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""Our organization was flawed. Our party was not united. T..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""As we all know, the beginning of our term saw an extraor..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""As we all know, the state of emergency that was declared..."*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""The deep state has acted once more. Our proposal had gathered 166 votes, but was unlawfully rejected. The very parliament we control has stabbed us in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Petr Vectern: ""We have reasons to believe that this was an organized ef..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""Sadly and for reasons outside of our control, Sordland h..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Sadly and for reasons outside of our control, Sordland h..."*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""Our organization was flawed. Our party was not united. The very parliament we control has denied us the reforms.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: ""Even though some people inside of us had hoped to see us..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Even though some people inside of us had hoped to see us fail at the Court... We did succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The cabinet members looked at each other. Petr glanced at..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "The cabinet members looked at each other. Petr glanced at Nia and Ciara."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Narrator**
> "The cabinet members looked at each other and eventually set their eyes on Nia."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Unfortunately, some people within our team had also worked towards this goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The cabinet members looked at each other and eventually s..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""The Supreme Court blocked us once again. Unfortunately, ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Petr Vectern: ""The Supreme Court blocked us once again. Another stain o..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have successfully made changes to the Sordish Constitution. This is a historic accomplishment. Without this team, it couldn't have been possible.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true` AND `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sadly and for reasons outside of our control, Sordland had plunged into violent terror in the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false` AND `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true` AND `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As we all know, the state of emergency that was declared against the chaos in the beginning of our term, is no longer in place.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false` AND `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sadly and for reasons outside of our control, Sordland had plunged into violent terror in the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true` AND `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true` AND `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Another stain on our democracy.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As we all know, the beginning of our term saw an extraordinary period of violence that led us to a state of emergency.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_OldGuard_Content"] == true` AND `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""We have successfully made changes to the Sordish Constit..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""We have worked long and hard but we couldn't reform the ..."*)
