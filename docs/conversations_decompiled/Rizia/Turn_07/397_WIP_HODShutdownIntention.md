# Rizia/Turn 7/WIP_HODShutdownIntention

- **ID konwersacji:** `397`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/397_WIP_HODShutdownIntention.md`
- **Liczba węzłów dialogowych:** 59
- **Liczba wyborów gracza:** 12

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Religion_Leaning_Theocratic`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLCIsolated.Turn07_Hugo_Informal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Turn07_Intention_HODShutdown`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[153]`
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[183]`
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[1502]`
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[1506]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""It was a fine experiment. But I believe the time has come to put a stop to it.""** | `[4]` **Hugo Toras**: ""Romus. What do you mean?""<br>`[8]` **Hugo Toras**: ""Your Majesty. What do you mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Hugo Toras**: ""Hmm."" |
| `[10]` | **""I have a vision, Hugo. Of a Rizia led only by the most devout and pure of heart.""** | `[4]` **Hugo Toras**: ""Romus. What do you mean?""<br>`[8]` **Hugo Toras**: ""Your Majesty. What do you mean?"" | `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true` | *Brak zmian stanu* | `[26]` **Hugo Toras**: ""I take it you've been consultin..." |
| `[14]` | **""It's a waste of resources. My council advises me on lawmaking. I don't need a bui..."** | `[4]` **Hugo Toras**: ""Romus. What do you mean?""<br>`[8]` **Hugo Toras**: ""Your Majesty. What do you mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Hugo Toras**: ""A waste indeed."" |
| `[15]` | **""Even assuming we can control Manus, some other young hothead might try to warp th..."** | `[4]` **Hugo Toras**: ""Romus. What do you mean?""<br>`[8]` **Hugo Toras**: ""Your Majesty. What do you mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Hugo Toras**: ""You do have a point..."" |
| `[19]` | **""It was a mistake to make it easier to elect commoners. I don't want their heads g..."** | `[4]` **Hugo Toras**: ""Romus. What do you mean?""<br>`[8]` **Hugo Toras**: ""Your Majesty. What do you mean?"" | `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true` | *Brak zmian stanu* | `[25]` **Hugo Toras**: ""Nor do I."" |
| `[20]` | **""Sazon and the other noble houses should stick to their provinces. They don't need..."** | `[4]` **Hugo Toras**: ""Romus. What do you mean?""<br>`[8]` **Hugo Toras**: ""Your Majesty. What do you mean?"" | `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false` | *Brak zmian stanu* | `[24]` **Hugo Toras**: ""Hmm."" |
| `[38]` | **""And if I knew someone with connections among commoners and nobles alike? Someone ..."** | `[33]` **Hugo Toras**: """If you command enough respect ..."<br>`[37]` **Hugo Toras**: ""If you command enough respect i..." | `Variable["RiziaDLC.Rusty_Allied"] == true` | *Brak zmian stanu* | `[42]` **Hugo Toras**: ""I'd imagine such a person could..." |
| `[43]` | **""All right. I'll give it some more thought.""** | `[33]` **Hugo Toras**: """If you command enough respect ..."<br>`[37]` **Hugo Toras**: ""If you command enough respect i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Hugo Toras**: ""At any rate, if you do shut dow..." |
| `[44]` | **""This has been my goal since I took the throne. And I will stop at nothing to make..."** | `[33]` **Hugo Toras**: """If you command enough respect ..."<br>`[37]` **Hugo Toras**: ""If you command enough respect i..." | `Variable["RiziaDLC.Focus_Government_Absolutism"] == true` | *Brak zmian stanu* | `[51]` **Hugo Toras**: ""When the time comes, you shall ..." |
| `[45]` | **""You don't say. Even my own uncle disrespects me.""** | `[37]` **Hugo Toras**: ""If you command enough respect i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Hugo Toras**: ""I hold you in the highest estee..." |
| `[46]` | **""I'll let go of this for now. Winning the war is more important than consolidating..."** | `[33]` **Hugo Toras**: """If you command enough respect ..."<br>`[37]` **Hugo Toras**: ""If you command enough respect i..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Perhaps you'll win it more easi..." |
| `[57]` | **""I'll let go of this for now. There are more important things than consolidating m..."** | `[33]` **Hugo Toras**: """If you command enough respect ..."<br>`[37]` **Hugo Toras**: ""If you command enough respect i..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[52]` **Hugo Toras**: ""At any rate, if you do shut dow..." |

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
  - -> `[3]` (*Narrator: "Hugo scrutinized me very closely."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[183]`
  - -> `[1502]`
  - -> `[1506]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Hugo scrutinized me very closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Hugo_Informal == true"*)

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""Romus. What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""It was a fine experiment. But I believe the time has com..."*)
  - -> `[15]` (*Player_Romus: ""Even assuming we can control Manus, some other young hot..."*)
  - -> `[14]` (*Player_Romus: ""It's a waste of resources. My council advises me on lawm..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Hugo_Informal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Hugo_Informal == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Hugo_Informal == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Hugo_Informal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Hugo_Informal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Hugo Toras: ""Romus. What do you mean?""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Hugo_Informal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Hugo_Informal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Your Majesty. What do you mean?""*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Your Majesty. What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""It was a fine experiment. But I believe the time has com..."*)
  - -> `[15]` (*Player_Romus: ""Even assuming we can control Manus, some other young hot..."*)
  - -> `[14]` (*Player_Romus: ""It's a waste of resources. My council advises me on lawm..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a fine experiment. But I believe the time has come to put a stop to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""Hmm.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a vision, Hugo. Of a Rizia led only by the most devout and pure of heart.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""I take it you've been consulting with the Grand Wiseman.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religion_Leaning_Theocratic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religion_Leaning_Theocratic == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religion_Leaning_Theocratic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""I have a vision, Hugo. Of a Rizia led only by the most d..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religion_Leaning_Theocratic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a waste of resources. My council advises me on lawmaking. I don't need a building full of useless bureaucrats doing the same thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""A waste indeed.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even assuming we can control Manus, some other young hothead might try to warp the HOD to his or her own ends. It's too dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""You do have a point...""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""It was a mistake to make it easier to elect commoners. I..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""Sazon and the other noble houses should stick to their p..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a mistake to make it easier to elect commoners. I don't want their heads getting too big.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Hugo Toras: ""Nor do I.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sazon and the other noble houses should stick to their provinces. They don't need a say in the federal government.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""Hmm.""*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""You do have a point...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Hugo mulled it over for a few seconds."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Hugo mulled it over for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""If you eliminate the House of Delegates as an institutio..."*)

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""A waste indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Hugo mulled it over for a few seconds."*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Hugo mulled it over for a few seconds."*)

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""Nor do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Hugo mulled it over for a few seconds."*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""I take it you've been consulting with the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Hugo mulled it over for a few seconds."*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""If you eliminate the House of Delegates as an institution, there will certainly be a backlash. Both at home and abroad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""And the reformists who've recently been elected may turn..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""The nobles who hold seats in the House of Delegates have..."*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""And the reformists who've recently been elected may turn to more dangerous outlets if this one is taken away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority > 7"*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""The nobles who hold seats in the House of Delegates have also gotten quite used to their positions, and the salaries and perks that come with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority > 7"*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> """If you command enough respect in the capital, you may be able to get away with it. But not overnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[43]` (*Player_Romus: ""All right. I'll give it some more thought.""*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority > 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority > 7"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority > 7)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority > 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] > 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: """If you command enough respect in the capital, you may b..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority > 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] > 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Hugo Toras: ""If you command enough respect in the capital, you may be..."*)

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""If you command enough respect in the capital, you may be able to get away with it. But frankly put, you're currently at a disadvantage in that regard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[43]` (*Player_Romus: ""All right. I'll give it some more thought.""*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[45]` (*Player_Romus: ""You don't say. Even my own uncle disrespects me.""*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I knew someone with connections among commoners and nobles alike? Someone with experience greasing the wheels in the capital?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras), `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""I'd imagine such a person could be very helpful. But you..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""And if I knew someone with connections among commoners a..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""I'd imagine such a person could be very helpful. But you have to be careful about what you promise them in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""At any rate, if you do shut down the House of Delegates,..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. I'll give it some more thought.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras), `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""At any rate, if you do shut down the House of Delegates,..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This has been my goal since I took the throne. And I will stop at nothing to make it happen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras), `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""When the time comes, you shall have my full backing. As ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't say. Even my own uncle disrespects me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""I hold you in the highest esteem. It's why I tell you th..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll let go of this for now. Winning the war is more important than consolidating my power.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras), `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Perhaps you'll win it more easily without a chorus of di..."*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""I hold you in the highest esteem. It's why I tell you the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""At any rate, if you do shut down the House of Delegates,..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Absolutism == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""This has been my goal since I took the throne. And I wil..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""When the time comes, you shall have my full backing. As always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""At any rate, if you do shut down the House of Delegates,..."*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""At any rate, if you do shut down the House of Delegates, Manus Sazon will be one of your greatest opponents. So I strongly suggest we figure out what to do with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Intention_HODShutdown = true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""I'll let go of this for now. Winning the war is more imp..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""I'll let go of this for now. There are more important th..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Perhaps you'll win it more easily without a chorus of dissent in your ear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""At any rate, if you do shut down the House of Delegates,..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll let go of this for now. There are more important things than consolidating my power.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras), `[37]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""At any rate, if you do shut down the House of Delegates,..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn07_Intention_HODShutdown = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn07_Intention_HODShutdown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
