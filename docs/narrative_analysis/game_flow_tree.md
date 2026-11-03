# Suzerain Game Flow & Event Hierarchy Tree

This document details the exact execution pipeline of turns, steps, story fragments, conversation triggers, and decisions for Suzerain: Kingdom of Rizia (and main game).

## StoryPack: `StoryPack_Main`

### Turn 1

#### Step 1
- **`Turn01_Start_Inauguration`** `[Conversation]`
  - Title: **-**
  - Dialogue Asset: `Sordland/Turn01/Start_Inauguration`
  - Map Token: `Sordland_City_Holsord`

#### Step 2
- **`Turn01_A_PoliticalOverview`** `[Conversation]`
  - Title: **Briefing on the Current Political Situation**
  - Dialogue Asset: `Sordland/Turn01/A_PoliticalOverview`
  - Map Token: `Sordland_City_Holsord`
- **`Turn01_EnT_EconomicOverview`** `[Conversation]`
  - Title: **Briefing on the Current Economic Situation**
  - Dialogue Asset: `Sordland/Turn01/EnT_EconomicOverview`
  - Map Token: `Sordland_City_Holsord`
  - OnEnd: `BaseGame.Panel_EconomicStability = true`

#### Step 3
- **`Turn01_A_Media`** `[Conversation]`
  - Title: **Meeting on the Media Strategy**
  - Dialogue Asset: `Sordland/Turn01/A_Media`
  - Map Token: `Sordland_City_Holsord`

#### Step 4
- **`Turn01_Decision_InfrastructureProject`** `[Decision]`
  - Title: **Invest in Mega-Infrastructure**
- **`Turn01_Bill_CampaignFinance`** `[SystemFragment/Other]`

#### Step 5
- **`Turn01_InT_Infrastructure`** `[Conversation]`
  - Title: **Discussion of the Potential Infrastructure Projects**
  - Dialogue Asset: `Sordland/Turn01/InT_Infrastructure`
  - Map Token: `Sordland_City_Lachaven`
  - Condition: `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`

#### Step 6
- *OnStepStart:* `BaseGame.Economy += 2;`
- **`Turn01_Decision_PersonalInvestment`** `[Decision]`
  - Title: **Invest in Arcasian Company Stocks**

#### Step 7
- **`Turn01_Personal_Ball`** `[Conversation]`
  - Title: **Reception at the Inaugural Ball**
  - Dialogue Asset: `Sordland/Turn01/Personal_Ball`
  - Map Token: `Sordland_City_Holsord`

#### Step 8
- *OnStepStart:* `BaseGame.Economy -= 1;`
- **`Turn01_SnO_MPShot`** `[Conversation]`
  - Title: **Emergency Meeting**
  - Dialogue Asset: `Sordland/Turn01/SnO_MPShot`
  - Map Token: `Sordland_City_Holsord`

### Turn 2

#### Step 1
- **`Turn02_Personal_FamilyDinner`** `[Conversation]`
  - Title: **Dinner with the Family at Home**
  - Dialogue Asset: `Sordland/Turn02/Personal_FamilyDinner`
  - Map Token: `Sordland_City_Holsord`
- **`Turn02_SnO_SecurityOverview`** `[Conversation]`
  - Title: **Security Briefing on the Threats Against Sordland**
  - Dialogue Asset: `Sordland/Turn02/SnO_SecurityOverview`
  - Map Token: `Sordland_City_Holsord`

#### Step 2
- **`Turn02_A_ContractBribe`** `[Conversation]`
  - Title: **End of Day at the Maroon Palace**
  - Dialogue Asset: `Sordland/Turn02/A_ContractBribe`
  - Map Token: `Sordland_City_Holsord`
- **`Turn02_Decision_StatusReaction`** `[Decision]`
  - Title: **React to the Unrest**

#### Step 3
- **`Turn02_A_MediaDeal`** `[Conversation]`
  - Title: **Meeting with Marcel Koronti**
  - Dialogue Asset: `Sordland/Turn02/A_MediaDeal`
  - Map Token: `Sordland_City_Conriat`
  - Condition: `BaseGame.Turn01_Admin_Meeting == true`
- **`Turn02_InT_HighwayContract`** `[Conversation]`
  - Title: **Finalization of the H-3 Highway Contract**
  - Dialogue Asset: `Sordland/Turn02/InT_HighwayContract`
  - Map Token: `Sordland_City_Lenkurg`
  - Condition: `BaseGame.Turn01_InT_Investment_Highway == true`
- **`Turn02_InT_RailwayContract`** `[Conversation]`
  - Title: **Finalization of the L-1 Railway Contract**
  - Dialogue Asset: `Sordland/Turn02/InT_RailwayContract`
  - Map Token: `Sordland_City_Anrica`
  - Condition: `BaseGame.Turn01_InT_Investment_Railway == true`
- **`Turn02_Decision_EconomicRelief`** `[Decision]`
  - Title: **Economic Relief Plan**

#### Step 4
- **`Turn02_Decision_Funeral`** `[Decision]`
  - Title: **Funeral of Bernard Circas**

#### Step 5
- **`Turn02_Personal_Funeral`** `[Conversation]`
  - Title: **Funeral of Bernard Circas**
  - Dialogue Asset: `Sordland/Turn02/Personal_Funeral`
  - Map Token: `Sordland_City_Deyr`
  - Condition: `BaseGame.Decision_Turn02_Funeral_Attend == true`

#### Step 6
- **`Turn02_FPnT_DiplomacyOverview`** `[Conversation]`
  - Title: **Briefing on the Current Diplomatic Situation**
  - Dialogue Asset: `Sordland/Turn02/FPnT_DiplomacyOverview`
  - Map Token: `Sordland_City_Lachaven`

#### Step 7
- **`Turn02_A_ReformBriefing`** `[Conversation]`
  - Title: **Briefing on the results from the Reform Committee**
  - Dialogue Asset: `Sordland/Turn02/A_ReformBriefing`
  - Map Token: `Sordland_City_Holsord`
- **`Turn02_Bill_TourismCulture`** `[SystemFragment/Other]`

#### Step 8
- **`Turn02_A_AutocratBriefing`** `[Conversation]`
  - Title: **Meeting with Chief Justice Orso Hawker**
  - Dialogue Asset: `Sordland/Turn02/A_AutocratBriefing`
  - Map Token: `Sordland_City_Holsord`

### Turn 3

#### Step 1
- **`Turn03_Personal_FrancTalk`** `[Conversation]`
  - Title: **Barbecue with Franc**
  - Dialogue Asset: `Sordland/Turn03/Personal_FrancTalk`
  - Map Token: `Sordland_City_Holsord`

#### Step 2
- **`Turn03_Personal_DriverTalk`** `[Conversation]`
  - Title: **Presidential Visit to Narbel**
  - Dialogue Asset: `Sordland/Turn03/Personal_DriverTalk`
  - Map Token: `Sordland_City_Narbel`

#### Step 3
- **`Turn03_PSnW_Overview`** `[Conversation]`
  - Title: **Briefing on the Current Welfare Situation**
  - Dialogue Asset: `Sordland/Turn03/PSnW_Overview`
  - Map Token: `Sordland_City_Narbel`

#### Step 4
- **`Turn03_EnT_GasomProposal`** `[Conversation]`
  - Title: **Meeting with Manger and Alphonso on Gasom**
  - Dialogue Asset: `Sordland/Turn03/EnT_GasomProposal`
  - Map Token: `Sordland_City_Narbel`

#### Step 5
- **`Turn03_Decision_Extraction`** `[Decision]`
  - Title: **Leave Gasom Facility and Narbel**

#### Step 6
- **`Turn03_A_AddressTheProtestors`** `[Conversation]`
  - Title: **Address the Protestors and Leave via Car**
  - Dialogue Asset: `Sordland/Turn03/A_AddressProtestors`
  - Map Token: `Sordland_City_Narbel`
  - Condition: `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **`Turn03_Personal_HelicopterEscape`** `[Conversation]`
  - Title: **Flying Over Nargis with Alphonso and Wolkner**
  - Dialogue Asset: `Sordland/Turn03/Personal_HelicopterEscape`
  - Map Token: `Sordland_City_Lachaven`
  - Condition: `BaseGame.Decision_Turn03_Extraction_FlyWithHelicopter == true`

#### Step 7
- **`Turn03_A_LateBriefing`** `[Conversation]`
  - Title: **Briefing on the results from the Reform Committee**
  - Dialogue Asset: `Sordland/Turn03/A_LateBriefing`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Autocrat_Abandon == true`
- **`Turn03_Decision_StabilityOrder`** `[Decision]`
  - Title: **Stability Order of 1954**
  - Condition: `BaseGame.Reform_Autocrat_Path == false`

#### Step 8
- **`Turn03_A_ReformistConstitution`** `[Conversation]`
  - Title: **Finalisation of the Drafted Constitutional Changes**
  - Dialogue Asset: `Sordland/Turn03/A_ReformistConstitution`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reformist_Path == true`
- **`Turn03_A_DictatorConstitution`** `[Conversation]`
  - Title: **Finalisation of the Drafted Constitutional Changes**
  - Dialogue Asset: `Sordland/Turn03/A_DictatorConstitution`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Dictator_Path == true`
- **`Turn03_A_AutocratDecree`** `[Conversation]`
  - Title: **Preparation of the Emergency Decree**
  - Dialogue Asset: `Sordland/Turn03/A_AutocratDecree`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Autocrat_Path == true`
- **`Turn03_Bill_GreenGruniDev`** `[SystemFragment/Other]`

#### Step 9
- *OnStepStart:* `AnalyticsEvent("Analytics_Sordland_PathChosen");`
- **`Turn03_A_AutocratSpeech`** `[Conversation]`
  - Title: **Declaration of the Emergency Act**
  - Dialogue Asset: `Sordland/Turn03/A_AutocratSpeech`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Autocrat_Path == true`

#### Step 10
- **`Turn03_EnT_BusinessCouncil`** `[Conversation]`
  - Title: **Dinner with the Business Council Members**
  - Dialogue Asset: `Sordland/Turn03/EnT_BusinessCouncil`
  - Map Token: `Sordland_City_Lachaven`
- **`Turn03_A_EnergyProtectionAct`** `[Conversation]`
  - Title: **Meeting on the Energy Protection Act of 1932**
  - Dialogue Asset: `Sordland/Turn03/A_EnergyProtectionAct`
  - Map Token: `Sordland_City_Holsord`

#### Step 11
- **`Turn03_EnT_Budget`** `[Conversation]`
  - Title: **Budget Allocation of the Government of Sordland**
  - Dialogue Asset: `Sordland/Turn03/EnT_Budget`
  - Map Token: `Sordland_City_Holsord`

### Turn 4

#### Step 1
- **`Turn04_Decision_RiotGear`** `[Decision]`
  - Title: **Buy Riot Control Equipment**
  - Condition: `BaseGame.Enable_RiotGear == true`
- **`Turn04_Bill_WorkersRights`** `[SystemFragment/Other]`

#### Step 2
- **`Turn04_SnO_LawEnforcementBudget`** `[Conversation]`
  - Title: **Budget Allocation of Law Enforcement**
  - Dialogue Asset: `Sordland/Turn04/SnO_LawEnforcementBudget`
  - Map Token: `Sordland_City_Holsord`
- **`Turn04_Personal_Jogging`** `[Conversation]`
  - Title: **An Evening Walk with Monica**
  - Dialogue Asset: `Sordland/Turn04/Personal_Jogging`
  - Map Token: `Sordland_City_Holsord`
- **`Turn04_Decision_RegionalInvestment`** `[Decision]`
  - Title: **Regional Investment Decision**

#### Step 3
- *OnStepStart:* `AnalyticsEvent("Analytics_Sordland_PoliceDepartments");`
- **`Turn04_InT_SSCRailwayIssue`** `[Conversation]`
  - Title: **Briefing on the L-1 Railway Construction Issues**
  - Dialogue Asset: `Sordland/Turn04/InT_SSCRailwayIssue`
  - Map Token: `Sordland_City_Gelsord`
  - Condition: `BaseGame.Enable_SSCRailwayIssue == true`
- **`Turn04_InT_TaurusRailwayIssue`** `[Conversation]`
  - Title: **Briefing on the L-1 Railway Construction Issues**
  - Dialogue Asset: `Sordland/Turn04/InT_TaurusRailwayIssue`
  - Map Token: `Sordland_City_Gelsord`
  - Condition: `BaseGame.Enable_TaurusRailwayIssue == true`
- **`Turn04_InT_SSCHighwayIssue`** `[Conversation]`
  - Title: **Briefing on the H-3 Highway Construction Issues**
  - Dialogue Asset: `Sordland/Turn04/InT_SSCHighwayIssue`
  - Map Token: `Sordland_City_Lenkurg`
  - Condition: `BaseGame.Enable_SSCHighwayIssue == true`
- **`Turn04_InT_TaurusHighwayIssue`** `[Conversation]`
  - Title: **Briefing on the H-3 Highway Construction Issues**
  - Dialogue Asset: `Sordland/Turn04/InT_TaurusHighwayIssue`
  - Map Token: `Sordland_City_Lenkurg`
  - Condition: `BaseGame.Enable_TaurusHighwayIssue == true`
- **`Turn04_EnT_TaxReform`** `[Conversation]`
  - Title: **Discussion of Changes to the Tax System**
  - Dialogue Asset: `Sordland/Turn04/EnT_TaxReform`
  - Map Token: `Sordland_City_Lachaven`

#### Step 4
- **`Turn04_PSnW_SchoolVisit`** `[Conversation]`
  - Title: **Visit and Inspection of Schools in Leiren**
  - Dialogue Asset: `Sordland/Turn04/PSnW_SchoolVisit`
  - Map Token: `Sordland_City_Leiren`
- **`Turn04_Decision_FoundationDonation`** `[Decision]`
  - Title: **Alphonso Foundation Asks For Donation**
  - Condition: `BaseGame.PersonalWealth >= 1 && BaseGame.Relations_Ewald_DonatedToFoundation == false`

#### Step 5
- **`Turn04_PSnW_EducationReform`** `[Conversation]`
  - Title: **Briefing on the Proposal of Education Reform**
  - Dialogue Asset: `Sordland/Turn04/PSnW_EducationReform`
  - Map Token: `Sordland_City_Leiren`

#### Step 6
- **`Turn04_Decision_GruniRuralDevelopment`** `[Decision]`
  - Title: **Gruni Rural Development Investment**

#### Step 7
- **`Turn04_A_ConvinceGloria`** `[Conversation]`
  - Title: **Meeting with Gloria Tory on Planned Reforms**
  - Dialogue Asset: `Sordland/Turn04/A_ConvinceGloria`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`

#### Step 8
- **`Turn04_Decision_PlayChessWithLucian`** `[Decision]`
  - Title: **Lucian Offers to Play Chess**
- **`Turn04_Personal_ChessWithLucian`** `[Conversation]`
  - Title: **An Evening Chess Match with Lucian Galade**
  - Dialogue Asset: `Sordland/Turn04/Personal_LucianChessMatch`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Decision_Turn04_ChessGame_PlayChess == true`

#### Step 9
- **`Turn04_A_ConvinceAlbin`** `[Conversation]`
  - Title: **Meeting with Albin Clavin on Planned Reforms**
  - Dialogue Asset: `Sordland/Turn04/A_ConvinceAlbin`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`

### Turn 5

#### Step 1
- **`Turn05_Decision_Penalty_SuperpowerTradeWar`** `[Decision]`
  - Title: **Superpower Trade War**
  - Condition: `BaseGame.SuperpowerTradeWarHappened == true`
- **`Turn05_Decision_Penalty_BlackTuesday`** `[Decision]`
  - Title: **Black Tuesday**
  - Condition: `BaseGame.BlackTuesdayHappened == true`

#### Step 2
- **`Turn05_Decision_FinancialAid_UnitedContana`** `[Decision]`
  - Title: **United Contana Offers Aid**
  - Condition: `BaseGame.FinancialAid_UC == true`
- **`Turn05_Decision_FinancialAid_Arcasia`** `[Decision]`
  - Title: **Arcasia Offers Aid**
  - Condition: `BaseGame.FinancialAid_Arcasia == true`
- **`Turn05_Decision_FinancialAid_Both`** `[Decision]`
  - Title: **Superpowers Offer Aid**
  - Condition: `BaseGame.FinancialAid_Both == true`
- **`Turn05_Bill_ReligiousHarmony`** `[SystemFragment/Other]`

#### Step 3
- **`Turn05_Personal_ReturnOfInvestment`** `[Conversation]`
  - Title: **A Call from Gus Manger**
  - Dialogue Asset: `Sordland/Turn05/Personal_ReturnOfInvestment`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Decision_Turn01_PersonalInvestment_Spend3 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend2 == true || BaseGame.Decision_Turn01_PersonalInvestment_Spend1 == true`

#### Step 4
- **`Turn05_FPnT_ImmigrationPolicy`** `[Conversation]`
  - Title: **Briefing on the Status of Immigration Regulation**
  - Dialogue Asset: `Sordland/Turn05/FPnT_ImmigrationPolicy`
  - Map Token: `Sordland_City_Holsord`
- **`Turn05_Personal_PetrParty`** `[Conversation]`
  - Title: **Private Party of the Gentleman's Club**
  - Dialogue Asset: `Sordland/Turn05/Personal_PetrParty`
  - Map Token: `Sordland_City_Erlory`

#### Step 5
- **`Turn05_Personal_FestivalOpening`** `[Conversation]`
  - Title: **The Opening of the Benfi Festival**
  - Dialogue Asset: `Sordland/Turn05/Personal_FestivalOpening`
  - Map Token: `Sordland_City_Benfi`

#### Step 6
- **`Turn05_A_DamageControl`** `[Conversation]`
  - Title: **Assessment of the Benfi Festival Scandal**
  - Dialogue Asset: `Sordland/Turn05/A_DamageControl`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Turn05_Personal_Festival_Force == true`

#### Step 7
- **`Turn05_Personal_MonicaTalk`** `[Conversation]`
  - Title: **Downtime at Home**
  - Dialogue Asset: `Sordland/Turn05/Personal_MonicaTalk`
  - Map Token: `Sordland_City_Holsord`

#### Step 8
- **`Turn05_Decision_RumburgBorderReinforcement`** `[Decision]`
  - Title: **Build Rumburg Border Fortifications**
  - Condition: `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`

#### Step 9
- **`Turn05_SnO_FoundedPolice`** `[Conversation]`
  - Title: **Discussion on the Formation of a New Police Force**
  - Dialogue Asset: `Sordland/Turn05/SnO_FoundedPolice`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **`Turn05_SnO_MilitaryBudget`** `[Conversation]`
  - Title: **Budget Allocation of Sordish Armed Forces**
  - Dialogue Asset: `Sordland/Turn05/SnO_MilitaryBudget`
  - Map Token: `Sordland_City_Holsord`

#### Step 10
- *OnStepStart:* `UpdateProgress("Progress_DiplomaticMission_Agnolia", 100);
UpdateProgress("Progress_DiplomaticMission_Wehlen", 100);`
- **`Turn05_FPnT_AgnoliaTradeVisit`** `[Conversation]`
  - Title: **Trade Talks with the Prime Minister of Agnolia**
  - Dialogue Asset: `Sordland/Turn05/FPnT_AgnoliaTradeVisit`
  - Map Token: `Sordland_Country_Agnolia`
- **`Turn05_FPnT_WehlenTradeVisit`** `[Conversation]`
  - Title: **Trade Talks with the President of Wehlen**
  - Dialogue Asset: `Sordland/Turn05/FPnT_WehlenTradeVisit`
  - Map Token: `Sordland_Country_Wehlen`

#### Step 11
- **`Turn05_A_DictatorSpeech`** `[Conversation]`
  - Title: **Speech of the President on the Reforms**
  - Dialogue Asset: `Sordland/Turn05/A_DictatorSpeech`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Dictator_Path == true`
- **`Turn05_A_ReformistSpeech`** `[Conversation]`
  - Title: **Speech of the President on the Reforms**
  - Dialogue Asset: `Sordland/Turn05/A_ReformistSpeech`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reformist_Path == true`
- **`Turn05_Decision_Emergency`** `[Decision]`
  - Title: **Extend Emergency Decree**
  - Condition: `BaseGame.Reform_Autocrat_Path == true`

#### Step 12
- **`Turn05_A_AutocratAssembly`** `[Conversation]`
  - Title: **Assembly Session on the Emergency Act**
  - Dialogue Asset: `Sordland/Turn05/A_AutocratAssembly`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`

### Turn 6

#### Step 1
- **`Turn06_InT_RailwayOpening`** `[Conversation]`
  - Title: **The Opening of the L-1 Railway**
  - Dialogue Asset: `Sordland/Turn06/InT_RailwayOpening`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Turn04_InT_RailwayIssue_Solved == true`
- **`Turn06_InT_HighwayOpening`** `[Conversation]`
  - Title: **The Opening of the H-3 Highway**
  - Dialogue Asset: `Sordland/Turn06/InT_HighwayOpening`
  - Map Token: `Sordland_City_Lachaven`
  - Condition: `BaseGame.Turn04_InT_HighwayIssue_Solved == true`
- **`Turn06_SnO_ConscriptionAndMilitaryPolicy`** `[Conversation]`
  - Title: **Requested Meeting of Iosef Lancea**
  - Dialogue Asset: `Sordland/Turn06/SnO_ConscriptionAndMilitaryPolicy`
  - Map Token: `Sordland_City_Holsord`

#### Step 2
- *OnStepStart:* `UpdateProgress("Progress_RumburgBorderReinforcement", 25);`
- **`Turn06_EnT_Overview`** `[Conversation]`
  - Title: **Briefing on the Current Economic Situation**
  - Dialogue Asset: `Sordland/Turn06/EnT_Overview`
  - Map Token: `Sordland_City_Holsord`

#### Step 3
- **`Turn06_Decision_Megaproject`** `[Decision]`
  - Title: **Economic Investment Project**
- **`Turn06_SnO_BergiaMeeting`** `[Conversation]`
  - Title: **Meeting on the escalating tensions in Bergia**
  - Dialogue Asset: `Sordland/Turn06/SnO_BergiaMeeting`
  - Map Token: `Sordland_City_Holsord`

#### Step 4
- **`Turn06_Decision_Penalty_EnergyInflationCrisis`** `[Decision]`
  - Title: **The Sordish Energy Inflation Crisis**
  - Condition: `BaseGame.Turn06_EnergyInflationCrisis == true || BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`

#### Step 5
- **`Turn06_PSnW_HealthBudget`** `[Conversation]`
  - Title: **Budget Allocation of Healthcare**
  - Dialogue Asset: `Sordland/Turn06/PSnW_HealthBudget`
  - Map Token: `Sordland_City_Deyr`
- **`Turn06_Bill_CentralBankReinforcement`** `[SystemFragment/Other]`

#### Step 6
- **`Turn06_A_AutocratDemands`** `[Conversation]`
  - Title: **Meeting with Justice Garaci on the Emergency Act**
  - Dialogue Asset: `Sordland/Turn06/A_AutocratDemands`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Autocrat_Path == true`
- **`Turn06_A_ReformistConvincePFJP`** `[Conversation]`
  - Title: **Talks with Frens Ricter on the Upcoming Vote**
  - Dialogue Asset: `Sordland/Turn06/A_ReformistConvincePFJP`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reformist_Path == true`
- **`Turn06_A_DictatorConvinceNFP`** `[Conversation]`
  - Title: **Talks with Kesaro Kibener on the Upcoming Vote**
  - Dialogue Asset: `Sordland/Turn06/A_DictatorConvinceNFP`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Dictator_Path == true`

#### Step 7
- **`Turn06_InT_2ndCompanyChoice`** `[Conversation]`
  - Title: **Finalisation of the New Megaproject Contract**
  - Dialogue Asset: `Sordland/Turn06/InT_2ndCompanyChoice`
  - Map Token: `Sordland_City_Conriat`
  - Condition: `BaseGame.Turn06_EnT_Started2ndMegaproject == true && BaseGame.Turn01_InT_Investment_Highway == false && BaseGame.Turn01_InT_Investment_Railway == false`
- **`Turn06_Decision_Investment2CompanyChoice`** `[Decision]`
  - Title: **Award Company Contract**
  - Condition: `BaseGame.Turn06_EnT_Started2ndMegaproject == true && (BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)`

#### Step 8
- **`Turn06_PSnW_EducationSpending`** `[Conversation]`
  - Title: **Updates on the Situation of Education**
  - Dialogue Asset: `Sordland/Turn06/PSnW_EducationSpending`
  - Map Token: `Sordland_City_Valgen`
- **`Turn06_Personal_ReturnOfInvestment2`** `[Conversation]`
  - Title: **A Call from Gus Manger**
  - Dialogue Asset: `Sordland/Turn06/Personal_ReturnOfInvestment2`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Accepted_PersonalInvestment2 == true`

#### Step 9
- *OnStepStart:* `UpdateProgress("Progress_RumburgBorderReinforcement", 50);`
- **`Turn06_PSnW_Curriculum`** `[Conversation]`
  - Title: **Briefing on the Current Curriculum in Schools**
  - Dialogue Asset: `Sordland/Turn06/PSnW_Curriculum`
  - Map Token: `Sordland_City_Holsord`
- **`Turn06_Bill_EnergyInflation`** `[SystemFragment/Other]`
- **`Turn06_Decision_GasomStake`** `[Decision]`
  - Title: **Gasom State Shares Divestment**
  - Condition: `BaseGame.Turn03_Admin_EnergyProtectionAct_10Percent == false && (BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`

#### Step 10
- **`Turn06_Decision_Lobbying`** `[Decision]`
  - Title: **Lobbying Effort in Assembly**
  - Condition: `BaseGame.Enable_Lobbying == true`
- **`Turn06_A_VictoryDay`** `[Conversation]`
  - Title: **Attending the Victory Day Event**
  - Dialogue Asset: `Sordland/Turn06/A_VictoryDayBludishMeeting`
  - Map Token: `Sordland_City_Jen`
- **`Turn06_Decision_GasomStakeResults`** `[Decision]`
  - Title: **Gasom Shares Sale Result**
  - Condition: `BaseGame.Gasom_VeryHighSale == true || BaseGame.Gasom_HighSale == true || BaseGame.Gasom_MediumSale == true || BaseGame.Gasom_LowSale == true || BaseGame.Gasom_VeryLowSale == true`

### Turn 7

#### Step 1
- **`Turn07_A_MarcelCalls`** `[Conversation]`
  - Title: **A Call from Marcel Koronti**
  - Dialogue Asset: `Sordland/Turn07/A_MarcelCalls`
  - Map Token: `Sordland_City_Holsord`

#### Step 2
- **`Turn07_A_EconomicDirection`** `[Conversation]`
  - Title: **Requested Meeting of Lucian Galade**
  - Dialogue Asset: `Sordland/Turn07/A_EconomicDirection`
  - Map Token: `Sordland_City_Holsord`

#### Step 3
- *OnStepStart:* `UpdateProgress("Progress_RumburgBorderReinforcement", 75);`
- **`Turn07_Decision_BludishLeadersMeeting_Invited`** `[Decision]`
  - Title: **Bludish Leaders Meeting Invitation**
  - Condition: `BaseGame.BergiaSpecialZone_Proposal_Amendment == true && 
BaseGame.ErsenCase_Statement_ProSollist == false`
- **`Turn07_Decision_BludishLeadersMeeting`** `[Decision]`
  - Title: **Bludish Leaders Meeting**
  - Condition: `BaseGame.ErsenCase_Statement_ProBlud == true && 
BaseGame.BergiaSpecialZone_Proposal_Amendment == false && 
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && 
(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && 
BaseGame.Reform_Reform_NFP_Convinced == false`

#### Step 4
- **`Turn07_A_BludishRightsMeeting`** `[Conversation]`
  - Title: **Meeting with the leaders of the Bludish Rights Movement**
  - Dialogue Asset: `Sordland/Turn07/BludishRightsMeeting`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true`

#### Step 5
- **`Turn07_EnT_NationalizationAndPrivatization`** `[Conversation]`
  - Title: **Ownership Changes of Major Corporations**
  - Dialogue Asset: `Sordland/Turn07/EnT_NationalizationAndPrivatization`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.EconomicDirection_Privatization == true || BaseGame.EconomicDirection_Nationalization == true`

#### Step 6
- **`Turn07_A_OligarchsFinalMeeting`** `[Conversation]`
  - Title: **Results of the Economic Direction**
  - Dialogue Asset: `Sordland/Turn07/A_OligarchsFinalMeeting`
  - Map Token: `Sordland_City_Holsord`
- **`Turn07_Bill_LanguageBill`** `[SystemFragment/Other]`

#### Step 7
- **`Turn07_A_ConfrontationToNewProposal`** `[Conversation]`
  - Title: **Confrontation Before the Vote**
  - Dialogue Asset: `Sordland/Turn07/A_ConfrontationToNewProposal`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_BludishRights_Amendment_Proposal == true`

#### Step 8
- *OnStepStart:* `UpdateProgress("Progress_RumburgBorderReinforcement", 100);`
- **`Turn07_A_AssemblyVote`** `[Conversation]`
  - Title: **Assembly Vote on the Constitutional Changes**
  - Dialogue Asset: `Sordland/Turn07/A_AssemblyVote`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Dictator_Path == true || 
BaseGame.Reform_Reformist_Path == true`

#### Step 9
- **`Turn07_A_AssemblyVote_ResultsMeeting`** `[Conversation]`
  - Title: **Meeting on the Results of the Assembly Vote**
  - Dialogue Asset: `Sordland/Turn07/A_AssemblyVote_ResultsMeeting`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Dictator_Path == true || 
BaseGame.Reform_Reformist_Path == true`

#### Step 10
- **`Turn07_Personal_TheatreVisit`** `[Conversation]`
  - Title: **Invitation to the Movie Premiere**
  - Dialogue Asset: `Sordland/Turn07/Personal_TheatreVisit`
  - Map Token: `Sordland_City_Erlory`
- **`Turn07_Decision_RumburgWhistleblower`** `[Decision]`
  - Title: **Rumburg Whistleblower Arrives**

#### Step 11
- **`Turn07_FPnT_DiplomacyOverview2AndTradeDeal`** `[Conversation]`
  - Title: **Briefing on the Diplomatic Strategy**
  - Dialogue Asset: `Sordland/Turn07/FPnT_DiplomacyOverview2AndTradeDeal`
  - Map Token: `Sordland_City_Holsord`
- **`Turn07_A_DayofDescension`** `[Conversation]`
  - Title: **Ceremonial Duty for the Day of Descension**
  - Dialogue Asset: `Sordland/Turn07/A_DayofDescension`
  - Map Token: `Sordland_City_Deyr`
- **`Turn07_Personal_UniversityChoice`** `[Conversation]`
  - Title: **Dinner with the Family at Home**
  - Dialogue Asset: `Sordland/Turn07/Personal_UniversityChoice`
  - Map Token: `Sordland_City_Holsord`

#### Step 12
- *OnStepStart:* `RemoveTokenStatus("Sordland_City_Narbel", "Progress_RumburgBorderReinforcement");
RemoveTokenStatus("Sordland_City_Estord", "Progress_RumburgBorderReinforcement");
RemoveTokenStatus("Sordland_City_Laren", "Progress_RumburgBorderReinforcement");`
- **`Turn07_A_ConvinceIsabel`** `[Conversation]`
  - Title: **Dinner with Justice Isabel**
  - Dialogue Asset: `Sordland/Turn07/A_ConvinceIsabel`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **`Turn07_A_Autocrat_CourtDecision`** `[Conversation]`
  - Title: **Announcement of the Supreme Court's Decision**
  - Dialogue Asset: `Sordland/Turn07/A_Autocrat_CourtDecision`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Autocrat_Path == true`

#### Step 13
- **`Turn07_Decision_HeronMeeting`** `[Decision]`
  - Title: **Reach out to Justice Heron**
  - Condition: `BaseGame.Enable_HeronDecision == true`

#### Step 14
- *OnStepStart:* `UpdateProgress("Progress_DiplomaticMission_Valgsland", 33);
UpdateProgress("Progress_DiplomaticMission_Lespia", 33);`
- **`Turn07_A_ConvinceHeron`** `[Conversation]`
  - Title: **Private Meeting with Justice Heron**
  - Dialogue Asset: `Sordland/Turn07/A_ConvinceHeron`
  - Map Token: `Sordland_City_Erlory`
  - Condition: `BaseGame.Enable_HeronMeeting == true`

#### Step 15
- **`Turn07_A_CourtVote`** `[Conversation]`
  - Title: **Announcement of the Supreme Court's Decision**
  - Dialogue Asset: `Sordland/Turn07/A_CourtVote`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Reform_Reform_AssemblyVote_Success == true`

#### Step 16
- **`Turn07_A_ResultsMeeting`** `[Conversation]`
  - Title: **Cabinet Meeting on the Results of the Vote**
  - Dialogue Asset: `Sordland/Turn07/A_ResultsMeeting`
  - Map Token: `Sordland_City_Holsord`

#### Step 17
- **`Turn07_A_AddressToTheNation`** `[Conversation]`
  - Title: **Address to the Nation Speech**
  - Dialogue Asset: `Sordland/Turn07/A_AddressToTheNation`
  - Map Token: `Sordland_City_Holsord`

### Turn 8

#### Step 1
- **`Turn08_Personal_FrancLeaves`** `[Conversation]`
  - Title: **Departure of President's Son from Home**
  - Dialogue Asset: `Sordland/Turn08/Personal_FrancLeaves`
  - Map Token: `Sordland_City_Holsord`

#### Step 2
- **`Turn08_InT_LateRailwayOpening`** `[Conversation]`
  - Title: **The Opening of the L-1 Railway**
  - Dialogue Asset: `Sordland/Turn08/InT_LateRailwayOpening`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_LateOpenRailway == true`
- **`Turn08_InT_LateHighwayOpening`** `[Conversation]`
  - Title: **The Opening of the H-3 Highway**
  - Dialogue Asset: `Sordland/Turn08/InT_LateHighwayOpening`
  - Map Token: `Sordland_City_Lachaven`
  - Condition: `BaseGame.Enable_LateOpenHighway == true`
- **`Turn08_Decision_ScholarshipProgram`** `[Decision]`
  - Title: **Scholarship Program Proposal**
  - Condition: `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`

#### Step 3
- **`Turn08_A_PresidentialPowers`** `[Conversation]`
  - Title: **Discussion on the Changes to the Law**
  - Dialogue Asset: `Sordland/Turn08/A_PresidentialPowers`
  - Map Token: `Sordland_City_Holsord`
- **`Turn08_Decision_GasomFinancialReport`** `[Decision]`
  - Title: **Gasom Financial Report**
  - Condition: `(BaseGame.Decision_Turn06_GasomStake_Keep == true || BaseGame.Decision_Turn06_GasomStake_SellOneThird == true) &&(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`

#### Step 4
- *OnStepStart:* `UpdateProgress("Progress_DiplomaticMission_Valgsland", 100);
UpdateProgress("Progress_DiplomaticMission_Lespia", 100);`
- **`Turn08_FPnT_ValgslandVisit`** `[Conversation]`
  - Title: **Trade Talks with the Chancellor of Valgsland**
  - Dialogue Asset: `Sordland/Turn08/FPnT_ValgslandVisit`
  - Map Token: `Sordland_City_Lachaven`
  - Condition: `BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **`Turn08_FPnT_LespiaVisit`** `[Conversation]`
  - Title: **Trade Talks with the Prime Minister of Lespia**
  - Dialogue Asset: `Sordland/Turn08/FPnT_LespiaVisit`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.TradeDeal_Negotiation_Lespia == true`
- **`Turn08_Bill_SpecialZone_Autonomy`** `[SystemFragment/Other]`
- **`Turn08_Bill_SpecialZone_Centralization`** `[SystemFragment/Other]`

#### Step 5
- **`Turn08_Personal_PetrTalk`** `[Conversation]`
  - Title: **Private Meeting with Petr Vectern**
  - Dialogue Asset: `Sordland/Turn08/Personal_PetrTalk`
  - Map Token: `Sordland_City_Erlory`

#### Step 6
- **`Turn08_A_AffairMeeting`** `[Conversation]`
  - Title: **Start of the Day at the Palace**
  - Dialogue Asset: `Sordland/Turn08/A_AffairMeeting`
  - Map Token: `Sordland_City_Holsord`

#### Step 7
- **`Turn08_A_InvestigationResults`** `[Conversation]`
  - Title: **Results of the Affair Scandal**
  - Dialogue Asset: `Sordland/Turn08/A_InvestigationResults`
  - Map Token: `Sordland_City_Holsord`
- **`Turn08_A_PoliticsBillsBriefing`** `[Conversation]`
  - Title: **Political Briefing Meeting**
  - Dialogue Asset: `Sordland/Turn08/PoliticsBillsBriefing`
  - Map Token: `Sordland_City_Holsord`

#### Step 8
- **`Turn08_A_PressRelease`** `[Conversation]`
  - Title: **Press Release for the Affair Scandal**
  - Dialogue Asset: `Sordland/Turn08/A_PressRelease`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_PressRelease == true`
- **`Turn08_A_LiviaPetrGone`** `[Conversation]`
  - Title: **Updates on the Situation Around Affair Scandal**
  - Dialogue Asset: `Sordland/Turn08/A_LiviaPetrGone`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_LiviaPetrGone == true`

#### Step 9
- **`Turn08_A_WomensRightsMeeting`** `[Conversation]`
  - Title: **Briefing on the Women's Rights Situation**
  - Dialogue Asset: `Sordland/Turn08/A_WomensRightsMeeting`
  - Map Token: `Sordland_City_Holsord`
- **`Turn08_A_VPSelection`** `[Conversation]`
  - Title: **Selection of a New Vice President**
  - Dialogue Asset: `Sordland/Turn08/A_VPSelection`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_VPSelection == true`
- **`Turn08_Decision_Penalty_USPObstructionist`** `[Decision]`
  - Title: **USP Apparatus Obstructs**
  - Condition: `BaseGame.Faction_USP_Obstructionist == true`

#### Step 10
- **`Turn08_Decision_LeagueOfWomenDonation`** `[Decision]`
  - Title: **Sordish League of Women Donation**
  - Condition: `BaseGame.Enable_LeagueOfWomenDonation == true`
- **`Turn08_Decision_VPSelection`** `[Decision]`
  - Title: **Vice President Selection**
  - Condition: `BaseGame.Enable_VPSelection == true`

#### Step 11
- **`Turn08_A_NewVPIntroduction`** `[Conversation]`
  - Title: **Start of the Day at the Palace**
  - Dialogue Asset: `Sordland/Turn08/A_NewVPIntroduction`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_VPSelection == true`

#### Step 12
- **`Turn08_SnO_GendarmerieDispute`** `[Conversation]`
  - Title: **Mediation of a Dispute in Gendarmerie**
  - Dialogue Asset: `Sordland/Turn08/SnO_GendarmerieDispute`
  - Map Token: `Sordland_City_Vesord`

#### Step 13
- **`Turn08_SnO_EstordRaid`** `[Conversation]`
  - Title: **Updates on the Situation of Oligarchs**
  - Dialogue Asset: `Sordland/Turn08/SnO_EstordRaid`
  - Map Token: `Sordland_City_Estord`
  - Condition: `BaseGame.Enable_EstordRaid == true`
- **`Turn08_Bill_DisabilityBenefit`** `[SystemFragment/Other]`

#### Step 14
- **`Turn08_PSnW_HealthOverviewAndPandemic`** `[Conversation]`
  - Title: **Briefing on the Current Healthcare Situation**
  - Dialogue Asset: `Sordland/Turn08/PSnW_HealthOverviewAndPandemic`
  - Map Token: `Sordland_City_Holsord`

#### Step 15
- **`Turn08_Bill_TobaccoTax`** `[SystemFragment/Other]`
- **`Turn08_Decision_IronLung`** `[Decision]`
  - Title: **Buy Iron Lung**
  - Condition: `BaseGame.Enable_IronLungDecision == true`
- **`Turn08_Decision_HealthcareSpending`** `[Decision]`
  - Title: **Healthcare Spending**
  - Condition: `BaseGame.Enable_HealthcareSpendingDecision == true`
- **`Turn08_Personal_FamilyScene`** `[Conversation]`
  - Title: **Meeting with the Family**
  - Dialogue Asset: `Sordland/Turn08/Personal_FamilyScene`
  - Map Token: `Sordland_City_Holsord`

#### Step 16
- **`Turn08_Decision_AschrafRequest`** `[Decision]`
  - Title: **Aschraf Anniversary Request**
  - Condition: `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`

#### Step 17
- **`Turn08_Decision_AschrafSupport`** `[Decision]`
  - Title: **Support Aschraf Anniversary?**
  - Condition: `(BaseGame.Reform_EmergencyDecree_SuspendedProtests == false &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true) == true || BaseGame.Decision_Turn05_AutocratEmergency_Extend == false ||
BaseGame.Decision_Turn08_AschrafRequest_Allow == true`

#### Step 18
- **`Turn08_A_AschrafAnniversary`** `[Conversation]`
  - Title: **Solidarity for Watani Aschraf's Anniversary**
  - Dialogue Asset: `Sordland/Turn08/A_AschrafAnniversary`
  - Map Token: `Sordland_City_Erzaren`
  - Condition: `BaseGame.Decision_Turn08_AschrafSupport_Go == true || 
BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`

#### Step 19
- **`Turn08_A_PoliticalOverview2`** `[Conversation]`
  - Title: **Briefing on the Current Political Situation**
  - Dialogue Asset: `Sordland/Turn08/A_PoliticalOverview2`
  - Map Token: `Sordland_City_Holsord`

#### Step 20
- **`Turn08_A_UnrestMeeting`** `[Conversation]`
  - Title: **Briefing on the Increasing Unrest Among Populace**
  - Dialogue Asset: `Sordland/Turn08/A_UnrestMeeting`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_UnrestMeeting == true`
- **`Turn08_Decision_SecondAid_Arcasia`** `[Decision]`
  - Title: **Arcasia Offers Military Investment Aid**
  - Condition: `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Policy_Diplomacy_Lespia_Alliance == true`
- **`Turn08_Decision_SecondAid_UnitedContana`** `[Decision]`
  - Title: **United Contana Offers Agricultural Investment Aid**
  - Condition: `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`

#### Step 21
- **`Turn08_Bill_HarsherSecurity`** `[SystemFragment/Other]`
- **`Turn08_Decision_IndustrialExpansion`** `[Decision]`
  - Title: **Industrial Expansion**
  - Condition: `BaseGame.Enable_IndustrialExpansionDecision == true`
- **`Turn08_Decision_Penalty_StabilityDrop`** `[Decision]`
  - Title: **The Great Dissent**
  - Condition: `BaseGame.Situation_Order_Nationwide_Revolt == true`
- **`Turn08_Decision_Penalty_LaborMarketCollapse`** `[Decision]`
  - Title: **Labor Market Collapse Drags Output**
  - Condition: `BaseGame.Economy <= 11 && BaseGame.Policy_Welfare_EducationPrivatization == true && BaseGame.Policy_Welfare_HealthPrivatization == true && (BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true) && ((BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3) ||(BaseGame.Policy_Order_PrivatePrisons == true || BaseGame.Gasom_Ownership_PrivatelyOwned == true) ||(BaseGame.Policy_Welfare_DecreasedEducationFunding == true || BaseGame.Policy_Welfare_DecreasedHealthFunding == true))`

#### Step 22
- **`Turn08_Decision_ExtendEmergency`** `[Decision]`
  - Title: **Extend Emergency**
  - Condition: `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true &&
BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **`Turn08_Decision_Penalty_UnrulyGenerals`** `[Decision]`
  - Title: **Communication Breakdown with Military**
  - Condition: `BaseGame.Situation_Military_UnrulyGeneral == true`

### Turn 9

#### Step 1
- **`Turn09_Bill_WomensRights`** `[SystemFragment/Other]`
- **`Turn09_Bill_StrongWomensRights`** `[SystemFragment/Other]`
- **`Turn09_Decision_Bonus_TermSurplus`** `[Decision]`
  - Title: **Fiscal Review Reveals Treasury Surplus**
  - Condition: `BaseGame.FiscalReview_Surplus == true`
- **`Turn09_Decision_Bonus_TermDeficit`** `[Decision]`
  - Title: **Fiscal Review Reveals Treasury Deficit**
  - Condition: `BaseGame.FiscalReview_Deficit == true`

#### Step 2
- **`Turn09_Personal_FrancCalls`** `[Conversation]`
  - Title: **End of Day at the Home**
  - Dialogue Asset: `Sordland/Turn09/Personal_FrancCalls`
  - Map Token: `Sordland_City_Holsord`

#### Step 3
- **`Turn09_Bill_BanProstitution`** `[SystemFragment/Other]`
- **`Turn09_Bill_ChildBenefit`** `[SystemFragment/Other]`
- **`Turn09_Decision_Penalty_DebtCrash`** `[Decision]`
  - Title: **The Sordish Debt Debacle**
  - Condition: `BaseGame.Situation_Economy_DebtCrisis == true`
- **`Turn09_Decision_Penalty_CapitalFlight`** `[Decision]`
  - Title: **The Sordish Capital Flight Crisis**
  - Condition: `BaseGame.Situation_Economy_CapitalWithdrawals == true`

#### Step 4
- **`Turn09_A_Talks`** `[Conversation]`
  - Title: **Discussion on the Current Internal Affairs**
  - Dialogue Asset: `Sordland/Turn09/A_Talks`
  - Map Token: `Sordland_City_Holsord`

#### Step 5
- **`Turn09_Bill_BludishCommission`** `[SystemFragment/Other]`
- **`Turn09_Bill_LighterSecurity`** `[SystemFragment/Other]`

#### Step 6
- **`Turn09_Bill_AlcoholTax`** `[SystemFragment/Other]`
- **`Turn09_Bill_LuxuryTax`** `[SystemFragment/Other]`
- **`Turn09_Decision_FundPoliticalGroup`** `[Decision]`
  - Title: **Fund Political Youth Group**
  - Condition: `BaseGame.Enable_FundPoliticalGroup == true`

#### Step 7
- **`Turn09_Decision_RumburgPeaceSummit`** `[Decision]`
  - Title: **Rumburg Reparations Proposal**
  - Condition: `BaseGame.Enable_RumburgPeaceSummit == true`

#### Step 8
- **`Turn09_A_KorontiLead`** `[Conversation]`
  - Title: **Briefing on the Marcel Koronti Investigation**
  - Dialogue Asset: `Sordland/Turn09/A_KorontiLead`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **`Turn09_SnO_RumburgIncident`** `[Conversation]`
  - Title: **Emergency Call on an Escalating Situation**
  - Dialogue Asset: `Sordland/Turn09/SnO_RumburgIncident`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_RumburgIncident == true && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false`

#### Step 9
- **`Turn09_FPnT_Preparations`** `[Conversation]`
  - Title: **Urgent Meeting on Potential Alliances**
  - Dialogue Asset: `Sordland/Turn09/FPnT_Preparations`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_Preparations == true`

#### Step 10
- **`Turn09_FPnT_ArcasiaVisit`** `[Conversation]`
  - Title: **State Visit of President Walker**
  - Dialogue Asset: `Sordland/Turn09/FPnT_ArcasiaVisit`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Arcasia_AcceptedVisit == true`
- **`Turn09_FPnT_UnitedContanaVisit`** `[Conversation]`
  - Title: **State Visit of Chairman Malenyev**
  - Dialogue Asset: `Sordland/Turn09/FPnT_UnitedContanaVisit`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.UnitedContana_AcceptedVisit == true`

#### Step 11
- *OnStepStart:* `AnalyticsEvent("Analytics_Sordland_Superpowers");`
- **`Turn09_Personal_PetrGoesMissing`** `[Conversation]`
  - Title: **Call with Evelyn Vectern**
  - Dialogue Asset: `Sordland/Turn09/Personal_PetrGoesMissing`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_PetrGoesMissing == true`

#### Step 12
- **`Turn09_Decision_PetrFuneral`** `[Decision]`
  - Title: **Petr Vectern's Funeral**
  - Condition: `BaseGame.Enable_PetrGoesMissing == true`

#### Step 13
- **`Turn09_Personal_PetrFuneral`** `[Conversation]`
  - Title: **Funeral of Petr Vectern**
  - Dialogue Asset: `Sordland/Turn09/Personal_PetrFuneral`
  - Map Token: `Sordland_City_Erlory`
  - Condition: `BaseGame.Enable_PetrGoesMissing == true`

#### Step 14
- **`Turn09_Personal_MonicaFinalTalk`** `[Conversation]`
  - Title: **Late Night at Rayne Household**
  - Dialogue Asset: `Sordland/Turn09/Personal_MonicaFinalTalk`
  - Map Token: `Sordland_City_Holsord`

#### Step 15
- **`Turn09_Decision_CampaignAdvertisement`** `[Decision]`
  - Title: **Rayne 57' Campaign Advertisement**
  - Condition: `BaseGame.Enable_CampaignAdvertisement == true`
- **`Turn09_A_SollTrial`** `[Conversation]`
  - Title: **Trial of Tarquin Soll**
  - Dialogue Asset: `Sordland/Turn09/A_SollTrial`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_SollTrial == true`
- **`Turn09_Bill_FreeTransportation`** `[SystemFragment/Other]`

#### Step 16
- **`Turn09_A_CampaignAndInvestigations`** `[Conversation]`
  - Title: **Election Speech at the USP HQ**
  - Dialogue Asset: `Sordland/Turn09/A_CampaignAndInvestigations`
  - Map Token: `Sordland_City_Anrica`

#### Step 17
- **`Turn09_EnT_EconomicOverviewAndAction`** `[Conversation]`
  - Title: **Briefing on the Current Economic Situation**
  - Dialogue Asset: `Sordland/Turn09/EnT_EconomicOverviewAndAction`
  - Map Token: `Sordland_City_Holsord`

#### Step 18
- **`Turn09_A_TelevisionInterview`** `[Conversation]`
  - Title: **Scheduled Television Interview**
  - Dialogue Asset: `Sordland/Turn09/A_TelevisionInterview`
  - Map Token: `Sordland_City_Lachaven`
- **`Turn09_Decision_Penalty_SordishDepression`** `[Decision]`
  - Title: **Sordish Great Depression**
  - Condition: `BaseGame.Turn09_EnT_SordishDepression == true`

#### Step 19
- **`Turn09_A_LeakedScandal`** `[Conversation]`
  - Title: **Early Morning at Rayne Household**
  - Dialogue Asset: `Sordland/Turn09/A_LeakedScandal`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_LeakedScandals == true`

#### Step 20
- **`Turn09_A_LileasDiscussion`** `[Conversation]`
  - Title: **Private Meeting with Lileas Graf**
  - Dialogue Asset: `Sordland/Turn09/A_LileasDiscussion`
  - Map Token: `Sordland_City_Arvory`
  - Condition: `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == false`
- **`Turn09_A_LileasPrisonVisit`** `[Conversation]`
  - Title: **Private Meeting with Lileas Graf**
  - Dialogue Asset: `Sordland/Turn09/A_LileasPrisonVisit`
  - Map Token: `Sordland_City_Antel`
  - Condition: `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true`

#### Step 21
- **`Turn09_SnO_MilitaryParade`** `[Conversation]`
  - Title: **Military Parade**
  - Dialogue Asset: `Sordland/Turn09/SnO_MilitaryParade`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.RumburgIncident_MilitaryParade == true`

### Turn 10

#### Step 1
- **`Turn10_Personal_SergeFuneral`** `[Conversation]`
  - Title: **Funeral of Serge Wolkner**
  - Dialogue Asset: `Sordland/Turn10/Personal_SergeFuneral`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_SergeFuneral == true`

#### Step 2
- **`Turn10_FCAnricaMatch`** `[Conversation]`
  - Title: **Merkopan Champions Cup**
  - Dialogue Asset: `Sordland/Turn10/Personal_FCAnricaDerby`
  - Map Token: `Sordland_City_Anrica`
  - Condition: `BaseGame.RumburgIncident_DeclareWar == false`

#### Step 3
- **`Turn10_FPnT_AllianceOfNations`** `[Conversation]`
  - Title: **Alliance of Nations Assembly Meeting**
  - Dialogue Asset: `Sordland/Turn10/FPnT_AllianceOfNations`
  - Map Token: `Sordland_Country_Kyrute`

#### Step 4
- **`Turn10_Decision_MovePersonalWealth`** `[Decision]`
  - Title: **Move Personal Wealth to Kyrute**
  - Condition: `BaseGame.Enable_MovePersonalWealth == true`

#### Step 5
- **`Turn10_FPnT_QueenPhoneCall`** `[Conversation]`
  - Title: **Phone Call with Queen of Rumburg**
  - Dialogue Asset: `Sordland/Turn10/FPnT_QueenPhoneCall`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_QueenPhoneCall == true`

#### Step 6
- **`Turn10_A_DeividFinalTalk`** `[Conversation]`
  - Title: **Private Meeting with Deivid Wisci**
  - Dialogue Asset: `Sordland/Turn10/A_DeividFinalTalk`
  - Map Token: `Sordland_City_Holsord`

#### Step 7
- **`Turn10_A_Resignations`** `[Conversation]`
  - Title: **Friday Afternoon in the Office**
  - Dialogue Asset: `Sordland/Turn10/A_Resignations`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_Resignations == true`

#### Step 8
- **`Turn10_A_Congress`** `[Conversation]`
  - Title: **United Sordland Party Congress**
  - Dialogue Asset: `Sordland/Turn10/A_Congress`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_Congress == true`

#### Step 9
- **`Turn10_Personal_FinalSupper`** `[Conversation]`
  - Title: **Dinner at Home**
  - Dialogue Asset: `Sordland/Turn10/Personal_FinalSupper`
  - Map Token: `Sordland_City_Holsord`

#### Step 10
- **`Turn10_Decision_Term2Focus`** `[Decision]`
  - Title: **Main Focus of Our Election Campaign**
  - Condition: `BaseGame.Enable_Debate == true`
- **`Turn10_SnO_CoupNight`** `[Conversation]`
  - Title: **Two Minutes to Midnight**
  - Dialogue Asset: `Sordland/Turn10/SnO_CoupNight`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_CoupNight == true`

#### Step 11
- **`Turn10_A_Debate`** `[Conversation]`
  - Title: **Presidential Debate**
  - Dialogue Asset: `Sordland/Turn10/A_Debate`
  - Map Token: `Sordland_City_Lachaven`
  - Condition: `BaseGame.Enable_Debate == true`
- **`Turn10_SnO_RumburgWarPlans`** `[Conversation]`
  - Title: **Rumburg War Planning Meeting**
  - Dialogue Asset: `Sordland/Turn10/SnO_RumburgWarPlans`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_RumburgWarPlans == true`

#### Step 12
- **`Turn10_SnO_RumburgWarSpeech`** `[Conversation]`
  - Title: **Declaration of War against Rumburg**
  - Dialogue Asset: `Sordland/Turn10/SnO_RumburgWarSpeech`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Enable_RumburgWarPlans == true`

### Turn 11

#### Step 1
- **`Turn_Endings_SnO_WorldWar`** `[Conversation]`
  - Title: **Briefing on the Status of Rumburg War**
  - Dialogue Asset: `Sordland/Turn11/SnO_WorldWar`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_WorldWar == true`
- **`Turn_Endings_SnO_RumburgWarLost`** `[Conversation]`
  - Title: **Battle of Holsord**
  - Dialogue Asset: `Sordland/Turn11/SnO_RumburgWarLost`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_RumburgWarLost == true`
- **`Turn_Endings_SnO_RumburgWarWin`** `[Conversation]`
  - Title: **Capitulation of Rumburg**
  - Dialogue Asset: `Sordland/Turn11/SnO_RumburgWarWin`
  - Map Token: `Sordland_City_Estord`
  - Condition: `BaseGame.Ending_RumburgWarWin == true`
- **`Turn_Endings_SnO_CoupTrial`** `[Conversation]`
  - Title: **Waiting for the Day of Trial**
  - Dialogue Asset: `Sordland/Turn11/SnO_CoupTrial`
  - Map Token: `Sordland_City_Antel`
  - Condition: `BaseGame.Ending_Coup == true`
- **`Turn_Endings_A_ImpeachmentTrial`** `[Conversation]`
  - Title: **Impeachment Trial of Anton Rayne**
  - Dialogue Asset: `Sordland/Turn11/A_ImpeachmentTrial`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_ImpeachmentTrial == true`
- **`Turn_Endings_Personal_Retirement`** `[Conversation]`
  - Title: **Announcement of Retirement**
  - Dialogue Asset: `Sordland/Turn11/Personal_Retirement`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_Retirement == true`
- **`Turn_Endings_Personal_Exile`** `[Conversation]`
  - Title: **Escape from Holsord**
  - Dialogue Asset: `Sordland/Turn11/Personal_Exile`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_Exile == true`

#### Step 2
- **`Turn_Endings_A_ElectionSpeech`** `[Conversation]`
  - Title: **Election Speech**
  - Dialogue Asset: `Sordland/Turn11/A_ElectionSpeech`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_ElectionSpeech == true && BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **`Turn_Endings_A_ElectionSpeech_MaroonSquare`** `[Conversation]`
  - Title: **Election Speech**
  - Dialogue Asset: `Sordland/Turn11/A_ElectionSpeech`
  - Map Token: `Sordland_City_Holsord`
  - Condition: `BaseGame.Ending_ElectionSpeech == true && BaseGame.Reform_PresiPower_Default_DeSollinisation == true`

## StoryPack: `StoryPack_Rizia`

### Turn 1

#### Step 1
- **`Turn01_Start_Coronation`** `[Conversation]`
  - Title: **Coronation**
  - Dialogue Asset: `Rizia/Turn 1/Start_Coronation`
  - Map Token: `Rizia_City_PorteDrazon`

#### Step 2
- *OnStepStart:* `EnableNews("Turn01_G_Contana_ICBMTest");`
- **`Turn01_P_FamilyIntroduction`** `[Conversation]`
  - Title: **Early Morning At Palas Rezna**
  - Dialogue Asset: `Rizia/Turn 1/P_FamilyIntroduction`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn01_Decision_CoronationCelebrations`** `[Decision]`
  - Title: **Coronation Celebrations**

#### Step 3
- *OnStepStart:* `EnableNews("Turn01_G_Arcasia_SouthXinaConflict");`
- **`Turn01_A_TorasPoliticalOverview`** `[Conversation]`
  - Title: **Political Overview with the Grand Vizier**
  - Dialogue Asset: `Rizia/Turn 1/A_TorasPoliticalOverview`
  - Map Token: `Rizia_City_PorteDrazon`
  - OnEnd: `RiziaDLC.Panel_RoyalDecrees = true`

#### Step 4
- **`Turn01_EnT_CouncilBriefing`** `[Conversation]`
  - Title: **Introductory Briefing from the Royal Council**
  - Dialogue Asset: `Rizia/Turn 1/EnT_CouncilBriefing`
  - Map Token: `Rizia_City_PorteDrazon`

#### Step 5
- *OnStepStart:* `EnableNews("Turn01_G_Contana_IncidentFSRSlovarya");`
- **`Turn01_A_ReligiousCeremony`** `[Conversation]`
  - Title: **Consecration of the King**
  - Dialogue Asset: `Rizia/Turn 1/A_ReligiousCeremony`
  - Map Token: `Rizia_City_Plavo`
- **`Turn01_Decision_RoyaltyConcertEvent`** `[Decision]`
  - Title: **Arrange a Classical Concert for the Noble Houses**
  - Condition: `RiziaDLC.Resources_Budget >= 2`

#### Step 6
- *OnStepStart:* `EnableNews("Turn01_G_CSP_GalmlandDemandsStraitRights");`
- **`Turn01_SnO_SecurityMilitaryBriefing`** `[Conversation]`
  - Title: **Briefing on the Current Security Situation**
  - Dialogue Asset: `Rizia/Turn 1/SnO_SecurityMilitaryMeeting`
  - Map Token: `Rizia_City_FolceDator`
  - OnEnd: `SetupAndShowTutorialPanel("WarProduction_Tutorial_Panel");`

#### Step 7
- *OnStepStart:* `EnableNews("Turn01_G_Rumburg_ErdmargPeace");`
- **`Turn01_Decision_InvestInRizianFootballFederation`** `[Decision]`
  - Title: **Investing in the Rizian Football Federation**
  - Condition: `RiziaDLC.Resources_Budget >= 1`
  - OnEnd: `SetRichPresence("Kicking around the future of Rizian football", "Palace Rezna", "Porte Drazon");`

### Turn 2

#### Step 1
- *OnStepStart:* `EnableNews("Turn02_G_CSP_StrategicControlOverStraits");
EnableReport("Turn02_Sallabes_AntiNarcotics_Alliance");`
- **`Turn02_FPnT_DiplomacyBriefing`** `[Conversation]`
  - Title: **Council Meeting on Foreign Relations**
  - Dialogue Asset: `Rizia/Turn 2/FPnT_DiplomacyBriefing`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn02_Decision_NelvisarFieldShutsDown_Penalty`** `[Decision]`
  - Title: **Nelvisar Oil Field Closure**
  - OnEnd: `RiziaDLC.Policy_Economy_NelvisarOilField = false;
RiziaDLCSupport.Reports_Turn02_Nelvisar_Decision_NelvisarFieldShutsDown_OilWorkerCommemoration = true;
RiziaDLC.Situation_Economy_NelvisarOilField_LowExtractionVolume = false;
RiziaDLC.Situation_Economy_NelvisarOilField_Depleted = true;
RiziaDLCSupport.Codex_Locations_Cities_Nelvisar = false;
RiziaDLCSupport.Codex_Locations_Cities_Nelvisar_OilDepleted = true;`

#### Step 2
- *OnStepStart:* `EnableNews("Turn02_G_AN_NonAlignedMovementGrows");
EnableNews("Turn02_G_Vendonesam_DemocraticForces");`
- **`Turn02_Decision_IncludeWernerTrade`** `[Decision]`
  - Title: **Bring Elena to Sordland Trade Discussion**

#### Step 3
- *OnStepStart:* `EnableNews("Turn02_G_Anraka_TradeWithNalipurnaOstioke");
EnableNews("Turn02_G_Arcasia_AntiImperialistProtests");`
- **`Turn02_FPnT_SordlandTradeVisit`** `[Conversation]`
  - Title: **Visit from the Sordland Trade Delegation**
  - Dialogue Asset: `Rizia/Turn 2/FPnT_SordlandTradeVisit`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn02_Decision_EsqirisFieldRunningOut_PenaltyWarning`** `[Decision]`
  - Title: **Esqiris Gas Field Reserves Alert**
  - Condition: `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == false`

#### Step 4
- *OnStepStart:* `EnableNews("Turn02_G_Contana_SouthProtestsQuelled");`
- **`Turn02_P_VinaTalk`** `[Conversation]`
  - Title: **Conversation with Vina**
  - Dialogue Asset: `Rizia/Turn 2/P_VinaAtMonqiz`
  - Map Token: `Rizia_City_Monqiz`
- **`Turn02_Decision_FamilyStatues`** `[Decision]`
  - Title: **Commission Toras Family Statues**
  - Condition: `RiziaDLC.Resources_Authority >= 1 || RiziaDLC.Resources_Budget >= 1`
- **`Turn02_Decision_OrganizedCrime_PenaltyWarning`** `[Decision]`
  - Title: **Law Enforcement Losing Grip in Districts**
  - Condition: `RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Order_DrugTrade_Persisting == true`
  - OnEnd: `RiziaDLC.Decision_Floating_OrganizedCrime_PenaltyWarning = true`

#### Step 5
- *OnStepStart:* `EnableNews("Turn02_G_ATO_WalkerPlanGrowthCentralMerkopa");
EnableNews("Turn02_G_Rumburg_ParliamentaryFactionForms");`
- **`Turn02_SnO_TitusGoldenGuard`** `[Conversation]`
  - Title: **Private Audience with Golden Guard**
  - Dialogue Asset: `Rizia/Turn 2/SnO_TitusGoldenGuard`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn02_Decision_SaveArufeldeOrg`** `[Decision]`
  - Title: **Save the Arufelde**
  - Condition: `RiziaDLC.Resources_Budget >= 2`
- **`Turn02_Decision_BanMalenyevistPropaganda`** `[Decision]`
  - Title: **Revolutionary Propaganda Ban**

#### Step 6
- *OnStepStart:* `EnableNews("Turn02_G_Contana_ReligiousGroupsFlee");
EnableNews("Turn02_RH_Gossip_CarlosFlirting")`
- **`Turn02_FPnT_ZilleFriendshipDay`** `[Conversation]`
  - Title: **Wehzek-Rizian Friendship Day**
  - Dialogue Asset: `Rizia/Turn 2/FPnT_ZilleVisit`
  - Map Token: `Rizia_Event_Zille`
- **`Turn02_Decision_ArmySpecialForcesDivisions`** `[Decision]`
  - Title: **Special Forces Division**
  - Condition: `RiziaDLC.Focus_MilitaryBranch_None == false &&  RiziaDLC.Resources_Budget >= 2`
  - OnEnd: `SetRichPresence("Forming new special forces divisions", "Folce Dator", "Montaklar");`

### Turn 3

#### Step 1
- *OnStepStart:* `EnableNews("Turn03_G_Arcasia_SouthXinaStruggle");`
- **`Turn03_SnO_ZilleIncidentBrief`** `[Conversation]`
  - Title: **Update on the Zille Incident**
  - Dialogue Asset: `Rizia/Turn 3/SnO_ZilleSecurityDebrief`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn03_Decision_ZilleBombDenounceSO`** `[Decision]`
  - Title: **Statement on the Zille Incident**
  - Condition: `RiziaDLC.ZilleSecurityDebriefFinished == true`
- **`Turn03_Decision_ZilleBombApology`** `[Decision]`
  - Title: **Apologize for Inflammatory Speech**
  - Condition: `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **`Turn03_Decision_OrganizedCrime_Penalty`** `[Decision]`
  - Title: **Organized Crime Undermines Local Control**
  - Condition: `RiziaDLC.Decision_Floating_OrganizedCrime_PenaltyWarning == true && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Order_DrugTrade_Persisting == true)`

#### Step 2
- *OnStepStart:* `EnableNews("Turn03_G_Lespia_CSPEncroachmentConcern");
EnableReport("Turn03_Sallabes_AidOfferForIza");`
- **`Turn03_FPnT_RumburgVisits`** `[Conversation]`
  - Title: **Visit from Queen Beatrice of Rumburg**
  - Dialogue Asset: `Rizia/Turn 3/FPnT_QueenBeatriceVisit`
  - Map Token: `Rizia_City_PorteDrazon`

#### Step 3
- *OnStepStart:* `EnableNews("Turn03_G_CSP_InvestsInNibiya");
EnableNews("Turn03_G_Contana_DenouncesForeignMeddling");`
- **`Turn03_A_IzaVisit`** `[Conversation]`
  - Title: **Family Visit to Iza**
  - Dialogue Asset: `Rizia/Turn 3/A_VisitToIza`
  - Map Token: `Rizia_City_Iza`
- **`Turn03_Decision_DiplomaticEnvoyChoice`** `[Decision]`
  - Title: **Send Diplomatic Envoy to Improve Relations**
  - Condition: `RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Resources_Budget >= 1`

#### Step 4
- *OnStepStart:* `EnableNews("Turn03_G_Contana_GeopoliticoMonitored");
EnableReport("Turn03_Montaklar_KingsVisit");`
- **`Turn03_A_SallabesVisit`** `[Conversation]`
  - Title: **Royal Visit to the Scarlet Kingbird Festival**
  - Dialogue Asset: `Rizia/Turn 3/A_VisitToSallabes`
  - Map Token: `Rizia_City_Sallabes`
- **`Turn03_Decision_IzaPoliceTransfer`** `[Decision]`
  - Title: **Iza Police Transfer**

#### Step 5
- *OnStepStart:* `EnableNews("Turn03_G_Arcasia_WalkerIncreasesWelfare");`
- **`Turn03_PSnW_RustyMeeting`** `[Conversation]`
  - Title: **Meeting With Rusty Montoro**
  - Dialogue Asset: `Rizia/Turn 3/EnT_ElenaRustyMeeting`
  - Map Token: `Rizia_City_Bronaz`
- **`Turn03_Decision_GolcondistPilgrimsAccess`** `[Decision]`
  - Title: **Golcondist Pilgrims Demand Access at Morella Border**
  - Condition: `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **`Turn03_Decision_LowPopularity_PenaltyWarning`** `[Decision]`
  - Title: **Rumblings from the Streets and Taverns**
  - Condition: `RiziaDLC.Country_PublicOpinion <= -2`
  - OnEnd: `RiziaDLC.Decision_Floating_LowPopularity_PenaltyWarning = true`

#### Step 6
- *OnStepStart:* `EnableNews("Turn03_G_Erdmarg_NonAlignedMovement");`
- **`Turn03_A_CardesseMontaklarVisit`** `[Conversation]`
  - Title: **Royal Visit to Montaklar**
  - Dialogue Asset: `Rizia/Turn 3/A_VisitToMontaklar`
  - Map Token: `Rizia_City_Montaklar`
- **`Turn03_Decision_FootballIndustryFalling_PenaltyWarning`** `[Decision]`
  - Title: **Football Industry Shows Signs of Stagnation**
  - Condition: `RiziaDLC.Policy_RD_Economy_InvestInFootballInfrastructure == false && RiziaDLC.Decision_Turn01_InvestInRizianFootball_None == true`
  - OnEnd: `RiziaDLCSupport.Reports_Turn03_Valenqir_Decision_FootballIndustryFalling = true;`
- **`Turn03_Decision_BrokenTraditions_PenaltyWarning`** `[Decision]`
  - Title: **Insinuations In the Palace Halls**
  - Condition: `RiziaDLC.PersonalValue_BrokeTradition >= 2`
  - OnEnd: `RiziaDLC.Decision_Floating_BrokenTraditions_PenaltyWarning = true`

#### Step 7
- *OnStepStart:* `EnableNews("Turn03_G_Sordland_RecessionOf51Begins");`
- **`Turn03_Decision_ProvincialTaxSubsidy`** `[Decision]`
  - Title: **Provincial Tax Subsidy**
  - Condition: `RiziaDLC.Resources_Budget >= 2`
  - OnEnd: `SetRichPresence("Deciding on subsidies for their kingdom’s provinces", "Palace Rezna", "Porte Drazon");`

### Turn 4

#### Step 1
- *OnStepStart:* `EnableNews("Turn04_G_ATO_LespiaMaintainsTariffs");
EnableReport("Turn04_CSP_CondemnsRavnosMilitarization");`
- **`Turn04_FPnT_CouncilTalkAboutPales`** `[Conversation]`
  - Title: **Council Meeting on Pales Gas Dispute**
  - Dialogue Asset: `Rizia/Turn 4/A_CouncilTalkAboutPales`
  - Map Token: `Rizia_City_FortAles`
- **`Turn04_Decision_ReactToWelfareProtestors`** `[Decision]`
  - Title: **React To Welfare Protestors**
  - Condition: `RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == false`
  - OnEnd: `RiziaDLC.Protests_Welfare_Happened = true;
SetRichPresence("Facing angry crowds", "Palace Toras", "Monqiz");`
- **`Turn04_Decision_BrokenTraditions_Penalty`** `[Decision]`
  - Title: **Tradition No Longer Taken for Granted**
  - Condition: `RiziaDLC.Decision_Floating_BrokenTraditions_PenaltyWarning == true && RiziaDLC.PersonalValue_BrokeTradition >= 3 && RiziaDLC.Reform_Path == false && RiziaDLC.HouseElections_RNCWinsSeats == false`
- **`Turn04_Decision_LowPopularity_Penalty`** `[Decision]`
  - Title: **Support for the Crown Wanes**
  - Condition: `RiziaDLC.Decision_Floating_LowPopularity_PenaltyWarning == true && RiziaDLC.Country_PublicOpinion <= -3 || (RiziaDLC.Situation_Order_MultiProvincialProtest == true || RiziaDLC.Situation_Order_LargeProvincialProtest == true || RiziaDLC.Situation_Order_ViolentProtests_RiziaImperii == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Religious_Grows == true || RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)`

#### Step 2
- *OnStepStart:* `EnableNews("Turn04_G_Arcasia_PhyrricVictorySouthXina");`
- **`Turn04_FPnT_PalesDukeVisit`** `[Conversation]`
  - Title: **Meeting with Duke Reinhart**
  - Dialogue Asset: `Rizia/Turn 4/FPnT_PalesDukeVisit`
  - Map Token: `Rizia_Country_Pales`
- **`Turn04_Decision_VendonesamAidRequest`** `[Decision]`
  - Title: **Confederacy of Vendonesam Requests Support in Uprising**
- **`Turn04_Decision_EastTradeReduced_PenaltyWarning`** `[Decision]`
  - Title: **CSP Deliveries Slowing**
  - Condition: `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == false &&
RiziaDLC.Trait_CommieKing == false && ((RiziaDLC.CountryRelation_Valgsland_Hostile == true || RiziaDLC.CountryRelation_Valgsland_Unfriendly == true) &&(RiziaDLC.Situation_Order_Revolutionaries_Dangerous == true || RiziaDLC.CountryRelation_Morella_Hostile == true || RiziaDLC.CountryRelation_Morella_Unfriendly == true))`
  - OnEnd: `RiziaDLC.Decision_Floating_EastTradeReduced_PenaltyWarning = true`

#### Step 3
- *OnStepStart:* `EnableNews("Turn04_G_CSP_MissilesStationedSonsamia");`
- **`Turn04_FPnT_AlvarezCall`** `[Conversation]`
  - Title: **Call With Prime Minister Alvarez**
  - Dialogue Asset: `Rizia/Turn 4/FPnT_AlvarezCall`
  - Map Token: `Rizia_City_Monqiz`
- **`Turn04_Decision_HouseOfDelegates_Attend`** `[Decision]`
  - Title: **Attend House of Delegates Session**

#### Step 4
- *OnStepStart:* `EnableNews("Turn04_G_Arcasia_SendsAidFreeCities");
EnableNews("Turn04_G_OMECReportOnEastMerkopa");`
- **`Turn04_A_HouseOfDelegates`** `[Conversation]`
  - Title: **Visiting the House of Delegates**
  - Dialogue Asset: `Rizia/Turn 4/A_HouseOfDelegates`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == true`
- **`Turn04_Decision_GRACETradeWeakens_Penalty`** `[Decision]`
  - Title: **Tackling GRACE Trade Decline**
  - Condition: `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == false && RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == false && RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == false`
  - OnEnd: `RiziaDLC.GRACETrade_Weakened = true;
RiziaDLC.Authority_Modifier_RumburgianBond -= 2;
RiziaDLC.Budget_Modifier_GRACETradeSurplus -= 1;
RiziaDLCSupport.Reports_Turn04_Rumburg_Decision_GraceTradeWeakens = true;
RiziaDLCSupport.FactionReports_Turn04_GRACE_CondemsTradeDecline = true;`
- **`Turn04_P_EstelaUpdate`** `[Conversation]`
  - Title: **Evening Conversation Queen-Mother Estela**
  - Dialogue Asset: `Rizia/Turn 4/P_EstelaUpdate`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn04_Decision_RRGStakeChange`** `[Decision]`
  - Title: **Rizian Royal Gold Stake Change**
  - Condition: `RiziaDLC.Turn04_EnableRRGStakeChange == true`

#### Step 5
- *OnStepStart:* `EnableNews("Turn04_G_CSP_HegelDivertsGalmlandTrade");`
- **`Turn04_Decision_WehlenIntelligence_Cooperate`** `[Decision]`
  - Title: **Request for Cooperation from Wehlen**
- **`Turn04_Decision_MalenyevistRevolutionaries_PenaltyWarning`** `[Decision]`
  - Title: **Border Guard Reports Mounting Concerns**
  - Condition: `RiziaDLC.Authority_Modifier_MalenyevistRevolutionaries <= -1`
  - OnEnd: `RiziaDLC.Decision_Floating_MalenyevistRevolutionaries_PenaltyWarning = true`

#### Step 6
- *OnStepStart:* `EnableReport("Turn04_Valenqir_ClimateConference");`
- **`Turn04_FPnT_ANSouthMerkopa`** `[Conversation]`
  - Title: **Alliance of Nations South Merkopa Session**
  - Dialogue Asset: `Rizia/Turn 4/FPnT_ANSouthMerkopa`
  - Map Token: `Rizia_Country_Kyrute`
- **`Turn04_Decision_GolcondistPilgrimsPlavo`** `[Decision]`
  - Title: **Golcondist Pilgrims Squat Plavo Sanctuary**
  - Condition: `RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage == true && RiziaDLC.Policy_Law_GolcondistBlasphemy == false`
- **`Turn04_Decision_WineExportsSoar`** `[Decision]`
  - Title: **Wine Exports Soar Amidst Trade Surge**
  - Condition: `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true && RiziaDLC.Situation_Economy_NewBusiness_Reduction == false && RiziaDLC.Situation_Economy_NewBusiness_Collapse == false && RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == false`
  - OnEnd: `RiziaDLC.Decision_Turn04_WineExportsSoar = true;
RiziaDLCSupport.News_Turn04_G_WineExports_Trade = true;
RiziaDLCSupport.News_Turn04_RH_WineExports_Tourists = true;
RiziaDLCSupport.Reports_Turn04_Topes_SordishTourists = true;
RiziaDLCSupport.Reports_Turn04_Monqiz_WineExport = true;`

#### Step 7
- *OnStepStart:* `EnableNews("Turn04_G_Qinal_KeyHubforATO");
EnableNews("Turn04_G_Arcasia_XinaTroopsPullBack");`
- **`Turn04_P_PabelLucitaRomance`** `[Conversation]`
  - Title: **"Romus The Red" Wine Launch Event**
  - Dialogue Asset: `Rizia/Turn 4/P_PabelLucitaRomance`
  - Map Token: `Rizia_City_Qalus`
- **`Turn04_Decision_PublicTransportationWeak_PenaltyWarning`** `[Decision]`
  - Title: **Public Transportation Inefficiency Crisis**
  - Condition: `RiziaDLC.Policy_RD_Economy_PublicTransportInfraInvestment == false && (RiziaDLC.Policy_RD_Economy_PublicRailTransportSubsidies == false && RiziaDLC.Policy_RD_Economy_PublicSeaTransportSubsidies == false)`
  - OnEnd: `RiziaDLCSupport.Reports_Turn04_Qalus_Decision_PublicTransportationWeak = true;
RiziaDLCSupport.News_Turn04_V_Decision_PublicTransportationWeak = true;`
- **`Turn04_Decision_XinaConflictEndsEnergyDrops_Penalty`** `[Decision]`
  - Title: **Energy Prices Drop as Xina Conflict Deescalates**
  - OnEnd: `RiziaDLC.Situation_Economy_GlobalEnergyPrice_High = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Average = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Low = true;`

#### Step 8
- *OnStepStart:* `EnableNews("Turn04_G_Xina_RiseOfTotalistMaximism");`
- **`Turn04_Decision_SordlandOffersInvestment`** `[Decision]`
  - Title: **Sordland Offers Investment Opportunity**
  - Condition: `RiziaDLC.Resources_Budget >= 2`
- **`Turn04_Decision_War_UpgradeProductionLinesOne`** `[Decision]`
  - Title: **Upgrade Military Production Lines**
  - Condition: `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed == true || RiziaDLC.Policy_RD_Order_FighterPlaneFactory_Completed == true`

#### Step 9
- *OnStepStart:* `EnableNews("Turn04_G_Xina_AntiCSPBulwark");`
- **`Turn04_FPnT_SordlandBondPurchase`** `[Conversation]`
  - Title: **Delegation Trip to Discuss Bond Offer**
  - Dialogue Asset: `Rizia/Turn 4/FPnT_SordlandBondPurchase`
  - Map Token: `Rizia_Country_Sordland`
  - Condition: `RiziaDLC.Decision_Turn04_AcceptedSordlandBondTalkOffer == true && RiziaDLC.Resources_Budget >= 1`

### Turn 5

#### Step 1
- *OnStepStart:* `EnableNews("Turn05_G_Arcasia_InvestsInAgard");
EnableNews("Turn05_G_Contana_MalenyevAgainstTotalism");`
- **`Turn05_FPnT_WehlenNegotiations`** `[Conversation]`
  - Title: **New Bilateral Agreement Discussions with Wehlen**
  - Dialogue Asset: `Rizia/Turn 5/FPnT_WehlenNegotiations`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn05_Decision_MalenyevistRevolutionaries_Penalty`** `[Decision]`
  - Title: **Revolutionary Activity Confirmed Inside Border**
  - Condition: `RiziaDLC.Decision_Floating_MalenyevistRevolutionaries_PenaltyWarning == true && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Trait_CommieKing == false && RiziaDLC.Reform_Movement_Leader_Adarfo == false && RiziaDLC.CountryRelation_Morella_Friendly == false && RiziaDLC.Decision_Turn09_ValgslandAid_Accepted == false`
- **`Turn05_Decision_EastTradeReduced_Penalty`** `[Decision]`
  - Title: **Reduced Trade from CSP Partners**
  - Condition: `RiziaDLC.Decision_Floating_EastTradeReduced_PenaltyWarning == true && RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == false &&
RiziaDLC.Trait_CommieKing == false && ((RiziaDLC.CountryRelation_Valgsland_Hostile == true || RiziaDLC.CountryRelation_Valgsland_Unfriendly == true) && (RiziaDLC.Situation_Order_Revolutionaries_Dangerous == true || RiziaDLC.CountryRelation_Morella_Hostile == true || RiziaDLC.CountryRelation_Morella_Unfriendly == true))`

#### Step 2
- *OnStepStart:* `EnableNews("Turn05_G_Arcasia_EconomicGrowthSlows");
EnableNews("Turn05_G_Arcasia_TracksUCSatellites");
EnableReport("Turn05_Montaklar_ArmsExhibitionInLespia");`
- **`Turn05_Decision_ZilleResistanceFunding`** `[Decision]`
  - Title: **Resistance Funding in Zille**

#### Step 3
- *OnStepStart:* `EnableNews("Turn05_G_Sordland_AntonRaynePresident");`
- **`Turn05_FPnT_MITZBoardMeeting`** `[Conversation]`
  - Title: **Gathering of the MITZ Board Member States**
  - Dialogue Asset: `Rizia/Turn 5/FPnT_MITZBoardMeeting`
  - Map Token: `Rizia_Country_Morella`
- **`Turn05_Decision_EsqirisFieldShutsDown_Penalty`** `[Decision]`
  - Title: **Esqiris Gas Field Decommissioning**
  - Condition: `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == false && RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == false`
  - OnEnd: `RiziaDLC.Policy_Economy_EsqirisGasField = false;
RiziaDLC.Situation_Economy_EsqirisGasField_AverageExtractionVolume = false;
RiziaDLC.Situation_Economy_EsqirisGasField_HighExtractionVolume = false;
RiziaDLCSupport.Reports_Turn05_Topes_Decision_EsqirisFieldShutsDown = true;`

#### Step 4
- *OnStepStart:* `EnableReport("Turn05_Montaklar_CarlosHomeVisit");
EnableNews("Turn05_RH_CarlosVisitsTaddeus");`
- **`Turn05_SnO_InternalSecurity`** `[Conversation]`
  - Title: **Meeting on Internal Security**
  - Dialogue Asset: `Rizia/Turn 5/SnO_InternalSecurity`
  - Map Token: `Rizia_City_Monqiz`
- **`Turn05_Decision_RNCElectionFundRequest`** `[Decision]`
  - Title: **RNC Requests Election Campaign Funds**
  - Condition: `RiziaDLC.Resources_Budget >= 1`
  - OnEnd: `RiziaDLC.Decision_Turn05_RNCElectionFund_Happened = true`
- **`Turn05_Decision_IzaSocialWelfareFunding`** `[Decision]`
  - Title: **Expand Iza Social Welfare Programs**
  - Condition: `RiziaDLC.Turn05_Security_IzaExpandSocialPrograms == true`

#### Step 5
- **`Turn05_SnO_TitusLucitaBriefing`** `[Conversation]`
  - Title: **An Evening at the Palace**
  - Dialogue Asset: `Rizia/Turn 5/SnO_TitusLucitaBriefing`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true`
- **`Turn05_Decision_FootballIndustryWeakens_Penalty`** `[Decision]`
  - Title: **Football Leagues' Quality Decline**
  - Condition: `RiziaDLC.Policy_RD_Economy_InvestInFootballInfrastructure == false && RiziaDLC.Decision_Turn01_InvestInRizianFootball_None == true`
  - OnEnd: `RiziaDLC.Resources_Budget -= 1;
RiziaDLC.Country_PublicOpinion -= 1;
RiziaDLC.Enable_Policy_RD_Economy_InvestInFootballInfrastructure = false;
RiziaDLCSupport.News_G_Turn05_Decision_FootballIndustryWeakens_LeagueRankingAnnounced = true;`

#### Step 6
- **`Turn05_FPnT_MITZHegelCall`** `[Conversation]`
  - Title: **Call from Chancellor Hegel**
  - Dialogue Asset: `Rizia/Turn 5/FPnT_MITZHegelCall`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn05_Decision_WestTradeReduced_PenaltyWarning`** `[Decision]`
  - Title: **ATO Clearance Delays**
  - Condition: `RiziaDLCSetup.CurrentTurn >= 6 && (RiziaDLC.CountryRelation_Lespia_Hostile == true || RiziaDLC.CountryRelation_Lespia_Unfriendly == true)`
  - OnEnd: `RiziaDLC.Decision_Floating_WestTradeReduced_PenaltyWarning = true`

#### Step 7
- **`Turn05_FPnT_MorellaNegotiations`** `[Conversation]`
  - Title: **Morella Trade Negotiations**
  - Dialogue Asset: `Rizia/Turn 5/FPnT_MorellaNegotiations`
  - Map Token: `Rizia_Country_Morella`

#### Step 8
- **`Turn05_FPnT_MorellaReturnFlight`** `[Conversation]`
  - Title: **On the Return Flight from Morella**
  - Dialogue Asset: `Rizia/Turn 5/FPnT_MorellaReturnFlight`
  - Map Token: `Rizia_City_Argno`
  - Condition: `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true ||RiziaDLC.MITZ_Nationalization_LargerShare == true ||RiziaDLC.MITZ_Renegotiation_LargerShare == true ||RiziaDLC.MITZ_Renegotiation_SmallerShare == true ||RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true ||RiziaDLC.MITZ_Renegotiation_SameShare == true`
- **`Turn05_Decision_GasomInvestOffer`** `[Decision]`
  - Title: **Alphonso Facilitates Gasom Stake Purchase**
  - Condition: `RiziaDLC.CountryRelation_Sordland_Friendly == true && ((BaseGame.Gasom_RumburgOwnsMajority == true || (BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true) && BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))`

#### Step 9
- **`Turn05_FPnT_MorellaNegotiationsFeedback`** `[Conversation]`
  - Title: **Follow-up on the MITZ and Morella Negotiations**
  - Dialogue Asset: `Rizia/Turn 5/EnT_MorellaNegotiationFeedback`
  - Map Token: `Rizia_City_PorteDrazon`
  - OnEnd: `EvaluateConditionalInstruction("ConstructionStarter_MorellaPipeline");`
- **`Turn05_Decision_DerdiaANSupport`** `[Decision]`
  - Title: **Request Derdia AN Support**
  - Condition: `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.CountryRelation_Derdia_Unfriendly == false && RiziaDLC.CountryRelation_Derdia_Hostile == false`

#### Step 10
- *OnStepStart:* `EnableReport("Turn05_Montaklar_CarlosVisitsMemorial");`
- **`Turn05_P_ManusVinaTalk`** `[Conversation]`
  - Title: **Visit to the Esqiris Gas Field**
  - Dialogue Asset: `Rizia/Turn 5/P_ManusVinaTalk`
  - Map Token: `Rizia_City_Topes`
- **`Turn05_Decision_SordishTouristIssue`** `[Decision]`
  - Title: **Assault on Rizian Citizen by Sordish Tourists**
  - Condition: `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`

#### Step 11
- **`Turn05_Decision_RoyalYachtRestoration`** `[Decision]`
  - Title: **Royal Yacht Restoration**

### Turn 6

#### Step 1
- **`Turn06_Decision_MalenyevistWorkersStrike`** `[Decision]`
  - Title: **Malenyevist Workers' Strike Halts City**
  - Condition: `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false`
  - OnEnd: `RiziaDLC.Protests_MalenyevistStrike_Happened = true`
- **`Turn06_Decision_PublicTransportationWorse_Penalty`** `[Decision]`
  - Title: **Public Transportation On-time Performance Downgraded**
  - Condition: `RiziaDLC.Policy_RD_Economy_PublicTransportInfraInvestment == false && RiziaDLC.Policy_RD_Economy_PublicRailTransportSubsidies == false && RiziaDLC.Policy_RD_Economy_PublicSeaTransportSubsidies == false`
  - OnEnd: `RiziaDLC.Situation_Welfare_PublicTransportation_Overcrowded = true;
RiziaDLC.Situation_Economy_TransportationSystem_Efficient = false;
RiziaDLC.Situation_Economy_TransportationSystem_Functioning = true;
RiziaDLC.Situation_Economy_TransportationSystem_Neglected = false;
RiziaDLCSupport.Reports_Turn06_Monqiz_Decision_PublicTransportationWorse = true;
RiziaDLCSupport.News_Turn06_V_Decision_PublicTransportationWorse = true;
RiziaDLC.Economy_MonqizRailwayBroken = true;
RiziaDLC.Resources_Budget -= 1;`

#### Step 2
- **`Turn06_Decision_MediaCampaign`** `[Decision]`
  - Title: **Global Media Campaign Proposal**
- **`Turn06_A_FootballGame`** `[Conversation]`
  - Title: **Charity Football Match**
  - Dialogue Asset: `Rizia/Turn 6/A_Rusty_FootballGame`
  - Map Token: `Rizia_City_Montaklar`
- **`Turn06_Decision_DelaysAtMITZCheckpoints_Penalty`** `[Decision]`
  - Title: **Delays at MITZ Checkpoints**
  - Condition: `RiziaDLC.MITZ_Renegotiation_Failed == true || RiziaDLC.CountryRelation_Morella_Unfriendly == true`

#### Step 3
- **`Turn06_A_CouncilMeeting`** `[Conversation]`
  - Title: **Meeting with the Royal Council**
  - Dialogue Asset: `Rizia/Turn 6/A_CouncilMeeting`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn06_Decision_VendonesamTroopRequest`** `[Decision]`
  - Title: **Vendonesam Requests Expeditionary Force in Civil War**
  - OnEnd: `RiziaDLCSupport.FactionReports_Turn06_GRACE_SupportsVendonesam = true;`

#### Step 4
- **`Turn06_SnO_Incident`** `[Conversation]`
  - Title: **Late Night at the Palace**
  - Dialogue Asset: `Rizia/Turn 6/SnO_Incident`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`

#### Step 5
- **`Turn06_FPnT_PalesPostIncidentMeeting`** `[Conversation]`
  - Title: **Meeting with Duke Reinhart About the Incident**
  - Dialogue Asset: `Rizia/Turn 6/SnO_PalesPostIncidentMeeting`
  - Map Token: `Rizia_Country_Pales`
  - Condition: `RiziaDLC.Diplomacy_Pales_PrepareForWar == false && RiziaDLC.Diplomacy_Pales_DeclareWar == false && (RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`

#### Step 6
- **`Turn06_A_ReligiousBriefing`** `[Conversation]`
  - Title: **The Alignment of the Six Stars**
  - Dialogue Asset: `Rizia/Turn 6/A_ReligionBriefing`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn06_Decision_RoyalYachtRestorationExtraCosts`** `[Decision]`
  - Title: **Additional Costs on Royal Yacht Restoration**
  - Condition: `RiziaDLC.Decision_Turn05_RestorationPlanRoyalYacht == true`
- **`Turn06_Decision_SuOminaDestabilization_PenaltyWarning`** `[Decision]`
  - Title: **Reports of Parallel Enforcement Activities**
  - Condition: `RiziaDLC.Situation_Order_SuOmina_Destabilizing == true && RiziaDLC.Situation_Order_CentralizedSecurity == false`
  - OnEnd: `RiziaDLC.Decision_Floating_SuOminaDestabilization_PenaltyWarning = true`

#### Step 7
- *OnStepStart:* `RiziaDLC.Enable_Policy_RD_Religion_RemoveStateReligion = true;
RiziaDLC.Enable_Policy_RD_Law_NurityStateReligion = true;`
- **`Turn06_Decision_SordlandsBlackTuesday_Penalty`** `[Decision]`
  - Title: **Sordland's Black Tuesday**
  - Condition: `BaseGame.BlackTuesdayHappened == true`
  - OnEnd: `RiziaDLCSupport.Reports_Turn06_Sordland_BlackTuesday = true;`
- **`Turn06_Decision_SuperpowerTradeWar_Penalty`** `[Decision]`
  - Title: **Superpower Trade War**
  - Condition: `BaseGame.SuperpowerTradeWarHappened == true`
  - OnEnd: `RiziaDLC.Resources_Budget += 2;
RiziaDLC.Budget_Modifier_EconomicInstability -= 1;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_High = true;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Average = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Low = false;
EnableToken("International_Event_TradeWar");
RiziaDLCSupport.News_Turn06_RH_SuperpowerTradeWar = true;`
- **`Turn06_Decision_FundReligiousCharities`** `[Decision]`
  - Title: **Funding of Religious Charities**
  - Condition: `RiziaDLC.Resources_Budget >= 1`

#### Step 8
- **`Turn06_SnO_BorderInvestigationResults`** `[Conversation]`
  - Title: **Investigation Results**
  - Dialogue Asset: `Rizia/Turn 6/A_BorderInvestigationResults`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.PostIncident_Border_JointInvestigation == true`
- **`Turn06_Decision_Protest_MediaCensorship`** `[Decision]`
  - Title: **Protest Against Media Censorship in Iza**
  - Condition: `RiziaDLC.Situation_Law_Media_Censored == true`
  - OnEnd: `RiziaDLC.Protests_MediaCensorship_Happened = true`

#### Step 9
- **`Turn06_P_LucitaAzaroUpdate`** `[Conversation]`
  - Title: **A Conversation with Lucita Azaro**
  - Dialogue Asset: `Rizia/Turn 6/P_LucitaAzaroUpdate`
  - Map Token: `Rizia_City_Terador`
  - Condition: `RiziaDLC.Lucita_Arrested == false`
- **`Turn06_Decision_CigarettesFloodMarket`** `[Decision]`
  - Title: **Cigarettes Flood Market**
  - Condition: `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true`
- **`Turn06_Decision_ProvincialObstruction_PenaltyWarning`** `[Decision]`
  - Title: **Coordination Falters in the Provinces**
  - Condition: `RiziaDLC.Country_PublicOpinion <= -7 && RiziaDLC.Country_HouseAzaro_Enemy == true && RiziaDLC.Country_HouseSazon_Enemy == true && RiziaDLC.Country_HouseToras_Enemy == true && RiziaDLC.HouseAzaro_Conquered == false && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.HouseToras_Conquered == false`
  - OnEnd: `RiziaDLC.Decision_Floating_ProvincialObstruction_PenaltyWarning = true`

#### Step 10
- **`Turn06_FPnT_PalesDealSigning`** `[Conversation]`
  - Title: **Official Signing of the Aureus Agreement**
  - Dialogue Asset: `Rizia/Turn 6/SnO_PalesDealSigning`
  - Map Token: `Rizia_Country_Pales`
  - Condition: `(RiziaDLC.Pales_War == false && RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false) || RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **`Turn06_SnO_DukeWarPhoneCall`** `[Conversation]`
  - Title: **Last Call with Duke Reinhart**
  - Dialogue Asset: `Rizia/Turn 6/FPnT_DukeWarPhoneCall`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Diplomacy_Pales_PrepareForWar == true || RiziaDLC.Diplomacy_Pales_DeclareWar == true`

#### Step 11
- **`Turn06_SnO_WarEruptionBriefing`** `[Conversation]`
  - Title: **Briefing on the Invasion of Pales**
  - Dialogue Asset: `Rizia/Turn 6/SnO_WarEruptionBriefing`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Pales_War == true`
- **`Turn06_P_Cemetary`** `[Conversation]`
  - Title: **Sovereign Memorial Commemoration**
  - Dialogue Asset: `Rizia/Turn 6/P_Cemetary`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn06_Decision_WestTradeReduced_Penalty`** `[Decision]`
  - Title: **Reduced Trade from ATO Partners**
  - Condition: `RiziaDLCSetup.CurrentTurn >= 6 && RiziaDLC.Decision_Floating_WestTradeReduced_PenaltyWarning == true && (RiziaDLC.CountryRelation_Lespia_Hostile == true || RiziaDLC.CountryRelation_Lespia_Unfriendly == true)`

#### Step 12
- **`Turn06_A_PalaceBalconySpeech`** `[Conversation]`
  - Title: **Declaration of War Speech**
  - Dialogue Asset: `Rizia/Turn 6/A_PalaceBalconySpeech`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Pales_War == true`
- **`Turn06_Decision_War_Both_AlertDrills`** `[Decision]`
  - Title: **Quick Reaction Alert Drills**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Fighter_Total >= 1`

#### Step 13
- **`Turn06_Decision_SabotagePalesianDefences`** `[Decision]`
  - Title: **Rizian Intelligence Sabotage Plans**
  - Condition: `(RiziaDLC.Security_Pales_SendSpecialOps == true || RiziaDLC.Turn05_Security_InvestigateBombingPales == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Pales_War == true`
  - OnEnd: `RiziaDLCSupport.Reports_Turn06_Pales_Decision_SabotagePalesianDefences = true;`
- **`Turn06_Decision_WarEnlistments`** `[Decision]`
  - Title: **War Enlistments Report**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.Turn06_WarSpeech_Impact >= 1`
- **`Turn06_Decision_OperationTutorial`** `[Decision]`
  - Title: **Operation Preparation**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Control_Skipped == false`
- **`Turn06_Decision_UAP`** `[Decision]`
  - Title: **Unidentified Aerial Objects**
  - Condition: `RiziaDLC.Rusty_Hostile == false && RiziaDLC.Reform_Movement_Radicalism < 5 && RiziaDLC.CountryRelation_Morella_Hostile == false && RiziaDLC.Morella_Funds_Revolutionaries == false && (RiziaDLC.CountryRelation_Lespia_Unfriendly == true || RiziaDLC.CountryRelation_Lespia_Neutral == true || RiziaDLC.CountryRelation_Lespia_Hostile == true)`

#### Step 14
- **`WarFragment_Tutorial`** `[SystemFragment/Other]`
- **`Turn06_Decision_War_UpgradeProductionLinesTwo`** `[Decision]`
  - Title: **Upgrade Military Production Lines**
  - Condition: `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed == true || RiziaDLC.Policy_RD_Order_FighterPlaneFactory_Completed == true`

### Turn 7

#### Step 1
- **`Turn07_Decision_OP1_MilitiaJoinsWar`** `[Decision]`
  - Title: **Militia to Join War**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Infantry_Total + RiziaDLC.Army_Unit_Azaro_Total + RiziaDLC.Army_Unit_GoldenGuard_Total + RiziaDLC.Army_Unit_Mercenary_Total + RiziaDLC.Army_Unit_Mountaineer_Total + RiziaDLC.Army_Unit_Sazon_Total + RiziaDLC.Army_Unit_Support_Total + RiziaDLC.Army_Unit_Tank_Total + 
RiziaDLC.Army_Unit_Militia_Total <= 8`
- **`Turn07_Decision_DerdiaVisit`** `[Decision]`
  - Title: **Invitation to Visit Derdia**
- **`Turn07_Decision_ProvincialObstruction_Penalty`** `[Decision]`
  - Title: **Obstruction from Provincial Administrations**
  - Condition: `RiziaDLC.Decision_Floating_ProvincialObstruction_PenaltyWarning == true && RiziaDLC.Country_PublicOpinion <= -8 && RiziaDLC.Country_HouseAzaro_Enemy == true && RiziaDLC.Country_HouseSazon_Enemy == true && RiziaDLC.Country_HouseToras_Enemy == true && RiziaDLC.HouseAzaro_Conquered == false && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.HouseToras_Conquered == false`
- **`Turn07_Decision_SuOminaDestabilization_Penalty`** `[Decision]`
  - Title: **Su Omina Undermines Civil Enforcement**
  - Condition: `RiziaDLC.Decision_Floating_SuOminaDestabilization_PenaltyWarning == true && RiziaDLC.Situation_Order_SuOmina_Destabilizing == true && RiziaDLC.Situation_Order_CentralizedSecurity == false`

#### Step 2
- **`WarFragment_1_1`** `[SystemFragment/Other]`
- **`Turn07_Decision_NameRoyalJet`** `[Decision]`
  - Title: **Commission a Morellan Plane As Royal Private Jet**
  - Condition: `RiziaDLC.Situation_Military_MorellanAirPlanes == true`
- **`Turn07_Decision_SalToHouseOfDelegates`** `[Decision]`
  - Title: **Invite Grand Wiseman to House of Delegates**
  - Condition: `RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Policy_RD_Religion_RemoveStateReligion == false`

#### Step 3
- *OnStepStart:* `EvaluateConditionalInstruction("Operation_1_Result");`
- **`Turn07_Decision_War_Both_WehlenDrugs`** `[Decision]`
  - Title: **Medical Supplies from Wehlen**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true`
- **`Turn07_Decision_War_Both_PalesBlockingRiziaTradeShips`** `[Decision]`
  - Title: **Breaking the Palesian Naval Grip**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_AttackPlan_BlockadeGulfofAles_Success == false`

#### Step 4
- **`Turn07_A_HouseofDelegatesII`** `[Conversation]`
  - Title: **House of Delegates Visit**
  - Dialogue Asset: `Rizia/Turn 7/A_HouseOfDelegatesII`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn07_Decision_ROGPrivatizationTwo`** `[Decision]`
  - Title: **Rusty Demands More ROG Shares**
  - Condition: `RiziaDLC.Rusty_GrantROGStake == true`
- **`Turn07_Decision_ForeignGoodsReliance_PenaltyWarning`** `[Decision]`
  - Title: **Crown Budget Strained by Imports**
  - Condition: `RiziaDLC.Situation_Economy_ProductionCapacity_Low == true && (RiziaDLC.Situation_Economy_SelfSufficiency_Dependent == true || (RiziaDLC.Policy_RD_Economy_InvestInTimberIndustry == false && RiziaDLC.Policy_RD_Economy_InvestInPharmaceuticals == false))`
  - OnEnd: `RiziaDLC.Decision_Floating_ForeignGoodsReliance_PenaltyWarning = true`

#### Step 5
- **`Turn07_Decision_SecondZilleResistanceFunding`** `[Decision]`
  - Title: **Funding Resistance in Zille Territory**
- **`Turn07_P_PabelPrivateTalk`** `[Conversation]`
  - Title: **Morning in the Palace**
  - Dialogue Asset: `Rizia/Turn 7/P_PabelPrivateTalk`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer_PabelKnows == true && RiziaDLC.Relations_Pabel > 0)`
- **`Turn07_Decision_Protest_LivingStandards`** `[Decision]`
  - Title: **Local Protest Over Living Standards**
  - Condition: `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
  - OnEnd: `RiziaDLC.Protests_LivingStandards_Happened = true`

#### Step 6
- **`Turn07_FPnT_DerdiaNegotiations`** `[Conversation]`
  - Title: **Meeting with Supreme Wiseman Azmal**
  - Dialogue Asset: `Rizia/Turn 7/FPnT_DerdiaNegotiations`
  - Map Token: `Rizia_Country_Derdia`
  - Condition: `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **`Turn07_Decision_VendonesamCivilWarEscalates`** `[Decision]`
  - Title: **Deepening Involvement in Vendonesam Civil War**
  - Condition: `RiziaDLC.Vendonesam_SupportLevel >= 1`
- **`Turn07_Decision_ProvincialTaxSubsidyTwo`** `[Decision]`
  - Title: **Requests for Provincial Tax Subsidies**
  - Condition: `RiziaDLC.Resources_Budget >= 2`

#### Step 7
- **`Turn07_Decision_RevolutionariesIncitement`** `[Decision]`
  - Title: **Revolutionaries Storm Town Hall**
  - Condition: `RiziaDLC.Situation_Order_Revolutionaries_NonThreat == false && RiziaDLC.Reform_Movement_Radicalism >= 5`
- **`Turn07_A_HugoManusPrivateTalk`** `[Conversation]`
  - Title: **Requested Meeting with Uncle Hugo**
  - Dialogue Asset: `Rizia/Turn 7/A_HugoManusPrivateTalk`
  - Map Token: `Rizia_City_PorteDrazon`

#### Step 8
- **`Turn07_Decision_NewSecurityCouncilor`** `[Decision]`
  - Title: **New War & Security Councilor**
  - Condition: `RiziaDLC.Lucita_Arrested == true`
- **`Turn07_A_IzaUniversity`** `[Conversation]`
  - Title: **750th Anniversary of Iza University**
  - Dialogue Asset: `Rizia/Turn 7/A_IzaUniversity`
  - Map Token: `Rizia_City_Iza`
- **`WarFragment_1_2`** `[SystemFragment/Other]`
- **`Turn07_Decision_AngelicaPardon`** `[Decision]`
  - Title: **Royal Pardon of Duchess Angelica Sazon**
  - Condition: `(RiziaDLCIsolated.Turn07_PhoneCalls_Manus == true || RiziaDLC.Country_HouseSazon > 2) && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false`
- **`Turn07_Decision_HeightenedConsumption_PenaltyWarning`** `[Decision]`
  - Title: **Energy Use Increasing Across All Sectors**
  - Condition: `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && (RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
  - OnEnd: `RiziaDLC.Decision_Floating_HeightenedConsumption_PenaltyWarning = true`

#### Step 9
- **`Turn07_Decision_AntiAureusProtest`** `[Decision]`
  - Title: **Aureus Environmental Protests Escalate**
  - Condition: `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
  - OnEnd: `RiziaDLC.Protests_AntiAureus_Happened = true`
- **`Turn07_FPnT_RumburgMeeting`** `[Conversation]`
  - Title: **Meeting with Queen Livingston**
  - Dialogue Asset: `Rizia/Turn 7/FPnT_RumburgMeeting`
  - Map Token: `Rizia_Country_Rumburg`
- **`Turn07_Decision_War_Both_RefugeeStory`** `[Decision]`
  - Title: **Refugee Crisis**
  - Condition: `RiziaDLC.Pales_War == true`
- **`Turn07_P_HugoConfronts`** `[Conversation]`
  - Title: **Requested Meeting with Hugo**
  - Dialogue Asset: `Rizia/Turn 7/P_HugoConfronts`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true`
- **`Turn07_Decision_GasomDivestResult`** `[Decision]`
  - Title: **GASOM Investment Report**
  - Condition: `RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true || RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true`

#### Step 10
- **`Turn07_FPnT_DukeVisit`** `[Conversation]`
  - Title: **Duke Reinhart's Visit**
  - Dialogue Asset: `Rizia/Turn 7/FPnT_DukeVisit`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Pales_War == false && RiziaDLC.Pales_PostIncident_Peace_NoDeal == false`
- **`Turn07_Decision_War_Both_IndependentJournalism`** `[Decision]`
  - Title: **Freedom of Press in Conflict Zones**
  - Condition: `RiziaDLC.Pales_War == true`
- **`Turn07_Decision_Manus_Gone_Arrested`** `[Decision]`
  - Title: **Protests Over Manus Sazon’s Arrest and RPP Leadership Struggle**
  - Condition: `RiziaDLC.Manus_Arrested == true`
- **`Turn07_Decision_Manus_Gone_Disappeared`** `[Decision]`
  - Title: **Protests Over Manus Sazon’s Disappearance and RPP Leadership Struggle**
  - Condition: `RiziaDLC.SuOmina_OrderedToKillManus == true`
- **`Turn07_Decision_Manus_Gone_LeadershipStruggle`** `[Decision]`
  - Title: **Protests Over Manus Sazon’s Departure and RPP Leadership Struggle**
  - Condition: `(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true) && RiziaDLC.Manus_Gone == true`
- **`Turn07_Decision_Manus_Gone_SentToWar`** `[Decision]`
  - Title: **Protest Over Manus Sazon's Deployment and RPP Leadership Struggle**
  - Condition: `RiziaDLC.Manus_SendToWar == true`

#### Step 11
- **`Turn07_Decision_RoyalYachtRestorationFinal`** `[Decision]`
  - Title: **Final Phase of Royal Yacht Restoration**
  - Condition: `RiziaDLC.Decision_Turn06_YachtRestoration_PayAdditionalCosts == true || RiziaDLC.Decision_Turn06_YachtRestoration_PayWithWehlenTimber == true || RiziaDLC.Decision_Turn06_YachtRestoration_PayWithRizianTimber == true`
- **`Turn07_Decision_War_Both_EconomicTurmoil`** `[Decision]`
  - Title: **Wartime Economy**
  - Condition: `RiziaDLC.Pales_War == true`
  - OnEnd: `RiziaDLCSupport.News_Turn07_RH_Decision_War_EconomicTurmoil = true;
RiziaDLCSupport.News_Turn07_V_Decision_War_EconomicTurmoil = true;`
- **`Turn07_Decision_UseDerdianMissiles`** `[Decision]`
  - Title: **Use Derdian Missiles**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Control_Skipped == true && RiziaDLC.Resources_Military_DerdianMissiles == true`

#### Step 12
- **`Turn07_Decision_WelfareProtestsExpand`** `[Decision]`
  - Title: **Unrest Over Unfulfilled Welfare Promises**
  - Condition: `RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == false && RiziaDLC.Decision_Turn04_MonqizProtests_Promise == true`
  - OnEnd: `RiziaDLC.Protests_Welfare_Expanded = true`
- **`Turn07_P_TorasDinner`** `[Conversation]`
  - Title: **Dinner with the Family**
  - Dialogue Asset: `Rizia/Turn 7/P_TorasDinner`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Vina_Hostage == false`
- **`Turn07_Decision_War_Both_PalesPropagandaInRizia`** `[Decision]`
  - Title: **Countering Palesian Propaganda**
  - Condition: `RiziaDLC.Pales_War == true`

#### Step 13
- **`Turn07_Decision_MatrilinealException`** `[Decision]`
  - Title: **Ensuring Continuity of the Toras Royal Lineage**
  - Condition: `RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **`Turn07_Decision_Protest_PoliceViolence`** `[Decision]`
  - Title: **Protest Against the Kingdom's Harsh Response Against Opposing Voices**
  - Condition: `RiziaDLC.Country_QuelledProtests > 2`
  - OnEnd: `RiziaDLC.Protests_PoliceBrutality_Happened = true`

#### Step 14
- **`Turn07_Decision_Pipeline_RustySabotage`** `[Decision]`
  - Title: **Employees linked to RRG**
  - Condition: `RiziaDLC.Military_Pipeline_RustySabotage_Investigation == true && (RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true) && RiziaDLC.Pales_War == false`
- **`Turn07_Decision_Pipeline_RevolutionarySabotage`** `[Decision]`
  - Title: **Revolutionary Links Uncovered**
  - Condition: `RiziaDLC.Military_Pipeline_RevolutionarySabotage_Investigation == true && (RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true) && RiziaDLC.Pales_War == false`
- **`Turn07_Decision_Pipeline_MorellaSabotage`** `[Decision]`
  - Title: **Revolutionary Sabotage Plot Unveiled**
  - Condition: `RiziaDLC.Military_Pipeline_MorellaSabotage_Investigation == true && RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true && RiziaDLC.Pales_War == false `

### Turn 8

#### Step 1
- *OnStepStart:* `RiziaDLC.Enable_Policy_RD_Economy_PorteDrazonTourismCampaign = true;
RiziaDLC.Enable_Policy_RD_Economy_FormPorteDrazonStockExchange = true;`
- **`Turn08_Decision_VendonesamLoses`** `[Decision]`
  - Title: **Confederacy of Vendonesam Loses Civil War**
  - Condition: `RiziaDLC.Vendonesam_SupportLevel <= 2`
  - OnEnd: `//RiziaDLC.Country_Military_PowerProjection -= 2;
RiziaDLC.PowerProjection_from_Decisions -= 2;
RiziaDLC.Budget_Modifier_GRACETradeSurplus -= 1;
RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1;
RiziaDLC.Vendonesam_Lose = true;
RiziaDLCSupport.FactionReports_Turn08_GRACE_CondemsVendonesamLoss = true;
EnableCodexEntry("Organisations_InterGovernmental_GRACENoVendonesam");
RiziaDLCText.GRACECountries = "the Kingdom of Rizia"`
- **`Turn08_Decision_VendonesamStalemate`** `[Decision]`
  - Title: **Vendonesam Civil War Reaches Stalemate**
  - Condition: `RiziaDLC.Vendonesam_SupportLevel >= 3 && RiziaDLC.Vendonesam_SupportLevel <= 6`
  - OnEnd: `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1;
//RiziaDLC.Country_Military_PowerProjection += 1;
RiziaDLC.PowerProjection_from_Decisions += 1;
RiziaDLC.Vendonesam_Stalemate = true;
RiziaDLCSupport.FactionReports_Turn08_GRACE_ContestsVendonesamStalemate = true;`
- **`Turn08_Decision_VendonesamVictory`** `[Decision]`
  - Title: **Confederacy of Vendonesam Wins Civil War**
  - Condition: `RiziaDLC.Vendonesam_SupportLevel >= 7`
  - OnEnd: `RiziaDLC.PowerProjection_from_Decisions += 2;
RiziaDLC.Budget_Modifier_GRACETradeSurplus += 1;
RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 2;
RiziaDLC.Country_PublicOpinion += 1;
RiziaDLC.Resources_Authority += 2;
RiziaDLC.Authority_Modifier_BaseMonarchRomus += 1;
RiziaDLC.Vendonesam_Victory = true;
RiziaDLCSupport.FactionReports_Turn08_GRACE_HailsVendonesamVictory = true;`
- **`Turn08_SnO_SecurityBriefAndZille`** `[Conversation]`
  - Title: **Security Council Meeting**
  - Dialogue Asset: `Rizia/Turn 8/SnO_SecurityBriefAndZille`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn08_Decision_War_Skipped_Experimental_Weapons_FirstTime`** `[Decision]`
  - Title: **Request for Experimental Weapon Usage**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Control_Skipped == true && RiziaDLC.Resources_Military_RumburgianNerveGas == true && RiziaDLC.War_Used_ExperimentalWeapons == 0`
- **`Turn08_Decision_ForeignGoodsReliance_Penalty`** `[Decision]`
  - Title: **Rising Costs from Foreign Dependency**
  - Condition: `RiziaDLC.Decision_Floating_ForeignGoodsReliance_PenaltyWarning == true && RiziaDLC.Situation_Economy_ProductionCapacity_Low == true && (RiziaDLC.Situation_Economy_SelfSufficiency_Dependent == true || (RiziaDLC.Policy_RD_Economy_InvestInTimberIndustry == false && RiziaDLC.Policy_RD_Economy_InvestInPharmaceuticals == false))`
- **`Turn08_Decision_HeightenedConsumption_Penalty`** `[Decision]`
  - Title: **Surge in National Energy Consumption**
  - Condition: `RiziaDLC.Decision_Floating_HeightenedConsumption_PenaltyWarning == true && RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && (RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`

#### Step 2
- **`WarFragment_1_3`** `[SystemFragment/Other]`
- **`Turn08_Decision_War_Both_ConscriptionLaborShortages`** `[Decision]`
  - Title: **Conscription and Labor Shortages**
  - Condition: `RiziaDLC.Pales_War == true && (RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false || RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false)`
- **`Turn08_Decision_NewManufacturing`** `[Decision]`
  - Title: **Invest in New Industry**
  - Condition: `RiziaDLC.Resources_Budget >= 4 && RiziaDLC.Situation_Economy_ProductionCapacity_Low == false &&(RiziaDLC.Resources_Energy >= 2 || RiziaDLC.Resources_EnergyModifiersTotal >= 2)`

#### Step 3
- *OnStepStart:* `EvaluateConditionalInstruction("Operation_1_Result");`
- **`Turn08_Decision_Operation1BriefingLocation`** `[Decision]`
  - Title: **Operation Briefing**
  - Condition: `RiziaDLC.Pales_War == true`
- **`Turn08_Decision_War_Both_FuelAllocation`** `[Decision]`
  - Title: **Fuel Allocation Prioritization**
  - Condition: `RiziaDLC.Pales_War == true && (RiziaDLC.Army_Unit_Fighter_Total >= 1 && RiziaDLC.Army_Unit_Bomber_Total >= 1)`
- **`Turn08_Decision_War_UpgradeProductionLinesThree`** `[Decision]`
  - Title: **Upgrade Military Production Lines**
  - Condition: `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed == true || RiziaDLC.Policy_RD_Order_FighterPlaneFactory_Completed == true`

#### Step 4
- **`Turn08_SnO_War_Pales_PostOperation1_Palace`** `[Conversation]`
  - Title: **Operation Golden Shield Briefing**
  - Dialogue Asset: `Rizia/Turn 8/SnO_War_Pales_PostOperation1`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Operation1Briefing_Frontline == false`
- **`Turn08_SnO_War_Pales_PostOperation1_Frontline_Win`** `[Conversation]`
  - Title: **Operation Golden Shield Briefing**
  - Dialogue Asset: `Rizia/Turn 8/SnO_War_Pales_PostOperation1`
  - Map Token: `Rizia_City_FortAles`
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Operation1Briefing_Frontline == true && RiziaDLC.War_Pales_Operation1_Won == true`
- **`Turn08_SnO_War_Pales_PostOperation1_Frontline_Loss`** `[Conversation]`
  - Title: **Operation Golden Shield Briefing**
  - Dialogue Asset: `Rizia/Turn 8/SnO_War_Pales_PostOperation1`
  - Map Token: `Rizia_City_Havas`
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Operation1Briefing_Frontline == true && RiziaDLC.War_Pales_Operation1_Won == false`
- **`Turn08_Decision_RustyLoanRepaymentApproaching`** `[Decision]`
  - Title: **Rusty’s Loan Repayment Approaching**
  - Condition: `RiziaDLC.Rusty_LoanAmount >= 1 && RiziaDLC.Rusty_Arrested == false && RiziaDLC.Rusty_Fled == false`

#### Step 5
- **`Turn08_Decision_War_Both_RemembranceCeremony`** `[Decision]`
  - Title: **Tribute to the Fallen**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == false`
- **`Turn08_Decision_ReformMovement_Rally`** `[Decision]`
  - Title: **Mass Rallies Demanding Democratic Reforms**
  - Condition: `RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5 && (RiziaDLC.Reform_Movement_Strength >= 7 && (RiziaDLC.Reform_Movement_Radicalism >= 7 || RiziaDLC.Manus_Gone == true)) == false`
- **`Turn08_Decision_ReformMovement_Rally_Radical`** `[Decision]`
  - Title: **Mass Rallies Demanding Democratic Reforms**
  - Condition: `RiziaDLC.Reform_Movement_Strength >= 7 && (RiziaDLC.Reform_Movement_Radicalism >= 7 || RiziaDLC.Manus_Gone == true)`

#### Step 6
- **`Turn08_Decision_HighEnergyPriceSurplus`** `[Decision]`
  - Title: **Surplus from High Global Energy Prices**
  - Condition: `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
  - OnEnd: `RiziaDLC.Resources_Budget += 2;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Low = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Average = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_High = true;
RiziaDLCSupport.News_Turn08_G_Decision_HighEnergyPriceSurplus = true;`
- **`Turn08_Decision_Vendonesam_TroopsReturn`** `[Decision]`
  - Title: **Rizian Royal Expeditionary Forces' Return**
  - Condition: `(RiziaDLC.Decision_Turn06_VendonesamTroopRequest_DeployDivision == true || RiziaDLC.Decision_Turn07_VendonesamCivilWar_DeployDivision == true || RiziaDLC.Decision_Turn07_VendonesamCivilWar_DeployMotorizedDivision == true ||  RiziaDLC.Decision_Turn07_VendonesamCivilWar_DeployTankDivision == true || RiziaDLC.Decision_Turn07_VendonesamCivilWar_AirForceSupport == true || RiziaDLC.Decision_Turn07_VendonesamCivilWar_NavalSupport == true) && RiziaDLC.Vendonesam_Victory == true`
- **`Turn08_FPnT_AlvarezVisit`** `[Conversation]`
  - Title: **Diplomatic Meeting with Lespia**
  - Dialogue Asset: `Rizia/Turn 8/FPnT_AlvarezVisit`
  - Map Token: `Rizia_Country_Lespia`
- **`Turn08_Decision_War_Both_MothersWarProtest`** `[Decision]`
  - Title: **Mothers' March Against War**
  - Condition: `RiziaDLC.Pales_War == true && (RiziaDLC.Policy_Military_Conscription_18_1Year == true || RiziaDLC.Policy_Military_Conscription_18_2Year == true)`

#### Step 7
- **`Turn08_Decision_Pipeline_RustySabotage_EvidenceReport`** `[Decision]`
  - Title: **Counterintelligence Operation Thwarts Sabotage Plot**
  - Condition: `RiziaDLC.Turn07_Decision_Pipeline_RustySabotage_CounterIntel == true`
  - OnEnd: `RiziaDLC.Rusty_KnownLespianAgent = true;
SetRichPresence("Uncovering evidence of foreign sabotage", "Council Chambers", "Porte Drazon");`
- **`Turn08_Decision_Pipeline_RevolutionarySabotage_EvidenceReport`** `[Decision]`
  - Title: **Counterintelligence Operation Thwarts Radical Plot**
  - Condition: `RiziaDLC.Decision_Turn07_Pipeline_RevolutionarySabotage_CounterIntel == true`
  - OnEnd: `SetRichPresence("Uncovering evidence of internal sabotage", "Council Chambers", "Porte Drazon");`
- **`Turn08_Decision_Pipeline_MorellaSabotage_EvidenceReport`** `[Decision]`
  - Title: **Counterintelligence Operation Thwarts Radical Plot**
  - Condition: `RiziaDLC.Decision_Turn07_Pipeline_MorellaSabotage_CounterIntel == true`
  - OnEnd: `SetRichPresence("Uncovering evidence of foreign sabotage", "Council Chambers", "Porte Drazon");`
- **`Turn08_Decision_SurplusOfMedicine`** `[Decision]`
  - Title: **Surplus of Medicine**
  - Condition: `RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true || RiziaDLC.Decision_Turn08_NewManufacturing_Pharma == true`

#### Step 8
- **`Turn08_Decision_MediateDerdiaMorella`** `[Decision]`
  - Title: **Morella and Derdia Request Diplomatic Mediation**
  - Condition: `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting == true || (RiziaDLC.CountryRelation_Morella_Unfriendly == false && RiziaDLC.CountryRelation_Morella_Hostile == false && RiziaDLC.CountryRelation_Derdia_Unfriendly == false && RiziaDLC.CountryRelation_Derdia_Hostile == false && RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)`
- **`Turn08_A_GeneralCouncilMeeting`** `[Conversation]`
  - Title: **Council Meeting**
  - Dialogue Asset: `Rizia/Turn 8/A_GeneralCouncilMeeting`
  - Map Token: `Rizia_City_PorteDrazon`
- **`Turn08_Decision_SordlandBondResults`** `[Decision]`
  - Title: **Outcome of the Sordland Bond Investment**
  - Condition: `RiziaDLC.Turn04_SordlandBond_LargeInvestment == true || RiziaDLC.Turn04_SordlandBond_SmallInvestment == true`

#### Step 9
- **`Turn08_A_RustyPhoneCall`** `[Conversation]`
  - Title: **Phone Call With Rusty Montoro**
  - Dialogue Asset: `Rizia/Turn 8/RustyCall`
  - Map Token: `Rizia_City_MaveNortus`
  - Condition: `(RiziaDLC.Rusty_Allied == true || RiziaDLC.Rusty_KnownLespianAgent == true) && RiziaDLC.Rusty_Arrested == false && RiziaDLC.Rusty_Fled == false`

#### Step 10
- *OnStepStart:* `EnableNews("G_GalmlandTension");`
- **`Turn08_Decision_RRGNationalization`** `[Decision]`
  - Title: **Nationalization of Rizian Royal Gold**
  - Condition: `RiziaDLC.Enable_RRG_Nationalization == true && RiziaDLC.Rusty_Arrested == true`
- **`Turn08_Decision_RRGNationalization_RustyFled`** `[Decision]`
  - Title: **Nationalization of Rizian Royal Gold**
  - Condition: `RiziaDLC.Enable_RRG_Nationalization == true && RiziaDLC.Rusty_Arrested == false`

#### Step 11
- **`Turn08_Decision_GRACETradeGrows`** `[Decision]`
  - Title: **GRACE Trade Grows**
  - Condition: `(RiziaDLC.GRACETrade_Weakened == false && RiziaDLC.Diplomacy_Rumburg_NegotiatingPower >= 8) && RiziaDLC.Vendonesam_Victory == true`
  - OnEnd: `RiziaDLCSupport.FactionReports_Turn08_GRACE_Decision_TradeGrows = true;
RiziaDLCSupport.FactionReports_Turn08_GRACE_CommendsTradeGrowth = true;`
- **`Turn08_Decision_GRACETradeEnds_Penalty`** `[Decision]`
  - Title: **GRACE Trade Volume Crashes**
  - Condition: `(RiziaDLC.Diplomacy_Rumburg_NegotiatingPower < 0 || RiziaDLC.Budget_Modifier_GRACETradeSurplus <= 1) && (RiziaDLC.Vendonesam_Lose == true || RiziaDLC.Vendonesam_Stalemate == true)`
  - OnEnd: `RiziaDLC.Budget_Modifier_GRACETradeSurplus -= 1;
RiziaDLC.Resources_Authority -= 1;
RiziaDLC.GRACETrade_Ends = true;
RiziaDLCSupport.FactionReports_Turn08_GRACE_Decision_TradeEnds = true;`
- **`Turn08_Decision_IntermerkopumFounding`** `[Decision]`
  - Title: **Begin South Merkopan Alliance Initiative**
  - Condition: `RiziaDLC.Intermerkopum_Efforts == true`
- **`Turn08_Decision_War_Both_NavarCastleAttack`** `[Decision]`
  - Title: **Siege of Navar Castle**
  - Condition: `RiziaDLC.Pales_War == true`

#### Step 12
- **`Turn08_Decision_OP2_MilitiaJoinsWar`** `[Decision]`
  - Title: **Militia to Join War**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.Army_Unit_Infantry_Total + RiziaDLC.Army_Unit_Azaro_Total + RiziaDLC.Army_Unit_GoldenGuard_Total + RiziaDLC.Army_Unit_Mercenary_Total + RiziaDLC.Army_Unit_Mountaineer_Total + RiziaDLC.Army_Unit_Sazon_Total + RiziaDLC.Army_Unit_Support_Total + RiziaDLC.Army_Unit_Tank_Total + 
RiziaDLC.Army_Unit_Militia_Total <= 5 && RiziaDLC.War_Pales_Operation1_Won == true`
- **`Turn08_FPnT_ZilleNegotiations`** `[Conversation]`
  - Title: **Negotiations with President Smolak**
  - Dialogue Asset: `Rizia/Turn 8/FPnT_ZilleNegotiations`
  - Map Token: `Rizia_Country_Wehlen`

#### Step 13
- **`WarFragment_2_1`** `[SystemFragment/Other]`
- **`Turn08_P_HugoLeaves`** `[Conversation]`
  - Title: **Requested Meeting with Hugo**
  - Dialogue Asset: `Rizia/Turn 8/A_HugoLeaves`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Rico_Extradited == true || RiziaDLC.Hugo_RicoNotPardoned == true`
- **`Turn08_Decision_HODMilitaryIntervention`** `[Decision]`
  - Title: **Invite Rizian Armed Forces To Attend House of Delegates**
  - Condition: `RiziaDLC.Stratocracy_HODAssistanceOffered == true && (RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.Pales_War == false)`

#### Step 14
- **`Turn08_Decision_MediateDerdiaWehlen`** `[Decision]`
  - Title: **Derdia and Wehlen Request Diplomatic Mediation**
  - Condition: `RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Resources_Budget >= 1 && RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true) && (RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **`Turn08_Decision_War_Skipped_PalesResistanceMilitia`** `[Decision]`
  - Title: **Quelling Palesian Insurgence**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Control_Skipped == true && RiziaDLC.War_Pales_Resistance >= 3 && RiziaDLC.War_Pales_PublicWarSupport >= 2`
  - OnEnd: `EnableNews("OP2_RH_Decision_MilitiaSpawn");
EnableNews("OP2_V_Decision_MilitiaSpawn");`
- **`Turn08_A_HouseOfDelegates3`** `[Conversation]`
  - Title: **House of Delegates Visit**
  - Dialogue Asset: `Rizia/Turn 8/A_HouseOfDelegates3`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.HouseOfDelegates_Abolished == false`

#### Step 15
- **`Turn08_FPnT_ANSession`** `[Conversation]`
  - Title: **Alliance of Nations**
  - Dialogue Asset: `Rizia/Turn 8/FPnT_ANSession`
  - Map Token: `Rizia_Country_Kyrute`
- **`Turn08_A_Reform_Manus`** `[Conversation]`
  - Title: **Secret Meeting with Manus Sazon**
  - Dialogue Asset: `Rizia/Turn 8/A_Reform_Manus`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Reform_Path == true`
- **`Turn08_Decision_AbolishHouseofDelegates`** `[Decision]`
  - Title: **Abolish the House of Delegates**
  - Condition: `RiziaDLC.HouseOfDelegates_Abolished == false && RiziaDLC.Reform_Path == false &&(RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.LeaningValue_Democratic < -10)`

#### Step 16
- *OnStepStart:* `EnableReport("Turn08_Sallabes_FashionHouse"); 
EnableNews("Turn08_RH_FashionHouseInSallabes");`
- **`Turn08_Decision_LowEnergyPriceDeficit`** `[Decision]`
  - Title: **Deficit from Low Global Energy Prices**
  - Condition: `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
  - OnEnd: `RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Low = true;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Average = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_High = false;
RiziaDLCSupport.News_Turn08_G_LowEnergyPriceDeficit = true;`
- **`Turn08_Decision_HighEnergyPriceSurplus`** `[Decision]`
  - Title: **Surplus from High Global Energy Prices**
  - Condition: `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
  - OnEnd: `RiziaDLC.Resources_Budget += 2;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Low = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_Average = false;
RiziaDLC.Situation_Economy_GlobalEnergyPrice_High = true;
RiziaDLCSupport.News_Turn08_G_Decision_HighEnergyPriceSurplus = true;`
- **`Turn08_Decision_WineExportsQuadruple`** `[Decision]`
  - Title: **Wine Exports Quadruple**
  - Condition: `(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true && RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false) ||(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true && RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true && RiziaDLC.Valenqiris_EnvironmentCrisisTackled == true)`
  - OnEnd: `RiziaDLC.Resources_Budget += 3;
RiziaDLCSupport.Reports_Turn08_Qalus_WineExportsQuadruple = true;
RiziaDLCSupport.Reports_Turn08_Sordland_WineExportsQuadruple = true;`
- **`Turn08_A_SalInvestigationResults`** `[Conversation]`
  - Title: **Lunch Time**
  - Dialogue Asset: `Rizia/Turn 8/A_SalInvestigationResults`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true)`

#### Step 17
- **`Turn08_Decision_WeddingCommittee`** `[Decision]`
  - Title: **Foundation of Royal Wedding Committee**
  - Condition: `RiziaDLC.Vina_Engaged == true && RiziaDLC.Resources_Budget >= 2`

#### Step 18
- **`Turn08_P_NightBeforeWedding`** `[Conversation]`
  - Title: **Nighttime At The Palace**
  - Dialogue Asset: `Rizia/Turn 8/P_NightBeforeWedding`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Vina_Escapes == true || RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Pabel_Together == true`
- **`Turn08_Decision_UseDerdianMissilesTwo`** `[Decision]`
  - Title: **Use Derdian Missiles**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Pales_Operation1_Won == true && RiziaDLC.War_Control_Skipped == true && RiziaDLC.Resources_Military_DerdianMissiles == true`

#### Step 19
- *OnStepStart:* `RiziaDLC.Enable_Policy_RD_Economy_FormPorteDrazonStockExchange = false;`
- **`Turn08_A_RoyalWedding`** `[Conversation]`
  - Title: **Wedding of Princess Vina**
  - Dialogue Asset: `Rizia/Turn 8/A_RoyalWedding`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Rico == true`

### Turn 9

#### Step 1
- *OnStepStart:* `EnableNews("G_VentrieCityAssassinations");`
- **`Turn9_FPnT_Mediation`** `[Conversation]`
  - Title: **Diplomatic Mediations With Derdia**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_Mediation`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true ||RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true||
RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true`
- **`Turn09_Decision_War_Both_PalesInfrastructureCollapse`** `[Decision]`
  - Title: **Pales Infrastructure Collapse**
  - Condition: `RiziaDLC.Pales_War == true`
  - OnEnd: `RiziaDLCSupport.News_V_Turn09_Decision_War_PalesInfrastructureCollapse_PalesInRuins = true;`
- **`Turn09_Decision_SordishPolioArrives`** `[Decision]`
  - Title: **Polio Pandemic from Sordland Arrives**
  - Condition: `BaseGame.Situation_Welfare_EpidemicSpreads == true`
  - OnEnd: `RiziaDLCSupport.News_Turn09_G_Decision_SordishPolioArrives = true;
RiziaDLCSupport.Reports_Turn09_Monqiz_SordishPolioArrives = true;`

#### Step 2
- **`Turn9_FPnT_MITZ_BoardMeeting`** `[Conversation]`
  - Title: **Final Board Vote on the MITZ**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_MITZ_BoardMeeting`
  - Map Token: `Rizia_Country_Morella`
- **`Turn09_Decision_PublicTransportationDestroyed_Penalty`** `[Decision]`
  - Title: **Public Transport In Total Disrepair**
  - Condition: `RiziaDLC.Policy_RD_Economy_PublicTransportInfraInvestment == false && RiziaDLC.Policy_RD_Economy_PublicRailTransportSubsidies == false && RiziaDLC.Policy_RD_Economy_PublicSeaTransportSubsidies == false`
  - OnEnd: `RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies = false;
RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment = false;
RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies = false;
RiziaDLC.Situation_Economy_TransportationSystem_Functioning = false;
RiziaDLC.Situation_Economy_TransportationSystem_Efficient = false;
RiziaDLC.Situation_Economy_TransportationSystem_Neglected = true;
RiziaDLC.Situation_Welfare_PublicTransportation_Overcrowded = true;
RiziaDLCSupport.Reports_Turn09_PorteDrazon_Decision_PublicTransportationDestroyed = true;
RiziaDLCSupport.News_Turn09_V_Decision_PublicTransportationDestroyed = true;
RiziaDLC.Country_PublicOpinion -= 2;`

#### Step 3
- *OnStepStart:* `EvaluateConditionalInstruction("IntermerkopumPartners2");
EvaluateConditionalInstruction("IntermerkopumPartners");`
- **`Turn09_Decision_HousingMovementPetitionsKing`** `[Decision]`
  - Title: **Housing Expropriation Movement Petitions King**
  - Condition: `RiziaDLCSupport.HousingMovementStarted == true && RiziaDLC.Policy_RD_Welfare_FreePress == true && RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false`

#### Step 4
- **`Turn09_Decision_ReformIntention_Declaration`** `[Decision]`
  - Title: **Declaration of the Plans for a New Constitution**
  - Condition: `RiziaDLC.Reform_Diplomatic == true && RiziaDLC.Reform_Diplomatic_RejectedandCancelled == false && RiziaDLC.Reform_Path_Cancelled == false`
- **`Turn09_Decision_SuOmina_Fights_PalesResistance`** `[Decision]`
  - Title: **Deploying Su Omina to Occupied Cities**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.War_Pales_Operation1_Won == true`

#### Step 5
- **`Turn9_Pipeline_NatDes_TombIntro`** `[Conversation]`
  - Title: **Surveying Father's Desecrated Tomb**
  - Dialogue Asset: `Rizia/Turn 9/Pipeline_NatDesMeeting`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Revolutionary_Pipeline_Sabotage == false && RiziaDLC.Morella_Pipeline_Sabotage == false && RiziaDLC.Rusty_Pipeline_Sabotage == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **`Turn9_Pipeline_NatDes_TVIntro`** `[Conversation]`
  - Title: **Downtime at the Palace**
  - Dialogue Asset: `Rizia/Turn 9/Pipeline_NatDesMeeting`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Revolutionary_Pipeline_Sabotage == true || RiziaDLC.Morella_Pipeline_Sabotage == true || RiziaDLC.Rusty_Pipeline_Sabotage == true`

#### Step 6
- **`Turn09_Decision_War_Skipped_Experimental_Weapons_Again`** `[Decision]`
  - Title: **Request for Nerve Gas Usage**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Control_Skipped == true && RiziaDLC.Resources_Military_RumburgianNerveGas == true && RiziaDLC.War_Used_ExperimentalWeapons > 0`
- **`WarFragment_2_2`** `[SystemFragment/Other]`
- **`Turn9_FPnT_IntermerkopumRoundtable`** `[Conversation]`
  - Title: **Roundtable Discussion On Proposed South Merkopan Alliance**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_IntermerkopumRoundtable`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Intermerkopum_Efforts == true`

#### Step 7
- *OnStepStart:* `RiziaDLC.Enable_Policy_RD_Economy_PorteDrazonTourismCampaign = false`
- **`Turn9_FPnT_GRACE_Rumburg_Meeting`** `[Conversation]`
  - Title: **High Tea With Queen Beatrice**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_GRACERumburgMeeting`
  - Map Token: `Rizia_Country_Rumburg`
- **`Turn09_Decision_Aid_Arcasia`** `[Decision]`
  - Title: **Arcasia Offers Aid**
  - Condition: `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && (RiziaDLC.CountryRelation_Lespia_Friendly == true || RiziaDLC.CountryRelation_Lespia_Allied == true)`
- **`Turn09_Decision_Aid_Valgsland`** `[Decision]`
  - Title: **Valgsland Offers Aid**
  - Condition: `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.CountryRelation_Valgsland_Friendly == true && RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == false`
- **`Turn09_Decision_TourismCampaignResults`** `[Decision]`
  - Title: **Tourism Campaign Results**
  - Condition: `RiziaDLC.Policy_RD_Economy_PorteDrazonTourismCampaign == true`

#### Step 8
- **`Turn9_FPnT_CallWithSmolak`** `[Conversation]`
  - Title: **An Evening in Monqiz**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_CallWithSmolak`
  - Map Token: `Rizia_City_Monqiz`
  - Condition: `RiziaDLC.War_RumburgCeasefireRequested == false && RiziaDLC.Pales_War == true && RiziaDLC.ZilleReferendum_StoppedByAN == false && RiziaDLC.War_Objective_Captured_Pales == false`
- **`Turn09_Decision_StockExchangeResults`** `[Decision]`
  - Title: **Porte Drazon Stock Exchange Opens**
  - Condition: `RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == true`

#### Step 9
- **`Turn9_FPnT_ZilleReferendum`** `[Conversation]`
  - Title: **Zille Referendum Results**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_ZilleReferendum`
  - Map Token: `Rizia_City_Jales`
  - Condition: `RiziaDLC.ZilleReturn_Success == false && RiziaDLC.ZilleReferendum_StoppedByAN == false && RiziaDLC.ZilleReferendum_SmolakOffer_Accepted == false`
- **`Turn09_Decision_RustyLoanBigLoanRepayment`** `[Decision]`
  - Title: **Rusty Demands Loan Repayment**
  - Condition: `RiziaDLC.Rusty_LoanAmount >= 10 && RiziaDLC.Rusty_Arrested == false && RiziaDLC.Rusty_Fled == false`
- **`Turn09_Decision_RustyLoanSmallLoanRepayment`** `[Decision]`
  - Title: **Rusty Demands Loan Repayment**
  - Condition: `RiziaDLC.Rusty_LoanAmount >= 1 && RiziaDLC.Rusty_LoanAmount <= 9 && RiziaDLC.Rusty_Arrested == false && RiziaDLC.Rusty_Fled == false`

#### Step 10
- **`Turn9_FPnT_ZilleReferendumInterference`** `[Conversation]`
  - Title: **Referendum Interference Results**
  - Dialogue Asset: `Rizia/Turn 9/FPnT_ZilleReferendumInterference`
  - Map Token: `Rizia_City_Jales`
  - Condition: `RiziaDLC.ZilleReferendum_Interfere_Agents == true || RiziaDLC.ZilleReferendum_Interfere_Army == true`

#### Step 11
- **`Turn09_Decision_War_Both_InternalDissent`** `[Decision]`
  - Title: **Quelling Dissent**
  - Condition: `RiziaDLC.Pales_War == true && ((RiziaDLC.War_Pales_RizianWarSupport <= 0 && (RiziaDLC.Situation_Welfare_LivingStandards_Bad || RiziaDLC.Situation_Welfare_LivingStandards_Horrible)) || (RiziaDLC.War_Pales_RizianWarSupport <= -2))`
  - OnEnd: `RiziaDLCSupport.News_Turn09_V_Decision_War_InternalDissent_Default = true;`

#### Step 12
- **`Turn9_A_ZilleReturnedSpeech`** `[Conversation]`
  - Title: **Return of Zille Speech**
  - Dialogue Asset: `Rizia/Turn 9/A_ZilleReturnedSpeech`
  - Map Token: `Rizia_Event_Zille`
  - Condition: `RiziaDLC.ZilleReturn_Success == true`
  - OnEnd: `EvaluateConditionalInstruction("MapChange_Zille");`
- **`Turn09_Decision_AdarfoAssassination`** `[Decision]`
  - Title: **A Growing Revolutionary Threat**
  - Condition: `RiziaDLC.Adarfo_AssassinationOrdered == true && RiziaDLC.Rusty_Arrested == false && RiziaDLC.Rusty_Hostile == false`
- **`Turn09_Decision_InviteOrEliminateAdarfo`** `[Decision]`
  - Title: **A Growing Revolutionary Threat**
  - Condition: `RiziaDLC.Reform_Path == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.Reform_TalkToAdarfo_AskedManus == false && RiziaDLC.Adarfo_AssassinationOrdered == false && RiziaDLC.Decision_TalkWithAdarfo == false`

#### Step 13
- **`Turn9_A_TalkWithAdarfo`** `[Conversation]`
  - Title: **Meeting With Adarfo Sotelato**
  - Dialogue Asset: `Rizia/Turn 9/TalkWithAdarfo`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `(RiziaDLC.Reform_TalkToAdarfo_AskedManus == true || RiziaDLC.Decision_TalkWithAdarfo == true) && RiziaDLC.Adarfo_Executed == false`
- **`Turn9_A_TalkWithManus`** `[Conversation]`
  - Title: **Secret Meeting With Manus Sazon**
  - Dialogue Asset: `Rizia/Turn 9/TalkWithManus`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Path_Cancelled == false`

#### Step 14
- **`Turn9_A_MeetingWithSal`** `[Conversation]`
  - Title: **Meeting with Sal**
  - Dialogue Asset: `Rizia/Turn 9/A_MeetingWithSal`
  - Map Token: `Rizia_City_Benievon`
  - Condition: `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Sal_Arrested == false`
- **`Turn09_Decision_Unification`** `[Decision]`
  - Title: **Rizian-Palesian Unification Initiative**
  - Condition: `RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Pales_Rizia_Unification_Failed == false && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false`
- **`Turn09_Decision_LeaveAllianceOfNations`** `[Decision]`
  - Title: **Rizia's State in Alliance of Nations**
  - Condition: `RiziaDLC.Policy_Diplomacy_Intermerkopum == false && (RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true || RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true || RiziaDLC.ZilleReferendum_NotStoppedByAN == true)`

#### Step 15
- *OnStepStart:* `EnableNews("Turn09_RH_Gossip_LeonaPreparesForBirthday")`
- **`Turn9_A_TalkWithTitus`** `[Conversation]`
  - Title: **Preparations for the Queen Mother's Birthday**
  - Dialogue Asset: `Rizia/Turn 9/TalkWithTitus`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.SkipTalkWithTitus == false`
- **`Turn09_Decision_RRGFuturePostNationalized`** `[Decision]`
  - Title: **Future of Rizian Royal Gold**
  - Condition: `RiziaDLC.Decision_Turn08_RRGNationalization_ByCash == true || RiziaDLC.Decision_Turn08_RRGNationalization_ByForce == true`

### Turn 10

#### Step 1
- **`Turn10_RelationshipAnnouncement`** `[Conversation]`
  - Title: **Morning in the Palace**
  - Dialogue Asset: `Rizia/Turn 10/RelationshipAnnouncement`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `((RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false) || (RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Pabel_Gone == false))`

#### Step 2
- **`Turn10_P_BirthdayGathering`** `[Conversation]`
  - Title: **Birthday Gathering of Queen Mother Estela**
  - Dialogue Asset: `Rizia/Turn 10/Birthday_Gathering`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.BirthdayGathering_ReformTalks == false && RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == false`
- **`Turn10_P_BirthdayGathering_ReformTalks`** `[Conversation]`
  - Title: **Reform Talks At Queen Mother's Birthday**
  - Dialogue Asset: `Rizia/Turn 10/Birthday_Gathering`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.BirthdayGathering_ReformTalks == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`

#### Step 3
- **`Turn10_Reform_ConstitutionSigning`** `[Conversation]`
  - Title: **Signing the 1958 Rizian Charter of Fundamental Law**
  - Dialogue Asset: `Rizia/Turn 10/Reform_ConstitutionSigning`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Path_Cancelled == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 4
- **`Turn10_A_CouncilMeet`** `[Conversation]`
  - Title: **Meeting with the Royal Council**
  - Dialogue Asset: `Rizia/Turn 10/CouncilMeeting`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `(RiziaDLC.Theocracy_Full == true || RiziaDLC.Reform_Success == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true || (RiziaDLC.HouseAzaro_Conquered == true && RiziaDLC.Council_Security_Titus == false) || (RiziaDLC.HouseToras_Conquered == true && RiziaDLC.Council_GrandVizier_Hugo == true)) && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 5
- **`Turn10_Decision_Ceasefire`** `[Decision]`
  - Title: **Pales Offers Peace**
  - Condition: `RiziaDLC.War_RumburgCeasefireRequested == true && RiziaDLC.War_ParliamentProposesPeace == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
  - OnEnd: `RiziaDLCSupport.News_Turn10_RH_Decision_War_Ceasefire = true;`
- **`Turn10_Bill_PeaceWithPales`** `[SystemFragment/Other]`

#### Step 6
- **`WarFragment_2_3`** `[SystemFragment/Other]`
- **`Turn10_Decision_War_Skipped_VinaRescue`** `[Decision]`
  - Title: **Princess Vina's Rescue**
  - Condition: `RiziaDLC.Pales_War == true && RiziaDLC.War_Control_Skipped == true && RiziaDLC.Vina_Hostage == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 7
- *OnStepStart:* `EvaluateConditionalInstruction("Operation_2_Result");`
- **`Turn10_VinaRescueOutcome`** `[Conversation]`
  - Title: **Four Minutes Past Midnight**
  - Dialogue Asset: `Rizia/Turn 10/VinaRescueOutcome`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `(RiziaDLC.Vina_Rescue_Success == true || RiziaDLC.Vina_Rescue_Failed == true || RiziaDLC.Pales_War == false) && RiziaDLC.Vina_Hostage == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 8
- **`Turn10_VinaFuneral`** `[Conversation]`
  - Title: **Funeral of Princess Vina**
  - Dialogue Asset: `Rizia/Turn 10/VinaFuneral`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Vina_Rescue_Failed == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 9
- **`Turn10_War_Pales_Loss`** `[Conversation]`
  - Title: **State of the Palesian War**
  - Dialogue Asset: `Rizia/Turn 10/War_Pales_Loss`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.War_Pales_Loss == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_War_Pales_VictoryParade`** `[Conversation]`
  - Title: **Victory Parade**
  - Dialogue Asset: `Rizia/Turn 10/War_Pales_VictoryParade`
  - Map Token: `Rizia_Event_InvasionOfPales`
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 10
- **`Turn10_War_Pales_PeaceTreaty_Konstantium`** `[Conversation]`
  - Title: **Treaty of Konstantium**
  - Dialogue Asset: `Rizia/Turn 10/War_Pales_PeaceTreaty`
  - Map Token: `Rizia_Country_Kyrute`
  - Condition: `((RiziaDLC.War_ParliamentProposesPeace == true && RiziaDLC.Decision_Turn10_Ceasefire_Accepted == true) || RiziaDLC.War_Pales_Loss_SueForPeace == true) && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_War_Pales_PeaceTreaty_Pales`** `[Conversation]`
  - Title: **Treaty of Pales**
  - Dialogue Asset: `Rizia/Turn 10/War_Pales_PeaceTreaty`
  - Map Token: `Rizia_Event_InvasionOfPales`
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_War_Pales_PeaceTreaty_Thornborough`** `[Conversation]`
  - Title: **Treaty of Thornborough**
  - Dialogue Asset: `Rizia/Turn 10/War_Pales_PeaceTreaty`
  - Map Token: `Rizia_Country_Rumburg`
  - Condition: `RiziaDLC.War_RumburgCeasefireRequested == true && RiziaDLC.Decision_Turn10_Ceasefire_Accepted == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_AxelVinaUnity`** `[Conversation]`
  - Title: **At the Beach With Axel Reinhart**
  - Dialogue Asset: `Rizia/Turn 10/AxelVina_Unity`
  - Map Token: `Rizia_City_Monqiz`
  - Condition: `RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Pales_Rizia_PreparationsUnification == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 11
- **`Turn10_Decision_PalesReconstruction_Annex_DariaPM`** `[Decision]`
  - Title: **Reconstruction of the Province of Pales**
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == true && RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_Annexation == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_Decision_PalesReconstruction_Annex_NoReform`** `[Decision]`
  - Title: **Reconstruction of Reclaimed Territories**
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == false && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_Annexation == true && RiziaDLC.War_WehlenJoined == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_Decision_PalesReconstruction_Annex_NoReform_Wehlen`** `[Decision]`
  - Title: **Reconstruction of Reclaimed Territories**
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == false && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_Annexation == true && RiziaDLC.War_WehlenJoined == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_Decision_PalesReconstruction_PalesDivided_NoReform`** `[Decision]`
  - Title: **Reconstruction of Reclaimed Territories**
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == false && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true && RiziaDLC.War_Outcome_Aureus == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_Decision_PalesReconstruction_PalesDividedAndAureus_NoReform`** `[Decision]`
  - Title: **Reconstruction of Reclaimed Territories**
  - Condition: `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == false && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true && RiziaDLC.War_Outcome_Aureus == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 12
- **`Turn10_Security_LucitaOrTitus`** `[Conversation]`
  - Title: **Results of the Valero Toras Murder Investigation**
  - Dialogue Asset: `Rizia/Turn 10/Security_LucitaOrTitus`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.SkipToEpilogue == false && RiziaDLC.PoisonInvestigation_Continues == true && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.SkipToEnding == false`
- **`Turn10_Bill_RemoveDeathPenalty`** `[SystemFragment/Other]`

#### Step 13
- **`Turn10_ExecutionDecisions`** `[Conversation]`
  - Title: **Fate of the Prisoners**
  - Dialogue Asset: `Rizia/Turn 10/ExecutionDecisions`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Taddeus_Arrested == true || RiziaDLC.Manus_Arrested == true || (RiziaDLC.Rico_Arrested == true && RiziaDLC.Rico_Extradited == false) || RiziaDLC.Sal_Arrested == true || RiziaDLC.Rusty_Arrested == true || RiziaDLC.Axel_Arrested == true || RiziaDLC.Pabel_Arrested == true || RiziaDLC.Titus_Arrested == true || RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Angelica_Arrested == true || RiziaDLC.Hugo_Arrested == true) && RiziaDLC.Policy_RD_Welfare_RemoveDeathPenalty == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false && RiziaDLC.Reform_Success == false`

#### Step 14
- **`Turn10_Executions_Citadel`** `[Conversation]`
  - Title: **Executions**
  - Dialogue Asset: `Rizia/Turn 10/Executions`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Executions_Publicity_NoOne == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_Executions_Palace`** `[Conversation]`
  - Title: **Executions**
  - Dialogue Asset: `Rizia/Turn 10/Executions`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Executions_Publicity_OnlyNobles == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn10_Executions_Plaza`** `[Conversation]`
  - Title: **Executions**
  - Dialogue Asset: `Rizia/Turn 10/Executions`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Executions_Publicity_Everyone == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 15
- **`Turn10_P_HODShutdown`** `[Conversation]`
  - Title: **A Final Visit to the House of Delegates**
  - Dialogue Asset: `Rizia/Turn 10/HODShutdown`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.HouseOfDelegates_Abolished == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 16
- *OnStepStart:* `EvaluateConditionalInstruction("LucitaLateArrestFallout");`
- **`Turn10_Succession`** `[Conversation]`
  - Title: **Announcement of the Prince-To-Be**
  - Dialogue Asset: `Rizia/Turn 10/SuccessionAnnouncement`
  - Map Token: `Rizia_City_Monqiz`
  - Condition: `(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false) && RiziaDLC.SkipToEpilogue == false && RiziaDLC.Ending_Coup_Reform == false && RiziaDLC.SkipToEnding == false`

#### Step 17
- *OnStepStart:* `EvaluateConditionalInstruction("Council_Petitions");`
- **`Turn10_Decision_CouncilShuffle`** `[Decision]`
  - Title: **Petition to Change Council Members**
  - Condition: `RiziaDLC.Reform_Success == false && RiziaDLC.Theocracy_Full == false && (RiziaDLC.CouncilPetition_ForeignAffairs_Vina == true || RiziaDLC.CouncilPetition_GrandVizier_Angelica == true || RiziaDLC.CouncilPetition_GrandVizier_Axel == true || RiziaDLC.CouncilPetition_GrandVizier_Sal == true || RiziaDLC.CouncilPetition_Security_Rico == true || RiziaDLC.CouncilPetition_Security_Taddeus == true || RiziaDLC.CouncilPetition_Security_Titus == true || RiziaDLC.CouncilPetition_Treasurer_Daria == true || RiziaDLC.CouncilPetition_Treasurer_Rusty == true) && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 18
- **`Turn10_A_HearingOfPetitions`** `[Conversation]`
  - Title: **Hearing of Petitions**
  - Dialogue Asset: `Rizia/Turn 10/A_HearingOfPetitions`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Turn10_Decision_AcceptCouncilShuffle == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
  - OnEnd: `EvaluateConditionalInstruction("Council_ForeignAffairs");
EvaluateConditionalInstruction("Council_GrandVizier");
EvaluateConditionalInstruction("Council_GrandWiseman");
EvaluateConditionalInstruction("Council_TreasuryEconomy");
EvaluateConditionalInstruction("Council_WarInternalSecurity");`
- **`Turn10_ReverseRRGNationalization`** `[SystemFragment/Other]`
- **`Turn10_RRGNationalization`** `[SystemFragment/Other]`

### Turn 11

#### Step 1
- **`Turn11_A_TheocracyDeclaration`** `[Conversation]`
  - Title: **Theocracy Declaration Speech**
  - Dialogue Asset: `Rizia/Turn 11/A_TheocracyDeclaration`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Theocracy_Full == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.Sal_Arrested == false && RiziaDLC.Sal_Executed == false && RiziaDLC.SkipToEnding == false`
- **`Turn11_A_NewGovernment_Default`** `[Conversation]`
  - Title: **Midday At the Palace**
  - Dialogue Asset: `Rizia/Turn 10/NewGovernment_Default`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Reform_Success == false && RiziaDLC.Theocracy_Full == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`
- **`Turn11_A_TalkWithPrimeMinister`** `[Conversation]`
  - Title: **On the Way to the House of Delegates**
  - Dialogue Asset: `Rizia/Turn 10/TalkWithPrimeMinister`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Reform_Success == true && RiziaDLC.Theocracy_Full == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 2
- **`Turn11_A_CoupWarning`** `[Conversation]`
  - Title: **A Quiet Afternoon**
  - Dialogue Asset: `Rizia/Turn 11/CoupWarning`
  - Map Token: `Rizia_City_Monqiz`
  - Condition: `(RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

#### Step 3
- **`Turn11_Ending_Coup_HouseFallouts`** `[Conversation]`
  - Title: **Night Time**
  - Dialogue Asset: `Rizia/Turn 11/Ending_Coup_HouseFallouts`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `(RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Sazon == true ||
RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.SkipToEpilogue == false`
- **`Turn11_Ending_Revolution`** `[Conversation]`
  - Title: **Measures Against the Revolution**
  - Dialogue Asset: `Rizia/Turn 11/Ending_Revolution`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Ending_Revolution == true && RiziaDLC.SkipToEpilogue == false`
- **`Turn11_Ending_Speech`** `[Conversation]`
  - Title: **Address to the Nation**
  - Dialogue Asset: `Rizia/Turn 11/Ending_Speech`
  - Map Token: `Rizia_City_PorteDrazon`
  - Condition: `RiziaDLC.Ending_Coup_Azaro == false &&
RiziaDLC.Ending_Coup_Sazon == false &&
RiziaDLC.Ending_Coup_Toras == false &&
RiziaDLC.Ending_Coup_Reform == false &&
RiziaDLC.Ending_Revolution == false && RiziaDLC.SkipToEpilogue == false`

