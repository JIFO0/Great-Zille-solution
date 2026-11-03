# Rizia/Turn 6/SnO_Incident

- **ID konwersacji:** `359`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/359_SnO_Incident.md`
- **Liczba węzłów dialogowych:** 485
- **Liczba wyborów gracza:** 106

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[81]** Titus Gordion
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Intention_Pales_DeclareWar`
- `RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed`
- `RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed`
- `RiziaDLC.Policy_RD_Order_TankFactory_Completed`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLC.War_Incident_Naval`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina`
- `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_DeclareWar`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Incident_Border_NoAction`
- `RiziaDLC.Incident_Naval_FocusAidOnValero`
- `RiziaDLC.Incident_Naval_FreeShips`
- `RiziaDLC.Incident_Naval_NoRescue`
- `RiziaDLC.Incident_Naval_RescueBoth`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina`
- `RiziaDLCSupport.News_Turn06_G_LandIncident`
- `RiziaDLCSupport.News_Turn06_G_NavalIncident`
- `RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar`
- `RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales`
- `RiziaDLCSupport.News_Turn06_RH_LandIncident`
- `RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression`
- `RiziaDLCSupport.News_Turn06_RH_RecruitementDrive`
- `RiziaDLCSupport.News_Turn06_RH_WhereIsVina`
- `RiziaDLCSupport.News_Turn06_V_LandIncident`
- `RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentFreeShips`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentNoRescue`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentRescueBoth`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentValeroFocus`
- `RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustryOutputIncrease`
- `RiziaDLCSupport.Reports_Turn06_FortAles_CityOnHighAlert`
- `RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion`
- `RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDenouncesWeakness`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront`
- `RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar`
- `RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_CommunicationsBlackout`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina`
- `RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 36

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_DeclareWar`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar`
- `RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales`
- `RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression`
- `RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion`
- `RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval`
- `RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar`
- `RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `-- BORDER INCIDENT HAPPENS - PLAYER DOESNT KNOW;`
- Węzeł `[4]` (Paskal Beniwoll): `-- NAVAL INCIDENT HAPPENS;`
- Węzeł `[18]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[21]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[35]` (Paskal Beniwoll): `AddConversant("Lucita Azaro"); AddConversant("Laurento Esquibel"); AddConversant("Elena Werner");...`
- Węzeł `[86]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- Węzeł `[146]` (Paskal Beniwoll): `AddConversant("Hugo Toras"); AddConversant("Vina Toras"); ;`
- Węzeł `[248]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- *...oraz 28 innych węzłów ze skryptami.*

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
  - -> `[479]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // BORDER INCIDENT HAPPENS - PLAYER DOESNT KNOW)*
- **Efekt (`userScript`):** `-- BORDER INCIDENT HAPPENS - PLAYER DOESNT KNOW;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NAVAL INCIDENT HAPPENS)*
- **Efekt (`userScript`):** `-- NAVAL INCIDENT HAPPENS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I was woken up in the middle of the night by the Golden Guard. Due to the sensitivity of the information, I had to be urgently briefed in person."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know what this is about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus? Why am I being disturbed at this hour?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "On our way to the chambers, we spoke no words to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[12]`
Mówca: **Titus Gordion**
> ""I was told to come and get you, Your Majesty. I believe there is an important situation that needs your immediate attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[13]`
Mówca: **Narrator**
> "When we arrived at the doors to the Council of Chambers, Uncle Hugo greeted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Hugo"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Hugo >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Hugo"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Romus, my boy... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I put on my clothes and followed Titus through the corridors of the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[11]`

### Węzeł `[20]`
Mówca: **Narrator**
> "He tugged on my arm, leaned in, and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""I'm afraid we'll be facing our biggest crisis yet. I must stress -- this is the time everybody needs a calm and resilient leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Make sure you are ready. I'm sure you'll do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[30]`
  - -> `[29]`
  - -> `[31]`

### Węzeł `[25]`
Mówca: **Narrator**
> "He took a long look at me and my clothes that I'd rushed to put on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""Your butler couldn't be summoned in time, I take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "He put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not making this any easier. I need to know what happened. Right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am always ready, uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time for this. Just step inside and let me in, so we can discuss it properly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be cryptic with me. You are supposed to be my Grand Vizier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""You are right. Let's just go in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""I'm glad to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He opened the doors for us and we entered a scene of barely restrained chaos. The councillors were already gathered inside, their faces etched with lines of worry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");
AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Sal Ignacius");
RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Sal Ignacius");
RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
Mówca: **Narrator**
> "As the king, I knew such a summons could only mean dire news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Upon my entrance, they all stood up immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[38]`
Mówca: **Lucita Azaro**
> ""Your Majesty... We have an emergency to report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[39]`
Mówca: **Lucita Azaro**
> ""A very serious incident at sea, around the Aureus gas field, has unfolded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucita approached me with a calm demeanor that contrasted with the anxious atmosphere inside. She bowed and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Lucita Azaro**
> ""I wish there was another way to put this. The Grand Duchy of Pales has committed an act of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[47]`
  - -> `[52]`
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""A very serious incident at our southern border with Pales has unfolded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An act of war? I'm sure there's a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This sounds serious. Let's just calm down and start from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah... The conflict we've all been waiting for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true || RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true || RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true || RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me what happened. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "Gesture for her to continue."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent and gestured for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Narrator**
> "There was a brief silence. Nobody responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""This is what we know so far...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""About an hour ago, we received grave news. To put it mildly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""Approximately an hour ago, a violent exchange erupted between our soldiers and Palesian forces at our border near Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[58]`
Mówca: **Elena Werner**
> ""Yes. Navar Castle is one of the most well-preserved Rezenid-era paleaccis outside of Pales. It is on a small islet on the River Alca -- directly at our border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`
  - -> `[66]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is something fishy about this. I need more details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are we absolutely sure they shot at us first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what happened to the attackers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I agree. The timing is too perfect. We were about to sign the deal to transfer the extraction rights of Aureus to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""It appears they made a bold and bloody incursion. They've crossed the river and taken refuge in Navar Castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""The paleaccis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the casualties?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's the last straw. If they want war, we'll bring them war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me laugh. Are you saying Pales is invading us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT!? How could such an attack even take place?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Paleaccis? Are you saying they are after a medieval castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""This is highly symbolic though. Pales is the land of the paleaccis. It is their national identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""No, Your Majesty. I would not say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Six of our soldiers, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`
  - -> `[78]`

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""Not necessarily, Your Majesty. I would not say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""I will do everything in my ability to get to the root of this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Divine's embrace be upon them, as they return to the source of all creation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those six represented more than numbers, they were sons of Rizia. Make sure their families are properly taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""Perhaps we may need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And theirs?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""The fact they took control of a paleaccis is highly symbolic. Pales is the land of the paleaccis. It is their national identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Elena Werner**
> ""The choice of the target definitely doesn't seem like a coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""The report from the border force states that our soldiers were patrolling just outside of the castle when they were shot at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[60]`
  - -> `[59]`
  - -> `[61]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the casualties?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[83]`
Mówca: **Laurento Esquibel**
> ""I would advise caution, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""Unfortunately as I've stated before, they have taken refuge in the castle during the firefight and they are still inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[60]`
  - -> `[59]`
  - -> `[94]`
  - -> `[93]`

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""We don't know yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[87]`
Mówca: **Lucita Azaro**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Hugo sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Lucita Azaro**
> ""It is too early to be certain. We are currently relying on the preliminary news we've received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[90]`
Mówca: **Lucita Azaro**
> ""However, the report of the commanding officer implicitly states they were 'attacked' while they were on patrol duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""There is something incredibly shady about this. The timing and how the incident took place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[60]`
  - -> `[94]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lucita Azaro**
> ""It is too early to be certain about anything. We are currently relying on the preliminary news we've received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And do we know how many of them are there right now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The real question is: why are they still alive?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""I would like to know the answer to that question myself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""During the brief firefight, the Palesians managed to cross our border at the Alca River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We need more details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""The commanding officer at the border suspects at least a dozen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""According to one onlooker, the first shot was fired from our side directly from the paleaccis. But I find it hard to believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Esquibel, what is your opinion on this incident?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Laurento looked at her skeptically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[160]`
  - -> `[103]`
  - -> `[104]`
  - -> `[106]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is too early to be certain of anything. We cannot act without establishing proper communication channels with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But what is your opinion, Duchess? Do you believe the reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What say you of this incursion, Hugo, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""You're right, Your Majesty. But it seems Pales didn't care about establishing communication before they killed six of our soldiers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if it's a false flag?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, it's perplexing. The Palesians gain nothing by occupying an old castle within our borders. Especially considering our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Laurento Esquibel**
> ""Someone is trying to sabotage our deal. I think that's clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""It is a possibility. To stir discord among us, or even provoke a harsh retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""As I've said, it is too early to be certain about anything. However, there is no reason to doubt the reports coming from our official channels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""The timing is too perfect for this not to have been planned, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""But it could also be a ruse, a distraction from their true intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`
  - -> `[118]`
  - -> `[119]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And who might that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if it's a false flag? This can be exactly what they are trying to make us think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And those would be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think it could be a false flag operation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""Possibly a false flag operation. To stir discord among us, or even provoke a harsh retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""It can very well turn out to be a false flag operation. To stir discord among us, or even provoke a harsh retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Yes. It could also be a ruse, a distraction from their true intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Pales has long been unfriendly towards us and coveted our lands. They wouldn't want to give away their rights to Aureus so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Lucita scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[125]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, it's perplexing. The Palesians gain nothing by occupying an old castle within our borders. Especially considering our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Laurento Esquibel**
> ""Someone is trying to sabotage our deal. I think that's clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""This is a blunt show of force, a test of our resolve -- right before the signing of our energy deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And who might that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if it's an inside job? Someone who knows our patrols, our weaknesses at the border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""Pales has long been unfriendly towards us and coveted our lands. They wouldn't want to give away their rights to Aureus so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Lucita scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""This is a blunt show of force, a test of our resolve -- right before the signing of our energy deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[137]`
  - -> `[139]`

### Węzeł `[134]`
Mówca: **Laurento Esquibel**
> ""We need to consider all possibilities, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[135]`
Mówca: **Laurento Esquibel**
> ""There is also the possibility that the true provocateur was someone else entirely. An external party who doesn't want us to sign the deal with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[136]`
Mówca: **Laurento Esquibel**
> ""That is a possibility we must seriously consider, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if it's an inside job? Someone who knows our patrols, our weaknesses at the border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I highly doubt that Pales would organize an attack like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Laurento Esquibel**
> ""We must consider the possibility of an inside job as well. Someone who knows our patrols and our weaknesses at the borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[141]`
Mówca: **Laurento Esquibel**
> ""One obvious explanation is that this was an inside job. Someone who knows our patrols and our weaknesses at the borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[145]`
Mówca: **Narrator**
> "When we arrived at the doors to the council chambers, Hugo and Vina greeted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");
AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");
AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""Of course, Uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""Apologies for disturbing both of you at this hour. Thank you for being here so quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""We'll talk about how to handle this situation. Could you tell us the details first, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on. Where is Vina? Did we manage to communicate with her at all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[154]`
Mówca: **Narrator**
> "She pointed at the map showing the border between Rizia and Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "Wait for Lucita to speak."]** — Mówca: **Player_Romus_Italic**
> "I waited for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm getting really worried. Please make it quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""Unfortunately, not yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Laurento Esquibel**
> ""As far as I'm aware, she is supposed to be at the port of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[159]`
Mówca: **Lucita Azaro**
> ""Of course, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is too early to be certain of anything. We cannot act so hastily while the Princess is in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Lucita Azaro**
> ""You're right, Your Majesty. We have to exercise utmost caution. They can even hold her as a hostage if we're not careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[171]`
Mówca: **Vina Toras**
> ""What if it's neither Pales nor treachery within, but another player on the world stage seeking to embroil us in conflict?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Everybody turned towards Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""Lespia would certainly fit that bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "The chamber fell into a restless silence. The theory was as plausible as it was terrifying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Narrator**
> "I looked upon my council, a tableau of concern, ambition and fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[188]`
  - -> `[189]`
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""If that's true, then we fell right into his hands by delivering Vina to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Lucita Azaro**
> ""I'm afraid that's the most likely scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not leap to the drumbeat of war, nor to conclusions. We will investigate this thoroughly. Establish communications with Pales immediately. We will not act until I talk to the Duke myself and demand an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not leap to the drumbeat of war, nor to conclusions. We cannot afford to be hasty while Vina is in their hands. We will not act until I talk to the Duke myself and demand an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. Pales has provoked us for the last time. We will prepare for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough! Pales has dared to shed Rizian blood, and such insolence demands retribution. I will show them the might of our kingdom. Prepare for war!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First, we will get rid of those Palesian soldiers who still have the audacity to occupy our land, and then we will get to the bottom of this. I will not talk to the Duke until those soldiers are dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot allow those soldiers to kill our people and leave our soil unscathed. Make sure they are eliminated or captured immediately. After that's done, I will talk to the Duke and demand an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Lucita Azaro**
> ""Approximately half an hour ago, the ships we sent to enforce our claim to the Aureus gas field fired on and sunk a Palesian vessel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[191]`
Mówca: **Narrator**
> "The councillors fell silent, a shocked look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. Our soldiers will march at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[193]`
Mówca: **Narrator**
> "The councillors fell silent, a resolved look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the commander know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Hugo Toras**
> ""A prudent decision. Our enemies will see hesitation as weakness. We must show them there are repercussions for their actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""I still believe this to be hasty, Your Majesty. We should first hear what they have to say before conducting any operations on the castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[200]`
Mówca: **Vina Toras**
> ""But what if this was indeed an inside job or a third party? I fear this path may lead to unnecessary bloodshed. Don't you think it's best to talk to Duke Reinhart before we act?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Laurento Esquibel**
> ""I agree with Her Highness, Your Majesty. We should first hear what they have to say before conducting any operations on the castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""I believe His Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[203]`
Mówca: **Narrator**
> "The councillors fell silent, a questioning look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[204]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty, but let us not delay. Every moment we ponder, Pales grows bolder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Hugo Toras**
> ""Our enemies will see hesitation as weakness. If we don't show them there are repercussions for their actions, this will only embolden them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[206]`
Mówca: **Laurento Esquibel**
> ""I agree with your decision, Your Majesty. We have to be calm if we want to find out the truth and reach an understanding with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[210]`
Mówca: **Vina Toras**
> ""I support the decision. We have to be calm if we want to find out the truth and reach an understanding with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[211]`
Mówca: **Lucita Azaro**
> ""The squad on duty was forced to fall back. As a result, the Palesians managed to enter the castle. The commander reported they have surrounded them but waiting for orders before taking any actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[212]`
Mówca: **Lucita Azaro**
> ""Their other two vessels were immediately surrounded. They are still being kept at the location of the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Hugo Toras**
> ""It's an outrage! They were warned, yet they encroached upon the field, knowing that our navy would defend it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""According to our reports, a small fleet of three Palesian ships advanced directly at our ships despite repeated warnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""The vessel that was sunk was not only warned, it managed to ram into our flagship -- RRN Valero -- damaging it almost beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Lucita Azaro**
> ""Our fleet then acted in retaliation, discharging its weapons at the Palesians and sinking one of their ships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[220]`
Mówca: **Hugo Toras**
> ""We'll talk about how to handle this situation. Could you tell us the details first, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on. Vina is still in Pales. Did we manage to communicate with her at all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
Mówca: **Narrator**
> "She pointed at the freshly printed report on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
**[WYBÓR GRACZA: "Wait for Lucita to speak."]** — Mówca: **Player_Romus_Italic**
> "I waited for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time to read all that. Tell me exactly what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""Unfortunately, not yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Laurento Esquibel**
> ""As far as I'm aware, she is supposed to be at the port of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""Of course, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[228]`
Mówca: **Elena Werner**
> ""That's true. Our fleet only acted in defense of our nation's asset. But this is still a disaster. The sinking of a ship is a grave matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[233]`
  - -> `[231]`
  - -> `[232]`
  - -> `[366]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the casualties?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's the last straw. If they want war, we'll bring them war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. Can you go back to the part where they rammed into our flagship?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT!? How can you let such an incident take place?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the extent of the damage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""Perhaps we may need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Laurento Esquibel**
> ""I would advise caution, Your Majesty. Why don't we go over the report first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
Mówca: **Lucita Azaro**
> ""The admiral was given the authority to do *whatever it takes* not to let Palesian ships into the field, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Lucita Azaro**
> ""I'm afraid it was the Palesians who forced our hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Lucita Azaro**
> ""I know it sounds ridiculous, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Elena Werner**
> ""It seemed to be a very intentional attack to provoke a response from us. And I think they have already succeeded in their plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""I share the same opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[241]`
Mówca: **Lucita Azaro**
> ""Severe, Your Majesty. The impact compromised the hull's integrity, causing significant flooding in the engine room and adjacent compartments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""The admiral is waiting for your orders on how to deal with the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[243]`
Mówca: **Lucita Azaro**
> ""We're still ascertaining the full extent, but preliminary reports suggest multiple injuries aboard the Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Divine's embrace be upon them, as they are healed by the source of all creation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope for the Duke's sake that we have no Rizian casualties on board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And theirs?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""We don't know yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[249]`
Mówca: **Narrator**
> "Hugo sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NavalIncidentHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[256]`
  - -> `[260]`
  - -> `[274]`
  - -> `[263]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How did the engagement come to pass?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. We can't spend any more time on this. We need to talk action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Lucita Azaro**
> ""According to the report, around 0400 hours, our naval forces, consisting of the flagship RRN Valero and three frigates, were patrolling the field, when the Palesian fleet, composed of three armed vessels, approached the disputed zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Lucita Azaro**
> ""Despite repeated warnings, they continued their advance -- executing aggressive maneuvers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Lucita Azaro**
> ""The vessel that initiated the conflict attempted to bypass our blockade, accelerating towards the RRN Valero. In a reckless act, it rammed our flagship on the starboard side near the engine room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare they...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will pay for what they've done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NavalIncidentHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""The Valero's propulsion system is heavily damaged, rendering the ship immobile. It is currently running on emergency power, but the flooding is critical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Lucita Azaro**
> ""The damage control teams are working tirelessly, but without external assistance, the risk of losing the flagship is very high. We estimate approximately 150 sailors are engaged in containment efforts as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the reports. How do you think we should respond?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[273]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""Reinhart is playing a dangerous game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NavalIncidentHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the Palesian ship?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds incredibly serious. We can't afford to lose our most valuable vessel by an attack like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""Therefore we must act quickly, Your Majesty. Our fleet requires all the help we can give.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[270]`

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""It sustained catastrophic damage post-collision. Seconds after the collision, it was shot at by multiple shots by our frigates. It capsized minutes after the ramming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""However, there are reasons to believe the collision was enough for it to sink -- and our shots may not be the main reason. It is too early to tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Lucita Azaro**
> ""Our initial reports indicate survivors, but they are in perilous waters, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Laurento Esquibel**
> ""We can't simply let them drown. We have to do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""We need our efforts focused on saving the Valero and our sailors inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the remaining Palesian vessels?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Lucita Azaro**
> ""The remaining two, upon seeing their companion's fate, ceased their advance and are currently held at a standoff distance. They're completely surrounded and outgunned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[289]`
Mówca: **Hugo Toras**
> ""I agree. The admiral is waiting for our decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Hugo Toras**
> ""We should consider capturing their remaining ships as a bargaining chip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Elena Werner**
> ""As I understand, we already have them surrounded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Yes, we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[297]`
Mówca: **Lucita Azaro**
> ""Additionally, it is reported that there are survivors from the colliding ship. These are perilous waters, Your Majesty, so we do not know if we'll be able to manage a complete rescue operation without any help arriving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""Our fleet is currently fully focused on holding the remaining vessels in place, while trying to help the RRN Valero contain the flooding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`
  - -> `[301]`
  - -> `[302]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro, what is the current status of the Palesian sailors? Do you think they can be saved?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the distance to the nearest Rizian port for additional support?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are your thoughts, Councillor Esquibel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, what do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""The closest port capable of dispatching a rescue team is on the mainland. Under current conditions, it would take several hours for a rescue team to reach the site.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Elena Werner**
> ""Those sailors don’t have several hours in these waters, Your Grace. We're talking about the open sea, and they're likely without sufficient life-saving equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, leaving the Palesian sailors to fend for themselves could be seen as a severe dereliction of maritime duty. It would damage our international standing and the Duke would paint us as inhumane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Hugo Toras**
> ""This is their game, Councillor Esquibel. We can't let them write the rules for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""However, focusing our efforts on the RRN Valero is crucial. It’s not only about saving our flagship -- which is our most expensive asset in the navy -- but also about preventing further loss of Rizian life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[308]`
Mówca: **Hugo Toras**
> ""They provoked us, Your Majesty. We cannot simply keep playing their game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Hugo Toras**
> ""We need to give a strong response. I don't think we should let those ships go free. We need them as leverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
Mówca: **Lucita Azaro**
> ""Diverting our frigates to rescue could jeopardize the containment efforts on the Valero -- as well as risk the escape of the Palesian vessels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[311]`
Mówca: **Lucita Azaro**
> ""Your Majesty, the sailors from the capsized vessel are in deep waters. Our frigates are currently occupied with both containing the situation aboard the RRN Valero and maintaining a perimeter around the remaining Palesian ships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""This has unfortunately left us with limited resources to mount an immediate rescue operation for the Palesian sailors. We can send a rescue team instead of diverting the resources of our fleet there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[300]`
  - -> `[301]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think their sailors are a priority for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Vina Toras**
> ""What about the sailors waiting for rescue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Elena Werner**
> ""I agree, Your Grace. We need all the leverage against Pales. However, we cannot let them paint us as the aggressors when they clearly initiated the attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Elena Werner**
> ""We should show compassion to their sailors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Narrator**
> "Laurento nodded in approval and quickly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, what do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be honest. This incident is what we needed. Pales has long been a problem for us. We can use this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think Lespia could have any hand in this? This happened right after we cancelled our deal to cede the field to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I have the picture. Any last thoughts before I announce my decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Here is what we'll do...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NavalIncidentHub2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[294]`
  - -> `[327]`
  - -> `[331]`
  - -> `[332]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NavalIncidentDecision)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[355]`
  - -> `[356]`
  - -> `[357]`
  - -> `[350]`

### Węzeł `[336]`
Mówca: **Sal Ignacius**
> ""May the Divine God protect us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[337]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[338]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[339]`
Mówca: **Sal Ignacius**
> ""May St. Wruhec embrace their souls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[340]`
Mówca: **Sal Ignacius**
> ""May St. Wruhec embrace their souls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[341]`
Mówca: **Sal Ignacius**
> ""May the Divine grant you strength, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Hugo Toras**
> ""House Toras expects you to use this opportunity, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Vina Toras**
> ""Father. You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[347]`
Mówca: **Laurento Esquibel**
> ""What does that mean, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NavalIncidentHub2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. Pales has provoked us for the last time. We must prepare for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough! Pales has dared to attack us, and such insolence demands retribution. I will show them the might of our kingdom. Prepare for war!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Narrator**
> "The councillors fell silent, a shocked look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our first duty is to our own. Focus all efforts on the RRN Valero. Dispatch a rescue team from the mainland for the Palesian sailors, but our immediate priority is saving the Valero and its crew. Keep the frigates focused on the Palesian ships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must attempt both rescues. Divert our frigates to aid the Palesian sailors as well as to continue to assist the Valero. Send for the mainland rescue team as backup.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Release the surrounded Palesian ships and instruct them to assist their sailors. Our frigates will focus on the Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not attempt any rescue attempts for their sailors. Focus all rescue efforts on the RRN Valero. Dispatch a rescue team from the mainland for the flagship, but make sure our frigates are locked onto the Palesian ships in the meantime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[359]`
Mówca: **Vina Toras**
> ""We should divert our efforts to rescue their sailors. Our priority should be human lives, regardless if it's Palesian or Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Vina Toras**
> ""And if it was indeed their plan to push us into a corner -- we shouldn't fall for their trap. We should show the world that Rizia has compassion even when attacked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Sal Ignacius**
> ""Wise words, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[362]`
Mówca: **Hugo Toras**
> ""Without a greenlight from Lespia, the Duke would never do something like this. I think the connection is obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Laurento Esquibel**
> ""The Lespians are furious about it. But I don't think would have forced the Palesians to engage us directly like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[364]`
Mówca: **Laurento Esquibel**
> ""Even if that's true, that makes our situation only worse. We cannot afford to go against Lespia while half of the world is backing them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intention_Pales_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intention_Pales_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intention_Pales_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already know about my intentions. We were waiting for them to initiate the attack -- and they did. It's time for us to bring them the war they wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_NoRescue = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentNoRescue = true;
RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests = true;
RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Incident_Naval_NoRescue"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentNoRescue"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests"] = true;
Variable["RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentValeroFocus = true;
RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests = true;
RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentValeroFocus"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests"] = true;
Variable["RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth = true;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentRescueBoth = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentRescueBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FreeShips = true;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentFreeShips = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Incident_Naval_FreeShips"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentFreeShips"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[374]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[375]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Hugo Toras**
> ""It's a risky maneuver, Your Majesty. I hope this does not come at the cost of our flagship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[378]`
Mówca: **Hugo Toras**
> ""It's a risky maneuver, Your Majesty. I hope this does not come at the cost of losing all of our leverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[379]`
Mówca: **Hugo Toras**
> ""It's a sound approach, Your Majesty. Our flagship represents Rizia's strength. We cannot afford to lose it -- nor the ships that attacked us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Elena Werner**
> ""I agree. It makes sense from a resource management perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Elena Werner**
> ""...Of course, the human cost is regrettable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[382]`
Mówca: **Elena Werner**
> ""Juggling both responsibilities will be a challenge, but it may be the best course to mitigate broader consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[383]`
Mówca: **Elena Werner**
> ""Releasing their ships is regrettable, but it may be the best course to mitigate broader consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared = true;
RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_NoAction = true;
RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion = true;
RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDenouncesWeakness = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Incident_Border_NoAction"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDenouncesWeakness"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[386]`
Mówca: **Laurento Esquibel**
> ""This action may have diplomatic repercussions, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[390]`
Mówca: **Vina Toras**
> ""I understand that the safety of our crew must be our paramount concern, but why don't we divert our ships that are already in the scene to help?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Laurento Esquibel**
> ""I agree with Your Highness, Your Majesty. This action may have diplomatic repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Lucita Azaro**
> ""The rescue crew can still make it in time to save everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[393]`
Mówca: **Hugo Toras**
> ""I believe His Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[394]`
Mówca: **Narrator**
> "The councillors fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[407]`
  - -> `[410]`
  - -> `[411]`

### Węzeł `[395]`
Mówca: **Sal Ignacius**
> ""I believe His Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[396]`
Mówca: **Laurento Esquibel**
> ""This is the best course of action in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[400]`
Mówca: **Vina Toras**
> ""I support the decision. This could foster goodwill, despite the complexities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Laurento Esquibel**
> ""I agree with Her Highness, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""Our House and Rizian nationalists would have expected us to use this opportunity, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Hugo Toras**
> ""I can only hope this doesn't turn into a larger problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Sal Ignacius**
> ""I believe Your Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've all already heard my decision. We'll call it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on. I want to hear it. Is there anybody who has the guts to question my decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. Dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was there anything else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Hugo Toras**
> ""I believe that was all, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DeclareWar = true; RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[414]`
Mówca: **Narrator**
> "There was complete silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[415]`
Mówca: **Narrator**
> "The councillors bowed in respect and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[416]`
Mówca: **Hugo Toras**
> ""I didn't expect to hear this, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Hugo Toras**
> ""But if Your Majesty thinks that time has finally come -- so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[418]`
Mówca: **Lucita Azaro**
> ""We've all heard the King, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""Father? Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[426]`
Mówca: **Elena Werner**
> ""I have always been a proponent of peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm surprised you're not on Mr. Esquibel's side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[428]`
Mówca: **Laurento Esquibel**
> ""And Princess Vina, Your Majesty? She's still in Pales, and they might try to keep her after what has happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[448]`
  - -> `[429]`
  - -> `[431]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Request her return immediately. We have to hope they will not do anything insane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sent her there to teach her a lesson. A little time spent as a hostage will only help her learn it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they indeed try to take her as hostage, we'll burn Pales to the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[432]`
Mówca: **Laurento Esquibel**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[433]`
Mówca: **Lucita Azaro**
> ""I wish it had not come to this. But our military is ready to rise to the challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[434]`
Mówca: **Elena Werner**
> ""But in this instance, I cannot ignore the potential economic boom the Aureus field represents...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`
  - -> `[452]`
  - -> `[427]`

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""We've all heard the King, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Lucita Azaro**
> ""I will signal the general staff immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`
  - -> `[439]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. I trust you all to begin the preparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any other questions or comments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Laurento Esquibel**
> ""Is this not reckless, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Narrator**
> "Laurento looked at me but then averted his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[442]`
Mówca: **Laurento Esquibel**
> ""Have we considered all diplomatic avenues? Are we prepared for the repercussions?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[443]`
Mówca: **Laurento Esquibel**
> ""Oh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage = true; 
RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they do, call their bluff. Duke Reinhart knows better than to mess with the Royal Family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[449]`
Mówca: **Narrator**
> "Laurento looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're speaking my language, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely. We cannot become an energy superpower without making sacrifices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This has nothing to do with the gas field. It's blood for blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Laurento Esquibel**
> ""Elena. I'm disappointed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Narrator**
> "Laurento turned to me for one last appeal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[455]`
Mówca: **Elena Werner**
> ""Why? There is a time for diplomacy, and a time for action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[456]`
Mówca: **Narrator**
> "Lucita gave him a furious stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Lucita Azaro**
> ""What are you implying about our intelligence, Mr. Esquibel? Or the loyalty of our military officers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""I didn't want to believe this. But could it be that Axel Reinhart never wanted peace with Rizia in the first place? Was the entire sale of the gas field a charade?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Lucita Azaro**
> ""I almost don't want to say it, but has Pales been playing the long game this entire time? Was Reinhart's supposed friendliness an act to gain our trust and reclaim territory?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval = true;
RiziaDLCSupport.News_Turn06_G_NavalIncident = true;
RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression = true;
RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests = true;
RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_NavalIncident"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_G_LandIncident = true;
RiziaDLCSupport.News_Turn06_RH_LandIncident = true;
RiziaDLCSupport.News_Turn06_V_LandIncident = true;
RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_LandIncident"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LandIncident"] = true;
Variable["RiziaDLCSupport.News_Turn06_V_LandIncident"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_WhereIsVina = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_WhereIsVina"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_WhereIsVina = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_WhereIsVina"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_TankFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_TankFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustryOutputIncrease = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustryOutputIncrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_RecruitementDrive = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_CommunicationsBlackout = true;
RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar = true;
RiziaDLCSupport.Reports_Turn06_FortAles_CityOnHighAlert = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_RecruitementDrive"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_CommunicationsBlackout"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_FortAles_CityOnHighAlert"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Gridlock", "R_Gridlock_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Gridlock","R_Gridlock_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Rizia_Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_ValeroSaved");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_ValeroSaved");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Receiving late-night news of a military incident at sea", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Receiving late-night news of a military incident at sea","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Receiving late-night news of a military incident at the southern border", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Receiving late-night news of a military incident at the southern border","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
