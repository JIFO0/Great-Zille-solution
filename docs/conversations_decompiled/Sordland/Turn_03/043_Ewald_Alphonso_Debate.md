# Sordland/Turn03/Ewald Alphonso Debate

- **ID konwersacji:** `43`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/043_Ewald_Alphonso_Debate.md`
- **Liczba węzłów dialogowych:** 424
- **Liczba wyborów gracza:** 101

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[41] Sordland/Turn03/EnT_GasomProposal** (../Turn_03/041_EnT_GasomProposal.md), Węzeł `[183]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 49

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[66]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[80]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[89]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[90]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[98]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[113]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[114]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- Węzeł `[121]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn...`
- *...oraz 41 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `41` (*Sordland/Turn03/EnT_GasomProposal*), Węzeł `[183]`

### Węzeł `[3]`
Mówca: **Ewald Alphonso**
> ""It's been a while, Mr. Rayne. Let me catch you up on my activities since I left office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true || BaseGame.Policy_Economy_PromoteMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true || BaseGame.Policy_Economy_PromoteMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true || BaseGame.Policy_Economy_PromoteMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Ewald Alphonso**
> ""Before we move on, I want to talk about the elephant in the room. The events that preceded the '53 election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
> "“President Rayne, I am here because we have a great opportunity on our hands. A business arrangement that will benefit Gasom and Sordland alike.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[15]`
Mówca: **Gus Manger**
> "“And serve you did. Sordland would be much worse off without you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[41]`
  - -> `[19]`
  - -> `[29]`

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
> ""I put so many years of my life into this corporation. And then I left it all behind and devoted myself to serving the people of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[17]`
Mówca: **Ewald Alphonso**
> "“The structure was rotting from the inside. It needed a shake-up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, you helped rescue the country from Soll's extreme protectionist and isolationist policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom continues to thrive, doesn't it? Your tenure as president may have come to an end, but it's not as if you were left with nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_CampaignedForAlphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Ewald Alphonso**
> ""I never would have imagined you capable of such a betrayal. Especially after you provided such invaluable support during my party leadership contest against Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“There might have been some disagreements in the past, but the President has shown strong leadership and good decision-making.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[25]`
Mówca: **Ewald Alphonso**
> ""I never would have imagined you capable of such a betrayal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[26]`
Mówca: **Ewald Alphonso**
> "“I also happen to believe that current and former presidents of Sordland should stick together and share our experiences. Not everyone has been in our shoes, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`
  - -> `[174]`

### Węzeł `[27]`
Mówca: **Ewald Alphonso**
> ""These two pillars embody the lasting impact we leave behind and the way we are remembered by others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[28]`
Mówca: **Narrator**
> "He gazed out for a moment longer as he contemplated what I'd said, then turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[32]`
Mówca: **Ewald Alphonso**
> "“My Gasom is not nearly as bad off as the Sordish government was. But a shake-up is needed nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“The latest figures show that Gasom will have to either decrease staff and operations by 40 percent in one year or take on a crushing amount of debt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Ewald Alphonso**
> "“I appreciate you coming through, Gus. Getting Rizia interested in another investment is a major feat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Ewald Alphonso**
> "“But I'm concerned about the future of what I have built up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Ewald Alphonso**
> ""But let's shift our focus to Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“This is why we have decided to reach out to foreign investors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[341]`
  - -> `[345]`
  - -> `[340]`

### Węzeł `[38]`
Mówca: **Ewald Alphonso**
> "“We've got an amazing opportunity here. The demand for gas is steadily increasing from both international partners and the Sordish state. All we have to do is ensure a consistent supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[39]`
Mówca: **Ewald Alphonso**
> ""I've had some time to think since leaving office. And to me, all of life's complexities can be distilled into two elements. Reputation and legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[40]`
Mówca: **Ewald Alphonso**
> "“With the right amount of investment, we can expand resource extraction, effectively fulfill rising demand and ensure long-term stability and profitability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I cannot help but empathize with individuals who invest their utmost dedication and passion into their work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> "“Not the right choice of words. This is not a bailout, but a strategic long-term cooperation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The fact that a leading privatizer is coming to the state to bail out his corporation is hysterical.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You do know that Rizia can't invest more than 20 percent unless the government permits the transaction which can take a long time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom is a private corporation. What does Sordland have to do with your business?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“If your analysis is correct, any investment would also make returns and secure further gas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[47]`
Mówca: **Ewald Alphonso**
> "“I ventured to Xina, immersing myself in its vibrant culture, then traversed the captivating landscapes of the Anrakan archipelago, and finally reunited with old acquaintances in Kyow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[48]`
Mówca: **Ewald Alphonso**
> "“And now that you're in office, you seem to be turning your back on your ideals entirely. Is power getting to you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[86]`
  - -> `[109]`

### Węzeł `[49]`
Mówca: **Ewald Alphonso**
> "“I always spoke highly of you, in fact. The youngest MP, a prodigy, I said. Even though I knew we could be rivals one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's too early to tell whether the Alphonso era was good for Sordland. It'll be a subject of debate among future historians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The deviation from our planned economic strategy didn't bode well for the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[52]`
Mówca: **Ewald Alphonso**
> ""Gasom still operates, yes. 'Thrives' is perhaps an exaggeration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Ewald Alphonso**
> ""That is much appreciated. I am well aware of the challenges you yourself have faced. I commend you for navigating those obstacles without causing harm to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[54]`
Mówca: **Ewald Alphonso**
> ""That's why Mr. Manger and I have been diligently exploring alternative solutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[55]`
Mówca: **Ewald Alphonso**
> ""If Soll had continued, we would have faced a severe economic downturn as well. The fabric of the country was being torn apart by corruption, greed and autocratic tendencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[56]`
Mówca: **Ewald Alphonso**
> ""We're not here to talk about my presidential successes or failures, Mr. Rayne. But I will say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
Mówca: **Narrator**
> "The sound of sirens briefly distracted us. Through the window, we saw police cars driving down the street adjacent to the Gasom zone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[58]`
Mówca: **Ewald Alphonso**
> "“I will remind you that I was never against the complete removal of the Energy Protection Act of 1932.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[65]`
Mówca: **Ewald Alphonso**
> "“In fact, I saw eye to eye with Soll about protecting our natural resources from foreign interests. But there is a balance in all things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
> ""I hope you won't stand idly by once again while the country is in desperate need of economic support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""Your government has recently provided stimulus payouts to Sordish citizens, so you understand the necessity of such investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Ewald Alphonso**
> "“Which is precisely why you were invited to be a part of this discussion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[70]`
Mówca: **Ewald Alphonso**
> ""Considering your own recent bailouts of businesses, you're hardly in a position to judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> "“We provide gas to half of Sordland, Mr. President. We could earn even more by selling gas abroad, but we value national advantage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""Why settle for being in the top 10 energy exporters when we have the potential to compete with Arcasia and United Contana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[73]`
Mówca: **Gus Manger**
> "“Mr. President, Gasom is a strategic asset to this nation regardless of its ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We don't need another nation to take care of our own energy company. Couldn't we keep this between Sordland and Gasom?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Considering the current state of the government budget, it may not be prudent to allocate additional funds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Ewald Alphonso**
> ""The right economic decisions can increase those funds. Gasom is poised for significant growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[77]`
Mówca: **Ewald Alphonso**
> ""To be honest, I prefer engaging with you and the Sordish government over foreign powers who prioritize their own interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Ewald Alphonso**
> ""Indeed. This deal has the potential to bolster both Gasom and Sordland. Together, we can create a historic opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“The reality of Arcasian-style capitalism means that our national interests should absolutely be part of the discussion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Investing together with Rizia could be better than just letting them purchase as much as they can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[82]`
Mówca: **Gus Manger**
> "“It might seem risky. But if we lose this opportunity, we might never have the chance again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Don't act so innocent. You and I both know how this game is played.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Blind? No, I see the truth all too well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The nation needs strong leadership after our fall from grace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Why didn't you approach the large international banks in Kyrute or Anraka? They might be eager.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[92]`
Mówca: **Gus Manger**
> ""Mr. Alphonso has neglected to mention that this is not an either/or proposition. Sordland can invest alongside Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[91]`
  - -> `[81]`
  - -> `[74]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've got the budget for it. And such a cooperation could be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Ewald Alphonso**
> "“Very beneficial. I will be at the helm to ensure these funds bring sustainable growth and good returns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“Ewald won't be alone. We have a talented financial team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I did what I had to do. Just like you did to beat Soll in the '46 Congress. Don't act like we are different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[101]`
Mówca: **Ewald Alphonso**
> "“Did the road to power blind you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[109]`
  - -> `[87]`

### Węzeł `[102]`
Mówca: **Ewald Alphonso**
> "“If we are going to work together, we'd better figure out if we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> "“As presidents of this republic there is more that binds us than that separates us. I want to establish a good partnership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[104]`
Mówca: **Ewald Alphonso**
> "“And you are providing it? Have you looked outside the palace windows?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[105]`
Mówca: **Ewald Alphonso**
> "“This isn't a game. If something fruitful is to come out of our talk today, we need to establish trust.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[106]`
Mówca: **Ewald Alphonso**
> "“We worked well together before, and we can again. But our intentions must be genuine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“And I appreciate your kind words but I want to iterate that the past is in the past. No reason to be petty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Your term may have come to a rough end. This doesn't mean I don't respect you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I worked with you because I believed in your vision. But opinions change, and so do allegiances.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[110]`
Mówca: **Ewald Alphonso**
> "“I think there is a strong potential for a deep partnership. The government strengthens the security of gas and the company can compete and grow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“And after we draw other investors, the state can always sell shares for a higher price and make a return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[112]`
Mówca: **Ewald Alphonso**
> "“It would be more costly from the government perspective, but a worthwhile endeavor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false && (BaseGame.Policy_Economy_PromoteMarket == true || BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Promise_Diplomacy_West == true || BaseGame.Promise_Immigration_Relaxed == true || BaseGame.Reform_Reformist_Intention == true || BaseGame.Reform_Reformist_Path == true ||
BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false && (BaseGame.Policy_Economy_PromoteMarket == true || BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Promise_Diplomacy_West == true || BaseGame.Promise_Immigration_Relaxed == true || BaseGame.Reform_Reformist_Intention == true || BaseGame.Reform_Reformist_Path == true ||
BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false  and  (Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Promise_Immigration_Relaxed"] == true  or  Variable["BaseGame.Reform_Reformist_Intention"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true  or 
Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false && (BaseGame.Policy_Economy_PromoteMarket == true || BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Promise_Diplomacy_West == true || BaseGame.Promise_Immigration_Relaxed == true || BaseGame.Reform_Reformist_Intention == true || BaseGame.Reform_Reformist_Path == true ||
BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false  and  (Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Promise_Immigration_Relaxed"] == true  or  Variable["BaseGame.Reform_Reformist_Intention"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true  or 
Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Gus scratched his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[223]`

### Węzeł `[119]`
Mówca: **Ewald Alphonso**
> "“Until '51, that is. Then the Sollist deep state began their damaging acts against our democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[120]`
Mówca: **Gus Manger**
> "“Gentleman, I think we are losing sight of our goal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[234]`
  - -> `[223]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true || BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true || BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true || BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[125]`
Mówca: **Ewald Alphonso**
> "“I beat that contest fairly. The era of Soll was ending. All I provided was a future vision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Ewald Alphonso**
> "“And Tarquin Soll didn't obstruct me initially. He actually respected the will of the party and gave me free reign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> "“And I guess you can empathize as to where my lack of optimism comes from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[194]`
  - -> `[195]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Optimism is a choice, Ewald. And sometimes, it's a difficult one to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[129]`
Mówca: **Ewald Alphonso**
> "“The future of this corporation matters as much to me as it does to the nation of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""...you won't get fooled again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, Ewald, we've seen division. Now it's a question of how we overcome it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[132]`
Mówca: **Ewald Alphonso**
> "“Why travel far for what you can achieve at home, or with our good friends in Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“Some international banks are interested, but they would rather buy the entirety of Gasom. Which is not possible, at least for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> "“Co-investing would reduce Sordland's contribution while allowing the nation to still have a stake for strategic purposes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Gus Manger**
> "“If the treasury situation is a concern, this path could be the most optimal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> "“I have been in your shoes. I saw the country descend into infighting, first in the Maroon Palace and then on the street.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[162]`
  - -> `[163]`

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> "“I'm an optimist, you know. I came here today despite everything because I believe we can still find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[164]`
  - -> `[165]`

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> "“You know what they say. Fool me once...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[166]`
  - -> `[167]`

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> "“And that is?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[146]`
  - -> `[147]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You need help with Gasom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Ewald Alphonso**
> ""I trust you comprehend Sordland's need for energy independence, President Rayne, especially as we labor to recover from the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Ewald Alphonso**
> "“Indeed. I've always considered you a strategic ally, President Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[143]`
Mówca: **Ewald Alphonso**
> "“Don't you see the mutual benefit in our collaboration?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""Of course, we've had our differences. But the people have chosen you. The nation's future is in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`
  - -> `[254]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We were always meant to work together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You are the reason that I am where I am now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[148]`
Mówca: **Ewald Alphonso**
> "“Despite our past differences, our visions for Sordland still intersect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`
  - -> `[251]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == true || BaseGame.Policy_Economy_PromoteMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == true || BaseGame.Policy_Economy_PromoteMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Speech_Democracy_Liberal == true || BaseGame.Policy_Economy_PromoteMarket == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“Other nations also heavily weighed against Sordland in that period.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[153]`
  - -> `[362]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I know there were other factors, Ewald. But you have to admit you played a part in your own downfall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It's easy to blame everyone else for your own faults, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[155]`
Mówca: **Ewald Alphonso**
> "“You should thank the obstructionists of the Old Guard and their disagreements with Soll for that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[156]`
Mówca: **Ewald Alphonso**
> ""That's easier said than done, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Ewald Alphonso**
> ""But without optimism, what do we have? Despair? That's no way to lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[158]`
Mówca: **Ewald Alphonso**
> ""Something like that. My point is, it would be unwise to attempt another double-cross.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Gus Manger**
> ""It's a tough road, sure. But we can't just roll over. Sordland needs us, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[160]`
Mówca: **Gus Manger**
> ""We can't afford despair either, can we? Let's keep our heads up and our eyes forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[161]`
Mówca: **Gus Manger**
> ""Let's not let old grudges cloud our judgment, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Division is a fact of life, Ewald. The challenge is how we navigate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes countries need to go through social division to change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Optimism, Ewald? That's a luxury I can't afford.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am as optimistic as you are, Ewald. We cannot afford to lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't come all this way just to fool you, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have a country to lead. Why should I even bother speaking to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[168]`
Mówca: **Ewald Alphonso**
> ""A difficult choice, but often the only one that can propel us forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[169]`
Mówca: **Ewald Alphonso**
> ""Indeed, President Rayne. And it seems our methods of navigation might differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[170]`
Mówca: **Ewald Alphonso**
> ""But how many people will suffer because of that division?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's put the past aside, Ewald. I have a country to run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is indeed a business arrangement, Ewald. Let's focus on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Presidents sticking together? That's an interesting notion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Ewald Alphonso**
> ""Of course, President Rayne. Business, above all, should drive this discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Ewald Alphonso**
> ""Indeed, it is an interesting notion, President Rayne. It's a shame that politics often stand in the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> ""A sentiment I share, President Rayne. The welfare of Sordland must always be our top priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[180]`
Mówca: **Gus Manger**
> ""Exactly, gentlemen! Let's get down to brass tacks, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[181]`
Mówca: **Gus Manger**
> ""Could do with a bit more of that, couldn't we? Former presidents, current presidents, all pulling together for Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Gus Manger**
> ""That's the spirit, gentlemen! Sordland is above most else, am I right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Ewald Alphonso**
> ""As we discuss the future of Sordland, it is paramount that I comprehend your vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[184]`
Mówca: **Ewald Alphonso**
> ""Now I hear that you are positive about the Kingdom of Rizia investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Ewald Alphonso**
> ""On the other hand, I have not heard any indication of your leanings regarding the Kingdom of Rizia's interest in investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`
  - -> `[190]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`
  - -> `[187]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My greatest concern is for the well-being of Sordland, whether that involves a collaboration with Rizia or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, I take it as an encouraging sign that a foreign nation is interested in a Sordish corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am certainly receptive to the idea, but engaging with international partners like monarchies brings its own set of bad repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While the prospect of collaborating with a wealthy nation like Rizia is not unappealing, I am suspicious of their underlying intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have yet to receive a comprehensive briefing on the matter. I prefer to maintain a careful approach, and not make premature commitments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not hand over crucial components of our energy industry to foreign entities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""The trajectory you set for this country will inevitably impact not just Gasom, but also Sordland's position on the global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look, I am open to make sense out of why I have come all the way here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your perspective, and it is justified to a degree. I want to explore an earnest way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I do understand your perspective, but I'm not here to care about your problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""For the future of Sordland, it is the best interest of all if Gasom remains in Sordish hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have state energy corporations that can do what you are doing with Gasom. Better, even.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom plays a crucial role in Sordland's energy independence. It must be controlled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That just shows how weak our so-called 'democracy' is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The reforms while bold were conducted way too quick. If they had succeeded any deep state attempt would have failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've come face to face with the Old Guard myself now. I understand what you were up against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Ewald Alphonso**
> "“I believe they can be defeated. But not without allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[204]`
Mówca: **Ewald Alphonso**
> ""Our democracy is not weak. It has been tested, but it has also shown resilience. We should not confuse struggle with weakness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[205]`
Mówca: **Ewald Alphonso**
> ""You're quick to judge from the comfort of hindsight. We acted decisively, yes, but that's what was needed at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[206]`
Mówca: **Ewald Alphonso**
> ""The state's interest and Gasom's success are not mutually exclusive. Our control can be shared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[207]`
Mówca: **Ewald Alphonso**
> ""I can't disagree. But it's not about who owns Gasom, it's about how it's run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[208]`
Mówca: **Ewald Alphonso**
> ""Then by all means, let them try. Competition is the lifeblood of progress. Let the best corporation win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[209]`
Mówca: **Ewald Alphonso**
> ""These aren't just my problems. They're Sordland's problems. And if you're not here to care about them, then why are you here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[210]`
Mówca: **Ewald Alphonso**
> ""Well, isn't that magnanimous of you. It's not about making sense of why you're here. It's about understanding the critical role you play in shaping the future of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[211]`
Mówca: **Ewald Alphonso**
> ""Then let's do that. For Sordland's sake, we need to find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""You make a valid point, President Rayne. The interest of foreign investors could indeed be seen as an endorsement of our potential for growth and competitiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""Your caution is well-founded, President Rayne. International partnerships are fraught with complexity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. The welfare and progress of Sordland must always be our primary concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""I respect your prudence, but let us not forget that fortune often favors the bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""It's encouraging to hear your concern for Sordland's key industries, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""Your wariness is understandable, President Rayne. The motivations of nations like Rizia are not always clear-cut.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""However, I would caution that such interest is not a guarantee of our success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[219]`
Mówca: **Ewald Alphonso**
> ""However, I trust that you recognize the potential opportunities and benefits they might bring to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Maintaining control of these sectors is indeed crucial, but we must also consider the potential benefits that foreign investment might bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
> ""Our utmost priority should be to ensure that any partnership we enter is in the best interest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're correct, Gus. We need to refocus. Ewald, let's set our differences aside and aim for the best possible outcome for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "I don't know. If our visions for Sordland are fundamentally at odds, is there even a point to continue this discussion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[225]`
Mówca: **Ewald Alphonso**
> ""Our reputation, what we're known for during our time, can shape our legacy, what we leave behind. The two are inseparable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Ewald Alphonso**
> ""We should strive to build a reputation that speaks to our values and a legacy that demonstrates our impact on Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[227]`
Mówca: **Gus Manger**
> ""Right you are, Ewald. How can a man be judged, if not by the impact he makes on others and the way he is remembered?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`
  - -> `[275]`
  - -> `[230]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree. Our reputation is the mirror of our actions, and our legacy, the shadow that remains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An interesting take. But reputation is transient, while legacy is lasting. The latter is what truly matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A valid point, Mr. Alphonso. But I would argue that integrity and service to the people should stand above reputation and legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""Very well, President Rayne. Our personal differences shouldn't overshadow the future of our country and my company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Ewald Alphonso**
> ""Your words hint at resignation, President Rayne. But I still believe in the possibility of a consensus, despite our differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[304]`

### Węzeł `[233]`
Mówca: **Gus Manger**
> ""I'm glad to see you both finding common ground. Let's proceed with Sordland's interests at heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I believe we've exhausted the possibilities here, Ewald. Our visions for Sordland are just too divergent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Ewald Alphonso**
> ""That's unfortunate, President Rayne. I was hoping we could find some middle ground. But I respect your stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[304]`

### Węzeł `[236]`
Mówca: **Ewald Alphonso**
> ""Good. Because you're on my territory right now, and another double-cross would be a terrible mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Gus Manger**
> ""Gentlemen, let's remember that we're here to make a new agreement, not rehash old disagreements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[238]`
Mówca: **Ewald Alphonso**
> ""I'm well aware of the responsibilities of leadership, President Rayne. Have you never thought that you could benefit from my experience?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Gus Manger**
> ""Mr. President, Ewald, let's not lose sight of the fact that we all want what's best for Sordland. We may have different ideas, but our goals are the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Ewald. Our country needs both energy independence and economic recovery. Perhaps a collaboration could be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our goals may align, Ewald, but that doesn't mean we need each other. Sordland isn't your responsibility anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not convinced, Ewald. Your past actions make me skeptical of your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your vision for Sordland has its merits, Ewald. However, my administration has its own path to tread.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our visions heavily intersect, Ewald. We should try our best to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Common visions are not always grounds for alliances, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The people's favor is a heavy burden, Ewald. One I intend to bear with honor and integrity, unlike you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's not about favor, Ewald. It's about making the right decisions for our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The people's favor is transient, Ewald. What matters is the legacy we leave behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""That's the spirit, President Rayne. Together, we can accomplish great things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[256]`
Mówca: **Ewald Alphonso**
> ""True. It's yours. But remember, no man is an island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[257]`
Mówca: **Ewald Alphonso**
> ""I understand your skepticism. But we can't let past misunderstandings get in the way of a fruitful future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""Yes, every administration has its own path. But don't disregard the wisdom of those who have trod it before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[259]`
Mówca: **Ewald Alphonso**
> ""Indeed, President Rayne. I will respect your autonomy in decision-making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""True, President Rayne. But sometimes, unexpected alliances can bring about the greatest changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[261]`
Mówca: **Ewald Alphonso**
> ""Your bitterness casts doubts that you will, President Rayne. It is not wise to make enemies for no reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[262]`
Mówca: **Ewald Alphonso**
> ""Indeed, President Rayne. The right decisions, however, aren't always the easiest ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[263]`
Mówca: **Ewald Alphonso**
> ""A wise observation, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[264]`
Mówca: **Ewald Alphonso**
> ""Have I told you about I became involved with Gasom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""It was all because I seized an opportunity. I bought the shares being sold by the Contanan partners and secured a significant stake. This move wasn't just about financial gain or personal ambition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[364]`

### Węzeł `[266]`
Mówca: **Narrator**
> "We redirected our attention to the meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[267]`
Mówca: **Narrator**
> "Alphonso took a sip of coffee before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[268]`
Mówca: **Ewald Alphonso**
> ""After acquiring the shares, I was elected as CEO. The company expanded, hired world-class engineers from all over the world, turned the small town of Narbel into a thriving city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
> ""Despite criticism from the Nature Preservation Foundation, I fulfilled most of the gas needs of Sordland and increased our energy independence, all while aligning with Tarquin Soll's autarky strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Ewald Alphonso**
> ""That's the essence of opportunity. What matters is that you seize it when it appears. And remember, it's not just about taking that leap, but about what you do once you've landed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[306]`
  - -> `[307]`
  - -> `[308]`

### Węzeł `[271]`
Mówca: **Narrator**
> "He took a sip of coffee. His face assumed a contemplative expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[272]`
Mówca: **Ewald Alphonso**
> ""I see them as more than just reflections and shadows. They are the tangible products of our actions, the fruits of our labor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[273]`
Mówca: **Ewald Alphonso**
> ""I would argue that the transient nature of reputation is what makes it important. It's the soil in which the seed of legacy grows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[274]`
Mówca: **Ewald Alphonso**
> ""A noble perspective. But isn't it through our reputation and legacy that our integrity and service are ultimately judged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your past actions show nothing but a ruthless pursuit of profit, at the expense of the people and environment. That's hardly a reputation or a legacy to be proud of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Ewald Alphonso**
> ""A harsh critique, but not an unexpected one. I see profit as a means to a greater end. It enables us to drive progress, change lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Ewald Alphonso**
> ""As for my legacy, it will be for history to judge, not you or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[278]`
Mówca: **Gus Manger**
> ""It seems we are at a crossroads with Gasom. The numbers tell a tale of struggle and potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Ewald Alphonso**
> ""No need to sugarcoat it, Gus. Our corporation is teetering on the edge of a cliff. Without significant restructuring, the firm risks plunging into insurmountable debt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Gus Manger**
> ""My old friend Ewald reached out to me for assistance. Out of respect for our shared history -- and my small stake in the company -- I couldn't refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[281]`
Mówca: **Ewald Alphonso**
> ""Thanks to Gus' Rizian connections, investors from the kingdom are now interested in Gasom, a development that could steer us clear of the looming crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm intrigued by the untapped fields. What's the potential return if we invest in these new areas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Will the investment help keep Gasom from having to downsize its operations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a risk, Mr. Alphonso. What if the investment doesn't pay off as expected?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[285]`
Mówca: **Gus Manger**
> ""It was only when his father fell ill that he took over and transformed the farm. He took risks, made some mistakes, but ultimately, he tripled their output in just a few years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`
  - -> `[289]`

### Węzeł `[286]`
Mówca: **Gus Manger**
> "“Your concerns, Mr. President, remind me of a time when I was working with OMEC. We were bringing in foreign investments to revitalize the local companies. There were protests, people who were scared of change, who thought we were selling out. But we weathered the backlash, stood by our decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A heartwarming story, Gus. But one successful case doesn't necessarily mean it's the best approach for the whole country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A truly inspiring story, Gus. This is the kind of innovation and growth we should be fostering in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait a minute, Gus. Is this story about you? Were you the young farmer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[290]`
Mówca: **Gus Manger**
> "“Years later, those same people saw the benefits, the jobs we created, the growth we spurred. Change is always met with resistance, but in the end, it's the results that matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[293]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a nice story, Gus, but we're not talking about a company here, we're talking about an entire nation. The stakes are much higher.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your experience with OMEC is very valuable for us, Gus. We do need to stay the course and see our decisions through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Change may be met with resistance, Gus, but it's our job to ensure that the people are with us on this journey. We can't disregard their concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[294]`
Mówca: **Gus Manger**
> ""Ha! Well, I did grow up on a farm, but no, that wasn't me. I was too busy trying to turn apples into a viable fuel source. A failed experiment, but it made some damn good cider!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[295]`
Mówca: **Gus Manger**
> ""That's the power of economic freedom. It allows innovation, it allows us to adapt and to grow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[296]`
Mówca: **Gus Manger**
> ""Of course not, Mr. President. But if we completely turn our backs on the idea of economic freedom, we're no worse than that farmer's father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[297]`
Mówca: **Gus Manger**
> ""I completely agree, Mr. President. The people are our greatest asset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[298]`
Mówca: **Gus Manger**
> ""It's true, OMEC was a great learning experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[299]`
Mówca: **Gus Manger**
> ""You're right, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[300]`
Mówca: **Gus Manger**
> ""But remember, sometimes, people don't know what's best for them until they see it. That's why we're here, to help them see a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[301]`
Mówca: **Gus Manger**
> ""A lot of sleepless nights, tough negotiations, and even a few broken friendships... but I'd do it all over again if it means seeing our country prosper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[302]`
Mówca: **Gus Manger**
> ""But remember, a nation is also a conglomerate of sorts, of people, of businesses, of hopes and dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Narrator**
> "As Gus finished his point, we suddenly heard the faint wailing of sirens in the distance. He waited for the noise to fade before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't like bullshit. Just tell me what you want from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will at least hear the details of your proposal. But I won't make any promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An inspiring story, President Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You talk about seizing opportunities, yet your rapid privatization nearly crashed our economy. That's rich, considering your 'leap' resulted in anything but a graceful landing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your approach might have worked for you, but it's not always as simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
> ""But that requires us to be willing to take risks and weather the storm. Now, that's a legacy worth striving for, wouldn't you agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[284]`
  - -> `[283]`
  - -> `[369]`

### Węzeł `[312]`
Mówca: **Ewald Alphonso**
> ""Every investment involves risk. But this one is an easy bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[313]`
Mówca: **Ewald Alphonso**
> ""That's the question of the hour, Mr. President. It won't be easy, but with the right moves, we might be able to navigate this storm without losing our crew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[315]`
Mówca: **Gus Manger**
> ""I've always believed in the power of networking. I'm sure you've heard of Rusty Montoro, Chairman and CEO of Rizian Royal Gold. Rusty and I go way back, and he's done quite well for himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Gus Manger**
> ""Back under Alphonso's government, I was able to broker a deal with King Romus Toras, thanks to my connection with Rusty. It was a win for all involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[319]`
  - -> `[318]`
  - -> `[419]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rusty Montoro, the Toras family, the Rizian government...it seems like an impressively powerful alliance you've formed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So I've heard, Gus. I understand the need for strategic alliances, but let's remember our own interests and values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With all due respect, Gus, I'm not thrilled that you got Sordland in bed with a monarchy. The kingdom's connection to Rumburg isn't particularly reassuring either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Gus Manger**
> ""It was quite a feat, and not one without risk. But the potential rewards for Sordland, I believe, are worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[321]`
Mówca: **Gus Manger**
> ""I hear your concern, but business doesn't always line up neatly with politics. Our deal with the Toras family was purely about economic growth for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[322]`
Mówca: **Gus Manger**
> ""Absolutely, we're in this for Sordland first and foremost. But remember, in the world of international business, alliances are tools, not ties that bind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
> ""Our pace was not the problem. Resistance to change was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[327]`
Mówca: **Ewald Alphonso**
> "“Along the way, I had the privilege of encountering remarkable individuals who have made significant contributions to their respective fields.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Ewald Alphonso**
> ""My experiences prompted deep reflection on the essence of life. I came out of it all with two words resonating in my head: reputation and legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[329]`
Mówca: **Narrator**
> "With a cup of coffee in hand, he strolled over to the window, his gaze drawn to the expansive gas fields stretching before him. Towering mountains provided a majestic backdrop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[423]`
  - -> `[333]`
  - -> `[332]`
  - -> `[336]`

### Węzeł `[330]`
Mówca: **Ewald Alphonso**
> ""I have been thinking about my own legacy and reputation. And I refuse to be remembered as a failed reformer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't we all yearn to be remembered and to make a meaningful contribution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Life's true essence lies in the present moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The focus on reputation and legacy is rooted in a capitalist framework that perpetuates individualism and inequality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[336]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I didn't comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Narrator**
> "After taking a moment to appreciate the landscape, Alphonso turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That makes sense. Foreign investors will bring much-needed capital and expertise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Engaging with foreign investors can be a double-edged sword.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have concerns about relying too heavily on foreign investors. It's important to prioritize local ownership and maintain sovereignty over our national resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Gus Manger**
> ""Correct, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[343]`
Mówca: **Gus Manger**
> ""I understand your concerns. But the future of Gasom is on the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[344]`
Mówca: **Gus Manger**
> ""I appreciate your perspective, but we need to adapt to the changing global landscape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Foreign investors such as the Kingdom of Rizia, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Gus Manger**
> ""The Kingdom of Rizia certainly has valuable expertise and resources in the energy sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[352]`
Mówca: **Gus Manger**
> ""It's a strategic move to ensure the growth and success of Gasom, benefiting both the company and the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[353]`
Mówca: **Gus Manger**
> ""Rest assured, we will take measures to protect our interests and ensure responsible engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[354]`
Mówca: **Gus Manger**
> ""Foreign investors will bring new opportunities and technologies that could enhance the efficiency and competitiveness of Gasom. It's about finding the right balance and safeguarding our interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[355]`
Mówca: **Gus Manger**
> ""We will carefully consider their investment proposal and assess how it aligns with our long-term goals for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[356]`
Mówca: **Ewald Alphonso**
> "“The trouble is that right now, some of our fields are operating at only half of their capacity due to resource limitations. But we have significant potential for expansion, including two new fields that haven't even been tapped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I won't let the Old Guard do what they did to you to me. You should have seen through it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Ewald Alphonso**
> ""You'll need allies if you want to beat the deep state, Mr. Rayne. A difficult proposition for a traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't like bullshit. Can we get to the choice at hand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
**[WYBÓR GRACZA: "Don't interrupt."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[366]`
Mówca: **Ewald Alphonso**
> ""One would expect more diplomatic skill from a president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[367]`
Mówca: **Ewald Alphonso**
> ""Your lack of statesmanship is disheartening, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've seen enough corporate bailouts and handouts to know that it's always the big businesses that benefit, while the common people are left to suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Ewald Alphonso**
> ""Gasom is not just another corporation; it's an essential part of the energy infrastructure that powers our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[372]`
Mówca: **Gus Manger**
> ""With proper investment and development, we project extremely high returns in the first five years alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[373]`
Mówca: **Gus Manger**
> ""We have developed a strategic plan that focuses on diversifying revenue streams and exploring new markets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[374]`
Mówca: **Gus Manger**
> ""There is the aforementioned interest from Rizia. But the investment could also come from Sordland itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[375]`
Mówca: **Ewald Alphonso**
> ""As chair, my own reputation and legacy are tied with that of Gasom. But so, I would argue, are Sordland's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[376]`
Mówca: **Ewald Alphonso**
> ""I confess I've been following the news from the Maroon Palace closely since leaving office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromoteMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Ewald Alphonso**
> ""I am heartened that your economic interests seem to align with mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Ewald Alphonso**
> ""Your decision to deviate from a market economy is, let's say, not what I would have chosen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[395]`
Mówca: **Ewald Alphonso**
> ""Even more so that you have chosen to align with the West. It's a path I myself considered while drafting my foreign policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Ewald Alphonso**
> ""But I am heartened by your decision to align with the West. It's a path I myself considered while drafting my foreign policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[399]`
Mówca: **Ewald Alphonso**
> ""But I am puzzled that your administration has so far ignored the wealth of opportunities provided by the West. It's not a foreign policy direction I would have chosen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[401]`
Mówca: **Ewald Alphonso**
> ""And I am puzzled that your administration has so far ignored the wealth of opportunities provided by the West.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Ewald Alphonso**
> ""Meanwhile, I have not heard any indication of your leanings regarding the Kingdom of Rizia's interest in investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`
  - -> `[190]`

### Węzeł `[407]`
Mówca: **Gus Manger**
> ""You know, gentlemen, this reminds me of a story from when I was just starting out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Gus Manger**
> ""There was this young farmer in Gruni. His father was a stubborn man, insisted on doing things the old way. But this young farmer, he had ideas. He wanted to modernize, to innovate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[409]`
Mówca: **Gus Manger**
> ""Back to the topic at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[410]`
Mówca: **Ewald Alphonso**
> "“We've got an amazing opportunity here. The demand for gas is steadily increasing from both international partners and the Sordish state. All we have to do is ensure a consistent supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Ewald Alphonso**
> "“With the right amount of investment, we can expand resource extraction, effectively fulfill rising demand and ensure long-term stability and profitability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[412]`
Mówca: **Ewald Alphonso**
> "“The trouble is that right now, some of our fields are operating at only half of their capacity due to resource limitations. But we have significant potential for expansion, including two new fields that haven't even been tapped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[418]`
Mówca: **Gus Manger**
> ""One hand washes the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can assist you if you can return the favor by improving the situation in the city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will seize opportunities, but not the ones you might like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Ewald Alphonso**
> ""I respect a man that sticks to his ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our image and our perception are a key force that shape our lives. But they can also be burdensome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
