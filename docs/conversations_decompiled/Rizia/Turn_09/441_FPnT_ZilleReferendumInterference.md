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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 23

**Główne modyfikowane wskaźniki i kluczowe flagi:**
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
- *...oraz 12 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[14]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] = true; Variable["RiziaDLCSupport.Journa...`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] = true; Variable["RiziaDLCSupport.Jou...`
- Węzeł `[19]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] = true; Variable["RiziaDLCSupport.Jour...`
- Węzeł `[20]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] = true; Variable["RiziaDLCSupport.J...`
- Węzeł `[227]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Lost"] = true; Variable["RiziaDLCSupport.Journal_Turn09_ZilleR...`
- Węzeł `[228]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Won"] = true; Variable["RiziaDLCSupport.Journal_Turn09_ZilleRe...`
- Węzeł `[229]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Lost"] = true; Variable["RiziaDLCSupport.Journal_Turn09_ZilleR...`
- Węzeł `[230]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_Won"] = true; Variable["RiziaDLCSupport.Journal_Turn09_ZilleRe...`
- *...oraz 15 innych węzłów ze skryptami.*

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
  - -> `[308]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was pacing back and forth in the Jales mansion, waiting to hear the results of the army deployment in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I was pacing back and forth in the Jales mansion, waiting to hear the results of our agents' interference in the Zille referendum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true || (RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Fail = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Fail = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Fail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Success = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Army_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Ineffective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Fail = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Fail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Success = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Interfere_Agents_Success"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[21]`
Mówca: **Narrator**
> "There was a knock on the door. I composed myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better bring me good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can someone open that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[28]`
Mówca: **Titus Gordion**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Lucita entered the room again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Narrator**
> "Taddeus entered the room again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Titus entered the room again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Lucita Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Titus Gordion**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""You can relax. I've brought good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[54]`
Mówca: **Taddeus Azaro**
> ""I have good news, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[55]`
Mówca: **Titus Gordion**
> ""I have good news for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[66]`
Mówca: **Taddeus Azaro**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[67]`
Mówca: **Titus Gordion**
> ""I am afraid I have bad news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""You can relax, Your Majesty. I bring good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[75]`
Mówca: **Taddeus Azaro**
> ""You can relax, Your Majesty. I bring good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[76]`
Mówca: **Titus Gordion**
> ""You can relax, Your Majesty. I bring good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""Then the unthinkable happened. The citizens themselves started to push our soldiers back. There was heavy fighting in some areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""As the Wehzek troops were falling back, they intentionally gave all of their equipment to the civilians of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lucita Azaro**
> ""Our soldiers had to fall back from the election centers to regroup. Unfortunately, we were no longer able to shield the referendum from Wehlen's interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[88]`
Mówca: **Taddeus Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Taddeus Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Taddeus Azaro**
> ""Then the unthinkable happened. The citizens themselves started to push our soldiers back. There was heavy fighting in some areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""As the Wehzek troops were falling back, they intentionally gave all of their equipment to the civilians of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""Our soldiers had to fall back from the election centers to regroup. Unfortunately, we were no longer able to shield the referendum from Wehlen's interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""Then the unthinkable happened. The citizens themselves started to push our soldiers back. There was heavy fighting in some areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Titus Gordion**
> ""As the Wehzek troops were falling back, they intentionally gave all of their equipment to the civilians of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Titus Gordion**
> ""Our soldiers had to fall back from the election centers to regroup. Unfortunately, we were no longer able to shield the referendum from Wehlen's interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""We are currently stationed at every single voting center. Our votes are protected. We can be sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Lucita Azaro**
> ""We will get Zille no matter what. I assure you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[102]`
Mówca: **Taddeus Azaro**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[104]`
Mówca: **Taddeus Azaro**
> ""We will get Zille no matter what. I assure you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[105]`
Mówca: **Titus Gordion**
> ""Our troops entered Zille immediately after I gave the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""The Wehzek troops fell back as soon as we entered. We stationed soldiers at each of the election centers to protect the votes and oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[107]`
Mówca: **Titus Gordion**
> ""We are currently stationed at every single voting center. Our votes are protected. We can be sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""We will get Zille no matter what. I assure you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""Unfortunately during the simultaneous raids, the police in Zille managed to identify some of our agents who led them to other agents, uncovering the web.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Lucita Azaro**
> ""Public has been made aware of our interference and now they are blaming us for our meddling. This will significantly impact the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[114]`
Mówca: **Taddeus Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Taddeus Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Taddeus Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Taddeus Azaro**
> ""Unfortunately during the simultaneous raids, the police in Zille managed to identify some of our agents who led them to other agents, uncovering the web.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Taddeus Azaro**
> ""Public has been made aware of our interference and now they are blaming us for our meddling. This will significantly impact the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[119]`
Mówca: **Titus Gordion**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Titus Gordion**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Titus Gordion**
> ""Unfortunately during the simultaneous raids, the police in Zille managed to identify some of our agents who led them to other agents, uncovering the web.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Titus Gordion**
> ""Public has been made aware of our interference and now they are blaming us for our meddling. This will significantly impact the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Lucita Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""No one will not even realize that we were behind the change in votes. The infiltration has been a major success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""In addition, our agents planted various false evidences to point at Wehlen interference to shift away any potential blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[129]`
Mówca: **Taddeus Azaro**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Taddeus Azaro**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Taddeus Azaro**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Taddeus Azaro**
> ""No one will not even realize that we were behind the change in votes. The infiltration has been a major success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Taddeus Azaro**
> ""In addition, our agents planted various false evidences to point at Wehlen interference to shift away any potential blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""We have activated all active personnel deployed in Zille. Undercover agents, spies, resistance fighters, every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Titus Gordion**
> ""They took control of the central election facility where all the votes are counted in along with many smaller facilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Titus Gordion**
> ""We have also intercepted many trucks carrying votes. They have all been taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Titus Gordion**
> ""No one will not even realize that we were behind the change in votes. The infiltration has been a major success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""In addition, our agents planted various false evidences to point at Wehlen interference to shift away any potential blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. At least we tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are all incompetent! You can't even do anything right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[144]`
  - -> `[140]`

### Węzeł `[142]`
Mówca: **Taddeus Azaro**
> ""Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[144]`
  - -> `[140]`

### Węzeł `[143]`
Mówca: **Titus Gordion**
> ""Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[144]`
  - -> `[140]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the one to blame. Responsibility of this lies with me alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You better be right. For your own sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will get it. I am sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent! I knew I could trust you with this task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[149]`
Mówca: **Taddeus Azaro**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[150]`
Mówca: **Titus Gordion**
> ""As you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""I can't let you take the whole blame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[158]`
Mówca: **Taddeus Azaro**
> ""I can't let you take the whole blame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""I can't let you take the whole blame, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""I am very sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[167]`
Mówca: **Taddeus Azaro**
> ""I am very sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[168]`
Mówca: **Titus Gordion**
> ""I am very sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""Thank you for your trust, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[176]`
Mówca: **Taddeus Azaro**
> ""Thank you for your trust, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[177]`
Mówca: **Titus Gordion**
> ""Thank you for your trust, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[184]`
Mówca: **Lucita Azaro**
> ""It will be. Wait and see, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[185]`
Mówca: **Taddeus Azaro**
> ""It will be. Wait and see, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[186]`
Mówca: **Titus Gordion**
> ""It will be. Wait and see, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""I made sure of that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[197]`
Mówca: **Taddeus Azaro**
> ""I made sure of that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[198]`
Mówca: **Titus Gordion**
> ""I made sure of that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[202]`
Mówca: **Narrator**
> "The door opened and Laurento entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[203]`
Mówca: **Narrator**
> "He was holding a sheet of paper above his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Fail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[213]`
Mówca: **Laurento Esquibel**
> ""But there's been another development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[214]`
Mówca: **Laurento Esquibel**
> ""Unfortunately, we lost the referendum by a landslide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[215]`
Mówca: **Laurento Esquibel**
> ""Votes are 64% in favor of joining Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, the results are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[217]`
Mówca: **Laurento Esquibel**
> ""We won the referendum by a landslide thanks to the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Laurento Esquibel**
> ""Votes are 82% in favor of joining Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[219]`
Mówca: **Laurento Esquibel**
> ""Unfortunately, we lost the referendum by a landslide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Laurento Esquibel**
> ""It seems like people reacted very strongly against the army coming in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[221]`
Mówca: **Laurento Esquibel**
> ""It seems like people reacted very strongly against the news of interference by Rizian-backed agents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
Mówca: **Laurento Esquibel**
> ""Please turn on the television.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
Mówca: **Laurento Esquibel**
> ""We won the referendum by a landslide thanks to the agents we activated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Laurento Esquibel**
> ""Votes are 72% in favor of joining Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[225]`
Mówca: **Laurento Esquibel**
> ""Votes are 92% in favor of joining Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "Turn on the TV."]** — Mówca: **Player_Romus_Italic**
> "I turned on the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Lost"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Won"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Lost = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Lost"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Lost"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Won"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Won"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Smolak was making an official state address, blaming Rizia for interfering in the democratic election process."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Agents_Fail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[235]`
Mówca: **Laurento Esquibel**
> ""This will impact our public image heavily, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[238]`
  - -> `[279]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust that you will handle it accordingly, Laurento.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about Smolak? Zille is ours again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He will know my vengeance. I swear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Laurento Esquibel**
> ""I will get to work immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Laurento fell silent as we both absorbed the magnitude of what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Narrator**
> "Calls started ringing in every room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[242]`
Mówca: **Narrator**
> "News traveled fast when it was bad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Taddeus Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Taddeus Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[248]`
Mówca: **Narrator**
> "He said that he was a representative of the 'Zille Liberation Front,' or ZLF."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen to establish a new state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence = true; RiziaDLC.CountryRelation_Wehlen_Unfriendly = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence"] = true;
Variable["RiziaDLC.CountryRelation_Wehlen_Unfriendly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true && RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  and  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[260]`
Mówca: **Narrator**
> "A burst of static gave way to the image of a man in a ski mask sitting on a table, reading from a paper in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[261]`
Mówca: **Narrator**
> "He said that he was broadcasting from the 'Bludish Republic of Zille.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen and establish a state for the Bludish people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[263]`
Mówca: **Narrator**
> "He said that he was broadcasting from the 'Wruhecist Republic of Zille.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen and establish a religious republic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[265]`
Mówca: **Narrator**
> "He said that he was broadcasting from the 'Holy Golcondist Protectorate of Zille.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Narrator**
> "His words sent a chill down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Narrator**
> "Zille was to declare independence from Rizia and Wehlen and establish a religious theocracy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Narrator**
> "I cursed and turned the TV off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[269]`
Mówca: **Narrator**
> "The announcer finished by asking all Golcondists of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[270]`
Mówca: **Narrator**
> "He finished by asking all Wruhecists of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
Mówca: **Narrator**
> "He finished by asking all Bluds of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[272]`
Mówca: **Narrator**
> "He finished by asking all revolutionaries of the world to unite, to aid them, and to join them in their fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Golcondist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist = true;
RiziaDLCText.IndependentZille = "Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille", "Theocratic Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Golcondist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Holy Golcondist Protectorate";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","Wiseman Lucerio Zano");
UpdateCountryGovernment("Rizia_Country_Zille","Theocratic Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Wruhecist = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist = true;
RiziaDLCText.IndependentZille = "Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille", "Religious Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Wruhecist"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Wruhecist Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","President Albero Revic");
UpdateCountryGovernment("Rizia_Country_Zille","Religious Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Bludish = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish = true;
RiziaDLCText.IndependentZille = "Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille", "Presidential Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Bludish"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Bludish Republic of Zille";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","President Farsoun Kara");
UpdateCountryGovernment("Rizia_Country_Zille","Presidential Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Independence_Liberation = true; RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation = true;
RiziaDLCText.IndependentZille = "Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille", "Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille", "Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille", "Parliamentary Republic");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReferendum_Independence_Liberation"] = true;
Variable["RiziaDLCText.IndependentZille"] ="Zille Liberation Front";
EnableToken("Rizia_Country_Zille");
UpdateCountryRelationship("Rizia_Country_Zille","Unfriendly");
UpdateCountryPresident("Rizia_Country_Zille","Prime Minister Lorentia Solv");
UpdateCountryGovernment("Rizia_Country_Zille","Parliamentary Republic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered = true;
RiziaDLC.CountryRelation_Wehlen_Hostile = true; RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered"] = true;
Variable["RiziaDLC.CountryRelation_Wehlen_Hostile"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about Smolak? Zille is lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Good news traveled fast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered = true;
RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony = true;
RiziaDLC.ZilleReturn_Success = true; RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.CountryRelation_Wehlen_Hostile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Nanta_DiscardedBallotsDiscovered"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_Zille_KingsSpeechAndSigningCeremony"] = true;
Variable["RiziaDLC.ZilleReturn_Success"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.CountryRelation_Wehlen_Hostile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && (RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true || RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && (RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true || RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  (Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  or  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance == true && (RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true || RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance"] == true  and  (Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true  or  Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[297]`
Mówca: **Lucita Azaro**
> ""The local branch of Su Omina was exceptionally helpful in making sure they encountered no trouble on their way in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Taddeus Azaro**
> ""The local branch of Su Omina was exceptionally helpful in making sure they encountered no trouble on their way in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Taddeus Azaro**
> ""We are currently stationed at every single voting center. Our votes are protected. We can be sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[306]`
Mówca: **Titus Gordion**
> ""The local branch of Su Omina was exceptionally helpful in making sure they encountered no trouble on their way in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_FreeZille");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_FreeZille");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Interfering with a democratic referendum", "Zille", "Wehlen");)*
- **Efekt (`userScript`):** `SetRichPresence("Interfering with a democratic referendum","Zille","Wehlen");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
