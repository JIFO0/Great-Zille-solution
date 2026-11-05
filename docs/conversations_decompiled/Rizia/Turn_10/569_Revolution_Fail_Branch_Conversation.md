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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[16]` | **"Escape."** | `[15]` **Narrator**: "Time was running out." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "Having Titus nearby would prove ..." |
| `[17]` | **"Remain where you are."** | `[15]` **Narrator**: "Time was running out." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeR...` | `[81]` **Narrator**: "I found a chair and sank into it..." |
| `[31]` | **""Name your price, Titus. Whatever you want -- money, power -- it’s yours. Just let..."** | `[93]` **Narrator**: "Especially since I knew his weak..."<br>`[25]` **Titus Gordion**: ""If you think everyone’s as corr..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] == false`<br>`(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus...` | `[25]` **Titus Gordion**: ""If you think everyone’s as corr..." |
| `[33]` | **"Use the element of surprise and make a run for it immediately."** | `[93]` **Narrator**: "Especially since I knew his weak..."<br>`[25]` **Titus Gordion**: ""If you think everyone’s as corr..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false` | *Brak zmian stanu* | `[187]` **Narrator**: "From the corner of my eye, I saw..."<br>`[35]` **Narrator**: "Just as I reached the main hall,..." |
| `[42]` | **""Congratulations, Titus. You passed the test. Now, if you'll excuse me... I'll be ..."** | `[93]` **Narrator**: "Especially since I knew his weak..."<br>`[25]` **Titus Gordion**: ""If you think everyone’s as corr..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] == false`<br>`(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit...` | `[43]` **Titus Gordion**: ""Take one more step, and I will ..." |
| `[48]` | **""What? You believe I'd cooperate with these thugs?""** | `[51]` **Titus Gordion**: ""By the authority vested in me, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Titus Gordion**: ""Guards, take him away."" |
| `[49]` | **""By what right do you dare to arrest me?""** | `[51]` **Titus Gordion**: ""By the authority vested in me, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Titus Gordion**: ""Right is defined by the oath I ..." |
| `[58]` | **"Strike Titus' boxing injury."** | `[93]` **Narrator**: "Especially since I knew his weak..."<br>`[25]` **Titus Gordion**: ""If you think everyone’s as corr..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true`<br>`(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punc...` | `[203]` **Player_Romus_Italic**: "It was now or never. I grabbed a..."<br>`[204]` **Player_Romus_Italic**: "I decided to wait until he came ..." |
| `[118]` | **""There's no time for this. I have to make sure my mother and Vina are safe.""** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..."<br>`[144]` **Hugo Toras**: ""Your Majesty... tell me you did..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true` | *Brak zmian stanu* | `[130]` **Lucita Azaro**: ""Your mother?! What about our ch..."<br>`[148]` **Hugo Toras**: ""You yourself compromised their ..." |
| `[119]` | **""I don't know what you are talking about.""** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..."<br>`[144]` **Hugo Toras**: ""Your Majesty... tell me you did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Lucita Azaro**: ""You're lying! I can see it in y..."<br>`[152]` **Hugo Toras**: ""I wish I could believe you didn..." |
| `[120]` | **""Quiet, woman! I don't need your meddling right now!""** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[126]` **Lucita Azaro**: ""How dare you speak to me with s..." |
| `[121]` | **""You may not see it now, but believe me when I say that I was doing what was best ..."** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Lucita Azaro**: ""What the hell... Do you have an..."<br>`[163]` **Hugo Toras**: ""Then it's true? Dear God, Romus..." |
| `[127]` | **""I’m sorry. I made a mistake. I never meant for it to come to this.""** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..."<br>`[144]` **Hugo Toras**: ""Your Majesty... tell me you did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Lucita Azaro**: ""What?! Do you have any idea wha..."<br>`[158]` **Hugo Toras**: ""So it is true! Dear God, Romus...." |
| `[131]` | **"Say nothing."** | `[130]` **Lucita Azaro**: ""Your mother?! What about our ch..."<br>`[148]` **Hugo Toras**: ""You yourself compromised their ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "My eyes met Lucita’s, her expres..."<br>`[180]` **Narrator**: "My eyes met Hugo's, his expressi..." |
| `[132]` | **""Ruined? We've been heading down this path for a long time.""** | `[130]` **Lucita Azaro**: ""Your mother?! What about our ch..."<br>`[148]` **Hugo Toras**: ""You yourself compromised their ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Lucita Azaro**: ""If we’ve been heading down this..."<br>`[179]` **Hugo Toras**: ""If we've been heading down this..." |
| `[133]` | **""I'll speak to you any way I damn well please! I don't have to explain myself to y..."** | `[126]` **Lucita Azaro**: ""How dare you speak to me with s..."<br>`[167]` **Hugo Toras**: ""'Old man?' How dare you speak t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "My eyes met Lucita’s, her expres..."<br>`[180]` **Narrator**: "My eyes met Hugo's, his expressi..." |
| `[134]` | **""No, I wasn’t! And I won’t stand here and be accused of such treachery!""** | `[126]` **Lucita Azaro**: ""How dare you speak to me with s..."<br>`[167]` **Hugo Toras**: ""'Old man?' How dare you speak t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "My eyes met Lucita’s, her expres..."<br>`[180]` **Narrator**: "My eyes met Hugo's, his expressi..." |
| `[135]` | **""Alright! I admit it! I was behind it from the start! I wanted to tear down the mo..."** | `[126]` **Lucita Azaro**: ""How dare you speak to me with s..."<br>`[167]` **Hugo Toras**: ""'Old man?' How dare you speak t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "My eyes met Lucita’s, her expres..."<br>`[180]` **Narrator**: "My eyes met Hugo's, his expressi..." |
| `[137]` | **""Don't worry. We'll find a way out of this.""** | `[130]` **Lucita Azaro**: ""Your mother?! What about our ch..."<br>`[148]` **Hugo Toras**: ""You yourself compromised their ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Lucita Azaro**: ""You’re naive if you think there..."<br>`[175]` **Hugo Toras**: ""You're a fool if you think ther..." |
| `[138]` | **""I said I'm sorry.""** | `[128]` **Lucita Azaro**: ""What?! Do you have any idea wha..."<br>`[158]` **Hugo Toras**: ""So it is true! Dear God, Romus...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucita Azaro**: ""'Sorry' isn't going to cut it. ..."<br>`[171]` **Hugo Toras**: ""Apologies are meaningless. What..." |
| `[139]` | **""I'm sorry.""** | `[130]` **Lucita Azaro**: ""Your mother?! What about our ch..."<br>`[148]` **Hugo Toras**: ""You yourself compromised their ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucita Azaro**: ""'Sorry' isn't going to cut it. ..."<br>`[171]` **Hugo Toras**: ""Apologies are meaningless. What..." |
| `[165]` | **""You may not see it now, but believe me when I say that I was doing what was best ..."** | `[144]` **Hugo Toras**: ""Your Majesty... tell me you did..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Lucita Azaro**: ""What the hell... Do you have an..."<br>`[163]` **Hugo Toras**: ""Then it's true? Dear God, Romus..." |
| `[166]` | **""Hold your tongue, old man! I don't need your meddling right now!""** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[167]` **Hugo Toras**: ""'Old man?' How dare you speak t..." |
| `[201]` | **""There's no time for this. I have to make sure my mother and the others are safe.""** | `[116]` **Lucita Azaro**: ""Romus... tell me you didn't hav..."<br>`[144]` **Hugo Toras**: ""Your Majesty... tell me you did..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false` | *Brak zmian stanu* | `[130]` **Lucita Azaro**: ""Your mother?! What about our ch..."<br>`[148]` **Hugo Toras**: ""You yourself compromised their ..." |
| `[202]` | **"Wait for the right moment, then run."** | `[93]` **Narrator**: "Especially since I knew his weak..."<br>`[25]` **Titus Gordion**: ""If you think everyone’s as corr..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false` | *Brak zmian stanu* | `[32]` **Narrator**: "I didn't have to wait long. A sp..." |
| `[203]` | **"Rush at him."** | `[58]` **Player_Romus_Italic**: "Going for his boxing injury was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Narrator**: "He twisted away. The plaque conn..." |
| `[204]` | **"Wait for him to come closer."** | `[58]` **Player_Romus_Italic**: "Going for his boxing injury was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "I didn't have to wait long. A sp..." |
| `[209]` | **""I consent. Just don't hurt my family.""** | `[51]` **Titus Gordion**: ""By the authority vested in me, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Titus Gordion**: ""Your family had nothing to do w..." |
| `[210]` | **""You fool. Adarfo was right. The Crown will crumble into insignificance, and the p..."** | `[51]` **Titus Gordion**: ""By the authority vested in me, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Titus Gordion**: ""Adarfo is dead. And the monarch..." |

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
  - -> `[3]` (*Narrator: "The heavy double doors crashed open, and a group of armed..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The heavy double doors crashed open, and a group of armed men rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == false"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I quickly took cover. Everything happened so fast, it was difficult to discern what was going on, but I was sure Adarfo's men had the upper hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Titus Gordion: ""SUPPRESSIVE FIRE!""*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Instead of being overwhelmed, they unleashed a hail of bullets on the attackers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)

### Węzeł `[6]`
Mówca: **Titus Gordion**
> ""Defensive protocol -- engage! Protect priority targets!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I quickly took cover. Everything happened so fast, it was..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "One of the guardians fell in the initial clash, but the others responded with unrelenting efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "In a matter of seconds, two of the attackers dropped to t..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "In a matter of seconds, two of the attackers dropped to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Titus, seemingly always a step ahead, reacted with calcul..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "As the assailants began to fall back into the main hall, it became clear that the uprising was faltering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike_Fail..."*)

### Węzeł `[10]`
Mówca: **Titus Gordion**
> ""Now's our chance! Close ranks and move forward! Nobody leaves the library.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Titus motioned for his men to push ahead into the next ro..."*)

### Węzeł `[11]`
Mówca: **Titus Gordion**
> ""Stay where you are, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "He turned back to his men."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "In rapid succession, two more attackers fell to Titus's marksmanship."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Titus motioned for his men to push ahead into the next room, but he stayed behind, keeping a watchful eye on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Time was running out."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "He squeezed the trigger with lightning speed, dropping the would-be shooter before a single shot could be fired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "In rapid succession, two more attackers fell to Titus's m..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Time was running out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus_Italic: "Remain where you are."*)
  - -> `[16]` (*Player_Romus_Italic: "Escape."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Escape."]** — Mówca: **Player_Romus_Italic**
> "So I embraced the only option I had left... escape."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Having Titus nearby would prove difficult, but not imposs..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Remain where you are."]** — Mówca: **Player_Romus_Italic**
> "Realizing there was no escape, I remained where I was. I would have to confront whatever I had coming head-on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_None ..."*)

### Węzeł `[18]`
Mówca: **Titus Gordion**
> ""Your pathetic attempt to use violence to force reform has been crushed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Titus Gordion: ""Lucky for us, we caught wind of it just in time.""*)

### Węzeł `[19]`
Mówca: **Titus Gordion**
> ""Your pathetic little rebellion has ended in failure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Titus Gordion: ""Lucky for us, we caught wind of it just in time.""*)

### Węzeł `[20]`
Mówca: **Titus Gordion**
> ""Lucky for us, we caught wind of it just in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail = true;"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Titus Gordion: ""Your pathetic little rebellion has ended in failure.""*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Titus Gordion: ""Your pathetic attempt to use violence to force reform ha..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Titus Gordion: ""By the authority vested in me, I hereby declare King Rom..."*)

### Węzeł `[25]`
Mówca: **Titus Gordion**
> ""If you think everyone’s as corruptible as you... think again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "Jump to: [Checkmate_Titus_Hub]"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "The pain was blinding, and my vision blurred as consciousness slipped in and out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I couldn't tell how much time had passed before the gunfi..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "The Golden Guard seized me by the arms and dragged me into the adjoining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == false)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "The Golden Guard seized me by the arms and dragged me int..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Several Wruhec's Guardians seized me by the arms and drag..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Name your price, Titus. Whatever you want -- money, power -- it’s yours. Just let me go.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] == false` AND `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator), `[25]` (Titus Gordion), `[43]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus = true;"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "I didn't have to wait long. A spray of bullets hit the ground near Titus’s feet, sending him diving for cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "That was when I seized the opportunity and bolted for the..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Use the element of surprise and make a run for it immediately."]** — Mówca: **Player_Romus_Italic**
> "It was now or never. I bolted past Titus towards the door."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator), `[25]` (Titus Gordion), `[43]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "That was when I seized the opportunity and bolted for the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Just as I reached the main hall, a gunshot cracked from behind. A sharp pain tore through my left side, and I crumpled to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Getting shot at their mother's birthday ..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "I looked down, blood pooling around my hand as I clutched the wound. Somehow, I knew it was Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "The pain was blinding, and my vision blurred as conscious..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "I couldn't tell how much time had passed before the gunfire faded into silence. When my eyes focused again, Titus was standing over me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "Jump to: [Vault_Caught_Hub]"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""Name your price, Titus. Whatever you want -- money, powe..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Checkmate_Titus_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "Checkmate_Titus_Hub"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations, Titus. You passed the test. Now, if you'll excuse me... I'll be going now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] == false` AND `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator), `[25]` (Titus Gordion), `[43]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Praise_Exit = true;"*)

### Węzeł `[43]`
Mówca: **Titus Gordion**
> ""Take one more step, and I will restrain you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "Jump to: [Checkmate_Titus_Hub]"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Titus Gordion: ""If you think everyone’s as corruptible as you... think a..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Praise_Exit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Titus Gordion: ""Take one more step, and I will restrain you.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Minutes seemed like hours, and before long, the gunfire subsided. Captain Castellanus approached Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Sevrio Castellanus: ""All clear, sir.""*)

### Węzeł `[47]`
Mówca: **Titus Gordion**
> ""Guards, take him away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? You believe I'd cooperate with these thugs?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Titus Gordion: ""Guards, take him away.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By what right do you dare to arrest me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Titus Gordion: ""Right is defined by the oath I swore -- to defend the Cr..."*)

### Węzeł `[50]`
Mówca: **Titus Gordion**
> ""Right is defined by the oath I swore -- to defend the Crown's true purpose, not the whims of a single monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Titus Gordion: ""Guards, take him away.""*)

### Węzeł `[51]`
Mówca: **Titus Gordion**
> ""By the authority vested in me, I hereby declare King Romus is to be taken into custody for treason against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""I consent. Just don't hurt my family.""*)
  - -> `[49]` (*Player_Romus: ""By what right do you dare to arrest me?""*)
  - -> `[48]` (*Player_Romus: ""What? You believe I'd cooperate with these thugs?""*)
  - -> `[210]` (*Player_Romus: ""You fool. Adarfo was right. The Crown will crumble into ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Titus, seemingly always a step ahead, reacted with calculated ferocity. As one man leveled a gun at Hugo, Titus' hand was already moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "He squeezed the trigger with lightning speed, dropping th..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == false"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Adarfo == false)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato");"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Adarfo proudly stood, raising his arms high."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "They were being led by Adarfo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Adarfo Sotelato: ""For the people!""*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Minutes seemed like hours, and before long, the gunfire subsided. Titus turned to me after receiving the "all clear" from his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Strike Titus' boxing injury."]** — Mówca: **Player_Romus_Italic**
> "Going for his boxing injury was the obvious solution, but he was too far away to strike."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true` AND `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator), `[25]` (Titus Gordion), `[43]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch = true;"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Boxing_Injury_Revealed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Boxing_Injury_Revealed == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Boxing_Injury_Revealed == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Boxing_Injury_Revealed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus_Italic: "Strike Titus' boxing injury."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Boxing_Injury_Revealed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Narrator**
> "I didn't have to wait long. A spray of bullets hit the ground near Titus’s feet, sending him running in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "My hand brushed against a bronze plaque that had fallen f..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "My hand brushed against a bronze plaque that had fallen from its mount."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "I grabbed it without hesitation and slammed it into Titus..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "I grabbed it without hesitation and slammed it into Titus’s side, aiming for his kidney."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He grunted in pain, clutching his side as he doubling ove..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "He grunted in pain, clutching his side as he doubling over as the blow landed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Titus Gordion: ""Coward!""*)

### Węzeł `[66]`
Mówca: **Titus Gordion**
> ""Coward!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I didn't wait for him to recover. I scrambled to my feet ..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I didn't wait for him to recover. I scrambled to my feet and bolted for the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player_Romus_Italic: "Rush at him."*)
  - -> `[204]` (*Player_Romus_Italic: "Wait for him to come closer."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""Congratulations, Titus. You passed the test. Now, if you..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Praise_Exit"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Narrator**
> "Several Wruhec's Guardians seized me by the arms and dragged me into the adjoining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "As I was escorted toward the exit, I saw Vina and Mother ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "As I was escorted toward the exit, I saw Mother watching ..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "As I was escorted toward the exit, I saw Vina and Mother watching from a distance with shock written across their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I wondered if this would be the last time I’d ever see th..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "As I was escorted toward the exit, I saw Mother watching from a distance with shock written across her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "I wondered if this would be the last time I’d ever see he..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see them again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested = t..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested = t..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Vault_Caught_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[81]`
Mówca: **Narrator**
> "I found a chair and sank into it, exhausted, as the muffled clamor of the uprising continued outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Lucita found her way to me."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Hugo found his way to me."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Boxing_Injury_Revealed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Boxing_Injury_Revealed == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Boxing_Injury_Revealed == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Boxing_Injury_Revealed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Especially since I knew his weak spot."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Boxing_Injury_Revealed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "Checkmate_Titus_Hub"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "He turned back to his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Titus Gordion: ""Now's our chance! Close ranks and move forward! Nobody l..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Hugo found his way to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Hugo Toras: ""Your Majesty... tell me you didn't have anything to do w..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "As the assailants began to fall back into the main hall, ..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Having Titus nearby would prove difficult, but not impossible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Boxing_Injury_Revealed == true"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Adarfo was nowhere to be seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Titus Gordion: ""Stay where you are, Your Majesty!""*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Especially since I knew his weak spot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "Checkmate_Titus_Hub"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Adarfo proudly stood, raising his arms high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Adarfo Sotelato: ""Your time is over, parasites!""*)

### Węzeł `[95]`
Mówca: **Narrator**
> "But to my dismay, I soon came to realize that the Golden Guard was far from the vulnerable targets I had anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Instead of being overwhelmed, they unleashed a hail of bu..."*)

### Węzeł `[96]`
Mówca: **Adarfo Sotelato**
> ""Your time is over, parasites!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == false"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Adarfo and his revolutionaries flooded in like an unstoppable tide, and the room erupted in gunfire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MachineGun");"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == false)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "One guardsman fell in the initial clash, but the others r..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "One of the guardians fell in the initial clash, but the o..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "One guardsman fell in the initial clash, but the others responded with unrelenting efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "In a matter of seconds, two of the attackers dropped to t..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == false)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "But to my dismay, I soon came to realize that the Golden ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "But to my dismay, I soon came to realize that the Wruhec'..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "They were being led by Adarfo."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == false"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Adarfo == false)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Adarfo and his revolutionaries flooded in like an unstopp..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "As his revolutionaries flooded in like an unstoppable tid..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "As his revolutionaries flooded in like an unstoppable tide, Adarfo joined the fray, and the room erupted in gunfire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MachineGun");"*)

### Węzeł `[110]`
Mówca: **Narrator**
> "But to my dismay, I soon came to realize that the Wruhec's Guardians were far from the vulnerable targets I had anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Instead of being overwhelmed, they unleashed a hail of bu..."*)

### Węzeł `[111]`
Mówca: **Adarfo Sotelato**
> ""For the people!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == false"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Checkmate_Titus_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Bribe_Titus == false"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Praise_Exit == false"*)
  - -> `[33]` (*Player_Romus_Italic: "Use the element of surprise and make a run for it immedia..."*)
  - -> `[202]` (*Player_Romus_Italic: "Wait for the right moment, then run."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Boxing_Injury_Revealed == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == false)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Minutes seemed like hours, and before long, the gunfire s..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sevrio Castellanus");"*)

### Węzeł `[116]`
Mówca: **Lucita Azaro**
> ""Romus... tell me you didn't have anything to do with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""You may not see it now, but believe me when I say that I..."*)
  - -> `[127]` (*Player_Romus: ""I’m sorry. I made a mistake. I never meant for it to com..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[119]` (*Player_Romus: ""I don't know what you are talking about.""*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Lucita found her way to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucita Azaro: ""Romus... tell me you didn't have anything to do with this.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no time for this. I have to make sure my mother and Vina are safe.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro), `[144]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know what you are talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro), `[144]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quiet, woman! I don't need your meddling right now!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""How dare you speak to me with such disrespect! Answer me..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but believe me when I say that I was doing what was best for the country -- for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""What the hell... Do you have any idea what you've done?! You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Quiet, woman! I don't need your meddling right now!""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""Hold your tongue, old man! I don't need your meddling ri..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""How dare you speak to me with such disrespect! Answer me now! Were you or were you not involved?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""Alright! I admit it! I was behind it from the start! I w..."*)
  - -> `[133]` (*Player_Romus: ""I'll speak to you any way I damn well please! I don't ha..."*)
  - -> `[134]` (*Player_Romus: ""No, I wasn’t! And I won’t stand here and be accused of s..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m sorry. I made a mistake. I never meant for it to come to this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro), `[144]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""What?! Do you have any idea what you've done? You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""You're lying! I can see it in your eyes! Your delusions have ruined our child's life...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""Your mother?! What about our child? Admit it, Romus, you've ruined everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, knowing full well there wasn't anything I could say to undo what had already transpired."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucita Azaro), `[148]` (Hugo Toras), `[129]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ruined? We've been heading down this path for a long time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucita Azaro), `[148]` (Hugo Toras), `[129]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll speak to you any way I damn well please! I don't have to explain myself to you or anyone else!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I wasn’t! And I won’t stand here and be accused of such treachery!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright! I admit it! I was behind it from the start! I wanted to tear down the monarchy brick by brick! There. Is that what you wanted to hear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[167]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[136]`
Mówca: **Narrator**
> "My eyes met Lucita’s, her expression filled with scorn and hatred."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "I turned away, my gaze falling on Hugo. His expression mi..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. We'll find a way out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucita Azaro), `[148]` (Hugo Toras), `[129]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I said I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Lucita Azaro), `[158]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucita Azaro), `[148]` (Hugo Toras), `[129]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""'Sorry' isn't going to cut it. What you've done is unforgivable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""You’re naive if you think there’s any way out of this now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[142]`
Mówca: **Lucita Azaro**
> ""If we’ve been heading down this path, it’s because you refused to see the signs along the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "I turned away, my gaze falling on Hugo. His expression mirrored Lucita’s, filled with contempt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""Your Majesty... tell me you didn't have anything to do with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""You may not see it now, but believe me when I say that I..."*)
  - -> `[127]` (*Player_Romus: ""I’m sorry. I made a mistake. I never meant for it to com..."*)
  - -> `[119]` (*Player_Romus: ""I don't know what you are talking about.""*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lucita Azaro: ""Your mother?! What about our child? Admit it, Romus, you..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Hugo Toras: ""You yourself compromised their safety, didn't you? My Go..."*)

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""You yourself compromised their safety, didn't you? My God, Romus... You've ruined everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucita Azaro: ""You're lying! I can see it in your eyes! Your delusions ..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""I wish I could believe you didn't wish to bring ruin on ..."*)

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""I wish I could believe you didn't wish to bring ruin on this kingdom, Romus. I really do...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""I'm sorry.""*)
  - -> `[137]` (*Player_Romus: ""Don't worry. We'll find a way out of this.""*)
  - -> `[132]` (*Player_Romus: ""Ruined? We've been heading down this path for a long time.""*)
  - -> `[131]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""I'm sorry.""*)
  - -> `[137]` (*Player_Romus: ""Don't worry. We'll find a way out of this.""*)
  - -> `[132]` (*Player_Romus: ""Ruined? We've been heading down this path for a long time.""*)
  - -> `[131]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucita Azaro: ""What?! Do you have any idea what you've done? You've rui..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Hugo Toras: ""So it is true! Dear God, Romus... Do you have any idea w..."*)

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""So it is true! Dear God, Romus... Do you have any idea what you've done? You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""I said I'm sorry.""*)
  - -> `[137]` (*Player_Romus: ""Don't worry. We'll find a way out of this.""*)
  - -> `[132]` (*Player_Romus: ""Ruined? We've been heading down this path for a long time.""*)
  - -> `[131]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucita Azaro: ""What the hell... Do you have any idea what you've done?!..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Hugo Toras: ""Then it's true? Dear God, Romus... Do you have any idea ..."*)

### Węzeł `[163]`
Mówca: **Hugo Toras**
> ""Then it's true? Dear God, Romus... Do you have any idea what you've done? You've ruined everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""I'm sorry.""*)
  - -> `[137]` (*Player_Romus: ""Don't worry. We'll find a way out of this.""*)
  - -> `[132]` (*Player_Romus: ""Ruined? We've been heading down this path for a long time.""*)
  - -> `[131]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but believe me when I say that I was doing what was best for the country -- for the family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold your tongue, old man! I don't need your meddling right now!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Hugo Toras: ""'Old man?' How dare you speak to me with such disrespect..."*)

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""'Old man?' How dare you speak to me with such disrespect! Answer me now! Were you or were you not involved in this upheaval?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""Alright! I admit it! I was behind it from the start! I w..."*)
  - -> `[133]` (*Player_Romus: ""I'll speak to you any way I damn well please! I don't ha..."*)
  - -> `[134]` (*Player_Romus: ""No, I wasn’t! And I won’t stand here and be accused of s..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucita Azaro: ""'Sorry' isn't going to cut it. What you've done is unfor..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Hugo Toras: ""Apologies are meaningless. What you've done is unforgiva..."*)

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""Apologies are meaningless. What you've done is unforgivable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucita Azaro: ""You’re naive if you think there’s any way out of this now.""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Hugo Toras: ""You're a fool if you think there's any way out of this n..."*)

### Węzeł `[175]`
Mówca: **Hugo Toras**
> ""You're a fool if you think there's any way out of this now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Lucita Azaro: ""If we’ve been heading down this path, it’s because you r..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Hugo Toras: ""If we've been heading down this path, it's because you c..."*)

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""If we've been heading down this path, it's because you chose to ignore the signs along the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "My eyes met Hugo's, his expression filled with contempt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "My eyes met Lucita’s, her expression filled with scorn an..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "My eyes met Hugo's, his expression filled with contempt."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "From the corner of my eye, I saw Lucita and motioned for ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Just as I reached the main hall, a gunshot cracked from b..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "From the corner of my eye, I saw Lucita and motioned for her to follow. But seeing the guards around her, I realized she was trapped. I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Just as I reached the main hall, a gunshot cracked from b..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "From the corner of my eye, I saw Lucita and motioned for ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[191]`
Mówca: **Narrator**
> "From the corner of my eye, I saw Lucita and motioned for her to follow. But seeing the guards around her, I realized she couldn't so I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[192]`
Mówca: **Narrator**
> "Titus turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[193]`
Mówca: **Sevrio Castellanus**
> ""All clear, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Titus turned to me."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sevrio Castellanus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Minutes seemed like hours, and before long, the gunfire s..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike_Failed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Adarfo was nowhere to be seen."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_None = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "I found a chair and sank into it, exhausted, as the muffl..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested = true;
RiziaDLC.Epilogue_Prison_HugoSendsToPrison = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_King_Arrested"] = true;
Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "Jump to: [END OF STRIKE FAIL]"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""There's no time for this. I have to make sure my mother ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""There's no time for this. I have to make sure my mother ..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no time for this. I have to make sure my mother and the others are safe.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Lucita Azaro), `[144]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "Wait for the right moment, then run."]** — Mówca: **Player_Romus_Italic**
> "I decided to wait until Titus was distracted, then make a run for it."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Titus_Boxing_Injury_Revealed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator), `[25]` (Titus Gordion), `[43]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I didn't have to wait long. A spray of bullets hit the gr..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: "Rush at him."]** — Mówca: **Player_Romus_Italic**
> "It was now or never. I grabbed a bronze plaque that had fallen from its mount and rushed at Titus, aiming for his kidney."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "He twisted away. The plaque connected with a spot on his ..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "Wait for him to come closer."]** — Mówca: **Player_Romus_Italic**
> "I decided to wait until he came closer to me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "I didn't have to wait long. A spray of bullets hit the gr..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "He twisted away. The plaque connected with a spot on his side just above my intended target."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "He coughed and took a few steps backwards."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "He coughed and took a few steps backwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Titus Gordion: ""Coward!""*)

### Węzeł `[207]`
Mówca: **Titus Gordion**
> ""Coward!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "I didn't wait for him to recover. I scrambled to my feet ..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "I didn't wait for him to recover. I scrambled to my feet and bolted for the main atrium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I consent. Just don't hurt my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Titus Gordion: ""Your family had nothing to do with this scheme. They wil..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fool. Adarfo was right. The Crown will crumble into insignificance, and the people will take power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Titus Gordion: ""Adarfo is dead. And the monarchy will live forever.""*)

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""Adarfo is dead. And the monarchy will live forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Titus Gordion: ""Guards, take him away.""*)

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""Your family had nothing to do with this scheme. They will live.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Titus Gordion: ""Guards, take him away.""*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [END OF STRIKE FAIL]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Titus Gordion: ""Stay where you are, Your Majesty!""*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[215]`
Mówca: **Titus Gordion**
> ""SUPPRESSIVE FIRE!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MachineGun");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MachineGun");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Titus Gordion: ""Defensive protocol -- engage! Protect priority targets!""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Getting shot at their mother's birthday party", "Royal Library", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Getting shot at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I looked down, blood pooling around my hand as I clutched..."*)
