# Sordland/Turn05/NOTES

- **ID konwersacji:** `67`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/067_NOTES.md`
- **Liczba węzłów dialogowych:** 37
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[29]** Ewald Alphonso

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Turn01_InT_Investment_Railway`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[12]`
Mówca: **Ewald Alphonso**
> ""Your refusal to bail out struggling businesses in this climate is a hardline stance, President Rayne. Some might say too hardline.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Ewald Alphonso**
> ""It seems you've been quite generous in bailing out businesses, Anton. Not everyone would agree with that strategy in a recession.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
> ""You've chosen to forego constitutional reform, President Rayne. A decision that speaks volumes about your respect for tradition.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
Mówca: **Ewald Alphonso**
> ""I've heard about your attempts at constitutional reform, Anton. Not an easy path, if I recall correctly.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
> ""Your decision not to align Sordland with the West is a perplexing one, President Rayne. It leaves one questioning your vision for our nation's place in the world.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Ewald Alphonso**
> ""And your foreign policy, Anton. Quite the tightrope walk, isn't it? West, East, or the middle ground?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Ewald Alphonso**
> ""Your decision not to construct a large-scale railway project between our major cities is a stance that confounds me. Such an initiative could have had transformative implications for corporate logistics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
Mówca: **Ewald Alphonso**
> ""Your decision to maintain a stricter immigration policy is a departure from the open and inclusive vision I had for Sordland.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
Mówca: **Ewald Alphonso**
> ""Your choice not to pursue constitutional reform is a conservative stance, differing from my belief that change is necessary for Sordland's advancement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Immigration_Relaxed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[27]`
Mówca: **Ewald Alphonso**
> ""Your choice not to pursue constitutional reform is a conservative stance, differing from my belief that change is necessary for Sordland's advancement.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[34]`
Mówca: **Ewald Alphonso**
> ""Your choice not to pursue constitutional reform is a conservative stance, differing from my belief that change is necessary for Sordland's advancement.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Ewald Alphonso**
> ""Your decision to construct a railway between our major cities is visionary, President Rayne. It will undoubtedly have significant positive implications for corporate logistics.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Ewald Alphonso**
> ""I see you've decided to further relax immigration policies, President Rayne. A choice I find commendable and aligned with the vision I had for Sordland.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Ewald Alphonso**
> ""You've decided to reform the constitution, a brave move. It aligns with my belief that Sordland needs change.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
