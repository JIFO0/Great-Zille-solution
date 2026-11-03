# Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Revolution Fail Branch/Revolution Fail Branch Conversation

- **ID konwersacji:** `569`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/569_Revolution_Fail_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 218
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.BirthdayGathering_Invited_Adarfo`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Boxing_Injury_Revealed`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus`
- `RiziaDLCIsolated.Birthday_Gathering_Praise_Exit`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Epilogue_Prison_HugoSendsToPrison`
- `RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus`
- `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch`
- `RiziaDLCIsolated.Birthday_Gathering_Praise_Exit`
- `RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail`
- `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike_Failed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_None`
- `RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[567] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation** (../Turn_10/567_Run_Romus_Run!_Conversation.md), Węzeł `[1]`
- Węzeł `[80]` -> **[567] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation** (../Turn_10/567_Run_Romus_Run!_Conversation.md), Węzeł `[373]`
- Węzeł `[213]` -> **[566] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation** (../Turn_10/566_HOUSE_STRIKE_FAIL_Conversation.md), Węzeł `[11]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 17

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[24]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] = true;`
- Węzeł `[44]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] = true;`
- Węzeł `[45]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] = true;`
- Węzeł `[68]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] = true;`
- Węzeł `[90]` (Paskal Beniwoll): `RemoveConversant("Adarfo Sotelato"); ;`
- Węzeł `[105]` (Paskal Beniwoll): `AddConversant("Adarfo Sotelato"); ;`
- Węzeł `[153]` (Paskal Beniwoll): `--;`
- Węzeł `[154]` (Paskal Beniwoll): `--;`
- *...oraz 9 innych węzłów ze skryptami.*

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `567` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The heavy double doors crashed open, and a group of armed men rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I quickly took cover. Everything happened so fast, it was difficult to discern what was going on, but I was sure Adarfo's men had the upper hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Instead of being overwhelmed, they unleashed a hail of bullets on the attackers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[6]`
Mówca: **Titus Gordion**
> ""Defensive protocol -- engage! Protect priority targets!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Narrator**
> "One of the guardians fell in the initial clash, but the others responded with unrelenting efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "In a matter of seconds, two of the attackers dropped to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[9]`
Mówca: **Narrator**
> "As the assailants began to fall back into the main hall, it became clear that the uprising was faltering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[10]`
Mówca: **Titus Gordion**
> ""Now's our chance! Close ranks and move forward! Nobody leaves the library.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Titus Gordion**
> ""Stay where you are, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[12]`
Mówca: **Narrator**
> "In rapid succession, two more attackers fell to Titus's marksmanship."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Titus motioned for his men to push ahead into the next room, but he stayed behind, keeping a watchful eye on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "He squeezed the trigger with lightning speed, dropping the would-be shooter before a single shot could be fired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Time was running out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[16]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Escape."]** — Mówca: **Player_Romus_Italic**
> "So I embraced the only option I had left... escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Remain where you are."]** — Mówca: **Player_Romus_Italic**
> "Realizing there was no escape, I remained where I was. I would have to confront whatever I had coming head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[18]`
Mówca: **Titus Gordion**
> ""Your pathetic attempt to use violence to force reform has been crushed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Titus Gordion**
> ""Your pathetic little rebellion has ended in failure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Titus Gordion**
> ""Lucky for us, we caught wind of it just in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[25]`
Mówca: **Titus Gordion**
> ""If you think everyone’s as corruptible as you... think again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[26]`
Mówca: **Narrator**
> "The pain was blinding, and my vision blurred as consciousness slipped in and out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[27]`
Mówca: **Narrator**
> "The Golden Guard seized me by the arms and dragged me into the adjoining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Name your price, Titus. Whatever you want -- money, power -- it’s yours. Just let me go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[32]`
Mówca: **Narrator**
> "I didn't have to wait long. A spray of bullets hit the ground near Titus’s feet, sending him diving for cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Use the element of surprise and make a run for it immediately."]** — Mówca: **Player_Romus_Italic**
> "It was now or never. I bolted past Titus towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[34]`
Mówca: **Narrator**
> "That was when I seized the opportunity and bolted for the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Just as I reached the main hall, a gunshot cracked from behind. A sharp pain tore through my left side, and I crumpled to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[36]`
Mówca: **Narrator**
> "I looked down, blood pooling around my hand as I clutched the wound. Somehow, I knew it was Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[37]`
Mówca: **Narrator**
> "I couldn't tell how much time had passed before the gunfire faded into silence. When my eyes focused again, Titus was standing over me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Checkmate_Titus_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations, Titus. You passed the test. Now, if you'll excuse me... I'll be going now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Titus Gordion**
> ""Take one more step, and I will restrain you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Praise_Exit = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Minutes seemed like hours, and before long, the gunfire subsided. Captain Castellanus approached Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[47]`
Mówca: **Titus Gordion**
> ""Guards, take him away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? You believe I'd cooperate with these thugs?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By what right do you dare to arrest me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Titus Gordion**
> ""Right is defined by the oath I swore -- to defend the Crown's true purpose, not the whims of a single monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[51]`
Mówca: **Titus Gordion**
> ""By the authority vested in me, I hereby declare King Romus is to be taken into custody for treason against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[49]`
  - -> `[48]`
  - -> `[210]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Titus, seemingly always a step ahead, reacted with calculated ferocity. As one man leveled a gun at Hugo, Titus' hand was already moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[56]`
Mówca: **Narrator**
> "They were being led by Adarfo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Minutes seemed like hours, and before long, the gunfire subsided. Titus turned to me after receiving the "all clear" from his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Strike Titus' boxing injury."]** — Mówca: **Player_Romus_Italic**
> "Going for his boxing injury was the obvious solution, but he was too far away to strike."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Boxing_Injury_Revealed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Boxing_Injury_Revealed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Boxing_Injury_Revealed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Narrator**
> "I didn't have to wait long. A spray of bullets hit the ground near Titus’s feet, sending him running in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Narrator**
> "My hand brushed against a bronze plaque that had fallen from its mount."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "I grabbed it without hesitation and slammed it into Titus’s side, aiming for his kidney."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "He grunted in pain, clutching his side as he doubling over as the blow landed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Titus Gordion**
> ""Coward!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I didn't wait for him to recover. I scrambled to my feet and bolted for the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Narrator**
> "Several Wruhec's Guardians seized me by the arms and dragged me into the adjoining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Narrator**
> "As I was escorted toward the exit, I saw Vina and Mother watching from a distance with shock written across their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Narrator**
> "As I was escorted toward the exit, I saw Mother watching from a distance with shock written across her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see them again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[79]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Vault_Caught_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `567` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation*), Węzeł `[373]`

### Węzeł `[81]`
Mówca: **Narrator**
> "I found a chair and sank into it, exhausted, as the muffled clamor of the uprising continued outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Boxing_Injury_Revealed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Boxing_Injury_Revealed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Boxing_Injury_Revealed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[88]`
Mówca: **Narrator**
> "He turned back to his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Hugo found his way to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Having Titus nearby would prove difficult, but not impossible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Adarfo was nowhere to be seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Especially since I knew his weak spot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Adarfo proudly stood, raising his arms high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Narrator**
> "But to my dismay, I soon came to realize that the Golden Guard was far from the vulnerable targets I had anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[96]`
Mówca: **Adarfo Sotelato**
> ""Your time is over, parasites!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Adarfo and his revolutionaries flooded in like an unstoppable tide, and the room erupted in gunfire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[101]`
Mówca: **Narrator**
> "One guardsman fell in the initial clash, but the others responded with unrelenting efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "As his revolutionaries flooded in like an unstoppable tide, Adarfo joined the fray, and the room erupted in gunfire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[110]`
Mówca: **Narrator**
> "But to my dismay, I soon came to realize that the Wruhec's Guardians were far from the vulnerable targets I had anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[111]`
Mówca: **Adarfo Sotelato**
> ""For the people!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Checkmate_Titus_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[69]`
  - -> `[33]`
  - -> `[202]`
  - -> `[59]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[116]`
Mówca: **Lucita Azaro**
> ""Romus... tell me you didn't have anything to do with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[127]`
  - -> `[123]`
  - -> `[119]`
  - -> `[198]`

### Węzeł `[117]`
Mówca: **Narrator**
> "Lucita found her way to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no time for this. I have to make sure my mother and Vina are safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know what you are talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quiet, woman! I don't need your meddling right now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but believe me when I say that I was doing what was best for the country -- for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""What the hell... Do you have any idea what you've done?! You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""How dare you speak to me with such disrespect! Answer me now! Were you or were you not involved?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m sorry. I made a mistake. I never meant for it to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""What?! Do you have any idea what you've done? You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""You're lying! I can see it in your eyes! Your delusions have ruined our child's life...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""Your mother?! What about our child? Admit it, Romus, you've ruined everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, knowing full well there wasn't anything I could say to undo what had already transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ruined? We've been heading down this path for a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll speak to you any way I damn well please! I don't have to explain myself to you or anyone else!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I wasn’t! And I won’t stand here and be accused of such treachery!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright! I admit it! I was behind it from the start! I wanted to tear down the monarchy brick by brick! There. Is that what you wanted to hear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[136]`
Mówca: **Narrator**
> "My eyes met Lucita’s, her expression filled with scorn and hatred."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. We'll find a way out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I said I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""'Sorry' isn't going to cut it. What you've done is unforgivable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""You’re naive if you think there’s any way out of this now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[142]`
Mówca: **Lucita Azaro**
> ""If we’ve been heading down this path, it’s because you refused to see the signs along the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[143]`
Mówca: **Narrator**
> "I turned away, my gaze falling on Hugo. His expression mirrored Lucita’s, filled with contempt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""Your Majesty... tell me you didn't have anything to do with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[127]`
  - -> `[119]`
  - -> `[198]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""You yourself compromised their safety, didn't you? My God, Romus... You've ruined everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""I wish I could believe you didn't wish to bring ruin on this kingdom, Romus. I really do...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[137]`
  - -> `[132]`
  - -> `[131]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[137]`
  - -> `[132]`
  - -> `[131]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""So it is true! Dear God, Romus... Do you have any idea what you've done? You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[137]`
  - -> `[132]`
  - -> `[131]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Hugo Toras**
> ""Then it's true? Dear God, Romus... Do you have any idea what you've done? You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[137]`
  - -> `[132]`
  - -> `[131]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but believe me when I say that I was doing what was best for the country -- for the family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold your tongue, old man! I don't need your meddling right now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""'Old man?' How dare you speak to me with such disrespect! Answer me now! Were you or were you not involved in this upheaval?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""Apologies are meaningless. What you've done is unforgivable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Hugo Toras**
> ""You're a fool if you think there's any way out of this now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""If we've been heading down this path, it's because you chose to ignore the signs along the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Narrator**
> "My eyes met Hugo's, his expression filled with contempt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[187]`
Mówca: **Narrator**
> "From the corner of my eye, I saw Lucita and motioned for her to follow. But seeing the guards around her, I realized she was trapped. I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[191]`
Mówca: **Narrator**
> "From the corner of my eye, I saw Lucita and motioned for her to follow. But seeing the guards around her, I realized she couldn't so I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[192]`
Mówca: **Narrator**
> "Titus turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[193]`
Mówca: **Sevrio Castellanus**
> ""All clear, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `AddConversant("Sevrio Castellanus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike_Failed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_None = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested = true;
RiziaDLC.Epilogue_Prison_HugoSendsToPrison = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested"] = true;
Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no time for this. I have to make sure my mother and the others are safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[202]`
**[WYBÓR GRACZA: "Wait for the right moment, then run."]** — Mówca: **Player_Romus_Italic**
> "I decided to wait until Titus was distracted, then make a run for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[203]`
**[WYBÓR GRACZA: "Rush at him."]** — Mówca: **Player_Romus_Italic**
> "It was now or never. I grabbed a bronze plaque that had fallen from its mount and rushed at Titus, aiming for his kidney."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "Wait for him to come closer."]** — Mówca: **Player_Romus_Italic**
> "I decided to wait until he came closer to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[205]`
Mówca: **Narrator**
> "He twisted away. The plaque connected with a spot on his side just above my intended target."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "He coughed and took a few steps backwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Titus Gordion**
> ""Coward!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "I didn't wait for him to recover. I scrambled to my feet and bolted for the main atrium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I consent. Just don't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fool. Adarfo was right. The Crown will crumble into insignificance, and the people will take power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""Adarfo is dead. And the monarchy will live forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""Your family had nothing to do with this scheme. They will live.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [END OF STRIKE FAIL])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `566` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation*), Węzeł `[11]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[215]`
Mówca: **Titus Gordion**
> ""SUPPRESSIVE FIRE!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MachineGun");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MachineGun");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Getting shot at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Getting shot at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
