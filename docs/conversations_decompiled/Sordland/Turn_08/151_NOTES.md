# Sordland/Turn08/NOTES

- **ID konwersacji:** `151`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/151_NOTES.md`
- **Liczba węzłów dialogowych:** 40
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn04_RiotGear_Buy`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn07_Results_Decision_RallyAgainstSC`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 20
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
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"]`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"]`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_FrensRicter)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"]`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_FrensRicter))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"]`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RiotGear_Buy))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Ovid Grecer**
> "BFF nuanced some riots"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[25]`
Mówca: **Ovid Grecer**
> "blud rebellion, racial tension"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Ovid Grecer**
> "police massacres + more autocrat nuances"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
Mówca: **Ovid Grecer**
> "needs law enforcement budget checks, security decision checks. how well is the police doing?"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Ovid Grecer**
> "BFF nuanced riots, militants battle"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Ovid Grecer**
> "riots, militants battle"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[36]`
Mówca: **Ovid Grecer**
> "some riots"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_RallyAgainstSC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_RallyAgainstSC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_RallyAgainstSC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Decision_RallyAgainstSC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_RallyAgainstSC"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Ovid Grecer**
> "People rally against SC and stand with Rayne"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
