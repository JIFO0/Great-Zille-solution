# Sordland/Turn08/LespiaVisit_AntiCapitalistRayne

- **ID konwersacji:** `156`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/156_LespiaVisit_AntiCapitalistRayne.md`
- **Liczba węzłów dialogowych:** 176
- **Liczba wyborów gracza:** 43

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
- `BaseGame.Lespia_SoldSordishPetroleum`
- `BaseGame.Lespia_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[154] Sordland/Turn08/FPnT_LespiaVisit** (../Turn_08/154_FPnT_LespiaVisit.md), Węzeł `[3]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"“Thank you. It's good to be here, Mr. Alvarez.”"** | `[5]` **Patricio Alvarez**: "“Have a seat.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Patricio Alvarez**: "“I hope you had a nice trip.”" |
| `[6]` | **"“I hear a lot about your successes, Mr. Alvarez.”"** | `[5]` **Patricio Alvarez**: "“Have a seat.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Patricio Alvarez**: "“Thank you, Mr. Rayne. That is v..." |
| `[17]` | **"“Have you been drinking?”"** | `[11]` **Narrator**: "I smelled the strong odor of alc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Patricio Alvarez**: "“A couple of glasses of the fine..." |
| `[18]` | **"Don't say anything."** | `[11]` **Narrator**: "I smelled the strong odor of alc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Patricio Alvarez**: "“Let's begin then.”" |
| `[21]` | **"“I would recommend you not to badmouth Colonel Soll.”"** | `[94]` **Patricio Alvarez**: "“Reminds me of Soll in many ways..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Patricio Alvarez**: "“My apologies. I never took you ..." |
| `[23]` | **"“No, thank you.”"** | `[22]` **Patricio Alvarez**: "“Would you like some?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Patricio Alvarez**: "“Very well.”" |
| `[25]` | **"“Since you asked, why not?”"** | `[22]` **Patricio Alvarez**: "“Would you like some?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "He gestured to the assistants." |
| `[27]` | **"“You are speaking to a President. Where is your professionalism?”"** | `[22]` **Patricio Alvarez**: "“Would you like some?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "He cleared his throat." |
| `[33]` | **"“And?”"** | `[98]` **Patricio Alvarez**: "“I want their oil.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Patricio Alvarez**: "“A lot of oil from Wehlen is pas..." |
| `[43]` | **"“Mr. Alvarez. Are you making fun of me right now?”"** | `[39]` **Patricio Alvarez**: "“What was it about again? Can yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Patricio Alvarez**: "“No. Absolutely not.”" |
| `[44]` | **"“We want to provide Sordish fishing output in return for Lespian capital.”"** | `[39]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true` | *Brak zmian stanu* | `[65]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[56]` | **"“We want to provide Sordish wheat in return for Lespian capital.”"** | `[39]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false` | *Brak zmian stanu* | `[65]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[57]` | **"“We want to provide Sordish coal in return for Lespian capital.”"** | `[39]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false` | *Brak zmian stanu* | `[65]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[58]` | **"“We want to provide Sordish tungsten in return for Lespian capital.”"** | `[39]` **Patricio Alvarez**: "“What was it about again? Can yo..." | `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`<br>`(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false` | *Brak zmian stanu* | `[65]` **Patricio Alvarez**: "“Ah. Yes. Right.”" |
| `[63]` | **"“I had to make a hard decision, and this is the result of it.”"** | `[94]` **Patricio Alvarez**: "“Reminds me of Soll in many ways..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Patricio Alvarez**: "“Not every hard decision is righ..." |
| `[66]` | **"“Take care of your own country's issues first, Mr. Alvarez.”"** | `[94]` **Patricio Alvarez**: "“Reminds me of Soll in many ways..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Patricio Alvarez**: "“I am doing exactly that right n..." |
| `[88]` | **"“No. The price will stay the same or there won't be any deal.”"** | `[85]` **Patricio Alvarez**: "“Which unfortunately means that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Patricio Alvarez**: "“It is your choice.”" |
| `[89]` | **"“Tell me what you want, Mr. Alvarez.”"** | `[85]` **Patricio Alvarez**: "“Which unfortunately means that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Patricio Alvarez**: "“The only thing that anyone coul..." |
| `[91]` | **"“Makes sense. I knew this was coming. So what is on the new price tag?”"** | `[85]` **Patricio Alvarez**: "“Which unfortunately means that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Patricio Alvarez**: "“Good intuition.”" |
| `[99]` | **"“And how are you planning to get that?”"** | `[98]` **Patricio Alvarez**: "“I want their oil.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Patricio Alvarez**: "“A lot of oil from Wehlen is pas..." |
| `[100]` | **"“I'm listening.”"** | `[98]` **Patricio Alvarez**: "“I want their oil.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Patricio Alvarez**: "“A lot of oil from Wehlen is pas..." |
| `[106]` | **"“Yes, I do.”"** | `[105]` **Patricio Alvarez**: "“Do you see where I am going wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." |
| `[107]` | **"“Enlighten me.”"** | `[105]` **Patricio Alvarez**: "“Do you see where I am going wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." |
| `[108]` | **"“You really are a shrewd man, Mr. Alvarez.”"** | `[109]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Patricio Alvarez**: "“I will take that as a compliment.”" |
| `[113]` | **"“Don't take my kindness for granted.”"** | `[112]` **Patricio Alvarez**: "“I wish I could say the same abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Patricio Alvarez**: "“And don't take my straightforwa..." |
| `[114]` | **"“What the hell does that mean?”"** | `[112]` **Patricio Alvarez**: "“I wish I could say the same abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Patricio Alvarez**: "“Ah, Mr. Rayne. You know what yo..." |
| `[115]` | **"“No need to argue, right? We have just met.”"** | `[112]` **Patricio Alvarez**: "“I wish I could say the same abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Patricio Alvarez**: "“Exactly. We don't need to waste..." |
| `[122]` | **"“When did ideology ever stop deals from happening?”"** | `[74]` **Patricio Alvarez**: "“I will sign the executive order.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Patricio Alvarez**: "“I could count at least a few do..." |
| `[123]` | **"“That is excellent news.”"** | `[74]` **Patricio Alvarez**: "“I will sign the executive order.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Patricio Alvarez**: "“I'm glad we are on the same page.”" |
| `[124]` | **"“Very good. We are done then.”"** | `[74]` **Patricio Alvarez**: "“I will sign the executive order.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Patricio Alvarez**: "“Yes. We are done.”" |
| `[128]` | **"“I'm glad this was quick. The less time I spend here, the better.”"** | `[19]` **Patricio Alvarez**: "“Thank you for your visit.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Patricio Alvarez**: "“If I were you I would reconside..." |
| `[129]` | **"“Perhaps we could advance this deal. What are your thoughts about an alliance?”"** | `[19]` **Patricio Alvarez**: "“Thank you for your visit.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Patricio Alvarez**: "“Mr. Rayne, Mr. Rayne, Mr. Rayne.”" |
| `[130]` | **"“Thank you for having me.”"** | `[19]` **Patricio Alvarez**: "“Thank you for your visit.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Patricio Alvarez**: "“Have a good day, Mr. Rayne.”" |
| `[137]` | **"“I thought the Prime Minister of Lespia would have at least some amount of social ..."** | `[112]` **Patricio Alvarez**: "“I wish I could say the same abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Patricio Alvarez**: "“I can assure you, I do, Mr. Ray..." |
| `[149]` | **"“There is no way I can do that.”"** | `[109]` **Patricio Alvarez**: "“I want you to sell me Sordish P..."<br>`[154]` **Patricio Alvarez**: "“I will take that as a compliment.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Patricio Alvarez**: "“Then thank you for coming this ..." |
| `[150]` | **"“Wait. Fine. I accept.” [-1 Government Budget]"** | `[152]` **Narrator**: "He got up and started making his..." | `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`<br>`Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` | *Brak zmian stanu* | `[36]` **Narrator**: "He turned around with a smile an..." |
| `[153]` | **"“Very well. I accept.” [-1 Government Budget]"** | `[109]` **Patricio Alvarez**: "“I want you to sell me Sordish P..."<br>`[154]` **Patricio Alvarez**: "“I will take that as a compliment.”" | `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`<br>`(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false` | *Brak zmian stanu* | `[62]` **Patricio Alvarez**: "“My favorite phrase in this worl..." |
| `[155]` | **"Let him go."** | `[152]` **Narrator**: "He got up and started making his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "On his way to the door, he sudde..."<br>`[146]` **Narrator**: "He left the room and an assistan..." |
| `[159]` | **"“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such..."** | `[154]` **Patricio Alvarez**: "“I will take that as a compliment.”" | `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false` | *Brak zmian stanu* | `[151]` **Patricio Alvarez**: "“Then thank you for coming this ..." |
| `[163]` | **"“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"** | `[109]` **Patricio Alvarez**: "“I want you to sell me Sordish P..." | `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false` | *Brak zmian stanu* | `[151]` **Patricio Alvarez**: "“Then thank you for coming this ..." |
| `[164]` | **"“Goodbye.”"** | `[152]` **Narrator**: "He got up and started making his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "He left the room and an assistan..." |
| `[171]` | **"“Very well. I accept.”"** | `[152]` **Narrator**: "He got up and started making his..." | `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`<br>`Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` | *Brak zmian stanu* | `[36]` **Narrator**: "He turned around with a smile an..." |
| `[172]` | **"“Very well. I accept.”"** | `[154]` **Patricio Alvarez**: "“I will take that as a compliment.”" | `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`<br>`Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` | *Brak zmian stanu* | `[62]` **Patricio Alvarez**: "“My favorite phrase in this worl..." |

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
  - -> `[3]` (*Patricio Alvarez: "“President Rayne. Welcome to Perla.”"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Patricio Alvarez: "“President Rayne. Welcome to Perla.”"*)

### Węzeł `[3]`
Mówca: **Patricio Alvarez**
> "“President Rayne. Welcome to Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Patricio Alvarez: "“Have a seat.”"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Thank you. It's good to be here, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Thank you. It's good to be here, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Patricio Alvarez: "“I hope you had a nice trip.”"*)

### Węzeł `[5]`
Mówca: **Patricio Alvarez**
> "“Have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“I hear a lot about your successes, Mr. Alvarez.”"*)
  - -> `[4]` (*Player: "“Thank you. It's good to be here, Mr. Alvarez.”"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“I hear a lot about your successes, Mr. Alvarez.”"]** — Mówca: **Player**
> "“I hear a lot about your successes, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Patricio Alvarez: "“Thank you, Mr. Rayne. That is very kind of you.”"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "He smiled and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[8]`
Mówca: **Patricio Alvarez**
> "“I hope you had a nice trip.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[9]`
Mówca: **Patricio Alvarez**
> "“Thank you, Mr. Rayne. That is very kind of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Patricio Alvarez: "“I wish I could say the same about you.”"*)

### Węzeł `[10]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "He smiled and left the room."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I smelled the strong odor of alcohol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“Have you been drinking?”"*)
  - -> `[18]` (*Player_Italic: "Don't say anything."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Patricio Alvarez: "“Before I forget.”"*)

### Węzeł `[13]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Patricio Alvarez: "“You owe me a teapot.”"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "On his way to the door, he suddenly turned around."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "He smiled and left the room."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Have you been drinking?”"]** — Mówca: **Player**
> "“Have you been drinking?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Patricio Alvarez: "“A couple of glasses of the finest Lespian wine is the be..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[19]`
Mówca: **Patricio Alvarez**
> "“Thank you for your visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“Thank you for having me.”"*)
  - -> `[129]` (*Player: "“Perhaps we could advance this deal. What are your though..."*)
  - -> `[128]` (*Player: "“I'm glad this was quick. The less time I spend here, the..."*)

### Węzeł `[20]`
Mówca: **Patricio Alvarez**
> "“A couple of glasses of the finest Lespian wine is the best way to start any meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Patricio Alvarez: "“Would you like some?”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I would recommend you not to badmouth Colonel Soll.”"]** — Mówca: **Player**
> "“I would recommend you not to badmouth Colonel Soll.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Patricio Alvarez: "“My apologies. I never took you for a Sollist.”"*)

### Węzeł `[22]`
Mówca: **Patricio Alvarez**
> "“Would you like some?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“No, thank you.”"*)
  - -> `[25]` (*Player: "“Since you asked, why not?”"*)
  - -> `[27]` (*Player: "“You are speaking to a President. Where is your professio..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“No, thank you.”"]** — Mówca: **Player**
> "“No, thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Patricio Alvarez: "“Very well.”"*)

### Węzeł `[24]`
Mówca: **Patricio Alvarez**
> "“I'm afraid I have to leave now to attend to other matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Patricio Alvarez: "“Thank you for your visit.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Since you asked, why not?”"]** — Mówca: **Player**
> "“Since you asked, why not?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He gestured to the assistants."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "He looked at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Patricio Alvarez: "“I'm afraid I have to leave now to attend to other matters.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“You are speaking to a President. Where is your professionalism?”"]** — Mówca: **Player**
> "“You are speaking to a President. Where is your professionalism?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He cleared his throat."*)

### Węzeł `[28]`
Mówca: **Patricio Alvarez**
> "“Let's begin then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Patricio Alvarez: "“So, you are here for the trade deal.”"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Patricio Alvarez: "“Don't you worry about my professionalism.”"*)

### Węzeł `[30]`
Mówca: **Patricio Alvarez**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "He gestured to the assistants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Patricio Alvarez: "“Two glasses.”"*)

### Węzeł `[32]`
Mówca: **Patricio Alvarez**
> "“Two glasses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "They came back very fast. They must've been used to this...."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“And?”"]** — Mówca: **Player**
> "“And?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Patricio Alvarez: "“A lot of oil from Wehlen is passing through Sordland.”"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "They came back very fast. They must've been used to this. We took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Patricio Alvarez: "“Ah. Nothing like it.”"*)

### Węzeł `[35]`
Mówca: **Patricio Alvarez**
> "“Ah. Nothing like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "He turned around with a smile and opened his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Patricio Alvarez: "“My favorite phrase in this world. 'I accept.'.”"*)

### Węzeł `[37]`
Mówca: **Patricio Alvarez**
> "“I am overjoyed. This is a start to bring our countries closer than ever before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Patricio Alvarez: "“We Eastern Merkopans should stand together.”"*)

### Węzeł `[38]`
Mówca: **Patricio Alvarez**
> "“So, you are here for the trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Patricio Alvarez: "“What was it about again? Can you remind me?”"*)

### Węzeł `[39]`
Mówca: **Patricio Alvarez**
> "“What was it about again? Can you remind me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“Mr. Alvarez. Are you making fun of me right now?”"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[40]`
Mówca: **Patricio Alvarez**
> "“I want the only thing that anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Patricio Alvarez: "“I want their oil.”"*)

### Węzeł `[41]`
Mówca: **Patricio Alvarez**
> "“Don't you worry about my professionalism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Patricio Alvarez: "“Let's begin then.”"*)

### Węzeł `[42]`
Mówca: **Patricio Alvarez**
> "“Before you make your final decision, let me tell you about my offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Patricio Alvarez: "“I want the only thing that anyone could possibly ever wa..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Mr. Alvarez. Are you making fun of me right now?”"]** — Mówca: **Player**
> "“Mr. Alvarez. Are you making fun of me right now?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Patricio Alvarez: "“No. Absolutely not.”"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“We want to provide Sordish fishing output in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish fishing output in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Kontekst wejściowy (poprzednik):** `[39]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[45]`
Mówca: **Patricio Alvarez**
> "“My apologies. I never took you for a Sollist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Patricio Alvarez: "“Before you make your final decision, let me tell you abo..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“We want to provide Sordish coal in return for Lespian ca..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“We want to provide Sordish tungsten in return for Lespia..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "“We want to provide Sordish wheat in return for Lespian c..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“We want to provide Sordish fishing output in return for ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[55]`
Mówca: **Patricio Alvarez**
> "“I am doing exactly that right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Patricio Alvarez: "“Before you make your final decision, let me tell you abo..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“We want to provide Sordish wheat in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish wheat in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We want to provide Sordish coal in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish coal in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“We want to provide Sordish tungsten in return for Lespian capital.”"]** — Mówca: **Player**
> "“We want to provide Sordish tungsten in return for Lespian capital.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false` AND `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Patricio Alvarez: "“Ah. Yes. Right.”"*)

### Węzeł `[59]`
Mówca: **Patricio Alvarez**
> "“Not every hard decision is right, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Patricio Alvarez: "“Before you make your final decision, let me tell you abo..."*)

### Węzeł `[60]`
Mówca: **Patricio Alvarez**
> "“No. Absolutely not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Patricio Alvarez: "“I have just been very busy lately.”"*)

### Węzeł `[61]`
Mówca: **Patricio Alvarez**
> "“I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Patricio Alvarez: "“You know...being the Prime Minister makes you pretty busy.”"*)

### Węzeł `[62]`
Mówca: **Patricio Alvarez**
> "“My favorite phrase in this world. 'I accept.'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Patricio Alvarez: "“I am overjoyed. This is a start to bring our countries c..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I had to make a hard decision, and this is the result of it.”"]** — Mówca: **Player**
> "“I had to make a hard decision, and this is the result of it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Patricio Alvarez: "“Not every hard decision is right, Mr. Rayne.”"*)

### Węzeł `[64]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Patricio Alvarez: "“So, I don't have any issues with this deal.”"*)

### Węzeł `[65]`
Mówca: **Patricio Alvarez**
> "“Ah. Yes. Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Patricio Alvarez: "“Sorry. I have just been very busy lately.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Take care of your own country's issues first, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Take care of your own country's issues first, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Patricio Alvarez: "“I am doing exactly that right now.”"*)

### Węzeł `[67]`
Mówca: **Patricio Alvarez**
> "“Sorry. I have just been very busy lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Patricio Alvarez: "“You know...being the Prime Minister makes you pretty busy.”"*)

### Węzeł `[68]`
Mówca: **Patricio Alvarez**
> "“Not to mention the humanitarian implications. We had to do our duty and send aid to those who were displaced as a result.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Patricio Alvarez: "“This has negatively affected Lespia. Our economy was ind..."*)

### Węzeł `[69]`
Mówca: **Patricio Alvarez**
> "“We Eastern Merkopans should stand together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "We shook hands."*)

### Węzeł `[70]`
Mówca: **Patricio Alvarez**
> "“So, I don't have any issues with this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_J..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_J..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Patricio Alvarez: "“Except there is one problem.”"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true || BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Patricio Alvarez: "“I think this deal will contribute nicely to the relation..."*)

### Węzeł `[74]`
Mówca: **Patricio Alvarez**
> "“I will sign the executive order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal = true"*)

### Węzeł `[75]`
Mówca: **Patricio Alvarez**
> "“Except there is one problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "He smirked."*)

### Węzeł `[76]`
Mówca: **Patricio Alvarez**
> "“You know...being the Prime Minister makes you pretty busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He pulled out a few documents from his briefcase and star..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He pulled out a few documents from his briefcase and started inspecting them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Patricio Alvarez: "“So, I don't have any issues with this deal.”"*)

### Węzeł `[78]`
Mówca: **Patricio Alvarez**
> "“Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Patricio Alvarez: "“Wehlen.”"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Patricio Alvarez: "“Your decision to defend the border while Smolak committe..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Patricio Alvarez: "“Your decision to join Smolak in his attack against the u..."*)

### Węzeł `[83]`
Mówca: **Patricio Alvarez**
> "“Your decision to defend the border while Smolak committed war crimes diverted all those refugees here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Patricio Alvarez: "“Now we have a full-blown refugee crisis in Lespia.”"*)

### Węzeł `[84]`
Mówca: **Patricio Alvarez**
> "“Now we have a full-blown refugee crisis in Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Patricio Alvarez: "“Which unfortunately means that the price has gone up, Mr..."*)

### Węzeł `[85]`
Mówca: **Patricio Alvarez**
> "“Which unfortunately means that the price has gone up, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“Tell me what you want, Mr. Alvarez.”"*)
  - -> `[88]` (*Player: "“No. The price will stay the same or there won't be any d..."*)
  - -> `[91]` (*Player: "“Makes sense. I knew this was coming. So what is on the n..."*)

### Węzeł `[86]`
Mówca: **Patricio Alvarez**
> "“Your decision to join Smolak in his attack against the unfortunate Bludish population compromised a lot of the Lespian assets in the area.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Patricio Alvarez: "“Not to mention the humanitarian implications. We had to ..."*)

### Węzeł `[87]`
Mówca: **Patricio Alvarez**
> "“This has negatively affected Lespia. Our economy was indirectly hit due to the destruction of manufacturing sites. In particular the oil refineries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Patricio Alvarez: "“Which unfortunately means that the price has gone up, Mr..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“No. The price will stay the same or there won't be any deal.”"]** — Mówca: **Player**
> "“No. The price will stay the same or there won't be any deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Patricio Alvarez: "“It is your choice.”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Tell me what you want, Mr. Alvarez.”"]** — Mówca: **Player**
> "“Tell me what you want, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Patricio Alvarez: "“The only thing that anyone could possibly ever want out ..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal = true"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Makes sense. I knew this was coming. So what is on the new price tag?”"]** — Mówca: **Player**
> "“Makes sense. I knew this was coming. So what is on the new price tag?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Patricio Alvarez: "“Good intuition.”"*)

### Węzeł `[92]`
Mówca: **Patricio Alvarez**
> "“It is your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Patricio Alvarez: "“Just like it was your choice to leave Bludish people alo..."*)

### Węzeł `[93]`
Mówca: **Patricio Alvarez**
> "“Just like it was your choice to leave Bludish people alone to fend for themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Patricio Alvarez: "“Reminds me of Soll in many ways. What was it? Ah yes. Th..."*)

### Węzeł `[94]`
Mówca: **Patricio Alvarez**
> "“Reminds me of Soll in many ways. What was it? Ah yes. The Soll Dam Incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "“I would recommend you not to badmouth Colonel Soll.”"*)
  - -> `[66]` (*Player: "“Take care of your own country's issues first, Mr. Alvarez.”"*)
  - -> `[63]` (*Player: "“I had to make a hard decision, and this is the result of..."*)

### Węzeł `[95]`
Mówca: **Patricio Alvarez**
> "“Good intuition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Patricio Alvarez: "“I want the only thing that anyone could possibly ever wa..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "“When did ideology ever stop deals from happening?”"*)
  - -> `[123]` (*Player: "“That is excellent news.”"*)
  - -> `[124]` (*Player: "“Very good. We are done then.”"*)

### Węzeł `[97]`
Mówca: **Patricio Alvarez**
> "“The only thing that anyone could possibly ever want out of Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Patricio Alvarez: "“I want their oil.”"*)

### Węzeł `[98]`
Mówca: **Patricio Alvarez**
> "“I want their oil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“I'm listening.”"*)
  - -> `[99]` (*Player: "“And how are you planning to get that?”"*)
  - -> `[33]` (*Player: "“And?”"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“And how are you planning to get that?”"]** — Mówca: **Player**
> "“And how are you planning to get that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Patricio Alvarez: "“A lot of oil from Wehlen is passing through Sordland.”"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Patricio Alvarez: "“A lot of oil from Wehlen is passing through Sordland.”"*)

### Węzeł `[101]`
Mówca: **Patricio Alvarez**
> "“A lot of oil from Wehlen is passing through Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Patricio Alvarez: "“And Sordish Petroleum owns most of the oil trade in Sord..."*)

### Węzeł `[102]`
Mówca: **Patricio Alvarez**
> "“I think this deal will contribute nicely to the relationship between Lespia and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Patricio Alvarez: "“Despite a lack of ideological alignments.”"*)

### Węzeł `[103]`
Mówca: **Patricio Alvarez**
> "“And Sordish Petroleum owns most of the oil trade in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Patricio Alvarez: "“Do you see where I am going with that?”"*)

### Węzeł `[104]`
Mówca: **Patricio Alvarez**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "He looked at the clock."*)

### Węzeł `[105]`
Mówca: **Patricio Alvarez**
> "“Do you see where I am going with that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“Yes, I do.”"*)
  - -> `[107]` (*Player: "“Enlighten me.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Patricio Alvarez: "“I want you to sell me Sordish Petroleum or the deal is o..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Enlighten me.”"]** — Mówca: **Player**
> "“Enlighten me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Patricio Alvarez: "“I want you to sell me Sordish Petroleum or the deal is o..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“You really are a shrewd man, Mr. Alvarez.”"]** — Mówca: **Player**
> "“You really are a shrewd man, Mr. Alvarez.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Patricio Alvarez: "“I will take that as a compliment.”"*)

### Węzeł `[109]`
Mówca: **Patricio Alvarez**
> "“I want you to sell me Sordish Petroleum or the deal is off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“You really are a shrewd man, Mr. Alvarez.”"*)
  - -> `[149]` (*Player: "“There is no way I can do that.”"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_SoldSordishPetroleum = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_SoldSordishPetroleum"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSo..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_SoldSordishPetroleum = true"*)

### Węzeł `[112]`
Mówca: **Patricio Alvarez**
> "“I wish I could say the same about you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“I thought the Prime Minister of Lespia would have at lea..."*)
  - -> `[114]` (*Player: "“What the hell does that mean?”"*)
  - -> `[113]` (*Player: "“Don't take my kindness for granted.”"*)
  - -> `[115]` (*Player: "“No need to argue, right? We have just met.”"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Don't take my kindness for granted.”"]** — Mówca: **Player**
> "“Don't take my kindness for granted.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Patricio Alvarez: "“And don't take my straightforwardness for granted, Mr. R..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“What the hell does that mean?”"]** — Mówca: **Player**
> "“What the hell does that mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Patricio Alvarez: "“Ah, Mr. Rayne. You know what you have done.”"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“No need to argue, right? We have just met.”"]** — Mówca: **Player**
> "“No need to argue, right? We have just met.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Patricio Alvarez: "“Exactly. We don't need to waste any time.”"*)

### Węzeł `[116]`
Mówca: **Patricio Alvarez**
> "“Ah, Mr. Rayne. You know what you have done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Patricio Alvarez: "“Your actions speak for themselves. It almost seems like ..."*)

### Węzeł `[117]`
Mówca: **Patricio Alvarez**
> "“Your actions speak for themselves. It almost seems like you are on a mission to ideologically oppose us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Patricio Alvarez: "“By us, I mean Lespia and ATO.”"*)

### Węzeł `[118]`
Mówca: **Patricio Alvarez**
> "“And don't take my straightforwardness for granted, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[119]`
Mówca: **Patricio Alvarez**
> "“Exactly. We don't need to waste any time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[120]`
Mówca: **Patricio Alvarez**
> "“By us, I mean Lespia and ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[121]`
Mówca: **Patricio Alvarez**
> "“Despite a lack of ideological alignments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Patricio Alvarez: "“I will sign the executive order.”"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“When did ideology ever stop deals from happening?”"]** — Mówca: **Player**
> "“When did ideology ever stop deals from happening?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Patricio Alvarez: "“I could count at least a few dozen instances, but let's ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“That is excellent news.”"]** — Mówca: **Player**
> "“That is excellent news.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Patricio Alvarez: "“I'm glad we are on the same page.”"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Very good. We are done then.”"]** — Mówca: **Player**
> "“Very good. We are done then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Patricio Alvarez: "“Yes. We are done.”"*)

### Węzeł `[125]`
Mówca: **Patricio Alvarez**
> "“Yes. We are done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "He looked at the clock."*)

### Węzeł `[126]`
Mówca: **Patricio Alvarez**
> "“I could count at least a few dozen instances, but let's not go into that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "He looked at the clock."*)

### Węzeł `[127]`
Mówca: **Patricio Alvarez**
> "“I'm glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "He looked at the clock."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“I'm glad this was quick. The less time I spend here, the better.”"]** — Mówca: **Player**
> "“I'm glad this was quick. The less time I spend here, the better.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Patricio Alvarez: "“If I were you I would reconsider my decision on who my f..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“Perhaps we could advance this deal. What are your thoughts about an alliance?”"]** — Mówca: **Player**
> "“Perhaps we could advance this deal. What are your thoughts about an alliance?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Patricio Alvarez: "“Mr. Rayne, Mr. Rayne, Mr. Rayne.”"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Thank you for having me.”"]** — Mówca: **Player**
> "“Thank you for having me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Patricio Alvarez: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[131]`
Mówca: **Patricio Alvarez**
> "“Mr. Rayne, Mr. Rayne, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Patricio Alvarez: "“I don't think so.”"*)

### Węzeł `[132]`
Mówca: **Patricio Alvarez**
> "“I don't think so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Patricio Alvarez: "“You should be glad that I am a lenient man. That's the o..."*)

### Węzeł `[133]`
Mówca: **Patricio Alvarez**
> "“You should be glad that I am a lenient man. That's the only reason we were able to achieve a deal today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Patricio Alvarez: "“I wouldn't push it if I were you.”"*)

### Węzeł `[134]`
Mówca: **Patricio Alvarez**
> "“I wouldn't push it if I were you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Patricio Alvarez: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[135]`
Mówca: **Patricio Alvarez**
> "“Have a good day, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)

### Węzeł `[136]`
Mówca: **Patricio Alvarez**
> "“If I were you I would reconsider my decision on who my friends and foes are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Patricio Alvarez: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“I thought the Prime Minister of Lespia would have at least some amount of social aptitude.”"]** — Mówca: **Player**
> "“I thought the Prime Minister of Lespia would have at least some amount of social aptitude.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Patricio Alvarez: "“I can assure you, I do, Mr. Rayne.”"*)

### Węzeł `[138]`
Mówca: **Patricio Alvarez**
> "“I can assure you, I do, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Patricio Alvarez: "“And it is reserved only for my friends.”"*)

### Węzeł `[139]`
Mówca: **Patricio Alvarez**
> "“And it is reserved only for my friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I smelled the strong odor of alcohol."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "On his way to the door, he suddenly turned around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Patricio Alvarez: "“Before I forget.”"*)

### Węzeł `[141]`
Mówca: **Patricio Alvarez**
> "“Before I forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Patricio Alvarez: "“You owe me a teapot.”"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "On his way to the door, he suddenly turned around."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_BrokenTeapot"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He left the room and an assistant arrived to escort me."*)

### Węzeł `[145]`
Mówca: **Patricio Alvarez**
> "“You owe me a teapot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He left the room and an assistant arrived to escort me."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "He left the room and an assistant arrived to escort me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal = true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_TradeDealAndSold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Patricio Alvarez: "“Excellent.”"*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“There is no way I can do that.”"]** — Mówca: **Player**
> "“There is no way I can do that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Patricio Alvarez), `[154]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Patricio Alvarez: "“Then thank you for coming this far to visit Perla.”"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Wait. Fine. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Wait. Fine. I accept.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false` AND `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "He turned around with a smile and opened his arms."*)

### Węzeł `[151]`
Mówca: **Patricio Alvarez**
> "“Then thank you for coming this far to visit Perla.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He got up and started making his way to the door."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He got up and started making his way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[164]` (*Player: "“Goodbye.”"*)
  - -> `[155]` (*Player_Italic: "Let him go."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Very well. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true` AND `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[109]` (Patricio Alvarez), `[154]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Patricio Alvarez: "“My favorite phrase in this world. 'I accept.'.”"*)

### Węzeł `[154]`
Mówca: **Patricio Alvarez**
> "“I will take that as a compliment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[149]` (*Player: "“There is no way I can do that.”"*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "Let him go."]** — Mówca: **Player_Italic**
> "I let him go without saying anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_BrokenTeapot == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: "“Very well. I accept.” [-1 Government Budget]"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "“Our energy protection laws don't allow such actions. I c..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"]** — Mówca: **Player**
> "“Shrewd but not investigative enough. The Energy Protection Act doesn't allow such a transaction.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[154]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Patricio Alvarez: "“Then thank you for coming this far to visit Perla.”"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: "“Shrewd but not investigative enough. The Energy Protecti..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"]** — Mówca: **Player**
> "“Our energy protection laws don't allow such actions. I can't comply Mr. Alvarez.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[109]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Patricio Alvarez: "“Then thank you for coming this far to visit Perla.”"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He left the room and an assistant arrived to escort me."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum ==..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: "“Very well. I accept.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: "“Very well. I accept.” [-1 Government Budget]"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum ==..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: "“Very well. I accept.”"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == false && BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“Wait. Fine. I accept.” [-1 Government Budget]"*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true` AND `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "He turned around with a smile and opened his arms."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] == false  and  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true` AND `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[154]` (Patricio Alvarez)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Patricio Alvarez: "“My favorite phrase in this world. 'I accept.'.”"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum == f..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
