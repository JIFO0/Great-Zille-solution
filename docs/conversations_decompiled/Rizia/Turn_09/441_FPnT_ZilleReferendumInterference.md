# Rizia/Turn 9/FPnT_ZilleReferendumInterference

- **ID konwersacji:** `441`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/441_FPnT_ZilleReferendumInterference.md`
- **Liczba węzłów dialogowych:** 309
- **Liczba wyborów gracza:** 15

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Resources_Military_RumburgianBFFMercenaries`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail`
- `RiziaDLC.ZilleReferendum_Interfere_Army`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Fail`
- `RiziaDLC.ZilleReferendum_Won`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.CountryRelation_Wehlen_Hostile`
- `RiziaDLC.CountryRelation_Wehlen_Unfriendly`
- `RiziaDLC.Policy_Diplomacy_ZLLAActive`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLC.ZilleReferendum_Independence`
- `RiziaDLC.ZilleReferendum_Independence_Bludish`
- `RiziaDLC.ZilleReferendum_Independence_Golcondist`
- `RiziaDLC.ZilleReferendum_Independence_Liberation`
- `RiziaDLC.ZilleReferendum_Independence_Wruhecist`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Success`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Fail`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Success`
- `RiziaDLC.ZilleReferendum_Lost`
- `RiziaDLC.ZilleReferendum_Won`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Fail`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Success`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Fail`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Success`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won`
- `RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered`
- `RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony`
- `RiziaDLCText.IndependentZille`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[22]` | **""Come in.""** | `[21]` **Narrator**: "There was a knock on the door. I..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Lucita Azaro");`<br>`AddConversant("Taddeus Azaro");`<br>*(+1 skryptów)* | `[41]` **Narrator**: "Lucita entered the room again."<br>`[42]` **Narrator**: "Taddeus entered the room again."<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **""You'd better bring me good news.""** | `[21]` **Narrator**: "There was a knock on the door. I..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Lucita Azaro");`<br>`AddConversant("Taddeus Azaro");`<br>*(+1 skryptów)* | `[41]` **Narrator**: "Lucita entered the room again."<br>`[42]` **Narrator**: "Taddeus entered the room again."<br>*(oraz 1 innych odgałęzień)* |
| `[24]` | **""Can someone open that?""** | `[21]` **Narrator**: "There was a knock on the door. I..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Lucita Azaro");`<br>`AddConversant("Taddeus Azaro");`<br>*(+1 skryptów)* | `[41]` **Narrator**: "Lucita entered the room again."<br>`[42]` **Narrator**: "Taddeus entered the room again."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **""Yes?""** | `[21]` **Narrator**: "There was a knock on the door. I..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Lucita Azaro");`<br>`AddConversant("Taddeus Azaro");`<br>*(+1 skryptów)* | `[41]` **Narrator**: "Lucita entered the room again."<br>`[42]` **Narrator**: "Taddeus entered the room again."<br>*(oraz 1 innych odgałęzień)* |
| `[139]` | **""Thank you. At least we tried.""** | `[141]` **Lucita Azaro**: ""Forgive me, Your Majesty.""<br>`[142]` **Taddeus Azaro**: ""Forgive me, Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Lucita Azaro**: ""As you say, Your Majesty.""<br>`[149]` **Taddeus Azaro**: ""As you say, Your Majesty.""<br>*(oraz 1 innych odgałęzień)* |
| `[140]` | **""You are all incompetent! You can't even do anything right!""** | `[141]` **Lucita Azaro**: ""Forgive me, Your Majesty.""<br>`[142]` **Taddeus Azaro**: ""Forgive me, Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Lucita Azaro**: ""I am very sorry, Your Majesty.""<br>`[167]` **Taddeus Azaro**: ""I am very sorry, Your Majesty.""<br>*(oraz 1 innych odgałęzień)* |
| `[144]` | **""I am the one to blame. Responsibility of this lies with me alone.""** | `[141]` **Lucita Azaro**: ""Forgive me, Your Majesty.""<br>`[142]` **Taddeus Azaro**: ""Forgive me, Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Lucita Azaro**: ""I can't let you take the whole ..."<br>`[158]` **Taddeus Azaro**: ""I can't let you take the whole ..."<br>*(oraz 1 innych odgałęzień)* |
| `[145]` | **""You better be right. For your own sake.""** | `[101]` **Lucita Azaro**: ""We will get Zille no matter wha..."<br>`[104]` **Taddeus Azaro**: ""We will get Zille no matter wha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucita Azaro**: ""It will be. Wait and see, Your ..."<br>`[185]` **Taddeus Azaro**: ""It will be. Wait and see, Your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[146]` | **""We will get it. I am sure of it.""** | `[101]` **Lucita Azaro**: ""We will get Zille no matter wha..."<br>`[104]` **Taddeus Azaro**: ""We will get Zille no matter wha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Lucita Azaro**: ""I made sure of that, Your Majes..."<br>`[197]` **Taddeus Azaro**: ""I made sure of that, Your Majes..."<br>*(oraz 1 innych odgałęzień)* |
| `[147]` | **""Excellent! I knew I could trust you with this task.""** | `[101]` **Lucita Azaro**: ""We will get Zille no matter wha..."<br>`[104]` **Taddeus Azaro**: ""We will get Zille no matter wha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Lucita Azaro**: ""Thank you for your trust, Your ..."<br>`[176]` **Taddeus Azaro**: ""Thank you for your trust, Your ..."<br>*(oraz 1 innych odgałęzień)* |
| `[226]` | **"Turn on the TV."** | `[222]` **Laurento Esquibel**: ""Please turn on the television."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleReferendum_Independence"] = true;...` | `[231]` **Narrator**: "Smolak was making an official st..."<br>`[260]` **Narrator**: "A burst of static gave way to th..." |
| `[236]` | **""I trust that you will handle it accordingly, Laurento.""** | `[235]` **Laurento Esquibel**: ""This will impact our public ima..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Laurento Esquibel**: ""I will get to work immediately."" |
| `[237]` | **""Who cares about Smolak? Zille is ours again.""** | `[235]` **Laurento Esquibel**: ""This will impact our public ima..." | `Variable["RiziaDLC.ZilleReferendum_Won"] == true` | *Brak zmian stanu* | `[240]` **Narrator**: "Laurento fell silent as we both ..." |
| `[238]` | **""He will know my vengeance. I swear it.""** | `[235]` **Laurento Esquibel**: ""This will impact our public ima..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Narrator**: "Laurento fell silent as we both ..." |
| `[282]` | **""Who cares about Smolak? Zille is lost.""** | `[235]` **Laurento Esquibel**: ""This will impact our public ima..." | `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false` | *Brak zmian stanu* | `[240]` **Narrator**: "Laurento fell silent as we both ..." |

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
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Interfering with a democratic referendum..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was pacing back and forth in the Jales mansion, waiting to hear the results of the army deployment in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "There was a knock on the door. I composed myself."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I was pacing back and forth in the Jales mansion, waiting..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I was pacing back and forth in the Jales mansion, waiting..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I was pacing back and forth in the Jales mansion, waiting to hear the results of our agents' interference in the Zille referendum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "There was a knock on the door. I composed myself."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diploma..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diploma..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplo..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success = true; R..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Fail = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Fail = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Fail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Success = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective ..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Ineffectiv..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success = true;..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Fail = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Fail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Success = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Success"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "There was a knock on the door. I composed myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Yes?""*)
  - -> `[22]` (*Player_Romus: ""Come in.""*)
  - -> `[23]` (*Player_Romus: ""You'd better bring me good news.""*)
  - -> `[24]` (*Player_Romus: ""Can someone open that?""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better bring me good news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can someone open that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""Our troops entered Zille immediately after I gave the or..."*)

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Taddeus Azaro: ""Our troops entered Zille immediately after I gave the or..."*)

### Węzeł `[28]`
Mówca: **Titus Gordion**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Titus Gordion: ""Our troops entered Zille immediately after I gave the or..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucita Azaro: ""I am afraid I have bad news.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""I am afraid I have bad news.""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Titus Gordion: ""I am afraid I have bad news.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro");"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Lucita entered the room again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucita Azaro: ""Your Majesty.""*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Taddeus entered the room again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Taddeus Azaro: ""Your Majesty.""*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Titus entered the room again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Titus Gordion: ""Your Majesty.""*)

### Węzeł `[44]`
Mówca: **Lucita Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[45]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[46]`
Mówca: **Titus Gordion**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""You can relax. I've brought good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""Our troops entered Zille immediately after I gave the or..."*)

### Węzeł `[54]`
Mówca: **Taddeus Azaro**
> ""I have good news, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Taddeus Azaro: ""Our troops entered Zille immediately after I gave the or..."*)

### Węzeł `[55]`
Mówca: **Titus Gordion**
> ""I have good news for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Titus Gordion: ""Our troops entered Zille immediately after I gave the or..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucita Azaro: ""You can relax. I've brought good news.""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Taddeus Azaro: ""I have good news, sire.""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Titus Gordion: ""I have good news for you.""*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucita Azaro: ""We have activated all active personnel deployed in Zille..."*)

### Węzeł `[66]`
Mówca: **Taddeus Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Taddeus Azaro: ""We have activated all active personnel deployed in Zille..."*)

### Węzeł `[67]`
Mówca: **Titus Gordion**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Titus Gordion: ""We have activated all active personnel deployed in Zille..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucita Azaro: ""I am afraid I have bad news.""*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Taddeus Azaro: ""I am afraid I have bad news.""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Titus Gordion: ""I am afraid I have bad news.""*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""You can relax, Your Majesty. I bring good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucita Azaro: ""We have activated all active personnel deployed in Zille..."*)

### Węzeł `[75]`
Mówca: **Taddeus Azaro**
> ""You can relax, Your Majesty. I bring good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Taddeus Azaro: ""We have activated all active personnel deployed in Zille..."*)

### Węzeł `[76]`
Mówca: **Titus Gordion**
> ""You can relax, Your Majesty. I bring good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Titus Gordion: ""We have activated all active personnel deployed in Zille..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""You can relax, Your Majesty. I bring good news.""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Taddeus Azaro: ""You can relax, Your Majesty. I bring good news.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Titus Gordion: ""You can relax, Your Majesty. I bring good news.""*)

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucita Azaro: ""The Wehzek troops fell back as soon as we entered. We st..."*)

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""Then the unthinkable happened. The citizens themselves s..."*)

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""Then the unthinkable happened. The citizens themselves started to push our soldiers back. There was heavy fighting in some areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucita Azaro: ""As the Wehzek troops were falling back, they intentional..."*)

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""As the Wehzek troops were falling back, they intentionally gave all of their equipment to the civilians of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucita Azaro: ""Our soldiers had to fall back from the election centers ..."*)

### Węzeł `[87]`
Mówca: **Lucita Azaro**
> ""Our soldiers had to fall back from the election centers to regroup. Unfortunately, we were no longer able to shield the referendum from Wehlen's interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucita Azaro: ""Forgive me, Your Majesty.""*)

### Węzeł `[88]`
Mówca: **Taddeus Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Taddeus Azaro: ""The Wehzek troops fell back as soon as we entered. We st..."*)

### Węzeł `[89]`
Mówca: **Taddeus Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Taddeus Azaro: ""Then the unthinkable happened. The citizens themselves s..."*)

### Węzeł `[90]`
Mówca: **Taddeus Azaro**
> ""Then the unthinkable happened. The citizens themselves started to push our soldiers back. There was heavy fighting in some areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Taddeus Azaro: ""As the Wehzek troops were falling back, they intentional..."*)

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""As the Wehzek troops were falling back, they intentionally gave all of their equipment to the civilians of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Taddeus Azaro: ""Our soldiers had to fall back from the election centers ..."*)

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""Our soldiers had to fall back from the election centers to regroup. Unfortunately, we were no longer able to shield the referendum from Wehlen's interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Taddeus Azaro: ""Forgive me, Your Majesty.""*)

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""The Wehzek troops fell back as soon as we entered. We st..."*)

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Titus Gordion: ""Then the unthinkable happened. The citizens themselves s..."*)

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""Then the unthinkable happened. The citizens themselves started to push our soldiers back. There was heavy fighting in some areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Titus Gordion: ""As the Wehzek troops were falling back, they intentional..."*)

### Węzeł `[96]`
Mówca: **Titus Gordion**
> ""As the Wehzek troops were falling back, they intentionally gave all of their equipment to the civilians of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Titus Gordion: ""Our soldiers had to fall back from the election centers ..."*)

### Węzeł `[97]`
Mówca: **Titus Gordion**
> ""Our soldiers had to fall back from the election centers to regroup. Unfortunately, we were no longer able to shield the referendum from Wehlen's interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Titus Gordion: ""Forgive me, Your Majesty.""*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""The Wehzek troops fell back as soon as we entered. We st..."*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""We are currently stationed at every single voting center. Our votes are protected. We can be sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucita Azaro: ""We will get Zille no matter what. I assure you.""*)

### Węzeł `[101]`
Mówca: **Lucita Azaro**
> ""We will get Zille no matter what. I assure you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""Excellent! I knew I could trust you with this task.""*)
  - -> `[145]` (*Player_Romus: ""You better be right. For your own sake.""*)
  - -> `[146]` (*Player_Romus: ""We will get it. I am sure of it.""*)

### Węzeł `[102]`
Mówca: **Taddeus Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Taddeus Azaro: ""The Wehzek troops fell back as soon as we entered. We st..."*)

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)

### Węzeł `[104]`
Mówca: **Taddeus Azaro**
> ""We will get Zille no matter what. I assure you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""Excellent! I knew I could trust you with this task.""*)
  - -> `[145]` (*Player_Romus: ""You better be right. For your own sake.""*)
  - -> `[146]` (*Player_Romus: ""We will get it. I am sure of it.""*)

### Węzeł `[105]`
Mówca: **Titus Gordion**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Titus Gordion: ""The Wehzek troops fell back as soon as we entered. We st..."*)

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)

### Węzeł `[107]`
Mówca: **Titus Gordion**
> ""We are currently stationed at every single voting center. Our votes are protected. We can be sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""We will get Zille no matter what. I assure you.""*)

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""We will get Zille no matter what. I assure you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""Excellent! I knew I could trust you with this task.""*)
  - -> `[145]` (*Player_Romus: ""You better be right. For your own sake.""*)
  - -> `[146]` (*Player_Romus: ""We will get it. I am sure of it.""*)

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""They took control of the central election facility where..."*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucita Azaro: ""We have also intercepted many trucks carrying votes. The..."*)

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucita Azaro: ""Unfortunately during the simultaneous raids, the police ..."*)

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""Unfortunately during the simultaneous raids, the police in Zille managed to identify some of our agents who led them to other agents, uncovering the web.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucita Azaro: ""Public has been made aware of our interference and now t..."*)

### Węzeł `[113]`
Mówca: **Lucita Azaro**
> ""Public has been made aware of our interference and now they are blaming us for our meddling. This will significantly impact the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucita Azaro: ""Forgive me, Your Majesty.""*)

### Węzeł `[114]`
Mówca: **Taddeus Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Taddeus Azaro: ""They took control of the central election facility where..."*)

### Węzeł `[115]`
Mówca: **Taddeus Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Taddeus Azaro: ""We have also intercepted many trucks carrying votes. The..."*)

### Węzeł `[116]`
Mówca: **Taddeus Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Taddeus Azaro: ""Unfortunately during the simultaneous raids, the police ..."*)

### Węzeł `[117]`
Mówca: **Taddeus Azaro**
> ""Unfortunately during the simultaneous raids, the police in Zille managed to identify some of our agents who led them to other agents, uncovering the web.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Taddeus Azaro: ""Public has been made aware of our interference and now t..."*)

### Węzeł `[118]`
Mówca: **Taddeus Azaro**
> ""Public has been made aware of our interference and now they are blaming us for our meddling. This will significantly impact the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Taddeus Azaro: ""Forgive me, Your Majesty.""*)

### Węzeł `[119]`
Mówca: **Titus Gordion**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Titus Gordion: ""They took control of the central election facility where..."*)

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Titus Gordion: ""We have also intercepted many trucks carrying votes. The..."*)

### Węzeł `[121]`
Mówca: **Titus Gordion**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Titus Gordion: ""Unfortunately during the simultaneous raids, the police ..."*)

### Węzeł `[122]`
Mówca: **Titus Gordion**
> ""Unfortunately during the simultaneous raids, the police in Zille managed to identify some of our agents who led them to other agents, uncovering the web.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Titus Gordion: ""Public has been made aware of our interference and now t..."*)

### Węzeł `[123]`
Mówca: **Titus Gordion**
> ""Public has been made aware of our interference and now they are blaming us for our meddling. This will significantly impact the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Titus Gordion: ""Forgive me, Your Majesty.""*)

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucita Azaro: ""They took control of the central election facility where..."*)

### Węzeł `[125]`
Mówca: **Lucita Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""We have also intercepted many trucks carrying votes. The..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""No one will not even realize that we were behind the cha..."*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""No one will not even realize that we were behind the change in votes. The infiltration has been a major success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucita Azaro: ""In addition, our agents planted various false evidences ..."*)

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""In addition, our agents planted various false evidences to point at Wehlen interference to shift away any potential blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucita Azaro: ""We will get Zille no matter what. I assure you.""*)

### Węzeł `[129]`
Mówca: **Taddeus Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Taddeus Azaro: ""They took control of the central election facility where..."*)

### Węzeł `[130]`
Mówca: **Taddeus Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Taddeus Azaro: ""We have also intercepted many trucks carrying votes. The..."*)

### Węzeł `[131]`
Mówca: **Taddeus Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Taddeus Azaro: ""No one will not even realize that we were behind the cha..."*)

### Węzeł `[132]`
Mówca: **Taddeus Azaro**
> ""No one will not even realize that we were behind the change in votes. The infiltration has been a major success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Taddeus Azaro: ""In addition, our agents planted various false evidences ..."*)

### Węzeł `[133]`
Mówca: **Taddeus Azaro**
> ""In addition, our agents planted various false evidences to point at Wehlen interference to shift away any potential blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Taddeus Azaro: ""We will get Zille no matter what. I assure you.""*)

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Titus Gordion: ""They took control of the central election facility where..."*)

### Węzeł `[135]`
Mówca: **Titus Gordion**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Titus Gordion: ""We have also intercepted many trucks carrying votes. The..."*)

### Węzeł `[136]`
Mówca: **Titus Gordion**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Titus Gordion: ""No one will not even realize that we were behind the cha..."*)

### Węzeł `[137]`
Mówca: **Titus Gordion**
> ""No one will not even realize that we were behind the change in votes. The infiltration has been a major success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""In addition, our agents planted various false evidences ..."*)

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""In addition, our agents planted various false evidences to point at Wehlen interference to shift away any potential blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""We will get Zille no matter what. I assure you.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. At least we tried.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucita Azaro), `[142]` (Taddeus Azaro), `[143]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are all incompetent! You can't even do anything right!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucita Azaro), `[142]` (Taddeus Azaro), `[143]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Thank you. At least we tried.""*)
  - -> `[144]` (*Player_Romus: ""I am the one to blame. Responsibility of this lies with ..."*)
  - -> `[140]` (*Player_Romus: ""You are all incompetent! You can't even do anything right!""*)

### Węzeł `[142]`
Mówca: **Taddeus Azaro**
> ""Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Thank you. At least we tried.""*)
  - -> `[144]` (*Player_Romus: ""I am the one to blame. Responsibility of this lies with ..."*)
  - -> `[140]` (*Player_Romus: ""You are all incompetent! You can't even do anything right!""*)

### Węzeł `[143]`
Mówca: **Titus Gordion**
> ""Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Thank you. At least we tried.""*)
  - -> `[144]` (*Player_Romus: ""I am the one to blame. Responsibility of this lies with ..."*)
  - -> `[140]` (*Player_Romus: ""You are all incompetent! You can't even do anything right!""*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the one to blame. Responsibility of this lies with me alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucita Azaro), `[142]` (Taddeus Azaro), `[143]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You better be right. For your own sake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Lucita Azaro), `[104]` (Taddeus Azaro), `[108]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will get it. I am sure of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Lucita Azaro), `[104]` (Taddeus Azaro), `[108]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent! I knew I could trust you with this task.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Lucita Azaro), `[104]` (Taddeus Azaro), `[108]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[149]`
Mówca: **Taddeus Azaro**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[150]`
Mówca: **Titus Gordion**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucita Azaro: ""As you say, Your Majesty.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Taddeus Azaro: ""As you say, Your Majesty.""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Titus Gordion: ""As you say, Your Majesty.""*)

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""I can't let you take the whole blame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[158]`
Mówca: **Taddeus Azaro**
> ""I can't let you take the whole blame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""I can't let you take the whole blame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucita Azaro: ""I can't let you take the whole blame, Your Majesty.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Taddeus Azaro: ""I can't let you take the whole blame, Your Majesty.""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Titus Gordion: ""I can't let you take the whole blame, Your Majesty.""*)

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""I am very sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[167]`
Mówca: **Taddeus Azaro**
> ""I am very sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[168]`
Mówca: **Titus Gordion**
> ""I am very sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucita Azaro: ""I am very sorry, Your Majesty.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Taddeus Azaro: ""I am very sorry, Your Majesty.""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Titus Gordion: ""I am very sorry, Your Majesty.""*)

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""Thank you for your trust, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[176]`
Mówca: **Taddeus Azaro**
> ""Thank you for your trust, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[177]`
Mówca: **Titus Gordion**
> ""Thank you for your trust, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucita Azaro: ""Thank you for your trust, Your Majesty.""*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Taddeus Azaro: ""Thank you for your trust, Your Majesty.""*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Titus Gordion: ""Thank you for your trust, Your Majesty.""*)

### Węzeł `[184]`
Mówca: **Lucita Azaro**
> ""It will be. Wait and see, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[185]`
Mówca: **Taddeus Azaro**
> ""It will be. Wait and see, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[186]`
Mówca: **Titus Gordion**
> ""It will be. Wait and see, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucita Azaro: ""It will be. Wait and see, Your Majesty.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Taddeus Azaro: ""It will be. Wait and see, Your Majesty.""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Titus Gordion: ""It will be. Wait and see, Your Majesty.""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Taddeus Azaro: ""I made sure of that, Your Majesty.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Titus Gordion: ""I made sure of that, Your Majesty.""*)

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""I made sure of that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[197]`
Mówca: **Taddeus Azaro**
> ""I made sure of that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[198]`
Mówca: **Titus Gordion**
> ""I made sure of that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The door opened and Laurento entered the room."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Lucita Azaro: ""I made sure of that, Your Majesty.""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[202]`
Mówca: **Narrator**
> "The door opened and Laurento entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel");"*)

### Węzeł `[203]`
Mówca: **Narrator**
> "He was holding a sheet of paper above his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Laurento Esquibel: ""Your Majesty, the results are here.""*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army == true)"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Jou..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Jou..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[213]`
Mówca: **Laurento Esquibel**
> ""But there's been another development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Laurento Esquibel: ""Please turn on the television.""*)

### Węzeł `[214]`
Mówca: **Laurento Esquibel**
> ""Unfortunately, we lost the referendum by a landslide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Laurento Esquibel: ""It seems like people reacted very strongly against the a..."*)

### Węzeł `[215]`
Mówca: **Laurento Esquibel**
> ""Votes are 64% in favor of joining Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Laurento Esquibel: ""But there's been another development.""*)

### Węzeł `[216]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, the results are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[217]`
Mówca: **Laurento Esquibel**
> ""We won the referendum by a landslide thanks to the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Laurento Esquibel: ""Votes are 82% in favor of joining Rizia.""*)

### Węzeł `[218]`
Mówca: **Laurento Esquibel**
> ""Votes are 82% in favor of joining Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Laurento Esquibel: ""But there's been another development.""*)

### Węzeł `[219]`
Mówca: **Laurento Esquibel**
> ""Unfortunately, we lost the referendum by a landslide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Laurento Esquibel: ""It seems like people reacted very strongly against the n..."*)

### Węzeł `[220]`
Mówca: **Laurento Esquibel**
> ""It seems like people reacted very strongly against the army coming in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Laurento Esquibel: ""Votes are 64% in favor of joining Wehlen.""*)

### Węzeł `[221]`
Mówca: **Laurento Esquibel**
> ""It seems like people reacted very strongly against the news of interference by Rizian-backed agents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Laurento Esquibel: ""Votes are 92% in favor of joining Wehlen.""*)

### Węzeł `[222]`
Mówca: **Laurento Esquibel**
> ""Please turn on the television.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus_Italic: "Turn on the TV."*)

### Węzeł `[223]`
Mówca: **Laurento Esquibel**
> ""We won the referendum by a landslide thanks to the agents we activated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Laurento Esquibel: ""Votes are 72% in favor of joining Rizia.""*)

### Węzeł `[224]`
Mówca: **Laurento Esquibel**
> ""Votes are 72% in favor of joining Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Laurento Esquibel: ""But there's been another development.""*)

### Węzeł `[225]`
Mówca: **Laurento Esquibel**
> ""Votes are 92% in favor of joining Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Laurento Esquibel: ""But there's been another development.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "Turn on the TV."]** — Mówca: **Player_Romus_Italic**
> "I turned on the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Lost"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Laurento Esquibel: ""Unfortunately, we lost the referendum by a landslide.""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Won"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Laurento Esquibel: ""We won the referendum by a landslide thanks to the army.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Lost"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Laurento Esquibel: ""Unfortunately, we lost the referendum by a landslide.""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Won"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Laurento Esquibel: ""We won the referendum by a landslide thanks to the agent..."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "Smolak was making an official state address, blaming Rizia for interfering in the democratic election process."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Laurento Esquibel: ""This will impact our public image heavily, Your Majesty.""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence = true; RiziaDLC.Co..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Smolak was making an official state address, blaming Rizi..."*)

### Węzeł `[235]`
Mówca: **Laurento Esquibel**
> ""This will impact our public image heavily, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Romus: ""I trust that you will handle it accordingly, Laurento.""*)
  - -> `[238]` (*Player_Romus: ""He will know my vengeance. I swear it.""*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust that you will handle it accordingly, Laurento.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Laurento Esquibel: ""I will get to work immediately.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about Smolak? Zille is ours again.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Kontekst wejściowy (poprzednik):** `[235]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Laurento fell silent as we both absorbed the magnitude of..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He will know my vengeance. I swear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Laurento fell silent as we both absorbed the magnitude of..."*)

### Węzeł `[239]`
Mówca: **Laurento Esquibel**
> ""I will get to work immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Laurento fell silent as we both absorbed the magnitude of..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Laurento fell silent as we both absorbed the magnitude of what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Calls started ringing in every room."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "Calls started ringing in every room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "News traveled fast when it was bad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDisc..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Lucita entered the room again."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Taddeus entered the room again."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Titus entered the room again."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He was holding a sheet of paper above his head."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "He said that he was a representative of the 'Zille Liberation Front,' or ZLF."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Zille was to declare independence from Rizia and Wehlen t..."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen to establish a new state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "He finished by asking all revolutionaries of the world to..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence = true; RiziaDLC.CountryRelation_Wehlen_Unfriendly = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence"] = true;
Variable["RiziaDLC.CountryRelation_Wehlen_Unfriendly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "A burst of static gave way to the image of a man in a ski..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille ==..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He said that he was broadcasting from the 'Wruhecist Repu..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries ==..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "He said that he was broadcasting from the 'Bludish Republ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "He said that he was a representative of the 'Zille Libera..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == t..."*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille ==..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "He said that he was broadcasting from the 'Holy Golcondis..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[260]`
Mówca: **Narrator**
> "A burst of static gave way to the image of a man in a ski mask sitting on a table, reading from a paper in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == t..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "He said that he was broadcasting from the 'Bludish Republic of Zille.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "Zille was to declare independence from Rizia and Wehlen a..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen and establish a state for the Bludish people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He finished by asking all Bluds of the world to unite, to..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "He said that he was broadcasting from the 'Wruhecist Republic of Zille.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "Zille was to declare independence from Rizia and Wehlen a..."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen and establish a religious republic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "He finished by asking all Wruhecists of the world to unit..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "He said that he was broadcasting from the 'Holy Golcondist Protectorate of Zille.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Zille was to declare independence from Rizia and Wehlen a..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "His words sent a chill down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "I cursed and turned the TV off."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen and establish a religious theocracy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "The announcer finished by asking all Golcondists of the w..."*)

### Węzeł `[268]`
Mówca: **Narrator**
> "I cursed and turned the TV off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_FreeZille");"*)

### Węzeł `[269]`
Mówca: **Narrator**
> "The announcer finished by asking all Golcondists of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Golcondist = true; ..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "He finished by asking all Wruhecists of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Wruhecist = true; R..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "He finished by asking all Bluds of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Bludish = true; Riz..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "He finished by asking all revolutionaries of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Liberation = true; ..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Golcondist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist = true;
RiziaDLCText.IndependentZille = "Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille", "Theocratic Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille","Theocratic Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "His words sent a chill down my spine."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Wruhecist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist = true;
RiziaDLCText.IndependentZille = "Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille", "Religious Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille","Religious Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "His words sent a chill down my spine."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Bludish = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish = true;
RiziaDLCText.IndependentZille = "Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille", "Presidential Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille","Presidential Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "His words sent a chill down my spine."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Liberation = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation = true;
RiziaDLCText.IndependentZille = "Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille", "Parliamentary Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille","Parliamentary Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "His words sent a chill down my spine."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered = true;
RiziaDLC.CountryRelation_Wehlen_Hostile = true; RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered"] = true;
Variable["RiziaDLC.CountryRelation_Wehlen_Hostile"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Won == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player_Romus: ""Who cares about Smolak? Zille is ours again.""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player_Romus: ""Who cares about Smolak? Zille is lost.""*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about Smolak? Zille is lost.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[235]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Laurento fell silent as we both absorbed the magnitude of..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Won == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Good news traveled fast."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "News traveled fast when it was bad."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Good news traveled fast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDisc..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered = true;
RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony = true;
RiziaDLC.ZilleReturn_Success = true; RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.CountryRelation_Wehlen_Hostile = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony"] = true;
Variable["RiziaDLC.ZilleReturn_Success"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.CountryRelation_Wehlen_Hostile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistanc..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success = true; R..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Fail = true; Rizi..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && (RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true || RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistanc..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && (RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true || RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  (Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  or  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success = true;..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && (RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true || RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  (Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  or  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Fail = true; Ri..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucita Azaro: ""The local branch of Su Omina was exceptionally helpful i..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""We are currently stationed at every single voting center..."*)

### Węzeł `[297]`
Mówca: **Lucita Azaro**
> ""The local branch of Su Omina was exceptionally helpful in making sure they encountered no trouble on their way in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""We are currently stationed at every single voting center..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Taddeus Azaro: ""The local branch of Su Omina was exceptionally helpful i..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Taddeus Azaro: ""We are currently stationed at every single voting center..."*)

### Węzeł `[301]`
Mówca: **Taddeus Azaro**
> ""The local branch of Su Omina was exceptionally helpful in making sure they encountered no trouble on their way in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Taddeus Azaro: ""We are currently stationed at every single voting center..."*)

### Węzeł `[302]`
Mówca: **Taddeus Azaro**
> ""We are currently stationed at every single voting center. Our votes are protected. We can be sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Taddeus Azaro: ""We will get Zille no matter what. I assure you.""*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Titus Gordion: ""The local branch of Su Omina was exceptionally helpful i..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Titus Gordion: ""We are currently stationed at every single voting center..."*)

### Węzeł `[306]`
Mówca: **Titus Gordion**
> ""The local branch of Su Omina was exceptionally helpful in making sure they encountered no trouble on their way in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Titus Gordion: ""We are currently stationed at every single voting center..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_FreeZille");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_FreeZille");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Interfering with a democratic referendum", "Zille", "Wehlen");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Interfering with a democratic referendum","Zille","Wehlen");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)
