# Rizia/Turn 5/Notes

- **ID konwersacji:** `325`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Rizia/Turn_05/325_Notes.md`
- **Liczba węzłów dialogowych:** 37
- **Liczba wyborów gracza:** 11

---

## 1. Uczestnicy Sceny

- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Turn03_Security_TitusLeadsInvestigation`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegration`
- `RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSupport`
- `RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram`
- `RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses`
- `RiziaDLC.Turn05_Security_ReducePolicePresence`
- `RiziaDLCSupport.Journal_Turn05_Security_IzaExpandSocialPrograms`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""We should look into expanding social programs for our new arrivals.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Lucita Azaro**: ""I agree. I have no doubt that w..."<br>`[14]` **Lucita Azaro**: ""I agree with you. It's sure to ..." |
| `[9]` | **""I understand your concern, but the name of the game here is compromise. We don't ..."** | `[8]` **Hugo Toras**: ""Yes. However, while such a prop..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucita Azaro**: ""Is there a particular program y..." |
| `[10]` | **""I've made my decision.""** | `[8]` **Hugo Toras**: ""Yes. However, while such a prop..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lucita Azaro**: ""Is there a specific program you..." |
| `[11]` | **""I disagree. History has shown that the smallest of actions can create profound po..."** | `[8]` **Hugo Toras**: ""Yes. However, while such a prop..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucita Azaro**: ""Is there a particular program y..." |
| `[21]` | **""Let's prioritize a food program.""** | `[18]` **Lucita Azaro**: ""Is there a particular program y..."<br>`[19]` **Lucita Azaro**: ""Is there a specific program you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodP...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | *Koniec sceny / Terminal* |
| `[22]` | **""Let's prioritize language courses.""** | `[18]` **Lucita Azaro**: ""Is there a particular program y..."<br>`[19]` **Lucita Azaro**: ""Is there a specific program you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_Langu...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | *Koniec sceny / Terminal* |
| `[23]` | **""Let's prioritize employment support.""** | `[18]` **Lucita Azaro**: ""Is there a particular program y..."<br>`[19]` **Lucita Azaro**: ""Is there a specific program you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_Emplo...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | *Koniec sceny / Terminal* |
| `[24]` | **""Let's prioritize cultural integration programs.""** | `[18]` **Lucita Azaro**: ""Is there a particular program y..."<br>`[19]` **Lucita Azaro**: ""Is there a specific program you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_Cultu...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | *Koniec sceny / Terminal* |
| `[33]` | **""Such as?""** | `[12]` **Lucita Azaro**: ""In addition, such social progra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucita Azaro**: ""Providing food assistance and m..." |
| `[35]` | **""What specifically?""** | `[12]` **Lucita Azaro**: ""In addition, such social progra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucita Azaro**: ""Providing food assistance and m..." |
| `[36]` | **""What sort of programs were you thinking?""** | `[12]` **Lucita Azaro**: ""In addition, such social progra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucita Azaro**: ""Providing food assistance and m..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: ""We should look into expanding social programs for our new arrivals.""]** — Mówca: **Player_Romus**
> ""We should look into expanding social programs for our new arrivals. If one can't put food on their table, it's easy to see why they'd take to the streets in protest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucita Azaro: ""I agree. I have no doubt that will have a positive impac..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucita Azaro: ""I agree with you. It's sure to have a positive impact on..."*)

### Węzeł `[7]`
Mówca: **Lucita Azaro**
> ""I agree. I have no doubt that will have a positive impact on the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""In addition, such social programs will help reduce the f..."*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Yes. However, while such a proposal may offer some relief, I still don't believe it gets to the heart of what driving the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""I've made my decision.""*)
  - -> `[9]` (*Player_Romus: ""I understand your concern, but the name of the game here..."*)
  - -> `[11]` (*Player_Romus: ""I disagree. History has shown that the smallest of actio..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your concern, but the name of the game here is compromise. We don't want to do anything that will rock the boat too drastically.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucita Azaro: ""Is there a particular program you wish to focus on? Keep..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've made my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucita Azaro: ""Is there a specific program you'd like to prioritize? Pl..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. History has shown that the smallest of actions can create profound positive change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucita Azaro: ""Is there a particular program you'd like to single out? ..."*)

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""In addition, such social programs will help reduce the financial burden placed on migrants, and reduce the prevalence of underground, illicit activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""What specifically?""*)
  - -> `[33]` (*Player_Romus: ""Such as?""*)
  - -> `[36]` (*Player_Romus: ""What sort of programs were you thinking?""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1; RiziaDLC.Turn05_Security_ReducePolicePresence = true; RiziaDLCSupport.Journal_Turn05_Security_IzaExpandSocialPrograms = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Turn05_Security_ReducePolicePresence"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_IzaExpandSocialPrograms"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
Mówca: **Lucita Azaro**
> ""I agree with you. It's sure to have a positive impact on the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""It might, however, we don't have the funds to support su..."*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""It might, however, we don't have the funds to support such an endeavor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""Another approach may be in order.""*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""Another approach may be in order.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Titus Gordion**
> ""Language courses and cultural integration programs to help migrants adapt to their new environment might also be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Yes. However, while such a proposal may offer some relie..."*)

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""Is there a particular program you wish to focus on? Keep in mind, our budget is limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Let's prioritize a food program.""*)
  - -> `[23]` (*Player_Romus: ""Let's prioritize employment support.""*)
  - -> `[22]` (*Player_Romus: ""Let's prioritize language courses.""*)
  - -> `[24]` (*Player_Romus: ""Let's prioritize cultural integration programs.""*)

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""Is there a specific program you'd like to prioritize? Please remember, we have budget constraints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Let's prioritize a food program.""*)
  - -> `[23]` (*Player_Romus: ""Let's prioritize employment support.""*)
  - -> `[22]` (*Player_Romus: ""Let's prioritize language courses.""*)
  - -> `[24]` (*Player_Romus: ""Let's prioritize cultural integration programs.""*)

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""Is there a particular program you'd like to single out? Let's keep in mind our budget limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Let's prioritize a food program.""*)
  - -> `[23]` (*Player_Romus: ""Let's prioritize employment support.""*)
  - -> `[22]` (*Player_Romus: ""Let's prioritize language courses.""*)
  - -> `[24]` (*Player_Romus: ""Let's prioritize cultural integration programs.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize a food program.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucita Azaro), `[19]` (Lucita Azaro), `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram = t..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize language courses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucita Azaro), `[19]` (Lucita Azaro), `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize employment support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucita Azaro), `[19]` (Lucita Azaro), `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSuppo..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize cultural integration programs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucita Azaro), `[19]` (Lucita Azaro), `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegra..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Turn05_Security_..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSupport = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Turn05_Security_..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Turn05_Security_..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegration = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Turn05_Security_..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Titus Gordion: ""Language courses and cultural integration programs to he..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucita Azaro: ""And language courses and cultural integration programs t..."*)

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""And language courses and cultural integration programs to help migrants adapt to their new environment could also be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Yes. However, while such a proposal may offer some relie..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such as?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucita Azaro: ""Providing food assistance and meal programs for migrants..."*)

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""Providing food assistance and meal programs for migrants who may face economic challenges, for one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""Assisting migrants in finding and retaining employment, ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What specifically?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucita Azaro: ""Providing food assistance and meal programs for migrants..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sort of programs were you thinking?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucita Azaro: ""Providing food assistance and meal programs for migrants..."*)

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""Assisting migrants in finding and retaining employment, including resume building and interview training, is another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true"*)
