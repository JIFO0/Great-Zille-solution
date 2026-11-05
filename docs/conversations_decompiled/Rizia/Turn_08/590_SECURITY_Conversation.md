# Rizia/Turn 8/SECURITY/SECURITY Conversation

- **ID konwersacji:** `590`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/590_SECURITY_Conversation.md`
- **Liczba węzłów dialogowych:** 287
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Flagship_Total`
- `RiziaDLC.Army_Unit_Infantry_Total`
- `RiziaDLC.Army_Unit_Ship_Total`
- `RiziaDLC.Army_Unit_Submarine_Total`
- `RiziaDLC.Army_Unit_Support_Total`
- `RiziaDLC.Army_Unit_Tank_Total`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Focus_MilitaryBranch_Airforce`
- `RiziaDLC.Focus_MilitaryBranch_Navy`
- `RiziaDLC.Incident_Naval_RescueBoth`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.War_Control_Skipped`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[281]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **""That doesn't give me any confidence about how things are going down there.""** | `[16]` **Lucita Azaro**: ""The operation will likely come ..." | `Variable["RiziaDLC.War_Control_Skipped"] == true` | *Brak zmian stanu* | `[29]` **Lucita Azaro**: ""Rest assured, Your Majesty, we ..." |
| `[21]` | **""You're right. We'll discuss such matters at the more appropriate juncture.""** | `[16]` **Lucita Azaro**: ""The operation will likely come ..." | `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false` | *Brak zmian stanu* | `[29]` **Lucita Azaro**: ""Rest assured, Your Majesty, we ..." |
| `[26]` | **""Of course. I understand.""** | `[16]` **Lucita Azaro**: ""The operation will likely come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Lucita Azaro**: ""Rest assured, Your Majesty, we ..." |
| `[27]` | **""Thank you, Duchess Azaro.""** | `[16]` **Lucita Azaro**: ""The operation will likely come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Lucita Azaro**: ""Rest assured, Your Majesty, we ..." |
| `[268]` | **""Thank you for the overview.""** | `[123]` **Lucita Azaro**: ""Our submarines can also provide..."<br>`[127]` **Lucita Azaro**: ""Our submarines can also provide..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[269]` | **""I have enough information about our armed forces.""** | `[123]` **Lucita Azaro**: ""Our submarines can also provide..."<br>`[127]` **Lucita Azaro**: ""Our submarines can also provide..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[270]` | **"Let's move on to another topic.""** | `[123]` **Lucita Azaro**: ""Our submarines can also provide..."<br>`[127]` **Lucita Azaro**: ""Our submarines can also provide..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[271]` | **""Thank you for the report, Titus.""** | `[193]` **Titus Gordion**: ""Our submarines can also provide..."<br>`[197]` **Titus Gordion**: ""Our submarines can also provide..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[272]` | **""Thank you for the report, General.""** | `[226]` **Taddeus Azaro**: ""Our submarines can also offer c..."<br>`[267]` **Taddeus Azaro**: ""Our submarines can also offer c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[273]` | **""Thank you for the report, Duchess.""** | `[123]` **Lucita Azaro**: ""Our submarines can also provide..."<br>`[127]` **Lucita Azaro**: ""Our submarines can also provide..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucita Azaro: ""With all due respect, Your Majesty, considering our curr..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Titus Gordion: ""Sir.""*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Taddeus Azaro: ""Of course.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[13]`
Mówca: **Titus Gordion**
> ""Sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[14]`
Mówca: **Taddeus Azaro**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[15]`
Mówca: **Lucita Azaro**
> ""With all due respect, Your Majesty, considering our current situation, I'd rather leave such sensitive information to the war meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == true"*)

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""The operation will likely come to an end very soon -- we can go over specifics after the council meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == true"*)
  - -> `[26]` (*Player_Romus: ""Of course. I understand.""*)
  - -> `[27]` (*Player_Romus: ""Thank you, Duchess Azaro.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't give me any confidence about how things are going down there.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Control_Skipped"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""Rest assured, Your Majesty, we will be victorious. No ma..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Control_Skipped == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""The operation will likely come to an end very soon -- we..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Control_Skipped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucita Azaro: ""As the acting commander of our armed forces, you must be..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We'll discuss such matters at the more appropriate juncture.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""Rest assured, Your Majesty, we will be victorious. No ma..."*)

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""As the acting commander of our armed forces, you must be briefed by the general staff directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""The operation will likely come to an end very soon -- we..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Control_Skipped == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""That doesn't give me any confidence about how things are..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Control_Skipped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""You're right. We'll discuss such matters at the more app..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""Rest assured, Your Majesty, we will be victorious. No ma..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duchess Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""Rest assured, Your Majesty, we will be victorious. No ma..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "She gave a military salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""Thank you for your service, Duchess.""*)

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""Rest assured, Your Majesty, we will be victorious. No matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "She gave a military salute."*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Thank you for your service, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Taddeus Azaro: ""Rizian armed forces have emerged as a formidable power, ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average ==..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Taddeus Azaro: ""Rizian armed forces stand ready and strong. However, we ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Taddeus Azaro: ""Rizian Armed Forces is in a sad state, Your Majesty. We ..."*)

### Węzeł `[37]`
Mówca: **Taddeus Azaro**
> ""Rizian armed forces have emerged as a formidable power, boasting superior capabilities compared to most neighboring nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[38]`
Mówca: **Taddeus Azaro**
> ""Rizian armed forces stand ready and strong. However, we still lag significantly behind some of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[39]`
Mówca: **Taddeus Azaro**
> ""Rizian Armed Forces is in a sad state, Your Majesty. We are completely behind our neighbors in military capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Titus Gordion: ""The general staff is content with the situation of the R..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average ==..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Titus Gordion: ""Rizian armed forces stand ready and strong. However, we ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Titus Gordion: ""The general staff is very disappointed about the state o..."*)

### Węzeł `[46]`
Mówca: **Titus Gordion**
> ""The general staff is content with the situation of the Rizian Armed Forces. We possess higher capabilities than most of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[47]`
Mówca: **Titus Gordion**
> ""Rizian armed forces stand ready and strong. However, we still lag significantly behind some of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[48]`
Mówca: **Titus Gordion**
> ""The general staff is very disappointed about the state of the Rizian Armed Forces. We are completely behind our neighbors in military capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""Rizian armed forces have emerged as a formidable power, ..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average ==..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucita Azaro: ""Rizian armed forces stand ready and strong. However, we ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""The Rizian Armed Forces require investment. We are compl..."*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""Rizian armed forces have emerged as a formidable power, boasting superior capabilities compared to most neighboring nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Rizian armed forces stand ready and strong. However, we still lag significantly behind some of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""The Rizian Armed Forces require investment. We are completely behind our neighbors in military capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total >= 10)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucita Azaro: ""At present, we can mobilize a large number of infantry d..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 8"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 8"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total >= 8)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucita Azaro: ""At present, we can deploy approximately eight to nine fu..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total > 5"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total > 5"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total > 5)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucita Azaro: ""At present, we can deploy approximately eight to nine fu..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucita Azaro: ""At present, we can deploy five fully equipped infantry d..."*)

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""At present, we can mobilize a large number of infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""At present, we can deploy approximately eight to nine fully equipped infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[69]`
Mówca: **Lucita Azaro**
> ""At present, we can deploy approximately eight to nine fully equipped infantry divisions. However, our numbers are limited, signaling a need for expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[70]`
Mówca: **Lucita Azaro**
> ""At present, we can deploy five fully equipped infantry divisions, which I believe is insufficient. We should look for ways to increase this number as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 7)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucita Azaro: ""Thankfully, we possess a vast number of mechanized suppo..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 5"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 5"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 5)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""Thankfully, we possess a substantial number of mechanize..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 3"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 3"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total > 3)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucita Azaro: ""On the other hand, we also have a modest amount of mecha..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""Unfortunately, we can only field three mechanized suppor..."*)

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""Thankfully, we possess a vast number of mechanized support divisions specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""And as far as our tanks are concerned...""*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Thankfully, we possess a substantial number of mechanized support divisions specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""And as far as our tanks are concerned...""*)

### Węzeł `[82]`
Mówca: **Lucita Azaro**
> ""On the other hand, we also have a modest amount of mechanized support divisions that are specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucita Azaro: ""Taking this into account, it would create substantial di..."*)

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""Unfortunately, we can only field three mechanized support divisions specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucita Azaro: ""Taking this into account, it would create substantial di..."*)

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""Taking this into account, it would create substantial difficulties in defending ourselves in the event of a military conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""And as far as our tanks are concerned...""*)

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""And as far as our tanks are concerned...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Tank_Total >= 6"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Tank_Total >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Tank_Total >= 6"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Tank_Total >= 6)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Tank_Total >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucita Azaro: ""Our tank divisions outnumber all of our neighbors except..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Tank_Total >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 4"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 4"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 4)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""We can comfortably field enough divisions to support our..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 1"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 1"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 1)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucita Azaro: ""We operate with limited divisions, while our neighbors' ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""We have no divisions in place, whereas our neighbors' in..."*)

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""Our tank divisions outnumber all of our neighbors except Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""We can comfortably field enough divisions to support our infantry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[97]`
Mówca: **Lucita Azaro**
> ""We operate with limited divisions, while our neighbors' inventory far surpasses ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She sighed."*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""We have no divisions in place, whereas our neighbors' inventory is well stocked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She sighed."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""On the other hand, our air force is fully capable of challenging regional powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""On the other hand, our air force is fully capable of cha..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucita Azaro: ""In contrast, the Rizian air force is barely capable of c..."*)

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""In contrast, the Rizian air force is barely capable of contesting Palesian air superiority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Flagship_Total == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Flagship_Total == 1)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Flagship_Total == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucita Azaro: ""And lastly, steering our navy is our flagship, the RRN V..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Flagship_Total == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""And lastly, steering our navy is our flagship, the RRN Valero -- the most prized asset of the whole Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""And lastly, our navy has unfortunately suffered a significant loss with the flagship RRN Valero being taken out of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""It's also important to highlight that despite significant investments in our navy, we still lack access to cutting-edge Valgish tech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Navy == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""It's also important to highlight that despite significan..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Navy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Ship_Total >= 5)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucita Azaro: ""Luckily, our fleet has a considerable number of destroye..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Ship_Total >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 3"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 3"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Ship_Total >= 3)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""Luckily, our fleet is capable of contesting our immediat..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Ship_Total >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucita Azaro: ""Unfortunately, our fleet is short on ships to effectivel..."*)

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""Luckily, our fleet has a considerable number of destroyers -- pivotal for projecting power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Luckily, our fleet is capable of contesting our immediate neighbors at critical locations, if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""Unfortunately, our fleet is short on ships to effectively project power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Our submarines can also provide crucial support -- enough to effectively defend our primary trade routes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[273]` (*Player_Romus: ""Thank you for the report, Duchess.""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Submarine_Total >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Submarine_Total >= 4)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Submarine_Total >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Our submarines can also provide crucial support -- enoug..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Submarine_Total >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""Our submarines can also provide crucial support -- enoug..."*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""Our submarines can also provide crucial support -- enough to cause significant damage despite being few in numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[273]` (*Player_Romus: ""Thank you for the report, Duchess.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total >= 10)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Titus Gordion: ""We can field a significant number of infantry divisions.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 8"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 8"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total >= 8)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""We can deploy approximately eight to nine fully equipped..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total > 5"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total > 5"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total > 5)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Titus Gordion: ""We can deploy approximately eight to nine fully equipped..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Titus Gordion: ""We can deploy five fully equipped infantry divisions, wh..."*)

### Węzeł `[137]`
Mówca: **Titus Gordion**
> ""We can field a significant number of infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""We can deploy approximately eight to nine fully equipped infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[139]`
Mówca: **Titus Gordion**
> ""We can deploy approximately eight to nine fully equipped infantry divisions. However, our numbers are limited, signaling a need for expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[140]`
Mówca: **Titus Gordion**
> ""We can deploy five fully equipped infantry divisions, which I believe is insufficient. We should look for ways to increase this number as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 7)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Titus Gordion: ""Thankfully, we possess a vast number of mechanized suppo..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 5"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 5"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 5)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Titus Gordion: ""Thankfully, we possess a substantial number of mechanize..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 3"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 3"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total > 3)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Titus Gordion: ""On the other hand, we also have a modest amount of mecha..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Titus Gordion: ""Regrettably, we can only field three mechanized support ..."*)

### Węzeł `[150]`
Mówca: **Titus Gordion**
> ""Thankfully, we possess a vast number of mechanized support divisions specifically trained to bolster our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Titus Gordion: ""And as for our tanks...""*)

### Węzeł `[151]`
Mówca: **Titus Gordion**
> ""Thankfully, we possess a substantial number of mechanized support divisions specifically trained to bolster our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Titus Gordion: ""And as for our tanks...""*)

### Węzeł `[152]`
Mówca: **Titus Gordion**
> ""On the other hand, we also have a modest amount of mechanized support divisions  that are specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Titus Gordion: ""In light of these factors, it would present a significan..."*)

### Węzeł `[153]`
Mówca: **Titus Gordion**
> ""Regrettably, we can only field three mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Titus Gordion: ""In light of these factors, it would present a significan..."*)

### Węzeł `[154]`
Mówca: **Titus Gordion**
> ""In light of these factors, it would present a significant challenge to defend ourselves should a military conflict arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Titus Gordion: ""And as for our tanks...""*)

### Węzeł `[155]`
Mówca: **Titus Gordion**
> ""And as for our tanks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Tank_Total >= 6"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Tank_Total >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Tank_Total >= 6"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Tank_Total >= 6)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Tank_Total >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Titus Gordion: ""Our tank divisions outnumber all of our neighbors except..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Tank_Total >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 4"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 4"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 4)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Titus Gordion: ""We presently field enough divisions to support our infan..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 2"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 2"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total > 2)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Titus Gordion: "We currently field three divisions, significantly fewer t..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Titus Gordion: ""We operate with only two divisions, while our neighbors'..."*)

### Węzeł `[165]`
Mówca: **Titus Gordion**
> ""Our tank divisions outnumber all of our neighbors except Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[166]`
Mówca: **Titus Gordion**
> ""We presently field enough divisions to support our infantry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[167]`
Mówca: **Titus Gordion**
> "We currently field three divisions, significantly fewer than our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He let out a sigh."*)

### Węzeł `[168]`
Mówca: **Titus Gordion**
> ""We operate with only two divisions, while our neighbors' stock far surpasses our own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He let out a sigh."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[170]`
Mówca: **Titus Gordion**
> ""In contrast, our air force is more than capable of challenging regional powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Titus Gordion: ""In contrast, our air force is more than capable of chall..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Titus Gordion: ""In contrast, Rizia's air force is barely capable of cont..."*)

### Węzeł `[174]`
Mówca: **Titus Gordion**
> ""In contrast, Rizia's air force is barely capable of contesting Palesian air superiority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Flagship_Total == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Flagship_Total == 1)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Flagship_Total == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Titus Gordion: ""And lastly, our navy is spearheaded by our flagship, the..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Flagship_Total == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)

### Węzeł `[178]`
Mówca: **Titus Gordion**
> ""And lastly, our navy is spearheaded by our flagship, the RRN Valero -- -- the most prized asset within the entire Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""And lastly, our navy has unfortunately experienced a significant setback due to the flagship RRN Valero being taken out of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[180]`
Mówca: **Titus Gordion**
> ""It's also important to highlight that despite significant investments in our navy, we still lack access to cutting-edge Valgish technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Navy == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Titus Gordion: ""It's also important to highlight that despite significan..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Navy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Ship_Total >= 5)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Titus Gordion: ""Luckily, our fleet includes a substantial number of dest..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Ship_Total >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 3"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 3"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Ship_Total >= 3)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Titus Gordion: ""Luckily, our fleet is able to contest our immediate neig..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Ship_Total >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Titus Gordion: ""Unfortunately, our fleet lacks the ships necessary to pr..."*)

### Węzeł `[190]`
Mówca: **Titus Gordion**
> ""Luckily, our fleet includes a substantial number of destroyers -- pivotal for projecting power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[191]`
Mówca: **Titus Gordion**
> ""Luckily, our fleet is able to contest our immediate neighbors at critical locations, if needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[192]`
Mówca: **Titus Gordion**
> ""Unfortunately, our fleet lacks the ships necessary to project any significant power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[193]`
Mówca: **Titus Gordion**
> ""Our submarines can also provide essential support -- enough to effectively defend our primary trade routes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[271]` (*Player_Romus: ""Thank you for the report, Titus.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Submarine_Total >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Submarine_Total >= 4)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Submarine_Total >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Titus Gordion: ""Our submarines can also provide essential support -- eno..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Submarine_Total >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Titus Gordion: ""Our submarines can also provide essential support -- eno..."*)

### Węzeł `[197]`
Mówca: **Titus Gordion**
> ""Our submarines can also provide essential support -- enough to cause significant damage despite being few in numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[271]` (*Player_Romus: ""Thank you for the report, Titus.""*)

### Węzeł `[198]`
Mówca: **Taddeus Azaro**
> ""Our current strength allows us to field five fully equipped infantry divisions, which is insufficient. We should look for ways to increase this number as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[199]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, we can only field three mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Taddeus Azaro: ""Given these circumstances, it would pose a considerable ..."*)

### Węzeł `[200]`
Mówca: **Taddeus Azaro**
> ""Given these circumstances, it would pose a considerable challenge to defend ourselves in the event of a military conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Taddeus Azaro: ""And when it comes to our tanks...""*)

### Węzeł `[201]`
Mówca: **Taddeus Azaro**
> ""And when it comes to our tanks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Tank_Total >= 6"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Tank_Total >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Tank_Total >= 6"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Tank_Total >= 6)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Tank_Total >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Taddeus Azaro: ""Our divisions outnumber all of our neighbors except Lesp..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Tank_Total >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 4"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 2"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total > 2)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Taddeus Azaro: ""We currently field three divisions, a figure considerabl..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Taddeus Azaro: ""We operate with only two divisions, while our neighbors'..."*)

### Węzeł `[208]`
Mówca: **Taddeus Azaro**
> ""Our divisions outnumber all of our neighbors except Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[209]`
Mówca: **Taddeus Azaro**
> ""We currently field enough divisions to support our infantry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[210]`
Mówca: **Taddeus Azaro**
> ""We currently field three divisions, a figure considerably lower than that of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He sighed."*)

### Węzeł `[211]`
Mówca: **Taddeus Azaro**
> ""We operate with only two divisions, while our neighbors' arsenal far surpasses our own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He sighed."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)

### Węzeł `[213]`
Mówca: **Taddeus Azaro**
> ""In contrast, our air force is quite capable of challenging regional powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Airforce == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Airforce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Taddeus Azaro: ""In contrast, our air force is quite capable of challengi..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Airforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Taddeus Azaro: ""In contrast, our air force is barely capable of contesti..."*)

### Węzeł `[217]`
Mówca: **Taddeus Azaro**
> ""In contrast, our air force is barely capable of contesting Palesian air superiority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Flagship_Total == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Flagship_Total == 1"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Flagship_Total == 1)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Flagship_Total == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Taddeus Azaro: ""Lastly, at the helm of our navy is our flagship, the RRN..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Flagship_Total == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)

### Węzeł `[221]`
Mówca: **Taddeus Azaro**
> ""Lastly, at the helm of our navy is our flagship, the RRN Valero -- the most prized asset of the whole Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[222]`
Mówca: **Taddeus Azaro**
> ""And lastly, our navy has unfortunately experienced a major setback with the flagship RRN Valero being taken out of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_MilitaryBranch_Navy == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_MilitaryBranch_Navy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Taddeus Azaro: ""It's also important to highlight that despite significan..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_MilitaryBranch_Navy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)

### Węzeł `[226]`
Mówca: **Taddeus Azaro**
> ""Our submarines can also offer crucial support -- enough to effectively defend our primary trade routes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[272]` (*Player_Romus: ""Thank you for the report, General.""*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 10"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total >= 10)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Taddeus Azaro: ""Our current strength allows us to field numerous infantr..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 8"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total >= 8"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total >= 8)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Taddeus Azaro: """Our current strength allows us to deploy approximately ..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total > 5"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Infantry_Total > 5"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Infantry_Total > 5)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Infantry_Total > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Taddeus Azaro: ""Our current strength allows us to deploy approximately e..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Infantry_Total > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Taddeus Azaro: ""Our current strength allows us to field five fully equip..."*)

### Węzeł `[236]`
Mówca: **Taddeus Azaro**
> ""Our current strength allows us to field numerous infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[237]`
Mówca: **Taddeus Azaro**
> """Our current strength allows us to deploy approximately eight to nine fully equipped infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[238]`
Mówca: **Taddeus Azaro**
> ""Our current strength allows us to deploy approximately eight to nine fully equipped infantry divisions. However, our numbers are limited, signaling a need for expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 7"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 7)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Taddeus Azaro: ""Thankfully, we command a vast number of mechanized suppo..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 5"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 5"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 5)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Taddeus Azaro: ""Thankfully, we command a substantial number of mechanize..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 3"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 3"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total > 3)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Taddeus Azaro: ""On the other hand, we command a modest number of mechani..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Taddeus Azaro: ""Unfortunately, we can only field three mechanized suppor..."*)

### Węzeł `[248]`
Mówca: **Taddeus Azaro**
> ""Thankfully, we command a vast number of mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Taddeus Azaro: ""And when it comes to our tanks...""*)

### Węzeł `[249]`
Mówca: **Taddeus Azaro**
> ""Thankfully, we command a substantial number of mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Taddeus Azaro: ""And when it comes to our tanks...""*)

### Węzeł `[250]`
Mówca: **Taddeus Azaro**
> ""On the other hand, we command a modest number of mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Taddeus Azaro: ""Given these circumstances, it would pose a considerable ..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total >= 4"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Support_Total >= 4)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Support_Total >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Taddeus Azaro: ""We currently field enough divisions to support our infan..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Support_Total >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Support_Total > 2"*)

### Węzeł `[254]`
Mówca: **Taddeus Azaro**
> ""It's also important to highlight that despite significant investments in our navy, we still lack access to advanced Valgish technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 5"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Ship_Total >= 5)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Taddeus Azaro: ""Luckily, our fleet boasts a substantial number of destro..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Ship_Total >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 3"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Ship_Total >= 3"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Ship_Total >= 3)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Ship_Total >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Taddeus Azaro: ""Luckily, our fleet is able to contest our immediate neig..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Ship_Total >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Taddeus Azaro: ""Unfortunately, our fleet lacks the ships necessary to ex..."*)

### Węzeł `[261]`
Mówca: **Taddeus Azaro**
> ""Luckily, our fleet boasts a substantial number of destroyers -- a vital component for projecting power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[262]`
Mówca: **Taddeus Azaro**
> ""Luckily, our fleet is able to contest our immediate neighbors at critical locations, if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[263]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, our fleet lacks the ships necessary to exert any significant power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Submarine_Total >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Submarine_Total >= 4"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Submarine_Total >= 4)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Submarine_Total >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Taddeus Azaro: ""Our submarines can also offer crucial support -- enough ..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Submarine_Total >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Taddeus Azaro: ""Our submarines can also offer crucial support -- enough ..."*)

### Węzeł `[267]`
Mówca: **Taddeus Azaro**
> ""Our submarines can also offer crucial support -- enough to cause significant damage despite being few in numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[272]` (*Player_Romus: ""Thank you for the report, General.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the overview.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Lucita Azaro), `[127]` (Lucita Azaro), `[193]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have enough information about our armed forces.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Lucita Azaro), `[127]` (Lucita Azaro), `[193]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Let's move on to another topic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Lucita Azaro), `[127]` (Lucita Azaro), `[193]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the report, Titus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Titus Gordion), `[197]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the report, General.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Taddeus Azaro), `[267]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the report, Duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Lucita Azaro), `[127]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""Thank you for the overview.""*)
  - -> `[269]` (*Player_Romus: ""I have enough information about our armed forces.""*)
  - -> `[270]` (*Player_Romus: "Let's move on to another topic.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_RescueBoth == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Taddeus Azaro: ""And lastly, our navy has unfortunately experienced a maj..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_RescueBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_RescueBoth == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Titus Gordion: ""And lastly, our navy has unfortunately experienced a sig..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_RescueBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_RescueBoth == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucita Azaro: ""And lastly, our navy has unfortunately suffered a signif..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_RescueBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_MilitaryBranch_Navy == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
