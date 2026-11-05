# Rizia/Turn 8/ECONOMY/ECONOMY Conversation

- **ID konwersacji:** `591`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/591_ECONOMY_Conversation.md`
- **Liczba węzłów dialogowych:** 483
- **Liczba wyborów gracza:** 62

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena`
- `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8`
- `RiziaDLC.Focus_Economy_Diversification`
- `RiziaDLC.Focus_Economy_Resource`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Economy_Diversified`
- `RiziaDLC.Policy_Economy_ResourceBased`
- `RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange`
- `RiziaDLC.Policy_RD_Economy_WarProfitsTax`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_GrantROGStake`
- `RiziaDLC.Rusty_Hostile`
- `RiziaDLC.Rusty_KnownLespianAgent`
- `RiziaDLC.Situation_Diplomacy_GlobalImage_Good`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth`
- `RiziaDLC.Situation_Economy_ProductionCapacity_Average`
- `RiziaDLC.Situation_Economy_ProductionCapacity_High`
- `RiziaDLC.Situation_Economy_ProductionCapacity_Low`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Effective`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Situation_Welfare_WorkersRights_Horrible`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Unrest_Nationalist_Grows`
- `RiziaDLC.Unrest_Religious_Grows`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLC.War_Pales_LespianSupport`
- `RiziaDLCIsolated.Turn08_Council_RustyAgent`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_RizianGoldIndustry`
- `RiziaDLC.Enable_RRG_Nationalization`
- `RiziaDLC.Energy_Modifier_SoldROGStake`
- `RiziaDLC.NationalizeRRG_War`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_Fled`
- `RiziaDLC.Turn08_A_CouncilEconomy_BigBoost`
- `RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost`
- `RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost`
- `RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost`
- `RiziaDLCSupport.News_Turn08_G_RustyArrested`
- `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost`
- `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise`
- `RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth`
- `RiziaDLCSupport.News_Turn08_RH_RustyArrested`
- `RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse`
- `RiziaDLCSupport.News_Turn08_V_Economy_NewBusiness_ReductionCollapse`
- `RiziaDLCSupport.News_Turn08_V_RRGNationalization`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_NewBusinessRise`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest`
- `RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrowth`
- `RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse`
- `RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse`
- `RiziaDLCText.RustyArrestReason`
- `RiziaDLCText.RustyFate`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[282]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[62]` | **""I don't want to hear excuses. I want to hear solutions and results.""** | `[60]` **Elena Werner**: ""While the war profits tax is he..."<br>`[61]` **Elena Werner**: ""The war expenses are putting a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Elena Werner**: ""Of course."" |
| `[63]` | **""Your comments are appreciated, Ms. Werner.""** | `[60]` **Elena Werner**: ""While the war profits tax is he..."<br>`[61]` **Elena Werner**: ""The war expenses are putting a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Elena Werner**: ""Of course."" |
| `[64]` | **""We are doing our best to end the war as quickly as possible.""** | `[60]` **Elena Werner**: ""While the war profits tax is he..."<br>`[61]` **Elena Werner**: ""The war expenses are putting a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Elena Werner**: ""I don't doubt it, Your Majesty...." |
| `[113]` | **""This is worrying news. I'll look into ways to solve this energy crisis.""** | `[82]` **Elena Werner**: ""I am afraid our production capa..."<br>`[83]` **Elena Werner**: ""Fortunately, our production cap..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[114]` | **""Surprising? Are you saying you expect our production to collapse?""** | `[83]` **Elena Werner**: ""Fortunately, our production cap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Elena Werner**: ""If the energy crisis continues,..." |
| `[115]` | **""Thank you for sharing this, Ms. Werner.""** | `[82]` **Elena Werner**: ""I am afraid our production capa..."<br>`[83]` **Elena Werner**: ""Fortunately, our production cap..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[116]` | **""This is a significant problem. What should we do?""** | `[82]` **Elena Werner**: ""I am afraid our production capa..."<br>`[83]` **Elena Werner**: ""Fortunately, our production cap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Elena Werner**: ""We should either seek new sourc..." |
| `[117]` | **""This is worrying news. I'll look into ways to increase our production capacity.""** | `[78]` **Elena Werner**: ""Unfortunately, we are still onl..."<br>`[177]` **Elena Werner**: ""Sadly, our goods are no longer ..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[118]` | **""Thank you for sharing this, Ms. Werner.""** | `[77]` **Elena Werner**: ""I'm pleased to say our producti..."<br>`[78]` **Elena Werner**: ""Unfortunately, we are still onl..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[119]` | **""This is still good news. Thank you for your contributions, Ms. Werner.""** | `[78]` **Elena Werner**: ""Unfortunately, we are still onl..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[120]` | **""This is great news. Thank you for all your contributions, Ms. Werner.""** | `[77]` **Elena Werner**: ""I'm pleased to say our producti..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[121]` | **""Good to know.""** | `[77]` **Elena Werner**: ""I'm pleased to say our producti..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[146]` | **""May the Lord guide us through these fiscally trying times and set us once more on..."** | `[144]` **Elena Werner**: ""This downturn is harming new bu..."<br>`[145]` **Elena Werner**: ""This economic climate is dire f..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[222]` **Sal Ignacius**: ""Halaita."" |
| `[147]` | **""This is disconcerting news. We must act decisively to prevent our country from fa..."** | `[144]` **Elena Werner**: ""This downturn is harming new bu..."<br>`[145]` **Elena Werner**: ""This economic climate is dire f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Elena Werner**: ""Rest assured, I am fully dedica..." |
| `[148]` | **""We couldn't have done it without you, Ms. Werner. You should be proud.""** | `[143]` **Elena Werner**: ""Jobs are being created; employm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Elena Werner**: ""You're too modest, Your Majesty..." |
| `[149]` | **""As long as nobody makes *too* much money. We don't want another Rusty on our hands.""** | `[143]` **Elena Werner**: ""Jobs are being created; employm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Elena Werner**: ""Rusty was a special case, Your ..." |
| `[160]` | **""And a horrible time to be a worker.""** | `[143]` **Elena Werner**: ""Jobs are being created; employm..." | `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true` | *Brak zmian stanu* | `[166]` **Elena Werner**: ""We've been over this, Your Maje..." |
| `[161]` | **""There must be additional strategies we can employ, Ms. Werner.""** | `[144]` **Elena Werner**: ""This downturn is harming new bu..."<br>`[145]` **Elena Werner**: ""This economic climate is dire f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Elena Werner**: ""I agree wholeheartedly. I'm exp..." |
| `[162]` | **""We have reserves in our treasury. Let’s strategically invest them to bolster our ..."** | `[144]` **Elena Werner**: ""This downturn is harming new bu..."<br>`[145]` **Elena Werner**: ""This economic climate is dire f..." | `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 3` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[218]` **Narrator**: "A confident smile spread across ..." |
| `[163]` | **""Allocate several billion guilders to mitigate this economic downturn. I entrust y..."** | `[144]` **Elena Werner**: ""This downturn is harming new bu..."<br>`[145]` **Elena Werner**: ""This economic climate is dire f..." | `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 4` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[217]` **Narrator**: "A look of incredulity spread acr..." |
| `[178]` | **""I'm not worried. We will bounce back eventually.""** | `[177]` **Elena Werner**: ""Sadly, our goods are no longer ..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_N...`<br>*(+1 skryptów)* | `[207]` **Elena Werner**: ""As for our business climate..."" |
| `[205]` | **""You know what will have a lasting impact? Claiming Pales and all the resources th..."** | `[60]` **Elena Werner**: ""While the war profits tax is he..."<br>`[61]` **Elena Werner**: ""The war expenses are putting a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Elena Werner**: ""Of course."" |
| `[211]` | **""And a good time to be a worker.""** | `[143]` **Elena Werner**: ""Jobs are being created; employm..." | `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false` | *Brak zmian stanu* | `[212]` **Elena Werner**: ""A rising tide lifts all boats, ..."<br>`[216]` **Elena Werner**: ""Yes, if the economy's good enou..." |
| `[256]` | **""To hell with what investors think. We ought to put the 'Royal' back in Rizian Roy..."** | `[253]` **Elena Werner**: ""Inevitably, some investors will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Narrator**: "She nodded." |
| `[257]` | **""We don't have to nationalize the company by force. We can buy our way to a stakeh..."** | `[253]` **Elena Werner**: ""Inevitably, some investors will..."<br>`[254]` **Elena Werner**: ""Inevitably, though, some invest..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Elena Werner**: ""That won't be cheap. But it may..." |
| `[258]` | **""Rusty isn't even in prison yet. We'll decide this later.""** | `[253]` **Elena Werner**: ""Inevitably, some investors will..."<br>`[254]` **Elena Werner**: ""Inevitably, though, some invest..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Rusty_Arrested"] == true` | *Brak zmian stanu* | `[259]` **Elena Werner**: ""As you wish."" |
| `[265]` | **""Whatever losses we incur will be worth it for the chance to pry our resources out..."** | `[253]` **Elena Werner**: ""Inevitably, some investors will..."<br>`[254]` **Elena Werner**: ""Inevitably, though, some invest..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[266]` **Elena Werner**: ""My goodness. You're starting to..." |
| `[276]` | **""A little overeager, aren't you? I haven't even spoken to Rusty about all this yet.""** | `[253]` **Elena Werner**: ""Inevitably, some investors will..."<br>`[254]` **Elena Werner**: ""Inevitably, though, some invest..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false` | *Brak zmian stanu* | `[277]` **Elena Werner**: ""You're right. The decision can ..." |
| `[287]` | **""Rusty does have known ties to Arcasia. And ATO is taking Pales' side in the war...""** | `[286]` **Hugo Toras**: ""One could argue that Rizian Roy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Laurento Esquibel**: ""We have no reason to believe Ar..." |
| `[288]` | **""If we want to keep funding this war, such a measure may be necessary.""** | `[286]` **Hugo Toras**: ""One could argue that Rizian Roy..." | `Variable["RiziaDLC.Resources_Budget"] < 5` | *Brak zmian stanu* | `[307]` **Lucita Azaro**: ""Yes, thank you for bringing thi..." |
| `[292]` | **""We can fund this war without resorting to such measures.""** | `[286]` **Hugo Toras**: ""One could argue that Rizian Roy..." | `(Variable["RiziaDLC.Resources_Budget"] < 5) == false` | *Brak zmian stanu* | `[299]` **Elena Werner**: ""I believe so as well."" |
| `[293]` | **""One could. But I would rather stay on Rusty Montoro's good side.""** | `[286]` **Hugo Toras**: ""One could argue that Rizian Roy..." | `(Variable["RiziaDLC.Rusty_Hostile"] == true) == false` | *Brak zmian stanu* | `[301]` **Elena Werner**: ""Your Grace, as it stands, Rizia..." |
| `[297]` | **""If I know Rusty Montoro, he won't allow this without a fight.""** | `[286]` **Hugo Toras**: ""One could argue that Rizian Roy..." | `Variable["RiziaDLC.Rusty_Hostile"] == true` | *Brak zmian stanu* | `[300]` **Elena Werner**: ""Legally, he won't have any reco..." |
| `[318]` | **""I have the feeling Soletato's people will not be appeased that easily.""** | `[317]` **Elena Werner**: ""Then again, if your goal is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Elena Werner**: ""Maybe not. But in combination w..." |
| `[319]` | **""Sotelato is a former miner, isn't he? It'll make him happy to see his ex-boss los..."** | `[317]` **Elena Werner**: ""Then again, if your goal is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Vina Toras**: ""Father. Do you really think the..."<br>`[328]` **Lucita Azaro**: ""Happy enough to drop his threat..." |
| `[320]` | **""Nationalization means putting RRG *into* the hands of the Royal Family. They'd ha..."** | `[317]` **Elena Werner**: ""Then again, if your goal is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Lucita Azaro**: ""Yes, and there are other ways t..." |
| `[321]` | **""So all of a sudden a ragtag bunch of radicals are more important to please than R..."** | `[317]` **Elena Werner**: ""Then again, if your goal is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Lucita Azaro**: ""Of course not, Your Majesty."" |
| `[338]` | **""Rusty put his heart and soul into RRG. If we're to nationalize, he and the other ..."** | `[330]` **Lucita Azaro**: ""With that said, nationalization..."<br>`[333]` **Lucita Azaro**: ""If I may chime in, nationalizat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Hugo Toras**: ""His heart and soul... As if Mon..." |
| `[339]` | **""A dangerous proposition, Duchess Azaro. What if he and his guards get wind of the..."** | `[330]` **Lucita Azaro**: ""With that said, nationalization..."<br>`[333]` **Lucita Azaro**: ""If I may chime in, nationalizat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Lucita Azaro**: ""There's always that risk. We'd ..." |
| `[340]` | **""Montoro was just starting to become useful to me. I don't want to throw away our ..."** | `[330]` **Lucita Azaro**: ""With that said, nationalization..."<br>`[333]` **Lucita Azaro**: ""If I may chime in, nationalizat..." | `Variable["RiziaDLC.Rusty_Allied"] == true` | *Brak zmian stanu* | `[341]` **Elena Werner**: ""Sensible, Your Majesty."" |
| `[342]` | **""That will take manpower. We can't afford to pull people from the front lines.""** | `[330]` **Lucita Azaro**: ""With that said, nationalization..."<br>`[333]` **Lucita Azaro**: ""If I may chime in, nationalizat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Lucita Azaro**: ""With sufficient intelligence, w..." |
| `[353]` | **""For the security of the kingdom, it is vital that we nationalize Rizian Royal Gol..."** | `[348]` **Elena Werner**: ""It is His Majesty's decision. I..."<br>`[352]` **Elena Werner**: ""It is His Majesty's decision. K..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[354]` | **""I'd like to thank His Grace Hugo for bringing up the matter. Rusty's had this com..."** | `[348]` **Elena Werner**: ""It is His Majesty's decision. I..."<br>`[352]` **Elena Werner**: ""It is His Majesty's decision. K..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Hugo Toras**: ""Very good, Your Majesty."" |
| `[355]` | **""I am satisfied with the Crown's current stake in Rizian Royal Gold. Nationalizati..."** | `[348]` **Elena Werner**: ""It is His Majesty's decision. I..."<br>`[352]` **Elena Werner**: ""It is His Majesty's decision. K..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Elena Werner**: ""Very good."" |
| `[360]` | **""With the current state of our intelligence services, this is a risk we cannot aff..."** | `[348]` **Elena Werner**: ""It is His Majesty's decision. I..."<br>`[352]` **Elena Werner**: ""It is His Majesty's decision. K..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == false` | *Brak zmian stanu* | `[358]` **Elena Werner**: ""Very good."" |
| `[384]` | **""Of course not. It's a terrible idea.""** | `[383]` **Hugo Toras**: ""You'd trust that man with the R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Elena Werner**: ""I have doubts about it myself, ..." |
| `[385]` | **""Why not? He could make us a lot of money.""** | `[383]` **Hugo Toras**: ""You'd trust that man with the R..." | `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true` | *Brak zmian stanu* | `[390]` **Hugo Toras**: ""Us, or himself?"" |
| `[386]` | **""I never much liked the idea of gambling with our kingdom's finances.""** | `[383]` **Hugo Toras**: ""You'd trust that man with the R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Elena Werner**: ""Nor do I. But I admit that if d..." |
| `[387]` | **""It's high time we established such a draw for investors. But I'm not sold on the ..."** | `[383]` **Hugo Toras**: ""You'd trust that man with the R..." | `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false` | *Brak zmian stanu* | `[388]` **Elena Werner**: ""It can be someone else. But Mr...." |
| `[408]` | **""With the leverage we now have over him, he could make us a lot of money.""** | `[383]` **Hugo Toras**: ""You'd trust that man with the R..." | `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false` | *Brak zmian stanu* | `[390]` **Hugo Toras**: ""Us, or himself?"" |
| `[412]` | **""It's high time we established such a draw for investors. But I have other plans f..."** | `[383]` **Hugo Toras**: ""You'd trust that man with the R..." | `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true` | *Brak zmian stanu* | `[413]` **Elena Werner**: ""Understood. It doesn't have to ..." |
| `[444]` | **""Of course not. It's a terrible idea.""** | `[443]` **Hugo Toras**: ""You'd trust that man with the R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Elena Werner**: ""He's a known name in Arcasian c..." |
| `[445]` | **""Why not? He could make us a lot of money.""** | `[443]` **Hugo Toras**: ""You'd trust that man with the R..." | `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true` | *Brak zmian stanu* | `[448]` **Hugo Toras**: ""Us, or himself?"" |
| `[446]` | **""If our kingdom's finances are to be gambled with, I'd prefer you be the one rolli..."** | `[443]` **Hugo Toras**: ""You'd trust that man with the R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Elena Werner**: ""That's very kind. But I admit t..." |
| `[453]` | **""With the leverage we now have over him, he could make us a lot of money.""** | `[443]` **Hugo Toras**: ""You'd trust that man with the R..." | `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false` | *Brak zmian stanu* | `[448]` **Hugo Toras**: ""Us, or himself?"" |
| `[457]` | **""Give Rusty a chance, Hugo. He's done more for Rizia than you know.""** | `[443]` **Hugo Toras**: ""You'd trust that man with the R..." | `Variable["RiziaDLC.Rusty_Allied"] == true  and  Variable["RiziaDLC.Rusty_KnownLespianAgent"] == false` | *Brak zmian stanu* | `[458]` **Elena Werner**: ""And he has the right connections."" |
| `[472]` | **""I have other plans for Rusty, Hugo. Don't worry.""** | `[468]` **Hugo Toras**: ""Ms. Werner, are you seriously s..." | `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false` | `--;` | `[285]` **Narrator**: "She closed her book." |
| `[473]` | **""Mr. Montoro's fate will be discussed shortly. I'll keep this information in mind.""** | `[468]` **Hugo Toras**: ""Ms. Werner, are you seriously s..." | `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false` | `--;` | `[285]` **Narrator**: "She closed her book." |
| `[474]` | **""Our treasury is shrinking. This is worth taking into consideration.""** | `[468]` **Hugo Toras**: ""Ms. Werner, are you seriously s..." | `Variable["RiziaDLC.Resources_Budget"] < 5` | `--;` | `[285]` **Narrator**: "She closed her book." |
| `[479]` | **""I agree with you, Hugo. This is absurd.""** | `[468]` **Hugo Toras**: ""Ms. Werner, are you seriously s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Elena Werner**: ""I would be happy to chair the e..." |
| `[481]` | **""Not just a few. Long-lasting financial security for Rizia is finally within our g..."** | `[468]` **Hugo Toras**: ""Ms. Werner, are you seriously s..." | `(Variable["RiziaDLC.Resources_Budget"] < 5) == false` | `--;` | `[285]` **Narrator**: "She closed her book." |
| `[482]` | **""I'll decide for myself whether he's a traitor. Then we'll see.""** | `[468]` **Hugo Toras**: ""Ms. Werner, are you seriously s..." | `(Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false) == false` | `--;` | `[285]` **Narrator**: "She closed her book." |

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
  - -> `[3]` (*Narrator: "Elena took out her ledger, placed it on the table and ope..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Everyone turned towards Hugo. Elena gestured for him to c..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Elena took out her ledger, placed it on the table and opened it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true"*)

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""We have a very significant amount of money flowing into our economy. This is a great indicator for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 0)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 1"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 7"*)

### Węzeł `[14]`
Mówca: **Elena Werner**
> ""As already mentioned, living standards in Rizia have improved by leaps and bounds thanks to the Crown's economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal < 0"*)

### Węzeł `[15]`
Mówca: **Elena Werner**
> ""As already mentioned, living standards in Rizia are in a very healthy position as a result of a combination of economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal < 0"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 7"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal >= 7)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Elena Werner: ""We have a very significant amount of money flowing into ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal > 3"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal > 3"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal > 3)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Elena Werner: ""We have a significant amount of money flowing into our e..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 1"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC...."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDL..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0  and  Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Elena Werner: ""We have a balanced budget at the moment. Our economy cou..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0  and  Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Elena Werner: ""We are rapidly losing money. We should try to get out of..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal < 0"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal < 0)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Elena Werner: ""However, we are rapidly losing money. We should try to g..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal == 0"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal == 0"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal == 0)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Elena Werner: ""However, we're not seeing a net increase in government i..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 7"*)

### Węzeł `[31]`
Mówca: **Elena Werner**
> ""However, we are rapidly losing money. We should try to get out of our current deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[32]`
Mówca: **Elena Werner**
> ""However, we're not seeing a net increase in government income. We're keeping a budgetary balance at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""We have a significant amount of money flowing into our economy. This is a good indicator for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[34]`
Mówca: **Elena Werner**
> ""We have a balanced budget at the moment. Our economy could be better, but this isn't a bad indicator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[35]`
Mówca: **Elena Werner**
> ""We are rapidly losing money. We should try to get out of our current deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 3)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Elena Werner: ""Luckily, we have enough reserves to give us time to make..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Elena Werner: ""And our reserves may not be enough to give us the time w..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 0)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Elena Werner: ""But at the moment, we don't have any money to spend on n..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 3)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Elena Werner: ""We also have enough funds in reserve that we can begin p..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Elena Werner: ""We also have some reserves with which we can fund projec..."*)

### Węzeł `[45]`
Mówca: **Elena Werner**
> ""Luckily, we have enough reserves to give us time to make improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[46]`
Mówca: **Elena Werner**
> ""And our reserves may not be enough to give us the time we need to make improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[47]`
Mówca: **Elena Werner**
> ""We also have enough funds in reserve that we can begin planning more ambitious projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[48]`
Mówca: **Elena Werner**
> ""We also have some reserves with which we can fund projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""But at the moment, we don't have any money to spend on new projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""And unfortunately, we lack the funds to make any improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "She turned a page."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "She turned a page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_WarProfitsTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_WarProfitsTax == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_WarProfitsTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Elena Werner: ""While the war profits tax is helping with our immediate ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Elena Werner: ""The war expenses are putting a crimp in our economy. If ..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Elena Werner: ""Of course, the war has influenced my department very neg..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[59]`
Mówca: **Elena Werner**
> ""Of course, the war has influenced my department very negatively, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_WarProfitsTax == true"*)

### Węzeł `[60]`
Mówca: **Elena Werner**
> ""While the war profits tax is helping with our immediate finances, it is stifling the growth of our economy. This may have lasting effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""I don't want to hear excuses. I want to hear solutions a..."*)
  - -> `[63]` (*Player_Romus: ""Your comments are appreciated, Ms. Werner.""*)
  - -> `[64]` (*Player_Romus: ""We are doing our best to end the war as quickly as possi..."*)
  - -> `[205]` (*Player_Romus: ""You know what will have a lasting impact? Claiming Pales..."*)

### Węzeł `[61]`
Mówca: **Elena Werner**
> ""The war expenses are putting a crimp in our economy. If this continues for much longer, it may have a lasting impact on our growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""I don't want to hear excuses. I want to hear solutions a..."*)
  - -> `[63]` (*Player_Romus: ""Your comments are appreciated, Ms. Werner.""*)
  - -> `[64]` (*Player_Romus: ""We are doing our best to end the war as quickly as possi..."*)
  - -> `[205]` (*Player_Romus: ""You know what will have a lasting impact? Claiming Pales..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to hear excuses. I want to hear solutions and results.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Elena Werner), `[61]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Elena Werner: ""Of course.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your comments are appreciated, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Elena Werner), `[61]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Elena Werner: ""Of course.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are doing our best to end the war as quickly as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Elena Werner), `[61]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Elena Werner: ""I don't doubt it, Your Majesty. I know our military will..."*)

### Węzeł `[65]`
Mówca: **Elena Werner**
> ""I don't doubt it, Your Majesty. I know our military will come out on top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Elena Werner: ""Moving on...""*)

### Węzeł `[66]`
Mówca: **Elena Werner**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Elena Werner: ""Moving on...""*)

### Węzeł `[67]`
Mówca: **Elena Werner**
> ""Unfortunately, the energy crisis continues with no end in sight. I believe this should be our most significant concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Elena Werner: ""As long as our industries' energy demands are not being ..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Diversification == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Elena Werner: ""Unfortunately, the energy crisis continues with no end i..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Elena Werner: ""Fortunately, we've managed to rescue ourselves from the ..."*)

### Węzeł `[72]`
Mówca: **Elena Werner**
> ""As long as our industries' energy demands are not being met, they will not operate at full capacity. And our economy will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_Low == true"*)

### Węzeł `[73]`
Mówca: **Elena Werner**
> ""Fortunately, we've managed to rescue ourselves from the energy crisis of a few years ago. The demands of our industries are finally being met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_High == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ProductionCapacity_High == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_High == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_ProductionCapacity_High == t..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ProductionCapacity_High == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ProductionCapacity_High"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Elena Werner: ""I'm pleased to say our production capacity has increased..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_ProductionCapacity_High == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ProductionCapacity_High"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_Average == ..."*)

### Węzeł `[77]`
Mówca: **Elena Werner**
> ""I'm pleased to say our production capacity has increased significantly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""This is great news. Thank you for all your contributions..."*)
  - -> `[121]` (*Player_Romus: ""Good to know.""*)
  - -> `[118]` (*Player_Romus: ""Thank you for sharing this, Ms. Werner.""*)

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""Unfortunately, we are still only seeing average production capacity. This is something to work on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""This is still good news. Thank you for your contribution..."*)
  - -> `[118]` (*Player_Romus: ""Thank you for sharing this, Ms. Werner.""*)
  - -> `[117]` (*Player_Romus: ""This is worrying news. I'll look into ways to increase o..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ProductionCapacity_Low == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_Low == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_ProductionCapacity_Low == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ProductionCapacity_Low == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Low"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Elena Werner: ""I am afraid our production capacity has already suffered..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_ProductionCapacity_Low == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Low"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Elena Werner: ""Fortunately, our production capacity hasn't collapsed ju..."*)

### Węzeł `[82]`
Mówca: **Elena Werner**
> ""I am afraid our production capacity has already suffered significantly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""This is worrying news. I'll look into ways to solve this..."*)
  - -> `[115]` (*Player_Romus: ""Thank you for sharing this, Ms. Werner.""*)
  - -> `[116]` (*Player_Romus: ""This is a significant problem. What should we do?""*)

### Węzeł `[83]`
Mówca: **Elena Werner**
> ""Fortunately, our production capacity hasn't collapsed just yet -- which is surprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""This is worrying news. I'll look into ways to solve this..."*)
  - -> `[115]` (*Player_Romus: ""Thank you for sharing this, Ms. Werner.""*)
  - -> `[116]` (*Player_Romus: ""This is a significant problem. What should we do?""*)
  - -> `[114]` (*Player_Romus: ""Surprising? Are you saying you expect our production to ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == t..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Elena Werner: ""With the current wave of robust economic growth, buoyed ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)

### Węzeł `[88]`
Mówca: **Elena Werner**
> ""With the current wave of robust economic growth, buoyed by market incentives to attract fresh investments, we are witnessing the formation of thousands of new businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Elena Werner: ""Jobs are being created; employment rates are skyrocketin..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Elena Werner: ""In light of the recent slowdown in growth, paired with f..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Elena Werner: ""As we find ourselves increasingly mired in what appears ..."*)

### Węzeł `[92]`
Mówca: **Elena Werner**
> ""In light of the recent slowdown in growth, paired with forecasts suggesting the potential onset of a recession next year, we are observing a notable decline in investment activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Elena Werner: ""This downturn is harming new businesses and forcing cutb..."*)

### Węzeł `[93]`
Mówca: **Elena Werner**
> ""As we find ourselves increasingly mired in what appears to be a deepening recession, there is an alarming trend of substantial withdrawal of investments across the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Elena Werner: ""This economic climate is dire for new businesses, leadin..."*)

### Węzeł `[94]`
Mówca: **Elena Werner**
> ""So far, we have managed to greatly diversify our energy sources. This helps our economic options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_Diversified == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_Diversified == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_Diversified == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_Diversified == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_Diversified"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Elena Werner: ""So far, we have managed to greatly diversify our energy ..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_Diversified == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_Diversified"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_ResourceBased == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_ResourceBased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_ResourceBased == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_ResourceBased == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_ResourceBased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Elena Werner: ""Currently, we have a very rigid energy economy with heav..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_ResourceBased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Elena Werner: ""So far, we seem to have a mixed energy economy. But I be..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Elena Werner: ""Despite this, however, the energy crisis continues with ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Elena Werner: ""Fortunately, we've managed to rescue ourselves from the ..."*)

### Węzeł `[104]`
Mówca: **Elena Werner**
> ""Despite this, however, the energy crisis continues with no end in sight. Tackling this should be our number-one concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Elena Werner: ""As long as our industries' energy demands are not being ..."*)

### Węzeł `[105]`
Mówca: **Elena Werner**
> ""Currently, we have a very rigid energy economy with heavy reliance on certain sources. Our future is looking strong -- as long as access to those resources remains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true"*)

### Węzeł `[106]`
Mówca: **Elena Werner**
> ""So far, we seem to have a mixed energy economy. But I believe we must diversify our sources further in order to cover potential weaknesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Elena Werner: ""Therefore, the energy crisis continues with no end in si..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Elena Werner: ""Despite this, however, we've managed to dig ourselves ou..."*)

### Węzeł `[110]`
Mówca: **Elena Werner**
> ""Therefore, the energy crisis continues with no end in sight. I believe this should be our most significant concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Elena Werner: ""As long as our industries' energy demands are not being ..."*)

### Węzeł `[111]`
Mówca: **Elena Werner**
> ""Despite this, however, we've managed to dig ourselves out of the energy crisis. The demands of our industries are finally being met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_High == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "She closed her book."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is worrying news. I'll look into ways to solve this energy crisis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Elena Werner), `[83]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surprising? Are you saying you expect our production to collapse?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Elena Werner: ""If the energy crisis continues, that is our projection, ..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for sharing this, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Elena Werner), `[83]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a significant problem. What should we do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Elena Werner), `[83]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Elena Werner: ""We should either seek new sources of energy or improve o..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is worrying news. I'll look into ways to increase our production capacity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner), `[177]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for sharing this, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Elena Werner), `[78]` (Elena Werner), `[177]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is still good news. Thank you for your contributions, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is great news. Thank you for all your contributions, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[122]`
Mówca: **Elena Werner**
> ""We should either seek new sources of energy or improve our current extraction capacity. Or both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Laurento Esquibel: ""We could look to our neighbors. Perhaps we can work out ..."*)

### Węzeł `[123]`
Mówca: **Elena Werner**
> ""If the energy crisis continues, that is our projection, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Elena Werner: ""We should either seek new sources of energy or improve o..."*)

### Węzeł `[124]`
Mówca: **Laurento Esquibel**
> ""We could look to our neighbors. Perhaps we can work out an import deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Diversification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Diversification == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Economy_Diversification == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Diversification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Diversification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Elena Werner: ""When you ascended the throne, we set a focus to diversif..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Economy_Diversification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Diversification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Resource == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Resource == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Resource == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Economy_Resource == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Resource == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Resource"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Elena Werner: ""When you ascended the throne, we set a focus to further ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Economy_Resource == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Resource"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Elena Werner: ""When you ascended the throne, we agreed to focus on a mi..."*)

### Węzeł `[131]`
Mówca: **Elena Werner**
> ""When you ascended the throne, we set a focus to diversify the Rizian economy away from resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_Diversified == true"*)

### Węzeł `[132]`
Mówca: **Elena Werner**
> ""When you ascended the throne, we set a focus to further the Rizian resource economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_Diversified == true"*)

### Węzeł `[133]`
Mówca: **Elena Werner**
> ""When you ascended the throne, we agreed to focus on a mixed approach for the Rizian economy -- balancing resources and other industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_Diversified == true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == t..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusiness..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise = true;
RiziaDLCSupport.Reports_Turn08_Bronaz_NewBusinessRise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise"] = true;
Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_NewBusinessRise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Elena Werner: ""As for our business climate...""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse = true;
RiziaDLCSupport.News_Turn08_V_Economy_NewBusiness_ReductionCollapse = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_Economy_NewBusiness_ReductionCollapse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Elena Werner: ""As for our business climate...""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse = true;
RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Elena Werner: ""As for our business climate...""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReduction..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollap..."*)

### Węzeł `[143]`
Mówca: **Elena Werner**
> ""Jobs are being created; employment rates are skyrocketing. It's a good time to be an entrepreneur in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""We couldn't have done it without you, Ms. Werner. You sh..."*)
  - -> `[149]` (*Player_Romus: ""As long as nobody makes *too* much money. We don't want ..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || R..."*)

### Węzeł `[144]`
Mówca: **Elena Werner**
> ""This downturn is harming new businesses and forcing cutbacks, resulting in a shrinking job market and posing serious challenges to our economic stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""There must be additional strategies we can employ, Ms. W..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC...."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC...."*)
  - -> `[147]` (*Player_Romus: ""This is disconcerting news. We must act decisively to pr..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[145]`
Mówca: **Elena Werner**
> ""This economic climate is dire for new businesses, leading to increased insolvencies and a significant rise in unemployment, which is severely impacting our workforce and marking a tough phase for Rizia’s overall economic health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""There must be additional strategies we can employ, Ms. W..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC...."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC...."*)
  - -> `[147]` (*Player_Romus: ""This is disconcerting news. We must act decisively to pr..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Lord guide us through these fiscally trying times and set us once more on a path to prosperity.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Elena Werner), `[145]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Sal Ignacius: ""Halaita.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is disconcerting news. We must act decisively to prevent our country from faltering.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Elena Werner), `[145]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Elena Werner: ""Rest assured, I am fully dedicated to preventing any fur..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We couldn't have done it without you, Ms. Werner. You should be proud.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Elena Werner: ""You're too modest, Your Majesty. You had the final say o..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as nobody makes *too* much money. We don't want another Rusty on our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Elena Werner: ""Rusty was a special case, Your Majesty. I foresee only g..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC...."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDL..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""Allocate several billion guilders to mitigate this econo..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 4;
RiziaDLC.Turn08_A_CouncilEconomy_BigBoost = true;
RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost = true;
RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;
Variable["RiziaDLC.Turn08_A_CouncilEconomy_BigBoost"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "A look of incredulity spread across Elena's face."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC...."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDL..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""We have reserves in our treasury. Let’s strategically in..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 2;
RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost = true;
RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost = true;
RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "A confident smile spread across Elena's face."*)

### Węzeł `[158]`
Mówca: **Elena Werner**
> ""That's an incredible gesture of trust, Your Majesty. I will not let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[159]`
Mówca: **Elena Werner**
> ""Thank you for your gesture of trust, Your Majesty. I'll be sure to use these funds judiciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And a horrible time to be a worker.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Elena Werner: ""We've been over this, Your Majesty. If you want to impro..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There must be additional strategies we can employ, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Elena Werner), `[145]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Elena Werner: ""I agree wholeheartedly. I'm exploring every possible opt..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""We have reserves in our treasury. Let’s strategically invest them to bolster our economic standing." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""We have reserves in our treasury. Let’s strategically invest them to bolster our economic standing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[144]` (Elena Werner), `[145]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 2; RiziaDLC.Turn08_A_Council..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Allocate several billion guilders to mitigate this economic downturn. I entrust you with overseeing this crucial initiative." [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Allocate several billion guilders to mitigate this economic downturn. I entrust you with overseeing this crucial initiative.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[144]` (Elena Werner), `[145]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 4; RiziaDLC.Turn08_A_Council..."*)

### Węzeł `[164]`
Mówca: **Elena Werner**
> ""You're too modest, Your Majesty. You had the final say on all of these decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[165]`
Mówca: **Elena Werner**
> ""Rusty was a special case, Your Majesty. I foresee only gains coming from this growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""We've been over this, Your Majesty. If you want to improve workers' rights, I will assist you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[167]`
Mówca: **Elena Werner**
> ""I agree wholeheartedly. I'm exploring every possible option to strengthen our economy further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[168]`
Mówca: **Elena Werner**
> ""Rest assured, I am fully dedicated to preventing any further economic decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[169]`
Mówca: **Elena Werner**
> ""Yes. In the meantime, I will see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal >= 1"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_BudgetModifiersTotal >= 1)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_BudgetModifiersTotal >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Elena Werner: ""We have a small budget surplus at the moment. This isn't..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_BudgetModifiersTotal >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC...."*)

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""We have a small budget surplus at the moment. This isn't a bad indicator for our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 0"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ProductionCapacity_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_Average == ..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_ProductionCapacity_Average =..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_ProductionCapacity_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Elena Werner: ""Unfortunately, we are still only seeing average producti..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_ProductionCapacity_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Elena Werner: ""Sadly, our goods are no longer in demand around the coun..."*)

### Węzeł `[177]`
Mówca: **Elena Werner**
> ""Sadly, our goods are no longer in demand around the country and the world. Our industrial production capacity has fallen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""Thank you for sharing this, Ms. Werner.""*)
  - -> `[117]` (*Player_Romus: ""This is worrying news. I'll look into ways to increase o..."*)
  - -> `[178]` (*Player_Romus: ""I'm not worried. We will bounce back eventually.""*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not worried. We will bounce back eventually.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Elena Werner: ""Unfortunately, however, we are now slipping into an ener..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_ProductionCapacity_High == true"*)

### Węzeł `[192]`
Mówca: **Elena Werner**
> ""Unfortunately, however, we are now slipping into an energy crisis. I believe this must be our most significant concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Elena Werner: ""As long as our industries' energy demands are not being ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unre..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Elena Werner: ""I'm happy to report that the Crown's economic policies h..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Elena Werner: ""As already mentioned, living standards in Rizia have imp..."*)

### Węzeł `[196]`
Mówca: **Elena Werner**
> ""I'm happy to report that the Crown's economic policies have drastically improved living standards in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal < 0"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest..."*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unre..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Elena Werner: ""I'm happy to report that living standards in Rizia are i..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Elena Werner: ""As already mentioned, living standards in Rizia are in a..."*)

### Węzeł `[200]`
Mówca: **Elena Werner**
> ""I'm happy to report that living standards in Rizia are in a very healthy position as a result of a combination of economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_BudgetModifiersTotal < 0"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 1"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 1)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Elena Werner: ""We don't have enough funds to tackle the situation the w..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Elena Werner: ""And unfortunately, we lack the funds to make any improve..."*)

### Węzeł `[204]`
Mówca: **Elena Werner**
> ""We don't have enough funds to tackle the situation the way I'd like to. But selling energy is still an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what will have a lasting impact? Claiming Pales and all the resources that come with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Elena Werner), `[61]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Elena Werner: ""Of course.""*)

### Węzeł `[206]`
Mówca: **Elena Werner**
> ""Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[207]`
Mówca: **Elena Werner**
> ""As for our business climate...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || R..."*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true ||..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player_Romus: ""And a horrible time to be a worker.""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""And a good time to be a worker.""*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And a good time to be a worker.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[212]`
Mówca: **Elena Werner**
> ""A rising tide lifts all boats, as the Alphonso administration was fond of saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Elena Werner: ""A rising tide lifts all boats, as the Alphonso administr..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Elena Werner: ""Yes, if the economy's good enough, everyone wins.""*)

### Węzeł `[216]`
Mówca: **Elena Werner**
> ""Yes, if the economy's good enough, everyone wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[217]`
Mówca: **Narrator**
> "A look of incredulity spread across Elena's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Elena Werner: ""That's an incredible gesture of trust, Your Majesty. I w..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "A confident smile spread across Elena's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Elena Werner: ""Thank you for your gesture of trust, Your Majesty. I'll ..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""May the Lord guide us through these fiscally trying time..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Elena Werner: ""Yes. In the meantime, I will see what I can do.""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_KnownLespianAgent == true )"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_Council_RustyAgent == false"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_KnownLespianAgent == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_Council_RustyAgent == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_Council_RustyAgent == false"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_Council_RustyAgent == false)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_Council_RustyAgent == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Elena Werner: ""There is one major economic factor we have not discussed..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_Council_RustyAgent == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Elena Werner: ""All this is not taking into account the potential impact..."*)

### Węzeł `[229]`
Mówca: **Elena Werner**
> ""There is one major economic factor we have not discussed yet. Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "The others around the table exchanged significant looks."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "The others around the table exchanged significant looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Elena Werner: ""But I assume we'll get to that.""*)

### Węzeł `[231]`
Mówca: **Elena Werner**
> ""But I assume we'll get to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Elena Werner: ""While we're on the subject...""*)

### Węzeł `[232]`
Mówca: **Elena Werner**
> ""All this is not taking into account the potential impact of nationalizing Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "She and Lucita exchanged looks."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)

### Węzeł `[236]`
Mówca: **Narrator**
> "She and Lucita exchanged looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "She and Titus exchanged looks."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "She and Taddeus exchanged looks."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "She and Titus exchanged looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[241]`
Mówca: **Narrator**
> "She and Taddeus exchanged looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[242]`
Mówca: **Elena Werner**
> ""Assuming all goes well with Rusty Montoro's arrest, a government takeover of the company will be relatively easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Elena Werner: ""It will cost us some resources in the short term, but ga..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Arrested == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Elena Werner: ""Assuming all goes well with Rusty Montoro's arrest, a go..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Elena Werner: ""If we decide to imprison Rusty Montoro, a government tak..."*)

### Węzeł `[246]`
Mówca: **Elena Werner**
> ""It will cost us some resources in the short term, but gain us a considerable amount of income that we'll be able to reinvest into other sectors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == t..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Elena Werner: ""Inevitably, some investors will be scared off. But in th..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Elena Werner: ""Inevitably, though, some investors will be scared off. W..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Elena Werner: ""Inevitably, though, investors will be scared off. Which ..."*)

### Węzeł `[253]`
Mówca: **Elena Werner**
> ""Inevitably, some investors will be scared off. But in the current climate, we can afford to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""To hell with what investors think. We ought to put the '..."*)
  - -> `[257]` (*Player_Romus: ""We don't have to nationalize the company by force. We ca..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[254]`
Mówca: **Elena Werner**
> ""Inevitably, though, some investors will be scared off. Which is something to consider in our current economic climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: ""We don't have to nationalize the company by force. We ca..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[255]`
Mówca: **Elena Werner**
> ""Inevitably, though, investors will be scared off. Which is something we can ill afford in today's economic climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: ""We don't have to nationalize the company by force. We ca..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To hell with what investors think. We ought to put the 'Royal' back in Rizian Royal Gold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "She nodded."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have to nationalize the company by force. We can buy our way to a stakeholder majority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Elena Werner), `[254]` (Elena Werner), `[255]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Elena Werner: ""That won't be cheap. But it may be worth it to keep Rizi..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty isn't even in prison yet. We'll decide this later.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[253]` (Elena Werner), `[254]` (Elena Werner), `[255]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Elena Werner: ""As you wish.""*)

### Węzeł `[259]`
Mówca: **Elena Werner**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[260]`
Mówca: **Elena Werner**
> ""That won't be cheap. But it may be worth it to keep Rizia's other business owners on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[261]`
Mówca: **Elena Werner**
> ""We'll make our move after our security forces make theirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Whatever losses we incur will be worth it for the chance..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever losses we incur will be worth it for the chance to pry our resources out of the hands of greedy oligarchs.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[253]` (Elena Werner), `[254]` (Elena Werner), `[255]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Elena Werner: ""My goodness. You're starting to sound like Saltana.""*)

### Węzeł `[266]`
Mówca: **Elena Werner**
> ""My goodness. You're starting to sound like Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[267]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[268]`
Mówca: **Elena Werner**
> ""If we decide to imprison Rusty Montoro, a government takeover of the company will be relatively easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Elena Werner: ""It will cost us some resources in the short term, but ga..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Arrested == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Elena Werner: ""We'll make our move after our security forces make theirs.""*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Elena Werner: ""If it comes to that, I will have the documents ready.""*)

### Węzeł `[272]`
Mówca: **Elena Werner**
> ""If it comes to that, I will have the documents ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Arrested == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""Rusty isn't even in prison yet. We'll decide this later.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player_Romus: ""A little overeager, aren't you? I haven't even spoken to..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little overeager, aren't you? I haven't even spoken to Rusty about all this yet.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[253]` (Elena Werner), `[254]` (Elena Werner), `[255]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Elena Werner: ""You're right. The decision can wait.""*)

### Węzeł `[277]`
Mówca: **Elena Werner**
> ""You're right. The decision can wait.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Hugo Toras: ""There is one economic factor we have not discussed yet. ..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Elena Werner: ""While we're on the subject...""*)

### Węzeł `[281]`
Mówca: **Hugo Toras**
> ""There is one economic factor we have not discussed yet. Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Everyone turned towards Hugo. Elena gestured for him to c..."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Everyone turned towards Hugo. Elena gestured for him to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Hugo Toras: ""In times of emergency -- such as war -- the Crown reserv..."*)

### Węzeł `[283]`
Mówca: **Hugo Toras**
> ""In times of emergency -- such as war -- the Crown reserves the right to nationalize any corporation deemed essential to the defense and security of the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Hugo Toras: ""One could argue that Rizian Royal Gold belongs to this c..."*)

### Węzeł `[284]`
Mówca: **Elena Werner**
> ""That's it for the economy, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[285]`
Mówca: **Narrator**
> "She closed her book."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Elena Werner: ""That's it for the economy, then.""*)

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""One could argue that Rizian Royal Gold belongs to this category.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Rusty does have known ties to Arcasia. And ATO is taking..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 5"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty does have known ties to Arcasia. And ATO is taking Pales' side in the war...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Laurento Esquibel: ""We have no reason to believe Arcasia is involved in Pale..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we want to keep funding this war, such a measure may be necessary.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Kontekst wejściowy (poprzednik):** `[286]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucita Azaro: ""Yes, thank you for bringing this up, Your Grace. The ext..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 5"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget < 5)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player_Romus: ""If we want to keep funding this war, such a measure may ..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""We can fund this war without resorting to such measures.""*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can fund this war without resorting to such measures.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Kontekst wejściowy (poprzednik):** `[286]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Elena Werner: ""I believe so as well.""*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One could. But I would rather stay on Rusty Montoro's good side.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_Hostile"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[286]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Elena Werner: ""Your Grace, as it stands, Rizian Royal Gold is a valuabl..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Hostile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Hostile == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Hostile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Hostile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Player_Romus: ""If I know Rusty Montoro, he won't allow this without a f..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Hostile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Hostile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player_Romus: ""One could. But I would rather stay on Rusty Montoro's go..."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I know Rusty Montoro, he won't allow this without a fight.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Hostile"] == true`
- **Kontekst wejściowy (poprzednik):** `[286]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Elena Werner: ""Legally, he won't have any recourse to oppose such a mea..."*)

### Węzeł `[298]`
Mówca: **Laurento Esquibel**
> ""We have no reason to believe Arcasia is involved in Pales, Your Majesty. Directly or indirectly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport > 0"*)

### Węzeł `[299]`
Mówca: **Elena Werner**
> ""I believe so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Elena Werner: ""We should not underestimate the difficulty of this endea..."*)

### Węzeł `[300]`
Mówca: **Elena Werner**
> ""Legally, he won't have any recourse to oppose such a measure. But he can definitely make it very difficult for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Elena Werner: ""The effort we expend on this may not be worth the long-t..."*)

### Węzeł `[301]`
Mówca: **Elena Werner**
> ""Your Grace, as it stands, Rizian Royal Gold is a valuable asset to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Elena Werner: ""Nationalization would allow us to extract more value fro..."*)

### Węzeł `[302]`
Mówca: **Lucita Azaro**
> ""But Lespia is supporting the Palesians. And everyone knows they're Arcasia's lapdog.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Elena Werner: ""Be that as it may, we should not underestimate the diffi..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_LespianSupport > 0"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_LespianSupport > 0)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_LespianSupport > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Lucita Azaro: ""But Lespia is supporting the Palesians. And everyone kno..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_LespianSupport > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lucita Azaro: ""But Lespia may still be covertly supporting the Palesian..."*)

### Węzeł `[306]`
Mówca: **Lucita Azaro**
> ""But Lespia may still be covertly supporting the Palesians. And everyone knows they're Arcasia's lapdog.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Elena Werner: ""Be that as it may, we should not underestimate the diffi..."*)

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""Yes, thank you for bringing this up, Your Grace. The extra funds provided by nationalization would indeed be of immense help to the war effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "Elena looked at them both uneasily."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "Elena looked at them both uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Elena Werner: ""We should not underestimate the difficulty of this endea..."*)

### Węzeł `[309]`
Mówca: **Elena Werner**
> ""We should not underestimate the difficulty of this endeavor. The resources we spend on nationalizing RRG may not be worth the long-term gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[310]`
Mówca: **Elena Werner**
> ""Be that as it may, we should not underestimate the difficulty of this endeavor. The resources we spend on nationalizing RRG may not be worth the long-term gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[311]`
Mówca: **Elena Werner**
> ""The effort we expend on this may not be worth the long-term gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "She paused thoughtfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Elena Werner: ""Then again, if your goal is to keep the left-wingers in ..."*)

### Węzeł `[313]`
Mówca: **Elena Werner**
> ""Nationalization would allow us to extract more value from it, it's true. But at quite a large upfront cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && Rizia..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "She paused thoughtfully."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Lucita Azaro: ""If I may chime in, nationalization isn't as complicated ..."*)

### Węzeł `[317]`
Mówca: **Elena Werner**
> ""Then again, if your goal is to keep the left-wingers in the RPP from causing a stir, taking Rizia's most renowned corporation out of private hands might do the trick. For a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player_Romus: ""I have the feeling Soletato's people will not be appease..."*)
  - -> `[319]` (*Player_Romus: ""Sotelato is a former miner, isn't he? It'll make him hap..."*)
  - -> `[320]` (*Player_Romus: ""Nationalization means putting RRG *into* the hands of th..."*)
  - -> `[321]` (*Player_Romus: ""So all of a sudden a ragtag bunch of radicals are more i..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have the feeling Soletato's people will not be appeased that easily.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Elena Werner: ""Maybe not. But in combination with other policies, perha..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sotelato is a former miner, isn't he? It'll make him happy to see his ex-boss lose everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nationalization means putting RRG *into* the hands of the Royal Family. They'd hate that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucita Azaro: ""Yes, and there are other ways to deal with Sotelato.""*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So all of a sudden a ragtag bunch of radicals are more important to please than Rizian business owners?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Lucita Azaro: ""Of course not, Your Majesty.""*)

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""Yes, and there are other ways to deal with Sotelato.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""With that said, nationalization isn't as complicated as ..."*)

### Węzeł `[323]`
Mówca: **Elena Werner**
> ""Maybe not. But in combination with other policies, perhaps...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Lucita Azaro: ""There are other ways to deal with Sotelato. We don't nee..."*)

### Węzeł `[324]`
Mówca: **Vina Toras**
> ""Father. Do you really think the reformists are that petty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostag..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Vina Toras: ""Father. Do you really think the reformists are that petty?""*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Lucita Azaro: ""Happy enough to drop his threats against the crown? I do..."*)

### Węzeł `[328]`
Mówca: **Lucita Azaro**
> ""Happy enough to drop his threats against the crown? I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""With that said, nationalization isn't as complicated as ..."*)

### Węzeł `[329]`
Mówca: **Lucita Azaro**
> ""Of course not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""With that said, nationalization isn't as complicated as ..."*)

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""With that said, nationalization isn't as complicated as Ms. Werner is making it out to be. A swift raid on Montoro's Bronaz palace, and we'll have all the necessary assets secured before he can blink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player_Romus: ""Rusty put his heart and soul into RRG. If we're to natio..."*)
  - -> `[339]` (*Player_Romus: ""A dangerous proposition, Duchess Azaro. What if he and h..."*)
  - -> `[342]` (*Player_Romus: ""That will take manpower. We can't afford to pull people ..."*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)

### Węzeł `[331]`
Mówca: **Lucita Azaro**
> ""There are other ways to deal with Sotelato. We don't need to acknowledge the demands of him or his 'movement'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""With that said, nationalization isn't as complicated as ..."*)

### Węzeł `[332]`
Mówca: **Lucita Azaro**
> ""Please, Your Highness. Sotelato's no more of a saint than Manus Sazon was. But we shouldn't feel compelled to nationalize RRG solely on his behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""With that said, nationalization isn't as complicated as ..."*)

### Węzeł `[333]`
Mówca: **Lucita Azaro**
> ""If I may chime in, nationalization isn't as complicated as Ms. Werner is making it out to be. A swift raid on Montoro's Bronaz palace, and we'll have all the necessary assets secured before he can blink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player_Romus: ""Rusty put his heart and soul into RRG. If we're to natio..."*)
  - -> `[339]` (*Player_Romus: ""A dangerous proposition, Duchess Azaro. What if he and h..."*)
  - -> `[342]` (*Player_Romus: ""That will take manpower. We can't afford to pull people ..."*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Lucita Azaro: ""Please, Your Highness. Sotelato's no more of a saint tha..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Lucita Azaro: ""Sotelato's no saint, Your Highness. But we shouldn't fee..."*)

### Węzeł `[337]`
Mówca: **Lucita Azaro**
> ""Sotelato's no saint, Your Highness. But we shouldn't feel compelled to nationalize RRG solely on his behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""With that said, nationalization isn't as complicated as ..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty put his heart and soul into RRG. If we're to nationalize, he and the other stakeholders should be justly compensated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[333]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Hugo Toras: ""His heart and soul... As if Montoro was in possession of..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A dangerous proposition, Duchess Azaro. What if he and his guards get wind of the operation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[333]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Lucita Azaro: ""There's always that risk. We'd have to make wise use of ..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Montoro was just starting to become useful to me. I don't want to throw away our cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[333]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Elena Werner: ""Sensible, Your Majesty.""*)

### Węzeł `[341]`
Mówca: **Elena Werner**
> ""Sensible, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Elena Werner: ""One last thing to keep in mind...""*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will take manpower. We can't afford to pull people from the front lines.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Lucita Azaro), `[333]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Lucita Azaro: ""With sufficient intelligence, we can complete the task w..."*)

### Węzeł `[343]`
Mówca: **Hugo Toras**
> ""His heart and soul... As if Montoro was in possession of either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Elena Werner: ""Compensation would put Rizia's other business owners at ..."*)

### Węzeł `[344]`
Mówca: **Lucita Azaro**
> ""There's always that risk. We'd have to make wise use of our intelligence services to gauge the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Elena looked around the table."*)

### Węzeł `[345]`
Mówca: **Elena Werner**
> ""Compensation would put Rizia's other business owners at ease. But I fear Montoro won't grant us even that opportunity unless he is forced to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Elena looked around the table."*)

### Węzeł `[346]`
Mówca: **Lucita Azaro**
> ""With sufficient intelligence, we can complete the task with a small core team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Elena looked around the table."*)

### Węzeł `[347]`
Mówca: **Narrator**
> "Elena looked around the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Elena Werner: ""One last thing to keep in mind...""*)

### Węzeł `[348]`
Mówca: **Elena Werner**
> ""It is His Majesty's decision. I admit we could use the extra budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""For the security of the kingdom, it is vital that we nat..."*)
  - -> `[354]` (*Player_Romus: ""I'd like to thank His Grace Hugo for bringing up the mat..."*)
  - -> `[355]` (*Player_Romus: ""I am satisfied with the Crown's current stake in Rizian ..."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 5"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget < 5)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Elena Werner: ""It is His Majesty's decision. I admit we could use the e..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Elena Werner: ""It is His Majesty's decision. Keeping in mind that we do..."*)

### Węzeł `[352]`
Mówca: **Elena Werner**
> ""It is His Majesty's decision. Keeping in mind that we don't strictly need the extra budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""For the security of the kingdom, it is vital that we nat..."*)
  - -> `[354]` (*Player_Romus: ""I'd like to thank His Grace Hugo for bringing up the mat..."*)
  - -> `[355]` (*Player_Romus: ""I am satisfied with the Crown's current stake in Rizian ..."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the security of the kingdom, it is vital that we nationalize Rizian Royal Gold. Lucita, you have my permission to act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Elena Werner), `[352]` (Elena Werner), `[463]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to thank His Grace Hugo for bringing up the matter. Rusty's had this coming for a long time. I say we do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Elena Werner), `[352]` (Elena Werner), `[463]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Hugo Toras: ""Very good, Your Majesty.""*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am satisfied with the Crown's current stake in Rizian Royal Gold. Nationalization is not worth the effort.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Elena Werner), `[352]` (Elena Werner), `[463]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Elena Werner: ""Very good.""*)

### Węzeł `[356]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NationalizeRRG_War = true; RiziaDLC.Enable_RRG_N..."*)

### Węzeł `[357]`
Mówca: **Hugo Toras**
> ""Very good, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NationalizeRRG_War = true; RiziaDLC.Enable_RRG_N..."*)

### Węzeł `[358]`
Mówca: **Elena Werner**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NationalizeRRG_War = true;
RiziaDLC.Enable_RRG_Nationalization = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.NationalizeRRG_War"] = true;
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the current state of our intelligence services, this is a risk we cannot afford to take. We will leave RRG alone.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == false`
- **Kontekst wejściowy (poprzednik):** `[348]` (Elena Werner), `[352]` (Elena Werner), `[463]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Elena Werner: ""Very good.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player_Romus: ""With the current state of our intelligence services, thi..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective ..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested = true; RiziaDLC.Rusty_Allied = f..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled = true; R..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested = true;
RiziaDLC.Rusty_Allied = false;
RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest = true;
EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");
RiziaDLC.Enable_RRG_Nationalization = true;
RiziaDLCText.RustyArrestReason = "as part of a sweeping wartime seizure of the Rizian Royal Gold corporation";
RiziaDLCSupport.News_Turn08_G_RustyArrested = true;
RiziaDLCSupport.News_Turn08_RH_RustyArrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rusty_Arrested"] = true;
Variable["RiziaDLC.Rusty_Allied"] = false;
Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest"] = true;
EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;
Variable["RiziaDLCText.RustyArrestReason"] ="as part of a sweeping wartime seizure of the Rizian Royal Gold corporation";
Variable["RiziaDLCSupport.News_Turn08_G_RustyArrested"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_RustyArrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_V_RRGNationalization = true;"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_GrantROGStake == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_GrantROGStake == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_GrantROGStake == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_GrantROGStake == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_GrantROGStake"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_Modifier_SoldROGStake = 0"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_GrantROGStake == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_GrantROGStake"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_Modifier_SoldROGStake = 0`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_Modifier_SoldROGStake"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled = true;
RiziaDLCText.RustyFate = "departure";
RiziaDLC.Rusty_Allied = false;
RiziaDLC.Rusty_Fled = true;
RiziaDLC.Budget_Modifier_RizianGoldIndustry -= 2; 
RiziaDLC.Enable_RRG_Nationalization = true;
EnableCodexEntry("Characters_Business_RustyMontoro_Fled");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled"] = true;
Variable["RiziaDLCText.RustyFate"] ="departure";
Variable["RiziaDLC.Rusty_Allied"] = false;
Variable["RiziaDLC.Rusty_Fled"] = true;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] - 2;
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;
EnableCodexEntry("Characters_Business_RustyMontoro_Fled");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_V_RRGNationalization = true;"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true"*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrow..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrowth = true;
RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrowth"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Elena Werner: ""As for our business climate...""*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_V_RRGNationalization = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_V_RRGNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_GrantROGStake == true"*)

### Węzeł `[378]`
Mówca: **Elena Werner**
> ""One last thing to keep in mind...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "Jump to: [Elena Stock Exchange Convo]"*)

### Węzeł `[379]`
Mówca: **Elena Werner**
> ""Rusty Montoro's name was floated as a candidate to chair it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Hugo Toras: ""You'd trust that man with the Rizian stock market?""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus: ""Montoro was just starting to become useful to me. I don'..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[383]`
Mówca: **Hugo Toras**
> ""You'd trust that man with the Rizian stock market?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Romus: ""Of course not. It's a terrible idea.""*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[386]` (*Player_Romus: ""I never much liked the idea of gambling with our kingdom..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. It's a terrible idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Elena Werner: ""I have doubts about it myself, Your Majesty. But its pro..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? He could make us a lot of money.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Kontekst wejściowy (poprzednik):** `[383]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Hugo Toras: ""Us, or himself?""*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never much liked the idea of gambling with our kingdom's finances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Elena Werner: ""Nor do I. But I admit that if done right, this could ope..."*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's high time we established such a draw for investors. But I'm not sold on the idea of Rusty heading it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[383]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Elena Werner: ""It can be someone else. But Mr. Montoro does have the ri..."*)

### Węzeł `[388]`
Mówca: **Elena Werner**
> ""It can be someone else. But Mr. Montoro does have the right connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""If we established such an exchange, Rizia's economy woul..."*)

### Węzeł `[389]`
Mówca: **Elena Werner**
> ""Nor do I. But I admit that if done right, this could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""If we established such an exchange, Rizia's economy woul..."*)

### Węzeł `[390]`
Mówca: **Hugo Toras**
> ""Us, or himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""If we established such an exchange, Rizia's economy woul..."*)

### Węzeł `[391]`
Mówca: **Elena Werner**
> ""I have doubts about it myself, Your Majesty. But its proponents say it could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""If we established such an exchange, Rizia's economy woul..."*)

### Węzeł `[392]`
Mówca: **Laurento Esquibel**
> ""If we established such an exchange, Rizia's economy would be tied to our global image more strongly than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "He smiled impishly."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Laurento Esquibel: ""As it stands, we have to think carefully before taking t..."*)

### Węzeł `[396]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have the potential to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Elena Werner: ""Correct as usual, Mr. Esquibel.""*)

### Węzeł `[397]`
Mówca: **Narrator**
> "He smiled impishly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Laurento Esquibel: ""As it stands, we have the potential to win big.""*)

### Węzeł `[398]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have to think carefully before taking that risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Elena Werner: ""Correct as usual, Mr. Esquibel.""*)

### Węzeł `[399]`
Mówca: **Elena Werner**
> ""Correct as usual, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Elena Werner: ""But we're getting off track. I'd like to know His Majest..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[403]`
Mówca: **Elena Werner**
> ""But we're getting off track. I'd like to know His Majesty's verdict on the wartime nationalization of RRG.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 5"*)

### Węzeł `[404]`
Mówca: **Elena Werner**
> ""While we're on the subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "Jump to: [Elena Stock Exchange Convo]"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_KnownLespianAgent == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player_Romus: ""Why not? He could make us a lot of money.""*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_KnownLespianAgent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Player_Romus: ""With the leverage we now have over him, he could make us..."*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the leverage we now have over him, he could make us a lot of money.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[383]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Hugo Toras: ""Us, or himself?""*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_KnownLespianAgent == true)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player_Romus: ""It's high time we established such a draw for investors...."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_KnownLespianAgent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Player_Romus: ""It's high time we established such a draw for investors...."*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's high time we established such a draw for investors. But I have other plans for Rusty.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Kontekst wejściowy (poprzednik):** `[383]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Elena Werner: ""Understood. It doesn't have to be him leading it.""*)

### Węzeł `[413]`
Mówca: **Elena Werner**
> ""Understood. It doesn't have to be him leading it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""If we established such an exchange, Rizia's economy woul..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Arrested == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Elena Werner: ""Speaking of all this...""*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Elena Werner: ""One last thing to keep in mind...""*)

### Węzeł `[417]`
Mówca: **Elena Werner**
> ""Speaking of all this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "Elena Stock Exchange Convo"*)

### Węzeł `[418]`
Mówca: **Elena Werner**
> ""Rusty Montoro's name was floated as a candidate to chair it. Obviously, that's not going to happen now. But the general idea still stands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Laurento Esquibel: ""If we established such an exchange, Rizia's economy woul..."*)

### Węzeł `[419]`
Mówca: **Laurento Esquibel**
> ""If we established such an exchange, Rizia's economy would be tied to our global image more strongly than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Narrator: "He smiled impishly."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Laurento Esquibel: ""As it stands, we have to think carefully before taking t..."*)

### Węzeł `[423]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have the potential to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Elena Werner: ""Correct as usual, Mr. Esquibel.""*)

### Węzeł `[424]`
Mówca: **Narrator**
> "He smiled impishly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Laurento Esquibel: ""As it stands, we have the potential to win big.""*)

### Węzeł `[425]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have to think carefully before taking that risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Elena Werner: ""Correct as usual, Mr. Esquibel.""*)

### Węzeł `[426]`
Mówca: **Elena Werner**
> ""Correct as usual, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Elena Stock Exchange Convo`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange =..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange =..."*)
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Elena Werner: ""As you may have heard, I was talking to some business ow..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Elena Werner: ""I'm glad you took my advice to form the Porte Drazon Sto..."*)

### Węzeł `[431]`
Mówca: **Elena Werner**
> ""As you may have heard, I was talking to some business owners about the idea of forming a stock exchange in Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Arrested == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Elena Werner: ""Rusty Montoro's name was floated as a candidate to chair..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Elena Werner: ""Rusty Montoro's name was floated as a candidate to chair..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Elena Stock Exchange Convo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "Elena Stock Exchange Convo"*)

### Węzeł `[436]`
Mówca: **Elena Werner**
> ""I'm glad you took my advice to form the Porte Drazon Stock Exchange. Once it opens, our kingdom will finally be fully integrated into the global market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Laurento Esquibel: ""With all the diplomatic benefits that entails.""*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Laurento Esquibel: ""With all the risks and perils that entails.""*)

### Węzeł `[440]`
Mówca: **Laurento Esquibel**
> ""With all the diplomatic benefits that entails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Elena Werner: ""And I thought I'd let you know that Rusty Montoro's name..."*)

### Węzeł `[441]`
Mówca: **Laurento Esquibel**
> ""With all the risks and perils that entails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Elena Werner: ""And I thought I'd let you know that Rusty Montoro's name..."*)

### Węzeł `[442]`
Mówca: **Elena Werner**
> ""And I thought I'd let you know that Rusty Montoro's name has been floated as a candidate to chair it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Hugo Toras: ""You'd trust that man with the Rizian stock market?""*)

### Węzeł `[443]`
Mówca: **Hugo Toras**
> ""You'd trust that man with the Rizian stock market?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player_Romus: ""Of course not. It's a terrible idea.""*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[446]` (*Player_Romus: ""If our kingdom's finances are to be gambled with, I'd pr..."*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLesp..."*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. It's a terrible idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Elena Werner: ""He's a known name in Arcasian circles, for better or wor..."*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? He could make us a lot of money.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Kontekst wejściowy (poprzednik):** `[443]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Hugo Toras: ""Us, or himself?""*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our kingdom's finances are to be gambled with, I'd prefer you be the one rolling the dice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Elena Werner: ""That's very kind. But I admit that with Mr. Montoro's co..."*)

### Węzeł `[447]`
Mówca: **Elena Werner**
> ""That's very kind. But I admit that with Mr. Montoro's connections, he could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[448]`
Mówca: **Hugo Toras**
> ""Us, or himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Elena Werner: ""He's a known name in Arcasian circles, for better or wor..."*)

### Węzeł `[449]`
Mówca: **Elena Werner**
> ""He's a known name in Arcasian circles, for better or worse. Appointing him could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_KnownLespianAgent == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player_Romus: ""Why not? He could make us a lot of money.""*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_KnownLespianAgent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Player_Romus: ""With the leverage we now have over him, he could make us..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the leverage we now have over him, he could make us a lot of money.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[443]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Hugo Toras: ""Us, or himself?""*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLespianAgent == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLesp..."*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLe..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLespianAgent == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true  and  Variable["RiziaDLC.Rusty_KnownLespianAgent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player_Romus: ""Give Rusty a chance, Hugo. He's done more for Rizia than..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLespianAgent == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true  and  Variable["RiziaDLC.Rusty_KnownLespianAgent"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give Rusty a chance, Hugo. He's done more for Rizia than you know.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Allied"] == true  and  Variable["RiziaDLC.Rusty_KnownLespianAgent"] == false`
- **Kontekst wejściowy (poprzednik):** `[443]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Elena Werner: ""And he has the right connections.""*)

### Węzeł `[458]`
Mówca: **Elena Werner**
> ""And he has the right connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Elena Werner: ""He's a known name in Arcasian circles, for better or wor..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Elena Werner: ""That is, if we don't nationalize his company.""*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)

### Węzeł `[462]`
Mówca: **Elena Werner**
> ""That is, if we don't nationalize his company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Hugo Toras: ""Which, again, I highly recommend.""*)

### Węzeł `[463]`
Mówca: **Hugo Toras**
> ""Which, again, I highly recommend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""For the security of the kingdom, it is vital that we nat..."*)
  - -> `[354]` (*Player_Romus: ""I'd like to thank His Grace Hugo for bringing up the mat..."*)
  - -> `[355]` (*Player_Romus: ""I am satisfied with the Crown's current stake in Rizian ..."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ForeignIntelligence_Effective ==..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_KnownLespianAgent == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_KnownLespianAgent == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_KnownLespianAgent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Elena Werner: ""Although of course there is the matter of his... allegia..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_KnownLespianAgent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Elena Werner: ""But it's your decision, Your Majesty. The appointment wi..."*)

### Węzeł `[467]`
Mówca: **Elena Werner**
> ""Although of course there is the matter of his... allegiance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Hugo Toras: ""Ms. Werner, are you seriously suggesting handing our fin..."*)

### Węzeł `[468]`
Mówca: **Hugo Toras**
> ""Ms. Werner, are you seriously suggesting handing our financial reins to a traitor for the sake of a few guilder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_Council_RustyAgent == false"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 5"*)
  - -> `[479]` (*Player_Romus: ""I agree with you, Hugo. This is absurd.""*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_Council_RustyAgent == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_Council_RustyAgent == false"*)
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_Council_RustyAgent == false)"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_Council_RustyAgent == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Player_Romus: ""I have other plans for Rusty, Hugo. Don't worry.""*)
  - -> `[473]` (*Player_Romus: ""Mr. Montoro's fate will be discussed shortly. I'll keep ..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_Council_RustyAgent == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Player_Romus: ""I'll decide for myself whether he's a traitor. Then we'l..."*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have other plans for Rusty, Hugo. Don't worry.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false`
- **Kontekst wejściowy (poprzednik):** `[468]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Montoro's fate will be discussed shortly. I'll keep this information in mind.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false`
- **Kontekst wejściowy (poprzednik):** `[468]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our treasury is shrinking. This is worth taking into consideration.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Kontekst wejściowy (poprzednik):** `[468]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[475]`
Mówca: **Elena Werner**
> ""But it's your decision, Your Majesty. The appointment will be made a few months from now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget < 5"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget < 5)"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""Our treasury is shrinking. This is worth taking into con..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Not just a few. Long-lasting financial security for Rizi..."*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you, Hugo. This is absurd.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Elena Werner: ""I would be happy to chair the exchange myself, Your Maje..."*)

### Węzeł `[480]`
Mówca: **Elena Werner**
> ""I would be happy to chair the exchange myself, Your Majesty. I'm just conveying business owners' opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not just a few. Long-lasting financial security for Rizia is finally within our grasp.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Kontekst wejściowy (poprzednik):** `[468]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll decide for myself whether he's a traitor. Then we'll see.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[468]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)
