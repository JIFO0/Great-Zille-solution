# Rizia/Turn 7/Angelica Greeting

- **ID konwersacji:** `400`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/400_Angelica_Greeting.md`
- **Liczba węzłów dialogowych:** 71
- **Liczba wyborów gracza:** 14

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Iza_AntiMonarchism`
- `RiziaDLC.Iza_Outcome_MaxOppression`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.SuOmina_OrderedToKillManus`
- `RiziaDLC.VinaManus_Together`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[399] Rizia/Turn 7/A_IzaUniversity** (../Turn_07/399_A_IzaUniversity.md), Węzeł `[1236]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `399` (*Rizia/Turn 7/A_IzaUniversity*), Węzeł `[1236]`

### Węzeł `[3]`
Mówca: **Narrator**
> "She approached me, her demeanor friendly yet cautious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchism > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchism > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Iza_AntiMonarchism"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchism > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Iza_AntiMonarchism"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "She approached me with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Angelica Sazon**
> ""King Romus. We meet at last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[18]`
  - -> `[24]`
  - -> `[34]`
  - -> `[19]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I suddenly remembered watching her give a speech in this very auditorium, nearly 30 years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "The person in front of me was much older, but had the exact same fire in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We meet *again*. I saw you speak when I was studying here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Romus the Merciful, you mean. You're welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.VinaManus_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.VinaManus_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're the mother of my future son-in-law. I couldn't let you rot away on that island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am so sorry about your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Sazon. It is a pleasure to see you here in Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[25]`
Mówca: **Angelica Sazon**
> ""Oh, that's terribly embarrassing. I'm sure I was parroting whatever revolutionary nonsense my husband was filling my head with at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`
  - -> `[33]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your husband. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucas had the right idea. But his methods left something to be desired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't blame him for what he did. Rizia was hungry for change. It still is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[29]`
Mówca: **Angelica Sazon**
> ""Yes, thank you, Your Majesty. I'm happy to be home again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Angelica Sazon**
> ""At the same time, it fills me with shame to think about my last days here. The things my husband did...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Angelica Sazon**
> ""Likewise, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Angelica Sazon**
> ""I watched your coronation from Caleqabiz. It disgusted me to think how close my husband came to keeping you from the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`
  - -> `[33]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were as guilty as your husband was. But you redeemed yourself by turning him in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_OrderedToKillManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_OrderedToKillManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Arrested"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_OrderedToKillManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Arrested"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Angelica Sazon**
> ""Yes, Manus' unfortunate absence has tainted the joy of my return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Angelica Sazon**
> ""I am ashamed to think that he inherited his father's treasonous tendencies. I thought I raised him better than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[33]`
  - -> `[39]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't seriously expect me to believe you don't share those tendencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[40]`
Mówca: **Angelica Sazon**
> ""I wouldn't call it rotting, Your Majesty. Manus and I were treated the same as any other villager on Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "She looked fondly at Manus and Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Angelica Sazon**
> ""But yes, it warms my heart to see my son and the Crown Princess so happy together. A sign that our houses are finally reconciling after my husband's shameful act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[28]`

### Węzeł `[43]`
Mówca: **Angelica Sazon**
> ""I won't pretend his words never swayed me. But when I became pregnant I realized some things are more important than revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[44]`
Mówca: **Angelica Sazon**
> ""A revolution bought with blood will never succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Her eyes traveled past me to the heavily armed officers patrolling the auditorium aisles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[46]`
Mówca: **Angelica Sazon**
> ""A revolution bought with blood will never succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Angelica Sazon**
> ""I was about to become a mother. That mattered more to me than any revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Angelica Sazon**
> ""Maybe I did once. But when I became pregnant I realized some things are more important than revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_Outcome_MaxOppression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_Outcome_MaxOppression == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Iza_Outcome_MaxOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Iza_Outcome_MaxOppression == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Iza_Outcome_MaxOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Narrator**
> "A flash of sorrow crossed her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Her eyes traveled past me to her son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Angelica Sazon**
> ""I should be getting to my seat. We will speak again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[64]`
  - -> `[63]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Her eyes traveled past me to Rico, who was already sitting onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can change Rizia together. It's not too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll get your seat, all right. Sooner than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy the festivities, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Try not to blame yourself for what happened. Focus on the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
Mówca: **Angelica Sazon**
> ""Please, Your Majesty. Call me Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Narrator**
> "She nodded, stepped away and continued down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[68]`
Mówca: **Narrator**
> "With a confused look, she continued down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[69]`
Mówca: **Narrator**
> "She stepped away from me and continued down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[70]`
Mówca: **Angelica Sazon**
> ""I will. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
