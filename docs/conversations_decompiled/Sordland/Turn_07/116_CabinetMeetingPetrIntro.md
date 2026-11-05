# Sordland/Turn07/CabinetMeetingPetrIntro

- **ID konwersacji:** `116`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/116_CabinetMeetingPetrIntro.md`
- **Liczba węzłów dialogowych:** 291
- **Liczba wyborów gracza:** 19

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Faction_Oligarchs_Destroyed`
- `BaseGame.Faction_Oligarchs_Enemy`
- `BaseGame.Faction_USP_AgainstProposal`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_Default`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_AssemblyVote_LostBy1`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reform_Heron_Convinced`
- `BaseGame.Reform_Reform_Isabel_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Reform_VoteCount_NFP`
- `BaseGame.Reform_VoteCount_PFJP_RictersWing`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn04_PSnW_Education_Progressive`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"Gesture at their seats."** | `[3]` **Narrator**: "When we entered the room, Petr w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "Petr turned towards me. Everybod..." |
| `[7]` | **""Good day everybody. Please have a seat.""** | `[3]` **Narrator**: "When we entered the room, Petr w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "Petr turned towards me. Everybod..." |
| `[8]` | **""Ladies and gentlemen.""** | `[3]` **Narrator**: "When we entered the room, Petr w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "Petr turned towards me. Everybod..." |
| `[9]` | **"Say nothing and watch the room."** | `[3]` **Narrator**: "When we entered the room, Petr w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "Petr stood right next to my seat..." |
| `[57]` | **"Let Petr talk."** | `[16]` **Narrator**: "When I sat down, everybody immed..."<br>`[17]` **Narrator**: "I sat down." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Petr Vectern**: ""Ladies and gentlemen, we are he..." |
| `[58]` | **""What's on our agenda?""** | `[16]` **Narrator**: "When I sat down, everybody immed..."<br>`[17]` **Narrator**: "I sat down." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Petr Vectern**: ""We'll be discussing our current..." |
| `[76]` | **"Look at Nia."** | `[74]` **Narrator**: "The cabinet members started look..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Petr Vectern**: ""The new Constitution has brough..." |
| `[77]` | **"Look at Petr."** | `[74]` **Narrator**: "The cabinet members started look..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Petr Vectern**: ""The new Constitution has brough..." |
| `[81]` | **"Watch the room."** | `[83]` **Narrator**: "The cabinet members started look..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Petr Vectern**: ""Isabel and the other justices l..."<br>`[281]` **Petr Vectern**: ""Heron and the other centrists v..."<br>*(oraz 1 innych odgałęzień)* |
| `[84]` | **"Look at Nia."** | `[83]` **Narrator**: "The cabinet members started look..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Petr Vectern**: ""Isabel and the other justices l..."<br>`[281]` **Petr Vectern**: ""Heron and the other centrists v..."<br>*(oraz 1 innych odgałęzień)* |
| `[85]` | **"Look at Petr."** | `[83]` **Narrator**: "The cabinet members started look..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Petr Vectern**: ""Isabel and the other justices l..."<br>`[281]` **Petr Vectern**: ""Heron and the other centrists v..."<br>*(oraz 1 innych odgałęzień)* |
| `[89]` | **"Look at Ciara."** | `[74]` **Narrator**: "The cabinet members started look..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Petr Vectern**: ""The new Constitution has brough..." |
| `[127]` | **"Keep listening."** | `[108]` **Petr Vectern**: ""You do not need to feel proud, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Petr Vectern**: ""Our success with these changes ..." |
| `[128]` | **""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice P..."** | `[108]` **Petr Vectern**: ""You do not need to feel proud, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Nia Morgna**: ""I'm sorry, Mr. President."" |
| `[142]` | **"Nod in agreement."** | `[141]` **Narrator**: "He glanced at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Petr Vectern**: ""So... Let's start the meeting w..." |
| `[143]` | **"Shake your head in disagreement."** | `[141]` **Narrator**: "He glanced at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Petr Vectern**: ""So... Let's start the meeting w..." |
| `[152]` | **"Keep listening."** | `[156]` **Petr Vectern**: ""And how did you help us inside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Petr Vectern**: ""Maybe we should take a look at ..." |
| `[159]` | **""Mrs. Morgna. As a member of the Supreme Court yourself, you are supposed to have ..."** | `[156]` **Petr Vectern**: ""And how did you help us inside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Nia Morgna**: ""I ca- Yes. I am doing my best, ..." |
| `[160]` | **""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice P..."** | `[156]` **Petr Vectern**: ""And how did you help us inside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Nia Morgna**: ""Understood, Mr. President."" |

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
  - -> `[3]` (*Narrator: "When we entered the room, Petr was speaking to the cabine..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "When we entered the room, Petr was speaking to the cabinet members who were already seated around the table. As soon as they noticed me, they all stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Italic: "Gesture at their seats."*)
  - -> `[7]` (*Player: ""Good day everybody. Please have a seat.""*)
  - -> `[8]` (*Player: ""Ladies and gentlemen.""*)
  - -> `[9]` (*Player_Italic: "Say nothing and watch the room."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Gesture at their seats."]** — Mówca: **Player_Italic**
> "I gestured at their seats."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Petr turned towards me. Everybody except him took their s..."*)

### Węzeł `[5]`
Mówca: **Petr Vectern**
> ""...And here's our president!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He held out my chair for me to sit down and smiled."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Petr turned towards me. Everybody except him took their seats. He stood right next to my chair in the middle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Petr Vectern: ""...And here's our president!""*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Good day everybody. Please have a seat.""]** — Mówca: **Player**
> ""Good day everybody. Please have a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Petr turned towards me. Everybody except him took their s..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Ladies and gentlemen.""]** — Mówca: **Player**
> ""Ladies and gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Petr turned towards me. Everybody except him took their s..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "Say nothing and watch the room."]** — Mówca: **Player_Italic**
> "I looked around at my cabinet members. They were staring at me and waiting for me to speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Petr stood right next to my seat in the middle. He turned..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Petr stood right next to my seat in the middle. He turned to me and gave a wave of his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: ""...And here's our president!""*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""...And here's our president!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "He held out my chair for me to sit down and smiled."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "He held out my chair for me to sit down and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""Please.""*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I sat down."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "He held out my chair for me to sit down and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""Please.""*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "When I sat down, everybody immediately took their seats."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "When I sat down, everybody immediately took their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Let Petr talk."*)
  - -> `[58]` (*Player: ""What's on our agenda?""*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Let Petr talk."*)
  - -> `[58]` (*Player: ""What's on our agenda?""*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""Ladies and gentlemen, we are here to discuss our current status and plan the remaining of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""I know that some of you have had your concerns about our..."*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""I know that some of you have had your concerns about our style of governance so far. There will be a time to speak up about these in the meeting today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""But I must also thank you all for your hard work so far...."*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""But I must also thank you all for your hard work so far. We are very lucky to have a team like this. All of you have been invaluable to this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""We have successfully made changes to the Sordish Constit..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: ""We have worked long and hard but we couldn't reform the ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""We have worked long and hard but we couldn't reform the Sordish Constitution...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""Sadly and for reasons outside of our control, Sordland p..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Petr Vectern: ""Sadly and for reasons outside of our control, Sordland h..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Petr Vectern: ""As we all know, the beginning of our term saw an extraor..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""As we all know, the state of emergency that was declared..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Nia and Ciara grimaced at his remarks."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malen..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == false || BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == false || Ba..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == false || ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == false || BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  or  Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Ciara grimaced at his remarks."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == false || BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  or  Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Fact..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malenyevist >= 6 || BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malen..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Mal..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malenyevist >= 6 || BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Malenyevist"] >= 6  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Lileas grimaced at his remarks."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Malenyevist >= 6 || BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Malenyevist"] >= 6  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == false || Ba..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Faction_Oligarchs_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Fact..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Fa..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Faction_Oligarchs_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] == true  or  Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Gus grimaced at his remarks."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Enemy == true || BaseGame.Faction_Oligarchs_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Enemy"] == true  or  Variable["BaseGame.Faction_Oligarchs_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Having said that... Now we have reached a critical point..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Nia and Ciara grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Having said that... Now we have reached a critical point..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Lileas grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Having said that... Now we have reached a critical point..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Ciara grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Having said that... Now we have reached a critical point..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Gus grimaced at his remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Having said that... Now we have reached a critical point..."*)

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""Having said that... Now we have reached a critical point of our term. We are nearing the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""We have successfully made changes to the Sordish Constitution. This is a historic accomplishment. Without this team, it couldn't have been possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""Sadly and for reasons outside of our control, Sordland plunged into violent terror at the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: ""Today, the state of emergency still continues. Despite m..."*)

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""Today, the state of emergency still continues. Despite making some of our jobs harder, it has also helped stabilize our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: ""I must thank Mr. President for being brave enough to act..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Let Petr talk."]** — Mówca: **Player_Italic**
> "Petr walked to his seat and spoke, still standing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: ""Ladies and gentlemen, we are here to discuss our current..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""What's on our agenda?""]** — Mówca: **Player**
> ""What's on our agenda?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: ""We'll be discussing our current status and planning the ..."*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""We'll be discussing our current status and planning the remainder of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Petr walked to his seat but didn't sit down. He took a lo..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Petr walked to his seat but didn't sit down. He took a look at the ministers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Petr Vectern: ""Now that Mr. President is here, we can begin the meeting..."*)

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""Now that Mr. President is here, we can begin the meeting. I know that some of you have had your concerns about our style of governance so far. There will be a time to speak up about these in the meeting today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""But I must also thank you all for your hard work so far...."*)

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""Sadly and for reasons outside of our control, Sordland had plunged into violent terror in the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: ""As we all know, the state of emergency is no longer in p..."*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""As we all know, the state of emergency is no longer in place. In a plot against President Rayne, it was revoked prematurely by the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Petr Vectern: ""Do not make a mistake. This plot affects all of us. An a..."*)

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""Do not make a mistake. This plot affects all of us. An attack against President Rayne is an attack against our whole administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Petr Vectern: ""It is against the United Sordland Party. And ultimately,..."*)

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""It is against the United Sordland Party. And ultimately, against the people of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He paused and looked around the room."*)

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""As we all know, the beginning of our term saw an extraordinary period of violence that led us to a state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Petr Vectern: ""Mr. President was brave enough to act swiftly, and thus ..."*)

### Węzeł `[67]`
Mówca: **Petr Vectern**
> ""Mr. President was brave enough to act swiftly, and thus we have successfully restored stability in a time of uncertainty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Nia raised an eyebrow and stared at Petr mockingly."*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""As we all know, the state of emergency that was declared against the chaos in the beginning of our term, is no longer in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Petr Vectern: ""Mr. President was brave enough to act swiftly and revoke..."*)

### Węzeł `[69]`
Mówca: **Petr Vectern**
> ""Mr. President was brave enough to act swiftly and revoked his decree when the situation was stabilized. However, the same Justices who agreed to the decree are now trying to use it against him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: ""Do not make a mistake. This is a clear plot that affects..."*)

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""Do not make a mistake. This is a clear plot that affects all of us. An attack against President Rayne is an attack against our whole administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "He paused and looked around the room."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""Even though some people, even within our own administrat..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""The new Constitution has brought us one step closer to t..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "The cabinet members started looking around the room. Petr glanced at Nia and Ciara, who were sitting next to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Italic: "Look at Nia."*)
  - -> `[77]` (*Player_Italic: "Look at Petr."*)
  - -> `[89]` (*Player_Italic: "Look at Ciara."*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Even though some people, even within our own administration, had hoped to see us fail in the Court... We did succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The cabinet members started looking around the room. Petr..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "Look at Nia."]** — Mówca: **Player_Italic**
> "Nia squinted at Petr and frowned. She then noticed me and immediately averted her eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""The new Constitution has brought us one step closer to t..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "Look at Petr."]** — Mówca: **Player_Italic**
> "Petr held his eyes on the two women, an enigmatic smile on his face."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""The new Constitution has brought us one step closer to t..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Petr Vectern: ""The Supreme Court blocked us once again. Unfortunately, ..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Petr Vectern: ""The Supreme Court blocked us once again. Another stain o..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "Watch the room."]** — Mówca: **Player_Italic**
> "The ministers looked concerned and kept watching Petr speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced == false"*)

### Węzeł `[82]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Unfortunately, some people within our team also worked towards this goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "The cabinet members started looking at each other and eve..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "The cabinet members started looking at each other and eventually set their eyes on Nia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Italic: "Look at Nia."*)
  - -> `[85]` (*Player_Italic: "Look at Petr."*)
  - -> `[81]` (*Player_Italic: "Watch the room."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Look at Nia."]** — Mówca: **Player_Italic**
> "Nia squinted at Petr and frowned. She then noticed me and immediately averted her eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced == false"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "Look at Petr."]** — Mówca: **Player_Italic**
> "Petr stared at Nia and narrowed his eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced == false"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "Look at Ciara."]** — Mówca: **Player_Italic**
> "Ciara glanced sideways at Petr and me, avoiding eye contact."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""The new Constitution has brought us one step closer to t..."*)

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""The new Constitution has brought us one step closer to the Sordish dream. We should be proud for having strengthened our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && BaseGa..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Threshold_Default == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true || Base..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Nia raised her hand."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""Our success with these changes has brought with it great..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Nia raised her hand."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Nia raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Nia Morgna: ""Mr. Vice President. I wouldn't go as far to claim that w..."*)

### Węzeł `[101]`
Mówca: **Nia Morgna**
> ""Mr. Vice President. I wouldn't go as far to claim that we have *strengthened our democracy*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true || Base..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Nia raised her hand."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Nia raised her hand."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Nia raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""Mr. Vice President. With all due respect, I wouldn't go ..."*)

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""Mr. Vice President. With all due respect, I wouldn't go as far to claim that we have *strengthened* anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The room fell silent for a few seconds. Petr broke the si..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "The room fell silent for a few seconds. Petr broke the silence with a cough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Petr Vectern: ""You do not need to feel proud, Mrs. Morgna. Please let m..."*)

### Węzeł `[108]`
Mówca: **Petr Vectern**
> ""You do not need to feel proud, Mrs. Morgna. Please let me finish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""We'll talk about that later, Mrs. Morgna. Please be resp..."*)
  - -> `[127]` (*Player_Italic: "Keep listening."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true || Base..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Nia Morgna: ""We know where the real power is gathered.""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The room fell silent for a few seconds. Petr broke the si..."*)

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""We know where the real power is gathered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Everyone in the room turned to look at Nia. Ciara put her..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Everyone in the room turned to look at Nia. Ciara put her hand on Nia's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The room fell silent for a few seconds. Petr broke the si..."*)

### Węzeł `[114]`
Mówca: **Petr Vectern**
> ""But the past is past. We must now look towards our future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Petr Vectern: ""We are investigating and analyzing our faults. We will b..."*)

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Another stain on our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Petr Vectern: ""Me and Lucian know the culprits.""*)

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""The deep state has acted once more. Our proposal had gathered 166 votes, but was unlawfully rejected. The very parliament we control has stabbed us in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Petr Vectern: ""We have reasons to believe that this was an organized ef..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Petr Vectern: ""The deep state has acted once more. Our proposal had gat..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Petr Vectern: ""Our organization was flawed. Our party was not united. T..."*)

### Węzeł `[120]`
Mówca: **Petr Vectern**
> ""We have reasons to believe that this was an organized effort which Mr. Soll himself was implicated in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "The cabinet members started looking at each other."*)

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""Our organization was flawed. Our party was not united. The very parliament we control has denied us the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "The cabinet members started looking at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "He paused and looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Petr Vectern: ""But the past is past. We must now look towards our future.""*)

### Węzeł `[124]`
Mówca: **Petr Vectern**
> ""We are investigating and analyzing our faults. We will be taking measures accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "He glanced at both Lucian and me."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "He glanced at both Lucian and me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Petr Vectern: ""Our party still remains divided. In order to look at the..."*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""Our success with these changes has brought with it great support. Our party --which was divided at the beginning of our term-- is finally coming together once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Italic**
> "Nia did not respond. I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Petr Vectern: ""Our success with these changes has brought with it great..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""]** — Mówca: **Player**
> ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Nia Morgna: ""I'm sorry, Mr. President.""*)

### Węzeł `[129]`
Mówca: **Nia Morgna**
> ""I'm sorry, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Petr Vectern: ""So... Where were we?""*)

### Węzeł `[130]`
Mówca: **Petr Vectern**
> ""So... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Petr Vectern: ""Ah yes. Our success...""*)

### Węzeł `[131]`
Mówca: **Petr Vectern**
> ""Ah yes. Our success...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Petr Vectern: ""Our success with these changes has brought with it great..."*)

### Węzeł `[132]`
Mówca: **Petr Vectern**
> ""Our party still remains divided. In order to look at the future, we may need to make some changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Petr Vectern: ""On the other hand, the opposition is exploiting our fail..."*)

### Węzeł `[133]`
Mówca: **Petr Vectern**
> ""On the other hand, the opposition is exploiting our failure to reform. The latest polls show a steep increase in the opposition's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""I must thank Mr. President for being brave enough to act so swiftly. And thank you all for your understanding our predicament at this difficult time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Iosef was nodding in agreement while Nia and Ciara whispe..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Iosef was nodding in agreement while Nia and Ciara whispered to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Petr Vectern: ""The emergency decree also gives the president the power ..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "Nia raised an eyebrow and stared at Petr mockingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "He paused and looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: ""We are all responsible for the actions of this administr..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He paused and looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: ""We are all responsible for the actions of this administr..."*)

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""The emergency decree also gives the president the power to enact laws that are otherwise not possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Petr Vectern: ""This will open the way for our long-awaited reforms.""*)

### Węzeł `[140]`
Mówca: **Petr Vectern**
> ""This will open the way for our long-awaited reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He glanced at me."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He glanced at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Italic: "Nod in agreement."*)
  - -> `[143]` (*Player_Italic: "Shake your head in disagreement."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "Nod in agreement."]** — Mówca: **Player_Italic**
> "I nodded in agreement."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "Shake your head in disagreement."]** — Mówca: **Player_Italic**
> "I shook my head in disagreement."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""We are all responsible for the actions of this administration. Today, we need to be united more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Petr Vectern: ""We will do whatever it takes to come out of this stronge..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 20"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion >= 20)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 20`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion >= 20)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 5"*)

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""So... Let's start the meeting with a brief look at some reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He fumbled with the stack of papers in front of him."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "He fumbled with the stack of papers in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 20"*)

### Węzeł `[150]`
Mówca: **Petr Vectern**
> ""We will do whatever it takes to come out of this stronger and serve our country better. If need be, we'll make major changes in our party structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Lileas raised an eyebrow and stared at Petr with crossed ..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Lileas raised an eyebrow and stared at Petr with crossed arms. Nia raised her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Nia Morgna: ""Mr. Vice President. I warned you about the path you took..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Italic**
> "Nia did not respond. I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Petr Vectern: ""Maybe we should take a look at our current situation fir..."*)

### Węzeł `[153]`
Mówca: **Nia Morgna**
> ""Mr. Vice President. I warned you about the path you took, but you did not listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Nia Morgna: ""Mr. Hawker is very adamant about the impeachment, and Mr..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "The room fell silent for a few seconds. Petr broke the silence with a cough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Petr Vectern: ""And how did you help us inside the Court, Mrs. Morgna? P..."*)

### Węzeł `[155]`
Mówca: **Petr Vectern**
> ""So... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Petr Vectern: ""Maybe we should take a look at our current situation fir..."*)

### Węzeł `[156]`
Mówca: **Petr Vectern**
> ""And how did you help us inside the Court, Mrs. Morgna? Please let me finish before we start arguing about the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: ""Mrs. Morgna. As a member of the Supreme Court yourself, ..."*)
  - -> `[160]` (*Player: ""We'll talk about that later, Mrs. Morgna. Please be resp..."*)
  - -> `[152]` (*Player_Italic: "Keep listening."*)

### Węzeł `[157]`
Mówca: **Nia Morgna**
> ""Mr. Hawker is very adamant about the impeachment, and Mr. President has given him a good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Everyone in the room was looking at Nia. Ciara, who sat n..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Everyone in the room was looking at Nia. Ciara, who sat next to her, put her hand on Nia's shoulder and slightly pulled her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "The room fell silent for a few seconds. Petr broke the si..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Mrs. Morgna. As a member of the Supreme Court yourself, you are supposed to have this case dismissed.""]** — Mówca: **Player**
> ""Mrs. Morgna. As a member of the Supreme Court yourself, you are supposed to have this case dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Nia Morgna: ""I ca- Yes. I am doing my best, of course.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""]** — Mówca: **Player**
> ""We'll talk about that later, Mrs. Morgna. Please be respectful and let the Vice President speak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Nia Morgna: ""Understood, Mr. President.""*)

### Węzeł `[161]`
Mówca: **Nia Morgna**
> ""Understood, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Petr Vectern: ""So... Where were we?""*)

### Węzeł `[162]`
Mówca: **Nia Morgna**
> ""I ca- Yes. I am doing my best, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Petr Vectern: ""You have our complete trust, Mrs. Morgna.""*)

### Węzeł `[163]`
Mówca: **Petr Vectern**
> ""You have our complete trust, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Petr smiled at her."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Petr smiled at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Petr Vectern: ""So... Where were we?""*)

### Węzeł `[165]`
Mówca: **Petr Vectern**
> ""Maybe we should take a look at our current situation first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[166]`
Mówca: **Petr Vectern**
> ""According to the latest polls, we have seen an increase in our popularity. The public opinion is most positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Facti..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Petr Vectern: ""According to the latest polls, we have seen an increase ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Petr Vectern: ""Despite the recent troubles, we have seen an increase in..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Reformist_Path == true || BaseGame.Ref..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Petr Vectern: ""According to the latest polls, we have seen an increase ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Facti..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Petr Vectern: ""According to the latest polls, we have seen an enormous ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Petr Vectern: ""With the latest developments, we have seen an enormous d..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Reformist_Path == true || BaseGame.Ref..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Petr Vectern: ""According to the latest polls, we have seen an enormous ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Facti..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Petr Vectern: ""According to the latest polls, people seem to be content..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Petr Vectern: ""Despite the recent troubles, people seem to be content a..."*)

### Węzeł `[182]`
Mówca: **Petr Vectern**
> ""According to the latest polls, people seem to be content about our administration. The public opinion has not changed much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Reformist_Path == true || BaseGame.Ref..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Petr Vectern: ""According to the latest polls, people seem to be content..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 5"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion >= 5)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 0"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Facti..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Petr Vectern: ""According to the latest polls, we have seen a decrease i..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Petr Vectern: ""With the latest developments, we have seen a decrease in..."*)

### Węzeł `[192]`
Mówca: **Petr Vectern**
> ""According to the latest polls, we have seen a decrease in our popularity. The public opinion has shrunk since we took office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Reformist_Path == true || BaseGame.Ref..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Petr Vectern: ""According to the latest polls, we have seen a decrease i..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true) && BaseGame.Reform_Reform_Court_Success == true == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Faction..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 0"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion >= 0)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Reformist_Path == true || BaseGame.Refor..."*)

### Węzeł `[199]`
Mówca: **Petr Vectern**
> ""Despite the recent troubles, we have seen an increase in our popularity in general. The public opinion is most positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[200]`
Mówca: **Petr Vectern**
> ""Despite the recent troubles, people seem to be content about our administration. The public opinion has not changed much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[201]`
Mówca: **Petr Vectern**
> ""With the latest developments, we have seen a decrease in our popularity. The public opinion has shrunk since we took office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[202]`
Mówca: **Petr Vectern**
> ""According to the latest polls, we have seen an enormous decrease in our popularity. The public opinion about our party is at an all-time low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[203]`
Mówca: **Petr Vectern**
> ""With the latest developments, we have seen an enormous decrease in our popularity. The public opinion about our party is at an all-time low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[204]`
Mówca: **Petr Vectern**
> ""Citizens are most concerned about the state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Petr Vectern: ""Citizens are most concerned about the state of emergency.""*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Petr Vectern: ""Our historic constitutional changes did not reflect well..."*)

### Węzeł `[208]`
Mówca: **Petr Vectern**
> ""Our historic constitutional changes did not reflect well on our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He took out a piece of paper from the stack and inspected..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Petr Vectern: ""One of the most important factors for the people's conte..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Petr Vectern: ""The biggest factor for the people's contentment is the s..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Petr Vectern: ""The biggest concern of the people is the state of our ec..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Petr Vectern: ""The biggest concern of the people is the state of our ec..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "He took out a piece of paper from the stack and inspected it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[219]`
Mówca: **Petr Vectern**
> ""The biggest factor for the people's contentment is the state of our economy. We have stopped the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Petr Vectern: ""I must thank Mr. Holl for his great work.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Petr Vectern: ""A major concern of the people is the state of our econom..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Petr Vectern: ""A major concern of the people is the state of our econom..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Petr Vectern: ""Despite everything, we have managed to greatly slow down..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Petr Vectern: ""Despite everything, the state of our economy is in very ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4"*)

### Węzeł `[229]`
Mówca: **Narrator**
> "He took out a piece of paper from the stack and inspected it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[230]`
Mówca: **Petr Vectern**
> ""One of the most important factors for the people's contentment is the state of our economy. We have greatly slowed down the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Petr Vectern: ""I must thank Mr. Holl for his great work.""*)

### Węzeł `[231]`
Mówca: **Petr Vectern**
> ""The biggest concern of the people is the state of our economy. We are still plagued by the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Petr Vectern: ""It is only a matter of time until the people will be hit..."*)

### Węzeł `[232]`
Mówca: **Petr Vectern**
> ""The biggest concern of the people is the state of our economy. We are slowly slipping into a depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Petr Vectern: ""It is only a matter of time until the people will be hit..."*)

### Węzeł `[233]`
Mówca: **Petr Vectern**
> ""It is only a matter of time until the people will be hit further. This will have dire consequences for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Petr Vectern: ""This is the time to give the best we can. For this admin..."*)

### Węzeł `[234]`
Mówca: **Petr Vectern**
> ""Despite everything, the state of our economy is in very good shape. We have stopped the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Petr Vectern: ""If everything goes well, it is a matter of time that peo..."*)

### Węzeł `[235]`
Mówca: **Petr Vectern**
> ""Despite everything, we have managed to greatly slow down the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Petr Vectern: ""If everything goes well, it is a matter of time that peo..."*)

### Węzeł `[236]`
Mówca: **Petr Vectern**
> ""A major concern of the people is the state of our economy. We are still plagued by the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Petr Vectern: ""This will have dire consequences for our administration.""*)

### Węzeł `[237]`
Mówca: **Petr Vectern**
> ""This will have dire consequences for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Petr Vectern: ""We mustn't lose hope and give it our best. Sordland need..."*)

### Węzeł `[238]`
Mówca: **Petr Vectern**
> ""A major concern of the people is the state of our economy. We are slowly slipping into a depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Petr Vectern: ""This will have dire consequences for our administration.""*)

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""If everything goes well, it is a matter of time that people will feel its results. Our economy is not looking too bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Petr Vectern: ""This is the time to give the best we can. For this admin..."*)

### Węzeł `[240]`
Mówca: **Petr Vectern**
> ""I must thank Mr. Holl for his great work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Symon nodded with a dimpled smile."*)

### Węzeł `[241]`
Mówca: **Petr Vectern**
> ""This is the time to give the best we can. For this administration and for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Petr turned to me."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Symon nodded with a dimpled smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Petr turned to me."*)

### Węzeł `[243]`
Mówca: **Petr Vectern**
> ""We mustn't lose hope and give it our best. Sordland needs us more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Petr turned to me."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "Petr turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Petr Vectern: ""I'll give the word to the President now.""*)

### Węzeł `[245]`
Mówca: **Petr Vectern**
> ""I'll give the word to the President now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[246]`
Mówca: **Petr Vectern**
> ""If everything goes well, it is a matter of time that people will feel its results. Our economy is looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Petr Vectern: ""This is the time to give the best we can. For this admin..."*)

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""Our success with these changes has brought with it great support. Our party --which was divided at the beginning of our term-- is finally coming together once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""So... Let's start the meeting with a brief look at some ..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_VoteCount_NFP <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_VoteCount_NFP <= 1"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_VoteCount_NFP <= 1)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_VoteCount_NFP <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_VoteCount_NFP"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Petr Vectern: ""Kesaro Kibener and the National Front MP's didn't like t..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_VoteCount_NFP <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_VoteCount_NFP"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_VoteCount_PFJP_RictersWing"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Petr Vectern: ""Frens Ricter and the PFJP left us hanging on the assembl..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_VoteCount_PFJP_RictersWing"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_VoteCount_NFP <= 1"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == false)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Petr Vectern: ""Albin and the reformist wing didn't vote for us.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Enemy == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Petr Vectern: ""The Lotherberg group led a massive lobbying effort again..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He paused and looked around the room."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == false"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == false)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Petr Vectern: ""Gloria and the conservative wing of the party didn't bac..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Family_Important == true && BaseGame.Bi..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Family_Important == true && BaseGame.Bill_Turn01_CampaignFinance_Signed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Family_Important == true && BaseGame.Bi..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Family_Important == true && BaseGame...."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Family_Important == true && BaseGame.Bill_Turn01_CampaignFinance_Signed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Family_Important"] == true  and  Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Petr Vectern: ""Some party centrists have opposed us due to our decision..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Family_Important == true && BaseGame.Bill_Turn01_CampaignFinance_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Family_Important"] == true  and  Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false"*)

### Węzeł `[266]`
Mówca: **Petr Vectern**
> ""Gloria and the conservative wing of the party didn't back us up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Family_Important == true && BaseGame.Bi..."*)

### Węzeł `[267]`
Mówca: **Petr Vectern**
> ""Some party centrists have opposed us due to our decision to veto the campaign finance bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false"*)

### Węzeł `[268]`
Mówca: **Petr Vectern**
> ""Albin and the reformist wing didn't vote for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_VoteCount_PFJP_RictersWing <= 2"*)

### Węzeł `[269]`
Mówca: **Petr Vectern**
> ""Frens Ricter and the PFJP left us hanging on the assembly floor. They voted nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_VoteCount_NFP <= 1"*)

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""Kesaro Kibener and the National Front MP's didn't like the proposal and voted against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true"*)

### Węzeł `[271]`
Mówca: **Petr Vectern**
> ""The Lotherberg group led a massive lobbying effort against us in the Assembly which caused us to lose many votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He paused and looked around the room."*)

### Węzeł `[272]`
Mówca: **Petr Vectern**
> ""Lucian and I have begun investigating who let us down at the vote when we needed them the most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == false"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_Convinced == false"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_Convinced == false)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Petr Vectern: ""Heron and the other centrists voted against us.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He paused and looked around the room."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Isabel_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced == false"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Isabel_Convinced == false)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Isabel_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Petr Vectern: ""Isabel and the other justices lenient to her legal opini..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Isabel_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Isabel_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_Convinced == false"*)

### Węzeł `[279]`
Mówca: **Petr Vectern**
> ""Me and Lucian know the culprits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced == false"*)

### Węzeł `[280]`
Mówca: **Petr Vectern**
> ""Isabel and the other justices lenient to her legal opinion did not support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_Convinced == false"*)

### Węzeł `[281]`
Mówca: **Petr Vectern**
> ""Heron and the other centrists voted against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He paused and looked around the room."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Petr Vectern: ""We lost most of our support after editing the proposal t..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Petr Vectern: ""Lucian and I have begun investigating who let us down at..."*)

### Węzeł `[285]`
Mówca: **Petr Vectern**
> ""We lost most of our support after editing the proposal to include changes to Articles 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_AgainstProposal == true"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_AgainstProposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_AgainstProposal == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_AgainstProposal == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_AgainstProposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_AgainstProposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Petr Vectern: ""The higher-ups of the USP has abandoned their support fo..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_AgainstProposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_AgainstProposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Petr Vectern: ""Despite doing our best, we didn't get enough support fro..."*)

### Węzeł `[289]`
Mówca: **Petr Vectern**
> ""Despite doing our best, we didn't get enough support from the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true"*)

### Węzeł `[290]`
Mówca: **Petr Vectern**
> ""The higher-ups of the USP has abandoned their support for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Enemy == true"*)
