# Rizia/Turn 9/Pabel Extradition

- **ID konwersacji:** `438`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/438_Pabel_Extradition.md`
- **Liczba węzłów dialogowych:** 80
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Success`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLC.Vina_Escapes`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Pabel_Arrested`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLCSupport.Journal_Turn09_Derdia_PabelExtradition`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[435] Rizia/Turn 9/FPnT_Mediation** (../Turn_09/435_FPnT_Mediation.md), Węzeł `[9]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Is it the Princess?""** | `[4]` **Jorga Azmal**: ""Your Majesty... did you know th..." | `Variable["RiziaDLC.Vina_Escapes"] == true` | *Brak zmian stanu* | `[16]` **Jorga Azmal**: ""No. A man by the name of Pabel ..." |
| `[9]` | **""I did not know that. But it does not come as surprising news.""** | `[4]` **Jorga Azmal**: ""Your Majesty... did you know th..."<br>`[73]` **Narrator**: "He stood up, shook my hand and l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Jorga Azmal**: ""I presume it is someone involve..."<br>`[33]` **Jorga Azmal**: ""Then you know that I cannot hel..." |
| `[10]` | **""What? You must extradite this person immediately.""** | `[4]` **Jorga Azmal**: ""Your Majesty... did you know th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Jorga Azmal**: ""That may be possible.""<br>`[22]` **Jorga Azmal**: ""That won't be possible."" |
| `[11]` | **""My butler Pabel Adria, I presume? He mentioned he had friends there.""** | `[4]` **Jorga Azmal**: ""Your Majesty... did you know th..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[15]` **Jorga Azmal**: ""None other."" |
| `[24]` | **""He assisted in my daughter's disappearance. He might have information about where..."** | `[33]` **Jorga Azmal**: ""Then you know that I cannot hel..."<br>`[64]` **Jorga Azmal**: ""I do not want to put a taint on..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Vina_Escapes"] == true` | *Brak zmian stanu* | `[66]` **Narrator**: "Azmal shook his head." |
| `[34]` | **""Thank you, Supreme Wiseman. Nobody betrays the King of Rizia without consequences.""** | `[23]` **Jorga Azmal**: ""The man, Pabel Adria, claims he..."<br>`[28]` **Jorga Azmal**: ""Mr. Adria claims he will be unj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Jorga Azmal**: ""Very well. I'll give the orders..." |
| `[35]` | **""No, leave him be. Punishing him would accomplish nothing.""** | `[23]` **Jorga Azmal**: ""The man, Pabel Adria, claims he..."<br>`[28]` **Jorga Azmal**: ""Mr. Adria claims he will be unj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "Azmal nodded." |
| `[36]` | **""Yes, send him here. He was complicit in my daughter's escape. He might have infor..."** | `[23]` **Jorga Azmal**: ""The man, Pabel Adria, claims he..."<br>`[28]` **Jorga Azmal**: ""Mr. Adria claims he will be unj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Jorga Azmal**: ""Very well. I'll give the orders..." |
| `[40]` | **""You don't understand. Nobody betrays the King of Rizia and gets away with it.""** | `[33]` **Jorga Azmal**: ""Then you know that I cannot hel..."<br>`[64]` **Jorga Azmal**: ""I do not want to put a taint on..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Azmal shook his head." |
| `[41]` | **""How can you say that? Do you even know what he did?""** | `[33]` **Jorga Azmal**: ""Then you know that I cannot hel..."<br>`[64]` **Jorga Azmal**: ""I do not want to put a taint on..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Azmal shook his head." |
| `[45]` | **""I would not expect your assistance in this matter. What happened is between Mr. A..."** | `[33]` **Jorga Azmal**: ""Then you know that I cannot hel..."<br>`[64]` **Jorga Azmal**: ""I do not want to put a taint on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "Azmal nodded sagely." |
| `[48]` | **""I don't understand. Are you saying my butler was a homosexual?""** | `[43]` **Jorga Azmal**: ""Without exception."" | `Variable["RiziaDLC.Relations_Pabel_Together"] == false  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == false` | *Brak zmian stanu* | `[47]` **Jorga Azmal**: ""We do not use such labels in De..." |
| `[52]` | **""I understand. May God forgive him, then.""** | `[43]` **Jorga Azmal**: ""Without exception."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Jorga Azmal**: ""I will not ask you to change yo..." |
| `[53]` | **""Love wasn't his crime. Abetting my daughter's escape was.""** | `[43]` **Jorga Azmal**: ""Without exception."" | `Variable["RiziaDLC.Vina_Escapes"] == true` | *Brak zmian stanu* | `[59]` **Jorga Azmal**: ""And yet Rizia would have him pu..." |
| `[60]` | **""The most sacred form of love is between a man and a woman.""** | `[43]` **Jorga Azmal**: ""Without exception."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Jorga Azmal**: ""Is that what you believe, Your ..." |
| `[62]` | **""Have you ever actually been with a man, Supreme Wiseman? There's nothing sacred a..."** | `[43]` **Jorga Azmal**: ""Without exception."" | `(Variable["RiziaDLC.Vina_Escapes"] == true) == false` | *Brak zmian stanu* | `[63]` **Jorga Azmal**: ""That is in the eye of the behol..." |

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
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""I did not know that. But it does not come as surprising ..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "The Derdian leader rose to leave, then sat back down with a thoughtful look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Jorga Azmal: ""Your Majesty... did you know that a former member of you..."*)

### Węzeł `[4]`
Mówca: **Jorga Azmal**
> ""Your Majesty... did you know that a former member of your royal household has recently claimed asylum in Derdia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""I did not know that. But it does not come as surprising ..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[10]` (*Player_Romus: ""What? You must extradite this person immediately.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it the Princess?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Jorga Azmal: ""No. A man by the name of Pabel Adria.""*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""Is it the Princess?""*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not know that. But it does not come as surprising news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal), `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? You must extradite this person immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My butler Pabel Adria, I presume? He mentioned he had friends there.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Jorga Azmal: ""None other.""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""My butler Pabel Adria, I presume? He mentioned he had fr..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
Mówca: **Jorga Azmal**
> ""None other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""No. A man by the name of Pabel Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)

### Węzeł `[17]`
Mówca: **Jorga Azmal**
> ""I presume it is someone involved in Princess Vina's recent disappearance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Jorga Azmal: ""This man, Pabel Adria, claims he will be unjustly persec..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality =..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Jorga Azmal: ""That may be possible.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Jorga Azmal: ""That won't be possible.""*)

### Węzeł `[21]`
Mówca: **Jorga Azmal**
> ""That may be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""The man, Pabel Adria, claims he will be unjustly persecu..."*)

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""That won't be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Jorga Azmal: ""As long as he faces danger upon returning to Rizia, Pabe..."*)

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""The man, Pabel Adria, claims he will be unjustly persecuted if he returns to Rizia. But if you deem his crime worthy of punishment, you may have him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Thank you, Supreme Wiseman. Nobody betrays the King of R..."*)
  - -> `[36]` (*Player_Romus: ""Yes, send him here. He was complicit in my daughter's es..."*)
  - -> `[35]` (*Player_Romus: ""No, leave him be. Punishing him would accomplish nothing.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He assisted in my daughter's disappearance. He might have information about where she is.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Jorga Azmal), `[64]` (Jorga Azmal), `[71]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Azmal shook his head."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality =..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Jorga Azmal: ""Mr. Adria claims he will be unjustly persecuted if he re..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Jorga Azmal: ""I do not want to put a taint on what we have accomplishe..."*)

### Węzeł `[28]`
Mówca: **Jorga Azmal**
> ""Mr. Adria claims he will be unjustly persecuted if he returns to Rizia. But if you deem his crime worthy of punishment by your laws, you may have him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Thank you, Supreme Wiseman. Nobody betrays the King of R..."*)
  - -> `[36]` (*Player_Romus: ""Yes, send him here. He was complicit in my daughter's es..."*)
  - -> `[35]` (*Player_Romus: ""No, leave him be. Punishing him would accomplish nothing.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality =..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Jorga Azmal: ""I presume it is someone involved in Princess Vina's rece..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Jorga Azmal: ""Then you know that I cannot help you should you wish Pab..."*)

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""This man, Pabel Adria, claims he will be unjustly persecuted if he returns to Rizia. But if you deem his crime worthy of punishment by your laws, you may have him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Thank you, Supreme Wiseman. Nobody betrays the King of R..."*)
  - -> `[36]` (*Player_Romus: ""Yes, send him here. He was complicit in my daughter's es..."*)
  - -> `[35]` (*Player_Romus: ""No, leave him be. Punishing him would accomplish nothing.""*)

### Węzeł `[33]`
Mówca: **Jorga Azmal**
> ""Then you know that I cannot help you should you wish Pabel Adria's extradition to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[40]` (*Player_Romus: ""You don't understand. Nobody betrays the King of Rizia a..."*)
  - -> `[41]` (*Player_Romus: ""How can you say that? Do you even know what he did?""*)
  - -> `[45]` (*Player_Romus: ""I would not expect your assistance in this matter. What ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Supreme Wiseman. Nobody betrays the King of Rizia without consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal), `[28]` (Jorga Azmal), `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""Very well. I'll give the orders when I arrive back at th..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, leave him be. Punishing him would accomplish nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal), `[28]` (Jorga Azmal), `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Azmal nodded."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, send him here. He was complicit in my daughter's escape. He might have information about where she is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Jorga Azmal), `[28]` (Jorga Azmal), `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""Very well. I'll give the orders when I arrive back at th..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""He assisted in my daughter's disappearance. He might hav..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't understand. Nobody betrays the King of Rizia and gets away with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Jorga Azmal), `[64]` (Jorga Azmal), `[71]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Azmal shook his head."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you say that? Do you even know what he did?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Jorga Azmal), `[64]` (Jorga Azmal), `[71]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Azmal shook his head."*)

### Węzeł `[42]`
Mówca: **Jorga Azmal**
> ""According to the Derdian Constitution, we are obliged to offer sanctuary to those facing persecution due to their practice of the most sacred form of love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Jorga Azmal: ""Without exception.""*)

### Węzeł `[43]`
Mówca: **Jorga Azmal**
> ""Without exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Re..."*)
  - -> `[52]` (*Player_Romus: ""I understand. May God forgive him, then.""*)
  - -> `[60]` (*Player_Romus: ""The most sacred form of love is between a man and a woman.""*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Arrested = true; RiziaDLCSupport.Journal_Turn09_Derdia_PabelExtradition = true; RiziaDLC.Relations_Pabel_Together = false;
EnableCodexEntry("Characters_Others_PabelAdria_Arrested");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_Derdia_PabelExtradition"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;
EnableCodexEntry("Characters_Others_PabelAdria_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He stood up, shook my hand and left the suite."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would not expect your assistance in this matter. What happened is between Mr. Adria and myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Jorga Azmal), `[64]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Azmal nodded sagely."*)

### Węzeł `[46]`
Mówca: **Jorga Azmal**
> ""Wruhec himself would admire your mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He stood up, shook my hand and left the suite."*)

### Węzeł `[47]`
Mówca: **Jorga Azmal**
> ""We do not use such labels in Derdia. And we do not imprison men when a divine spark ignites between them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Jorga Azmal: ""I will not ask you to change your kingdom's laws.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand. Are you saying my butler was a homosexual?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == false`
- **Kontekst wejściowy (poprzednik):** `[43]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Jorga Azmal: ""We do not use such labels in Derdia. And we do not impri..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Relations_Pabel_OutedToPlayer == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Re..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == false && RiziaDLC...."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Relations_Pabel_OutedToPlayer == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""I don't understand. Are you saying my butler was a homos..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Relations_Pabel_OutedToPlayer == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. May God forgive him, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Jorga Azmal: ""I will not ask you to change your kingdom's laws.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Love wasn't his crime. Abetting my daughter's escape was.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Kontekst wejściowy (poprzednik):** `[43]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Jorga Azmal: ""And yet Rizia would have him punished for either.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""Love wasn't his crime. Abetting my daughter's escape was.""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Have you ever actually been with a man, Supreme Wiseman?..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Azmal nodded sagely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Jorga Azmal: ""I will not ask what happened. But I hope the Lord shows ..."*)

### Węzeł `[58]`
Mówca: **Jorga Azmal**
> ""I will not ask what happened. But I hope the Lord shows you both mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He stood up, shook my hand and left the suite."*)

### Węzeł `[59]`
Mówca: **Jorga Azmal**
> ""And yet Rizia would have him punished for either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Jorga Azmal: ""I will not ask you to change your kingdom's laws.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The most sacred form of love is between a man and a woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Jorga Azmal: ""Is that what you believe, Your Majesty? Or are you parro..."*)

### Węzeł `[61]`
Mówca: **Jorga Azmal**
> ""Is that what you believe, Your Majesty? Or are you parroting the words of your flawed Sanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you ever actually been with a man, Supreme Wiseman? There's nothing sacred about it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[43]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Jorga Azmal: ""That is in the eye of the beholder, Your Majesty.""*)

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""That is in the eye of the beholder, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""I do not want to put a taint on what we have accomplished today. But I unfortunately cannot assist in returning him to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[40]` (*Player_Romus: ""You don't understand. Nobody betrays the King of Rizia a..."*)
  - -> `[41]` (*Player_Romus: ""How can you say that? Do you even know what he did?""*)
  - -> `[45]` (*Player_Romus: ""I would not expect your assistance in this matter. What ..."*)

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""Very well. I'll give the orders when I arrive back at the Garrison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Arrested = true; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Azmal shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Jorga Azmal: ""According to the Derdian Constitution, we are obliged to..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Azmal nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Jorga Azmal: ""Wruhec himself would admire your mercy.""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The Derdian leader rose to leave, then sat back down with..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Jorga Azmal: ""May the Lord be with you.""*)

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""As long as he faces danger upon returning to Rizia, Pabel Adria must remain in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[40]` (*Player_Romus: ""You don't understand. Nobody betrays the King of Rizia a..."*)
  - -> `[41]` (*Player_Romus: ""How can you say that? Do you even know what he did?""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Jorga Azmal: ""I will not ask you to change your kingdom's laws.""*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He stood up, shook my hand and left the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[74]`
Mówca: **Jorga Azmal**
> ""I will not ask you to change your kingdom's laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Jorga Azmal: ""But I hope that someday you and your people will see thi..."*)

### Węzeł `[75]`
Mówca: **Jorga Azmal**
> ""But I hope that someday you and your people will see things the way we do. The way St. Wruhec intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He stood up, shook my hand and left the suite."*)

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""May the Lord be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He stood up, shook my hand and left the suite."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || ..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true |..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Jorga Azmal: ""May the Lord be with you.""*)
