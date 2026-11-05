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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Ewald Alphonso: ""It seems you've been quite generous in bailing out busin..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Ewald Alphonso: ""Your refusal to bail out struggling businesses in this c..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Intention == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Ewald Alphonso: ""I've heard about your attempts at constitutional reform,..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ewald Alphonso: ""You've chosen to forego constitutional reform, President..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ewald Alphonso: ""And your foreign policy, Anton. Quite the tightrope walk..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Ewald Alphonso: ""Your decision not to align Sordland with the West is a p..."*)

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
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true || BaseGame.Re..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Ewald Alphonso: ""Your decision to construct a railway between our major c..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ewald Alphonso: ""Your decision not to construct a large-scale railway pro..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Ewald Alphonso: ""I see you've decided to further relax immigration polici..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Ewald Alphonso: ""Your decision to maintain a stricter immigration policy ..."*)

### Węzeł `[27]`
Mówca: **Ewald Alphonso**
> ""Your choice not to pursue constitutional reform is a conservative stance, differing from my belief that change is necessary for Sordland's advancement.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Intention == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Ewald Alphonso: ""You've decided to reform the constitution, a brave move...."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Ewald Alphonso: ""Your choice not to pursue constitutional reform is a con..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true || BaseGame.Re..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true || BaseGame...."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ewald Alphonso: ""Your choice not to pursue constitutional reform is a con..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Ewald Alphonso: ""Your choice not to pursue constitutional reform is a con..."*)

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
