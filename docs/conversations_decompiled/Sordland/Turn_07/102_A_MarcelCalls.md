# Sordland/Turn07/A_MarcelCalls

- **ID konwersacji:** `102`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/102_A_MarcelCalls.md`
- **Liczba węzłów dialogowych:** 362
- **Liczba wyborów gracza:** 52

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.BergiaSpecialZone_Proposal_Amendment`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce`
- `BaseGame.Decision_Turn06_GasomSaleResult_Low`
- `BaseGame.Decision_Turn06_GasomSaleResult_VeryLow`
- `BaseGame.Decision_Turn06_Lobbying_Bribe`
- `BaseGame.Decision_Turn06_Lobbying_Bribe2`
- `BaseGame.Decision_Turn06_Lobbying_Bribe3`
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Faction_OldGuard_Destroyed`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Situation_Economy_BusinessBailout`
- `BaseGame.Turn01_Admin_Meeting`
- `BaseGame.Turn01_Admin_TalkedToMarcel`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGame.Turn07_MarcelFavor_NoNationalizeHOS`
- `BaseGame.Turn07_MarcelFavor_PrivateTakeover`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn07_A_Marcel_OwnershipDeal`
- `BaseGame.Turn07_A_Marcel_Threatened`
- `BaseGame.Turn07_MarcelFavor_NoNationalizeHOS`
- `BaseGame.Turn07_MarcelFavor_PrivateTakeover`
- `BaseGameIsolated.Turn07_MarcelCall_NotListened`
- `BaseGameSupport.Journal_Turn07_MarcelThreatened`
- `BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader`
- `BaseGameSupport.News_Turn07_E_Gasom_LowReturnsForState`
- `BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration`
- `BaseGameSupport.News_Turn07_G_WehlenJointOperation`
- `BaseGameSupport.News_Turn07_HP_SupremeCourtChargesBron`
- `BaseGameSupport.News_Turn07_HP_SupremeCourtDelaysCase`
- `BaseGameSupport.News_Turn07_LT_BludLeadersCallForAmendment`
- `BaseGameSupport.News_Turn07_LT_NFPCondemns_ProBlud`
- `BaseGameSupport.News_Turn07_LT_ProtestAgainstCourtDelay`
- `BaseGameSupport.News_Turn07_LT_ProtestAgainstJointOperation`
- `BaseGameSupport.News_Turn07_LT_ProtestAgainstSollistOutcome`
- `BaseGameSupport.News_Turn07_R_BludLeadersCallForAmendment`
- `BaseGameSupport.News_Turn07_R_BludsCondemnPresident`
- `BaseGameSupport.News_Turn07_R_ProtestAgainstRayne`
- `BaseGameSupport.News_Turn07_R_SupremeCourtChargesBron`
- `BaseGameSupport.News_Turn07_R_SupremeCourtDelaysCase`
- `BaseGameSupport.News_Turn07_R_WehlenBorderClosed`
- `BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction`
- `BaseGameSupport.Report_Turn07_Erzaren_LocalsProtestJointOperation`
- `BaseGameSupport.Report_Turn07_Holsord_EmergencyBeingIgnored`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ConflictedAmendment_BludsPullOut`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtChargesBron`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtDelaysCase`
- `BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegative`
- `BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositive`
- `BaseGameSupport.Report_Turn07_Holsord_USPShowSupportEmergency`
- `BaseGameSupport.Report_Turn07_Lachaven_IncreasedSupportForBludishRight`
- `BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt`
- `BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCallForAmendment`
- `BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCondemnPresident`
- `BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings`
- `BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings2`
- `BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings3`
- `BaseGameSupport.Report_Turn07_Vesord_ProtestAgainstEmergency`
- `GameCondition.Turn07_A_MarcelCalls`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"“I don't see why we should be enemies.”"** | `[12]` **Marcel Koronti**: "“You can't blame them, can you? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Marcel Koronti**: "“Exactly.”" |
| `[13]` | **"“We will only ask for a reasonable share. Nothing out of the ordinary.”"** | `[12]` **Marcel Koronti**: "“You can't blame them, can you? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Marcel Koronti**: "“That is good to hear.”" |
| `[14]` | **"“They'll have to deal with whatever I decide. It is a tough world.”"** | `[12]` **Marcel Koronti**: "“You can't blame them, can you? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Marcel Koronti**: "“Please don't take what I'm abou..." |
| `[16]` | **"“I haven't been seeing any benefits yet.”"** | `[8]` **Marcel Koronti**: "“Half of the non-state media in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Marcel Koronti**: "“Mr. Rayne. I used my connection..." |
| `[17]` | **""There's always more you could be doing for us.”"** | `[8]` **Marcel Koronti**: "“Half of the non-state media in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Marcel Koronti**: "“Mr. Rayne. We essentially acqui..." |
| `[20]` | **"“Our partnership has been successful so far.”"** | `[8]` **Marcel Koronti**: "“Half of the non-state media in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Marcel Koronti**: "“I'm glad you agree. Your public..." |
| `[30]` | **"“I'm glad to hear that. It was a widely contested decision.”"** | `[37]` **Marcel Koronti**: "“We managed to avoid closing tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Marcel Koronti**: "“It must've been a hard choice. ..." |
| `[31]` | **"“Ensuring employment was our primary target.”"** | `[37]` **Marcel Koronti**: "“We managed to avoid closing tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Marcel Koronti**: "“Of course.”" |
| `[32]` | **"“Of course. Private corporations had to have a financial leg up to boost investmen..."** | `[118]` **Marcel Koronti**: "“You have successfully strengthe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Marcel Koronti**: "“You couldn't be more right.”" |
| `[33]` | **"“Needless to say, I still expect you to reinvest any surplus back into the economy..."** | `[118]` **Marcel Koronti**: "“You have successfully strengthe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Marcel Koronti**: "“Increasing our investments insi..." |
| `[34]` | **"“Underhall has been a pleasure to work with. They made our opening a success.""** | `[42]` **Marcel Koronti**: "“The mayor of Conriat Kris Schar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Marcel Koronti**: "“It is the number-one constructi..." |
| `[36]` | **"“The decision wasn't necessarily made to benefit you, Marcel.”"** | `[42]` **Marcel Koronti**: "“The mayor of Conriat Kris Schar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Marcel Koronti**: "“Perhaps not, but it certainly w..." |
| `[53]` | **"Pick up the phone."** | `[132]` **Narrator**: "The phone rang and I put the age..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Marcel Koronti**: "“Greetings, Mr. President. I'm s..."<br>`[55]` **Marcel Koronti**: "“Greetings, Mr. President. It ha..."<br>*(oraz 2 innych odgałęzień)* |
| `[64]` | **"“Why did you call me?”"** | `[57]` **Marcel Koronti**: "“Oh, I remember. It was in Conri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“You probably know why I am call..." |
| `[65]` | **"“I've been starting to regret that decision.”"** | `[57]` **Marcel Koronti**: "“Oh, I remember. It was in Conri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Marcel Koronti**: "“That is unfortunate. My father ..." |
| `[66]` | **"“For a good reason.”"** | `[57]` **Marcel Koronti**: "“Oh, I remember. It was in Conri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Marcel Koronti**: "“Well, we are both adults here. ..." |
| `[75]` | **"“You tell me. Where are we now?”"** | `[61]` **Marcel Koronti**: "“And look at where we are now.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Marcel Koronti**: "“The real question is about wher..." |
| `[76]` | **"“Is that really why you called?”"** | `[61]` **Marcel Koronti**: "“And look at where we are now.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Marcel Koronti**: "“I think you know why I am calli..." |
| `[77]` | **"“I've been starting to regret that decision.”"** | `[61]` **Marcel Koronti**: "“And look at where we are now.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Marcel Koronti**: "“That is unfortunate. My father ..." |
| `[90]` | **"“Get to the point. What do you want?”"** | `[89]` **Marcel Koronti**: "“My attempts to reach you seem t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Marcel Koronti**: "“I think you already know. I'm c..." |
| `[91]` | **"“Yet here we are, talking.”"** | `[89]` **Marcel Koronti**: "“My attempts to reach you seem t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Marcel Koronti**: "“Indeed.”" |
| `[92]` | **"“Apologies. That was certainly not my intention.”"** | `[89]` **Marcel Koronti**: "“My attempts to reach you seem t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Marcel Koronti**: "“It's alright, Mr. President.”" |
| `[108]` | **"“You're welcome.”"** | `[42]` **Marcel Koronti**: "“The mayor of Conriat Kris Schar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Marcel Koronti**: ""Moving on..."" |
| `[115]` | **"“Never forget who made that decision.”"** | `[37]` **Marcel Koronti**: "“We managed to avoid closing tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Marcel Koronti**: "“Don't worry, Mr. President. I w..." |
| `[120]` | **"“It was a tough decision. Don't make me regret it.”"** | `[118]` **Marcel Koronti**: "“You have successfully strengthe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Marcel Koronti**: "“I assure you, I won't.”" |
| `[123]` | **"“Good.”"** | `[126]` **Marcel Koronti**: "“But I assure you, it is nothing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "He paused for a few seconds." |
| `[125]` | **"“Unfortunately, we had to tighten our belts wherever we could.”"** | `[126]` **Marcel Koronti**: "“But I assure you, it is nothing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Marcel Koronti**: "“That way of thinking is correct..." |
| `[150]` | **"“We don't need to be enemies.”"** | `[149]` **Marcel Koronti**: "“Ah, let's not even imagine that..."<br>`[147]` **Marcel Koronti**: "“You may recall that one of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Marcel Koronti**: "“No. We don't.”" |
| `[151]` | **"“Imagine this scenario. You will either help me out, or I will eat your little com..."** | `[149]` **Marcel Koronti**: "“Ah, let's not even imagine that..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] = true;` | `[164]` **Marcel Koronti**: "“As long as you do as I say and ..." |
| `[152]` | **"“I don't give in to threats. Your time is over, Koronti.”"** | `[149]` **Marcel Koronti**: "“Ah, let's not even imagine that..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_A_Marcel_Threatened"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_MarcelThreatened...` | `[155]` **Marcel Koronti**: "“What an unfortunate turn of eve..." |
| `[153]` | **"“Don't get your knickers in a twist. I was planning on leaving HOS alone anyway.”"** | `[149]` **Marcel Koronti**: "“Ah, let's not even imagine that..."<br>`[147]` **Marcel Koronti**: "“You may recall that one of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Marcel Koronti**: "“That is excellent to hear!”" |
| `[179]` | **"“That's exactly what I was thinking.”"** | `[178]` **Marcel Koronti**: "“After all, I am considering buy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Marcel Koronti**: "“Excellent! Great minds do think..." |
| `[182]` | **"“Screw you.”"** | `[180]` **Marcel Koronti**: "“You think I don't know?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "He laughed again." |
| `[183]` | **"“Don't know what?”"** | `[180]` **Marcel Koronti**: "“You think I don't know?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "He laughed again." |
| `[186]` | **"“Privatizing both might be too much. I will see what I can do.”"** | `[178]` **Marcel Koronti**: "“After all, I am considering buy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Marcel Koronti**: "“Think about it this way. It is ..." |
| `[188]` | **"“I am not thinking about privatization.”"** | `[178]` **Marcel Koronti**: "“After all, I am considering buy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Marcel Koronti**: "“What do you mean? You will leav..." |
| `[192]` | **"“Yes, I am.”"** | `[191]` **Marcel Koronti**: "“Don't tell me you are thinking ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Marcel Koronti**: "“Mr. President. Nationalization ..." |
| `[194]` | **"“I'm thinking about a more balanced approach.”"** | `[191]` **Marcel Koronti**: "“Don't tell me you are thinking ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Marcel Koronti**: "“Balance is important, Mr. Presi..." |
| `[204]` | **"“I see where this is going.”"** | `[203]` **Marcel Koronti**: "“It is high time something chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Marcel Koronti**: "“I want him gone.”" |
| `[205]` | **"“Who do you have in mind to replace him?”"** | `[203]` **Marcel Koronti**: "“It is high time something chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Marcel Koronti**: "“Who do you think?"" |
| `[206]` | **"“Stop. Before you say anything more, I won't meddle in Oligarchs' affairs.”"** | `[203]` **Marcel Koronti**: "“It is high time something chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Marcel Koronti**: "“You may recall that one of the ..."<br>`[207]` **Marcel Koronti**: "“Ah, it was worth a shot. But I ..." |
| `[220]` | **"“I'll have to think about it.”"** | `[219]` **Marcel Koronti**: "“How does that sound?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Marcel Koronti**: "“Just think about it. That's all..." |
| `[221]` | **"“That sounds profitable to me. Deal.”"** | `[219]` **Marcel Koronti**: "“How does that sound?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] =...` | `[223]` **Marcel Koronti**: "“Perfect!”" |
| `[222]` | **"“I won't make myself a target by picking a side.”"** | `[219]` **Marcel Koronti**: "“How does that sound?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Marcel Koronti**: "“You and me. We would be unstopp..." |
| `[229]` | **"“Thanks Marcel. Talk to you later.”"** | `[228]` **Marcel Koronti**: "“Thank you for your time, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "After a couple of minutes, I wen..." |
| `[230]` | **"“Goodbye, Mr. Koronti.”"** | `[228]` **Marcel Koronti**: "“Thank you for your time, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "After a couple of minutes, I wen..." |
| `[231]` | **"Hang up."** | `[228]` **Marcel Koronti**: "“Thank you for your time, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "After a couple of minutes, I wen..." |
| `[242]` | **"“You've outlived your usefulness to me. You are done for, Koronti.”"** | `[147]` **Marcel Koronti**: "“You may recall that one of the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_A_Marcel_Threatened"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_MarcelThreatened...` | `[155]` **Marcel Koronti**: "“What an unfortunate turn of eve..." |
| `[243]` | **"“I understand. I want our partnership to continue uninterrupted.”"** | `[147]` **Marcel Koronti**: "“You may recall that one of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Marcel Koronti**: "“As do I.”" |
| `[256]` | **""I'll have to think about it.""** | `[255]` **Marcel Koronti**: "“Do you accept?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Marcel Koronti**: ""Think about all the free help y..." |
| `[257]` | **""Of course. A deal's a deal.""** | `[255]` **Marcel Koronti**: "“Do you accept?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Marcel Koronti**: ""Korontis always keep their word..." |
| `[258]` | **""You're asking too much of me.""** | `[255]` **Marcel Koronti**: "“Do you accept?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Marcel Koronti**: ""Think about all the free help y..." |

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
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Marcel Koronti: "“I can't help but mention your tax hike, Mr. President.""*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He paused for a few seconds."*)

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“I'm sure you'll agree that the support I and my network have given your administration has been nothing but beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Marcel Koronti: "“Half of the non-state media in the country has been shar..."*)

### Węzeł `[7]`
Mówca: **Marcel Koronti**
> "“Mr. Rayne. I used my connections to cancel the publishing of 73 negative articles and personally directed the release of more than 41 positive reports, be they on the television, radio or newsprint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Marcel Koronti: "“Nobody in the entire country is supporting you as much a..."*)

### Węzeł `[8]`
Mówca: **Marcel Koronti**
> "“Half of the non-state media in the country has been sharing positive news about you and downplaying negative events.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“Our partnership has been successful so far.”"*)
  - -> `[17]` (*Player: ""There's always more you could be doing for us.”"*)
  - -> `[16]` (*Player: "“I haven't been seeing any benefits yet.”"*)

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“I'm glad you agree. Your public opinion could have nosedived were it not for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I heard him knock on wood."*)

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“Out of goodwill, I will share a key piece of information.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Marcel Koronti: "“The Lotherberg Group has contingency plans if you decide..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I don't see why we should be enemies.”"]** — Mówca: **Player**
> "“I don't see why we should be enemies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Marcel Koronti: "“Exactly.”"*)

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“You can't blame them, can you? Imagine someone trying to take your authority and personal wealth away without your consent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "“They'll have to deal with whatever I decide. It is a tou..."*)
  - -> `[13]` (*Player: "“We will only ask for a reasonable share. Nothing out of ..."*)
  - -> `[11]` (*Player: "“I don't see why we should be enemies.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“We will only ask for a reasonable share. Nothing out of the ordinary.”"]** — Mówca: **Player**
> "“We will only ask for a reasonable share. Nothing out of the ordinary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Marcel Koronti: "“That is good to hear.”"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“They'll have to deal with whatever I decide. It is a tough world.”"]** — Mówca: **Player**
> "“They'll have to deal with whatever I decide. It is a tough world.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Marcel Koronti: "“Please don't take what I'm about to say as a threat.”"*)

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“I can't help but mention the tax breaks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Marcel Koronti: "“They have been extraordinarily beneficial to our quarter..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I haven't been seeing any benefits yet.”"]** — Mówca: **Player**
> "“I haven't been seeing any benefits yet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Marcel Koronti: "“Mr. Rayne. I used my connections to cancel the publishin..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""There's always more you could be doing for us.”"]** — Mówca: **Player**
> ""There's always more you could be doing for us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Marcel Koronti: "“Mr. Rayne. We essentially acquired Lachaven Times and ha..."*)

### Węzeł `[18]`
Mówca: **Marcel Koronti**
> "“Please don't take what I'm about to say as a threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Marcel Koronti: "“If you are not careful about what happens next, it might..."*)

### Węzeł `[19]`
Mówca: **Marcel Koronti**
> "“That is good to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Marcel Koronti: "“If everyone plays their cards right, it will be all fine.”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Our partnership has been successful so far.”"]** — Mówca: **Player**
> "“Our partnership has been successful so far.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Marcel Koronti: "“I'm glad you agree. Your public opinion could have nosed..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_BusinessBailout == true"*)

### Węzeł `[24]`
Mówca: **Marcel Koronti**
> "“The increased taxes have made a substantial dent in HOS' net profits. This has hurt the backbone of the Sordish economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: "“But I assure you, it is nothing we can't endure.”"*)

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“Mr. Rayne. We essentially acquired Lachaven Times and have been coordinating media publishing across the three largest broadcasting organisations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Marcel Koronti: "“Nobody in the entire country is supporting you as much a..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Marcel Koronti: "“I can't help but mention the tax breaks, Mr. President.”"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "I heard him knock on wood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Marcel Koronti: ""On another note...""*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“I'm glad to hear that. It was a widely contested decision.”"]** — Mówca: **Player**
> "“I'm glad to hear that. It was a widely contested decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Marcel Koronti: "“It must've been a hard choice. It is safe to say that yo..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Ensuring employment was our primary target.”"]** — Mówca: **Player**
> "“Ensuring employment was our primary target.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Marcel Koronti: "“Of course.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Of course. Private corporations had to have a financial leg up to boost investments.”"]** — Mówca: **Player**
> "“Of course. Private corporations had to have a financial leg up to boost investments.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Marcel Koronti: "“You couldn't be more right.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Needless to say, I still expect you to reinvest any surplus back into the economy to create more jobs.”"]** — Mówca: **Player**
> "“Needless to say, I still expect you to reinvest any surplus back into the economy to create more jobs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Marcel Koronti: "“Increasing our investments inside Sordland is a key topi..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Underhall has been a pleasure to work with. They made our opening a success.""]** — Mówca: **Player**
> "“Underhall has been a pleasure to work with. They made our opening a success.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Marcel Koronti: "“It is the number-one construction company in Sordland, a..."*)

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“Increasing our investments inside Sordland is a key topic in our board discussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He paused for a few seconds."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“The decision wasn't necessarily made to benefit you, Marcel.”"]** — Mówca: **Player**
> "“The decision wasn't necessarily made to benefit you, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Marcel Koronti: "“Perhaps not, but it certainly worked out for me.”"*)

### Węzeł `[37]`
Mówca: **Marcel Koronti**
> "“We managed to avoid closing those companies, and they satisfied the Board of HOS with a high profit report in return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Ensuring employment was our primary target.”"*)
  - -> `[30]` (*Player: "“I'm glad to hear that. It was a widely contested decision.”"*)
  - -> `[115]` (*Player: "“Never forget who made that decision.”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_BusinessBailout == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_BusinessBailout == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_BusinessBailout == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_BusinessBailout == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_BusinessBailout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Marcel Koronti: "“I know it has been a while, but I have to give credit wh..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_BusinessBailout == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_BusinessBailout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "He paused for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Marcel Koronti: "“Out of goodwill, I will share a key piece of information.”"*)

### Węzeł `[42]`
Mówca: **Marcel Koronti**
> "“The mayor of Conriat Kris Schar is a close friend and an investor in Underhall, and your contracting of the firm has tripled his returns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“Underhall has been a pleasure to work with. They made ou..."*)
  - -> `[36]` (*Player: "“The decision wasn't necessarily made to benefit you, Mar..."*)
  - -> `[108]` (*Player: "“You're welcome.”"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_TalkedToMarcel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_TalkedToMarcel == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_Admin_TalkedToMarcel == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_TalkedToMarcel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“Greetings, Mr. President. It has been a while, hasn't it?""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_Admin_TalkedToMarcel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Marcel Koronti: "“Greetings, Mr. President. My name is Marcel Koronti. CEO..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_Admin_Meeting == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_Admin_Meeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_TalkedToMarcel == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Marcel Koronti: "“Greetings, Mr. President. I'm sorry to disturb you befor..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Marcel Koronti: "“Greetings, Mr. President. It has been a while, hasn't it?""*)

### Węzeł `[52]`
Mówca: **Narrator**
> "I was in my office, looking through the agenda for the upcoming meeting at the Ministry of Economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGa..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Italic**
> "I picked up the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)

### Węzeł `[54]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. I'm sorry to disturb you before such an important meeting. But I thought now would be a good time to talk about our... arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Marcel Koronti: "“I'm sure you'll agree that the support I and my network ..."*)

### Węzeł `[55]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. It has been a while, hasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Marcel Koronti: "“Let me try to remember. When was the last time we had a ..."*)

### Węzeł `[56]`
Mówca: **Marcel Koronti**
> "“Let me try to remember. When was the last time we had a chat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Marcel Koronti: "“Oh, I remember. It was in Conriat when you refused my gr..."*)

### Węzeł `[57]`
Mówca: **Marcel Koronti**
> "“Oh, I remember. It was in Conriat when you refused my gracious offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“For a good reason.”"*)
  - -> `[65]` (*Player: "“I've been starting to regret that decision.”"*)
  - -> `[64]` (*Player: "“Why did you call me?”"*)

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. It has been a while, hasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Marcel Koronti: "“Let me try to remember. When was the last time we had a ..."*)

### Węzeł `[59]`
Mówca: **Marcel Koronti**
> "“Let me try to remember. When was the last time we had a chat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Marcel Koronti: "“Oh, I remember. It was when you refused to meet with me.”"*)

### Węzeł `[60]`
Mówca: **Marcel Koronti**
> "“Oh, I remember. It was when you refused to meet with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“And look at where we are now.”"*)

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“And look at where we are now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“You tell me. Where are we now?”"*)
  - -> `[76]` (*Player: "“Is that really why you called?”"*)
  - -> `[77]` (*Player: "“I've been starting to regret that decision.”"*)

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. My name is Marcel Koronti. CEO of Heart of Sordland Enterprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Marcel Koronti: "“Unfortunately, we haven't had the pleasure to chat yet.”"*)

### Węzeł `[63]`
Mówca: **Marcel Koronti**
> "“Unfortunately, we haven't had the pleasure to chat yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Marcel Koronti: "“My attempts to reach you seem to have failed every time,..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Why did you call me?”"]** — Mówca: **Player**
> "“Why did you call me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“You probably know why I am calling. It's because of the ..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I've been starting to regret that decision.”"]** — Mówca: **Player**
> "“I've been starting to regret that decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Marcel Koronti: "“That is unfortunate. My father once had a saying—may he ..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“For a good reason.”"]** — Mówca: **Player**
> "“For a good reason.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Marcel Koronti: "“Well, we are both adults here. I am sure we can let past..."*)

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“Well, we are both adults here. I am sure we can let past be past and focus on the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Marcel Koronti: "“Although this time, I am talking about the short-term fu..."*)

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Although this time, I am talking about the short-term future...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Marcel Koronti: ""Your upcoming ownership meeting, for example.”"*)

### Węzeł `[69]`
Mówca: **Marcel Koronti**
> ""Your upcoming ownership meeting, for example.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“But before we move on to that...”"*)

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“That is unfortunate. My father once had a saying—may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Marcel Koronti: "“He told me that if I don't seize an opportunity when it ..."*)

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“He told me that if I don't seize an opportunity when it is presented, the opportunity could disappear forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Marcel Koronti: "“And that's how I have chosen to live my life. Unlike you..."*)

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“And that's how I have chosen to live my life. Unlike you, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“You probably know why I am calling. It's because of the ..."*)

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“You probably know why I am calling. It's because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“But before we move on to that...”"*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“But before we move on to that...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“You tell me. Where are we now?”"]** — Mówca: **Player**
> "“You tell me. Where are we now?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Marcel Koronti: "“The real question is about where *you* are. Not me.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Is that really why you called?”"]** — Mówca: **Player**
> "“Is that really why you called?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Marcel Koronti: "“I think you know why I am calling.”"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I've been starting to regret that decision.”"]** — Mówca: **Player**
> "“I've been starting to regret that decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Marcel Koronti: "“That is unfortunate. My father once had a saying—may he ..."*)

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“The real question is about where *you* are. Not me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Marcel Koronti: "“If we worked together, *you* could be so much more. *You..."*)

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“If we worked together, *you* could be so much more. *You* could've accomplished so much more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Marcel Koronti: "“Yet you wouldn't even deign to meet with me.”"*)

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“Yet you wouldn't even deign to meet with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Marcel Koronti: "“Anyway. That's not why I called. We are both adults here..."*)

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“He told me that if I don't seize an opportunity when it is presented, the opportunity could disappear forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Marcel Koronti: "“And that's how I have chosen to live my life. Unlike you..."*)

### Węzeł `[82]`
Mówca: **Marcel Koronti**
> "“That is unfortunate. My father once had a saying—may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Marcel Koronti: "“He told me that if I don't seize an opportunity when it ..."*)

### Węzeł `[83]`
Mówca: **Marcel Koronti**
> "“And that's how I have chosen to live my life. Unlike you, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Marcel Koronti: "“You probably know why I am calling. It's because of the ..."*)

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“You probably know why I am calling. It's because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Marcel Koronti: "“But before we move on to that.”"*)

### Węzeł `[85]`
Mówca: **Marcel Koronti**
> "“Anyway. That's not why I called. We are both adults here. I am sure we can let past be past and focus on the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Marcel Koronti: "“Although this time, I am talking about the more short-te..."*)

### Węzeł `[86]`
Mówca: **Marcel Koronti**
> "“Although this time, I am talking about the more short-term future...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Marcel Koronti: "“The upcoming ownership meeting, for example.”"*)

### Węzeł `[87]`
Mówca: **Marcel Koronti**
> "“The upcoming ownership meeting, for example.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Marcel Koronti: "“But before we move on to that.”"*)

### Węzeł `[88]`
Mówca: **Marcel Koronti**
> "“But before we move on to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[89]`
Mówca: **Marcel Koronti**
> "“My attempts to reach you seem to have failed every time, as if I was being... avoided.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "“Apologies. That was certainly not my intention.”"*)
  - -> `[91]` (*Player: "“Yet here we are, talking.”"*)
  - -> `[90]` (*Player: "“Get to the point. What do you want?”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Get to the point. What do you want?”"]** — Mówca: **Player**
> "“Get to the point. What do you want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Marcel Koronti: "“I think you already know. I'm calling because of the upc..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Yet here we are, talking.”"]** — Mówca: **Player**
> "“Yet here we are, talking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Marcel Koronti: "“Indeed.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Apologies. That was certainly not my intention.”"]** — Mówca: **Player**
> "“Apologies. That was certainly not my intention.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Marcel Koronti: "“It's alright, Mr. President.”"*)

### Węzeł `[93]`
Mówca: **Marcel Koronti**
> "“I think you know why I am calling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Marcel Koronti: "“It's because of the upcoming ownership meeting.”"*)

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“It's because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Marcel Koronti: "“But before we move on to that.”"*)

### Węzeł `[95]`
Mówca: **Marcel Koronti**
> "“It's alright, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Marcel Koronti: "“After all, there is no need to dwell on our previous mis..."*)

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Although, of course, I would've liked it if we had a closer friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Marcel Koronti: "“But no. That was not my real intention for calling you t..."*)

### Węzeł `[97]`
Mówca: **Marcel Koronti**
> "“After all, there is no need to dwell on our previous missed opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Marcel Koronti: "“Although, of course, I would've liked it if we had a clo..."*)

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“But no. That was not my real intention for calling you today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: "“I'm calling you because of the upcoming ownership meeting.”"*)

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“I'm calling you because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[100]`
Mówca: **Marcel Koronti**
> "“I think you already know. I'm calling because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[101]`
Mówca: **Marcel Koronti**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Marcel Koronti: "“My father once told me—may he rest in peace.”"*)

### Węzeł `[102]`
Mówca: **Marcel Koronti**
> "“My father once told me—may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Marcel Koronti: "“He told me that if I don't seize an opportunity when it ..."*)

### Węzeł `[103]`
Mówca: **Marcel Koronti**
> "“He told me that if I don't seize an opportunity when it is presented, the opportunity could disappear forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Marcel Koronti: "“And that's how I have chosen to live my life. Unlike you..."*)

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“And that's how I have chosen to live my life. Unlike you, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Marcel Koronti: "“But past is past. And we must look at the future. Specif..."*)

### Węzeł `[105]`
Mówca: **Marcel Koronti**
> "“But past is past. And we must look at the future. Specifically, the very short-term future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Marcel Koronti: "“I'm talking about the upcoming ownership meeting.”"*)

### Węzeł `[106]`
Mówca: **Marcel Koronti**
> "“I'm talking about the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[107]`
Mówca: **Marcel Koronti**
> "“I wanted to thank you for choosing Underhall Construction to complete the H-3 highway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Marcel Koronti: "“The mayor of Conriat Kris Schar is a close friend and an..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“You're welcome.”"]** — Mówca: **Player**
> "“You're welcome.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Marcel Koronti: ""Moving on...""*)

### Węzeł `[109]`
Mówca: **Marcel Koronti**
> "“It is the number-one construction company in Sordland, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Marcel Koronti: ""Moving on...""*)

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“Perhaps not, but it certainly worked out for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Marcel Koronti: ""Moving on...""*)

### Węzeł `[111]`
Mówca: **Marcel Koronti**
> "“Your business bailout greatly benefitted certain subsidiaries of HOS that were reporting record losses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Marcel Koronti: "“We managed to avoid closing those companies, and they sa..."*)

### Węzeł `[112]`
Mówca: **Marcel Koronti**
> "“I know it has been a while, but I have to give credit where it's due. Or overdue, in this case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Marcel Koronti: "“Your business bailout greatly benefitted certain subsidi..."*)

### Węzeł `[113]`
Mówca: **Marcel Koronti**
> "“It must've been a hard choice. It is safe to say that you picked the right one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[114]`
Mówca: **Marcel Koronti**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Never forget who made that decision.”"]** — Mówca: **Player**
> "“Never forget who made that decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Marcel Koronti: "“Don't worry, Mr. President. I won't.”"*)

### Węzeł `[116]`
Mówca: **Marcel Koronti**
> "“Don't worry, Mr. President. I won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[117]`
Mówca: **Marcel Koronti**
> "“They have been extraordinarily beneficial to our quarterly performance. HOS is now operating on a much larger revenue pool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Marcel Koronti: "“You have successfully strengthened the backbone of the S..."*)

### Węzeł `[118]`
Mówca: **Marcel Koronti**
> "“You have successfully strengthened the backbone of the Sordish economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“Of course. Private corporations had to have a financial ..."*)
  - -> `[33]` (*Player: "“Needless to say, I still expect you to reinvest any surp..."*)
  - -> `[120]` (*Player: "“It was a tough decision. Don't make me regret it.”"*)

### Węzeł `[119]`
Mówca: **Marcel Koronti**
> "“You couldn't be more right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He paused for a few seconds."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“It was a tough decision. Don't make me regret it.”"]** — Mówca: **Player**
> "“It was a tough decision. Don't make me regret it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Marcel Koronti: "“I assure you, I won't.”"*)

### Węzeł `[121]`
Mówca: **Marcel Koronti**
> "“I can't help but mention your tax hike, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Marcel Koronti: "“The increased taxes have made a substantial dent in HOS'..."*)

### Węzeł `[122]`
Mówca: **Marcel Koronti**
> "“I assure you, I won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He paused for a few seconds."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“Good.”"]** — Mówca: **Player**
> "“Good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He paused for a few seconds."*)

### Węzeł `[124]`
Mówca: **Marcel Koronti**
> "“That way of thinking is correct, but you acted wrongly. This will only serve to damage our economy in the long run.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He paused for a few seconds."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Unfortunately, we had to tighten our belts wherever we could.”"]** — Mówca: **Player**
> "“Unfortunately, we had to tighten our belts wherever we could.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Marcel Koronti: "“That way of thinking is correct, but you acted wrongly. ..."*)

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> "“But I assure you, it is nothing we can't endure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Unfortunately, we had to tighten our belts wherever we c..."*)
  - -> `[123]` (*Player: "“Good.”"*)

### Węzeł `[127]`
Mówca: **Marcel Koronti**
> "“The Lotherberg Group has contingency plans if you decide to do anything rash that would disrupt their empires.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Marcel Koronti: "“You can't blame them, can you? Imagine someone trying to..."*)

### Węzeł `[128]`
Mówca: **Marcel Koronti**
> "“If you are not careful about what happens next, it might cost you dearly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Marcel Koronti: "“Nobody wants that.”"*)

### Węzeł `[129]`
Mówca: **Marcel Koronti**
> "“Nobody wants that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Marcel Koronti: "“If everyone plays their cards right, it will be all fine.”"*)

### Węzeł `[130]`
Mówca: **Marcel Koronti**
> "“If everyone plays their cards right, it will be all fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Marcel Koronti: "“Now.”"*)

### Węzeł `[131]`
Mówca: **Marcel Koronti**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Marcel Koronti: "“If everyone plays their cards right, it will be all fine.”"*)

### Węzeł `[132]`
Mówca: **Narrator**
> "The phone rang and I put the agenda down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Italic: "Pick up the phone."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "The meeting was going to be about the ownership of the Big Four, the four corporations at the heart of Sordland's ownership debate: Heart of Sordland, Bergia Steel, the Sordish State Corporation and Nedam Mining Group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Some of these companies were controlled in part or entire..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Some of these companies were controlled in part or entirely by the state. The others were mostly or completely privatized. I had the power to change that fact."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "The phone rang and I put the agenda down."*)

### Węzeł `[135]`
Mówca: **Marcel Koronti**
> "“Nobody in the entire country is supporting you as much as I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I heard him knock on wood."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Marcel Koronti: "“Since the start of your campaign, you've adamantly promo..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Marcel Koronti: "“Since the start of your campaign, you've wisely committe..."*)

### Węzeł `[139]`
Mówca: **Marcel Koronti**
> "“Now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Marcel Koronti: "“Let's talk about those cards.”"*)

### Węzeł `[140]`
Mówca: **Marcel Koronti**
> "“Let's talk about those cards.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[141]`
Mówca: **Marcel Koronti**
> "“Since the start of your campaign, you've adamantly promoted a planned economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Marcel Koronti: "“Going by that, I am worried that you will attempt to nat..."*)

### Węzeł `[142]`
Mówca: **Marcel Koronti**
> "“Going by that, I am worried that you will attempt to nationalize Sordland's largest private corporations. Nationalization as a concept goes against everything my father built and stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Marcel Koronti: "“If you do want to go down this road, I must insist on yo..."*)

### Węzeł `[143]`
Mówca: **Marcel Koronti**
> "“If you do want to go down this road, I must insist on you excluding HOS from any such plan. That is my most important request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Marcel Koronti: "“You may recall that one of the terms of our agreement wa..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Marcel Koronti: "“Think of your corporate allies as a sea of ravenous shar..."*)

### Węzeł `[147]`
Mówca: **Marcel Koronti**
> "“You may recall that one of the terms of our agreement was that I may ask you for one favor. Well, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_NoNationalizeHOS = true"*)

### Węzeł `[148]`
Mówca: **Marcel Koronti**
> "“Think of your corporate allies as a sea of ravenous sharks surrounding you. We could co-exist peacefully, or...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Marcel Koronti: "“Ah, let's not even imagine that scenario.”"*)

### Węzeł `[149]`
Mówca: **Marcel Koronti**
> "“Ah, let's not even imagine that scenario.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“We don't need to be enemies.”"*)
  - -> `[151]` (*Player: "“Imagine this scenario. You will either help me out, or I..."*)
  - -> `[153]` (*Player: "“Don't get your knickers in a twist. I was planning on le..."*)
  - -> `[152]` (*Player: "“I don't give in to threats. Your time is over, Koronti.”"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“We don't need to be enemies.”"]** — Mówca: **Player**
> "“We don't need to be enemies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Marcel Koronti), `[147]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Marcel Koronti: "“No. We don't.”"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Imagine this scenario. You will either help me out, or I will eat your little company for dinner. Understood?”"]** — Mówca: **Player**
> "“Imagine this scenario. You will either help me out, or I will eat your little company for dinner. Understood?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_OwnershipDeal = true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I don't give in to threats. Your time is over, Koronti.”"]** — Mówca: **Player**
> "“I don't give in to threats. Your time is over, Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_Threatened = true"*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Don't get your knickers in a twist. I was planning on leaving HOS alone anyway.”"]** — Mówca: **Player**
> "“Don't get your knickers in a twist. I was planning on leaving HOS alone anyway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Marcel Koronti), `[147]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Marcel Koronti: "“That is excellent to hear!”"*)

### Węzeł `[154]`
Mówca: **Marcel Koronti**
> "“That is excellent to hear!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Marcel Koronti: "“I knew we would be on the same page!”"*)

### Węzeł `[155]`
Mówca: **Marcel Koronti**
> "“What an unfortunate turn of events. What a tragedy!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "He laughed mockingly."*)

### Węzeł `[156]`
Mówca: **Marcel Koronti**
> "“When I'm done with you, getting re-elected will be the least of your worries, Mr. *President*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "The line dropped dead."*)

### Węzeł `[157]`
Mówca: **Marcel Koronti**
> "“Listen to me. Do you think you have power because you're sitting in the fancy chair? Do you think you are Soll?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Marcel Koronti: "“You are nothing!”"*)

### Węzeł `[158]`
Mówca: **Marcel Koronti**
> "“If you want war, you will have your war. But know this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Marcel Koronti: "“I will destroy you and everything you hold dear.”"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "He laughed mockingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Marcel Koronti: "“Listen to me. Do you think you have power because you're..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_MarcelCalls = true"*)

### Węzeł `[161]`
Mówca: **Marcel Koronti**
> "“I knew we would be on the same page!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Marcel Koronti: "“I am raising my glass to you right now, Mr. President.”"*)

### Węzeł `[162]`
Mówca: **Marcel Koronti**
> "“I am raising my glass to you right now, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Marcel Koronti: "“There is actually one more thing I would like to discuss.”"*)

### Węzeł `[163]`
Mówca: **Marcel Koronti**
> "“There is actually one more thing I would like to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "Jump to: [BergiaSteelTalk]"*)

### Węzeł `[164]`
Mówca: **Marcel Koronti**
> "“As long as you do as I say and exclude my *little* company, I will gladly help you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Marcel Koronti: "“I always keep my end of the bargain, Mr. President. Don'..."*)

### Węzeł `[165]`
Mówca: **Marcel Koronti**
> "“I always keep my end of the bargain, Mr. President. Don't forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Marcel Koronti: "“You had better keep yours as well.”"*)

### Węzeł `[166]`
Mówca: **Marcel Koronti**
> "“You had better keep yours as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "He cleared his throat."*)

### Węzeł `[167]`
Mówca: **Marcel Koronti**
> "“Before we end the call, there is actually one more thing I would like to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "Jump to: [BergiaSteelTalk]"*)

### Węzeł `[168]`
Mówca: **Marcel Koronti**
> "“No. We don't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Marcel Koronti: "“As long as we both understand what entails *not* being e..."*)

### Węzeł `[169]`
Mówca: **Marcel Koronti**
> "“As long as we both understand what entails *not* being enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Marcel Koronti: "“I always keep my end of the bargain, Mr. President. Don'..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Marcel Koronti: "“Before we end the call, there is actually one more thing..."*)

### Węzeł `[171]`
Mówca: **Marcel Koronti**
> "“Since the start of your campaign, you've wisely committed to a market economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Marcel Koronti: "“Judging by that, I am sure you are looking into privatiz..."*)

### Węzeł `[172]`
Mówca: **Marcel Koronti**
> "“Judging by that, I am sure you are looking into privatizing some of the companies that are currently state owned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Marcel Koronti: "“I believe, therefore, that privatizing both Nedam Mining..."*)

### Węzeł `[173]`
Mówca: **Marcel Koronti**
> "“I believe, therefore, that privatizing both Nedam Mining Group and the Sordish State Corporation would be in both of our interests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Marcel Koronti: "“After all, I am considering buying stocks in both compan..."*)

### Węzeł `[174]`
Mówca: **Marcel Koronti**
> "“You are nothing!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Marcel Koronti: "“If you want war, you will have your war. But know this.”"*)

### Węzeł `[175]`
Mówca: **Marcel Koronti**
> "“I will destroy you and everything you hold dear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Marcel Koronti: "“Slowly.”"*)

### Węzeł `[176]`
Mówca: **Marcel Koronti**
> "“Slowly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Marcel Koronti: "“Very slowly.”"*)

### Węzeł `[177]`
Mówca: **Marcel Koronti**
> "“Very slowly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Marcel Koronti: "“You think I don't know?”"*)

### Węzeł `[178]`
Mówca: **Marcel Koronti**
> "“After all, I am considering buying stocks in both companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“Privatizing both might be too much. I will see what I ca..."*)
  - -> `[179]` (*Player: "“That's exactly what I was thinking.”"*)
  - -> `[188]` (*Player: "“I am not thinking about privatization.”"*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“That's exactly what I was thinking.”"]** — Mówca: **Player**
> "“That's exactly what I was thinking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Marcel Koronti: "“Excellent! Great minds do think alike. Thank you for you..."*)

### Węzeł `[180]`
Mówca: **Marcel Koronti**
> "“You think I don't know?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: "“Screw you.”"*)
  - -> `[183]` (*Player: "“Don't know what?”"*)

### Węzeł `[181]`
Mówca: **Marcel Koronti**
> "“Be careful around the people you trust.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Marcel Koronti: "“When I'm done with you, getting re-elected will be the l..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "“Screw you.”"]** — Mówca: **Player**
> "“Screw you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He laughed again."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Don't know what?”"]** — Mówca: **Player**
> "“Don't know what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He laughed again."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "He laughed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Marcel Koronti: "“Be careful around the people you trust.”"*)

### Węzeł `[185]`
Mówca: **Marcel Koronti**
> "“Excellent! Great minds do think alike. Thank you for your support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Marcel Koronti: "“Before we end the call, there is actually one more thing..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Privatizing both might be too much. I will see what I can do.”"]** — Mówca: **Player**
> "“Privatizing both might be too much. I will see what I can do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Marcel Koronti: "“Think about it this way. It is another step forward in s..."*)

### Węzeł `[187]`
Mówca: **Marcel Koronti**
> "“Think about it this way. It is another step forward in strengthening our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Marcel Koronti: "“Please at least think about it.”"*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I am not thinking about privatization.”"]** — Mówca: **Player**
> "“I am not thinking about privatization.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Marcel Koronti: "“What do you mean? You will leave everything the same, th..."*)

### Węzeł `[189]`
Mówca: **Marcel Koronti**
> "“Please at least think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "He cleared his throat."*)

### Węzeł `[190]`
Mówca: **Marcel Koronti**
> "“What do you mean? You will leave everything the same, then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Marcel Koronti: "“Don't tell me you are thinking about nationalization?”"*)

### Węzeł `[191]`
Mówca: **Marcel Koronti**
> "“Don't tell me you are thinking about nationalization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“Yes, I am.”"*)
  - -> `[194]` (*Player: "“I'm thinking about a more balanced approach.”"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“Yes, I am.”"]** — Mówca: **Player**
> "“Yes, I am.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Marcel Koronti: "“Mr. President. Nationalization as a concept goes against..."*)

### Węzeł `[193]`
Mówca: **Marcel Koronti**
> "“Mr. President. Nationalization as a concept goes against everything my father built and stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Marcel Koronti: "“If you do want to go down this road, I must insist on yo..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "“I'm thinking about a more balanced approach.”"]** — Mówca: **Player**
> "“I'm thinking about a more balanced approach.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Marcel Koronti: "“Balance is important, Mr. President, but the concept of ..."*)

### Węzeł `[195]`
Mówca: **Marcel Koronti**
> "“Balance is important, Mr. President, but the concept of nationalization goes against everything my father built and stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Marcel Koronti: "“If you do want to go down this road, I must insist on yo..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BergiaSteelTalk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader = true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BergiaSteelTalk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BergiaSteelTalk"*)

### Węzeł `[198]`
Mówca: **Marcel Koronti**
> "“Before we end the call, there is actually one more thing I would like to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "Jump to: [BergiaSteelTalk]"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BergiaSteelTalk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BergiaSteelTalk"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "Jump to: [BergiaSteelTalk]"*)

### Węzeł `[201]`
Mówca: **Marcel Koronti**
> "“I will be blunt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Marcel Koronti: "“Mr. Tusk is unfit to be the spokesperson for the Lotherb..."*)

### Węzeł `[202]`
Mówca: **Marcel Koronti**
> "“Mr. Tusk is unfit to be the spokesperson for the Lotherberg Group. His archaic thinking has only preserved a status quo that benefits himself and precious few others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Marcel Koronti: "“It is high time something changed.""*)

### Węzeł `[203]`
Mówca: **Marcel Koronti**
> "“It is high time something changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: "“Who do you have in mind to replace him?”"*)
  - -> `[204]` (*Player: "“I see where this is going.”"*)
  - -> `[206]` (*Player: "“Stop. Before you say anything more, I won't meddle in Ol..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "“I see where this is going.”"]** — Mówca: **Player**
> "“I see where this is going.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Marcel Koronti: "“I want him gone.”"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“Who do you have in mind to replace him?”"]** — Mówca: **Player**
> "“Who do you have in mind to replace him?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Marcel Koronti: "“Who do you think?""*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "“Stop. Before you say anything more, I won't meddle in Oligarchs' affairs.”"]** — Mówca: **Player**
> "“Stop. Before you say anything more, I won't meddle in Oligarchs' affairs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && ..."*)

### Węzeł `[207]`
Mówca: **Marcel Koronti**
> "“Ah, it was worth a shot. But I respect your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Marcel Koronti: "“Very well. I won't push further.”"*)

### Węzeł `[208]`
Mówca: **Marcel Koronti**
> "“Very well. I won't push further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_MarcelCall_NotListened = true"*)

### Węzeł `[209]`
Mówca: **Marcel Koronti**
> "“I want him gone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Marcel Koronti: "“It is time the group had a proper leader.""*)

### Węzeł `[210]`
Mówca: **Marcel Koronti**
> "“Who do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Marcel Koronti: "“Me, of course!”"*)

### Węzeł `[211]`
Mówca: **Marcel Koronti**
> "“Me, of course!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Marcel Koronti: "“Here is what I propose. A win-win situation.”"*)

### Węzeł `[212]`
Mówca: **Marcel Koronti**
> "“I have taken up enough of your time today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Marcel Koronti: "“This has been a productive call.”"*)

### Węzeł `[213]`
Mówca: **Marcel Koronti**
> "“Here is what I propose. A win-win situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[214]`
Mówca: **Marcel Koronti**
> "“It is time the group had a proper leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Marcel Koronti: "“Me.”"*)

### Węzeł `[215]`
Mówca: **Marcel Koronti**
> "“Me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Marcel Koronti: "“Here is what I propose. A win-win situation.”"*)

### Węzeł `[216]`
Mówca: **Marcel Koronti**
> "“If you could use your powers to make Bergia Steel, Tusk's main company, state-owned, he would lose considerable influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Marcel Koronti: "“Which means I could take over.”"*)

### Węzeł `[217]`
Mówca: **Marcel Koronti**
> "“Which means I could take over.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Ma..."*)

### Węzeł `[218]`
Mówca: **Marcel Koronti**
> "“If I take over with your help, I will be forever indebted to you and support you in all your goals, be they re-election or something more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Marcel Koronti: "“How does that sound?”"*)

### Węzeł `[219]`
Mówca: **Marcel Koronti**
> "“How does that sound?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“That sounds profitable to me. Deal.”"*)
  - -> `[220]` (*Player: "“I'll have to think about it.”"*)
  - -> `[222]` (*Player: "“I won't make myself a target by picking a side.”"*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "“I'll have to think about it.”"]** — Mówca: **Player**
> "“I'll have to think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Marcel Koronti: "“Just think about it. That's all I am asking.”"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“That sounds profitable to me. Deal.”"]** — Mówca: **Player**
> "“That sounds profitable to me. Deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover = true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“I won't make myself a target by picking a side.”"]** — Mówca: **Player**
> "“I won't make myself a target by picking a side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Marcel Koronti: "“You and me. We would be unstoppable. We could eliminate ..."*)

### Węzeł `[223]`
Mówca: **Marcel Koronti**
> "“Perfect!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Marcel Koronti: "“Well then.”"*)

### Węzeł `[224]`
Mówca: **Marcel Koronti**
> "“Just think about it. That's all I am asking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Marcel Koronti: "“Well then.”"*)

### Węzeł `[225]`
Mówca: **Marcel Koronti**
> "“You and me. We would be unstoppable. We could eliminate everyone who's after us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Marcel Koronti: "“Just think about it. That's all I am asking.”"*)

### Węzeł `[226]`
Mówca: **Marcel Koronti**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Marcel Koronti: "“I have taken up enough of your time today.”"*)

### Węzeł `[227]`
Mówca: **Marcel Koronti**
> "“This has been a productive call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Marcel Koronti: "“Thank you for your time, Mr. President.”"*)

### Węzeł `[228]`
Mówca: **Marcel Koronti**
> "“Thank you for your time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: "“Thanks Marcel. Talk to you later.”"*)
  - -> `[230]` (*Player: "“Goodbye, Mr. Koronti.”"*)
  - -> `[231]` (*Player_Italic: "Hang up."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Thanks Marcel. Talk to you later.”"]** — Mówca: **Player**
> "“Thanks Marcel. Talk to you later.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "After a couple of minutes, I went back to reviewing the a..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: "“Goodbye, Mr. Koronti.”"]** — Mówca: **Player**
> "“Goodbye, Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "After a couple of minutes, I went back to reviewing the a..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "After a couple of minutes, I went back to reviewing the a..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "After a couple of minutes, I went back to reviewing the agenda."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_MarcelCalls = true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_MarcelCalls = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_MarcelCalls"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0 && BaseGame.Reform_Emergency..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_A_Marcel_OwnershipDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Marcel Koronti: "“As long as you do as I say and exclude my *little* compa..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_A_Marcel_Threatened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_A_Marcel_Threatened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_MarcelThreatened = true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Marcel Koronti: "“If you could use your powers to make Bergia Steel, Tusk'..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Marcel Koronti: "“If you promised me a majority of shares from the privati..."*)

### Węzeł `[239]`
Mówca: **Marcel Koronti**
> "“If you promised me a majority of shares from the privatization, he would lose considerable power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Marcel Koronti: "“Which means I could take over.”"*)

### Węzeł `[240]`
Mówca: **Marcel Koronti**
> ""On another note...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[241]`
Mówca: **Marcel Koronti**
> ""Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_BusinessBailout == true"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "“You've outlived your usefulness to me. You are done for, Koronti.”"]** — Mówca: **Player**
> "“You've outlived your usefulness to me. You are done for, Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_Threatened = true"*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "“I understand. I want our partnership to continue uninterrupted.”"]** — Mówca: **Player**
> "“I understand. I want our partnership to continue uninterrupted.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Marcel Koronti: "“As do I.”"*)

### Węzeł `[244]`
Mówca: **Marcel Koronti**
> "“As do I.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Marcel Koronti: "“I always keep my end of the bargain, Mr. President. Don'..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_NoNationalizeHOS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: "“I understand. I want our partnership to continue uninter..."*)
  - -> `[150]` (*Player: "“We don't need to be enemies.”"*)
  - -> `[153]` (*Player: "“Don't get your knickers in a twist. I was planning on le..."*)
  - -> `[242]` (*Player: "“You've outlived your usefulness to me. You are done for,..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && ..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false &..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Marcel Koronti: "“You may recall that one of the terms of our agreement wa..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Marcel Koronti: "“Ah, it was worth a shot. But I respect your decision.”"*)

### Węzeł `[249]`
Mówca: **Marcel Koronti**
> "“You may recall that one of the terms of our agreement was that I may ask you for one favor. Well, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Marcel Koronti: "“I want him gone. And you're going to make it happen.""*)

### Węzeł `[250]`
Mówca: **Marcel Koronti**
> "“I want him gone. And you're going to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Marcel Koronti: "“Here is what I propose. A win-win situation.”"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Turn07_MarcelFavor_PrivateTakeover == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Ma..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Turn07_MarcelFavor_PrivateTakeover == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Marcel Koronti: "“You may recall that one of the terms of our agreement wa..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Turn07_MarcelFavor_PrivateTakeover == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Marcel Koronti: "“If I take over with your help, I will be forever indebte..."*)

### Węzeł `[254]`
Mówca: **Marcel Koronti**
> "“You may recall that one of the terms of our agreement was that I may ask you for one favor. Well, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Marcel Koronti: "“Do you accept?”"*)

### Węzeł `[255]`
Mówca: **Marcel Koronti**
> "“Do you accept?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: ""I'll have to think about it.""*)
  - -> `[257]` (*Player: ""Of course. A deal's a deal.""*)
  - -> `[258]` (*Player: ""You're asking too much of me.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I'll have to think about it.""]** — Mówca: **Player**
> ""I'll have to think about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Marcel Koronti: ""Think about all the free help you've gotten from me -- a..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Of course. A deal's a deal.""]** — Mówca: **Player**
> ""Of course. A deal's a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Marcel Koronti: ""Korontis always keep their word, my father said. He woul..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""You're asking too much of me.""]** — Mówca: **Player**
> ""You're asking too much of me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Marcel Koronti: ""Think about all the free help you've gotten from me -- a..."*)

### Węzeł `[259]`
Mówca: **Marcel Koronti**
> ""Think about all the free help you've gotten from me -- and the many scandals you might have to cover up on the way to re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Marcel Koronti: "“Well then.”"*)

### Węzeł `[260]`
Mówca: **Marcel Koronti**
> ""Korontis always keep their word, my father said. He would have liked you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover = true"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Marcel Koronti: "“I wanted to thank you for choosing Underhall Constructio..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Marcel Koronti: "“I wanted to thank you for choosing Underhall Constructio..."*)

### Węzeł `[264]`
Mówca: **Marcel Koronti**
> "“I wanted to thank you for choosing Underhall Construction to complete the L-1 railway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Marcel Koronti: "“The mayor of Conriat Kris Schar is a close friend and an..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_MarcelThreatened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_MarcelThreatened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Marcel Koronti: "“What an unfortunate turn of events. What a tragedy!”"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Marcel Koronti: "“I will be blunt.”"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegativ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositive = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I was in my office, looking through the agenda for the up..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegative = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I was in my office, looking through the agenda for the up..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Vesord_ProtestAgainstEmerge..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Vesord_ProtestAgainstEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Vesord_ProtestAgainstEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Erzaren_LocalsProtestJointO..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossin..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Erzaren_LocalsProtestJointOperation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Erzaren_LocalsProtestJointOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_ProtestAgainstJointOperati..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_WehlenBorderClosed = true;"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_FPnT_Immigration_Tight == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossin..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_FPnT_Immigration_Tight == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossin..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_EmergencyBeingIgnor..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_EmergencyBeingIgnored = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_EmergencyBeingIgnored"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_USPShowSupportEmerg..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_USPShowSupportEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_USPShowSupportEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= 0 && BaseGame.Reform_EmergencyDecree_SuspendedProtests == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0 && BaseGame.Reform_Emergency..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= 0 && BaseGame.Reform_Emergen..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= 0 && BaseGame.Reform_EmergencyDecree_SuspendedProtests == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_ProtestAgainstRayne = true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= 0 && BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//Continue"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_ProtestAgainstRayne = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_ProtestAgainstRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "//Continue"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_LT_ProtestAgainstJointOperation = true; BaseGameSupport.News_Turn07_G_WehlenJointOperation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_ProtestAgainstJointOperation"] = true;
Variable["BaseGameSupport.News_Turn07_G_WehlenJointOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_WehlenBorderClosed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_WehlenBorderClosed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Marcel Koronti: "“I have taken up enough of your time today.”"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Marcel Koronti: "“Perfect!”"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_MarcelCall_NotListened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Marcel Koronti: "“I have taken up enough of your time today.”"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true )"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositiv..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I was in my office, looking through the agenda for the up..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGame.Decision_Turn06_Lobbying_Bribe2 == true || BaseGame.Decision_Turn06_Lobbying_Bribe3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGa..."*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Lobbying_Bribe == true || Base..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGame.Decision_Turn06_Lobbying_Bribe2 == true || BaseGame.Decision_Turn06_Lobbying_Bribe3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Lobbying_Bribe"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe2"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "The meeting was going to be about the ownership of the Bi..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGame.Decision_Turn06_Lobbying_Bribe2 == true || BaseGame.Decision_Turn06_Lobbying_Bribe3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Lobbying_Bribe"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe2"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The meeting was going to be about the ownership of the Bi..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "The meeting was going to be about the ownership of the Big Four, the four corporations at the heart of Sordland's ownership debate: Heart of Sordland, Bergia Steel, the Sordish State Corporation and Nedam Mining Group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Some of these companies were controlled in part or entire..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Uziren", "City_BludishRefugees");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_BludishRefugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "// Filler"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true || BaseGame.Wehl..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  or  Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  or  Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_FPnT_Immigration_Tight == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "// Filler"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_FPnT_Immigration_Tight == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Uziren", "City_BludishRefug..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_FPnT_Immigration_Tight == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Uziren", "City_BludishRefug..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_FPnT_Immigration_Tight == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Uziren", "City_BludishRefug..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Uziren", "City_BludishRefugees");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_BludishRefugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Ribel", "City_BludishRefuge..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Ribel", "City_BludishRefugees");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Ribel","City_BludishRefugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "// Filler"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Filler`
- **Efekt skryptowy (`userScript`):** `-- Filler;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame..."*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGa..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true  or  (Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCallF..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true  or  (Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsConde..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCallForAmendment = true;
BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction = true;
BaseGameSupport.News_Turn07_LT_BludLeadersCallForAmendment = true;
BaseGameSupport.News_Turn07_R_BludLeadersCallForAmendment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCallForAmendment"] = true;
Variable["BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction"] = true;
Variable["BaseGameSupport.News_Turn07_LT_BludLeadersCallForAmendment"] = true;
Variable["BaseGameSupport.News_Turn07_R_BludLeadersCallForAmendment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCondemnPresident = true;
BaseGameSupport.News_Turn07_R_BludsCondemnPresident = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCondemnPresident"] = true;
Variable["BaseGameSupport.News_Turn07_R_BludsCondemnPresident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCo..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true && ..."*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true &..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_Conflicte..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ConflictedAmendment_BludsPullOut = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ConflictedAmendment_BludsPullOut"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCo..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtDelaysCase = true;
BaseGameSupport.News_Turn07_HP_SupremeCourtDelaysCase = true;
BaseGameSupport.News_Turn07_R_SupremeCourtDelaysCase = true;
BaseGameSupport.News_Turn07_LT_ProtestAgainstCourtDelay = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtDelaysCase"] = true;
Variable["BaseGameSupport.News_Turn07_HP_SupremeCourtDelaysCase"] = true;
Variable["BaseGameSupport.News_Turn07_R_SupremeCourtDelaysCase"] = true;
Variable["BaseGameSupport.News_Turn07_LT_ProtestAgainstCourtDelay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtChargesBron = true;
BaseGameSupport.News_Turn07_HP_SupremeCourtChargesBron = true;
BaseGameSupport.News_Turn07_R_SupremeCourtChargesBron = true;
BaseGameSupport.News_Turn07_LT_ProtestAgainstSollistOutcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtChargesBron"] = true;
Variable["BaseGameSupport.News_Turn07_HP_SupremeCourtChargesBron"] = true;
Variable["BaseGameSupport.News_Turn07_R_SupremeCourtChargesBron"] = true;
Variable["BaseGameSupport.News_Turn07_LT_ProtestAgainstSollistOutcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction = true;
BaseGameSupport.News_Turn07_LT_NFPCondemns_ProBlud = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction"] = true;
Variable["BaseGameSupport.News_Turn07_LT_NFPCondemns_ProBlud"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCo..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBC..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCo..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Lachaven_IncreasedSupportFo..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true && ..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Lachaven_IncreasedSupportForBludishRight = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Lachaven_IncreasedSupportForBludishRight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true && ..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt = t..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true ..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//Continue`
- **Efekt skryptowy (`userScript`):** `--Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true || BaseGame.Decision_Turn06_GasomSaleResult_Low == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true ..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == tru..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true || BaseGame.Decision_Turn06_GasomSaleResult_Low == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomSaleResult_VeryLow"] == true  or  Variable["BaseGame.Decision_Turn06_GasomSaleResult_Low"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_E_Gasom_LowReturnsForState = ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true || BaseGame.Decision_Turn06_GasomSaleResult_Low == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomSaleResult_VeryLow"] == true  or  Variable["BaseGame.Decision_Turn06_GasomSaleResult_Low"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration =..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_E_Gasom_LowReturnsForState = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_E_Gasom_LowReturnsForState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration =..."*)
