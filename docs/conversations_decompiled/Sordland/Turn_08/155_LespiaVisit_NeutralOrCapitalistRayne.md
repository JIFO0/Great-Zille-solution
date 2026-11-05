# Sordland/Turn08/LespiaVisit_NeutralOrCapitalistRayne

- **ID konwersacji:** `155`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/155_LespiaVisit_NeutralOrCapitalistRayne.md`
- **Liczba węzłów dialogowych:** 201
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[3]** Patricio Alvarez
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn08_FPnT_BrokenTeapot`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.GovernmentBudget`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_SoldSordishPetroleum`
- `BaseGame.Lespia_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[154] Sordland/Turn08/FPnT_LespiaVisit** (../Turn_08/154_FPnT_LespiaVisit.md), Węzeł `[3]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“Thank you. It's good to be here, Mr. Alvarez.”"** | `[6]` **Patricio Alvarez**: "“Good to have you here. I hear a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Patricio Alvarez**: "“I hope you had a nice trip.”" |
| `[7]` | **"“And I hear a lot about your successes as well, Mr. Alvarez.”"** | `[6]` **Patricio Alvarez**: "“Good to have you here. I hear a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Patricio Alvarez**: "“I try, Mr. Rayne.”" |
| `[8]` | **"“Who doesn't?”"** | `[6]` **Patricio Alvarez**: "“Good to have you here. I hear a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "He laughed." |
| `[13]` | **"“Have you been drinking?”"** | `[12]` **Narrator**: "I smelled the strong odor of alc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Patricio Alvarez**: "“A couple of glasses of the fine..." |
| `[14]` | **"Don't say anything."** | `[12]` **Narrator**: "I smelled the strong odor of alc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Patricio Alvarez**: "“Let's begin then.”" |
| `[17]` | **"“No, thank you.”"** | `[16]` **Patricio Alvarez**: "“Would you like some?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Patricio Alvarez**: "“Very well.”" |
| `[18]` | **"“Since you asked, why not?”"** | `[16]` **Patricio Alvarez**: "“Would you like some?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "He gestured to the assistants." |
| `[19]` | **"“You are speaking to a President. Where is your professionalism?”"** | `[16]` **Patricio Alvarez**: "“Would you like some?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "He cleared his throat." |
| `[30]` | **"“Mr. Alvarez. Are you making fun of me right now?”"** | `[28]` **Patricio Alvarez**: "“What was it about again? Can yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Patricio Alvarez**: "“No. Absolutely not.”" |
| `[31]` | **"“We want to provide Sordish fishing output in return for Lespian capital.”"** | `[28]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true` | *Brak zmian stanu* | `[47]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[41]` | **"“We want to provide Sordish wheat in return for Lespian capital.”"** | `[28]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false` | *Brak zmian stanu* | `[47]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[42]` | **"“We want to provide Sordish coal in return for Lespian capital.”"** | `[28]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false` | *Brak zmian stanu* | `[47]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[43]` | **"“We want to provide Sordish tungsten in return for Lespian capital.”"** | `[28]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false` | *Brak zmian stanu* | `[47]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[66]` | **"“No. The price will stay the same or there won't be any deal.”"** | `[63]` **Patricio Alvarez**: "“Which unfortunately means that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Patricio Alvarez**: "“It is your choice.”" |
| `[67]` | **"“Tell me what you want, Mr. Alvarez.”"** | `[63]` **Patricio Alvarez**: "“Which unfortunately means that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Patricio Alvarez**: "“The only thing anyone could pos..." |
| `[68]` | **"“Makes sense. I knew this was coming. So what is on the new price tag?”"** | `[63]` **Patricio Alvarez**: "“Which unfortunately means that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Patricio Alvarez**: "“Good intuition.”" |
| `[75]` | **"“And how are you planning to get that?”"** | `[74]` **Patricio Alvarez**: "“I want their oil.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Patricio Alvarez**: "“A lot of oil from Wehlen is pas..." |
| `[76]` | **"“I'm listening.”"** | `[74]` **Patricio Alvarez**: "“I want their oil.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Patricio Alvarez**: "“A lot of oil from Wehlen is pas..." |
| `[80]` | **"“Yes, I do.”"** | `[79]` **Patricio Alvarez**: "“Do you see where I am going wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." |
| `[81]` | **"“Enlighten me.”"** | `[79]` **Patricio Alvarez**: "“Do you see where I am going wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." |
| `[83]` | **"“There is no way I can do that.”"** | `[82]` **Patricio Alvarez**: "“I want you to sell me Sordish P..."<br>`[86]` **Patricio Alvarez**: "“I will take that as a compliment.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Patricio Alvarez**: "“Then thank you for coming this ..." |
| `[84]` | **"“Very well. I accept.” [-1 Government Budget]"** | `[82]` **Patricio Alvarez**: "“I want you to sell me Sordish P..."<br>`[86]` **Patricio Alvarez**: "“I will take that as a compliment.”" | `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`<br>`(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false` | *Brak zmian stanu* | `[91]` **Patricio Alvarez**: "“My favorite phrase in this worl..." |
| `[85]` | **"“You really are a shrewd man, Mr. Alvarez.”"** | `[82]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Patricio Alvarez**: "“I will take that as a compliment.”" |
| `[89]` | **"“Wait. Fine. I accept.” [-1 Government Budget]"** | `[88]` **Narrator**: "He got up and started making his..." | `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`<br>`Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` | *Brak zmian stanu* | `[90]` **Narrator**: "He turned around with a smile an..." |
| `[95]` | **"Let him go."** | `[88]` **Narrator**: "He got up and started making his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "On his way to the door, he sudde..."<br>`[174]` **Narrator**: "He left the room and an assistan..." |
| `[102]` | **"“Thank you for the offer but that is not one of our aims for now.”"** | `[101]` **Patricio Alvarez**: "“What do you think, Mr. Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Patricio Alvarez**: "“For now...maybe.”" |
| `[103]` | **"“Why would you do that for Sordland? What's in it for you?”"** | `[101]` **Patricio Alvarez**: "“What do you think, Mr. Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Patricio Alvarez**: "“Prosperity in Eastern Merkopa!”" |
| `[104]` | **"“That sounds excellent. How do we begin?”"** | `[101]` **Patricio Alvarez**: "“What do you think, Mr. Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Patricio Alvarez**: "“Just the answer I wanted to hear!”" |
| `[121]` | **"“Down with the communists. I am willing to do whatever it takes to protect Sordland.”"** | `[120]` **Patricio Alvarez**: "“Will you defend our continent a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Patricio Alvarez**: "“Well said! First, Hegel will fa..." |
| `[122]` | **"“I think you are exaggerating the threat. I have my doubts about this.”"** | `[120]` **Patricio Alvarez**: "“Will you defend our continent a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Patricio Alvarez**: "“I am giving you this option for..." |
| `[123]` | **"“I can't decide without knowing what is in it for me.”"** | `[120]` **Patricio Alvarez**: "“Will you defend our continent a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Patricio Alvarez**: "“I see that you possess the mind..." |
| `[130]` | **"“I accept. Sordland will be allied to Lespia.” [+2 Government Budget]"** | `[127]` **Patricio Alvarez**: "“Not to mention that you will ha..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Lespia_Alliance"] = true; Variable["Ba...`<br>`Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Alli...` | `[141]` **Patricio Alvarez**: "“Perfect! Brilliant!”" |
| `[131]` | **"“I have to refuse. I will not drag Sordland into an international conflict.”"** | `[127]` **Patricio Alvarez**: "“Not to mention that you will ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Patricio Alvarez**: "“You think you are evading the c..." |
| `[150]` | **"“Take care of your own country's issues first, Mr. Alvarez.”"** | `[71]` **Patricio Alvarez**: "“Reminds me of Soll in many ways..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Patricio Alvarez**: "“I am doing exactly that right n..." |
| `[151]` | **"“I would recommend you not to badmouth Colonel Soll.”"** | `[71]` **Patricio Alvarez**: "“Reminds me of Soll in many ways..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Patricio Alvarez**: "“My apologies. I never took you ..." |
| `[152]` | **"“I had to make a hard decision and this is the result of it.”"** | `[71]` **Patricio Alvarez**: "“Reminds me of Soll in many ways..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Patricio Alvarez**: "“Not every hard decision is righ..." |
| `[158]` | **"“And?”"** | `[74]` **Patricio Alvarez**: "“I want their oil.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Patricio Alvarez**: "“A lot of oil from Wehlen is pas..." |
| `[184]` | **"“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"** | `[82]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." | `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false` | *Brak zmian stanu* | `[87]` **Patricio Alvarez**: "“Then thank you for coming this ..." |
| `[185]` | **"“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such..."** | `[86]` **Patricio Alvarez**: "“I will take that as a compliment.”" | `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false` | *Brak zmian stanu* | `[87]` **Patricio Alvarez**: "“Then thank you for coming this ..." |
| `[192]` | **"“Goodbye.”"** | `[88]` **Narrator**: "He got up and started making his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "He left the room and an assistan..." |
| `[196]` | **"“Very well. I accept.”"** | `[86]` **Patricio Alvarez**: "“I will take that as a compliment.”" | `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`<br>`Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` | *Brak zmian stanu* | `[91]` **Patricio Alvarez**: "“My favorite phrase in this worl..." |
| `[197]` | **"“Very well. I accept.”"** | `[88]` **Narrator**: "He got up and started making his..." | `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`<br>`Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` | *Brak zmian stanu* | `[90]` **Narrator**: "He turned around with a smile an..." |

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
  - -> `[4]` (*Patricio Alvarez: "“President Rayne. Welcome to Perla.”"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He laughed."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Patricio Alvarez: "“Confidence is a rare quality, Mr. Rayne.”"*)

### Węzeł `[4]`
Mówca: **Patricio Alvarez**
> "“President Rayne. Welcome to Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Patricio Alvarez: "“Good to have you here. I hear a lot about your successes.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Thank you. It's good to be here, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Thank you. It's good to be here, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Patricio Alvarez: "“I hope you had a nice trip.”"*)

### Węzeł `[6]`
Mówca: **Patricio Alvarez**
> "“Good to have you here. I hear a lot about your successes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“And I hear a lot about your successes as well, Mr. Alvar..."*)
  - -> `[5]` (*Player: "“Thank you. It's good to be here, Mr. Alvarez.”"*)
  - -> `[8]` (*Player: "“Who doesn't?”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“And I hear a lot about your successes as well, Mr. Alvarez.”"]** — Mówca: **Player**
> "“And I hear a lot about your successes as well, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Patricio Alvarez: "“I try, Mr. Rayne.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Who doesn't?”"]** — Mówca: **Player**
> "“Who doesn't?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He laughed."*)

### Węzeł `[9]`
Mówca: **Patricio Alvarez**
> "“I hope you had a nice trip.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[10]`
Mówca: **Patricio Alvarez**
> "“I try, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[11]`
Mówca: **Patricio Alvarez**
> "“Confidence is a rare quality, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "I smelled the strong odor of alcohol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“Have you been drinking?”"*)
  - -> `[14]` (*Player_Italic: "Don't say anything."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Have you been drinking?”"]** — Mówca: **Player**
> "“Have you been drinking?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Patricio Alvarez: "“A couple of glasses of the finest Lespian wine is the be..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[15]`
Mówca: **Patricio Alvarez**
> "“A couple of glasses of the finest Lespian wine is the best way to start any meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Patricio Alvarez: "“Would you like some?”"*)

### Węzeł `[16]`
Mówca: **Patricio Alvarez**
> "“Would you like some?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“No, thank you.”"*)
  - -> `[18]` (*Player: "“Since you asked, why not?”"*)
  - -> `[19]` (*Player: "“You are speaking to a President. Where is your professio..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“No, thank you.”"]** — Mówca: **Player**
> "“No, thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Patricio Alvarez: "“Very well.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Since you asked, why not?”"]** — Mówca: **Player**
> "“Since you asked, why not?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He gestured to the assistants."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“You are speaking to a President. Where is your professionalism?”"]** — Mówca: **Player**
> "“You are speaking to a President. Where is your professionalism?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "He cleared his throat."*)

### Węzeł `[20]`
Mówca: **Patricio Alvarez**
> "“Let's begin then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Patricio Alvarez: "“So, you are here for the trade deal.”"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Patricio Alvarez: "“Right.”"*)

### Węzeł `[22]`
Mówca: **Patricio Alvarez**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He gestured to the assistants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Patricio Alvarez: "“Two glasses.”"*)

### Węzeł `[24]`
Mówca: **Patricio Alvarez**
> "“Two glasses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "They came back very fast. We took a sip."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "They came back very fast. We took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Patricio Alvarez: "“Ah. Nothing like it.”"*)

### Węzeł `[26]`
Mówca: **Patricio Alvarez**
> "“Ah. Nothing like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[27]`
Mówca: **Patricio Alvarez**
> "“So, you are here for the trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Patricio Alvarez: "“What was it about again? Can you remind me?”"*)

### Węzeł `[28]`
Mówca: **Patricio Alvarez**
> "“What was it about again? Can you remind me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: "“Mr. Alvarez. Are you making fun of me right now?”"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[29]`
Mówca: **Patricio Alvarez**
> "“Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Mr. Alvarez. Are you making fun of me right now?”"]** — Mówca: **Player**
> "“Mr. Alvarez. Are you making fun of me right now?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Patricio Alvarez: "“No. Absolutely not.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“We want to provide Sordish fishing output in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish fishing output in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Kontekst wejściowy (poprzednik):** `[28]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“We want to provide Sordish coal in return for Lespian ca..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“We want to provide Sordish tungsten in return for Lespia..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“We want to provide Sordish wheat in return for Lespian c..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“We want to provide Sordish fishing output in return for ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“We want to provide Sordish wheat in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish wheat in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[28]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“We want to provide Sordish coal in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish coal in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[28]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“We want to provide Sordish tungsten in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish tungsten in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[28]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[44]`
Mówca: **Patricio Alvarez**
> "“No. Absolutely not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Patricio Alvarez: "“I have just been very busy lately.”"*)

### Węzeł `[45]`
Mówca: **Patricio Alvarez**
> "“I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Patricio Alvarez: "“You know...being the Prime Minister makes you pretty busy.”"*)

### Węzeł `[46]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Patricio Alvarez: "“So, I don't have any issues with this deal.”"*)

### Węzeł `[47]`
Mówca: **Patricio Alvarez**
> "“Ah. Yes. Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Patricio Alvarez: "“Sorry. I have just been very busy lately.”"*)

### Węzeł `[48]`
Mówca: **Patricio Alvarez**
> "“Sorry. I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Patricio Alvarez: "“You know...being the Prime Minister makes you pretty busy.”"*)

### Węzeł `[49]`
Mówca: **Patricio Alvarez**
> "“So, I don't have any issues with this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_J..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_J..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Patricio Alvarez: "“Except there is one problem.”"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Patricio Alvarez: "“I think it will contribute nicely to the relationship be..."*)

### Węzeł `[53]`
Mówca: **Patricio Alvarez**
> "“Except there is one problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "He smirked."*)

### Węzeł `[54]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He pulled out a few documents from his briefcase and star..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "He pulled out a few documents from his briefcase and started inspecting them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Patricio Alvarez: "“So, I don't have any issues with this deal.”"*)

### Węzeł `[56]`
Mówca: **Patricio Alvarez**
> "“Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Patricio Alvarez: "“Wehlen.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Patricio Alvarez: "“Your decision to defend the border while Smolak committe..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Patricio Alvarez: "“Your decision to join Smolak in his attack against the u..."*)

### Węzeł `[61]`
Mówca: **Patricio Alvarez**
> "“Your decision to defend the border while Smolak committed war crimes diverted all those refugees here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Patricio Alvarez: "“Now we have a full-blown refugee crisis in Lespia.”"*)

### Węzeł `[62]`
Mówca: **Patricio Alvarez**
> "“Now we have a full-blown refugee crisis in Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Patricio Alvarez: "“Which unfortunately means that the price has gone up, Mr..."*)

### Węzeł `[63]`
Mówca: **Patricio Alvarez**
> "“Which unfortunately means that the price has gone up, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“Tell me what you want, Mr. Alvarez.”"*)
  - -> `[66]` (*Player: "“No. The price will stay the same or there won't be any d..."*)
  - -> `[68]` (*Player: "“Makes sense. I knew this was coming. So what is on the n..."*)

### Węzeł `[64]`
Mówca: **Patricio Alvarez**
> "“Your decision to join Smolak in his attack against the unfortunate Bludish population compromised a lot of the Lespian assets in the area.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Patricio Alvarez: "“Not to mention the humanitarian implications. We had to ..."*)

### Węzeł `[65]`
Mówca: **Patricio Alvarez**
> "“This has negatively affected Lespia. Our economy was indirectly hit due to the destruction of manufacturing sites. In particular the oil refineries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Patricio Alvarez: "“Which unfortunately means that the price has gone up, Mr..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“No. The price will stay the same or there won't be any deal.”"]** — Mówca: **Player**
> "“No. The price will stay the same or there won't be any deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Patricio Alvarez: "“It is your choice.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Tell me what you want, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Tell me what you want, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Patricio Alvarez: "“The only thing anyone could possibly ever want out of We..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Makes sense. I knew this was coming. So what is on the new price tag?”"]** — Mówca: **Player**
> "“Makes sense. I knew this was coming. So what is on the new price tag?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Patricio Alvarez: "“Good intuition.”"*)

### Węzeł `[69]`
Mówca: **Patricio Alvarez**
> "“It is your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Patricio Alvarez: "“Just like it was your choice to leave Bludish people alo..."*)

### Węzeł `[70]`
Mówca: **Patricio Alvarez**
> "“Just like it was your choice to leave Bludish people alone to fend for themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Patricio Alvarez: "“Reminds me of Soll in many ways. What was it? Ah yes. Th..."*)

### Węzeł `[71]`
Mówca: **Patricio Alvarez**
> "“Reminds me of Soll in many ways. What was it? Ah yes. The Soll Dam Incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“I would recommend you not to badmouth Colonel Soll.”"*)
  - -> `[150]` (*Player: "“Take care of your own country's issues first, Mr. Alvarez.”"*)
  - -> `[152]` (*Player: "“I had to make a hard decision and this is the result of ..."*)

### Węzeł `[72]`
Mówca: **Patricio Alvarez**
> "“Good intuition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Patricio Alvarez: "“I want the only thing that anyone could possibly ever wa..."*)

### Węzeł `[73]`
Mówca: **Patricio Alvarez**
> "“The only thing anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Patricio Alvarez: "“I want their oil.”"*)

### Węzeł `[74]`
Mówca: **Patricio Alvarez**
> "“I want their oil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“I'm listening.”"*)
  - -> `[75]` (*Player: "“And how are you planning to get that?”"*)
  - -> `[158]` (*Player: "“And?”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“And how are you planning to get that?”"]** — Mówca: **Player**
> "“And how are you planning to get that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Patricio Alvarez: "“A lot of oil from Wehlen is passing through Sordland.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Patricio Alvarez: "“A lot of oil from Wehlen is passing through Sordland.”"*)

### Węzeł `[77]`
Mówca: **Patricio Alvarez**
> "“A lot of oil from Wehlen is passing through Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Patricio Alvarez: "“And Sordish Petroleum owns most of the oil trade in Sord..."*)

### Węzeł `[78]`
Mówca: **Patricio Alvarez**
> "“And Sordish Petroleum owns most of the oil trade in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Patricio Alvarez: "“Do you see where I am going with that?”"*)

### Węzeł `[79]`
Mówca: **Patricio Alvarez**
> "“Do you see where I am going with that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“Yes, I do.”"*)
  - -> `[81]` (*Player: "“Enlighten me.”"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Patricio Alvarez: "“I want you to sell me Sordish Petroleum or the deal is o..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Enlighten me.”"]** — Mówca: **Player**
> "“Enlighten me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Patricio Alvarez: "“I want you to sell me Sordish Petroleum or the deal is o..."*)

### Węzeł `[82]`
Mówca: **Patricio Alvarez**
> "“I want you to sell me Sordish Petroleum or the deal is off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "“You really are a shrewd man, Mr. Alvarez.”"*)
  - -> `[83]` (*Player: "“There is no way I can do that.”"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“There is no way I can do that.”"]** — Mówca: **Player**
> "“There is no way I can do that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Patricio Alvarez), `[86]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Patricio Alvarez: "“Then thank you for coming this far to visit Perla.”"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Very well. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` AND `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Patricio Alvarez), `[86]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Patricio Alvarez: "“My favorite phrase in this world. 'I accept.'.”"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“You really are a shrewd man, Mr. Alvarez.”"]** — Mówca: **Player**
> "“You really are a shrewd man, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Patricio Alvarez: "“I will take that as a compliment.”"*)

### Węzeł `[86]`
Mówca: **Patricio Alvarez**
> "“I will take that as a compliment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[83]` (*Player: "“There is no way I can do that.”"*)

### Węzeł `[87]`
Mówca: **Patricio Alvarez**
> "“Then thank you for coming this far to visit Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "He got up and started making his way to the door."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "He got up and started making his way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[192]` (*Player: "“Goodbye.”"*)
  - -> `[95]` (*Player_Italic: "Let him go."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Wait. Fine. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Wait. Fine. I accept.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false` AND `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He turned around with a smile and opened his arms."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He turned around with a smile and opened his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Patricio Alvarez: "“My favorite phrase in this world. 'I accept.'.”"*)

### Węzeł `[91]`
Mówca: **Patricio Alvarez**
> "“My favorite phrase in this world. 'I accept.'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Patricio Alvarez: "“I am overjoyed. This is a start to bring our countries c..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal = true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_SoldSordishPetroleum = true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_SoldSordishPetroleum = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_SoldSordishPetroleum"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSo..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "Let him go."]** — Mówca: **Player_Italic**
> "I let him go without saying anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)

### Węzeł `[96]`
Mówca: **Patricio Alvarez**
> "“I think it will contribute nicely to the relationship between Lespia and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Patricio Alvarez: "“I will sign the executive order.”"*)

### Węzeł `[97]`
Mówca: **Patricio Alvarez**
> "“I do, however, believe that we can do much more than just trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal = true"*)

### Węzeł `[98]`
Mówca: **Patricio Alvarez**
> "“We...by we, I mean ATO...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Patricio Alvarez: "“...Would like to see Sordland in our sphere.”"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Patricio Alvarez: "“We...by we, I mean ATO...”"*)

### Węzeł `[100]`
Mówca: **Patricio Alvarez**
> "“...Would like to see Sordland in our sphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Patricio Alvarez: "“What do you think, Mr. Rayne?”"*)

### Węzeł `[101]`
Mówca: **Patricio Alvarez**
> "“What do you think, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: "“That sounds excellent. How do we begin?”"*)
  - -> `[103]` (*Player: "“Why would you do that for Sordland? What's in it for you?”"*)
  - -> `[102]` (*Player: "“Thank you for the offer but that is not one of our aims ..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Thank you for the offer but that is not one of our aims for now.”"]** — Mówca: **Player**
> "“Thank you for the offer but that is not one of our aims for now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Patricio Alvarez: "“For now...maybe.”"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Why would you do that for Sordland? What's in it for you?”"]** — Mówca: **Player**
> "“Why would you do that for Sordland? What's in it for you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Patricio Alvarez: "“Prosperity in Eastern Merkopa!”"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“That sounds excellent. How do we begin?”"]** — Mówca: **Player**
> "“That sounds excellent. How do we begin?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Patricio Alvarez: "“Just the answer I wanted to hear!”"*)

### Węzeł `[105]`
Mówca: **Patricio Alvarez**
> "“Just the answer I wanted to hear!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Patricio Alvarez: "“We need to form a defensive pact against United Contana ..."*)

### Węzeł `[106]`
Mówca: **Patricio Alvarez**
> "“Prosperity in Eastern Merkopa!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Patricio Alvarez: "“Remedying old alliances!”"*)

### Węzeł `[107]`
Mówca: **Patricio Alvarez**
> "“Remedying old alliances!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Patricio Alvarez: "“And most importantly, forming a defensive pact against U..."*)

### Węzeł `[108]`
Mówca: **Patricio Alvarez**
> "“And most importantly, forming a defensive pact against United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "He clenched his fist and slammed it on the coffee table."*)

### Węzeł `[109]`
Mówca: **Patricio Alvarez**
> "“For now...maybe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Patricio Alvarez: "“But where will you stand when United Contana attacks Eas..."*)

### Węzeł `[110]`
Mówca: **Patricio Alvarez**
> "“But where will you stand when United Contana attacks Eastern Merkopa, as it surely will?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Patricio Alvarez: "“That is the real question.”"*)

### Węzeł `[111]`
Mówca: **Patricio Alvarez**
> "“That is the real question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "He clenched his fist and slammed it on the coffee table."*)

### Węzeł `[112]`
Mówca: **Patricio Alvarez**
> "“We need to form a defensive pact against United Contana in Eastern Merkopa before it's too late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Patricio Alvarez: "“They will attack eventually.”"*)

### Węzeł `[113]`
Mówca: **Patricio Alvarez**
> "“They will attack eventually.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "He clenched his fist and slammed it on the coffee table."*)

### Węzeł `[114]`
Mówca: **Patricio Alvarez**
> "“Those damn communists!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Patricio Alvarez: "“We need to stop them before it's too late.”"*)

### Węzeł `[115]`
Mówca: **Patricio Alvarez**
> "“We need to stop them before it's too late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Patricio Alvarez: "“Valgsland, those barbarians, are preparing to invade Hel..."*)

### Węzeł `[116]`
Mówca: **Patricio Alvarez**
> "“Valgsland, those barbarians, are preparing to invade Heljiland on false accusations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Patricio Alvarez: "“If Agnolia is first, Sordland will be next.”"*)

### Węzeł `[117]`
Mówca: **Patricio Alvarez**
> "“If Agnolia is first, Sordland will be next.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Patricio Alvarez: "“I will be frank. Eastern Merkopa's only way to survival ..."*)

### Węzeł `[118]`
Mówca: **Patricio Alvarez**
> "“I will be frank. Eastern Merkopa's only way to survival is through ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Patricio Alvarez: "“And we need the support of one of the largest players in..."*)

### Węzeł `[119]`
Mówca: **Patricio Alvarez**
> "“Are you with us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Patricio Alvarez: "“Will you defend our continent against the blight of comm..."*)

### Węzeł `[120]`
Mówca: **Patricio Alvarez**
> "“Will you defend our continent against the blight of communism?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: "“Down with the communists. I am willing to do whatever it..."*)
  - -> `[122]` (*Player: "“I think you are exaggerating the threat. I have my doubt..."*)
  - -> `[123]` (*Player: "“I can't decide without knowing what is in it for me.”"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Down with the communists. I am willing to do whatever it takes to protect Sordland.”"]** — Mówca: **Player**
> "“Down with the communists. I am willing to do whatever it takes to protect Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Patricio Alvarez: "“Well said! First, Hegel will fall. Then Malenyev!”"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I think you are exaggerating the threat. I have my doubts about this.”"]** — Mówca: **Player**
> "“I think you are exaggerating the threat. I have my doubts about this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Patricio Alvarez: "“I am giving you this option for your country's own good,..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I can't decide without knowing what is in it for me.”"]** — Mówca: **Player**
> "“I can't decide without knowing what is in it for me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Patricio Alvarez: "“I see that you possess the mind of a man who understands..."*)

### Węzeł `[124]`
Mówca: **Patricio Alvarez**
> "“I see that you possess the mind of a man who understands business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Patricio Alvarez: "“I offer you an alliance. It will come with a special aid..."*)

### Węzeł `[125]`
Mówca: **Patricio Alvarez**
> "“I offer you an alliance. It will come with a special aid package from me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Patricio Alvarez: "“Together we will shield the continent against Malenyev's..."*)

### Węzeł `[126]`
Mówca: **Patricio Alvarez**
> "“Together we will shield the continent against Malenyev's evil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Patricio Alvarez: "“Not to mention that you will have Arcasia's full backing..."*)

### Węzeł `[127]`
Mówca: **Patricio Alvarez**
> "“Not to mention that you will have Arcasia's full backing. The most powerful ally you can have in this era.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“I accept. Sordland will be allied to Lespia.” [+2 Govern..."*)
  - -> `[131]` (*Player: "“I have to refuse. I will not drag Sordland into an inter..."*)

### Węzeł `[128]`
Mówca: **Patricio Alvarez**
> "“I am giving you this option for your country's own good, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Patricio Alvarez: "“I offer you an alliance. It will come with a special aid..."*)

### Węzeł `[129]`
Mówca: **Patricio Alvarez**
> "“Well said! First, Hegel will fall. Then Malenyev!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Patricio Alvarez: "“I offer you an alliance. It will come with a special aid..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I accept. Sordland will be allied to Lespia.” [+2 Government Budget]"]** — Mówca: **Player**
> "“I accept. Sordland will be allied to Lespia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance = true; BaseGame.GovernmentBudge..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I have to refuse. I will not drag Sordland into an international conflict.”"]** — Mówca: **Player**
> "“I have to refuse. I will not drag Sordland into an international conflict.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Patricio Alvarez: "“You think you are evading the conflict by trying to stay..."*)

### Węzeł `[132]`
Mówca: **Patricio Alvarez**
> "“I am overjoyed. This is a start to bring our countries closer than ever before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Patricio Alvarez: "“We Eastern Merkopans should stand together.”"*)

### Węzeł `[133]`
Mówca: **Patricio Alvarez**
> "“We Eastern Merkopans should stand together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "We shook hands."*)

### Węzeł `[134]`
Mówca: **Patricio Alvarez**
> "“Speaking of standing together...I want to talk to you about something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Patricio Alvarez: "“We...by we, I mean ATO...”"*)

### Węzeł `[135]`
Mówca: **Narrator**
> "He clenched his fist and slammed it on the coffee table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Patricio Alvarez: "“Those damn communists!”"*)

### Węzeł `[136]`
Mówca: **Patricio Alvarez**
> "“And we need the support of one of the largest players in Eastern Merkopa. Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Patricio Alvarez: "“The beautiful country of Sordland is the key to all of t..."*)

### Węzeł `[137]`
Mówca: **Patricio Alvarez**
> "“The beautiful country of Sordland is the key to all of this. We need you, Mr. Rayne. We need Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Patricio Alvarez: "“Are you with us?”"*)

### Węzeł `[138]`
Mówca: **Patricio Alvarez**
> "“You think you are evading the conflict by trying to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Patricio Alvarez: "“Remember my words when the conflict is at your doorstep,..."*)

### Węzeł `[139]`
Mówca: **Patricio Alvarez**
> "“Remember my words when the conflict is at your doorstep, ringing your doorbell, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Patricio Alvarez: "“Don't forget that I gave you a choice.”"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance = true;
BaseGame.GovernmentBudget += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_Alliance"] = true;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance = true"*)

### Węzeł `[141]`
Mówca: **Patricio Alvarez**
> "“Perfect! Brilliant!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Patricio Alvarez: "“You don't know how valuable you are, Mr. Rayne!”"*)

### Węzeł `[142]`
Mówca: **Patricio Alvarez**
> "“You don't know how valuable you are, Mr. Rayne!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Patricio Alvarez: "“You just saved your country from its demise.”"*)

### Węzeł `[143]`
Mówca: **Patricio Alvarez**
> "“You just saved your country from its demise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Patricio Alvarez: "“I will personally talk to Mr. Walker to let him know of ..."*)

### Węzeł `[144]`
Mówca: **Patricio Alvarez**
> "“I will personally talk to Mr. Walker to let him know of this achievement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "We shook hands and he went in for a hug. I could smell th..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "We shook hands and he went in for a hug. I could smell the alcohol on his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Lespia", "All..."*)

### Węzeł `[146]`
Mówca: **Patricio Alvarez**
> "“Don't forget that I gave you a choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Patricio Alvarez: "“I can just say that I hope Sordland doesn't fall into a ..."*)

### Węzeł `[147]`
Mówca: **Patricio Alvarez**
> "“I can just say that I hope Sordland doesn't fall into a bad position because of your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "He looked at the clock."*)

### Węzeł `[148]`
Mówca: **Patricio Alvarez**
> "“I will sign the executive order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Patricio Alvarez: "“I do, however, believe that we can do much more than jus..."*)

### Węzeł `[149]`
Mówca: **Patricio Alvarez**
> "“Not to mention the humanitarian implications. We had to do our duty and send aid to those who were displaced as a result.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Patricio Alvarez: "“This has negatively affected Lespia. Our economy was ind..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Take care of your own country's issues first, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Take care of your own country's issues first, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Patricio Alvarez: "“I am doing exactly that right now.”"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I would recommend you not to badmouth Colonel Soll.”"]** — Mówca: **Player**
> "“I would recommend you not to badmouth Colonel Soll.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Patricio Alvarez: "“My apologies. I never took you for a Sollist.”"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I had to make a hard decision and this is the result of it.”"]** — Mówca: **Player**
> "“I had to make a hard decision and this is the result of it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Patricio Alvarez: "“Not every hard decision is right, Mr. Rayne.”"*)

### Węzeł `[153]`
Mówca: **Patricio Alvarez**
> "“Not every hard decision is right, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Patricio Alvarez: "“Before you make your final decision, let me tell you abo..."*)

### Węzeł `[154]`
Mówca: **Patricio Alvarez**
> "“I am doing exactly that right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Patricio Alvarez: "“Before you make your final decision, let me tell you abo..."*)

### Węzeł `[155]`
Mówca: **Patricio Alvarez**
> "“My apologies. I never took you for a Sollist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Patricio Alvarez: "“Before you make your final decision, let me tell you abo..."*)

### Węzeł `[156]`
Mówca: **Patricio Alvarez**
> "“Before you make your final decision, let me tell you about my offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Patricio Alvarez: "“I want the only thing that anyone could possibly ever wa..."*)

### Węzeł `[157]`
Mówca: **Patricio Alvarez**
> "“I want the only thing that anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Patricio Alvarez: "“I want their oil.”"*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“And?”"]** — Mówca: **Player**
> "“And?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Patricio Alvarez: "“A lot of oil from Wehlen is passing through Sordland.”"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "He looked at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Patricio Alvarez: "“I'm afraid I have to leave now to attend to other matters.”"*)

### Węzeł `[160]`
Mówca: **Patricio Alvarez**
> "“I'm afraid I have to leave now to attend to other matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Patricio Alvarez: "“Thank you for your visit.”"*)

### Węzeł `[161]`
Mówca: **Patricio Alvarez**
> "“Thank you for your visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "On his way to the door, he suddenly turned around."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "He smiled and left the room."*)

### Węzeł `[165]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Patricio Alvarez: "“You owe me a teapot.”"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Patricio Alvarez: "“Before I forget.”"*)

### Węzeł `[167]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "He smiled and left the room."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "He smiled and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "On his way to the door, he suddenly turned around."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He left the room and an assistant arrived to escort me."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Patricio Alvarez: "“Before I forget.”"*)

### Węzeł `[173]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Patricio Alvarez: "“You owe me a teapot.”"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "He left the room and an assistant arrived to escort me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[175]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He left the room and an assistant arrived to escort me."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Patricio Alvarez: "“Speaking of standing together...I want to talk to you ab..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Patricio Alvarez: "“Perfect! Brilliant!”"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Lespia", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Valgsland", "..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Valgsland", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "He looked at the clock."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Very well. I accept.” [-1 Government Budget]"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“Our energy protection laws don't allow such actions. I c..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"]** — Mówca: **Player**
> "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Patricio Alvarez: "“Then thank you for coming this far to visit Perla.”"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"]** — Mówca: **Player**
> "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[86]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Patricio Alvarez: "“Then thank you for coming this far to visit Perla.”"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "“Shrewd but not investigative enough. The Energy Protecti..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum ==..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: "“Very well. I accept.”"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“Wait. Fine. I accept.” [-1 Government Budget]"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He left the room and an assistant arrived to escort me."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum ==..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "“Very well. I accept.”"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Very well. I accept.” [-1 Government Budget]"*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true` AND `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[86]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Patricio Alvarez: "“My favorite phrase in this world. 'I accept.'.”"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true` AND `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He turned around with a smile and opened his arms."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
