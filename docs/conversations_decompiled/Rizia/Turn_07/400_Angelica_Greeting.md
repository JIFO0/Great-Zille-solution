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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **""We meet *again*. I saw you speak when I was studying here.""** | `[8]` **Angelica Sazon**: ""King Romus. We meet at last."" | `Variable["RiziaDLC.Prologue_Studied"] == true` | *Brak zmian stanu* | `[25]` **Angelica Sazon**: ""Oh, that's terribly embarrassin..." |
| `[18]` | **""Romus the Merciful, you mean. You're welcome.""** | `[8]` **Angelica Sazon**: ""King Romus. We meet at last."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Angelica Sazon**: ""Yes, thank you, Your Majesty. I..." |
| `[22]` | **""You're the mother of my future son-in-law. I couldn't let you rot away on that is..."** | `[8]` **Angelica Sazon**: ""King Romus. We meet at last."" | `Variable["RiziaDLC.VinaManus_Together"] == true` | *Brak zmian stanu* | `[40]` **Angelica Sazon**: ""I wouldn't call it rotting, You..." |
| `[23]` | **""I am so sorry about your son.""** | `[8]` **Angelica Sazon**: ""King Romus. We meet at last."" | `Variable["RiziaDLC.Manus_Arrested"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true` | *Brak zmian stanu* | `[37]` **Angelica Sazon**: ""Yes, Manus' unfortunate absence..." |
| `[24]` | **""Duchess Sazon. It is a pleasure to see you here in Iza.""** | `[8]` **Angelica Sazon**: ""King Romus. We meet at last."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Angelica Sazon**: ""Likewise, Your Majesty."" |
| `[26]` | **""Your husband. Right.""** | `[25]` **Angelica Sazon**: ""Oh, that's terribly embarrassin..."<br>`[30]` **Angelica Sazon**: ""At the same time, it fills me w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Angelica Sazon**: ""I won't pretend his words never..." |
| `[27]` | **""Lucas had the right idea. But his methods left something to be desired.""** | `[25]` **Angelica Sazon**: ""Oh, that's terribly embarrassin..."<br>`[30]` **Angelica Sazon**: ""At the same time, it fills me w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Angelica Sazon**: ""A revolution bought with blood ..." |
| `[28]` | **""I don't blame him for what he did. Rizia was hungry for change. It still is.""** | `[25]` **Angelica Sazon**: ""Oh, that's terribly embarrassin..."<br>`[30]` **Angelica Sazon**: ""At the same time, it fills me w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Angelica Sazon**: ""A revolution bought with blood ..." |
| `[33]` | **""You were as guilty as your husband was. But you redeemed yourself by turning him ..."** | `[25]` **Angelica Sazon**: ""Oh, that's terribly embarrassin..."<br>`[30]` **Angelica Sazon**: ""At the same time, it fills me w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Angelica Sazon**: ""I was about to become a mother...." |
| `[39]` | **""You can't seriously expect me to believe you don't share those tendencies.""** | `[38]` **Angelica Sazon**: ""I am ashamed to think that he i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Angelica Sazon**: ""Maybe I did once. But when I be..." |
| `[62]` | **""We can change Rizia together. It's not too late.""** | `[57]` **Angelica Sazon**: ""I should be getting to my seat...." | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true` | *Brak zmian stanu* | `[67]` **Narrator**: "She nodded, stepped away and con..." |
| `[63]` | **""You'll get your seat, all right. Sooner than you think.""** | `[57]` **Angelica Sazon**: ""I should be getting to my seat...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "With a confused look, she contin..." |
| `[64]` | **""Enjoy the festivities, Duchess.""** | `[57]` **Angelica Sazon**: ""I should be getting to my seat...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Angelica Sazon**: ""Please, Your Majesty. Call me A..." |
| `[65]` | **""Try not to blame yourself for what happened. Focus on the future.""** | `[57]` **Angelica Sazon**: ""I should be getting to my seat...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Angelica Sazon**: ""I will. Thank you."" |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchis..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1236]`

### Węzeł `[3]`
Mówca: **Narrator**
> "She approached me, her demeanor friendly yet cautious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchism > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchis..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarch..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchism > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Iza_AntiMonarchism"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "She approached me, her demeanor friendly yet cautious."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true && RiziaDLC.Iza_AntiMonarchism > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Iza_AntiMonarchism"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "She approached me with a smile."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "She approached me with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied"*)

### Węzeł `[8]`
Mówca: **Angelica Sazon**
> ""King Romus. We meet at last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[18]` (*Player_Romus: ""Romus the Merciful, you mean. You're welcome.""*)
  - -> `[24]` (*Player_Romus: ""Duchess Sazon. It is a pleasure to see you here in Iza.""*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_Order..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""We meet *again*. I saw you speak when I was studying here.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I suddenly remembered watching her give a speech in this ..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Angelica Sazon: ""King Romus. We meet at last.""*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I suddenly remembered watching her give a speech in this very auditorium, nearly 30 years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "The person in front of me was much older, but had the exa..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "The person in front of me was much older, but had the exact same fire in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Angelica Sazon: ""King Romus. We meet at last.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We meet *again*. I saw you speak when I was studying here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Angelica Sazon: ""Oh, that's terribly embarrassing. I'm sure I was parroti..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Romus the Merciful, you mean. You're welcome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Angelica Sazon: ""Yes, thank you, Your Majesty. I'm happy to be home again.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.VinaManus_Together == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""You're the mother of my future son-in-law. I couldn't le..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.VinaManus_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.VinaManus_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're the mother of my future son-in-law. I couldn't let you rot away on that island.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Angelica Sazon: ""I wouldn't call it rotting, Your Majesty. Manus and I we..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am so sorry about your son.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_Arrested"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Angelica Sazon: ""Yes, Manus' unfortunate absence has tainted the joy of m..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Sazon. It is a pleasure to see you here in Iza.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Angelica Sazon: ""Likewise, Your Majesty.""*)

### Węzeł `[25]`
Mówca: **Angelica Sazon**
> ""Oh, that's terribly embarrassing. I'm sure I was parroting whatever revolutionary nonsense my husband was filling my head with at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Your husband. Right.""*)
  - -> `[27]` (*Player_Romus: ""Lucas had the right idea. But his methods left something..."*)
  - -> `[28]` (*Player_Romus: ""I don't blame him for what he did. Rizia was hungry for ..."*)
  - -> `[33]` (*Player_Romus: ""You were as guilty as your husband was. But you redeemed..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your husband. Right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Angelica Sazon), `[30]` (Angelica Sazon), `[32]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Angelica Sazon: ""I won't pretend his words never swayed me. But when I be..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucas had the right idea. But his methods left something to be desired.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Angelica Sazon), `[30]` (Angelica Sazon), `[32]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Angelica Sazon: ""A revolution bought with blood will never succeed.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't blame him for what he did. Rizia was hungry for change. It still is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Angelica Sazon), `[30]` (Angelica Sazon), `[32]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Angelica Sazon: ""A revolution bought with blood will never succeed.""*)

### Węzeł `[29]`
Mówca: **Angelica Sazon**
> ""Yes, thank you, Your Majesty. I'm happy to be home again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Angelica Sazon: ""At the same time, it fills me with shame to think about ..."*)

### Węzeł `[30]`
Mówca: **Angelica Sazon**
> ""At the same time, it fills me with shame to think about my last days here. The things my husband did...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Your husband. Right.""*)
  - -> `[27]` (*Player_Romus: ""Lucas had the right idea. But his methods left something..."*)
  - -> `[28]` (*Player_Romus: ""I don't blame him for what he did. Rizia was hungry for ..."*)
  - -> `[33]` (*Player_Romus: ""You were as guilty as your husband was. But you redeemed..."*)

### Węzeł `[31]`
Mówca: **Angelica Sazon**
> ""Likewise, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Angelica Sazon: ""I watched your coronation from Caleqabiz. It disgusted m..."*)

### Węzeł `[32]`
Mówca: **Angelica Sazon**
> ""I watched your coronation from Caleqabiz. It disgusted me to think how close my husband came to keeping you from the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Your husband. Right.""*)
  - -> `[27]` (*Player_Romus: ""Lucas had the right idea. But his methods left something..."*)
  - -> `[28]` (*Player_Romus: ""I don't blame him for what he did. Rizia was hungry for ..."*)
  - -> `[33]` (*Player_Romus: ""You were as guilty as your husband was. But you redeemed..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were as guilty as your husband was. But you redeemed yourself by turning him in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Angelica Sazon), `[30]` (Angelica Sazon), `[32]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Angelica Sazon: ""I was about to become a mother. That mattered more to me..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_OrderedToKillManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_Order..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_Ord..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_OrderedToKillManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Arrested"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""I am so sorry about your son.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Arrested == true || RiziaDLC.SuOmina_OrderedToKillManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Arrested"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Angelica Sazon**
> ""Yes, Manus' unfortunate absence has tainted the joy of my return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Angelica Sazon: ""I am ashamed to think that he inherited his father's tre..."*)

### Węzeł `[38]`
Mówca: **Angelica Sazon**
> ""I am ashamed to think that he inherited his father's treasonous tendencies. I thought I raised him better than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""Lucas had the right idea. But his methods left something..."*)
  - -> `[33]` (*Player_Romus: ""You were as guilty as your husband was. But you redeemed..."*)
  - -> `[39]` (*Player_Romus: ""You can't seriously expect me to believe you don't share..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't seriously expect me to believe you don't share those tendencies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Angelica Sazon: ""Maybe I did once. But when I became pregnant I realized ..."*)

### Węzeł `[40]`
Mówca: **Angelica Sazon**
> ""I wouldn't call it rotting, Your Majesty. Manus and I were treated the same as any other villager on Caleqabiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "She looked fondly at Manus and Vina."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "She looked fondly at Manus and Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Angelica Sazon: ""But yes, it warms my heart to see my son and the Crown P..."*)

### Węzeł `[42]`
Mówca: **Angelica Sazon**
> ""But yes, it warms my heart to see my son and the Crown Princess so happy together. A sign that our houses are finally reconciling after my husband's shameful act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Your husband. Right.""*)
  - -> `[28]` (*Player_Romus: ""I don't blame him for what he did. Rizia was hungry for ..."*)

### Węzeł `[43]`
Mówca: **Angelica Sazon**
> ""I won't pretend his words never swayed me. But when I became pregnant I realized some things are more important than revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[44]`
Mówca: **Angelica Sazon**
> ""A revolution bought with blood will never succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_Outcome_MaxOppression == true"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Her eyes traveled past me to the heavily armed officers patrolling the auditorium aisles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Angelica Sazon: ""I should be getting to my seat. We will speak again soon.""*)

### Węzeł `[46]`
Mówca: **Angelica Sazon**
> ""A revolution bought with blood will never succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_Outcome_MaxOppression == true"*)

### Węzeł `[47]`
Mówca: **Angelica Sazon**
> ""I was about to become a mother. That mattered more to me than any revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[48]`
Mówca: **Angelica Sazon**
> ""Maybe I did once. But when I became pregnant I realized some things are more important than revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_Outcome_MaxOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_Outcome_MaxOppression == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Iza_Outcome_MaxOppression == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_Outcome_MaxOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Iza_Outcome_MaxOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Her eyes traveled past me to the heavily armed officers p..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Iza_Outcome_MaxOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Iza_Outcome_MaxOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Her eyes traveled past me to Rico, who was already sittin..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "A flash of sorrow crossed her face."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Her eyes traveled past me to her son."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "A flash of sorrow crossed her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Angelica Sazon: ""I should be getting to my seat. We will speak again soon.""*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Her eyes traveled past me to her son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Angelica Sazon: ""I should be getting to my seat. We will speak again soon.""*)

### Węzeł `[57]`
Mówca: **Angelica Sazon**
> ""I should be getting to my seat. We will speak again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""Try not to blame yourself for what happened. Focus on th..."*)
  - -> `[64]` (*Player_Romus: ""Enjoy the festivities, Duchess.""*)
  - -> `[63]` (*Player_Romus: ""You'll get your seat, all right. Sooner than you think.""*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Her eyes traveled past me to Rico, who was already sitting onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Angelica Sazon: ""I should be getting to my seat. We will speak again soon.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""We can change Rizia together. It's not too late.""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can change Rizia together. It's not too late.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "She nodded, stepped away and continued down the aisle."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll get your seat, all right. Sooner than you think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "With a confused look, she continued down the aisle."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy the festivities, Duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Angelica Sazon: ""Please, Your Majesty. Call me Angelica.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Try not to blame yourself for what happened. Focus on the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Angelica Sazon: ""I will. Thank you.""*)

### Węzeł `[66]`
Mówca: **Angelica Sazon**
> ""Please, Your Majesty. Call me Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "She stepped away from me and continued down the aisle."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "She nodded, stepped away and continued down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "With a confused look, she continued down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "She stepped away from me and continued down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
Mówca: **Angelica Sazon**
> ""I will. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "She stepped away from me and continued down the aisle."*)
