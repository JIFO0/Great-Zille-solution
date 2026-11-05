# Rizia/Turn 10/STRIKE SCENE/INTRO_ABDICATION/ABOLISHMENT/INTRO_ABDICATION/ABOLISHMENT Conversation

- **ID konwersacji:** `558`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/558_ABOLISHMENT_Conversation.md`
- **Liczba węzłów dialogowych:** 129
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Lucita_Married`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[49]`
- Węzeł `[6]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[25]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""I had a whole speech prepared. But now that we're all here, let's just raise a to..."** | `[13]` **Narrator**: "Once inside, I closed the door, ..." | `Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true` | *Brak zmian stanu* | `[5]` **Narrator**: "They looked at one another, seem..." |
| `[10]` | **""A wise man once said, 'Resistance to change is futile when the wheels of time tur..."** | `[13]` **Narrator**: "Once inside, I closed the door, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "There was a tense silence follow..." |
| `[11]` | **""I've called everyone here as a courtesy to inform you that there are going to be ..."** | `[13]` **Narrator**: "Once inside, I closed the door, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Hugo Toras**: ""You've already outdone yourself..." |
| `[12]` | **""I didn't want it to come to this. But alas, here we are.""** | `[13]` **Narrator**: "Once inside, I closed the door, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Narrator**: "The nobles exchange confused looks." |
| `[16]` | **""For centuries, the monarchy has been the stabilizing force of Rizia.""** | `[15]` **Narrator**: "There was a ripple of light laug..."<br>`[71]` **Taddeus Azaro**: ""Resistance to what, exactly?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player_Romus**: ""While the Crown has shouldered ..."<br>`[89]` **Player_Romus**: ""The Crown may have guided us th..."<br>*(oraz 1 innych odgałęzień)* |
| `[17]` | **""Through hardship and prosperity, the Crown has stood firm, guiding this nation th..."** | `[16]` **Player_Romus**: ""For centuries, the monarchy has..."<br>`[76]` **Player_Romus**: ""You people have taken Rizia for..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""While Rizia’s past should be ce..."<br>`[79]` **Player_Romus**: ""But you have failed to protect ..."<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **""While Rizia’s past should be celebrated and revered, we cannot afford to become s..."** | `[17]` **Player_Romus**: ""Through hardship and prosperity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player_Romus**: ""The throne has become a symbol ..."<br>`[19]` **Player_Romus**: ""Clinging too tightly to traditi..."<br>*(oraz 1 innych odgałęzień)* |
| `[19]` | **""Clinging too tightly to tradition risks dragging us into ruin.""** | `[18]` **Player_Romus**: ""While Rizia’s past should be ce..."<br>`[79]` **Player_Romus**: ""But you have failed to protect ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Your Majesty... are you implyin..."<br>`[20]` **Angelica Sazon**: ""Are you saying tradition is a b..."<br>*(oraz 1 innych odgałęzień)* |
| `[45]` | **""I intend to transform Rizia into a democratic republic -- one governed by the peo..."** | `[44]` **Hugo Toras**: ""Quiet, everyone. Let His Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "The guests froze, their eyes ref..." |
| `[58]` | **""That’s why I've brought you here -- to ensure we embrace this change together on ..."** | `[57]` **Angelica Sazon**: ""If you're committed to this cou..."<br>`[64]` **Leona Sazon**: ""If you intend to follow through..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Taddeus Azaro**: ""You’re declaring open war on us..." |
| `[76]` | **""You people have taken Rizia for granted.""** | `[15]` **Narrator**: "There was a ripple of light laug..."<br>`[71]` **Taddeus Azaro**: ""Resistance to what, exactly?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player_Romus**: ""While the Crown has shouldered ..."<br>`[89]` **Player_Romus**: ""The Crown may have guided us th..."<br>*(oraz 1 innych odgałęzień)* |
| `[77]` | **""Rizia is burdened by the weight of its history. She deserves a future unshackled ..."** | `[15]` **Narrator**: "There was a ripple of light laug..."<br>`[71]` **Taddeus Azaro**: ""Resistance to what, exactly?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Player_Romus**: ""While the Crown has shouldered ..."<br>`[89]` **Player_Romus**: ""The Crown may have guided us th..."<br>*(oraz 1 innych odgałęzień)* |
| `[78]` | **""While the Crown has shouldered the cost of your greed and apathy, you grew fat on..."** | `[16]` **Player_Romus**: ""For centuries, the monarchy has..."<br>`[76]` **Player_Romus**: ""You people have taken Rizia for..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Player_Romus**: ""And now, the throne has become ..."<br>`[88]` **Player_Romus**: ""You have failed to protect what..."<br>*(oraz 1 innych odgałęzień)* |
| `[79]` | **""But you have failed to protect what was entrusted to you, and now the kingdom tee..."** | `[17]` **Player_Romus**: ""Through hardship and prosperity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player_Romus**: ""The throne has become a symbol ..."<br>`[81]` **Player_Romus**: ""For it is you who are the engin..."<br>*(oraz 2 innych odgałęzień)* |
| `[80]` | **""I see no heirs to this legacy, only scavengers circling a dying institution.""** | `[78]` **Player_Romus**: ""While the Crown has shouldered ..."<br>`[89]` **Player_Romus**: ""The Crown may have guided us th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player_Romus**: ""The throne has become a symbol ..."<br>`[81]` **Player_Romus**: ""For it is you who are the engin..."<br>*(oraz 2 innych odgałęzień)* |
| `[81]` | **""For it is you who are the engineers of Rizia's demise.""** | `[79]` **Player_Romus**: ""But you have failed to protect ..."<br>`[80]` **Player_Romus**: ""I see no heirs to this legacy, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Your Majesty... are you implyin..."<br>`[20]` **Angelica Sazon**: ""Are you saying tradition is a b..."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **""The world has outgrown kings, and I refuse to be a relic hopelessly tied to a fad..."** | `[18]` **Player_Romus**: ""While Rizia’s past should be ce..."<br>`[79]` **Player_Romus**: ""But you have failed to protect ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Your Majesty... are you implyin..."<br>`[20]` **Angelica Sazon**: ""Are you saying tradition is a b..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **""It’s time for the Crown to fall, so Rizia may rise.""** | `[44]` **Hugo Toras**: ""Quiet, everyone. Let His Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Lucita Azaro**: ""You mean to dismantle the monar..."<br>`[97]` **Taddeus Azaro**: ""You mean to abolish the monarchy?""<br>*(oraz 1 innych odgałęzień)* |
| `[84]` | **""You know, I'm going to remember this moment... the moment when the winds of democ..."** | `[44]` **Hugo Toras**: ""Quiet, everyone. Let His Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "The guests froze, their eyes ref..." |
| `[85]` | **""Oh, who am I kidding. Speeches are useless. You'll never support Rizia's transfor..."** | `[44]` **Hugo Toras**: ""Quiet, everyone. Let His Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "The guests froze, their eyes ref..." |
| `[86]` | **""It leaves you free of your obligations to the Crown.""** | `[57]` **Angelica Sazon**: ""If you're committed to this cou..."<br>`[64]` **Leona Sazon**: ""If you intend to follow through..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Taddeus Azaro**: ""You’re declaring open war on us..." |
| `[87]` | **""Exactly where you deserve to be --without the power you never earned.""** | `[57]` **Angelica Sazon**: ""If you're committed to this cou..."<br>`[64]` **Leona Sazon**: ""If you intend to follow through..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Taddeus Azaro**: ""You’re declaring open war on us..." |
| `[88]` | **""You have failed to protect what was entrusted, and now the kingdom teeters on the..."** | `[78]` **Player_Romus**: ""While the Crown has shouldered ..."<br>`[89]` **Player_Romus**: ""The Crown may have guided us th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player_Romus**: ""The throne has become a symbol ..."<br>`[81]` **Player_Romus**: ""For it is you who are the engin..."<br>*(oraz 2 innych odgałęzień)* |
| `[89]` | **""The Crown may have guided us through war and famine, but those victories now rest..."** | `[16]` **Player_Romus**: ""For centuries, the monarchy has..."<br>`[76]` **Player_Romus**: ""You people have taken Rizia for..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Player_Romus**: ""You have failed to protect what..."<br>`[80]` **Player_Romus**: ""I see no heirs to this legacy, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[90]` | **""But I see no heirs to this legacy, only scavengers circling a dying institution.""** | `[17]` **Player_Romus**: ""Through hardship and prosperity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player_Romus**: ""The throne has become a symbol ..."<br>`[19]` **Player_Romus**: ""Clinging too tightly to traditi..."<br>*(oraz 1 innych odgałęzień)* |
| `[91]` | **""The throne has become a symbol of frailty, not strength.""** | `[18]` **Player_Romus**: ""While Rizia’s past should be ce..."<br>`[79]` **Player_Romus**: ""But you have failed to protect ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Your Majesty... are you implyin..."<br>`[20]` **Angelica Sazon**: ""Are you saying tradition is a b..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **""For once, you'll have to survive on merit rather than privilege.""** | `[57]` **Angelica Sazon**: ""If you're committed to this cou..."<br>`[64]` **Leona Sazon**: ""If you intend to follow through..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Taddeus Azaro**: ""You’re declaring open war on us..." |
| `[103]` | **""And now, the throne has become a symbol of frailty, not strength.""** | `[78]` **Player_Romus**: ""While the Crown has shouldered ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Your Majesty... are you implyin..."<br>`[20]` **Angelica Sazon**: ""Are you saying tradition is a b..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro"); AddConversant("Hugo Toras..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had a whole speech prepared. But now that we're all here, let's just raise a toast.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "They looked at one another, seemingly relieved."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "They looked at one another, seemingly relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "Jump to: [RaiseAToast_Hub]"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RaiseAToast_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == ..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike =..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""I had a whole speech prepared. But now that we're all he..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise man once said, 'Resistance to change is futile when the wheels of time turn unceasingly.'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "There was a tense silence followed by uneasy glances."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've called everyone here as a courtesy to inform you that there are going to be some changes around here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""You've already outdone yourself with the renovations, Yo..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't want it to come to this. But alas, here we are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The nobles exchange confused looks."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Once inside, I closed the door, leaving the celebrations behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""I've called everyone here as a courtesy to inform you th..."*)
  - -> `[10]` (*Player_Romus: ""A wise man once said, 'Resistance to change is futile wh..."*)
  - -> `[12]` (*Player_Romus: ""I didn't want it to come to this. But alas, here we are.""*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == ..."*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""You've already outdone yourself with the renovations, Your Majesty. No need to gild the lily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "There was a ripple of light laughter."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "There was a ripple of light laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For centuries, the monarchy has been the stabilizing force of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator), `[71]` (Taddeus Azaro), `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""While the Crown has shouldered the cost of your greed an..."*)
  - -> `[89]` (*Player_Romus: ""The Crown may have guided us through war and famine, but..."*)
  - -> `[17]` (*Player_Romus: ""Through hardship and prosperity, the Crown has stood fir..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Through hardship and prosperity, the Crown has stood firm, guiding this nation through its darkest and brightest days.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[76]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""While Rizia’s past should be celebrated and revered, we ..."*)
  - -> `[79]` (*Player_Romus: ""But you have failed to protect what was entrusted to you..."*)
  - -> `[90]` (*Player_Romus: ""But I see no heirs to this legacy, only scavengers circl..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While Rizia’s past should be celebrated and revered, we cannot afford to become stuck in it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The throne has become a symbol of frailty, not strength.""*)
  - -> `[19]` (*Player_Romus: ""Clinging too tightly to tradition risks dragging us into..."*)
  - -> `[82]` (*Player_Romus: ""The world has outgrown kings, and I refuse to be a relic..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Clinging too tightly to tradition risks dragging us into ruin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player_Romus), `[79]` (Player_Romus), `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[20]`
Mówca: **Angelica Sazon**
> ""Are you saying tradition is a burden now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Angelica Sazon: ""Are you saying tradition is a burden now?""*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Leona Sazon: ""Are you suggesting that tradition is a burden now?"*)

### Węzeł `[24]`
Mówca: **Leona Sazon**
> ""Are you suggesting that tradition is a burden now?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[28]`
Mówca: **Lucita Azaro**
> "You’re speaking in riddles, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucita Azaro: "You’re speaking in riddles, dear.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucita Azaro: ""You’re speaking in riddles, Your Majesty.""*)

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[33]`
Mówca: **Taddeus Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Carlos Robles Azaro: ""Yes, just what exactly are you trying to tell us?""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Taddeus Azaro: ""You’re speaking in riddles, Your Majesty.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Carlos Robles Azaro: ""You’re speaking in riddles, Your Majesty. Just what exac..."*)

### Węzeł `[37]`
Mówca: **Carlos Robles Azaro**
> ""Yes, just what exactly are you trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Quiet, everyone. Let His Majesty speak.""*)

### Węzeł `[38]`
Mówca: **Carlos Robles Azaro**
> ""You’re speaking in riddles, Your Majesty. Just what exactly is it you're trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Quiet, everyone. Let His Majesty speak.""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Carlos Robles Azaro: ""Yes, just what exactly are you trying to tell us?""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucita Azaro: ""Just what exactly are you trying to tell us?""*)

### Węzeł `[42]`
Mówca: **Carlos Robles Azaro**
> ""Yes, just what exactly are you trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Quiet, everyone. Let His Majesty speak.""*)

### Węzeł `[43]`
Mówca: **Lucita Azaro**
> ""Just what exactly are you trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Quiet, everyone. Let His Majesty speak.""*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Quiet, everyone. Let His Majesty speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""It’s time for the Crown to fall, so Rizia may rise.""*)
  - -> `[85]` (*Player_Romus: ""Oh, who am I kidding. Speeches are useless. You'll never..."*)
  - -> `[45]` (*Player_Romus: ""I intend to transform Rizia into a democratic republic -..."*)
  - -> `[84]` (*Player_Romus: ""You know, I'm going to remember this moment... the momen..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I intend to transform Rizia into a democratic republic -- one governed by the people, for the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The guests froze, their eyes reflecting shock and outrage."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The guests froze, their eyes reflecting shock and outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Romus, please. You can't be serious about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[48]`
Mówca: **Lucita Azaro**
> ""A republic? You mean to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Romus, please. You can't be serious about this.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucita Azaro: ""A republic? You mean to dismantle the monarchy?""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""A republic? You mean to abolish the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Romus, please. You can't be serious about this.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Taddeus Azaro: ""A republic? You mean to abolish the monarchy?""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Carlos Robles Azaro: ""A republic? You intend to dismantle the monarchy?""*)

### Węzeł `[56]`
Mówca: **Carlos Robles Azaro**
> ""A republic? You intend to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Romus, please. You can't be serious about this.""*)

### Węzeł `[57]`
Mówca: **Angelica Sazon**
> ""If you're committed to this course, where does that leave the nobility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""It leaves you free of your obligations to the Crown.""*)
  - -> `[58]` (*Player_Romus: ""That’s why I've brought you here -- to ensure we embrace..."*)
  - -> `[87]` (*Player_Romus: ""Exactly where you deserve to be --without the power you ..."*)
  - -> `[102]` (*Player_Romus: ""For once, you'll have to survive on merit rather than pr..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That’s why I've brought you here -- to ensure we embrace this change together on the best possible terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon), `[64]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Taddeus Azaro: ""You’re declaring open war on us -- a war which you canno..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Angelica Sazon: ""The same holds true for House Sazon. I did not tolerate ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Leona Sazon: ""The same holds true for House Sazon. We will not stand f..."*)

### Węzeł `[62]`
Mówca: **Angelica Sazon**
> ""The same holds true for House Sazon. I did not tolerate this talk coming from Lucas, and I won't hear it coming from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
Mówca: **Leona Sazon**
> ""The same holds true for House Sazon. We will not stand for such treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[64]`
Mówca: **Leona Sazon**
> ""If you intend to follow through with this, where does that leave the nobility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""It leaves you free of your obligations to the Crown.""*)
  - -> `[58]` (*Player_Romus: ""That’s why I've brought you here -- to ensure we embrace..."*)
  - -> `[87]` (*Player_Romus: ""Exactly where you deserve to be --without the power you ..."*)
  - -> `[102]` (*Player_Romus: ""For once, you'll have to survive on merit rather than pr..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Angelica Sazon: ""If you're committed to this course, where does that leav..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Leona Sazon: ""If you intend to follow through with this, where does th..."*)

### Węzeł `[68]`
Mówca: **Taddeus Azaro**
> ""You’re declaring open war on us -- a war which you cannot win!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""As head of House Toras -- your own family -- understand ..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""As head of House Toras -- your own family -- understand this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""You may have the crown, but you do not have us.""*)

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""You may have the crown, but you do not have us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[71]`
Mówca: **Taddeus Azaro**
> ""Resistance to what, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "There was a tense silence followed by uneasy glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Taddeus Azaro: ""Resistance to what, exactly?""*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The nobles exchange confused looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Taddeus Azaro: ""Come to what, exactly?""*)

### Węzeł `[74]`
Mówca: **Taddeus Azaro**
> ""Come to what, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""What is this about, Your Majesty?""*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""What is this about, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You people have taken Rizia for granted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator), `[71]` (Taddeus Azaro), `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""While the Crown has shouldered the cost of your greed an..."*)
  - -> `[89]` (*Player_Romus: ""The Crown may have guided us through war and famine, but..."*)
  - -> `[17]` (*Player_Romus: ""Through hardship and prosperity, the Crown has stood fir..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is burdened by the weight of its history. She deserves a future unshackled from the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator), `[71]` (Taddeus Azaro), `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""While the Crown has shouldered the cost of your greed an..."*)
  - -> `[89]` (*Player_Romus: ""The Crown may have guided us through war and famine, but..."*)
  - -> `[17]` (*Player_Romus: ""Through hardship and prosperity, the Crown has stood fir..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While the Crown has shouldered the cost of your greed and apathy, you grew fat on the very people you were meant to serve.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[76]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""And now, the throne has become a symbol of frailty, not ..."*)
  - -> `[88]` (*Player_Romus: ""You have failed to protect what was entrusted, and now t..."*)
  - -> `[80]` (*Player_Romus: ""I see no heirs to this legacy, only scavengers circling ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But you have failed to protect what was entrusted to you, and now the kingdom teeters on the edge of destruction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The throne has become a symbol of frailty, not strength.""*)
  - -> `[81]` (*Player_Romus: ""For it is you who are the engineers of Rizia's demise.""*)
  - -> `[19]` (*Player_Romus: ""Clinging too tightly to tradition risks dragging us into..."*)
  - -> `[82]` (*Player_Romus: ""The world has outgrown kings, and I refuse to be a relic..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no heirs to this legacy, only scavengers circling a dying institution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[89]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The throne has become a symbol of frailty, not strength.""*)
  - -> `[81]` (*Player_Romus: ""For it is you who are the engineers of Rizia's demise.""*)
  - -> `[19]` (*Player_Romus: ""Clinging too tightly to tradition risks dragging us into..."*)
  - -> `[82]` (*Player_Romus: ""The world has outgrown kings, and I refuse to be a relic..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For it is you who are the engineers of Rizia's demise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Player_Romus), `[80]` (Player_Romus), `[88]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world has outgrown kings, and I refuse to be a relic hopelessly tied to a fading throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player_Romus), `[79]` (Player_Romus), `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s time for the Crown to fall, so Rizia may rise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know, I'm going to remember this moment... the moment when the winds of democracy swept through the land and Rizia's nobles became footnotes in history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The guests froze, their eyes reflecting shock and outrage."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, who am I kidding. Speeches are useless. You'll never support Rizia's transformation into a republic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The guests froze, their eyes reflecting shock and outrage."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It leaves you free of your obligations to the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon), `[64]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Taddeus Azaro: ""You’re declaring open war on us -- a war which you canno..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly where you deserve to be --without the power you never earned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon), `[64]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Taddeus Azaro: ""You’re declaring open war on us -- a war which you canno..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have failed to protect what was entrusted, and now the kingdom teeters on the edge of destruction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[89]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The throne has become a symbol of frailty, not strength.""*)
  - -> `[81]` (*Player_Romus: ""For it is you who are the engineers of Rizia's demise.""*)
  - -> `[19]` (*Player_Romus: ""Clinging too tightly to tradition risks dragging us into..."*)
  - -> `[82]` (*Player_Romus: ""The world has outgrown kings, and I refuse to be a relic..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Crown may have guided us through war and famine, but those victories now rest on forgotten laurels.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus), `[76]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""You have failed to protect what was entrusted, and now t..."*)
  - -> `[80]` (*Player_Romus: ""I see no heirs to this legacy, only scavengers circling ..."*)
  - -> `[19]` (*Player_Romus: ""Clinging too tightly to tradition risks dragging us into..."*)
  - -> `[82]` (*Player_Romus: ""The world has outgrown kings, and I refuse to be a relic..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I see no heirs to this legacy, only scavengers circling a dying institution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The throne has become a symbol of frailty, not strength.""*)
  - -> `[19]` (*Player_Romus: ""Clinging too tightly to tradition risks dragging us into..."*)
  - -> `[82]` (*Player_Romus: ""The world has outgrown kings, and I refuse to be a relic..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The throne has become a symbol of frailty, not strength.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player_Romus), `[79]` (Player_Romus), `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""You people have taken Rizia for granted.""*)
  - -> `[16]` (*Player_Romus: ""For centuries, the monarchy has been the stabilizing for..."*)
  - -> `[77]` (*Player_Romus: ""Rizia is burdened by the weight of its history. She dese..."*)

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""You mean to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Romus, please. You can't be serious about this.""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucita Azaro: ""You mean to dismantle the monarchy?""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[97]`
Mówca: **Taddeus Azaro**
> ""You mean to abolish the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Romus, please. You can't be serious about this.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Taddeus Azaro: ""You mean to abolish the monarchy?""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Carlos Robles Azaro: ""You intend to dismantle the monarchy?""*)

### Węzeł `[101]`
Mówca: **Carlos Robles Azaro**
> ""You intend to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Romus, please. You can't be serious about this.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For once, you'll have to survive on merit rather than privilege.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon), `[64]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Taddeus Azaro: ""You’re declaring open war on us -- a war which you canno..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And now, the throne has become a symbol of frailty, not strength.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro"); AddConversant("Hugo Toras"); AddConversant("Leona Sazon"); AddConversant("Hubertus Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");
AddConversant("Hugo Toras");
AddConversant("Leona Sazon");
AddConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Angelica Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Rico Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Once inside, I closed the door, leaving the celebrations ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "AddConversant("Angelica Sazon");"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "AddConversant("Rico Toras");"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Once inside, I closed the door, leaving the celebrations ..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Manus Sazon: ""Your Majesty... are you implying what I think you are?""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[128]`
Mówca: **Manus Sazon**
> ""Your Majesty... are you implying what I think you are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
