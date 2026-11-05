# Rizia/Turn 6/FPnT_DukeWarPhoneCall

- **ID konwersacji:** `368`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/368_FPnT_DukeWarPhoneCall.md`
- **Liczba węzłów dialogowych:** 93
- **Liczba wyborów gracza:** 40

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pales_War`
- `RiziaDLC.PostIncident_Border_JointInvestigation`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.War_Incident_Border`
- `RiziaDLC.War_Incident_Naval`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Duke Reinhart. What a pleasure it is to have the chance to speak with you again.""** | `[4]` **Narrator**: "I placed the phone to my ear. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Axel Reinhart**: ""I'm afraid I don't see it that ..."<br>`[5]` **Axel Reinhart**: ""Oh... Your Majesty. I've been w..." |
| `[7]` | **""This is the King speaking.""** | `[4]` **Narrator**: "I placed the phone to my ear. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Axel Reinhart**: ""I didn't expect to have a dialo..."<br>`[5]` **Axel Reinhart**: ""Oh... Your Majesty. I've been w..." |
| `[8]` | **""Hello, Axel.""** | `[4]` **Narrator**: "I placed the phone to my ear. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Axel Reinhart**: ""I didn't expect to have a dialo..."<br>`[5]` **Axel Reinhart**: ""Oh... Your Majesty. I've been w..." |
| `[9]` | **""It's King Romus Toras. The Ruler of Rizia Imperii, and Valenqiris, and of Brenas ..."** | `[4]` **Narrator**: "I placed the phone to my ear. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Axel Reinhart**: ""Am I supposed to be impressed?"" |
| `[19]` | **""Indeed. You should be.""** | `[18]` **Axel Reinhart**: ""Am I supposed to be impressed?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Axel Reinhart**: ""The world knows it was Rizia wh..."<br>`[31]` **Axel Reinhart**: ""So... What did you want to tell..." |
| `[20]` | **""It is just part of the protocol, as you know.""** | `[18]` **Axel Reinhart**: ""Am I supposed to be impressed?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Axel Reinhart**: ""The world knows it was Rizia wh..."<br>`[31]` **Axel Reinhart**: ""So... What did you want to tell..." |
| `[21]` | **""Well... It doesn't really matter, Your Grace.""** | `[18]` **Axel Reinhart**: ""Am I supposed to be impressed?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Axel Reinhart**: ""The world knows it was Rizia wh..."<br>`[31]` **Axel Reinhart**: ""So... What did you want to tell..." |
| `[22]` | **""Me too, Your Grace. And now, you're going to hear me out.""** | `[5]` **Axel Reinhart**: ""Oh... Your Majesty. I've been w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Axel Reinhart**: ""I'm listening."" |
| `[23]` | **""Good. Because I wanted to talk to you about something.""** | `[5]` **Axel Reinhart**: ""Oh... Your Majesty. I've been w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Axel Reinhart**: ""I'm listening."" |
| `[24]` | **""I'm afraid I'm not bringing good news, Your Grace.""** | `[5]` **Axel Reinhart**: ""Oh... Your Majesty. I've been w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Axel Reinhart**: ""I'm listening."" |
| `[25]` | **""Given the circumstances, I never thought I would be giving you a personal phone c..."** | `[16]` **Axel Reinhart**: ""I didn't expect to have a dialo..."<br>`[17]` **Axel Reinhart**: ""I'm afraid I don't see it that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Axel Reinhart**: ""I'm listening."" |
| `[26]` | **""Me neither. So listen carefully.""** | `[16]` **Axel Reinhart**: ""I didn't expect to have a dialo..."<br>`[17]` **Axel Reinhart**: ""I'm afraid I don't see it that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Axel Reinhart**: ""I'm listening."" |
| `[27]` | **""Well... I'm not bringing good news, Your Grace.""** | `[16]` **Axel Reinhart**: ""I didn't expect to have a dialo..."<br>`[17]` **Axel Reinhart**: ""I'm afraid I don't see it that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Axel Reinhart**: ""I wasn't expecting anything less."" |
| `[32]` | **""Even after Pales' horrific actions, I am showing you my respect by opening commun..."** | `[86]` **Axel Reinhart**: ""And yet you decided not to even..."<br>`[31]` **Axel Reinhart**: ""So... What did you want to tell..." | `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true` | *Brak zmian stanu* | `[45]` **Narrator**: "He went silent." |
| `[36]` | **""Please listen to me very carefully. This is your last chance.""** | `[31]` **Axel Reinhart**: ""So... What did you want to tell..."<br>`[86]` **Axel Reinhart**: ""And yet you decided not to even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "He went silent." |
| `[37]` | **""I am giving you a gentlemanly head start by informing you of my decision to invad..."** | `[31]` **Axel Reinhart**: ""So... What did you want to tell..."<br>`[86]` **Axel Reinhart**: ""And yet you decided not to even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Axel Reinhart**: ""No... You can't be serious."" |
| `[38]` | **""I wanted to offer you a way out. Surrender the duchy and swear fealty to the Rizi..."** | `[31]` **Axel Reinhart**: ""So... What did you want to tell..."<br>`[86]` **Axel Reinhart**: ""And yet you decided not to even..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Axel Reinhart**: ""Hah... You can't be serious."" |
| `[42]` | **""There are no jokes, Your Grace. Pales has become a rogue nation with you at its h..."** | `[41]` **Narrator**: "There was a brief silence." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[60]` **Player_Romus**: ""You will surrender the Aureus f..."<br>`[59]` **Player_Romus**: ""I only want you to swear allegi..."<br>*(oraz 2 innych odgałęzień)* |
| `[43]` | **""The quicker you grasp the reality of the situation the better, Your Grace. I'm an..."** | `[41]` **Narrator**: "There was a brief silence." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Axel Reinhart**: ""What?"" |
| `[44]` | **""But I am. So listen to me very carefully.""** | `[41]` **Narrator**: "There was a brief silence." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "He went silent." |
| `[46]` | **""This is not a joke, Your Grace. Pales has become a rogue nation with you at its h..."** | `[45]` **Narrator**: "He went silent." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[60]` **Player_Romus**: ""You will surrender the Aureus f..."<br>`[59]` **Player_Romus**: ""I only want you to swear allegi..."<br>*(oraz 2 innych odgałęzień)* |
| `[49]` | **""I'm sure I don't need to remind you of how much stronger the Rizian Armed Forces ..."** | `[45]` **Narrator**: "He went silent." | `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true` | *Brak zmian stanu* | `[56]` **Axel Reinhart**: ""And?"" |
| `[53]` | **""I'm sure I don't need to remind you of how much larger Rizia is than Pales...""** | `[45]` **Narrator**: "He went silent." | `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false` | *Brak zmian stanu* | `[56]` **Axel Reinhart**: ""And?"" |
| `[54]` | **""I am aware of your intentions to let the western powers settle in our region in e..."** | `[45]` **Narrator**: "He went silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Axel Reinhart**: ""What are you talking about?"" |
| `[57]` | **""I'm offering a peaceful way out from your dire situation.""** | `[45]` **Narrator**: "He went silent." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[60]` **Player_Romus**: ""You will surrender the Aureus f..."<br>`[59]` **Player_Romus**: ""I only want you to swear allegi..."<br>*(oraz 2 innych odgałęzień)* |
| `[58]` | **""I cannot allow you to become a threat to our energy industry. You must understand..."** | `[45]` **Narrator**: "He went silent." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[60]` **Player_Romus**: ""You will surrender the Aureus f..."<br>`[59]` **Player_Romus**: ""I only want you to swear allegi..."<br>*(oraz 2 innych odgałęzień)* |
| `[59]` | **""I only want you to swear allegiance to the Rizian crown and reunite Pales with Ri..."** | `[68]` **Player_Romus**: ""If you want peace... Listen to ..."<br>`[42]` **Player_Romus**: ""There are no jokes, Your Grace...."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Axel Reinhart**: ""You must be insane if you think..." |
| `[60]` | **""You will surrender the Aureus field to Rizia completely.""** | `[68]` **Player_Romus**: ""If you want peace... Listen to ..."<br>`[42]` **Player_Romus**: ""There are no jokes, Your Grace...."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Axel Reinhart**: ""You must be insane if you think..." |
| `[61]` | **""You will surrender all the territories except the city of Pales to Rizia.""** | `[68]` **Player_Romus**: ""If you want peace... Listen to ..."<br>`[42]` **Player_Romus**: ""There are no jokes, Your Grace...."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Axel Reinhart**: ""You must be insane if you think..." |
| `[62]` | **""The quicker you grasp the reality of the situation the better, Your Grace. I'm an..."** | `[42]` **Player_Romus**: ""There are no jokes, Your Grace...."<br>`[46]` **Player_Romus**: ""This is not a joke, Your Grace...."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Axel Reinhart**: ""What?"" |
| `[67]` | **""It's too late for that.""** | `[66]` **Axel Reinhart**: ""We can't lead our countries to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Axel Reinhart**: ""You must be insane if you think..." |
| `[68]` | **""If you want peace... Listen to me very carefully.""** | `[66]` **Axel Reinhart**: ""We can't lead our countries to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player_Romus**: ""You will surrender the Aureus f..."<br>`[59]` **Player_Romus**: ""I only want you to swear allegi..."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **""Think of your people, Axel. Think of the destruction your people will suffer. Sur..."** | `[63]` **Axel Reinhart**: ""You must be insane if you think..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Axel Reinhart**: ""Pales stood against the forces ..." |
| `[70]` | **""You are right. I am insane. But I thought you were cleverer than that.""** | `[63]` **Axel Reinhart**: ""You must be insane if you think..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Axel Reinhart**: ""Pales stood against the forces ..." |
| `[71]` | **""You still dare insult me? You will pay for this, Duke Reinhart.""** | `[63]` **Axel Reinhart**: ""You must be insane if you think..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Axel Reinhart**: ""Pales stood against the forces ..." |
| `[72]` | **""That's it, then. It's war.""** | `[63]` **Axel Reinhart**: ""You must be insane if you think..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Axel Reinhart**: ""Pales stood against the forces ..." |
| `[73]` | **""Remember: I gave you a choice, and you refused. You will regret it.""** | `[65]` **Axel Reinhart**: ""If you insist on repeating his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "I hung up." |
| `[74]` | **""This time it will be very different.""** | `[65]` **Axel Reinhart**: ""If you insist on repeating his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "I hung up." |
| `[75]` | **""I am sorry it had to come to this, Axel. I hope you'll survive the war.""** | `[65]` **Axel Reinhart**: ""If you insist on repeating his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "I hung up." |
| `[76]` | **""Have a good day, Axel.""** | `[65]` **Axel Reinhart**: ""If you insist on repeating his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "I hung up." |

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
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Threatening their neighouring country ov..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I sat in my office, waiting to place the call that would change the future of Rizia and Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I placed the phone to my ear. I took a deep breath as the Palesian palace operators connected me to Duke Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""Duke Reinhart. What a pleasure it is to have the chance ..."*)
  - -> `[7]` (*Player_Romus: ""This is the King speaking.""*)
  - -> `[8]` (*Player_Romus: ""Hello, Axel.""*)
  - -> `[9]` (*Player_Romus: ""It's King Romus Toras. The Ruler of Rizia Imperii, and V..."*)

### Węzeł `[5]`
Mówca: **Axel Reinhart**
> ""Oh... Your Majesty. I've been waiting to hear from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""Me too, Your Grace. And now, you're going to hear me out.""*)
  - -> `[23]` (*Player_Romus: ""Good. Because I wanted to talk to you about something.""*)
  - -> `[24]` (*Player_Romus: ""I'm afraid I'm not bringing good news, Your Grace.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart. What a pleasure it is to have the chance to speak with you again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Bord..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the King speaking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hello, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's King Romus Toras. The Ruler of Rizia Imperii, and Valenqiris, and of Brenas and Iza; of Cardesse and Montaklar, and the ancient lands of the Rezenids, Descendant of the Most Honorable Queen Lyza and King Valero, and the Sovereign of the Kingdom of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Axel Reinhart: ""Am I supposed to be impressed?""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Axel Reinhart: ""I didn't expect to have a dialogue with you after what h..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Axel Reinhart: ""Oh... Your Majesty. I've been waiting to hear from you.""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Axel Reinhart: ""I'm afraid I don't see it that way, Your Majesty. Especi..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Axel Reinhart: ""Oh... Your Majesty. I've been waiting to hear from you.""*)

### Węzeł `[16]`
Mówca: **Axel Reinhart**
> ""I didn't expect to have a dialogue with you after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Given the circumstances, I never thought I would be givi..."*)
  - -> `[26]` (*Player_Romus: ""Me neither. So listen carefully.""*)
  - -> `[27]` (*Player_Romus: ""Well... I'm not bringing good news, Your Grace.""*)

### Węzeł `[17]`
Mówca: **Axel Reinhart**
> ""I'm afraid I don't see it that way, Your Majesty. Especially after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Given the circumstances, I never thought I would be givi..."*)
  - -> `[26]` (*Player_Romus: ""Me neither. So listen carefully.""*)
  - -> `[27]` (*Player_Romus: ""Well... I'm not bringing good news, Your Grace.""*)

### Węzeł `[18]`
Mówca: **Axel Reinhart**
> ""Am I supposed to be impressed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Indeed. You should be.""*)
  - -> `[20]` (*Player_Romus: ""It is just part of the protocol, as you know.""*)
  - -> `[21]` (*Player_Romus: ""Well... It doesn't really matter, Your Grace.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. You should be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is just part of the protocol, as you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... It doesn't really matter, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Me too, Your Grace. And now, you're going to hear me out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Axel Reinhart: ""I'm listening.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Because I wanted to talk to you about something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Axel Reinhart: ""I'm listening.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid I'm not bringing good news, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Axel Reinhart: ""I'm listening.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given the circumstances, I never thought I would be giving you a personal phone call. But here we are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Axel Reinhart), `[17]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Axel Reinhart: ""I'm listening.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Me neither. So listen carefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Axel Reinhart), `[17]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Axel Reinhart: ""I'm listening.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... I'm not bringing good news, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Axel Reinhart), `[17]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Axel Reinhart: ""I wasn't expecting anything less.""*)

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""I wasn't expecting anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)

### Węzeł `[29]`
Mówca: **Axel Reinhart**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)

### Węzeł `[30]`
Mówca: **Axel Reinhart**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Axel Reinhart: ""So... What did you want to tell me, Your Majesty?""*)

### Węzeł `[31]`
Mówca: **Axel Reinhart**
> ""So... What did you want to tell me, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[36]` (*Player_Romus: ""Please listen to me very carefully. This is your last ch..."*)
  - -> `[37]` (*Player_Romus: ""I am giving you a gentlemanly head start by informing yo..."*)
  - -> `[38]` (*Player_Romus: ""I wanted to offer you a way out. Surrender the duchy and..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even after Pales' horrific actions, I am showing you my respect by opening communications. Let that be clear.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Kontekst wejściowy (poprzednik):** `[86]` (Axel Reinhart), `[31]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He went silent."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""Even after Pales' horrific actions, I am showing you my ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please listen to me very carefully. This is your last chance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Axel Reinhart), `[86]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He went silent."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am giving you a gentlemanly head start by informing you of my decision to invade Pales, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Axel Reinhart), `[86]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Axel Reinhart: ""No... You can't be serious.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to offer you a way out. Surrender the duchy and swear fealty to the Rizian crown, so we can be stronger together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Axel Reinhart), `[86]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Axel Reinhart: ""Hah... You can't be serious.""*)

### Węzeł `[39]`
Mówca: **Axel Reinhart**
> ""Hah... You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "There was a brief silence."*)

### Węzeł `[40]`
Mówca: **Axel Reinhart**
> ""No... You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "There was a brief silence."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""But I am. So listen to me very carefully.""*)
  - -> `[42]` (*Player_Romus: ""There are no jokes, Your Grace. Pales has become a rogue..."*)
  - -> `[43]` (*Player_Romus: ""The quicker you grasp the reality of the situation the b..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are no jokes, Your Grace. Pales has become a rogue nation with you at its head. Rizia will militarily intervene -- if you don't comply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The quicker you grasp the reality of the situation the better, Your Grace. I'm announcing the invasion of Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Axel Reinhart: ""What?""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I am. So listen to me very carefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "He went silent."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "He went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""I cannot allow you to become a threat to our energy indu..."*)
  - -> `[54]` (*Player_Romus: ""I am aware of your intentions to let the western powers ..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == tr..."*)
  - -> `[46]` (*Player_Romus: ""This is not a joke, Your Grace. Pales has become a rogue..."*)
  - -> `[57]` (*Player_Romus: ""I'm offering a peaceful way out from your dire situation.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not a joke, Your Grace. Pales has become a rogue nation with you at its head. Rizia will militarily intervene -- if you don't comply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Axel Reinhart: ""We can't lead our countries to war. Peace must be mainta..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""You will surrender the Aureus field to Rizia completely.""*)
  - -> `[59]` (*Player_Romus: ""I only want you to swear allegiance to the Rizian crown ..."*)
  - -> `[61]` (*Player_Romus: ""You will surrender all the territories except the city o..."*)
  - -> `[62]` (*Player_Romus: ""The quicker you grasp the reality of the situation the b..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure I don't need to remind you of how much stronger the Rizian Armed Forces are compared to Pales' armies...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Axel Reinhart: ""And?""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == tr..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == ..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""I'm sure I don't need to remind you of how much stronger..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""I'm sure I don't need to remind you of how much larger R..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure I don't need to remind you of how much larger Rizia is than Pales...""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Axel Reinhart: ""And?""*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am aware of your intentions to let the western powers settle in our region in exchange for your own security. I will not allow that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Axel Reinhart: ""What are you talking about?""*)

### Węzeł `[55]`
Mówca: **Axel Reinhart**
> ""What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[56]`
Mówca: **Axel Reinhart**
> ""And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm offering a peaceful way out from your dire situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot allow you to become a threat to our energy industry. You must understand my situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only want you to swear allegiance to the Rizian crown and reunite Pales with Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Player_Romus), `[42]` (Player_Romus), `[46]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""You must be insane if you think I'll give in to your thr..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will surrender the Aureus field to Rizia completely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Player_Romus), `[42]` (Player_Romus), `[46]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""You must be insane if you think I'll give in to your thr..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will surrender all the territories except the city of Pales to Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Player_Romus), `[42]` (Player_Romus), `[46]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""You must be insane if you think I'll give in to your thr..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The quicker you grasp the reality of the situation the better, Your Grace. I'm announcing the invasion of Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Player_Romus), `[46]` (Player_Romus), `[55]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Axel Reinhart: ""What?""*)

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> ""You must be insane if you think I'll give in to your threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""That's it, then. It's war.""*)
  - -> `[69]` (*Player_Romus: ""Think of your people, Axel. Think of the destruction you..."*)
  - -> `[70]` (*Player_Romus: ""You are right. I am insane. But I thought you were cleve..."*)
  - -> `[71]` (*Player_Romus: ""You still dare insult me? You will pay for this, Duke Re..."*)

### Węzeł `[64]`
Mówca: **Axel Reinhart**
> ""Pales stood against the forces of your father, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Axel Reinhart: ""If you insist on repeating his mistakes, we will stand a..."*)

### Węzeł `[65]`
Mówca: **Axel Reinhart**
> ""If you insist on repeating his mistakes, we will stand against you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""Have a good day, Axel.""*)
  - -> `[73]` (*Player_Romus: ""Remember: I gave you a choice, and you refused. You will..."*)
  - -> `[74]` (*Player_Romus: ""This time it will be very different.""*)
  - -> `[75]` (*Player_Romus: ""I am sorry it had to come to this, Axel. I hope you'll s..."*)

### Węzeł `[66]`
Mówca: **Axel Reinhart**
> ""We can't lead our countries to war. Peace must be maintained by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""If you want peace... Listen to me very carefully.""*)
  - -> `[67]` (*Player_Romus: ""It's too late for that.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too late for that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""You must be insane if you think I'll give in to your thr..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want peace... Listen to me very carefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""You will surrender the Aureus field to Rizia completely.""*)
  - -> `[59]` (*Player_Romus: ""I only want you to swear allegiance to the Rizian crown ..."*)
  - -> `[61]` (*Player_Romus: ""You will surrender all the territories except the city o..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think of your people, Axel. Think of the destruction your people will suffer. Surrender before it's too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Axel Reinhart: ""Pales stood against the forces of your father, Your Maje..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. I am insane. But I thought you were cleverer than that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Axel Reinhart: ""Pales stood against the forces of your father, Your Maje..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You still dare insult me? You will pay for this, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Axel Reinhart: ""Pales stood against the forces of your father, Your Maje..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it, then. It's war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Axel Reinhart: ""Pales stood against the forces of your father, Your Maje..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember: I gave you a choice, and you refused. You will regret it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I hung up."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This time it will be very different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I hung up."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry it had to come to this, Axel. I hope you'll survive the war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I hung up."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have a good day, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I hung up."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "I hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "And just like that, the Second Pales War had begun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War = true; RiziaDLC.Diplomacy_Pales_Negot..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Border_JointInvestigation == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Bord..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Bo..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Border_JointInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Axel Reinhart: ""I'm afraid I don't see it that way, Your Majesty. Especi..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Border_JointInvestigation == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Axel Reinhart: ""The world knows it was Rizia who was behind the incident..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Axel Reinhart: ""So... What did you want to tell me, Your Majesty?""*)

### Węzeł `[85]`
Mówca: **Axel Reinhart**
> ""The world knows it was Rizia who was behind the incident at our border, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Axel Reinhart: ""And yet you decided not to even acknowledge it.""*)

### Węzeł `[86]`
Mówca: **Axel Reinhart**
> ""And yet you decided not to even acknowledge it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""Even after Pales' horrific actions, I am showing you my ..."*)
  - -> `[36]` (*Player_Romus: ""Please listen to me very carefully. This is your last ch..."*)
  - -> `[37]` (*Player_Romus: ""I am giving you a gentlemanly head start by informing yo..."*)
  - -> `[38]` (*Player_Romus: ""I wanted to offer you a way out. Surrender the duchy and..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I placed the phone to my ear. I took a deep breath as the..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "And just like that, the Second Pales War had begun."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I sat in my office, waiting to place the call that would ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower = -100;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_War"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -100;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Threatening their neighouring country over the phone", "Personal Office", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Threatening their neighouring country over the phone","Personal Office","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)
