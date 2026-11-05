# Rizia/Turn 7/Morella Discussion Friendly

- **ID konwersacji:** `378`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/378_Morella_Discussion_Friendly.md`
- **Liczba węzłów dialogowych:** 105
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.MorellaConditions_DerdianProblemSolved`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting`
- `RiziaDLCIsolated.Turn07_Derdia_FavorsDone`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`
- `RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute`
- `RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension`
- `RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[575]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""This isn't about 'goodwill'. It's about a murderous incursion of Derdian insurgen..."** | `[3]` **Jorga Azmal**: ""Tell me. What has Saltana done ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Jorga Azmal**: ""Insurgents? Was Wruhec an 'insu..." |
| `[5]` | **""You are a man of God. Must your goodwill be earned, or can it not be freely given?""** | `[3]` **Jorga Azmal**: ""Tell me. What has Saltana done ..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[12]` **Jorga Azmal**: ""As St. Wruhec has said, 'Genero..." |
| `[10]` | **""Remember the words of St. Wruhec. 'The light of compassion can illuminate even th..."** | `[3]` **Jorga Azmal**: ""Tell me. What has Saltana done ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[65]` **Jorga Azmal**: ""Yes, that is so."" |
| `[18]` | **""Silence, both of you. I did not come here to trade aphorisms.""** | `[70]` **Jorga Azmal**: ""Did he not also write, 'As the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Jorga Azmal**: ""'In the realm of discourse, suc..." |
| `[27]` | **""Think about it from a financial perspective. Peace between Derdia and Morella cou..."** | `[3]` **Jorga Azmal**: ""Tell me. What has Saltana done ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Jorga Azmal**: ""Riches are useless if we are un..." |
| `[28]` | **""What will happen when she allies with the CSP? Your insurgents will get blown to ..."** | `[3]` **Jorga Azmal**: ""Tell me. What has Saltana done ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Jorga Azmal**: ""Are you aware of my country's w..." |
| `[29]` | **""'Yet even the most imposing of mountains may still be shaped by the gentle rains ..."** | `[70]` **Jorga Azmal**: ""Did he not also write, 'As the ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[31]` **Narrator**: "Azmal nodded approvingly." |
| `[30]` | **""I don't care what he wrote. The law is the law.""** | `[70]` **Jorga Azmal**: ""Did he not also write, 'As the ..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true) == false` | *Brak zmian stanu* | `[33]` **Jorga Azmal**: ""We in Derdia only recognize one..." |
| `[35]` | **""I agree, Supreme Wiseman. We will get Saltana to recognize your people's right to..."** | `[70]` **Jorga Azmal**: ""Did he not also write, 'As the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Jorga Azmal**: ""Halaita. If it is said, so it w..." |
| `[41]` | **""We are fighting a war. Building a pipeline would be a waste of much-needed resour..."** | `[76]` **Jorga Azmal**: ""I've heard about your partnersh..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[23]` **Jorga Azmal**: ""Or a way to make sure you still..." |
| `[43]` | **""A pipeline is out of the question. I'm sorry.""** | `[24]` **Jorga Azmal**: ""It's an investment, Your Majest..."<br>`[85]` **Jorga Azmal**: ""Or is it your Morellan friends ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Jorga Azmal**: ""In that case..."" |
| `[44]` | **""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella al..."** | `[24]` **Jorga Azmal**: ""It's an investment, Your Majest..."<br>`[79]` **Jorga Azmal**: ""When two like souls converge, t..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2` | *Brak zmian stanu* | `[42]` **Narrator**: "A faint smile appeared on Sal's ..." |
| `[48]` | **""That sounds fair enough. I'm happy to help.""** | `[47]` **Jorga Azmal**: ""Tell Ms. Saltana I will talk to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Jorga Azmal**: ""Make sure she is aware that I w..." |
| `[49]` | **""I hope you are ready to compromise. Derdians are not automatically entitled to en..."** | `[47]` **Jorga Azmal**: ""Tell Ms. Saltana I will talk to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Jorga Azmal**: ""We were once one kingdom. St. W..." |
| `[53]` | **""My country's fighting a war, Supreme Wiseman. I don't have time to mediate my nei..."** | `[47]` **Jorga Azmal**: ""Tell Ms. Saltana I will talk to..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[54]` **Jorga Azmal**: ""You approached me, not the othe..." |
| `[59]` | **""With the Lord on our side, we will convince her to aid your people in their holy ..."** | `[47]` **Jorga Azmal**: ""Tell Ms. Saltana I will talk to..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[55]` **Jorga Azmal**: ""Halaita. If it is said, so it w..." |
| `[77]` | **""That's your only request? Nothing would make me happier than to pursue an energy ..."** | `[76]` **Jorga Azmal**: ""I've heard about your partnersh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "He smiled." |
| `[80]` | **""Respectfully, Supreme Wiseman, we barely have enough energy to sell to Morella, l..."** | `[76]` **Jorga Azmal**: ""I've heard about your partnersh..." | `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1` | *Brak zmian stanu* | `[81]` **Jorga Azmal**: ""So Rizia's legendary gas wealth..." |
| `[83]` | **""I can't do that. Too much could go wrong.""** | `[76]` **Jorga Azmal**: ""I've heard about your partnersh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Jorga Azmal**: ""Do you not trust us, Your Majes..." |
| `[86]` | **""He wrote a lot, didn't he?""** | `[26]` **Jorga Azmal**: ""...before tending to the soil b..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[95]` **Jorga Azmal**: ""His pen was but a conduit for t..." |
| `[87]` | **""That was easier than I expected.""** | `[26]` **Jorga Azmal**: ""...before tending to the soil b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Jorga Azmal**: ""We have more in common than exp..." |
| `[96]` | **""'For lo, true virtue lies in balancing the celestial with the hearth.'""** | `[26]` **Jorga Azmal**: ""...before tending to the soil b..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[94]` **Jorga Azmal**: ""And we in Derdia have plenty of..." |
| `[97]` | **""Don't make me regret this, Mr. Azmal.""** | `[26]` **Jorga Azmal**: ""...before tending to the soil b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Jorga Azmal**: ""I assure you I will not."" |
| `[101]` | **""Unfortunately, Rizia cannot fund such a construction at this time. Is there anyth..."** | `[24]` **Jorga Azmal**: ""It's an investment, Your Majest..."<br>`[79]` **Jorga Azmal**: ""When two like souls converge, t..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false` | *Brak zmian stanu* | `[37]` **Jorga Azmal**: ""In that case..."" |

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
  - -> `[14]` (*Jorga Azmal: ""Ha. That witch has you doing her bidding?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[3]`
Mówca: **Jorga Azmal**
> ""Tell me. What has Saltana done to deserve my goodwill?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""What will happen when she allies with the CSP? Your insu..."*)
  - -> `[27]` (*Player_Romus: ""Think about it from a financial perspective. Peace betwe..."*)
  - -> `[4]` (*Player_Romus: ""This isn't about 'goodwill'. It's about a murderous incu..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't about 'goodwill'. It's about a murderous incursion of Derdian insurgents.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Jorga Azmal: ""Insurgents? Was Wruhec an 'insurgent' when he spread his..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a man of God. Must your goodwill be earned, or can it not be freely given?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Jorga Azmal: ""As St. Wruhec has said, 'Generosity is the heart's river..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""Remember the words of St. Wruhec. 'The light of compassi..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""You are a man of God. Must your goodwill be earned, or c..."*)

### Węzeł `[9]`
Mówca: **Jorga Azmal**
> ""Insurgents? Was Wruhec an 'insurgent' when he spread his gospel across Southern Merkopa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He sat back on his cushion, looking defiant."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember the words of St. Wruhec. 'The light of compassion can illuminate even those who walk in the darkest of shadows.'""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""Yes, that is so.""*)

### Węzeł `[12]`
Mówca: **Jorga Azmal**
> ""As St. Wruhec has said, 'Generosity is the heart's river, but let its waters flow with discernment'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He sat back on his cushion for a moment."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He sat back on his cushion for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true"*)

### Węzeł `[14]`
Mówca: **Jorga Azmal**
> ""Ha. That witch has you doing her bidding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Jorga Azmal: ""Tell me. What has Saltana done to deserve my goodwill?""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Jorga Azmal: ""We will talk to Saltana. I will respect her borders if s..."*)

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""We will talk. That is all I can promise you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[17]`
Mówca: **Jorga Azmal**
> ""I will meet with you and Saltana. That is all I can promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Silence, both of you. I did not come here to trade aphorisms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Jorga Azmal: ""'In the realm of discourse, succinct truths are the shar..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prolog..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""'Yet even the most imposing of mountains may still be sh..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""I don't care what he wrote. The law is the law.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""Or a way to make sure you still have resources for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""It's an investment, Your Majesty. Into the future of thi..."*)

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""It's an investment, Your Majesty. Into the future of this region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""A pipeline is out of the question. I'm sorry.""*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Budge..."*)

### Węzeł `[25]`
Mówca: **Sal Ignacius**
> ""As Wruhec wrote, 'Reach not for the stars above your head...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Jorga Azmal: ""...before tending to the soil beneath your feet.""*)

### Węzeł `[26]`
Mówca: **Jorga Azmal**
> ""...before tending to the soil beneath your feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think about it from a financial perspective. Peace between Derdia and Morella could be lucrative for all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Jorga Azmal: ""Riches are useless if we are unable to express our grati..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What will happen when she allies with the CSP? Your insurgents will get blown to smithereens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Jorga Azmal: ""Are you aware of my country's weapons capabilities? We a..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Yet even the most imposing of mountains may still be shaped by the gentle rains of understanding'.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Azmal nodded approvingly."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what he wrote. The law is the law.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Jorga Azmal: ""We in Derdia only recognize one law. The law of the divi..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Azmal nodded approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1"*)

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""We will talk to Saltana. I will respect her borders if she respects my pilgrims' rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[33]`
Mówca: **Jorga Azmal**
> ""We in Derdia only recognize one law. The law of the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Jorga Azmal: ""We will talk. That is all I can promise you.""*)

### Węzeł `[34]`
Mówca: **Jorga Azmal**
> ""'In the realm of discourse, succinct truths are the sharpest blades of wisdom'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Jorga Azmal: ""I will meet with you and Saltana. That is all I can prom..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree, Supreme Wiseman. We will get Saltana to recognize your people's right to their ancestral land.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Jorga Azmal: ""Halaita. If it is said, so it will be.""*)

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""Halaita. If it is said, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1"*)

### Węzeł `[37]`
Mówca: **Jorga Azmal**
> ""In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Jorga Azmal: ""Tell Ms. Saltana I will talk to her. But only if the Kin..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""We are fighting a war. Building a pipeline would be a wa..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are fighting a war. Building a pipeline would be a waste of much-needed resources.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[76]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""Or a way to make sure you still have resources for years..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "A faint smile appeared on Sal's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As Wruhec wrote, 'Reach not for the stars above your hea..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pipeline is out of the question. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Jorga Azmal), `[85]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Jorga Azmal: ""In that case...""*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone." [-2 Energy For +4 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[24]` (Jorga Azmal), `[79]` (Jorga Azmal), `[85]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A faint smile appeared on Sal's lips."*)

### Węzeł `[45]`
Mówca: **Jorga Azmal**
> ""Are you aware of my country's weapons capabilities? We are more than prepared to fight for our right to holy pilgrimage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He sat back on his cushion, looking defiant."*)

### Węzeł `[46]`
Mówca: **Jorga Azmal**
> ""Riches are useless if we are unable to express our gratitude to the Lord who provided them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He sat back on his cushion, looking defiant."*)

### Węzeł `[47]`
Mówca: **Jorga Azmal**
> ""Tell Ms. Saltana I will talk to her. But only if the King of Rizia is present to act as an intermediary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""That sounds fair enough. I'm happy to help.""*)
  - -> `[49]` (*Player_Romus: ""I hope you are ready to compromise. Derdians are not aut..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds fair enough. I'm happy to help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Jorga Azmal: ""Make sure she is aware that I will not simply back down...."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you are ready to compromise. Derdians are not automatically entitled to enter Morella, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Jorga Azmal: ""We were once one kingdom. St. Wruhec knew nothing of the..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""My country's fighting a war, Supreme Wiseman. I don't ha..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My country's fighting a war, Supreme Wiseman. I don't have time to mediate my neighbors' squabbles.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[47]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""You approached me, not the other way around. And this as..."*)

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""You approached me, not the other way around. And this as far as I will go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Sal Ignacius: ""Wruhec himself would not have approved of your attitude,..."*)

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""Halaita. If it is said, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""With the Lord on our side, we will convince her to aid y..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the Lord on our side, we will convince her to aid your people in their holy travels.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[47]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Jorga Azmal: ""Halaita. If it is said, so it will be.""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Jorga Azmal: ""You spoke in our favor at the Alliance of Nations. I kno..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Jorga Azmal: ""I was wary of you after your words at the Alliance of Na..."*)

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""You spoke in our favor at the Alliance of Nations. I know you are not entirely on Morella's side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""I was wary of you after your words at the Alliance of Nations. But your actions on behalf of Golcondists have spoken volumes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""Yes, that is so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He sat back on his cushion for a moment."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He sat back on his cushion, looking defiant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true"*)

### Węzeł `[67]`
Mówca: **Jorga Azmal**
> ""We were once one kingdom. St. Wruhec knew nothing of these modern-day borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Sal Ignacius: ""Wruhec himself would not have approved of your attitude,..."*)

### Węzeł `[68]`
Mówca: **Jorga Azmal**
> ""Make sure she is aware that I will not simply back down. The more she tries to block our holy pilgrimage, the more fiercely we will fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Sal Ignacius: ""Wruhec himself would not have approved of your attitude,..."*)

### Węzeł `[69]`
Mówca: **Sal Ignacius**
> ""Wruhec himself would not have approved of your attitude, Supreme Wiseman. 'The most steadfast heart must be willing to sway, for in yielding, it finds strength.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Jorga Azmal: ""Did he not also write, 'As the mountain stand still agai..."*)

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""Did he not also write, 'As the mountain stand still against the tempest, so too must one hold firm to their convictions'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue..."*)
  - -> `[18]` (*Player_Romus: ""Silence, both of you. I did not come here to trade aphor..."*)
  - -> `[35]` (*Player_Romus: ""I agree, Supreme Wiseman. We will get Saltana to recogni..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Jorga Azmal: ""Tell Ms. Saltana I will talk to her. But only if the Kin..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Jorga Azmal: ""There is one thing we Derdians need more than access to ..."*)

### Węzeł `[75]`
Mówca: **Jorga Azmal**
> ""There is one thing we Derdians need more than access to sacred sites. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Jorga Azmal: ""I've heard about your partnership with Morella. Extend t..."*)

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""I've heard about your partnership with Morella. Extend the pipeline to Derdia, and I will order our pilgrims away from Morella's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 1"*)
  - -> `[83]` (*Player_Romus: ""I can't do that. Too much could go wrong.""*)
  - -> `[77]` (*Player_Romus: ""That's your only request? Nothing would make me happier ..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's your only request? Nothing would make me happier than to pursue an energy partnership with Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "He smiled."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Jorga Azmal: ""When two like souls converge, the Divine smiles upon them.""*)

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""When two like souls converge, the Divine smiles upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Budge..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Respectfully, Supreme Wiseman, we barely have enough energy to sell to Morella, let alone Derdia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1`
- **Kontekst wejściowy (poprzednik):** `[76]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Jorga Azmal: ""So Rizia's legendary gas wealth is a myth.""*)

### Węzeł `[81]`
Mówca: **Jorga Azmal**
> ""So Rizia's legendary gas wealth is a myth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He looked disappointed."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "He looked disappointed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Jorga Azmal: ""In that case...""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that. Too much could go wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Jorga Azmal: ""Do you not trust us, Your Majesty? The word of a Derdian..."*)

### Węzeł `[84]`
Mówca: **Jorga Azmal**
> ""Do you not trust us, Your Majesty? The word of a Derdian is bond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Jorga Azmal: ""Or is it your Morellan friends you are worried about?""*)

### Węzeł `[85]`
Mówca: **Jorga Azmal**
> ""Or is it your Morellan friends you are worried about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""A pipeline is out of the question. I'm sorry.""*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Budge..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wrote a lot, didn't he?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Jorga Azmal: ""His pen was but a conduit for the Divine.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was easier than I expected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Jorga Azmal: ""We have more in common than expected.""*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true; RiziaDLC.MorellaConditions_DerdianProblemSolved = true;
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 4;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLC.MorellaConditions_DerdianProblemSolved"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 4;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""That was easier than I expected.""*)
  - -> `[97]` (*Player_Romus: ""Don't make me regret this, Mr. Azmal.""*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""'For lo, true virtue lies in balancing the celestial wit..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""He wrote a lot, didn't he?""*)

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""We have more in common than expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""I assure you I will not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""And we in Derdia have plenty of hearths to keep alit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[95]`
Mówca: **Jorga Azmal**
> ""His pen was but a conduit for the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'For lo, true virtue lies in balancing the celestial with the hearth.'""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Jorga Azmal: ""And we in Derdia have plenty of hearths to keep alit.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me regret this, Mr. Azmal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Jorga Azmal: ""I assure you I will not.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Budge..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Bud..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""It's a deal, Supreme Wiseman. We will extend the pipelin..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""Unfortunately, Rizia cannot fund such a construction at ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, Rizia cannot fund such a construction at this time. Is there anything else we can offer instead?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Jorga Azmal), `[79]` (Jorga Azmal), `[85]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Jorga Azmal: ""In that case...""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 1"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal < 1)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""Respectfully, Supreme Wiseman, we barely have enough ene..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
