# Rizia/Turn 1/SnO_SecurityMilitaryMeeting

- **ID konwersacji:** `295`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/295_SnO_SecurityMilitaryMeeting.md`
- **Liczba węzłów dialogowych:** 565
- **Liczba wyborów gracza:** 117

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
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Focus_MilitaryBranch_Airforce`
- `RiziaDLC.Focus_MilitaryBranch_Army`
- `RiziaDLC.Focus_MilitaryBranch_Navy`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized`
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Monqiz_Arrests`
- `RiziaDLC.Situation_Military_CombatExperience_Waning`
- `RiziaDLC.Situation_Military_Manpower_High`
- `RiziaDLC.Situation_Military_Manpower_Massive`
- `RiziaDLC.Situation_Military_Stockpile_Full`
- `RiziaDLC.Situation_Military_Stockpile_HalfFull`
- `RiziaDLC.Situation_Military_Stockpile_Low`
- `RiziaDLC.Situation_Military_Stockpile_Overflowing`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn01_Briefing_Intelligence`
- `RiziaDLCIsolated.Turn01_Briefing_InternalSecurity`
- `RiziaDLCIsolated.Turn01_Briefing_Military`
- `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies`
- `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts`
- `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime`
- `RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain`
- `RiziaDLCIsolated.Turn01_Military_Conscription`
- `RiziaDLCIsolated.Turn01_Military_NavyAir`
- `RiziaDLCIsolated.Turn01_Military_Weapons`
- `RiziaDLCIsolated.Turn03_KnifeThrow`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Enable_Policy_RD_Order_AntiDrugOperations`
- `RiziaDLC.Enable_Policy_RD_Order_IncreaseConscriptionDuration`
- `RiziaDLC.Enable_Policy_RD_Order_IncreaseProvincialLevies`
- `RiziaDLC.Enable_Policy_RD_Order_LowerConscriptionAge`
- `RiziaDLC.Enable_Policy_RD_Order_MilitaryEquipmentFactory`
- `RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Enable_Policy_RD_Order_SupportVehicleFactory`
- `RiziaDLC.Enable_Policy_RD_Order_TankFactory`
- `RiziaDLC.Panel_WarProduction`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLCIsolated.Turn01_Briefing_Intelligence`
- `RiziaDLCIsolated.Turn01_Briefing_InternalSecurity`
- `RiziaDLCIsolated.Turn01_Briefing_Military`
- `RiziaDLCIsolated.Turn01_MilitaryQs_Strategies`
- `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts`
- `RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime`
- `RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain`
- `RiziaDLCIsolated.Turn01_Military_Conscription`
- `RiziaDLCIsolated.Turn01_Military_NavyAir`
- `RiziaDLCIsolated.Turn01_Military_Weapons`
- `RiziaDLCIsolated.Turn01_SnO_LaurentoLeft`
- `RiziaDLCIsolated.Turn03_KnifeThrow`
- `RiziaDLCSupport.Codex_Locations_Countries_Lespia`
- `RiziaDLCSupport.Codex_Locations_Countries_Lespia_1950`
- `RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO`
- `RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO1950`
- `RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet`
- `RiziaDLCSupport.News_Turn01_G_LespiaATO`
- `RiziaDLCSupport.Reports_Turn01_Iza_LaborHandsProtest`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 20
- **Węzły modyfikujące stan gry:** 39

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Panel_WarProduction`
- `RiziaDLC.Relations_Lucita_Romance`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[130]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] = true;`
- Węzeł `[196]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] = true;`
- Węzeł `[247]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] = true;`
- Węzeł `[251]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] = true;`
- Węzeł `[271]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] = true;`
- Węzeł `[303]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] = true;`
- Węzeł `[319]` (Paskal Beniwoll): `RemoveConversant("Laurento Esquibel"); ;`
- Węzeł `[356]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn01_G_LespiaATO"] = true;`
- *...oraz 31 innych węzłów ze skryptami.*

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
  - -> `[560]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Laurento Esquibel**
> ""I just received official confirmation that our neighbor has been accepted into the Arcasian Treaty Organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derdia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Laurento Esquibel**
> ""Precisely. Prime Minister Alvarez will make the official announcement tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Lucita Azaro**
> ""Didn't we all see this coming? It should hardly be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""Are you trying to be humorous, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""I'm sure that was a joke. He knows it could only have been Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""Thank you for updating us, Mr. Esquibel. I suggest we set a date for a meeting to discuss Lespia's ATO membership as well as our general foreign policy strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[329]`
  - -> `[328]`

### Węzeł `[13]`
Mówca: **Narrator**
> "I had barely even started my reign, and it already felt like the ground was shifting beneath my feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "What other challenges lay in store?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""Indeed, this development has been on the horizon for some time. But our relations with our neighbors are sure to change because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Narrator**
> "On the way back from the Plavo Archsanctuary, I met my council in the city of Folce Dator for a briefing on our security and military situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "The so-called "Forge of Rizia" was famous for its numerous foundries and factories, in which iron from the nearby hills was transformed into rifles and handguns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Largest of them all was the Royal Folce Foundry, responsible for supplying the Rizian police and military. The red brick complex towered at the end of the King's Avenue, Folce Dator's main road."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[19]`
Mówca: **Narrator**
> "My council and I were given a tour of the facilities before settling around the table in the foundry's Great Hall. Murals on the walls around us depicted the city's history as an industrial center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "As duchess of the province and my war and security councilor, Lucita sat at the head of the table. She nodded at the rest of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""Your Majesty, Your Highness, my esteemed fellow councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""Your Majesty, my esteemed fellow councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""I planned this meeting here so that the King would have a shorter journey after his consecration ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[27]`
Mówca: **Narrator**
> "A corner of her mouth twisted upwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Lucita Azaro**
> ""Serendipitously, His Majesty's wise rejection of the ceremony has left us with more time to spend in this fine city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""I'm sure the proceedings were very taxing, Your Majesty. Whatever they were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[32]`
  - -> `[361]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happened in Plavo is between me and God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're wrong, Duchess Azaro. I have never felt so invigorated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was taxing, for sure. But it was my duty as King to bear that burden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Lucita Azaro**
> ""Let's hope that something useful came out of all that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""I'm glad to hear it. Religion has that effect on some people, I'm told.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Lucita Azaro**
> ""And the Grand Wiseman, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Sal was sitting across from me, still wearing his robes. He smiled enigmatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Sal Ignacius**
> ""I am but a lowly conduit between His Majesty and the powers above, Ms. Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
Mówca: **Sal Ignacius**
> ""Even if you are not a believer, Ms. Azaro, I assure you the six stars of St. Wruhec shine upon your house and our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Sal was sitting across from me, still wearing his robes. He smiled enigmatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Sal was sitting across from me, still wearing his robes. He smiled enigmatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Sal Ignacius**
> ""Religion is not a tool to be used, Ms. Azaro. It is a guiding light that shines even on those who do not believe in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "Hugo nodded approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""I know better than to pry into the contents of the ceremony, Your Majesty. But I will say I hope it was an enlightening experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""You may proceed with your briefing, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""With great pleasure, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "She gestured at one of the murals on the wall. It depicted a beautiful but severe-looking woman riding a horse down the King's Avenue, her rifle at the ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Lucita Azaro**
> ""My ancestress Ana Azaro ordered the construction of this foundry in 1812, immediately after the end of the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Lucita Azaro**
> ""House Azaro knows that 'peacetime' is not a period of rest. It is a time to gather our strength and hone our weapons for when they are next needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""Because they most certainly *will* be needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[52]`
  - -> `[53]`
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a rather pessimistic view, Duchess Azaro. Isn't peace the final state that all nations strive towards?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you completely, Duchess. Rizia has become soft and complacent during these conflict-free years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can also use peacetime to form new alliances and improve international relations. Strength is about more than just weaponry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we should remain vigilant and prepared. But not to the point where our military focus detracts from the needs of the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Laurento Esquibel**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""Alliances can shift. Treaties can be broken. We should not be so naive as to assume every nation will respect diplomatic boundaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Safety is at the top of the hierarchy of our people's needs, is it not? Everything else is optional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""Ideally, maybe. But reality has taught us that peace is fragile. We can only preserve it with hard work and a firm hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Lucita Azaro**
> ""Not without reason, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Our failure to win the Reclamation War and the rebellion of 1926 served as a double blow to the Rizian armed forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Narrator**
> "I could hear the passion rising in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Even after my father purged the troops and general staff of all suspected traitors to the throne, His Majesty King Valero was reluctant to restore our military to its former strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""As a result, Your Majesty, we are ludicrously underprepared for a country of our size.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[466]`
  - -> `[442]`
  - -> `[445]`

### Węzeł `[63]`
Mówca: **Narrator**
> "With lightning speed, she reached under the table, pulled out a knife and hurled it in the direction of the doorway. Titus languidly snatched it out of the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[262]`
  - -> `[256]`
  - -> `[255]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a few more questions regarding the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""I'm here to answer them, Your Majesty. Where should I start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the state of our military production industry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me more about our naval and air capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's talk about army conscription. How do we bolster our ranks?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Does our internal security need improvement as well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Lucita sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""Despite our very grand surroundings, we have long neglected the potential of Folce Dator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Rumburg currently supplies us with the bulk of our weaponry, including their KA-74 rifles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""But if we invested more into research, development and production in this city, our small arms industry could become a real force to be reckoned with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""Our navy has actually made significant strides in the past 30 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Lucita Azaro**
> ""We are a coastal nation, after all, and our fleet is both well-trained and up to date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Our submarines could use improvement, though. Compared to those currently coming out of Rumburg and Valgsland, they're practically ancient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""Our ranks are looking healthy already, Your Majesty. But since you asked...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lucita Azaro**
> ""As you know, our central royal army is fed both by general conscription and levies from the individual provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""If you ask me, the provincial armies should be pulling more weight. Though I do understand that those of Brenas and Valenqiris are not nearly as well trained as Cardesse-Montaklar's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see the need for that. It seems easier and cheaper to continue importing from Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do we have the capability to build larger weapons too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I imagine that would give a boost to the local economy as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to take our diplomatic stance into account. Wouldn't a sudden increase in arms production be seen as provocation by our neighbors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[84]`
Mówca: **Elena Werner**
> ""It would, Your Majesty. As long as there were enough people available to fill the new positions that would be created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""Not currently, Your Majesty. Even if we were able to begin production in that sector immediately, it would take years before our missile technology caught up to, say, Derdia's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`
  - -> `[94]`

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""Producing our own weapons would save us untold amounts in the long run. We could even ask Rumburg for a license to make our own KA-74s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lucita Azaro**
> ""On the other hand, larger arms such as missiles are best purchased from Rumburg. Or barring that, Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Lucita Azaro**
> ""We would unfortunately still have to rely on Rumburg for weaponry such as missiles. Although I've also seen promising developments in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`
  - -> `[94]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. A weapons deal with Derdia could help improve relations between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't bother with Derdia. I'm counting on a stable trade relationship with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt Derdia will sell us weapons considering our religious differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[92]`
Mówca: **Laurento Esquibel**
> ""It would depend on what they'd demand in return, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Laurento Esquibel**
> ""Yes, I'm afraid any negotiation with Derdia would be more trouble than it's worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is ridiculous. What would we need missiles for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""The wars to come will not be fought with guns alone, Your Majesty. We all know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Laurento Esquibel**
> ""Everyone has a price, Your Majesty. It would depend on what Rizia is willing to pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Laurento Esquibel**
> ""But I've set aside time to discuss Derdia during our upcoming foreign policy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[98]`
Mówca: **Laurento Esquibel**
> ""I personally believe attempting to sign an arms deal with Derdia would be more trouble than it's worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""On the contrary, Your Majesty, it might serve as a deterrent. A nation that invests in producing high-quality weaponry is not one that you want to provoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Elena Werner**
> ""Actually, were our foundries in Folce Dator to become productive enough, we could use rifles as yet another trade resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Lucita Azaro**
> ""I suggest we think about procuring larger weapons as well. Derdian missiles, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`
  - -> `[94]`

### Węzeł `[102]`
Mówca: **Lucita Azaro**
> ""I look forward to that conversation, Mr. Esquibel. Where were we, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""Our air force, meanwhile, is still suffering the consequences of the Pales campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == false && RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == false && RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == false  and  Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == false && RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == false  and  Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Hugo wore a disproving look on his face. Across from me, Sal was smiling beatifically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need a ceremony to validate my God-given right to rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My apologies once again, Grand Wiseman Ignacius. I did not mean to disrespect the Wruhecist faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I made the right decision. Arcane religious rituals have no place in modern politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had my reasons for not participating in the ceremony. I don't want any of you questioning them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""Whatever your personal feelings about the ceremony, Your Majesty, Rizia is a Wruhecist country. Breaking such a centuries-old tradition will have repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Sal Ignacius**
> ""These rituals connect us to our past. A good leader draws not only on God for guidance, but on those who came before him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
Mówca: **Sal Ignacius**
> ""Do not chastise your nephew too harshly, Your Grace. King Romus must find the divine path on his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[115]`
Mówca: **Sal Ignacius**
> ""Do not fear, Your Majesty. The divine path is yours to find on your own. Nobody can force you onto it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""Still, Rizia is a Wruhecist country. It might have been wise to participate if only for the public's approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""The public will not approve of your decision, Your Majesty. But perhaps it will command respect among certain international factions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
Mówca: **Sal Ignacius**
> ""Quite right. A man's faith is a personal matter. The King must be allowed to find his path on his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""Halaita, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""But what's been done is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""At any rate... what's been done is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Thank you for your reminder, Grand Wiseman. I am sure he will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Less so, Your Majesty. Our police forces have kept a firm handle on our populace since the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""Civil disobedience in Valenqiris, for example, is at a historic low thanks to your zero-tolerance policies as Duke. Not that it's ever been high in the era of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Arrests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Arrests == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_Arrests == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""Civil disobedience in Montaklar, for example, is at a historic low thanks to my zero-tolerance policies as Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""My own anti-crime efforts in Montaklar appear to be paying off as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_InternalSecurity = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""No, indeed. Iza has been experiencing periods of unrest ever since the handover of Zille and the exile of Duchess Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""Valenqiris, too, is unlikely to pose major difficulties as long as House Toras is on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""The members of House Sazon who rule Brenas have mostly fallen in line following the uprising. They're content to use the House of Delegates as a forum for their grievances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's no surprise that giving part of Brenas to House Toras would divide the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess. The Wehzek and Derdian newcomers have been causing problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew it. The city was always a stronghold for anti-monarchists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Well... ruling the Brenas capital after its transfer to House Toras would not be an easy task for anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Is my cousin failing in his duties as Duke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""And the Central Police, headquartered in Rizia Imperii, have been keeping the capital secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""We are not seeing anti-monarchist activity in Iza, Your Majesty. At least on the surface.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""It's complicated, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Lucita Azaro**
> ""Complicating matters are the large numbers of Wehzek migrants who settled in the city following the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
Mówca: **Narrator**
> "She took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""If there's a problem area, it's Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[136]`
  - -> `[135]`
  - -> `[134]`

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""But we are seeing complications having to do with the Wehzek migrants who settled in the city after the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Lucita Azaro**
> ""Large numbers of migrants, particularly Wehzeks fleeing the civil war, settled in the city in the '30s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Lucita Azaro**
> ""As I mentioned in our earlier meeting, some turned to the black market to supplement their meager 'guest worker' income, giving rise to organized crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[150]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of black-market activities?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't blame them. They had no other choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, you were in Iza during the '30s. Didn't you try and stop this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""The drug trade, mostly. There are cartels connected to families in Wehlen, who in turn answer to powerful distributors in Agard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""We gave them a home and employment, Your Majesty. They chose to abuse our hospitality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""I implemented a community policing program. But the criminal networks were too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Lucita sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Lucita Azaro**
> ""In my opinion, the growing influence of the nationalist group Su Omina has only inflamed tensions in the area.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""I attempted to tackle this myself with a community policing program. But the networks were too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""The King, of course, might disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[165]`
  - -> `[163]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""Certain members of House Toras may disagree, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[163]`
  - -> `[169]`
  - -> `[164]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. A group like Su Omina is a necessary counter-correction to the problems caused by immigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe Su Omina was founded with good intentions. But they may have made things worse without meaning to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree completely. The provocations of people like my cousin will only stoke the flames of violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because I supported the group in my younger days doesn't mean I do now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My cousin Rico has witnessed Iza's problems firsthand. If he supports Su Omina, it must be for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Hugo Toras**
> ""The good Rizians of Iza are doing their best with the resources they've been given, Duchess. My son included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""The problem as I see it lies in the lack of cooperation between the city's police force and those of the surrounding region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Lucita Azaro**
> ""Yes, I've received Duke Rico's complaints that the Brenas forces have not been providing him with as much aid as he wishes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Lucita Azaro**
> ""As well as his requests that extra police from our central forces be transferred to Iza and placed under his command. But I don't think that would solve anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[176]`
  - -> `[178]`
  - -> `[183]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why not, Duchess Azaro? I thought you were tough on crime yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""I believe in the power of a firm hand, Your Majesty. But only when it's exercised with responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would set a dangerous precedent. We can't have the other provinces demanding the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why aren't the Brenas police cooperating?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Lucita Azaro**
> ""They are providing some assistance. But my instinct is that they, like most of House Sazon, disagree with Duke Rico's policies and his associations with Su Omina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""Their political views should not matter. Their job is to protect and serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[181]`
Mówca: **Hugo Toras**
> ""Are you calling my son irresponsible, Duchess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Iza is a special case. I'm sure everyone is aware of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Extra force won't solve anything. We need to get to the root of the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucita Azaro**
> ""Force is absolutely necessary in some circumstances. But it must be wielded with responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Lucita Azaro**
> ""I am saying that in the wrong hands, the Central Police could legitimize Su Omina's campaign of oppression, rather than neutralize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Hugo opened his mouth to respond. Lucita pretended not to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty? Shall we continue with the briefing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[188]`
Mówca: **Lucita Azaro**
> ""I have the situation under control, Your Grace. You don't need to involve yourself with such a minor issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Security/Military Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Security/Military Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[191]`
  - -> `[200]`
  - -> `[273]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about our intelligence capabilities? They're just as important as our military strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[195]`
Mówca: **Lucita Azaro**
> ""The Rizian Intelligence Service has operatives in Morella, Derdia, central Wehlen, Lespia and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Intelligence = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would he do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Lucita Azaro**
> ""He was afraid their leaders would get suspicious. He may have been right, or it may have been his trademark paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure he had a good reason for doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Intelligence == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Intelligence == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Intelligence == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
Mówca: **Lucita Azaro**
> ""His Majesty Valero, however, insisted on withdrawing our presence from Zille and Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[204]`
  - -> `[206]`
  - -> `[199]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. We need to keep a close watch on both of those regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good thinking. We cannot repair our ties with Wehlen and Pales if we don't trust each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_TakeBackLand == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""Yes, my father told him the same thing. He was afraid of drawing their leaders' suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Laurento sniffed indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Laurento Esquibel**
> ""What useful information were we receiving from either region before the operatives' withdrawal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Laurento Esquibel**
> ""In my experience, we have much more to gain from straightforward diplomacy than from cloak-and-dagger operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Lucita Azaro**
> ""Mr. Esquibel, if you think Wehlen and Pales are not spying on Rizia, you're fooling yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""We learned of the prior Duke Njolma's abdication before it was officially announced, for one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[225]`
  - -> `[217]`

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""He believed their leaders were starting to get suspicious of him. He may have been right, or it may have been his trademark paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't count as useful information. It would have come out anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the agents are gone, they're gone. What about domestic intelligence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[218]`
Mówca: **Lucita Azaro**
> ""But by the time it did, we had already determined our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[227]`
  - -> `[241]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Now that they have been withdrawn, it will be a difficult and costly process to get them back into place. But I can inquire into the possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[220]`
  - -> `[230]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please do so immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about our domestic intelligence services?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep up the good work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[223]`
Mówca: **Lucita Azaro**
> ""Domestically, our main intelligence focus has been on preventing another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""To that end, our information gathering has been concentrated in Brenas, where the last anti-monarchist movement originated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[233]`
  - -> `[231]`
  - -> `[237]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can the agents in those regions be placed back in position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That makes sense. Can you put the operatives back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Valenqiris? I tried my best as Duke, but some traitors may have slipped through the cracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Valenqiris? I didn't crack down on traitors as Duke, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, let's keep things as they are. We have other priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't be spying on our own citizens like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[232]`
Mówca: **Lucita Azaro**
> ""I'll update you should major concerns arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Cardesse-Montaklar? The military was involved in the last uprising as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Lucita Azaro**
> ""As I've mentioned, the military has been purged and my province is now under the strictest of control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[235]`
Mówca: **Lucita Azaro**
> ""History has taught us that if we turn a blind eye to potential traitors, we'll be the last to know when they come for our head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[236]`
Mówca: **Hugo Toras**
> ""Rest assured that House Toras will not turn on itself. And it will most certainly not countenance being surveilled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Arrests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Arrests == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_Arrests == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Arrests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Laurento is right. Let's not waste our resources spying on Zille and Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""Any other questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Military sub-hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Weapons == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Weapons == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Military_Weapons == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Weapons = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_NavyAir == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_NavyAir == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Military_NavyAir == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_NavyAir = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. Your house should be commended for its deep devotion to protecting this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You brought a weapon to a council meeting, Duchess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trained at Camp Domus, too. You could've thrown that knife at me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Lucita Azaro**
> ""Another time. If your reflexes haven't gone soft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you insane? You could've hurt someone!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""I wouldn't dream of leaving home without it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[261]`
Mówca: **Lucita Azaro**
> ""Spoken like someone who hasn't gone through our training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You made your point. No need to put on a show.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""Sorry, Your Majesty. The spirit of Ana Azaro must've overtaken me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Narrator**
> "She grinned briefly before regaining her poise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Lucita Azaro**
> ""We're pleased to serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[266]`
Mówca: **Lucita Azaro**
> ""Of course, national security doesn't begin and end with the Rizian military. We also have our police and intelligence divisions to think about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[267]`
Mówca: **Lucita Azaro**
> ""I was getting to that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Military == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Military == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Military == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Military = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to think about. Let's call it a day for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && (RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == true || RiziaDLCIsolated.Turn01_Briefing_Military == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && (RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == true || RiziaDLCIsolated.Turn01_Briefing_Military == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == true  and  (Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Intelligence == true && (RiziaDLCIsolated.Turn01_Briefing_InternalSecurity == true || RiziaDLCIsolated.Turn01_Briefing_Military == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Intelligence"] == true  and  (Variable["RiziaDLCIsolated.Turn01_Briefing_InternalSecurity"] == true  or  Variable["RiziaDLCIsolated.Turn01_Briefing_Military"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[276]`
Mówca: **Lucita Azaro**
> ""Anyway. If we leave soon, we can make it back to Porte Drazon before it gets too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[277]`
Mówca: **Narrator**
> "She signalled to Titus, who tossed her knife back at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Narrator**
> "In one fluid motion, she hiked up her gown, caught the projectile and stowed it in a leather holster strapped to her thigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`
  - -> `[334]`
  - -> `[281]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will remind you that this is a royal court, not a variety theater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Careful with that. I had a... bad dream involving stabbing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lower your hem, Duchess. The Lord frowns upon such indecency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Conscription == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Conscription == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Military_Conscription == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[289]`
Mówca: **Narrator**
> "Laurento nodded grimly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Laurento Esquibel**
> ""We did not foresee that Lespia would become so heavily involved, nor that they would provide the Grand Duchy with cutting-edge aircraft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[297]`
  - -> `[294]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia wouldn't even have those planes if it weren't for their close ties with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So hypothetically speaking, if we tried to reconquer Pales again, they'd rain death on us from above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember when our troops laid eyes on those planes for the first time. Their morale disappeared then and there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're better off strengthening our other divisions than trying to compete with the likes of Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""My father always had terror in his eyes when he spoke of them. The silver falcons...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[299]`
Mówca: **Lucita Azaro**
> ""We can't ignore the possibility of aerial combat. Many battles these days are decided above our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""Hypothetically... yes. We're more well balanced in the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[301]`
Mówca: **Lucita Azaro**
> ""Very true. There is much to criticize about the West, but their technological prowess can't be argued with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Military sub-hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Conscription = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[304]`
Mówca: **Lucita Azaro**
> ""And then there's the question of...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Conscription == true && RiziaDLCIsolated.Turn01_Military_NavyAir == true && RiziaDLCIsolated.Turn01_Military_Weapons == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Military_Conscription == true && RiziaDLCIsolated.Turn01_Military_NavyAir == true && RiziaDLCIsolated.Turn01_Military_Weapons == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Military_Conscription == true && RiziaDLCIsolated.Turn01_Military_NavyAir == true && RiziaDLCIsolated.Turn01_Military_Weapons == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Military_Conscription"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_NavyAir"] == true  and  Variable["RiziaDLCIsolated.Turn01_Military_Weapons"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[248]`
  - -> `[286]`

### Węzeł `[308]`
Mówca: **Narrator**
> "The heavy wooden door to the hall creaked open. An aide rushed over to Laurento and whispered something in his ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Laurento Esquibel**
> ""I see. I'll get to a telephone right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Narrator**
> "He turned to the rest of us, his usual jocular expression overlaid with concern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Laurento Esquibel**
> ""I must excuse myself briefly, ladies and gentlemen. Please continue without me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be excused, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fine. None of these topics concern you, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[315]`
Mówca: **Laurento Esquibel**
> ""I will explain once I have all the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
Mówca: **Laurento Esquibel**
> ""Thank you, Your Majesty. I'll explain everything shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Laurento Esquibel**
> ""Our security and foreign policy are quite intertwined, Your Majesty. Nonetheless, I trust Duchess Azaro to provide you with all relevant details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Narrator**
> "He gave a quick bow, then rushed out of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `RemoveConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Lucita Azaro**
> ""Hmm. I wonder what that could be about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""It was nothing. In my fitter days I could do it hands-free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""Danger can strike at any time, Your Majesty. Even here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[323]`
Mówca: **Lucita Azaro**
> ""Nobody's getting stabbed on my watch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[324]`
Mówca: **Sal Ignacius**
> ""Indeed, modesty is one of the essential virtues of Wruhecism. For women or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[325]`
Mówca: **Narrator**
> "The door swung open again and Laurento came back into the hall. He wiped his brow with a silk pocket square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Elena Werner**
> ""Well, Mr. Esquibel? I hope you've brought us good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Laurento Esquibel**
> ""It's too early to tell if it's good or bad. But it's definitely impactful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent suggestion, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Preferably as soon as possible. We must decide on our official stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see the urgency. We won't be expected to respond immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Laurento Esquibel**
> ""No, but it's good that we all get on the same page as a council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[332]`
Mówca: **Laurento Esquibel**
> ""We are not expected to come out against or in favor of Lespia's alignment. But we should get on the same page as a council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[333]`
Mówca: **Laurento Esquibel**
> ""I'll start preparing a briefing once we're back in the capital. We should all be on the same page regarding this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Religious > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[337]`
Mówca: **Narrator**
> "Lucita gave him a look of defiance as she readjusted her gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
Mówca: **Lucita Azaro**
> ""Pardon me, Grand Wiseman. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[339]`
Mówca: **Narrator**
> "Lucita readjusted her gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Hugo Toras**
> ""An early return to the capital would be my preference as well. But where is Mr. Esquibel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[341]`
Mówca: **Lucita Azaro**
> ""I'll inform our hosts that we'll be departing shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Narrator**
> "She pushed back her chair and briskly left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Narrator**
> "I looked over at my daughter. Her brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Narrator**
> "I looked over at Hugo. His brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[348]`
Mówca: **Vina Toras**
> ""The Arcasian Treaty Organization? What will that mean for us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`
  - -> `[351]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing good, that's for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing for you to worry about, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. I suppose we'll find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[352]`
Mówca: **Hugo Toras**
> ""What do you make of the ATO development, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not good. I can tell you that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems like a lot of fuss over nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_LespiaATO = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_LespiaATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_HegelSaltanaMeet"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was fine. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn01_RoyaltyConcertOrganized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[365]`
Mówca: **Laurento Esquibel**
> ""That is, after the lovely evening of musical entertainment that the King has so generously organized for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Hugo Toras**
> ""Ah, yes. Albeni was an excellent choice, Your Majesty. Although I do hope the performance showcases his earlier work, not his more... chaotic contemporary offerings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`
  - -> `[369]`
  - -> `[370]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those works are only chaotic to the untrained ear, Hugo. Listen to them for long enough, and a structure appears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same here. If I wanted to hear two hours of ear-splitting screeching, I'd pay a visit to my sister-in-law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's precisely that chaos that makes them so compelling. He's pushing the boundaries of music itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Music is a reflection of the times. Our era is far from neat and orderly; why should Albeni's compositions be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[371]`
Mówca: **Narrator**
> "Laurento reeled in shock. Lucita stifled a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[373]`
Mówca: **Lucita Azaro**
> ""I confess it all sounds old-fashioned to me. Have you heard the jazz that's coming out of Qinal these days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""I beg your pardon, Your Majesty. I'll be sure to listen more attentively during the concert.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
Mówca: **Hugo Toras**
> ""Boundaries exist for a reason, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Hugo Toras**
> ""But if you see the merit in his newer works, I will give them a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[377]`
Mówca: **Narrator**
> "Lucita gave an impatient shrug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[378]`
Mówca: **Laurento Esquibel**
> ""That's up for debate, Your Majesty. Should art portray the world as it is, or the world we want to see?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Narrator**
> "Lucita gave an impatient shrug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[380]`
Mówca: **Lucita Azaro**
> ""But you have my house's gratitude for the gesture, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[381]`
Mówca: **Lucita Azaro**
> ""I would also suggest extending the length of our conscription period, and lowering the conscription age from 24 back to 18.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[384]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, why did my father even raise the age to 24, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't send kids to war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hell, I joined the military at 18. It did me a world of good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""18 is too young. I myself wish I'd joined the military later in life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[392]`
Mówca: **Vina Toras**
> ""18-year-olds are hardly 'kids', Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[393]`
Mówca: **Hugo Toras**
> ""24 is the age by which a person's brain is fully formed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[397]`
Mówca: **Vina Toras**
> ""I do beg your pardon, Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Hugo Toras**
> ""I mean no offense, Your Highness. But young people, especially young men, tend to make irrational decisions before that age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[409]`
  - -> `[410]`

### Węzeł `[399]`
Mówca: **Hugo Toras**
> ""Young people, especially young men, tend to make irrational decisions before then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[409]`
  - -> `[410]`
  - -> `[411]`

### Węzeł `[400]`
Mówca: **Hugo Toras**
> ""Indeed not, Your Highness. But young people, especially young men, tend to make irrational decisions around that age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[409]`
  - -> `[410]`
  - -> `[411]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such as rebelling against their general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""I agree that young people, especially young men, tend to make irrational decisions before they reach their mid-twenties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[410]`
  - -> `[411]`

### Węzeł `[403]`
Mówca: **Hugo Toras**
> ""You were unusually mature for your age, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Hugo Toras**
> ""But many young people, especially young men, tend to make irrational decisions before they reach their mid-twenties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[409]`
  - -> `[410]`
  - -> `[411]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[408]`
Mówca: **Vina Toras**
> ""18 isn't that young, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They get a little too trigger-happy, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I disagree. If you're old enough to vote, you're old enough to fight for your country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's simply not true. I feel my mind was at its sharpest as a young man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[413]`
Mówca: **Lucita Azaro**
> ""Not with proper training, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[414]`
Mówca: **Lucita Azaro**
> ""As I've said, the 1920s were extraordinary circumstances. There will be no second mutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[415]`
Mówca: **Lucita Azaro**
> ""You're sharp now, Your Majesty. But I will say that in war, the best decisions are not always the most rational ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");
AddConversant("Hugo Toras");
AddConversant("Elena Werner");
AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
AddConversant("Hugo Toras");
AddConversant("Elena Werner");
AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");
RemoveConversant("Elena Werner");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");
RemoveConversant("Elena Werner");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Order_IncreaseConscriptionDuration = true;
RiziaDLC.Enable_Policy_RD_Order_AntiDrugOperations = true;
RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies = true;
RiziaDLC.Enable_Policy_RD_Order_IncreaseProvincialLevies = true;
RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialPolice = true;
RiziaDLC.Enable_Policy_RD_Order_TankFactory = true;
RiziaDLC.Enable_Policy_RD_Order_SupportVehicleFactory = true;
RiziaDLC.Enable_Policy_RD_Order_MilitaryEquipmentFactory = true;
RiziaDLC.Enable_Policy_RD_Order_LowerConscriptionAge = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_IncreaseConscriptionDuration"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_AntiDrugOperations"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_IncreaseProvincialLevies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialPolice"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_TankFactory"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_SupportVehicleFactory"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_MilitaryEquipmentFactory"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_LowerConscriptionAge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Iza_LaborHandsProtest = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Iza_LaborHandsProtest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_WarProduction = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_WarProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Lucita Azaro**
> ""We can achieve this thanks to my house. Camp Domus still runs the most rigorous, high-quality training program on the continent. Right, Captain Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[427]`
Mówca: **Lucita Azaro**
> ""Ultimately, it's the readiness of our forces that will determine how well we can uphold our sovereignty and carry out our military strategies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""If our kingdom took anything away from Pales and the rebellion, it's that we learned the deadly cost of unpreparedness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Airforce == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Army == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Army == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Army == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Navy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[438]`
Mówca: **Lucita Azaro**
> ""Focusing on the air force offers us a chance to establish aerial superiority, but it requires precise investments in procurement and fleet expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[439]`
Mówca: **Lucita Azaro**
> ""Prioritizing the army means enhancing our ground capabilities with modern equipment and tactics. In my view, this will be worth every cent of the budget allocated for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[440]`
Mówca: **Lucita Azaro**
> ""Shifting our focus to the navy could significantly boost our maritime strength, but we must consider the costs of producing and integrating vessels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""Opting not to focus on any particular branch will allow us to allocate resources flexibly across various national priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is alarming. We need immediate measures to rectify this situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While modernizing the military is a significant challenge, we can't simply throw money at it. We need to be efficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[444]`
Mówca: **Lucita Azaro**
> ""But training is key. Each unit, from infantry to naval, requires preparation. We can't expect our men and women in uniform to go into battle with no experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Understanding the details will help us plan more effectively. Tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[446]`
Mówca: **Lucita Azaro**
> ""If you ask me, an immediate audit of our military assets is necessary. From there, we can fast-track procurement and training to address the most pressing deficiencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[447]`
Mówca: **Lucita Azaro**
> ""Efficiency is key. We must strategically allocate resources, perhaps starting with the most outdated sectors and gradually expanding our focus as funds allow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[448]`
Mówca: **Lucita Azaro**
> ""We're facing shortages in critical areas like armored vehicles, advanced communication technology, and even basic infantry gear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Lucita Azaro**
> ""The strength of our Rizian Armed Forces lies in the diversity of our resources and units. We have manpower ready for duty,  as long as they're equipped with the necessary gear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[450]`
Mówca: **Lucita Azaro**
> ""Now. A word about our military priorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""Our troops must reflect Rizia's resilience, ensuring such blows never weaken us again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[452]`
Mówca: **Lucita Azaro**
> ""We will also be training a paratrooper division under this initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[453]`
Mówca: **Lucita Azaro**
> ""We will also be training an additional mountaineer division under this initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[454]`
Mówca: **Lucita Azaro**
> ""We will also be training a marine division under this initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO = false;
RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO1950 = true;
RiziaDLCSupport.Codex_Locations_Countries_Lespia = false;
RiziaDLCSupport.Codex_Locations_Countries_Lespia_1950 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO"] = false;
Variable["RiziaDLCSupport.Codex_Organizations_InterGovernmental_ATO1950"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Lespia"] = false;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Lespia_1950"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_KnifeThrow = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_KnifeThrow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_SnO_LaurentoLeft = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_SnO_LaurentoLeft"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Time to move on to other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatus("Rizia_Country_Lespia", "Country_ATO");)*
- **Efekt (`userScript`):** `AddTokenStatus("Rizia_Country_Lespia","Country_ATO");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[460]`
Mówca: **Lucita Azaro**
> ""I myself joined the military while I was still in my teens. And I'm eternally thankful I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Focus_ArmedForces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Which is why, Your Majesty, I'm very grateful to you for taking steps to address these inadequacies before the crown was even on your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Lucita Azaro**
> ""But the way I see it, this is only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[466]`
  - -> `[443]`
  - -> `[445]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like what you're implying about King Valero the First. Attempts to slander my father's name will not be tolerated in this court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1; RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[468]`
Mówca: **Lucita Azaro**
> ""I-- I beg your pardon. I only meant to say that I am looking forward to working with you on making improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[469]`
Mówca: **Narrator**
> "She straightened her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Military_Stockpile_Full == true || RiziaDLC.Situation_Military_Stockpile_Overflowing == true) && (RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Military_Stockpile_Full == true || RiziaDLC.Situation_Military_Stockpile_Overflowing == true) && (RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Stockpile_Full"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_Overflowing"] == true)  and  (Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Military_Stockpile_Full == true || RiziaDLC.Situation_Military_Stockpile_Overflowing == true) && (RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true) ))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Military_Stockpile_Full"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_Overflowing"] == true)  and  (Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Stockpile_Low == true || RiziaDLC.Situation_Military_Stockpile_HalfFull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Stockpile_Low == true || RiziaDLC.Situation_Military_Stockpile_HalfFull == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Stockpile_Low"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_HalfFull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Stockpile_Low == true || RiziaDLC.Situation_Military_Stockpile_HalfFull == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Stockpile_Low"] == true  or  Variable["RiziaDLC.Situation_Military_Stockpile_HalfFull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Lucita Azaro**
> ""While our equipment stockpile has grown considerably, we're still facing a shortage of manpower. All the weapons in the world won't help us if there's nobody to wield them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_High == false && RiziaDLC.Situation_Military_Manpower_Massive == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_High == false && RiziaDLC.Situation_Military_Manpower_Massive == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_High"] == false  and  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Manpower_High == false && RiziaDLC.Situation_Military_Manpower_Massive == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_High"] == false  and  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Lucita Azaro**
> ""While you've managed to rectify our equipment and manpower shortages in a surprisingly short amount of time, our troops still need training. A horde of well-equipped soldiers won't do us any good if they lack experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_CombatExperience_Waning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_CombatExperience_Waning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_CombatExperience_Waning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_CombatExperience_Waning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_CombatExperience_Waning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[484]`
Mówca: **Lucita Azaro**
> ""You've managed to rectify our equipment and manpower shortages in a surprisingly short amount of time. From here, we can focus on specialization and new technologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Manpower_High == true || RiziaDLC.Situation_Military_Manpower_Massive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_High"] == true  or  Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[488]`
Mówca: **Lucita Azaro**
> ""I'm glad you asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Army Panel Questions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[494]`
  - -> `[497]`
  - -> `[512]`
  - -> `[524]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
  - -> `[499]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do the costs of training and equipping our units compare?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[501]`
Mówca: **Lucita Azaro**
> ""The costs vary by unit. Obviously, the more complex the training and equipment, the more expensive it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long does it take to prepare a unit from basic training to full combat readiness?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[503]`
Mówca: **Lucita Azaro**
> ""The majority of our units reach full readiness within a year, with specialized units requiring additional time for their rigorous preparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the point of keeping our troops in a constant state of readiness? It's not like war is on the horizon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[505]`
Mówca: **Lucita Azaro**
> ""Not yet. But given the shifting allegiances all around us, we should be prepared for anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""Besides which, the benefits of a strong, capable military go beyond the battlefield. The more power we project internationally, the more respect our neighbors and trading partners will have for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Laurento Esquibel**
> ""Only up to a point, Duchess. We want our potential allies to see us as a friendly, open negotiator, not a bully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Army Panel Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Prologue_Focus_ArmedForces == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Prologue_Focus_ArmedForces == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == false && RiziaDLC.Prologue_Focus_ArmedForces == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == false  and  Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm no master strategist. Are you expecting me to draw up plans for our troops?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The entire armed forces of Rizia, under my sole command... I've been waiting my whole life for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Narrator**
> "I saw a gleam in her eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Narrator**
> "She laughed lightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[522]`
Mówca: **Lucita Azaro**
> ""You won't be alone. Together, we'll build a force as formidable as your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_Strategies = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == true || RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == true || RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_MilitaryQs_Strategies == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime == true || RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts == true || RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_MilitaryQs_Strategies"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingTime"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_TrainingCosts"] == true  or  Variable["RiziaDLCIsolated.Turn01_MilitaryQs_WhyTrain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate all this information. I'll relay my instructions to you after this meeting ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[528]`
Mówca: **Narrator**
> "Lucita nodded with satisfaction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[529]`
Mówca: **Lucita Azaro**
> ""That's what I and our generals are here for. Leave the strategizing to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[530]`
Mówca: **Lucita Azaro**
> ""But don't hesitate to take the reins if need be. Sometimes, the intuition of a wise king can be more valuable than the by-the-book maneuvers of a seasoned veteran.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to say any more. If you all will excuse me, I'm going to get started at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[534]`
Mówca: **Narrator**
> "Lucita raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Lucita Azaro**
> ""You don't want to hear any more?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[536]`
  - -> `[545]`
  - -> `[550]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not right now. But I'm looking forward to many more private discussions with you in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I do have a few questions related to military and security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_WarProduction = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_WarProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Lucita Azaro**
> ""By all means, go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Security/Military Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_WarProduction = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_WarProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[543]`
Mówca: **Lucita Azaro**
> ""As am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[544]`
Mówca: **Narrator**
> "She smiled coyly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, thanks. I have plenty of my own ideas for the military without House Azaro's input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 1;
RiziaDLC.Country_HouseAzaro -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;
Variable["RiziaDLC.Country_HouseAzaro"] = Variable["RiziaDLC.Country_HouseAzaro"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Narrator**
> "Her expression soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Lucita Azaro**
> ""Very well. I won't keep you any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had a vision, Duchess. The Lord has shown me the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[553]`
Mówca: **Narrator**
> "Sal grinned triumphantly. A troubled frown crossed Lucita's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Military Briefing Skipped)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Military Briefing Skipped])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_KnifeThrow == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_KnifeThrow == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_KnifeThrow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_KnifeThrow == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_KnifeThrow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Facing a blunt report on the state of the military", "Folce Dator", "Cardesse-Montaklar");)*
- **Efekt (`userScript`):** `SetRichPresence("Facing a blunt report on the state of the military","Folce Dator","Cardesse-Montaklar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Dodging throwning knives at a security meeting", "Folce Dator", "Cardesse-Montaklar");)*
- **Efekt (`userScript`):** `SetRichPresence("Dodging throwning knives at a security meeting","Folce Dator","Cardesse-Montaklar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
