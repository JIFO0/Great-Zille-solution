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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 14

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Gus_CutLosses`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[12]` (Gus Manger): `Variable["GameCondition.Turn05_Personal_ReturnOfInvestment"] = true;`
- Węzeł `[13]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 7;`
- Węzeł `[14]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 5;`
- Węzeł `[17]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 3;`
- Węzeł `[106]` (Gus Manger): `Variable["BaseGame.Relations_Gus_CutLosses"] = true;`
- Węzeł `[112]` (Gus Manger): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- Węzeł `[135]` (Gus Manger): `Variable["BaseGame.Investment_Arcasia_Successful"] = true;`
- Węzeł `[139]` (Gus Manger): `Variable["BaseGameSupport.News_Turn05_E_ArmadineSuccessful"] = true;`
- *...oraz 6 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Gus Manger)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“I was doing well until you gave me a call.”"]** — Mówca: **Player**
> "“I was doing well until you gave me a call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I was sipping my first cup of coffee for the day when the phone lit up and rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I swore under my breath. I thought my schedule was clear for at least half an hour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
Mówca: **Gus Manger**
> "“It definitely was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[8]`
Mówca: **Gus Manger**
> "“Mr. President. How are you doing on this fine day, if I may ask?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[10]`
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Gus Manger**
> "“Sorry, I know it's underwhelming. I bet you wish you'd gone for a bigger buy-in earlier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[30]`
  - -> `[26]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""I'm fine. You?”"]** — Mówca: **Player**
> ""I'm fine. You?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“What is it, Gus?”"]** — Mówca: **Player**
> "“What is it, Gus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Personal_ReturnOfInvestment = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Personal_ReturnOfInvestment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[13]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 7)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[14]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 5)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Gus Manger**
> "“I am calling you because I just heard from the CEO of Armadine Industries, Arron Bridges, regarding the recent initial public offering on the Ventrie City Stock Exchange.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[16]`
Mówca: **Gus Manger**
> "“Business as usual on my end. Thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[17]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[18]`
Mówca: **Gus Manger**
> "“Oh, come on. You are the president! Nobody got to that seat without taking massive risks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[19]`
Mówca: **Gus Manger**
> "“Well. I will take that. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“As you might've guessed, it's about our massive venture investment of 3000 shares worth nearly three million ren.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“Thanks to the ongoing trade war, I was told that the Armadine stock prices plunged after the IPO. The markets are very volatile right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Gus Manger**
> "“You will love it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I'm not much of a risk taker.”"]** — Mówca: **Player**
> "“I'm not much of a risk taker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[27]`
Mówca: **Gus Manger**
> "“Don't worry. Our stocks are still secure and they advised us not to sell because a recovery is expected in the near future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“However, this means that we have not made any profits, and on the contrary have lost fifty percent of the value compared to our initial purchase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Gus Manger**
> "“It is. Trust me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Darn it. Yes, I do.”"]** — Mówca: **Player**
> "“Darn it. Yes, I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[31]`
Mówca: **Gus Manger**
> "“I'm sorry, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[34]`
  - -> `[33]`
  - -> `[35]`
  - -> `[86]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“It was a good start for sure.”"]** — Mówca: **Player**
> "“It was a good start for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“I knew I shouldn't have listened to your advice.”"]** — Mówca: **Player**
> "“I knew I shouldn't have listened to your advice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Why are you apologizing? It's not your fault.”"]** — Mówca: **Player**
> "“Why are you apologizing? It's not your fault.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“You know what they say. Don't invest what you can't afford to lose.”"]** — Mówca: **Player**
> "“You know what they say. Don't invest what you can't afford to lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
Mówca: **Gus Manger**
> "“It was risky, yes. But look at where we are now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[65]`
  - -> `[63]`

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“Isn't that great?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[38]`
Mówca: **Gus Manger**
> "“At the time, I thought Armadine was a sure bet. This trade war came out of nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“Thank you for understanding the unfortunate situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Great news! So, how much did we gain?”"]** — Mówca: **Player**
> "“Great news! So, how much did we gain?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Yes. It's great. Go on.”"]** — Mówca: **Player**
> "“Yes. It's great. Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[42]`
Mówca: **Gus Manger**
> "“Wasn't Konrath Koronti the one that said that? He was a visionary for the free world for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“This better be worth it.”"]** — Mówca: **Player**
> "“This better be worth it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“Regardless, we still have a hold on our stocks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Gus Manger**
> "“The shares have doubled in price at the IPO in the VCSE and we will soon receive the profits made from the investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“Exactly. Electronics manufacturing has a great future and Armadine seems to have a head start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“I am confident once the effects of this nasty trade war subside, we'll recover the value of our shares and then some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[100]`
  - -> `[102]`

### Węzeł `[48]`
Mówca: **Gus Manger**
> "“I am very pleased to say that we have made gains!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“That's all I wanted to talk to you about, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[59]`
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“Goodbye for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Remind me never to do business with you ever again.”"]** — Mówca: **Player**
> "“Remind me never to do business with you ever again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Keep me up to date on other opportunities.”"]** — Mówca: **Player**
> "“Keep me up to date on other opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I knew it was the right call to trust you on this.”"]** — Mówca: **Player**
> "“I knew it was the right call to trust you on this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[54]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[56]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[57]`
Mówca: **Gus Manger**
> "“Again, I am so sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[58]`
Mówca: **Gus Manger**
> "“I'll let you know immediately when new opportunities arise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Very well. Talk to you later then.”"]** — Mówca: **Player**
> "“Very well. Talk to you later then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[60]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[62]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It's all thanks to you.”"]** — Mówca: **Player**
> "“It's all thanks to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[64]`
Mówca: **Gus Manger**
> "“I assure you, this will pale in comparison to what we will do together in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Some things are just worth taking the risk for.”"]** — Mówca: **Player**
> "“Some things are just worth taking the risk for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[67]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.BlackTuesdayHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“I have a good eye for investments.”"]** — Mówca: **Player**
> "“I have a good eye for investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“Instead of suffering losses due to market volatility like most public firms in Merkopa, we actually came out unscathed. Arcasia wasn't influenced by the Black Tuesday crash!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“It could have been much worse, but we got out of it with the best outcome. Isn't that great?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[73]`
  - -> `[53]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Great news! So, how much did we gain?”"]** — Mówca: **Player**
> "“Great news! So, how much did we gain?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Unbelievable. How can you say that when the Sordish economy is crippled?”"]** — Mówca: **Player**
> "“Unbelievable. How can you say that when the Sordish economy is crippled?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“I think so too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[76]`
Mówca: **Gus Manger**
> "“You are right, Mr. President. I'm sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“This is the beginning of a good partnership. Keep it up.”"]** — Mówca: **Player**
> "“This is the beginning of a good partnership. Keep it up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Gus Manger**
> "“You're going to want to sit down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“That, you do. Did you read Konrath Koronti's book on entrepreneurship, by any chance? Everything I know about the market, I learned from him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[80]`
Mówca: **Gus Manger**
> "“In total we have made...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[81]`
Mówca: **Gus Manger**
> "“It's not great on our end, either. Some of our investments are suffering due to Black Tuesday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[82]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true  or  Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true  or  Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
**[WYBÓR GRACZA: "“So you're telling me I spent a fortune on this investment and got nothing back?!”"]** — Mówca: **Player**
> "“So you're telling me I spent a fortune on this investment and got nothing back?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[86]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend1"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Gus Manger**
> "“Fair point. I would have felt worse if your investment was larger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“At least we didn't invest much and have no direct losses.”"]** — Mówca: **Player**
> "“At least we didn't invest much and have no direct losses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[91]`
Mówca: **Gus Manger**
> "“I know it's not great. But no one saw the trade war coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[92]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[94]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Gus Manger**
> "“As you might've guessed, it's about our significant venture investment of 2000 shares worth nearly two million ren.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“As you might've guessed, it's about our little venture investment of 1000 shares worth nearly a million ren.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Let's hope so. I want to trust you Gus.”"]** — Mówca: **Player**
> "“Let's hope so. I want to trust you Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“I doubt it. Sell all of our stocks and cut our losses." [+1 Personal Wealth]"]** — Mówca: **Player**
> "“I doubt it. Sell all of our stocks and cut our losses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[104]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Gus Manger**
> "“Very well, sir. I will arrange it and make the transfer to your personal bank account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Gus_CutLosses = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Gus_CutLosses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Anything else?”"]** — Mówca: **Player**
> "“Anything else?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“The shares have doubled in price at the IPO in the VCSE and we will soon receive the profits made from the investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[109]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Gus_CutLosses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Gus_CutLosses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Gus_CutLosses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Gus_CutLosses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Gus_CutLosses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[112]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[113]`
Mówca: **Gus Manger**
> "“Appreciate it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[114]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Gus Manger**
> "“...nearly two million Sordish Ren!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“...nearly four million Sordish Ren!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[122]`
Mówca: **Gus Manger**
> "“...nearly three million Sordish Ren!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[123]`
Mówca: **Gus Manger**
> "“The money will be transferred to your personal bank account shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[52]`
  - -> `[77]`

### Węzeł `[124]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true ||BaseGame.SuperpowerTradeWarHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true ||BaseGame.SuperpowerTradeWarHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true  or Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.BlackTuesdayHappened == true ||BaseGame.SuperpowerTradeWarHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true  or Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[127]`
Mówca: **Gus Manger**
> "“Mr. President. How are you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[132]`
  - -> `[11]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“Not so great. You must have seen what is going on.”"]** — Mówca: **Player**
> "“Not so great. You must have seen what is going on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[131]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.BlackTuesdayHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Eh. You?”"]** — Mówca: **Player**
> "“Eh. You?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“The trade war has us on edge. We've been working on mitigation measures for the rural economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[134]`
Mówca: **Gus Manger**
> "“You bet I have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Investment_Arcasia_Successful"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[136]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Investment_Arcasia_Successful == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Investment_Arcasia_Successful"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_E_ArmadineSuccessful = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_ArmadineSuccessful"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[140]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_E_ArmadineNotSuccessful = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_ArmadineNotSuccessful"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[141]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[143]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Investment_Arcasia_Successful == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Investment_Arcasia_Successful"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[144]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_MarketsCrash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_MarketsCrash == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_MarketsCrash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[146]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_MarketsCrash == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_MarketsCrash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[148]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_MarketsCrash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_MarketsCrash == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_MarketsCrash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[150]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_MarketsCrash == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_MarketsCrash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 4)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[152]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_MarketsCrash == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_MarketsCrash == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_MarketsCrash"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[154]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_MarketsCrash == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_MarketsCrash"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 6)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[156]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Gus_CutLosses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Gus_CutLosses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Gus_CutLosses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[158]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Gus_CutLosses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Gus_CutLosses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Gus Manger**
> "“Oh, I almost forgot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Gus Manger**
> "“The management sent you one of their brand new radios as a gift. Ms. Suno will bring it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_ArmadineRadio");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_ArmadineRadio");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[162]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[163]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Gus Manger**
*(Węzeł logiki narracyjnej: !(BaseGame.SuperpowerTradeWarHappened == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Narrator**
> "He didn't laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[167]`
Mówca: **Narrator**
> "He laughed out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Gus Manger**
> ""Don't fret. It's not one of *those* calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
