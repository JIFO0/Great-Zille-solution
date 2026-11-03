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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 29

**Główne modyfikowane wskaźniki i kluczowe flagi:**
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
- *...oraz 11 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[17]` (Paskal Beniwoll): `AddConversant("Laurento Esquibel");`
- Węzeł `[18]` (Paskal Beniwoll): `AddConversant("Lucita Azaro");`
- Węzeł `[19]` (Paskal Beniwoll): `AddConversant("Taddeus Azaro");`
- Węzeł `[20]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[109]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] = true;`
- Węzeł `[113]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] = true;`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] = true;`
- Węzeł `[208]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] = true; Variable["RiziaDLCSupport.Journal_Tur...`
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
  - -> `[106]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[4]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[5]`
Mówca: **Titus Gordion**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[6]`
Mówca: **Narrator**
> "It was a sunny, beautiful day in Jales. From the tall windows of the hilltop mansion where I was staying, I saw Brenas locals frolicking on the beach beneath colorful umbrellas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Narrator**
> "At least Pabel had managed to source a bottle of very rare champagne for me, as well as a golden saber to open it with."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I sighed, longing for the sun and the sand. Instead, I was cooped up in a small room with my councilors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[9]`
Mówca: **Laurento Esquibel**
> ""It is about to begin, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Laurento came before me, bowed and gestured towards the antique sofa in front of the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[21]`
Mówca: **Narrator**
> "He was referring to the Zille referendum. The event that would determine the future of our northernmost region, and the reason we were all inside on this gorgeous day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for letting me know, Laurento.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "Move to the sofa."]** — Mówca: **Player_Romus_Italic**
> "I moved to the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Lucita bowed and sat down beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Taddeus bowed and moved his wheelchair next to where I was sitting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Titus bowed and sat down next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Turn on the television."]** — Mówca: **Player_Romus_Italic**
> "I turned on the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The ballot boxes were only 18% open. It was too early to say anything yet. We had to wait."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Laurento Esquibel**
> ""What are your thoughts, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[36]`
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille will vote to return to Rizia. I can't see this going any other way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the will of the people is to remain a part of Wehlen, I will respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will see Zille return to Rizia. By any means possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Laurento Esquibel**
> ""My worry is that this 'will' is being manipulated by Wehlen, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Laurento Esquibel**
> ""Not without a massive manipulation effort by Wehlen. Which is, I'm sorry to say, entirely possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Laurento Esquibel**
> ""There are options. I am sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
Mówca: **Narrator**
> "An aide entered the room and whispered something into Lucita's ear. She got up and bowed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Narrator**
> "An aide entered the room and whispered something into Taddeus' ear. He got up and bowed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Narrator**
> "An aide entered the room and whispered something into Titus' ear. He got up and bowed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""If you will excuse me, Your Majesty. It seems I've received an urgent call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""If you will excuse me, Your Majesty. It seems I've received an urgent call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`
  - -> `[57]`

### Węzeł `[53]`
Mówca: **Titus Gordion**
> ""If you will excuse me, Your Majesty. It seems I've received an urgent call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`
  - -> `[57]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are excused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Gesture towards the door."]** — Mówca: **Player_Romus_Italic**
> "I gestured towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Ballot boxes were 32% open. So far around 74% of Zille citizens had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Ballot boxes were 32% open. So far around 53% of Zille citizens had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Ballot boxes were 32% open. So far around 21% of Zille citizens had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The doors to the room swung open and Lucita rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Narrator**
> "The doors to the room swung open and Taddeus rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[75]`
Mówca: **Narrator**
> "The doors to the room swung open and Titus rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Your Majesty. I've received important news from our foreign intelligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[80]`
Mówca: **Narrator**
> "The channel abruptly cut to breaking news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[87]`
Mówca: **Narrator**
> "They were carrying machine guns and wearing black and red patches on their arms. The police were nowhere to be found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Narrator**
> "The channel abruptly cut to breaking news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[89]`
Mówca: **Narrator**
> "They were carrying machine guns and wearing black and red patches on their arms. The police were nowhere to be found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_ArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""As you can see, a group of armed militants has begun threatening voters. They're taking over the election centers as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[94]`
Mówca: **Laurento Esquibel**
> ""Oh my. This can't be good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_EarlyResult_Win == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""It looks like we are on track to win the referendum. At the moment most of the votes are on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""Initial numbers show that we are going to lose the referendum. We must act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""We're seeing street fights between the people of Zille and these interlopers. This does not look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_BothSidesClash == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""I'm afraid a civil conflict might be on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""What I do know is that their presence is interfering with the voting process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true || RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true) || (RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true) && RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true) || (RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true) && RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true)  or  (Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true)  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true) || (RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true) && RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true)  or  (Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true)  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[118]`
Mówca: **Lucita Azaro**
> ""This could go either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""In addition, we have been informed that Zillean Wehzek sympathizers are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""In addition, we have evidence that Smolak's people are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""We don't have direct evidence to connect them to Wehlen, but we all know what Smolak is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""We found agents trying to intimidate voters and instigate violence. The interrogations showed that they are directly linked to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""We don't know which side they are on at the moment, but we will know more soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[124]`
Mówca: **Narrator**
> "A massive number of armed militants had taken over the streets of Zille, their faces covered in ski masks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[125]`
Mówca: **Narrator**
> "A small number of armed militants had gone out onto the streets of Zille, their faces covered in ski masks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[126]`
Mówca: **Narrator**
> "She pointed at the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""We must act, Your Majesty. And with haste. We have all of the contingency plans ready to launch at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Your Majesty. I've received important news from our foreign intelligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_ArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Taddeus Azaro**
> ""As you can see, a group of armed militants has begun threatening voters. They're taking over the election centers as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_EarlyResult_Win == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Taddeus Azaro**
> ""It looks like we are on track to win the referendum. At the moment, most of the votes are on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[140]`
Mówca: **Taddeus Azaro**
> ""Initial numbers show that we are going to lose the referendum. We must act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_BothSidesClash == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
Mówca: **Taddeus Azaro**
> ""We're seeing street fights between the people of Zille and these interlopers. This does not look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Taddeus Azaro**
> ""I'm afraid a civil conflict might be on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[146]`
Mówca: **Taddeus Azaro**
> ""What I do know is that their presence is interfering with the voting process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Taddeus Azaro**
> ""This could go either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[148]`
Mówca: **Taddeus Azaro**
> ""In addition, we have been informed that Zillean Wehzek sympathizers are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Taddeus Azaro**
> ""In addition, we have evidence that Smolak's people are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Taddeus Azaro**
> ""We don't have direct evidence to connect them to Wehlen, but we all know what Smolak is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Taddeus Azaro**
> ""We found agents trying to intimidate voters and instigate violence. The interrogations showed that they are directly linked to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
Mówca: **Taddeus Azaro**
> ""We don't know whose side they are on at the moment, but we will know more soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[153]`
Mówca: **Narrator**
> "He pointed at the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[154]`
Mówca: **Taddeus Azaro**
> ""We must act, Your Majesty. And with haste. We have all of the contingency plans ready to launch at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[155]`
Mówca: **Titus Gordion**
> ""Your Majesty. I've received important news from our foreign intelligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true || RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_ArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[162]`
Mówca: **Titus Gordion**
> ""As you can see, a group of armed militants has begun threatening voters. They're taking over the election centers as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_EarlyResult_Win == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Titus Gordion**
> ""It looks like we are on track to win the referendum. At the moment, most of the votes are on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[167]`
Mówca: **Titus Gordion**
> ""Initial numbers show that we are going to lose the referendum. We must act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_BothSidesClash == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Titus Gordion**
> ""We're seeing street fights between the people of Zille and these interlopers. This does not look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Titus Gordion**
> ""I'm afraid a civil conflict might be on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[173]`
Mówca: **Titus Gordion**
> ""What we do know is that their presence is interfering with the voting process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Titus Gordion**
> ""This might go both sides now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[175]`
Mówca: **Titus Gordion**
> ""In addition, we have been informed that Zillean Wehzek sympathizers are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Titus Gordion**
> ""In addition, we have evidence that Smolak's people are attempting to influence the referendum results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Titus Gordion**
> ""We don't have direct evidence to connect them to Wehlen, but we all know what Smolak is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Titus Gordion**
> ""We found agents trying to intimidate voters and instigate violence. The interrogations showed that they are directly linked to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""We don't know which side they are on at the moment, but we will know more soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[180]`
Mówca: **Narrator**
> "He pointed at the television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[181]`
Mówca: **Titus Gordion**
> ""We must act, Your Majesty. And with haste. We have all of the options prepared and ready to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Laurento Esquibel**
> ""I really would caution against doing anything rash at this point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[183]`
Mówca: **Laurento Esquibel**
> ""But it is your decision. If we are going to interfere, I suggest we act quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "The TV host returned with the current numbers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Narrator**
> "The ballot boxes were 43% open. So far, around 62% of residents had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Narrator**
> "The ballot boxes were 43% open. So far around 53% of residents had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Narrator**
> "The ballot boxes were 43% open. So far around 35% of residents had voted no to joining Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Narrator**
> "I took a moment to think."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Ballot boxes were 49% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""Your Majesty? We need a decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[197]`
Mówca: **Narrator**
> "Everyone was staring at me, awaiting my decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Narrator**
> "Suddenly...clarity. I knew what I had to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[199]`
  - -> `[207]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will interfere with the Rizian Armed Forces. Our troops will enter Zille to protect the ballot boxes and make sure we get what is ours back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not interfere with the referendum in any way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_EarlyResult_Win == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_EarlyResult_Win == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_EarlyResult_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[204]`
Mówca: **Laurento Esquibel**
> ""We are already winning, are we not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Laurento Esquibel**
> ""Unless something changes in the next few hours...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Ballot boxes were 52% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Activate all of our agents in Zille to try to make use of the chaos and steal the votes from our opponents. Make sure that they are undercover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[210]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[211]`
Mówca: **Taddeus Azaro**
> ""At once, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""Consider it done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Understood. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[220]`
Mówca: **Taddeus Azaro**
> ""Yes, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[221]`
Mówca: **Titus Gordion**
> ""You've made yourself clear, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[228]`
Mówca: **Narrator**
> "She sat back down on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Narrator**
> "He sat back down on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Narrator**
> "All of our attention was on the television as we watched the numbers change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Narrator**
> "The ballot boxes were 84% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Laurento Esquibel**
> ""The result is almost a certainty now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Narrator**
> "93% open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Narrator**
> "98% open. A shiver ran down my spine as the final numbers appeared on the screen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Narrator**
> "The final referendum result was 'No', with 68% of Zille residents agreeing on the transfer of the region back to Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Narrator**
> "The final referendum result was 'No', with 51% of Zille residents agreeing on the transfer of the region back to Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[243]`
Mówca: **Narrator**
> "The final referendum result was 'Yes', with only 32% of Zille residents voting for the transfer of the region back to Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_BothSidesClash == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_BothSidesClash == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_BothSidesClash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[247]`
Mówca: **Laurento Esquibel**
> ""I am so sorry, Your Majesty. I never would have expected Smolak to be capable of such treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[248]`
Mówca: **Narrator**
> "It had been done. Smolak had defeated me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[249]`
Mówca: **Narrator**
> "Zille was going to be returned. I had defeated Smolak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Laurento Esquibel**
> ""A historic win! I knew we could solve this without violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[251]`
Mówca: **Narrator**
> "Lucita left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Taddeus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[253]`
Mówca: **Narrator**
> "Titus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[254]`
Mówca: **Laurento Esquibel**
> ""I must go as well, Your Majesty. Whatever happens next is bound to have major repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[256]`
Mówca: **Narrator**
> "He announced that he represented the 'Zille Liberation Front', or ZLF."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "Saber the bottle of champagne."]** — Mówca: **Player_Romus_Italic**
> "I grabbed the saber and sliced the top off the champagne bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Narrator**
> "We clinked our glasses and took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[259]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen to establish a new state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[260]`
Mówca: **Narrator**
> "I got up to look out the window again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Narrator**
> "I was more envious of the carefree beachgoers than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Lost"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[263]`
Mówca: **Narrator**
> "He bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[268]`
Mówca: **Lucita Azaro**
> ""We could've turned this around. I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[269]`
Mówca: **Taddeus Azaro**
> ""We could've turned this around, Your Majesty. I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[270]`
Mówca: **Titus Gordion**
> ""We could've turned this around, Your Majesty. I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[277]`
Mówca: **Narrator**
> "She left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[281]`
Mówca: **Narrator**
> "Taddeus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Titus left the room quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[286]`
Mówca: **Narrator**
> "At least Pabel had made sure that my favorite sparkling grape juice would be on hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false && RiziaDLC.Pabel_Gone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false && RiziaDLC.Pabel_Gone == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[345]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false && RiziaDLC.Pabel_Gone == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false  and  Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[344]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "Toast with a glass of grape juice."]** — Mówca: **Player_Romus_Italic**
> "I toasted with a glass of grape juice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""I will come back with the results in a few hours before all the votes are counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[292]`
Mówca: **Taddeus Azaro**
> ""I will come back with the results in a few hours before all the votes are counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[293]`
Mówca: **Titus Gordion**
> ""I will come back with the results in a few hours before all the votes are counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_DerdianMercenaries == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[303]`
Mówca: **Narrator**
> "He announced that Zille was declaring its independence from both Rizia and Wehlen. The results of the referendum would be null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Narrator**
> "From henceforth, the region would be renamed the 'Bludish Republic of Zille'. The Bludish population finally had their own state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[305]`
Mówca: **Narrator**
> "He announced that Zille was declaring its independence from both Rizia and Wehlen. The results of the referendum would be null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Narrator**
> "From henceforth, the region would be renamed the 'Wruhecist Republic of Zille'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[307]`
Mówca: **Narrator**
> "He announced that Zille was declaring its independence from both Rizia and Wehlen. The results of the referendum would be null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Narrator**
> "From henceforth, the region would be renamed the 'Holy Golcondist Protectorate of Zille'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[309]`
Mówca: **Narrator**
> "I cursed and smashed the bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Narrator**
> "The TV program was once again interrupted. But this time by someone with a ski mask sitting on a table, reading from a paper in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[312]`
Mówca: **Narrator**
> "His words sent another, colder shiver down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[313]`
Mówca: **Narrator**
> "He finished by asking all Golcondists of the world to unite, to aid them and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[314]`
Mówca: **Narrator**
> "He finished by asking all Wruhecists of the world to unite, to aid them and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[315]`
Mówca: **Narrator**
> "He finished by asking all Bluds of the world to unite, to aid them and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[316]`
Mówca: **Narrator**
> "He finished by asking all revolutionaries of the world to unite, to aid them and to join in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Golcondist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist = true; 
RiziaDLCText.IndependentZille = "Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille", "Theocratic Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille","Theocratic Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Wruhecist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist = true;
RiziaDLCText.IndependentZille = "Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille", "Religious Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille","Religious Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Bludish = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish = true;
RiziaDLCText.IndependentZille = "Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille", "Presidential Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille","Presidential Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Liberation = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation = true;
RiziaDLCText.IndependentZille = "Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Neutral");
UpdateCountryPresident("Rizia_Country_Zille", "Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille", "Parliamentary Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Neutral");
UpdateCountryPresident("Rizia_Country_Zille","Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille","Parliamentary Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony = true;
RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered = true; RiziaDLC.ZilleReturn_Success = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered"] = true;
Variable["RiziaDLC.ZilleReturn_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[323]`
Mówca: **Narrator**
> "Lucita's fists were clenched tight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Narrator**
> "The staff had sourced a bottle of very rare champagne for me, as well as a golden saber to open it with. They didn't yet know about my sobriety."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Gone == false && RiziaDLC.Pabel_Lord == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Narrator**
> "At least the staff had managed to source a bottle of very rare champagne for me, as well as a golden saber to open it with."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[335]`
Mówca: **Narrator**
> "Lucita kissed my cheek as she sat down beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_ArmedResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_ArmedResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[339]`
Mówca: **Taddeus Azaro**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[340]`
Mówca: **Lucita Azaro**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[341]`
Mówca: **Titus Gordion**
> ""However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Won"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[343]`
Mówca: **Laurento Esquibel**
> ""I must go as well, Your Majesty. The sooner we begin preparing the official concession of the region to Wehlen, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing. I can't wait to celebrate later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? This calls for champagne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[346]`
Mówca: **Laurento Esquibel**
> ""We all deserve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[347]`
Mówca: **Laurento Esquibel**
> ""I've got to get in touch with Zille's foreign ministry right away. But congratulations, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Narrator**
> "He was whistling a jaunty tune as he left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[349]`
Mówca: **Narrator**
> "The staff brought in a bottle, as well as a golden saber with which to open it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Drinking += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["RiziaDLC.PersonalValue_Drinking"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_FreeZille");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_FreeZille");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
