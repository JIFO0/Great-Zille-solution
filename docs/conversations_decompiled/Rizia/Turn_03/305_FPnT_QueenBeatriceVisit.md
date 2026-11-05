# Rizia/Turn 3/FPnT_QueenBeatriceVisit

- **ID konwersacji:** `305`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/305_FPnT_QueenBeatriceVisit.md`
- **Liczba węzłów dialogowych:** 558
- **Liczba wyborów gracza:** 136

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[92]** Beatrice Livingston (R)
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Decision_Turn03_ZilleBombApology`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_RumburgTrade`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_RumburgEnergyExport`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse`
- `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers`
- `RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise`
- `RiziaDLCSupport.News_Turn03_RH_BlameSO`
- `RiziaDLCSupport.News_Turn03_RH_DefendSO`
- `RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO`
- `RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWeek`
- `RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenceUpdate`
- `RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit`
- `RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit`
- `RiziaDLCSupport.Reports_Turn03_RumburgBuysLessOil`
- `RiziaDLCSupport.Reports_Turn03_RumburgOilEmbargo`
- `RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"Kiss Beatrice on the cheek."** | `[7]` **Narrator**: "Vina, Estela and I rose to greet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Beatrice Livingston (R)**: ""What a pleasure it is to see yo..." |
| `[9]` | **"Kiss her hand."** | `[7]` **Narrator**: "Vina, Estela and I rose to greet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Beatrice Livingston (R)**: ""What a pleasure it is to see yo..." |
| `[10]` | **"Shake her hand."** | `[7]` **Narrator**: "Vina, Estela and I rose to greet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Beatrice Livingston (R)**: ""What a pleasure it is to see yo..." |
| `[11]` | **"Embrace her."** | `[7]` **Narrator**: "Vina, Estela and I rose to greet..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Beatrice Livingston (R)**: ""What a pleasure it is to see yo..." |
| `[22]` | **""Let's be civil, ladies. We have important state issues to discuss.""** | `[21]` **Estela Toras**: ""Funny, I do seem to detect an u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Estela Toras**: ""Then I shall take my leave. I h..." |
| `[23]` | **""Shall we be seated?""** | `[21]` **Estela Toras**: ""Funny, I do seem to detect an u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Estela Toras**: ""If you'll excuse me, I shall ta..." |
| `[24]` | **""Pabel, please look into these matters at once. The air quality in the palace may ..."** | `[21]` **Estela Toras**: ""Funny, I do seem to detect an u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Pabel bemusedly raised an eyebrow." |
| `[34]` | **""Queen Mother Estela may have a common upbringing, but she's part of the royal fam..."** | `[159]` **Narrator**: "Beatrice motioned for her own at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Beatrice Livingston (R)**: ""Whatever do you mean, my love?"" |
| `[36]` | **""How is your own family?""** | `[159]` **Narrator**: "Beatrice motioned for her own at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Beatrice Livingston (R)**: ""Splendid. King Consort Boris se..." |
| `[37]` | **""To what do we owe this pleasure, Your Excellency?""** | `[159]` **Narrator**: "Beatrice motioned for her own at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Beatrice Livingston (R)**: ""First things first."" |
| `[38]` | **"Sip your tea."** | `[159]` **Narrator**: "Beatrice motioned for her own at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "Queen Beatrice extended her litt..." |
| `[53]` | **""That won't happen. President Smolak will respect the rule of law.""** | `[52]` **Beatrice Livingston (R)**: ""But how do you plan to follow t..."<br>`[61]` **Beatrice Livingston (R)**: ""Have you thought about your nex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Beatrice Livingston (R)**: ""A good monarch must anticipate ..." |
| `[54]` | **""If it comes down to it, I'm prepared to fight.""** | `[52]` **Beatrice Livingston (R)**: ""But how do you plan to follow t..."<br>`[61]` **Beatrice Livingston (R)**: ""Have you thought about your nex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Beatrice Livingston (R)**: ""Then you will need Rumburg's he..." |
| `[55]` | **""We will exercise diplomacy until an agreement is reached.""** | `[52]` **Beatrice Livingston (R)**: ""But how do you plan to follow t..."<br>`[61]` **Beatrice Livingston (R)**: ""Have you thought about your nex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Beatrice Livingston (R)**: ""That sounds simply wonderful, Y..." |
| `[56]` | **""I know Rumburg has its own agenda when it comes to Wehlen. Rizia's path will be d..."** | `[52]` **Beatrice Livingston (R)**: ""But how do you plan to follow t..."<br>`[61]` **Beatrice Livingston (R)**: ""Have you thought about your nex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Beatrice Livingston (R)**: ""Our only agenda is neutralizing..." |
| `[73]` | **""I'm already funding a Rizian cultural organization in Zille. That should get loca..."** | `[58]` **Beatrice Livingston (R)**: ""Then you will need Rumburg's he..."<br>`[59]` **Beatrice Livingston (R)**: ""To that end, Rumburg is prepare..." | `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true` | *Brak zmian stanu* | `[75]` **Beatrice Livingston (R)**: ""I see. A light touch."" |
| `[77]` | **""I thought this was a family visit, Your Excellency. Can we save the politics for ..."** | `[58]` **Beatrice Livingston (R)**: ""Then you will need Rumburg's he..."<br>`[59]` **Beatrice Livingston (R)**: ""To that end, Rumburg is prepare..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Beatrice Livingston (R)**: ""You and I are royals, Romus. Fo..." |
| `[78]` | **""You've helped us so much over the years. I would not ask more of you.""** | `[58]` **Beatrice Livingston (R)**: ""Then you will need Rumburg's he..."<br>`[59]` **Beatrice Livingston (R)**: ""To that end, Rumburg is prepare..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Beatrice Livingston (R)**: ""You don't need to ask."" |
| `[79]` | **""Do go on, Queen Beatrice.""** | `[58]` **Beatrice Livingston (R)**: ""Then you will need Rumburg's he..."<br>`[59]` **Beatrice Livingston (R)**: ""To that end, Rumburg is prepare..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Beatrice Livingston (R)**: ""Here's what I suggest, Your Maj..." |
| `[90]` | **""Why? Is your eldest son single?""** | `[89]` **Beatrice Livingston (R)**: ""How are the princess' marriage ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Beatrice Livingston (R)**: ""Heavens, no. My Bradley is stil..." |
| `[91]` | **""I wouldn't know. I told her I won't be arranging her marriage.""** | `[89]` **Beatrice Livingston (R)**: ""How are the princess' marriage ..." | `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true` | *Brak zmian stanu* | `[105]` **Beatrice Livingston (R)**: ""Did you? My word."" |
| `[94]` | **""A shame. They would have made beautiful children.""** | `[93]` **Beatrice Livingston (R)**: ""Much as I'd like to continue ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Beatrice Livingston (R)**: ""Indeed they would have. But you..." |
| `[95]` | **""Indeed. You made a wise arrangement.""** | `[93]` **Beatrice Livingston (R)**: ""Much as I'd like to continue ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Beatrice Livingston (R)**: ""I'm sure you'll find just as su..." |
| `[96]` | **""I was joking. They're cousins, for Dast's sake.""** | `[93]` **Beatrice Livingston (R)**: ""Much as I'd like to continue ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Beatrice Livingston (R)**: ""That never stopped any of our n..." |
| `[104]` | **""It doesn't matter, anyway. I already told her she can marry whomever she wants.""** | `[93]` **Beatrice Livingston (R)**: ""Much as I'd like to continue ou..." | `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true` | *Brak zmian stanu* | `[105]` **Beatrice Livingston (R)**: ""Did you? My word."" |
| `[109]` | **""I'm on the lookout for candidates. Someone from one of our other royal houses, pe..."** | `[89]` **Beatrice Livingston (R)**: ""How are the princess' marriage ..." | `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false` | *Brak zmian stanu* | `[115]` **Beatrice Livingston (R)**: ""Very good. As you'll recall, I ..." |
| `[113]` | **""You'll have to ask her yourself. We're not on the best terms these days.""** | `[89]` **Beatrice Livingston (R)**: ""How are the princess' marriage ..." | `Variable["RiziaDLC.Relations_Vina"] < 0` | *Brak zmian stanu* | `[117]` **Beatrice Livingston (R)**: ""Oh? I'm sorry to hear that."" |
| `[114]` | **""Honestly, I have too much on my mind to even start to think about that.""** | `[89]` **Beatrice Livingston (R)**: ""How are the princess' marriage ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Beatrice Livingston (R)**: ""Well, don't dilly-dally much lo..." |
| `[121]` | **""If that means inbreeding, perhaps it's best to let the garden die.""** | `[98]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Beatrice Livingston (R)**: ""If the garden dies, your ties t..." |
| `[122]` | **""I agree. But first cousins are too closely related for my comfort.""** | `[98]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Beatrice Livingston (R)**: ""Better a cousin than a commoner..." |
| `[123]` | **""I don't see the harm in allowing a few exotic plants to blossom here and there.""** | `[98]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..."<br>`[116]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Beatrice Livingston (R)**: ""Choose the wrong ones, and the ..." |
| `[126]` | **""Fear not. The garden of House Toras shall remain in bloom for a long, long time.""** | `[98]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..."<br>`[116]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Beatrice Livingston (R)**: ""With the help of House Livingst..." |
| `[127]` | **""If that means forcing my daughter into an unhappy union, perhaps it's best to let..."** | `[116]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Beatrice Livingston (R)**: ""If the garden dies, your ties t..." |
| `[129]` | **""Precisely my thinking. It's good to speak with someone who understands these thin..."** | `[128]` **Beatrice Livingston (R)**: ""We royals are an endangered bre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Beatrice Livingston (R)**: ""Anytime, my dear brother-in-law."" |
| `[137]` | **""She's on my council, you know.""** | `[15]` **Beatrice Livingston (R)**: ""Why, you're looking more and mo..." | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[143]` **Beatrice Livingston (R)**: ""Oh, my. So young, and already p..." |
| `[138]` | **""She's as stubborn as her mother was, that's for sure.""** | `[15]` **Beatrice Livingston (R)**: ""Why, you're looking more and mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Beatrice Livingston (R)**: ""Good girl. It's your royal obli..." |
| `[142]` | **""I wouldn't call her a 'lady''. She's been neglecting her duties as princess.""** | `[15]` **Beatrice Livingston (R)**: ""Why, you're looking more and mo..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[148]` **Narrator**: "Queen Beatrice gave Vina a mock ..." |
| `[150]` | **""I am. And I know Lena would have been, too.""** | `[15]` **Beatrice Livingston (R)**: ""Why, you're looking more and mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Narrator**: "Vina beamed."<br>`[155]` **Narrator**: "Vina managed a weak smile." |
| `[167]` | **""We always try to stay ahead.""** | `[505]` **Beatrice Livingston (R)**: ""I have been notified of your ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Beatrice Livingston (R)**: ""I can see. Good job."" |
| `[168]` | **""I love it. You buy less oil from Wehlen, and we'll make up the difference with na..."** | `[180]` **Beatrice Livingston (R)**: ""And? What do you think of the i..." | `Variable["RiziaDLC.Resources_Energy"] >= 2` | *Brak zmian stanu* | `[182]` **Beatrice Livingston (R)**: ""Thrilling. How much less oil sh..." |
| `[169]` | **""That's a lot to demand for a plan that may not even be useful or necessary.""** | `[166]` **Beatrice Livingston (R)**: ""Of course, an immediate moderni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Beatrice Livingston (R)**: ""Even if you don't ship us gas, ..." |
| `[171]` | **""That can be arranged.""** | `[166]` **Beatrice Livingston (R)**: ""Of course, an immediate moderni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Beatrice Livingston (R)**: ""Even if you don't ship us gas, ..." |
| `[172]` | **""To be honest, I'm satisfied with our countries' current trade relations. I don't ..."** | `[180]` **Beatrice Livingston (R)**: ""And? What do you think of the i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Beatrice Livingston (R)**: ""Are you quite sure? Remember, b..." |
| `[173]` | **""Interesting. But how would Rizian gas even reach Rumburg from here?""** | `[225]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>`[459]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == false` | *Brak zmian stanu* | `[170]` **Beatrice Livingston (R)**: ""I'm quite sure some of the same..." |
| `[174]` | **""Would we have to replace all the oil you've been purchasing? What about only part..."** | `[225]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>`[459]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == false` | *Brak zmian stanu* | `[177]` **Beatrice Livingston (R)**: ""Rumburg would prefer to elimina..." |
| `[175]` | **""So you believe Wehlen can't find another customer?""** | `[225]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>`[459]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == false` | *Brak zmian stanu* | `[178]` **Beatrice Livingston (R)**: ""Believe it or not, Wiktor Smola..." |
| `[176]` | **""This is a serious promise. What happens if I can't keep up my end of the guarantee?""** | `[225]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>`[459]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == false` | *Brak zmian stanu* | `[179]` **Beatrice Livingston (R)**: ""We'll have to find a more relia..." |
| `[181]` | **""I can't promise you anything. Rizia is indeed expanding its energy horizons, but ..."** | `[180]` **Beatrice Livingston (R)**: ""And? What do you think of the i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Beatrice Livingston (R)**: ""You would turn your back on fam..." |
| `[183]` | **""Can you halve your imports? We will provide some from our stockpiles now and more..."** | `[182]` **Beatrice Livingston (R)**: ""Thrilling. How much less oil sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[474]` **Beatrice Livingston (R)**: ""Certainly. It may not have as m..." |
| `[184]` | **""Screw it, Your Excellency. Cut off Wehlen completely." [-3 Energy, -2 Energy Per ..."** | `[182]` **Beatrice Livingston (R)**: ""Thrilling. How much less oil sh..." | `Variable["RiziaDLC.Resources_Energy"] >= 3` | *Brak zmian stanu* | `[185]` **Narrator**: "Beatrice smiled." |
| `[193]` | **""Wait. How much oil are you importing from Wehlen?""** | `[192]` **Beatrice Livingston (R)**: ""If we were to significantly red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Beatrice Livingston (R)**: ""Enough to seriously make a dent..." |
| `[194]` | **""I thought you hated Wehlen. But you're buying their oil?""** | `[192]` **Beatrice Livingston (R)**: ""If we were to significantly red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Beatrice Livingston (R)**: ""Don't look so shocked. It's a p..." |
| `[197]` | **""I don't need leverage over Wehlen.""** | `[192]` **Beatrice Livingston (R)**: ""If we were to significantly red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Beatrice Livingston (R)**: ""Leverage isn't the only thing I..." |
| `[201]` | **""Yes, we've discovered a new gas field. It's very exciting.""** | `[200]` **Beatrice Livingston (R)**: ""And as it happens, Rizia is abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Beatrice Livingston (R)**: ""How grand."" |
| `[202]` | **""We don't know yet. Our scientists are still figuring out the details.""** | `[200]` **Beatrice Livingston (R)**: ""And as it happens, Rizia is abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Beatrice Livingston (R)**: ""I see. Very interesting."" |
| `[203]` | **""At least some of it belongs to Pales.""** | `[200]` **Beatrice Livingston (R)**: ""And as it happens, Rizia is abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Beatrice Livingston (R)**: ""If you say so."" |
| `[204]` | **""Rizia has enough natural gas already. We're not looking for more.""** | `[200]` **Beatrice Livingston (R)**: ""And as it happens, Rizia is abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Beatrice Livingston (R)**: ""Hmm. Perhaps my intelligence wa..." |
| `[213]` | **""You'd deprive your own people of energy just to help Rizia?""** | `[192]` **Beatrice Livingston (R)**: ""If we were to significantly red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Beatrice Livingston (R)**: ""I most certainly would not."" |
| `[216]` | **""What kind of timeline are you thinking about?""** | `[208]` **Beatrice Livingston (R)**: ""We enrich your country and assi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Beatrice Livingston (R)**: ""We can cut off our orders of We..." |
| `[217]` | **""Generous, Your Excellency. But I can't guarantee that we'll be able to access tha..."** | `[208]` **Beatrice Livingston (R)**: ""We enrich your country and assi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Beatrice Livingston (R)**: ""It doesn't have to be that one ..." |
| `[218]` | **""I promise you access to the gas from that field and you'll stop purchasing oil fr..."** | `[208]` **Beatrice Livingston (R)**: ""We enrich your country and assi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Beatrice Livingston (R)**: ""It doesn't have to be that one ..." |
| `[226]` | **""Sorry, Your Excellency. I can already tell you I'm not interested.""** | `[208]` **Beatrice Livingston (R)**: ""We enrich your country and assi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Beatrice Livingston (R)**: ""Ah, well."" |
| `[234]` | **""I was never scared. Rizians weren't the target, after all.""** | `[233]` **Beatrice Livingston (R)**: ""Now. How are you faring a year ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Beatrice Livingston (R)**: ""No, they weren't. How curious."" |
| `[235]` | **""Yes, Mother and I were lucky to get out with our lives.""** | `[233]` **Beatrice Livingston (R)**: ""Now. How are you faring a year ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Beatrice Livingston (R)**: ""No Rizians were harmed at all, ..." |
| `[236]` | **""I'm less scared by what happened than by the ramifications of it.""** | `[233]` **Beatrice Livingston (R)**: ""Now. How are you faring a year ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Beatrice Livingston (R)**: ""That is the correct manner of t..." |
| `[237]` | **""I have good security. And everything's under control now.""** | `[233]` **Beatrice Livingston (R)**: ""Now. How are you faring a year ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Beatrice Livingston (R)**: ""I do hope that's true."" |
| `[243]` | **""Your concern is much appreciated.""** | `[242]` **Beatrice Livingston (R)**: ""Needless to say, Rumburg has be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "She nodded." |
| `[244]` | **""Why? How does what happened affect you?""** | `[242]` **Beatrice Livingston (R)**: ""Needless to say, Rumburg has be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Beatrice Livingston (R)**: ""Aside from my worries about you..." |
| `[245]` | **""So you came all the way to Porte Drazon to... express your concern?""** | `[242]` **Beatrice Livingston (R)**: ""Needless to say, Rumburg has be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Beatrice Livingston (R)**: ""I don't need an excuse to see m..." |
| `[253]` | **""Not as long as they have our land.""** | `[252]` **Beatrice Livingston (R)**: ""And Wehlen amassing more power ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Beatrice Livingston (R)**: ""Precisely."" |
| `[254]` | **""No. We've got to be very careful not to stir the pot further.""** | `[252]` **Beatrice Livingston (R)**: ""And Wehlen amassing more power ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Beatrice Livingston (R)**: ""It's more important not to capi..." |
| `[255]` | **""If they try, they will face the consequences.""** | `[252]` **Beatrice Livingston (R)**: ""And Wehlen amassing more power ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Beatrice Livingston (R)**: ""Precisely."" |
| `[256]` | **""I only want peace with Wehlen. Our countries have a historical bond.""** | `[252]` **Beatrice Livingston (R)**: ""And Wehlen amassing more power ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Beatrice Livingston (R)**: ""It's more important not to capi..." |
| `[269]` | **""That's quite all right. Tell me your idea.""** | `[267]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..."<br>`[268]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "Beatrice smiled fiercely." |
| `[271]` | **""What was so controversial about it?""** | `[266]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Beatrice Livingston (R)**: ""Now, now. Don't play coy."" |
| `[272]` | **""I'm so sorry. It was never my intention to be unfaithful.""** | `[267]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Beatrice Livingston (R)**: ""Oh, it's never anyone's intenti..." |
| `[273]` | **""She told you about that?""** | `[267]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Beatrice Livingston (R)**: ""She told me everything, Your Ma..." |
| `[275]` | **""What about GRACE?""** | `[266]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Beatrice Livingston (R)**: ""You are as crucial of a member ..." |
| `[280]` | **""Giving people a voice doesn't mean giving up monarchy. Isn't your own country gov..."** | `[279]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Beatrice Livingston (R)**: ""Technically, yes. But it has ro..." |
| `[281]` | **""I got carried away in the moment. I didn't really mean it.""** | `[279]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Beatrice Livingston (R)**: ""I hear your behavior as king ha..."<br>`[290]` **Beatrice Livingston (R)**: ""It's an odd promise to simply b..." |
| `[283]` | **""You can all make of it what you will.""** | `[279]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Beatrice Livingston (R)**: ""I hardly think such a flippant ..." |
| `[284]` | **""I didn't realize that GRACE was so attuned to my actions as king.""** | `[279]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Beatrice Livingston (R)**: ""You are the unproven ruler of o..." |
| `[294]` | **""Don't worry, Your Excellency. The Rizian monarchy is not going anywhere.""** | `[292]` **Beatrice Livingston (R)**: ""You were lucky to escape the 19..."<br>`[293]` **Beatrice Livingston (R)**: ""Of course you are free to run y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Beatrice Livingston (R)**: ""Wehlen might beg to differ."" |
| `[295]` | **""Thank you for warning me. I shall keep your words in mind.""** | `[292]` **Beatrice Livingston (R)**: ""You were lucky to escape the 19..."<br>`[293]` **Beatrice Livingston (R)**: ""Of course you are free to run y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Beatrice Livingston (R)**: ""I hope you shall do more than t..." |
| `[296]` | **""I know what I'm getting myself into.""** | `[292]` **Beatrice Livingston (R)**: ""You were lucky to escape the 19..."<br>`[293]` **Beatrice Livingston (R)**: ""Of course you are free to run y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Narrator**: "She regarded me warily." |
| `[299]` | **""What affairs?""** | `[267]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Narrator**: "She rolled her eyes." |
| `[305]` | **""I understand what you're getting at. Let's talk about Wehlen.""** | `[304]` **Beatrice Livingston (R)**: ""But should that bond in any way..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "Beatrice smiled fiercely." |
| `[306]` | **""Same here, Your Excellency.""** | `[304]` **Beatrice Livingston (R)**: ""But should that bond in any way..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Narrator**: "Beatrice glared at me, then smil..." |
| `[307]` | **""The bond will not falter. Don't forget there's also Vina.""** | `[304]` **Beatrice Livingston (R)**: ""But should that bond in any way..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "Beatrice smiled." |
| `[313]` | **""You know what? Let's talk about that instead.""** | `[268]` **Beatrice Livingston (R)**: ""Or would you rather talk about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Beatrice Livingston (R)**: ""Very well, Your Majesty."" |
| `[336]` | **""Okay. I think I have a good grasp on the particulars of the deal you're suggesting.""** | `[225]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>`[459]` **Beatrice Livingston (R)**: ""We'd then give you a one-year g..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == true` | *Brak zmian stanu* | `[180]` **Beatrice Livingston (R)**: ""And? What do you think of the i..." |
| `[338]` | **""I just don't see it. Even if my goal was to put the squeeze on Wehlen, this is no..."** | `[180]` **Beatrice Livingston (R)**: ""And? What do you think of the i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Beatrice Livingston (R)**: ""Suit yourself, Your Majesty."" |
| `[342]` | **""You do seem quite keen on it. I would be remiss not to hear you out.""** | `[340]` **Beatrice Livingston (R)**: ""Are you sure you don't want to ..."<br>`[341]` **Beatrice Livingston (R)**: ""Now, are you sure you don't wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Narrator**: "Beatrice smiled fiercely." |
| `[345]` | **""Vina's a modest girl. She won't do anything worth gossiping about.""** | `[120]` **Beatrice Livingston (R)**: ""They had quite the field day wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Beatrice Livingston (R)**: ""Never underestimate the ability..." |
| `[346]` | **""Good point. I'll start thinking about candidates.""** | `[120]` **Beatrice Livingston (R)**: ""They had quite the field day wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Beatrice Livingston (R)**: ""It's high time you do."" |
| `[347]` | **""Remind me, who is your son betrothed to again?""** | `[120]` **Beatrice Livingston (R)**: ""They had quite the field day wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Beatrice Livingston (R)**: ""Why, the Duchess of Thompsfort,..." |
| `[354]` | **""If the Rizian tabloids try something like that, I'll shut them down.""** | `[120]` **Beatrice Livingston (R)**: ""They had quite the field day wi..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[355]` **Beatrice Livingston (R)**: ""It's not only Rizia who's payin..." |
| `[358]` | **""Tell that to Vina.""** | `[131]` **Beatrice Livingston (R)**: ""You're lucky to have such a rel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Beatrice Livingston (R)**: ""Perhaps I will."" |
| `[359]` | **""My daughter doesn't want my guidance anymore.""** | `[131]` **Beatrice Livingston (R)**: ""You're lucky to have such a rel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Beatrice Livingston (R)**: ""But she may need it. Especially..." |
| `[360]` | **""I will try.""** | `[131]` **Beatrice Livingston (R)**: ""You're lucky to have such a rel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Beatrice Livingston (R)**: ""See that you do."" |
| `[372]` | **""What was so controversial about it?""** | `[371]` **Beatrice Livingston (R)**: ""Our partners will be looking fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Beatrice Livingston (R)**: ""Now, now. Don't play coy."" |
| `[373]` | **""Which partners do you mean?""** | `[371]` **Beatrice Livingston (R)**: ""Our partners will be looking fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Beatrice Livingston (R)**: ""All of them, Your Majesty."" |
| `[378]` | **""Giving people a voice doesn't mean giving up monarchy. Isn't your own country gov..."** | `[377]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Beatrice Livingston (R)**: ""Technically, yes. But it has ro..." |
| `[379]` | **""I got carried away in the moment. I didn't really mean it.""** | `[377]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Beatrice Livingston (R)**: ""I hear your behavior as king ha..."<br>`[388]` **Beatrice Livingston (R)**: ""It's an odd promise to simply b..." |
| `[381]` | **""You can all make of it what you will.""** | `[377]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Beatrice Livingston (R)**: ""I hardly think such a flippant ..." |
| `[382]` | **""I didn't realize that GRACE was so attuned to my actions as king.""** | `[377]` **Beatrice Livingston (R)**: ""What am I to make of that, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Beatrice Livingston (R)**: ""You are the unproven ruler of o..." |
| `[392]` | **""Don't worry, Your Excellency. The Rizian monarchy is not going anywhere.""** | `[390]` **Beatrice Livingston (R)**: ""You were lucky to escape the 19..."<br>`[391]` **Beatrice Livingston (R)**: ""Of course you are free to run y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Beatrice Livingston (R)**: ""Wehlen might beg to differ."" |
| `[393]` | **""I know what I'm getting myself into.""** | `[390]` **Beatrice Livingston (R)**: ""You were lucky to escape the 19..."<br>`[391]` **Beatrice Livingston (R)**: ""Of course you are free to run y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Narrator**: "She regarded me warily." |
| `[394]` | **""Thank you for warning me. I shall keep your words in mind.""** | `[390]` **Beatrice Livingston (R)**: ""You were lucky to escape the 19..."<br>`[391]` **Beatrice Livingston (R)**: ""Of course you are free to run y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Beatrice Livingston (R)**: ""I hope you shall do more than t..." |
| `[405]` | **""I'm sure, Your Excellency.""** | `[340]` **Beatrice Livingston (R)**: ""Are you sure you don't want to ..."<br>`[341]` **Beatrice Livingston (R)**: ""Now, are you sure you don't wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Beatrice Livingston (R)**: ""A pity."" |
| `[417]` | **""What about GRACE?""** | `[416]` **Beatrice Livingston (R)**: ""Rizia is one of its linchpin na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Beatrice Livingston (R)**: ""Do not discount the importance ..." |
| `[419]` | **""I didn't realize our fellow kingdoms were keeping such a close eye on me.""** | `[416]` **Beatrice Livingston (R)**: ""Rizia is one of its linchpin na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Beatrice Livingston (R)**: ""You are the unproven ruler of a..." |
| `[423]` | **""I'll keep that in mind. We monarchies have to stick together.""** | `[421]` **Beatrice Livingston (R)**: ""Our fellow monarchies want to s..."<br>`[422]` **Beatrice Livingston (R)**: ""GRACE wants to see a stable Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Narrator**: "She smiled."<br>`[432]` **Beatrice Livingston (R)**: ""Rumburg will do its best to aid..." |
| `[424]` | **""I'm still not sure of the utility of such an organization.""** | `[421]` **Beatrice Livingston (R)**: ""Our fellow monarchies want to s..."<br>`[422]` **Beatrice Livingston (R)**: ""GRACE wants to see a stable Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Beatrice Livingston (R)**: ""In case you haven't noticed, it..." |
| `[425]` | **""Believe me, I want to see a stable Rizia as well.""** | `[421]` **Beatrice Livingston (R)**: ""Our fellow monarchies want to s..."<br>`[422]` **Beatrice Livingston (R)**: ""GRACE wants to see a stable Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Narrator**: "She smiled."<br>`[432]` **Beatrice Livingston (R)**: ""Rumburg will do its best to aid..." |
| `[461]` | **""I agree completely. My councilors and your foreign ministers can iron out the sma..."** | `[460]` **Beatrice Livingston (R)**: ""This will all need to be formal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[464]` **Beatrice Livingston (R)**: ""Precisely. We handle the big pi..." |
| `[462]` | **""How long have we known each other, sweet Beatrice? My word is as good as gold.""** | `[460]` **Beatrice Livingston (R)**: ""This will all need to be formal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Beatrice Livingston (R)**: ""I believe your intentions are n..." |
| `[463]` | **""It is still quite the leap of faith, though, isn't it? Is your sisterly affection..."** | `[460]` **Beatrice Livingston (R)**: ""This will all need to be formal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Beatrice Livingston (R)**: ""Our mutual love for Lena has in..." |
| `[468]` | **""With whom do you think you're speaking? King Romus always keeps a promise." [-3 E..."** | `[458]` **Beatrice Livingston (R)**: ""I feel obliged to ask once more..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[471]` **Beatrice Livingston (R)**: ""What a delightful little rhyme."" |
| `[469]` | **""Well... you do have quite a large country. Perhaps you should halve your orders i..."** | `[458]` **Beatrice Livingston (R)**: ""I feel obliged to ask once more..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Beatrice Livingston (R)**: ""Certainly, Your Majesty. It's i..." |
| `[472]` | **""If the Queen of Rumburg demands it, so it shall be." [-3 Energy, -2 Energy Per Tu..."** | `[458]` **Beatrice Livingston (R)**: ""I feel obliged to ask once more..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[473]` **Beatrice Livingston (R)**: ""Very good."" |
| `[482]` | **""I hope you had nothing to do with it.""** | `[233]` **Beatrice Livingston (R)**: ""Now. How are you faring a year ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Beatrice Livingston (R)**: ""You must be joking..."" |
| `[484]` | **""Of course.""** | `[416]` **Beatrice Livingston (R)**: ""Rizia is one of its linchpin na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Beatrice Livingston (R)**: ""Our fellow monarchies want to s..." |
| `[485]` | **""My speech?""** | `[371]` **Beatrice Livingston (R)**: ""Our partners will be looking fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Beatrice Livingston (R)**: ""Just as the world's remaining m..." |
| `[506]` | **""Indeed. I ordered that expansion with foreign trade in mind.""** | `[505]` **Beatrice Livingston (R)**: ""I have been notified of your ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Beatrice Livingston (R)**: ""Even if you don't agree to sell..." |
| `[507]` | **""It's almost as if I knew this deal was coming. Just call me Romus the Prescient.""** | `[505]` **Beatrice Livingston (R)**: ""I have been notified of your ex..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[508]` **Beatrice Livingston (R)**: ""I'd rather not. But I appreciat..." |
| `[512]` | **""Yes, I'm sure. Shall we change the subject?""** | `[188]` **Beatrice Livingston (R)**: ""Are you quite sure? Remember, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[513]` **Beatrice Livingston (R)**: ""Very well. Let's."" |
| `[514]` | **""I remember just fine. Shall we change the subject?""** | `[511]` **Beatrice Livingston (R)**: ""Remember who got you into GRACE..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[513]` **Beatrice Livingston (R)**: ""Very well. Let's."" |
| `[515]` | **""On second thought, this embargo could be quite useful. Let's go through with it.""** | `[188]` **Beatrice Livingston (R)**: ""Are you quite sure? Remember, b..."<br>`[511]` **Beatrice Livingston (R)**: ""Remember who got you into GRACE..." | `Variable["RiziaDLC.Resources_Energy"] >= 2` | *Brak zmian stanu* | `[182]` **Beatrice Livingston (R)**: ""Thrilling. How much less oil sh..." |
| `[519]` | **""I treasure our alliance, Beatrice. I just don't believe this deal is in Rizia's b..."** | `[188]` **Beatrice Livingston (R)**: ""Are you quite sure? Remember, b..."<br>`[511]` **Beatrice Livingston (R)**: ""Remember who got you into GRACE..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Beatrice Livingston (R)**: ""Hm. Very well."" |
| `[521]` | **""Actually, I'm beginning to have second thoughts. Let's keep our trade relationshi..."** | `[182]` **Beatrice Livingston (R)**: ""Thrilling. How much less oil sh..."<br>`[458]` **Beatrice Livingston (R)**: ""I feel obliged to ask once more..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[522]` **Narrator**: "She gave me a disappointed frown." |
| `[531]` | **""Be honest with me. Do you really care about religion that much?""** | `[529]` **Beatrice Livingston (R)**: ""So I was quite pleased to hear ..."<br>`[530]` **Beatrice Livingston (R)**: ""I know Dastnurity is a minority..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[546]` **Beatrice Livingston (R)**: ""Our personal beliefs don't fact..." |
| `[532]` | **""I will try. But it's not at the top of my list of priorities.""** | `[530]` **Beatrice Livingston (R)**: ""I know Dastnurity is a minority..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Beatrice Livingston (R)**: ""I suggest you rearrange that li..." |
| `[533]` | **""Of course. The Kingdom of Rizia welcomes all denominations of Nurity.""** | `[529]` **Beatrice Livingston (R)**: ""So I was quite pleased to hear ..."<br>`[530]` **Beatrice Livingston (R)**: ""I know Dastnurity is a minority..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[539]` **Beatrice Livingston (R)**: ""Yes, you proved that, didn't yo..."<br>`[540]` **Beatrice Livingston (R)**: ""Except Golcondists, it seems. O..." |
| `[534]` | **""Why should I accept them when they don't accept the sacred scripture of St. Wruhec?""** | `[530]` **Beatrice Livingston (R)**: ""I know Dastnurity is a minority..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[535]` **Beatrice Livingston (R)**: ""For heaven's sake, Romus. Golco..."<br>`[544]` **Beatrice Livingston (R)**: ""That's no attitude to take towa..." |
| `[547]` | **""It was the least I could do. I still regret that Lena was forced to convert.""** | `[529]` **Beatrice Livingston (R)**: ""So I was quite pleased to hear ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[548]` **Beatrice Livingston (R)**: ""Past is past. I don't believe s..."<br>`[552]` **Beatrice Livingston (R)**: ""She forgave you. Though I don't..." |

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
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Welcoming Queen Beatrice of Rumburg to t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Vina, Estela and I sat in Palas Rezna's most ornate stateroom, awaiting the arrival of Queen Beatrice Livingston."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "An informal supper with my sister-in-law was scheduled fo..."*)

### Węzeł `[4]`
Mówca: **Pabel Adria**
> ""Announcing Her Excellency Beatrice Livingston, Queen of the Four Corners of Merkopa, Defender of Castle Tzarsbough, Conqueror of the Tranquil Sea, Stout Protector of the Ancient Lands of Rum, Descendant of the Most Honorable King Edward the First and the Ruler of Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "AddConversant("Beatrice Livingston (R)" );"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Pabel came in through the stateroom door. He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Pabel Adria: ""Announcing Her Excellency Beatrice Livingston, Queen of ..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "He stepped aside and Queen Beatrice entered. She was wearing an emerald-green gown that matched her tiara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Vina, Estela and I rose to greet the queen."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Vina, Estela and I rose to greet the queen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus_Italic: "Kiss Beatrice on the cheek."*)
  - -> `[9]` (*Player_Romus_Italic: "Kiss her hand."*)
  - -> `[10]` (*Player_Romus_Italic: "Shake her hand."*)
  - -> `[11]` (*Player_Romus_Italic: "Embrace her."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "Kiss Beatrice on the cheek."]** — Mówca: **Player_Romus_Italic**
> "I kissed my sister-in-law on the cheek. She returned the gesture warmly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Beatrice Livingston (R): ""What a pleasure it is to see you, Your Majesty. We barel..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "Kiss her hand."]** — Mówca: **Player_Romus_Italic**
> "I took my sister-in-law's hand and kissed it. She looked me up and down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Beatrice Livingston (R): ""What a pleasure it is to see you, Your Majesty. We barel..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Shake her hand."]** — Mówca: **Player_Romus_Italic**
> "I shook my sister-in-law's hand. She returned it with a firm grip."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Beatrice Livingston (R): ""What a pleasure it is to see you, Your Majesty. We barel..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Embrace her."]** — Mówca: **Player_Romus_Italic**
> "I gave my sister-in-law a hug. She returned it warmly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Beatrice Livingston (R): ""What a pleasure it is to see you, Your Majesty. We barel..."*)

### Węzeł `[12]`
Mówca: **Beatrice Livingston (R)**
> ""What a pleasure it is to see you, Your Majesty. We barely had the chance to speak at the coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Beatrice Livingston (R): ""And my dear niece!""*)

### Węzeł `[13]`
Mówca: **Beatrice Livingston (R)**
> ""And my dear niece!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "She turned towards Vina."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "She turned towards Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Beatrice Livingston (R): ""Why, you're looking more and more like your mother every..."*)

### Węzeł `[15]`
Mówca: **Beatrice Livingston (R)**
> ""Why, you're looking more and more like your mother every day. I hope your father's proud of the lady you've become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[138]` (*Player_Romus: ""She's as stubborn as her mother was, that's for sure.""*)
  - -> `[150]` (*Player_Romus: ""I am. And I know Lena would have been, too.""*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Beatrice embraced her tightly before moving on to my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "The two women gave each other air kisses, then stood back..."*)

### Węzeł `[17]`
Mówca: **Estela Toras**
> ""Queen Beatrice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Beatrice Livingston (R): ""Queen Mother Estela.""*)

### Węzeł `[18]`
Mówca: **Beatrice Livingston (R)**
> ""Queen Mother Estela.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "She tilted her face upwards and gave a short sniff."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "She tilted her face upwards and gave a short sniff."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Beatrice Livingston (R): ""The palace looks as magnificent as always, but I fear a ..."*)

### Węzeł `[20]`
Mówca: **Beatrice Livingston (R)**
> ""The palace looks as magnificent as always, but I fear a chat with your housekeeper may be in order. Every time I visit, it smells just the faintest bit like trash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: "My mother feigned a puzzled look."*)

### Węzeł `[21]`
Mówca: **Estela Toras**
> ""Funny, I do seem to detect an unpleasant draft of hot air. But only since you walked in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""Let's be civil, ladies. We have important state issues t..."*)
  - -> `[23]` (*Player_Romus: ""Shall we be seated?""*)
  - -> `[24]` (*Player_Romus: ""Pabel, please look into these matters at once. The air q..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's be civil, ladies. We have important state issues to discuss.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Estela Toras: ""Then I shall take my leave. I have a terribly urgent app..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shall we be seated?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Estela Toras: ""If you'll excuse me, I shall take my leave. I have a ter..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel, please look into these matters at once. The air quality in the palace may be compromised.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Pabel bemusedly raised an eyebrow."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Pabel bemusedly raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Pabel Adria: ""Right away, Your Majesty.""*)

### Węzeł `[26]`
Mówca: **Pabel Adria**
> ""Right away, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Estela Toras: ""If you'll excuse me, I shall take my leave. I have a ter..."*)

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""Then I shall take my leave. I have a terribly urgent appointment on the other side of the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Beatrice Livingston (R): ""By all means, Your Highness. Our chatter is far more bor..."*)

### Węzeł `[28]`
Mówca: **Estela Toras**
> ""If you'll excuse me, I shall take my leave. I have a terribly urgent appointment on the other side of the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Beatrice Livingston (R): ""By all means, Your Highness. Our chatter is far more bor..."*)

### Węzeł `[29]`
Mówca: **Beatrice Livingston (R)**
> ""By all means, Your Highness. Our chatter is far more boring than the sort of carousing you're used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Beatrice Livingston (R): ""Vina, why don't you run along as well? We'll catch up ov..."*)

### Węzeł `[30]`
Mówca: **Beatrice Livingston (R)**
> ""Vina, why don't you run along as well? We'll catch up over supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Vina reluctantly nodded."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Vina reluctantly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Vina Toras: ""Sure, Aunt Bea. Have the staff give my room a ring when ..."*)

### Węzeł `[32]`
Mówca: **Vina Toras**
> ""Sure, Aunt Bea. Have the staff give my room a ring when you're done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Pabel Adria: ""I'll see you two out. Just a moment.""*)

### Węzeł `[33]`
Mówca: **Narrator**
> "He filled two porcelain cups for us, then escorted Vina and my mother out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras"); RemoveConversant("Vina ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Queen Mother Estela may have a common upbringing, but she's part of the royal family. Please respect her as such.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Beatrice Livingston (R): ""Whatever do you mean, my love?""*)

### Węzeł `[35]`
Mówca: **Beatrice Livingston (R)**
> ""Whatever do you mean, my love?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Beatrice Livingston (R): ""I find your mother ever so charming. I never believed th..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is your own family?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Beatrice Livingston (R): ""Splendid. King Consort Boris sends his sincerest regrets..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To what do we owe this pleasure, Your Excellency?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Beatrice Livingston (R): ""First things first.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Sip your tea."]** — Mówca: **Player_Romus_Italic**
> "I took a sip of Rumburgian tea. Lena had loved its earthy taste, but I never quite got used to it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Queen Beatrice extended her little finger and took a sip ..."*)

### Węzeł `[39]`
Mówca: **Beatrice Livingston (R)**
> ""First things first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Queen Beatrice extended her little finger and raised her ..."*)

### Węzeł `[40]`
Mówca: **Beatrice Livingston (R)**
> ""Splendid. King Consort Boris sends his sincerest regrets. He had to oversee some air force exercises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Queen Beatrice extended her little finger and raised her ..."*)

### Węzeł `[41]`
Mówca: **Beatrice Livingston (R)**
> ""Of course we are the same age, Your Majesty, but I've worn my crown for many years longer than you have yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Beatrice Livingston (R): ""And I and my country are far more experienced at dealing..."*)

### Węzeł `[42]`
Mówca: **Beatrice Livingston (R)**
> ""And I and my country are far more experienced at dealing with the Republic of Wehlen and their backers in the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Beatrice Livingston (R): ""Sending your own investigators to ferret out the bombing..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)

### Węzeł `[46]`
Mówca: **Beatrice Livingston (R)**
> ""Sending your own investigators to ferret out the bombing culprit is a good start. It shows President Smolak you are unwilling to play by his terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Beatrice Livingston (R): ""But how do you plan to follow that up? What will you do ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_Denounce..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Beatrice Livingston (R): ""By indicating that you regard your own countrymen as cul..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleBombApology == true"*)

### Węzeł `[50]`
Mówca: **Beatrice Livingston (R)**
> ""By indicating that you regard your own countrymen as culpable for the bombing, you are putting yourself in a position of weakness from the start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Beatrice Livingston (R): ""Have you thought about your next steps? What will you do..."*)

### Węzeł `[51]`
Mówca: **Beatrice Livingston (R)**
> ""By apologizing to President Smolak for a perfectly justified speech, you are putting yourself in a position of weakness from the start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Beatrice Livingston (R): ""Have you thought about your next steps? What will you do..."*)

### Węzeł `[52]`
Mówca: **Beatrice Livingston (R)**
> ""But how do you plan to follow that up? What will you do if Mr. Smolak fails to relinquish his hold on Zille?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""That won't happen. President Smolak will respect the rul..."*)
  - -> `[54]` (*Player_Romus: ""If it comes down to it, I'm prepared to fight.""*)
  - -> `[56]` (*Player_Romus: ""I know Rumburg has its own agenda when it comes to Wehle..."*)
  - -> `[55]` (*Player_Romus: ""We will exercise diplomacy until an agreement is reached.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That won't happen. President Smolak will respect the rule of law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston (R)), `[61]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Beatrice Livingston (R): ""A good monarch must anticipate every eventuality. No mat..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it comes down to it, I'm prepared to fight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston (R)), `[61]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Beatrice Livingston (R): ""Then you will need Rumburg's help.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will exercise diplomacy until an agreement is reached.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston (R)), `[61]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Beatrice Livingston (R): ""That sounds simply wonderful, Your Majesty. Until you ar..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Rumburg has its own agenda when it comes to Wehlen. Rizia's path will be different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston (R)), `[61]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Beatrice Livingston (R): ""Our only agenda is neutralizing the threat that this unp..."*)

### Węzeł `[57]`
Mówca: **Beatrice Livingston (R)**
> ""Our only agenda is neutralizing the threat that this unpredictable regime poses to its neighbors. Including you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Beatrice Livingston (R): ""To that end, Rumburg is prepared to provide assistance w..."*)

### Węzeł `[58]`
Mówca: **Beatrice Livingston (R)**
> ""Then you will need Rumburg's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[78]` (*Player_Romus: ""You've helped us so much over the years. I would not ask..."*)
  - -> `[79]` (*Player_Romus: ""Do go on, Queen Beatrice.""*)
  - -> `[77]` (*Player_Romus: ""I thought this was a family visit, Your Excellency. Can ..."*)

### Węzeł `[59]`
Mówca: **Beatrice Livingston (R)**
> ""To that end, Rumburg is prepared to provide assistance with the delicate situation in which you've found yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[78]` (*Player_Romus: ""You've helped us so much over the years. I would not ask..."*)
  - -> `[79]` (*Player_Romus: ""Do go on, Queen Beatrice.""*)
  - -> `[77]` (*Player_Romus: ""I thought this was a family visit, Your Excellency. Can ..."*)

### Węzeł `[60]`
Mówca: **Beatrice Livingston (R)**
> ""That sounds simply wonderful, Your Majesty. Until you arrive at the bargaining table and realize your pockets are empty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Beatrice Livingston (R): ""To that end, Rumburg is prepared to provide assistance w..."*)

### Węzeł `[61]`
Mówca: **Beatrice Livingston (R)**
> ""Have you thought about your next steps? What will you do if Mr. Smolak fails to relinquish his hold on Zille?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""That won't happen. President Smolak will respect the rul..."*)
  - -> `[54]` (*Player_Romus: ""If it comes down to it, I'm prepared to fight.""*)
  - -> `[56]` (*Player_Romus: ""I know Rumburg has its own agenda when it comes to Wehle..."*)
  - -> `[55]` (*Player_Romus: ""We will exercise diplomacy until an agreement is reached.""*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleBombApology == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleBombApology == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleBombApology == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleBombApology == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleBombApology"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Beatrice Livingston (R): ""By apologizing to President Smolak for a perfectly justi..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleBombApology == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleBombApology"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO =..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO =..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Beatrice Livingston (R): ""You denied that your countrymen were culpable for the at..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Beatrice Livingston (R): ""You have expressed no opinion on the incident thus far. ..."*)

### Węzeł `[68]`
Mówca: **Beatrice Livingston (R)**
> ""You denied that your countrymen were culpable for the attack. But you must realize President Smolak will not take your words at face value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Beatrice Livingston (R): ""Have you thought about your next steps? What will you do..."*)

### Węzeł `[69]`
Mówca: **Beatrice Livingston (R)**
> ""You have expressed no opinion on the incident thus far. You must realize that President Smolak will see that as an admission of guilt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Beatrice Livingston (R): ""Have you thought about your next steps? What will you do..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""I'm already funding a Rizian cultural organization in Zi..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm already funding a Rizian cultural organization in Zille. That should get locals on my side.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Kontekst wejściowy (poprzednik):** `[58]` (Beatrice Livingston (R)), `[59]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Beatrice Livingston (R): ""I see. A light touch.""*)

### Węzeł `[74]`
Mówca: **Beatrice Livingston (R)**
> ""A good monarch must anticipate every eventuality. No matter how unlikely he or she believes it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Beatrice Livingston (R): ""To that end, Rumburg is prepared to provide assistance w..."*)

### Węzeł `[75]`
Mówca: **Beatrice Livingston (R)**
> ""I see. A light touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Beatrice Livingston (R): ""Should you wish for something a little less subtle, I ha..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Beatrice leaned forward and held my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Beatrice Livingston (R): ""Of course we are the same age, Your Majesty, but I've wo..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought this was a family visit, Your Excellency. Can we save the politics for another time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Beatrice Livingston (R)), `[59]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Beatrice Livingston (R): ""You and I are royals, Romus. For us, family and politics..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've helped us so much over the years. I would not ask more of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Beatrice Livingston (R)), `[59]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Beatrice Livingston (R): ""You don't need to ask.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do go on, Queen Beatrice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Beatrice Livingston (R)), `[59]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "Natural Gas Talk"*)

### Węzeł `[80]`
Mówca: **Beatrice Livingston (R)**
> ""You don't need to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Beatrice Livingston (R): ""Our nations are bound by our shared love for my sister. ..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == false)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "She shot me a piercing glance. I wondered how much Lena h..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "She looked at me with what seemed like genuine compassion."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "She shot me a piercing glance. I wondered how much Lena had told her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "Natural Gas Talk"*)

### Węzeł `[85]`
Mówca: **Narrator**
> "She looked at me with what seemed like genuine compassion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "Natural Gas Talk"*)

### Węzeł `[86]`
Mówca: **Beatrice Livingston (R)**
> ""Here's what I suggest, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Beatrice Livingston (R): ""As you may know, Rumburg is currently a major importer o..."*)

### Węzeł `[87]`
Mówca: **Pabel Adria**
> ""I'll see you two out. Just a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Pabel walked Beatrice and myself over to a pair of velvet..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Pabel walked Beatrice and myself over to a pair of velvet armchairs. Next to them was a table upon which a towering silver Rumburgian tea urn had been set up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "He filled two porcelain cups for us, then escorted Vina a..."*)

### Węzeł `[89]`
Mówca: **Beatrice Livingston (R)**
> ""How are the princess' marriage plans coming along?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""Why? Is your eldest son single?""*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[114]` (*Player_Romus: ""Honestly, I have too much on my mind to even start to th..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Is your eldest son single?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Beatrice Livingston (R): ""Heavens, no. My Bradley is still betrothed to the Duches..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't know. I told her I won't be arranging her marriage.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Beatrice Livingston (R): ""Did you? My word.""*)

### Węzeł `[92]`
Mówca: **Beatrice Livingston (R)**
> ""Heavens, no. My Bradley is still betrothed to the Duchess of Thompsfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Beatrice Livingston (R): ""Much as I'd like to continue our tradition of royal inte..."*)

### Węzeł `[93]`
Mówca: **Beatrice Livingston (R)**
> ""Much as I'd like to continue our tradition of royal intermarriage, this pairing is necessary to secure northwestern Rumburg's continued loyalty. Surely you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Romus: ""A shame. They would have made beautiful children.""*)
  - -> `[95]` (*Player_Romus: ""Indeed. You made a wise arrangement.""*)
  - -> `[96]` (*Player_Romus: ""I was joking. They're cousins, for Dast's sake.""*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A shame. They would have made beautiful children.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Beatrice Livingston (R): ""Indeed they would have. But you'll find another suitable..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. You made a wise arrangement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Beatrice Livingston (R): ""I'm sure you'll find just as suitable a match for my bri..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was joking. They're cousins, for Dast's sake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Beatrice Livingston (R): ""That never stopped any of our noble ancestors.""*)

### Węzeł `[97]`
Mówca: **Beatrice Livingston (R)**
> ""That never stopped any of our noble ancestors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Beatrice Livingston (R): ""We royals are an endangered breed, you know. We've got t..."*)

### Węzeł `[98]`
Mówca: **Beatrice Livingston (R)**
> ""We royals are an endangered breed, you know. We've got to tend to our lineages as we would a rose garden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""If that means inbreeding, perhaps it's best to let the g..."*)
  - -> `[122]` (*Player_Romus: ""I agree. But first cousins are too closely related for m..."*)
  - -> `[123]` (*Player_Romus: ""I don't see the harm in allowing a few exotic plants to ..."*)
  - -> `[126]` (*Player_Romus: ""Fear not. The garden of House Toras shall remain in bloo..."*)

### Węzeł `[99]`
Mówca: **Beatrice Livingston (R)**
> ""I'm sure you'll find just as suitable a match for my brilliant niece.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Beatrice Livingston (R): ""We royals are an endangered breed, you know. We've got t..."*)

### Węzeł `[100]`
Mówca: **Beatrice Livingston (R)**
> ""Indeed they would have. But you'll find another suitable a match for my brilliant niece, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Beatrice Livingston (R): ""We royals are an endangered breed, you know. We've got t..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == t..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""It doesn't matter, anyway. I already told her she can ma..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter, anyway. I already told her she can marry whomever she wants.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Kontekst wejściowy (poprzednik):** `[93]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Beatrice Livingston (R): ""Did you? My word.""*)

### Węzeł `[105]`
Mówca: **Beatrice Livingston (R)**
> ""Did you? My word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Beatrice Livingston (R): ""We royals are an endangered breed, you know. We've got t..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == t..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""I wouldn't know. I told her I won't be arranging her mar..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player_Romus: ""I'm on the lookout for candidates. Someone from one of o..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm on the lookout for candidates. Someone from one of our other royal houses, perhaps.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Beatrice Livingston (R): ""Very good. As you'll recall, I promised my Bradley to th..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""You'll have to ask her yourself. We're not on the best t..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll have to ask her yourself. We're not on the best terms these days.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Kontekst wejściowy (poprzednik):** `[89]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Beatrice Livingston (R): ""Oh? I'm sorry to hear that.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly, I have too much on my mind to even start to think about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Beatrice Livingston (R): ""Well, don't dilly-dally much longer. An unmarried royal ..."*)

### Węzeł `[115]`
Mówca: **Beatrice Livingston (R)**
> ""Very good. As you'll recall, I promised my Bradley to the Duchess of Thompsfort to secure the loyalty of our country's northwestern regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Beatrice Livingston (R): ""We royals are an endangered breed, you know. We've got t..."*)

### Węzeł `[116]`
Mówca: **Beatrice Livingston (R)**
> ""We royals are an endangered breed, you know. We've got to tend to our lineages as we would a rose garden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""I don't see the harm in allowing a few exotic plants to ..."*)
  - -> `[127]` (*Player_Romus: ""If that means forcing my daughter into an unhappy union,..."*)
  - -> `[126]` (*Player_Romus: ""Fear not. The garden of House Toras shall remain in bloo..."*)

### Węzeł `[117]`
Mówca: **Beatrice Livingston (R)**
> ""Oh? I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Beatrice Livingston (R): ""I lost my father at only 16, as you know. There were so ..."*)

### Węzeł `[118]`
Mówca: **Beatrice Livingston (R)**
> ""I lost my father at only 16, as you know. There were so many times over the years that I wished for his guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Beatrice Livingston (R): ""You're lucky to have such a relationship in your life. C..."*)

### Węzeł `[119]`
Mówca: **Beatrice Livingston (R)**
> ""Well, don't dilly-dally much longer. An unmarried royal is catnip for the tabloids.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Beatrice Livingston (R): ""They had quite the field day with my Bradley before I se..."*)

### Węzeł `[120]`
Mówca: **Beatrice Livingston (R)**
> ""They had quite the field day with my Bradley before I secured his betrothal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""Vina's a modest girl. She won't do anything worth gossip..."*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[346]` (*Player_Romus: ""Good point. I'll start thinking about candidates.""*)
  - -> `[347]` (*Player_Romus: ""Remind me, who is your son betrothed to again?""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that means inbreeding, perhaps it's best to let the garden die.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Beatrice Livingston (R): ""If the garden dies, your ties to House Livingston die wi..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. But first cousins are too closely related for my comfort.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Beatrice Livingston (R): ""Better a cousin than a commoner, no?""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see the harm in allowing a few exotic plants to blossom here and there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Beatrice Livingston (R)), `[116]` (Beatrice Livingston (R)), `[128]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Beatrice Livingston (R): ""Choose the wrong ones, and the weeds will spread faster ..."*)

### Węzeł `[124]`
Mówca: **Beatrice Livingston (R)**
> ""Choose the wrong ones, and the weeds will spread faster than you can pull them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Beatrice Livingston (R): ""And don't forget that the rest of GRACE is invested in t..."*)

### Węzeł `[125]`
Mówca: **Beatrice Livingston (R)**
> ""Better a cousin than a commoner, no?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fear not. The garden of House Toras shall remain in bloom for a long, long time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Beatrice Livingston (R)), `[116]` (Beatrice Livingston (R)), `[128]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Beatrice Livingston (R): ""With the help of House Livingston, it shall bloom on onl..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that means forcing my daughter into an unhappy union, perhaps it's best to let the garden die.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Beatrice Livingston (R): ""If the garden dies, your ties to House Livingston die wi..."*)

### Węzeł `[128]`
Mówca: **Beatrice Livingston (R)**
> ""We royals are an endangered breed, you know. We've got to tend to our lineages as we would a rose garden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""I don't see the harm in allowing a few exotic plants to ..."*)
  - -> `[126]` (*Player_Romus: ""Fear not. The garden of House Toras shall remain in bloo..."*)
  - -> `[129]` (*Player_Romus: ""Precisely my thinking. It's good to speak with someone w..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely my thinking. It's good to speak with someone who understands these things.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Beatrice Livingston (R): ""Anytime, my dear brother-in-law.""*)

### Węzeł `[130]`
Mówca: **Beatrice Livingston (R)**
> ""Anytime, my dear brother-in-law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Beatrice Livingston (R): ""And don't forget that the rest of GRACE is invested in t..."*)

### Węzeł `[131]`
Mówca: **Beatrice Livingston (R)**
> ""You're lucky to have such a relationship in your life. Cherish it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""Tell that to Vina.""*)
  - -> `[359]` (*Player_Romus: ""My daughter doesn't want my guidance anymore.""*)
  - -> `[360]` (*Player_Romus: ""I will try.""*)

### Węzeł `[132]`
Mówca: **Beatrice Livingston (R)**
> ""With the help of House Livingston, it shall bloom on only the richest of soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Beatrice Livingston (R): ""And don't forget that the rest of GRACE is invested in t..."*)

### Węzeł `[133]`
Mówca: **Beatrice Livingston (R)**
> ""If the garden dies, your ties to House Livingston die with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Beatrice Livingston (R): ""And don't forget that the rest of GRACE is invested in t..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Princess Marriage Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Beatrice Livingston (R): ""How are the princess' marriage plans coming along?""*)

### Węzeł `[135]`
Mówca: **Narrator**
> "An informal supper with my sister-in-law was scheduled for the evening. But for now, the protocol for an official diplomatic visit had to be observed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria");"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Pabel came in through the stateroom door. He took a deep ..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's on my council, you know.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Beatrice Livingston (R): ""Oh, my. So young, and already preparing for the crown.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's as stubborn as her mother was, that's for sure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Beatrice Livingston (R): ""Good girl. It's your royal obligation to give your fathe..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus: ""She's on my council, you know.""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""I wouldn't call her a 'lady''. She's been neglecting her..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't call her a 'lady''. She's been neglecting her duties as princess.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Queen Beatrice gave Vina a mock stern look."*)

### Węzeł `[143]`
Mówca: **Beatrice Livingston (R)**
> ""Oh, my. So young, and already preparing for the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Vina Toras: ""You were younger than me when you got yours, weren't you?""*)

### Węzeł `[144]`
Mówca: **Vina Toras**
> ""You were younger than me when you got yours, weren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""It's lovely to see you, Aunt Bea.""*)

### Węzeł `[145]`
Mówca: **Beatrice Livingston (R)**
> ""Good girl. It's your royal obligation to give your father hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Vina laughed."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Vina laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""It's lovely to see you, Aunt Bea.""*)

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""It's lovely to see you, Aunt Bea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Beatrice embraced her tightly before moving on to my mother."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Queen Beatrice gave Vina a mock stern look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Beatrice Livingston (R): ""It's your royal duty to give your father hell. And it se..."*)

### Węzeł `[149]`
Mówca: **Beatrice Livingston (R)**
> ""It's your royal duty to give your father hell. And it seems you're performing it admirably.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Vina laughed."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am. And I know Lena would have been, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Vina beamed."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Vina managed a weak smile."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Vina beamed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""It's lovely to see you, Aunt Bea.""*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Vina managed a weak smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""It's lovely to see you, Aunt Bea.""*)

### Węzeł `[156]`
Mówca: **Narrator**
> "The two women gave each other air kisses, then stood back and eyed each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Estela Toras: ""Queen Beatrice.""*)

### Węzeł `[157]`
Mówca: **Estela Toras**
> ""Is that so, Your Excellency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Estela Toras: ""Funny, I do seem to detect an unpleasant draft of hot ai..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras"); RemoveConversant("Vina Toras");
RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Beatrice motioned for her own attendants to wait outside...."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Beatrice motioned for her own attendants to wait outside. We settled into our seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Queen Mother Estela may have a common upbringing, but sh..."*)
  - -> `[37]` (*Player_Romus: ""To what do we owe this pleasure, Your Excellency?""*)
  - -> `[36]` (*Player_Romus: ""How is your own family?""*)
  - -> `[38]` (*Player_Romus_Italic: "Sip your tea."*)

### Węzeł `[160]`
Mówca: **Beatrice Livingston (R)**
> ""I find your mother ever so charming. I never believed those nasty rumors about her one bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Queen Beatrice extended her little finger and raised her ..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "Queen Beatrice extended her little finger and took a sip from her own cup. She smiled approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Beatrice Livingston (R): ""Just like home. My compliments to your butler.""*)

### Węzeł `[162]`
Mówca: **Beatrice Livingston (R)**
> ""As you may know, Rumburg is currently a major importer of Wehzek oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Beatrice Livingston (R): ""If we were to significantly reduce our imports, the fina..."*)

### Węzeł `[163]`
Mówca: **Beatrice Livingston (R)**
> ""Our nations are bound by our shared love for my sister. Such a relationship goes beyond mere transaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)

### Węzeł `[164]`
Mówca: **Beatrice Livingston (R)**
> ""Should you wish for something a little less subtle, I have a suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Beatrice Livingston (R): ""As you may know, Rumburg is currently a major importer o..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true;
RiziaDLC.Energy_Modifier_RumburgEnergyExport -= 1; 
RiziaDLC.Budget_Modifier_RumburgTrade += 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1;
RiziaDLC.Resources_Energy -= 2;
RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport = true;
RiziaDLCSupport.Reports_Turn03_RumburgBuysLessOil = true;
RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] = true;
Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] = Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] - 1;
Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] = Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] + 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 1;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] - 2;
Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] = true;
Variable["RiziaDLCSupport.Reports_Turn03_RumburgBuysLessOil"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Beatrice Livingston (R): ""This will all need to be formalized by my parliament and..."*)

### Węzeł `[166]`
Mówca: **Beatrice Livingston (R)**
> ""Of course, an immediate modernization of your Monqiz port would be required to handle the excess shipping traffic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""That can be arranged.""*)
  - -> `[169]` (*Player_Romus: ""That's a lot to demand for a plan that may not even be u..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We always try to stay ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Beatrice Livingston (R): ""I can see. Good job.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love it. You buy less oil from Wehlen, and we'll make up the difference with natural gas and other energy sources.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[180]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Beatrice Livingston (R): ""Thrilling. How much less oil shall we buy, then?""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a lot to demand for a plan that may not even be useful or necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Beatrice Livingston (R): ""Even if you don't ship us gas, getting that port into ti..."*)

### Węzeł `[170]`
Mówca: **Beatrice Livingston (R)**
> ""I'm quite sure some of the same ships that carry out our gold trade can be retrofitted to transport natural gas in its liquified form.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Pr..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That can be arranged.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Beatrice Livingston (R): ""Even if you don't ship us gas, getting that port into ti..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be honest, I'm satisfied with our countries' current trade relations. I don't want to complicate them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Beatrice Livingston (R): ""Are you quite sure? Remember, bilateral relations always..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Interesting. But how would Rizian gas even reach Rumburg from here?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == false`
- **Kontekst wejściowy (poprzednik):** `[225]` (Beatrice Livingston (R)), `[459]` (Beatrice Livingston (R)), `[221]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Beatrice Livingston (R): ""I'm quite sure some of the same ships that carry out our..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would we have to replace all the oil you've been purchasing? What about only part of it?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == false`
- **Kontekst wejściowy (poprzednik):** `[225]` (Beatrice Livingston (R)), `[459]` (Beatrice Livingston (R)), `[221]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Beatrice Livingston (R): ""Rumburg would prefer to eliminate its energy dependence ..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you believe Wehlen can't find another customer?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == false`
- **Kontekst wejściowy (poprzednik):** `[225]` (Beatrice Livingston (R)), `[459]` (Beatrice Livingston (R)), `[221]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Beatrice Livingston (R): ""Believe it or not, Wiktor Smolak has managed to alienate..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a serious promise. What happens if I can't keep up my end of the guarantee?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == false`
- **Kontekst wejściowy (poprzednik):** `[225]` (Beatrice Livingston (R)), `[459]` (Beatrice Livingston (R)), `[221]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Beatrice Livingston (R): ""We'll have to find a more reliable trading partner. For ..."*)

### Węzeł `[177]`
Mówca: **Beatrice Livingston (R)**
> ""Rumburg would prefer to eliminate its energy dependence on Wehlen entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Beatrice Livingston (R): ""But of course, we wouldn't want Rizia to make any overly..."*)

### Węzeł `[178]`
Mówca: **Beatrice Livingston (R)**
> ""Believe it or not, Wiktor Smolak has managed to alienate Wehlen from most of its neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Beatrice Livingston (R): ""I know our partners in GRACE would surely follow suit an..."*)

### Węzeł `[179]`
Mówca: **Beatrice Livingston (R)**
> ""We'll have to find a more reliable trading partner. For energy as well as other materials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Beatrice Livingston (R): ""And I will be most displeased.""*)

### Węzeł `[180]`
Mówca: **Beatrice Livingston (R)**
> ""And? What do you think of the idea?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 2"*)
  - -> `[181]` (*Player_Romus: ""I can't promise you anything. Rizia is indeed expanding ..."*)
  - -> `[172]` (*Player_Romus: ""To be honest, I'm satisfied with our countries' current ..."*)
  - -> `[338]` (*Player_Romus: ""I just don't see it. Even if my goal was to put the sque..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't promise you anything. Rizia is indeed expanding its energy horizons, but we have other potential buyers in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Beatrice Livingston (R): ""You would turn your back on family that easily?""*)

### Węzeł `[182]`
Mówca: **Beatrice Livingston (R)**
> ""Thrilling. How much less oil shall we buy, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player_Romus: ""Actually, I'm beginning to have second thoughts. Let's k..."*)
  - -> `[183]` (*Player_Romus: ""Can you halve your imports? We will provide some from ou..."*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 3"*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""Can you halve your imports? We will provide some from our stockpiles now and more in the future." [-2 Energy, -1 Energy Per Turn, +1 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""Can you halve your imports? We will provide some from our stockpiles now and more in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Beatrice Livingston (R): ""Certainly. It may not have as much of an impact as you w..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: ""Screw it, Your Excellency. Cut off Wehlen completely." [-3 Energy, -2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""Screw it, Your Excellency. Cut off Wehlen completely.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[182]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Beatrice smiled."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Beatrice smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Beatrice Livingston (R): ""Very bold of you. My sister didn't marry a man who takes..."*)

### Węzeł `[186]`
Mówca: **Beatrice Livingston (R)**
> ""Very bold of you. My sister didn't marry a man who takes half measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Beatrice Livingston (R): ""I feel obliged to ask once more: Are you positive you'll..."*)

### Węzeł `[187]`
Mówca: **Beatrice Livingston (R)**
> ""You would turn your back on family that easily?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Beatrice Livingston (R): ""Remember who got you into GRACE, Your Majesty. And on wh..."*)

### Węzeł `[188]`
Mówca: **Beatrice Livingston (R)**
> ""Are you quite sure? Remember, bilateral relations always need maintaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: ""Yes, I'm sure. Shall we change the subject?""*)
  - -> `[519]` (*Player_Romus: ""I treasure our alliance, Beatrice. I just don't believe ..."*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 2;"*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 2"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Princess Marriage Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "Princess Marriage Talk"*)

### Węzeł `[190]`
Mówca: **Beatrice Livingston (R)**
> ""I can see. Good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics = true"*)

### Węzeł `[191]`
Mówca: **Beatrice Livingston (R)**
> ""Even if you don't ship us gas, getting that port into tip-top shape would make our gold trade more efficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics = true"*)

### Węzeł `[192]`
Mówca: **Beatrice Livingston (R)**
> ""If we were to significantly reduce our imports, the financial pressure -- and thus your leverage over Wehlen -- would be considerable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""Wait. How much oil are you importing from Wehlen?""*)
  - -> `[194]` (*Player_Romus: ""I thought you hated Wehlen. But you're buying their oil?""*)
  - -> `[213]` (*Player_Romus: ""You'd deprive your own people of energy just to help Riz..."*)
  - -> `[197]` (*Player_Romus: ""I don't need leverage over Wehlen.""*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. How much oil are you importing from Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Beatrice Livingston (R): ""Enough to seriously make a dent in the country's economy..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you hated Wehlen. But you're buying their oil?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Beatrice Livingston (R): ""Don't look so shocked. It's a partnership of convenience.""*)

### Węzeł `[195]`
Mówca: **Beatrice Livingston (R)**
> ""Don't look so shocked. It's a partnership of convenience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Beatrice Livingston (R): ""But in fact, my advisors and I have been speaking about ..."*)

### Węzeł `[196]`
Mówca: **Beatrice Livingston (R)**
> ""Enough to seriously make a dent in the country's economy were our purchase orders to diminish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Beatrice Livingston (R): ""But in fact, my advisors and I have been speaking about ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need leverage over Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Beatrice Livingston (R): ""Leverage isn't the only thing I'm offering you.""*)

### Węzeł `[198]`
Mówca: **Beatrice Livingston (R)**
> ""Leverage isn't the only thing I'm offering you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Beatrice Livingston (R): ""My advisors and I have been speaking about forging new e..."*)

### Węzeł `[199]`
Mówca: **Beatrice Livingston (R)**
> ""But in fact, my advisors and I have been speaking about forging new energy partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Beatrice Livingston (R): ""And as it happens, Rizia is about to come into possessio..."*)

### Węzeł `[200]`
Mówca: **Beatrice Livingston (R)**
> ""And as it happens, Rizia is about to come into possession of quite a bit of natural gas, correct?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""Yes, we've discovered a new gas field. It's very exciting.""*)
  - -> `[202]` (*Player_Romus: ""We don't know yet. Our scientists are still figuring out..."*)
  - -> `[203]` (*Player_Romus: ""At least some of it belongs to Pales.""*)
  - -> `[204]` (*Player_Romus: ""Rizia has enough natural gas already. We're not looking ..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we've discovered a new gas field. It's very exciting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Beatrice Livingston (R): ""How grand.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't know yet. Our scientists are still figuring out the details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Beatrice Livingston (R): ""I see. Very interesting.""*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At least some of it belongs to Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Beatrice Livingston (R): ""If you say so.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has enough natural gas already. We're not looking for more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Beatrice Livingston (R): ""Hmm. Perhaps my intelligence was mistaken.""*)

### Węzeł `[205]`
Mówca: **Beatrice Livingston (R)**
> ""Hmm. Perhaps my intelligence was mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Beatrice Livingston (R): ""I was about to propose that Rumburg purchase Rizian ener..."*)

### Węzeł `[206]`
Mówca: **Beatrice Livingston (R)**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Beatrice Livingston (R): ""I was about to propose that Rumburg purchase Rizian ener..."*)

### Węzeł `[207]`
Mówca: **Beatrice Livingston (R)**
> ""I was about to propose that Rumburg purchase Rizian energy in lieu of Wehzek oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Beatrice Livingston (R): ""We enrich your country and assist you with your Wehlen p..."*)

### Węzeł `[208]`
Mówca: **Beatrice Livingston (R)**
> ""We enrich your country and assist you with your Wehlen problem in one fell swoop.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player_Romus: ""What kind of timeline are you thinking about?""*)
  - -> `[217]` (*Player_Romus: ""Generous, Your Excellency. But I can't guarantee that we..."*)
  - -> `[218]` (*Player_Romus: ""I promise you access to the gas from that field and you'..."*)
  - -> `[226]` (*Player_Romus: ""Sorry, Your Excellency. I can already tell you I'm not i..."*)

### Węzeł `[209]`
Mówca: **Beatrice Livingston (R)**
> ""How grand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Beatrice Livingston (R): ""My proposal, then, would be for Rumburg to purchase Rizi..."*)

### Węzeł `[210]`
Mówca: **Beatrice Livingston (R)**
> ""My proposal, then, would be for Rumburg to purchase Rizian energy in lieu of Wehzek oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Beatrice Livingston (R): ""We enrich your country and assist you with your Wehlen p..."*)

### Węzeł `[211]`
Mówca: **Beatrice Livingston (R)**
> ""I see. Very interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Beatrice Livingston (R): ""I was about to propose that Rumburg purchase Rizian ener..."*)

### Węzeł `[212]`
Mówca: **Beatrice Livingston (R)**
> ""My advisors and I have been speaking about forging new energy partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Beatrice Livingston (R): ""And as it happens, Rizia is about to come into possessio..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd deprive your own people of energy just to help Rizia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Beatrice Livingston (R): ""I most certainly would not.""*)

### Węzeł `[214]`
Mówca: **Beatrice Livingston (R)**
> ""I most certainly would not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Beatrice Livingston (R): ""But in fact, my advisors and I have been speaking about ..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Rumburg Gas Qs`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == ..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomer..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == tru..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of timeline are you thinking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Beatrice Livingston (R): ""We can cut off our orders of Wehzek oil immediately, as ..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Generous, Your Excellency. But I can't guarantee that we'll be able to access that gas field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Beatrice Livingston (R): ""It doesn't have to be that one particular gas field, to ..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise you access to the gas from that field and you'll stop purchasing oil from Wehlen. I like the sound of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Beatrice Livingston (R): ""It doesn't have to be that one particular gas field, to ..."*)

### Węzeł `[219]`
Mówca: **Beatrice Livingston (R)**
> ""It doesn't have to be that one particular gas field, to be honest. We'll accept other sources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Beatrice Livingston (R): ""Grant us a small amount of energy to add to our stockpil..."*)

### Węzeł `[220]`
Mówca: **Beatrice Livingston (R)**
> ""Grant us a small amount of energy to add to our stockpile now, and we can cut off Wehlen immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Beatrice Livingston (R): ""We'd then give you a one-year grace period to make the t..."*)

### Węzeł `[221]`
Mówca: **Beatrice Livingston (R)**
> ""And I will be most displeased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse = true"*)

### Węzeł `[222]`
Mówca: **Beatrice Livingston (R)**
> ""I know our partners in GRACE would surely follow suit and cut their own ties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomer..."*)

### Węzeł `[223]`
Mówca: **Beatrice Livingston (R)**
> ""But of course, we wouldn't want Rizia to make any overly rash promises. So yes, a partial embargo on our end is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount = true"*)

### Węzeł `[224]`
Mówca: **Beatrice Livingston (R)**
> ""We can cut off our orders of Wehzek oil immediately, as long as you grant us a small amount of energy upfront to add to our stockpile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Beatrice Livingston (R): ""We'd then give you a one-year grace period to make the t..."*)

### Węzeł `[225]`
Mówca: **Beatrice Livingston (R)**
> ""We'd then give you a one-year grace period to make the transition. After which, I warn you, our needs will be quite substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Rumburg Gas Qs"*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, Your Excellency. I can already tell you I'm not interested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Beatrice Livingston (R): ""Ah, well.""*)

### Węzeł `[227]`
Mówca: **Beatrice Livingston (R)**
> ""Ah, well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "Her teacup made a soft clink as she placed it on her saucer."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "Her teacup made a soft clink as she placed it on her saucer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Beatrice Livingston (R): ""It seemed most convenient to me.""*)

### Węzeł `[229]`
Mówca: **Beatrice Livingston (R)**
> ""It seemed most convenient to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Beatrice Livingston (R): ""But let's move on to equally important matters.""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Princess Marriage Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "Princess Marriage Talk"*)

### Węzeł `[231]`
Mówca: **Narrator**
> "Queen Beatrice extended her little finger and raised her teacup to her lips. She smiled approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Beatrice Livingston (R): ""Just like home. My compliments to your butler.""*)

### Węzeł `[232]`
Mówca: **Beatrice Livingston (R)**
> ""Just like home. My compliments to your butler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Beatrice Livingston (R): ""Now. How are you faring a year into your reign? I know y..."*)

### Węzeł `[233]`
Mówca: **Beatrice Livingston (R)**
> ""Now. How are you faring a year into your reign? I know you had quite the scare in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus: ""I was never scared. Rizians weren't the target, after all.""*)
  - -> `[235]` (*Player_Romus: ""Yes, Mother and I were lucky to get out with our lives.""*)
  - -> `[236]` (*Player_Romus: ""I'm less scared by what happened than by the ramificatio..."*)
  - -> `[237]` (*Player_Romus: ""I have good security. And everything's under control now.""*)
  - -> `[482]` (*Player_Romus: ""I hope you had nothing to do with it.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was never scared. Rizians weren't the target, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Beatrice Livingston (R): ""No, they weren't. How curious.""*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Mother and I were lucky to get out with our lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Beatrice Livingston (R): ""No Rizians were harmed at all, in fact. How curious.""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm less scared by what happened than by the ramifications of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Beatrice Livingston (R): ""That is the correct manner of thinking.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have good security. And everything's under control now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Beatrice Livingston (R): ""I do hope that's true.""*)

### Węzeł `[238]`
Mówca: **Beatrice Livingston (R)**
> ""That is the correct manner of thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Beatrice Livingston (R): ""Needless to say, Rumburg has been monitoring the fallout..."*)

### Węzeł `[239]`
Mówca: **Beatrice Livingston (R)**
> ""No Rizians were harmed at all, in fact. How curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Beatrice Livingston (R): ""Needless to say, Rumburg has been monitoring the fallout..."*)

### Węzeł `[240]`
Mówca: **Beatrice Livingston (R)**
> ""No, they weren't. How curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Beatrice Livingston (R): ""Needless to say, Rumburg has been monitoring the fallout..."*)

### Węzeł `[241]`
Mówca: **Beatrice Livingston (R)**
> ""I do hope that's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Beatrice Livingston (R): ""Needless to say, Rumburg has been monitoring the fallout..."*)

### Węzeł `[242]`
Mówca: **Beatrice Livingston (R)**
> ""Needless to say, Rumburg has been monitoring the fallout of the incident with great concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Romus: ""Your concern is much appreciated.""*)
  - -> `[244]` (*Player_Romus: ""Why? How does what happened affect you?""*)
  - -> `[245]` (*Player_Romus: ""So you came all the way to Porte Drazon to... express yo..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your concern is much appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "She nodded."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? How does what happened affect you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Beatrice Livingston (R): ""Aside from my worries about your personal safety, you me..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you came all the way to Porte Drazon to... express your concern?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Beatrice Livingston (R): ""I don't need an excuse to see my extended family.""*)

### Węzeł `[246]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Beatrice Livingston (R): ""Aside from my worries about your personal safety, I fore..."*)

### Węzeł `[247]`
Mówca: **Beatrice Livingston (R)**
> ""Aside from my worries about your personal safety, I foresee a scenario where Wehlen uses this tragedy to its own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Beatrice Livingston (R): ""And Wehlen amassing more power is not in either of our i..."*)

### Węzeł `[248]`
Mówca: **Beatrice Livingston (R)**
> ""I don't need an excuse to see my extended family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Beatrice Livingston (R): ""But aside from my worries about your personal safety, I ..."*)

### Węzeł `[249]`
Mówca: **Beatrice Livingston (R)**
> ""But aside from my worries about your personal safety, I foresee a scenario where Wehlen uses this tragedy to its own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Beatrice Livingston (R): ""And Wehlen amassing more power is not in either of our i..."*)

### Węzeł `[250]`
Mówca: **Beatrice Livingston (R)**
> ""Aside from my worries about your personal safety, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Beatrice Livingston (R): ""I foresee a scenario where Wehlen uses this tragedy to i..."*)

### Węzeł `[251]`
Mówca: **Beatrice Livingston (R)**
> ""I foresee a scenario where Wehlen uses this tragedy to its own gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Beatrice Livingston (R): ""And Wehlen amassing more power is not in either of our i..."*)

### Węzeł `[252]`
Mówca: **Beatrice Livingston (R)**
> ""And Wehlen amassing more power is not in either of our interests, correct, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""Not as long as they have our land.""*)
  - -> `[254]` (*Player_Romus: ""No. We've got to be very careful not to stir the pot fur..."*)
  - -> `[255]` (*Player_Romus: ""If they try, they will face the consequences.""*)
  - -> `[256]` (*Player_Romus: ""I only want peace with Wehlen. Our countries have a hist..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not as long as they have our land.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Beatrice Livingston (R): ""Precisely.""*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. We've got to be very careful not to stir the pot further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Beatrice Livingston (R): ""It's more important not to capitulate.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they try, they will face the consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Beatrice Livingston (R): ""Precisely.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only want peace with Wehlen. Our countries have a historical bond.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Beatrice Livingston (R): ""It's more important not to capitulate.""*)

### Węzeł `[257]`
Mówca: **Beatrice Livingston (R)**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Beatrice leaned forward and held my gaze."*)

### Węzeł `[258]`
Mówca: **Beatrice Livingston (R)**
> ""It's more important not to capitulate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Beatrice leaned forward and held my gaze."*)

### Węzeł `[259]`
Mówca: **Beatrice Livingston (R)**
> ""You and I are royals, Romus. For us, family and politics are one and the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_AntiMonarchy == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Beatrice Livingston (R): ""Or would you rather talk about how your coronation speec..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_AntiMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HadAffairs == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Beatrice Livingston (R): ""Or would you rather talk about how your affairs humiliat..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HadAffairs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Beatrice Livingston (R): ""Or would you rather talk about how your daughter is near..."*)

### Węzeł `[266]`
Mówca: **Beatrice Livingston (R)**
> ""Or would you rather talk about how your coronation speech angered our partners in GRACE?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed = true"*)

### Węzeł `[267]`
Mówca: **Beatrice Livingston (R)**
> ""Or would you rather talk about how your affairs humiliated my sister until the day she died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""That's quite all right. Tell me your idea.""*)
  - -> `[299]` (*Player_Romus: ""What affairs?""*)
  - -> `[272]` (*Player_Romus: ""I'm so sorry. It was never my intention to be unfaithful.""*)
  - -> `[273]` (*Player_Romus: ""She told you about that?""*)

### Węzeł `[268]`
Mówca: **Beatrice Livingston (R)**
> ""Or would you rather talk about how your daughter is nearly 20 and still not betrothed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""That's quite all right. Tell me your idea.""*)
  - -> `[313]` (*Player_Romus: ""You know what? Let's talk about that instead.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's quite all right. Tell me your idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Beatrice Livingston (R)), `[268]` (Beatrice Livingston (R)), `[266]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Beatrice smiled fiercely."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Beatrice smiled fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "Jump to: [Natural Gas Talk]"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was so controversial about it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Beatrice Livingston (R): ""Now, now. Don't play coy.""*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm so sorry. It was never my intention to be unfaithful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Beatrice Livingston (R): ""Oh, it's never anyone's intention.""*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She told you about that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Beatrice Livingston (R): ""She told me everything, Your Majesty.""*)

### Węzeł `[274]`
Mówca: **Beatrice Livingston (R)**
> ""She told me everything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Beatrice Livingston (R): ""Lena was able to put her personal resentments aside for ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about GRACE?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Beatrice Livingston (R): ""You are as crucial of a member as Rumburg, Your Majesty...."*)

### Węzeł `[276]`
Mówca: **Beatrice Livingston (R)**
> ""Now, now. Don't play coy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Beatrice Livingston (R): ""Just as the world's remaining monarchies pledge to enter..."*)

### Węzeł `[277]`
Mówca: **Beatrice Livingston (R)**
> ""You are as crucial of a member as Rumburg, Your Majesty. Do not feign naivete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Beatrice Livingston (R): ""Just as the world's remaining monarchies pledge to enter..."*)

### Węzeł `[278]`
Mówca: **Beatrice Livingston (R)**
> ""Just as the world's remaining monarchies pledge to enter an era of increased cooperation, you tell your entire country you intend on 'giving the people a voice'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Beatrice Livingston (R): ""What am I to make of that, Your Majesty? Or Nahrburk, or..."*)

### Węzeł `[279]`
Mówca: **Beatrice Livingston (R)**
> ""What am I to make of that, Your Majesty? Or Nahrburk, or the Baronies of Soradis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""You can all make of it what you will.""*)
  - -> `[281]` (*Player_Romus: ""I got carried away in the moment. I didn't really mean it.""*)
  - -> `[280]` (*Player_Romus: ""Giving people a voice doesn't mean giving up monarchy. I..."*)
  - -> `[284]` (*Player_Romus: ""I didn't realize that GRACE was so attuned to my actions..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving people a voice doesn't mean giving up monarchy. Isn't your own country governed by a parliament?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Beatrice Livingston (R): ""Technically, yes. But it has roughly as much power as yo..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I got carried away in the moment. I didn't really mean it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)

### Węzeł `[282]`
Mówca: **Beatrice Livingston (R)**
> ""Technically, yes. But it has roughly as much power as your 'House of Delegates'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Beatrice Livingston (R): ""You were lucky to escape the 1926 uprising with your hea..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can all make of it what you will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Beatrice Livingston (R): ""I hardly think such a flippant answer is appropriate.""*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize that GRACE was so attuned to my actions as king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Beatrice Livingston (R): ""You are the unproven ruler of one of GRACE's linchpin co..."*)

### Węzeł `[285]`
Mówca: **Beatrice Livingston (R)**
> ""You are the unproven ruler of one of GRACE's linchpin countries. Don't be surprised that you are under scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Beatrice Livingston (R): ""Of course you are free to run your country the way you l..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Beatrice Livingston (R): ""I hear your behavior as king has suggested otherwise.""*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Beatrice Livingston (R): ""It's an odd promise to simply blurt out.""*)

### Węzeł `[289]`
Mówca: **Beatrice Livingston (R)**
> ""I hear your behavior as king has suggested otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Beatrice Livingston (R): ""Of course you are free to run your country the way you l..."*)

### Węzeł `[290]`
Mówca: **Beatrice Livingston (R)**
> ""It's an odd promise to simply blurt out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Beatrice Livingston (R): ""You were lucky to escape the 1926 uprising with your hea..."*)

### Węzeł `[291]`
Mówca: **Beatrice Livingston (R)**
> ""I hardly think such a flippant answer is appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Beatrice Livingston (R): ""You were lucky to escape the 1926 uprising with your hea..."*)

### Węzeł `[292]`
Mówca: **Beatrice Livingston (R)**
> ""You were lucky to escape the 1926 uprising with your head. To make such a public overture towards democracy is to tempt fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player_Romus: ""Don't worry, Your Excellency. The Rizian monarchy is not..."*)
  - -> `[295]` (*Player_Romus: ""Thank you for warning me. I shall keep your words in mind.""*)
  - -> `[296]` (*Player_Romus: ""I know what I'm getting myself into.""*)

### Węzeł `[293]`
Mówca: **Beatrice Livingston (R)**
> ""Of course you are free to run your country the way you like. But without GRACE's backing, you will be at the mercy of ATO and the CSP like every other country on this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player_Romus: ""Don't worry, Your Excellency. The Rizian monarchy is not..."*)
  - -> `[295]` (*Player_Romus: ""Thank you for warning me. I shall keep your words in mind.""*)
  - -> `[296]` (*Player_Romus: ""I know what I'm getting myself into.""*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Your Excellency. The Rizian monarchy is not going anywhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Beatrice Livingston (R)), `[293]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Beatrice Livingston (R): ""Wehlen might beg to differ.""*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for warning me. I shall keep your words in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Beatrice Livingston (R)), `[293]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Beatrice Livingston (R): ""I hope you shall do more than that.""*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know what I'm getting myself into.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Beatrice Livingston (R)), `[293]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "She regarded me warily."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "She regarded me warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Beatrice Livingston (R): ""Very well.""*)

### Węzeł `[298]`
Mówca: **Beatrice Livingston (R)**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Beatrice Livingston (R): ""Now, are you sure you don't want to hear my proposal reg..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What affairs?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "She rolled her eyes."*)

### Węzeł `[300]`
Mówca: **Beatrice Livingston (R)**
> ""Oh, it's never anyone's intention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Beatrice Livingston (R): ""Lena was able to put her personal resentments aside for ..."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "She rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Beatrice Livingston (R): ""Excuse my short breach of decorum, but don't bullshit me..."*)

### Węzeł `[302]`
Mówca: **Beatrice Livingston (R)**
> ""Excuse my short breach of decorum, but don't bullshit me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Beatrice Livingston (R): ""Lena was able to put her personal resentments aside for ..."*)

### Węzeł `[303]`
Mówca: **Beatrice Livingston (R)**
> ""Lena was able to put her personal resentments aside for the sake of the bond between our kingdoms. I have tried to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Beatrice Livingston (R): ""But should that bond in any way falter, I cannot promise..."*)

### Węzeł `[304]`
Mówca: **Beatrice Livingston (R)**
> ""But should that bond in any way falter, I cannot promise those resentments will not color my judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player_Romus: ""I understand what you're getting at. Let's talk about We..."*)
  - -> `[306]` (*Player_Romus: ""Same here, Your Excellency.""*)
  - -> `[307]` (*Player_Romus: ""The bond will not falter. Don't forget there's also Vina.""*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand what you're getting at. Let's talk about Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Beatrice smiled fiercely."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same here, Your Excellency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "Beatrice glared at me, then smiled insincerely."*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The bond will not falter. Don't forget there's also Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "Beatrice smiled."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "Beatrice glared at me, then smiled insincerely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Beatrice Livingston (R): ""Now.""*)

### Węzeł `[309]`
Mówca: **Beatrice Livingston (R)**
> ""Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Princess Marriage Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "Princess Marriage Talk"*)

### Węzeł `[311]`
Mówca: **Narrator**
> "Beatrice smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Beatrice Livingston (R): ""Actually, I've been meaning to ask.""*)

### Węzeł `[312]`
Mówca: **Beatrice Livingston (R)**
> ""Actually, I've been meaning to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? Let's talk about that instead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Beatrice Livingston (R): ""Very well, Your Majesty.""*)

### Węzeł `[314]`
Mówca: **Beatrice Livingston (R)**
> ""Very well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Natural Gas Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Beatrice Livingston (R): ""Here's what I suggest, Your Majesty.""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Natural Gas Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "Natural Gas Talk"*)

### Węzeł `[317]`
Mówca: **Beatrice Livingston (R)**
> ""Moving on to equally important matters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Beatrice Livingston (R): ""We Rumburgians do agree with Wehlen on one thing. The ri..."*)

### Węzeł `[318]`
Mówca: **Beatrice Livingston (R)**
> ""But let's move on to equally important matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[319]`
Mówca: **Beatrice Livingston (R)**
> ""I hope you shall do more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Beatrice Livingston (R): ""Now, are you sure you don't want to hear my proposal reg..."*)

### Węzeł `[320]`
Mówca: **Beatrice Livingston (R)**
> ""Wehlen might beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Beatrice Livingston (R): ""Are you sure you don't want to hear my proposal, by the ..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == f..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""This is a serious promise. What happens if I can't keep ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomer..."*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustom..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player_Romus: ""So you believe Wehlen can't find another customer?""*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == f..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""Would we have to replace all the oil you've been purchas..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == ..."*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics =..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""Interesting. But how would Rizian gas even reach Rumburg..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == tru..."*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == t..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""Okay. I think I have a good grasp on the particulars of ..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount == true || RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. I think I have a good grasp on the particulars of the deal you're suggesting.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] == true  or  Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] == true`
- **Kontekst wejściowy (poprzednik):** `[225]` (Beatrice Livingston (R)), `[459]` (Beatrice Livingston (R)), `[221]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Beatrice Livingston (R): ""And? What do you think of the idea?""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rumburg Gas Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Rumburg Gas Qs"*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just don't see it. Even if my goal was to put the squeeze on Wehlen, this is not the most efficient way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Beatrice Livingston (R): ""Suit yourself, Your Majesty.""*)

### Węzeł `[339]`
Mówca: **Beatrice Livingston (R)**
> ""Suit yourself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 2;"*)

### Węzeł `[340]`
Mówca: **Beatrice Livingston (R)**
> ""Are you sure you don't want to hear my proposal, by the way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""You do seem quite keen on it. I would be remiss not to h..."*)
  - -> `[405]` (*Player_Romus: ""I'm sure, Your Excellency.""*)

### Węzeł `[341]`
Mówca: **Beatrice Livingston (R)**
> ""Now, are you sure you don't want to hear my proposal regarding Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""You do seem quite keen on it. I would be remiss not to h..."*)
  - -> `[405]` (*Player_Romus: ""I'm sure, Your Excellency.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You do seem quite keen on it. I would be remiss not to hear you out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Beatrice Livingston (R)), `[341]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "Beatrice smiled fiercely."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "Beatrice smiled fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "Jump to: [Natural Gas Talk]"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Natural Gas Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "Natural Gas Talk"*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's a modest girl. She won't do anything worth gossiping about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Beatrice Livingston (R): ""Never underestimate the ability of the international pre..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. I'll start thinking about candidates.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Beatrice Livingston (R): ""It's high time you do.""*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me, who is your son betrothed to again?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Beatrice Livingston (R): ""Why, the Duchess of Thompsfort, of course. Her family co..."*)

### Węzeł `[348]`
Mówca: **Beatrice Livingston (R)**
> ""Why, the Duchess of Thompsfort, of course. Her family controls most of northwestern Rumburg. And she's got good birthing hips.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Beatrice Livingston (R): ""As you can see, I put some careful thought into the deci..."*)

### Węzeł `[349]`
Mówca: **Beatrice Livingston (R)**
> ""It's high time you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[350]`
Mówca: **Beatrice Livingston (R)**
> ""Never underestimate the ability of the international press to manufacture royal scandals from thin air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player_Romus: ""If the Rizian tabloids try something like that, I'll shu..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the Rizian tabloids try something like that, I'll shut them down.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[120]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Beatrice Livingston (R): ""It's not only Rizia who's paying attention, Your Majesty.""*)

### Węzeł `[355]`
Mówca: **Beatrice Livingston (R)**
> ""It's not only Rizia who's paying attention, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[356]`
Mówca: **Beatrice Livingston (R)**
> ""Don't forget the rest of GRACE is invested in the Toras line of succession as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true"*)

### Węzeł `[357]`
Mówca: **Beatrice Livingston (R)**
> ""As you can see, I put some careful thought into the decision. And so should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell that to Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Beatrice Livingston (R): ""Perhaps I will.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter doesn't want my guidance anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Beatrice Livingston (R): ""But she may need it. Especially when it comes to her mar..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Beatrice Livingston (R): ""See that you do.""*)

### Węzeł `[361]`
Mówca: **Beatrice Livingston (R)**
> ""But she may need it. Especially when it comes to her marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[362]`
Mówca: **Beatrice Livingston (R)**
> ""Perhaps I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[363]`
Mówca: **Beatrice Livingston (R)**
> ""See that you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Beatrice Livingston (R): ""Don't forget the rest of GRACE is invested in the Toras ..."*)

### Węzeł `[364]`
Mówca: **Beatrice Livingston (R)**
> ""And don't forget that the rest of GRACE is invested in the Toras line of succession as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She rose to leave."]"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_AntiMonarchy == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Beatrice Livingston (R): ""Our partners will be looking for reassurance after your ..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_AntiMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Beatrice Livingston (R): ""Rizia is one of its linchpin nations, after all.""*)

### Węzeł `[371]`
Mówca: **Beatrice Livingston (R)**
> ""Our partners will be looking for reassurance after your coronation speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Player_Romus: ""My speech?""*)
  - -> `[373]` (*Player_Romus: ""Which partners do you mean?""*)
  - -> `[372]` (*Player_Romus: ""What was so controversial about it?""*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was so controversial about it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Beatrice Livingston (R): ""Now, now. Don't play coy.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which partners do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Beatrice Livingston (R): ""All of them, Your Majesty.""*)

### Węzeł `[374]`
Mówca: **Beatrice Livingston (R)**
> ""Now, now. Don't play coy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Beatrice Livingston (R): ""Just as the world's remaining monarchies pledge to enter..."*)

### Węzeł `[375]`
Mówca: **Beatrice Livingston (R)**
> ""All of them, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Beatrice Livingston (R): ""Just as the world's remaining monarchies pledge to enter..."*)

### Węzeł `[376]`
Mówca: **Beatrice Livingston (R)**
> ""Just as the world's remaining monarchies pledge to enter an era of increased cooperation, you tell your entire country you intend on 'giving the people a voice'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Beatrice Livingston (R): ""What am I to make of that, Your Majesty? Or Nahrburk, or..."*)

### Węzeł `[377]`
Mówca: **Beatrice Livingston (R)**
> ""What am I to make of that, Your Majesty? Or Nahrburk, or the Baronies of Soradis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Player_Romus: ""You can all make of it what you will.""*)
  - -> `[379]` (*Player_Romus: ""I got carried away in the moment. I didn't really mean it.""*)
  - -> `[378]` (*Player_Romus: ""Giving people a voice doesn't mean giving up monarchy. I..."*)
  - -> `[382]` (*Player_Romus: ""I didn't realize that GRACE was so attuned to my actions..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving people a voice doesn't mean giving up monarchy. Isn't your own country governed by a parliament?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Beatrice Livingston (R): ""Technically, yes. But it has roughly as much power as yo..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I got carried away in the moment. I didn't really mean it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)

### Węzeł `[380]`
Mówca: **Beatrice Livingston (R)**
> ""Technically, yes. But it has roughly as much power as your 'House of Delegates'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Beatrice Livingston (R): ""You were lucky to escape the 1926 uprising with your hea..."*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can all make of it what you will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Beatrice Livingston (R): ""I hardly think such a flippant answer is appropriate.""*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize that GRACE was so attuned to my actions as king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Beatrice Livingston (R): ""You are the unproven ruler of one of GRACE's linchpin co..."*)

### Węzeł `[383]`
Mówca: **Beatrice Livingston (R)**
> ""You are the unproven ruler of one of GRACE's linchpin countries. Don't be surprised that you are under scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Beatrice Livingston (R): ""Of course you are free to run your country the way you l..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Beatrice Livingston (R): ""I hear your behavior as king has suggested otherwise.""*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Beatrice Livingston (R): ""It's an odd promise to simply blurt out.""*)

### Węzeł `[387]`
Mówca: **Beatrice Livingston (R)**
> ""I hear your behavior as king has suggested otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Beatrice Livingston (R): ""Of course you are free to run your country the way you l..."*)

### Węzeł `[388]`
Mówca: **Beatrice Livingston (R)**
> ""It's an odd promise to simply blurt out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Beatrice Livingston (R): ""You were lucky to escape the 1926 uprising with your hea..."*)

### Węzeł `[389]`
Mówca: **Beatrice Livingston (R)**
> ""I hardly think such a flippant answer is appropriate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Beatrice Livingston (R): ""You were lucky to escape the 1926 uprising with your hea..."*)

### Węzeł `[390]`
Mówca: **Beatrice Livingston (R)**
> ""You were lucky to escape the 1926 uprising with your head. To make such a public overture towards democracy is to tempt fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Player_Romus: ""Don't worry, Your Excellency. The Rizian monarchy is not..."*)
  - -> `[394]` (*Player_Romus: ""Thank you for warning me. I shall keep your words in mind.""*)
  - -> `[393]` (*Player_Romus: ""I know what I'm getting myself into.""*)

### Węzeł `[391]`
Mówca: **Beatrice Livingston (R)**
> ""Of course you are free to run your country the way you like. But without GRACE's backing, you will be at the mercy of ATO and the CSP like every other country on this continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Player_Romus: ""Don't worry, Your Excellency. The Rizian monarchy is not..."*)
  - -> `[394]` (*Player_Romus: ""Thank you for warning me. I shall keep your words in mind.""*)
  - -> `[393]` (*Player_Romus: ""I know what I'm getting myself into.""*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Your Excellency. The Rizian monarchy is not going anywhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Beatrice Livingston (R)), `[391]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Beatrice Livingston (R): ""Wehlen might beg to differ.""*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know what I'm getting myself into.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Beatrice Livingston (R)), `[391]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "She regarded me warily."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for warning me. I shall keep your words in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Beatrice Livingston (R)), `[391]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Beatrice Livingston (R): ""I hope you shall do more than that.""*)

### Węzeł `[395]`
Mówca: **Beatrice Livingston (R)**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She rose to leave."*)

### Węzeł `[396]`
Mówca: **Beatrice Livingston (R)**
> ""Wehlen might beg to differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[397]`
Mówca: **Beatrice Livingston (R)**
> ""I hope you shall do more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She rose to leave."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "She regarded me warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Beatrice Livingston (R): ""Very well.""*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "She smiled."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She rose to leave."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Beatrice Livingston (R): ""But we'll show them, won't we?""*)

### Węzeł `[403]`
Mówca: **Beatrice Livingston (R)**
> ""But we'll show them, won't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She rose to leave."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "She rose to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Beatrice Livingston (R): ""I shall see you at supper, Your Majesty.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure, Your Excellency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Beatrice Livingston (R)), `[341]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Beatrice Livingston (R): ""A pity.""*)

### Węzeł `[406]`
Mówca: **Beatrice Livingston (R)**
> ""A pity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "She folded her hands in her lap."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "She folded her hands in her lap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Princess Marriage Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "Princess Marriage Talk"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_GRACEDiscussed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""That's quite all right. Tell me your idea.""*)
  - -> `[275]` (*Player_Romus: ""What about GRACE?""*)
  - -> `[271]` (*Player_Romus: ""What was so controversial about it?""*)

### Węzeł `[410]`
Mówca: **Beatrice Livingston (R)**
> ""I shall see you at supper, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Narrator: "The Queen gave the door a swift knock. Her attendants ope..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Narrator: "She paused."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "She walked out with her gown trailing behind her."*)

### Węzeł `[414]`
Mówca: **Beatrice Livingston (R)**
> ""Congratulations on your recent trade deal, by the way. Although I wouldn't trust the Sords any further than I could throw them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "She walked out with her gown trailing behind her."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "She rose to leave."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She rose to leave."*)

### Węzeł `[416]`
Mówca: **Beatrice Livingston (R)**
> ""Rizia is one of its linchpin nations, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player_Romus: ""Of course.""*)
  - -> `[417]` (*Player_Romus: ""What about GRACE?""*)
  - -> `[419]` (*Player_Romus: ""I didn't realize our fellow kingdoms were keeping such a..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about GRACE?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[416]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Beatrice Livingston (R): ""Do not discount the importance of our economic pact, You..."*)

### Węzeł `[418]`
Mówca: **Beatrice Livingston (R)**
> ""Do not discount the importance of our economic pact, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Beatrice Livingston (R): ""Our fellow monarchies want to see a stable Rizia. Especi..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize our fellow kingdoms were keeping such a close eye on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[416]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Beatrice Livingston (R): ""You are the unproven ruler of a country that possesses f..."*)

### Węzeł `[420]`
Mówca: **Beatrice Livingston (R)**
> ""You are the unproven ruler of a country that possesses fabulous wealth. Don't be surprised you're under scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Beatrice Livingston (R): ""GRACE wants to see a stable Rizia. Especially after the ..."*)

### Węzeł `[421]`
Mówca: **Beatrice Livingston (R)**
> ""Our fellow monarchies want to see a stable Rizia. Especially after the summit at which we all promised closer cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: ""I'll keep that in mind. We monarchies have to stick toge..."*)
  - -> `[424]` (*Player_Romus: ""I'm still not sure of the utility of such an organization.""*)
  - -> `[425]` (*Player_Romus: ""Believe me, I want to see a stable Rizia as well.""*)

### Węzeł `[422]`
Mówca: **Beatrice Livingston (R)**
> ""GRACE wants to see a stable Rizia. Especially after the summit at which we all promised closer cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: ""I'll keep that in mind. We monarchies have to stick toge..."*)
  - -> `[424]` (*Player_Romus: ""I'm still not sure of the utility of such an organization.""*)
  - -> `[425]` (*Player_Romus: ""Believe me, I want to see a stable Rizia as well.""*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll keep that in mind. We monarchies have to stick together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Beatrice Livingston (R)), `[422]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not sure of the utility of such an organization.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Beatrice Livingston (R)), `[422]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Beatrice Livingston (R): ""In case you haven't noticed, it's quite dangerous to be ..."*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, I want to see a stable Rizia as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Beatrice Livingston (R)), `[422]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "She smiled."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Beatrice Livingston (R): ""Rumburg will do its best to aid you.""*)

### Węzeł `[429]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Beatrice Livingston (R): ""Together, we will ensure your lasting legacy.""*)

### Węzeł `[430]`
Mówca: **Beatrice Livingston (R)**
> ""Together, we will ensure your lasting legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She rose to leave."]"*)

### Węzeł `[431]`
Mówca: **Beatrice Livingston (R)**
> ""In case you haven't noticed, it's quite dangerous to be a monarch nowadays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Beatrice Livingston (R): ""There is safety in numbers. Even for those of us with we..."*)

### Węzeł `[432]`
Mówca: **Beatrice Livingston (R)**
> ""Rumburg will do its best to aid you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She rose to leave."]"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "She rose to leave."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She rose to leave."*)

### Węzeł `[434]`
Mówca: **Beatrice Livingston (R)**
> ""There is safety in numbers. Even for those of us with well-equipped militaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She rose to leave."]"*)

### Węzeł `[435]`
Mówca: **Narrator**
> "She paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Beatrice Livingston (R): ""Congratulations on your recent trade deal, by the way. A..."*)

### Węzeł `[436]`
Mówca: **Narrator**
> "She walked out with her gown trailing behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWe..."*)

### Węzeł `[437]`
Mówca: **Narrator**
> "The Queen gave the door a swift knock. Her attendants opened it, bowing as they did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Beatrice Livingston (R)" );`
- **Efekt skryptowy (`userScript`):** `AddConversant("Beatrice Livingston (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He stepped aside and Queen Beatrice entered. She was wear..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras"); AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");
AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Vina, Estela and I sat in Palas Rezna's most ornate state..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_RH_BlameSO = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_BlameSO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_Denounce..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_BlameSO = true"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO =..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO =..."*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_DefendSO = true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO = true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_RH_DefendSO = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_DefendSO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_NeutralTowardsSO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenceUpdate = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenceUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Iza_GoldenGuardIntelligenc..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Zille_IntelligenceUpdate =..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true;
RiziaDLC.Energy_Modifier_RumburgEnergyExport -= 2;
RiziaDLC.Budget_Modifier_RumburgTrade += 2;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 2;
RiziaDLC.Resources_Energy -= 3;
RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport = true;      
RiziaDLCSupport.Reports_Turn03_RumburgOilEmbargo = true;
RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] = true;
Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] = Variable["RiziaDLC.Energy_Modifier_RumburgEnergyExport"] - 2;
Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] = Variable["RiziaDLC.Budget_Modifier_RumburgTrade"] + 2;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 2;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] - 3;
Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] = true;
Variable["RiziaDLCSupport.Reports_Turn03_RumburgOilEmbargo"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Rumburg_GasPromise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Beatrice Livingston (R): ""This will all need to be formalized by my parliament and..."*)

### Węzeł `[458]`
Mówca: **Beatrice Livingston (R)**
> ""I feel obliged to ask once more: Are you positive you'll be able to deliver on Rizia's end of the bargain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player_Romus: ""Actually, I'm beginning to have second thoughts. Let's k..."*)
  - -> `[468]` (*Player_Romus: ""With whom do you think you're speaking? King Romus alway..."*)
  - -> `[469]` (*Player_Romus: ""Well... you do have quite a large country. Perhaps you s..."*)
  - -> `[472]` (*Player_Romus: ""If the Queen of Rumburg demands it, so it shall be." [-3..."*)

### Węzeł `[459]`
Mówca: **Beatrice Livingston (R)**
> ""We'd then give you a one-year grace period to make the transition. After which, I warn you, our needs will be quite substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Rumburg Gas Qs"*)

### Węzeł `[460]`
Mówca: **Beatrice Livingston (R)**
> ""This will all need to be formalized by my parliament and your government, of course. A verbal agreement between in-laws is hardly sufficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player_Romus: ""I agree completely. My councilors and your foreign minis..."*)
  - -> `[462]` (*Player_Romus: ""How long have we known each other, sweet Beatrice? My wo..."*)
  - -> `[463]` (*Player_Romus: ""It is still quite the leap of faith, though, isn't it? I..."*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree completely. My councilors and your foreign ministers can iron out the small print.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Beatrice Livingston (R): ""Precisely. We handle the big picture while the underling..."*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long have we known each other, sweet Beatrice? My word is as good as gold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Beatrice Livingston (R): ""I believe your intentions are nothing but pure, dear Rom..."*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is still quite the leap of faith, though, isn't it? Is your sisterly affection for me that strong?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Beatrice Livingston (R): ""Our mutual love for Lena has indeed bound us tightly. Bu..."*)

### Węzeł `[464]`
Mówca: **Beatrice Livingston (R)**
> ""Precisely. We handle the big picture while the underlings take care of the particularities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Beatrice Livingston (R): ""Moving on to equally important matters...""*)

### Węzeł `[465]`
Mówca: **Beatrice Livingston (R)**
> ""I believe your intentions are nothing but pure, dear Romus. But we are a vast nation with freezing winters. I cannot stake my people's fate on an informal agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Beatrice Livingston (R): ""Moving on to equally important matters...""*)

### Węzeł `[466]`
Mówca: **Beatrice Livingston (R)**
> ""Our mutual love for Lena has indeed bound us tightly. But I confess we are also facing pressure to shift our energy purchases away from CSP and CSP-aligned countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Beatrice Livingston (R): ""And given our numerous existing trade agreements, Rizia ..."*)

### Węzeł `[467]`
Mówca: **Beatrice Livingston (R)**
> ""And given our numerous existing trade agreements, Rizia makes sense as a replacement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Beatrice Livingston (R): ""Moving on to equally important matters...""*)

### Węzeł `[468]`
**[WYBÓR GRACZA: ""With whom do you think you're speaking? King Romus always keeps a promise." [-3 Energy, -2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""With whom do you think you're speaking? King Romus always keeps a promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[458]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Beatrice Livingston (R): ""What a delightful little rhyme.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA: ""Well... you do have quite a large country. Perhaps you should halve your orders instead." [-2 Energy, -1 Energy Per Turn, +1 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""Well... you do have quite a large country. Perhaps you should halve your orders instead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[458]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Beatrice Livingston (R): ""Certainly, Your Majesty. It's important to be realistic ..."*)

### Węzeł `[470]`
Mówca: **Beatrice Livingston (R)**
> ""Certainly, Your Majesty. It's important to be realistic about these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true; Rizia..."*)

### Węzeł `[471]`
Mówca: **Beatrice Livingston (R)**
> ""What a delightful little rhyme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true; Rizia..."*)

### Węzeł `[472]`
**[WYBÓR GRACZA: ""If the Queen of Rumburg demands it, so it shall be." [-3 Energy, -2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""If the Queen of Rumburg demands it, so it shall be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[458]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Beatrice Livingston (R): ""Very good.""*)

### Węzeł `[473]`
Mówca: **Beatrice Livingston (R)**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true; Rizia..."*)

### Węzeł `[474]`
Mówca: **Beatrice Livingston (R)**
> ""Certainly. It may not have as much of an impact as you were hoping, but it also won't be as much of a leap of faith on our part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg = true; Rizia..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OrElse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rumburg Gas Qs]"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_OtherCustomers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rumburg Gas Qs]"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Amount"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rumburg Gas Qs]"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rumburg Gas Qs]"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras"); AddConversant("Vina Toras");"*)

### Węzeł `[481]`
Mówca: **Narrator**
> "My mother feigned a puzzled look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Estela Toras: ""Is that so, Your Excellency?""*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you had nothing to do with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Beatrice Livingston (R): ""You must be joking...""*)

### Węzeł `[483]`
Mówca: **Beatrice Livingston (R)**
> ""You must be joking...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Beatrice Livingston (R): ""Needless to say, Rumburg has been monitoring the fallout..."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[416]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Beatrice Livingston (R): ""Our fellow monarchies want to see a stable Rizia. Especi..."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My speech?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Beatrice Livingston (R): ""Just as the world's remaining monarchies pledge to enter..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 2"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy >= 2)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""I love it. You buy less oil from Wehlen, and we'll make ..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 3"*)
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy >= 3)"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""Screw it, Your Excellency. Cut off Wehlen completely." [..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == true || RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Pr..."*)
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == true || RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Beatrice Livingston (R): ""I have been notified of your expansion of the Monqiz por..."*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == true || RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Beatrice Livingston (R): ""Of course, an immediate modernization of your Monqiz por..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWeek = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_FortAles_ValgishHeritageWeek"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit = true;"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit = true;"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Qalus_TuskVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Monqiz_KorontiVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Beatrice Livingston (R): ""Moving on to equally important matters...""*)

### Węzeł `[505]`
Mówca: **Beatrice Livingston (R)**
> ""I have been notified of your expansion of the Monqiz port and dockyard facilities. This will easily handle the excess shipping traffic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Player_Romus: ""Indeed. I ordered that expansion with foreign trade in m..."*)
  - -> `[167]` (*Player_Romus: ""We always try to stay ahead.""*)
  - -> `[507]` (*Player_Romus: ""It's almost as if I knew this deal was coming. Just call..."*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. I ordered that expansion with foreign trade in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Beatrice Livingston (R): ""Even if you don't agree to sell us gas, our gold trade w..."*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's almost as if I knew this deal was coming. Just call me Romus the Prescient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[508]`
Mówca: **Beatrice Livingston (R)**
> ""I'd rather not. But I appreciate your forward thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics = true"*)

### Węzeł `[509]`
Mówca: **Beatrice Livingston (R)**
> ""Even if you don't agree to sell us gas, our gold trade will be much more efficient. Well done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Beatrice_RumburgGas_Logistics = true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Beatrice Livingston (R): ""I'd rather not. But I appreciate your forward thinking.""*)

### Węzeł `[511]`
Mówca: **Beatrice Livingston (R)**
> ""Remember who got you into GRACE, Your Majesty. And on whose grace Rizia's trade depends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Player_Romus: ""I remember just fine. Shall we change the subject?""*)
  - -> `[519]` (*Player_Romus: ""I treasure our alliance, Beatrice. I just don't believe ..."*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 2"*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm sure. Shall we change the subject?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Beatrice Livingston (R): ""Very well. Let's.""*)

### Węzeł `[513]`
Mówca: **Beatrice Livingston (R)**
> ""Very well. Let's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 2;"*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember just fine. Shall we change the subject?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[511]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Beatrice Livingston (R): ""Very well. Let's.""*)

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, this embargo could be quite useful. Let's go through with it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Energy"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[188]` (Beatrice Livingston (R)), `[511]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Beatrice Livingston (R): ""Thrilling. How much less oil shall we buy, then?""*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 2"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy >= 2)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Player_Romus: ""On second thought, this embargo could be quite useful. L..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I treasure our alliance, Beatrice. I just don't believe this deal is in Rizia's best interests.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Beatrice Livingston (R)), `[511]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Beatrice Livingston (R): ""Hm. Very well.""*)

### Węzeł `[520]`
Mówca: **Beatrice Livingston (R)**
> ""Hm. Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Beatrice Livingston (R): ""Moving on to equally important matters...""*)

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'm beginning to have second thoughts. Let's keep our trade relationship as it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Beatrice Livingston (R)), `[458]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "She gave me a disappointed frown."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "She gave me a disappointed frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Beatrice Livingston (R): ""How cruel of you to get my hopes up like that.""*)

### Węzeł `[523]`
Mówca: **Beatrice Livingston (R)**
> ""How cruel of you to get my hopes up like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1;"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Beatrice Livingston (R): ""Moving on to equally important matters...""*)

### Węzeł `[525]`
Mówca: **Beatrice Livingston (R)**
> ""We Rumburgians do agree with Wehlen on one thing. The right of Dastnurists to practice their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true || RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Proj..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true || RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Beatrice Livingston (R): ""So I was quite pleased to hear you granted the Dastnuris..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true || RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Beatrice Livingston (R): ""I know Dastnurity is a minority religion over here. But ..."*)

### Węzeł `[529]`
Mówca: **Beatrice Livingston (R)**
> ""So I was quite pleased to hear you granted the Dastnurists of Sallabes their long-overdue sanctuary expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Player_Romus: ""It was the least I could do. I still regret that Lena wa..."*)
  - -> `[533]` (*Player_Romus: ""Of course. The Kingdom of Rizia welcomes all denominatio..."*)
  - -> `[531]` (*Player_Romus: ""Be honest with me. Do you really care about religion tha..."*)

### Węzeł `[530]`
Mówca: **Beatrice Livingston (R)**
> ""I know Dastnurity is a minority religion over here. But it would be ever so kind of you to accommodate the community's needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Player_Romus: ""Of course. The Kingdom of Rizia welcomes all denominatio..."*)
  - -> `[531]` (*Player_Romus: ""Be honest with me. Do you really care about religion tha..."*)
  - -> `[532]` (*Player_Romus: ""I will try. But it's not at the top of my list of priori..."*)
  - -> `[534]` (*Player_Romus: ""Why should I accept them when they don't accept the sacr..."*)

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be honest with me. Do you really care about religion that much?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Beatrice Livingston (R)), `[530]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Beatrice Livingston (R): ""Our personal beliefs don't factor into this, Romus.""*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will try. But it's not at the top of my list of priorities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[530]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Beatrice Livingston (R): ""I suggest you rearrange that list, then.""*)

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. The Kingdom of Rizia welcomes all denominations of Nurity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Beatrice Livingston (R)), `[530]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why should I accept them when they don't accept the sacred scripture of St. Wruhec?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[530]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[535]`
Mówca: **Beatrice Livingston (R)**
> ""For heaven's sake, Romus. Golcondists are hardly Wruhecists, and you accept them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Beatrice Livingston (R): ""Keep your kingdom's faithful happy, and they will be you..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Beatrice Livingston (R): ""Yes, you proved that, didn't you? An interesting decisio..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Beatrice Livingston (R): ""Except Golcondists, it seems. One could only imagine Weh..."*)

### Węzeł `[539]`
Mówca: **Beatrice Livingston (R)**
> ""Yes, you proved that, didn't you? An interesting decision, revoking your blasphemy law. One that will surely get Wehlen's attention...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Beatrice Livingston (R): ""But I'm getting ahead of myself.""*)

### Węzeł `[540]`
Mówca: **Beatrice Livingston (R)**
> ""Except Golcondists, it seems. One could only imagine Wehlen's wrath if you began tolerating them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Beatrice Livingston (R): ""But I'm getting ahead of myself.""*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Beatrice Livingston (R): ""For heaven's sake, Romus. Golcondists are hardly Wruheci..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Beatrice Livingston (R): ""That's no attitude to take towards a small but significa..."*)

### Węzeł `[544]`
Mówca: **Beatrice Livingston (R)**
> ""That's no attitude to take towards a small but significant part of your population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Beatrice Livingston (R): ""Keep your kingdom's faithful happy, and they will be you..."*)

### Węzeł `[545]`
Mówca: **Beatrice Livingston (R)**
> ""Keep your kingdom's faithful happy, and they will be your strongest supporters. Your so-called Wiseman should have told you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Beatrice Livingston (R): ""And speaking of happiness...""*)

### Węzeł `[546]`
Mówca: **Beatrice Livingston (R)**
> ""Our personal beliefs don't factor into this, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Beatrice Livingston (R): ""Keep your kingdom's faithful happy, and they will be you..."*)

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was the least I could do. I still regret that Lena was forced to convert.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[548]`
Mówca: **Beatrice Livingston (R)**
> ""Past is past. I don't believe she ever truly accepted St. Wruhec's writings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Beatrice Livingston (R): ""Speaking of wives...""*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Beatrice Livingston (R): ""Past is past. I don't believe she ever truly accepted St..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Beatrice Livingston (R): ""She forgave you. Though I don't believe she ever truly a..."*)

### Węzeł `[552]`
Mówca: **Beatrice Livingston (R)**
> ""She forgave you. Though I don't believe she ever truly accepted St. Wruhec's writings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Beatrice Livingston (R): ""Speaking of wives...""*)

### Węzeł `[553]`
Mówca: **Beatrice Livingston (R)**
> ""Speaking of wives...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[554]`
Mówca: **Beatrice Livingston (R)**
> ""But I'm getting ahead of myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[555]`
Mówca: **Beatrice Livingston (R)**
> ""I suggest you rearrange that list, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Beatrice Livingston (R): ""Keep your kingdom's faithful happy, and they will be you..."*)

### Węzeł `[556]`
Mówca: **Beatrice Livingston (R)**
> ""And speaking of happiness...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "Jump to: [Princess Marriage Talk]"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Welcoming Queen Beatrice of Rumburg to the Palace", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Welcoming Queen Beatrice of Rumburg to the Palace","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
