# Sordland/Turn07/FPnT_DiplomacyOverview2AndTradeDeal

- **ID konwersacji:** `93`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/093_FPnT_DiplomacyOverview2AndTradeDeal.md`
- **Liczba węzłów dialogowych:** 362
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Economy`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGame.Turn06_InT_OnTime`
- `BaseGame.Turn06_PSnW_Healthcare_Hospitals`
- `BaseGame.Turn06_PSnW_Healthcare_ImproveRural`
- `BaseGame.Turn06_PSnW_Healthcare_Salary`
- `BaseGame.Wehlen_TradeDeal`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.TradeDeal_Negotiation_Lespia`
- `BaseGame.TradeDeal_Negotiation_Valgsland`
- `BaseGameSupport.Journal_Turn07_Negotiation_Lespia`
- `BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgsland`
- `BaseGameSupport.Journal_Turn07_Negotiation_None`
- `BaseGameSupport.Journal_Turn07_Negotiation_Valgsland`
- `BaseGameSupport.News_Turn07_G_RayneWillVisitBoth`
- `BaseGameSupport.News_Turn07_G_RayneWillVisitLespia`
- `BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland`
- `BaseGameSupport.News_Turn07_HP_Polio`
- `BaseGameSupport.News_Turn07_LT_Polio`
- `BaseGameSupport.Report_Turn07_Arvory_H3Result`
- `BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease`
- `BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport`
- `BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorkers`
- `BaseGameSupport.Report_Turn07_Holsord_CurrencyLosesValue`
- `BaseGameSupport.Report_Turn07_Lachaven_L1Result`
- `BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreased`
- `BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced`
- `BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncreased`
- `BaseGameSupport.Report_Turn07_Sarna_IncreasedAgriculturalProduction`
- `BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt`
- `GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 35

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[256]` (Deivid Wisci): `Variable["GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal"] = true;`
- Węzeł `[265]` (Deivid Wisci): `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true; Variable["BaseGame.TradeDeal_Negotiatio...`
- Węzeł `[266]` (Deivid Wisci): `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true; ;`
- Węzeł `[267]` (Deivid Wisci): `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] = true; ;`
- Węzeł `[274]` (Deivid Wisci): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- Węzeł `[275]` (Deivid Wisci): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- Węzeł `[285]` (Deivid Wisci): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- Węzeł `[289]` (Deivid Wisci): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- *...oraz 27 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Deivid Wisci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The doors to the White Room, like everything else in the Maroon Palace's main nerve center, were painted white. I took a deep breath before pushing them open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The attendees rose up from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“Now that you are here, let's talk about our diplomatic strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Iosef nodded. He and Lucian sat down, while Deivid remained standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[11]`
Mówca: **Deivid Wisci**
> "“We have successfully passed trade deals with both Wehlen and Agnolia, which means we have increased our presence in those regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Time for yet another meeting. At least this time, it was with people who liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Deivid cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“Mr. President, if I may, I would like to provide you with a short overview of where we are at right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[15]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "Nod and gesture for Deivid to begin."]** — Mówca: **Player_Italic**
> "I nodded and gestured for Deivid to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Go ahead.”"]** — Mówca: **Player**
> "“Go ahead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[17]`
Mówca: **Deivid Wisci**
> "“We decided not to pursue any deals with Wehlen and Agnolia, which means our presence in both regions is lacking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[18]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Although we did not make a trade deal with Agnolia, we succeeded in making one with Wehlen, which means we have increased our presence in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“Although we did not make a trade deal with Wehlen, we succeeded in making one with Agnolia, which means we have increased our presence in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“These deals were important pieces of leverage and significant first steps into the global arena.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Deivid Wisci**
> "“We must now look towards the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“What do you mean by looking towards the future?”"]** — Mówca: **Player**
> "“What do you mean by looking towards the future?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“It's time to take the next steps.”"]** — Mówca: **Player**
> "“It's time to take the next steps.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Precisely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[32]`
Mówca: **Deivid Wisci**
> "“Wehlen and Agnolia were practice runs. We must begin improving our relationship with greater nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[33]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[36]`
Mówca: **Iosef Lancea**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Iosef Lancea**
> "“You know me. I don't trust the 'helping hands' other countries offer us. For a good reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Iosef Lancea**
> "“But I also know when those helping hands are necessary. And right now, we need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Iosef Lancea**
> "“I've said this over and over, but I will repeat it until you get it through your skull: Rumburg will come. Sooner or later. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“And with the current state of our military, if a Rumburg invasion happens, Sordland will cease to exist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“We ought to head General Lancea's advice, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[44]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“We need allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Nonsense. Our country can defend itself just fine without allies.”"]** — Mówca: **Player**
> "“Nonsense. Our country can defend itself just fine without allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Thank you for your input. I will consider it.”"]** — Mówca: **Player**
> "“Thank you for your input. I will consider it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I trust your assessment, Iosef.”"]** — Mówca: **Player**
> "“I trust your assessment, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“Let future generations of Sordish people know I did all I could to protect them. If there *are* any future generations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[48]`
Mówca: **Iosef Lancea**
> "“Thanks to your wise investment, Sordland's army is on its way to becoming a force to be reckoned with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Iosef Lancea**
> "“Whether it be Rumburg or anyone else, we can handle outside threats just fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Iosef Lancea**
> "“We don't need to beg for help from anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[53]`
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“But being friendly won't hurt, right?""]** — Mówca: **Player**
> "“But being friendly won't hurt, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“You are right. I will not let Sordland look weak.”"]** — Mówca: **Player**
> "“You are right. I will not let Sordland look weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Thank you for your input. I will consider it.”"]** — Mówca: **Player**
> "“Thank you for your input. I will consider it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“I agree. There is nothing to be lost by making alliances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Deivid Wisci**
> "“We also need to consider the benefits to our economy such deals will provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Deivid Wisci**
> "“A military perspective is important, but these deals are about more than just gaining allies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy <= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy <= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] <= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[59]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy <= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Deivid Wisci**
> "“We may be close to ending the recession, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Deivid Wisci**
> "“But why not go a step further?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[62]`
Mówca: **Deivid Wisci**
> "“At the start of our term, I had a comprehensive trade deal plan laid out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Deivid sat down, pulled out a few papers and started going through them as he kept talking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[64]`
Mówca: **Deivid Wisci**
> "“We need to elevate our international standing, especially with the threat of Rumburg looming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Iosef cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Especially when we are *still* struggling to end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Deivid took a seat and brought out two stacks of documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Deivid Wisci**
> "“That is it for the overview.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[70]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[73]`
Mówca: **Deivid Wisci**
> "“At the start of our term, I had a comprehensive trade deal plan laid out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Deivid Wisci**
> "“Following the visits to Wehlen and Agnolia, we were to pursue potential trade deals with Lespia and Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Deivid Wisci**
> "“Unfortunately, due to certain events that have since occurred, this course of action is no longer possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Which events exactly?""]** — Mówca: **Player**
> ""Which events exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Good riddance.”"]** — Mówca: **Player**
> "“Good riddance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I did what had to be done.”"]** — Mówca: **Player**
> "“I did what had to be done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[79]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true && BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true && BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  and  Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true && BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  and  Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[82]`
Mówca: **Deivid Wisci**
> "“In Valgsland's case, their intentions on Heljiland have been clear for many years. Our deal with Agnolia regarding the island did not sit well with them,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[83]`
Mówca: **Deivid Wisci**
> "“The alliance with Agnolia itself was also a slap in the face where Valgsland was concerned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
Mówca: **Deivid Wisci**
> "“And this is the result.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Deivid frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[86]`
Mówca: **Iosef Lancea**
> "“Now those commies won't be able to invade Agnolia without facing the might of the Sordish Armed Forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“That's an understatement. The Alliance of Nations has spent years debating the status of Heljiland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[88]`
Mówca: **Iosef Lancea**
> "“It will make them think twice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Deivid Wisci**
> "“True, but as a result, we won't be able to conduct a trade deal, let alone proceed with any diplomatic missions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[171]`

### Węzeł `[90]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> "“That's an understatement. The Alliance of Nations has spent years debating the status of Heljiland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Deivid Wisci**
> "“In Valgsland's case, their intentions on Heljiland have been clear for many years. Our deal with Agnolia regarding the island did not sit well with them,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Deivid Wisci**
> "“As a result, we won't be able to conduct a trade deal let alone proceed with any diplomatic missions at the moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[171]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“Becoming one of the first world leaders to recognise the island as Agnolian was quite the statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“Becoming one of the first world leaders to recognise the island as Agnolian was quite the statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[98]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
Mówca: **Deivid Wisci**
> "“In Valgsland's case, given the country's territorial ambitions, our alliance with Agnolia was rather a slap in the face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Iosef Lancea**
> "“Now those commies won't be able to invade Agnolia without facing the might of the Sordish Armed Forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Iosef Lancea**
> "“It will make them think twice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Deivid Wisci**
> "“True, but as a result, we won't be able to conduct a trade deal let alone proceed with any diplomatic missions at the moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[171]`

### Węzeł `[105]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Deivid Wisci**
> "“I can't discuss Valgsland without bringing up your decree to embargo United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Deivid Wisci**
> "“Blacklisting the superpower leading the CSP was naturally going to anger one of the alliance's most important members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[112]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Deivid Wisci**
> "“As we stand right now, any kind of deal with Valgsland is simply out of the question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“We will not rely on anyone but ourselves.”"]** — Mówca: **Player**
> "“We will not rely on anyone but ourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“You don't seem satisfied with my decision.”"]** — Mówca: **Player**
> "“You don't seem satisfied with my decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Deivid Wisci**
> "“That is because I am not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Deivid looked me up and down before returning to his papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[115]`
Mówca: **Deivid Wisci**
> "“Following the visits to Wehlen and Agnolia, we were to pursue potential trade deals with two greater nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[118]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[121]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[122]`
Mówca: **Deivid Wisci**
> "“Valgsland is one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Deivid Wisci**
> "“If we can manage to get them to the table, there is much more potential here than in Wehlen or Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
Mówca: **Deivid Wisci**
> "“Valgsland is one of them. Or at least *was*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[125]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[127]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`
  - -> `[163]`

### Węzeł `[128]`
Mówca: **Deivid Wisci**
> "“Because they are one of the most important countries in CSP, a deal with Valgsland is a ticket to bring Sordland closer to the United Contanan sphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Deivid Wisci**
> "“Moving on to Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[130]`
Mówca: **Deivid Wisci**
> "“Our southern neighbour is one of the wealthiest countries in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Deivid Wisci**
> "“A trade deal with them would be very beneficial, not just for our economy, but also for our regional and international presence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Deivid Wisci**
> "“Not to mention that they are in the Arcasian sphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“Because we would be following through with our promise to lean westwards, this would also strengthen our voter base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[134]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[136]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`
  - -> `[182]`

### Węzeł `[137]`
Mówca: **Deivid Wisci**
> "“Indeed. This deal could also be the first step in allying ourselves with Lespia or maybe even entering ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`
  - -> `[182]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“It would also strengthen our voter base, since they're expecting us to follow through on our promise to lean eastwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Deivid Wisci**
> "“Indeed. This trade deal could also be the first step in allying ourselves with Valgsland or maybe even entering CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[162]`
  - -> `[163]`

### Węzeł `[140]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[143]`
Mówca: **Deivid Wisci**
> "“Our southern neighbor is rather sore over our embargo of Arcasia, as are all the countries in ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Deivid Wisci**
> "“Another factor is our decision to accept financial aid from United Contana, allowing its ships to dock at our naval base in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Deivid Wisci**
> "“Granting those docking rights essentially gave United Contana a foothold in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Deivid Wisci**
> "“It is no wonder ATO felt threatened by this move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Deivid Wisci**
> "“In any case, a deal won't be happening with Lespia. That is for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`
  - -> `[186]`

### Węzeł `[148]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Deivid Wisci**
> "“Our southern neighbor is rather sore over our decision to accept financial aid from United Contana, allowing its ships to dock at our naval base in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Deivid Wisci**
> "“Granting those docking rights essentially gave United Contana a foothold in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Deivid Wisci**
> "“It is no wonder ATO felt threatened by this move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Deivid Wisci**
> "“In any case, a deal won't be happening with Lespia. That is for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[155]`
Mówca: **Deivid Wisci**
> "“Unfortunately, it doesn't seem possible for us to attempt a trade deal with our southern neighbor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Deivid Wisci**
> "“Lespia is rather sore over our embargo of Arcasia, as are all the countries in ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`
  - -> `[186]`

### Węzeł `[157]`
Mówca: **Deivid Wisci**
> "“Unfortunately, a trade deal with them no longer seems possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[158]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[160]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Dealing with countries in CSP is dangerous.”"]** — Mówca: **Player**
> "“Dealing with countries in CSP is dangerous.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "“We should do whatever we can to get them on our side.”"]** — Mówca: **Player**
> "“We should do whatever we can to get them on our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“We don't need the help of other countries.”"]** — Mówca: **Player**
> "“We don't need the help of other countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Sordland will get to its rightful place within CSP.”"]** — Mówca: **Player**
> "“Sordland will get to its rightful place within CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
> "“A simple trade deal wouldn't cause issues unless we decide to go further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“That would be the best outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“I agree. Vaglsland is certainly powerful enough to deter Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“As we all know, times change, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“We won't let Agnolia get bullied by Valgsland.”"]** — Mówca: **Player**
> "“We won't let Agnolia get bullied by Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Unfortunate. So much needless dispute over such a small island...”"]** — Mówca: **Player**
> "“Unfortunate. So much needless dispute over such a small island...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“What is done is done. Let's look forward.”"]** — Mówca: **Player**
> "“What is done is done. Let's look forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Deivid Wisci**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[173]`
Mówca: **Deivid Wisci**
> "“I'm afraid it might get much worse in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[174]`
Mówca: **Deivid Wisci**
> "“Now that we have an alliance with them, I agree. We can't leave them alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Sordland will never get closer to Valgsland.”"]** — Mówca: **Player**
> "“Sordland will never get closer to Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“Sordland will get to its rightful place within ATO.”"]** — Mówca: **Player**
> "“Sordland will get to its rightful place within ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“A trade deal with Lespia could open many doors for us.""]** — Mówca: **Player**
> "“A trade deal with Lespia could open many doors for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "“I do not wish to get closer with any country in ATO.”"]** — Mówca: **Player**
> "“I do not wish to get closer with any country in ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“True. A country as influential as Lespia could help elevate our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“That would be the best outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“Nor do I, but it would certainly be profitable to have a business relationship with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "“I don't trust Lespia.”"]** — Mówca: **Player**
> "“I don't trust Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> "“That's a valid concern. Dealing with them would mean facing CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[184]`
**[WYBÓR GRACZA: "“I hope you are not questioning my decisions.”"]** — Mówca: **Player**
> "“I hope you are not questioning my decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“Good. We will never make a deal with a country in ATO.”"]** — Mówca: **Player**
> "“Good. We will never make a deal with a country in ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Unfortunate but necessary.”"]** — Mówca: **Player**
> "“Unfortunate but necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Deivid Wisci**
> "“Of course not, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[188]`
Mówca: **Deivid Wisci**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[189]`
Mówca: **Deivid Wisci**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[190]`
Mówca: **Deivid Wisci**
> "“In light of all this, I will begin researching other potential trading partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Deivid Wisci**
> "“That will be it for today. Thank you for coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> "“As to the actual contents of the trade deal...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[195]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[198]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[201]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[202]`
Mówca: **Deivid Wisci**
> "“The investment we have made in the Agnland region has yielded positive results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
Mówca: **Deivid Wisci**
> "“The investment we have made in the Bergia region has yielded positive results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
Mówca: **Deivid Wisci**
> "“The investment we have done in the Lorren region has yielded positive results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[206]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[207]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, the investment helped increase the coal output of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
> "“We now have a surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, the investment helped increase the wheat output of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“We now have a surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[214]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, the investment helped increase the fishing output of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
> "“We now have a surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[218]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[220]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, we now have a small tungsten surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Deivid Wisci**
> "“But let's not get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Deivid Wisci**
> "“I need to know your decision before we can proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[226]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`
  - -> `[231]`
  - -> `[233]`

### Węzeł `[228]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Begin negotiations with both Valgsland and Lespia.”"]** — Mówca: **Player**
> "“Begin negotiations with both Valgsland and Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[230]`
**[WYBÓR GRACZA: "“Begin negotiations with Lespia.”"]** — Mówca: **Player**
> "“Begin negotiations with Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "“Begin negotiations with Valgsland.”"]** — Mówca: **Player**
> "“Begin negotiations with Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[232]`
Mówca: **Deivid Wisci**
> "“What should we do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
**[WYBÓR GRACZA: "“We will not make any trade deals.”"]** — Mówca: **Player**
> "“We will not make any trade deals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[234]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: (BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[233]`

### Węzeł `[236]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[233]`

### Węzeł `[237]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[240]`
Mówca: **Iosef Lancea**
> "“Before you say anything, remember what I said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Iosef Lancea**
> "“We need allies. Not just a trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Iosef Lancea**
> "“If Rumburg attacks, we will fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
> "“Thank you. gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[244]`
Mówca: **Iosef Lancea**
> "“Mr. President. Before we disperse, remember what I said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[247]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[248]`
Mówca: **Iosef Lancea**
> "“We need allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Iosef Lancea**
> "“If Rumburg attacks, we will fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[250]`
  - -> `[252]`

### Węzeł `[250]`
**[WYBÓR GRACZA: "“Thank you. You're dismissed.""]** — Mówca: **Player**
> "“Thank you. You're dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[251]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "“I trust your capabilities Iosef.”"]** — Mówca: **Player**
> "“I trust your capabilities, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Iosef spoke softly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[255]`
Mówca: **Narrator**
> "Iosef saluted as we left the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[257]`
Mówca: **Deivid Wisci**
> "“Excellent news. I will begin at once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[258]`
Mówca: **Deivid Wisci**
> "“Excellent news. I will begin at once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[259]`
Mówca: **Deivid Wisci**
> "“Excellent news. I will begin at once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[260]`
Mówca: **Deivid Wisci**
> "“Anton, I think that's a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Deivid Wisci**
> "“But I can't force you to heed my advice. You're not my student anymore, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
> "“Thank you, gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[263]`
Mówca: **Deivid Wisci**
> "“Thank you for coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[264]`
Mówca: **Deivid Wisci**
> "“That was all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[265]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Lespia = true; BaseGame.TradeDeal_Negotiation_Valgsland = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true;
Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[266]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Lespia = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[267]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Valgsland = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[268]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[274]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[275]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[276]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn06_InT_OnTime == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn06_InT_OnTime == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[278]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn06_InT_OnTime == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[281]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[282]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[285]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[286]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[288]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[289]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[290]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[291]`
Mówca: **Deivid Wisci**
> "“Moving on to Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[292]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgsland = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[293]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Negotiation_Lespia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[294]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Negotiation_Valgsland = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_Valgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[295]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Negotiation_None = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[296]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[299]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[300]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[302]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Salary == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[305]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[308]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Hospitals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[309]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[310]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[311]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[312]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[315]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Sarna_IncreasedAgriculturalProduction = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Sarna_IncreasedAgriculturalProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[318]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[321]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[324]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[325]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[327]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[328]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[329]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[330]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Arvory_H3Result = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Arvory_H3Result"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Lachaven_L1Result = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Lachaven_L1Result"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy <= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Economy <= 4)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy <= 4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[339]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorkers = true;
BaseGameSupport.Report_Turn07_Holsord_CurrencyLosesValue = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorkers"] = true;
Variable["BaseGameSupport.Report_Turn07_Holsord_CurrencyLosesValue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[340]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_LT_Polio = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_Polio"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_Polio = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_Polio"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[342]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[343]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_RayneWillVisitLespia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_RayneWillVisitLespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[344]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_RayneWillVisitBoth = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_RayneWillVisitBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[345]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[348]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[349]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[350]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[352]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[353]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[354]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[356]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Deivid Wisci**
> "“Now that we have recognized Heljiland, I can only agree with you. Sordland shouldn't leave them alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[358]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[360]`
Mówca: **Deivid Wisci**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Deivid Wisci**
> "“With limited support, I can only think that it will be difficult from our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
