# Sordland/Turn05/Personal_ReturnOfInvestment

- **ID konwersacji:** `74`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/074_Personal_ReturnOfInvestment.md`
- **Liczba węzłów dialogowych:** 169
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BlackTuesdayHappened`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend1`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend2`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend3`
- `BaseGame.Investment_Arcasia_Successful`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Relations_Gus_CutLosses`
- `BaseGame.Situation_Economy_MarketsCrash`
- `BaseGame.SuperpowerTradeWarHappened`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Investment_Arcasia_Successful`
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Gus_CutLosses`
- `BaseGameSupport.News_Turn05_E_ArmadineNotSuccessful`
- `BaseGameSupport.News_Turn05_E_ArmadineSuccessful`
- `GameCondition.Turn05_Personal_ReturnOfInvestment`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“I was doing well until you gave me a call.”"** | `[8]` **Gus Manger**: "“Mr. President. How are you doin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Narrator**: "He didn't laugh."<br>`[167]` **Narrator**: "He laughed out loud." |
| `[10]` | **""I'm fine. You?”"** | `[8]` **Gus Manger**: "“Mr. President. How are you doin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Gus Manger**: "“Business as usual on my end. Th..." |
| `[11]` | **"“What is it, Gus?”"** | `[8]` **Gus Manger**: "“Mr. President. How are you doin..."<br>`[127]` **Gus Manger**: "“Mr. President. How are you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Gus Manger**: "“I am calling you because I just..." |
| `[26]` | **"“I'm not much of a risk taker.”"** | `[9]` **Gus Manger**: "“Sorry, I know it's underwhelmin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Gus Manger**: "“Oh, come on. You are the presid..." |
| `[30]` | **"“Darn it. Yes, I do.”"** | `[9]` **Gus Manger**: "“Sorry, I know it's underwhelmin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Gus Manger**: "“I assure you, this will pale in..." |
| `[32]` | **"“It was a good start for sure.”"** | `[9]` **Gus Manger**: "“Sorry, I know it's underwhelmin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Gus Manger**: "“It definitely was.”" |
| `[33]` | **"“I knew I shouldn't have listened to your advice.”"** | `[31]` **Gus Manger**: "“I'm sorry, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Gus Manger**: "“At the time, I thought Armadine..." |
| `[34]` | **"“Why are you apologizing? It's not your fault.”"** | `[31]` **Gus Manger**: "“I'm sorry, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Gus Manger**: "“Thank you for understanding the..." |
| `[35]` | **"“You know what they say. Don't invest what you can't afford to lose.”"** | `[31]` **Gus Manger**: "“I'm sorry, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Gus Manger**: "“Wasn't Konrath Koronti the one ..." |
| `[40]` | **"“Great news! So, how much did we gain?”"** | `[37]` **Gus Manger**: "“Isn't that great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Gus Manger**: "“You will love it.”" |
| `[41]` | **"“Yes. It's great. Go on.”"** | `[37]` **Gus Manger**: "“Isn't that great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Gus Manger**: "“You will love it.”" |
| `[43]` | **"“This better be worth it.”"** | `[37]` **Gus Manger**: "“Isn't that great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Gus Manger**: "“It is. Trust me.”" |
| `[51]` | **"“Remind me never to do business with you ever again.”"** | `[49]` **Gus Manger**: "“That's all I wanted to talk to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Gus Manger**: "“Again, I am so sorry."" |
| `[52]` | **"“Keep me up to date on other opportunities.”"** | `[49]` **Gus Manger**: "“That's all I wanted to talk to ..."<br>`[123]` **Gus Manger**: "“The money will be transferred t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Gus Manger**: "“I'll let you know immediately w..." |
| `[53]` | **"“I knew it was the right call to trust you on this.”"** | `[72]` **Gus Manger**: "“It could have been much worse, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Gus Manger**: "“Appreciate it.”" |
| `[59]` | **"“Very well. Talk to you later then.”"** | `[49]` **Gus Manger**: "“That's all I wanted to talk to ..."<br>`[123]` **Gus Manger**: "“The money will be transferred t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Gus Manger**: "“Goodbye for now.”"<br>`[159]` **Gus Manger**: "“Oh, I almost forgot.”" |
| `[63]` | **"“It's all thanks to you.”"** | `[36]` **Gus Manger**: "“It was risky, yes. But look at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Gus Manger**: "“Well. I will take that. Thank y..." |
| `[65]` | **"“Some things are just worth taking the risk for.”"** | `[36]` **Gus Manger**: "“It was risky, yes. But look at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Gus Manger**: "“Exactly. Electronics manufactur..." |
| `[70]` | **"“I have a good eye for investments.”"** | `[36]` **Gus Manger**: "“It was risky, yes. But look at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Gus Manger**: "“That, you do. Did you read Konr..." |
| `[73]` | **"“Great news! So, how much did we gain?”"** | `[72]` **Gus Manger**: "“It could have been much worse, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Gus Manger**: "“You're going to want to sit down."" |
| `[74]` | **"“Unbelievable. How can you say that when the Sordish economy is crippled?”"** | `[72]` **Gus Manger**: "“It could have been much worse, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Gus Manger**: "“You are right, Mr. President. I..." |
| `[77]` | **"“This is the beginning of a good partnership. Keep it up.”"** | `[123]` **Gus Manger**: "“The money will be transferred t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Gus Manger**: "“I think so too.”" |
| `[85]` | **"“So you're telling me I spent a fortune on this investment and got nothing back?!”"** | `[31]` **Gus Manger**: "“I'm sorry, Mr. President.”" | `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true  or  Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true` | *Brak zmian stanu* | `[91]` **Gus Manger**: "“I know it's not great. But no o..." |
| `[90]` | **"“At least we didn't invest much and have no direct losses.”"** | `[31]` **Gus Manger**: "“I'm sorry, Mr. President.”" | `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true` | *Brak zmian stanu* | `[89]` **Gus Manger**: "“Fair point. I would have felt w..." |
| `[100]` | **"“Let's hope so. I want to trust you Gus.”"** | `[47]` **Gus Manger**: "“I am confident once the effects..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Gus Manger**: "“That's all I wanted to talk to ..." |
| `[101]` | **"“I doubt it. Sell all of our stocks and cut our losses." [+1 Personal Wealth]"** | `[47]` **Gus Manger**: "“I am confident once the effects..." | `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true` | *Brak zmian stanu* | `[105]` **Gus Manger**: "“Very well, sir. I will arrange ..." |
| `[107]` | **"“Anything else?”"** | `[47]` **Gus Manger**: "“I am confident once the effects..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Gus Manger**: "“That's all I wanted to talk to ..." |
| `[128]` | **"“Not so great. You must have seen what is going on.”"** | `[127]` **Gus Manger**: "“Mr. President. How are you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Gus Manger**: "“You bet I have."" |
| `[132]` | **"“Eh. You?”"** | `[127]` **Gus Manger**: "“Mr. President. How are you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“It's not great on our end, eith..."<br>`[133]` **Gus Manger**: "“The trade war has us on edge. W..." |

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
  - -> `[4]` (*Narrator: "I was sipping my first cup of coffee for the day when the..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“I was doing well until you gave me a call.”"]** — Mówca: **Player**
> "“I was doing well until you gave me a call.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true || BaseGame.R..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I was sipping my first cup of coffee for the day when the phone lit up and rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I swore under my breath. I thought my schedule was clear ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true ||BaseGame.Superpow..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I swore under my breath. I thought my schedule was clear for at least half an hour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I picked up the phone."*)

### Węzeł `[7]`
Mówca: **Gus Manger**
> "“It definitely was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“I assure you, this will pale in comparison to what we wi..."*)

### Węzeł `[8]`
Mówca: **Gus Manger**
> "“Mr. President. How are you doing on this fine day, if I may ask?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“What is it, Gus?”"*)
  - -> `[10]` (*Player: ""I'm fine. You?”"*)
  - -> `[3]` (*Player: "“I was doing well until you gave me a call.”"*)

### Węzeł `[9]`
Mówca: **Gus Manger**
> "“Sorry, I know it's underwhelming. I bet you wish you'd gone for a bigger buy-in earlier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“It was a good start for sure.”"*)
  - -> `[30]` (*Player: "“Darn it. Yes, I do.”"*)
  - -> `[26]` (*Player: "“I'm not much of a risk taker.”"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""I'm fine. You?”"]** — Mówca: **Player**
> ""I'm fine. You?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Gus Manger: "“Business as usual on my end. Thanks for asking.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“What is it, Gus?”"]** — Mówca: **Player**
> "“What is it, Gus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Gus Manger), `[127]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“I am calling you because I just heard from the CEO of Ar..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Personal_ReturnOfInvestment = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Personal_ReturnOfInvestment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 7`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 5`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[15]`
Mówca: **Gus Manger**
> "“I am calling you because I just heard from the CEO of Armadine Industries, Arron Bridges, regarding the recent initial public offering on the Ventrie City Stock Exchange.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)

### Węzeł `[16]`
Mówca: **Gus Manger**
> "“Business as usual on my end. Thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“I am calling you because I just heard from the CEO of Ar..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[18]`
Mówca: **Gus Manger**
> "“Oh, come on. You are the president! Nobody got to that seat without taking massive risks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“I assure you, this will pale in comparison to what we wi..."*)

### Węzeł `[19]`
Mówca: **Gus Manger**
> "“Well. I will take that. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“I assure you, this will pale in comparison to what we wi..."*)

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“As you might've guessed, it's about our massive venture investment of 3000 shares worth nearly three million ren.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true || BaseGame.R..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true || BaseGame.R..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerTradeWarHappened == true || BaseGame..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gus Manger: "“Thanks to the ongoing trade war, I was told that the Arm..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“Thanks to the ongoing trade war, I was told that the Armadine stock prices plunged after the IPO. The markets are very volatile right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: "“Don't worry. Our stocks are still secure and they advise..."*)

### Węzeł `[25]`
Mówca: **Gus Manger**
> "“You will love it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Gus Manger: "“In total we have made...”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I'm not much of a risk taker.”"]** — Mówca: **Player**
> "“I'm not much of a risk taker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gus Manger: "“Oh, come on. You are the president! Nobody got to that s..."*)

### Węzeł `[27]`
Mówca: **Gus Manger**
> "“Don't worry. Our stocks are still secure and they advised us not to sell because a recovery is expected in the near future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gus Manger: "“However, this means that we have not made any profits, a..."*)

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“However, this means that we have not made any profits, and on the contrary have lost fifty percent of the value compared to our initial purchase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Gus Manger: "“I'm sorry, Mr. President.”"*)

### Węzeł `[29]`
Mówca: **Gus Manger**
> "“It is. Trust me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gus Manger: "“You will love it.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Darn it. Yes, I do.”"]** — Mówca: **Player**
> "“Darn it. Yes, I do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“I assure you, this will pale in comparison to what we wi..."*)

### Węzeł `[31]`
Mówca: **Gus Manger**
> "“I'm sorry, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == tru..."*)
  - -> `[34]` (*Player: "“Why are you apologizing? It's not your fault.”"*)
  - -> `[33]` (*Player: "“I knew I shouldn't have listened to your advice.”"*)
  - -> `[35]` (*Player: "“You know what they say. Don't invest what you can't affo..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“It was a good start for sure.”"]** — Mówca: **Player**
> "“It was a good start for sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Gus Manger: "“It definitely was.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“I knew I shouldn't have listened to your advice.”"]** — Mówca: **Player**
> "“I knew I shouldn't have listened to your advice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Gus Manger: "“At the time, I thought Armadine was a sure bet. This tra..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Why are you apologizing? It's not your fault.”"]** — Mówca: **Player**
> "“Why are you apologizing? It's not your fault.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger: "“Thank you for understanding the unfortunate situation.”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“You know what they say. Don't invest what you can't afford to lose.”"]** — Mówca: **Player**
> "“You know what they say. Don't invest what you can't afford to lose.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gus Manger: "“Wasn't Konrath Koronti the one that said that? He was a ..."*)

### Węzeł `[36]`
Mówca: **Gus Manger**
> "“It was risky, yes. But look at where we are now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“I have a good eye for investments.”"*)
  - -> `[65]` (*Player: "“Some things are just worth taking the risk for.”"*)
  - -> `[63]` (*Player: "“It's all thanks to you.”"*)

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“Isn't that great?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“This better be worth it.”"*)
  - -> `[40]` (*Player: "“Great news! So, how much did we gain?”"*)
  - -> `[41]` (*Player: "“Yes. It's great. Go on.”"*)

### Węzeł `[38]`
Mówca: **Gus Manger**
> "“At the time, I thought Armadine was a sure bet. This trade war came out of nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“Regardless, we still have a hold on our stocks.”"*)

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“Thank you for understanding the unfortunate situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“Regardless, we still have a hold on our stocks.”"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Great news! So, how much did we gain?”"]** — Mówca: **Player**
> "“Great news! So, how much did we gain?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gus Manger: "“You will love it.”"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Yes. It's great. Go on.”"]** — Mówca: **Player**
> "“Yes. It's great. Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gus Manger: "“You will love it.”"*)

### Węzeł `[42]`
Mówca: **Gus Manger**
> "“Wasn't Konrath Koronti the one that said that? He was a visionary for the free world for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“Regardless, we still have a hold on our stocks.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“This better be worth it.”"]** — Mówca: **Player**
> "“This better be worth it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Gus Manger: "“It is. Trust me.”"*)

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“Regardless, we still have a hold on our stocks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gus Manger: "“I am confident once the effects of this nasty trade war ..."*)

### Węzeł `[45]`
Mówca: **Gus Manger**
> "“The shares have doubled in price at the IPO in the VCSE and we will soon receive the profits made from the investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gus Manger: "“Isn't that great?”"*)

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“Exactly. Electronics manufacturing has a great future and Armadine seems to have a head start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“I assure you, this will pale in comparison to what we wi..."*)

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“I am confident once the effects of this nasty trade war subside, we'll recover the value of our shares and then some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“Anything else?”"*)
  - -> `[100]` (*Player: "“Let's hope so. I want to trust you Gus.”"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)

### Węzeł `[48]`
Mówca: **Gus Manger**
> "“I am very pleased to say that we have made gains!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Gus Manger: "“The shares have doubled in price at the IPO in the VCSE ..."*)

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“That's all I wanted to talk to you about, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Remind me never to do business with you ever again.”"*)
  - -> `[59]` (*Player: "“Very well. Talk to you later then.”"*)
  - -> `[52]` (*Player: "“Keep me up to date on other opportunities.”"*)

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“Goodbye for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The line dropped."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Remind me never to do business with you ever again.”"]** — Mówca: **Player**
> "“Remind me never to do business with you ever again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gus Manger: "“Again, I am so sorry.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Keep me up to date on other opportunities.”"]** — Mówca: **Player**
> "“Keep me up to date on other opportunities.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Gus Manger), `[123]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Gus Manger: "“I'll let you know immediately when new opportunities ari..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I knew it was the right call to trust you on this.”"]** — Mówca: **Player**
> "“I knew it was the right call to trust you on this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: "“Appreciate it.”"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == t..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_MarketsCrash == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_MarketsCrash == true"*)

### Węzeł `[57]`
Mówca: **Gus Manger**
> "“Again, I am so sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)

### Węzeł `[58]`
Mówca: **Gus Manger**
> "“I'll let you know immediately when new opportunities arise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Very well. Talk to you later then.”"]** — Mówca: **Player**
> "“Very well. Talk to you later then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Gus Manger), `[123]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == t..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_MarketsCrash == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It's all thanks to you.”"]** — Mówca: **Player**
> "“It's all thanks to you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Gus Manger: "“Well. I will take that. Thank you.”"*)

### Węzeł `[64]`
Mówca: **Gus Manger**
> "“I assure you, this will pale in comparison to what we will do together in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful = true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Some things are just worth taking the risk for.”"]** — Mówca: **Player**
> "“Some things are just worth taking the risk for.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Gus Manger: "“Exactly. Electronics manufacturing has a great future an..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BlackTuesdayHappened == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gus Manger: "“Instead of suffering losses due to market volatility lik..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BlackTuesdayHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gus Manger: "“I am very pleased to say that we have made gains!”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“I have a good eye for investments.”"]** — Mówca: **Player**
> "“I have a good eye for investments.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gus Manger: "“That, you do. Did you read Konrath Koronti's book on ent..."*)

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“Instead of suffering losses due to market volatility like most public firms in Merkopa, we actually came out unscathed. Arcasia wasn't influenced by the Black Tuesday crash!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gus Manger: "“The shares have doubled in price at the IPO in the VCSE ..."*)

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“It could have been much worse, but we got out of it with the best outcome. Isn't that great?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“Unbelievable. How can you say that when the Sordish econ..."*)
  - -> `[73]` (*Player: "“Great news! So, how much did we gain?”"*)
  - -> `[53]` (*Player: "“I knew it was the right call to trust you on this.”"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Great news! So, how much did we gain?”"]** — Mówca: **Player**
> "“Great news! So, how much did we gain?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“You're going to want to sit down.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Unbelievable. How can you say that when the Sordish economy is crippled?”"]** — Mówca: **Player**
> "“Unbelievable. How can you say that when the Sordish economy is crippled?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Gus Manger: "“You are right, Mr. President. I'm sorry.”"*)

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“I think so too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)

### Węzeł `[76]`
Mówca: **Gus Manger**
> "“You are right, Mr. President. I'm sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Gus Manger: "“In total we have made...”"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“This is the beginning of a good partnership. Keep it up.”"]** — Mówca: **Player**
> "“This is the beginning of a good partnership. Keep it up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gus Manger: "“I think so too.”"*)

### Węzeł `[78]`
Mówca: **Gus Manger**
> "“You're going to want to sit down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Gus Manger: "“In total we have made...”"*)

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“That, you do. Did you read Konrath Koronti's book on entrepreneurship, by any chance? Everything I know about the market, I learned from him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“I assure you, this will pale in comparison to what we wi..."*)

### Węzeł `[80]`
Mówca: **Gus Manger**
> "“In total we have made...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)

### Węzeł `[81]`
Mówca: **Gus Manger**
> "“It's not great on our end, either. Some of our investments are suffering due to Black Tuesday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“I am calling you because I just heard from the CEO of Ar..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == tru..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == t..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true  or  Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "“So you're telling me I spent a fortune on this investmen..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true  or  Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
**[WYBÓR GRACZA: "“So you're telling me I spent a fortune on this investment and got nothing back?!”"]** — Mówca: **Player**
> "“So you're telling me I spent a fortune on this investment and got nothing back?!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true  or  Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Kontekst wejściowy (poprzednik):** `[31]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gus Manger: "“I know it's not great. But no one saw the trade war comi..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == t..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“At least we didn't invest much and have no direct losses.”"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Gus Manger**
> "“Fair point. I would have felt worse if your investment was larger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“Regardless, we still have a hold on our stocks.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“At least we didn't invest much and have no direct losses.”"]** — Mówca: **Player**
> "“At least we didn't invest much and have no direct losses.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true`
- **Kontekst wejściowy (poprzednik):** `[31]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Gus Manger: "“Fair point. I would have felt worse if your investment w..."*)

### Węzeł `[91]`
Mówca: **Gus Manger**
> "“I know it's not great. But no one saw the trade war coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“Regardless, we still have a hold on our stocks.”"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == t..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Gus Manger: "“As you might've guessed, it's about our massive venture ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == t..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Gus Manger: "“As you might've guessed, it's about our significant vent..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Gus Manger: "“As you might've guessed, it's about our little venture i..."*)

### Węzeł `[98]`
Mówca: **Gus Manger**
> "“As you might've guessed, it's about our significant venture investment of 2000 shares worth nearly two million ren.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true || BaseGame.R..."*)

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“As you might've guessed, it's about our little venture investment of 1000 shares worth nearly a million ren.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true || BaseGame.R..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Let's hope so. I want to trust you Gus.”"]** — Mówca: **Player**
> "“Let's hope so. I want to trust you Gus.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“That's all I wanted to talk to you about, Mr. President.”"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“I doubt it. Sell all of our stocks and cut our losses." [+1 Personal Wealth]"]** — Mówca: **Player**
> "“I doubt it. Sell all of our stocks and cut our losses.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Kontekst wejściowy (poprzednik):** `[47]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gus Manger: "“Very well, sir. I will arrange it and make the transfer ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == t..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“I doubt it. Sell all of our stocks and cut our losses." ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Gus Manger**
> "“Very well, sir. I will arrange it and make the transfer to your personal bank account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses = true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Gus_CutLosses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Gus_CutLosses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“That's all I wanted to talk to you about, Mr. President.”"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Anything else?”"]** — Mówca: **Player**
> "“Anything else?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“That's all I wanted to talk to you about, Mr. President.”"*)

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“The shares have doubled in price at the IPO in the VCSE and we will soon receive the profits made from the investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Gus Manger: "“It could have been much worse, but we got out of it with..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Gus_CutLosses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Gus_CutLosses == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Gus_CutLosses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Gus_CutLosses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Gus_CutLosses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Gus_CutLosses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[113]`
Mówca: **Gus Manger**
> "“Appreciate it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Gus Manger: "“In total we have made...”"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == t..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Gus Manger: "“...nearly four million Sordish Ren!”"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == t..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Gus Manger: "“...nearly three million Sordish Ren!”"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“...nearly two million Sordish Ren!”"*)

### Węzeł `[120]`
Mówca: **Gus Manger**
> "“...nearly two million Sordish Ren!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Gus Manger: "“Sorry, I know it's underwhelming. I bet you wish you'd g..."*)

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“...nearly four million Sordish Ren!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Gus Manger: "“It was risky, yes. But look at where we are now!”"*)

### Węzeł `[122]`
Mówca: **Gus Manger**
> "“...nearly three million Sordish Ren!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Gus Manger: "“It was risky, yes. But look at where we are now!”"*)

### Węzeł `[123]`
Mówca: **Gus Manger**
> "“The money will be transferred to your personal bank account shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Very well. Talk to you later then.”"*)
  - -> `[52]` (*Player: "“Keep me up to date on other opportunities.”"*)
  - -> `[77]` (*Player: "“This is the beginning of a good partnership. Keep it up.”"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true ||BaseGame.SuperpowerTradeWarHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true ||BaseGame.Superpow..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BlackTuesdayHappened == true ||BaseGame.Superp..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true ||BaseGame.SuperpowerTradeWarHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true  or Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Gus Manger: "“Mr. President. How are you?”"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BlackTuesdayHappened == true ||BaseGame.SuperpowerTradeWarHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true  or Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Gus Manger: "“Mr. President. How are you doing on this fine day, if I ..."*)

### Węzeł `[127]`
Mówca: **Gus Manger**
> "“Mr. President. How are you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: "“Not so great. You must have seen what is going on.”"*)
  - -> `[132]` (*Player: "“Eh. You?”"*)
  - -> `[11]` (*Player: "“What is it, Gus?”"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“Not so great. You must have seen what is going on.”"]** — Mówca: **Player**
> "“Not so great. You must have seen what is going on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Gus Manger: "“You bet I have.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BlackTuesdayHappened == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“It's not great on our end, either. Some of our investmen..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BlackTuesdayHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: "“The trade war has us on edge. We've been working on miti..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Eh. You?”"]** — Mówca: **Player**
> "“Eh. You?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“The trade war has us on edge. We've been working on mitigation measures for the rural economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“I am calling you because I just heard from the CEO of Ar..."*)

### Węzeł `[134]`
Mówca: **Gus Manger**
> "“You bet I have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Investment_Arcasia_Successful"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gus Manger: "“The money will be transferred to your personal bank acco..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Investment_Arcasia_Successful == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_E_ArmadineSuccessful = true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Investment_Arcasia_Successful == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Investment_Arcasia_Successful"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_E_ArmadineNotSuccessful = true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_E_ArmadineSuccessful = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_ArmadineSuccessful"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_E_ArmadineNotSuccessful = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_ArmadineNotSuccessful"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Investment_Arcasia_Successful == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Investment_Arcasia_Successful == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Investment_Arcasia_Successful == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Investment_Arcasia_Successful == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Investment_Arcasia_Successful"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_MarketsCrash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_MarketsCrash == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_MarketsCrash == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_MarketsCrash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_MarketsCrash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 3"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_MarketsCrash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_MarketsCrash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 2"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_MarketsCrash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_MarketsCrash == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_MarketsCrash == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_MarketsCrash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_MarketsCrash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 5"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_MarketsCrash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_MarketsCrash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 4"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 4`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_MarketsCrash == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_MarketsCrash == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_MarketsCrash == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_MarketsCrash == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_MarketsCrash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 7"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_MarketsCrash == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_MarketsCrash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 6"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 6`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_ReturnOfInvestment = true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Gus_CutLosses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gus_CutLosses == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Gus_CutLosses == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Gus_CutLosses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Gus_CutLosses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gus Manger: "“Goodbye for now.”"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Gus_CutLosses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Gus_CutLosses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gus Manger: "“Oh, I almost forgot.”"*)

### Węzeł `[159]`
Mówca: **Gus Manger**
> "“Oh, I almost forgot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Gus Manger: "“The management sent you one of their brand new radios as..."*)

### Węzeł `[160]`
Mówca: **Gus Manger**
> "“The management sent you one of their brand new radios as a gift. Ms. Suno will bring it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_ArmadineRadio");"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_ArmadineRadio");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_ArmadineRadio");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gus Manger: "“Goodbye for now.”"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true || BaseGame.R..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerTradeWarHappened == true || BaseGame..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "He didn't laugh."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He laughed out loud."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "He didn't laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“I am calling you because I just heard from the CEO of Ar..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "He laughed out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Gus Manger: ""Don't fret. It's not one of *those* calls.""*)

### Węzeł `[168]`
Mówca: **Gus Manger**
> ""Don't fret. It's not one of *those* calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“I am calling you because I just heard from the CEO of Ar..."*)
