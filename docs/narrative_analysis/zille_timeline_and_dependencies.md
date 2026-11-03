# Zille & Wehlen Arc: Turn-by-Turn Event Timeline & Dependencies

Extracted from vanilla `_GameFlow`, `ConversationData`, and `DecisionData`. This maps all official triggers involving Zille, Wiktor Smolak, Wehlen, the Bombing, Su Omina, ATA, and the Zille Handover.


## Turn 2

### `Turn02_P_VinaTalk` (Conversation) - Step 4
- **Title:** Conversation with Vina
- **Dialogue:** `Rizia/Turn 2/P_VinaAtMonqiz`
- **Token:** `Rizia_City_Monqiz`

### `Turn02_FPnT_ZilleFriendshipDay` (Conversation) - Step 6
- **Title:** Wehzek-Rizian Friendship Day
- **Dialogue:** `Rizia/Turn 2/FPnT_ZilleVisit`
- **Token:** `Rizia_Event_Zille`


## Turn 3

### `Turn03_SnO_ZilleIncidentBrief` (Conversation) - Step 1
- **Title:** Update on the Zille Incident
- **Dialogue:** `Rizia/Turn 3/SnO_ZilleSecurityDebrief`
- **Token:** `Rizia_City_PorteDrazon`

### `Turn03_Decision_ZilleBombDenounceSO` (Decision) - Step 1
- **Title:** Statement on the Zille Incident
- **Condition:** `RiziaDLC.ZilleSecurityDebriefFinished == true`

### `Turn03_Decision_ZilleBombApology` (Decision) - Step 1
- **Title:** Apologize for Inflammatory Speech
- **Condition:** `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`


## Turn 4

### `Turn04_Decision_WehlenIntelligence_Cooperate` (Decision) - Step 5
- **Title:** Request for Cooperation from Wehlen

### `Turn04_Decision_War_UpgradeProductionLinesOne` (Decision) - Step 8
- **Title:** Upgrade Military Production Lines
- **Condition:** `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed == true || RiziaDLC.Policy_RD_Order_FighterPlaneFactory_Completed == true`


## Turn 5

### `Turn05_FPnT_WehlenNegotiations` (Conversation) - Step 1
- **Title:** New Bilateral Agreement Discussions with Wehlen
- **Dialogue:** `Rizia/Turn 5/FPnT_WehlenNegotiations`
- **Token:** `Rizia_City_PorteDrazon`

### `Turn05_Decision_ZilleResistanceFunding` (Decision) - Step 2
- **Title:** Resistance Funding in Zille

### `Turn05_P_ManusVinaTalk` (Conversation) - Step 10
- **Title:** Visit to the Esqiris Gas Field
- **Dialogue:** `Rizia/Turn 5/P_ManusVinaTalk`
- **Token:** `Rizia_City_Topes`


## Turn 6

### `Turn06_SnO_Incident` (Conversation) - Step 4
- **Title:** Late Night at the Palace
- **Dialogue:** `Rizia/Turn 6/SnO_Incident`
- **Token:** `Rizia_City_PorteDrazon`
- **Condition:** `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`

### `Turn06_FPnT_PalesPostIncidentMeeting` (Conversation) - Step 5
- **Title:** Meeting with Duke Reinhart About the Incident
- **Dialogue:** `Rizia/Turn 6/SnO_PalesPostIncidentMeeting`
- **Token:** `Rizia_Country_Pales`
- **Condition:** `RiziaDLC.Diplomacy_Pales_PrepareForWar == false && RiziaDLC.Diplomacy_Pales_DeclareWar == false && (RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`

### `Turn06_Decision_SuOminaDestabilization_PenaltyWarning` (Decision) - Step 6
- **Title:** Reports of Parallel Enforcement Activities
- **Condition:** `RiziaDLC.Situation_Order_SuOmina_Destabilizing == true && RiziaDLC.Situation_Order_CentralizedSecurity == false`
- **OnEnd:** `RiziaDLC.Decision_Floating_SuOminaDestabilization_PenaltyWarning = true`

### `Turn06_SnO_BorderInvestigationResults` (Conversation) - Step 8
- **Title:** Investigation Results
- **Dialogue:** `Rizia/Turn 6/A_BorderInvestigationResults`
- **Token:** `Rizia_City_PorteDrazon`
- **Condition:** `RiziaDLC.PostIncident_Border_JointInvestigation == true`

### `Turn06_Decision_CigarettesFloodMarket` (Decision) - Step 9
- **Title:** Cigarettes Flood Market
- **Condition:** `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true`

### `Turn06_FPnT_PalesDealSigning` (Conversation) - Step 10
- **Title:** Official Signing of the Aureus Agreement
- **Dialogue:** `Rizia/Turn 6/SnO_PalesDealSigning`
- **Token:** `Rizia_Country_Pales`
- **Condition:** `(RiziaDLC.Pales_War == false && RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false) || RiziaDLC.Pales_PostIncident_Peace_Deal == true`

### `Turn06_Decision_SabotagePalesianDefences` (Decision) - Step 13
- **Title:** Rizian Intelligence Sabotage Plans
- **Condition:** `(RiziaDLC.Security_Pales_SendSpecialOps == true || RiziaDLC.Turn05_Security_InvestigateBombingPales == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Pales_War == true`
- **OnEnd:** `RiziaDLCSupport.Reports_Turn06_Pales_Decision_SabotagePalesianDefences = true;`

### `Turn06_Decision_War_UpgradeProductionLinesTwo` (Decision) - Step 14
- **Title:** Upgrade Military Production Lines
- **Condition:** `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed == true || RiziaDLC.Policy_RD_Order_FighterPlaneFactory_Completed == true`


## Turn 7

### `Turn07_Decision_SuOminaDestabilization_Penalty` (Decision) - Step 1
- **Title:** Su Omina Undermines Civil Enforcement
- **Condition:** `RiziaDLC.Decision_Floating_SuOminaDestabilization_PenaltyWarning == true && RiziaDLC.Situation_Order_SuOmina_Destabilizing == true && RiziaDLC.Situation_Order_CentralizedSecurity == false`

### `Turn07_Decision_War_Both_WehlenDrugs` (Decision) - Step 3
- **Title:** Medical Supplies from Wehlen
- **Condition:** `RiziaDLC.Pales_War == true && RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true`

### `Turn07_Decision_SecondZilleResistanceFunding` (Decision) - Step 5
- **Title:** Funding Resistance in Zille Territory

### `Turn07_FPnT_DukeVisit` (Conversation) - Step 10
- **Title:** Duke Reinhart's Visit
- **Dialogue:** `Rizia/Turn 7/FPnT_DukeVisit`
- **Token:** `Rizia_City_PorteDrazon`
- **Condition:** `RiziaDLC.Pales_War == false && RiziaDLC.Pales_PostIncident_Peace_NoDeal == false`

### `Turn07_Decision_Manus_Gone_Disappeared` (Decision) - Step 10
- **Title:** Protests Over Manus Sazon’s Disappearance and RPP Leadership Struggle
- **Condition:** `RiziaDLC.SuOmina_OrderedToKillManus == true`

### `Turn07_Decision_RoyalYachtRestorationFinal` (Decision) - Step 11
- **Title:** Final Phase of Royal Yacht Restoration
- **Condition:** `RiziaDLC.Decision_Turn06_YachtRestoration_PayAdditionalCosts == true || RiziaDLC.Decision_Turn06_YachtRestoration_PayWithWehlenTimber == true || RiziaDLC.Decision_Turn06_YachtRestoration_PayWithRizianTimber == true`


## Turn 8

### `Turn08_SnO_SecurityBriefAndZille` (Conversation) - Step 1
- **Title:** Security Council Meeting
- **Dialogue:** `Rizia/Turn 8/SnO_SecurityBriefAndZille`
- **Token:** `Rizia_City_PorteDrazon`

### `Turn08_Decision_War_Both_FuelAllocation` (Decision) - Step 3
- **Title:** Fuel Allocation Prioritization
- **Condition:** `RiziaDLC.Pales_War == true && (RiziaDLC.Army_Unit_Fighter_Total >= 1 && RiziaDLC.Army_Unit_Bomber_Total >= 1)`

### `Turn08_Decision_War_UpgradeProductionLinesThree` (Decision) - Step 3
- **Title:** Upgrade Military Production Lines
- **Condition:** `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_BomberPlaneFactory_Completed == true || RiziaDLC.Policy_RD_Order_FighterPlaneFactory_Completed == true`

### `Turn08_Decision_SurplusOfMedicine` (Decision) - Step 7
- **Title:** Surplus of Medicine
- **Condition:** `RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true || RiziaDLC.Decision_Turn08_NewManufacturing_Pharma == true`

### `Turn08_FPnT_ZilleNegotiations` (Conversation) - Step 12
- **Title:** Negotiations with President Smolak
- **Dialogue:** `Rizia/Turn 8/FPnT_ZilleNegotiations`
- **Token:** `Rizia_Country_Wehlen`

### `Turn08_Decision_MediateDerdiaWehlen` (Decision) - Step 14
- **Title:** Derdia and Wehlen Request Diplomatic Mediation
- **Condition:** `RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Resources_Budget >= 1 && RiziaDLC.ZilleReturn_Success == true && (RiziaDLC.CountryRelation_Wehlen_Friendly == true || RiziaDLC.CountryRelation_Wehlen_Allied == true) && (RiziaDLC.CountryRelation_Derdia_Friendly == true || RiziaDLC.CountryRelation_Derdia_Allied == true) && RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`

### `Turn08_Decision_WineExportsQuadruple` (Decision) - Step 16
- **Title:** Wine Exports Quadruple
- **Condition:** `(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true && RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false) ||(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true && RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true && RiziaDLC.Valenqiris_EnvironmentCrisisTackled == true)`
- **OnEnd:** `RiziaDLC.Resources_Budget += 3;
RiziaDLCSupport.Reports_Turn08_Qalus_WineExportsQuadruple = true;
RiziaDLCSupport.Reports_Turn08_Sordland_WineExportsQuadruple = true;`


## Turn 9

### `Turn9_FPnT_Mediation` (Conversation) - Step 1
- **Title:** Diplomatic Mediations With Derdia
- **Dialogue:** `Rizia/Turn 9/FPnT_Mediation`
- **Token:** `Rizia_City_PorteDrazon`
- **Condition:** `RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true ||RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true||
RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true`

### `Turn09_Decision_SuOmina_Fights_PalesResistance` (Decision) - Step 4
- **Title:** Deploying Su Omina to Occupied Cities
- **Condition:** `RiziaDLC.Pales_War == true && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.War_Pales_Operation1_Won == true`

### `Turn9_FPnT_CallWithSmolak` (Conversation) - Step 8
- **Title:** An Evening in Monqiz
- **Dialogue:** `Rizia/Turn 9/FPnT_CallWithSmolak`
- **Token:** `Rizia_City_Monqiz`
- **Condition:** `RiziaDLC.War_RumburgCeasefireRequested == false && RiziaDLC.Pales_War == true && RiziaDLC.ZilleReferendum_StoppedByAN == false && RiziaDLC.War_Objective_Captured_Pales == false`

### `Turn9_FPnT_ZilleReferendum` (Conversation) - Step 9
- **Title:** Zille Referendum Results
- **Dialogue:** `Rizia/Turn 9/FPnT_ZilleReferendum`
- **Token:** `Rizia_City_Jales`
- **Condition:** `RiziaDLC.ZilleReturn_Success == false && RiziaDLC.ZilleReferendum_StoppedByAN == false && RiziaDLC.ZilleReferendum_SmolakOffer_Accepted == false`

### `Turn9_FPnT_ZilleReferendumInterference` (Conversation) - Step 10
- **Title:** Referendum Interference Results
- **Dialogue:** `Rizia/Turn 9/FPnT_ZilleReferendumInterference`
- **Token:** `Rizia_City_Jales`
- **Condition:** `RiziaDLC.ZilleReferendum_Interfere_Agents == true || RiziaDLC.ZilleReferendum_Interfere_Army == true`

### `Turn9_A_ZilleReturnedSpeech` (Conversation) - Step 12
- **Title:** Return of Zille Speech
- **Dialogue:** `Rizia/Turn 9/A_ZilleReturnedSpeech`
- **Token:** `Rizia_Event_Zille`
- **Condition:** `RiziaDLC.ZilleReturn_Success == true`
- **OnEnd:** `EvaluateConditionalInstruction("MapChange_Zille");`

### `Turn09_Decision_LeaveAllianceOfNations` (Decision) - Step 14
- **Title:** Rizia's State in Alliance of Nations
- **Condition:** `RiziaDLC.Policy_Diplomacy_Intermerkopum == false && (RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true || RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true || RiziaDLC.ZilleReferendum_NotStoppedByAN == true)`


## Turn 10

### `Turn10_Decision_PalesReconstruction_Annex_NoReform` (Decision) - Step 11
- **Title:** Reconstruction of Reclaimed Territories
- **Condition:** `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == false && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_Annexation == true && RiziaDLC.War_WehlenJoined == false && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

### `Turn10_Decision_PalesReconstruction_Annex_NoReform_Wehlen` (Decision) - Step 11
- **Title:** Reconstruction of Reclaimed Territories
- **Condition:** `RiziaDLC.War_Pales_Won == true && RiziaDLC.Reform_Success == false && RiziaDLC.Pales_Reconstruction_EnoughFunds == true && RiziaDLC.War_BorderOutcome_Peace_Annexation == true && RiziaDLC.War_WehlenJoined == true && RiziaDLC.SkipToEpilogue == false && RiziaDLC.SkipToEnding == false`

