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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Titus. Shoot him.""** | `[7]` **Taddeus Azaro**: ""No. Never. I’d sooner die.""<br>`[70]` **Taddeus Azaro**: ""I’d sooner die than give an inch!""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Taddeus_Executed"] = true; Variable["R...`<br>`PlaySoundEffect("GunshotEnding");` | `[9]` **Narrator**: "Without hesitating, Titus raised..." |
| `[13]` | **""Anyone else feeling brave?""** | `[429]` **Narrator**: "Too shaken to respond, his daugh..."<br>`[431]` **Narrator**: "His cousin looked away as he was..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>`[338]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **""Arrest her -- *immediately*.""** | `[21]` **Lucita Azaro**: "“You’ll never get away with this!”"<br>`[150]` **Titus Gordion**: ""I'm sorry, Your Majesty. But yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_Arrested"] = true; Variable["Ri...` | `[23]` **Titus Gordion**: ""Yes, sir."" |
| `[24]` | **""Titus, see to it that she meets the same fate as her father.""** | `[21]` **Lucita Azaro**: "“You’ll never get away with this!”" | `Variable["RiziaDLC.Taddeus_Executed"] == true` | `Variable["RiziaDLC.Lucita_Executed"] = true; Variable["Ri...`<br>`PlaySoundEffect("GunshotEnding");` | `[25]` **Narrator**: "In one swift motion, Titus aimed..." |
| `[29]` | **""There. That wasn't so difficult, was it?""** | `[28]` **Narrator**: "He picked up the pen from the fl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "Carlos rose slowly, his head bow..." |
| `[32]` | **""Your fate was sealed the moment you crossed me.""** | `[54]` **Taddeus Azaro**: ""You will not escape the consequ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Hugo Toras**: ""Pity it had to come to this.""<br>`[428]` **Taddeus Azaro**: ""Lucita! Preserve the family hon..."<br>*(oraz 1 innych odgałęzień)* |
| `[36]` | **""I sense hostility -- not a good position for negotiations, though there’s nothing..."** | `[429]` **Narrator**: "Too shaken to respond, his daugh..."<br>`[431]` **Narrator**: "His cousin looked away as he was..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>`[338]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **""Now... Your signature, if you will.""** | `[429]` **Narrator**: "Too shaken to respond, his daugh..."<br>`[431]` **Narrator**: "His cousin looked away as he was..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>`[338]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **""Under the authority vested in me as king, I place you under arrest.""** | `[7]` **Taddeus Azaro**: ""No. Never. I’d sooner die.""<br>`[70]` **Taddeus Azaro**: ""I’d sooner die than give an inch!""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Taddeus_Arrested"] = true; Variable["R...` | `[31]` **Narrator**: "Titus took hold of Taddeus's whe..."<br>`[378]` **Narrator**: "Titus signaled to Sevrio, who to..." |
| `[59]` | **""Justice is precisely what’s being served.""** | `[54]` **Taddeus Azaro**: ""You will not escape the consequ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Hugo Toras**: ""Pity it had to come to this.""<br>`[428]` **Taddeus Azaro**: ""Lucita! Preserve the family hon..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **""Titus! His hands appear to be too weak. Please help him with the signature.""** | `[7]` **Taddeus Azaro**: ""No. Never. I’d sooner die.""<br>`[70]` **Taddeus Azaro**: ""I’d sooner die than give an inch!""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] = ...`<br>`RemoveTokenStatusImmediately("Rizia_City_FolceDator","Riz...` | `[382]` **Narrator**: "I nodded to Titus, who signaled ..."<br>`[383]` **Narrator**: "I nodded to Titus, who signaled ..." |
| `[61]` | **""I am grateful for your commitment. Rise, for your actions do not go unnoticed.""** | `[28]` **Narrator**: "He picked up the pen from the fl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Carlos Robles Azaro**: ""Thank you, sir."" |
| `[62]` | **""One act does not prove your loyalty. I expect to see consistency in your actions ..."** | `[28]` **Narrator**: "He picked up the pen from the fl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Carlos Robles Azaro**: ""Yes, Your Majesty."" |
| `[63]` | **""Are you sure you’re not trying to sign in Morse code? I can barely read that mess!""** | `[28]` **Narrator**: "He picked up the pen from the fl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "Carlos took a moment to steady h..." |
| `[64]` | **""Justice lies in the hands of those who hold power, not in empty ideals.""** | `[54]` **Taddeus Azaro**: ""You will not escape the consequ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Hugo Toras**: ""Pity it had to come to this.""<br>`[428]` **Taddeus Azaro**: ""Lucita! Preserve the family hon..."<br>*(oraz 1 innych odgałęzień)* |
| `[65]` | **""Justice is mine to command. Your actions left me no choice.""** | `[54]` **Taddeus Azaro**: ""You will not escape the consequ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Hugo Toras**: ""Pity it had to come to this.""<br>`[428]` **Taddeus Azaro**: ""Lucita! Preserve the family hon..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **""And then there was one.""** | `[26]` **Narrator**: "Carlos's face blanched with fear..."<br>`[326]` **Narrator**: "I turned to Carlos." | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[95]` **Carlos Robles Azaro**: ""Please, spare me, Your Majesty...."<br>`[89]` **Carlos Robles Azaro**: ""I pledge my loyalty to you. The..." |
| `[87]` | **""Well? What will it be, Carlos?""** | `[26]` **Narrator**: "Carlos's face blanched with fear..."<br>`[326]` **Narrator**: "I turned to Carlos." | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[27]` **Carlos Robles Azaro**: ""I... I swear my undying allegia..."<br>`[142]` **Carlos Robles Azaro**: ""I swear my undying allegiance t..." |
| `[94]` | **""These documents aren't going to sign themselves, General.""** | `[26]` **Narrator**: "Carlos's face blanched with fear..."<br>`[326]` **Narrator**: "I turned to Carlos." | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[93]` **Carlos Robles Azaro**: ""Please, spare me, Your Majesty...."<br>`[71]` **Carlos Robles Azaro**: ""Your Majesty, my allegiance is ..." |
| `[109]` | **""There. Was that so hard?""** | `[108]` **Narrator**: "Lucita pressed the pen to the pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucita Azaro**: ""Not nearly as hard as it’ll be ..." |
| `[110]` | **""Such defiance. I’ll give you credit for that, though I wonder how far it will tak..."** | `[108]` **Narrator**: "Lucita pressed the pen to the pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lucita Azaro**: ""Farther than you think. I don’t..." |
| `[111]` | **""Oh, Lucita, silence from you was never my expectation. Guards, take her into cust..."** | `[108]` **Narrator**: "Lucita pressed the pen to the pa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_Arrested"] = true;` | `[166]` **Titus Gordion**: "“Gladly.”" |
| `[116]` | **""I’m sure I'll lose sleep over it.""** | `[352]` **Angelica Sazon**: ""Nor House Sazon for that matter.""<br>`[355]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntR...` | `[126]` **Lucita Azaro**: ""Romus, how could you?!""<br>`[186]` **Lucita Azaro**: ""You've crossed a line today, Yo..." |
| `[117]` | **""Just try to challenge it. You'll see how much weight this document carries.""** | `[352]` **Angelica Sazon**: ""Nor House Sazon for that matter.""<br>`[115]` **Taddeus Azaro**: ""Let it be known that House Azar..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntR...` | `[126]` **Lucita Azaro**: ""Romus, how could you?!""<br>`[186]` **Lucita Azaro**: ""You've crossed a line today, Yo..." |
| `[118]` | **""Alright. That was the last straw, General.""** | `[115]` **Taddeus Azaro**: ""Let it be known that House Azar..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false` | *Brak zmian stanu* | `[344]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..." |
| `[122]` | **""Sorry, love. But it has to be done.""** | `[126]` **Lucita Azaro**: ""Romus, how could you?!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Lucita Azaro**: ""You always have a choice, Romus..." |
| `[128]` | **""Your duty is to me, not to a crumbling legacy.""** | `[127]` **Lucita Azaro**: ""There's nothing you can say or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Lucita Azaro**: ""If loyalty to my own blood is a..." |
| `[131]` | **""After everything we've shared, you would still choose them over me?""** | `[127]` **Lucita Azaro**: ""There's nothing you can say or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "She placed a hand on her pregnan..." |
| `[132]` | **""I AM your family -- WE are a family.""** | `[127]` **Lucita Azaro**: ""There's nothing you can say or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lucita Azaro**: ""Just because we share a child d..." |
| `[133]` | **""Not afraid? You should be. Titus, see to her arrest.""** | `[130]` **Lucita Azaro**: ""I am not afraid of you, and I w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_Arrested"] = true;` | `[166]` **Titus Gordion**: "“Gladly.”" |
| `[134]` | **""Then you have forced my hand. Titus, please help her with the signature.""** | `[130]` **Lucita Azaro**: ""I am not afraid of you, and I w..."<br>`[136]` **Lucita Azaro**: ""Without question.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Narrator**: "I nodded to Titus, who signaled ..."<br>`[389]` **Narrator**: "I nodded to Titus, who signaled ..." |
| `[135]` | **""Your defiance only serves to endanger our child. You shall be taken into custody ..."** | `[136]` **Lucita Azaro**: ""Without question.""<br>`[137]` **Lucita Azaro**: ""Just because we share a child d..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_Arrested"] = true;` | `[166]` **Titus Gordion**: "“Gladly.”" |
| `[149]` | **""You fool! She's with child!""** | `[20]` **Narrator**: "Lucita staggered back, clutching..." | `(Variable["RiziaDLC.Lucita_Married"] == false) == false` | *Brak zmian stanu* | `[150]` **Titus Gordion**: ""I'm sorry, Your Majesty. But yo..." |
| `[151]` | **""You'll pay for that little stunt.""** | `[20]` **Narrator**: "Lucita staggered back, clutching..." | `(Variable["RiziaDLC.Lucita_Married"] == false) == false` | *Brak zmian stanu* | `[154]` **Lucita Azaro**: ""How could you?! I'm carrying yo..." |
| `[152]` | **""After everything we've been through, this is how you choose to repay me?""** | `[20]` **Narrator**: "Lucita staggered back, clutching..." | `(Variable["RiziaDLC.Lucita_Married"] == false) == false` | *Brak zmian stanu* | `[153]` **Lucita Azaro**: ""Believe me, my repayment is far..." |
| `[158]` | **""Arrest her. See to it that she is given the necessary medical attention. If she's..."** | `[21]` **Lucita Azaro**: "“You’ll never get away with this!”"<br>`[150]` **Titus Gordion**: ""I'm sorry, Your Majesty. But yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_Arrested"] = true; Variable["Ri...` | `[159]` **Titus Gordion**: ""Alright. Let's get her out of h..." |
| `[171]` | **""Yes, 'think.' But not too long. I don't have all day.""** | `[15]` **Carlos Robles Azaro**: ""Don’t. Think of what will happe..."<br>`[337]` **Hugo Toras**: ""Don’t. Think of what will happe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[172]` | **""I'd heed Carlos' warning if I were you.""** | `[15]` **Carlos Robles Azaro**: ""Don’t. Think of what will happe..."<br>`[395]` **Carlos Robles Azaro**: ""Don’t! Think of the consequences."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[180]` | **""Oh, don't get all weepy on me now. He got what he deserved.""** | `[126]` **Lucita Azaro**: ""Romus, how could you?!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Lucita Azaro**: ""I was wrong about you. Your act..." |
| `[181]` | **""By Divine authority.""** | `[126]` **Lucita Azaro**: ""Romus, how could you?!"" | `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true` | *Brak zmian stanu* | `[189]` **Lucita Azaro**: ""'Divine authority?'"" |
| `[185]` | **""With charm and persistence, my dear.""** | `[126]` **Lucita Azaro**: ""Romus, how could you?!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "Lucita scoffed." |
| `[193]` | **""It had to be done.""** | `[186]` **Lucita Azaro**: ""You've crossed a line today, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Lucita Azaro**: ""You didn't *have* to do anythin..." |
| `[195]` | **""Protest all you like. I'll make a note of it.""** | `[186]` **Lucita Azaro**: ""You've crossed a line today, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Narrator**: "Lucita scowled." |
| `[197]` | **""That may be the first honest thing you've ever said to me.""** | `[187]` **Lucita Azaro**: ""Your actions are no better than..."<br>`[188]` **Lucita Azaro**: ""I was wrong about you. Your act..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "Lucita's eyes flared with fury." |
| `[198]` | **""Better a despot than a coward who stands idle in the face of crisis.""** | `[187]` **Lucita Azaro**: ""Your actions are no better than..."<br>`[188]` **Lucita Azaro**: ""I was wrong about you. Your act..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "Lucita's eyes flared with fury." |
| `[199]` | **""You're pretty when you're angry.""** | `[187]` **Lucita Azaro**: ""Your actions are no better than..."<br>`[188]` **Lucita Azaro**: ""I was wrong about you. Your act..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "Lucita's eyes flared with fury." |
| `[200]` | **""You may soon regret those words.""** | `[188]` **Lucita Azaro**: ""I was wrong about you. Your act..."<br>`[191]` **Lucita Azaro**: ""You know, I was wrong about you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "Lucita's eyes flared with fury." |
| `[205]` | **""Anything you'd like to add?""** | `[204]` **Narrator**: "I turned my attention toward Car..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Carlos Robles Azaro**: ""Only that I swear my undying lo..." |
| `[206]` | **""If you've got anything to say, now's the time, General.""** | `[204]` **Narrator**: "I turned my attention toward Car..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Carlos Robles Azaro**: ""Only that I swear my undying lo..." |
| `[207]` | **""What are you looking at?""** | `[204]` **Narrator**: "I turned my attention toward Car..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Carlos Robles Azaro**: ""Nothing, Your Majesty. I only w..." |
| `[210]` | **""That's self-evident. Nevertheless, I accept your pledge of devotion.""** | `[209]` **Carlos Robles Azaro**: ""King and country come before al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "Carlos bowed his head respectfully." |
| `[211]` | **""Good man. I knew I could count on you to see reason.""** | `[209]` **Carlos Robles Azaro**: ""King and country come before al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "Carlos bowed his head respectfully." |
| `[212]` | **""How swiftly you shift loyalties. But loyalty is loyalty, no matter where it lands.""** | `[209]` **Carlos Robles Azaro**: ""King and country come before al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "Carlos bowed his head respectfully." |
| `[220]` | **""More like the pot calling the kettle black.""** | `[219]` **Lucita Azaro**: ""Traitor!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "I’ll never forget the searing ha..." |
| `[221]` | **""I think 'patriot' is the word you're looking for.""** | `[219]` **Lucita Azaro**: ""Traitor!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "I’ll never forget the searing ha..." |
| `[222]` | **"Stay silent."** | `[219]` **Lucita Azaro**: ""Traitor!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Narrator**: "With no signature left to gather..."<br>`[30]` **Narrator**: "The smell of smoke and gunpowder..." |
| `[254]` | **""I am grateful for your commitment. Rise.""** | `[253]` **Narrator**: "The general took a knee and bowe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Carlos bowed his head in quiet a..." |
| `[255]` | **""Very well. Time will tell if your words match your actions.""** | `[253]` **Narrator**: "The general took a knee and bowe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Carlos bowed his head in quiet a..." |
| `[256]` | **""We'll see how long that lasts. Just don’t make me regret it.""** | `[253]` **Narrator**: "The general took a knee and bowe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Carlos bowed his head in quiet a..." |
| `[257]` | **""I’m glad to hear it. Your loyalty means more than you realize.""** | `[253]` **Narrator**: "The general took a knee and bowe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Carlos bowed his head in quiet a..." |
| `[263]` | **""Don't try anything funny. You know what you have to do.""** | `[262]` **Narrator**: "Lucita glared at me, her gaze a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[264]` | **""If you know what's good for you, you'll sign.""** | `[15]` **Carlos Robles Azaro**: ""Don’t. Think of what will happe..."<br>`[262]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[265]` | **""Enough of this. Your father’s gone. Sign it now, or I’ll make you regret not doin..."** | `[15]` **Carlos Robles Azaro**: ""Don’t. Think of what will happe..."<br>`[262]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[268]` | **""Stand down, Lucita. You're testing my patience.""** | `[186]` **Lucita Azaro**: ""You've crossed a line today, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Lucita Azaro**: ""Patience be damned!"" |
| `[299]` | **""Perhaps you underestimated my resolve, Uncle. A mistake, I trust, you won't make ..."** | `[294]` **Hugo Toras**: ""Your Majesty... I must admit, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Hugo Toras**: ""No, Your Majesty. Your resolve ..." |
| `[300]` | **""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""** | `[294]` **Hugo Toras**: ""Your Majesty... I must admit, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Narrator**: "Hugo lowered his gaze, offering ..." |
| `[301]` | **""You may not see it now, but this will secure the future of the kingdom, Hugo.""** | `[294]` **Hugo Toras**: ""Your Majesty... I must admit, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Hugo Toras**: ""For all our sakes, I hope you'r..." |
| `[313]` | **""Sometimes things fall into place when you have the proper leverage.""** | `[312]` **Hugo Toras**: ""Well, that was less troublesome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Hugo Toras**: ""True enough, Your Majesty. Leve..." |
| `[314]` | **""I’m sure it was, Uncle. But let’s not get ahead of ourselves.""** | `[312]` **Hugo Toras**: ""Well, that was less troublesome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Hugo Toras**: ""Of course, Your Majesty."" |
| `[315]` | **""A reminder that the simplest approach can often be the most effective.""** | `[312]` **Hugo Toras**: ""Well, that was less troublesome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Hugo Toras**: ""Indeed."" |
| `[327]` | **""So be it.""** | `[7]` **Taddeus Azaro**: ""No. Never. I’d sooner die.""<br>`[70]` **Taddeus Azaro**: ""I’d sooner die than give an inch!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Narrator**: "Titus looked at me for a signal." |
| `[329]` | **""Arrest him immediately.""** | `[328]` **Narrator**: "Titus looked at me for a signal." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Taddeus_Arrested"] = true; Variable["R...` | `[31]` **Narrator**: "Titus took hold of Taddeus's whe..."<br>`[378]` **Narrator**: "Titus signaled to Sevrio, who to..." |
| `[333]` | **"Gesture at Titus to pass the pen."** | `[429]` **Narrator**: "Too shaken to respond, his daugh..."<br>`[431]` **Narrator**: "His cousin looked away as he was..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false` | *Brak zmian stanu* | `[14]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>`[338]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 1 innych odgałęzień)* |
| `[339]` | **""I'd heed my uncle's warning if I were you.""** | `[337]` **Hugo Toras**: ""Don’t. Think of what will happe..."<br>`[402]` **Hugo Toras**: ""Don’t! Think of the consequences."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[340]` | **"Watch her in silence."** | `[15]` **Carlos Robles Azaro**: ""Don’t. Think of what will happe..."<br>`[262]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[343]` | **""NO!""** | `[20]` **Narrator**: "Lucita staggered back, clutching..." | `(Variable["RiziaDLC.Lucita_Married"] == false) == false` | *Brak zmian stanu* | `[150]` **Titus Gordion**: ""I'm sorry, Your Majesty. But yo..." |
| `[348]` | **""I can't let you go after you told me that now, can I?""** | `[115]` **Taddeus Azaro**: ""Let it be known that House Azar..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false` | *Brak zmian stanu* | `[344]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..." |
| `[353]` | **""It makes my eyes tear up to see Housea Sazon and Azaro hand in hand.""** | `[352]` **Angelica Sazon**: ""Nor House Sazon for that matter."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..." |
| `[354]` | **""Hush. It's not your turn yet.""** | `[352]` **Angelica Sazon**: ""Nor House Sazon for that matter."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..." |
| `[356]` | **""Alright. That was the last straw, General. Let this be a message to you both...""** | `[355]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Romus**: ""Under the authority vested in m..."<br>`[8]` **Player_Romus**: ""Titus. Shoot him."" |
| `[357]` | **""Don't waste your words, General. It's over.""** | `[355]` **Taddeus Azaro**: ""Damn you, Romus Toras. You are ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntR...` | `[126]` **Lucita Azaro**: ""Romus, how could you?!""<br>`[186]` **Lucita Azaro**: ""You've crossed a line today, Yo..." |
| `[368]` | **""Your father already signed the documents. You'd better respect the law now.""** | `[15]` **Carlos Robles Azaro**: ""Don’t. Think of what will happe..."<br>`[262]` **Narrator**: "Lucita glared at me, her gaze a ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true` | *Brak zmian stanu* | `[16]` **Narrator**: "After a moment, Lucita took a de..."<br>`[406]` **Narrator**: "After a moment, Lucita took a de..." |
| `[440]` | **""Titus, I see no choice but for you to finish the job. Make it painless.""** | `[21]` **Lucita Azaro**: "“You’ll never get away with this!”" | `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false` | `Variable["RiziaDLC.Lucita_Executed"] = true; Variable["Ri...`<br>`PlaySoundEffect("GunshotEnding");` | `[25]` **Narrator**: "In one swift motion, Titus aimed..." |

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
  - -> `[145]` (*Narrator: "Taddeus' expression twisted in anger."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[3]`
Mówca: **Taddeus Azaro**
> ""I will not yield, not when I've fought to keep this realm whole. I refuse to sign away my family’s legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Taddeus Azaro: ""Nothing you could say or do could convince me otherwise.""*)

### Węzeł `[4]`
Mówca: **Lucita Azaro**
> "“Father, please. Think of the family. Pride isn't worth the cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Carlos Robles Azaro: ""It’s not what any of us want, but there is no point in r..."*)

### Węzeł `[5]`
Mówca: **Carlos Robles Azaro**
> ""It’s not what any of us want, but there is no point in resisting the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Taddeus’s jaw clenched, his eyes blazing with defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Taddeus Azaro: ""No. Never. I’d sooner die.""*)

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""No. Never. I’d sooner die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Titus! His hands appear to be too weak. Please help him ..."*)
  - -> `[58]` (*Player_Romus: ""Under the authority vested in me as king, I place you un..."*)
  - -> `[327]` (*Player_Romus: ""So be it.""*)
  - -> `[8]` (*Player_Romus: ""Titus. Shoot him.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Shoot him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[70]` (Taddeus Azaro), `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed = true; RiziaDLCSupport.Journal..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Without hesitating, Titus raised his gun and fired, a single shot resonating throughout the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Taddeus’ body tumbled out of his wheelchair and crumpled ..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Taddeus’ body tumbled out of his wheelchair and crumpled lifelessly to the floor, blood pooling around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Lucita's scream pierced the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""You… BASTARD!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "Jump to: [FeelingBrave_Hub]"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Anyone else feeling brave?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[429]` (Narrator), `[431]` (Narrator), `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Lucita glared at me, her gaze a mix of rage and anguish, readying to lash out. But Carlos grabbed her arm, pulling her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[15]`
Mówca: **Carlos Robles Azaro**
> ""Don’t. Think of what will happen if we refuse. This is the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""I'd heed Carlos' warning if I were you.""*)
  - -> `[171]` (*Player_Romus: ""Yes, 'think.' But not too long. I don't have all day.""*)
  - -> `[340]` (*Player_Romus_Italic: "Watch her in silence."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "After a moment, Lucita took a deep breath and stepped toward the table. She turned and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == false"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "She picked up the pen with trembling fingers and bent down as though to sign the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "But then, in a flash, her hand moved to her side, pulled ..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "But then, in a flash, her hand moved to her side, pulled out the hidden knife she always carried, and drew her arm back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "It took less than a heartbeat to realize that I was her i..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Titus reacted instantly, piercing the air with another gunshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunshot");"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Lucita staggered back, clutching her thigh as she fell to her knees, her face a mask of pain and defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> "“You’ll never get away with this!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""Arrest her -- *immediately*.""*)
  - -> `[158]` (*Player_Romus: ""Arrest her. See to it that she is given the necessary me..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest her -- *immediately*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucita Azaro), `[150]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true; RiziaDLCSupport.Journal_..."*)

### Węzeł `[23]`
Mówca: **Titus Gordion**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, see to it that she meets the same fate as her father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "In one swift motion, Titus aimed and pulled the trigger. Lucita collapsed, lifeless, beside her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Carlos's face blanched with fear. He glanced at the blood on the floor, his lips trembling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[27]`
Mówca: **Carlos Robles Azaro**
> ""I... I swear my undying allegiance to you, Your Majesty. I’ll do as you ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He picked up the pen from the floor, kneeling to sign the document with shaking hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""One act does not prove your loyalty. I expect to see con..."*)
  - -> `[61]` (*Player_Romus: ""I am grateful for your commitment. Rise, for your action..."*)
  - -> `[29]` (*Player_Romus: ""There. That wasn't so difficult, was it?""*)
  - -> `[63]` (*Player_Romus: ""Are you sure you’re not trying to sign in Morse code? I ..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. That wasn't so difficult, was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Carlos rose slowly, his head bowed in quiet acknowledgmen..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The smell of smoke and gunpowder hung in the room, marking the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Titus took hold of Taddeus's wheelchair, passing him off to the other guardsmen waiting at the far end of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Taddeus Azaro: ""You will not escape the consequences of this action! Mar..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your fate was sealed the moment you crossed me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""He can’t force us into anything, Father. Our legacy isn'..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: "“Please, Father. Think of the family. Pride isn't worth t..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sense hostility -- not a good position for negotiations, though there’s nothing to negotiate.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[429]` (Narrator), `[431]` (Narrator), `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> "“Please, Father. Think of the family. Pride isn't worth the cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucita Azaro: ""It’s not what any of us want, but this is our only chance.”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Your signature, if you will.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[429]` (Narrator), `[431]` (Narrator), `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[40]`
Mówca: **Lucita Azaro**
> ""It’s not what any of us want, but this is our only chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""He can’t force us into anything, Father. His Majesty fat..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucita Azaro: "“Father, please. Think of the family. Pride isn't worth t..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[50]`
Mówca: **Carlos Robles Azaro**
> ""Taddeus, for the sake of the family, you must reconsider. Our pride is not worth the cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Carlos Robles Azaro: ""It’s not what any of us want, but there is no point in r..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Carlos Robles Azaro: ""Taddeus, for the sake of the family, you must reconsider..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[54]`
Mówca: **Taddeus Azaro**
> ""You will not escape the consequences of this action! Mark my words... justice will be served!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""Justice is mine to command. Your actions left me no choi..."*)
  - -> `[64]` (*Player_Romus: ""Justice lies in the hands of those who hold power, not i..."*)
  - -> `[59]` (*Player_Romus: ""Justice is precisely what’s being served.""*)
  - -> `[32]` (*Player_Romus: ""Your fate was sealed the moment you crossed me.""*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""He can’t force us into anything, Father. His Majesty fathered a child with me. House Azaro's fate is bound with the Crown's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Carlos Robles Azaro: ""Are you two mad? I don't like this anymore than you do, ..."*)

### Węzeł `[56]`
Mówca: **Carlos Robles Azaro**
> ""Are you two mad? I don't like this anymore than you do, but what choice do we have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Carlos Robles Azaro: ""It’s not what any of us want, but there is no point in r..."*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""He can’t force us into anything, Father. Our legacy isn't theirs to claim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Under the authority vested in me as king, I place you under arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[70]` (Taddeus Azaro), `[344]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true; RiziaDLCSupport.Journal..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is precisely what’s being served.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! His hands appear to be too weak. Please help him with the signature.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[70]` (Taddeus Azaro), `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature = true; RiziaD..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am grateful for your commitment. Rise, for your actions do not go unnoticed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Carlos Robles Azaro: ""Thank you, sir.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One act does not prove your loyalty. I expect to see consistency in your actions from here on out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Carlos Robles Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure you’re not trying to sign in Morse code? I can barely read that mess!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Carlos took a moment to steady himself before completing ..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice lies in the hands of those who hold power, not in empty ideals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is mine to command. Your actions left me no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Taddeus_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[67]`
Mówca: **Carlos Robles Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Carlos rose slowly, his head bowed in quiet acknowledgmen..."*)

### Węzeł `[68]`
Mówca: **Taddeus Azaro**
> ""Nothing you could say or do could convince me otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[69]`
Mówca: **Carlos Robles Azaro**
> ""It’s not what any of us want, but there is no point in resisting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[70]`
Mówca: **Taddeus Azaro**
> ""I’d sooner die than give an inch!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Titus! His hands appear to be too weak. Please help him ..."*)
  - -> `[58]` (*Player_Romus: ""Under the authority vested in me as king, I place you un..."*)
  - -> `[327]` (*Player_Romus: ""So be it.""*)
  - -> `[8]` (*Player_Romus: ""Titus. Shoot him.""*)

### Węzeł `[71]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty, my allegiance is to you and you alone. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Jaw clenched, Taddeus’s eyes blazing with defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Taddeus Azaro: ""I’d sooner die than give an inch!""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Lucita's scream pierced the room."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Lucita's scream pierced the room as the sound of fear filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""You… BASTARD!""*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Carlos sat paralyzed, eyes wide in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "Jump to: [FeelingBrave_Hub]"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Titus Gordion: ""Yes, sir.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotEnding");"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And then there was one.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator), `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Exec..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Lucita glared at me, her gaze a mix of rage and anguish, ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? What will it be, Carlos?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator), `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Exec..."*)

### Węzeł `[88]`
Mówca: **Carlos Robles Azaro**
> ""Thank you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Carlos rose slowly, his head bowed in quiet acknowledgmen..."*)

### Węzeł `[89]`
Mówca: **Carlos Robles Azaro**
> ""I pledge my loyalty to you. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Exec..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Carlos Robles Azaro: ""Please, spare me, Your Majesty. My allegiance is to you ..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Carlos Robles Azaro: ""Your Majesty, my allegiance is to you and you alone. The..."*)

### Węzeł `[93]`
Mówca: **Carlos Robles Azaro**
> ""Please, spare me, Your Majesty. My allegiance is to you and you alone. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These documents aren't going to sign themselves, General.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator), `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Exec..."*)

### Węzeł `[95]`
Mówca: **Carlos Robles Azaro**
> ""Please, spare me, Your Majesty. I pledge my loyalty to you. The rest of House Azaro is at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Carlos took a moment to steady himself before completing his signature and stepping away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Exec..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Carlos rose slowly, his head bowed in quiet acknowledgment as he stepped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Exec..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Exec..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Carlos Robles Azaro: ""Please, spare me, Your Majesty. I pledge my loyalty to y..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Carlos Robles Azaro: ""I pledge my loyalty to you. The rest of House Azaro is a..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == false"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == false )"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "She picked up the pen with trembling fingers and bent dow..."*)

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""I'll give you your damn signature. But if you think that will buy my silence, you don’t know me at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Lucita pressed the pen to the page, her strokes sharp and..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucita pressed the pen to the page, her strokes sharp and deliberate,"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""Such defiance. I’ll give you credit for that, though I w..."*)
  - -> `[109]` (*Player_Romus: ""There. Was that so hard?""*)
  - -> `[111]` (*Player_Romus: ""Oh, Lucita, silence from you was never my expectation. G..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. Was that so hard?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucita Azaro: ""Not nearly as hard as it’ll be for you when I’m through.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such defiance. I’ll give you credit for that, though I wonder how far it will take you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucita Azaro: ""Farther than you think. I don’t rely on credit from men ..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, Lucita, silence from you was never my expectation. Guards, take her into custody immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true;"*)

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""Not nearly as hard as it’ll be for you when I’m through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[113]`
Mówca: **Lucita Azaro**
> ""Farther than you think. I don’t rely on credit from men like you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Uneasy whispers filled the room as eyes darted nervously, marking the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[115]`
Mówca: **Taddeus Azaro**
> ""Let it be known that House Azaro will never respect the legitimacy of this fraudulent document.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true && Ri..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m sure I'll lose sleep over it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[352]` (Angelica Sazon), `[355]` (Taddeus Azaro), `[115]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just try to challenge it. You'll see how much weight this document carries.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[352]` (Angelica Sazon), `[115]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. That was the last straw, General.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Taddeus Azaro: ""Damn you, Romus Toras. You are a traitor to Rizia.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist = true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, love. But it has to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""You always have a choice, Romus. Don’t hide behind excus..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""Romus, how could you?!""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucita Azaro: ""You've crossed a line today, Your Majesty. This is a bet..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Romus, how could you?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: ""With charm and persistence, my dear.""*)
  - -> `[122]` (*Player_Romus: ""Sorry, love. But it has to be done.""*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)
  - -> `[180]` (*Player_Romus: ""Oh, don't get all weepy on me now. He got what he deserv..."*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""There's nothing you can say or do that would make me betray my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player_Romus: ""Your duty is to me, not to a crumbling legacy.""*)
  - -> `[131]` (*Player_Romus: ""After everything we've shared, you would still choose th..."*)
  - -> `[132]` (*Player_Romus: ""I AM your family -- WE are a family.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your duty is to me, not to a crumbling legacy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucita Azaro: ""If loyalty to my own blood is a crime, then so be it.""*)

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""If loyalty to my own blood is a crime, then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lucita Azaro: ""I am not afraid of you, and I will not betray my family.""*)

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""I am not afraid of you, and I will not betray my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""Not afraid? You should be. Titus, see to her arrest.""*)
  - -> `[134]` (*Player_Romus: ""Then you have forced my hand. Titus, please help her wit..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After everything we've shared, you would still choose them over me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "She placed a hand on her pregnant belly."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I AM your family -- WE are a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucita Azaro: ""Just because we share a child doesn't mean I will follow..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not afraid? You should be. Titus, see to her arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true;"*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you have forced my hand. Titus, please help her with the signature.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucita Azaro), `[136]` (Lucita Azaro), `[137]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your defiance only serves to endanger our child. You shall be taken into custody immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Lucita Azaro), `[137]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true;"*)

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""Without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""Then you have forced my hand. Titus, please help her wit..."*)
  - -> `[135]` (*Player_Romus: ""Your defiance only serves to endanger our child. You sha..."*)

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Just because we share a child doesn't mean I will follow you blindly into treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""Then you have forced my hand. Titus, please help her wit..."*)
  - -> `[135]` (*Player_Romus: ""Your defiance only serves to endanger our child. You sha..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "She placed a hand on her pregnant belly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucita Azaro: ""Without question.""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Exec..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Ex..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Carlos Robles Azaro: ""I... I swear my undying allegiance to you, Your Majesty...."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true || RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Carlos Robles Azaro: ""I swear my undying allegiance to you, Your Majesty. I’ll..."*)

### Węzeł `[142]`
Mówca: **Carlos Robles Azaro**
> ""I swear my undying allegiance to you, Your Majesty. I’ll do as you ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[143]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, I've given my blood, my years, and my loyalty to Rizia -- to preserve the very kingdom you now accuse me of betraying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Taddeus Azaro: ""I have sacrificed more than most, and yet you demand tha..."*)

### Węzeł `[144]`
Mówca: **Taddeus Azaro**
> ""I have sacrificed more than most, and yet you demand that I surrender the very legacy I've fought to protect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Taddeus Azaro: ""I will not yield, not when I've fought to keep this real..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Taddeus' expression twisted in anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Taddeus Azaro: ""Your Majesty, I've given my blood, my years, and my loya..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == false)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucita Azaro: "“You’ll never get away with this!”"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: ""NO!""*)
  - -> `[149]` (*Player_Romus: ""You fool! She's with child!""*)
  - -> `[151]` (*Player_Romus: ""You'll pay for that little stunt.""*)
  - -> `[152]` (*Player_Romus: ""After everything we've been through, this is how you cho..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fool! She's with child!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Titus Gordion: ""I'm sorry, Your Majesty. But your life was in danger.""*)

### Węzeł `[150]`
Mówca: **Titus Gordion**
> ""I'm sorry, Your Majesty. But your life was in danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""Arrest her -- *immediately*.""*)
  - -> `[158]` (*Player_Romus: ""Arrest her. See to it that she is given the necessary me..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll pay for that little stunt.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucita Azaro: ""How could you?! I'm carrying your child!""*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After everything we've been through, this is how you choose to repay me?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucita Azaro: ""Believe me, my repayment is far from finished!""*)

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""Believe me, my repayment is far from finished!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucita Azaro: "“You’ll never get away with this!”"*)

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""How could you?! I'm carrying your child!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucita Azaro: "“You’ll never get away with this!”"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""Titus, see to it that she meets the same fate as her fat..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player_Romus: ""Titus, I see no choice but for you to finish the job. Ma..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest her. See to it that she is given the necessary medical attention. If she's to be brought to justice, I need her alive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucita Azaro), `[150]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true; RiziaDLCIsolated.Birthda..."*)

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""Alright. Let's get her out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Upon Titus' command, several men in uniform carefully esc..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested = true; RiziaDLCIsolated.Birthday_Gathering_Lucita_MedicalAttention = true; RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Lucita_MedicalAttention"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Lucita_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Titus Gordion: ""Alright. Let's get her out of here.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Lucita staggered back, clutching her thigh as she fell to..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Upon Titus' command, several men in uniform carefully esc..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Upon Titus' command, several men in uniform carefully escorted her to the other side of the room, where her wound was quickly attended to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[166]`
Mówca: **Titus Gordion**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Lucita Azaro: ""No! Stop! What are you doing?!""*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Titus stepped forward swiftly, gripping her arms firmly as he pulled her back, then handed her off to his guardsmen who thwarted her attempts to resist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Titus Gordion: "“Gladly.”"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "FeelingBrave_Hub"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, 'think.' But not too long. I don't have all day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Carlos Robles Azaro), `[337]` (Hugo Toras), `[395]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd heed Carlos' warning if I were you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Carlos Robles Azaro), `[395]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Without missing a beat, two men pushed Taddeus' wheelchair to the desk and pressed a pen firmly into his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Despite Taddeus' attempt to resist, the men wrenched his ..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Despite Taddeus' attempt to resist, the men wrenched his hand to the signature line, forcing him to write his name, though it was barely legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Taddeus Azaro: ""Let it be known that House Azaro will never respect the ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""There's nothing you can say or do that would make me bet..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucita Azaro: ""I'll give you your damn signature. But if you think that..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AzaroFinalMoment_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == false && (Ri..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AzaroFinalMoment_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AzaroFinalMoment_Hub"*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, don't get all weepy on me now. He got what he deserved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucita Azaro: ""I was wrong about you. Your actions are no better than t..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By Divine authority.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucita Azaro: ""'Divine authority?'""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocrac..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocr..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""By Divine authority.""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With charm and persistence, my dear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Lucita scoffed."*)

### Węzeł `[186]`
Mówca: **Lucita Azaro**
> ""You've crossed a line today, Your Majesty. This is a betrayal beyond measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""It had to be done.""*)
  - -> `[195]` (*Player_Romus: ""Protest all you like. I'll make a note of it.""*)
  - -> `[268]` (*Player_Romus: ""Stand down, Lucita. You're testing my patience.""*)

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""Your actions are no better than the whims of a despot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""You're pretty when you're angry.""*)
  - -> `[197]` (*Player_Romus: ""That may be the first honest thing you've ever said to me.""*)
  - -> `[198]` (*Player_Romus: ""Better a despot than a coward who stands idle in the fac..."*)

### Węzeł `[188]`
Mówca: **Lucita Azaro**
> ""I was wrong about you. Your actions are no better than the whims of a despot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""You may soon regret those words.""*)
  - -> `[199]` (*Player_Romus: ""You're pretty when you're angry.""*)
  - -> `[197]` (*Player_Romus: ""That may be the first honest thing you've ever said to me.""*)
  - -> `[198]` (*Player_Romus: ""Better a despot than a coward who stands idle in the fac..."*)

### Węzeł `[189]`
Mówca: **Lucita Azaro**
> ""'Divine authority?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Lucita scoffed."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "Lucita scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucita Azaro: ""You know, I was wrong about you. Beneath it all, you're ..."*)

### Węzeł `[191]`
Mówca: **Lucita Azaro**
> ""You know, I was wrong about you. Beneath it all, you're just another despot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""You may soon regret those words.""*)
  - -> `[199]` (*Player_Romus: ""You're pretty when you're angry.""*)
  - -> `[197]` (*Player_Romus: ""That may be the first honest thing you've ever said to me.""*)
  - -> `[198]` (*Player_Romus: ""Better a despot than a coward who stands idle in the fac..."*)

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""You always have a choice, Romus. Don’t hide behind excuses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucita Azaro: ""You know, I was wrong about you. Beneath it all, you're ..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It had to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucita Azaro: ""You didn't *have* to do anything! You always have a choi..."*)

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""You didn't *have* to do anything! You always have a choice. Don’t hide behind excuses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucita Azaro: ""Your actions are no better than the whims of a despot.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Protest all you like. I'll make a note of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Lucita scowled."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Lucita scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucita Azaro: ""You know, I was wrong about you. Beneath it all, you're ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That may be the first honest thing you've ever said to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucita Azaro), `[188]` (Lucita Azaro), `[191]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Lucita's eyes flared with fury."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Better a despot than a coward who stands idle in the face of crisis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucita Azaro), `[188]` (Lucita Azaro), `[191]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Lucita's eyes flared with fury."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're pretty when you're angry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Lucita Azaro), `[188]` (Lucita Azaro), `[191]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Lucita's eyes flared with fury."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may soon regret those words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Lucita Azaro), `[191]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Lucita's eyes flared with fury."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "I turned my attention toward Carlos."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[204]`
Mówca: **Narrator**
> "I turned my attention toward Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""If you've got anything to say, now's the time, General.""*)
  - -> `[205]` (*Player_Romus: ""Anything you'd like to add?""*)
  - -> `[207]` (*Player_Romus: ""What are you looking at?""*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Anything you'd like to add?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Carlos Robles Azaro: ""Only that I swear my undying loyalty to you, Your Majesty.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you've got anything to say, now's the time, General.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Carlos Robles Azaro: ""Only that I swear my undying loyalty to you, Your Majesty.""*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you looking at?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Carlos Robles Azaro: ""Nothing, Your Majesty. I only wish to convey my undying ..."*)

### Węzeł `[208]`
Mówca: **Carlos Robles Azaro**
> ""Only that I swear my undying loyalty to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Carlos Robles Azaro: ""King and country come before all else.""*)

### Węzeł `[209]`
Mówca: **Carlos Robles Azaro**
> ""King and country come before all else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""Good man. I knew I could count on you to see reason.""*)
  - -> `[210]` (*Player_Romus: ""That's self-evident. Nevertheless, I accept your pledge ..."*)
  - -> `[212]` (*Player_Romus: ""How swiftly you shift loyalties. But loyalty is loyalty,..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's self-evident. Nevertheless, I accept your pledge of devotion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Carlos bowed his head respectfully."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good man. I knew I could count on you to see reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Carlos bowed his head respectfully."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How swiftly you shift loyalties. But loyalty is loyalty, no matter where it lands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Carlos bowed his head respectfully."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "Lucita's eyes flared with fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AzaroFinalMoment_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AzaroFinalMoment_Hub"*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Carlos bowed his head respectfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""Traitor!""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Traitor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""I think 'patriot' is the word you're looking for.""*)
  - -> `[220]` (*Player_Romus: ""More like the pot calling the kettle black.""*)
  - -> `[222]` (*Player_Romus_Italic: "Stay silent."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More like the pot calling the kettle black.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "I’ll never forget the searing hatred that burned in her e..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think 'patriot' is the word you're looking for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "I’ll never forget the searing hatred that burned in her e..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I rolled my eyes, ignoring her commentary."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AzaroFinalMoment_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AzaroFinalMoment_Hub"*)

### Węzeł `[224]`
Mówca: **Narrator**
> "I’ll never forget the searing hatred that burned in her eyes as she looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[225]`
Mówca: **Carlos Robles Azaro**
> ""Nothing, Your Majesty. I only wish to convey my undying loyalty to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Carlos Robles Azaro: ""King and country come before all else.""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Taddeus Azaro: ""Lucita! Preserve the family honor at all costs!""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Taddeus Azaro: ""Carlos! Preserve the family honor at all costs!""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player_Romus_Italic: "Gesture at Titus to pass the pen."*)
  - -> `[36]` (*Player_Romus: ""I sense hostility -- not a good position for negotiation..."*)
  - -> `[13]` (*Player_Romus: ""Anyone else feeling brave?""*)
  - -> `[39]` (*Player_Romus: ""Now... Your signature, if you will.""*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Carlos sat paralyzed, his expression frozen in disbelief, as the sound of fear filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""You… BASTARD!""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Carlos sat paralyzed, his expression frozen in disbelief,..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "Carlos sat paralyzed, his expression frozen in disbelief."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "Carlos sat paralyzed, his expression frozen in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""You… BASTARD!""*)

### Węzeł `[235]`
Mówca: **Narrator**
> "Lucita's scream pierced the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""You… BASTARD!""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Lucita's scream pierced the room as the sound of fear fil..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Lucita's scream pierced the room."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Carlos sat paralyzed, eyes wide in disbelief as the sound..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Carlos sat paralyzed, eyes wide in disbelief."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Carlos sat paralyzed, eyes wide in disbelief as the sound of fear filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "Jump to: [FeelingBrave_Hub]"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AzaroFinalMoment_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AzaroFinalMoment_Hub"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  (Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Uneasy whispers filled the room as eyes darted nervously,..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  (Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "An eerie silence marked the final moment of House Azaro’s..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "An eerie silence marked the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature = true; RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_ForcedSign = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Taddeus_ForcedSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusImmediately("Rizia_City_FolceDator", "Ri..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == false)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Signed = t..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "The general took a knee and bowed his head."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Carlos bowed his head in quiet acknowledgment as he stepped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "The general took a knee and bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Romus: ""I am grateful for your commitment. Rise.""*)
  - -> `[255]` (*Player_Romus: ""Very well. Time will tell if your words match your actio..."*)
  - -> `[256]` (*Player_Romus: ""We'll see how long that lasts. Just don’t make me regret..."*)
  - -> `[257]` (*Player_Romus: ""I’m glad to hear it. Your loyalty means more than you re..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am grateful for your commitment. Rise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Carlos bowed his head in quiet acknowledgment as he stepp..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Time will tell if your words match your actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Carlos bowed his head in quiet acknowledgment as he stepp..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll see how long that lasts. Just don’t make me regret it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Carlos bowed his head in quiet acknowledgment as he stepp..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m glad to hear it. Your loyalty means more than you realize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Carlos bowed his head in quiet acknowledgment as he stepp..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "The silence fell heavy, marking the final moment of House Azaro’s defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Exec..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Ex..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The smell of smoke and gunpowder hung in the room, markin..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "The silence fell heavy, marking the final moment of House..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "Lucita glared at me, her gaze a mix of rage and anguish, readying to lash out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus_Italic: "Watch her in silence."*)
  - -> `[263]` (*Player_Romus: ""Don't try anything funny. You know what you have to do.""*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try anything funny. You know what you have to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you know what's good for you, you'll sign.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[15]` (Carlos Robles Azaro), `[262]` (Narrator), `[337]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this. Your father’s gone. Sign it now, or I’ll make you regret not doing so.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[15]` (Carlos Robles Azaro), `[262]` (Narrator), `[337]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `FeelingBrave_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [FeelingBrave_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "FeelingBrave_Hub"*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stand down, Lucita. You're testing my patience.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lucita Azaro: ""Patience be damned!""*)

### Węzeł `[269]`
Mówca: **Lucita Azaro**
> ""Patience be damned!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucita Azaro: ""You know, I was wrong about you. Beneath it all, you're ..."*)

### Węzeł `[270]`
Mówca: **Hugo Toras**
> ""Don't be a fool, Taddeus. You know there's only one choice to make here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Taddeus’s jaw clenched, his eyes blazing with defiance."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Hugo Toras: ""Don't be a fool, Taddeus. You know there's only one choi..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Taddeus’s jaw clenched, his eyes blazing with defiance."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Hugo Toras: ""Carlos is right. You may not like it, but you're not bli..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Taddeus’s jaw clenched, his eyes blazing with defiance."*)

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""Carlos is right. You may not like it, but you're not blind -- this is the only option you have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Taddeus’s jaw clenched, his eyes blazing with defiance."*)

### Węzeł `[278]`
Mówca: **Hugo Toras**
> ""Don't be a fool, General. You know there's only one choice to make here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Jaw clenched, Taddeus’s eyes blazing with defiance."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Hugo Toras: ""Don't be a fool, General. You know there's only one choi..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Jaw clenched, Taddeus’s eyes blazing with defiance."*)

### Węzeł `[282]`
Mówca: **Hugo Toras**
> ""Pity it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Hugo Toras: ""Pity it had to come to this.""*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""Farewell, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Hugo Toras: ""Farewell, Duchess.""*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[290]`
Mówca: **Narrator**
> "Hugo’s gaze lingered on Lucita's body, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Hugo’s gaze lingered on Lucita's body, as if struggling t..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[294]`
Mówca: **Hugo Toras**
> ""Your Majesty... I must admit, I never thought you'd take it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player_Romus: ""You may not see it now, but this will secure the future ..."*)
  - -> `[299]` (*Player_Romus: ""Perhaps you underestimated my resolve, Uncle. A mistake,..."*)
  - -> `[300]` (*Player_Romus: ""If you lack the stomach for hard decisions, perhaps it’s..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "Hugo stepped near me, leaning in to whisper."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[298]`
Mówca: **Narrator**
> "Hugo stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Hugo Toras: ""Your Majesty... I must admit, I never thought you'd take..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve, Uncle. A mistake, I trust, you won't make again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Hugo Toras: ""No, Your Majesty. Your resolve is clearer than ever.""*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "Hugo lowered his gaze, offering no reply."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Hugo Toras: ""For all our sakes, I hope you're right.""*)

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""For all our sakes, I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[303]`
Mówca: **Hugo Toras**
> ""No, Your Majesty. Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[304]`
Mówca: **Narrator**
> "Hugo lowered his gaze, offering no reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ||..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Hugo Toras: ""Dear God...""*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[308]`
Mówca: **Hugo Toras**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Hugo Toras: ""Well, that was less troublesome than I anticipated.""*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[312]`
Mówca: **Hugo Toras**
> ""Well, that was less troublesome than I anticipated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""I’m sure it was, Uncle. But let’s not get ahead of ourse..."*)
  - -> `[313]` (*Player_Romus: ""Sometimes things fall into place when you have the prope..."*)
  - -> `[315]` (*Player_Romus: ""A reminder that the simplest approach can often be the m..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes things fall into place when you have the proper leverage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Hugo Toras: ""True enough, Your Majesty. Leverage is everything.""*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m sure it was, Uncle. But let’s not get ahead of ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Hugo Toras: ""Of course, Your Majesty.""*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder that the simplest approach can often be the most effective.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Hugo Toras: ""Indeed.""*)

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""True enough, Your Majesty. Leverage is everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[318]`
Mówca: **Hugo Toras**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[320]`
Mówca: **Lucita Azaro**
> ""No! Stop! What are you doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Titus stepped forward swiftly, gripping her arms firmly a..."*)

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""Let go of me! You have no idea what you've done! This betrayal will haunt you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Her screams continued to echo as she was dragged out of t..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Her screams continued to echo as she was dragged out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""Let go of me! You have no idea what you've done! This be..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Her screams continued to echo as she was dragged out of t..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "I turned to Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So be it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Taddeus Azaro), `[70]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "Titus looked at me for a signal."*)

### Węzeł `[328]`
Mówca: **Narrator**
> "Titus looked at me for a signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Titus! His hands appear to be too weak. Please help him ..."*)
  - -> `[329]` (*Player_Romus: ""Arrest him immediately.""*)
  - -> `[8]` (*Player_Romus: ""Titus. Shoot him.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest him immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested = true; RiziaDLCSupport.Journal..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Exec..."*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Ex..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The smell of smoke and gunpowder hung in the room, markin..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA: "Gesture at Titus to pass the pen."]** — Mówca: **Player_Romus_Italic**
> "I gestured at Titus to pass the pen."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[429]` (Narrator), `[431]` (Narrator), `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Lucita glared at me, her gaze a mix of rage and anguish, ..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "Lucita glared at me, her gaze a mix of rage and anguish, ..."*)

### Węzeł `[337]`
Mówca: **Hugo Toras**
> ""Don’t. Think of what will happen if you refuse. This is the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""Yes, 'think.' But not too long. I don't have all day.""*)
  - -> `[339]` (*Player_Romus: ""I'd heed my uncle's warning if I were you.""*)
  - -> `[340]` (*Player_Romus_Italic: "Watch her in silence."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[338]`
Mówca: **Narrator**
> "Lucita glared at me, her gaze a mix of rage and anguish, readying to lash out. Hugo grabbed her arm, pulling her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd heed my uncle's warning if I were you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Hugo Toras), `[402]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[340]`
**[WYBÓR GRACZA: "Watch her in silence."]** — Mówca: **Player_Romus_Italic**
> "I watched her in silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Carlos Robles Azaro), `[262]` (Narrator), `[337]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Carlos's face blanched with fear. H..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Carlos's face blanched with fear. He glanced at the blood..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "It took less than a heartbeat to realize that I was her intended target."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Titus reacted instantly, piercing the air with another gu..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""NO!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Titus Gordion: ""I'm sorry, Your Majesty. But your life was in danger.""*)

### Węzeł `[344]`
Mówca: **Taddeus Azaro**
> ""Damn you, Romus Toras. You are a traitor to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""Under the authority vested in m..."*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""Titus. Shoot him.""]"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true && Ri..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true && ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Angelica Sazon: ""Nor House Sazon for that matter.""*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't let you go after you told me that now, can I?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Taddeus Azaro: ""Damn you, Romus Toras. You are a traitor to Rizia.""*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""I’m sure I'll lose sleep over it.""*)
  - -> `[117]` (*Player_Romus: ""Just try to challenge it. You'll see how much weight thi..."*)
  - -> `[348]` (*Player_Romus: ""I can't let you go after you told me that now, can I?""*)
  - -> `[118]` (*Player_Romus: ""Alright. That was the last straw, General.""*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Romus: ""Under the authority vested in me a..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""Under the authority vested in me as king, I place you un..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Romus: ""Titus. Shoot him.""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Titus. Shoot him.""*)

### Węzeł `[352]`
Mówca: **Angelica Sazon**
> ""Nor House Sazon for that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""It makes my eyes tear up to see Housea Sazon and Azaro h..."*)
  - -> `[354]` (*Player_Romus: ""Hush. It's not your turn yet.""*)
  - -> `[116]` (*Player_Romus: ""I’m sure I'll lose sleep over it.""*)
  - -> `[117]` (*Player_Romus: ""Just try to challenge it. You'll see how much weight thi..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It makes my eyes tear up to see Housea Sazon and Azaro hand in hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Taddeus Azaro: ""Damn you, Romus Toras. You are nothing but one man -- on..."*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hush. It's not your turn yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Taddeus Azaro: ""Damn you, Romus Toras. You are nothing but one man -- on..."*)

### Węzeł `[355]`
Mówca: **Taddeus Azaro**
> ""Damn you, Romus Toras. You are nothing but one man -- one tiny little man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player_Romus: ""Don't waste your words, General. It's over.""*)
  - -> `[116]` (*Player_Romus: ""I’m sure I'll lose sleep over it.""*)
  - -> `[356]` (*Player_Romus: ""Alright. That was the last straw, General. Let this be a..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. That was the last straw, General. Let this be a message to you both...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""Under the authority vested in m..."*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""Titus. Shoot him.""]"*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't waste your words, General. It's over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == true)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Player_Romus: ""Your father already signed the documents. You'd better r..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player_Romus: ""If you know what's good for you, you'll sign.""*)
  - -> `[265]` (*Player_Romus: ""Enough of this. Your father’s gone. Sign it now, or I’ll..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Carlos's face blanched with fear. H...."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "I turned to Carlos."]"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "I turned to Carlos."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I turned to Carlos."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your father already signed the documents. You'd better respect the law now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Kontekst wejściowy (poprzednik):** `[15]` (Carlos Robles Azaro), `[262]` (Narrator), `[337]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == true)"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Carlos Robles Azaro: ""I have no choice but to respect this decree, Your Majesty.""*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""Well? What will it be, Carlos?""*)
  - -> `[83]` (*Player_Romus: ""And then there was one.""*)
  - -> `[94]` (*Player_Romus: ""These documents aren't going to sign themselves, General.""*)

### Węzeł `[372]`
Mówca: **Carlos Robles Azaro**
> ""I have no choice but to respect this decree, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Carlos Robles Azaro: ""I swear my undying allegiance to you.""*)

### Węzeł `[373]`
Mówca: **Carlos Robles Azaro**
> ""I swear my undying allegiance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; ..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Titus took hold of Taddeus's wheelchair, passing him off ..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "Titus signaled to Sevrio, who took hold of Taddeus' wheel..."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "Titus signaled to Sevrio, who took hold of Taddeus' wheelchair before passing him off to his Guardians waiting at the far end of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Taddeus Azaro: ""You will not escape the consequences of this action! Mar..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Narrator: "I nodded to Titus, who signaled to our armed visitors."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "I nodded to Titus, who signaled to Sevrio."*)

### Węzeł `[382]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to our armed visitors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Without missing a beat, two men pushed Taddeus' wheelchai..."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "Without missing a beat, two Wruhec's Guardians pushed Tad..."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "Without missing a beat, two Wruhec's Guardians pushed Taddeus' wheelchair to the desk and pressed a pen firmly into his grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Despite Taddeus' attempt to resist, the men wrenched his ..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "I nodded to Titus, who signaled to our armed visitors."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "I nodded to Titus, who signaled to Sevrio."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to our armed visitors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucita Azaro: ""No! The Queen of Rizia will not stand for such humiliati..."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "I nodded to Titus, who signaled to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucita Azaro: ""No! The Queen of Rizia will not stand for such humiliati..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Sevrio Castellanus: ""May he find redemption in the afterlife.""*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[393]`
Mówca: **Sevrio Castellanus**
> ""May he find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[394]`
Mówca: **Narrator**
> "The knife flew past me, embedding itself in the head of a wall-mounted animal above my shoulder. One of the guards pulled it out and handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_LucitaDagger");"*)

### Węzeł `[395]`
Mówca: **Carlos Robles Azaro**
> ""Don’t! Think of the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""I'd heed Carlos' warning if I were you.""*)
  - -> `[171]` (*Player_Romus: ""Yes, 'think.' But not too long. I don't have all day.""*)
  - -> `[340]` (*Player_Romus_Italic: "Watch her in silence."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == true)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Carlos Robles Azaro: ""Don’t! Think of the consequences.""*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Carlos Robles Azaro: ""Don’t. Think of what will happen if we refuse. This is t..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == true)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Hugo Toras: ""Don’t! Think of the consequences.""*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Hugo Toras: ""Don’t. Think of what will happen if you refuse. This is ..."*)

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""Don’t! Think of the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""Yes, 'think.' But not too long. I don't have all day.""*)
  - -> `[339]` (*Player_Romus: ""I'd heed my uncle's warning if I were you.""*)
  - -> `[340]` (*Player_Romus_Italic: "Watch her in silence."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == false)"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "After a moment, Lucita took a deep breath and stepped tow..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "After a moment, Lucita took a deep breath, calming hersel..."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "After a moment, Lucita took a deep breath, calming herself down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == false"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ForcedSignature == false)"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ForcedSignature == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ForcedSignature == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "Jump to: [Taddeus_Arrest_Hub]"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Taddeus_Arrest_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "Taddeus_Arrest_Hub"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Taddeus_Arrest_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusImmediately("Rizia_City_FolceDator", "Ri..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_CarlosSworeAllegiance = true; RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Kneeled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_CarlosSworeAllegiance"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Carlos_Kneeled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ForcedSignature == false"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I turned to Carlos."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Carlos's face blanched with fear. He glanced at the blood..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "Jump to: [AzaroFinalMoment_Hub]"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AzaroFinalMoment_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AzaroFinalMoment_Hub"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Lucita Azaro: ""So it was all a lie? You gained my trust -- my love -- j..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist = true"*)

### Węzeł `[424]`
Mówca: **Lucita Azaro**
> ""So it was all a lie? You gained my trust -- my love -- just so you could destroy my family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Attacks]"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Lucita Attacks`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Narrator: "In a flash, her hand moved to her side and pulled out the..."*)

### Węzeł `[426]`
Mówca: **Narrator**
> "In a flash, her hand moved to her side and pulled out the hidden knife she always carried. She drew her arm back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Titus reacted instantly, piercing the air with another gu..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Attacks]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "Lucita Attacks"*)

### Węzeł `[428]`
Mówca: **Taddeus Azaro**
> ""Lucita! Preserve the family honor at all costs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "Too shaken to respond, his daughter simply stared as he w..."*)

### Węzeł `[429]`
Mówca: **Narrator**
> "Too shaken to respond, his daughter simply stared as he was wheeled out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[430]`
Mówca: **Taddeus Azaro**
> ""Carlos! Preserve the family honor at all costs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "His cousin looked away as he was wheeled out of the room."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "His cousin looked away as he was wheeled out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[433]`
Mówca: **Lucita Azaro**
> ""No! The Queen of Rizia will not stand for such humiliation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Attacks]"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Attacks]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "Lucita Attacks"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_AzaroDidntResist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == false && (RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == false && (Ri..."*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == false && (..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == false && (RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == false  and  (Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Narrator: "With no signature left to gather, I took the pen and, in ..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == false && (RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == false  and  (Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Exec..."*)

### Węzeł `[439]`
Mówca: **Narrator**
> "With no signature left to gather, I took the pen and, in a single fluid stroke, transferred all Azaro property to the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Lucita_Exec..."*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, I see no choice but for you to finish the job. Make it painless.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed = true; RiziaDLCSupport.Journal_..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_LucitaDagger");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_LucitaDagger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Lucita_Resist = true;"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunshot");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Shooting nobles at their mother's birthd..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true)"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_AzarosDead");"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_AzarosDead");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_AzarosDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "The knife flew past me, embedding itself in the head of a..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseAzaro");
AddTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_FolceDator","Rizia_City_HouseAzaro");
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
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseAzaro");
RemoveTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseAzaro");
AddTokenStatusImmediately("Rizia_City_FolceDator", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Havas", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Montaklar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Nelvisar", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Plavo", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_FolceDator","Rizia_City_HouseAzaro");
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
  - -> `[28]` (*Narrator: "He picked up the pen from the floor, kneeling to sign the..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Without hesitating, Titus raised his gun and fired, a sin..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotEnding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "In one swift motion, Titus aimed and pulled the trigger. ..."*)
