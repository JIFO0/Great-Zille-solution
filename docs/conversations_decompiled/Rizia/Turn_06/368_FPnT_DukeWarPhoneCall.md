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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 7

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[48]` (Paskal Beniwoll): `--;`
- Węzeł `[87]` (Paskal Beniwoll): `AddConversant("Axel Reinhart");`
- Węzeł `[88]` (Paskal Beniwoll): `RemoveConversant("Axel Reinhart");`
- Węzeł `[89]` (Paskal Beniwoll): `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- Węzeł `[90]` (Paskal Beniwoll): `Variable["RiziaDLC.Pales_War"] = true; Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -1...`
- Węzeł `[91]` (Paskal Beniwoll): `End();`
- Węzeł `[92]` (Paskal Beniwoll): `SetRichPresence("Threatening their neighouring country over the phone","Personal Office","Porte D...`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I sat in my office, waiting to place the call that would change the future of Rizia and Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I placed the phone to my ear. I took a deep breath as the Palesian palace operators connected me to Duke Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Axel Reinhart**
> ""Oh... Your Majesty. I've been waiting to hear from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart. What a pleasure it is to have the chance to speak with you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the King speaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hello, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's King Romus Toras. The Ruler of Rizia Imperii, and Valenqiris, and of Brenas and Iza; of Cardesse and Montaklar, and the ancient lands of the Rezenids, Descendant of the Most Honorable Queen Lyza and King Valero, and the Sovereign of the Kingdom of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[16]`
Mówca: **Axel Reinhart**
> ""I didn't expect to have a dialogue with you after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[17]`
Mówca: **Axel Reinhart**
> ""I'm afraid I don't see it that way, Your Majesty. Especially after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[18]`
Mówca: **Axel Reinhart**
> ""Am I supposed to be impressed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. You should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is just part of the protocol, as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... It doesn't really matter, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Me too, Your Grace. And now, you're going to hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Because I wanted to talk to you about something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid I'm not bringing good news, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given the circumstances, I never thought I would be giving you a personal phone call. But here we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Me neither. So listen carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... I'm not bringing good news, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""I wasn't expecting anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[29]`
Mówca: **Axel Reinhart**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[30]`
Mówca: **Axel Reinhart**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Axel Reinhart**
> ""So... What did you want to tell me, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even after Pales' horrific actions, I am showing you my respect by opening communications. Let that be clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please listen to me very carefully. This is your last chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am giving you a gentlemanly head start by informing you of my decision to invade Pales, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to offer you a way out. Surrender the duchy and swear fealty to the Rizian crown, so we can be stronger together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Axel Reinhart**
> ""Hah... You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Axel Reinhart**
> ""No... You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are no jokes, Your Grace. Pales has become a rogue nation with you at its head. Rizia will militarily intervene -- if you don't comply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The quicker you grasp the reality of the situation the better, Your Grace. I'm announcing the invasion of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I am. So listen to me very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "He went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[54]`
  - -> `[50]`
  - -> `[46]`
  - -> `[57]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not a joke, Your Grace. Pales has become a rogue nation with you at its head. Rizia will militarily intervene -- if you don't comply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[61]`
  - -> `[62]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure I don't need to remind you of how much stronger the Rizian Armed Forces are compared to Pales' armies...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure I don't need to remind you of how much larger Rizia is than Pales...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am aware of your intentions to let the western powers settle in our region in exchange for your own security. I will not allow that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Axel Reinhart**
> ""What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[56]`
Mówca: **Axel Reinhart**
> ""And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm offering a peaceful way out from your dire situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot allow you to become a threat to our energy industry. You must understand my situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only want you to swear allegiance to the Rizian crown and reunite Pales with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will surrender the Aureus field to Rizia completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will surrender all the territories except the city of Pales to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The quicker you grasp the reality of the situation the better, Your Grace. I'm announcing the invasion of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> ""You must be insane if you think I'll give in to your threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[69]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[64]`
Mówca: **Axel Reinhart**
> ""Pales stood against the forces of your father, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Axel Reinhart**
> ""If you insist on repeating his mistakes, we will stand against you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[66]`
Mówca: **Axel Reinhart**
> ""We can't lead our countries to war. Peace must be maintained by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[67]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want peace... Listen to me very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[61]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think of your people, Axel. Think of the destruction your people will suffer. Surrender before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. I am insane. But I thought you were cleverer than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You still dare insult me? You will pay for this, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it, then. It's war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember: I gave you a choice, and you refused. You will regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This time it will be very different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry it had to come to this, Axel. I hope you'll survive the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have a good day, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "I hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[78]`
Mówca: **Narrator**
> "And just like that, the Second Pales War had begun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Border_JointInvestigation == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Border_JointInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Pales_War == true && RiziaDLC.PostIncident_Border_JointInvestigation == true)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[85]`
Mówca: **Axel Reinhart**
> ""The world knows it was Rizia who was behind the incident at our border, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Axel Reinhart**
> ""And yet you decided not to even acknowledge it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower = -100;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_War"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -100;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Threatening their neighouring country over the phone", "Personal Office", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Threatening their neighouring country over the phone","Personal Office","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
