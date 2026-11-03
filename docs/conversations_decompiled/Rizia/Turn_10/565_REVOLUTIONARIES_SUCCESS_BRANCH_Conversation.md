# Rizia/Turn 10/STRIKE SCENE/REVOLUTIONARIES SUCCESS BRANCH/REVOLUTIONARIES SUCCESS BRANCH Conversation

- **ID konwersacji:** `565`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/565_REVOLUTIONARIES_SUCCESS_BRANCH_Conversation.md`
- **Liczba węzłów dialogowych:** 402
- **Liczba wyborów gracza:** 72

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[86]** Daria de Rava
- **[89]** Russello Montoro
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.BirthdayGathering_Invited_Adarfo`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_Invited_Rusty`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo`
- `RiziaDLCIsolated.Birthday_Gathering_King_Resists`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Epilogue_Death_AdarfoShoots`
- `RiziaDLC.Epilogue_Revolution_Birthday`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.SkipToEnding`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo`
- `RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo`
- `RiziaDLCIsolated.Birthday_Gathering_King_Resists`
- `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Lucita_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibrary`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Taddeus_Executed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[193]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 27

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[34]` (Paskal Beniwoll): `RemoveConversant("Taddeus Azaro"); ;`
- Węzeł `[57]` (Paskal Beniwoll): `RemoveConversant("Lucita Azaro"); ;`
- Węzeł `[77]` (Paskal Beniwoll): `Variable["RiziaDLC.Lucita_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Ad...`
- Węzeł `[78]` (Paskal Beniwoll): `Variable["RiziaDLC.Taddeus_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_A...`
- Węzeł `[115]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthda...`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthda...`
- Węzeł `[152]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo"] = true;`
- Węzeł `[202]` (Paskal Beniwoll): `--;`
- *...oraz 19 innych węzłów ze skryptami.*

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
  - -> `[248]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `555` (*Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation*), Węzeł `[193]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The guards, unprepared for the ambush, were overwhelmed. Shots rang out, and two of them crumpled to the floor, dead before they could react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[4]`
Mówca: **Narrator**
> "One man leveled his gun at Hugo, but Titus drew his weapon and shot him dead before the assailant could pull the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He was dragged down, his arms pinned and tied behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Titus took down two more attackers, just as a man with a knife charged at him from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Grunting with pain, he grappled with the assailant, throwing him to the ground and locking his hands around the man's throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "As the man’s gasps faded, the doors burst open. A mob of revolutionaries, weapons raised, flooded the room, swarming Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The doors burst open and Adarfo Sotelato stepped inside. He dipped his head in a mock bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Adarfo Sotelato**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[11]`
Mówca: **Narrator**
> "It was at that moment a mob of revolutionaries, weapons raised, flooded the room, swarming Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! Behind you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "I watched as the knife plunged into his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[15]`
Mówca: **Narrator**
> "He turned and immediately shot the man dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Taddeus wheeled himself forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Confusion momentarily flickered across Taddeus’s face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[21]`
Mówca: **Adarfo Sotelato**
> ""I'm so glad you asked. Let it be known that every one of you is being placed under arrest for treason against the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Adarfo Sotelato**
> ""For too long, you've fed off the less fortunate, broken their backs so you could indulge in your lavish lifestyles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Adarfo Sotelato**
> ""This kingdom is crumbling under the strain of your greed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[24]`
Mówca: **Adarfo Sotelato**
> ""Enough! Hands. Let me see your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Adarfo walked up to Angelica and roughly examined her palms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[26]`
Mówca: **Taddeus Azaro**
> ""Your so-called movement will be crushed! This little uprising will be nothing more than a stain in the history books!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""House Azaro will never submit --especially to someone who hasn't a single drop of blue blood in their veins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Adarfo Sotelato**
> ""Nobles… So obsessed with your bloodlines. Tell me, General -- do royals really bleed blue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[29]`
Mówca: **Narrator**
> "The room erupted in screams as Taddeus slumped in his chair. Adarfo pointed to the blood trickling to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Adarfo Sotelato**
> ""See? The color red… just like the rest of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""You… BASTARD!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Her hand moved to her side. She pulled out her hidden dagger and drew her arm back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Adarfo reacted instantly. Another shot rang out as the knife flew past him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Lucita's scream pierced the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Clutching her stomach, Lucita fell to her knees and collapsed onto the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[37]`
Mówca: **Adarfo Sotelato**
> ""Soft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Narrator**
> "He turned to Rico and grabbed his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Adarfo Sotelato**
> ""Uncalloused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Adarfo sauntered back and stood on top of a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Adarfo Sotelato**
> ""This nation belongs in the hands of the people. The age of kings is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't act so surprised. You've had this coming for a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[81]`
  - -> `[86]`
  - -> `[52]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[50]`
  - -> `[90]`
  - -> `[45]`
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This wasn't part of the deal. The new constitution specifically says the monarch will remain in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not just kings who have ended, but loyalty and honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, it's not as bad as it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trusted you to lead change, not to usurp the throne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[53]`
Mówca: **Adarfo Sotelato**
> ""The only recognized constitution in Rizia shall be the one the people write themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[62]`
  - -> `[356]`
  - -> `[72]`
  - -> `[330]`
  - -> `[75]`
  - -> `[76]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could you?! She was carrying my child!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Adarfo Sotelato**
> ""I am sorry. But she brought this upon herself the moment she drew her weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WAKE UP, LUCITA!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, just held her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""SOMEBODY CALL A DOCTOR!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""All right, Mr. Sotelato! We submit! Please, don’t harm anybody else!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Adarfo Sotelato**
> ""I don't need your submission. I need you out of the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Adarfo's men restrained every individual in the room with brutal efficiency. Looks of betrayal and hatred burned into me as they were dragged out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[69]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry about that. But she brought this upon herself the moment she drew her weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I ran to Lucita and took her body in my arms. The light was rapidly draining from her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[62]`
  - -> `[58]`
  - -> `[356]`
  - -> `[61]`

### Węzeł `[71]`
Mówca: **Adarfo Sotelato**
> ""She's dead, Romus. She brought this upon herself the moment she drew her weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT THE HELL ARE YOU DOING?! You weren't supposed to kill anyone!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was that completely necessary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Adarfo Sotelato**
> ""They made their choice the moment they stood in my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They had it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing as Adarfo's men dragged her body aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Lucita_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Lucita_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Taddeus_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Taddeus_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[79]`
Mówca: **Adarfo Sotelato**
> ""Yes. Stand in the way of the revolution, and you will face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[80]`
Mówca: **Adarfo Sotelato**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So this was your plan all along. I should have seen it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Adarfo Sotelato**
> ""Come now, did you truly believe the movement would allow you to remain in power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[83]`
Mówca: **Adarfo Sotelato**
> ""Yes, you should have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God will judge us both, Adarfo. But mark my words... He will not look kindly on treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Adarfo Sotelato**
> ""If your God truly saw you fit for the throne, perhaps He would have stopped you from falling off it so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ha! You should see your faces!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Taddeus Azaro**
> ""You should be ashamed of yourself! The end of the monarchy is no laughing matter!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[96]`
Mówca: **Taddeus Azaro**
> ""Here I thought you were a king. You're nothing more than a court jester!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "He turned to Adarfo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Taddeus Azaro**
> ""As for you... Your movement will be crushed! This little uprising will be nothing more than a stain in the history books!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Taddeus Azaro**
> ""'Had this coming?' You should be ashamed of yourself, Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Taddeus wheeled himself toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Taddeus Azaro**
> ""'Not as bad as it seems?' How dare you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""I bled for you! I stood by you when others wouldn't. And for what? A knife in the back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[104]`
Mówca: **Adarfo Sotelato**
> ""You're hardly any better, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[105]`
Mówca: **Adarfo Sotelato**
> ""None of you are innocent. Don't you understand that yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry, but I'm afraid your commands have no authority here. In any case, I believe I've made my point quite clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Vina pulled away as Adarfo loosened his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Vina looked at me, bewildered by my lack of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[109]`
Mówca: **Adarfo Sotelato**
> ""But she does know what real work is, Your Majesty. Unlike yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Adarfo Sotelato**
> ""None of you are innocent. Don't you understand that yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry, but I'm afraid that your commands have no authority here. In any case, I believe I've made my point quite clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Mother pulled away as Adarfo loosened his grip. He smirked at me as if this whole act was a test."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Mother looked at me, bewildered by my lack of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Mother pulled away as Adarfo loosened his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Vina pulled away as Adarfo loosened his grip. He smirked at me as if this whole act was a test."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[118]`
Mówca: **Adarfo Sotelato**
> ""Let Mr. Toras go. I have something I want to show him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "They reluctantly loosened their grip. Adarfo gestured for me to follow him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "Follow Adarfo."]** — Mówca: **Player_Romus_Italic**
> "Left without a choice, I followed Adarfo up the spiral staircase in the back of the hall leading to the second leave. His men weren't far behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Stay where you are."]** — Mówca: **Player_Romus_Italic**
> "I didn't budge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going anywhere with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I respectfully decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't take orders from you, nor will I ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Adarfo Sotelato**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "With the others gone, the noise from outside became unmistakable -- distant cheers and crackle of fireworks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Adarfo Sotelato**
> ""Do you hear that? That’s the sound of liberation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Adarfo Sotelato**
> ""And it's all thanks to you. None of this would've been possible without your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[165]`
  - -> `[129]`
  - -> `[173]`
  - -> `[135]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You mock me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Adarfo Sotelato**
> ""Not at all. You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[131]`
Mówca: **Adarfo Sotelato**
> ""The king who fought and died to give his people a brighter future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[134]`
  - -> `[132]`
  - -> `[154]`
  - -> `[155]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. It wouldn't have... best you remember that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're expecting gratitude, you won't find it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me if I'm not in a celebratory mood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let freedom ring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[137]`
Mówca: **Adarfo Sotelato**
> ""Your sacrifice will be remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[141]`
  - -> `[144]`
  - -> `[140]`
  - -> `[138]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did this for the Rizian people. You had better not let them down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're expecting gratitude, you won't find it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sacrifice? Do you intend to kill me too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've done my part. Please, just let me go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Adarfo Sotelato**
> ""Not just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You took my wife and unborn child from me. Nothing you say or do will ever justify that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Adarfo Sotelato**
> ""Be grateful you didn't meet the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[148]`
Mówca: **Adarfo Sotelato**
> ""You think I care about your gratitude? I did what was needed, not for you, but for the future -- for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[149]`
Mówca: **Narrator**
> "He didn't answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[150]`
Mówca: **Adarfo Sotelato**
> ""That's not for you to worry about anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[151]`
Mówca: **Narrator**
> "For the second time in my life, a hood went over my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Follow_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[153]`
Mówca: **Adarfo Sotelato**
> ""You think I care about your gratitude?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A future built on betrayal and bloodshed. And here I thought we were building something lasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given the circumstances, I suppose it's not the worst outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Adarfo Sotelato**
> ""We are. You just won't be around long enough to see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[157]`
Mówca: **Adarfo Sotelato**
> ""Glad you’re beginning to understand. You see... sometimes, sacrifices are inevitable for a greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You took my wife and child away from me. Nothing you say or do will ever replace that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Adarfo Sotelato**
> ""Don't worry. You'll be seeing them soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[163]`
Mówca: **Adarfo Sotelato**
> ""For what it's worth, you'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[164]`
Mówca: **Adarfo Sotelato**
> ""How could I forget? You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Adarfo Sotelato**
> ""Exactly! For all to hear! You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The last thing I want is recognition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Adarfo Sotelato**
> ""Are you kidding me? You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Adarfo Sotelato**
> ""Yes, you did. You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Married == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No... I suppose not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Adarfo Sotelato**
> ""You'll be remembered as the man who ushered in a new era for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Banners of revolution waved proudly as fireworks illuminated the night sky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Adarfo Sotelato**
> ""Do you see that? That’s what liberation looks like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Adarfo walked up to a large curtain and pulled it aside, revealing the street below illuminated with cheers and celebrations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[181]`
Mówca: **Taddeus Azaro**
> ""Shame on you, Romus Toras! You know nothing of loyalty and honor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[182]`
Mówca: **Narrator**
> "A bullet whizzed past us, close enough to leave a sharp ringing in my ears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[188]`
  - -> `[189]`
  - -> `[190]`

### Węzeł `[183]`
Mówca: **Adarfo Sotelato**
> ""Stop worrying. It will be over soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter is in the building! I have to get her out!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything happens to my family, you will pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is too much. Order them to stand down immediately!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""TITUS! I ORDER YOU TO STAND DOWN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damn! Titus will kill all of us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nicely done. My compliments to your men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you botch this, Adarfo! Do you hear me? If your guys fail, we're screwed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell is going on!? I thought you were capable of a silent assault!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[198]`
Mówca: **Narrator**
> "As I peeked in Titus' direction, I noticed a man with a knife charging at him from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[203]`
Mówca: **Adarfo Sotelato**
> ""It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[204]`
Mówca: **Adarfo Sotelato**
> ""Wait!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[205]`
Mówca: **Adarfo Sotelato**
> ""They'll be fine. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Titus paused for a moment and glanced my way, just as a man with a knife charged at him from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[207]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing as Adarfo continued showing off my daughter's hand. He eyed me, almost as if baiting, before eventually letting go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right, Vina. You're an armchair liberal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be reasonable, Adarfo. My daughter is innocent in all this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[210]`
Mówca: **Manus Sazon**
> ""Your Majesty! What have you done!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Hugo Toras**
> ""Captain Gordion! Handle this at once!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Titus, wielding his sidearm, managed to take down an attacker before jumping behind a serving trolley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[213]`
Mówca: **Narrator**
> "Adarfo walked up to Manus and roughly examined his palms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Adarfo walked up to Leona and roughly examined her palms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[218]`
Mówca: **Adarfo Sotelato**
> ""A fisherman's daughter who turned her back on the commoners' struggle as soon as she fished herself a royal husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[219]`
Mówca: **Narrator**
> "He took Vina by the wrist and held her arm high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[220]`
Mówca: **Titus Gordion**
> ""SUPPRESSIVE FIRE!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true && RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[227]`
Mówca: **Narrator**
> "As I dove for cover behind the table, I realized Adarfo was crouched beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`
  - -> `[197]`
  - -> `[194]`

### Węzeł `[228]`
Mówca: **Narrator**
> "The room filled with screams and the deafening crack of gunshots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[229]`
Mówca: **Vina Toras**
> ""FATHER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sotelato. I command you to get your hands off of her!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[231]`
Mówca: **Narrator**
> "He turned to Hubertus and grabbed his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[232]`
Mówca: **Narrator**
> "He took Mother by the wrist and held her arm high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[233]`
Mówca: **Vina Toras**
> ""Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[209]`
  - -> `[208]`
  - -> `[207]`

### Węzeł `[234]`
Mówca: **Estela Toras**
> ""For heaven's sake, Romus, are you really going to let him get away with this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[238]`
  - -> `[237]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Titus Gordion**
> ""You got my men killed, Your Majesty! Good men who devoted their lives to protecting you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing as Adarfo continued showing off Mother's hand. He eyed me, almost as if baiting, before eventually letting go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right, Mother. You're a class traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be reasonable, Adarfo. My mother is innocent in all this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sotelato. I command you to get your hands off of her!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[240]`
Mówca: **Adarfo Sotelato**
> ""Something that should have been done a long time ago. Men, escort our friends into the atrium.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[241]`
Mówca: **Daria de Rava**
> ""Mr. Sotelato! What have you done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""What kind of king invites revolutionaries to attack his family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[246]`
Mówca: **Hugo Toras**
> ""You organized this with the rebels? How could you?! Do you have any idea what you've done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[247]`
Mówca: **Narrator**
> "My guests barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[251]`
Mówca: **Rico Toras**
> ""Holy shit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[255]`
Mówca: **Narrator**
> "Adarfo stepped out from his cover and slapped me on the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[256]`
Mówca: **Pabel Adria**
> ""Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Held at gunpoint, everyone did as they were told."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[258]`
Mówca: **Estela Toras**
> ""Mr. Sotelato! What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Narrator**
> "When we entered the room, Mother and Pabel stood up abruptly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[263]`
Mówca: **Narrator**
> "When we entered the room, Mother stood up abruptly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Estela Toras**
> ""Oh my God! Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "Attack Adarfo."]** — Mówca: **Player_Romus_Italic**
> "I leapt off the floor and lunged at Adarfo, determined to break his neck. His men restrained me before I could reach him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "Restrain yourself."]** — Mówca: **Player_Romus_Italic**
> "I held back the urge to act rashly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_King_Resists += 2; RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 2;
Variable["RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Adarfo Sotelato**
> ""Don't do that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Adarfo Sotelato**
> ""Anyone else feeling brave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Mother's silent condemnation was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Narrator**
> "Pabel's face was filled with disappointment, as if I had let him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Worse were Vina and Mother, whose silent condemnation was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Worse was Mother, whose silent condemnation was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[285]`
Mówca: **Narrator**
> "Vina's face was filled with disappointment, as if I had let her down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[286]`
Mówca: **Adarfo Sotelato**
> ""Courtesy of your esteemed sovereign... that ends today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[345]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[318]`
  - -> `[399]`

### Węzeł `[290]`
Mówca: **Adarfo Sotelato**
> ""You see? What did I tell you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Manus rushed for Adarfo, but his men held him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Narrator**
> "Axel rushed for Adarfo, but his men held him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[305]`
Mówca: **Narrator**
> "Rico cowered, doing nothing as the scene unfolded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Everyone_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoBetrayal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `AddConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[311]`
Mówca: **Adarfo Sotelato**
> ""It's not pretty. But true change rarely is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[312]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato! What have you done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""You... What have you done?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[317]`
Mówca: **Narrator**
> "All eyes turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. Now sign the new constitution so we can all get on with our lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Narrator**
> "Adarfo choked back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Adarfo Sotelato**
> ""It's a little too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Adarfo Sotelato**
> ""A Princess reading the words of Malenyev -- but what do you know of the workers' struggle? Nothing!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[325]`
Mówca: **Adarfo Sotelato**
> ""A Princess claiming to sympathize with the people -- but what do you know of their struggle? Nothing!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Taddeus Azaro**
> ""I bled for your father! I stood by him when others wouldn't. And for what? A knife in the back from his coward of a son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_RomanceHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_RomanceHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_RomanceHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RomanceHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could you?! I loved her!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Adarfo Sotelato**
> ""I'm sorry. But anyone who stands in the way of revolution has to face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibrary = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_SeizedLibrary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Narrator**
> "Without warning, Adarfo drew his gun and shot him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_AdarfoShoots = true;
RiziaDLC.SkipToEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Death_AdarfoShoots"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Birthday = true;
RiziaDLC.Birthday_Adarfo_Usurped = true;
RiziaDLC.SkipToEnding = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Revolution_Birthday"] = true;
Variable["RiziaDLC.Birthday_Adarfo_Usurped"] = true;
Variable["RiziaDLC.SkipToEnding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no other choice. We need these reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Violence wasn't part of the plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[343]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[342]`
  - -> `[287]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no other choice. It is time to let go of the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. I'm giving my full support to Mr. Sotelato to form a new democratic government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Hugo Toras**
> ""You've gone mad!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop with the theatrics, Mr. Sotelato. We are here for the signatures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Adarfo Sotelato**
> ""No. That ship has sailed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop with the theatrics, Mr. Sotelato. This is supposed to be a *smooth and peaceful* transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[351]`
Mówca: **Narrator**
> "I froze momentarily, unable to react at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_King_Resists > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And so the great House of Azaro ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Adarfo Sotelato**
> ""As all noble houses must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[361]`
  - -> `[363]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You monster! This wasn't part of the plan!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I urge you all to do as he asks. Nobody else needs to get hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[363]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I didn't say a word. Finally, Hugo broke the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[364]`
Mówca: **Russello Montoro**
> ""Now you wait just a gosh-darn second--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[368]`
Mówca: **Narrator**
> "Without looking in Rusty's direction, Adarfo signalled to one of his men, who swiftly drew his rifle and shot the gold magnate in the head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Somebody screamed. Adarfo permitted himself a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[373]`
Mówca: **Narrator**
> "Lucita shook with rage, unable to form words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras"); RemoveConversant("Hubertus Toras"); RemoveConversant("Estela Toras"); RemoveConversant("Leona Sazon"); RemoveConversant("Titus Gordion"); RemoveConversant("Angelica Sazon"); RemoveConversant("Manus Sazon"); RemoveConversant("Vina Toras"); RemoveConversant("Rico Toras"); RemoveConversant("Axel Reinhart"); RemoveConversant("Russello Montoro"); RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Hubertus Toras");
RemoveConversant("Estela Toras");
RemoveConversant("Leona Sazon");
RemoveConversant("Titus Gordion");
RemoveConversant("Angelica Sazon");
RemoveConversant("Manus Sazon");
RemoveConversant("Vina Toras");
RemoveConversant("Rico Toras");
RemoveConversant("Axel Reinhart");
RemoveConversant("Russello Montoro");
RemoveConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[378]`
Mówca: **Narrator**
> "Rusty, Lucita and Taddeus' bodies had been piled in a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[379]`
Mówca: **Narrator**
> "After a while, I realized that I was the only living noble left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[380]`
Mówca: **Narrator**
> "Lucita and Taddeus' bodies had been piled in a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Narrator**
> "Taddeus and Rusty's bodies had been piled in a corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Narrator**
> "Taddeus' corpse lay in a corner, next to his wheelchair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Attack_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Narrator**
> "Adarfo's men continued to hold me back. He walked over to us and looked me up and down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[390]`
Mówca: **Narrator**
> "Adarfo's men moved in to restrain me. He walked over to us and swiftly looked me up and down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""Good work, *Your Majesty*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[392]`
Mówca: **Hugo Toras**
> ""For heaven's sake, Romus, shut up before you get the rest of us killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[393]`
Mówca: **Hugo Toras**
> ""We submit, Mr. Sotelato. Please don't harm anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[394]`
Mówca: **Narrator**
> "With a withering glance at me, Hugo nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_King_Resists += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] = Variable["RiziaDLCIsolated.Birthday_Gathering_King_Resists"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[396]`
Mówca: **Adarfo Sotelato**
> ""Come along. Your final royal duty beckons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[397]`
Mówca: **Narrator**
> "Jeers mixed with screams of horror as I was led through the crowd outside and shoved into a waiting car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Narrator**
> "Our destination -- just like Rizia's -- was unknown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This wasn't part of the plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
