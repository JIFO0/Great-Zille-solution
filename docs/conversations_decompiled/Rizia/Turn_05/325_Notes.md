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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 5

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[13]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1; Variable["Rizi...`
- Węzeł `[25]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram"] = true;`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSupport"] = true;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses"] = true;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegration"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: ""We should look into expanding social programs for our new arrivals.""]** — Mówca: **Player_Romus**
> ""We should look into expanding social programs for our new arrivals. If one can't put food on their table, it's easy to see why they'd take to the streets in protest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
Mówca: **Lucita Azaro**
> ""I agree. I have no doubt that will have a positive impact on the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Yes. However, while such a proposal may offer some relief, I still don't believe it gets to the heart of what driving the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your concern, but the name of the game here is compromise. We don't want to do anything that will rock the boat too drastically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've made my decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. History has shown that the smallest of actions can create profound positive change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""In addition, such social programs will help reduce the financial burden placed on migrants, and reduce the prevalence of underground, illicit activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[33]`
  - -> `[36]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1; RiziaDLC.Turn05_Security_ReducePolicePresence = true; RiziaDLCSupport.Journal_Turn05_Security_IzaExpandSocialPrograms = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Turn05_Security_ReducePolicePresence"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_IzaExpandSocialPrograms"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
Mówca: **Lucita Azaro**
> ""I agree with you. It's sure to have a positive impact on the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""It might, however, we don't have the funds to support such an endeavor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""Another approach may be in order.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Titus Gordion**
> ""Language courses and cultural integration programs to help migrants adapt to their new environment might also be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""Is there a particular program you wish to focus on? Keep in mind, our budget is limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[23]`
  - -> `[22]`
  - -> `[24]`

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""Is there a specific program you'd like to prioritize? Please remember, we have budget constraints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[23]`
  - -> `[22]`
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""Is there a particular program you'd like to single out? Let's keep in mind our budget limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[23]`
  - -> `[22]`
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize a food program.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize language courses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize employment support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's prioritize cultural integration programs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_FoodProgram"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSupport = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_EmploymentSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_LanguageCourses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegration = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_Decision_IzaSocialProgram_CulturalIntegration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn03_Security_TitusLeadsInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""And language courses and cultural integration programs to help migrants adapt to their new environment could also be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such as?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""Providing food assistance and meal programs for migrants who may face economic challenges, for one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What specifically?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sort of programs were you thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""Assisting migrants in finding and retaining employment, including resume building and interview training, is another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
