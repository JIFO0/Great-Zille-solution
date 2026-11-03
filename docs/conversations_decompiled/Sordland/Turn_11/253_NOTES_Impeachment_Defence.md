# Sordland/Turn11/NOTES Impeachment Defence

- **ID konwersacji:** `253`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/253_NOTES_Impeachment_Defence.md`
- **Liczba węzłów dialogowych:** 36
- **Liczba wyborów gracza:** 1

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[36]** Heron Garaci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal`
- `BaseGame.LeakedScandal_SecretState_KillFrensRicter`
- `BaseGame.LeakedScandal_SecretState_KillKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_KillLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_KillOrsoHawker`
- `BaseGame.LeakedScandal_SecretState_KillPetrVectern`
- `BaseGame.LeakedScandal_Testify_ACP`
- `BaseGame.Leaker_LucianGalade`
- `BaseGame.Petr_Dead`
- `BaseGame.Petr_isVP`
- `BaseGame.Relations_Serge_TalkSoured`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn09_MilitaryParade_SergeDead`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
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
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true && BaseGame.Leaker_LucianGalade == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true && BaseGame.Leaker_LucianGalade == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  and  Variable["BaseGame.Leaker_LucianGalade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true && BaseGame.Leaker_LucianGalade == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  and  Variable["BaseGame.Leaker_LucianGalade"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true
|| BaseGame.Petr_Dead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true
|| BaseGame.Petr_Dead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true
 or  Variable["BaseGame.Petr_Dead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true
|| BaseGame.Petr_Dead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true
 or  Variable["BaseGame.Petr_Dead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Petr entered the room with the gesture of the guards."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_isVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_isVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Petr_isVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Petr_isVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Petr_isVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Petr entered the room with the gesture of the guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == false && BaseGame.Relations_Serge_TalkSoured == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == false && BaseGame.Relations_Serge_TalkSoured == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == false  and  Variable["BaseGame.Relations_Serge_TalkSoured"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == false && BaseGame.Relations_Serge_TalkSoured == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == false  and  Variable["BaseGame.Relations_Serge_TalkSoured"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Narrator**
> "Serge entered the room with the gesture of the guards."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Testify_ACP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Testify_ACP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Testify_ACP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Testify_ACP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Testify_ACP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Ovid Grecer**
*(Węzeł logiki narracyjnej: Ovid Grecer: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Heron Garaci**
> """
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: Orso Hawker: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
*(Węzeł logiki narracyjnej: Player: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
