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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 37

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGameSupport.News_Turn07_LT_ProtestAgainstSollistOutcome`
- `BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[233]` (Marcel Koronti): `Variable["GameCondition.Turn07_A_MarcelCalls"] = true;`
- Węzeł `[234]` (Marcel Koronti): `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] = true;`
- Węzeł `[235]` (Marcel Koronti): `Variable["BaseGame.Turn07_A_Marcel_Threatened"] = true;`
- Węzeł `[245]` (Marcel Koronti): `Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] = true;`
- Węzeł `[265]` (Marcel Koronti): `Variable["BaseGameSupport.Journal_Turn07_MarcelThreatened"] = true;`
- Węzeł `[266]` (Marcel Koronti): `Variable["BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader"] = true;`
- Węzeł `[270]` (Marcel Koronti): `Variable["BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositive"] = true;`
- Węzeł `[271]` (Marcel Koronti): `Variable["BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegative"] = true;`
- *...oraz 29 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Marcel Koronti)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[5]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“I'm sure you'll agree that the support I and my network have given your administration has been nothing but beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Marcel Koronti**
> "“Mr. Rayne. I used my connections to cancel the publishing of 73 negative articles and personally directed the release of more than 41 positive reports, be they on the television, radio or newsprint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[8]`
Mówca: **Marcel Koronti**
> "“Half of the non-state media in the country has been sharing positive news about you and downplaying negative events.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[17]`
  - -> `[16]`

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“I'm glad you agree. Your public opinion could have nosedived were it not for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“Out of goodwill, I will share a key piece of information.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I don't see why we should be enemies.”"]** — Mówca: **Player**
> "“I don't see why we should be enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“You can't blame them, can you? Imagine someone trying to take your authority and personal wealth away without your consent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[11]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“We will only ask for a reasonable share. Nothing out of the ordinary.”"]** — Mówca: **Player**
> "“We will only ask for a reasonable share. Nothing out of the ordinary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“They'll have to deal with whatever I decide. It is a tough world.”"]** — Mówca: **Player**
> "“They'll have to deal with whatever I decide. It is a tough world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“I can't help but mention the tax breaks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I haven't been seeing any benefits yet.”"]** — Mówca: **Player**
> "“I haven't been seeing any benefits yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""There's always more you could be doing for us.”"]** — Mówca: **Player**
> ""There's always more you could be doing for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
Mówca: **Marcel Koronti**
> "“Please don't take what I'm about to say as a threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[19]`
Mówca: **Marcel Koronti**
> "“That is good to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Our partnership has been successful so far.”"]** — Mówca: **Player**
> "“Our partnership has been successful so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[21]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[23]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[24]`
Mówca: **Marcel Koronti**
> "“The increased taxes have made a substantial dent in HOS' net profits. This has hurt the backbone of the Sordish economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“Mr. Rayne. We essentially acquired Lachaven Times and have been coordinating media publishing across the three largest broadcasting organisations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[26]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[28]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[29]`
Mówca: **Narrator**
> "I heard him knock on wood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“I'm glad to hear that. It was a widely contested decision.”"]** — Mówca: **Player**
> "“I'm glad to hear that. It was a widely contested decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Ensuring employment was our primary target.”"]** — Mówca: **Player**
> "“Ensuring employment was our primary target.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Of course. Private corporations had to have a financial leg up to boost investments.”"]** — Mówca: **Player**
> "“Of course. Private corporations had to have a financial leg up to boost investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Needless to say, I still expect you to reinvest any surplus back into the economy to create more jobs.”"]** — Mówca: **Player**
> "“Needless to say, I still expect you to reinvest any surplus back into the economy to create more jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Underhall has been a pleasure to work with. They made our opening a success.""]** — Mówca: **Player**
> "“Underhall has been a pleasure to work with. They made our opening a success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“Increasing our investments inside Sordland is a key topic in our board discussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“The decision wasn't necessarily made to benefit you, Marcel.”"]** — Mówca: **Player**
> "“The decision wasn't necessarily made to benefit you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[37]`
Mówca: **Marcel Koronti**
> "“We managed to avoid closing those companies, and they satisfied the Board of HOS with a high profit report in return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`
  - -> `[115]`

### Węzeł `[38]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_BusinessBailout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_BusinessBailout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_BusinessBailout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[40]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_BusinessBailout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_BusinessBailout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[41]`
Mówca: **Narrator**
> "He paused for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[42]`
Mówca: **Marcel Koronti**
> "“The mayor of Conriat Kris Schar is a close friend and an investor in Underhall, and your contracting of the firm has tripled his returns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[36]`
  - -> `[108]`

### Węzeł `[43]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_TalkedToMarcel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_TalkedToMarcel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[45]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_Admin_TalkedToMarcel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[46]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_Admin_Meeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[49]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[51]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[52]`
Mówca: **Narrator**
> "I was in my office, looking through the agenda for the upcoming meeting at the Ministry of Economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Italic**
> "I picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[54]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. I'm sorry to disturb you before such an important meeting. But I thought now would be a good time to talk about our... arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[55]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. It has been a while, hasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Marcel Koronti**
> "“Let me try to remember. When was the last time we had a chat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Marcel Koronti**
> "“Oh, I remember. It was in Conriat when you refused my gracious offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[64]`

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. It has been a while, hasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Marcel Koronti**
> "“Let me try to remember. When was the last time we had a chat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Marcel Koronti**
> "“Oh, I remember. It was when you refused to meet with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“And look at where we are now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`
  - -> `[77]`

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. President. My name is Marcel Koronti. CEO of Heart of Sordland Enterprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Marcel Koronti**
> "“Unfortunately, we haven't had the pleasure to chat yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Why did you call me?”"]** — Mówca: **Player**
> "“Why did you call me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I've been starting to regret that decision.”"]** — Mówca: **Player**
> "“I've been starting to regret that decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“For a good reason.”"]** — Mówca: **Player**
> "“For a good reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“Well, we are both adults here. I am sure we can let past be past and focus on the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Although this time, I am talking about the short-term future...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Marcel Koronti**
> ""Your upcoming ownership meeting, for example.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“That is unfortunate. My father once had a saying—may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“He told me that if I don't seize an opportunity when it is presented, the opportunity could disappear forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“And that's how I have chosen to live my life. Unlike you, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“You probably know why I am calling. It's because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“But before we move on to that...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“You tell me. Where are we now?”"]** — Mówca: **Player**
> "“You tell me. Where are we now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Is that really why you called?”"]** — Mówca: **Player**
> "“Is that really why you called?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I've been starting to regret that decision.”"]** — Mówca: **Player**
> "“I've been starting to regret that decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“The real question is about where *you* are. Not me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“If we worked together, *you* could be so much more. *You* could've accomplished so much more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“Yet you wouldn't even deign to meet with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“He told me that if I don't seize an opportunity when it is presented, the opportunity could disappear forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Marcel Koronti**
> "“That is unfortunate. My father once had a saying—may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Marcel Koronti**
> "“And that's how I have chosen to live my life. Unlike you, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“You probably know why I am calling. It's because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Marcel Koronti**
> "“Anyway. That's not why I called. We are both adults here. I am sure we can let past be past and focus on the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Marcel Koronti**
> "“Although this time, I am talking about the more short-term future...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Marcel Koronti**
> "“The upcoming ownership meeting, for example.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Marcel Koronti**
> "“But before we move on to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[89]`
Mówca: **Marcel Koronti**
> "“My attempts to reach you seem to have failed every time, as if I was being... avoided.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[90]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Get to the point. What do you want?”"]** — Mówca: **Player**
> "“Get to the point. What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Yet here we are, talking.”"]** — Mówca: **Player**
> "“Yet here we are, talking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Apologies. That was certainly not my intention.”"]** — Mówca: **Player**
> "“Apologies. That was certainly not my intention.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Marcel Koronti**
> "“I think you know why I am calling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“It's because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[95]`
Mówca: **Marcel Koronti**
> "“It's alright, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Although, of course, I would've liked it if we had a closer friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Marcel Koronti**
> "“After all, there is no need to dwell on our previous missed opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“But no. That was not my real intention for calling you today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“I'm calling you because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[100]`
Mówca: **Marcel Koronti**
> "“I think you already know. I'm calling because of the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[101]`
Mówca: **Marcel Koronti**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Marcel Koronti**
> "“My father once told me—may he rest in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Marcel Koronti**
> "“He told me that if I don't seize an opportunity when it is presented, the opportunity could disappear forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“And that's how I have chosen to live my life. Unlike you, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Marcel Koronti**
> "“But past is past. And we must look at the future. Specifically, the very short-term future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Marcel Koronti**
> "“I'm talking about the upcoming ownership meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[107]`
Mówca: **Marcel Koronti**
> "“I wanted to thank you for choosing Underhall Construction to complete the H-3 highway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“You're welcome.”"]** — Mówca: **Player**
> "“You're welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[109]`
Mówca: **Marcel Koronti**
> "“It is the number-one construction company in Sordland, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“Perhaps not, but it certainly worked out for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[111]`
Mówca: **Marcel Koronti**
> "“Your business bailout greatly benefitted certain subsidiaries of HOS that were reporting record losses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[112]`
Mówca: **Marcel Koronti**
> "“I know it has been a while, but I have to give credit where it's due. Or overdue, in this case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Marcel Koronti**
> "“It must've been a hard choice. It is safe to say that you picked the right one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[114]`
Mówca: **Marcel Koronti**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Never forget who made that decision.”"]** — Mówca: **Player**
> "“Never forget who made that decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Marcel Koronti**
> "“Don't worry, Mr. President. I won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[117]`
Mówca: **Marcel Koronti**
> "“They have been extraordinarily beneficial to our quarterly performance. HOS is now operating on a much larger revenue pool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Marcel Koronti**
> "“You have successfully strengthened the backbone of the Sordish economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Marcel Koronti**
> "“You couldn't be more right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“It was a tough decision. Don't make me regret it.”"]** — Mówca: **Player**
> "“It was a tough decision. Don't make me regret it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Marcel Koronti**
> "“I can't help but mention your tax hike, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[122]`
Mówca: **Marcel Koronti**
> "“I assure you, I won't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“Good.”"]** — Mówca: **Player**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[124]`
Mówca: **Marcel Koronti**
> "“That way of thinking is correct, but you acted wrongly. This will only serve to damage our economy in the long run.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Unfortunately, we had to tighten our belts wherever we could.”"]** — Mówca: **Player**
> "“Unfortunately, we had to tighten our belts wherever we could.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> "“But I assure you, it is nothing we can't endure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[123]`

### Węzeł `[127]`
Mówca: **Marcel Koronti**
> "“The Lotherberg Group has contingency plans if you decide to do anything rash that would disrupt their empires.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[128]`
Mówca: **Marcel Koronti**
> "“If you are not careful about what happens next, it might cost you dearly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Marcel Koronti**
> "“Nobody wants that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Marcel Koronti**
> "“If everyone plays their cards right, it will be all fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[131]`
Mówca: **Marcel Koronti**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[132]`
Mówca: **Narrator**
> "The phone rang and I put the agenda down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[133]`
Mówca: **Narrator**
> "The meeting was going to be about the ownership of the Big Four, the four corporations at the heart of Sordland's ownership debate: Heart of Sordland, Bergia Steel, the Sordish State Corporation and Nedam Mining Group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Some of these companies were controlled in part or entirely by the state. The others were mostly or completely privatized. I had the power to change that fact."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[135]`
Mówca: **Marcel Koronti**
> "“Nobody in the entire country is supporting you as much as I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[136]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[139]`
Mówca: **Marcel Koronti**
> "“Now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Marcel Koronti**
> "“Let's talk about those cards.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[141]`
Mówca: **Marcel Koronti**
> "“Since the start of your campaign, you've adamantly promoted a planned economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Marcel Koronti**
> "“Going by that, I am worried that you will attempt to nationalize Sordland's largest private corporations. Nationalization as a concept goes against everything my father built and stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Marcel Koronti**
> "“If you do want to go down this road, I must insist on you excluding HOS from any such plan. That is my most important request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Marcel Koronti**
> "“You may recall that one of the terms of our agreement was that I may ask you for one favor. Well, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[148]`
Mówca: **Marcel Koronti**
> "“Think of your corporate allies as a sea of ravenous sharks surrounding you. We could co-exist peacefully, or...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Marcel Koronti**
> "“Ah, let's not even imagine that scenario.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[153]`
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“We don't need to be enemies.”"]** — Mówca: **Player**
> "“We don't need to be enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Imagine this scenario. You will either help me out, or I will eat your little company for dinner. Understood?”"]** — Mówca: **Player**
> "“Imagine this scenario. You will either help me out, or I will eat your little company for dinner. Understood?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I don't give in to threats. Your time is over, Koronti.”"]** — Mówca: **Player**
> "“I don't give in to threats. Your time is over, Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Don't get your knickers in a twist. I was planning on leaving HOS alone anyway.”"]** — Mówca: **Player**
> "“Don't get your knickers in a twist. I was planning on leaving HOS alone anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Marcel Koronti**
> "“That is excellent to hear!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[155]`
Mówca: **Marcel Koronti**
> "“What an unfortunate turn of events. What a tragedy!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Marcel Koronti**
> "“When I'm done with you, getting re-elected will be the least of your worries, Mr. *President*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Marcel Koronti**
> "“Listen to me. Do you think you have power because you're sitting in the fancy chair? Do you think you are Soll?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[158]`
Mówca: **Marcel Koronti**
> "“If you want war, you will have your war. But know this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[159]`
Mówca: **Narrator**
> "He laughed mockingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[160]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[161]`
Mówca: **Marcel Koronti**
> "“I knew we would be on the same page!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Marcel Koronti**
> "“I am raising my glass to you right now, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Marcel Koronti**
> "“There is actually one more thing I would like to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[164]`
Mówca: **Marcel Koronti**
> "“As long as you do as I say and exclude my *little* company, I will gladly help you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Marcel Koronti**
> "“I always keep my end of the bargain, Mr. President. Don't forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Marcel Koronti**
> "“You had better keep yours as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
Mówca: **Marcel Koronti**
> "“Before we end the call, there is actually one more thing I would like to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[168]`
Mówca: **Marcel Koronti**
> "“No. We don't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Marcel Koronti**
> "“As long as we both understand what entails *not* being enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[170]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[171]`
Mówca: **Marcel Koronti**
> "“Since the start of your campaign, you've wisely committed to a market economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Marcel Koronti**
> "“Judging by that, I am sure you are looking into privatizing some of the companies that are currently state owned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Marcel Koronti**
> "“I believe, therefore, that privatizing both Nedam Mining Group and the Sordish State Corporation would be in both of our interests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
Mówca: **Marcel Koronti**
> "“You are nothing!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[175]`
Mówca: **Marcel Koronti**
> "“I will destroy you and everything you hold dear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Marcel Koronti**
> "“Slowly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Marcel Koronti**
> "“Very slowly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Marcel Koronti**
> "“After all, I am considering buying stocks in both companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[179]`
  - -> `[188]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "“That's exactly what I was thinking.”"]** — Mówca: **Player**
> "“That's exactly what I was thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[180]`
Mówca: **Marcel Koronti**
> "“You think I don't know?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[181]`
Mówca: **Marcel Koronti**
> "“Be careful around the people you trust.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "“Screw you.”"]** — Mówca: **Player**
> "“Screw you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Don't know what?”"]** — Mówca: **Player**
> "“Don't know what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "He laughed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Marcel Koronti**
> "“Excellent! Great minds do think alike. Thank you for your support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Privatizing both might be too much. I will see what I can do.”"]** — Mówca: **Player**
> "“Privatizing both might be too much. I will see what I can do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Marcel Koronti**
> "“Think about it this way. It is another step forward in strengthening our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I am not thinking about privatization.”"]** — Mówca: **Player**
> "“I am not thinking about privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Marcel Koronti**
> "“Please at least think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[190]`
Mówca: **Marcel Koronti**
> "“What do you mean? You will leave everything the same, then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Marcel Koronti**
> "“Don't tell me you are thinking about nationalization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "“Yes, I am.”"]** — Mówca: **Player**
> "“Yes, I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Marcel Koronti**
> "“Mr. President. Nationalization as a concept goes against everything my father built and stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "“I'm thinking about a more balanced approach.”"]** — Mówca: **Player**
> "“I'm thinking about a more balanced approach.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Marcel Koronti**
> "“Balance is important, Mr. President, but the concept of nationalization goes against everything my father built and stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[196]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BergiaSteelTalk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[197]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: Jump to: [BergiaSteelTalk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[198]`
Mówca: **Marcel Koronti**
> "“Before we end the call, there is actually one more thing I would like to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: Jump to: [BergiaSteelTalk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[200]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[201]`
Mówca: **Marcel Koronti**
> "“I will be blunt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Marcel Koronti**
> "“Mr. Tusk is unfit to be the spokesperson for the Lotherberg Group. His archaic thinking has only preserved a status quo that benefits himself and precious few others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Marcel Koronti**
> "“It is high time something changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[204]`
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "“I see where this is going.”"]** — Mówca: **Player**
> "“I see where this is going.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“Who do you have in mind to replace him?”"]** — Mówca: **Player**
> "“Who do you have in mind to replace him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "“Stop. Before you say anything more, I won't meddle in Oligarchs' affairs.”"]** — Mówca: **Player**
> "“Stop. Before you say anything more, I won't meddle in Oligarchs' affairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[207]`
Mówca: **Marcel Koronti**
> "“Ah, it was worth a shot. But I respect your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Marcel Koronti**
> "“Very well. I won't push further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[209]`
Mówca: **Marcel Koronti**
> "“I want him gone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
Mówca: **Marcel Koronti**
> "“Who do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Marcel Koronti**
> "“Me, of course!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Marcel Koronti**
> "“I have taken up enough of your time today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[213]`
Mówca: **Marcel Koronti**
> "“Here is what I propose. A win-win situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[214]`
Mówca: **Marcel Koronti**
> "“It is time the group had a proper leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Marcel Koronti**
> "“Me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Marcel Koronti**
> "“If you could use your powers to make Bergia Steel, Tusk's main company, state-owned, he would lose considerable influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Marcel Koronti**
> "“Which means I could take over.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[218]`
Mówca: **Marcel Koronti**
> "“If I take over with your help, I will be forever indebted to you and support you in all your goals, be they re-election or something more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Marcel Koronti**
> "“How does that sound?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[220]`
  - -> `[222]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "“I'll have to think about it.”"]** — Mówca: **Player**
> "“I'll have to think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“That sounds profitable to me. Deal.”"]** — Mówca: **Player**
> "“That sounds profitable to me. Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“I won't make myself a target by picking a side.”"]** — Mówca: **Player**
> "“I won't make myself a target by picking a side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[223]`
Mówca: **Marcel Koronti**
> "“Perfect!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Marcel Koronti**
> "“Just think about it. That's all I am asking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Marcel Koronti**
> "“You and me. We would be unstoppable. We could eliminate everyone who's after us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[226]`
Mówca: **Marcel Koronti**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[227]`
Mówca: **Marcel Koronti**
> "“This has been a productive call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Marcel Koronti**
> "“Thank you for your time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`
  - -> `[231]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Thanks Marcel. Talk to you later.”"]** — Mówca: **Player**
> "“Thanks Marcel. Talk to you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[230]`
**[WYBÓR GRACZA: "“Goodbye, Mr. Koronti.”"]** — Mówca: **Player**
> "“Goodbye, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Narrator**
> "After a couple of minutes, I went back to reviewing the agenda."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_MarcelCalls = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_MarcelCalls"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[234]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_A_Marcel_OwnershipDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[235]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_A_Marcel_Threatened = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_A_Marcel_Threatened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[236]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[238]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Marcel Koronti**
> "“If you promised me a majority of shares from the privatization, he would lose considerable power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[240]`
Mówca: **Marcel Koronti**
> ""On another note...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[241]`
Mówca: **Marcel Koronti**
> ""Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "“You've outlived your usefulness to me. You are done for, Koronti.”"]** — Mówca: **Player**
> "“You've outlived your usefulness to me. You are done for, Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "“I understand. I want our partnership to continue uninterrupted.”"]** — Mówca: **Player**
> "“I understand. I want our partnership to continue uninterrupted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Marcel Koronti**
> "“As do I.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[245]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_NoNationalizeHOS = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[150]`
  - -> `[153]`
  - -> `[242]`

### Węzeł `[246]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[249]`
Mówca: **Marcel Koronti**
> "“You may recall that one of the terms of our agreement was that I may ask you for one favor. Well, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Marcel Koronti**
> "“I want him gone. And you're going to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[251]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Turn07_MarcelFavor_PrivateTakeover == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Turn07_MarcelFavor_PrivateTakeover == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_MarcelFavor_NoNationalizeHOS == false && BaseGame.Turn07_MarcelFavor_PrivateTakeover == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_MarcelFavor_NoNationalizeHOS"] == false  and  Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[254]`
Mówca: **Marcel Koronti**
> "“You may recall that one of the terms of our agreement was that I may ask you for one favor. Well, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Marcel Koronti**
> "“Do you accept?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`
  - -> `[258]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I'll have to think about it.""]** — Mówca: **Player**
> ""I'll have to think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Of course. A deal's a deal.""]** — Mówca: **Player**
> ""Of course. A deal's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""You're asking too much of me.""]** — Mówca: **Player**
> ""You're asking too much of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Marcel Koronti**
> ""Think about all the free help you've gotten from me -- and the many scandals you might have to cover up on the way to re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[260]`
Mówca: **Marcel Koronti**
> ""Korontis always keep their word, my father said. He would have liked you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[261]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[263]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Marcel Koronti**
> "“I wanted to thank you for choosing Underhall Construction to complete the L-1 railway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[265]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_MarcelThreatened = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_MarcelThreatened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[266]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_MarcelWantsToBeLeader"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[267]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[269]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[270]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositive = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_GeneralStaffPositive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[271]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegative = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_GeneralStaffNegative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[272]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[275]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Vesord_ProtestAgainstEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Vesord_ProtestAgainstEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[276]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[278]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[281]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[282]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Erzaren_LocalsProtestJointOperation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Erzaren_LocalsProtestJointOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[283]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[284]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_FPnT_Immigration_Tight == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[288]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_IllegalBorderCrossings2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[289]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_EmergencyBeingIgnored = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_EmergencyBeingIgnored"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[296]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_USPShowSupportEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_USPShowSupportEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[297]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= 0 && BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= 0 && BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= 0 && BaseGame.Reform_EmergencyDecree_SuspendedProtests == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[300]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_ProtestAgainstRayne = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_ProtestAgainstRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[301]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_LT_ProtestAgainstJointOperation = true; BaseGameSupport.News_Turn07_G_WehlenJointOperation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_ProtestAgainstJointOperation"] = true;
Variable["BaseGameSupport.News_Turn07_G_WehlenJointOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[302]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_WehlenBorderClosed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_WehlenBorderClosed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[303]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[304]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[305]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_MarcelCall_NotListened = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[306]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[308]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[309]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGame.Decision_Turn06_Lobbying_Bribe2 == true || BaseGame.Decision_Turn06_Lobbying_Bribe3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGame.Decision_Turn06_Lobbying_Bribe2 == true || BaseGame.Decision_Turn06_Lobbying_Bribe3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Lobbying_Bribe"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe2"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Lobbying_Bribe == true || BaseGame.Decision_Turn06_Lobbying_Bribe2 == true || BaseGame.Decision_Turn06_Lobbying_Bribe3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Lobbying_Bribe"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe2"] == true  or  Variable["BaseGame.Decision_Turn06_Lobbying_Bribe3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[312]`
Mówca: **Narrator**
> "The meeting was going to be about the ownership of the Big Four, the four corporations at the heart of Sordland's ownership debate: Heart of Sordland, Bergia Steel, the Sordish State Corporation and Nedam Mining Group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[313]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Uziren", "City_BludishRefugees");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_BludishRefugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[314]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  or  Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true || BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  or  Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[319]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_FPnT_Immigration_Tight == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[320]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[322]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_FPnT_Immigration_Tight == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Uziren", "City_BludishRefugees");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Uziren","City_BludishRefugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Ribel", "City_BludishRefugees");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Ribel","City_BludishRefugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: // Filler)*
- **Efekt (`userScript`):** `-- Filler;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[326]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true  or  (Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true || (BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true  or  (Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[332]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCallForAmendment = true;
BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction = true;
BaseGameSupport.News_Turn07_LT_BludLeadersCallForAmendment = true;
BaseGameSupport.News_Turn07_R_BludLeadersCallForAmendment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCallForAmendment"] = true;
Variable["BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction"] = true;
Variable["BaseGameSupport.News_Turn07_LT_BludLeadersCallForAmendment"] = true;
Variable["BaseGameSupport.News_Turn07_R_BludLeadersCallForAmendment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[333]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCondemnPresident = true;
BaseGameSupport.News_Turn07_R_BludsCondemnPresident = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_ErsenCase_BludsCondemnPresident"] = true;
Variable["BaseGameSupport.News_Turn07_R_BludsCondemnPresident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[334]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true && BaseGame.ErsenCase_Statement_ProSollist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true  and  Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[337]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ConflictedAmendment_BludsPullOut = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ConflictedAmendment_BludsPullOut"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[338]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[341]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtDelaysCase = true;
BaseGameSupport.News_Turn07_HP_SupremeCourtDelaysCase = true;
BaseGameSupport.News_Turn07_R_SupremeCourtDelaysCase = true;
BaseGameSupport.News_Turn07_LT_ProtestAgainstCourtDelay = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtDelaysCase"] = true;
Variable["BaseGameSupport.News_Turn07_HP_SupremeCourtDelaysCase"] = true;
Variable["BaseGameSupport.News_Turn07_R_SupremeCourtDelaysCase"] = true;
Variable["BaseGameSupport.News_Turn07_LT_ProtestAgainstCourtDelay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[342]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtChargesBron = true;
BaseGameSupport.News_Turn07_HP_SupremeCourtChargesBron = true;
BaseGameSupport.News_Turn07_R_SupremeCourtChargesBron = true;
BaseGameSupport.News_Turn07_LT_ProtestAgainstSollistOutcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_SupremeCourtChargesBron"] = true;
Variable["BaseGameSupport.News_Turn07_HP_SupremeCourtChargesBron"] = true;
Variable["BaseGameSupport.News_Turn07_R_SupremeCourtChargesBron"] = true;
Variable["BaseGameSupport.News_Turn07_LT_ProtestAgainstSollistOutcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[343]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction = true;
BaseGameSupport.News_Turn07_LT_NFPCondemns_ProBlud = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_ErsenCase_ProBlud_WPBCallsPresidentToAction"] = true;
Variable["BaseGameSupport.News_Turn07_LT_NFPCondemns_ProBlud"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[344]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[346]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[347]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[350]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Lachaven_IncreasedSupportForBludishRight = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Lachaven_IncreasedSupportForBludishRight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[351]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[352]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[355]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: //Continue)*
- **Efekt (`userScript`):** `--Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[356]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Leiren_EnergyPricesHurt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_ArcasianQinaliRestoration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[358]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true || BaseGame.Decision_Turn06_GasomSaleResult_Low == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true || BaseGame.Decision_Turn06_GasomSaleResult_Low == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomSaleResult_VeryLow"] == true  or  Variable["BaseGame.Decision_Turn06_GasomSaleResult_Low"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_GasomSaleResult_VeryLow == true || BaseGame.Decision_Turn06_GasomSaleResult_Low == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomSaleResult_VeryLow"] == true  or  Variable["BaseGame.Decision_Turn06_GasomSaleResult_Low"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[361]`
Mówca: **Marcel Koronti**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_E_Gasom_LowReturnsForState = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_E_Gasom_LowReturnsForState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
