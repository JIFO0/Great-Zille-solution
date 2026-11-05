# Rizia/Turn 7/Energy Partnership Friendly

- **ID konwersacji:** `383`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/383_Energy_Partnership_Friendly.md`
- **Liczba węzłów dialogowych:** 115
- **Liczba wyborów gracza:** 27

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
- `RiziaDLC.CountryRelation_Derdia_Friendly`
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
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[575]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""I doubt that Morella would allow such an extension given your history.""** | `[4]` **Jorga Azmal**: ""I hear you are constructing a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Jorga Azmal**: ""It is not Derdia's fault that w..." |
| `[6]` | **""You're right. We shouldn't be getting too far ahead of ourselves.""** | `[29]` **Jorga Azmal**: ""Once energy is flowing from Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Jorga Azmal**: ""Still, I see much potential."" |
| `[8]` | **""Perfect. Derdia, Rizia and Morella will stand strong against the CSP's overreach.""** | `[29]` **Jorga Azmal**: ""Once energy is flowing from Riz..." | `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false` | *Brak zmian stanu* | `[78]` **Jorga Azmal**: ""Both superpowers are equally re..." |
| `[12]` | **""We're at war. Our ships could get targeted.""** | `[13]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[28]` **Jorga Azmal**: ""I hear you have sold oil and ga..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[60]` **Jorga Azmal**: ""The Gulf is far north of your f..." |
| `[14]` | **""It depends on whether you are able to make peace with the Morellan prime minister.""** | `[4]` **Jorga Azmal**: ""I hear you are constructing a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Jorga Azmal**: ""Peace? Her country discarded th..." |
| `[15]` | **""An interesting possibility. I will consider it.""** | `[4]` **Jorga Azmal**: ""I hear you are constructing a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Jorga Azmal**: ""I recognize that this would req..." |
| `[23]` | **""Perfect. Derdia, Rizia and Morella will stand strong together against Arcasian im..."** | `[29]` **Jorga Azmal**: ""Once energy is flowing from Riz..." | `Variable["RiziaDLC.Trait_CommieKing"] == true` | *Brak zmian stanu* | `[78]` **Jorga Azmal**: ""Both superpowers are equally re..." |
| `[36]` | **""We would be, if we had any energy to sell you.""** | `[13]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[28]` **Jorga Azmal**: ""I hear you have sold oil and ga..." | `Variable["RiziaDLC.Resources_Energy"] < 2` | *Brak zmian stanu* | `[83]` **Jorga Azmal**: ""Ah. So I heard wrong."" |
| `[37]` | **""I am afraid not. We barely have enough energy to meet Morella's needs, let alone ..."** | `[4]` **Jorga Azmal**: ""I hear you are constructing a p..." | `Variable["RiziaDLC.Resources_Energy"] < 1` | *Brak zmian stanu* | `[64]` **Jorga Azmal**: ""Ah. A shame."" |
| `[38]` | **""I agree to extend the pipeline. But you must be ready to stop your disgraceful bo..."** | `[54]` **Jorga Azmal**: ""It is your energy, Your Majesty..." | `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2` | *Brak zmian stanu* | `[65]` **Jorga Azmal**: ""Only if she is ready to admit t..." |
| `[39]` | **""Excellent. We will begin the pipeline, and our three nations will begin a new era..."** | `[54]` **Jorga Azmal**: ""It is your energy, Your Majesty..." | `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2` | *Brak zmian stanu* | `[71]` **Jorga Azmal**: ""You're very optimistic. But I w..." |
| `[40]` | **""My answer is no. You will have to come up with another energy solution.""** | `[54]` **Jorga Azmal**: ""It is your energy, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Jorga Azmal**: ""That's unfortunate, Your Majesty."" |
| `[44]` | **""I wouldn't call energy 'riches'. It is a basic need.""** | `[43]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Jorga Azmal**: ""Precisely. We cannot honor God ..." |
| `[45]` | **""Remember Wruhec's words, Sal. Do not reach for the stars above your head before t..."** | `[43]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[46]` **Jorga Azmal**: ""Precisely."" |
| `[52]` | **""All right. An energy agreement it is." [-2 Energy Per Turn, +3 Budget Per Turn]"** | `[89]` **Jorga Azmal**: ""Think about it. Once your Zille..."<br>`[90]` **Jorga Azmal**: ""It will be easier to trade with..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = ...` | `[51]` **Jorga Azmal**: ""Thank you, Your Majesty."" |
| `[53]` | **""Nevertheless, I would rather not make an energy deal at this time.""** | `[89]` **Jorga Azmal**: ""Think about it. Once your Zille..."<br>`[90]` **Jorga Azmal**: ""It will be easier to trade with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Jorga Azmal**: ""That's too bad, Your Majesty."" |
| `[58]` | **""Wouldn't it be easier for you to buy oil from Wehlen?""** | `[13]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[28]` **Jorga Azmal**: ""I hear you have sold oil and ga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Jorga Azmal**: ""Wehlen? Your Majesty, Wiktor Sm..." |
| `[59]` | **""To be frank, we need your diplomatic support more than we need you to buy our ene..."** | `[13]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[28]` **Jorga Azmal**: ""I hear you have sold oil and ga..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Resources_Energy"] < 1) == false` | *Brak zmian stanu* | `[76]` **Jorga Azmal**: ""Diplomatic support from a count..." |
| `[73]` | **""He is only trying to provide for his people, Grand Wiseman. Just as I am doing in..."** | `[43]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Jorga Azmal**: ""Yes, we cannot be expected to c..." |
| `[74]` | **""Indeed, Azmal. You cannot have it both ways.""** | `[43]` **Sal Ignacius**: ""Ignoring your religious ideals ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Jorga Azmal**: ""You asked me about closer ties,..." |
| `[82]` | **""That's exactly the kind of strengthened ties I was thinking of, Supreme Wiseman.""** | `[13]` **Jorga Azmal**: ""You do not want to extend your ..."<br>`[28]` **Jorga Azmal**: ""I hear you have sold oil and ga..." | `(Variable["RiziaDLC.Resources_Energy"] < 2) == false` | *Brak zmian stanu* | `[77]` **Jorga Azmal**: ""When two like souls converge, t..." |
| `[84]` | **""The Empire of Moridia, united once more. It warms my heart.""** | `[29]` **Jorga Azmal**: ""Once energy is flowing from Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Jorga Azmal**: ""'United' is not the word for it..." |
| `[98]` | **""May St. Wruhec bless our bond.""** | `[70]` **Jorga Azmal**: ""Our great Nurist republic will ..."<br>`[93]` **Jorga Azmal**: ""But as long as you continue to ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Jorga Azmal**: ""From now through eternity."" |
| `[99]` | **""I will hold you to those words, Supreme Wiseman.""** | `[70]` **Jorga Azmal**: ""Our great Nurist republic will ..."<br>`[93]` **Jorga Azmal**: ""But as long as you continue to ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Jorga Azmal**: ""From my lips to God's ears."" |
| `[100]` | **""You need not be outspoken in your support. Behind the scenes is fine.""** | `[70]` **Jorga Azmal**: ""Our great Nurist republic will ..."<br>`[93]` **Jorga Azmal**: ""But as long as you continue to ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "Azmal looked somewhat wounded." |
| `[101]` | **""An energy partnership is enough for now, I think.""** | `[70]` **Jorga Azmal**: ""Our great Nurist republic will ..."<br>`[93]` **Jorga Azmal**: ""But as long as you continue to ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "Azmal nodded slowly." |
| `[114]` | **""Sorry. But it's out of the realm of possibility for us at the moment.""** | `[54]` **Jorga Azmal**: ""It is your energy, Your Majesty..." | `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false` | *Brak zmian stanu* | `[72]` **Jorga Azmal**: ""That's unfortunate, Your Majesty."" |

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
  - -> `[91]` (*Narrator: "Azmal's eyes lit up."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[3]`
Mówca: **Jorga Azmal**
> ""In fact, I was hoping to speak with you about an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Jorga Azmal: ""I hear you are constructing a pipeline between Rizia and..."*)

### Węzeł `[4]`
Mówca: **Jorga Azmal**
> ""I hear you are constructing a pipeline between Rizia and Morella. Can it be extended to my country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""I doubt that Morella would allow such an extension given..."*)
  - -> `[14]` (*Player_Romus: ""It depends on whether you are able to make peace with th..."*)
  - -> `[15]` (*Player_Romus: ""An interesting possibility. I will consider it.""*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt that Morella would allow such an extension given your history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Jorga Azmal: ""It is not Derdia's fault that we are cruelly barred from..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We shouldn't be getting too far ahead of ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Jorga Azmal: ""Still, I see much potential.""*)

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""It is not Derdia's fault that we are cruelly barred from our ancestral places of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""But for a chance at energy security, I am willing to fac..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong against the CSP's overreach.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Jorga Azmal: ""Both superpowers are equally repugnant to me, Your Majes..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""We're at war. Our ships could get targeted.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're at war. Our ships could get targeted.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Jorga Azmal), `[28]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Jorga Azmal: ""The Gulf is far north of your front, is it not? Shipping..."*)

### Węzeł `[13]`
Mówca: **Jorga Azmal**
> ""You do not want to extend your pipeline from Morella. But perhaps you would still be willing to ship us oil or gas across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 2"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[58]` (*Player_Romus: ""Wouldn't it be easier for you to buy oil from Wehlen?""*)
  - -> `[59]` (*Player_Romus: ""To be frank, we need your diplomatic support more than w..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It depends on whether you are able to make peace with the Morellan prime minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Jorga Azmal: ""Peace? Her country discarded that chance when it closed ..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An interesting possibility. I will consider it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Jorga Azmal: ""I recognize that this would require closer cooperation w..."*)

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""I recognize that this would require closer cooperation with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""But for a chance at energy security, I am willing to fac..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Jorga Azmal: ""The pipeline you have promised is a good start.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""I have not given up hope that we may form an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Jorga Azmal: ""You do not want to extend your pipeline from Morella. Bu..."*)

### Węzeł `[21]`
Mówca: **Jorga Azmal**
> ""In fact, I was hoping to speak with you about an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Jorga Azmal: ""I hear you have sold oil and gas to other Merkopan count..."*)

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""The pipeline you have promised is a good start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Jorga Azmal: ""Once energy is flowing from Rizia to Derdia, we can begi..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong together against Arcasian imperialism.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Jorga Azmal: ""Both superpowers are equally repugnant to me, Your Majes..."*)

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""But for a chance at energy security, I am willing to face the devil herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Sal smiled faintly."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_CommieKing == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_CommieKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Perfect. Derdia, Rizia and Morella will stand strong tog..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_CommieKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Perfect. Derdia, Rizia and Morella will stand strong aga..."*)

### Węzeł `[28]`
Mówca: **Jorga Azmal**
> ""I hear you have sold oil and gas to other Merkopan countries. Perhaps you would be willing to ship it to us across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 2"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[58]` (*Player_Romus: ""Wouldn't it be easier for you to buy oil from Wehlen?""*)
  - -> `[59]` (*Player_Romus: ""To be frank, we need your diplomatic support more than w..."*)

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""Once energy is flowing from Rizia to Derdia, we can begin to talk about further cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""You're right. We shouldn't be getting too far ahead of o..."*)
  - -> `[84]` (*Player_Romus: ""The Empire of Moridia, united once more. It warms my hea..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_CommieKing == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Jorga Azmal: ""I have not given up hope that we may form an energy part..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Jorga Azmal: ""In fact, I was hoping to speak with you about an energy ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Jorga Azmal: ""In fact, I was hoping to speak with you about an energy ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would be, if we had any energy to sell you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] < 2`
- **Kontekst wejściowy (poprzednik):** `[13]` (Jorga Azmal), `[28]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Jorga Azmal: ""Ah. So I heard wrong.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am afraid not. We barely have enough energy to meet Morella's needs, let alone Derdia's.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Kontekst wejściowy (poprzednik):** `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Jorga Azmal: ""Ah. A shame.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""I agree to extend the pipeline. But you must be ready to stop your disgraceful border violations." [-2 Energy For +4 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""I agree to extend the pipeline. But you must be ready to stop your disgraceful border violations.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[54]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""Only if she is ready to admit that she has wronged us.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Excellent. We will begin the pipeline, and our three nations will begin a new era of peace and cooperation." [-2 Energy For +4 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""Excellent. We will begin the pipeline, and our three nations will begin a new era of peace and cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[54]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Jorga Azmal: ""You're very optimistic. But I would not count on Morella..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My answer is no. You will have to come up with another energy solution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Jorga Azmal: ""That's unfortunate, Your Majesty.""*)

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""Peace? Her country discarded that chance when it closed its borders to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""But for a chance at energy security, I am willing to fac..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Sal smiled faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""Ignoring your religious ideals for the sake of earthly r..."*)

### Węzeł `[43]`
Mówca: **Sal Ignacius**
> ""Ignoring your religious ideals for the sake of earthly riches. Your true colors are showing, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""He is only trying to provide for his people, Grand Wisem..."*)
  - -> `[74]` (*Player_Romus: ""Indeed, Azmal. You cannot have it both ways.""*)
  - -> `[44]` (*Player_Romus: ""I wouldn't call energy 'riches'. It is a basic need.""*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't call energy 'riches'. It is a basic need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Jorga Azmal: ""Precisely. We cannot honor God if we cannot keep the lig..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember Wruhec's words, Sal. Do not reach for the stars above your head before tending to the soil beneath your feet.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[43]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1"*)

### Węzeł `[46]`
Mówca: **Jorga Azmal**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""It is your energy, Your Majesty. And your decision.""*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Jorga Azmal: ""Precisely.""*)

### Węzeł `[48]`
Mówca: **Jorga Azmal**
> ""Precisely. We cannot honor God if we cannot keep the lights on at our sanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""It is your energy, Your Majesty. And your decision.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true; 
RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; 
RiziaDLC.Energy_Modifier_DerdiaEnergyExport = -2;
RiziaDLC.Budget_Modifier_DerdiaTrade = 3;
RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true;
RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping = true;
RiziaDLC.Derdia_EnergyShippingAgreement = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Energy_Modifier_DerdiaEnergyExport"] = -2;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 3;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping"] = true;
Variable["RiziaDLC.Derdia_EnergyShippingAgreement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Jorga Azmal: ""Thank you, Your Majesty.""*)

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""That's too bad, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Jorga Azmal: ""Regardless, we will do our best to support you in other ..."*)

### Węzeł `[51]`
Mówca: **Jorga Azmal**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Jorga Azmal: ""Our great Nurist republic will endeavor to support you d..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""All right. An energy agreement it is." [-2 Energy Per Turn, +3 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""All right. An energy agreement it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Jorga Azmal), `[90]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;  Rizia..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nevertheless, I would rather not make an energy deal at this time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Jorga Azmal), `[90]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Jorga Azmal: ""That's too bad, Your Majesty.""*)

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""It is your energy, Your Majesty. And your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Budge..."*)
  - -> `[40]` (*Player_Romus: ""My answer is no. You will have to come up with another e..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 2"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy < 2)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""We would be, if we had any energy to sell you.""*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""That's exactly the kind of strengthened ties I was think..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't it be easier for you to buy oil from Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Jorga Azmal), `[28]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Jorga Azmal: ""Wehlen? Your Majesty, Wiktor Smolak's persecution of Gol..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be frank, we need your diplomatic support more than we need you to buy our energy.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Jorga Azmal), `[28]` (Jorga Azmal), `[4]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Jorga Azmal: ""Diplomatic support from a country with rolling blackouts..."*)

### Węzeł `[60]`
Mówca: **Jorga Azmal**
> ""The Gulf is far north of your front, is it not? Shipping has not been disrupted so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Jorga Azmal: ""Think about it. Once your Zille harbor is recovered, the..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy < 1)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""I am afraid not. We barely have enough energy to meet Mo..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""To be frank, we need your diplomatic support more than w..."*)

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""Ah. A shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Jorga Azmal: ""Regardless, we will do our best to support you in other ..."*)

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""Only if she is ready to admit that she has wronged us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; Ri..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""Remember Wruhec's words, Sal. Do not reach for the stars..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""Our great Nurist republic will endeavor to support you diplomatically as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""May St. Wruhec bless our bond.""*)
  - -> `[99]` (*Player_Romus: ""I will hold you to those words, Supreme Wiseman.""*)
  - -> `[100]` (*Player_Romus: ""You need not be outspoken in your support. Behind the sc..."*)
  - -> `[101]` (*Player_Romus: ""An energy partnership is enough for now, I think.""*)

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""You're very optimistic. But I would not count on Morella to offer either of those to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; Ri..."*)

### Węzeł `[72]`
Mówca: **Jorga Azmal**
> ""That's unfortunate, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Jorga Azmal: ""Regardless, we will do our best to support you in other ..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He is only trying to provide for his people, Grand Wiseman. Just as I am doing in Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Jorga Azmal: ""Yes, we cannot be expected to carry out our religious du..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Azmal. You cannot have it both ways.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Jorga Azmal: ""You asked me about closer ties, Your Majesty. This is my..."*)

### Węzeł `[75]`
Mówca: **Jorga Azmal**
> ""You asked me about closer ties, Your Majesty. This is my answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""It is your energy, Your Majesty. And your decision.""*)

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""Diplomatic support from a country with rolling blackouts. I'm not sure how much that's worth, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Jorga Azmal: ""But we will endeavor to support you however we can.""*)

### Węzeł `[77]`
Mówca: **Jorga Azmal**
> ""When two like souls converge, the Divine smiles upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Jorga Azmal: ""Think about it. Once your Zille harbor is recovered, the..."*)

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""Both superpowers are equally repugnant to me, Your Majesty. All I wish is for both of them to leave Derdia alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Jorga Azmal: ""But as long as you continue to support Golcondists, we w..."*)

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""Still, I see much potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Jorga Azmal: ""As long as you do not succumb to the Morellans' influenc..."*)

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""'United' is not the word for it. But if Rizia wishes for us to keep the peace, we shall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Jorga Azmal: ""As long as you do not succumb to the Morellans' influenc..."*)

### Węzeł `[81]`
Mówca: **Jorga Azmal**
> ""Wehlen? Your Majesty, Wiktor Smolak's persecution of Golcondists makes Morella's border controls seem gentle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Jorga Azmal: ""He will not even grant our pilgrims passage through his ..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly the kind of strengthened ties I was thinking of, Supreme Wiseman.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Energy"] < 2) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Jorga Azmal), `[28]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Jorga Azmal: ""When two like souls converge, the Divine smiles upon them.""*)

### Węzeł `[83]`
Mówca: **Jorga Azmal**
> ""Ah. So I heard wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Jorga Azmal: ""We ourselves have implemented rolling blackouts recently.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Empire of Moridia, united once more. It warms my heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Jorga Azmal: ""'United' is not the word for it. But if Rizia wishes for..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Jorga Azmal: ""It will be easier to trade with Rizia once your Zille ha..."*)

### Węzeł `[86]`
Mówca: **Jorga Azmal**
> ""Yes, we cannot be expected to carry out our religious duties without heat or electricity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""It is your energy, Your Majesty. And your decision.""*)

### Węzeł `[87]`
Mówca: **Jorga Azmal**
> ""We ourselves have implemented rolling blackouts recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Jorga Azmal: ""We may not be able to help each other with our energy ne..."*)

### Węzeł `[88]`
Mówca: **Jorga Azmal**
> ""He will not even grant our pilgrims passage through his country to the holy Archsanctuary of Deyr. And you think he will trade with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[89]`
Mówca: **Jorga Azmal**
> ""Think about it. Once your Zille harbor is recovered, the distance between our ports will be practically nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""All right. An energy agreement it is." [-2 Energy Per Tu..."*)
  - -> `[53]` (*Player_Romus: ""Nevertheless, I would rather not make an energy deal at ..."*)

### Węzeł `[90]`
Mówca: **Jorga Azmal**
> ""It will be easier to trade with Rizia once your Zille harbor is recovered from that madman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""All right. An energy agreement it is." [-2 Energy Per Tu..."*)
  - -> `[53]` (*Player_Romus: ""Nevertheless, I would rather not make an energy deal at ..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Azmal's eyes lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Jorga Azmal: ""I would welcome the chance for Derdia to grow closer to ..."*)

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""I would welcome the chance for Derdia to grow closer to our Rizian brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true"*)

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""But as long as you continue to support Golcondists, we will endeavor to support you in whatever matters we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""May St. Wruhec bless our bond.""*)
  - -> `[99]` (*Player_Romus: ""I will hold you to those words, Supreme Wiseman.""*)
  - -> `[100]` (*Player_Romus: ""You need not be outspoken in your support. Behind the sc..."*)
  - -> `[101]` (*Player_Romus: ""An energy partnership is enough for now, I think.""*)

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""But we will endeavor to support you however we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""May St. Wruhec bless our bond.""*)
  - -> `[99]` (*Player_Romus: ""I will hold you to those words, Supreme Wiseman.""*)
  - -> `[100]` (*Player_Romus: ""You need not be outspoken in your support. Behind the sc..."*)

### Węzeł `[95]`
Mówca: **Jorga Azmal**
> ""We may not be able to help each other with our energy needs. But you will have our support in other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""May St. Wruhec bless our bond.""*)
  - -> `[99]` (*Player_Romus: ""I will hold you to those words, Supreme Wiseman.""*)
  - -> `[100]` (*Player_Romus: ""You need not be outspoken in your support. Behind the sc..."*)

### Węzeł `[96]`
Mówca: **Jorga Azmal**
> ""Regardless, we will do our best to support you in other matters if that is what you desire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""May St. Wruhec bless our bond.""*)
  - -> `[100]` (*Player_Romus: ""You need not be outspoken in your support. Behind the sc..."*)

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""As long as you do not succumb to the Morellans' influence, we will endeavor to support you in whatever matters we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""May St. Wruhec bless our bond.""*)
  - -> `[99]` (*Player_Romus: ""I will hold you to those words, Supreme Wiseman.""*)
  - -> `[100]` (*Player_Romus: ""You need not be outspoken in your support. Behind the sc..."*)
  - -> `[101]` (*Player_Romus: ""An energy partnership is enough for now, I think.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May St. Wruhec bless our bond.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal), `[93]` (Jorga Azmal), `[94]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Jorga Azmal: ""From now through eternity.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will hold you to those words, Supreme Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal), `[93]` (Jorga Azmal), `[94]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Jorga Azmal: ""From my lips to God's ears.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You need not be outspoken in your support. Behind the scenes is fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal), `[93]` (Jorga Azmal), `[94]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Azmal looked somewhat wounded."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An energy partnership is enough for now, I think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Jorga Azmal), `[93]` (Jorga Azmal), `[97]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Azmal nodded slowly."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Azmal looked somewhat wounded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[103]`
Mówca: **Jorga Azmal**
> ""If you do not wish to be associated with Derdia, we will stay in the shadows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Azmal nodded slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""We will see where it takes us.""*)

### Węzeł `[105]`
Mówca: **Jorga Azmal**
> ""We will see where it takes us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[106]`
Mówca: **Jorga Azmal**
> ""From now through eternity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Derdia_Friendly = true"*)

### Węzeł `[107]`
Mówca: **Jorga Azmal**
> ""From my lips to God's ears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Derdia_Friendly = true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Jorga Azmal: ""If you do not wish to be associated with Derdia, we will..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Derdia_Friendly = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true; 
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 4;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 4;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = t..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Budge..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_Bud..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""I agree to extend the pipeline. But you must be ready to..."*)
  - -> `[39]` (*Player_Romus: ""Excellent. We will begin the pipeline, and our three nat..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus: ""Sorry. But it's out of the realm of possibility for us a..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. But it's out of the realm of possibility for us at the moment.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Jorga Azmal: ""That's unfortunate, Your Majesty.""*)
