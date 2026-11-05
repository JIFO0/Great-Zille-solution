# Rizia/Turn 7/Energy Partnership Unfriendly

- **ID konwersacji:** `382`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/382_Energy_Partnership_Unfriendly.md`
- **Liczba węzłów dialogowych:** 109
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
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.Turn07_DerdiaRequests_Morella`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Derdia_EnergyShippingAgreement`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_DerdiaEnergyExport`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting`
- `RiziaDLCIsolated.Turn07_Derdia_FavorsDone`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`
- `RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping`
- `RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[536]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""I doubt that Morella would allow such an extension given your history.""** | `[7]` **Jorga Azmal**: ""I hear you are constructing a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Jorga Azmal**: ""It is not Derdia's fault that w..." |
| `[9]` | **""Agreed. We shouldn't be getting too far ahead of ourselves.""** | `[32]` **Jorga Azmal**: ""Get energy flowing from Morella..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Jorga Azmal**: ""Indeed not."" |
| `[11]` | **""Perfect. Derdia, Rizia and Morella will stand strong against the CSP's overreach.""** | `[32]` **Jorga Azmal**: ""Get energy flowing from Morella..." | `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false` | *Brak zmian stanu* | `[91]` **Jorga Azmal**: ""I do not share your animosity t..." |
| `[15]` | **""We're at war. Our ships could get targeted.""** | `[16]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[31]` **Jorga Azmal**: ""I hear you have formed energy p..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[64]` **Jorga Azmal**: ""The Gulf is far north of your f..." |
| `[17]` | **""It depends on whether you are able to make peace with the Morellan prime minister.""** | `[7]` **Jorga Azmal**: ""I hear you are constructing a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Jorga Azmal**: ""Peace? Her country discarded th..." |
| `[18]` | **""An interesting possibility. I will consider it.""** | `[7]` **Jorga Azmal**: ""I hear you are constructing a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Jorga Azmal**: ""I recognize that it would requi..." |
| `[26]` | **""Perfect. Derdia, Rizia and Morella will stand strong together against Arcasian im..."** | `[32]` **Jorga Azmal**: ""Get energy flowing from Morella..." | `Variable["RiziaDLC.Trait_CommieKing"] == true` | *Brak zmian stanu* | `[91]` **Jorga Azmal**: ""I do not share your animosity t..." |
| `[39]` | **""We would be, if we had any energy to sell you.""** | `[31]` **Jorga Azmal**: ""I hear you have formed energy p..." | `Variable["RiziaDLC.Resources_Energy"] < 2` | *Brak zmian stanu* | `[96]` **Jorga Azmal**: ""Ah. So the mighty Rizia is faci..." |
| `[40]` | **""I am afraid not. We barely have enough energy to meet Morella's needs, let alone ..."** | `[7]` **Jorga Azmal**: ""I hear you are constructing a p..." | `Variable["RiziaDLC.Resources_Energy"] < 1` | *Brak zmian stanu* | `[69]` **Jorga Azmal**: ""Ah. A shame."" |
| `[42]` | **""I shall begin the pipeline. But you must be ready to stop your disgraceful border..."** | `[58]` **Jorga Azmal**: ""In the end, it is your energy a..." | `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2` | *Brak zmian stanu* | `[71]` **Jorga Azmal**: ""Only if she is ready to admit t..." |
| `[43]` | **""Excellent. We will build the pipeline, and together, our three nations will begin..."** | `[58]` **Jorga Azmal**: ""In the end, it is your energy a..." | `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2` | *Brak zmian stanu* | `[78]` **Jorga Azmal**: ""Let's not get too far ahead of ..." |
| `[44]` | **""With all apologies, I cannot. A pipeline to Morella is all I can manage right now.""** | `[58]` **Jorga Azmal**: ""In the end, it is your energy a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Jorga Azmal**: ""So for all your talk of coopera..." |
| `[48]` | **""More proof that Golcondists don't have ideals at all.""** | `[47]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[52]` **Jorga Azmal**: ""You ask me for a closer relatio..." |
| `[49]` | **""Remember Wruhec's words, Sal. Do not reach for the stars above your head before t..."** | `[47]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[50]` **Jorga Azmal**: ""Precisely."" |
| `[56]` | **""All right. An energy agreement it is." [-2 Energy Per Turn, +2 Budget Per Turn]"** | `[89]` **Jorga Azmal**: ""Until your holy institutions re..."<br>`[103]` **Jorga Azmal**: ""Think about it. Once your Zille..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = ...` | `[55]` **Jorga Azmal**: ""Thank you, Your Majesty."" |
| `[57]` | **""Nevertheless, I would rather not make an energy deal with you.""** | `[89]` **Jorga Azmal**: ""Until your holy institutions re..."<br>`[103]` **Jorga Azmal**: ""Think about it. Once your Zille..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Jorga Azmal**: ""Then we have failed to find com..." |
| `[62]` | **""Wouldn't it be easier for you to buy oil from Wehlen?""** | `[16]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[31]` **Jorga Azmal**: ""I hear you have formed energy p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Jorga Azmal**: ""Wehlen? Your Majesty, Wiktor Sm..." |
| `[63]` | **""To be frank, we need your diplomatic support more than we need you to buy our ene..."** | `[16]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[31]` **Jorga Azmal**: ""I hear you have formed energy p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Jorga Azmal**: ""Until your holy institutions re..." |
| `[68]` | **""I was thinking of a different kind of partnership.""** | `[7]` **Jorga Azmal**: ""I hear you are constructing a p..." | `(Variable["RiziaDLC.Resources_Energy"] < 1) == false` | *Brak zmian stanu* | `[41]` **Jorga Azmal**: ""Until your holy institutions re..." |
| `[77]` | **""I wish I could help you. But we lack the funds for such a construction.""** | `[58]` **Jorga Azmal**: ""In the end, it is your energy a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Jorga Azmal**: ""And yet you were able to afford..." |
| `[83]` | **""He is only trying to provide for his people, Grand Wiseman. Just as I am doing in..."** | `[47]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Jorga Azmal**: ""Yes, we cannot be expected to c..." |
| `[84]` | **""Indeed, Azmal. You cannot have it both ways.""** | `[47]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Jorga Azmal**: ""You asked me about closer ties,..." |
| `[95]` | **""That's exactly the kind of partnership I was thinking of, Supreme Wiseman.""** | `[31]` **Jorga Azmal**: ""I hear you have formed energy p..." | `(Variable["RiziaDLC.Resources_Energy"] < 2) == false` | *Brak zmian stanu* | `[90]` **Jorga Azmal**: ""I am glad we are on the same pa..." |
| `[98]` | **""The Empire of Moridia, united once more. It warms my heart.""** | `[32]` **Jorga Azmal**: ""Get energy flowing from Morella..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Jorga Azmal**: ""'United' is not the term for it."" |

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
  - -> `[3]` (*Jorga Azmal: ""Do you?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[3]`
Mówca: **Jorga Azmal**
> ""Do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "He adjusted the folds of his robe."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "He adjusted the folds of his robe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Jorga Azmal: ""I will remind you that you had an opportunity to strengt..."*)

### Węzeł `[5]`
Mówca: **Jorga Azmal**
> ""I will remind you that you had an opportunity to strengthen those ties by lifting your Golcondist ban. You did not seize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true"*)

### Węzeł `[6]`
Mówca: **Jorga Azmal**
> ""But there is one other thing Rizia can help us with. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Jorga Azmal: ""I hear you are constructing a pipeline between Rizia and..."*)

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""I hear you are constructing a pipeline between Rizia and Morella. Can it be extended to my country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""I doubt that Morella would allow such an extension given..."*)
  - -> `[17]` (*Player_Romus: ""It depends on whether you are able to make peace with th..."*)
  - -> `[18]` (*Player_Romus: ""An interesting possibility. I will consider it.""*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt that Morella would allow such an extension given your history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Jorga Azmal: ""It is not Derdia's fault that we are cruelly barred from..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. We shouldn't be getting too far ahead of ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Jorga Azmal: ""Indeed not.""*)

### Węzeł `[10]`
Mówca: **Jorga Azmal**
> ""It is not Derdia's fault that we are cruelly barred from our ancestral places of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Jorga Azmal: ""But for a chance at energy security, I am willing to fac..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong against the CSP's overreach.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Jorga Azmal: ""I do not share your animosity towards the superpowers. F..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""We're at war. Our ships could get targeted.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're at war. Our ships could get targeted.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Jorga Azmal), `[31]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Jorga Azmal: ""The Gulf is far north of your front, is it not? Shipping..."*)

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""You do not want to extend your pipeline from Morella. But perhaps you would still be willing to ship us oil or gas across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[62]` (*Player_Romus: ""Wouldn't it be easier for you to buy oil from Wehlen?""*)
  - -> `[63]` (*Player_Romus: ""To be frank, we need your diplomatic support more than w..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It depends on whether you are able to make peace with the Morellan prime minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Jorga Azmal: ""Peace? Her country discarded that chance when it closed ..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An interesting possibility. I will consider it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Jorga Azmal: ""I recognize that it would require us to cooperate with M..."*)

### Węzeł `[19]`
Mówca: **Jorga Azmal**
> ""I recognize that it would require us to cooperate with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Jorga Azmal: ""But for a chance at energy security, I am willing to fac..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Jorga Azmal: ""But the pipeline you have promised is a good start.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""The only potential I see is for an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 1"*)

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""But there is one other thing Rizia can help us with. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Jorga Azmal: ""I hear you have formed energy partnerships with other Me..."*)

### Węzeł `[25]`
Mówca: **Jorga Azmal**
> ""But the pipeline you have promised is a good start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Jorga Azmal: ""Get energy flowing from Morella to my country. Then we c..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong together against Arcasian imperialism.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Jorga Azmal: ""I do not share your animosity towards the superpowers. F..."*)

### Węzeł `[27]`
Mówca: **Jorga Azmal**
> ""But for a chance at energy security, I am willing to face the devil herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Sal smiled faintly."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_CommieKing == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Perfect. Derdia, Rizia and Morella will stand strong tog..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_CommieKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""Perfect. Derdia, Rizia and Morella will stand strong aga..."*)

### Węzeł `[31]`
Mówca: **Jorga Azmal**
> ""I hear you have formed energy partnerships with other Merkopan countries. Perhaps you would be willing to ship us oil or gas across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 2"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[62]` (*Player_Romus: ""Wouldn't it be easier for you to buy oil from Wehlen?""*)
  - -> `[63]` (*Player_Romus: ""To be frank, we need your diplomatic support more than w..."*)

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""Get energy flowing from Morella to my country. Then we can talk about further cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""Agreed. We shouldn't be getting too far ahead of ourselv..."*)
  - -> `[98]` (*Player_Romus: ""The Empire of Moridia, united once more. It warms my hea..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Jorga Azmal: ""The only potential I see is for an energy partnership.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Jorga Azmal: ""But there is one other thing Rizia can help us with. Ene..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""But there is one other thing Rizia can help us with. Ene..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would be, if we had any energy to sell you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] < 2`
- **Kontekst wejściowy (poprzednik):** `[31]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Jorga Azmal: ""Ah. So the mighty Rizia is facing an energy shortage.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am afraid not. We barely have enough energy to meet Morella's needs, let alone Derdia's.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Kontekst wejściowy (poprzednik):** `[7]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Jorga Azmal: ""Ah. A shame.""*)

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""Until your holy institutions respect my country's religion, a strictly transactional relationship is all I will agree to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Sal smiled faintly."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I shall begin the pipeline. But you must be ready to stop your disgraceful border violations." [-2 Energy For +2 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""I shall begin the pipeline. But you must be ready to stop your disgraceful border violations.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Jorga Azmal: ""Only if she is ready to admit that she has wronged us.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Excellent. We will build the pipeline, and together, our three nations will begin a new era of peace and cooperation." [-2 Energy For +2 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""Excellent. We will build the pipeline, and together, our three nations will begin a new era of peace and cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Jorga Azmal: ""Let's not get too far ahead of ourselves.""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With all apologies, I cannot. A pipeline to Morella is all I can manage right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Jorga Azmal: ""So for all your talk of cooperation, you're on the side ..."*)

### Węzeł `[45]`
Mówca: **Jorga Azmal**
> ""Peace? Her country discarded that chance when it closed its borders to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Jorga Azmal: ""But for a chance at energy security, I am willing to fac..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Sal smiled faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Sal Ignacius: ""Ignoring your religious ideals for the sake of earthly r..."*)

### Węzeł `[47]`
Mówca: **Sal Ignacius**
> ""Ignoring your religious ideals for the sake of earthly riches. Your true colors are showing, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""He is only trying to provide for his people, Grand Wisem..."*)
  - -> `[84]` (*Player_Romus: ""Indeed, Azmal. You cannot have it both ways.""*)
  - -> `[48]` (*Player_Romus: ""More proof that Golcondists don't have ideals at all.""*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More proof that Golcondists don't have ideals at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember Wruhec's words, Sal. Do not reach for the stars above your head before tending to the soil beneath your feet,""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1"*)

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Jorga Azmal: ""In the end, it is your energy and your decision.""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Jorga Azmal: ""Precisely.""*)

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""You ask me for a closer relationship, only to insult me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Jorga Azmal: ""This conversation is going nowhere.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true; 
RiziaDLC.Derdia_EnergyShippingAgreement = true;
RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; 
RiziaDLC.Energy_Modifier_DerdiaEnergyExport = -2;
RiziaDLC.Budget_Modifier_DerdiaTrade = 2;
RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true;
RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Derdia_EnergyShippingAgreement"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Energy_Modifier_DerdiaEnergyExport"] = -2;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 2;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Jorga Azmal: ""Thank you, Your Majesty.""*)

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""Then we have failed to find common ground once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Jorga Azmal: ""I cannot promise closer cooperation than that. But I hop..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""All right. An energy agreement it is." [-2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""All right. An energy agreement it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Jorga Azmal), `[103]` (Jorga Azmal), `[104]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;  Rizia..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nevertheless, I would rather not make an energy deal with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Jorga Azmal), `[103]` (Jorga Azmal), `[104]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""Then we have failed to find common ground once more.""*)

### Węzeł `[58]`
Mówca: **Jorga Azmal**
> ""In the end, it is your energy and your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Budg..."*)
  - -> `[44]` (*Player_Romus: ""With all apologies, I cannot. A pipeline to Morella is a..."*)
  - -> `[77]` (*Player_Romus: ""I wish I could help you. But we lack the funds for such ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 2"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy < 2)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""We would be, if we had any energy to sell you.""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""That's exactly the kind of partnership I was thinking of..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't it be easier for you to buy oil from Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Jorga Azmal), `[31]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Jorga Azmal: ""Wehlen? Your Majesty, Wiktor Smolak's persecution of Gol..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be frank, we need your diplomatic support more than we need you to buy our energy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Jorga Azmal), `[31]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Jorga Azmal: ""Until your holy institutions respect my country's religi..."*)

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""The Gulf is far north of your front, is it not? Shipping has not been disrupted so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Jorga Azmal: ""Think about it. Once your Zille harbor is recovered, the..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy < 1)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""I am afraid not. We barely have enough energy to meet Mo..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""I was thinking of a different kind of partnership.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was thinking of a different kind of partnership.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Jorga Azmal: ""Until your holy institutions respect my country's religi..."*)

### Węzeł `[69]`
Mówca: **Jorga Azmal**
> ""Ah. A shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Jorga Azmal: ""But perhaps it is best for both of us to keep our relati..."*)

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""But perhaps it is best for both of us to keep our relationship as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""Only if she is ready to admit that she has wronged us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true;  R..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""Remember Wruhec's words, Sal. Do not reach for the stars..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""I cannot promise closer cooperation than that. But I hope you are satisfied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I could help you. But we lack the funds for such a construction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Jorga Azmal: ""And yet you were able to afford it where Morella was con..."*)

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""Let's not get too far ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true;  R..."*)

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""So for all your talk of cooperation, you're on the side of the godless heathens. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""And yet you were able to afford it where Morella was concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Jorga Azmal: ""You ask me for a closer relationship, only to insult me?""*)

### Węzeł `[82]`
Mówca: **Jorga Azmal**
> ""This conversation is going nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He is only trying to provide for his people, Grand Wiseman. Just as I am doing in Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Jorga Azmal: ""Yes, we cannot be expected to carry out our religious du..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Azmal. You cannot have it both ways.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Jorga Azmal: ""You asked me about closer ties, Your Majesty. This is my..."*)

### Węzeł `[85]`
Mówca: **Jorga Azmal**
> ""You asked me about closer ties, Your Majesty. This is my answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Jorga Azmal: ""In the end, it is your energy and your decision.""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 1"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 1)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Jorga Azmal: ""You do not want to extend your pipeline from Morella. Bu..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Jorga Azmal: ""But as I understand it, your own supplies are running to..."*)

### Węzeł `[89]`
Mówca: **Jorga Azmal**
> ""Until your holy institutions respect my country's religion, a strictly transactional relationship is all I will agree to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""All right. An energy agreement it is." [-2 Energy Per Tu..."*)
  - -> `[57]` (*Player_Romus: ""Nevertheless, I would rather not make an energy deal wit..."*)

### Węzeł `[90]`
Mówca: **Jorga Azmal**
> ""I am glad we are on the same page. Regarding this, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Jorga Azmal: ""Think about it. Once your Zille harbor is recovered, the..."*)

### Węzeł `[91]`
Mówca: **Jorga Azmal**
> ""I do not share your animosity towards the superpowers. For the last 40 years, they have been kind enough to leave Derdia alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""Indeed not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""'United' is not the term for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""Wehlen? Your Majesty, Wiktor Smolak's persecution of Golcondists makes your blasphemy laws look gentle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Jorga Azmal: ""He will not even grant our pilgrims passage through his ..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly the kind of partnership I was thinking of, Supreme Wiseman.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Energy"] < 2) == false`
- **Kontekst wejściowy (poprzednik):** `[31]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Jorga Azmal: ""I am glad we are on the same page. Regarding this, at le..."*)

### Węzeł `[96]`
Mówca: **Jorga Azmal**
> ""Ah. So the mighty Rizia is facing an energy shortage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Jorga Azmal: ""All the more reason for our nations to stay at a distanc..."*)

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""But as I understand it, your own supplies are running too low to provide us with what we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Empire of Moridia, united once more. It warms my heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Jorga Azmal: ""'United' is not the term for it.""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Jorga Azmal: ""It will be easier to trade with Rizia once your Zille ha..."*)

### Węzeł `[100]`
Mówca: **Jorga Azmal**
> ""Yes, we cannot be expected to carry out our religious duties without heat or electricity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Jorga Azmal: ""In the end, it is your energy and your decision.""*)

### Węzeł `[101]`
Mówca: **Jorga Azmal**
> ""All the more reason for our nations to stay at a distance from each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[102]`
Mówca: **Jorga Azmal**
> ""He will not even grant our pilgrims passage through his country to the holy Archsanctuary of Deyr. And you think he will trade with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[103]`
Mówca: **Jorga Azmal**
> ""Think about it. Once your Zille harbor is recovered, the distance between our ports will be practically nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""All right. An energy agreement it is." [-2 Energy Per Tu..."*)
  - -> `[57]` (*Player_Romus: ""Nevertheless, I would rather not make an energy deal wit..."*)

### Węzeł `[104]`
Mówca: **Jorga Azmal**
> ""It will be easier to trade with Rizia once your Zille harbor is recovered from that madman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""All right. An energy agreement it is." [-2 Energy Per Tu..."*)
  - -> `[57]` (*Player_Romus: ""Nevertheless, I would rather not make an energy deal wit..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; 
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true; 
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 2;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 2;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Budg..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_Bu..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""I shall begin the pipeline. But you must be ready to sto..."*)
  - -> `[43]` (*Player_Romus: ""Excellent. We will build the pipeline, and together, our..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Romus: ""I wish I could help you. But we lack the funds for such ..."*)
