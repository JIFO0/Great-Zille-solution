# Rizia/Turn 7/Morella Discussion Unfriendly

- **ID konwersacji:** `379`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/379_Morella_Discussion_Unfriendly.md`
- **Liczba węzłów dialogowych:** 92
- **Liczba wyborów gracza:** 20

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
- `RiziaDLC.Policy_Law_GolcondistBlasphemy`
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
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[536]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""Peace between Morella, Rizia and Derdia could be lucrative for all of us. Don't y..."** | `[14]` **Jorga Azmal**: ""Why should I help either of you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Jorga Azmal**: ""You think a man of God can be b..." |
| `[4]` | **""Don't you realize Morella is on the verge of joining the CSP? Your insurgents wil..."** | `[14]` **Jorga Azmal**: ""Why should I help either of you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Jorga Azmal**: ""Are you aware of my country's w..." |
| `[5]` | **""It's not about 'help'. It's about Derdians breaking the law.""** | `[14]` **Jorga Azmal**: ""Why should I help either of you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Jorga Azmal**: ""As St. Wruhec has said, 'Laws d..." |
| `[15]` | **""You are a man of God. Must your goodwill be earned, or can it not be freely given?""** | `[14]` **Jorga Azmal**: ""Why should I help either of you?"" | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[19]` **Jorga Azmal**: ""As St. Wruhec has said, 'Genero..." |
| `[20]` | **""Remember the words of St. Wruhec. 'The light of compassion can illuminate even th..."** | `[14]` **Jorga Azmal**: ""Why should I help either of you?"" | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[22]` **Jorga Azmal**: ""Yes, that is so."" |
| `[31]` | **""With the Lord on our side, we will convince her to aid your people in their holy ..."** | `[29]` **Jorga Azmal**: ""And only if she is willing to c..."<br>`[88]` **Jorga Azmal**: ""And only if she is willing to c..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[36]` **Jorga Azmal**: ""Halaita. If it is said, so it w..." |
| `[32]` | **""My country's fighting a war, Supreme Wiseman. I don't have time to mediate my nei..."** | `[29]` **Jorga Azmal**: ""And only if she is willing to c..."<br>`[88]` **Jorga Azmal**: ""And only if she is willing to c..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[28]` **Jorga Azmal**: ""You approached me, not the othe..." |
| `[37]` | **""I have spoken to her. I highly doubt she will compromise on that.""** | `[29]` **Jorga Azmal**: ""And only if she is willing to c..."<br>`[88]` **Jorga Azmal**: ""And only if she is willing to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Jorga Azmal**: ""I will give her one chance. If ..." |
| `[46]` | **""'For lo, true virtue lies in balancing the celestial with the hearth.'""** | `[58]` **Jorga Azmal**: ""...before tending to the soil b..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[50]` **Jorga Azmal**: ""And we in Derdia have plenty of..." |
| `[47]` | **""Don't make me regret this, Mr. Azmal.""** | `[58]` **Jorga Azmal**: ""...before tending to the soil b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Jorga Azmal**: ""I assure you I will not."" |
| `[53]` | **""A pipeline is out of the question. Isn't there anything else you want?""** | `[42]` **Jorga Azmal**: ""Or is it your Morellan friends ..."<br>`[52]` **Jorga Azmal**: ""It's an investment, Your Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Jorga Azmal**: ""In that case..."" |
| `[55]` | **""That was easier than I expected.""** | `[58]` **Jorga Azmal**: ""...before tending to the soil b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Jorga Azmal**: ""Promises are easier to make tha..." |
| `[56]` | **""He wrote a lot, didn't he?""** | `[58]` **Jorga Azmal**: ""...before tending to the soil b..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[51]` **Jorga Azmal**: ""His pen was but a conduit for t..." |
| `[60]` | **""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella al..."** | `[42]` **Jorga Azmal**: ""Or is it your Morellan friends ..."<br>`[43]` **Jorga Azmal**: ""We are not allies, Your Majesty..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2` | *Brak zmian stanu* | `[54]` **Narrator**: "A faint smile appeared on Sal's ..." |
| `[64]` | **""She is a reasonable leader. I'm sure she will be able to meet you halfway.""** | `[29]` **Jorga Azmal**: ""And only if she is willing to c..."<br>`[88]` **Jorga Azmal**: ""And only if she is willing to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Jorga Azmal**: ""There is no 'halfway' when it c..." |
| `[71]` | **""Perfect. I wanted to suggest an energy partnership anyway.""** | `[65]` **Jorga Azmal**: ""I have heard of your gas pipeli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "He cast a suspicious glance at me." |
| `[72]` | **""Respectfully, Supreme Wiseman, we barely have enough energy to sell to Morella, l..."** | `[65]` **Jorga Azmal**: ""I have heard of your gas pipeli..." | `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1` | *Brak zmian stanu* | `[73]` **Jorga Azmal**: ""So Rizia's legendary gas wealth..." |
| `[75]` | **""I can't do that. Too much could go wrong.""** | `[65]` **Jorga Azmal**: ""I have heard of your gas pipeli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Jorga Azmal**: ""Do you not trust us, Your Majes..." |
| `[79]` | **""We are fighting a war. Building a pipeline would be a waste of much-needed resour..."** | `[65]` **Jorga Azmal**: ""I have heard of your gas pipeli..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[45]` **Jorga Azmal**: ""Or a way to make sure you still..." |
| `[84]` | **""I wish it were that easy. But I cannot fund such a construction at this time.""** | `[42]` **Jorga Azmal**: ""Or is it your Morellan friends ..."<br>`[43]` **Jorga Azmal**: ""We are not allies, Your Majesty..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false` | *Brak zmian stanu* | `[40]` **Narrator**: "He smirked slightly." |

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
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Peace between Morella, Rizia and Derdia could be lucrative for all of us. Don't you realize that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Jorga Azmal: ""You think a man of God can be bought so easily?""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you realize Morella is on the verge of joining the CSP? Your insurgents will be blown to smithereens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Jorga Azmal: ""Are you aware of my country's weapons capabilities? We a..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not about 'help'. It's about Derdians breaking the law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Jorga Azmal: ""As St. Wruhec has said, 'Laws devoid of justice are but ..."*)

### Węzeł `[6]`
Mówca: **Jorga Azmal**
> ""As St. Wruhec has said, 'Laws devoid of justice are but chains upon the righteous. To break such chains is man's highest duty.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He sat back on his cushion, looking defiant."*)

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""You think a man of God can be bought so easily?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He sat back on his cushion, looking defiant."*)

### Węzeł `[8]`
Mówca: **Jorga Azmal**
> ""Are you aware of my country's weapons capabilities? We are more than prepared to fight for our right to holy pilgrimage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He sat back on his cushion, looking defiant."*)

### Węzeł `[9]`
Mówca: **Jorga Azmal**
> ""After your lip service to Derdia at the Alliance of Nations, you are siding with Morella after all. I shouldn't be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Jorga Azmal: ""Why should I help either of you?""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Jorga Azmal: ""After your lip service to Derdia at the Alliance of Nati..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Jorga Azmal: ""So you are here to do a woman's bidding. I shouldn't be ..."*)

### Węzeł `[13]`
Mówca: **Jorga Azmal**
> ""So you are here to do a woman's bidding. I shouldn't be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Jorga Azmal: ""Why should I help either of you?""*)

### Węzeł `[14]`
Mówca: **Jorga Azmal**
> ""Why should I help either of you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus: ""Peace between Morella, Rizia and Derdia could be lucrati..."*)
  - -> `[4]` (*Player_Romus: ""Don't you realize Morella is on the verge of joining the..."*)
  - -> `[5]` (*Player_Romus: ""It's not about 'help'. It's about Derdians breaking the ..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a man of God. Must your goodwill be earned, or can it not be freely given?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Jorga Azmal: ""As St. Wruhec has said, 'Generosity is the heart's river..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""Remember the words of St. Wruhec. 'The light of compassi..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""You are a man of God. Must your goodwill be earned, or c..."*)

### Węzeł `[19]`
Mówca: **Jorga Azmal**
> ""As St. Wruhec has said, 'Generosity is the heart's river, but let its waters flow with discernment'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He sat back on his cushion for a moment."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember the words of St. Wruhec. 'The light of compassion can illuminate even those who walk in the darkest of shadows.'""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[14]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Jorga Azmal: ""Yes, that is so.""*)

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""Yes, that is so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He sat back on his cushion for a moment."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He sat back on his cushion, looking defiant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "He sat back on his cushion for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""My country's fighting a war, Supreme Wiseman. I don't ha..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
Mówca: **Jorga Azmal**
> ""You approached me, not the other way around. And this as far as I will go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""And only if she is willing to compromise and allow Derdians into Morella's Archsanctuaries. Unlike you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[64]` (*Player_Romus: ""She is a reasonable leader. I'm sure she will be able to..."*)
  - -> `[37]` (*Player_Romus: ""I have spoken to her. I highly doubt she will compromise..."*)

### Węzeł `[30]`
Mówca: **Jorga Azmal**
> ""Tell Ms. Saltana I will talk to her. But only if the King of Rizia is present to act as an intermediary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the Lord on our side, we will convince her to aid your people in their holy travels.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal), `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Jorga Azmal: ""Halaita. If it is said, so it will be.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My country's fighting a war, Supreme Wiseman. I don't have time to mediate my neighbors' squabbles.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal), `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Jorga Azmal: ""You approached me, not the other way around. And this as..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""With the Lord on our side, we will convince her to aid y..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""Halaita. If it is said, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have spoken to her. I highly doubt she will compromise on that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal), `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Jorga Azmal: ""I will give her one chance. If she refuses it, the Derdi..."*)

### Węzeł `[38]`
Mówca: **Jorga Azmal**
> ""There is no 'halfway' when it comes to the holy duties of a Golcondist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "He smirked slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Jorga Azmal: ""In that case...""*)

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Jorga Azmal: ""Tell Ms. Saltana I will talk to her. But only if the Kin..."*)

### Węzeł `[42]`
Mówca: **Jorga Azmal**
> ""Or is it your Morellan friends you are worried about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""A pipeline is out of the question. Isn't there anything ..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Budg..."*)

### Węzeł `[43]`
Mówca: **Jorga Azmal**
> ""We are not allies, Your Majesty. This is purely a matter of convenience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Budg..."*)

### Węzeł `[44]`
Mówca: **Jorga Azmal**
> ""I will give her one chance. If she refuses it, the Derdians' holy struggle will continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[45]`
Mówca: **Jorga Azmal**
> ""Or a way to make sure you still have resources for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Jorga Azmal: ""It's an investment, Your Majesty. Into the future of thi..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'For lo, true virtue lies in balancing the celestial with the hearth.'""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Jorga Azmal: ""And we in Derdia have plenty of hearths to keep alit.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me regret this, Mr. Azmal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Jorga Azmal: ""I assure you I will not.""*)

### Węzeł `[48]`
Mówca: **Jorga Azmal**
> ""Promises are easier to make than fulfill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "He gave Sal and myself an appraising look."*)

### Węzeł `[49]`
Mówca: **Jorga Azmal**
> ""I assure you I will not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "He gave Sal and myself an appraising look."*)

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""And we in Derdia have plenty of hearths to keep alit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "He gave Sal and myself an appraising look."*)

### Węzeł `[51]`
Mówca: **Jorga Azmal**
> ""His pen was but a conduit for the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "He gave Sal and myself an appraising look."*)

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""It's an investment, Your Majesty. Into the future of this region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""A pipeline is out of the question. Isn't there anything ..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Budg..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pipeline is out of the question. Isn't there anything else you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Jorga Azmal), `[52]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Jorga Azmal: ""In that case...""*)

### Węzeł `[54]`
Mówca: **Narrator**
> "A faint smile appeared on Sal's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Sal Ignacius: ""As Wruhec wrote, 'Reach not for the stars above your hea..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was easier than I expected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Jorga Azmal: ""Promises are easier to make than fulfill.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wrote a lot, didn't he?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Jorga Azmal: ""His pen was but a conduit for the Divine.""*)

### Węzeł `[57]`
Mówca: **Sal Ignacius**
> ""As Wruhec wrote, 'Reach not for the stars above your head...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Jorga Azmal: ""...before tending to the soil beneath your feet.""*)

### Węzeł `[58]`
Mówca: **Jorga Azmal**
> ""...before tending to the soil beneath your feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC...."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; 
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 2;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC.MorellaConditions_DerdianProblemSolved = true; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true;
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone = true;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 2;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.MorellaConditions_DerdianProblemSolved"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone"] = true;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""That was easier than I expected.""*)
  - -> `[47]` (*Player_Romus: ""Don't make me regret this, Mr. Azmal.""*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone." [-2 Energy For +2 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[42]` (Jorga Azmal), `[43]` (Jorga Azmal), `[52]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "A faint smile appeared on Sal's lips."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""'For lo, true virtue lies in balancing the celestial wit..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""He wrote a lot, didn't he?""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is a reasonable leader. I'm sure she will be able to meet you halfway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal), `[88]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Jorga Azmal: ""There is no 'halfway' when it comes to the holy duties o..."*)

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""I have heard of your gas pipeline to Morella. Extend it to Derdia, and I will order our pilgrims away from Morella's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 1"*)
  - -> `[75]` (*Player_Romus: ""I can't do that. Too much could go wrong.""*)
  - -> `[71]` (*Player_Romus: ""Perfect. I wanted to suggest an energy partnership anyway.""*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He cast a suspicious glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Jorga Azmal: ""We are not allies, Your Majesty. This is purely a matter..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Jorga Azmal: ""Tell Ms. Saltana I will talk to her. But only if the Kin..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Jorga Azmal: ""There is one thing we Derdians need more than access to ..."*)

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""There is one thing we Derdians need more than access to sacred sites. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""I have heard of your gas pipeline to Morella. Extend it ..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. I wanted to suggest an energy partnership anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He cast a suspicious glance at me."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Respectfully, Supreme Wiseman, we barely have enough energy to sell to Morella, let alone Derdia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1`
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Jorga Azmal: ""So Rizia's legendary gas wealth is a myth.""*)

### Węzeł `[73]`
Mówca: **Jorga Azmal**
> ""So Rizia's legendary gas wealth is a myth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He smirked slightly."*)

### Węzeł `[74]`
Mówca: **Jorga Azmal**
> ""Do you not trust us, Your Majesty? The word of a Derdian is bond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Jorga Azmal: ""Or is it your Morellan friends you are worried about?""*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that. Too much could go wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Jorga Azmal: ""Do you not trust us, Your Majesty? The word of a Derdian..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""We are fighting a war. Building a pipeline would be a wa..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are fighting a war. Building a pipeline would be a waste of much-needed resources.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Jorga Azmal: ""Or a way to make sure you still have resources for years..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "He gave Sal and myself an appraising look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Budg..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Bu..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""It's a deal, Supreme Wiseman. We will extend the pipelin..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""I wish it were that easy. But I cannot fund such a const..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish it were that easy. But I cannot fund such a construction at this time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Jorga Azmal), `[43]` (Jorga Azmal), `[52]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He smirked slightly."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_GolcondistBlasphemy == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Jorga Azmal: ""And only if she is willing to compromise and allow Derdi..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_GolcondistBlasphemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Jorga Azmal: ""And only if she is willing to compromise and allow Derdi..."*)

### Węzeł `[88]`
Mówca: **Jorga Azmal**
> ""And only if she is willing to compromise and allow Derdians into Morella's Archsanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[64]` (*Player_Romus: ""She is a reasonable leader. I'm sure she will be able to..."*)
  - -> `[37]` (*Player_Romus: ""I have spoken to her. I highly doubt she will compromise..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 1"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal < 1)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Respectfully, Supreme Wiseman, we barely have enough ene..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
