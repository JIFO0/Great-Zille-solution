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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[25]` | **""Vina will be fine, Mr. Sazon. I made this decision for her own good.""** | `[11]` **Manus Sazon**: ""I have to say, I was shocked th..."<br>`[24]` **Manus Sazon**: ""Vina didn't tell me the full ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "His expression darkened. He nodded." |
| `[26]` | **""I wish things had gone differently as well. But what's done is done.""** | `[11]` **Manus Sazon**: ""I have to say, I was shocked th..."<br>`[24]` **Manus Sazon**: ""Vina didn't tell me the full ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "His expression darkened. He nodded." |
| `[27]` | **""Rest assured, it's nothing personal. I won't let it affect our working relationsh..."** | `[11]` **Manus Sazon**: ""I have to say, I was shocked th..."<br>`[24]` **Manus Sazon**: ""Vina didn't tell me the full ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "His expression darkened. He nodded." |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""We haven't gotten a chance to speak since Her Highness' engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_ForcedIntoMarriage == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Manus Sazon: ""We haven't gotten a chance to speak since Her Highness' ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""We haven't gotten a chance to speak since you refused to..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_ForcedIntoMarriage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_ForcedIntoMarriage == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_ForcedIntoMarriage == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_ForcedIntoMarriage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_ForcedIntoMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""Vina didn't tell me the full extent of your conversation..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_ForcedIntoMarriage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_ForcedIntoMarriage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Manus Sazon: ""Vina didn't tell me the full extent of your conversation..."*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Vina didn't tell me the full extent of your conversation. But from what I gather, she had no say in the matter whatsoever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Manus Sazon: ""I have to say, I was shocked that you would do such a th..."*)

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""I have to say, I was shocked that you would do such a thing to your own daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Vina will be fine, Mr. Sazon. I made this decision for h..."*)
  - -> `[26]` (*Player_Romus: ""I wish things had gone differently as well. But what's d..."*)
  - -> `[27]` (*Player_Romus: ""Rest assured, it's nothing personal. I won't let it affe..."*)

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""Vina didn't tell me the full extent of your conversation. But from what I gather, this was necessary for the sake of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: ""I also have a sneaking suspicion that more went on betwe..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Manus Sazon: ""Her Highness assured me that you gave her a choice in th..."*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""I also have a sneaking suspicion that more went on between them in Pales than Her Highness was willing to admit at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""At any rate... it goes without saying that my family is ..."*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""At any rate... it goes without saying that my family is disappointed. But I don't want this to affect our professional relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""We haven't gotten a chance to speak since you refused to allow Her Highness and myself to marry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_Duch..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_Duch..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_Du..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Manus Sazon: ""Her Highness assured me that there were legitimate reaso..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FullCouncilor == true || RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Manus Sazon: ""Vina didn't tell me the full extent of your conversation..."*)

### Węzeł `[22]`
Mówca: **Manus Sazon**
> ""Her Highness assured me that you gave her a choice in the matter. All I could do was wish her and her new fiance the best of luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""At any rate... it goes without saying that my family is ..."*)

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""Her Highness assured me that there were legitimate reasons behind your decision. All I could do was wish her the best of luck in her new position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""At any rate... it goes without saying that my family is ..."*)

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""Vina didn't tell me the full extent of your conversation. But she seemed quite shaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Vina will be fine, Mr. Sazon. I made this decision for h..."*)
  - -> `[26]` (*Player_Romus: ""I wish things had gone differently as well. But what's d..."*)
  - -> `[27]` (*Player_Romus: ""Rest assured, it's nothing personal. I won't let it affe..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina will be fine, Mr. Sazon. I made this decision for her own good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon), `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "His expression darkened. He nodded."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish things had gone differently as well. But what's done is done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon), `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "His expression darkened. He nodded."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured, it's nothing personal. I won't let it affect our working relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon), `[24]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "His expression darkened. He nodded."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "His expression darkened. He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Manus Sazon: ""I understand, Your Majesty.""*)

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
