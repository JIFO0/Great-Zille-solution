# Sordland/Turn03/EnT_GasomProposal

- **ID konwersacji:** `41`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/041_EnT_GasomProposal.md`
- **Liczba węzłów dialogowych:** 353
- **Liczba wyborów gracza:** 57

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Decision_Turn04_FoundationDonation_SmallSum`
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.GovernmentBudget`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_Gasom_LargeStateInvestment`
- `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_DonatedToFoundation`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.RuralDevelopment_Interest`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits`
- `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages`
- `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`
- `BaseGameSupport.Codex_Organisations_Corporations_Gasom`
- `BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested`
- `BaseGameSupport.Journal_Turn03_AlphonsoFoundation_DonatedSmall`
- `BaseGameSupport.Journal_Turn03_GasomWelfare_EducationHealthHousing`
- `BaseGameSupport.Journal_Turn03_GasomWelfare_MoreBlueSalary`
- `BaseGameSupport.Journal_Turn03_GasomWelfare_NarbelCharity`
- `BaseGameSupport.Journal_Turn03_Gasom_CoInvestRizia`
- `BaseGameSupport.Journal_Turn03_Gasom_LargeSordlandInvest`
- `BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest`
- `BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkepticism`
- `BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPraise`
- `BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique`
- `BaseGameSupport.News_Turn03_LT_Gasom_CoInvestmentPotential`
- `BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside`
- `BaseGameSupport.News_Turn03_LT_Gasom_SordlandInvestmentPositive`
- `BaseGameSupport.News_Turn03_LT_PresidentAFDonation`
- `BaseGameSupport.News_Turn03_R_Gasom_LargeInvestmentCritique`
- `BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique`
- `BaseGameSupport.News_Turn03_R_PresidentAFDonation`
- `BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique`
- `BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise`
- `BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCritique`
- `BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPraise`
- `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique`
- `BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise`
- `BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership`

### Skoki między-konwersacyjne:
- Węzeł `[24]` -> **[42] Sordland/Turn03/Gus Intro Talk** (../Turn_03/042_Gus_Intro_Talk.md), Węzeł `[1]`
- Węzeł `[36]` -> **[43] Sordland/Turn03/Ewald Alphonso Debate** (../Turn_03/043_Ewald_Alphonso_Debate.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 44

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.GovernmentBudget`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_Gasom_LargeStateInvestment`
- `BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_DonatedToFoundation`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[55]` (Ewald Alphonso): `Variable["BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership"] = true;`
- Węzeł `[56]` (Ewald Alphonso): `Variable["BaseGame.Relations_Ewald_Friendly"] = true;`
- Węzeł `[57]` (Ewald Alphonso): `Variable["BaseGame.Relations_Ewald_Neutral"] = true;`
- Węzeł `[58]` (Ewald Alphonso): `Variable["BaseGame.Relations_Ewald_Discontent"] = true;`
- Węzeł `[88]` (Ewald Alphonso): `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] = true; Variable["BaseGame.Pol...`
- Węzeł `[89]` (Ewald Alphonso): `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] = true; Variable["BaseGame.Policy_Economy...`
- Węzeł `[90]` (Ewald Alphonso): `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] = true; Variable["BaseGameSupport.Journ...`
- Węzeł `[142]` (Ewald Alphonso): `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] = true; Variable["BaseGameSupport.Jou...`
- *...oraz 36 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Ewald Alphonso)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Meanwhile, Gus Manger had invited me to visit the Gasom headquarters in Narbel. It was situated in Ornobel, a neighborhood on the city outskirts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Next to it was the Damenoy gas reserve, a prominent natural gas source consisting of four large fields."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The roads were bumpy and marked by potholes, while the buildings surrounded us appeared run-down and dilapidated. The community had apparently endured a prolonged period of neglect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "We came to a halt at the entrance gates of the facility. A sizeable mural depicting the Gasom logo had been painted on a nearby wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[7]`
Mówca: **Narrator**
> "After a series of intense meetings with Ciara and Paskal, I decided to take some much-needed time to recharge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[10]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[11]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[13]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They were working hard to unite democratically leaning reformers for the crucial task of drafting a new constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They had devoted themselves to the challenging task of uniting pro-centralization factions behind the drafting of a new constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They were engaged in intense negotiations with the Old Guard in order to address their pressing national security concerns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I checked in with Lucian and Petr back at the capital. They were working tirelessly, exploring all possibilities and avenues to advance the constitutional reform draft."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Ewald Alphonso stood up from his chair. He had on a perfectly tailored suit that he wore as casually as pajamas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Ewald Alphonso**
> "“Gus, you old devil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Adjacent to the mural, a group of individuals wearing blue work vests had assembled, holding what looked like protest signs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[24]`
Mówca: **Gus Manger**
> ""Good day, President Rayne. Welcome to Gasom's Narbel operations!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `42` (*Sordland/Turn03/Gus Intro Talk*), Węzeł `[1]`

### Węzeł `[25]`
Mówca: **Gus Manger**
> "“It takes one to know one. As promised, I've brought our guest of honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Ewald Alphonso**
> "“President Rayne. I hope you enjoyed seeing our facilities here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`
  - -> `[346]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“President Alphonso. It's nice to see what you have built from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The facilities appear to be in much better shape than the city around them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Greetings. I'm curious to find out more about where Gasom stands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Ewald Alphonso**
> "“It's fine. Nothing compared to the Gasom HQ in Holsord, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Ewald Alphonso**
> ""You should have seen Narbel before Gasom came here. The jobs it generated have had a lasting positive effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
Mówca: **Ewald Alphonso**
> ""The same sentiment applies to the government's stance on our energy policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“Still one of the standouts of the Maroon District.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Gus Manger**
> ""It's true. Things here could be a lot worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Gus Manger**
> "“Plenty of discussions we can have. We have the two new faces of Sordland in one room. The old man is nowhere to be seen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Narrator**
> "We sat down. Some snacks and drinks were served. Multiple Gasom yearly financial reports were scattered on the table between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `43` (*Sordland/Turn03/Ewald Alphonso Debate*), Węzeł `[1]`

### Węzeł `[37]`
Mówca: **Ewald Alphonso**
> "“Please have a seat. Let's talk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[38]`
Mówca: **Ewald Alphonso**
> "“If we raise a minority investment, it would allow us to invest in further resource excavations in the gas fields, and turn the company back to significant profitability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Ewald Alphonso**
> "“By significant, I mean that our projections show that we would be able to cover eighty percent of Sordland's gas needs in three years, and we would achieve profits four times the value of our investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we are to invest in Gasom, I want to make sure that the company is also committed to improving the socio-economic conditions in Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your projections sound impressive. However, we need to consider the international market as well. How do we plan to compete against nations like Anraka, Arcasia, United Contana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""I understand your concern. The risk is indeed there, but our experienced team of geologists and engineers have identified promising fields.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[43]`
Mówca: **Gus Manger**
> ""Ewald's got a point, Mr. President. Sure, there's some risk, but look at the upside -- Sordland could be energy resilient. I reckon that's a gamble worth taking, especially in these tough economic times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Ewald walked back over to the window. He stood there, silhouetted against the vast expanse of the gas fields."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[45]`
Mówca: **Ewald Alphonso**
> ""I wholeheartedly agree. The well-being of Narbel's citizens is a priority for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An enticing proposition. However, I would like to know more about the risks involved. What if the excavations do not yield the expected results?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[47]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[49]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[53]`
Mówca: **Ewald Alphonso**
> ""Your attitude and choices as President has prompted me to reflect on the significant gap that exists between us. Regrettably, this divide could pose challenges to the feasibility of any prospective business collaboration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[190]`
  - -> `[188]`
  - -> `[189]`

### Węzeł `[54]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I believe we have the potential for a mutually beneficial partnership. However, we need to align our objectives and expectations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[55]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Ribel_NewBFFLeadership"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[56]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Friendly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Ewald_Friendly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[57]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Neutral = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Ewald_Neutral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[58]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Ewald_Discontent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[59]`
Mówca: **Ewald Alphonso**
> ""We've got a strong strategy in place. Our competitive edge lies in the quality and efficiency of our production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Ewald Alphonso**
> ""The odds are in our favor. And let's not forget the potential rewards are substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[61]`
Mówca: **Ewald Alphonso**
> ""With this investment, we could certainly allocate some funds to improve the local infrastructure and create more jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Ewald Alphonso**
> ""With this investment, we can further enhance our technologies and stay ahead of the competition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> ""Mr. President, I've been thinking -- what if we tie Gasom's growth to Narbel's development? Get the company to invest in the community, you know? That way, everybody wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Gus Manger**
> ""Ewald and his team have been doing a hell of a job. Give them the right backing, and I reckon Gasom could give the big boys a run for their money. We just need to have a little faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromotePlanned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""Mr. President, your administration's focus on a planned economy resonates with our strategic vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Ewald Alphonso**
> ""Mr. President, your administration's commitment to a market economy aligns with our vision for a competitive corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Ewald Alphonso**
> ""A government investment in our company aligns perfectly with this approach. It's about strengthening Sordland's economy and becoming self-sufficient in energy production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[72]`
  - -> `[73]`
  - -> `[251]`

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> ""With a government investment, we can further liberalize the energy market, enhance our technologies, and compete globally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[74]`
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Kingdom of Rizia's investment would reduce the risk for us. However, we need to carefully consider the implications of sharing control with a foreign entity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm heavily interested in the idea of Gasom investing in Narbel's development. But we need concrete actions, not just words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see the potential for us to drive Sordland's energy independence. But we need to make sure this is a sustainable solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Ewald Alphonso**
> ""You bring up a valid point. We're dedicated to responsible resource extraction and have allocated a portion of the proposed investment for environmental mitigation measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Ewald Alphonso**
> ""The partnership with Rizia is indeed a new venture for us, as a company, Anton. However, they have a vested interest in a stable gas supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Ewald Alphonso**
> ""You're right to demand specifics. With this investment, we aim to improve the living conditions in Narbel by creating more jobs, providing better housing for our workers, and initiating educational programs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Ewald Alphonso**
> ""Sustainability is a key part of our strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Ewald Alphonso**
> ""Our agreement would be focused on operations and profits, but not policy – Gasom would remain under Sordish control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Ewald Alphonso**
> ""Gasom is as committed to Narbel as it is to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Gus Manger**
> ""Couldn't agree more, Mr. President. We've got to keep the big picture in mind, and that includes our environment. I trust Ewald and his team to handle this responsibly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[82]`
Mówca: **Gus Manger**
> ""Mr. President, I know the Rizians want the same thing we do. And the more energy partners we have, the better off we'll be. Plus, we'll keep the reins on Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[83]`
Mówca: **Gus Manger**
> ""It's about time Narbel got a leg up. Ewald's plan sounds solid to me. More jobs, better living conditions – that's a step in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We'll co-invest with Rizia. We'll share the costs and stakes." [-1 Government Budget]"]** — Mówca: **Player**
> ""We'll co-invest with Rizia. We'll share the costs and stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""We won't invest at this time. Let the Kingdom and other foreign investors contribute.""]** — Mówca: **Player**
> ""We won't invest at this time. Let the Kingdom and other foreign investors contribute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We're investing alone. Sordland will provide the majority of funds, and Gus will tell Rizia to back off." [-2 Government Budget]"]** — Mówca: **Player**
> ""We're investing alone. Sordland will provide the majority of funds, and Gus will tell Rizia to back off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Narrator**
> "After a moment, he turned back to face us. His gaze was steady, the expectation clear in his eyes. The time had come to make a decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[88]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone = true; 
BaseGame.Policy_Economy_Gasom_LargeStateInvestment = true;
BaseGameSupport.Journal_Turn03_Gasom_LargeSordlandInvest = true;
BaseGame.GovernmentBudget -= 2; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 3;
BaseGame.Public_Opinion += 1;
BaseGame.EconomyDirection_Scale -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] = true;
Variable["BaseGame.Policy_Economy_Gasom_LargeStateInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_LargeSordlandInvest"] = true;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 3;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[89]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia = true;
BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment = true; BaseGameSupport.Journal_Turn03_Gasom_CoInvestRizia = true;
BaseGame.GovernmentBudget -= 1; 
BaseGame.EconomyDirection_Scale -= 1;
BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] = true;
Variable["BaseGame.Policy_Economy_Gasom_StateRiziaCoInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_CoInvestRizia"] = true;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 1;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[90]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment = true; BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest = true; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 2;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[91]`
Mówca: **Gus Manger**
> ""Before we dive into the celebrations, I've allocated time during this meeting for President Rayne to discuss any concerns regarding Gasom's treatment of its workers and its effects on Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[92]`
Mówca: **Ewald Alphonso**
> ""Your decision shows a commitment to Sordland's energy independence. We won't let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Ewald Alphonso**
> ""A joint investment? A wise choice. It ensures steady funds for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Ewald Alphonso**
> ""I understand your reservations. We'll continue to serve Sordland's energy needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Gus Manger**
> ""That's a bold move, Mr. President. But I reckon it's the right one. Gasom's success will be Sordland's success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[96]`
Mówca: **Gus Manger**
> ""I like the way you think, Mr. President. Sharing the costs with Rizia reduces our risk and strengthens our ties. It's a smart move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[97]`
Mówca: **Gus Manger**
> ""Well, Mr. President, you've always been one to play it safe. I guess we'll just have to make do and see how things turn out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The wages of Gasom blue-collar workers need to be increased. They are the backbone of your operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I expect Gasom to contribute significantly to local charities, to aid in the city's recovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The workers of Gasom need better housing, access to healthcare, and opportunities for education. As the leading industry there, Gasom can't ignore its responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've covered a lot today. I believe we can wrap up the meeting now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[102]`
Mówca: **Ewald Alphonso**
> ""President Rayne, I appreciate your concerns about Narbel. Rest assured, we are constantly evaluating our impact on the community and are looking for ways to improve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> ""Mr. President, while I acknowledge your concerns, Gasom's primary responsibility is to its shareholders and the economic stability of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[104]`
Mówca: **Ewald Alphonso**
> ""A good point. I see the potential for Gasom to play a larger role in supporting our workers and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[105]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[107]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[110]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[111]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[113]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[116]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[117]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[119]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
Mówca: **Gus Manger**
> ""It's been a long day. We've got a lot to think about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
Mówca: **Ewald Alphonso**
> ""President Rayne, the welfare of our workers is certainly important. We'll continue to review their conditions and remuneration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[125]`
Mówca: **Ewald Alphonso**
> ""Mr. President, while I understand your concerns, we must consider the financial implications of such actions. I cannot really promise you anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[126]`
Mówca: **Ewald Alphonso**
> ""I fully agree that we must do more for our workers. Their welfare is a priority for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> ""President Rayne, I understand the role Gasom could play in supporting local charities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""Mr. President, Gasom already contributes significantly to Sordland's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[129]`
Mówca: **Gus Manger**
> ""Well, this is promising. Ewald's commitment to these initiatives should alleviate some of our concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[130]`
Mówca: **Gus Manger**
> ""Gentlemen, it's clear that we all share the goal of improving the situation in Narbel. Let's continue working together to make that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[131]`
Mówca: **Gus Manger**
> ""We're all in agreement that we should do more for the local community. Let's move forward with that in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[132]`
Mówca: **Ewald Alphonso**
> ""I will personally oversee initiatives to provide private housing, health, and education support for our blue-collar workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Ewald Alphonso**
> ""I will personally ensure that we review their salaries and work towards providing them with competitive compensation immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> ""I share your concerns about Narbel. Gasom is committed to implementing sustainable practices that will lessen our impact on the environment and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[135]`
Mówca: **Ewald Alphonso**
> ""Personally, I am committed to supporting local charities to enhance our community engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's reassuring to hear. I trust that you'll follow through on these commitments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are significant steps. I look forward to seeing these changes implemented swiftly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Agreed, Gus. Mr. Alphonso, we expect to see tangible improvements in this city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gus, all the talk in the world won't change the situation in Narbel. We need concrete action from Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[140]`
Mówca: **Gus Manger**
> ""Ewald, your personal commitment to these initiatives speaks volumes. This could be a turning point for Gasom and for Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Suddenly, the meeting was interrupted. The quiet murmur of a conversation from outside the room grew louder, followed by the sound of hurried footsteps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[142]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation = true; BaseGameSupport.Journal_Turn03_GasomWelfare_NarbelCharity = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] = true;
Variable["BaseGameSupport.Journal_Turn03_GasomWelfare_NarbelCharity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[143]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages = true; BaseGameSupport.Journal_Turn03_GasomWelfare_MoreBlueSalary = true;
BaseGame.RuralDevelopment_Interest += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] = true;
Variable["BaseGameSupport.Journal_Turn03_GasomWelfare_MoreBlueSalary"] = true;
Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits = true; BaseGameSupport.Journal_Turn03_GasomWelfare_EducationHealthHousing = true;
BaseGame.RuralDevelopment_Interest += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] = true;
Variable["BaseGameSupport.Journal_Turn03_GasomWelfare_EducationHealthHousing"] = true;
Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[145]`
Mówca: **Ewald Alphonso**
> ""Gentlemen, it seems we have an unexpected situation outside. Some protestors from the Labor Union have blocked the main vehicular exits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[146]`
Mówca: **Ewald Alphonso**
> ""We are not blind to the socio-economic conditions here. We're deeply invested in this community and are committed to doing our part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[147]`
Mówca: **Ewald Alphonso**
> ""It's a challenging task to balance the needs of our shareholders with our responsibilities. I cannot promise you anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[148]`
Mówca: **Ewald Alphonso**
> ""We understand the importance of fair compensation. Discussions are ongoing on how to best support our hardworking employees. That is all I can say for the time being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Ewald Alphonso**
> ""We must indeed be mindful of the economic realities. We are striving to make decisions that are financially sound and sustainable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Gus Manger**
> ""Both of you make good points. It's a fine line between fulfilling our responsibilities and ensuring economic stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Ewald Alphonso**
> ""Donating more is an interesting idea. It's something we will consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[152]`
Mówca: **Ewald Alphonso**
> ""Our contributions to Sordland's economy are substantial. Our focus must remain on maintaining that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Indeed Gus, we have to ensure that we don't jeopardize the economic stability of Sordland. But we also can't ignore the plight of Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a fine line indeed. But that doesn't absolve us, or Gasom, of our responsibilities towards the people of Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's true. And I hope that Gasom is ready to make some significant changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're all in agreement, Gus. Now it's time to turn that agreement into action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[157]`
Mówca: **Ewald Alphonso**
> ""Well, Mr. President, we're committed to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[158]`
Mówca: **Ewald Alphonso**
> ""We understand the need for action, Mr. President, but also--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[159]`
Mówca: **Ewald Alphonso**
> ""As I mentioned before, we're always considering how we can--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[160]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I assure you that Gasom takes its responsibilities--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[161]`
Mówca: **Ewald Alphonso**
> ""I understand, Anton. At Gasom, we are committed to reducing harm and contributing to the--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[162]`
Mówca: **Ewald Alphonso**
> ""I agree, it's time for us to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[163]`
Mówca: **Gus Manger**
> ""We are all on the same page here. Let's not lose sight of that as we move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm relieved to hear that. A fair wage is the least we can provide for the hardworking people of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Promises are a start, Ewald. But the people need actions, not words. I look forward to seeing concrete changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Gus Manger**
> ""Ewald, your personal commitment to these initiatives speaks volumes. This could be a turning point for Gasom and for Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[167]`
Mówca: **Gus Manger**
> ""This is still promising. Ewald's commitment to these initiatives should alleviate some of our concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We need to do more than reduce harm. Our goal should be a better Narbel, not just a less bad one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Charitable donations are commendable. But we must address the source of the harm, not just mitigate its effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Gus Manger**
> ""I couldn't agree more. It's high time we took our responsibilities to Narbel seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Ewald Alphonso**
> ""Of course, we are fully committed to ensuring our operations are-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[172]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[174]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 3))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[177]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true || BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true) && BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint >= 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true)  and  Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[178]`
Mówca: **Narrator**
> "He approached Alphonso and leaned in to whisper something in his ear. Ewald nodded solemnly, his gaze meeting mine with a serious intensity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[179]`
Mówca: **Gus Manger**
> ""Well, that's a pickle. What's our move, Ewald?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Ewald Alphonso**
> ""I have a helicopter ready. We can leave undetected and avoid the chaos and potential danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`
  - -> `[263]`

### Węzeł `[181]`
Mówca: **Serge Wolkner**
> ""Mr. President, I have discussed the situation with the Presidential Guard and the police security. They are advising us not to go out the way we came in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Serge Wolkner rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[183]`
Mówca: **Narrator**
> "Ewald looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[184]`
Mówca: **Serge Wolkner**
> ""You must make a decision, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[185]`
Mówca: **Narrator**
> "As our motorcade made its way through the Ornobel district, I noted the neighborhood's state of disrepair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Serge skillfully parked the car, bringing our journey to a smooth and elegant conclusion. Gus greeted us warmly as we stepped out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[187]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.RuralDevelopment_Interest += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a shame. I still believe there's potential for us to work together in some capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand, Mr. Alphonso. It's important that we each stay true to our principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps it's for the best, Mr. Alphonso. Your approach to business doesn't align with my vision for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""We each have our roles to play for Sordland. Let us each do what we believe is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""I appreciate your optimism, Mr. President. While this particular deal may not have worked out, I remain open to future collaborations that could benefit both our interests and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. Our principles are what guide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[194]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[197]`
Mówca: **Ewald Alphonso**
> ""As a further gesture of goodwill, would you consider making a personal donation to the Alphonso Foundation? It's a cause close to my heart, focusing on providing shelter for the homeless in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[198]`

### Węzeł `[198]`
**[WYBÓR GRACZA: ""Gentlemen, after careful consideration, I've decided to step away from this deal." [No Deal Path]"]** — Mówca: **Player**
> ""Gentlemen, after careful consideration, I've decided to step away from this deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Alright, let's proceed with the deal. The EPA restrictions will remain as they are, and I'll personally contribute to your cause for the homeless." [Deal Path, -1 Personal Wealth]"]** — Mówca: **Player**
> ""Alright, let's proceed with the deal. The EPA restrictions will remain as they are, and I'll personally contribute to your cause for the homeless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1;
BaseGame.Relations_Ewald_DonatedToFoundation = true;
BaseGame.Relations_Ewald_PromiseNotHarsherEPA = true;
BaseGame.Decision_Turn04_FoundationDonation_SmallSum = true;
BaseGameSupport.Journal_Turn03_AlphonsoFoundation_DonatedSmall = true;
BaseGameSupport.News_Turn03_LT_PresidentAFDonation = true;
BaseGameSupport.News_Turn03_R_PresidentAFDonation = true;
BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] = true;
Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] = true;
Variable["BaseGame.Decision_Turn04_FoundationDonation_SmallSum"] = true;
Variable["BaseGameSupport.Journal_Turn03_AlphonsoFoundation_DonatedSmall"] = true;
Variable["BaseGameSupport.News_Turn03_LT_PresidentAFDonation"] = true;
Variable["BaseGameSupport.News_Turn03_R_PresidentAFDonation"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[201]`
Mówca: **Ewald Alphonso**
> ""If they don't point us in the same direction, then it's best we part ways here. I wish you all the best in your endeavors for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[202]`
Mówca: **Gus Manger**
> ""Hold on, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Gus Manger**
> ""You're right, Mr. President. There's always potential for collaboration. Let's not close the door just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Gus Manger**
> ""Wait. Gentlemen, let's not let a single disagreement define our relationship. There's a bigger picture here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Gus Manger**
> ""I understand that tensions are high right now. But I have faith that we can find a solution that benefits everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Gus Manger**
> ""However, for that to happen, I need to know: Mr. President, do you trust my judgement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`
  - -> `[207]`
  - -> `[348]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Gus, I respect you, but I can't trust your judgement in this matter. You seem to have a fundamental bias on this." [Reject Deal]"]** — Mówca: **Player**
> ""Gus, I respect you, but I can't trust your judgement in this matter. You seem to have a fundamental bias on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I trust your advice. You've proven yourself a reliable ally and I believe we can find a way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your judgement has been questionable at times. But I'm willing to hear you out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Gus Manger**
> ""Thank you, Mr. President. I propose a compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Gus Manger**
> ""If you promise not to tighten the current restrictions of the Energy Protection Act, we can reconsider our stance and keep the deal on the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I'm giving you a chance to prove your commitment to the people of Sordland and to our shared future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""I hope you'll consider our offer carefully. This could be the beginning of a fruitful partnership, or the end of a potential alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[214]`
Mówca: **Gus Manger**
> ""Fair enough, Mr. President. I gave it my all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""We both tried, it seems. Still, I appreciate the discussion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""Well, Mr. President? Will Gasom and Sordland make history or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne, the foundation for a robust partnership is right here. It's high time we shift our focus towards sealing this deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""You've made a compelling case. Let's get this deal on the road. I can assure you that the EPA restrictions won't get any stricter." [Deal Path]"]** — Mówca: **Player**
> ""You've made a compelling case. Let's get this deal on the road. I can assure you that the EPA restrictions won't get any stricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA = true;
BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Gus Manger**
> ""I'm glad you're on board, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[84]`

### Węzeł `[223]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[224]`
Mówca: **Ewald Alphonso**
> ""If the Sordish government chooses to invest, it would gain a voice in the broader company decisions, even as a minority stakeholder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Ewald Alphonso**
> ""The government could either liquidate its shares at a future date or continue to reap the long-term profits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Gus Manger**
> ""A beneficial arrangement for all parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[227]`
Mówca: **Ewald Alphonso**
> ""Excellent, Mr. President! Your support for the homeless cause is commendable. Together, we will ensure a promising future for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[228]`
Mówca: **Ewald Alphonso**
> ""Mr. President, your assurances on the EPA front are much appreciated. This partnership is going to bring great benefits for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[229]`
Mówca: **Gus Manger**
> ""You know, Mr. President, if we can get the government in on this, it's a win-win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Gus Manger**
> ""Not only does Gasom continue to operate and grow, but it also strengthens the state's energy security and economic power. We just need a little risk appetite, that's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""Are you ready, Mr. President, to take on the risks that come with ensuring one of Sordland's most valuable energy companies continues to operate and grow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Ewald Alphonso**
> ""Are you ready to make your government stronger?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[235]`
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't you think there's a way we can ensure Gasom's growth without putting the government at risk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What kind of assurances can you provide that this will pay off in the long term, President Alphonso?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm all for taking calculated risks. But we need to be sure that the benefits outweigh the potential losses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, are you suggesting that we should risk the treasury of Sordland for the growth of a single company?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Ewald Alphonso**
> ""Not at all, Mr. President. I'm suggesting that supporting Gasom's growth could significantly contribute to Sordland's overall economic stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[238]`
Mówca: **Ewald Alphonso**
> ""Of course, Mr. President. I wouldn't propose a strategy that I didn't believe would be beneficial for both Gasom and Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Ewald Alphonso**
> ""Gus, would you like to answer that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[240]`
Mówca: **Ewald Alphonso**
> ""Mr. President, in business, there are no guarantees. But I can assure you that we at Gasom are committed to doing everything in our power to ensure this deal pays off for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[241]`
Mówca: **Gus Manger**
> ""Ewald is right. We're not talking about risking the economy. We're discussing an investment that has the potential to pay significant dividends for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[242]`
Mówca: **Gus Manger**
> ""As someone who's been in the energy business for decades, I can tell you that this deal is solid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[243]`
Mówca: **Gus Manger**
> ""Absolutely. I believe that by working together with Rizia, we can find a shared investment solution that promotes Gasom's growth while minimizing any potential risk to the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Gus Manger**
> ""I can't give you a guarantee. But I can tell you that I trust President Alphonso, and I believe in this deal. Sometimes, you have to take a leap of faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[245]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.RuralDevelopment_Interest += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[246]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.RuralDevelopment_Interest += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[247]`
Mówca: **Ewald Alphonso**
> ""Mr. President, have you ever considered that the future of Sordland might rest not on avoiding risks, but about embracing them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your point. However, the stakes are too high for us to gamble on uncertainty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have. And I believe that embracing uncertainty is a part of leadership. We must be bold in our decisions for the future of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[250]`
Mówca: **Ewald Alphonso**
> ""That our greatest potential might lie not in the safety of what we know, but in the uncertainty of what we might discover?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[249]`
  - -> `[248]`
  - -> `[330]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Liberalizing the energy market merely serves the interests of the wealthy elites. What we need is a comprehensive nationalization of the energy sector to ensure it serves the people, not profit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Ewald Alphonso**
> ""While I respect your perspective, Mr. President, I firmly believe that the power of the free market, coupled with appropriate regulation, can drive both progress and equity. It's not an 'us versus them' situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Gus Manger**
> ""We must also consider the economic realities and global competitiveness. A balance between public ownership and market forces could be the key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A thriving market economy is the engine of prosperity and innovation. I believe in Gasom's potential to compete and succeed under these principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""I'm glad we see eye to eye on this. With your support, I am confident that Gasom will be able to chart a prosperous future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Gus Manger**
> ""Your words are reassuring, Mr. President. Let's harness the power of the free market to elevate Gasom and, in turn, the entire Sordish economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[257]`
Mówca: **Gus Manger**
> ""I understand, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""It's unfortunate we couldn't bridge our differences. Nonetheless, we respect your stance and value the time spent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[259]`
Mówca: **Ewald Alphonso**
> ""Ready to make history together? Set our differences aside and work together for the energy independence of our nation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[198]`

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""Katarina Horten and Denis Stahler seem to be leading the group. It would be difficult to leave the way we came without causing trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A helicopter might be the safer option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think we should face the crowd head-on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is there no other way out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[264]`
Mówca: **Gus Manger**
> ""Mr. President, I advise you to leave via helicopter just in case. I can stay back and update the crowd on the discussions today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""I will give the order to ready it. We can fly to the Blue Mansion in Lachaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[266]`
Mówca: **Ewald Alphonso**
> ""That is your prerogative, Mr. President. Following the violent events of late, I heavily recommend against facing any crowd.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[267]`
Mówca: **Ewald Alphonso**
> ""Trust me, I know this place well. The only other way out is through a dangerous hilly terrain or the sewers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[268]`
Mówca: **Serge Wolkner**
> ""More police are on the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Everyone waited. The tense silence of the room stood in stark contrast to the buzz of the ever-growing crowd outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[271]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: PlayMusic("Reflection");)*
- **Efekt (`userScript`):** `PlayMusic("Reflection");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[272]`
Mówca: **Gus Manger**
> ""Amazing! I knew you two could make it work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[273]`
Mówca: **Gus Manger**
> ""Before we conclude, Ewald, I've set aside time during this meeting for President Rayne to discuss concerns about Gasom's treatment of workers and its repercussions on Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Alphonso nodded and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`
  - -> `[338]`
  - -> `[101]`
  - -> `[341]`

### Węzeł `[275]`
Mówca: **Ewald Alphonso**
> ""Do you have a proposal in mind, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[98]`
  - -> `[99]`
  - -> `[101]`

### Węzeł `[276]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[277]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique = true;
BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside = true;
BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside"] = true;
Variable["BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[278]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkepticism = true;
BaseGameSupport.News_Turn03_LT_Gasom_CoInvestmentPotential = true;
BaseGameSupport.Codex_Organisations_Corporations_Gasom = false;
BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_CoInvestmentSkepticism"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_CoInvestmentPotential"] = true;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[279]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPraise = true; BaseGameSupport.News_Turn03_LT_Gasom_SordlandInvestmentPositive = true;
BaseGameSupport.News_Turn03_R_Gasom_LargeInvestmentCritique = true;
BaseGameSupport.Codex_Organisations_Corporations_Gasom = false;
BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_LargeInvestmentPraise"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_SordlandInvestmentPositive"] = true;
Variable["BaseGameSupport.News_Turn03_R_Gasom_LargeInvestmentCritique"] = true;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_Gasom_Invested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[280]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique = true;
BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside = true;
BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Gasom_RiziaInvestmentCritique"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_NoInvestmentDownside"] = true;
Variable["BaseGameSupport.News_Turn03_R_Gasom_NoInvestmentCritique"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment = true; BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest = true; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1;
BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] = true;
Variable["BaseGameSupport.Journal_Turn03_Gasom_RiziaAloneInvest"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[282]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[285]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique = true;
BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[286]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[291]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[292]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique = true;
BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentCritique"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[293]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_CoInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[294]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[295]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCritique = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentCritique"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[296]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPraise = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_LargeInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[297]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique = true;
BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentCritique"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[301]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Gasom_NoInvestmentPraise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[302]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[306]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[307]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[310]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[315]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[316]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: SetRichPresence("Visiting a large gas company to discuss a potential deal", "Ornobel District", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Visiting a large gas company to discuss a potential deal","Ornobel District","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[317]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: SetRichPresence("Heavily investing to enrich a critical energy company", "Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Heavily investing to enrich a critical energy company","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[318]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: SetRichPresence("Co-investing with a kingdom to fund a critical energy company", "Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Co-investing with a kingdom to fund a critical energy company","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[319]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: SetRichPresence("Letting another nation buy a critical energy company", "Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Letting another nation buy a critical energy company","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[320]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: SetRichPresence("Securing better conditions for the workers of big gas", "Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Securing better conditions for the workers of big gas","Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[321]`
Mówca: **Ewald Alphonso**
> ""I appreciate your visit today, and despite our differences, your willingness to meet with me is noted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Ewald Alphonso**
> ""Throughout my journey, I've held faith in collaborating with individuals who genuinely share my vision. The presence of the right allies amplifies our potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[323]`
Mówca: **Gus Manger**
> ""I'll leverage my Rizian contacts to finalize the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Ewald Alphonso**
> ""Our allies in the Golden Kingdom will step in where Sordland couldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[325]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not here for your approval, Alphonso. My priority is Gus and, more importantly, the workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Ewald Alphonso**
> ""That sounds eerily like what Mr. Soll would say when things didn't go his way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Gus Manger**
> ""Let's not get heated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must make decisions based on what is best for Sordland in the present moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Running the state is not like running your company Alphonso. You out of all people should know this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Ewald Alphonso**
*(Węzeł logiki narracyjnej: BaseGame.RuralDevelopment_Interest -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.RuralDevelopment_Interest"] = Variable["BaseGame.RuralDevelopment_Interest"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[333]`
Mówca: **Gus Manger**
> ""The Labor Union and the Communist Party of Sordland have garnered significant support, capitalizing on the anxieties of the many Gasom workers concerned about their job security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[334]`
Mówca: **Gus Manger**
> ""The worried workers will have no fears about job security thanks to this state intervention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[335]`
Mówca: **Gus Manger**
> ""The Labor Union, along with the Communist Party of Sordland, has rallied substantial support from Gasom workers in Narbel, advocating for improved local conditions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We need to address these concerns; they could jeopardize the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our duty is to listen and take action. That's the mandate granted to us by the public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom stands as a global energy powerhouse. It's only right they give back somewhat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[339]`
Mówca: **Ewald Alphonso**
> ""Together, we might discover solutions beneficial to both parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[340]`
Mówca: **Ewald Alphonso**
> ""Very well, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've wasted enough time to this. Time to depart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""It's regrettable you feel this way, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""While sometimes people may not always recognize what's in their best interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[344]`
Mówca: **Ewald Alphonso**
> ""Let's mull it over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[345]`
Mówca: **Narrator**
> "A member of the private security team entered the room, his face taut with urgency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look, gentlemen. My time is valuable, so let’s cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Ewald Alphonso**
> ""Blunt. Must be the new way of doing things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don’t forget, the state stands above you all. Nothing may happen today, or next week, but the future is never certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Ewald Alphonso**
> ""I have served Sordland all my life. It’s the people who voted for me, just like they did for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Gus Manger**
> ""We’re all civil servants here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Ewald Alphonso**
> ""I think it's time to call Mr. Montoro, Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[352]`
Mówca: **Gus Manger**
> ""Thank you for making the trip and setting aside the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
