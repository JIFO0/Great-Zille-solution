# Rizia/Turn 8/Garden/Vina Non Marriage

- **ID konwersacji:** `420`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/420_Vina_Non_Marriage.md`
- **Liczba węzłów dialogowych:** 30
- **Liczba wyborów gracza:** 3

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_ForcedIntoMarriage`
- `RiziaDLC.Vina_FullCouncilor`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[592] Rizia/Turn 8/Garden/Garden Conversation** (../Turn_08/592_Garden_Conversation.md), Węzeł `[367]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `592` (*Rizia/Turn 8/Garden/Garden Conversation*), Węzeł `[367]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""We haven't gotten a chance to speak since Her Highness' engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_ForcedIntoMarriage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_ForcedIntoMarriage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_ForcedIntoMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_ForcedIntoMarriage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_ForcedIntoMarriage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Vina didn't tell me the full extent of your conversation. But from what I gather, she had no say in the matter whatsoever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""I have to say, I was shocked that you would do such a thing to your own daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""Vina didn't tell me the full extent of your conversation. But from what I gather, this was necessary for the sake of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""I also have a sneaking suspicion that more went on between them in Pales than Her Highness was willing to admit at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""At any rate... it goes without saying that my family is disappointed. But I don't want this to affect our professional relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""We haven't gotten a chance to speak since you refused to allow Her Highness and myself to marry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Manus Sazon**
> ""Her Highness assured me that you gave her a choice in the matter. All I could do was wish her and her new fiance the best of luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""Her Highness assured me that there were legitimate reasons behind your decision. All I could do was wish her the best of luck in her new position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""Vina didn't tell me the full extent of your conversation. But she seemed quite shaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina will be fine, Mr. Sazon. I made this decision for her own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish things had gone differently as well. But what's done is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured, it's nothing personal. I won't let it affect our working relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "His expression darkened. He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
