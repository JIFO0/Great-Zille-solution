# Rizia/Turn 9/FPnT_ZilleReferendum

- **ID konwersacji:** `448`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/448_FPnT_ZilleReferendum.md`
- **Liczba węzłów dialogowych:** 356
- **Liczba wyborów gracza:** 17

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
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RelationshipPublic`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Resources_Military_DerdianMercenaries`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Resources_Military_RumburgianBFFMercenaries`
- `RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance`
- `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement`
- `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement`
- `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Effective`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.ZilleReferendum_ArmedResistance`
- `RiziaDLC.ZilleReferendum_BothSidesClash`
- `RiziaDLC.ZilleReferendum_EarlyResult_Win`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_Drinking`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_Diplomacy_ZLLAActive`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLC.ZilleReferendum_ArmedResistance`
- `RiziaDLC.ZilleReferendum_BothSidesClash`
- `RiziaDLC.ZilleReferendum_EarlyResult_Win`
- `RiziaDLC.ZilleReferendum_Independence`
- `RiziaDLC.ZilleReferendum_Independence_Bludish`
- `RiziaDLC.ZilleReferendum_Independence_Golcondist`
- `RiziaDLC.ZilleReferendum_Independence_Liberation`
- `RiziaDLC.ZilleReferendum_Independence_Wruhecist`
- `RiziaDLC.ZilleReferendum_Interfere_Agents`
- `RiziaDLC.ZilleReferendum_Interfere_Army`
- `RiziaDLC.ZilleReferendum_Lost`
- `RiziaDLC.ZilleReferendum_Won`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents`
- `RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army`
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
| `[22]` | **""Thank you for letting me know, Laurento.""** | `[21]` **Narrator**: "He was referring to the Zille re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Lucita Azaro**: ""Your Majesty.""<br>`[4]` **Taddeus Azaro**: ""Your Majesty.""<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **"Move to the sofa."** | `[21]` **Narrator**: "He was referring to the Zille re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Lucita Azaro**: ""Your Majesty.""<br>`[4]` **Taddeus Azaro**: ""Your Majesty.""<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **"Turn on the television."** | `[30]` **Narrator**: "Lucita bowed and sat down beside..."<br>`[31]` **Narrator**: "Taddeus bowed and moved his whee..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "The ballot boxes were only 18% o..." |
| `[36]` | **""Zille will vote to return to Rizia. I can't see this going any other way.""** | `[35]` **Laurento Esquibel**: ""What are your thoughts, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Laurento Esquibel**: ""Not without a massive manipulat..." |
| `[37]` | **""If the will of the people is to remain a part of Wehlen, I will respect that.""** | `[35]` **Laurento Esquibel**: ""What are your thoughts, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Laurento Esquibel**: ""My worry is that this 'will' is..." |
| `[38]` | **""I will see Zille return to Rizia. By any means possible.""** | `[35]` **Laurento Esquibel**: ""What are your thoughts, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Laurento Esquibel**: ""There are options. I am sure."" |
| `[54]` | **""You may leave.""** | `[51]` **Lucita Azaro**: ""If you will excuse me, Your Maj..."<br>`[52]` **Taddeus Azaro**: ""If you will excuse me, Your Maj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>`[65]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **""You are excused.""** | `[51]` **Lucita Azaro**: ""If you will excuse me, Your Maj..."<br>`[52]` **Taddeus Azaro**: ""If you will excuse me, Your Maj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>`[65]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>*(oraz 1 innych odgałęzień)* |
| `[56]` | **""Yes. Of course.""** | `[51]` **Lucita Azaro**: ""If you will excuse me, Your Maj..."<br>`[52]` **Taddeus Azaro**: ""If you will excuse me, Your Maj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>`[65]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"Gesture towards the door."** | `[51]` **Lucita Azaro**: ""If you will excuse me, Your Maj..."<br>`[52]` **Taddeus Azaro**: ""If you will excuse me, Your Maj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>`[65]` **Narrator**: "Ballot boxes were 32% open. So f..."<br>*(oraz 1 innych odgałęzień)* |
| `[199]` | **""We will interfere with the Rizian Armed Forces. Our troops will enter Zille to pr..."** | `[198]` **Narrator**: "Suddenly...clarity. I knew what ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] = tru...` | `[210]` **Lucita Azaro**: ""Understood, Your Majesty.""<br>`[211]` **Taddeus Azaro**: ""At once, my liege.""<br>*(oraz 1 innych odgałęzień)* |
| `[200]` | **""We will not interfere with the referendum in any way.""** | `[198]` **Narrator**: "Suddenly...clarity. I knew what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Lucita Azaro**: ""Understood. Your Majesty.""<br>`[220]` **Taddeus Azaro**: ""Yes, my liege.""<br>*(oraz 1 innych odgałęzień)* |
| `[207]` | **""Activate all of our agents in Zille to try to make use of the chaos and steal the..."** | `[198]` **Narrator**: "Suddenly...clarity. I knew what ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents"] = t...` | `[210]` **Lucita Azaro**: ""Understood, Your Majesty.""<br>`[211]` **Taddeus Azaro**: ""At once, my liege.""<br>*(oraz 1 innych odgałęzień)* |
| `[257]` | **"Saber the bottle of champagne."** | `[349]` **Narrator**: "The staff brought in a bottle, a..."<br>`[250]` **Laurento Esquibel**: ""A historic win! I knew we could..." | `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false) == false` | *Brak zmian stanu* | `[258]` **Narrator**: "We clinked our glasses and took ..." |
| `[290]` | **"Toast with a glass of grape juice."** | `[250]` **Laurento Esquibel**: ""A historic win! I knew we could..." | `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false` | *Brak zmian stanu* | `[258]` **Narrator**: "We clinked our glasses and took ..." |
| `[344]` | **""Amazing. I can't wait to celebrate later.""** | `[250]` **Laurento Esquibel**: ""A historic win! I knew we could..." | `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false) == false` | *Brak zmian stanu* | `[346]` **Laurento Esquibel**: ""We all deserve it."" |
| `[345]` | **""You know what? This calls for champagne.""** | `[250]` **Laurento Esquibel**: ""A historic win! I knew we could..." | `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false` | *Brak zmian stanu* | `[349]` **Narrator**: "The staff brought in a bottle, a..." |

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
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Relati..."*)

### Węzeł `[4]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Taddeus bowed and moved his wheelchair next to where I wa..."*)

### Węzeł `[5]`
Mówca: **Titus Gordion**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Titus bowed and sat down next to me."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "It was a sunny, beautiful day in Jales. From the tall windows of the hilltop mansion where I was staying, I saw Brenas locals frolicking on the beach beneath colorful umbrellas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I sighed, longing for the sun and the sand. Instead, I wa..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "At least Pabel had managed to source a bottle of very rare champagne for me, as well as a golden saber to open it with."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Laurento came before me, bowed and gestured towards the a..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I sighed, longing for the sun and the sand. Instead, I was cooped up in a small room with my councilors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)

### Węzeł `[9]`
Mówca: **Laurento Esquibel**
> ""It is about to begin, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "He was referring to the Zille referendum. The event that ..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Laurento came before me, bowed and gestured towards the antique sofa in front of the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel");"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro");"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Laurento Esquibel: ""It is about to begin, Your Majesty.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Laurento Esquibel: ""It is about to begin, Your Majesty.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Laurento Esquibel: ""It is about to begin, Your Majesty.""*)

### Węzeł `[21]`
Mówca: **Narrator**
> "He was referring to the Zille referendum. The event that would determine the future of our northernmost region, and the reason we were all inside on this gorgeous day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus_Italic: "Move to the sofa."*)
  - -> `[22]` (*Player_Romus: ""Thank you for letting me know, Laurento.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for letting me know, Laurento.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Move to the sofa."]** — Mówca: **Player_Romus_Italic**
> "I moved to the sofa."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucita Azaro: ""Your Majesty.""*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Taddeus Azaro: ""Your Majesty.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Titus Gordion: ""Your Majesty.""*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Lucita bowed and sat down beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus_Italic: "Turn on the television."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Taddeus bowed and moved his wheelchair next to where I was sitting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus_Italic: "Turn on the television."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Titus bowed and sat down next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus_Italic: "Turn on the television."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Turn on the television."]** — Mówca: **Player_Romus_Italic**
> "I turned on the television."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator), `[31]` (Narrator), `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The ballot boxes were only 18% open. It was too early to ..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The ballot boxes were only 18% open. It was too early to say anything yet. We had to wait."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Laurento Esquibel: ""What are your thoughts, Your Majesty?""*)

### Węzeł `[35]`
Mówca: **Laurento Esquibel**
> ""What are your thoughts, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""If the will of the people is to remain a part of Wehlen,..."*)
  - -> `[36]` (*Player_Romus: ""Zille will vote to return to Rizia. I can't see this goi..."*)
  - -> `[38]` (*Player_Romus: ""I will see Zille return to Rizia. By any means possible.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille will vote to return to Rizia. I can't see this going any other way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Laurento Esquibel: ""Not without a massive manipulation effort by Wehlen. Whi..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the will of the people is to remain a part of Wehlen, I will respect that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Laurento Esquibel: ""My worry is that this 'will' is being manipulated by Weh..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will see Zille return to Rizia. By any means possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Laurento Esquibel: ""There are options. I am sure.""*)

### Węzeł `[39]`
Mówca: **Laurento Esquibel**
> ""My worry is that this 'will' is being manipulated by Wehlen, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[40]`
Mówca: **Laurento Esquibel**
> ""Not without a massive manipulation effort by Wehlen. Which is, I'm sorry to say, entirely possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[41]`
Mówca: **Laurento Esquibel**
> ""There are options. I am sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "An aide entered the room and whispered something into Luc..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "An aide entered the room and whispered something into Tad..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "An aide entered the room and whispered something into Tit..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "An aide entered the room and whispered something into Lucita's ear. She got up and bowed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If you will excuse me, Your Majesty. It seems I've recei..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "An aide entered the room and whispered something into Taddeus' ear. He got up and bowed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Taddeus Azaro: ""If you will excuse me, Your Majesty. It seems I've recei..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "An aide entered the room and whispered something into Titus' ear. He got up and bowed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Titus Gordion: ""If you will excuse me, Your Majesty. It seems I've recei..."*)

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""If you will excuse me, Your Majesty. It seems I've received an urgent call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Yes. Of course.""*)
  - -> `[55]` (*Player_Romus: ""You are excused.""*)
  - -> `[54]` (*Player_Romus: ""You may leave.""*)
  - -> `[57]` (*Player_Romus_Italic: "Gesture towards the door."*)

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""If you will excuse me, Your Majesty. It seems I've received an urgent call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Yes. Of course.""*)
  - -> `[55]` (*Player_Romus: ""You are excused.""*)
  - -> `[54]` (*Player_Romus: ""You may leave.""*)
  - -> `[57]` (*Player_Romus_Italic: "Gesture towards the door."*)

### Węzeł `[53]`
Mówca: **Titus Gordion**
> ""If you will excuse me, Your Majesty. It seems I've received an urgent call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Yes. Of course.""*)
  - -> `[55]` (*Player_Romus: ""You are excused.""*)
  - -> `[54]` (*Player_Romus: ""You may leave.""*)
  - -> `[57]` (*Player_Romus_Italic: "Gesture towards the door."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro), `[52]` (Taddeus Azaro), `[53]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are excused.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro), `[52]` (Taddeus Azaro), `[53]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro), `[52]` (Taddeus Azaro), `[53]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Gesture towards the door."]** — Mówca: **Player_Romus_Italic**
> "I gestured towards the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro), `[52]` (Taddeus Azaro), `[53]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Ballot boxes were 32% open. So far around 74% of Zille citizens had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Ballot boxes were 32% open. So far around 74% of Zille ci..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement =..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement =..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Ballot boxes were 32% open. So far around 53% of Zille ci..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Ballot boxes were 32% open. So far around 21% of Zille ci..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Ballot boxes were 32% open. So far around 53% of Zille citizens had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Ballot boxes were 32% open. So far around 21% of Zille citizens had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The doors to the room swung open and Lucita rushed in."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The doors to the room swung open and Taddeus rushed in."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "The doors to the room swung open and Titus rushed in."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The doors to the room swung open and Lucita rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucita Azaro: ""Your Majesty. I've received important news from our fore..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "The doors to the room swung open and Taddeus rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Taddeus Azaro: ""Your Majesty. I've received important news from our fore..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "The doors to the room swung open and Titus rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Titus Gordion: ""Your Majesty. I've received important news from our fore..."*)

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Your Majesty. I've received important news from our foreign intelligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucita Azaro: ""In addition, we have evidence that Smolak's people are a..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucita Azaro: ""In addition, we have been informed that Zillean Wehzek s..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "The channel abruptly cut to breaking news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "A massive number of armed militants had taken over the st..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistanc..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The channel abruptly cut to breaking news."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistan..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "The channel abruptly cut to breaking news."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "They were carrying machine guns and wearing black and red patches on their arms. The police were nowhere to be found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Laurento Esquibel: ""Oh my. This can't be good.""*)

### Węzeł `[88]`
Mówca: **Narrator**
> "The channel abruptly cut to breaking news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "A small number of armed militants had gone out onto the s..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "They were carrying machine guns and wearing black and red patches on their arms. The police were nowhere to be found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Laurento Esquibel: ""Oh my. This can't be good.""*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_ArmedResistance == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "She pointed at the television."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_ArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""As you can see, a group of armed militants has begun threatening voters. They're taking over the election centers as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""We don't know which side they are on at the moment, but ..."*)

### Węzeł `[94]`
Mówca: **Laurento Esquibel**
> ""Oh my. This can't be good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""It looks like we are on track to win the referendum. At ..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""Initial numbers show that we are going to lose the refer..."*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""It looks like we are on track to win the referendum. At the moment most of the votes are on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Lucita Azaro: ""However...""*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""Initial numbers show that we are going to lose the referendum. We must act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""We're seeing street fights between the people of Zille and these interlopers. This does not look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucita Azaro: ""I'm afraid a civil conflict might be on the horizon.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_BothSidesClash == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""We're seeing street fights between the people of Zille a..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_BothSidesClash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""What I do know is that their presence is interfering wit..."*)

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""I'm afraid a civil conflict might be on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""What I do know is that their presence is interfering with the voting process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucita Azaro: ""This could go either way.""*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win = true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance ..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistanc..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance = true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true) || (RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true) && RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistan..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true) || (RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true) && RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true)  or  (Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true)  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash = true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true) || (RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true) && RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true)  or  (Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true)  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)

### Węzeł `[118]`
Mówca: **Lucita Azaro**
> ""This could go either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""In addition, we have been informed that Zillean Wehzek sympathizers are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""We don't have direct evidence to connect them to Wehlen,..."*)

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""In addition, we have evidence that Smolak's people are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucita Azaro: ""We found agents trying to intimidate voters and instigat..."*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""We don't have direct evidence to connect them to Wehlen, but we all know what Smolak is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""We must act, Your Majesty. And with haste. We have all o..."*)

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""We found agents trying to intimidate voters and instigate violence. The interrogations showed that they are directly linked to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""We must act, Your Majesty. And with haste. We have all o..."*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""We don't know which side they are on at the moment, but we will know more soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "A massive number of armed militants had taken over the streets of Zille, their faces covered in ski masks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "They were carrying machine guns and wearing black and red..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "A small number of armed militants had gone out onto the streets of Zille, their faces covered in ski masks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "They were carrying machine guns and wearing black and red..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "She pointed at the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucita Azaro: ""As you can see, a group of armed militants has begun thr..."*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""We must act, Your Majesty. And with haste. We have all of the contingency plans ready to launch at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Laurento Esquibel: ""I really would caution against doing anything rash at th..."*)

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Your Majesty. I've received important news from our foreign intelligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Taddeus Azaro: ""In addition, we have evidence that Smolak's people are a..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Taddeus Azaro: ""In addition, we have been informed that Zillean Wehzek s..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_ArmedResistance == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He pointed at the television."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_ArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""As you can see, a group of armed militants has begun threatening voters. They're taking over the election centers as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Taddeus Azaro: ""We don't know whose side they are on at the moment, but ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Taddeus Azaro: ""It looks like we are on track to win the referendum. At ..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Taddeus Azaro: ""Initial numbers show that we are going to lose the refer..."*)

### Węzeł `[139]`
Mówca: **Taddeus Azaro**
> ""It looks like we are on track to win the referendum. At the moment, most of the votes are on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Taddeus Azaro: ""However...""*)

### Węzeł `[140]`
Mówca: **Taddeus Azaro**
> ""Initial numbers show that we are going to lose the referendum. We must act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_BothSidesClash == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Taddeus Azaro: ""We're seeing street fights between the people of Zille a..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_BothSidesClash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Taddeus Azaro: ""What I do know is that their presence is interfering wit..."*)

### Węzeł `[144]`
Mówca: **Taddeus Azaro**
> ""We're seeing street fights between the people of Zille and these interlopers. This does not look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Taddeus Azaro: ""I'm afraid a civil conflict might be on the horizon.""*)

### Węzeł `[145]`
Mówca: **Taddeus Azaro**
> ""I'm afraid a civil conflict might be on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[146]`
Mówca: **Taddeus Azaro**
> ""What I do know is that their presence is interfering with the voting process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Taddeus Azaro: ""This could go either way.""*)

### Węzeł `[147]`
Mówca: **Taddeus Azaro**
> ""This could go either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[148]`
Mówca: **Taddeus Azaro**
> ""In addition, we have been informed that Zillean Wehzek sympathizers are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Taddeus Azaro: ""We don't have direct evidence to connect them to Wehlen,..."*)

### Węzeł `[149]`
Mówca: **Taddeus Azaro**
> ""In addition, we have evidence that Smolak's people are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Taddeus Azaro: ""We found agents trying to intimidate voters and instigat..."*)

### Węzeł `[150]`
Mówca: **Taddeus Azaro**
> ""We don't have direct evidence to connect them to Wehlen, but we all know what Smolak is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Taddeus Azaro: ""We must act, Your Majesty. And with haste. We have all o..."*)

### Węzeł `[151]`
Mówca: **Taddeus Azaro**
> ""We found agents trying to intimidate voters and instigate violence. The interrogations showed that they are directly linked to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Taddeus Azaro: ""We must act, Your Majesty. And with haste. We have all o..."*)

### Węzeł `[152]`
Mówca: **Taddeus Azaro**
> ""We don't know whose side they are on at the moment, but we will know more soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "He pointed at the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Taddeus Azaro: ""As you can see, a group of armed militants has begun thr..."*)

### Węzeł `[154]`
Mówca: **Taddeus Azaro**
> ""We must act, Your Majesty. And with haste. We have all of the contingency plans ready to launch at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Laurento Esquibel: ""I really would caution against doing anything rash at th..."*)

### Węzeł `[155]`
Mówca: **Titus Gordion**
> ""Your Majesty. I've received important news from our foreign intelligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Titus Gordion: ""In addition, we have been informed that Zillean Wehzek s..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Titus Gordion: ""In addition, we have evidence that Smolak's people are a..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_ArmedResistance == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "He pointed at the television."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_ArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[162]`
Mówca: **Titus Gordion**
> ""As you can see, a group of armed militants has begun threatening voters. They're taking over the election centers as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Titus Gordion: ""We don't know which side they are on at the moment, but ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Titus Gordion: ""It looks like we are on track to win the referendum. At ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Titus Gordion: ""Initial numbers show that we are going to lose the refer..."*)

### Węzeł `[166]`
Mówca: **Titus Gordion**
> ""It looks like we are on track to win the referendum. At the moment, most of the votes are on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Titus Gordion: ""However...""*)

### Węzeł `[167]`
Mówca: **Titus Gordion**
> ""Initial numbers show that we are going to lose the referendum. We must act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_BothSidesClash == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Titus Gordion: ""We're seeing street fights between the people of Zille a..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_BothSidesClash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Titus Gordion: ""What we do know is that their presence is interfering wi..."*)

### Węzeł `[171]`
Mówca: **Titus Gordion**
> ""We're seeing street fights between the people of Zille and these interlopers. This does not look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""I'm afraid a civil conflict might be on the horizon.""*)

### Węzeł `[172]`
Mówca: **Titus Gordion**
> ""I'm afraid a civil conflict might be on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[173]`
Mówca: **Titus Gordion**
> ""What we do know is that their presence is interfering with the voting process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Titus Gordion: ""This might go both sides now.""*)

### Węzeł `[174]`
Mówca: **Titus Gordion**
> ""This might go both sides now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[175]`
Mówca: **Titus Gordion**
> ""In addition, we have been informed that Zillean Wehzek sympathizers are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Titus Gordion: ""We don't have direct evidence to connect them to Wehlen,..."*)

### Węzeł `[176]`
Mówca: **Titus Gordion**
> ""In addition, we have evidence that Smolak's people are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Titus Gordion: ""We found agents trying to intimidate voters and instigat..."*)

### Węzeł `[177]`
Mówca: **Titus Gordion**
> ""We don't have direct evidence to connect them to Wehlen, but we all know what Smolak is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Titus Gordion: ""We must act, Your Majesty. And with haste. We have all o..."*)

### Węzeł `[178]`
Mówca: **Titus Gordion**
> ""We found agents trying to intimidate voters and instigate violence. The interrogations showed that they are directly linked to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Titus Gordion: ""We must act, Your Majesty. And with haste. We have all o..."*)

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""We don't know which side they are on at the moment, but we will know more soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "He pointed at the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Titus Gordion: ""As you can see, a group of armed militants has begun thr..."*)

### Węzeł `[181]`
Mówca: **Titus Gordion**
> ""We must act, Your Majesty. And with haste. We have all of the options prepared and ready to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Laurento Esquibel: ""I really would caution against doing anything rash at th..."*)

### Węzeł `[182]`
Mówca: **Laurento Esquibel**
> ""I really would caution against doing anything rash at this point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)

### Węzeł `[183]`
Mówca: **Laurento Esquibel**
> ""But it is your decision. If we are going to interfere, I suggest we act quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "The TV host returned with the current numbers."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "The TV host returned with the current numbers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "The ballot boxes were 43% open. So far, around 62% of residents had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I took a moment to think."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "The ballot boxes were 43% open. So far, around 62% of res..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement =..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement =..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "The ballot boxes were 43% open. So far around 53% of resi..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "The ballot boxes were 43% open. So far around 35% of resi..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "The ballot boxes were 43% open. So far around 53% of residents had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I took a moment to think."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "The ballot boxes were 43% open. So far around 35% of residents had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I took a moment to think."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "I took a moment to think."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Ballot boxes were 49% open."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Ballot boxes were 49% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Laurento Esquibel: ""Your Majesty? We need a decision.""*)

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""Your Majesty? We need a decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Ballot boxes were 52% open."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "Everyone was staring at me, awaiting my decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "Suddenly...clarity. I knew what I had to do."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "Suddenly...clarity. I knew what I had to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""We will not interfere with the referendum in any way.""*)
  - -> `[199]` (*Player_Romus: ""We will interfere with the Rizian Armed Forces. Our troo..."*)
  - -> `[207]` (*Player_Romus: ""Activate all of our agents in Zille to try to make use o..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will interfere with the Rizian Armed Forces. Our troops will enter Zille to protect the ballot boxes and make sure we get what is ours back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army = true; RiziaDLCS..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not interfere with the referendum in any way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_EarlyResult_Win == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_EarlyResult_Win == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Laurento Esquibel: ""We are already winning, are we not?""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_EarlyResult_Win == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Laurento Esquibel: ""But it is your decision. If we are going to interfere, I..."*)

### Węzeł `[204]`
Mówca: **Laurento Esquibel**
> ""We are already winning, are we not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Laurento Esquibel: ""Unless something changes in the next few hours...""*)

### Węzeł `[205]`
Mówca: **Laurento Esquibel**
> ""Unless something changes in the next few hours...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Laurento Esquibel: ""But it is your decision. If we are going to interfere, I..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Ballot boxes were 52% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "Everyone was staring at me, awaiting my decision."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Activate all of our agents in Zille to try to make use of the chaos and steal the votes from our opponents. Make sure that they are undercover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents = true; RiziaDL..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[210]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucita Azaro: ""I will come back with the results in a few hours before ..."*)

### Węzeł `[211]`
Mówca: **Taddeus Azaro**
> ""At once, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Taddeus Azaro: ""I will come back with the results in a few hours before ..."*)

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""Consider it done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Titus Gordion: ""I will come back with the results in a few hours before ..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucita Azaro: ""Understood, Your Majesty.""*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Taddeus Azaro: ""At once, my liege.""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Titus Gordion: ""Consider it done, Your Majesty.""*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Understood. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "She sat back down on the couch."*)

### Węzeł `[220]`
Mówca: **Taddeus Azaro**
> ""Yes, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He sat back down on the couch."*)

### Węzeł `[221]`
Mówca: **Titus Gordion**
> ""You've made yourself clear, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He sat back down on the couch."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""Understood. Your Majesty.""*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Taddeus Azaro: ""Yes, my liege.""*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Titus Gordion: ""You've made yourself clear, Your Majesty.""*)

### Węzeł `[228]`
Mówca: **Narrator**
> "She sat back down on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "All of our attention was on the television as we watched ..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "He sat back down on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "All of our attention was on the television as we watched ..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "All of our attention was on the television as we watched the numbers change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "The ballot boxes were 84% open."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "The ballot boxes were 84% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Laurento Esquibel: ""The result is almost a certainty now.""*)

### Węzeł `[232]`
Mówca: **Laurento Esquibel**
> ""The result is almost a certainty now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "93% open."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "93% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "98% open. A shiver ran down my spine as the final numbers..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "98% open. A shiver ran down my spine as the final numbers appeared on the screen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "The final referendum result was 'No', with 68% of Zille residents agreeing on the transfer of the region back to Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Zille was going to be returned. I had defeated Smolak."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement =..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "The final referendum result was 'No', with 68% of Zille r..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement =..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement =..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "The final referendum result was 'No', with 51% of Zille r..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "The final referendum result was 'Yes', with only 32% of Z..."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "The final referendum result was 'No', with 51% of Zille residents agreeing on the transfer of the region back to Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Zille was going to be returned. I had defeated Smolak."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "The final referendum result was 'Yes', with only 32% of Zille residents voting for the transfer of the region back to Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "It had been done. Smolak had defeated me."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_BothSidesClash == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_BothSidesClash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence = true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_BothSidesClash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Laurento Esquibel: ""I've got to get in touch with Zille's foreign ministry r..."*)

### Węzeł `[247]`
Mówca: **Laurento Esquibel**
> ""I am so sorry, Your Majesty. I never would have expected Smolak to be capable of such treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[248]`
Mówca: **Narrator**
> "It had been done. Smolak had defeated me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Jou..."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Zille was going to be returned. I had defeated Smolak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Laurento Esquibel: ""A historic win! I knew we could solve this without viole..."*)

### Węzeł `[250]`
Mówca: **Laurento Esquibel**
> ""A historic win! I knew we could solve this without violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "Lucita left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Taddeus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[253]`
Mówca: **Narrator**
> "Titus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[254]`
Mówca: **Laurento Esquibel**
> ""I must go as well, Your Majesty. Whatever happens next is bound to have major repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He bowed and left."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[256]`
Mówca: **Narrator**
> "He announced that he represented the 'Zille Liberation Front', or ZLF."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "Zille was to declare independence from Rizia and Wehlen t..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "Saber the bottle of champagne."]** — Mówca: **Player_Romus_Italic**
> "I grabbed the saber and sliced the top off the champagne bottle."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[349]` (Narrator), `[250]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "We clinked our glasses and took a sip."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "We clinked our glasses and took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[259]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen to establish a new state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "He finished by asking all revolutionaries of the world to..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "I got up to look out the window again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "I was more envious of the carefree beachgoers than ever."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "I was more envious of the carefree beachgoers than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Lost"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Laurento Esquibel: ""I am so sorry, Your Majesty. I never would have expected..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "He bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Laurento Esquibel");"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Laurento Esquibel: ""I must go as well, Your Majesty. Whatever happens next i..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Laurento Esquibel: ""I must go as well, Your Majesty. Whatever happens next i..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Laurento Esquibel: ""I must go as well, Your Majesty. Whatever happens next i..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "I got up to look out the window again."*)

### Węzeł `[268]`
Mówca: **Lucita Azaro**
> ""We could've turned this around. I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "She left the room quickly."*)

### Węzeł `[269]`
Mówca: **Taddeus Azaro**
> ""We could've turned this around, Your Majesty. I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Taddeus left the room quickly."*)

### Węzeł `[270]`
Mówca: **Titus Gordion**
> ""We could've turned this around, Your Majesty. I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Titus left the room quickly."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Lucita's fists were clenched tight."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Taddeus Azaro: ""We could've turned this around, Your Majesty. I know it.""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Titus Gordion: ""We could've turned this around, Your Majesty. I know it.""*)

### Węzeł `[277]`
Mówca: **Narrator**
> "She left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Laurento Esquibel: ""I must go as well, Your Majesty. The sooner we begin pre..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Laurento Esquibel: ""I must go as well, Your Majesty. The sooner we begin pre..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Laurento Esquibel: ""I must go as well, Your Majesty. The sooner we begin pre..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "Taddeus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Taddeus Azaro");"*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Titus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalVa..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "At least Pabel had made sure that my favorite sparkling grape juice would be on hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Laurento came before me, bowed and gestured towards the a..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false && RiziaDLC.Pabel_Gone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalVa..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false && RiziaDLC.Pabel_Gone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player_Romus_Italic: "Toast with a glass of grape juice."*)
  - -> `[345]` (*Player_Romus: ""You know what? This calls for champagne.""*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false && RiziaDLC.Pabel_Gone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus_Italic: "Saber the bottle of champagne."*)
  - -> `[344]` (*Player_Romus: ""Amazing. I can't wait to celebrate later.""*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "Toast with a glass of grape juice."]** — Mówca: **Player_Romus_Italic**
> "I toasted with a glass of grape juice."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "We clinked our glasses and took a sip."*)

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""I will come back with the results in a few hours before all the votes are counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "Lucita left the room quickly."*)

### Węzeł `[292]`
Mówca: **Taddeus Azaro**
> ""I will come back with the results in a few hours before all the votes are counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Taddeus left the room quickly."*)

### Węzeł `[293]`
Mówca: **Titus Gordion**
> ""I will come back with the results in a few hours before all the votes are counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "Titus left the room quickly."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille ==..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "He announced that Zille was declaring its independence fr..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries ==..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He announced that Zille was declaring its independence fr..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "He announced that he represented the 'Zille Liberation Fr..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries == true &&..."*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_DerdianMercenaries == true ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "He announced that Zille was declaring its independence fr..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_DerdianMercenaries == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[303]`
Mówca: **Narrator**
> "He announced that Zille was declaring its independence from both Rizia and Wehlen. The results of the referendum would be null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "From henceforth, the region would be renamed the 'Bludish..."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "From henceforth, the region would be renamed the 'Bludish Republic of Zille'. The Bludish population finally had their own state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "He finished by asking all Bluds of the world to unite, to..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "He announced that Zille was declaring its independence from both Rizia and Wehlen. The results of the referendum would be null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "From henceforth, the region would be renamed the 'Wruheci..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "From henceforth, the region would be renamed the 'Wruhecist Republic of Zille'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "He finished by asking all Wruhecists of the world to unit..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "He announced that Zille was declaring its independence from both Rizia and Wehlen. The results of the referendum would be null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "From henceforth, the region would be renamed the 'Holy Go..."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "From henceforth, the region would be renamed the 'Holy Golcondist Protectorate of Zille'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "He finished by asking all Golcondists of the world to uni..."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "I cursed and smashed the bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_FreeZille");"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The TV program was once again interrupted. But this time ..."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "The TV program was once again interrupted. But this time by someone with a ski mask sitting on a table, reading from a paper in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries == true &&..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "His words sent another, colder shiver down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "I cursed and smashed the bottle."*)

### Węzeł `[313]`
Mówca: **Narrator**
> "He finished by asking all Golcondists of the world to unite, to aid them and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Golcondist = true; ..."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "He finished by asking all Wruhecists of the world to unite, to aid them and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Wruhecist = true; R..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "He finished by asking all Bluds of the world to unite, to aid them and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Bludish = true; Riz..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "He finished by asking all revolutionaries of the world to unite, to aid them and to join in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence_Liberation = true; ..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Golcondist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist = true; 
RiziaDLCText.IndependentZille = "Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille", "Theocratic Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille","Theocratic Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "His words sent another, colder shiver down my spine."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Wruhecist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist = true;
RiziaDLCText.IndependentZille = "Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille", "Religious Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille","Religious Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "His words sent another, colder shiver down my spine."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Bludish = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish = true;
RiziaDLCText.IndependentZille = "Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille", "Presidential Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille","Presidential Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "His words sent another, colder shiver down my spine."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence_Liberation = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation = true;
RiziaDLCText.IndependentZille = "Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille", "Parliamentary Republic");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille","Parliamentary Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "His words sent another, colder shiver down my spine."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "It was a sunny, beautiful day in Jales. From the tall win..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony = true;
RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered = true; RiziaDLC.ZilleReturn_Success = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered"] = true;
Variable["RiziaDLC.ZilleReturn_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[323]`
Mówca: **Narrator**
> "Lucita's fists were clenched tight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucita Azaro: ""We could've turned this around. I know it.""*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == ..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "At least Pabel had made sure that my favorite sparkling g..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "The staff had sourced a bottle of very rare champagne for..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "The staff had sourced a bottle of very rare champagne for me, as well as a golden saber to open it with. They didn't yet know about my sobriety."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Laurento came before me, bowed and gestured towards the a..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == ..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "At least Pabel had managed to source a bottle of very rar..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "At least the staff had managed to source a bottle of very..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "At least the staff had managed to source a bottle of very rare champagne for me, as well as a golden saber to open it with."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Laurento came before me, bowed and gestured towards the a..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Relati..."*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Rela..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Lucita kissed my cheek as she sat down beside me."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Lucita bowed and sat down beside me."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Lucita kissed my cheek as she sat down beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus_Italic: "Turn on the television."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_ArmedResistance == true)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He pointed at the television."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_ArmedResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[339]`
Mówca: **Taddeus Azaro**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)

### Węzeł `[340]`
Mówca: **Lucita Azaro**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)

### Węzeł `[341]`
Mówca: **Titus Gordion**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Won"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSignin..."*)

### Węzeł `[343]`
Mówca: **Laurento Esquibel**
> ""I must go as well, Your Majesty. The sooner we begin preparing the official concession of the region to Wehlen, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He bowed and left."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing. I can't wait to celebrate later.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Laurento Esquibel: ""We all deserve it.""*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? This calls for champagne.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "The staff brought in a bottle, as well as a golden saber ..."*)

### Węzeł `[346]`
Mówca: **Laurento Esquibel**
> ""We all deserve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)

### Węzeł `[347]`
Mówca: **Laurento Esquibel**
> ""I've got to get in touch with Zille's foreign ministry right away. But congratulations, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "He was whistling a jaunty tune as he left the room."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "He was whistling a jaunty tune as he left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[349]`
Mówca: **Narrator**
> "The staff brought in a bottle, as well as a golden saber with which to open it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus_Italic: "Saber the bottle of champagne."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Drinking += 1"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Drinking += 1"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Drinking += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["RiziaDLC.PersonalValue_Drinking"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_BothSidesClash == true"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_FreeZille");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_FreeZille");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "End();"*)
