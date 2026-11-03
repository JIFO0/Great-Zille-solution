# Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/House Azaro Strike/House Azaro Strike Conversation

- **ID konwersacji:** `560`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/560_House_Azaro_Strike_Conversation.md`
- **Liczba węzłów dialogowych:** 452
- **Liczba wyborów gracza:** 83

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[85]** Sevrio Castellanus
- **[88]** Carlos Robles Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_ForcedSignature`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BirthdayGathering_CarlosSworeAllegiance`
- `RiziaDLC.BirthdayGathering_ForcedSignature`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist`
- `RiziaDLCIsolated.Birthday_Gathering_Lucita_MedicalAttention`
- `RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Kneeled`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Signed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_ForcedSign`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[514]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 29

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[38]` (Paskal Beniwoll): `Variable["RiziaDLC.Taddeus_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_T...`
- Węzeł `[66]` (Paskal Beniwoll): `Variable["RiziaDLC.Taddeus_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_T...`
- Węzeł `[81]` (Paskal Beniwoll): `Variable["RiziaDLC.Lucita_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lu...`
- Węzeł `[82]` (Paskal Beniwoll): `Variable["RiziaDLC.Lucita_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lu...`
- Węzeł `[160]` (Paskal Beniwoll): `RemoveConversant("Lucita Azaro"); ;`
- Węzeł `[161]` (Paskal Beniwoll): `Variable["RiziaDLC.Lucita_Arrested"] = true; Variable["RiziaDLCIsolated.Birthday_Gathering_Lucita...`
- Węzeł `[162]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist"] = true;`
- Węzeł `[163]` (Paskal Beniwoll): `RemoveConversant("Lucita Azaro"); ;`
- *...oraz 21 innych węzłów ze skryptami.*

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
  - -> `[145]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `559` (*Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation*), Węzeł `[514]`

### Węzeł `[3]`
Mówca: **Taddeus Azaro**
> ""I will not yield, not when I've fought to keep this realm whole. I refuse to sign away my family’s legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[4]`
Mówca: **Lucita Azaro**
> "“Father, please. Think of the family. Pride isn't worth the cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Carlos Robles Azaro**
> ""It’s not what any of us want, but there is no point in resisting the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Taddeus’s jaw clenched, his eyes blazing with defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""No. Never. I’d sooner die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[58]`
  - -> `[327]`
  - -> `[8]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Shoot him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Without hesitating, Titus raised his gun and fired, a single shot resonating throughout the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Taddeus’ body tumbled out of his wheelchair and crumpled lifelessly to the floor, blood pooling around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Lucita's scream pierced the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""You… BASTARD!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Anyone else feeling brave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Lucita glared at me, her gaze a mix of rage and anguish, readying to lash out. But Carlos grabbed her arm, pulling her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[15]`
Mówca: **Carlos Robles Azaro**
> ""Don’t. Think of what will happen if we refuse. This is the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[171]`
  - -> `[340]`
  - -> `[361]`

### Węzeł `[16]`
Mówca: **Narrator**
> "After a moment, Lucita took a deep breath and stepped toward the table. She turned and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[17]`
Mówca: **Narrator**
> "She picked up the pen with trembling fingers and bent down as though to sign the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "But then, in a flash, her hand moved to her side, pulled out the hidden knife she always carried, and drew her arm back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Titus reacted instantly, piercing the air with another gunshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Lucita staggered back, clutching her thigh as she fell to her knees, her face a mask of pain and defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> "“You’ll never get away with this!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[158]`
  - -> `[155]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest her -- *immediately*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[23]`
Mówca: **Titus Gordion**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, see to it that she meets the same fate as her father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[25]`
Mówca: **Narrator**
> "In one swift motion, Titus aimed and pulled the trigger. Lucita collapsed, lifeless, beside her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Carlos's face blanched with fear. He glanced at the blood on the floor, his lips trembling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[27]`
Mówca: **Carlos Robles Azaro**
> ""I... I swear my undying allegiance to you, Your Majesty. I’ll do as you ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[28]`
Mówca: **Narrator**
> "He picked up the pen from the floor, kneeling to sign the document with shaking hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[61]`
  - -> `[29]`
  - -> `[63]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. That wasn't so difficult, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The smell of smoke and gunpowder hung in the room, marking the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Titus took hold of Taddeus's wheelchair, passing him off to the other guardsmen waiting at the far end of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your fate was sealed the moment you crossed me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sense hostility -- not a good position for negotiations, though there’s nothing to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> "“Please, Father. Think of the family. Pride isn't worth the cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Your signature, if you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[40]`
Mówca: **Lucita Azaro**
> ""It’s not what any of us want, but this is our only chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Carlos Robles Azaro**
> ""Taddeus, for the sake of the family, you must reconsider. Our pride is not worth the cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[54]`
Mówca: **Taddeus Azaro**
> ""You will not escape the consequences of this action! Mark my words... justice will be served!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[64]`
  - -> `[59]`
  - -> `[32]`

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""He can’t force us into anything, Father. His Majesty fathered a child with me. House Azaro's fate is bound with the Crown's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Carlos Robles Azaro**
> ""Are you two mad? I don't like this anymore than you do, but what choice do we have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""He can’t force us into anything, Father. Our legacy isn't theirs to claim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Under the authority vested in me as king, I place you under arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is precisely what’s being served.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! His hands appear to be too weak. Please help him with the signature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am grateful for your commitment. Rise, for your actions do not go unnoticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One act does not prove your loyalty. I expect to see consistency in your actions from here on out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure you’re not trying to sign in Morse code? I can barely read that mess!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice lies in the hands of those who hold power, not in empty ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is mine to command. Your actions left me no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[67]`
Mówca: **Carlos Robles Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[68]`
Mówca: **Taddeus Azaro**
> ""Nothing you could say or do could convince me otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[69]`
Mówca: **Carlos Robles Azaro**
> ""It’s not what any of us want, but there is no point in resisting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[70]`
Mówca: **Taddeus Azaro**
> ""I’d sooner die than give an inch!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[58]`
  - -> `[327]`
  - -> `[8]`

### Węzeł `[71]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty, my allegiance is to you and you alone. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Jaw clenched, Taddeus’s eyes blazing with defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Lucita's scream pierced the room as the sound of fear filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Carlos sat paralyzed, eyes wide in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And then there was one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? What will it be, Carlos?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[88]`
Mówca: **Carlos Robles Azaro**
> ""Thank you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[89]`
Mówca: **Carlos Robles Azaro**
> ""I pledge my loyalty to you. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[93]`
Mówca: **Carlos Robles Azaro**
> ""Please, spare me, Your Majesty. My allegiance is to you and you alone. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These documents aren't going to sign themselves, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[95]`
Mówca: **Carlos Robles Azaro**
> ""Please, spare me, Your Majesty. I pledge my loyalty to you. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Carlos took a moment to steady himself before completing his signature and stepping away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Carlos rose slowly, his head bowed in quiet acknowledgment as he stepped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""I'll give you your damn signature. But if you think that will buy my silence, you don’t know me at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucita pressed the pen to the page, her strokes sharp and deliberate,"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[109]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. Was that so hard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such defiance. I’ll give you credit for that, though I wonder how far it will take you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, Lucita, silence from you was never my expectation. Guards, take her into custody immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""Not nearly as hard as it’ll be for you when I’m through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[113]`
Mówca: **Lucita Azaro**
> ""Farther than you think. I don’t rely on credit from men like you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Uneasy whispers filled the room as eyes darted nervously, marking the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[115]`
Mówca: **Taddeus Azaro**
> ""Let it be known that House Azaro will never respect the legitimacy of this fraudulent document.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m sure I'll lose sleep over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just try to challenge it. You'll see how much weight this document carries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. That was the last straw, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, love. But it has to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Romus, how could you?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[122]`
  - -> `[182]`
  - -> `[180]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""There's nothing you can say or do that would make me betray my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your duty is to me, not to a crumbling legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""If loyalty to my own blood is a crime, then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""I am not afraid of you, and I will not betray my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After everything we've shared, you would still choose them over me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I AM your family -- WE are a family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not afraid? You should be. Titus, see to her arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you have forced my hand. Titus, please help her with the signature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your defiance only serves to endanger our child. You shall be taken into custody immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""Without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Just because we share a child doesn't mean I will follow you blindly into treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Narrator**
> "She placed a hand on her pregnant belly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Carlos Robles Azaro**
> ""I swear my undying allegiance to you, Your Majesty. I’ll do as you ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[143]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I've given my blood, my years, and my loyalty to Rizia -- to preserve the very kingdom you now accuse me of betraying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Taddeus Azaro**
> ""I have sacrificed more than most, and yet you demand that I surrender the very legacy I've fought to protect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[145]`
Mówca: **Narrator**
> "Taddeus' expression twisted in anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[149]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fool! She's with child!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Titus Gordion**
> ""I'm sorry, Your Majesty. But your life was in danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[158]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll pay for that little stunt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After everything we've been through, this is how you choose to repay me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""Believe me, my repayment is far from finished!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""How could you?! I'm carrying your child!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest her. See to it that she is given the necessary medical attention. If she's to be brought to justice, I need her alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""Alright. Let's get her out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested = true; RiziaDLCIsolated.Birthday_Gathering_Lucita_MedicalAttention = true; RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Lucita_MedicalAttention"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Upon Titus' command, several men in uniform carefully escorted her to the other side of the room, where her wound was quickly attended to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[166]`
Mówca: **Titus Gordion**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Titus stepped forward swiftly, gripping her arms firmly as he pulled her back, then handed her off to his guardsmen who thwarted her attempts to resist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, 'think.' But not too long. I don't have all day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd heed Carlos' warning if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Without missing a beat, two men pushed Taddeus' wheelchair to the desk and pressed a pen firmly into his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Despite Taddeus' attempt to resist, the men wrenched his hand to the signature line, forcing him to write his name, though it was barely legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AzaroFinalMoment_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AzaroFinalMoment_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, don't get all weepy on me now. He got what he deserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By Divine authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With charm and persistence, my dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
Mówca: **Lucita Azaro**
> ""You've crossed a line today, Your Majesty. This is a betrayal beyond measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[195]`
  - -> `[268]`

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""Your actions are no better than the whims of a despot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[188]`
Mówca: **Lucita Azaro**
> ""I was wrong about you. Your actions are no better than the whims of a despot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[199]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[189]`
Mówca: **Lucita Azaro**
> ""'Divine authority?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Narrator**
> "Lucita scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Lucita Azaro**
> ""You know, I was wrong about you. Beneath it all, you're just another despot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[199]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""You always have a choice, Romus. Don’t hide behind excuses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""You didn't *have* to do anything! You always have a choice. Don’t hide behind excuses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Protest all you like. I'll make a note of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Lucita scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That may be the first honest thing you've ever said to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Better a despot than a coward who stands idle in the face of crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're pretty when you're angry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may soon regret those words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[204]`
Mówca: **Narrator**
> "I turned my attention toward Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[205]`
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Anything you'd like to add?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you've got anything to say, now's the time, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you looking at?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[208]`
Mówca: **Carlos Robles Azaro**
> ""Only that I swear my undying loyalty to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Carlos Robles Azaro**
> ""King and country come before all else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[210]`
  - -> `[212]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's self-evident. Nevertheless, I accept your pledge of devotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good man. I knew I could count on you to see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How swiftly you shift loyalties. But loyalty is loyalty, no matter where it lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
Mówca: **Narrator**
> "Lucita's eyes flared with fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AzaroFinalMoment_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Carlos bowed his head respectfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Traitor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[220]`
  - -> `[222]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More like the pot calling the kettle black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think 'patriot' is the word you're looking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I rolled my eyes, ignoring her commentary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AzaroFinalMoment_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[224]`
Mówca: **Narrator**
> "I’ll never forget the searing hatred that burned in her eyes as she looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[225]`
Mówca: **Carlos Robles Azaro**
> ""Nothing, Your Majesty. I only wish to convey my undying loyalty to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[36]`
  - -> `[13]`
  - -> `[39]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Carlos sat paralyzed, his expression frozen in disbelief, as the sound of fear filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Narrator**
> "Carlos sat paralyzed, his expression frozen in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[235]`
Mówca: **Narrator**
> "Lucita's scream pierced the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Carlos sat paralyzed, eyes wide in disbelief as the sound of fear filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AzaroFinalMoment_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  (Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  (Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "An eerie silence marked the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature = true; RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_ForcedSign = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_ForcedSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Carlos bowed his head in quiet acknowledgment as he stepped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[253]`
Mówca: **Narrator**
> "The general took a knee and bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[256]`
  - -> `[257]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am grateful for your commitment. Rise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Time will tell if your words match your actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll see how long that lasts. Just don’t make me regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m glad to hear it. Your loyalty means more than you realize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[258]`
Mówca: **Narrator**
> "The silence fell heavy, marking the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[262]`
Mówca: **Narrator**
> "Lucita glared at me, her gaze a mix of rage and anguish, readying to lash out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[263]`
  - -> `[361]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try anything funny. You know what you have to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you know what's good for you, you'll sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this. Your father’s gone. Sign it now, or I’ll make you regret not doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: FeelingBrave_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [FeelingBrave_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stand down, Lucita. You're testing my patience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Lucita Azaro**
> ""Patience be damned!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[270]`
Mówca: **Hugo Toras**
> ""Don't be a fool, Taddeus. You know there's only one choice to make here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""Carlos is right. You may not like it, but you're not blind -- this is the only option you have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[278]`
Mówca: **Hugo Toras**
> ""Don't be a fool, General. You know there's only one choice to make here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[282]`
Mówca: **Hugo Toras**
> ""Pity it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""Farewell, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[290]`
Mówca: **Narrator**
> "Hugo’s gaze lingered on Lucita's body, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[294]`
Mówca: **Hugo Toras**
> ""Your Majesty... I must admit, I never thought you'd take it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[299]`
  - -> `[300]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[298]`
Mówca: **Narrator**
> "Hugo stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve, Uncle. A mistake, I trust, you won't make again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""For all our sakes, I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[303]`
Mówca: **Hugo Toras**
> ""No, Your Majesty. Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[304]`
Mówca: **Narrator**
> "Hugo lowered his gaze, offering no reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[308]`
Mówca: **Hugo Toras**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[312]`
Mówca: **Hugo Toras**
> ""Well, that was less troublesome than I anticipated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[313]`
  - -> `[315]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes things fall into place when you have the proper leverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m sure it was, Uncle. But let’s not get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder that the simplest approach can often be the most effective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""True enough, Your Majesty. Leverage is everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Hugo Toras**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[320]`
Mówca: **Lucita Azaro**
> ""No! Stop! What are you doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""Let go of me! You have no idea what you've done! This betrayal will haunt you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Her screams continued to echo as she was dragged out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[326]`
Mówca: **Narrator**
> "I turned to Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Narrator**
> "Titus looked at me for a signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[329]`
  - -> `[8]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest him immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[333]`
**[WYBÓR GRACZA: "Gesture at Titus to pass the pen."]** — Mówca: **Player_Romus_Italic**
> "I gestured at Titus to pass the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[337]`
Mówca: **Hugo Toras**
> ""Don’t. Think of what will happen if you refuse. This is the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[339]`
  - -> `[340]`
  - -> `[361]`

### Węzeł `[338]`
Mówca: **Narrator**
> "Lucita glared at me, her gaze a mix of rage and anguish, readying to lash out. Hugo grabbed her arm, pulling her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd heed my uncle's warning if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[340]`
**[WYBÓR GRACZA: "Watch her in silence."]** — Mówca: **Player_Romus_Italic**
> "I watched her in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Carlos's face blanched with fear. H..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[342]`
Mówca: **Narrator**
> "It took less than a heartbeat to realize that I was her intended target."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""NO!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[344]`
Mówca: **Taddeus Azaro**
> ""Damn you, Romus Toras. You are a traitor to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't let you go after you told me that now, can I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`
  - -> `[348]`
  - -> `[118]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player_Romus: ""Under the authority vested in me a..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player_Romus: ""Titus. Shoot him.""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[352]`
Mówca: **Angelica Sazon**
> ""Nor House Sazon for that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It makes my eyes tear up to see Housea Sazon and Azaro hand in hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hush. It's not your turn yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Taddeus Azaro**
> ""Damn you, Romus Toras. You are nothing but one man -- one tiny little man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[116]`
  - -> `[356]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. That was the last straw, General. Let this be a message to you both...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't waste your words, General. It's over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "I turned to Carlos."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your father already signed the documents. You'd better respect the law now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[83]`
  - -> `[94]`

### Węzeł `[372]`
Mówca: **Carlos Robles Azaro**
> ""I have no choice but to respect this decree, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Carlos Robles Azaro**
> ""I swear my undying allegiance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Narrator**
> "Titus signaled to Sevrio, who took hold of Taddeus' wheelchair before passing him off to his Guardians waiting at the far end of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to our armed visitors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[383]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Narrator**
> "Without missing a beat, two Wruhec's Guardians pushed Taddeus' wheelchair to the desk and pressed a pen firmly into his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to our armed visitors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[389]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[393]`
Mówca: **Sevrio Castellanus**
> ""May he find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[394]`
Mówca: **Narrator**
> "The knife flew past me, embedding itself in the head of a wall-mounted animal above my shoulder. One of the guards pulled it out and handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[395]`
Mówca: **Carlos Robles Azaro**
> ""Don’t! Think of the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[171]`
  - -> `[340]`
  - -> `[361]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""Don’t! Think of the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[339]`
  - -> `[340]`
  - -> `[361]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Narrator**
> "After a moment, Lucita took a deep breath, calming herself down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ForcedSignature == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Taddeus_Arrest_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Taddeus_Arrest_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Signed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Kneeled = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_CarlosSworeAllegiance"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Kneeled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AzaroFinalMoment_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[424]`
Mówca: **Lucita Azaro**
> ""So it was all a lie? You gained my trust -- my love -- just so you could destroy my family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Lucita Attacks)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Narrator**
> "In a flash, her hand moved to her side and pulled out the hidden knife she always carried. She drew her arm back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Attacks])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[428]`
Mówca: **Taddeus Azaro**
> ""Lucita! Preserve the family honor at all costs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Narrator**
> "Too shaken to respond, his daughter simply stared as he was wheeled out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[430]`
Mówca: **Taddeus Azaro**
> ""Carlos! Preserve the family honor at all costs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[431]`
Mówca: **Narrator**
> "His cousin looked away as he was wheeled out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[433]`
Mówca: **Lucita Azaro**
> ""No! The Queen of Rizia will not stand for such humiliation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucita Attacks])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == false && (RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == false && (RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == false  and  (Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == false && (RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == false  and  (Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[439]`
Mówca: **Narrator**
> "With no signature left to gather, I took the pen and, in a single fluid stroke, transferred all Azaro property to the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, I see no choice but for you to finish the job. Make it painless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_LucitaDagger");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_LucitaDagger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunshot");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_AzarosDead");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_AzarosDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseAzaro");
AddTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_FolceDator","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Havas","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Montaklar","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Nelvisar","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Plavo","Rizia_City_HouseAzaro");
AddTokenStatusImmediately("Rizia_City_FolceDator","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Havas","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Montaklar","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Nelvisar","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Plavo","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseAzaro");
AddTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_FolceDator","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Havas","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Montaklar","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Nelvisar","Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Plavo","Rizia_City_HouseAzaro");
AddTokenStatusImmediately("Rizia_City_FolceDator","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Havas","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Montaklar","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Nelvisar","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Plavo","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
