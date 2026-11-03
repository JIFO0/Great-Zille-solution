# Sordland/Turn11/Personal_Exile

- **ID konwersacji:** `255`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/255_Personal_Exile.md`
- **Liczba węzłów dialogowych:** 392
- **Liczba wyborów gracza:** 58

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[7]** Policeman
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn10_MovePersonalWealth_Move`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Exile_MonicaDeanaWithYou`
- `BaseGame.Exile_PetrWithYou`
- `BaseGame.Exile_WholeFamilyWithYou`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_PresiPower_Strong_GunRights`
- `BaseGame.Relations_Lucian_Enemy`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGameIsolated.Turn07_AcceptedMarcelCar`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `GameCondition.Turn11_P_Exile`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[374]` (Paskal Beniwoll): `Variable["GameCondition.Turn11_P_Exile"] = true;`
- Węzeł `[384]` (Paskal Beniwoll): `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- Węzeł `[385]` (Paskal Beniwoll): `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- Węzeł `[386]` (Paskal Beniwoll): `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- Węzeł `[387]` (Paskal Beniwoll): `PlaySoundEffect("CarSiren");`
- Węzeł `[391]` (Paskal Beniwoll): `End();`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_LeaveNow == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Just one day after deciding to leave the country, I pulled out of the driveway in the Randolfini sports car Marcel had given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_AcceptedMarcelCar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Just one day after deciding to leave the country, I pulled out of the driveway in an unobtrusive-looking station wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Narrator**
> "One week after deciding to leave the country, I pulled out of the driveway in the Randolfini sports car Marcel had given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_AcceptedMarcelCar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "One week after deciding to leave the country, I pulled out of the driveway in an unobtrusive-looking station wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Monica and Deana were with me. We'd all packed just one suitcase. I'd told the guards we were going to visit Monica's parents for the weekend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I only had one suitcase with me. I had told the guards I was going on a short personal trip for the weekend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Narrator**
> "On the way out of Holsord, I picked up Petr from his apartment. He was carrying a suitcase and a heavy-looking duffel bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[25]`
Mówca: **Narrator**
> "On the way out of Holsord, I picked up Franc from university. He was carrying a small backpack and nothing else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""That's all you're bringing?""]** — Mówca: **Player**
> ""That's all you're bringing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Did you say your goodbyes?""]** — Mówca: **Player**
> ""Did you say your goodbyes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Deana**
> ""Papa! I forgot Mr. Bunnybun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[32]`
Mówca: **Franc**
> ""Just to Sheyna. Dad, she can come visit me in Kyrute, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I don't see why not.""]** — Mówca: **Player**
> ""I don't see why not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""We'll talk about that later.""]** — Mówca: **Player**
> ""We'll talk about that later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Franc**
> ""I didn't want to arouse suspicion. There were some older guys lurking around campus who looked like they might've been military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""You're too old for stuffed animals, Deana.""]** — Mówca: **Player**
> ""You're too old for stuffed animals, Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""All right. Let's go back and get him.""]** — Mówca: **Player**
> ""All right. Let's go back and get him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Monica put a hand on my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Monica**
> ""We don't have time, honey. Our ship leaves from Benfi Port in a few hours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "I kept driving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[41]`
Mówca: **Narrator**
> "As I drove out of Holsord, I could see the domed roof of the Maroon Palace looming in the rear-view mirror. I felt bad I hadn't said goodbye to Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[45]`
Mówca: **Narrator**
> "As I drove out of Holsord, I could see the domed roof of the Maroon Palace looming in the rear-view mirror."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Kyrute, here we come! Anton, I hope you're ready to live like a king.""]** — Mówca: **Petr Vectern**
> ""Kyrute, here we come! Anton, I hope you're ready to live like a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[52]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I don't know about living like a king, but at least I'll be able to access my savings.""]** — Mówca: **Player**
> ""I don't know about living like a king, but at least I'll be able to access my savings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Yes, thankfully I managed to get my savings into an international account. It ought to tide us over for a good long while.""]** — Mówca: **Player**
> ""Yes, thankfully I managed to get my savings into an international account. It ought to tide us over for a good long while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""No, I don't want to attract too much attention.""]** — Mówca: **Player**
> ""No, I don't want to attract too much attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Petr unzipped his duffel bag. It was full of cash -- what must have been millions of Sordish Ren. He winked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Just in case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Driving past the graveyard where Serge was buried, I said a silent farewell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[59]`
Mówca: **Narrator**
> "I hadn't said goodbye to Serge either. I hoped he'd be okay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[60]`
Mówca: **Narrator**
> "After an hour or so of silence, Monica switched on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[61]`
Mówca: **Narrator**
> "After about an hour or so of silence, Petr switched on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Narrator**
> "After an hour or so of silence, Franc asked if we could switch on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "After about an hour or so of silence, I switched on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[76]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Monica and Deana Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "The military had taken my family into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[78]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Franc Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Narrator**
> "A boy who looked like my son had been taken into military custody at Holsord State, then released when his identity was confirmed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Franc**
> ""I knew there was something fishy about those guys on campus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[81]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Deana Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[88]`
Mówca: **Narrator**
> "The military had come to Deana's school and taken a girl who looked like her into custody. They released her once her identity was confirmed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Deana**
> ""I guess we left just in time, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Monica gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Monica**
> ""Keep driving, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Shit. I've got to go back.""]** — Mówca: **Player**
> ""Shit. I've got to go back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I can't go back. That's exactly what they want.""]** — Mówca: **Player**
> ""I can't go back. That's exactly what they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Petr shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Petr Vectern**
> ""They're trying to use Monica and Deana as a bargaining chip. They'll let them go once they realize they can't reach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[96]`
Mówca: **Narrator**
> "The car skidded as I violently spun the wheel. We began racing back the way we'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "After a few minutes, I saw flashing lights on the road ahead of us. The military had set up a checkpoint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""Don't do it, Anton. They won't hurt Monica and Deana. But they'll kill you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[102]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Monica and Deana Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "Don't go back for them."]** — Mówca: **Player_Italic**
> "I switched the radio off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Narrator**
> "After a few minutes, I saw flashing lights on the road ahead. The military had set up a checkpoint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Narrator**
> "The military had taken my wife and daughter into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[103]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "Go back for them."]** — Mówca: **Player_Italic**
> "The car skidded as I violently spun the wheel. I began racing back the way I'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[107]`
Mówca: **Narrator**
> "This was just a scare tactic to get to me. The military wouldn't hurt my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I couldn't go back. I had to keep going."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Narrator**
> "I hoped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "I pressed my foot to the gas pedal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[111]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Anton Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[112]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Anton Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Lileas was giving a campaign speech, promising to fix all the mistakes I'd made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Narrator**
> "A political commentator was discussing how my mishandling of the Rumburg crisis would set Sordland back at least a century."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[124]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I'd like to see her try.""]** — Mówca: **Player**
> ""I'd like to see her try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I can't wait to be out of this country.""]** — Mówca: **Player**
> ""I can't wait to get out of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[123]`
Mówca: **Narrator**
> "One of Sordland's most famous musical comedians was warbling a song parody about me entitled "A Hard Rayne's Gonna Fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[125]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""They don't know the full story.""]** — Mówca: **Player**
> ""They don't know the full story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "Turn off the radio."]** — Mówca: **Player_Italic**
> "I turned off the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""Hey, I was enjoying that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "My ship from Benfi was leaving in just two hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[137]`
Mówca: **Petr Vectern**
> ""She won't last a month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Amen to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""You did your best. We all did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Lileas was giving a campaign speech, promising to fix all the mistakes I'd made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[147]`
Mówca: **Narrator**
> "A political commentator was discussing how my mishandling of the Rumburg crisis would set Sordland back at least a century. War didn't break out but thousands of Sordish were displaced from Narbel and Estord after hearing about the atrocities committed by Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[148]`
Mówca: **Monica**
> ""That was tasteless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[149]`
Mówca: **Franc**
> ""Hey, I was enjoying that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""I'd like to see her try.""]** — Mówca: **Player**
> ""I'd like to see her try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I can't wait to be out of this country.""]** — Mówca: **Player**
> ""I can't wait to get out of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""They don't know the full story.""]** — Mówca: **Player**
> ""They don't know the full story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[156]`
Mówca: **Monica**
> ""You'd better drive faster, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[157]`
Mówca: **Narrator**
> "One of Sordland's most famous musical comedians was warbling a song parody about me entitled "A Hard Rayne's Gonna Fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Monica**
> ""She won't last a month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "Turn off the radio."]** — Mówca: **Player_Italic**
> "I turned off the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[160]`
Mówca: **Monica**
> ""You did your best. We all did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[164]`
Mówca: **Narrator**
> "After what seemed like forever, I passed the Benfi city limits sign. The port was in sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Suddenly, I heard a siren blaring from behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "Speed up."]** — Mówca: **Player_Italic**
> "I floored it, only to see that the road ahead of me was blocked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "Pull over."]** — Mówca: **Player_Italic**
> "With a reluctant sigh, I pulled the car over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[168]`
Mówca: **Narrator**
> "With a reluctant sigh, I pulled the car over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[169]`
Mówca: **Policeman**
> ""Sorry, sir, just a routine checkpoint-- Wait a minute, are you...?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[174]`
  - -> `[178]`
  - -> `[179]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Whoever you think I am, I've got a wad of cash that says otherwise.""]** — Mówca: **Player**
> ""Whoever you think I am, I've got a wad of cash that says otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WYBÓR GRACZA: ""Whoever you think I am, my friend here has a wad of cash that says otherwise.""]** — Mówca: **Player**
> ""Whoever you think I am, my friend here has a wad of cash that says otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Whoever you think I am, I've got a gun here that says otherwise.""]** — Mówca: **Player**
> ""Whoever you think I am, I've got a gun here that says otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""Uh... yes, that's right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Petr reached into his duffel bag and pulled out a handful of bills. The policeman looked uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[182]`
Mówca: **Narrator**
> "A policeman tapped on the window. I rolled it down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[183]`
Mówca: **Policeman**
> ""I'm going to need to see your identification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Monica turned pale. I could see Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Monica turned pale. I could see Franc and Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Petr looked at me incredulously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "Hand him your passport."]** — Mówca: **Player_Italic**
> "I handed him my passport."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I didn't move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Petr Vectern**
> ""Listen, sir, this is all a misunderstanding. Please allow me to help clear it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true  or  Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true  or  Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Monica**
> ""Anton, for God's sake...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[206]`
Mówca: **Policeman**
> ""Please step out of the vehicle, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[207]`
Mówca: **Narrator**
> "After a few agonizing moments, he quickly snatched the money and stuffed it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Policeman**
> ""Forgive me, I obviously mistook you for someone else. You may proceed to your destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[209]`
Mówca: **Narrator**
> "The policeman took a few steps back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Policeman**
> ""Forgive me, I obviously mistook you for someone else. You may proceed to your destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[211]`
Mówca: **Narrator**
> "I grabbed a handful of bills from my suit pocket and waved them in the policeman's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Narrator**
> "Monica turned pale. I could see Franc and Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
Mówca: **Narrator**
> "Monica turned pale. I could see Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Petr looked at me incredulously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Narrator**
> "The policeman seemed uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[225]`
Mówca: **Policeman**
> ""Monica Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Policeman**
> ""Listen, I'm not supposed to let anyone through here. But my wife-- she absolutely loves you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[227]`
Mówca: **Narrator**
> "I slowly began to open the car door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Policeman**
> ""I was right! You're Anton Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Policeman**
> ""Listen, I'm not supposed to let anyone through here. But I voted for you back in '53. I still think you're a great man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
**[WYBÓR GRACZA: ""That makes one of us.""]** — Mówca: **Player**
> ""That makes one of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Thanks. That means a lot.""]** — Mówca: **Player**
> ""Thanks. That means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Monica looked startled. It took her a few seconds to reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Monica**
> ""I'm happy to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Policeman**
> ""You keep fighting the good fight, Mrs. First Lady. And you folks enjoy... wherever it is you're off to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[235]`
Mówca: **Narrator**
> "I began reaching towards the car's glove compartment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[236]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[237]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and drove off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""So much for fighting corruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[248]`
Mówca: **Deana**
> ""Papa. That was illegal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[269]`

### Węzeł `[249]`
Mówca: **Narrator**
> "So the police were still corrupt. I hadn't even managed to change that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Petr Vectern**
> ""That was a close one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[259]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and drove off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Franc**
> ""Whoa. Nice job, Mom!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Deana**
> ""That was amazing, Mama!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Monica**
> ""We got lucky, Let's just hope he doesn't have friends waiting at the port.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""It was a special circumstance.""]** — Mówca: **Player**
> ""It was a special circumstance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[267]`
**[WYBÓR GRACZA: ""Thanks, Mr. Moneybags.""]** — Mówca: **Player**
> ""Thanks, Mr. Moneybags.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[268]`
**[WYBÓR GRACZA: ""Let's just hope he doesn't have friends waiting at the port.""]** — Mówca: **Player**
> ""Let's just hope he doesn't have friends waiting at the port.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""I broke the law for you, sweetheart.""]** — Mówca: **Player**
> ""I broke the law for you, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Monica looked chagrined, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[271]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[273]`
Mówca: **Narrator**
> "I could see Monica trying hard to suppress a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[275]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and drove off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[287]`
Mówca: **Petr Vectern**
> ""Since when do you have a gun?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[288]`
Mówca: **Narrator**
> "I opened the glove compartment to reveal a shiny revolver."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[289]`

### Węzeł `[289]`
**[WYBÓR GRACZA: ""Family heirloom.""]** — Mówca: **Player**
> ""Family heirloom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[290]`
**[WYBÓR GRACZA: ""I got it when I changed the gun ownership laws.""]** — Mówca: **Player**
> ""I got it when I changed the gun ownership laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_GunRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_GunRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_GunRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[294]`
Mówca: **Deana**
> ""Papa? You have a gun?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_GunRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_GunRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_GunRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Narrator**
> "I inwardly thanked myself for changing Sordland's gun ownership laws."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[299]`
Mówca: **Narrator**
> "He'd bought my lie. Maybe I still had some power left in me as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[300]`
Mówca: **Narrator**
> "I opened the glove compartment to reveal the car's manual and a few candy wrappers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
**[WYBÓR GRACZA: ""I guess my word as President still means something.""]** — Mówca: **Player**
> ""I guess my word as President still means something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[302]`
**[WYBÓR GRACZA: ""We just got extremely lucky.""]** — Mówca: **Player**
> ""We just got extremely lucky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[303]`
Mówca: **Franc**
> ""Pretty gutsy, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[307]`
Mówca: **Narrator**
> "At last, there it was: the Port of Benfi. The ship to Kyrute was already docked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[308]`
Mówca: **Franc**
> ""Can I have one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Monica**
> ""No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Monica**
> ""You're getting rid of that in Kyrute, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[314]`
Mówca: **Monica**
> ""That could've gone very badly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Narrator**
> "Monica turned to look out the window. She said nothing for the rest of the ride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[319]`
Mówca: **Petr Vectern**
> ""Why, Anton. You're just full of surprises today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[323]`
Mówca: **Petr Vectern**
> ""Pretty gutsy, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[324]`
Mówca: **Narrator**
> "Petr and I grabbed our belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[334]`
Mówca: **Narrator**
> "Monica, Franc, Deana and I grabbed our belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
Mówca: **Narrator**
> "Monica, Deana and I grabbed our belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[336]`
Mówca: **Narrator**
> "I grabbed my belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Narrator**
> "After looking it over very closely, he let me on board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[338]`
Mówca: **Narrator**
> "After looking them over very closely, he let us on board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
**[WYBÓR GRACZA: "Go to the back of the ship."]** — Mówca: **Player_Italic**
> "I made my way to the back of the ship."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
**[WYBÓR GRACZA: "Go to the front of the ship."]** — Mówca: **Player_Italic**
> "I made my way to the front of the ship. A strong sea breeze was blowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_PetrWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Exile_MonicaDeanaWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[350]`
Mówca: **Narrator**
> "Petr and I stood there as we left harbor, watching Sordland recede into the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[351]`
Mówca: **Narrator**
> "My family and I stood there as we left harbor, watching Sordland recede into the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`

### Węzeł `[352]`
Mówca: **Narrator**
> "I stood there as we left harbor, watching my home country recede into the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`
  - -> `[358]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""A Morgna wes core.""]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[354]`
**[WYBÓR GRACZA: ""We'll be back someday.""]** — Mówca: **Player**
> ""We'll be back someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[355]`
**[WYBÓR GRACZA: ""Goodbye, Sordland.""]** — Mówca: **Player**
> ""Goodbye, Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[356]`
**[WYBÓR GRACZA: ""A Morgna wes core.""]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""I'll be back someday.""]** — Mówca: **Player**
> ""I'll be back someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Goodbye, Sordland.""]** — Mówca: **Player**
> ""Goodbye, Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Narrator**
> "My words floated out over the water, unanswered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""A Morgna wes core.""]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""We'll be back someday.""]** — Mówca: **Player**
> ""We'll be back someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[362]`
**[WYBÓR GRACZA: ""I hope Monica and the kids will be all right.""]** — Mówca: **Player**
> ""I hope Monica and the kids will be all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
Mówca: **Petr Vectern**
> ""Vectern sis da, baby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[364]`
Mówca: **Petr Vectern**
> ""I'm sure we will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[365]`
Mówca: **Petr Vectern**
> ""I'm sure they will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[366]`
Mówca: **Monica**
> ""Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Monica**
> ""What kind of country will it be by then, though?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Narrator**
> "Monica and I looked at each other. My wife had tears in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Petr Vectern**
> ""Come on, let's go to the front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[370]`
Mówca: **Monica**
> ""Let's go to the front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Narrator**
> "I walked to the ship's bow. A strong sea breeze was blowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Narrator**
> "We walked to the ship's bow. A strong sea breeze was blowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Narrator**
> "An impossibly wide expanse of water stretched out before me. I closed my eyes, listening to the roar of the waves and the cries of seagulls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_P_Exile = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn11_P_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn10_MovePersonalWealth_Move == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Shit. All my savings are still tied up in Sordland. We'll have to start from scratch.""]** — Mówca: **Player**
> ""Shit. All my savings are still tied up in Sordland. We'll have to start from scratch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[379]`
Mówca: **Narrator**
> "He took a brief look at my passport."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_GunRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_GunRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_GunRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[383]`
Mówca: **Narrator**
> "I touched the gun I brought with me. The cold steel gave me confidence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CarSiren");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CarSiren");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[388]`
Mówca: **Policeman**
> ""Good luck on the path, Mr. Rayne. I didn't see anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Narrator**
> "He smiled. Then went back to his car and drove off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[390]`
Mówca: **Narrator**
> "I had a hard time suppressing a smile as I drove off towards the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
