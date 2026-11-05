# Rizia/Turn 10/VinaRescueOutcome

- **ID konwersacji:** `335`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/335_VinaRescueOutcome.md`
- **Liczba węzłów dialogowych:** 211
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[88]** Carlos Robles Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RelationshipPublic`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Manus_SendToWar`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Rescue_Success`
- `RiziaDLCIsolated.Turn09_VinaOutcome_Standing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_Rescue_Failed`
- `RiziaDLCIsolated.Turn09_VinaOutcome_Standing`
- `RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Died`
- `RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Rescued`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"Pick up the phone."** | `[5]` **Narrator**: "The ringing sound felt off for s..." | `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false` | `AddConversant("Hugo Toras");` | `[7]` **Hugo Toras**: ""Romus, my boy.""<br>`[11]` **Hugo Toras**: ""Your Majesty."" |
| `[12]` | **""What is it?""** | `[7]` **Hugo Toras**: ""Romus, my boy.""<br>`[11]` **Hugo Toras**: ""Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Carlos Robles Azaro**: ""I suggest sitting down if you'r..."<br>`[15]` **Hugo Toras**: ""Oh, my nephew.""<br>*(oraz 1 innych odgałęzień)* |
| `[13]` | **""What happened?""** | `[7]` **Hugo Toras**: ""Romus, my boy.""<br>`[11]` **Hugo Toras**: ""Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Carlos Robles Azaro**: ""I suggest sitting down if you'r..."<br>`[15]` **Hugo Toras**: ""Oh, my nephew.""<br>*(oraz 1 innych odgałęzień)* |
| `[14]` | **""Yes?""** | `[7]` **Hugo Toras**: ""Romus, my boy.""<br>`[11]` **Hugo Toras**: ""Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Carlos Robles Azaro**: ""I suggest sitting down if you'r..."<br>`[15]` **Hugo Toras**: ""Oh, my nephew.""<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **""What do you mean?""** | `[21]` **Hugo Toras**: ""Please take a seat if you aren't.""<br>`[176]` **Carlos Robles Azaro**: ""What I have to share won’t be e..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn09_VinaOutcome_Standing"] ...` | `[180]` **Carlos Robles Azaro**: ""Please listen closely, Your Maj..."<br>`[24]` **Hugo Toras**: ""Listen to me very carefully, Ro..." |
| `[23]` | **"Sit down on the bed."** | `[21]` **Hugo Toras**: ""Please take a seat if you aren't.""<br>`[176]` **Carlos Robles Azaro**: ""What I have to share won’t be e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Carlos Robles Azaro**: ""Please listen closely, Your Maj..."<br>`[24]` **Hugo Toras**: ""Listen to me very carefully, Ro..." |
| `[47]` | **"Pick up the phone."** | `[4]` **Narrator**: "I knew that if someone was calli..." | `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`<br>`Variable["RiziaDLC.Vina_Rescue_Success"] == true` | `AddConversant("Hugo Toras");` | `[48]` **Hugo Toras**: ""Romus, my boy.""<br>`[52]` **Hugo Toras**: ""Your Majesty."" |
| `[53]` | **""What is it?""** | `[48]` **Hugo Toras**: ""Romus, my boy.""<br>`[52]` **Hugo Toras**: ""Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Carlos Robles Azaro**: ""I was supervising our troops ne..."<br>`[56]` **Hugo Toras**: ""I was handling crown matters ne..." |
| `[54]` | **""What happened?""** | `[48]` **Hugo Toras**: ""Romus, my boy.""<br>`[52]` **Hugo Toras**: ""Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Carlos Robles Azaro**: ""I was supervising our troops ne..."<br>`[56]` **Hugo Toras**: ""I was handling crown matters ne..." |
| `[55]` | **""Yes?""** | `[48]` **Hugo Toras**: ""Romus, my boy.""<br>`[52]` **Hugo Toras**: ""Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Carlos Robles Azaro**: ""I was supervising our troops ne..."<br>`[56]` **Hugo Toras**: ""I was handling crown matters ne..." |
| `[62]` | **""Praise God!""** | `[61]` **Narrator**: "She was laughing and crying at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "She laughed again." |
| `[63]` | **""I am so glad you are okay.""** | `[61]` **Narrator**: "She was laughing and crying at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "She laughed again." |
| `[64]` | **""It is so good to hear your voice.""** | `[61]` **Narrator**: "She was laughing and crying at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "She laughed again." |
| `[68]` | **""Are you hurt? Did your captors hurt you?""** | `[67]` **Narrator**: "She laughed again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Vina Toras**: ""No, I'm fine. They didn't dare ..." |
| `[69]` | **""I swear it on the name of House Toras. They will pay in blood.""** | `[67]` **Narrator**: "She laughed again." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[77]` **Vina Toras**: ""War is war, Father. I'm sure Ri..." |
| `[73]` | **""No matter what, you are safe now.""** | `[67]` **Narrator**: "She laughed again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Vina Toras**: ""You don't know how good it is t..." |
| `[74]` | **""I will make sure that your captors will be punished accordingly.""** | `[67]` **Narrator**: "She laughed again." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[78]` **Vina Toras**: ""It's Duke Reinhart you should p..." |
| `[82]` | **""Yes?""** | `[81]` **Vina Toras**: ""Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..."<br>`[106]` **Vina Toras**: ""I forgive you. For everything.""<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **""What is it?""** | `[81]` **Vina Toras**: ""Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..."<br>`[106]` **Vina Toras**: ""I forgive you. For everything.""<br>*(oraz 1 innych odgałęzień)* |
| `[84]` | **""Tell me.""** | `[81]` **Vina Toras**: ""Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..."<br>`[106]` **Vina Toras**: ""I forgive you. For everything.""<br>*(oraz 1 innych odgałęzień)* |
| `[127]` | **""Manus is still fighting, sweetheart. We'll have this conversation if he returns.""** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | `Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false` | *Brak zmian stanu* | `[142]` **Vina Toras**: ""When, Father. Not if."" |
| `[131]` | **""Oh. Nobody told you.""** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | `Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true`<br>`(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false` | *Brak zmian stanu* | `[132]` **Narrator**: "A tremor appeared in her voice." |
| `[134]` | **""Yes, of course. If anyone deserves to be happy, it's you two.""** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | `(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false`<br>`(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false` | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true; ...` | `[146]` **Narrator**: "She gave a barely contained shri..." |
| `[139]` | **""Sure, why not? I'm a married man myself these days.""** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`<br>`(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false`<br>`(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false` | *Brak zmian stanu* | `[140]` **Narrator**: "She laughed uneasily." |
| `[143]` | **""I'm afraid much has changed in Rizia since you were taken hostage. Pairing you of..."** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "A tremor appeared in her voice." |
| `[158]` | **"Pick up the phone."** | `[4]` **Narrator**: "I knew that if someone was calli..." | `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`<br>`Variable["RiziaDLC.Vina_Rescue_Success"] == true` | `AddConversant("Carlos Robles Azaro");` | `[160]` **Carlos Robles Azaro**: ""Your Majesty… I apologize for t..." |
| `[169]` | **"Pick up the phone."** | `[5]` **Narrator**: "The ringing sound felt off for s..." | `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true` | `AddConversant("Carlos Robles Azaro");` | `[171]` **Carlos Robles Azaro**: ""Your Majesty… I apologize for t..." |
| `[193]` | **""It's not my decision anymore. You'll have to ask Prime Minister Sazon.""** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`<br>`(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false`<br>`(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false` | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true; ...` | `[195]` **Narrator**: "She gave a barely contained shri..." |
| `[197]` | **""You don't have to ask me, Vina. You're free to do whatever you want.""** | `[123]` **Vina Toras**: ""Now that this ordeal is behind ..." | `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`<br>`(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false`<br>`(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false` | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true; ...` | `[146]` **Narrator**: "She gave a barely contained shri..." |

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
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage = false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was preparing to sleep when the private phone in my living quarters rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I knew that if someone was calling at this hour, somethin..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I knew that if someone was calling at this hour, something urgent must have happened. The phone rang again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Rescue_Success == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The ringing sound felt off for some reason. I knew something was wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Romus_Italic**
> "I picked up the phone. It was Hugo."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""Romus, my boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""What is it?""*)
  - -> `[13]` (*Player_Romus: ""What happened?""*)
  - -> `[14]` (*Player_Romus: ""Yes?""*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""Romus, my boy.""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""What is it?""*)
  - -> `[13]` (*Player_Romus: ""What happened?""*)
  - -> `[14]` (*Player_Romus: ""Yes?""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[11]` (Hugo Toras), `[171]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[11]` (Hugo Toras), `[171]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[11]` (Hugo Toras), `[171]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""Oh, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""Are you sitting down?""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""Oh, my nephew.""*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""Oh, Your Majesty.""*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Oh, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""Are you sitting down?""*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""Are you sitting down?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""Please take a seat if you aren't.""*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Please take a seat if you aren't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""What do you mean?""*)
  - -> `[23]` (*Player_Romus_Italic: "Sit down on the bed."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Hugo Toras), `[176]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_VinaOutcome_Standing = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Sit down on the bed."]** — Mówca: **Player_Romus_Italic**
> "I sat down on the bed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Hugo Toras), `[176]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Listen to me very carefully, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Hugo Toras: ""I received news from the frontline...""*)

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""I received news from the frontline...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""It's about Vina.""*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""It's about Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""It breaks my heart to inform you that your daughter, our Princess Vina has passed away during her captivity in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""I am so sorry, Romus. Truly. I can't even imagine--""*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""I am so sorry, Romus. Truly. I can't even imagine--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Rescue_Failed = true;"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "I did not hear the rest of it. All I heard was the ringing of my ears. I dropped the phone on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "I started breathing heavily. It felt like my heart was be..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "I started breathing heavily. It felt like my heart was being squeezed with a wrench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "I felt helpless. I wanted to scream. I wanted to--"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "I felt helpless. I wanted to scream. I wanted to--"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "It was all in vain. Everything. My life. The crown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_VinaOutcome_Standing == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_VinaOutcome_Standing = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_VinaOutcome_Standing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_VinaOutcome_Standing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_VinaOutcome_Standing == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_VinaOutcome_Standing == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_VinaOutcome_Standing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_VinaOutcome_Standing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "My vision tunneled. I couldn't breathe anymore. I fell down."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_VinaOutcome_Standing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_VinaOutcome_Standing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "I curled up on the chair."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "My vision tunneled. I couldn't breathe anymore. I fell down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Rizia_Map_Music_Tense");"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "I curled up on the chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Rizia_Map_Music_Tense");"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Bruno rushed to my side and licked my face. I hugged him tight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Rescue_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Rescue_Success == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Rescue_Success == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Rescue_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Rescue_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Rescued ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Rescue_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Rescue_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Died = t..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Romus_Italic**
> "I picked up the phone. It was Hugo."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false` AND `Variable["RiziaDLC.Vina_Rescue_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""Romus, my boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""What is it?""*)
  - -> `[54]` (*Player_Romus: ""What happened?""*)
  - -> `[55]` (*Player_Romus: ""Yes?""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Hugo Toras: ""Romus, my boy.""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""What is it?""*)
  - -> `[54]` (*Player_Romus: ""What happened?""*)
  - -> `[55]` (*Player_Romus: ""Yes?""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[52]` (Hugo Toras), `[160]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[52]` (Hugo Toras), `[160]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[52]` (Hugo Toras), `[160]` (Carlos Robles Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""I was handling crown matters near the border when I received the news that Princess Vina and her rescuers had arrived from the front lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""And I am here with someone who has been longing to speak..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "I heard the faint voice of a woman in the background."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[58]`
Mówca: **Vina Toras**
> ""Father. It's me! Vina!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_RescuedVina");"*)

### Węzeł `[59]`
Mówca: **Vina Toras**
> ""I'm safe. We will soon fly to the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Vina Toras: ""Finally. I'm coming home!""*)

### Węzeł `[60]`
Mówca: **Vina Toras**
> ""Finally. I'm coming home!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She was laughing and crying at the same time."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "She was laughing and crying at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""I am so glad you are okay.""*)
  - -> `[62]` (*Player_Romus: ""Praise God!""*)
  - -> `[64]` (*Player_Romus: ""It is so good to hear your voice.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Praise God!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "She laughed again."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am so glad you are okay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "She laughed again."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is so good to hear your voice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "She laughed again."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "I could feel my knees go weak. It was really her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Vina Toras: ""I'm safe. We will soon fly to the palace.""*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""And I am here with someone who has been longing to speak with you for months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I heard the faint voice of a woman in the background."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "She laughed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""No matter what, you are safe now.""*)
  - -> `[68]` (*Player_Romus: ""Are you hurt? Did your captors hurt you?""*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you hurt? Did your captors hurt you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Vina Toras: ""No, I'm fine. They didn't dare lay a finger on the Crown..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I swear it on the name of House Toras. They will pay in blood.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Vina Toras: ""War is war, Father. I'm sure Rizia would have done the s..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""I swear it on the name of House Toras. They will pay in ..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""I will make sure that your captors will be punished acco..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what, you are safe now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Vina Toras: ""You don't know how good it is to hear your voice. After ..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will make sure that your captors will be punished accordingly.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Vina Toras: ""It's Duke Reinhart you should punish. Everyone else was ..."*)

### Węzeł `[75]`
Mówca: **Vina Toras**
> ""You don't know how good it is to hear your voice. After all this time in captivity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Vina Toras: ""Listen, we have to go now.""*)

### Węzeł `[76]`
Mówca: **Vina Toras**
> ""No, I'm fine. They didn't dare lay a finger on the Crown Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Vina Toras: ""Listen, we have to go now.""*)

### Węzeł `[77]`
Mówca: **Vina Toras**
> ""War is war, Father. I'm sure Rizia would have done the same or worse if we'd captured Duke Reinhart...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Vina Toras: ""Listen, we have to go now.""*)

### Węzeł `[78]`
Mówca: **Vina Toras**
> ""It's Duke Reinhart you should punish. Everyone else was just following his orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Vina Toras: ""Listen, we have to go now.""*)

### Węzeł `[79]`
Mówca: **Vina Toras**
> ""Listen, we have to go now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Vina Toras: ""I'll see you in the morning, all right?""*)

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""I'll see you in the morning, all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Vina Toras: ""Father?""*)

### Węzeł `[81]`
Mówca: **Vina Toras**
> ""Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Yes?""*)
  - -> `[83]` (*Player_Romus: ""What is it?""*)
  - -> `[84]` (*Player_Romus: ""Tell me.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC...."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC...."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC...."*)

### Węzeł `[85]`
Mówca: **Vina Toras**
> ""I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Before I could respond, the line dropped."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Before I could respond, the line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "I put down the receiver and sat on the bed, my head still abuzz with the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");
RemoveConversant("Hugo Toras"); RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");
RemoveConversant("Hugo Toras");
RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Vina Toras: ""Father. It's me! Vina!""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I put down the receiver and sat on the bed, my head still..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I did not hear the rest of it. All I heard was the ringin..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Rescued = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Rescued"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Welcoming their daughter back from capti..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Died = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_VinaRescueOutcome_Died"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The ringing sound felt off for some reason. I knew someth..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras"); RemoveConversant("Hugo Toras..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "I was in bed next to Lucita when the private phone in my ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "I was in bed next to Lucita when the private phone in my living quarters rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I knew that if someone was calling at this hour, somethin..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Vina Toras: ""I forgive you. For everything.""*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Vina Toras: ""I love you.""*)

### Węzeł `[106]`
Mówca: **Vina Toras**
> ""I forgive you. For everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Before I could respond, the line dropped."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""Romus? What happened?""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""Romus? What happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "My wife's voice sounded like it was coming from miles away."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "My wife's voice sounded like it was coming from miles away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "It was all in vain. Everything. My life. The crown."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Just then, Pabel rushed into my quarters."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "It was all in vain. Everything. My life. The crown."*)

### Węzeł `[115]`
Mówca: **Pabel Adria**
> ""I heard a noise. Is everything all right, {RiziaDLCText.PabelToPlayer}?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "My lover's voice sounded like it was coming from miles away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "It was all in vain. Everything. My life. The crown."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Just then, Pabel rushed into my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Pabel Adria: ""I heard a noise. Is everything all right, {RiziaDLCText...."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "My butler's voice sounded like it was coming from miles away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "It was all in vain. Everything. My life. The crown."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC...."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDL..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Vina Toras: ""Now that this ordeal is behind us, do Manus and I finall..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[123]`
Mówca: **Vina Toras**
> ""Now that this ordeal is behind us, do Manus and I finally have your permission to marry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesIn..."*)
  - -> `[143]` (*Player_Romus: ""I'm afraid much has changed in Rizia since you were take..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesIn..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_Dies..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""Manus is still fighting, sweetheart. We'll have this con..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true || RiziaDLC.Manus_Arrested ==..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus is still fighting, sweetheart. We'll have this conversation if he returns.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Vina Toras: ""When, Father. Not if.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true || RiziaDLC.Manus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true || RiziaDLC.Manus_Arrested ==..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true || RiziaDLC.Manus_Arrested ..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true || RiziaDLC.Manus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""Oh. Nobody told you.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true || RiziaDLC.Manus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""Yes, of course. If anyone deserves to be happy, it's you..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Relati..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. Nobody told you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true` AND `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "A tremor appeared in her voice."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "A tremor appeared in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Vina Toras: ""Told me what?""*)

### Węzeł `[133]`
Mówca: **Vina Toras**
> ""Told me what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Vina Toras: ""We really do have to go. But this conversation is not ov..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, of course. If anyone deserves to be happy, it's you two.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false` AND `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus = true;  RiziaDLC.Re..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus = true; 
RiziaDLC.Relations_Vina += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "She gave a barely contained shriek of joy."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Relati..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Rela..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Sure, why not? I'm a married man myself these days.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, why not? I'm a married man myself these days.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false` AND `(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false` AND `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "She laughed uneasily."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "She laughed uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Vina Toras: ""I know. I heard the guards gossiping.""*)

### Węzeł `[141]`
Mówca: **Vina Toras**
> ""I know. I heard the guards gossiping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus = true;  RiziaDLC.Re..."*)

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""When, Father. Not if.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Vina Toras: ""Listen...""*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid much has changed in Rizia since you were taken hostage. Pairing you off with Manus is no longer a possibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "A tremor appeared in her voice."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "A tremor appeared in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Vina Toras: ""It isn't?""*)

### Węzeł `[145]`
Mówca: **Vina Toras**
> ""It isn't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Vina Toras: ""We really do have to go. But this conversation is not ov..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "She gave a barely contained shriek of joy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""Oh, I can't wait to be home! Thank you!""*)

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""Oh, I can't wait to be home! Thank you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Vina Toras: ""Listen...""*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus = true; 
RiziaDLC.Relations_Vina += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Vina Toras: ""Congratulations, I guess. And thank you.""*)

### Węzeł `[149]`
Mówca: **Vina Toras**
> ""Congratulations, I guess. And thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Vina Toras: ""Listen...""*)

### Węzeł `[150]`
Mówca: **Vina Toras**
> ""We really do have to go. But this conversation is not over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Before I could respond, the line dropped."*)

### Węzeł `[151]`
Mówca: **Vina Toras**
> ""Listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[152]`
Mówca: **Vina Toras**
> ""Listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_RescuedVina");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_RescuedVina");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "I could feel my knees go weak. It was really her."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Rescue_Failed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Rescue_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus_Italic: "Pick up the phone."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus_Italic: "Pick up the phone."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Romus_Italic**
> "I picked up the phone. It was General Carlos Azaro."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true` AND `Variable["RiziaDLC.Vina_Rescue_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Carlos Robles Azaro: ""Your Majesty… I apologize for the late hour.”"*)

### Węzeł `[160]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty… I apologize for the late hour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""What is it?""*)
  - -> `[54]` (*Player_Romus: ""What happened?""*)
  - -> `[55]` (*Player_Romus: ""Yes?""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Carlos Robles Azaro: ""I was supervising our troops near the border when I got ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""I was handling crown matters near the border when I rece..."*)

### Węzeł `[164]`
Mówca: **Carlos Robles Azaro**
> ""I was supervising our troops near the border when I got word that Princess Vina and her rescuers had arrived from the front lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Carlos Robles Azaro: ""And I am here with someone who's been eager to speak wit..."*)

### Węzeł `[165]`
Mówca: **Carlos Robles Azaro**
> ""And I am here with someone who's been eager to speak with you for months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I heard the faint voice of a woman in the background."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus_Italic: "Pick up the phone."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus_Italic: "Pick up the phone."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Romus_Italic**
> "I picked up the phone. It was General Carlos Azaro."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Carlos Robles Azaro: ""Your Majesty… I apologize for the late hour.”"*)

### Węzeł `[171]`
Mówca: **Carlos Robles Azaro**
> ""Your Majesty… I apologize for the late hour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""What is it?""*)
  - -> `[13]` (*Player_Romus: ""What happened?""*)
  - -> `[14]` (*Player_Romus: ""Yes?""*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Carlos Robles Azaro: ""I suggest sitting down if you're not already."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[175]`
Mówca: **Carlos Robles Azaro**
> ""I suggest sitting down if you're not already."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Carlos Robles Azaro: ""What I have to share won’t be easy to hear.""*)

### Węzeł `[176]`
Mówca: **Carlos Robles Azaro**
> ""What I have to share won’t be easy to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""What do you mean?""*)
  - -> `[23]` (*Player_Romus_Italic: "Sit down on the bed."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Carlos Robles Azaro: ""Please listen closely, Your Majesty.""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""Listen to me very carefully, Romus.""*)

### Węzeł `[180]`
Mówca: **Carlos Robles Azaro**
> ""Please listen closely, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Carlos Robles Azaro: ""I just received news from the frontline...""*)

### Węzeł `[181]`
Mówca: **Carlos Robles Azaro**
> ""I just received news from the frontline...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Carlos Robles Azaro: ""About the princess.""*)

### Węzeł `[182]`
Mówca: **Carlos Robles Azaro**
> ""About the princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arreste..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Carlos Robles Azaro: ""I regret to report, Your Majesty, that Princess Vina did..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""It breaks my heart to inform you that your daughter, our..."*)

### Węzeł `[186]`
Mówca: **Carlos Robles Azaro**
> ""I regret to report, Your Majesty, that Princess Vina did not survive her captivity in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Carlos Robles Azaro: ""I am sorry, Your Majesty. I never--""*)

### Węzeł `[187]`
Mówca: **Carlos Robles Azaro**
> ""I am sorry, Your Majesty. I never--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Rescue_Failed = true;"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I did not hear the rest of it. All I heard was the ringin..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Rescue_Failed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Rescue_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Carlos Robles Azaro");"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""It's not my decision anymore. You'll have to ask Prime M..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""You don't have to ask me, Vina. You're free to do whatev..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not my decision anymore. You'll have to ask Prime Minister Sazon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true` AND `(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false` AND `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus = true;  RiziaDLC.Re..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus = true; 
RiziaDLC.Relations_Vina += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "She gave a barely contained shriek of joy."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "She gave a barely contained shriek of joy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Vina Toras: ""This is incredible! I can't wait to get home.""*)

### Węzeł `[196]`
Mówca: **Vina Toras**
> ""This is incredible! I can't wait to get home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Vina Toras: ""Listen...""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to ask me, Vina. You're free to do whatever you want.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false` AND `(Variable["RiziaDLC.Manus_Gone"] == true  or  Variable["RiziaDLC.Manus_Arrested"] == true) == false` AND `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus = true;  RiziaDLC.Re..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Pabel Adria: ""Rom? What's happening?""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "I was in bed next to Pabel when the private phone in my l..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I was preparing to sleep when the private phone in my liv..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "I was in bed next to Pabel when the private phone in my living quarters rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I knew that if someone was calling at this hour, somethin..."*)

### Węzeł `[205]`
Mówca: **Pabel Adria**
> ""Rom? What's happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "My lover's voice sounded like it was coming from miles away."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "My lover's voice sounded like it was coming from miles away."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "My butler's voice sounded like it was coming from miles a..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Bruno rushed to my side and licked my face. I hugged him ..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Welcoming their daughter back from captivity", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Welcoming their daughter back from captivity","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true || RiziaDLC.Hugo_Arrested ..."*)
