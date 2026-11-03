# Sordland/Turn03/Gus Intro Talk

- **ID konwersacji:** `42`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/042_Gus_Intro_Talk.md`
- **Liczba węzłów dialogowych:** 252
- **Liczba wyborów gracza:** 67

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend2`
- `BaseGame.Decision_Turn01_PersonalInvestment_Spend3`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.RuralDevelopment_Interest`
- `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention`
- `BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject`
- `BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[41] Sordland/Turn03/EnT_GasomProposal** (../Turn_03/041_EnT_GasomProposal.md), Węzeł `[21]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[25]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject"] = true;`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment"] = true;`
- Węzeł `[98]` (Paskal Beniwoll): `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- Węzeł `[101]` (Paskal Beniwoll): `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`

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
  - -> `[93]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `41` (*Sordland/Turn03/EnT_GasomProposal*), Węzeł `[21]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You still have to prove that you make returns on your deals. Our investment in Armadine had better make a return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Gus Manger**
> "“I never claim to see the future, President Rayne. I merely find good opportunities and seize them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The discussions were lively during the highway contract award. I'm willing to hear new offers from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Gus Manger**
> "“And I'm willing to present them. Despite your unfortunate choice of the H-3 over the L-1.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_Spend2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_RespondedToInfraProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_RespondedToPersonalInvestment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[27]`
Mówca: **Gus Manger**
> ""Please come this way. Ewald and I have some exciting news to share with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“The corruption in that organization is unfathomable. Makes the Lotherberg group look like saints.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[42]`

### Węzeł `[29]`
Mówca: **Gus Manger**
> "“By the way, I still don't believe Taurus should be trusted with such a monumental mega-project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[30]`
Mówca: **Gus Manger**
> "“I'm glad you contracted Underhall, by the way. You won't be disappointed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[57]`
  - -> `[36]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The government has clear control over SSC's operations. We wouldn't get that with a private corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have to take the safe option this early in the term, Mr. Manger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I think it's time we let fresh -- and fast -- new faces have a shot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Status quos are meant to be broken. I want to be the change maker during my term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It seemed the least risky option. We need safe bets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The workers need to be protected somehow. We can't ignore that problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“It might seem like we have control, but those organizations are slow and inflexible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[38]`
Mówca: **Gus Manger**
> "“I admit I'm slightly frustrated that you contracted SSC. They've been leeching off the Sordish people for too long.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“They need to walk before they can run. And I'm saying this as a guy who actually almost likes Frens Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[54]`

### Węzeł `[40]`
Mówca: **Gus Manger**
> "“Calculated risks, Mr. President. Taurus is not the right call. But don't mind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“It's a pity you only had three choices, to be honest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The SSC is one of our national treasures. It rebuilt most of Sordland in the '30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Gus Manger**
> "“Understandable. But we have to break the cycle at some point if we want to stick around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“Yes, nobody can deny the SSC's great work for our people in the Restoration period. But those days are long gone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Narrator**
> "He pushed open a door. We walked down yet another hallway, seemingly in the direction we'd just come from."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“Like a maze, isn't it? That's Qinali architecture for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“The only difference between an SSC manager and a fossil from the pre-Migration period is that the fossil might actually be worth something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[48]`
Mówca: **Narrator**
> "A stark contrast to the blue-collar workers outside working with machinery, transportation, and maintenance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[129]`
  - -> `[134]`
  - -> `[151]`

### Węzeł `[49]`
Mówca: **Narrator**
> "The doors opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“To be 100 percent honest, Mr. President, I doubted he even wanted to discuss this with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[66]`
  - -> `[73]`

### Węzeł `[51]`
Mówca: **Gus Manger**
> "“We do have to be delicate with Gasom, though. A corporation this big is like a house of cards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“He must really care about Gasom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Does the average working-class man in Narbel really give a damn about that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We won't know until they complete the project. There's no reason to be negative before then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Gus Manger**
> "“I respect that. Most of my life has been about changing the status quo in Gruni.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
Mówca: **Gus Manger**
> "“Time will tell. I also hope that it will succeed, believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I still have my doubts, but I'll take your word for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[58]`
Mówca: **Gus Manger**
> "“I'm just a civil servant who wants what's best for the Sordish people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[59]`
Mówca: **Gus Manger**
> "“But there's a time and a place to take risks. The stock market, yes. National infrastructure, no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“Admittedly, I'm biased. But I do think Gasom is extraordinary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[82]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We worked closely in the past and are on friendly terms. I'm open to see what we can do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“I think he is fully focused on Gasom these days. His entire reputation is bound to this corporation now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What's in the past shouldn't shape our future. Especially if a good deal can be talked through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The feeling is mutual. Both of us are only here because of you, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“It's one of Sordland's most significant private corporations. Ewald's reputation as chairman and ex-CEO rests on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Gus Manger**
> "“Yes, and Sordland needs any deal it can get. Soon the term budget will be determined and expenditures won't recover the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“I do my best. Got a close influential contact in Porte Drazon who opened a lot of doors a few years ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“Moreover, we have an opportunity to make a larger economic impact on the people of Narbel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“We can't provide services to our people without corporations like Gasom filling our coffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_CampaignedForAlphonso == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I wasn't against him early on. Quite the opposite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Gus Manger**
> ""I still remember the day the party leadership changed from Tarquin Soll. What a historic moment that was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Gus Manger**
> "“Shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The fact that you managed to get Rizia entangled in this is surprising.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“If he needs to be hands-on as chairman, then the business must not be doing well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's so extraordinary about another corporation trying to make a hefty profit off the back of the people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have no ill-will against Ewald Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Gus Manger**
> "“Human greed is undeniable. I always saw it as an asset to move wealth our way, to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
Mówca: **Gus Manger**
> "“It's true that it's seen a lack of consistent growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Gus Manger**
> "“As you know, he and I go back a long time. He isn't the sell-out some Sollists painted him to be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[89]`
Mówca: **Gus Manger**
> "“Why should you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[90]`
Mówca: **Gus Manger**
> "“But Gasom is beyond that. Not many nations have such an influential and valuable asset. We ought to maximize its potential.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[91]`
Mówca: **Gus Manger**
> "“But Gasom has the potential to rival global corporations like Rizian Royal Gold. It could be *the* gas exporter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not exactly the most pleasant location for a meeting, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[93]`
Mówca: **Gus Manger**
> ""I trust Ministers Walda and Beniwoll didn't overwhelm you with their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[95]`
  - -> `[94]`
  - -> `[92]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good to see you, Gus. I wanted to talk to you about what we can do to help the development here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I would be surprised if there are no demands or expectations here today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a relief to have a break from all that, even if just for a little while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Gus Manger**
> "“Petr Vectern isn't the only one you can have fun with, you know! Jokes aside, you are the President, so do what you want!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RuralDevelopment_Interest += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RuralDevelopment_Interest += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[102]`
Mówca: **Gus Manger**
> "“No demands from me, President Rayne. I'm all about making deals and finding common ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Gus Manger**
> "“Perfect. That's exactly what I hope to accomplish during today's discussions. My job is to improve the conditions of places like these.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“Sipping Borin wine at the Jewel beach resort in Benfi would be better, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Gus Manger**
> "“Except for running the country to the ground, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[106]`
Mówca: **Gus Manger**
> "“If there's one thing Gus Manger stands for, it's win-win solutions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“The methods for achieving better living standards can be discussed in detail when we talk terms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[108]`
Mówca: **Gus Manger**
> ""But you know, as someone who has never experienced the working-class way of life, it's important for me to understand why my role holds such significance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[109]`
Mówca: **Gus Manger**
> "“Kris Schar and the company still have many things they need to figure out, but they are good at what they do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Gus Manger**
> "“We won't ignore it, Mr. President. But as I mentioned before, I don't think this new Assembly bill is the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“Too few large corporations own too much power. Market economics won't succeed with monopolies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Gus Manger**
> "“If I had any extra time or resources left, I'd enter the construction business myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Gus Manger**
> "“Anyway, I digress. Let's get to the elevator.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Keep up with the times. Your knowledge will come in handy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm still not sure how fattening your own wallet helps our rural populations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“That's going to be me one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I don't care about the books. My worry is our duty and service.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Does it, though?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I see your point, but the economy is a complex beast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Gus Manger**
> "“We can discuss this later, Mr. Rayne. We shouldn't keep our former president waiting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“They don't, but it affects them nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
Mówca: **Gus Manger**
> "“Of course it wasn't just Rizia. But their contribution led to interest from other nations like Qinal and Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I understand. Support the business, and we support the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Gus Manger**
> "“I highly advise us to find a middle-ground. If the state can assist Gasom through these tough times, we'll all benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[125]`
Mówca: **Gus Manger**
> "“Isn't that paraphrasing Malenyev? Keep in mind we only have a single term to work with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[126]`
Mówca: **Gus Manger**
> "“Our country needs steadiness and stability more than ever. Yes, we need to fix inequality. But not at the expense of everything else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[127]`
Mówca: **Gus Manger**
> "“Think of Gasom as a house of cards with an entire city built atop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[128]`
Mówca: **Gus Manger**
> "“And none of the average citizens here care about anything other than direct support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Why are there so many workers from abroad?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The whole complex feels very hands-on deck. I can tell an intricate operation when I see one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Gus Manger**
> "“It took decades for Ewald -- and the workers, of course -- to create an enterprise of such global competitive potential.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Gus Manger**
> "“The best talent in Sordland was snatched by the SSC in the 1930s. Most other corporations couldn't contend, so they had to look elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“The equipment provided is high-standard. I've seen it for myself. Besides, there will always be differences between workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The white-collars seem to be having it good in here while the majority are working out in the cold.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[135]`
Mówca: **Gus Manger**
> "“Ah, here's the elevator. Ewald ought to be up there already; there's a separate entrance by the helipad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Pat yourself on the back, Gus. You did well. I expect the same and more in my term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Gus Manger**
> "“That's what I liked about Ewald Alphonso. He didn't let titles or rules get in the way of results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
Mówca: **Gus Manger**
> "“It was more complicated than that. Obstructionists in the institutions halted critical policies that could have avoided us the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
Mówca: **Gus Manger**
> "“It's a hundred percent with me. I have some new ideas I'm discussing with Mr. Holl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Gus Manger**
> "“I'm glad we have overcome the worst of those days. The economy isn't great, but it is more stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[141]`
Mówca: **Gus Manger**
> "“Good leadership is allowing people to excel in what they are good at, not forcing them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[142]`
Mówca: **Gus Manger**
> "“Yes, the privatization and the cancellation of old policies was too fast and radical, but that wasn't it. The geopolitical pressures on the market were significant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[143]`
Mówca: **Gus Manger**
> "“We'll brief you on those later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[147]`
Mówca: **Gus Manger**
> "“Just remember. Past is past. We've got to look to the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[148]`
Mówca: **Gus Manger**
> "“Let's do this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[149]`
Mówca: **Narrator**
> "We stepped into the elevator. Gus punched a code and we began our ascent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[150]`
Mówca: **Narrator**
> "The hallways were lined with doors. Glass panels in them revealed workers in suits and ties, many of foreign origin, busy in their pristine offices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“A Qinali architect is an odd choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“Some of Gasom's global hires are from the Republic of Qinal. Once you get past the cultural differences, they're really quite gifted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[156]`
Mówca: **Gus Manger**
> "“Just remember. Alphonso's our friend. We've got the foundation for a great deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[157]`
Mówca: **Gus Manger**
> ""I have faith that you won't leave us hanging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[6]`
  - -> `[182]`
  - -> `[183]`
  - -> `[79]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“After your convincing arguments about the railway project, I was curious what else we could achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[159]`
Mówca: **Gus Manger**
> "“Sometimes I do it for myself, other times I chase luck with others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“For your sake and mine, I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Don't you think it's a little wrong that someone in your position is active in the stock market?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“A true capitalist knows how and when to play.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[163]`
Mówca: **Gus Manger**
> "“I like the all-in 3000-share purchase you made. Shows that you're a man of action, like me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Gus Manger**
> ""You played it safe with 2000 shares, but you still stand to make some gains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Gus Manger**
> "“Your measly 1000 shares won't make you much profit. But you know, good to dip your feet in the water before taking a dive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Gus Manger**
> "“Me, I got 4000 shares thanks to a low-risk loan I leveraged on an old logistics business of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[167]`
Mówca: **Gus Manger**
> "“The offerings on the Lachaven Stock Exchange aren't bad either. Much better than anything in eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“How a development minister came to lead such initiatives is beyond me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Alphonso was the one who nearly brought the depression on us in the first place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We shouldn't act in a way that jeopardizes Gasom. But we should still do *something*”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Sometimes we must destroy our rotten foundations to build something better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I doubt that a single regional power like Rizia had such an impact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Look at us, promoting a planned economy while playing our personal wealth for profit in Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[174]`
Mówca: **Gus Manger**
> "“You make one wrong move, and the whole thing falls apart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[170]`
  - -> `[171]`
  - -> `[123]`

### Węzeł `[175]`
Mówca: **Gus Manger**
> "“We made history with the 1950 and 1953 deals. You might remember that the latter agreement prevented a depression just eight months before the elections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[168]`
  - -> `[169]`
  - -> `[136]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[179]`
Mówca: **Gus Manger**
> "“I hate to brag, but I was the one who opened the gates in Porte Drazon after nearly 32 years of frozen Sordish-Rizia relations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Gus Manger**
> "“Rizia and Sordland were considering a full embargo until Alphonso and I came along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[181]`
Mówca: **Gus Manger**
> "“Ah! I'm flattered, Mr. President. And glad that you made the right choice, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I haven't seen him since the inauguration. He really pulled back from public life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm here because something needs to be done about Narbel's living standards.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Gus Manger**
> "“Can you blame the guy? We went full Dwight Walker on him. At least we didn't resort to corporate assassinations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[185]`
Mówca: **Gus Manger**
> "“Of course. That's going to play a big role in our discussion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[186]`
Mówca: **Gus Manger**
> ""As soon as the IPO kicks in on the Ventrie City Stock Exchange, we'll both be rolling in Ren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[160]`
  - -> `[161]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's play, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Time for Sordland to think outside of the box and break the game.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[189]`
Mówca: **Gus Manger**
> "“Except the Perla exchange in Lespia, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Gus Manger**
> "“Not all of the market economy believers are *capitalist pigs*. Look at me, and how many jobs I've brought to this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[191]`
Mówca: **Gus Manger**
> "“I don't think so. My job is to bring resources to long-forgotten areas of Sordland and keep our rural areas vitalized.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Gus Manger**
> "“What I do during my personal time doesn't affect that. If anything, keeping up with market trends will help me benefit our local economies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[193]`
Mówca: **Gus Manger**
> ""Anyway, Mr. President, when it comes to money, we either play the game or the game plays us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[194]`
Mówca: **Gus Manger**
> "“Attract money, invest in the right solutions, increase wealth and living standards. It all trickles down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[195]`
Mówca: **Gus Manger**
> "“Think of history. Leaders who took big leaps were written in the books.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[196]`
Mówca: **Gus Manger**
> "“Well said! The higher you rise, the less you can fall. Why not pick good people up along the way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[197]`
Mówca: **Gus Manger**
> "“Well a quarter of my net wealth is on that stock now. But hey, you've got to play big to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[198]`
Mówca: **Gus Manger**
> "“Here we are! Ewald, my friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[199]`
Mówca: **Gus Manger**
> ""Mr. President, I've been brainstorming a little something. The Gruni Rural Investment Plan. I reckon it's got the potential to breathe new life into our rural communities out in Gruni.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Gus Manger**
> ""We could consider a few things. For starters, we could give the farming business a boost with some subsidies. Or, we could steer towards modernizing existing farms with machinery and tech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[201]`
Mówca: **Gus Manger**
> ""Mr. President, I get the appeal of that GREEN bill that's been making the rounds in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have my doubts, Gus. But I'll give your plan some thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a tough call, Gus. I need to weigh the environmental implications and the economic benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus, I'm intrigued by your vision. I'll seriously consider your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Gus Manger**
> ""I appreciate you hearing me out, Mr. President. I genuinely believe this plan could work wonders for our rural folks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[206]`
Mówca: **Gus Manger**
> ""That's all I'm asking for, Mr. President. Just give this plan a fair shake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[207]`
Mówca: **Gus Manger**
> ""Sure, Mr. President, doubts are part of the game. I trust you'll play the cards right for all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[208]`
Mówca: **Gus Manger**
> ""This Workers' Rights Bill... Look, I'm all for giving hard-working folks what they deserve. But, isn't it a bit hasty to push this while we're still stuck in a recession?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In my book, workers' rights aren't up for negotiation, no matter the economic climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've got to play this smart. We can't risk another economic blow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus, I get what you're saying. But isn't it high time we put people before profits?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Gus Manger**
> ""I see where you're coming from, Mr. President. But a prosperous economy helps everyone - the workers included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[213]`
Mówca: **Gus Manger**
> ""Mr. President, I'm glad you're thinking about the big picture. We've got to strike a balance to protect our economy and our workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[214]`
Mówca: **Gus Manger**
> ""Mr. President, I respect your stance. But let's not forget about the potential fallout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[215]`
Mówca: **Gus Manger**
> ""Or here's another thought - we could pour resources into developing crop breeds tailor-made for Gruni conditions. If it works out, we could roll this out across Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[216]`
Mówca: **Gus Manger**
> ""The way I see it, short-term wins might end up costing us big time in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[210]`
  - -> `[209]`
  - -> `[242]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Our talk was interrupted by a noise coming from outside the building. We looked out the nearest window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[218]`
Mówca: **Gus Manger**
> ""But I'm telling you, if we put the brakes on that and funnel those funds into the Gruni plan instead, we could make some real strides without spooking any potential investors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[204]`
  - -> `[203]`
  - -> `[202]`

### Węzeł `[219]`
Mówca: **Gus Manger**
> ""Spectacle aside… before we sit down with him, there's one more Assembly matter I wanted to raise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[220]`
Mówca: **Narrator**
> "On it was our next appointment, Ewald Alphonso."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[223]`
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An extravagant show of wealth, isn't it? Hardly seems necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That kind of display plays well to investors... but terribly to farmers watching on state TV.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alphonso sure knows how to make an entrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Gus Manger**
> ""The man loves his theatrics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[225]`
Mówca: **Gus Manger**
> ""Exactly. The optics matter. We just have to decide who we’re trying to impress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[226]`
Mówca: **Gus Manger**
> ""It's Alphonso's style, Mr. President. He's always enjoyed his toys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[227]`
Mówca: **Narrator**
> "A sleek helicopter was cutting through the sky, sunlight glinting off its polished surface as it descended towards us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[228]`
Mówca: **Narrator**
> "He kept talking as he guided me into the Gasom building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_InfrastructureProject_Invest == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I grew up around people like the ones this would help, Gus. If your plan’s solid, I want it to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[236]`
Mówca: **Gus Manger**
> ""Then we’re on the same page, Mr. President. Let’s make sure they feel seen for once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that a helicopter or just his ego with rotor blades?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Gus Manger**
> ""He calls it branding. I call it a fuel bill with sound effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[239]`
Mówca: **Gus Manger**
> ""If we're all sinking, nobody's winning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[240]`
Mówca: **Gus Manger**
> ""Timing and approach are everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[241]`
Mówca: **Gus Manger**
> ""There's got to be a way to improve workers' rights without rocking the economic boat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Heard a worker from Estord on the radio. Said he's got rights on paper, but nothing in his fridge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Gus Manger**
> ""That kind of thing sticks with you. Still, we’ve got to make sure the fixes don’t break something bigger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we overload businesses now, they'll shrink or shut down. Workers lose more than just rights, they lose jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Strong labor protections are the foundation of lasting growth. A secure worker is a productive one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let’s think of the option that signals progress without rattling the markets. We need both stability and reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""People don’t care about long-term strategy when their kids are hungry now. We fix this for them, or we lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[248]`
Mówca: **Gus Manger**
> ""Exactly. We can’t let good intentions gut the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[249]`
Mówca: **Gus Manger**
> ""Fair enough, but let’s roll it out in stages. Rushing it could backfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[250]`
Mówca: **Gus Manger**
> ""That’s the sweet spot. You bring the idealism, I’ll help shape the rollout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[251]`
Mówca: **Gus Manger**
> ""Hard to argue with that. Just make sure we don’t promise more than the treasury can carry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
