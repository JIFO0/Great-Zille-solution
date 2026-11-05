# Rizia/Turn 7/BFF Convo (Friendly)

- **ID konwersacji:** `390`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/390_BFF_Convo_(Friendly).md`
- **Liczba węzłów dialogowych:** 106
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[92]** Beatrice Livingston (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Rumburg_Hostile`
- `RiziaDLC.CountryRelation_Rumburg_Unfriendly`
- `RiziaDLC.Diplomacy_Wehlen_AgreementRefused`
- `RiziaDLC.Policy_Law_GolcondistBlasphemy`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Wehlen_FundBFF`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Zille_ViolentResistancePower`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[389] Rizia/Turn 7/FPnT_RumburgMeeting** (../Turn_07/389_FPnT_RumburgMeeting.md), Węzeł `[1370]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""The Bluds? But they're terrorists.""** | `[3]` **Beatrice Livingston (R)**: ""I suggest that you take advanta..."<br>`[80]` **Beatrice Livingston (R)**: ""I suggest that you assist Rumbu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Beatrice Livingston (R)**: ""They are a persecuted minority ..." |
| `[8]` | **""Those Golcondists? Never.""** | `[3]` **Beatrice Livingston (R)**: ""I suggest that you take advanta..."<br>`[80]` **Beatrice Livingston (R)**: ""I suggest that you assist Rumbu..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false` | *Brak zmian stanu* | `[24]` **Beatrice Livingston (R)**: ""Try to see past their religion ..." |
| `[9]` | **""That's it? Of course I welcome the opportunity to assist devout Wruhecists in need.""** | `[3]` **Beatrice Livingston (R)**: ""I suggest that you take advanta..."<br>`[80]` **Beatrice Livingston (R)**: ""I suggest that you assist Rumbu..." | `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false) == false` | *Brak zmian stanu* | `[22]` **Beatrice Livingston (R)**: ""And they, in turn, can assist y..." |
| `[10]` | **""I still don't see how that will help us in any way.""** | `[3]` **Beatrice Livingston (R)**: ""I suggest that you take advanta..."<br>`[80]` **Beatrice Livingston (R)**: ""I suggest that you assist Rumbu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Beatrice Livingston (R)**: ""It's simple, really."" |
| `[26]` | **""I don't want the BFF getting in the way of our existing resistance plans.""** | `[16]` **Laurento Esquibel**: ""I am still loathe to suggest vi..." | `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true` | *Brak zmian stanu* | `[39]` **Beatrice Livingston (R)**: ""Ah, well. I don't know what els..." |
| `[30]` | **""The BFF would be active in Zille sooner or later, anyway. We'd just be giving the..."** | `[15]` **Laurento Esquibel**: ""As loathe as I am to suggest vi..."<br>`[16]` **Laurento Esquibel**: ""I am still loathe to suggest vi..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[37]` **Beatrice Livingston (R)**: ""Exactly."" |
| `[31]` | **""The BFF have their own fight going on. I don't want to interfere with it one way ..."** | `[15]` **Laurento Esquibel**: ""As loathe as I am to suggest vi..."<br>`[16]` **Laurento Esquibel**: ""I am still loathe to suggest vi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Beatrice Livingston (R)**: ""The BFF only exists due to fore..." |
| `[32]` | **""If we funded the BFF and Smolak found out about it, he'd have an excuse to hold o..."** | `[15]` **Laurento Esquibel**: ""As loathe as I am to suggest vi..."<br>`[20]` **Laurento Esquibel**: ""I am loathe to suggest violence..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Beatrice Livingston (R)**: ""And who would tell him? Do you ..." |
| `[33]` | **""Why do I get the feeling you're trying to use both Rizia and the BFF toward your ..."** | `[15]` **Laurento Esquibel**: ""As loathe as I am to suggest vi..."<br>`[16]` **Laurento Esquibel**: ""I am still loathe to suggest vi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Beatrice Livingston (R)**: ""Don't be so cynical. I see an o..." |
| `[38]` | **""No... I don't like this. We'll figure out another way to retake Zille.""** | `[34]` **Beatrice Livingston (R)**: ""Don't be so cynical. I see an o..."<br>`[35]` **Beatrice Livingston (R)**: ""And who would tell him? Do you ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false` | *Brak zmian stanu* | `[36]` **Beatrice Livingston (R)**: ""Suit yourself, Your Majesty. It..." |
| `[41]` | **""You don't have to twist my arm, Your Excellency. I'll fund the Bludish Freedom Fr..."** | `[34]` **Beatrice Livingston (R)**: ""Don't be so cynical. I see an o..."<br>`[35]` **Beatrice Livingston (R)**: ""And who would tell him? Do you ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Resources_Budget"] < 0) == false`<br>`Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false` | *Brak zmian stanu* | `[89]` **Beatrice Livingston (R)**: ""I cannot control their actions ..." |
| `[42]` | **""I cannot agree to this plan in good conscience. I'll be damned to hell before I h..."** | `[15]` **Laurento Esquibel**: ""As loathe as I am to suggest vi..."<br>`[16]` **Laurento Esquibel**: ""I am still loathe to suggest vi..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[47]` **Beatrice Livingston (R)**: ""Oh, my."" |
| `[46]` | **""I'd love to agree to this. But I don't have the budget for it.""** | `[34]` **Beatrice Livingston (R)**: ""Don't be so cynical. I see an o..."<br>`[35]` **Beatrice Livingston (R)**: ""And who would tell him? Do you ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] < 0`<br>`Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false` | *Brak zmian stanu* | `[88]` **Beatrice Livingston (R)**: ""Then we'll have to leave it be...." |
| `[49]` | **""Zealotry? I am telling the objective truth. If you could only look beyond the nar..."** | `[48]` **Beatrice Livingston (R)**: ""I knew you were taking Rizia in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Beatrice Livingston (R)**: ""I... I see."" |
| `[54]` | **""You should consider the same, Your Excellency. Your secularization reforms will l..."** | `[48]` **Beatrice Livingston (R)**: ""I knew you were taking Rizia in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Beatrice Livingston (R)**: ""As valuable as religion is to m..." |
| `[56]` | **""It is not too late for you to embrace Wruhecism either, Beatrice. Your sister was..."** | `[48]` **Beatrice Livingston (R)**: ""I knew you were taking Rizia in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "Her face contorted into a snarl."<br>`[61]` **Beatrice Livingston (R)**: ""My sister was happy with you. W..." |
| `[87]` | **""We still have a chance to get Zille back fair and square. If that fails, you migh..."** | `[34]` **Beatrice Livingston (R)**: ""Don't be so cynical. I see an o..."<br>`[35]` **Beatrice Livingston (R)**: ""And who would tell him? Do you ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false) == false` | *Brak zmian stanu* | `[90]` **Beatrice Livingston (R)**: ""Understood."" |
| `[98]` | **""You don't have to twist my arm, Your Excellency. I want the BFF's help in Zille.""** | `[34]` **Beatrice Livingston (R)**: ""Don't be so cynical. I see an o..."<br>`[35]` **Beatrice Livingston (R)**: ""And who would tell him? Do you ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false) == false` | *Brak zmian stanu* | `[99]` **Beatrice Livingston (R)**: ""Then you shall have it."" |

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
  - -> `[76]` (*Narrator: "She leaned forward and spoke confidentially."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1370]`

### Węzeł `[3]`
Mówca: **Beatrice Livingston (R)**
> ""I suggest that you take advantage of Rumburg's contacts within the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""The Bluds? But they're terrorists.""*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[10]` (*Player_Romus: ""I still don't see how that will help us in any way.""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Bluds? But they're terrorists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Beatrice Livingston (R)), `[80]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Beatrice Livingston (R): ""They are a persecuted minority fighting an oppressive go..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Those Golcondists? Never.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""That's it? Of course I welcome the opportunity to assist..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those Golcondists? Never.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Beatrice Livingston (R)), `[80]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Beatrice Livingston (R): ""Try to see past their religion and empathize with their ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? Of course I welcome the opportunity to assist devout Wruhecists in need.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Beatrice Livingston (R)), `[80]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Beatrice Livingston (R): ""And they, in turn, can assist you in the reclamation of ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't see how that will help us in any way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Beatrice Livingston (R)), `[80]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Beatrice Livingston (R): ""It's simple, really.""*)

### Węzeł `[11]`
Mówca: **Beatrice Livingston (R)**
> ""It's simple, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Beatrice Livingston (R): ""Up to this point, we have been aiding the Bluds' liberat..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille ==..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Laurento Esquibel: ""As loathe as I am to suggest violence as a solution to t..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""As loathe as I am to suggest violence as a solution to the Zille conundrum...  an internal resistance effort from the BFF could work in perfect concert with the Derdian mercenaries already present in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""The BFF have their own fight going on. I don't want to i..."*)
  - -> `[32]` (*Player_Romus: ""If we funded the BFF and Smolak found out about it, he'd..."*)
  - -> `[33]` (*Player_Romus: ""Why do I get the feeling you're trying to use both Rizia..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""I am still loathe to suggest violence as a solution to the Zille conundrum. But in the absence of an agreement with President Smolak, an internal resistance might be our last hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""The BFF have their own fight going on. I don't want to i..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || R..."*)
  - -> `[33]` (*Player_Romus: ""Why do I get the feeling you're trying to use both Rizia..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Laurento Esquibel: ""I am still loathe to suggest violence as a solution to t..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Laurento Esquibel: ""I am loathe to suggest violence as a solution to the Zil..."*)

### Węzeł `[20]`
Mówca: **Laurento Esquibel**
> ""I am loathe to suggest violence as a solution to the Zille conundrum. Especially since Wehlen may yet return the region through diplomatic means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""The BFF have their own fight going on. I don't want to i..."*)
  - -> `[32]` (*Player_Romus: ""If we funded the BFF and Smolak found out about it, he'd..."*)
  - -> `[33]` (*Player_Romus: ""Why do I get the feeling you're trying to use both Rizia..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[21]`
Mówca: **Beatrice Livingston (R)**
> ""They are a persecuted minority fighting an oppressive government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Beatrice Livingston (R): ""And their struggle can, conveniently, be channeled towar..."*)

### Węzeł `[22]`
Mówca: **Beatrice Livingston (R)**
> ""And they, in turn, can assist you in the reclamation of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Laurento coughed."*)

### Węzeł `[23]`
Mówca: **Beatrice Livingston (R)**
> ""And their struggle can, conveniently, be channeled towards Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Laurento coughed."*)

### Węzeł `[24]`
Mówca: **Beatrice Livingston (R)**
> ""Try to see past their religion and empathize with their struggle against the Wehzek government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Beatrice Livingston (R): ""A struggle that can, conveniently, be channeled towards ..."*)

### Węzeł `[25]`
Mówca: **Beatrice Livingston (R)**
> ""A struggle that can, conveniently, be channeled towards Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Laurento coughed."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want the BFF getting in the way of our existing resistance plans.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Beatrice Livingston (R): ""Ah, well. I don't know what else is happening in Zille. ..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || R..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true ||..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""I don't want the BFF getting in the way of our existing ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The BFF would be active in Zille sooner or later, anyway. We'd just be giving them a nudge.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[15]` (Laurento Esquibel), `[16]` (Laurento Esquibel), `[20]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Beatrice Livingston (R): ""Exactly.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The BFF have their own fight going on. I don't want to interfere with it one way or another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Laurento Esquibel), `[16]` (Laurento Esquibel), `[20]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Beatrice Livingston (R): ""The BFF only exists due to foreign powers interfering in..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we funded the BFF and Smolak found out about it, he'd have an excuse to hold on to Zille forever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Laurento Esquibel), `[20]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Beatrice Livingston (R): ""And who would tell him? Do you run that leaky of a ship,..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do I get the feeling you're trying to use both Rizia and the BFF toward your own ends, Your Excellency?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Laurento Esquibel), `[16]` (Laurento Esquibel), `[20]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Beatrice Livingston (R): ""Don't be so cynical. I see an opportunity for our intere..."*)

### Węzeł `[34]`
Mówca: **Beatrice Livingston (R)**
> ""Don't be so cynical. I see an opportunity for our interests to align. That's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)

### Węzeł `[35]`
Mówca: **Beatrice Livingston (R)**
> ""And who would tell him? Do you run that leaky of a ship, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)

### Węzeł `[36]`
Mówca: **Beatrice Livingston (R)**
> ""Suit yourself, Your Majesty. It was just a suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Laurento Esquibel: ""At any rate, Your Excellency, thank you for this offer. ..."*)

### Węzeł `[37]`
Mówca: **Beatrice Livingston (R)**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No... I don't like this. We'll figure out another way to retake Zille.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Beatrice Livingston (R)), `[35]` (Beatrice Livingston (R)), `[37]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Beatrice Livingston (R): ""Suit yourself, Your Majesty. It was just a suggestion.""*)

### Węzeł `[39]`
Mówca: **Beatrice Livingston (R)**
> ""Ah, well. I don't know what else is happening in Zille. I merely saw an opportunity for our interests to align.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)

### Węzeł `[40]`
Mówca: **Beatrice Livingston (R)**
> ""The BFF only exists due to foreign powers interfering in Bludia. It's only right that we help them tip the scales in the other direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""You don't have to twist my arm, Your Excellency. I'll fund the Bludish Freedom Front, if you can promise me they'll help us 'liberate' Zille." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""You don't have to twist my arm, Your Excellency. I'll fund the Bludish Freedom Front, if you can promise me they'll help us 'liberate' Zille.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] < 0) == false` AND `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Beatrice Livingston (R)), `[35]` (Beatrice Livingston (R)), `[37]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Beatrice Livingston (R): ""I cannot control their actions completely, of course. Bu..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot agree to this plan in good conscience. I'll be damned to hell before I help Golcondist sinners spread their twisted gospel.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[15]` (Laurento Esquibel), `[16]` (Laurento Esquibel), `[20]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Beatrice Livingston (R): ""Oh, my.""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == false &&..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 0"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""You don't have to twist my arm, Your Excellency. I want ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd love to agree to this. But I don't have the budget for it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] < 0` AND `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Beatrice Livingston (R)), `[35]` (Beatrice Livingston (R)), `[37]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Beatrice Livingston (R): ""Then we'll have to leave it be. Rizia must ante up to ha..."*)

### Węzeł `[47]`
Mówca: **Beatrice Livingston (R)**
> ""Oh, my.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Beatrice Livingston (R): ""I knew you were taking Rizia in a more religious directi..."*)

### Węzeł `[48]`
Mówca: **Beatrice Livingston (R)**
> ""I knew you were taking Rizia in a more religious direction, but to hear such zealotry with my own ears...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""Zealotry? I am telling the objective truth. If you could..."*)
  - -> `[54]` (*Player_Romus: ""You should consider the same, Your Excellency. Your secu..."*)
  - -> `[56]` (*Player_Romus: ""It is not too late for you to embrace Wruhecism either, ..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zealotry? I am telling the objective truth. If you could only look beyond the narrow worldview of St. Dast, you would agree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Beatrice Livingston (R): ""I... I see.""*)

### Węzeł `[50]`
Mówca: **Beatrice Livingston (R)**
> ""Up to this point, we have been aiding the Bluds' liberation efforts in the north of Wehlen. But I see no reason why their struggle can't be directed southward as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Laurento coughed."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == false"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_GolcondistBlasphemy == false)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Beatrice Livingston (R): ""You have established Rizia as a safe haven for their so-..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_GolcondistBlasphemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should consider the same, Your Excellency. Your secularization reforms will lead Rumburg to ruin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Beatrice Livingston (R): ""As valuable as religion is to me personally, it must be ..."*)

### Węzeł `[55]`
Mówca: **Laurento Esquibel**
> ""If I may, Your Excellency... Zille has nothing to do with the former Greater Bludia region. Why would the BFF get involved there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == false"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not too late for you to embrace Wruhecism either, Beatrice. Your sister was so happy after she saw the light.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == false)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Her face contorted into a snarl."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Beatrice Livingston (R): ""My sister was happy with you. Wruhecism had nothing to d..."*)

### Węzeł `[60]`
Mówca: **Beatrice Livingston (R)**
> ""My sister despised your silly religion almost as much as she despised you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Laurento's face flushed."*)

### Węzeł `[61]`
Mówca: **Beatrice Livingston (R)**
> ""My sister was happy with you. Wruhecism had nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Laurento's face flushed."*)

### Węzeł `[62]`
Mówca: **Beatrice Livingston (R)**
> ""I... I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Laurento hurriedly cut in."*)

### Węzeł `[63]`
Mówca: **Beatrice Livingston (R)**
> ""As valuable as religion is to me personally, it must be separated from the state if my nation is to be taken seriously. I'm surprised Mr. Esquibel hasn't told you the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Laurento grew indignant."*)

### Węzeł `[64]`
Mówca: **Laurento Esquibel**
> ""Rizia's religious governance is between the King and our Grand Wiseman. I wouldn't presume to have a say in such matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Laurento Esquibel: ""His Majesty has turned down your offer. Let's leave it a..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Laurento's face flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Laurento Esquibel: ""The King has turned down your offer, Your Excellency. No..."*)

### Węzeł `[66]`
Mówca: **Laurento Esquibel**
> ""The King has turned down your offer, Your Excellency. No need to bring up personal matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Beatrice still looked troubled."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Laurento grew indignant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Laurento Esquibel: ""Rizia's religious governance is between the King and our..."*)

### Węzeł `[68]`
Mówca: **Beatrice Livingston (R)**
> ""You have established Rizia as a safe haven for their so-called religion. Besides which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Beatrice Livingston (R): ""Any action that destabilizes the Smolak regime will help..."*)

### Węzeł `[69]`
Mówca: **Beatrice Livingston (R)**
> ""You have shown yourself to be no great friend to Wiktor Smolak. Besides which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Beatrice Livingston (R): ""Any action that destabilizes the Smolak regime will help..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Beatrice Livingston (R): ""You have shown yourself to be no great friend to Wiktor ..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Beatrice Livingston (R): ""Any action that destabilizes the Smolak regime will help..."*)

### Węzeł `[73]`
Mówca: **Beatrice Livingston (R)**
> ""Any action that destabilizes the Smolak regime will help the Bludish cause, no matter where it is carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Laurento pondered over this for a moment."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Laurento pondered over this for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[75]`
Mówca: **Laurento Esquibel**
> ""His Majesty has turned down your offer. Let's leave it at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Beatrice still looked troubled."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "She leaned forward and spoke confidentially."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && R..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == false &&..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Beatrice Livingston (R): ""I suggest that you take advantage of Rumburg's contacts ..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == false && RiziaDLC.CountryRelation_Rumburg_Hostile == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Beatrice Livingston (R): ""I suggest that you assist Rumburg in funding the Bludish..."*)

### Węzeł `[80]`
Mówca: **Beatrice Livingston (R)**
> ""I suggest that you assist Rumburg in funding the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""The Bluds? But they're terrorists.""*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[10]` (*Player_Romus: ""I still don't see how that will help us in any way.""*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""No... I don't like this. We'll figure out another way to..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""We still have a chance to get Zille back fair and square..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 0"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget < 0 )"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""I'd love to agree to this. But I don't have the budget f..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""You don't have to twist my arm, Your Excellency. I'll fu..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have a chance to get Zille back fair and square. If that fails, you might hear from me again.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Beatrice Livingston (R)), `[35]` (Beatrice Livingston (R)), `[37]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Beatrice Livingston (R): ""Understood.""*)

### Węzeł `[88]`
Mówca: **Beatrice Livingston (R)**
> ""Then we'll have to leave it be. Rizia must ante up to have a stake in this game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Laurento Esquibel: ""At any rate, Your Excellency, thank you for this offer. ..."*)

### Węzeł `[89]`
Mówca: **Beatrice Livingston (R)**
> ""I cannot control their actions completely, of course. But as I said, I will do my very best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[90]`
Mówca: **Beatrice Livingston (R)**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Laurento Esquibel: ""At any rate, Your Excellency, thank you for this offer. ..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false && RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false && RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""I cannot agree to this plan in good conscience. I'll be ..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false && RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false  and  Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""The BFF would be active in Zille sooner or later, anyway..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Her face contorted into a snarl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Beatrice Livingston (R): ""My sister despised your silly religion almost as much as..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Laurento hurriedly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Laurento Esquibel: ""Your Excellency, the King has turned down your offer. Pe..."*)

### Węzeł `[96]`
Mówca: **Laurento Esquibel**
> ""Your Excellency, the King has turned down your offer. Perhaps it's best to leave it at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Beatrice still looked troubled."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Dipl..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to twist my arm, Your Excellency. I want the BFF's help in Zille.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == false  and  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Beatrice Livingston (R)), `[35]` (Beatrice Livingston (R)), `[37]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Beatrice Livingston (R): ""Then you shall have it.""*)

### Węzeł `[99]`
Mówca: **Beatrice Livingston (R)**
> ""Then you shall have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Dipl..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower += 1; RiziaDLC.Diplomacy_Wehlen_FundBFF = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Laurento coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Laurento Esquibel: ""If I may, Your Excellency... Zille has nothing to do wit..."*)

### Węzeł `[102]`
Mówca: **Laurento Esquibel**
> ""At any rate, Your Excellency, thank you for this offer. And for entrusting us with such sensitive information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Beatrice Livingston (R): ""Why, certainly. What are allies for?""*)

### Węzeł `[103]`
Mówca: **Beatrice Livingston (R)**
> ""Why, certainly. What are allies for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Beatrice still looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Beatrice Livingston (R): ""It is a dangerous road you are traveling, Romus. I do no..."*)

### Węzeł `[105]`
Mówca: **Beatrice Livingston (R)**
> ""It is a dangerous road you are traveling, Romus. I do not know how much further Rumburg can accompany you down it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
